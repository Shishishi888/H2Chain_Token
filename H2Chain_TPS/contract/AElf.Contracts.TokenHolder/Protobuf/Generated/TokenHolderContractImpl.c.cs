// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: token_holder_contract_impl.proto
// </auto-generated>
// Original file comments:
// *
// TokenHolder contract.
//
// Used to build a a bonus model for distributing bonus’ to whom hold the token.
// 
// Implement AElf Standards ACS1.
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.TokenHolder {

  #region Events
  #endregion
  public static partial class TokenHolderContractImplContainer
  {
    static readonly string __ServiceName = "TokenHolderImpl.TokenHolderContractImpl";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS1.MethodFees> __Marshaller_acs1_MethodFees = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS1.MethodFees.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AuthorityInfo> __Marshaller_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput> __Marshaller_TokenHolder_CreateTokenHolderProfitSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput> __Marshaller_TokenHolder_AddTokenHolderBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput> __Marshaller_TokenHolder_RemoveTokenHolderBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ContributeProfitsInput> __Marshaller_TokenHolder_ContributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ContributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.DistributeProfitsInput> __Marshaller_TokenHolder_DistributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.DistributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput> __Marshaller_TokenHolder_RegisterForProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.RegisterForProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ClaimProfitsInput> __Marshaller_TokenHolder_ClaimProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ClaimProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme> __Marshaller_TokenHolder_TokenHolderProfitScheme = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ReceivedProfitsMap> __Marshaller_TokenHolder_ReceivedProfitsMap = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ReceivedProfitsMap.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMethodFee = new aelf::Method<global::AElf.Standards.ACS1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMethodFee",
        __Marshaller_acs1_MethodFees,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeMethodFeeController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeMethodFeeController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Standards.ACS1.MethodFees> __Method_GetMethodFee = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Standards.ACS1.MethodFees>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodFee",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_acs1_MethodFees);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetMethodFeeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodFeeController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateScheme = new aelf::Method<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateScheme",
        __Marshaller_TokenHolder_CreateTokenHolderProfitSchemeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddBeneficiary = new aelf::Method<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddBeneficiary",
        __Marshaller_TokenHolder_AddTokenHolderBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveBeneficiary = new aelf::Method<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveBeneficiary",
        __Marshaller_TokenHolder_RemoveTokenHolderBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ContributeProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ContributeProfits",
        __Marshaller_TokenHolder_ContributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DistributeProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DistributeProfits",
        __Marshaller_TokenHolder_DistributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RegisterForProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RegisterForProfits",
        __Marshaller_TokenHolder_RegisterForProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Withdraw = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Withdraw",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ClaimProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ClaimProfits",
        __Marshaller_TokenHolder_ClaimProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme> __Method_GetScheme = new aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme>(
        aelf::MethodType.View,
        __ServiceName,
        "GetScheme",
        __Marshaller_aelf_Address,
        __Marshaller_TokenHolder_TokenHolderProfitScheme);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::AElf.Contracts.TokenHolder.ReceivedProfitsMap> __Method_GetProfitsMap = new aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::AElf.Contracts.TokenHolder.ReceivedProfitsMap>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitsMap",
        __Marshaller_TokenHolder_ClaimProfitsInput,
        __Marshaller_TokenHolder_ReceivedProfitsMap);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.TokenHolder.TokenHolderContractImplReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS1.Acs1Reflection.Descriptor.Services[0],
          global::AElf.Contracts.TokenHolder.TokenHolderContractReflection.Descriptor.Services[0],
          global::AElf.Contracts.TokenHolder.TokenHolderContractImplReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    /// <summary>Base class for the contract of TokenHolderContractImpl</summary>
    public abstract partial class TokenHolderContractImplBase : AElf.Sdk.CSharp.CSharpSmartContract<AElf.Contracts.TokenHolder.TokenHolderContractState>
    {
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetMethodFee(global::AElf.Standards.ACS1.MethodFees input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty ChangeMethodFeeController(global::AuthorityInfo input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Standards.ACS1.MethodFees GetMethodFee(global::Google.Protobuf.WellKnownTypes.StringValue input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AuthorityInfo GetMethodFeeController(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty CreateScheme(global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddBeneficiary(global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty RemoveBeneficiary(global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty ContributeProfits(global::AElf.Contracts.TokenHolder.ContributeProfitsInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty DistributeProfits(global::AElf.Contracts.TokenHolder.DistributeProfitsInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty RegisterForProfits(global::AElf.Contracts.TokenHolder.RegisterForProfitsInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Withdraw(global::AElf.Types.Address input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty ClaimProfits(global::AElf.Contracts.TokenHolder.ClaimProfitsInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme GetScheme(global::AElf.Types.Address input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.TokenHolder.ReceivedProfitsMap GetProfitsMap(global::AElf.Contracts.TokenHolder.ClaimProfitsInput input)
      {
        throw new global::System.NotImplementedException();
      }

    }

    public static aelf::ServerServiceDefinition BindService(TokenHolderContractImplBase serviceImpl)
    {
      return aelf::ServerServiceDefinition.CreateBuilder()
          .AddDescriptors(Descriptors)
          .AddMethod(__Method_SetMethodFee, serviceImpl.SetMethodFee)
          .AddMethod(__Method_ChangeMethodFeeController, serviceImpl.ChangeMethodFeeController)
          .AddMethod(__Method_GetMethodFee, serviceImpl.GetMethodFee)
          .AddMethod(__Method_GetMethodFeeController, serviceImpl.GetMethodFeeController)
          .AddMethod(__Method_CreateScheme, serviceImpl.CreateScheme)
          .AddMethod(__Method_AddBeneficiary, serviceImpl.AddBeneficiary)
          .AddMethod(__Method_RemoveBeneficiary, serviceImpl.RemoveBeneficiary)
          .AddMethod(__Method_ContributeProfits, serviceImpl.ContributeProfits)
          .AddMethod(__Method_DistributeProfits, serviceImpl.DistributeProfits)
          .AddMethod(__Method_RegisterForProfits, serviceImpl.RegisterForProfits)
          .AddMethod(__Method_Withdraw, serviceImpl.Withdraw)
          .AddMethod(__Method_ClaimProfits, serviceImpl.ClaimProfits)
          .AddMethod(__Method_GetScheme, serviceImpl.GetScheme)
          .AddMethod(__Method_GetProfitsMap, serviceImpl.GetProfitsMap).Build();
    }

  }
}
#endregion

