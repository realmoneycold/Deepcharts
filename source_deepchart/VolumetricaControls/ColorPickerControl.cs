using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using Deepchart.DecisionMaking;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

internal class ColorPickerControl : UserControl, IComponentConnector, IStyleConnector
{
	private static DynamicUserRequester[] _RegBridgeCalculatorArray;

	private static DynamicUserRequester[] m_ConvertibleChooserRegArray;

	public static readonly DependencyProperty m_ExplorerSpec;

	public static readonly DependencyProperty m_RegValuePolicy;

	protected static readonly RoutedEvent m_InterruptibleRecommenderReg;

	public static readonly DependencyProperty _ProviderVisitor;

	public static readonly DependencyProperty _CalcOrder;

	internal Button PART_Btn;

	internal Popup PART_Popup;

	internal TabItem tabStandard;

	internal Grid grdStandard;

	internal ListView lswStandard;

	internal Grid grdAvailable;

	internal ListView lswAvailable;

	internal TabItem tabCustom;

	internal Canvas CNV_All;

	internal Rectangle RECT_CnvValue;

	internal Canvas PART_CnvSelected;

	internal TranslateTransform m_CustomizableAllocatorReg;

	internal Rectangle rectColor;

	internal TextBox txtInputHex;

	internal Slider sldR;

	internal NumUpDown nudR;

	internal Slider sldG;

	internal NumUpDown nudG;

	internal Slider sldB;

	internal NumUpDown nudB;

	internal Slider sldA;

	internal NumUpDown nudA;

	private bool m_IsSingletonTransactionSelector;

	private static ColorPickerControl SimulateSymbolicModelRequester;

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

	public Color? Value
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

	public bool ShowTransparent
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

	public event RoutedPropertyChangedEventHandler<Color?> ValueChanged
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
	static ColorPickerControl()
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num != 10)
					{
						if (num == 990)
						{
							goto end_IL_0017;
						}
						goto case 1;
					}
					WriterCommandResolver.ReflectDefinitionSelector();
					num2 = 5;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ef477db91c94193a08bf365e8abefbc == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					_RegBridgeCalculatorArray = (from x in WrapperStreamEditor.EncapsulateCommonSynchronizer(0x623340D5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0).Split('|')
						select (DynamicUserRequester)null).ToArray();
					m_ConvertibleChooserRegArray = (from x in WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E733BB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180).Split('|')
						select (DynamicUserRequester)null).ToArray();
					return;
				case 2:
					m_ExplorerSpec = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5742D11C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777944)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556733)), new PropertyMetadata((object)new CornerRadius(2.0)));
					m_RegValuePolicy = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316AE4C4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708), typeof(Color?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556733)), new PropertyMetadata((object)null, new PropertyChangedCallback(SaveResponsiveEvent)));
					m_InterruptibleRecommenderReg = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68F9BB1F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), (RoutingStrategy)1, typeof(RoutedPropertyChangedEventHandler<Color?>), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556733)));
					_ProviderVisitor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B608E41 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556733)), new PropertyMetadata((object)null));
					num2 = 3;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					_CalcOrder = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7EE32C1B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556733)), (PropertyMetadata)new FrameworkPropertyMetadata((object)true, new PropertyChangedCallback(ChangeEvaluator)));
					_RegBridgeCalculatorArray = (from x in WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8D346A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909).Split('|')
						select (DynamicUserRequester)null).ToArray();
					num2 = 1;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d9f03e0b6eff4bfaa3ef2502f54df2d2 != 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0017:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ChangeEvaluator(DependencyObject init, DependencyPropertyChangedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SaveResponsiveEvent(DependencyObject res, DependencyPropertyChangedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColorPickerControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PART_Btn_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SolveTracer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<Color?> v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillPredictor(object ident, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindTransformer(object param, RoutedPropertyChangedEventArgs<double> b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nudR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<decimal?> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenSequentialWrapper(object var1, RoutedPropertyChangedEventArgs<double> cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nudG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<decimal?> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveTransformableConfig(object instance, RoutedPropertyChangedEventArgs<double> reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nudB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<decimal?> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreGenericConfiguration(object last, RoutedPropertyChangedEventArgs<double> ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nudA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<decimal?> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenSimpleRecommender(object task, TextChangedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitProject(object def, MouseButtonEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveObserver(object config, MouseButtonEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveStatelessDriver(object task, MouseEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenActiveSharer(object last, DependencyPropertyChangedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveFilteredDecider(object info, SizeChangedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenPortableObject()
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int indexOfres, object connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int flags_v, object caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachConcreteRequesterFilter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ColorPickerControl SimulateCentralFilterWriter()
	{
		return null;
	}
}
