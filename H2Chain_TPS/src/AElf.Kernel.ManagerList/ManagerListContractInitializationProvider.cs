using System.Collections.Generic;
using AElf.Contracts.ManagerList;
using AElf.Kernel.SmartContract.Application;
using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Volo.Abp.DependencyInjection;

namespace AElf.Kernel.ManagerList
{
    public class ManagerListContractInitializationProvider : IContractInitializationProvider, ITransientDependency
    {
        public Hash SystemSmartContractName { get; } = ManagerListSmartContractAddressNameProvider.Name;
        public string ContractCodeName { get; } = "AElf.Contracts.ManagerList";

        private readonly IManagerListContractInitializationDataProvider _managerListContractInitializationDataProvider;

        public ManagerListContractInitializationProvider()
        {
           // _managerListContractInitializationDataProvider = managerListContractInitializationDataProvider;
        }

        public virtual List<ContractInitializationMethodCall> GetInitializeMethodList(byte[] contractCode)
        {
            var methodList = new List<ContractInitializationMethodCall>();
            // var initializationData = _managerListContractInitializationDataProvider.GetContractInitializationData();

            // For the main chain, we use the economic contract to initialize the token contract.
            // So no initialization methods are required in here.
            // But for the side chain, which has no economic contract, we need initialize token contract.
            var empty_input = new Empty();
            methodList.Add(new ContractInitializationMethodCall
            {
                MethodName = nameof(ManagerListContractContainer.ManagerListContractStub.Initialize),
                Params = empty_input.ToByteString()
            });
         

            return methodList;
        }

       
    }
}