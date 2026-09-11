using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;

namespace VolAnalysis.Wrapping;

[ProtoContract]
internal class SpecConfigurationWrapper : IExtensible
{
	[ProtoContract]
	internal enum LoggerConfig
	{
		Tick,
		Minute
	}

	[ProtoContract]
	internal enum RegSchemaBlockType
	{

	}

	private IExtension m_AccessibleReceiverWrapper;

	[CompilerGenerated]
	private long m_EditorRequestFlag;

	[CompilerGenerated]
	private string _SeparatedAdapterWrapperTitle;

	[CompilerGenerated]
	private long wrapperConfigurationTaskPerc;

	[CompilerGenerated]
	private long wrapperTaskReporterCnt;

	[CompilerGenerated]
	private LoggerConfig m_WrapperReporterCollection;

	[CompilerGenerated]
	private RegSchemaBlockType wrapperCollectionPublisher;

	[CompilerGenerated]
	private string groupedModelStr;

	[CompilerGenerated]
	private string configurableVerifierWrapperStr;

	[CompilerGenerated]
	private string _WrapperPublisherSchemaID;

	[CompilerGenerated]
	private int m_WrapperSchemaReceiverErrorCode;

	private static SpecConfigurationWrapper GenerateCommonConsumerTemplate;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long JoinTag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(2)]
	[DefaultValue("")]
	public string ContractName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long CoverStaticAuditor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long RunJoinedAnnotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(5)]
	public LoggerConfig CoverExpandableEngine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LoggerConfig)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(6)]
	public RegSchemaBlockType StartRole
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegSchemaBlockType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DefaultValue("")]
	[ProtoMember(7)]
	public string PredictAdjustableDecorator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DefaultValue("")]
	[ProtoMember(8)]
	public string EncapsulateHiddenFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DefaultValue("")]
	[ProtoMember(9)]
	public string RevertConfigurablePolicy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool lastneeded)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecConfigurationWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecConfigurationWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateControllableTemplateTag()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SpecConfigurationWrapper AttachRemoteTagChecker()
	{
		return null;
	}
}
