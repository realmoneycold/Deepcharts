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

internal class TimePickerControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty _ProcHandler;

	public static readonly DependencyProperty wrapperProjectProvider;

	public static readonly DependencyProperty m_WrapperProviderQueue;

	public static readonly DependencyProperty _WrapperQueueError;

	public static readonly DependencyProperty readableProcessorWrapper;

	public static readonly DependencyProperty wrapperErrorChain;

	public static readonly DependencyProperty m_ConnectedPoolWrapper;

	protected static readonly RoutedEvent m_WrapperChainSharer;

	public static readonly DependencyProperty m_SpecMonitorRequester;

	public static readonly DependencyProperty m_MonitorResolver;

	protected static readonly RoutedEvent _ScopeSummarizerWrapper;

	public static readonly DependencyProperty m_WrapperSharerRecommender;

	public static readonly DependencyProperty m_CustomProgramWrapper;

	private TimeSpan? _RecommenderRecordWrapper;

	internal CheckBox PART_Checkbox;

	internal TextBlock PART_Header;

	internal TextBox PART_Txt;

	internal RepeatButton PART_Increase;

	internal RepeatButton PART_Decrease;

	private bool m_IsStackNode;

	private static TimePickerControl PauseTokenElement;

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

	public TimeSpan? Minimum
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

	public TimeSpan? Maximum
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

	public TimeSpan Increment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TimeSpan)(object)null;
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

	public TimeSpan? Value
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

	public event RoutedPropertyChangedEventHandler<TimeSpan?> ValueChanged
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
	private static void WrapCommonChooser(DependencyObject task, DependencyPropertyChangedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SplitAuthenticator(DependencyObject key, DependencyPropertyChangedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TimePickerControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LeadCollection(object first, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CancelAnnotation(object value, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapTransferableEnumerator(object ident, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NewDictionary(object instance, MouseButtonEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncapsulateGlobalSingleton(object item, MouseButtonEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncapsulateDetachedCalculator(object res, DependencyPropertyChangedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapExtendedAnalyzer(object item, KeyboardFocusChangedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapCustomWorker(object def, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapAttachedSolver(object param, TextChangedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool WrapBasicNotifier(string spec, out TimeSpan cfg)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeTask(TimeSpan init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapFlexibleQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapEditableExtractor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CoverIntegratedFinder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<TimeSpan?> ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCheckedChanged(RoutedPropertyChangedEventArgs<bool?> instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int index_def, object connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TimePickerControl()
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		int num = 6;
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
							goto case 3;
						}
						m_WrapperChainSharer = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE419B8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<TimeSpan?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)));
						m_SpecMonitorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4C179A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
						num = 2;
						break;
					case 2:
						m_MonitorResolver = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5647352F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), typeof(bool?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(SplitAuthenticator)));
						_ScopeSummarizerWrapper = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(-117581714 ^ -822946254 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<bool?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)));
						num3 = 4;
						continue;
					case 6:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 5;
						continue;
					case 5:
						WrapperStreamEditor.PresentConfiguration();
						num3 = 1;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f7153e12738d421a9f1c8d1ce74c74b0 != 0)
						{
							num3 = 10;
						}
						continue;
					case 1:
						WriterCommandResolver.ReflectDefinitionSelector();
						num = 3;
						break;
					case 3:
						_ProcHandler = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x21411FAB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new CornerRadius(0.0, 0.0, 0.0, 0.0)));
						wrapperProjectProvider = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x594E6046 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60e044da66db4b08896730b7f82d59f6), typeof(TimeSpan?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						m_WrapperProviderQueue = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F4B369D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), typeof(TimeSpan?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						_WrapperQueueError = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8D6B34 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777311)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)TimeSpan.FromMinutes(15L)));
						readableProcessorWrapper = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--1896610954 ^ 0x3965C3E6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F350C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282)));
						wrapperErrorChain = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9E5CB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						m_ConnectedPoolWrapper = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AABA213 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), typeof(TimeSpan?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)TimeSpan.Zero, new PropertyChangedCallback(WrapCommonChooser)));
						num = 13;
						break;
					case 0:
						return;
					case 4:
						m_WrapperSharerRecommender = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E466045 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((object)""));
						m_CustomProgramWrapper = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486E75BE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556761)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						num3 = 12;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c134208b4ea4777b9fe8986b1148b1d == 0)
						{
							num3 = 0;
						}
						continue;
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
	internal static bool GenerateScheduledSpecSystem()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimePickerControl AttachMonoSystemProfiler()
	{
		return null;
	}
}
