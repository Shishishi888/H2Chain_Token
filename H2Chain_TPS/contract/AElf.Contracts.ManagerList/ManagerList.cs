using AElf.Types;
using Google.Protobuf.WellKnownTypes;
using AElf.Kernel;
using AElf.Sdk.CSharp;

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
        
        #region Action
        
        /**
         * Initialize function.
         * Auto execute.
         */
        public override Empty Initialize(Empty empty)
        {
            State.AEDPoSContract.Value = Context.GetContractAddressByName(SmartContractConstants.ConsensusContractSystemName);
            State.CrossChainContract.Value = Context.GetContractAddressByName(SmartContractConstants.CrossChainContractSystemName);
            State.ElectionContract.Value = Context.GetContractAddressByName(SmartContractConstants.ElectionContractSystemName);
            State.TokenContract.Value = Context.GetContractAddressByName(SmartContractConstants.TokenContractSystemName);
            State.ProfitContract.Value = Context.GetContractAddressByName(SmartContractConstants.ProfitContractSystemName);
            State.ReferendumContract.Value = Context.GetContractAddressByName(SmartContractConstants.ReferendumContractSystemName);
            State.TokenConverterContract.Value = Context.GetContractAddressByName(SmartContractConstants.TokenConverterContractSystemName);
            State.TokenHolderContract.Value = Context.GetContractAddressByName(SmartContractConstants.TokenHolderContractSystemName);
            State.TreasuryContract.Value = Context.GetContractAddressByName(SmartContractConstants.TreasuryContractSystemName);
            
            State.ManagerBase[State.AEDPoSContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.CrossChainContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.ElectionContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.TokenContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.ProfitContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.ReferendumContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.TokenConverterContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.TokenHolderContract.Value] = new BoolValue { Value = true };
            State.ManagerBase[State.TreasuryContract.Value] = new BoolValue { Value = true };
            
            State.SuperAdminAddressLock.Value = false; 
            State.AllowFreeTransfer.Value = true;  // allow free transfer 
            
            return new Empty();
        }
        
        /**
         * Set super admin address.
         * Only can be called once.
         */
        public override Empty SetSuperAdminAddress(StringValue superAdminAddress)
        {
            Assert(!State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has been called.");  // Initialize method has been called.
            
            // 1. Write the super admin address into state.
            State.SuperAdminAddress.Value = superAdminAddress.Value;
            
            // 2. Add super admin address to manager list.
            _superAdminAddress = Address.FromBase58(superAdminAddress.Value);
            State.ManagerBase[_superAdminAddress] = new BoolValue { Value = true };

            // 3. Lock the SetSuperAdminAddress method.
            State.SuperAdminAddressLock.Value = true;  
            
            return new Empty();
        }

        /**
         * Check if the SetSuperAdminAddress method has been called.
         */
        public override BoolValue HasSetSuperAdminAddress(Empty empty)
        {
            return new BoolValue { Value = State.SuperAdminAddressLock.Value };
        }

        /**
         * Add a address to manager list.
         */
        public override  Empty AddManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

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
         * Remove a address from manager list.
         */
        public override Empty RemoveManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");
            
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
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");
            
            // 2. validate sender
            Address superAdminAddress = Address.FromBase58(State.SuperAdminAddress.Value);
            bool isSuperAdmin = Context.Sender == superAdminAddress;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. set if allow free transfer
            State.AllowFreeTransfer.Value = allow.Value;

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
            return new BoolValue
            {
                Value = State.AllowFreeTransfer.Value
            };
        }
        
        #endregion

        #region ContractAdressBlackList

        /**
         * Add an address to the black list.
         */ 
        public override Empty AddContractAddressToBlackList(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

            // 2. validate sender
            Address superAdminAddress = Address.FromBase58(State.SuperAdminAddress.Value);
            bool isSuperAdmin = Context.Sender == superAdminAddress;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add an address to the black list
            State.ContractAddressBlackList[address] = new BoolValue
            {
                Value = true
            };

            return new Empty();
        }

        #endregion
        
        public override StringValue TestMySystemContract(Empty empty)
        {

            return new StringValue
            {
                Value = "success"
            };
        }
    }
}

