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

internal class ViewerTransformer : LocatorRequest
{
	internal enum EncryptorInspectorSingletonState
	{
		Minute,
		Daily,
		Weekly,
		Montly,
		VolBars,
		Range,
		Volume,
		Trade,
		Renko,
		Second,
		PointFigure,
		Delta
	}

	internal enum LocatorSynchronizerTag
	{
		All,
		Regular,
		IsoOrder
	}

	internal enum LocatorPROPPAGESTATUS
	{
		BidAsk,
		UpDownTick
	}

	internal enum TokenValidatorKind
	{
		Automatic,
		Fixed
	}

	internal enum ViewerAttributeInfoProperty
	{
		Last,
		Start,
		Average
	}

	internal enum ConvertibleParserDeciderEnum
	{
		DeltaVolume,
		DeltaPercentual
	}

	internal enum RegCalculatorWriter
	{
		FixedDelta,
		FadingDelta,
		BarDirection
	}

	internal enum AnimateBehaviorValues
	{
		Volume,
		Trades
	}

	internal enum GeneratorCertType
	{
		Fixed,
		FadingColor
	}

	internal enum DeciderEXECTYPE
	{
		Axis,
		Floating
	}

	internal enum RegSizeRelativeHorizontallyValues
	{
		Disabled,
		TimeAndVolume,
		TimeOrVolume
	}

	internal enum ColumnEncryptionKeyValueParameterKind
	{
		None,
		Percentual,
		Fixed
	}

	[CompilerGenerated]
	private int m_ViewerServerFreq;

	[CompilerGenerated]
	private EncryptorInspectorSingletonState detailedEditorViewer;

	[CompilerGenerated]
	private int m_ViewerProcessorVol;

	[CompilerGenerated]
	private int m_ScheduledSetViewerCount;

	[CompilerGenerated]
	private bool _IsOrderedSharerViewer;

	[CompilerGenerated]
	private EncryptorCacheBuffer.RolloverTypeEnum writerConsumer;

	[CompilerGenerated]
	private bool m_IsEditorRunner;

	[CompilerGenerated]
	private bool m_IsGlobalStream;

	[CompilerGenerated]
	private LocatorSynchronizerTag _IntegratedRunnerViewer;

	[CompilerGenerated]
	private bool _IsFilteredAllocatorViewer;

	[CompilerGenerated]
	private LocatorPROPPAGESTATUS m_ViewerAnnotation;

	[CompilerGenerated]
	private TokenValidatorKind randomSenderViewer;

	[CompilerGenerated]
	private int viewerInterpreterAge;

	[CompilerGenerated]
	private ViewerAttributeInfoProperty viewerTask;

	[CompilerGenerated]
	private bool _IsSharerSender;

	[CompilerGenerated]
	private int m_AdjustablePolicyCount;

	[CompilerGenerated]
	private bool m_IsPassiveEvent;

	[CompilerGenerated]
	private RegCalculatorWriter adjustableTrackerViewer;

	[CompilerGenerated]
	private AnimateBehaviorValues _ListViewer;

	[CompilerGenerated]
	private GeneratorCertType m_StatelessCompressorViewer;

	[CompilerGenerated]
	private ConvertibleParserDeciderEnum m_ViewerError;

	[CompilerGenerated]
	private double operationalBuilderViewer;

	[CompilerGenerated]
	private bool m_IsRecordViewer;

	[CompilerGenerated]
	private Color m_ViewerClient;

	[CompilerGenerated]
	private DashStyle m_ModularCacheViewer;

	[CompilerGenerated]
	private int m_GroupedCreatorViewerAge;

	[CompilerGenerated]
	private bool isModularEngine;

	[CompilerGenerated]
	private bool isCustomObserverViewer;

	[CompilerGenerated]
	private DeciderEXECTYPE m_ViewerSpec;

	[CompilerGenerated]
	private float m_SystemViewer;

	[CompilerGenerated]
	private Color convertibleAnalyzer;

	[CompilerGenerated]
	private Color portableStreamViewer;

	[CompilerGenerated]
	private bool _IsSummarizerSpec;

	[CompilerGenerated]
	private float _CustomProc;

	[CompilerGenerated]
	private Color m_SenderBuilder;

	[CompilerGenerated]
	private Color concreteCheckerViewer;

	[CompilerGenerated]
	private Color m_SetChooserViewer;

	[CompilerGenerated]
	private bool m_IsTrackerCache;

	[CompilerGenerated]
	private Color _InternalEnumeratorViewer;

	[CompilerGenerated]
	private DashStyle m_CombinedAuthorizerViewer;

	[CompilerGenerated]
	private int _AccessibleTransactionPnts;

	[CompilerGenerated]
	private bool isRecordConfiguration;

