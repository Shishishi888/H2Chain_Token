using AElf.Sdk.CSharp.State;
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
        #region Action

        /**
         * Initialize function.
         * Only can be called once.
         */
        public override Empty Initialize(StringValue superAdminAddress)
        {
            Assert(State.InitializeMethodLock.Value, "Initialize method has been called.");  // 已经执行过 Initialize 方法
            
            Address address = Address.FromBase58(superAdminAddress.Value);
            State.ManagerBase[address] = new BoolValue { Value = true };
            
            State.SuperAdminAddress.Value = superAdminAddress.Value;
            
            State.AllowFreeTransfer.Value = true;
            
            State.InitializeMethodLock.Value = false;  // 为 Initialize 方法加锁。

            return new Empty();
        }
        
        /**
         * Add a manager to manager list.
         */
        public override  Empty AddManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);
            
            // 1. validate initialize method
            Assert(!State.InitializeMethodLock.Value, "Initialize method has not been called yet.");

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
            Assert(!State.InitializeMethodLock.Value, "Initialize method has not been called yet.");
            
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
         * Set if allow free transfer.
         */
        public override Empty SetAllowFreeTransfer(BoolValue allow)
        {
            // 1. validate initialize method
            Assert(!State.InitializeMethodLock.Value, "Initialize method has not been called yet.");
            
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
         * Get if allow free transfer.
         */
        public override BoolValue GetAllowFreeTransfer(Empty empty)
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

        #region View
        public override StringValue TestMySystemContract(StringValue stringValue)
        {
            
            return new StringValue
            {
                Value = stringValue.Value
            };
        }
        #endregion view
        
    }
}
