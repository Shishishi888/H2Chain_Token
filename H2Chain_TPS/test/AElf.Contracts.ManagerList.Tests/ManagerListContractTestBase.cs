using AElf.Cryptography.ECDSA;
using AElf.Types;
using AElf.ContractTestBase.ContractTestKit;
using AElf.Contracts.TestBase;
using AElf.Kernel.Proposal;
using AElf.Kernel.Token;
using Volo.Abp.Threading;

namespace AElf.Contracts.ManagerList
{
    public class ManagerListContractTestBase : TestBase.ContractTestBase<ManagerListContractTestAElfModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);
        protected Address ManagerListContractAddress;
        protected new ContractTester<ManagerListContractTestAElfModule> Tester;

        public ManagerListContractTestBase()
        {
            var mainChainId = ChainHelper.ConvertBase58ToChainId("AELF");
            var chainId = ChainHelper.GetChainId(1);
            Tester = new ContractTester<ManagerListContractTestAElfModule>(chainId,SampleECKeyPairs.KeyPairs[1]);
            AsyncHelper.RunSync(() =>
                Tester.InitialChainAsyncWithAuthAsync(Tester.GetSideChainSystemContract(
                    Tester.GetCallOwnerAddress(),
                    mainChainId,"STA",out TotalSupply,Tester.GetCallOwnerAddress())));
            ManagerListContractAddress = Tester.GetContractAddress(ManagerListSmartContractAddressNameProvider.Name);
        }
    }
}