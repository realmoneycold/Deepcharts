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

internal class DatePickerControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty _AlphabeticResolverRequester;

	public static readonly DependencyProperty m_ReceiverPredictorRequester;

	public static readonly DependencyProperty internalNodeRequester;

	protected static readonly RoutedEvent m_ContextTransformer;

	public static readonly DependencyProperty _RequesterPredictorDispatcher;

	public static readonly DependencyProperty m_LogicalMember;

	protected static readonly RoutedEvent m_ChainListener;

	public static readonly DependencyProperty requesterDispatcherValidator;

	public static readonly DependencyProperty _RequesterValidatorService;

	internal CheckBox PART_Checkbox;

	internal TextBlock PART_Header;

	internal TextBox PART_Txt;

	internal IconButton PART_Btn;

	internal Popup popCalendar;

	internal Calendar inpCalendar;

	private bool m_IsCentralTesterRequester;

	private static DatePickerControl StoreIterator;

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
	private static void FilterCalc(DependencyObject asset, DependencyPropertyChangedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QueryBasicAnalyzer(DependencyObject value, DependencyPropertyChangedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DatePickerControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeThread(object res, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryFlexibleSolver(object init, DependencyPropertyChangedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryEditableNotifier(object asset, KeyboardFocusChangedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MatchBridge(object reference, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareDispatcher(object i, TextChangedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryCustomizableExtractor(bool moveinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateResolver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<DateTime?> first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PART_Btn_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchJoinedWatcher(object info, SelectionChangedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCheckedChanged(RoutedPropertyChangedEventArgs<bool?> var1)
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
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int mean_setup, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatePickerControl()
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				if (num3 != 11)
				{
					if (num3 == 991)
					{
						goto IL_0013;
					}
					goto case 0;
				}
				_RequesterPredictorDispatcher = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(-189226311 ^ -336920672 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
				m_LogicalMember = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2096BC22 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743), typeof(bool?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(QueryBasicAnalyzer)));
				m_ChainListener = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E73425 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<bool?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)));
				num = 1;
				break;
			case 0:
				_RequesterValidatorService = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319EADAD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777478)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num2 = 3;
				goto IL_000f;
			case 1:
				requesterDispatcherValidator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B27E75A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((object)""));
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_098a6072c5404edaaa1950336d79b009 != 0)
				{
					num = 7;
				}
				break;
			case 3:
				return;
			case 2:
				{
					WriterCommandResolver.ReflectDefinitionSelector();
					_AlphabeticResolverRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x196C00D3 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85d190cf4c4a4d04b10953a29bb27a0f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new CornerRadius(0.0, 0.0, 0.0, 0.0)));
					m_ReceiverPredictorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71EE6D51 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
					internalNodeRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319DA81B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), typeof(DateTime?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)), new PropertyMetadata((object)DateTime.Now, new PropertyChangedCallback(FilterCalc)));
					m_ContextTransformer = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F0CEAD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<DateTime?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556737)));
					num2 = 11;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0 == 0)
					{
						num2 = 11;
					}
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
	internal static bool RatePredicate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DatePickerControl SimulateTransferableAuditorAuthenticator()
	{
		return null;
	}
}
