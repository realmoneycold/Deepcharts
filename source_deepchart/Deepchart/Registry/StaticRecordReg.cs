using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Deepchart.DecisionMaking;
using VolAnalysis.Drivers;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class StaticRecordReg : ContentControl
{
	public static readonly DependencyProperty m_ValidatorTracerReg;

	public static readonly DependencyProperty m_ProgramStrategy;

	public static readonly DependencyProperty m_TransformableParameter;

	public static readonly DependencyProperty _ConnectedMatcher;

	public static readonly DependencyProperty _AutomatedSolverReg;

	public static readonly DependencyProperty filterProfile;

	public static readonly DependencyProperty alphabeticSystem;

	public static readonly DependencyProperty m_StatelessAuditorReg;

	public static readonly DependencyProperty predicateStruct;

	public static readonly DependencyProperty m_RegTracerTracker;

	public static readonly DependencyProperty m_TrackerReceiverReg;

	public static readonly DependencyProperty m_SimpleVisitorReg;

	public static readonly DependencyProperty m_RegReceiverRunner;

	public static readonly DependencyProperty dynamicListReg;

	public static readonly DependencyProperty regRunnerDistributor;

	public static readonly DependencyProperty m_GeneralSorter;

	public static readonly DependencyProperty m_PoolDecorator;

	public static readonly DependencyProperty m_VisibleFinalizerReg;

	private static StaticRecordReg TestCollection;

	public Orientation Orientation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Orientation)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength ColumnWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength RowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Thickness ChildrenMargin
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

	public bool OpenQtyVisible
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

	public bool OpenPriceVisible
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

	public bool OpenPLVisible
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

	public bool DailyPLVisible
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

	public bool BalanceVisible
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

	public bool EquityVisible
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

	public string OpenQtyHeader
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

	public string OpenPriceHeader
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

	public string OpenPLHeader
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

	public string DailyPLHeader
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

	public string BalanceHeader
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

	public string EquityHeader
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

	public RandomWrapperValues OpenPlDisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (RandomWrapperValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public DriverBuildControllerUpdate DailyPlDisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (DriverBuildControllerUpdate)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StaticRecordReg()
	{
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 3;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b == 0)
		{
			num = 3;
		}
		int num2 = default(int);
		while (true)
		{
			int num3;
			switch (num)
			{
			default:
				if (num2 != 15)
				{
					if (num2 == 995)
					{
						goto IL_0013;
					}
					goto case 5;
				}
				m_PoolDecorator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3FC3DE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555168)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)RandomWrapperValues.Money));
				m_VisibleFinalizerReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FACE61 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555167)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)DriverBuildControllerUpdate.Money));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923))));
				num = 2;
				break;
			case 5:
				m_StatelessAuditorReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F481E19 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)true));
				num = 4;
				break;
			case 4:
				predicateStruct = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F517629 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)false));
				m_RegTracerTracker = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x72711D9D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)false));
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a2fc660f0d7445079941fcd5037432e3 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				m_TrackerReceiverReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x72711DBF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				m_SimpleVisitorReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x46C216E0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				m_RegReceiverRunner = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6A772A98 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				dynamicListReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699B65A5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				regRunnerDistributor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x31918E14 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				m_GeneralSorter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319DCDA9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)null));
				num3 = 15;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707 == 0)
				{
					num3 = 5;
				}
				goto IL_000f;
			case 2:
				return;
			case 1:
				_AutomatedSolverReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x786407E6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_bb3801db3d634a8f97973394c9549a6c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)true));
				filterProfile = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319DCF71 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)true));
				alphabeticSystem = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x46C2159A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)true));
				num3 = 5;
				goto IL_000f;
			case 6:
				_ConnectedMatcher = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6A7729B8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777336)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)new Thickness(0.0)));
				num = 3;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				m_ProgramStrategy = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF01A0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)new GridLength(1.0, (GridUnitType)2)));
				m_TransformableParameter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E922479 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)new GridLength(1.0, (GridUnitType)0)));
				num = 6;
				break;
			case 3:
				{
					m_ValidatorTracerReg = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE76ECA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777586)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555923)), new PropertyMetadata((object)(Orientation)1));
					num = 7;
					break;
				}
				IL_0013:
				num = num2;
				break;
				IL_000f:
				num2 = num3;
				goto IL_0013;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StaticRecordReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateFlexibleSetServer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StaticRecordReg AttachEditableServerModule()
	{
		return null;
	}
}
