using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AElf.Kernel.Miner.Application;
using AElf.Kernel.SmartContract.Application;
using AElf.Kernel.SmartContract.Domain;
using AElf.Types;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Local;

namespace AElf.Kernel.SmartContract.Parallel.Application
{
    public class LocalParallelTransactionExecutingService : IParallelTransactionExecutingService, ISingletonDependency
    {
        private readonly ITransactionGrouper _grouper;
        private readonly IPlainTransactionExecutingService _planTransactionExecutingService;
        public ILogger<LocalParallelTransactionExecutingService> Logger { get; set; }
        public ILocalEventBus EventBus { get; set; }

        public LocalParallelTransactionExecutingService(ITransactionGrouper grouper,
            IPlainTransactionExecutingService planTransactionExecutingService, 
            ISystemTransactionExtraDataProvider systemTransactionExtraDataProvider)
        {
            _grouper = grouper;
            _planTransactionExecutingService = planTransactionExecutingService;
            EventBus = NullLocalEventBus.Instance;
            Logger = NullLogger<LocalParallelTransactionExecutingService>.Instance;
        }

        /**
         * 并行执行交易
         * TransactionExecutingDto
         * CancellationToken 用于超时后取消交易
         */
        public async Task<List<ExecutionReturnSet>> ExecuteAsync(TransactionExecutingDto transactionExecutingDto,
            CancellationToken cancellationToken)
        {
            Logger.LogTrace("Entered parallel ExecuteAsync.");
            var transactions = transactionExecutingDto.Transactions.ToList();
            var blockHeader = transactionExecutingDto.BlockHeader;

            var chainContext = new ChainContext
            {
                BlockHash = blockHeader.PreviousBlockHash,
                BlockHeight = blockHeader.Height - 1
            };
            var groupedTransactions = await _grouper.GroupAsync(chainContext, transactions);  // 将交易分组

            var returnSets = new List<ExecutionReturnSet>();  // 处理交易的结果

            var mergeResult = await ExecuteParallelizableTransactionsAsync(groupedTransactions.Parallelizables,
                blockHeader, transactionExecutingDto.PartialBlockStateSet, cancellationToken);  // 将可以并行处理的交易并行处理
            returnSets.AddRange(mergeResult.ExecutionReturnSets);  // 将并行交易的处理结果加入returnSets 
            var conflictingSets = mergeResult.ConflictingReturnSets;  // 获取并行交易中的冲突交易
            
            var returnSetCollection = new ExecutionReturnSetCollection(returnSets);
            var updatedPartialBlockStateSet = GetUpdatedBlockStateSet(returnSetCollection, transactionExecutingDto);
            
            var nonParallelizableReturnSets = await ExecuteNonParallelizableTransactionsAsync(groupedTransactions.NonParallelizables, blockHeader,
                updatedPartialBlockStateSet, cancellationToken);  // 将不可以并行处理的交易串行处理
            returnSets.AddRange(nonParallelizableReturnSets);  // 将串行交易的处理结果加入returnSets 
        
            var transactionWithoutContractReturnSets = ProcessTransactionsWithoutContract(
                groupedTransactions.TransactionsWithoutContract);  // 处理无合约交易

            Logger.LogTrace("Merged results from transactions without contract.");
            returnSets.AddRange(transactionWithoutContractReturnSets);  // 将处理无合约交易的结果加入returnSets 

            if (conflictingSets.Count > 0 &&
                returnSets.Count + conflictingSets.Count == transactionExecutingDto.Transactions.Count())
            {
                ProcessConflictingSets(conflictingSets);  // 处理并行交易中的冲突交易
                returnSets.AddRange(conflictingSets);  // 将冲突交易的处理结果加入returnSets
            }

            return returnSets;
        }

        private async Task<ExecutionReturnSetMergeResult> ExecuteParallelizableTransactionsAsync(
            List<List<Transaction>> groupedTransactions, BlockHeader blockHeader, BlockStateSet blockStateSet,
            CancellationToken cancellationToken)
        {
            var tasks = groupedTransactions.Select(
                txns => ExecuteAndPreprocessResult(new TransactionExecutingDto
                {
                    BlockHeader = blockHeader,
                    Transactions = txns,
                    PartialBlockStateSet = blockStateSet
                }, cancellationToken));
            var results = await Task.WhenAll(tasks);
            Logger.LogTrace("Executed parallelizables.");

            var executionReturnSets = MergeResults(results, out var conflictingSets);
            Logger.LogTrace("Merged results from parallelizables.");
            return new ExecutionReturnSetMergeResult
            {
                ExecutionReturnSets = executionReturnSets,
                ConflictingReturnSets = conflictingSets
            };
        }

        private async Task<List<ExecutionReturnSet>> ExecuteNonParallelizableTransactionsAsync(List<Transaction> transactions,
            BlockHeader blockHeader, BlockStateSet blockStateSet, CancellationToken cancellationToken)
        {
            var nonParallelizableReturnSets = await _planTransactionExecutingService.ExecuteAsync(
                new TransactionExecutingDto
                {
                    Transactions = transactions,
                    BlockHeader = blockHeader,
                    PartialBlockStateSet = blockStateSet
                }, 
                cancellationToken);
        
            Logger.LogTrace("Merged results from non-parallelizables.");
            return nonParallelizableReturnSets;
        }