	[CompilerGenerated]
	private TimeSpan _ViewerMatcher;

	[CompilerGenerated]
	private TimeSpan cacheIterator;

	[CompilerGenerated]
	private bool isLiteralNodeViewer;

	[CompilerGenerated]
	private RegSizeRelativeHorizontallyValues m_FlexibleDecryptorViewer;

	[CompilerGenerated]
	private int m_CompressorCreatorTotal;

	[CompilerGenerated]
	private int _SegmentedFinderFlag;

	[CompilerGenerated]
	private int responderResolverLimit;

	[CompilerGenerated]
	private int m_AccessibleFactoryStep;

	[CompilerGenerated]
	private ColumnEncryptionKeyValueParameterKind m_MixedRequestViewer;

	[CompilerGenerated]
	private int _FactoryViewerFlag;

	[CompilerGenerated]
	private double responsiveAnalyzer;

	[CompilerGenerated]
	private int _FilterDefinitionSize;

	[CompilerGenerated]
	private int _AlphabeticRequesterViewerLevel;

	[CompilerGenerated]
	private int sortedReporterViewerId;

	[CompilerGenerated]
	private bool _IsAdaptableFunctionViewer;

	[CompilerGenerated]
	private double m_IsolatedAdapter;

	[CompilerGenerated]
	private double m_StaticBuffer;

	[CompilerGenerated]
	private double staticRoleViewer;

	[CompilerGenerated]
	private double m_ViewerWatcher;

	[CompilerGenerated]
	private bool m_IsBuilderObserver;

	[CompilerGenerated]
	private double detachedEditorAllocator;

	[CompilerGenerated]
	private bool _IsTransformableThreadViewer;

	[CompilerGenerated]
	private bool _IsVisualSchemaViewer;

	[CompilerGenerated]
	private double viewerHandler;

	[CompilerGenerated]
	private double m_DetachedPredictorSingleton;

	[CompilerGenerated]
	private bool m_IsDicViewer;

	[CompilerGenerated]
	private bool m_IsScalableEngineViewer;

	[CompilerGenerated]
	private int viewerAttributeRate;

	private RequesterTagExplorer m_CacheStream;

	private RequesterTagExplorer m_ViewerLogger;

	private Common.WriterWrapperHandler m_AutomatedDriverViewer;

	private VisualWrapperRequester<long> creatorChecker;

	private Common.WriterWrapperHandler observerChooser;

	private VisualWrapperRequester<long> _ConvertibleEngine;

	private long m_AccessibleEncryptorViewerVol;

	private bool isVisibleWrapperViewer;

	private int simpleProfileViewerErrorCode;

	private bool m_IsViewerCalculator;

	private double viewerStack;

	private double m_ViewerViewer;

	private bool isLogicalContext;

	private bool isSequentialPredictorViewer;

	private GeneratorCertType viewerUser;

	private AnimateBehaviorValues _DispatcherDic;

	private Color parserViewer;

	private Color m_AttachedEmitterViewer;

	private Color m_InterruptibleAuditor;

	private Color m_CheckerAuthorizer;

	private double automatableResolverViewer;

	private double automatableChecker;

	private double calculatorFinder;

	private static ViewerTransformer AttachGroupedCompilerPolicy;

	[Category("Data")]
	[DisplayName("Days To Load")]
	[StaticStructAllocator(SubCategory = "General", MaxValue = 1000000.0, DecimalPosToShow = 0, CategoryIndex = 0, PropertyIndex = 0)]
	public int DaysToLoad
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

