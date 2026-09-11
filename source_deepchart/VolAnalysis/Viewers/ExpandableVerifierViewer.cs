using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Management;
using ProtoBuf;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

[ProtoContract]
internal class ExpandableVerifierViewer : IExtensible, ITransformableExtractorLocator
{
	private IExtension _EvaluatorExplorer;

	[CompilerGenerated]
	private long m_SingletonSolverViewerLevel;

	[CompilerGenerated]
	private GeneratorProfilerPublisher genericQueueViewer;

	[CompilerGenerated]
	private ViewerListenerPool _ViewerSolverListener;

	[CompilerGenerated]
	private LiteralStubAllocator m_IdentifiableStrategyViewer;

	internal static ExpandableVerifierViewer GenerateSortedTransmitterProc;

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

	[ProtoMember(2)]
	public GeneratorProfilerPublisher CloseOperationalAuditor
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

	[ProtoMember(3)]
	public ViewerListenerPool ChangeGateway
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
	public LiteralStubAllocator FillSorter
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
	IExtension IExtensible.GetExtensionObject(bool usedef)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExpandableVerifierViewer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpandableVerifierViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FindFunction()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExpandableVerifierViewer IncludeReceiver()
	{
		return null;
	}
}
