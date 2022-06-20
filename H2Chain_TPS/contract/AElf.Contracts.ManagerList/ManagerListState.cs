using Google.Protobuf.WellKnownTypes;
using AElf.Sdk.CSharp.State;
using AElf.Types;
using AElf.Contracts.MultiToken;

namespace AElf.Contracts.ManagerList
{
    public class ManagerListState : ContractState
    {
        public StringState SuperAdminAddress { get; set; }
        public MappedState<Address, BoolValue> ManagerBase { get; set; }
        
        public BoolState AllowFreeTransfer { get; set; }
        
        public BoolState InitializeMethodLock { get; set; }
        
        internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }
    }
}