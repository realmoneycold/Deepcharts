using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.Cryptography;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis;

[Serializable]
internal struct ToolConfiguration
{
	internal static object GenerateConnectedProvider;

	[Category("General")]
	[DisplayName("Line Width")]
	public int LineWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Line Color")]
	public Color LineColor
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

	[DisplayName("Line Style")]
	[Category("General")]
	public DashStyle LineStyle
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

	[Category("General")]
	[DisplayName("Background Opacity")]
	public int BackGroundOpacity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Background Color")]
	[Category("General")]
	public Color BackGroundColor
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

	[Category("General")]
	[DisplayName("Extended")]
	public bool IsExtended
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Second Line")]
	[DisplayName("Line Enable")]
	public bool LineEnabled2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Second Line")]
	[DisplayName("Line Width")]
	public int LineWidth2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Second Line")]
	[DisplayName("Line Color")]
	public Color LineColor2
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

	[Category("Second Line")]
	[DisplayName("Line Style")]
	public DashStyle LineStyle2
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

	[DisplayName("Font Size")]
	[Category("Text")]
	public float FontSize
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

	[Category("Text")]
	[DisplayName("Show Background")]
	public bool ShowLabelBack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Show Price")]
	[Category("Text")]
	public bool ShowPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Show Percent")]
	[Category("Text")]
	public bool ShowPercent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Show Difference")]
	[Category("Text")]
	public bool ShowDifference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Text align")]
	[Category("Text")]
	public LabelAlignEnum LabelAlign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return (LabelAlignEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Text")]
	[DisplayName("Text")]
	public string TextMsg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Text")]
	public Color TextColor
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

	[Category("Text")]
	[DisplayName("Text Padding")]
	public float TextPadding
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

	[DisplayName("Levels")]
	[Category("General")]
	public List<AnnotationParameters> AnnParam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
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
	public MixedWrapper Money
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public string TCName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool AlreadyStyled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public ScopeEncryptor.HiddenModelDecider paramVbp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public AnnotationType CurrAnnType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return (AnnotationType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AnnParamInit(object p_obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPropVisibleStatic(string PropName, AnnotationType p_AnnType)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetDefault(AnnotationType annType)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AnnotationParameters CreateParamLevel(double AnnCoeff)
	{
		return (AnnotationParameters)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPropFromUserAnn(RegInitializer UserAnn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUserAnnFromProp(RegInitializer UserAnn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetMinLineWidth(AnnotationType annType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPropVisible(string PropName)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object InitAnnParams(Type type)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToolConfiguration()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachExpandableParser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StopSelector()
	{
		return null;
	}
}
