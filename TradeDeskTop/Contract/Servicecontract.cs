// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TradeDeskTop/protos/servicecontract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ServiceContract {

  /// <summary>Holder for reflection information generated from TradeDeskTop/protos/servicecontract.proto</summary>
  public static partial class ServicecontractReflection {

    #region Descriptor
    /// <summary>File descriptor for TradeDeskTop/protos/servicecontract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServicecontractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUcmFkZURlc2tUb3AvcHJvdG9zL3NlcnZpY2Vjb250cmFjdC5wcm90bxIP",
            "U2VydmljZUNvbnRyYWN0IhoKDFRyYWRlUmVxdWVzdBIKCgJpZBgBIAEoBSJT",
            "CgtUcmFkZVJlc3VsdBIKCgJpZBgBIAEoBRIUCgxjb3VudGVycGFydHkYAiAB",
            "KAkSEAoIY3VycmVuY3kYAyABKAkSEAoIbm90aW9uYWwYBCABKAUysAEKDFRy",
            "YWRlU2VydmljZRJTChJHZXRBbGxUcmFkZXNTdHJlYW0SHS5TZXJ2aWNlQ29u",
            "dHJhY3QuVHJhZGVSZXF1ZXN0GhwuU2VydmljZUNvbnRyYWN0LlRyYWRlUmVz",
            "dWx0MAESSwoMR2V0VHJhZGVCeUlkEh0uU2VydmljZUNvbnRyYWN0LlRyYWRl",
            "UmVxdWVzdBocLlNlcnZpY2VDb250cmFjdC5UcmFkZVJlc3VsdEISqgIPU2Vy",
            "dmljZUNvbnRyYWN0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ServiceContract.TradeRequest), global::ServiceContract.TradeRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServiceContract.TradeResult), global::ServiceContract.TradeResult.Parser, new[]{ "Id", "Counterparty", "Currency", "Notional" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TradeRequest : pb::IMessage<TradeRequest> {
    private static readonly pb::MessageParser<TradeRequest> _parser = new pb::MessageParser<TradeRequest>(() => new TradeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TradeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServiceContract.ServicecontractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeRequest(TradeRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeRequest Clone() {
      return new TradeRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TradeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TradeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TradeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
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
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TradeResult : pb::IMessage<TradeResult> {
    private static readonly pb::MessageParser<TradeResult> _parser = new pb::MessageParser<TradeResult>(() => new TradeResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TradeResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServiceContract.ServicecontractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeResult(TradeResult other) : this() {
      id_ = other.id_;
      counterparty_ = other.counterparty_;
      currency_ = other.currency_;
      notional_ = other.notional_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeResult Clone() {
      return new TradeResult(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "counterparty" field.</summary>
    public const int CounterpartyFieldNumber = 2;
    private string counterparty_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Counterparty {
      get { return counterparty_; }
      set {
        counterparty_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "currency" field.</summary>
    public const int CurrencyFieldNumber = 3;
    private string currency_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Currency {
      get { return currency_; }
      set {
        currency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "notional" field.</summary>
    public const int NotionalFieldNumber = 4;
    private int notional_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Notional {
      get { return notional_; }
      set {
        notional_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TradeResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TradeResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Counterparty != other.Counterparty) return false;
      if (Currency != other.Currency) return false;
      if (Notional != other.Notional) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Counterparty.Length != 0) hash ^= Counterparty.GetHashCode();
      if (Currency.Length != 0) hash ^= Currency.GetHashCode();
      if (Notional != 0) hash ^= Notional.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Counterparty.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Counterparty);
      }
      if (Currency.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Currency);
      }
      if (Notional != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Notional);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Counterparty.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Counterparty);
      }
      if (Currency.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Currency);
      }
      if (Notional != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Notional);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TradeResult other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Counterparty.Length != 0) {
        Counterparty = other.Counterparty;
      }
      if (other.Currency.Length != 0) {
        Currency = other.Currency;
      }
      if (other.Notional != 0) {
        Notional = other.Notional;
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
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Counterparty = input.ReadString();
            break;
          }
          case 26: {
            Currency = input.ReadString();
            break;
          }
          case 32: {
            Notional = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
