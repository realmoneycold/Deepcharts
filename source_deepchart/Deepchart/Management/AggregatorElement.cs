using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

[ProtoContract]
internal class AggregatorElement : IExtensible
{
	private IExtension _AllocatorRequestPredicate;

	[CompilerGenerated]
	private ScopeFilterWriter _CheckerWriter;

	[CompilerGenerated]
	private int adaptableVisitorAllocatorFreq;

	[CompilerGenerated]
	private SpecConfigurationWrapper _WorkerSingleton;

	internal static AggregatorElement CheckIterator;

	[ProtoMember(1)]
	public ScopeFilterWriter AssignScalableExplorer
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
	public int ReleaseLogicalProfiler
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

	[ProtoMember(101)]
	public SpecConfigurationWrapper AllocateSetRecord
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
	IExtension IExtensible.GetExtensionObject(bool comparevar1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AggregatorElement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AggregatorElement()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InstantiatePredicate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AggregatorElement GenerateTransformableProcIterator()
	{
		return null;
	}
}
