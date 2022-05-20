using Google.Protobuf.WellKnownTypes;
using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.ManagerList
{
    public class ManagerListState : ContractState
    {
        public MappedState<Address, BoolValue> ManagerList { get; set; }
    }
}