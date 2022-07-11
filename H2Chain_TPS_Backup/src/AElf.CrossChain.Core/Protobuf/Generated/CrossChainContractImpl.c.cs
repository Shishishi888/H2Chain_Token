// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cross_chain_contract_impl.proto
// </auto-generated>
// Original file comments:
// *
// Cross-Chain contract.
// 
// Implement AElf Standards ACS1 and ACS7.
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.CrossChain {

  #region Events
  #endregion
  internal static partial class CrossChainContractImplContainer
  {
    static readonly string __ServiceName = "CrossChainImpl.CrossChainContractImpl";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CrossChainBlockData> __Marshaller_acs7_CrossChainBlockData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CrossChainBlockData.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput> __Marshaller_acs7_ReleaseCrossChainIndexingProposalInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.SideChainCreationRequest> __Marshaller_acs7_SideChainCreationRequest = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.SideChainCreationRequest.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput> __Marshaller_acs7_ReleaseSideChainCreationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ReleaseSideChainCreationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CreateSideChainInput> __Marshaller_acs7_CreateSideChainInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CreateSideChainInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.RechargeInput> __Marshaller_acs7_RechargeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.RechargeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.AdjustIndexingFeeInput> __Marshaller_acs7_AdjustIndexingFeeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.AdjustIndexingFeeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.VerifyTransactionInput> __Marshaller_acs7_VerifyTransactionInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.VerifyTransactionInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Marshaller_acs7_ChainIdAndHeightDict = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ChainIdAndHeightDict.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.SideChainIndexingInformationList> __Marshaller_acs7_SideChainIndexingInformationList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.SideChainIndexingInformationList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.IndexedSideChainBlockData> __Marshaller_acs7_IndexedSideChainBlockData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.IndexedSideChainBlockData.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CrossChainMerkleProofContext> __Marshaller_acs7_CrossChainMerkleProofContext = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CrossChainMerkleProofContext.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ChainInitializationData> __Marshaller_acs7_ChainInitializationData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ChainInitializationData.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS1.MethodFees> __Marshaller_acs1_MethodFees = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS1.MethodFees.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AuthorityInfo> __Marshaller_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.InitializeInput> __Marshaller_CrossChain_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput> __Marshaller_CrossChain_ChangeSideChainIndexingFeeControllerInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput> __Marshaller_CrossChain_AcceptCrossChainIndexingProposalInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.GetChainStatusOutput> __Marshaller_CrossChain_GetChainStatusOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.GetChainStatusOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> __Marshaller_CrossChain_GetIndexingProposalStatusOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ProposeCrossChainIndexing = new aelf::Method<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeCrossChainIndexing",
        __Marshaller_acs7_CrossChainBlockData,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseCrossChainIndexingProposal = new aelf::Method<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseCrossChainIndexingProposal",
        __Marshaller_acs7_ReleaseCrossChainIndexingProposalInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestSideChainCreation = new aelf::Method<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RequestSideChainCreation",
        __Marshaller_acs7_SideChainCreationRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseSideChainCreation = new aelf::Method<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseSideChainCreation",
        __Marshaller_acs7_ReleaseSideChainCreationInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_CreateSideChain = new aelf::Method<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateSideChain",
        __Marshaller_acs7_CreateSideChainInput,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Recharge = new aelf::Method<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Recharge",
        __Marshaller_acs7_RechargeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_DisposeSideChain = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "DisposeSideChain",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AdjustIndexingFeePrice = new aelf::Method<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AdjustIndexingFeePrice",
        __Marshaller_acs7_AdjustIndexingFeeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_VerifyTransaction = new aelf::Method<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "VerifyTransaction",
        __Marshaller_acs7_VerifyTransactionInput,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Method_GetSideChainIdAndHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIdAndHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_ChainIdAndHeightDict);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList> __Method_GetSideChainIndexingInformationList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingInformationList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_SideChainIndexingInformationList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Method_GetAllChainsIdAndHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict>(
        aelf::MethodType.View,
        __ServiceName,
        "GetAllChainsIdAndHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_ChainIdAndHeightDict);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData> __Method_GetIndexedSideChainBlockDataByHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData>(
        aelf::MethodType.View,
        __ServiceName,
        "GetIndexedSideChainBlockDataByHeight",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_acs7_IndexedSideChainBlockData);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext> __Method_GetBoundParentChainHeightAndMerklePathByHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext>(
        aelf::MethodType.View,
        __ServiceName,
        "GetBoundParentChainHeightAndMerklePathByHeight",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_acs7_CrossChainMerkleProofContext);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData> __Method_GetChainInitializationData = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData>(
        aelf::MethodType.View,
        __ServiceName,
        "GetChainInitializationData",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_acs7_ChainInitializationData);

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

    static readonly aelf::Method<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_CrossChain_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetInitialSideChainLifetimeControllerAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetInitialSideChainLifetimeControllerAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetInitialIndexingControllerAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetInitialIndexingControllerAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeCrossChainIndexingController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeCrossChainIndexingController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeSideChainLifetimeController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeSideChainLifetimeController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeSideChainIndexingFeeController = new aelf::Method<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeSideChainIndexingFeeController",
        __Marshaller_CrossChain_ChangeSideChainIndexingFeeControllerInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AcceptCrossChainIndexingProposal = new aelf::Method<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AcceptCrossChainIndexingProposal",
        __Marshaller_CrossChain_AcceptCrossChainIndexingProposalInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address> __Method_GetSideChainCreator = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainCreator",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput> __Method_GetChainStatus = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetChainStatus",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_CrossChain_GetChainStatusOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainHeight",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetParentChainHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetParentChainHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetParentChainId = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetParentChainId",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainBalance = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainBalance",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainIndexingFeeDebt = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeeDebt",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> __Method_GetIndexingProposalStatus = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetIndexingProposalStatus",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CrossChain_GetIndexingProposalStatusOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainIndexingFeePrice = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeePrice",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetSideChainLifetimeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainLifetimeController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetCrossChainIndexingController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCrossChainIndexingController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo> __Method_GetSideChainIndexingFeeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeeController",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_AuthorityInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.CrossChain.CrossChainContractImplReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS7.Acs7Reflection.Descriptor.Services[0],
          global::AElf.Standards.ACS1.Acs1Reflection.Descriptor.Services[0],
          global::AElf.Contracts.CrossChain.CrossChainContractReflection.Descriptor.Services[0],
          global::AElf.Contracts.CrossChain.CrossChainContractImplReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class CrossChainContractImplStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty> ProposeCrossChainIndexing
      {
        get { return __factory.Create(__Method_ProposeCrossChainIndexing); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseCrossChainIndexingProposal
      {
        get { return __factory.Create(__Method_ReleaseCrossChainIndexingProposal); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty> RequestSideChainCreation
      {
        get { return __factory.Create(__Method_RequestSideChainCreation); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseSideChainCreation
      {
        get { return __factory.Create(__Method_ReleaseSideChainCreation); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value> CreateSideChain
      {
        get { return __factory.Create(__Method_CreateSideChain); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty> Recharge
      {
        get { return __factory.Create(__Method_Recharge); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value> DisposeSideChain
      {
        get { return __factory.Create(__Method_DisposeSideChain); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty> AdjustIndexingFeePrice
      {
        get { return __factory.Create(__Method_AdjustIndexingFeePrice); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue> VerifyTransaction
      {
        get { return __factory.Create(__Method_VerifyTransaction); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> GetSideChainIdAndHeight
      {
        get { return __factory.Create(__Method_GetSideChainIdAndHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList> GetSideChainIndexingInformationList
      {
        get { return __factory.Create(__Method_GetSideChainIndexingInformationList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> GetAllChainsIdAndHeight
      {
        get { return __factory.Create(__Method_GetAllChainsIdAndHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData> GetIndexedSideChainBlockDataByHeight
      {
        get { return __factory.Create(__Method_GetIndexedSideChainBlockDataByHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext> GetBoundParentChainHeightAndMerklePathByHeight
      {
        get { return __factory.Create(__Method_GetBoundParentChainHeightAndMerklePathByHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData> GetChainInitializationData
      {
        get { return __factory.Create(__Method_GetChainInitializationData); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty> SetMethodFee
      {
        get { return __factory.Create(__Method_SetMethodFee); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeMethodFeeController
      {
        get { return __factory.Create(__Method_ChangeMethodFeeController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Standards.ACS1.MethodFees> GetMethodFee
      {
        get { return __factory.Create(__Method_GetMethodFee); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetMethodFeeController
      {
        get { return __factory.Create(__Method_GetMethodFeeController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> Initialize
      {
        get { return __factory.Create(__Method_Initialize); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> SetInitialSideChainLifetimeControllerAddress
      {
        get { return __factory.Create(__Method_SetInitialSideChainLifetimeControllerAddress); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> SetInitialIndexingControllerAddress
      {
        get { return __factory.Create(__Method_SetInitialIndexingControllerAddress); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeCrossChainIndexingController
      {
        get { return __factory.Create(__Method_ChangeCrossChainIndexingController); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeSideChainLifetimeController
      {
        get { return __factory.Create(__Method_ChangeSideChainLifetimeController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty> ChangeSideChainIndexingFeeController
      {
        get { return __factory.Create(__Method_ChangeSideChainIndexingFeeController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> AcceptCrossChainIndexingProposal
      {
        get { return __factory.Create(__Method_AcceptCrossChainIndexingProposal); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address> GetSideChainCreator
      {
        get { return __factory.Create(__Method_GetSideChainCreator); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput> GetChainStatus
      {
        get { return __factory.Create(__Method_GetChainStatus); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainHeight
      {
        get { return __factory.Create(__Method_GetSideChainHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> GetParentChainHeight
      {
        get { return __factory.Create(__Method_GetParentChainHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> GetParentChainId
      {
        get { return __factory.Create(__Method_GetParentChainId); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainBalance
      {
        get { return __factory.Create(__Method_GetSideChainBalance); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainIndexingFeeDebt
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeeDebt); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> GetIndexingProposalStatus
      {
        get { return __factory.Create(__Method_GetIndexingProposalStatus); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainIndexingFeePrice
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeePrice); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetSideChainLifetimeController
      {
        get { return __factory.Create(__Method_GetSideChainLifetimeController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetCrossChainIndexingController
      {
        get { return __factory.Create(__Method_GetCrossChainIndexingController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo> GetSideChainIndexingFeeController
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeeController); }
      }

    }
  }
}
#endregion

