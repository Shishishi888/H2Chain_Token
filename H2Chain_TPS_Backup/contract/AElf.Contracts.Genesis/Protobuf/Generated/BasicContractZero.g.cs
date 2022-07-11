// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: basic_contract_zero.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.Genesis {

  /// <summary>Holder for reflection information generated from basic_contract_zero.proto</summary>
  public static partial class BasicContractZeroReflection {

    #region Descriptor
    /// <summary>File descriptor for basic_contract_zero.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BasicContractZeroReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChliYXNpY19jb250cmFjdF96ZXJvLnByb3RvEgRaZXJvGhJhZWxmL29wdGlv",
            "bnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoPYWVsZi9j",
            "b3JlLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhRh",
            "dXRob3JpdHlfaW5mby5wcm90byJBCg9Jbml0aWFsaXplSW5wdXQSLgomY29u",
            "dHJhY3RfZGVwbG95bWVudF9hdXRob3JpdHlfcmVxdWlyZWQYASABKAginwEK",
            "FkNvbnRyYWN0UHJvcG9zaW5nSW5wdXQSHwoIcHJvcG9zZXIYASABKAsyDS5h",
            "ZWxmLkFkZHJlc3MSMgoGc3RhdHVzGAIgASgOMiIuWmVyby5Db250cmFjdFBy",
            "b3Bvc2luZ0lucHV0U3RhdHVzEjAKDGV4cGlyZWRfdGltZRgDIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAqZQocQ29udHJhY3RQcm9wb3NpbmdJ",
            "bnB1dFN0YXR1cxIMCghQUk9QT1NFRBAAEgwKCEFQUFJPVkVEEAESFwoTQ09E",
            "RV9DSEVDS19QUk9QT1NFRBACEhAKDENPREVfQ0hFQ0tFRBADMoAEChFCYXNp",
            "Y0NvbnRyYWN0WmVybxI9CgpJbml0aWFsaXplEhUuWmVyby5Jbml0aWFsaXpl",
            "SW5wdXQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABJGChtTZXRJbml0aWFs",
            "Q29udHJvbGxlckFkZHJlc3MSDS5hZWxmLkFkZHJlc3MaFi5nb29nbGUucHJv",
            "dG9idWYuRW1wdHkiABJOCiJDaGFuZ2VDb250cmFjdERlcGxveW1lbnRDb250",
            "cm9sbGVyEg4uQXV0aG9yaXR5SW5mbxoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0",
            "eSIAEkUKGUNoYW5nZUNvZGVDaGVja0NvbnRyb2xsZXISDi5BdXRob3JpdHlJ",
            "bmZvGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASUAofR2V0Q29udHJhY3RE",
            "ZXBsb3ltZW50Q29udHJvbGxlchIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoO",
            "LkF1dGhvcml0eUluZm8iBYiJ9wEBEkcKFkdldENvZGVDaGVja0NvbnRyb2xs",
            "ZXISFi5nb29nbGUucHJvdG9idWYuRW1wdHkaDi5BdXRob3JpdHlJbmZvIgWI",
            "ifcBARoyssz2AS1BRWxmLkNvbnRyYWN0cy5HZW5lc2lzLkJhc2ljQ29udHJh",
            "Y3RaZXJvU3RhdGVCGaoCFkFFbGYuQ29udHJhY3RzLkdlbmVzaXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::AElf.Types.CoreReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::AuthorityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AElf.Contracts.Genesis.ContractProposingInputStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Genesis.InitializeInput), global::AElf.Contracts.Genesis.InitializeInput.Parser, new[]{ "ContractDeploymentAuthorityRequired" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Genesis.ContractProposingInput), global::AElf.Contracts.Genesis.ContractProposingInput.Parser, new[]{ "Proposer", "Status", "ExpiredTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ContractProposingInputStatus {
    /// <summary>
    /// Proposal is proposed.
    /// </summary>
    [pbr::OriginalName("PROPOSED")] Proposed = 0,
    /// <summary>
    /// Proposal is approved by parliament.
    /// </summary>
    [pbr::OriginalName("APPROVED")] Approved = 1,
    /// <summary>
    /// Code check is proposed.
    /// </summary>
    [pbr::OriginalName("CODE_CHECK_PROPOSED")] CodeCheckProposed = 2,
    /// <summary>
    /// Passed code checks.
    /// </summary>
    [pbr::OriginalName("CODE_CHECKED")] CodeChecked = 3,
  }

  #endregion

  #region Messages
  public sealed partial class InitializeInput : pb::IMessage<InitializeInput> {
    private static readonly pb::MessageParser<InitializeInput> _parser = new pb::MessageParser<InitializeInput>(() => new InitializeInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializeInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Genesis.BasicContractZeroReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput(InitializeInput other) : this() {
      contractDeploymentAuthorityRequired_ = other.contractDeploymentAuthorityRequired_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput Clone() {
      return new InitializeInput(this);
    }

    /// <summary>Field number for the "contract_deployment_authority_required" field.</summary>
    public const int ContractDeploymentAuthorityRequiredFieldNumber = 1;
    private bool contractDeploymentAuthorityRequired_;
    /// <summary>
    /// Whether contract deployment/update requires authority.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ContractDeploymentAuthorityRequired {
      get { return contractDeploymentAuthorityRequired_; }
      set {
        contractDeploymentAuthorityRequired_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializeInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializeInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContractDeploymentAuthorityRequired != other.ContractDeploymentAuthorityRequired) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ContractDeploymentAuthorityRequired != false) hash ^= ContractDeploymentAuthorityRequired.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ContractDeploymentAuthorityRequired != false) {
        output.WriteRawTag(8);
        output.WriteBool(ContractDeploymentAuthorityRequired);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ContractDeploymentAuthorityRequired != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializeInput other) {
      if (other == null) {
        return;
      }
      if (other.ContractDeploymentAuthorityRequired != false) {
        ContractDeploymentAuthorityRequired = other.ContractDeploymentAuthorityRequired;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ContractDeploymentAuthorityRequired = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ContractProposingInput : pb::IMessage<ContractProposingInput> {
    private static readonly pb::MessageParser<ContractProposingInput> _parser = new pb::MessageParser<ContractProposingInput>(() => new ContractProposingInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContractProposingInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Genesis.BasicContractZeroReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractProposingInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractProposingInput(ContractProposingInput other) : this() {
      proposer_ = other.proposer_ != null ? other.proposer_.Clone() : null;
      status_ = other.status_;
      expiredTime_ = other.expiredTime_ != null ? other.expiredTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContractProposingInput Clone() {
      return new ContractProposingInput(this);
    }

    /// <summary>Field number for the "proposer" field.</summary>
    public const int ProposerFieldNumber = 1;
    private global::AElf.Types.Address proposer_;
    /// <summary>
    /// The address of proposer for contract deployment/update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address Proposer {
      get { return proposer_; }
      set {
        proposer_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::AElf.Contracts.Genesis.ContractProposingInputStatus status_ = global::AElf.Contracts.Genesis.ContractProposingInputStatus.Proposed;
    /// <summary>
    /// The status of proposal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Contracts.Genesis.ContractProposingInputStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "expired_time" field.</summary>
    public const int ExpiredTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiredTime_;
    /// <summary>
    /// The expiration time of proposal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpiredTime {
      get { return expiredTime_; }
      set {
        expiredTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContractProposingInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContractProposingInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Proposer, other.Proposer)) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(ExpiredTime, other.ExpiredTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (proposer_ != null) hash ^= Proposer.GetHashCode();
      if (Status != global::AElf.Contracts.Genesis.ContractProposingInputStatus.Proposed) hash ^= Status.GetHashCode();
      if (expiredTime_ != null) hash ^= ExpiredTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (proposer_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Proposer);
      }
      if (Status != global::AElf.Contracts.Genesis.ContractProposingInputStatus.Proposed) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (expiredTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExpiredTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (proposer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Proposer);
      }
      if (Status != global::AElf.Contracts.Genesis.ContractProposingInputStatus.Proposed) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (expiredTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpiredTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContractProposingInput other) {
      if (other == null) {
        return;
      }
      if (other.proposer_ != null) {
        if (proposer_ == null) {
          Proposer = new global::AElf.Types.Address();
        }
        Proposer.MergeFrom(other.Proposer);
      }
      if (other.Status != global::AElf.Contracts.Genesis.ContractProposingInputStatus.Proposed) {
        Status = other.Status;
      }
      if (other.expiredTime_ != null) {
        if (expiredTime_ == null) {
          ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpiredTime.MergeFrom(other.ExpiredTime);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (proposer_ == null) {
              Proposer = new global::AElf.Types.Address();
            }
            input.ReadMessage(Proposer);
            break;
          }
          case 16: {
            Status = (global::AElf.Contracts.Genesis.ContractProposingInputStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (expiredTime_ == null) {
              ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpiredTime);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
