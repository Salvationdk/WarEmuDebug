// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace WarProtocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetCharSummaryListReplyProto {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_login_proto_GetCharSummaryListReply__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::WarProtocol.GetCharSummaryListReply, global::WarProtocol.GetCharSummaryListReply.Builder> internal__static_login_proto_GetCharSummaryListReply__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_login_proto_GetCharSummaryListReply_CharSummary__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary, global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.Builder> internal__static_login_proto_GetCharSummaryListReply_CharSummary__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static GetCharSummaryListReplyProto() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiF3YXIvR2V0Q2hhclN1bW1hcnlMaXN0UmVwbHkucHJvdG8SC2xvZ2luLnBy" + 
          "b3RvGiRnb29nbGUvcHJvdG9idWYvY3NoYXJwX29wdGlvbnMucHJvdG8iygQK" + 
          "F0dldENoYXJTdW1tYXJ5TGlzdFJlcGx5EkQKC3Jlc3VsdF9jb2RlGAEgAigO" + 
          "Mi8ubG9naW4ucHJvdG8uR2V0Q2hhclN1bW1hcnlMaXN0UmVwbHkuUmVzdWx0" + 
          "Q29kZRJGCgxzdW1tYXJ5X2xpc3QYAiADKAsyMC5sb2dpbi5wcm90by5HZXRD" + 
          "aGFyU3VtbWFyeUxpc3RSZXBseS5DaGFyU3VtbWFyeRpiCgtDaGFyU3VtbWFy" + 
          "eRIRCglzZXJ2ZXJfaWQYASACKA0SFAoMY2hhcmFjdGVyX2lkGAIgAigNEhgK" + 
          "EGxhc3RfcGxheWVkX3RpbWUYAyACKAMSEAoIeG1sX2RhdGEYBCABKAkivAIK" + 
          "ClJlc3VsdENvZGUSDwoLUkVTX1NVQ0NFU1MQABIcChhSRVNfUFJPVE9DT0xf" + 
          "VU5TVVBQT1JURUQQARIbChdSRVNfUFJPRFVDVF9VTlNVUFBPUlRFRBACEhsK" + 
          "F1JFU19BQ0NPVU5UX0FVVEhfRkFJTEVEEAMSGgoWUkVTX0FDQ09VTlRfVEVS" + 
          "TUlOQVRFRBAEEhcKE1JFU19BQ0NPVU5UX0VYUElSRUQQBRIZChVSRVNfQUND" + 
          "T1VOVF9TVVNQRU5ERUQQBhIlCiFSRVNfQUNDT1VOVF9TRUNPTkRBUllfQVVU" + 
          "SF9ORUVERUQQBxIeChpSRVNfQUNDT1VOVF9BTFJFQURZX09OTElORRAIEhQK" + 
          "EFJFU19TWVNURU1fRVJST1IQCRIYChRSRVNfRU5DUllQVElPTl9FUlJPUhAK" + 
          "QizCPikKCUZyYW1lV29yaxIcR2V0Q2hhclN1bW1hcnlMaXN0UmVwbHlQcm90" + 
          "bw==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_login_proto_GetCharSummaryListReply__Descriptor = Descriptor.MessageTypes[0];
        internal__static_login_proto_GetCharSummaryListReply__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::WarProtocol.GetCharSummaryListReply, global::WarProtocol.GetCharSummaryListReply.Builder>(internal__static_login_proto_GetCharSummaryListReply__Descriptor,
                new string[] { "ResultCode", "SummaryList", });
        internal__static_login_proto_GetCharSummaryListReply_CharSummary__Descriptor = internal__static_login_proto_GetCharSummaryListReply__Descriptor.NestedTypes[0];
        internal__static_login_proto_GetCharSummaryListReply_CharSummary__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary, global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.Builder>(internal__static_login_proto_GetCharSummaryListReply_CharSummary__Descriptor,
                new string[] { "ServerId", "CharacterId", "LastPlayedTime", "XmlData", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetCharSummaryListReply : pb::GeneratedMessage<GetCharSummaryListReply, GetCharSummaryListReply.Builder> {
    private GetCharSummaryListReply() { }
    private static readonly GetCharSummaryListReply defaultInstance = new GetCharSummaryListReply().MakeReadOnly();
    private static readonly string[] _getCharSummaryListReplyFieldNames = new string[] { "result_code", "summary_list" };
    private static readonly uint[] _getCharSummaryListReplyFieldTags = new uint[] { 8, 18 };
    public static GetCharSummaryListReply DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override GetCharSummaryListReply DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override GetCharSummaryListReply ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::WarProtocol.GetCharSummaryListReplyProto.internal__static_login_proto_GetCharSummaryListReply__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<GetCharSummaryListReply, GetCharSummaryListReply.Builder> InternalFieldAccessors {
      get { return global::WarProtocol.GetCharSummaryListReplyProto.internal__static_login_proto_GetCharSummaryListReply__FieldAccessorTable; }
    }
    
    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum ResultCode {
        RES_SUCCESS = 0,
        RES_PROTOCOL_UNSUPPORTED = 1,
        RES_PRODUCT_UNSUPPORTED = 2,
        RES_ACCOUNT_AUTH_FAILED = 3,
        RES_ACCOUNT_TERMINATED = 4,
        RES_ACCOUNT_EXPIRED = 5,
        RES_ACCOUNT_SUSPENDED = 6,
        RES_ACCOUNT_SECONDARY_AUTH_NEEDED = 7,
        RES_ACCOUNT_ALREADY_ONLINE = 8,
        RES_SYSTEM_ERROR = 9,
        RES_ENCRYPTION_ERROR = 10,
      }
      
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class CharSummary : pb::GeneratedMessage<CharSummary, CharSummary.Builder> {
        private CharSummary() { }
        private static readonly CharSummary defaultInstance = new CharSummary().MakeReadOnly();
        private static readonly string[] _charSummaryFieldNames = new string[] { "character_id", "last_played_time", "server_id", "xml_data" };
        private static readonly uint[] _charSummaryFieldTags = new uint[] { 16, 24, 8, 34 };
        public static CharSummary DefaultInstance {
          get { return defaultInstance; }
        }
        
        public override CharSummary DefaultInstanceForType {
          get { return DefaultInstance; }
        }
        
        protected override CharSummary ThisMessage {
          get { return this; }
        }
        
        public static pbd::MessageDescriptor Descriptor {
          get { return global::WarProtocol.GetCharSummaryListReplyProto.internal__static_login_proto_GetCharSummaryListReply_CharSummary__Descriptor; }
        }
        
        protected override pb::FieldAccess.FieldAccessorTable<CharSummary, CharSummary.Builder> InternalFieldAccessors {
          get { return global::WarProtocol.GetCharSummaryListReplyProto.internal__static_login_proto_GetCharSummaryListReply_CharSummary__FieldAccessorTable; }
        }
        
        public const int ServerIdFieldNumber = 1;
        private bool hasServerId;
        private uint serverId_;
        public bool HasServerId {
          get { return hasServerId; }
        }
        [global::System.CLSCompliant(false)]
        public uint ServerId {
          get { return serverId_; }
        }
        
        public const int CharacterIdFieldNumber = 2;
        private bool hasCharacterId;
        private uint characterId_;
        public bool HasCharacterId {
          get { return hasCharacterId; }
        }
        [global::System.CLSCompliant(false)]
        public uint CharacterId {
          get { return characterId_; }
        }
        
        public const int LastPlayedTimeFieldNumber = 3;
        private bool hasLastPlayedTime;
        private long lastPlayedTime_;
        public bool HasLastPlayedTime {
          get { return hasLastPlayedTime; }
        }
        public long LastPlayedTime {
          get { return lastPlayedTime_; }
        }
        
        public const int XmlDataFieldNumber = 4;
        private bool hasXmlData;
        private string xmlData_ = "";
        public bool HasXmlData {
          get { return hasXmlData; }
        }
        public string XmlData {
          get { return xmlData_; }
        }
        
        public override bool IsInitialized {
          get {
            if (!hasServerId) return false;
            if (!hasCharacterId) return false;
            if (!hasLastPlayedTime) return false;
            return true;
          }
        }
        
        public override void WriteTo(pb::ICodedOutputStream output) {
          int size = SerializedSize;
          string[] field_names = _charSummaryFieldNames;
          if (hasServerId) {
            output.WriteUInt32(1, field_names[2], ServerId);
          }
          if (hasCharacterId) {
            output.WriteUInt32(2, field_names[0], CharacterId);
          }
          if (hasLastPlayedTime) {
            output.WriteInt64(3, field_names[1], LastPlayedTime);
          }
          if (hasXmlData) {
            output.WriteString(4, field_names[3], XmlData);
          }
          UnknownFields.WriteTo(output);
        }
        
        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (hasServerId) {
              size += pb::CodedOutputStream.ComputeUInt32Size(1, ServerId);
            }
            if (hasCharacterId) {
              size += pb::CodedOutputStream.ComputeUInt32Size(2, CharacterId);
            }
            if (hasLastPlayedTime) {
              size += pb::CodedOutputStream.ComputeInt64Size(3, LastPlayedTime);
            }
            if (hasXmlData) {
              size += pb::CodedOutputStream.ComputeStringSize(4, XmlData);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }
        
        public static CharSummary ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static CharSummary ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static CharSummary ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static CharSummary ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static CharSummary ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static CharSummary ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static CharSummary ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static CharSummary ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static CharSummary ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static CharSummary ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private CharSummary MakeReadOnly() {
          return this;
        }
        
        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(CharSummary prototype) {
          return new Builder(prototype);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class Builder : pb::GeneratedBuilder<CharSummary, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(CharSummary cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }
          
          private bool resultIsReadOnly;
          private CharSummary result;
          
          private CharSummary PrepareBuilder() {
            if (resultIsReadOnly) {
              CharSummary original = result;
              result = new CharSummary();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }
          
          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }
          
          protected override CharSummary MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }
          
          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }
          
          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }
          
          public override pbd::MessageDescriptor DescriptorForType {
            get { return global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.Descriptor; }
          }
          
          public override CharSummary DefaultInstanceForType {
            get { return global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.DefaultInstance; }
          }
          
          public override CharSummary BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }
          
          public override Builder MergeFrom(pb::IMessage other) {
            if (other is CharSummary) {
              return MergeFrom((CharSummary) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }
          
          public override Builder MergeFrom(CharSummary other) {
            if (other == global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasServerId) {
              ServerId = other.ServerId;
            }
            if (other.HasCharacterId) {
              CharacterId = other.CharacterId;
            }
            if (other.HasLastPlayedTime) {
              LastPlayedTime = other.LastPlayedTime;
            }
            if (other.HasXmlData) {
              XmlData = other.XmlData;
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }
          
          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }
          
          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            pb::UnknownFieldSet.Builder unknownFields = null;
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_charSummaryFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _charSummaryFieldTags[field_ordinal];
                else {
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    if (unknownFields != null) {
                      this.UnknownFields = unknownFields.Build();
                    }
                    return this;
                  }
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasServerId = input.ReadUInt32(ref result.serverId_);
                  break;
                }
                case 16: {
                  result.hasCharacterId = input.ReadUInt32(ref result.characterId_);
                  break;
                }
                case 24: {
                  result.hasLastPlayedTime = input.ReadInt64(ref result.lastPlayedTime_);
                  break;
                }
                case 34: {
                  result.hasXmlData = input.ReadString(ref result.xmlData_);
                  break;
                }
              }
            }
            
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }
          
          
          public bool HasServerId {
            get { return result.hasServerId; }
          }
          [global::System.CLSCompliant(false)]
          public uint ServerId {
            get { return result.ServerId; }
            set { SetServerId(value); }
          }
          [global::System.CLSCompliant(false)]
          public Builder SetServerId(uint value) {
            PrepareBuilder();
            result.hasServerId = true;
            result.serverId_ = value;
            return this;
          }
          public Builder ClearServerId() {
            PrepareBuilder();
            result.hasServerId = false;
            result.serverId_ = 0;
            return this;
          }
          
          public bool HasCharacterId {
            get { return result.hasCharacterId; }
          }
          [global::System.CLSCompliant(false)]
          public uint CharacterId {
            get { return result.CharacterId; }
            set { SetCharacterId(value); }
          }
          [global::System.CLSCompliant(false)]
          public Builder SetCharacterId(uint value) {
            PrepareBuilder();
            result.hasCharacterId = true;
            result.characterId_ = value;
            return this;
          }
          public Builder ClearCharacterId() {
            PrepareBuilder();
            result.hasCharacterId = false;
            result.characterId_ = 0;
            return this;
          }
          
          public bool HasLastPlayedTime {
            get { return result.hasLastPlayedTime; }
          }
          public long LastPlayedTime {
            get { return result.LastPlayedTime; }
            set { SetLastPlayedTime(value); }
          }
          public Builder SetLastPlayedTime(long value) {
            PrepareBuilder();
            result.hasLastPlayedTime = true;
            result.lastPlayedTime_ = value;
            return this;
          }
          public Builder ClearLastPlayedTime() {
            PrepareBuilder();
            result.hasLastPlayedTime = false;
            result.lastPlayedTime_ = 0L;
            return this;
          }
          
          public bool HasXmlData {
            get { return result.hasXmlData; }
          }
          public string XmlData {
            get { return result.XmlData; }
            set { SetXmlData(value); }
          }
          public Builder SetXmlData(string value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.hasXmlData = true;
            result.xmlData_ = value;
            return this;
          }
          public Builder ClearXmlData() {
            PrepareBuilder();
            result.hasXmlData = false;
            result.xmlData_ = "";
            return this;
          }
        }
        static CharSummary() {
          object.ReferenceEquals(global::WarProtocol.GetCharSummaryListReplyProto.Descriptor, null);
        }
      }
      
    }
    #endregion
    
    public const int ResultCodeFieldNumber = 1;
    private bool hasResultCode;
    private global::WarProtocol.GetCharSummaryListReply.Types.ResultCode resultCode_ = global::WarProtocol.GetCharSummaryListReply.Types.ResultCode.RES_SUCCESS;
    public bool HasResultCode {
      get { return hasResultCode; }
    }
    public global::WarProtocol.GetCharSummaryListReply.Types.ResultCode ResultCode {
      get { return resultCode_; }
    }
    
    public const int SummaryListFieldNumber = 2;
    private pbc::PopsicleList<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary> summaryList_ = new pbc::PopsicleList<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary>();
    public scg::IList<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary> SummaryListList {
      get { return summaryList_; }
    }
    public int SummaryListCount {
      get { return summaryList_.Count; }
    }
    public global::WarProtocol.GetCharSummaryListReply.Types.CharSummary GetSummaryList(int index) {
      return summaryList_[index];
    }
    
    public override bool IsInitialized {
      get {
        if (!hasResultCode) return false;
        foreach (global::WarProtocol.GetCharSummaryListReply.Types.CharSummary element in SummaryListList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _getCharSummaryListReplyFieldNames;
      if (hasResultCode) {
        output.WriteEnum(1, field_names[0], (int) ResultCode, ResultCode);
      }
      if (summaryList_.Count > 0) {
        output.WriteMessageArray(2, field_names[1], summaryList_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasResultCode) {
          size += pb::CodedOutputStream.ComputeEnumSize(1, (int) ResultCode);
        }
        foreach (global::WarProtocol.GetCharSummaryListReply.Types.CharSummary element in SummaryListList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static GetCharSummaryListReply ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static GetCharSummaryListReply ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static GetCharSummaryListReply ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private GetCharSummaryListReply MakeReadOnly() {
      summaryList_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(GetCharSummaryListReply prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<GetCharSummaryListReply, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(GetCharSummaryListReply cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private GetCharSummaryListReply result;
      
      private GetCharSummaryListReply PrepareBuilder() {
        if (resultIsReadOnly) {
          GetCharSummaryListReply original = result;
          result = new GetCharSummaryListReply();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override GetCharSummaryListReply MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::WarProtocol.GetCharSummaryListReply.Descriptor; }
      }
      
      public override GetCharSummaryListReply DefaultInstanceForType {
        get { return global::WarProtocol.GetCharSummaryListReply.DefaultInstance; }
      }
      
      public override GetCharSummaryListReply BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is GetCharSummaryListReply) {
          return MergeFrom((GetCharSummaryListReply) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(GetCharSummaryListReply other) {
        if (other == global::WarProtocol.GetCharSummaryListReply.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasResultCode) {
          ResultCode = other.ResultCode;
        }
        if (other.summaryList_.Count != 0) {
          result.summaryList_.Add(other.summaryList_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_getCharSummaryListReplyFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _getCharSummaryListReplyFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              object unknown;
              if(input.ReadEnum(ref result.resultCode_, out unknown)) {
                result.hasResultCode = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(1, (ulong)(int)unknown);
              }
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.summaryList_, global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasResultCode {
       get { return result.hasResultCode; }
      }
      public global::WarProtocol.GetCharSummaryListReply.Types.ResultCode ResultCode {
        get { return result.ResultCode; }
        set { SetResultCode(value); }
      }
      public Builder SetResultCode(global::WarProtocol.GetCharSummaryListReply.Types.ResultCode value) {
        PrepareBuilder();
        result.hasResultCode = true;
        result.resultCode_ = value;
        return this;
      }
      public Builder ClearResultCode() {
        PrepareBuilder();
        result.hasResultCode = false;
        result.resultCode_ = global::WarProtocol.GetCharSummaryListReply.Types.ResultCode.RES_SUCCESS;
        return this;
      }
      
      public pbc::IPopsicleList<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary> SummaryListList {
        get { return PrepareBuilder().summaryList_; }
      }
      public int SummaryListCount {
        get { return result.SummaryListCount; }
      }
      public global::WarProtocol.GetCharSummaryListReply.Types.CharSummary GetSummaryList(int index) {
        return result.GetSummaryList(index);
      }
      public Builder SetSummaryList(int index, global::WarProtocol.GetCharSummaryListReply.Types.CharSummary value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.summaryList_[index] = value;
        return this;
      }
      public Builder SetSummaryList(int index, global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.summaryList_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddSummaryList(global::WarProtocol.GetCharSummaryListReply.Types.CharSummary value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.summaryList_.Add(value);
        return this;
      }
      public Builder AddSummaryList(global::WarProtocol.GetCharSummaryListReply.Types.CharSummary.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.summaryList_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeSummaryList(scg::IEnumerable<global::WarProtocol.GetCharSummaryListReply.Types.CharSummary> values) {
        PrepareBuilder();
        result.summaryList_.Add(values);
        return this;
      }
      public Builder ClearSummaryList() {
        PrepareBuilder();
        result.summaryList_.Clear();
        return this;
      }
    }
    static GetCharSummaryListReply() {
      object.ReferenceEquals(global::WarProtocol.GetCharSummaryListReplyProto.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
