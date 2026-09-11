using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class ScheduledSystemAllocator : LocatorRequest
{
	internal enum GenericArgumentGenerator
	{
		None,
		Trade,
		Range,
		TradeAndRange
	}

	private class ControllerStack
	{
		[CompilerGenerated]
		private double centralCollection;

		[CompilerGenerated]
		private double m_RequesterStreamContext;

		[CompilerGenerated]
		private double requesterContextTree;

		[CompilerGenerated]
		private bool _IsActiveLogger;

		internal static ControllerStack EncodeProfile;

		public double HinT
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

		public double LinT
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

		public double ExitIndex
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

		public bool ExitedUp
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ControllerStack()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ControllerStack()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateSeparatedProviderParser()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ControllerStack JoinCache()
		{
			return null;
		}
	}

	private class TesterParser
	{
		public AllocatorCompilerEvent<MapResponderLocator.EfficientStructRequester> _FlexibleResponder;

		public int scalableExecutorRegDepth;

		public long m_RegWriterStrategyCap;

		public int _RegSystemTransactionErrorCode;

		public int m_AlphabeticObserverCounter;

		public int regStrategyStubOffset;

		public int _RegTransactionAnnotations;

		public bool isReadableWorker;

		public double m_SelectorAttribute;

		public long regStubRecordDist;

		private static TesterParser ResumeSubscriber;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TesterParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TesterParser()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PeekClient()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TesterParser AttachLogicalParameterProxy()
		{
			return null;
		}
	}

	private enum InspectorMatcherAllocatorType
	{
		None,
		Up,
		Down
	}

	private class ObserverField
	{
		[CompilerGenerated]
		private int generatorDriverValue;

		[CompilerGenerated]
		private int m_StatelessDicGeneratorVol;

		[CompilerGenerated]
		private int _GeneratorStateDepth;

		[CompilerGenerated]
		private int _GroupedAuditorGeneratorNum;

		[CompilerGenerated]
		private bool m_IsGeneratorInterpreter;

		private VisualWrapperRequester<long> m_GeneratorSummarizer;

		private VisualWrapperRequester<long> m_DetailedConnection;

		private bool m_IsTesterEditor;

		private int segmentedProgramLength;

		private long concreteConverterGeneratorNum;

		private int m_CentralBuilderInterval;

		private int attributeCollectorRate;

		private bool _IsClientSet;

		private bool isGenericState;

		private long setCheckerLength;

		private long accessiblePredictorGeneratorFreq;

		private long m_GeneratorAttributeDepth;

		internal static ObserverField SimulateSortedModuleDecorator;

		public int Length
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

		public int MinVolume
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

		public int MinDelta
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

		public int BarPassed
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

		public bool IsMakerUp
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObserverField()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Close(long AskVol, long BidVol, int indBar)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObserverField()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateVisibleDecoratorValidator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObserverField SimulateSequentialValidatorReg()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private bool isAllocatorProgramEditor;

	[CompilerGenerated]
	private Color _AllocatorEditorDispatcher;

	[CompilerGenerated]
	private Color m_GenericConfigurationAllocator;

	[CompilerGenerated]
	private bool isAllocatorDispatcherVerifier;

	[CompilerGenerated]
	private Color scheduledProxy;

	[CompilerGenerated]
	private Color m_DynamicSubscriberAllocator;

	[CompilerGenerated]
	private bool isStreamCreator;

	[CompilerGenerated]
	private int allocatorVerifierStrategyFreq;

	[CompilerGenerated]
	private int allocatorStrategyHandlerRank;

	[CompilerGenerated]
	private int m_AllocatorHandlerTransformers;

	[CompilerGenerated]
	private Color m_AttachedDic;

	[CompilerGenerated]
	private Color _InterruptibleProcAllocator;

	[CompilerGenerated]
	private Color m_AllocatorTransformerManager;

	[CompilerGenerated]
	private GenericArgumentGenerator m_DividedStateAllocator;

	[CompilerGenerated]
	private int internalTransmitterAllocatorIndex;

	[CompilerGenerated]
	private int adaptableObserverAllocatorTotal;

	[CompilerGenerated]
	private int inspectorWatcherAge;

	[CompilerGenerated]
	private int _ProjectSetFlag;

	[CompilerGenerated]
	private int _ScalableEngineAllocatorCnt;

	[CompilerGenerated]
	private int _FormatterDefinitionVol;

	[CompilerGenerated]
	private int visualObserverPerc;

	[CompilerGenerated]
	private int errorBufferValue;

	[CompilerGenerated]
	private int statelessCompilerLevel;

	[CompilerGenerated]
	private int _FilterInspectorPos;

	[CompilerGenerated]
	private int managerProcessorAllocatorCap;

	[CompilerGenerated]
	private int _ExtendedDefinitionFreq;

	[CompilerGenerated]
	private int customizableEmitterAllocatorErrorCode;

	[CompilerGenerated]
	private int m_ProgramDecoratorId;

	[CompilerGenerated]
	private int literalVisitorAllocatorId;

	[CompilerGenerated]
	private int m_SystemOrderInterval;

	[CompilerGenerated]
	private int _SequentialBuilderAllocatorDist;

	[CompilerGenerated]
	private Color m_AllocatorProcessorReg;

	[CompilerGenerated]
	private Color _TokenStack;

	[CompilerGenerated]
	private bool _IsAllocatorRegFinalizer;

	[CompilerGenerated]
	private int allocatorFinalizerModelInterval;

	[CompilerGenerated]
	private int integratedClientAllocatorVol;

	[CompilerGenerated]
	private SequentialAttributeReg.PropertyPosition m_CreatorMapper;

	[CompilerGenerated]
	private double m_PortableStubAllocator;

	[CompilerGenerated]
	private int m_AllocatorModelFactoryRank;

	private TesterParser groupedObjectAllocator;

	private ObserverField m_ModularTokenAllocator;

	private ObserverField allocatorFactoryReceiver;

	private bool _IsAllocatorReceiverProfiler;

	private int _AllocatorProfilerEnumeratorCounter;

	private int allocatorEnumeratorExecutorLength;

	private int connectedCompilerAllocatorVal;

	private int _AllocatorExecutorFinderCount;

	private int m_ListenerRequesterVol;

	private bool isRemoteChooser;

	private bool isFlexibleExtractorAllocator;

	private int _SeparatedNotifierCount;

	private bool m_IsMonoQueueAllocator;

	private int sharerListSize;

	private int logicalEventAllocatorDepth;

	private int _RegModuleSpecErrorCode;

	private int _SetSolverCount;

	private int m_AllocatorFinderStreamAge;

	private bool isReadableDistributorAllocator;

	private int m_IsolatedMemberAllocatorIndex;

	private int extendedServerAllocatorTotal;

	private int allocatorStreamProjectSize;

	private int _RemoteRequesterAllocatorSize;

	private int m_RandomReporterAllocatorPnts;

	private int m_SimpleThreadAllocatorRate;

	private int m_ConnectedSolverLength;

	private int _SingletonDicVol;

	private int m_ProjectErrorAllocatorPnts;

	private int _GeneralGatewayAllocatorLevel;

	private int m_AllocatorErrorCreatorAge;

	private int segmentedSorterAllocatorOffset;

	private bool m_IsSortedAdapterAllocator;

	private DateTime m_AllocatorCreatorSet;

	private InspectorMatcherAllocatorType setInitializerAllocator;

	private int localTaskAllocatorCount;

	private int m_BasicContainerAllocatorValue;

	private int m_InternalMapperLocatorTotal;

	private int joinedProfileAllocatorLimit;

	private bool m_IsPredictorTemplate;

	private bool isStaticListAllocator;

	private AllocatorCompilerEvent<MapResponderLocator.EfficientStructRequester> _AllocatorSetBuffer;

	private RequesterTagExplorer _SpecIterator;

	private RequesterTagExplorer _AllocatorBufferMapper;

	private RequesterTagExplorer _FilteredProviderAllocator;

	private List<ControllerStack> _MapperSolverAllocators;

	private List<ControllerStack> _AllocatorSolverAuthorizers;

	private IMonoCalcViewer transformableControllerAllocator;

	private SequentialAttributeReg _VirtualLoggerAllocator;

	private SequentialAttributeReg.LocatorBridgeRequester m_AllocatorAuthorizerSpec;

	private static ScheduledSystemAllocator SimulateAdvancedDecryptorDefinition;

	[Category("Volume Marker")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public bool VolMarkerEnabled
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[Category("Volume Marker")]
	public int VolMarkerLength
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

	[Category("Volume Marker")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public Color VolUpColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("Volume Marker")]
	public Color VolDownColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[Category("Volume Marker")]
	public int VolBarPassed
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 550000000.0)]
	[Category("Volume Marker")]
	public int VolMinVolume
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

	[Category("Volume Marker")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 550000000.0)]
	public int VolMinDelta
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Trade Marker")]
	public bool TradeMarkerEnabled
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
	[Category("Trade Marker")]
	public int TradeMarkerLength
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

	[Category("Trade Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public Color TradeUpColor
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

	[Category("Trade Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public Color TradeDownColor
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

	[Category("Trade Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public int TradeBarPassed
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

	[Category("Trade Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5, MaxValue = 550000000.0)]
	public int TradeMinTrade
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

	[Category("Trade Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6, MaxValue = 550000000.0)]
	public int TradeMinDelta
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Capping Marker")]
	public bool CappingMarkerEnabled
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public int CappingRangeParam
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public int CappingNumComparison
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public int CappingMaxVolume
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	public Color CappingRangeColor
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
	public Color CappingTradeColor
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
	public Color CappingBothColor
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7)]
	public GenericArgumentGenerator FilterCappingMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GenericArgumentGenerator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Box Range Detector")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public int BoxRangeTickRange
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[Category("Box Range Detector")]
	public int BoxRangeMinNumBar
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

	[Category("Box Range Detector")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public int BoxRangeTickMargin
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

	[Category("Box Range Detector")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public int BoxRangeProjBar
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

	[Category("Box Trade Detector")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public int BoxTradeTickRange
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

	[Category("Box Trade Detector")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 25000000.0)]
	public int BoxTradeMinNumTrade
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

	[Category("Box Trade Detector")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public int BoxTradeTickMargin
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

	[Category("Box Trade Detector")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	public int BoxTradeProjBar
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

	[Category("HFT Settings")]
	[DisplayName("Filter Min.")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	public int FilterMin
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

	[Category("HFT Settings")]
	[DisplayName("Filter Max.")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	public int FilterMax
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

	[DisplayName("Minimum Sum Volume")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	[Category("HFT Settings")]
	public int MinimumTotal
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

	[Category("HFT Settings")]
	[DisplayName("Minimum Tick Range")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	public int MinTick
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

	[DisplayName("Minimum Retracement")]
	[Category("HFT Settings")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public int MinRetracement
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5)]
	[DisplayName("Minimum Bar Passed")]
	[Category("HFT Settings")]
	public int HFTMinBarPassed
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

	[Category("Zone Settings")]
	public int ZoneMaxBarPassed
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

	[Category("Zone Settings")]
	public int ZoneThrowBack
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

	[Category("Zone Settings")]
	public int ZoneTickRange
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

	[Category("Zone Settings")]
	public int ZoneProjectionBar
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

	[Category("Zone Settings")]
	public Color ZoneSupport
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

	[Category("Zone Settings")]
	public Color ZoneResistance
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

	[Category("Trading Settings")]
	public bool TradingEnabled
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

	[Category("Trading Settings")]
	public int TradingQuantity
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

	[Category("Trading Settings")]
	public int TradingNumberBar
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

	[DisplayName("Zig Zag Mode")]
	[Category("Zig Zag Settings")]
	public SequentialAttributeReg.PropertyPosition ZigZagMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SequentialAttributeReg.PropertyPosition)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(DecimalPosToShow = 2, MaxValue = 100.0)]
	[DisplayName("Zig Zag Abs. Rev")]
	[Category("Zig Zag Settings")]
	public double ZigZagAbsParam
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

	[Category("Zig Zag Settings")]
	[DisplayName("Zig Zag Tick Rev./Highest Lowest")]
	public int ZigZagTickHLParam
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
	static ScheduledSystemAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 6;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555665)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x46C220EC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C0FBA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator._OrderThreadVol);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScheduledSystemAllocator(ScopeEncryptor.HiddenModelDecider first, MapResponderLocator.TransformableUserEncryptor second, int flags_temp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool rejectdef, bool isattr)
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
	public override void DecodeListener(bool noinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignLiteralState(int positionkey, TesterParser cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryDefinition(TesterParser item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignDetachedConsumer(int res_Position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator reference, bool allowvisitor, MapResponderLocator.TokenParameterViewer dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AssignExtendedTemplate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseCustomTag()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseAttachedChecker(int i_min, double ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CombineService(int IDinit, bool istoken)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TestSchema(int idx_first, bool iscol)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AllocateFlexiblePool(int first_high, int cont_counter, bool skiprole)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ParseTracker(int index_v, int remove_ORDAt, bool isdir)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateStaticTransformer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SolveVerifier(bool appendinstance, int max_attr, int maxthird, int param2low)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseAutomatedTree(SingletonHandlerConnection.ObjectAuthenticatorLocator ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignJoinedGenerator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool stripinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool updateparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer IncludeProgram(bool allowvalue, int removePOLAt, double pool, double selection2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseConnectedProject(bool isres, int end_selection, Color filter, int positionvar12)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DecompressParameter(Color var1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateOrderedDefinitionSelector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScheduledSystemAllocator CloseCache()
	{
		return null;
	}
}
