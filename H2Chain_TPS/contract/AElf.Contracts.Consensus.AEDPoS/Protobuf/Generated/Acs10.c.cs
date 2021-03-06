// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs10.proto
// </auto-generated>
// Original file comments:
// *
// AElf Standards ACS10(Dividend Pool Standard)
//
// Used to construct a dividend pool in the contract.
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS10 {

  #region Events
  public partial class DonationReceived : aelf::IEvent<DonationReceived>
  {
    public global::System.Collections.Generic.IEnumerable<DonationReceived> GetIndexed()
    {
      return new List<DonationReceived>
      {
      };
    }

    public DonationReceived GetNonIndexed()
    {
      return new DonationReceived
      {
        From = From,
        PoolContract = PoolContract,
        Symbol = Symbol,
        Amount = Amount,
      };
    }
  }

  #endregion
}
#endregion

