// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TEXTUAL_ANALYSIS_COMPLETE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace V4Design.Protos.Taln {

  /// <summary>Holder for reflection information generated from TEXTUAL_ANALYSIS_COMPLETE.proto</summary>
  public static partial class TEXTUALANALYSISCOMPLETEReflection {

    #region Descriptor
    /// <summary>File descriptor for TEXTUAL_ANALYSIS_COMPLETE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TEXTUALANALYSISCOMPLETEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9URVhUVUFMX0FOQUxZU0lTX0NPTVBMRVRFLnByb3RvEhR2NGRlc2lnbi5w",
            "cm90b3MudGFsbiJPCg5BbmFseXNpc1Jlc3VsdBIMCgR0ZXh0GAEgASgJEi8K",
            "CGNvbmNlcHRzGAIgAygLMh0udjRkZXNpZ24ucHJvdG9zLnRhbG4uQ29uY2Vw",
            "dCL/AQoHQ29uY2VwdBINCgViZWdpbhgBIAEoBRILCgNlbmQYAiABKAUSDAoE",
            "dGV4dBgDIAEoCRI/CgtEQnBlZGlhSW5mbxgEIAEoCzIoLnY0ZGVzaWduLnBy",
            "b3Rvcy50YWxuLkRCcGVkaWFDb25jZXB0SW5mb0gAEkEKDEJhYmVsTmV0SW5m",
            "bxgFIAEoCzIpLnY0ZGVzaWduLnByb3Rvcy50YWxuLkJhYmVsTmV0Q29uY2Vw",
            "dEluZm9IABI3CgdOZXJJbmZvGAYgASgLMiQudjRkZXNpZ24ucHJvdG9zLnRh",
            "bG4uTmVyQ29uY2VwdEluZm9IAEINCgtDb25jZXB0SW5mbyJFChJEQnBlZGlh",
            "Q29uY2VwdEluZm8SCwoDdXJpGAEgASgJEg0KBXR5cGVzGAIgASgJEhMKC3Np",
            "bXBsZVR5cGVzGAMgASgJIkoKE0JhYmVsTmV0Q29uY2VwdEluZm8SCgoCaWQY",
            "ASABKAkSEwoLZGVzY3JpcHRpb24YAiABKAkSEgoKY29uZmlkZW5jZRgDIAEo",
            "ASI0Cg5OZXJDb25jZXB0SW5mbxINCgV0eXBlcxgBIAEoCRITCgtzaW1wbGVU",
            "eXBlcxgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::V4Design.Protos.Taln.AnalysisResult), global::V4Design.Protos.Taln.AnalysisResult.Parser, new[]{ "Text", "Concepts" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::V4Design.Protos.Taln.Concept), global::V4Design.Protos.Taln.Concept.Parser, new[]{ "Begin", "End", "Text", "DBpediaInfo", "BabelNetInfo", "NerInfo" }, new[]{ "ConceptInfo" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::V4Design.Protos.Taln.DBpediaConceptInfo), global::V4Design.Protos.Taln.DBpediaConceptInfo.Parser, new[]{ "Uri", "Types_", "SimpleTypes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::V4Design.Protos.Taln.BabelNetConceptInfo), global::V4Design.Protos.Taln.BabelNetConceptInfo.Parser, new[]{ "Id", "Description", "Confidence" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::V4Design.Protos.Taln.NerConceptInfo), global::V4Design.Protos.Taln.NerConceptInfo.Parser, new[]{ "Types_", "SimpleTypes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AnalysisResult : pb::IMessage<AnalysisResult> {
    private static readonly pb::MessageParser<AnalysisResult> _parser = new pb::MessageParser<AnalysisResult>(() => new AnalysisResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnalysisResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V4Design.Protos.Taln.TEXTUALANALYSISCOMPLETEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalysisResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalysisResult(AnalysisResult other) : this() {
      text_ = other.text_;
      concepts_ = other.concepts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnalysisResult Clone() {
      return new AnalysisResult(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "concepts" field.</summary>
    public const int ConceptsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::V4Design.Protos.Taln.Concept> _repeated_concepts_codec
        = pb::FieldCodec.ForMessage(18, global::V4Design.Protos.Taln.Concept.Parser);
    private readonly pbc::RepeatedField<global::V4Design.Protos.Taln.Concept> concepts_ = new pbc::RepeatedField<global::V4Design.Protos.Taln.Concept>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::V4Design.Protos.Taln.Concept> Concepts {
      get { return concepts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnalysisResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnalysisResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if(!concepts_.Equals(other.concepts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      hash ^= concepts_.GetHashCode();
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
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
      concepts_.WriteTo(output, _repeated_concepts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      size += concepts_.CalculateSize(_repeated_concepts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnalysisResult other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      concepts_.Add(other.concepts_);
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
            Text = input.ReadString();
            break;
          }
          case 18: {
            concepts_.AddEntriesFrom(input, _repeated_concepts_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Concept : pb::IMessage<Concept> {
    private static readonly pb::MessageParser<Concept> _parser = new pb::MessageParser<Concept>(() => new Concept());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Concept> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V4Design.Protos.Taln.TEXTUALANALYSISCOMPLETEReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Concept() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Concept(Concept other) : this() {
      begin_ = other.begin_;
      end_ = other.end_;
      text_ = other.text_;
      switch (other.ConceptInfoCase) {
        case ConceptInfoOneofCase.DBpediaInfo:
          DBpediaInfo = other.DBpediaInfo.Clone();
          break;
        case ConceptInfoOneofCase.BabelNetInfo:
          BabelNetInfo = other.BabelNetInfo.Clone();
          break;
        case ConceptInfoOneofCase.NerInfo:
          NerInfo = other.NerInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Concept Clone() {
      return new Concept(this);
    }

    /// <summary>Field number for the "begin" field.</summary>
    public const int BeginFieldNumber = 1;
    private int begin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Begin {
      get { return begin_; }
      set {
        begin_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 2;
    private int end_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 3;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DBpediaInfo" field.</summary>
    public const int DBpediaInfoFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::V4Design.Protos.Taln.DBpediaConceptInfo DBpediaInfo {
      get { return conceptInfoCase_ == ConceptInfoOneofCase.DBpediaInfo ? (global::V4Design.Protos.Taln.DBpediaConceptInfo) conceptInfo_ : null; }
      set {
        conceptInfo_ = value;
        conceptInfoCase_ = value == null ? ConceptInfoOneofCase.None : ConceptInfoOneofCase.DBpediaInfo;
      }
    }

    /// <summary>Field number for the "BabelNetInfo" field.</summary>
    public const int BabelNetInfoFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::V4Design.Protos.Taln.BabelNetConceptInfo BabelNetInfo {
      get { return conceptInfoCase_ == ConceptInfoOneofCase.BabelNetInfo ? (global::V4Design.Protos.Taln.BabelNetConceptInfo) conceptInfo_ : null; }
      set {
        conceptInfo_ = value;
        conceptInfoCase_ = value == null ? ConceptInfoOneofCase.None : ConceptInfoOneofCase.BabelNetInfo;
      }
    }

    /// <summary>Field number for the "NerInfo" field.</summary>
    public const int NerInfoFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::V4Design.Protos.Taln.NerConceptInfo NerInfo {
      get { return conceptInfoCase_ == ConceptInfoOneofCase.NerInfo ? (global::V4Design.Protos.Taln.NerConceptInfo) conceptInfo_ : null; }
      set {
        conceptInfo_ = value;
        conceptInfoCase_ = value == null ? ConceptInfoOneofCase.None : ConceptInfoOneofCase.NerInfo;
      }
    }

    private object conceptInfo_;
    /// <summary>Enum of possible cases for the "ConceptInfo" oneof.</summary>
    public enum ConceptInfoOneofCase {
      None = 0,
      DBpediaInfo = 4,
      BabelNetInfo = 5,
      NerInfo = 6,
    }
    private ConceptInfoOneofCase conceptInfoCase_ = ConceptInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConceptInfoOneofCase ConceptInfoCase {
      get { return conceptInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConceptInfo() {
      conceptInfoCase_ = ConceptInfoOneofCase.None;
      conceptInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Concept);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Concept other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Begin != other.Begin) return false;
      if (End != other.End) return false;
      if (Text != other.Text) return false;
      if (!object.Equals(DBpediaInfo, other.DBpediaInfo)) return false;
      if (!object.Equals(BabelNetInfo, other.BabelNetInfo)) return false;
      if (!object.Equals(NerInfo, other.NerInfo)) return false;
      if (ConceptInfoCase != other.ConceptInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Begin != 0) hash ^= Begin.GetHashCode();
      if (End != 0) hash ^= End.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (conceptInfoCase_ == ConceptInfoOneofCase.DBpediaInfo) hash ^= DBpediaInfo.GetHashCode();
      if (conceptInfoCase_ == ConceptInfoOneofCase.BabelNetInfo) hash ^= BabelNetInfo.GetHashCode();
      if (conceptInfoCase_ == ConceptInfoOneofCase.NerInfo) hash ^= NerInfo.GetHashCode();
      hash ^= (int) conceptInfoCase_;
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
      if (Begin != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Begin);
      }
      if (End != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(End);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Text);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.DBpediaInfo) {
        output.WriteRawTag(34);
        output.WriteMessage(DBpediaInfo);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.BabelNetInfo) {
        output.WriteRawTag(42);
        output.WriteMessage(BabelNetInfo);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.NerInfo) {
        output.WriteRawTag(50);
        output.WriteMessage(NerInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Begin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Begin);
      }
      if (End != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(End);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.DBpediaInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DBpediaInfo);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.BabelNetInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BabelNetInfo);
      }
      if (conceptInfoCase_ == ConceptInfoOneofCase.NerInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NerInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Concept other) {
      if (other == null) {
        return;
      }
      if (other.Begin != 0) {
        Begin = other.Begin;
      }
      if (other.End != 0) {
        End = other.End;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      switch (other.ConceptInfoCase) {
        case ConceptInfoOneofCase.DBpediaInfo:
          if (DBpediaInfo == null) {
            DBpediaInfo = new global::V4Design.Protos.Taln.DBpediaConceptInfo();
          }
          DBpediaInfo.MergeFrom(other.DBpediaInfo);
          break;
        case ConceptInfoOneofCase.BabelNetInfo:
          if (BabelNetInfo == null) {
            BabelNetInfo = new global::V4Design.Protos.Taln.BabelNetConceptInfo();
          }
          BabelNetInfo.MergeFrom(other.BabelNetInfo);
          break;
        case ConceptInfoOneofCase.NerInfo:
          if (NerInfo == null) {
            NerInfo = new global::V4Design.Protos.Taln.NerConceptInfo();
          }
          NerInfo.MergeFrom(other.NerInfo);
          break;
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
            Begin = input.ReadInt32();
            break;
          }
          case 16: {
            End = input.ReadInt32();
            break;
          }
          case 26: {
            Text = input.ReadString();
            break;
          }
          case 34: {
            global::V4Design.Protos.Taln.DBpediaConceptInfo subBuilder = new global::V4Design.Protos.Taln.DBpediaConceptInfo();
            if (conceptInfoCase_ == ConceptInfoOneofCase.DBpediaInfo) {
              subBuilder.MergeFrom(DBpediaInfo);
            }
            input.ReadMessage(subBuilder);
            DBpediaInfo = subBuilder;
            break;
          }
          case 42: {
            global::V4Design.Protos.Taln.BabelNetConceptInfo subBuilder = new global::V4Design.Protos.Taln.BabelNetConceptInfo();
            if (conceptInfoCase_ == ConceptInfoOneofCase.BabelNetInfo) {
              subBuilder.MergeFrom(BabelNetInfo);
            }
            input.ReadMessage(subBuilder);
            BabelNetInfo = subBuilder;
            break;
          }
          case 50: {
            global::V4Design.Protos.Taln.NerConceptInfo subBuilder = new global::V4Design.Protos.Taln.NerConceptInfo();
            if (conceptInfoCase_ == ConceptInfoOneofCase.NerInfo) {
              subBuilder.MergeFrom(NerInfo);
            }
            input.ReadMessage(subBuilder);
            NerInfo = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class DBpediaConceptInfo : pb::IMessage<DBpediaConceptInfo> {
    private static readonly pb::MessageParser<DBpediaConceptInfo> _parser = new pb::MessageParser<DBpediaConceptInfo>(() => new DBpediaConceptInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DBpediaConceptInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V4Design.Protos.Taln.TEXTUALANALYSISCOMPLETEReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DBpediaConceptInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DBpediaConceptInfo(DBpediaConceptInfo other) : this() {
      uri_ = other.uri_;
      types_ = other.types_;
      simpleTypes_ = other.simpleTypes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DBpediaConceptInfo Clone() {
      return new DBpediaConceptInfo(this);
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 1;
    private string uri_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "types" field.</summary>
    public const int Types_FieldNumber = 2;
    private string types_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Types_ {
      get { return types_; }
      set {
        types_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "simpleTypes" field.</summary>
    public const int SimpleTypesFieldNumber = 3;
    private string simpleTypes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SimpleTypes {
      get { return simpleTypes_; }
      set {
        simpleTypes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DBpediaConceptInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DBpediaConceptInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uri != other.Uri) return false;
      if (Types_ != other.Types_) return false;
      if (SimpleTypes != other.SimpleTypes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (Types_.Length != 0) hash ^= Types_.GetHashCode();
      if (SimpleTypes.Length != 0) hash ^= SimpleTypes.GetHashCode();
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
      if (Uri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (Types_.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Types_);
      }
      if (SimpleTypes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SimpleTypes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (Types_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Types_);
      }
      if (SimpleTypes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SimpleTypes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DBpediaConceptInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.Types_.Length != 0) {
        Types_ = other.Types_;
      }
      if (other.SimpleTypes.Length != 0) {
        SimpleTypes = other.SimpleTypes;
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
            Uri = input.ReadString();
            break;
          }
          case 18: {
            Types_ = input.ReadString();
            break;
          }
          case 26: {
            SimpleTypes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BabelNetConceptInfo : pb::IMessage<BabelNetConceptInfo> {
    private static readonly pb::MessageParser<BabelNetConceptInfo> _parser = new pb::MessageParser<BabelNetConceptInfo>(() => new BabelNetConceptInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BabelNetConceptInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V4Design.Protos.Taln.TEXTUALANALYSISCOMPLETEReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BabelNetConceptInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BabelNetConceptInfo(BabelNetConceptInfo other) : this() {
      id_ = other.id_;
      description_ = other.description_;
      confidence_ = other.confidence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BabelNetConceptInfo Clone() {
      return new BabelNetConceptInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 3;
    private double confidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BabelNetConceptInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BabelNetConceptInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Description != other.Description) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Confidence, other.Confidence)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Confidence != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Confidence);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Confidence != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Confidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Confidence != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BabelNetConceptInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Confidence != 0D) {
        Confidence = other.Confidence;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 25: {
            Confidence = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NerConceptInfo : pb::IMessage<NerConceptInfo> {
    private static readonly pb::MessageParser<NerConceptInfo> _parser = new pb::MessageParser<NerConceptInfo>(() => new NerConceptInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NerConceptInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V4Design.Protos.Taln.TEXTUALANALYSISCOMPLETEReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NerConceptInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NerConceptInfo(NerConceptInfo other) : this() {
      types_ = other.types_;
      simpleTypes_ = other.simpleTypes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NerConceptInfo Clone() {
      return new NerConceptInfo(this);
    }

    /// <summary>Field number for the "types" field.</summary>
    public const int Types_FieldNumber = 1;
    private string types_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Types_ {
      get { return types_; }
      set {
        types_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "simpleTypes" field.</summary>
    public const int SimpleTypesFieldNumber = 2;
    private string simpleTypes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SimpleTypes {
      get { return simpleTypes_; }
      set {
        simpleTypes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NerConceptInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NerConceptInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Types_ != other.Types_) return false;
      if (SimpleTypes != other.SimpleTypes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Types_.Length != 0) hash ^= Types_.GetHashCode();
      if (SimpleTypes.Length != 0) hash ^= SimpleTypes.GetHashCode();
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
      if (Types_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Types_);
      }
      if (SimpleTypes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SimpleTypes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Types_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Types_);
      }
      if (SimpleTypes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SimpleTypes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NerConceptInfo other) {
      if (other == null) {
        return;
      }
      if (other.Types_.Length != 0) {
        Types_ = other.Types_;
      }
      if (other.SimpleTypes.Length != 0) {
        SimpleTypes = other.SimpleTypes;
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
            Types_ = input.ReadString();
            break;
          }
          case 18: {
            SimpleTypes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