	[DisplayName("Param Type")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 1)]
	[Category("Data")]
	public EncryptorInspectorSingletonState ParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorInspectorSingletonState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Param 1")]
	[Category("Data")]
	[StaticStructAllocator(SubCategory = "General", MaxValue = 1000000.0, DecimalPosToShow = 0, CategoryIndex = 0, PropertyIndex = 2)]
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

	[DisplayName("Param 2")]
	[StaticStructAllocator(SubCategory = "General", MaxValue = 1000000.0, DecimalPosToShow = 0, CategoryIndex = 0, PropertyIndex = 3)]
	[Category("Data")]
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

	[Category("Data")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 4)]
	[DisplayName("Based on minute data")]
	public bool BasedOnMinute
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

	[Category("Data")]
	[DisplayName("Continuous Contract")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 5)]
	public EncryptorCacheBuffer.RolloverTypeEnum ContinuosContract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorCacheBuffer.RolloverTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 6)]
	[Category("Data")]
	[DisplayName("Exclude Auction(Tick Data)")]
	public bool ExclucdeAuction
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

	[DisplayName("Filter Bad Ticks")]
	[Category("Data")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 7)]
	public bool FilterBadTicks
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

	[Category("Data")]
	[DisplayName("Trade Type")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 8)]
	public LocatorSynchronizerTag TradeType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorSynchronizerTag)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data")]
	[DisplayName("RTH - only")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 9)]
	public bool RthOnly
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

	[Category("Data")]
	[DisplayName("Bid/Ask type")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 0, PropertyIndex = 10)]
	public LocatorPROPPAGESTATUS BidAskType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorPROPPAGESTATUS)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data")]
	[DisplayName("Mode")]
	[StaticStructAllocator(SubCategory = "Tick grouping", CategoryIndex = 0, PropertyIndex = 11)]
	public TokenValidatorKind BaseTickGroupingMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TokenValidatorKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Fixed value")]
	[StaticStructAllocator(SubCategory = "Tick grouping", CategoryIndex = 0, PropertyIndex = 12, MinValue = 1.0)]
	[Category("Data")]
	public int BaseTickGroupingFixedValue
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

	[StaticStructAllocator(SubCategory = "Aggregated Trades", CategoryIndex = 0, PropertyIndex = 13)]
	[DisplayName("Price Mode")]
	[Category("Data")]
	public ViewerAttributeInfoProperty AggregatePriceType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerAttributeInfoProperty)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Volume", PropertyIndex = 0)]
	public bool WidthBasedVolume
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

	[Category("Volume/Delta")]
	[DisplayName("% max width based volume")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Volume", PropertyIndex = 1, MaxValue = 250.0, IncrementValue = 5.0)]
	public int MaxPercWidthVolume
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 2)]
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

	[DisplayName("Border color mode")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 3)]
	[Category("Volume/Delta")]
	public RegCalculatorWriter DeltaBorderColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegCalculatorWriter)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 4)]
	public AnimateBehaviorValues DeltaInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AnimateBehaviorValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 6)]
	public GeneratorCertType ColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorCertType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 7)]
	public ConvertibleParserDeciderEnum DeltaFadingMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConvertibleParserDeciderEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, SubCategory = "Delta", PropertyIndex = 8, MinValue = 0.75, MaxValue = 4.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
	[Category("Volume/Delta")]
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

	[DisplayName("Enable")]
	[Category("Price Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool PLine_Enabled
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

	[Category("Price Line")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public Color PLine_Color
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

	[Category("Price Line")]
	[DisplayName("Line Style")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public DashStyle PLine_Style
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

	[Category("Price Line")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MinValue = 1.0, MaxValue = 6.0)]
	public int PLine_Width
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

	[Category("Price Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[Category("Countdown")]
	[DisplayName("Enable")]
	public bool CD_Enabled
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[DisplayName("Mode")]
	[Category("Countdown")]
	public DeciderEXECTYPE CD_Mode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderEXECTYPE)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Text Size")]
	[Category("Countdown")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2, DecimalPosToShow = 1, IncrementValue = 1.0, MaxValue = 35.0, MinValue = 1.0)]
	public float CD_TextSize
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

	[Category("Countdown")]
	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public Color CD_TextColor
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

	[Category("Countdown")]
	[DisplayName("BackColor")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	public Color CD_BackColor
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

	[Category("% Var")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public bool VP_Enabled
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, DecimalPosToShow = 1, IncrementValue = 1.0, MaxValue = 35.0, MinValue = 1.0)]
	[Category("% Var")]
	[DisplayName("Text Size")]
	public float VP_TextSize
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

	[DisplayName("Pos. Text Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	[Category("% Var")]
	public Color VP_PosTextColor
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

	[Category("% Var")]
	[DisplayName("Neg. Text Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	public Color VP_NegTextColor
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

	[Category("% Var")]
	[DisplayName("BackColor")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
	public Color VP_BackColor
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	[Category("Line Start Day")]
	[DisplayName("Enable")]
	public bool VLine_Enabled
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

	[Category("Line Start Day")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	[DisplayName("Line Color")]
	public Color VLine_Color
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	[DisplayName("Line Style")]
	[Category("Line Start Day")]
	public DashStyle VLine_Style
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

	[Category("Line Start Day")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, MinValue = 1.0, MaxValue = 6.0)]
	public int VLine_Width
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

	[Category("Custom time session (Exchange time zone)")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	public bool CustomTimeEnabled
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

	[Category("Custom time session (Exchange time zone)")]
	[DisplayName("Ini Time")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
	public TimeSpan CustomTimeIni
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Custom time session (Exchange time zone)")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	[DisplayName("End Time")]
	public TimeSpan CustomTimeEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Custom time session (Exchange time zone)")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	[DisplayName("Use ini time as base for minute tf.")]
	public bool UseCustomTimeIniAsBaseForMinuteTf
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

	[DisplayName("Mode")]
	[Category("Deep Range")]
	[StaticStructAllocator(SubCategory = "Time/Volume", CategoryIndex = 7, PropertyIndex = 0)]
	public RegSizeRelativeHorizontallyValues EnabelCustomRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegSizeRelativeHorizontallyValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Deep Range")]
	[DisplayName("Time - Mininimum (s)")]
	[StaticStructAllocator(SubCategory = "Time/Volume", CategoryIndex = 7, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int CustomMinSecs
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

	[StaticStructAllocator(SubCategory = "Time/Volume", CategoryIndex = 7, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("Deep Range")]
	[DisplayName("Time - Maximum (s)")]
	public int CustomMaxSecs
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

	[DisplayName("Volume - Mininimum")]
	[StaticStructAllocator(SubCategory = "Time/Volume", CategoryIndex = 7, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("Deep Range")]
	public int CustomMinVols
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

	[Category("Deep Range")]
	[DisplayName("Volume - Maximum")]
	[StaticStructAllocator(SubCategory = "Time/Volume", CategoryIndex = 7, PropertyIndex = 4, MaxValue = 2147483647.0)]
	public int CustomMaxVols
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

	[Category("Deep Range")]
	[StaticStructAllocator(SubCategory = "Wick Volume", CategoryIndex = 7, PropertyIndex = 5)]
	[DisplayName("Custom mode")]
	public ColumnEncryptionKeyValueParameterKind EnableCustomExtreme
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ColumnEncryptionKeyValueParameterKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "Wick Volume", CategoryIndex = 7, PropertyIndex = 6, MinValue = 1.0, MaxValue = 2147483647.0)]
	[DisplayName("Ticks")]
	[Category("Deep Range")]
	public int CustomExtremeTicks
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

	[StaticStructAllocator(SubCategory = "Wick Volume", CategoryIndex = 7, PropertyIndex = 7, DecimalPosToShow = 2, MaxValue = 2147483647.0)]
	[DisplayName("Minimum volume")]
	[Category("Deep Range")]
	public double CustomExtremeVols
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

	[StaticStructAllocator(IsVisible = false)]
	public int LockNBarFilled
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

	[StaticStructAllocator(IsVisible = false)]
	public int BarZoomed
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

	[StaticStructAllocator(IsVisible = false)]
	public int BarOffset
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

	[StaticStructAllocator(IsVisible = false)]
	public bool OnceLoad
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

	[StaticStructAllocator(IsVisible = false)]
	public double CD_X
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

	[StaticStructAllocator(IsVisible = false)]
	public double CD_Y
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

	[StaticStructAllocator(IsVisible = false)]
	public double VP_X
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

	[StaticStructAllocator(IsVisible = false)]
	public double VP_Y
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

	[StaticStructAllocator(IsVisible = false)]
	public bool YFixedDeltaEnable
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

	[StaticStructAllocator(IsVisible = false)]
	public double YFixedDeltaValue
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

	[StaticStructAllocator(IsVisible = false)]
	public bool YFixedMarginEnable
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

	[StaticStructAllocator(IsVisible = false)]
	public bool YMarginClosestOnly
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

	[StaticStructAllocator(IsVisible = false)]
	public double YFixedMarginTopValue
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

	[StaticStructAllocator(IsVisible = false)]
	public double YFixedMarginBottomValue
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

	[StaticStructAllocator(IsVisible = false)]
	public bool HideBarValues
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

	[StaticStructAllocator(IsVisible = false)]
	public bool BorderBasedOpenClose
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

	[StaticStructAllocator(IsVisible = false)]
	public int Version
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
	static ViewerTransformer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001f;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555528)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8EA89A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x62315A51 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), MapResponderLocator.BasicRecordReg.Utility)
					{
						Hidden = true
					});
					return;
				case 1:
					break;
				}
				goto IL_00b1;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_00b1;
				IL_00b1:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa0784742b414723af10424e83d8cd83 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerTransformer(ScopeEncryptor.HiddenModelDecider param, MapResponderLocator.TransformableUserEncryptor map, int pool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool createsetup, bool iscol)
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
	private RequesterTagExplorer AssembleDictionary(string key, bool strippred, double helper, double col2, Color first3, Color visitor4, float ord5)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewExpandableRunner(int value_Y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator info, bool ispred, MapResponderLocator.TokenParameterViewer tag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayAutomatableProject(bool isdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayCombinedObserver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool requiresinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SortDic(int reference_X, bool canresult)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvokeThread(int position_value, bool isord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool excludeasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreCentralInterpreter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachIdentifiablePolicySorter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerTransformer SimulateInternalRequestChain()
	{
		return null;
	}
}
