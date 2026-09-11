using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class SingletonNodeProxy : ContentControl
{
	public static readonly DependencyProperty _CommonComparatorSingleton;

	public static readonly DependencyProperty m_AnalyzerMap;

	public static readonly DependencyProperty _SingletonProxyTransaction;

	private static SingletonNodeProxy SimulateAccessibleProfilerComparator;

	public SolidColorBrush IconBackground
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool Loading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public object Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonNodeProxy()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69 == 0)
		{
			num = 4;
		}
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				switch (num3)
				{
				case 989:
					break;
				default:
					return;
				case 9:
					_SingletonProxyTransaction = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71EE2663 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777246)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556724)), new PropertyMetadata((object)null));
					FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556724)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556724))));
					num = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c4b807f2d234a1db471f24a593fc425 == 0)
					{
						num = 5;
					}
					continue;
				}
				break;
			case 1:
			{
				WriterCommandResolver.ReflectDefinitionSelector();
				_CommonComparatorSingleton = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486E7522 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556724)), new PropertyMetadata((object)null));
				m_AnalyzerMap = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x17CC664F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556724)), new PropertyMetadata((object)false));
				int num2 = 5;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7 != 0)
				{
					num2 = 9;
				}
				num3 = num2;
				break;
			}
			case 0:
				return;
			}
			num = num3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonNodeProxy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePassiveComparatorStrategy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingletonNodeProxy PlayResponder()
	{
		return null;
	}
}
