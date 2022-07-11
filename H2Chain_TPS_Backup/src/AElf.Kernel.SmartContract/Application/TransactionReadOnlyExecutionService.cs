using System.Collections.Generic;
using System.Threading.Tasks;
using AElf.Kernel.SmartContract.Infrastructure;
using AElf.Kernel.SmartContract;
using AElf.Types;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace AElf.Kernel.SmartContract.Application
{
    public class TransactionReadOnlyExecutionService : ITransactionReadOnlyExecutionService
    {
        private readonly ISmartContractExecutiveService _smartContractExecutiveService;
        private readonly ITransactionContextFactory _transactionContextFactory;

        public TransactionReadOnlyExecutionService(ISmartContractExecutiveService smartContractExecutiveService, 
            ITransactionContextFactory transactionContextFactory)
        {
            _smartContractExecutiveService = smartContractExecutiveService;
            _transactionContextFactory = transactionContextFactory;
        }

        /**
         * chainContext,chainContext中的BlockHash和BlockHeight确定基于哪个区块执行交易，StateCache是缓存，基于缓存来执行交易
         * transaction，需要执行的交易
         * currentBlockTime，执行交易的区块时间
         */
        public async Task<TransactionTrace> ExecuteAsync(IChainContext chainContext, Transaction transaction,
            Timestamp currentBlockTime)
        {
            var transactionContext = _transactionContextFactory.Create(transaction, chainContext, currentBlockTime);
            var executive = await _smartContractExecutiveService.GetExecutiveAsync( // 根据合约地址生成合约执行器
                chainContext, transaction.To);

            try
            {
                await executive.ApplyAsync(transactionContext); // 用合约执行器执行交易
            }
            finally
            {
                await _smartContractExecutiveService.PutExecutiveAsync(chainContext, transaction.To, executive); // 将合约执行器放入缓存
            }

            return transactionContext.Trace;  // 这是干什么的？？？
        }

        public async Task<byte[]> GetFileDescriptorSetAsync(IChainContext chainContext, Address address)
        {
            IExecutive executive = null;

            byte[] output;
            try
            {
                executive = await _smartContractExecutiveService.GetExecutiveAsync(
                    chainContext, address);
                output = executive.GetFileDescriptorSet();
            }
            finally
            {
                if (executive != null)
                {
                    await _smartContractExecutiveService.PutExecutiveAsync(chainContext, address, executive);
                }
            }

            return output;
        }

        public async Task<IEnumerable<FileDescriptor>> GetFileDescriptorsAsync(IChainContext chainContext, Address address)
        {
            IExecutive executive = null;

            IEnumerable<FileDescriptor> output;
            try
            {
                executive = await _smartContractExecutiveService.GetExecutiveAsync(
                    chainContext, address);
                output = executive.GetFileDescriptors();
            }
            finally
            {
                if (executive != null)
                {
                    await _smartContractExecutiveService.PutExecutiveAsync(chainContext, address, executive);
                }
            }

            return output;
        }

        public async Task<string> GetTransactionParametersAsync(IChainContext chainContext, Transaction transaction)
        {
            var address = transaction.To;
            IExecutive executive = null;
            try
            {
                executive = await _smartContractExecutiveService.GetExecutiveAsync(chainContext, address);
                return executive.GetJsonStringOfParameters(transaction.MethodName, transaction.Params.ToByteArray());
            }
            finally
            {
                if (executive != null)
                {
                    await _smartContractExecutiveService.PutExecutiveAsync(chainContext, address, executive);
                }
            }
        }

        public async Task<bool> IsViewTransactionAsync(IChainContext chainContext, Transaction transaction)
        {
            var address = transaction.To;
            IExecutive executive = null;
            try
            {
                executive = await _smartContractExecutiveService.GetExecutiveAsync(chainContext, address);
                return executive.IsView(transaction.MethodName);
            }
            finally
            {
                if (executive != null)
                {
                    await _smartContractExecutiveService.PutExecutiveAsync(chainContext, address, executive);
                }
            }
        }
    }
}