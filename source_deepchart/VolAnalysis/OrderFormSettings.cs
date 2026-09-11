using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using VolAnalysis.Wrapping;

namespace VolAnalysis;

[Serializable]
internal class OrderFormSettings : ICloneable
{
	private static OrderFormSettings GenerateSegmentedAdapter;

	[Category("General")]
	[DisplayName("Font Size")]
	public float FontSize
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
	public OrderFormSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFormSettings()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ConcatTransformer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OrderFormSettings GenerateControllableBuilder()
	{
		return null;
	}
}
