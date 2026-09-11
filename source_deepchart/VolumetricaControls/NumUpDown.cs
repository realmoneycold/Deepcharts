using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

internal class NumUpDown : UserControl, IComponentConnector
{
	public static readonly DependencyProperty _ElementMap;

	public static readonly DependencyProperty requesterStrategyDecider;

	public static readonly DependencyProperty m_ConvertibleAuditor;

	public static readonly DependencyProperty _ResponderSynchronizer;

	public static readonly DependencyProperty _TrackerSchema;

	public static readonly DependencyProperty m_VirtualNode;

	public static readonly DependencyProperty requesterDeciderResponder;

	public static readonly DependencyProperty m_RequesterResponderServer;

	protected static readonly RoutedEvent scalableAnalyzerRequester;

	public static readonly DependencyProperty m_ReadableTransactionRequester;

	public static readonly DependencyProperty m_OrderedEncryptorRequester;

	protected static readonly RoutedEvent _EvaluatorOrder;

	public static readonly DependencyProperty _SequentialAuthenticatorRequester;

	public static readonly DependencyProperty m_ExtendedFilterRequester;

	public static readonly DependencyProperty _RequesterServerProvider;

	private decimal? requesterProviderSpec;

	internal CheckBox PART_Checkbox;

	internal TextBlock PART_Header;

	internal TextBox PART_Txt;

	internal RepeatButton PART_Increase;

	internal RepeatButton PART_Decrease;

	private bool isTokenizerTransaction;

	private static NumUpDown InsertComparator;

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

	public decimal? Minimum
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

	public decimal? Maximum
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

	public decimal? Increment
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

	public string FormatString
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

	public bool IsKeyboardFocus
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

	public decimal? Value
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

	public bool IsCheckable
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

	public bool? IsChecked
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

	public bool WheelEvenIfNotFocused
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

	public event RoutedPropertyChangedEventHandler<decimal?> ValueChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event RoutedPropertyChangedEventHandler<bool?> CheckedChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int? EstimateCombinedExecutor()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void DecryptGroupedViewer(int? info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CompressProfiler(DependencyObject task, DependencyPropertyChangedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void FetchCommonEmitter(DependencyObject last, DependencyPropertyChangedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NumUpDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReplaceStrategy(object instance, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestRemoteChooser(object first, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryEfficientFunction(object v, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestTransferableReceiver(object info, MouseButtonEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryLiteralField(object param, MouseButtonEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryGlobalEnumerator(object info, DependencyPropertyChangedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryDetachedSynchronizer(object asset, KeyboardFocusChangedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchExtendedSingleton(object config, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeleteConsumer(object reference, TextChangedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RequestAttachedAnalyzer(string item, out decimal caller)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryBasicWorker(decimal v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestChecker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestFlexibleNotifier()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryEditableInterpreter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<decimal?> config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCheckedChanged(RoutedPropertyChangedEventArgs<bool?> setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangePool(object info, MouseWheelEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int key_Low, object visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NumUpDown()
	{
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 3;
		int num3 = default(int);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				if (num3 != 14)
				{
					if (num3 == 994)
					{
						goto IL_0013;
					}
					goto case 0;
				}
				m_OrderedEncryptorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x72726171 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), typeof(bool?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(FetchCommonEmitter)));
				_EvaluatorOrder = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4C1784 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<bool?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)));
				_SequentialAuthenticatorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4EE7FA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)""));
				m_ExtendedFilterRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F0DB95 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				_RequesterServerProvider = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8CC4F0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
				num = 2;
				break;
			case 4:
				requesterStrategyDecider = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AA8EE2D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), typeof(decimal?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_ConvertibleAuditor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A0A92E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7), typeof(decimal?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				_ResponderSynchronizer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486E3F7A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), typeof(decimal?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num = 6;
				break;
			case 3:
				_ElementMap = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9B1A3 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new CornerRadius(0.0, 0.0, 0.0, 0.0)));
				num2 = 4;
				goto IL_000f;
			case 6:
				_TrackerSchema = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x42AE11DA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_624b474964114179bb2ea3d4c0497999), typeof(int?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a7061df8d09141e9a6cc560bc78e9163 != 0)
				{
					num = 10;
				}
				break;
			case 0:
				m_VirtualNode = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4C1746 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				requesterDeciderResponder = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556F13C2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aae4aafced0345eba92ee791dabe4490 == 0)
				{
					num = 11;
				}
				break;
			case 1:
				m_RequesterResponderServer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9BEE53 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), typeof(decimal?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(CompressProfiler)));
				scalableAnalyzerRequester = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71EE3385 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<decimal?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)));
				num = 5;
				break;
			case 2:
				return;
			case 5:
				{
					m_ReadableTransactionRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8D6BFE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556739)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
					num2 = 14;
					goto IL_000f;
				}
				IL_000f:
				num3 = num2;
				goto IL_0013;
				IL_0013:
				num = num3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCustomDictionaryEngine()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NumUpDown AttachAttachedEngineStack()
	{
		return null;
	}
}
