using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Xml.Serialization;
using Deepchart.Management;
using VolAnalysis.Wrapping;

namespace VolumetricaAPI.Chart;

[Serializable]
internal struct AnnotationParameters
{
	internal static object SimulateConnectedMapTask;

	[Category("General")]
	[DisplayName("% Level")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MinValue = -10000.0, MaxValue = 10000.0, IncrementValue = 25.0, DecimalPosToShow = 2)]
	public double AnnCoeff
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[XmlElement(Type = typeof(XmlColorChart))]
	[Category("General")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[Category("General")]
	public float LineWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Line Style")]
	[Category("General")]
	public DashStyle LStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnnotationParameters Clone()
	{
		return (AnnotationParameters)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationParameters()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachExpandableTaskBridge()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GenerateAutomatableBridgeDispatcher()
	{
		return null;
	}
}
