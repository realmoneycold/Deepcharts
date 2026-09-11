using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using VolAnalysis.Wrapping;

namespace VolAnalysis;

[Serializable]
internal class PortfolioSettings : ICloneable
{
	private static PortfolioSettings SimulateLiteralMember;

	[Category("General")]
	[DisplayName("Text Size")]
	public float TextSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool AlwaysOnTop
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
	public object Clone()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PortfolioSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PortfolioSettings()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QueryObserver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PortfolioSettings GenerateDetachedSender()
	{
		return null;
	}
}
