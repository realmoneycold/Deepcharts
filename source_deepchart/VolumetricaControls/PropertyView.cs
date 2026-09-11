using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

internal class PropertyView : UserControl, IComponentConnector
{
	private enum RequesterBinaryOperatorSpacingOptions
	{
		Symbol = 2
	}

	public static List<EditableEditorWriter> sequentialWrapperGenerators;

	public static Type _FilteredComparatorGenerator;

	public static Type providerEvent;

	public static readonly DependencyProperty _ConfigurationDictionary;

	public static readonly DependencyProperty extendedObjectGenerator;

	public static readonly DependencyProperty m_DividedSenderGenerator;

	public static readonly DependencyProperty m_CombinedInspectorGenerator;

	public static readonly DependencyProperty _ChooserModelGenerator;

	public static readonly DependencyProperty trackerProject;

	public static readonly DependencyProperty _InitializerDistributor;

	public static readonly DependencyProperty m_VirtualControllerGenerator;

	public static readonly DependencyProperty compilerMember;

	public static readonly DependencyProperty _DetailedBuilderWriter;

	[CompilerGenerated]
	private bool m_IsGeneratorModelCompressor;

	[CompilerGenerated]
	private bool isActiveStrategyGenerator;

	private object _PublisherRecommenderObj;

	private Dictionary<string, Tuple<Type, Control>> dictionaryTokenizerDic;

	private List<Label> m_AutomatableNotifierGenerators;

	private Action m_MixedGatewayGenerator;

	private bool isEventReg;

	private Func<string, bool> enumeratorListener;

	private Func<Type, object> m_CompressorLocatorGenerator;

	private ObservableCollection<WrapperContextProfiler> _GeneratorLocatorCacheList;

	private CancellationTokenSource generatorCacheSpec;

	private bool _IsGeneratorSpecStack;

	internal ListView lswCategories;

	internal ScrollViewer cntProp;

	private bool isArgumentRecommender;

	internal static PropertyView AttachCustomizableBridgeDispatcher;

	public int CategoryGap
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

	public int PropertyGap
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

	public GridLength LabelWidth
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

	public double LabelMinWidth
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

	public double LabelMaxWidth
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

	public TextAlignment LabelAlignment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (TextAlignment)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Brush InputBackground
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

	public Brush InputForeground
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

	public Style IconButtonStyle
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

	public Style CategoryListViewStyle
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
	[SpecialName]
	public object ReceiveAdaptableCalc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void ReadMonitor(object var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool CloseReadableMap()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void CreateDividedTask(bool writespec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool TransmitSeparatedDispatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void GenerateScalableFinalizer(bool containsi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertyView()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertyView(Action value, Func<string, bool> selection = null, bool ispool = false, bool verifyres2 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertyView(bool isdef, Action selection, Func<string, bool> dir = null, bool wantdef2 = false, bool isreference3 = false, Func<Type, object> key4 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateActiveObject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateFilteredRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool VerifySharer(Type v)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RequesterBinaryOperatorSpacingOptions CreateSymbolicOrder(char def)
	{
		return (RequesterBinaryOperatorSpacingOptions)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string CreateConcreteListener(string res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateCentralDistributor(Grid info, bool removeconnection = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Grid CloseAdvancedCreator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DirectOrder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseAlphabeticElement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CollectDistributor(IconButton var1, StaticStructAllocator ivk, object tag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HandleCreator(Enum instance)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GenerateControllableChooser(Enum i)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int StoreElement(Tuple<string, List<Tuple<string, string, Type, StaticStructAllocator, object>>> item, Tuple<string, List<Tuple<string, string, Type, StaticStructAllocator, object>>> cust)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GenerateEfficientReceiver(Tuple<string, string, Type, StaticStructAllocator, object> v, Tuple<string, string, Type, StaticStructAllocator, object> vis)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseTransferableField()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewChooser(object i, SelectionChangedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int value_counter, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyView()
	{
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909 == 0)
		{
			num = 9;
		}
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num3 != 12)
				{
					if (num3 == 992)
					{
						goto IL_0013;
					}
					goto case 4;
				}
				_InitializerDistributor = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3169A7B2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Brushes.Transparent));
				num = 3;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_26d6e57b924c4618b170b903cd8b4023 != 0)
				{
					num = 12;
				}
				break;
			case 3:
				m_VirtualControllerGenerator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3786B4A5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Brushes.Transparent));
				compilerMember = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(-1023941699 ^ -2005193845 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				_DetailedBuilderWriter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x15204FE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ccd483989b5e477dadf241757c38ebb6), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				num = 2;
				break;
			case 4:
			{
				_ChooserModelGenerator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486E333C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777260)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)double.PositiveInfinity));
				trackerProject = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6B320536 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c4b807f2d234a1db471f24a593fc425), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777963)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(TextAlignment)0));
				int num2 = 12;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c != 0)
				{
					num2 = 12;
				}
				num3 = num2;
				goto IL_0013;
			}
			case 1:
				providerEvent = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556740));
				_ConfigurationDictionary = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F52513F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777220)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)16));
				extendedObjectGenerator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3786B475 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777220)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)8));
				m_DividedSenderGenerator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2141467B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new GridLength(1.0, (GridUnitType)2)));
				num = 9;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7f5e62e6715e481fa3aefa1c945abcc4 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 0:
				{
					m_CombinedInspectorGenerator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5EDE5571 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6b3eda098e1a4d3aa281067d349fea8d), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777260)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556742)), (PropertyMetadata)new FrameworkPropertyMetadata((object)0.0));
					num = 4;
					break;
				}
				IL_0013:
				num = num3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void ProcessFunction(object init, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateDetachedSingleton(object value, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GenerateExtendedCalculator(Task task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void WatchEnumerator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateAttachedWorker(object spec, TextChangedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GenerateBasicSolver(object value, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GenerateOperationalNotifier(object i, RoutedPropertyChangedEventArgs<Color?> ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateFlexibleInterpreter(object instance, RoutedPropertyChangedEventArgs<decimal?> caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateEditableQueue(object i, RoutedPropertyChangedEventArgs<DateTime?> reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void DisableSolver(object var1, RoutedPropertyChangedEventArgs<DateTime?> ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CloseStaticFinder(object asset, RoutedPropertyChangedEventArgs<TimeSpan?> reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateCustomizableWatcher(object reference, SelectionChangedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CreateAutomatedProfile(object reference, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GenerateJoinedEditor(object last, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CloseConvertibleCache(object item, SelectionChangedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VisitTemplate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PropertyView SimulateJoinedFinalizerResolver()
	{
		return null;
	}
}
