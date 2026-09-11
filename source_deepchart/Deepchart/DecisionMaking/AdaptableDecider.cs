using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class AdaptableDecider
{
	[CompilerGenerated]
	private string deciderTokenizerTxt;

	[CompilerGenerated]
	private decimal expandableDecider;

	[CompilerGenerated]
	private decimal _CustomObserver;

	[CompilerGenerated]
	private int groupedDeciderInterval;

	internal static AdaptableDecider ValidateChecker;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public string Name
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

	[Category("General")]
	[DisplayName("Default Quantity")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0, MaxValue = 2147483647.0)]
	public decimal DefQty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Increment Quantity")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 1.0, MaxValue = 2147483647.0)]
	[Category("General")]
	public decimal IncrQty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("BidAsk Tick Diff.")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MinValue = 0.0, MaxValue = 2147483647.0)]
	public int BidAskTickDiff
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
	public AdaptableDecider()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdaptableDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateInterruptibleCompressor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AdaptableDecider AttachIterableDriver()
	{
		return null;
	}
}
