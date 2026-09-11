using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

internal class ComboBoxWithHeader : ComboBox
{
	public static readonly DependencyProperty _ChooserTask;

	public static readonly DependencyProperty _RemoteProfilerRequester;

	public static readonly DependencyProperty _RequesterTransmitterCache;

	public static readonly DependencyProperty _RequesterCacheSingleton;

	public static readonly DependencyProperty m_SingletonAuthorizerRequester;

	internal static ComboBoxWithHeader SimulateEditableCalcDic;

	public string HeaderText
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

	public SolidColorBrush HeaderForeground
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

	public Thickness HeaderMargin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Thickness)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Style ToggleButtonStyle
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

	public Thickness ContentMargin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Thickness)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ComboBoxWithHeader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComboBoxWithHeader()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						switch (num2)
						{
						case 990:
							break;
						case 9:
							goto IL_004e;
						default:
							goto end_IL_000e;
						}
						break;
					case 0:
						WriterCommandResolver.ReflectDefinitionSelector();
						_ChooserTask = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x703CE0EE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556678)), (PropertyMetadata)new FrameworkPropertyMetadata((object)""));
						_RemoteProfilerRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E4662FD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556678)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						_RequesterTransmitterCache = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE40CBC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777336)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556678)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new Thickness(0.0, 0.0, 2.0, 0.0)));
						num3 = 1;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a2fc660f0d7445079941fcd5037432e3 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						goto end_IL_000e;
					case 1:
						{
							_RequesterCacheSingleton = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x6D3DCF86 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556678)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
							m_SingletonAuthorizerRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4EE53C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777336)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556678)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new Thickness(0.0, 0.0, 2.0, 0.0)));
							return;
						}
						IL_004e:
						WrapperStreamEditor.PresentConfiguration();
						num3 = 0;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4 == 0)
						{
							num3 = 3;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			WrapperStreamEditor.CoverPortableElement();
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateIntegratedDicThread()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ComboBoxWithHeader GenerateStaticThreadMap()
	{
		return null;
	}
}
