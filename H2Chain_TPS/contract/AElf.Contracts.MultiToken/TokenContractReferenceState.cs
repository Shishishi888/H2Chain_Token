using AElf.Standards.ACS10;
using AElf.Contracts.Association;
using AElf.Contracts.Consensus.AEDPoS;
using AElf.Contracts.Parliament;
using AElf.Contracts.Referendum;
using AElf.Contracts.ManagerList;

namespace AElf.Contracts.MultiToken
{
    public partial class TokenContractState
    {
        internal ManagerListContractContainer.ManagerListContractReferenceState ManagerListContract { get; set; }
        internal ParliamentContractContainer.ParliamentContractReferenceState ParliamentContract { get; set; }
        internal AssociationContractContainer.AssociationContractReferenceState AssociationContract { get; set; }
        internal ReferendumContractContainer.ReferendumContractReferenceState ReferendumContract { get; set; }
        internal AEDPoSContractContainer.AEDPoSContractReferenceState ConsensusContract { get; set; }
        internal DividendPoolContractContainer.DividendPoolContractReferenceState DividendPoolContract{ get; set; }
    }
}