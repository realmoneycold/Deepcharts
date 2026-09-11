using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;
using VolumetricaProtcol.Shared;

namespace Deepchart.Management;

[ProtoContract]
internal class AllocatorChainRecommender : IExtensible
{
	[ProtoContract]
	internal enum BuildVerbosity
	{
		Ticks,
		Price
	}

	private IExtension _ScalableBuilderAllocator;

	[CompilerGenerated]
	private BuildVerbosity segmentedNode;

	[CompilerGenerated]
	private Decimal customizableClientAllocator;

	[CompilerGenerated]
	private int _PredicateCalcAllocatorCnt;

	[CompilerGenerated]
	private double logicalError;

	internal static AllocatorChainRecommender SimulateLogicalTransactionError;

	[ProtoMember(1)]
	public BuildVerbosity ReleaseSequentialState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (BuildVerbosity)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(2)]
	public Decimal Quantity
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
	public int StartController
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

	[ProtoMember(4)]
	public double Price
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool isfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorChainRecommender()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorChainRecommender()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MatchVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorChainRecommender PrepareDecryptor()
	{
		return null;
	}
}
