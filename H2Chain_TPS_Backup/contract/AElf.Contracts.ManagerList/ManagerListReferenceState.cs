using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.CrossChain;
using AElf.Contracts.Election;
using AElf.Contracts.MultiToken;
using AElf.Contracts.Profit;
using AElf.Contracts.Referendum;
using AElf.Contracts.TokenConverter;
using AElf.Contracts.TokenHolder;
using AElf.Contracts.Treasury;

namespace AElf.Contracts.ManagerList
{
    public partial class ManagerListState
    {
        internal AEDPoSContractContainer.AEDPoSContractReferenceState AEDPoSContract { get; set; }
        
        internal CrossChainContractContainer.CrossChainContractReferenceState CrossChainContract { get; set; }
        
        internal ElectionContractContainer.ElectionContractReferenceState ElectionContract { get; set; }
        internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }
        internal ProfitContractContainer.ProfitContractReferenceState ProfitContract { get; set; }
        internal ReferendumContractContainer.ReferendumContractReferenceState ReferendumContract { get; set; }
        internal TokenConverterContractContainer.TokenConverterContractReferenceState TokenConverterContract { get; set; }
        internal TokenHolderContractContainer.TokenHolderContractReferenceState TokenHolderContract { get; set; }
        internal TreasuryContractContainer.TreasuryContractReferenceState TreasuryContract { get; set; }
    }
}