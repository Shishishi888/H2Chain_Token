using System.Collections.Generic;
using AElf.Kernel.SmartContract.Application;
using AElf.Types;

namespace AElf.Contracts.ManagerList
{
    public class ManagerListContractInitializationProvider : IContractInitializationProvider
    {
        public List<ContractInitializationMethodCall> GetInitializeMethodList(byte[] contractCode)
        {
            return new List<ContractInitializationMethodCall>();
        }

        public Hash SystemSmartContractName { get; } = DAppSmartContractAddressNameProvider.Name;
        public string ContractCodeName { get; } = "AElf.Contracts.ManagerList";
    }
}