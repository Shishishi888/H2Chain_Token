using System.Collections.Generic;
using AElf.Types;

namespace AElf.Kernel.SmartContract.Application
{
    public class TransactionExecutingDto
    {
        public BlockHeader BlockHeader { get; set; }  // 交易所属区块的区块头
        public IEnumerable<Transaction> Transactions { get; set; }  // 需要执行的交易列表
        public BlockStateSet PartialBlockStateSet { get; set; }  // 同一个块內先执行的交易产生的数据
    }
}