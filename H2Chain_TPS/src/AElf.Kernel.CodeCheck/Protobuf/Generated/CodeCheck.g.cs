// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: code_check.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Kernel.CodeCheck {

  /// <summary>Holder for reflection information generated from code_check.proto</summary>
  public static partial class CodeCheckReflection {

    #region Descriptor
    /// <summary>File descriptor for code_check.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CodeCheckReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBjb2RlX2NoZWNrLnByb3RvEgRhZWxmIj8KFlJlcXVpcmVkQWNzSW5Db250",
            "cmFjdHMSEAoIYWNzX2xpc3QYASADKAkSEwoLcmVxdWlyZV9hbGwYAiABKAhC",
            "GKoCFUFFbGYuS2VybmVsLkNvZGVDaGVja2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Kernel.CodeCheck.RequiredAcsInContracts), global::AElf.Kernel.CodeCheck.RequiredAcsInContracts.Parser, new[]{ "AcsList", "RequireAll" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RequiredAcsInContracts : pb::IMessage<RequiredAcsInContracts> {
    private static readonly pb::MessageParser<RequiredAcsInContracts> _parser = new pb::MessageParser<RequiredAcsInContracts>(() => new RequiredAcsInContracts());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequiredAcsInContracts> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Kernel.CodeCheck.CodeCheckReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequiredAcsInContracts() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequiredAcsInContracts(RequiredAcsInContracts other) : this() {
      acsList_ = other.acsList_.Clone();
      requireAll_ = other.requireAll_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequiredAcsInContracts Clone() {
      return new RequiredAcsInContracts(this);
    }

    /// <summary>Field number for the "acs_list" field.</summary>
    public const int AcsListFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_acsList_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> acsList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AcsList {
      get { return acsList_; }
    }

    /// <summary>Field number for the "require_all" field.</summary>
    public const int RequireAllFieldNumber = 2;
    private bool requireAll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RequireAll {
      get { return requireAll_; }
      set {
        requireAll_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequiredAcsInContracts);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequiredAcsInContracts other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!acsList_.Equals(other.acsList_)) return false;
      if (RequireAll != other.RequireAll) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= acsList_.GetHashCode();
      if (RequireAll != false) hash ^= RequireAll.GetHashCode();
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
      acsList_.WriteTo(output, _repeated_acsList_codec);
      if (RequireAll != false) {
        output.WriteRawTag(16);
        output.WriteBool(RequireAll);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += acsList_.CalculateSize(_repeated_acsList_codec);
      if (RequireAll != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequiredAcsInContracts other) {
      if (other == null) {
        return;
      }
      acsList_.Add(other.acsList_);
      if (other.RequireAll != false) {
        RequireAll = other.RequireAll;
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
            acsList_.AddEntriesFrom(input, _repeated_acsList_codec);
            break;
          }
          case 16: {
            RequireAll = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
