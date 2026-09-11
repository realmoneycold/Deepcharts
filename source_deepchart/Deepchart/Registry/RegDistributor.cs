using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using VolAnalysis.IO;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal static class RegDistributor
{
	private static Dictionary<Window, Tuple<HotKeyCategoryEnum, Action<HotKeyActionEnum>>> m_BufferRegMap;

	private static Dictionary<HotKeyCategoryEnum, Dictionary<string, HotKeyActionEnum>> m_RegRegDic;

	private static List<Action<HotKeyActionEnum>> _EventStructList;

	private static TaskCompletionSource<Tuple<string, bool>> _FlexibleControllerDecider;

	private static RegDistributor UpdateEncryptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StoreControllableSpec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StoreRemoteSystem(Window def, HotKeyCategoryEnum vis, Action<HotKeyActionEnum> pool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Detach(Window sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveEfficientProfiler(int flags_def, bool tokenclose)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<Tuple<string, bool>> CreateManager()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadMember()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegDistributor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_bb3801db3d634a8f97973394c9549a6c == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					_EventStructList = new List<Action<HotKeyActionEnum>>();
					return;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					m_BufferRegMap = new Dictionary<Window, Tuple<HotKeyCategoryEnum, Action<HotKeyActionEnum>>>();
					num2 = 6;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fdb22fc15ab04efe9805fd33cda91e1c == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BuildChooser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegDistributor PresentFunction()
	{
		return null;
	}
}
