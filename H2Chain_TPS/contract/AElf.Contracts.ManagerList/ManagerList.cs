using AElf.Types;
using Google.Protobuf.WellKnownTypes;

/*
 * ManagerListContract
 * Author: ShiYang WeiHanWang
 * Date: 2022.05.17
 */
namespace AElf.Contracts.ManagerList
{
    public  class ManagerListContract : ManagerListContractImplContainer.ManagerListContractImplBase
    {

        #region Action

        public override Empty Initialize(Empty input)
        {
            Address superAdmin = Address.FromBase58("2tEkpoyCFAWhTVZGageFpm4LfdFwKQcK2SUaGWrdxM6FGQL836");
            State.Manager_Base[superAdmin] = new BoolValue { Value = true };
            return new Empty();
        }
        /**
         * Add a manager to manager list.
         */
        public override  Empty AddManager(Address address)
        {
        
            // 1. validate address
            var isRegistered = State.Manager_Base[Context.Sender].Value;
              Assert(isRegistered, "invalid sender!");
              
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
        public override Empty RemoveManager(Address address)
        {
            // 1. validate address
            // Assert(ValidateAddress(address), "Invalid address");
            
            // 2. remove mananger from manager list
            if (State.Manager_Base[address]==null)
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
        #endregion

        #region View
        public override StringValue TestMySystemContract(Empty empty)
        {
            
            return new StringValue
            {
                Value = "success"
            };
        }

        #endregion view
        
        /**
         * Validate address 
         */
        // private bool ValidateAddress(Address address)
        // {
        //     return true;
        // }
    }
}