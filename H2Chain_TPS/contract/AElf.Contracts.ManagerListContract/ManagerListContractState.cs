using Google.Protobuf.WellKnownTypes;
using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.Contracts.ManagerListContract
{
    public class ManagerListContractState : ContractState
    {
        public MappedState<Address, BoolValue> ManagerList { get; set; }
    }
}