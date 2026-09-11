using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.Registry;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis;

[Serializable]
internal class ToolAllConfig
{
	private static AnnotationType[] UserAnnAvaiable;

	private static ToolAllConfig VisitProcessor;

	public List<List<ToolConfiguration>> ToolConfig
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

	public bool IsNewVersion
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
	public void FillList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefaultUserAnnProp(RegInitializer userAnn)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ToolConfiguration> GetToolConfigsForAnnType(AnnotationType annType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolConfiguration GetOrCreateToolConfig(AnnotationType annType, string tcName)
	{
		return (ToolConfiguration)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetToolConfig(AnnotationType annType, int tcIndex, out ToolConfiguration? tcFound)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolAllConfig()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToolAllConfig()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803 != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		UserAnnAvaiable = new AnnotationType[17]
		{
			AnnotationType.Line,
			AnnotationType.Rectangle,
			AnnotationType.ParallelLines,
			AnnotationType.PriceProjection,
			AnnotationType.PriceRetracement,
			AnnotationType.PriceFan,
			AnnotationType.HorizontalLine,
			AnnotationType.VerticalLine,
			AnnotationType.VbpProfile,
			AnnotationType.Text,
			AnnotationType.HorizontalRay,
			AnnotationType.PosCalculator,
			AnnotationType.VWAPAnchored,
			AnnotationType.Ellipse,
			AnnotationType.Pencil,
			AnnotationType.RulerLine,
			AnnotationType.Pitchfork
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateJoinedLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ToolAllConfig GenerateConvertibleVerifier()
	{
		return null;
	}
}
