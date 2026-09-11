using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class FlexibleMemberAllocator : ContentControl
{
	public static readonly DependencyProperty _SubscriberFinder;

	public static readonly DependencyProperty _MonoServerAllocator;

	public static readonly DependencyProperty _LogicalRequesterAllocator;

	public static readonly DependencyProperty allocatorDictionaryArgument;

	public static readonly DependencyProperty m_ReadableReporterAllocator;

	public static readonly DependencyProperty isolatedThreadAllocator;

	public static readonly DependencyProperty m_ExtendedGatewayAllocator;

	public static readonly DependencyProperty m_AllocatorCalculatorTemplate;

	public static readonly DependencyProperty remoteSorterAllocator;

	public static readonly DependencyProperty m_RandomAdapterAllocator;

	public static readonly DependencyProperty _TransactionSharer;

	public static readonly DependencyProperty m_DecoratorCollection;

	internal static FlexibleMemberAllocator ValidateDecider;

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

	public LocatorStateAction State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LocatorStateAction)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int IconSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
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

	public object IconSpinner
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

	public Visibility SpinnerVisiblity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Message
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

	public string CustomMessage
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

	public Visibility ProgressBarVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double ProgressBarValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Style TextBlockStyle
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

	public Style ProgressBarStyle
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
	private static void AssignDynamicAnnotation(DependencyObject info, DependencyPropertyChangedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FlexibleMemberAllocator()
	{
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0012;
							}
							goto case 6;
						}
						return;
					case 2:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 1;
						continue;
					case 0:
						_SubscriberFinder = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x594E2952 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60e044da66db4b08896730b7f82d59f6), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null));
						num3 = 4;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90aede27c2f4423c9363d0159f771eeb == 0)
						{
							num3 = 6;
						}
						continue;
					case 4:
						m_ReadableReporterAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8F6BBA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777246)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null));
						isolatedThreadAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360F449E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)(Visibility)2, new PropertyChangedCallback(AssignDynamicAnnotation)));
						m_ExtendedGatewayAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C46C6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null, new PropertyChangedCallback(AssignDynamicAnnotation)));
						m_AllocatorCalculatorTemplate = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x17CC61C1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null, new PropertyChangedCallback(AssignDynamicAnnotation)));
						remoteSorterAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3191ED66 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)(Visibility)2, new PropertyChangedCallback(AssignDynamicAnnotation)));
						num3 = 3;
						continue;
					case 6:
						_MonoServerAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x56472821 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556695)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)LocatorStateAction.Loading, new PropertyChangedCallback(AssignDynamicAnnotation)));
						_LogicalRequesterAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4EE5F0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777220)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)24));
						allocatorDictionaryArgument = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3169E1AC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777246)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null));
						num3 = 4;
						continue;
					case 5:
						m_DecoratorCollection = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5742D1F0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null, new PropertyChangedCallback(AssignDynamicAnnotation)));
						FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696))));
						num = 13;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed == 0)
						{
							num = 0;
						}
						break;
					case 1:
						WrapperStreamEditor.PresentConfiguration();
						WriterCommandResolver.ReflectDefinitionSelector();
						num3 = 0;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef == 0)
						{
							num3 = 2;
						}
						continue;
					case 3:
						m_RandomAdapterAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x21411F03 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777260)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)0.0, new PropertyChangedCallback(AssignDynamicAnnotation)));
						_TransactionSharer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--160250047 ^ 0x6BBE5874 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556696)), new PropertyMetadata((object)null, new PropertyChangedCallback(AssignDynamicAnnotation)));
						num = 5;
						break;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlexibleMemberAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableCollection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePortableRoleController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FlexibleMemberAllocator AwakeRequest()
	{
		return null;
	}
}
