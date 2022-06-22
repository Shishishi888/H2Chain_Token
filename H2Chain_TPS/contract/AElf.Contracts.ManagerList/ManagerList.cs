using AElf.Types;
using Google.Protobuf.WellKnownTypes;
using AElf.Kernel;

/*
 * ManagerListContract
 * Author: ShiYang
 * Date: 2022.05.17
 */
namespace AElf.Contracts.ManagerList
{
    public  class ManagerListContract : ManagerListContractImplContainer.ManagerListContractImplBase
    {
        private Address _superAdminAddress;
        
        private Address _aedposContractAddress;
        private Address _crossChainContractAddress;
        private Address _electionContractAddress;
        private Address _tokenContractAddress;
        private Address _profitContractAddress;
        private Address _referendumContractAddress;
        private Address _tokenConverterContractAddress;
        private Address _tokenHolderContractAddress;
        private Address _treasuryContractAddress;
        
        #region Action

        /**
         * Initialize function.
         * Only can be called once.
         */
        public override Empty Initialize(StringValue superAdminAddress)
        {
            Assert(!State.InitializeMethodLock.Value, "Initialize method has been called.");  // Initialize method has been called.
            
            // 1. Add super admin address to manager list.
            _superAdminAddress = Address.FromBase58(superAdminAddress.Value);
            State.ManagerBase[_superAdminAddress] = new BoolValue { Value = true };
            
            // 2. Add system contract addresses to manager list.
            _aedposContractAddress = State.AEDPoSContract.Value;
            _crossChainContractAddress = State.CrossChainContract.Value;
            _electionContractAddress = State.ElectionContract.Value;
            _tokenContractAddress = State.TokenContract.Value;
            _profitContractAddress = State.ProfitContract.Value;
            _referendumContractAddress = State.ReferendumContract.Value;
            _tokenConverterContractAddress = State.TokenConverterContract.Value;
            _tokenHolderContractAddress = State.TokenHolderContract.Value;
            _treasuryContractAddress = State.TreasuryContract.Value;
            
            State.ManagerBase[_aedposContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_crossChainContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_electionContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_tokenContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_profitContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_referendumContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_tokenConverterContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_tokenHolderContractAddress] = new BoolValue { Value = true };
            State.ManagerBase[_treasuryContractAddress] = new BoolValue { Value = true };
            
            // 3. Write the super admin address into state.
            State.SuperAdminAddress.Value = superAdminAddress.Value;
            
            // 4. Allow free transfer.
            State.AllowFreeTransfer.Value = true; 
            
            // 5. Lock the initialize method.
            State.InitializeMethodLock.Value = true;   
            
            return new Empty();
        }

        /**
         * Check initialize method if has been called.
         */
        public override BoolValue HasInitialized(Empty empty)
        {
            return new BoolValue { Value = State.InitializeMethodLock.Value };
        }

        /**
         * Add a manager to manager list.
         */
        public override  Empty AddManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.InitializeMethodLock.Value, "Initialize method has not been called yet.");

            // 2. validate sender
            Address superAdminAddress = Address.FromBase58(State.SuperAdminAddress.Value);
            bool isSuperAdmin = Context.Sender == superAdminAddress;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add a mananger to manager list
            State.ManagerBase[address] = new BoolValue
            {
                Value = true
            };

              return new Empty();
        }

        /**
         * Remove a manager from manager list.
         */
        public override Empty RemoveManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.InitializeMethodLock.Value, "Initialize method has not been called yet.");
            
            // 2. validate sender
            Address superAdminAddress = Address.FromBase58(State.SuperAdminAddress.Value);
            bool isSuperAdmin = Context.Sender == superAdminAddress;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. remove mananger from manager list
            if (State.ManagerBase[address] == null)
            {
                // do nothing
            }
            else
            {
                State.ManagerBase[address] = new BoolValue
                {
                    Value = false
                };
            }
            return new Empty();
        }

        /**
         * Check if a address is in ManagerList
         */
        public override BoolValue CheckManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            if (State.ManagerBase[address] != null && State.ManagerBase[address].Value == true)
            {
                return  new BoolValue { Value = true };
            }
            // if (State.Manager_Base[address] == null || State.Manager_Base[address].Value == false)
            else
            {
               return  new BoolValue { Value = false };
            }
        }
        
        #endregion

        
        #region Action
        
        /**
         * Set transfer mode
         * param:
         *  true:   allow free transfer
         *  false:  not allow free transfer
         */
        public override Empty SetTransferMode(BoolValue allow)
        {
            // 1. validate initialize method
            Assert(State.InitializeMethodLock.Value, "Initialize method has not been called yet.");
            
            // 2. validate sender
            Address superAdminAddress = Address.FromBase58(State.SuperAdminAddress.Value);
            bool isSuperAdmin = Context.Sender == superAdminAddress;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. set if allow free transfer
            if (allow.Value)
            {
                State.AllowFreeTransfer.Value = true;
            }
            else
            {
                State.AllowFreeTransfer.Value = false;
            }

            return new Empty();
        }
        
        /**
         * Get transfer mode.
         * return:
         *  true:  allow free transfer.
         *  false: not allow free transfer.
         */
        public override BoolValue GetTransferMode(Empty empty)
        {
            if (State.AllowFreeTransfer.Value == true)
            {
                return new BoolValue { Value = true };
            }
            else
            {
                return new BoolValue { Value = false };
            }
        }
        
        #endregion
    }
}
