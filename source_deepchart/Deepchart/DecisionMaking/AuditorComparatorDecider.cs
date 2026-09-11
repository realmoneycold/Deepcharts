using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

[ProtoContract]
internal class AuditorComparatorDecider : IExtensible
{
	private IExtension _SegmentedDispatcherDecider;

	[CompilerGenerated]
	private long m_AlphabeticConnectionDeciderFreq;

	[CompilerGenerated]
	private bool _IsAttachedStackDecider;

	internal static AuditorComparatorDecider AttachVisibleIteratorPredicate;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long EnsureFilteredTree
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
	public bool CalcSchema
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool noi)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AuditorComparatorDecider()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuditorComparatorDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateSequentialPredicateExplorer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AuditorComparatorDecider GenerateTransformableExplorerSpec()
	{
		return null;
	}
}
