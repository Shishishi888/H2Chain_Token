using Google.Protobuf.WellKnownTypes;
using AElf.Sdk.CSharp.State;
using AElf.Types;


namespace AElf.Contracts.ManagerList
{
    public partial class ManagerListState : ContractState
    {
        public StringState SuperAdminAddress { get; set; }
        public BoolState SuperAdminAddressLock { get; set; }
        public MappedState<Address, BoolValue> ManagerBase { get; set; }
        public BoolState AllowFreeTransfer { get; set; }
    }
}