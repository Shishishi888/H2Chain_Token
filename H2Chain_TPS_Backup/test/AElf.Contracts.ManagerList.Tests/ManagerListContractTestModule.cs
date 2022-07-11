using Volo.Abp.Modularity;
using AElf.Contracts.TestBase;
namespace AElf.Contracts.ManagerList
{
    [DependsOn(
        typeof(ContractTestAElfModule)
    )]
    public class ManagerListContractTestAElfModule : ContractTestAElfModule
    {
        
    }
}