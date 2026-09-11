using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Viewers;

internal class ScopeDefinitionViewer : LocatorRequest
{
	internal enum AllocatorRuleReevaluationBehavior
	{
		Minute,
		Daily,
		Weekly,
		VolBars,
		Range,
		Monthly
	}

	internal enum QueueManagerOptions
	{
		Fixed,
		FadingColor
	}

	[CompilerGenerated]
	private AllocatorRuleReevaluationBehavior _ViewerMonitor;

	[CompilerGenerated]
	private int connectionViewerVal;

	[CompilerGenerated]
	private int _ViewerCommandPnts;

	[CompilerGenerated]
	private bool _IsIterableInitializer;

	[CompilerGenerated]
	private QueueManagerOptions _AdaptableEngineReg;

	[CompilerGenerated]
	private double evaluatorViewer;

	[CompilerGenerated]
	private Color _ViewerFinalizer;

	[CompilerGenerated]
	private Color _ServiceAggregator;

	[CompilerGenerated]
	private bool m_IsGenericAnalyzerDecider;

	[CompilerGenerated]
	private int m_LocatorTransmitterCount;

	[CompilerGenerated]
	private int m_GeneralTreeViewerVal;

	[CompilerGenerated]
	private int m_ViewerIteratorStep;

	[CompilerGenerated]
	private bool isExpandableBufferViewer;

	[CompilerGenerated]
	private bool isListAuthorizer;

	[CompilerGenerated]
	private Color m_ViewerExplorer;

	[CompilerGenerated]
	private Color m_GenericTagViewer;

	[CompilerGenerated]
	private int dicPolicyErrorCode;

	[CompilerGenerated]
	private DashStyle orderExtractor;

	[CompilerGenerated]
	private bool m_IsElementMonitor;

	[CompilerGenerated]
	private bool _IsViewerModel;

	[CompilerGenerated]
	private Color m_ViewerPublisher;

	[CompilerGenerated]
	private float _GatewayProfile;

	[CompilerGenerated]
	private bool m_IsAnalyzerTag;

	[CompilerGenerated]
	private bool _IsStubViewer;

	[CompilerGenerated]
	private bool _IsWriterCompiler;

	[CompilerGenerated]
	private Color m_ServerThread;

	[CompilerGenerated]
	private Color m_IdentifiableVerifierViewer;

	[CompilerGenerated]
	private Color _DispatcherReceiver;

	[CompilerGenerated]
	private float _ViewerDictionary;

	[CompilerGenerated]
	private int m_ViewerMapperFlag;

	private RequesterTagExplorer _ViewerField;

	private RequesterTagExplorer dictionaryConnection;

	private RequesterTagExplorer passiveQueueViewer;

	private RequesterTagExplorer _TemplateListener;

	private RequesterTagExplorer m_SymbolicStrategyViewer;

	private DateTime m_MapComparator;

	private DateTime m_ProfileConfiguration;

	private double m_UserExecutor;

	private double m_ComparatorEvent;

	private double m_ConcreteCreator;

	private double m_IsolatedVisitorViewer;

	private int m_AggregatorEditorFlag;

	private int _ProjectClientAge;

	private int visualStrategyValue;

	private int _AccessibleResponderLevel;

	private int m_CompilerSetVol;

	private int detachedOrderPerc;

	private int m_ViewerFilterOffset;

	private int m_InterruptibleConfigurationViewerErrorCode;

	private int _SorterFinalizerPos;

	private Common.WriterWrapperHandler m_IterableDeciderViewer;

	private VisualWrapperRequester<int> _OrderViewer;

	private RequesterTagExplorer commonServiceViewer;

	private RequesterTagExplorer m_CentralMonitorAllocator;

	private RequesterTagExplorer _FinderViewer;

	private RequesterTagExplorer _DynamicModule;

	private RequesterTagExplorer viewerReceiver;

	private bool isSeparatedWriterViewer;

	private bool isLocalComparatorViewer;

	private int _DistributorViewerCount;

	private bool m_IsInterruptibleSorter;

	private int responsiveAggregatorViewerPnts;

	private AllocatorRuleReevaluationBehavior m_DetachedCompilerViewer;

	private int m_ViewerArgumentPos;

	private int m_DefinitionDecryptorVol;

	private bool _IsJoinedEventViewer;

	private int viewerTransmitterValue;

	private int m_EventSharerCnt;

	internal static ScopeDefinitionViewer GenerateControllableInitializerResponder;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public AllocatorRuleReevaluationBehavior ParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorRuleReevaluationBehavior)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2000.0)]
	public int Param1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2000.0)]
	public int Param2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool ColorBasedOnDelta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Color")]
	public QueueManagerOptions ColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (QueueManagerOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MinValue = 0.75, MaxValue = 4.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
	[Category("Color")]
	public double StdDevForColoring
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public Color UpBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	[Category("Color")]
	public Color DownBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MaxValue = 7.0, IncrementValue = 1.0)]
	[DisplayName("Enable")]
	[Category("Plot")]
	public bool EnableBars
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 7.0, IncrementValue = 1.0)]
	public int BorderWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 100.0, IncrementValue = 5.0)]
	public int BodyOpacity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MaxValue = 100.0, IncrementValue = 5.0)]
	public int ShadowOpacity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	public bool ShowBackground
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public bool TargetEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public Color HighColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public Color LowColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3, MinValue = 1.0, MaxValue = 6.0)]
	public int LineWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	public DashStyle LineStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
	public bool ExtendLineToLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 6)]
	public bool ShowText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 7)]
	public Color TextColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Range Target")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 8, DecimalPosToShow = 1, IncrementValue = 1.0, MaxValue = 35.0, MinValue = 1.0)]
	public float TextSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[DisplayName("Enable Summary")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public bool SummaryEnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	[Category("Summary")]
	[DisplayName("Volume Summary")]
	public bool SummaryEnableVolume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[DisplayName("Trade Summary")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public bool SummaryEnableNumTrade
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	[DisplayName("Text Color")]
	public Color SummaryTextColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
	[DisplayName("Ask Color")]
	[Category("Summary")]
	public Color SummaryAskColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[DisplayName("Bid Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
	public Color SummaryBidColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6, DecimalPosToShow = 1, IncrementValue = 1.0, MaxValue = 35.0, MinValue = 1.0)]
	public float SummaryTextSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 7, MinValue = 0.0)]
	[Category("Summary")]
	public int SummaryToView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScopeDefinitionViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555508)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C4812 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2095EC26 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743), MapResponderLocator.BasicRecordReg.Overlay));
		int num = 5;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b8a398ef849b48a09f0c26204f046be9 == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			if (num2 == 988)
			{
				num = num2;
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScopeDefinitionViewer(ScopeEncryptor.HiddenModelDecider init, MapResponderLocator.TransformableUserEncryptor vis, int mintag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isres, bool usepol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanTag(RequesterTagExplorer config, Color visitor, bool usestate = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DisplayActiveMatcher(int no__first, double b, bool addfilter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewFilteredReporter(int paramcount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPortableTransmitter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunPool(SingletonHandlerConnection.ObjectAuthenticatorLocator first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator reference, bool isresult, MapResponderLocator.TokenParameterViewer consumer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EvaluateTracer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool removelast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewCentralPredicate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool containskey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LeadCompressor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScopeDefinitionViewer CancelDriver()
	{
		return null;
	}
}