        private List<ExecutionReturnSet> ProcessTransactionsWithoutContract(List<Transaction> transactions)
        {
            var returnSets = new List<ExecutionReturnSet>();
            foreach (var transaction in transactions)
            {
                var result = new TransactionResult
                {
                    TransactionId = transaction.GetHash(),
                    Status = TransactionResultStatus.Failed,
                    Error = "Invalid contract address."
                };
                Logger.LogDebug(result.Error);

                var returnSet = new ExecutionReturnSet
                {
                    TransactionId = result.TransactionId,
                    Status = result.Status,
                    Bloom = result.Bloom,
                    TransactionResult = result
                };
                returnSets.Add(returnSet);
            }
            
            return returnSets;
        }

        private void ProcessConflictingSets(List<ExecutionReturnSet> conflictingSets)
        {
            foreach (var conflictingSet in conflictingSets)
            {
                var result = new TransactionResult
                {
                    TransactionId = conflictingSet.TransactionId,
                    Status = TransactionResultStatus.Conflict,
                    Error = "Parallel conflict",
                };
                conflictingSet.Status = result.Status;
                conflictingSet.TransactionResult = result;
            }

        }

        private async Task<GroupedExecutionReturnSets> ExecuteAndPreprocessResult(
            TransactionExecutingDto transactionExecutingDto, CancellationToken cancellationToken)
        {
            var executionReturnSets =
                await _planTransactionExecutingService.ExecuteAsync(transactionExecutingDto, cancellationToken);
            var changeKeys =
                    executionReturnSets.SelectMany(s => s.StateChanges.Keys.Concat(s.StateDeletes.Keys));
            var allKeys = new HashSet<string>(
                executionReturnSets.SelectMany(s =>s.StateAccesses.Keys));
            var readKeys = allKeys.Where(k => !changeKeys.Contains(k));
            
            return new GroupedExecutionReturnSets
            {
                ReturnSets = executionReturnSets,
                AllKeys = allKeys,
                ChangeKeys = changeKeys,
                ReadKeys = readKeys
            };
        }

        private class GroupedExecutionReturnSets
        {
            public List<ExecutionReturnSet> ReturnSets { get; set; }

            public HashSet<string> AllKeys { get; set; }
            
            public IEnumerable<string> ChangeKeys { get; set; }
            
            public IEnumerable<string> ReadKeys { get; set; }
        }

        private HashSet<string> GetReadOnlyKeys(GroupedExecutionReturnSets[] groupedExecutionReturnSetsArray)
        {
            var readKeys = new HashSet<string>(groupedExecutionReturnSetsArray.SelectMany(s => s.ReadKeys));;
            var changeKeys = new HashSet<string>(groupedExecutionReturnSetsArray.SelectMany(s => s.ChangeKeys));
            readKeys.ExceptWith(changeKeys);
            return readKeys;
        }

        private class ExecutionReturnSetMergeResult
        {
            public List<ExecutionReturnSet> ExecutionReturnSets { get; set; }
            
            public List<ExecutionReturnSet> ConflictingReturnSets { get; set; }
        }

        private List<ExecutionReturnSet> MergeResults(
            GroupedExecutionReturnSets[] groupedExecutionReturnSetsArray,
            out List<ExecutionReturnSet> conflictingSets)
        {
            var returnSets = new List<ExecutionReturnSet>();
            conflictingSets = new List<ExecutionReturnSet>();
            var existingKeys = new HashSet<string>();
            var readOnlyKeys = GetReadOnlyKeys(groupedExecutionReturnSetsArray);
            foreach (var groupedExecutionReturnSets in groupedExecutionReturnSetsArray)
            {
                groupedExecutionReturnSets.AllKeys.ExceptWith(readOnlyKeys);
                if (!existingKeys.Overlaps(groupedExecutionReturnSets.AllKeys))
                {
                    returnSets.AddRange(groupedExecutionReturnSets.ReturnSets);
                    foreach (var key in groupedExecutionReturnSets.AllKeys)
                    {
                        existingKeys.Add(key);
                    }
                }
                else
                {
                    conflictingSets.AddRange(groupedExecutionReturnSets.ReturnSets);
                }
            }

            if (readOnlyKeys.Count == 0) return returnSets;
            
            foreach (var returnSet in returnSets.Concat(conflictingSets))
            {
                returnSet.StateAccesses.RemoveAll(k => readOnlyKeys.Contains(k.Key));
            }

            return returnSets;
        }

        private BlockStateSet GetUpdatedBlockStateSet(ExecutionReturnSetCollection executionReturnSetCollection,
            TransactionExecutingDto transactionExecutingDto)
        {
            var updatedPartialBlockStateSet = executionReturnSetCollection.ToBlockStateSet();
            if (transactionExecutingDto.PartialBlockStateSet != null)
            {
                var partialBlockStateSet = transactionExecutingDto.PartialBlockStateSet.Clone();
                foreach (var change in partialBlockStateSet.Changes)
                {
                    if (updatedPartialBlockStateSet.Changes.TryGetValue(change.Key, out _)) continue;
                    if (updatedPartialBlockStateSet.Deletes.Contains(change.Key)) continue;
                    updatedPartialBlockStateSet.Changes[change.Key] = change.Value;
                }

                foreach (var delete in partialBlockStateSet.Deletes)
                {
                    if (updatedPartialBlockStateSet.Deletes.Contains(delete)) continue;
                    if (updatedPartialBlockStateSet.Changes.TryGetValue(delete, out _)) continue;
                    updatedPartialBlockStateSet.Deletes.Add(delete);
                }
            }

            return updatedPartialBlockStateSet;
        }
    }
}