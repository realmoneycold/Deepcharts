using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
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

internal class DateTimePickerControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty _FlexibleLocatorRequester;

	public static readonly DependencyProperty symbolicAnalyzer;

	public static readonly DependencyProperty requesterServiceEditor;

	public static readonly DependencyProperty _InspectorObserver;

	protected static readonly RoutedEvent poolVisitor;

	public static readonly DependencyProperty m_RequesterEditorRecord;

	public static readonly DependencyProperty responsiveInspectorRequester;

	protected static readonly RoutedEvent _OperationalConfig;

	public static readonly DependencyProperty customizableProcessorRequester;

	public static readonly DependencyProperty poolEmitter;

	public static readonly DependencyProperty m_GroupedObjectRequester;

	public static readonly DependencyProperty m_RecordStrategyRequester;

	internal CheckBox PART_Checkbox;

	internal TextBlock PART_Header;

	internal TextBox PART_Txt;

	internal IconButton PART_Btn;

	internal Popup popCalendar;

	internal Calendar inpCalendar;

	internal TimePickerControl PART_Time;

	private bool isFieldBuffer;

	private static DateTimePickerControl SimulateLiteralAuthenticatorCollection;

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

	public DateTime? Value
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

	public Style PopupBorderStyle
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

	public event RoutedPropertyChangedEventHandler<DateTime?> ValueChanged
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
	private static void SetupCreator(DependencyObject asset, DependencyPropertyChangedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void StoreToken(DependencyObject init, DependencyPropertyChangedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTimePickerControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchPassiveDictionary(object spec, RoutedPropertyChangedEventArgs<TimeSpan?> pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchAdaptableEngine(object value, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestRandomStack(object res, DependencyPropertyChangedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestDynamicCalc(object spec, KeyboardFocusChangedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchReadableDic(object key, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertReceiver(object task, TextChangedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchField(bool updateconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QuerySeparatedTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<DateTime?> asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PART_Btn_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryScalableBridge(object i, SelectionChangedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCheckedChanged(RoutedPropertyChangedEventArgs<bool?> info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int first_count, object pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DateTimePickerControl()
	{
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0012;
							}
							goto case 4;
						}
						_FlexibleLocatorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3192F076 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new CornerRadius(0.0, 0.0, 0.0, 0.0)));
						symbolicAnalyzer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE44644 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777311)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)TimeSpan.FromMinutes(15L)));
						requesterServiceEditor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x742ADBD4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						num3 = 0;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_5b86380d716f44fa99fac622f4c13933 != 0)
						{
							num3 = 6;
						}
						continue;
					case 3:
						return;
					case 1:
						WrapperStreamEditor.PresentConfiguration();
						num3 = 5;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64 == 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
						_InspectorObserver = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -1160261118 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), typeof(DateTime?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), new PropertyMetadata((object)DateTime.Now, new PropertyChangedCallback(SetupCreator)));
						poolVisitor = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A0F58C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<DateTime?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)));
						m_RequesterEditorRecord = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B27AFEC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
						responsiveInspectorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x21411D9D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803), typeof(bool?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(StoreToken)));
						_OperationalConfig = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4EAF52 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<bool?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)));
						customizableProcessorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE8B34DD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)""));
						poolEmitter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x72727CC3 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
						num3 = 4;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7f5e62e6715e481fa3aefa1c945abcc4 != 0)
						{
							num3 = 1;
						}
						continue;
					case 5:
						break;
					case 4:
						m_GroupedObjectRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x417A4DD1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aae4aafced0345eba92ee791dabe4490), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A0AA42 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7))));
						m_RecordStrategyRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9BB7B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556738)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
						num3 = 3;
						continue;
					case 2:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 1;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_42fbc1ba04824a6bbb0b9900cd13a5de == 0)
						{
							num3 = 6;
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
			WriterCommandResolver.ReflectDefinitionSelector();
			num = 12;
			if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_098a6072c5404edaaa1950336d79b009 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ProcessSystem()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimePickerControl MergeProfiler()
	{
		return null;
	}
}
