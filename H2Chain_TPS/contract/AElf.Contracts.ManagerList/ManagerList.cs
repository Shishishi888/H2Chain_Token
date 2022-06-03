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
        private Address _superAdminAddress;

        #region Action

        /**
         * Initialize function.
         * Only can be called once.
         */
        public override Empty Initialize(StringValue superAdminAddress)
        {
            Assert(State.UnLockInitializeMethod.Value, "Have initialized.");  // 已经执行过 Initialize 方法
            
            _superAdminAddress = Address.FromBase58(superAdminAddress.Value);
            State.Manager_Base[_superAdminAddress] = new BoolValue { Value = true };

            State.AllowFreeTransfer.Value = true;
            
            State.UnLockInitializeMethod.Value = false;

            return new Empty();
        }
        
        /**
         * Add a manager to manager list.
         */
        public override  Empty AddManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);

            // 1. validate sender
            bool isSuperAdmin = Context.Sender.Value == _superAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");

            // 2. add a mananger to manager list
            State.Manager_Base[address] = new BoolValue
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
            
            // 1. validate sender
            bool isSuperAdmin = Context.Sender.Value == _superAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 2. remove mananger from manager list
            if (State.Manager_Base[address] == null)
            {
                // do nothing
            }
            else
            {
                State.Manager_Base[address] = new BoolValue
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
            
            if (State.Manager_Base[address] != null && State.Manager_Base[address].Value == true)
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
            // 1. validate sender
            bool isSuperAdmin = Context.Sender.Value == _superAdminAddress.Value;
            Assert(isSuperAdmin, "Invalid sender.");
            
            // 2. set if allow free transfer
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
