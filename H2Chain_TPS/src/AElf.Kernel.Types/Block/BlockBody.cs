using System;
using AElf.Types;
using Google.Protobuf;

namespace AElf.Kernel
{
    public partial class BlockBody : IBlockBody
    {
        public int TransactionsCount => TransactionIds.Count;
        private Hash _blockBodyHash;

        private Hash CalculateBodyHash()
        {
            if (!VerifyFields())
                throw new InvalidOperationException($"Invalid block body.");

            _blockBodyHash = HashHelper.ComputeFrom(this.ToByteArray());
            return _blockBodyHash;
        }

        public bool VerifyFields()
        {
            
                return false;

            return true;
        }

        public Hash GetHash()
        {
            return _blockBodyHash ?? CalculateBodyHash();
        }
    }
}