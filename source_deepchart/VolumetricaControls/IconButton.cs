using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

internal class IconButton : Button
{
	public static readonly DependencyProperty sequentialElement;

	public static readonly DependencyProperty simpleInitializerAllocator;

	public static readonly DependencyProperty m_AllocatorRoleCompressor;

	public static readonly DependencyProperty m_AllocatorArgumentField;

	public static readonly DependencyProperty _GeneralTaskAllocator;

	public static readonly DependencyProperty m_PublisherDecryptor;

	public static readonly DependencyProperty chainReporter;

	public static readonly DependencyProperty m_AllocatorTemplateMonitor;

	public static readonly DependencyProperty _AdapterStream;

	public static readonly DependencyProperty transactionProcessor;

	public static readonly DependencyProperty _DetachedMatcher;

	public static readonly DependencyProperty _SegmentedContainerAllocator;

	public static readonly DependencyProperty m_SortedProfileAllocator;

	public static readonly DependencyProperty m_AdapterDefinition;

	public static readonly DependencyProperty _CompressorParserAllocator;

	public static readonly DependencyProperty _StubList;

	public static readonly DependencyProperty m_ElementTransformer;

	public static readonly DependencyProperty setListAllocator;

	internal static IconButton CalcChain;

	public CornerRadius CornerRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (CornerRadius)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public SolidColorBrush BackgroundChecked
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

	public SolidColorBrush ForegroundChecked
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

	public EditableElementLocator IconChecked
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

	public SolidColorBrush IconBackgroundChecked
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

	public EditableElementLocator Icon
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

	public bool IconShowOnRight
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

	public Thickness IconMargin
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

	public Brush MouseOverBackground
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

	public Brush MouseOverBorderBrush
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

	public Brush MouseOverForeground
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

	public bool MouseOverForegroundHasValue
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

	public Brush MousePressedBackground
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

	public Brush MousePressedBorderBrush
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

	public Brush MousePressedForeground
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

	public bool IsChecked
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IconButton()
	{
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		sequentialElement = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8D3E74 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new CornerRadius(0.0, 0.0, 0.0, 0.0)));
		int num = 7;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_42fbc1ba04824a6bbb0b9900cd13a5de == 0)
		{
			num = 7;
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
					goto case 2;
				}
				setListAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AC7E7E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
				num = 3;
				break;
			case 0:
				_GeneralTaskAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E915809 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_PublisherDecryptor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x17CC7E11 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				chainReporter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B98EB79 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_AllocatorTemplateMonitor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3192EF40 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777220)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)16));
				_AdapterStream = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E91583B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
				transactionProcessor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9B071 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777336)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new Thickness(0.0, 0.0, 0.0, 0.0)));
				_DetachedMatcher = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29C97D4A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				_SegmentedContainerAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE8B28F5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0 == 0)
				{
					num = 12;
				}
				break;
			case 7:
				simpleInitializerAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x530D53B0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0bc27ac9f2bd46bca41590fe99075f1a), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num3 = 4;
				goto IL_000f;
			case 4:
				m_AllocatorRoleCompressor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9B1E1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_AllocatorArgumentField = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29C97CC8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ccd483989b5e477dadf241757c38ebb6 == 0)
				{
					num = 5;
				}
				break;
			case 5:
				return;
			case 3:
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697))));
				num = 5;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f7153e12738d421a9f1c8d1ce74c74b0 != 0)
				{
					num = 7;
				}
				break;
			case 2:
				_CompressorParserAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F4B6227 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				_StubList = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AD766F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_ElementTransformer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE41102 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num3 = 15;
				goto IL_000f;
			case 6:
				m_AdapterDefinition = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F5209E9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((object)true));
				num = 2;
				break;
			case 1:
				{
					m_SortedProfileAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x62336147 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556697)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
					num = 6;
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
	public IconButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AddOrder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IconButton AssessListener()
	{
		return null;
	}
}
