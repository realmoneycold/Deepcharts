using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using ProtoBuf;
using VolAnalysis.Creations;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

[ProtoContract]
internal class EditableWrapperReg : IExtensible, ITransformableExtractorLocator
{
	private IExtension m_AdaptableNotifier;

	[CompilerGenerated]
	private long regDispatcherMemberLength;

	[CompilerGenerated]
	private readonly List<DeciderEvaluatorExplorer> m_StreamStateList;

	[CompilerGenerated]
	private AllocatorSenderValidator configListener;

	[CompilerGenerated]
	private MixedInitializerLocator m_RegTransmitterMonitor;

	[CompilerGenerated]
	private StructTokenizerSingleton externalIteratorReg;

	internal static EditableWrapperReg GenerateAdaptableRegFormatter;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long RequestId
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

	[ProtoMember(2, Name = "quote")]
	public List<DeciderEvaluatorExplorer> ViewCalc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(3)]
	public AllocatorSenderValidator OpenDividedComparator
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

	[ProtoMember(4)]
	public MixedInitializerLocator OpenScalableHandler
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

	[ProtoMember(5)]
	public StructTokenizerSingleton SaveLogicalMonitor
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool requiresfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditableWrapperReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EditableWrapperReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachRandomFormatterGateway()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EditableWrapperReg AttachDynamicGatewayCompiler()
	{
		return null;
	}
}
