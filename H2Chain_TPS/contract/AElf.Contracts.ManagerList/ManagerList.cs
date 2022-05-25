using AElf.Types;
using Google.Protobuf.WellKnownTypes;
// using Microsoft.Extensions.Logging;

/*
 * ManagerListContract
 * Author: ShiYang WeiHanWang
 * Date: 2022.05.17
 */
namespace AElf.Contracts.ManagerList
{
    public  class ManagerListContract : ManagerListContractImplContainer.ManagerListContractImplBase
    {
        // private ILogger<ManagerListContract> Logger { get; set; }
        
        private Address _superAdminAddress;
        
        #region Action

        public override Empty Initialize(Empty input)
        {
            _superAdminAddress = Address.FromBase58("y35saYSrfXtQXKWodZ2XEBA2wCdbC21YKzFHxwLhZovgsX4xn");
            State.Manager_Base[_superAdminAddress] = new BoolValue { Value = true };
            return new Empty();
        }
        
        /**
         * Add a manager to manager list.
         */
        public override  Empty AddManager(StringValue walletAddress)
        {
            Address address = Address.FromBase58(walletAddress.Value);

            // Logger.LogDebug("###" + Context.Sender.Value);
            // Logger.LogDebug("###" + _superAdminAddress.Value);
            
            // 1. validate sender
            bool isSuperAdmin = Context.Sender.Value == _superAdminAddress.Value;
            Assert(!isSuperAdmin, "Invalid sender.");

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
            Assert(!isSuperAdmin, "Invalid sender.");
            
            // 2. remove mananger from manager list
            if (State.Manager_Base[address]== null)
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
            
            if (State.Manager_Base[address] != null && State.Manager_Base[address].Value)
            {
                return  new BoolValue { Value = true };
            }
            // else if (State.Manager_Base[address] == null || State.Manager_Base[address].Value == false)
            else
            {
               return  new BoolValue { Value = false };
            }
        }
        
        #endregion
        
        /**
         * 三个问题：
         * 1. 如何打log
         * 2. python脚本如何打印合约函数返回的true/false值
         * 3. 合约调用者身份验证问题
         */
        
        #region Action
        /**
         *  Set if allow free transfer.
         */
        
        /**
         *  Get if allow free transfer
         */
        
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