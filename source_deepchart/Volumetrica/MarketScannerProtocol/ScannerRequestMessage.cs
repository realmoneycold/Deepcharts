using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Volumetrica.MarketScannerProtocol;

[Serializable]
internal class ScannerRequestMessage
{
	private static ScannerRequestMessage SimulateGenericProfilerComparator;

	public string Symbol
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

	public string Country
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

	public bool Subscribe
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
	public ScannerRequestMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScannerRequestMessage()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSimpleComparatorStrategy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScannerRequestMessage AttachDetailedStrategyRecord()
	{
		return null;
	}
}
