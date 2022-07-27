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
            
            State.ManagerList[State.AEDPoSContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.CrossChainContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.ElectionContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.TokenContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.ProfitContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.ReferendumContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.TokenConverterContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.TokenHolderContract.Value] = new BoolValue { Value = true };
            State.ManagerList[State.TreasuryContract.Value] = new BoolValue { Value = true };
            
            State.SuperAdminAddressLock.Value = false; 
            State.AllowFreeTransfer.Value = true;  // allow free transfer 
            
            return new Empty();
        }
        
        /**
         * Set super admin address.
         * Only can be called once.
         */
        public override Empty SetSuperAdminAddress(Address superAdminAddress)
        {
            Assert(!State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has been called.");  // Initialize method has been called.
            
            // 1. Write the super admin address into state.
            State.SuperAdminAddress.Value = superAdminAddress;
            
            // 2. Add the super admin address to manager list.
            State.ManagerList[superAdminAddress] = new BoolValue { Value = true };

            // 3. Lock the SetSuperAdminAddress method.
            State.SuperAdminAddressLock.Value = true;  
            
            return new Empty();
        }

        #endregion

        /**
         * Check if the SetSuperAdminAddress method has been called.
         */
        public override BoolValue HasSetSuperAdminAddress(Empty empty)
        {
            return new BoolValue { Value = State.SuperAdminAddressLock.Value };
        }

        /**
         * Add the address to manager list.
         */
        public override  Empty AddManager(Address address)
        {
            // Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add the address to manager list
            State.ManagerList[address] = new BoolValue
            {
                Value = true
            };

              return new Empty();
        }

        /**
         * Remove the address from manager list.
         */
        public override Empty RemoveManager(Address address)
        {   
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");
            
            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. remove the address from manager list
            if (State.ManagerList[address] == null)
            {
                // do nothing
            }
            else
            {
                State.ManagerList[address] = new BoolValue
                {
                    Value = false
                };
            }
            return new Empty();
        }

        /**
         * Check if the address is in ManagerList
         */
        public override BoolValue CheckManager(Address address)
        {            
            if (State.ManagerList[address] != null && State.ManagerList[address].Value == true)
            {
                return  new BoolValue { Value = true };
            }
            // if (State.Manager_Base[address] == null || State.Manager_Base[address].Value == false)
            else
            {
               return  new BoolValue { Value = false };
            }
        }
        
        // #endregion

        
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
            
            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
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

        #region ContractBlackList

        /**
         * Add the contract address to the black list.
         */ 
        public override Empty AddToContractBlackList(Address address)
        {    
            // 1. validate the initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add the contract address to the black list
            State.ContractBlackList[address] = new BoolValue
            {
                Value = true
            };

            return new Empty();
        }

        /**
         * Remove the contract address from the black list.
         */
        public override Empty RemoveFromContractBlackList(Address address)
        {   
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");
            
            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. remove the contract address from black list
            if (State.ContractBlackList[address] == null)
            {
                // do nothing
            }
            else
            {
                State.ContractBlackList[address] = new BoolValue
                {
                    Value = false
                };
            }
            return new Empty();
        }

        /**
         * Check if the contract address is in the black list.
         */
        public override BoolValue CheckInContractBlackList(Address address)
        {
            if (State.ContractBlackList[address] != null && State.ContractBlackList[address].Value == true)
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

        #region AccountBlackList

        /**
         * Add the user to the Account BlackList.
         */ 
        public override Empty AddToAccountBlackList(Address address)
        {    
            // 1. validate the initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add the user address to the black list
            State.AccountBlackList[address] = new BoolValue
            {
                Value = true
            };

            return new Empty();
        }

        /**
         * Remove the user from the  Account BlackList.
         */
        public override Empty RemoveFromAccountBlackList(Address address)
        {   
            // 1. validate initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");
            
            // 2. validate sender' identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 3. remove the user address from black list
            if (State.AccountBlackList[address] == null)
            {
                // do nothing
            }
            else
            {
                State.AccountBlackList[address] = new BoolValue
                {
                    Value = false
                };
            }
            return new Empty();
        }

        /**
         * Check if the user is in the  Account BlackList.
         */
        public override BoolValue CheckInAccountBlackList(Address address)
        {
            if (State.AccountBlackList[address] != null && State.AccountBlackList[address].Value == true)
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

        #region DestroyedContractList

        /**
         * Add the user to the Destroyed ContractList.
         */ 
        public override Empty AddToDestroyedContractList(Address address)
        {    
            // 1. validate the initialize method
            Assert(State.SuperAdminAddressLock.Value, "SetSuperAdminAddress method has not been called yet.");

            // 2. validate the sender's identity
            bool isSuperAdmin = Context.Sender == State.SuperAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");

            // 3. add the user address to the Destroyed ContractList
            State.DestroyedContractList[address] = new BoolValue
            {
                Value = true
            };

            return new Empty();
        }

        /**
         * Check if the user is in the Destroyed ContractList.
         */
        public override BoolValue CheckInDestroyedContractList(Address address)
        {
            if (State.DestroyedContractList[address] != null && State.DestroyedContractList[address].Value == true)
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


        public override StringValue TestMySystemContract(Empty empty)
        {

            return new StringValue
            {
                Value = "success"
            };
        }
    }
}

