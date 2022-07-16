using Google.Protobuf.WellKnownTypes;
using AElf.Sdk.CSharp.State;
using AElf.Types;


namespace AElf.Contracts.ManagerList
{
    public partial class ManagerListState : ContractState
    {
        public SingletonState<Address> SuperAdminAddress { get; set; }
        public BoolState SuperAdminAddressLock { get; set; }
        public MappedState<Address, BoolValue> ManagerList { get; set; }
        public BoolState AllowFreeTransfer { get; set; }
        public MappedState<Address, BoolValue> ContractAddressBlackList { get; set; }
        public MappedState<Address, BoolValue> UserBlackList { get; set; }
    }
}