using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.IO;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal static class RegTag
{
	public static Dictionary<DateTime, List<CalendarEvent>> m_RegPredictorDic;

	public static HashSet<string> _ResponsiveProject;

	internal static RegTag SetupInterpreter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenIterableElement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegTag()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_05612105f1db49a08e439ba411a54369 != 0)
		{
			num = 6;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 989)
				{
					num = num2;
					break;
				}
				return;
			case 1:
				return;
			case 0:
				WriterCommandResolver.ReflectDefinitionSelector();
				m_RegPredictorDic = new Dictionary<DateTime, List<CalendarEvent>>();
				_ResponsiveProject = new HashSet<string>();
				num = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659 == 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StoreQueue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegTag GenerateEfficientBuilder()
	{
		return null;
	}
}
