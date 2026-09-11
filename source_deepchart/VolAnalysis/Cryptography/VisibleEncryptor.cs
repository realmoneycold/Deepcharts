using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Cryptography;

internal class VisibleEncryptor : LocatorRequest
{
	internal enum LocatorPrintingPermissionLevel
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order
	}

	[Serializable]
	internal struct ProfileSettings
	{
		internal enum IdentifiableRunnerGeneratorKind
		{
			Daily,
			Weekly,
			Monthly,
			AllBars
		}

		internal static object SimulateAutomatedContextBuffer;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("Profile Settings")]
		public IdentifiableRunnerGeneratorKind LenthType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (IdentifiableRunnerGeneratorKind)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Profile Settings")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 30.0)]
		public int Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Profile Settings")]
		[DisplayName("Ticks per Bar")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 200.0)]
		public int TicksPerBar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 2147483647.0)]
		[DisplayName("Peak/Valley Sensitivty")]
		[Category("Profile Settings")]
		public int PeakValleySensitivty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MaxValue = 1000.0)]
		[DisplayName("Exclude Peak/Valley High/Low")]
		[Category("Profile Settings")]
		public bool PVExcludeHL
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Peak Min. Vol")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 2147483647.0)]
		[Category("Profile Settings")]
		public int PeakMinVol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Profile Settings")]
		[DisplayName("Valley Max. Vol")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 2147483647.0)]
		public int ValleyMaxVol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Delta Imbalance Num Tick")]
		[Category("Profile Settings")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7, MaxValue = 2147483647.0)]
		public int DeltaImbNumTick
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Delta Imblanace Max. Vol")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8, MaxValue = 2147483647.0)]
		[Category("Profile Settings")]
		public int DeltaImbMaxVol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[Category("Enables")]
		[DisplayName("Point of Control")]
		public bool enablePoc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Value Area")]
		[Category("Enables")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		public bool enableVA
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		[Category("Enables")]
		[DisplayName("Peak")]
		public bool enablePeak
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[DisplayName("Valley")]
		[Category("Enables")]
		public bool enableValley
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[DisplayName("Delta Imbalance")]
		[Category("Enables")]
		public bool enableDeltaImb
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Visual Appearance")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[DisplayName("Point of Control")]
		public Color colorPoc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Visual Appearance")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
		[DisplayName("Value Area")]
		public Color colorVA
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Visual Appearance")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[DisplayName("Peak")]
		public Color colorPeak
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Visual Appearance")]
		[DisplayName("Valley")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
		public Color colorValley
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[DisplayName("Valley")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		[Category("Visual Appearance")]
		public Color colorDeltaImbalance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
		[Category("Visual Appearance")]
		[DisplayName("Line Width")]
		public int LineWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Visual Appearance")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
		[DisplayName("Line Width")]
		public DashStyle LineStyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProfileSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckReg()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateConvertibleMonitorState()
		{
			return null;
		}
	}

	internal enum RequesterChartValueType
	{
		ZigZag,
		Date
	}

	private class WrapperDecorator
	{
		internal class RegListSelector
		{
			internal class DeciderCalcElement
			{
				public MapResponderLocator.EfficientStructRequester m_DeciderClientEngine;

				public bool isMonitorLocator;

				public bool m_IsConnectedInitializerDecider;

				public bool m_IsDeciderElementContext;

				public RequesterTagExplorer _LogicalFilter;

				public RequesterTagExplorer _TransformerWatcher;

				internal static DeciderCalcElement SimulateScheduledParserProgram;

				[MethodImpl(MethodImplOptions.NoInlining)]
				public DeciderCalcElement()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static DeciderCalcElement()
				{
					WrapperStreamEditor.AnalyzeRecord();
					WrapperStreamEditor.CoverPortableElement();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool MeasureWatcher()
				{
					return true;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DeciderCalcElement SimulateExternalPublisherParameter()
				{
					return null;
				}
			}

			public RequesterTagExplorer regFinalizerToken;

			public RequesterTagExplorer fieldProfile;

			public RequesterTagExplorer m_GeneralIterator;

			public AllocatorCompilerEvent<DeciderCalcElement> profileEmitter;

			public int m_RegSelectorTokenizerAge;

			public int m_EnumeratorSelectorFreq;

			public bool m_IsSortedPolicyReg;

			public int m_InterpreterEventIndex;

			public int m_RegTokenGeneratorLevel;

			public HashSet<int> m_RegTokenizerChooser;

			public HashSet<int> _RegGeneratorRecommender;

			public HashSet<int> _PortableWriterReg;

			public int _RegChooserAllocatorRank;

			public long _IntegratedSystemRegValue;

			public long configurableOrderFreq;

			public int genericStrategyRegStep;

			public int _AccessibleTransactionRegCap;

			public int _RegRecommenderProcScore;

			public int _AllocatorModelRegDepth;

			internal static RegListSelector AttachDetailedProcIterator;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RegListSelector()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RegListSelector()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AttachVisualIteratorPredicate()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static RegListSelector InvokeProfiler()
			{
				return null;
			}
		}

		public int _ExtendedProfileWrapperFreq;

		public List<RequesterTagExplorer> _StatelessMonitorWrapperList;

		public bool _IsTransactionReporter;

		public List<RegListSelector> queueSharerList;

		public DateTime adapterViewer;

		public ProfileSettings aggregatorAuditor;

		public bool m_IsScalableListWrapper;

		public int _ScheduledParserWrapperId;

		public int validatorDecryptorPnts;

		internal static WrapperDecorator AdaptSorter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperDecorator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperDecorator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateGroupedTagChecker()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperDecorator InvokeInspector()
		{
			return null;
		}
	}

	private enum ScalableProcessorRequesterValues
	{
		Not,
		Up,
		Down
	}

	private class FilteredObjectReg
	{
		internal class AllocatorAuthorizerStack
		{
			public int Index;

			public int Price;

			public int visibleProgramAllocatorErrorCode;

			public int m_AllocatorSpecAttributeOffset;

			public int _AllocatorStackUserPnts;

			public int _ControllableEditorAllocatorRank;

			public bool isCommonDispatcherAllocator;

			public bool _IsRequestProxy;

			public bool isAllocatorAttributeTransaction;

			public bool m_IsCustomizableCalcGenerator;

			public int m_CustomVerifierAllocatorValue;

			public ScalableProcessorRequesterValues _ScopeStrategyAllocator;

			internal static AllocatorAuthorizerStack AttachActiveExplorerSpec;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AllocatorAuthorizerStack()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AllocatorAuthorizerStack()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AttachFilteredSpecSystem()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static AllocatorAuthorizerStack AttachPortableSystemProfiler()
			{
				return null;
			}
		}

		public double regDictionaryViewer;

		public int _DicSetDepth;

		public double detachedClientReg;

		public double checkerGateway;

		public int m_ValidatorReceiverFreq;

		public bool m_IsDynamicConnection;

		public double m_ElementAnalyzerReg;

		public double _TrackerDistributor;

		public double regViewerSummarizer;

		public double m_SetAttributeReg;

		public double m_RegAnalyzerResponder;

		public ScalableProcessorRequesterValues regSummarizerArgument;

		public Color _ExternalInterpreter;

		public Color m_RegResponderCollector;

		public RequesterTagExplorer _RegArgumentExecutor;

		public RequesterTagExplorer _ScopeSetReg;

		public DashStyle collectorConnectionReg;

		public bool _IsReceiverBuffer;

		public RequesterTagExplorer m_RegExecutorState;

		public List<RequesterTagExplorer> commonDefinitionList;

		public List<AllocatorAuthorizerStack> sequentialWatcherRegList;

		internal static FilteredObjectReg GenerateIterableExecutorViewer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilteredObjectReg()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FilteredObjectReg()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachHiddenViewerAdapter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FilteredObjectReg AddCollection()
		{
			return null;
		}
	}

	private class SenderConsumerLocator
	{
		public int locatorProgramSharerErrorCode;

		public int m_StatelessEmitterLocatorFreq;

		public int customizableAttributeLocatorIndex;

		public int locatorConsumerBridgeScore;

		public int m_DecryptorCreatorPerc;

		public int _NodeCommandLimit;

		internal static SenderConsumerLocator AttachLocalAttributeBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SenderConsumerLocator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SenderConsumerLocator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachConfigurableBuilderCollector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SenderConsumerLocator PauseDictionary()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private LocatorPrintingPermissionLevel transactionResponder;

	[CompilerGenerated]
	private int interpreterEncryptorPerc;

	[CompilerGenerated]
	private int encryptorAuditorDist;

	[CompilerGenerated]
	private int _AnalyzerServerLength;

	[CompilerGenerated]
	private int _InterruptibleAnalyzerLength;

	[CompilerGenerated]
	private RequesterChartValueType m_EncryptorCache;

	[CompilerGenerated]
	private DateTime _AutomatableEncryptor;

	[CompilerGenerated]
	private double m_FinderTracker;

	[CompilerGenerated]
	private int m_EncryptorBufferIndex;

	[CompilerGenerated]
	private double encryptorError;

	[CompilerGenerated]
	private bool _IsEncryptorMatcher;

	[CompilerGenerated]
	private bool m_IsGlobalEncryptor;

	[CompilerGenerated]
	private bool _IsConverterProject;

	[CompilerGenerated]
	private ProfileSettings groupedEncryptor;

	[CompilerGenerated]
	private bool _IsEncryptorPool;

	[CompilerGenerated]
	private int activeEncryptorOffset;

	[CompilerGenerated]
	private bool m_IsOrderedEncryptor;

	[CompilerGenerated]
	private ProfileSettings _EncryptorField;

	[CompilerGenerated]
	private bool isSortedStub;

	[CompilerGenerated]
	private int m_ModelEncryptors;

	[CompilerGenerated]
	private bool isExtendedEncryptor;

	[CompilerGenerated]
	private ProfileSettings m_InterruptibleEncryptor;

	[CompilerGenerated]
	private bool _IsTransmitterAdapter;

	[CompilerGenerated]
	private int tokenizerMonitorCounter;

	[CompilerGenerated]
	private bool isControllableEncryptor;

	[CompilerGenerated]
	private bool _IsEncryptorAnnotation;

	[CompilerGenerated]
	private bool m_IsIterableEncryptor;

	[CompilerGenerated]
	private bool _IsEncryptorState;

	[CompilerGenerated]
	private bool _IsResolverEncryptor;

	[CompilerGenerated]
	private bool _IsInternalEnumerator;

	[CompilerGenerated]
	private bool _IsEncryptorExtractor;

	[CompilerGenerated]
	private Color encryptorExecutor;

	[CompilerGenerated]
	private Color _EncryptorFilter;

	[CompilerGenerated]
	private Color _EncryptorWorker;

	[CompilerGenerated]
	private Color dispatcherLocator;

	[CompilerGenerated]
	private Color _LogicalEncryptor;

	[CompilerGenerated]
	private Color _JoinedEncryptor;

	[CompilerGenerated]
	private int m_TransformableReporterLevel;

	[CompilerGenerated]
	private Color m_SimpleEncryptor;

	[CompilerGenerated]
	private int m_ExpandableIteratorCounter;

	[CompilerGenerated]
	private Color _ConfigurableEncryptor;

	[CompilerGenerated]
	private int localEncryptorVal;

	[CompilerGenerated]
	private Color attributeEncryptor;

	[CompilerGenerated]
	private Color _TransformableStruct;

	[CompilerGenerated]
	private int formatterEncryptorSize;

	[CompilerGenerated]
	private Color _DistributorChain;

	[CompilerGenerated]
	private int hiddenEncryptorPos;

	[CompilerGenerated]
	private Color m_EncryptorRequest;

	[CompilerGenerated]
	private int generatorControllerIndex;

	[CompilerGenerated]
	private Color m_CombinedEncryptor;

	private List<WrapperDecorator> m_SymbolicEncryptors;

	private FilteredObjectReg m_ModularEncryptor;

	private FilteredObjectReg _PortableRunnerEncryptor;

	private List<int> _TrackerConfigurations;

	private List<int> detailedTransformerEncryptors;

	private MapResponderLocator.FilterWatcherLocator genericConverterEncryptor;

	private (int, Color)[] readableClientEncryptors;

	private (int, Color)[] enumeratorGeneratorItems;

	private bool _IsResponderLocator;

	private RequesterTagExplorer m_EncryptorReg;

	private int _MonitorArgumentScore;

	private long m_IntegratedMapperEncryptorRate;

	private long _CommonGatewayEncryptorIdx;

	internal static VisibleEncryptor AttachExpandableDecorator;

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public LocatorPrintingPermissionLevel InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorPrintingPermissionLevel)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Data Settings")]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 500.0, MinValue = 1.0)]
	[DisplayName("Tick Sensitivity")]
	[Category("Confluence Settings")]
	public int TickSensConf
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 500.0, MinValue = 1.0)]
	[DisplayName("Min Num of Confluence")]
	[Category("Confluence Settings")]
	public int MinNumConf
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 10.0, DecimalPosToShow = 2, IncrementValue = 0.2)]
	[DisplayName("Starting Mode")]
	[Category("Confluence Settings")]
	public RequesterChartValueType ConfIniMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RequesterChartValueType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Confluence Settings")]
	[DisplayName("Start Date")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 100.0, MinValue = 1.0)]
	public DateTime ConfIniDt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Confluence Settings")]
	[DisplayName("Absolute % of Rev. for Zig Zag Trend")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, MaxValue = 10.0, DecimalPosToShow = 2, IncrementValue = 0.2)]
	public double ZigZagRevTrend
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

	[DisplayName("Number of Swing")]
	[Category("Confluence Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5, MaxValue = 100.0, MinValue = 1.0)]
	public int numOfSwingForTrend
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MaxValue = 10.0, DecimalPosToShow = 2, IncrementValue = 0.1)]
	[Category("Zig Zag Swing")]
	[DisplayName("Absolute % of Rev. for Zig Zag Swing")]
	public double ZigZagRevSwing
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

	[DisplayName("Enable Zig Zag Swing")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[Category("Zig Zag Swing")]
	public bool enableZigZagSwing
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Include Swing Before Mid Trend")]
	[Category("Zig Zag Swing")]
	public bool includeSwingBeforeMid
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

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[Category("First Vbp")]
	public bool FirstVbpEnable
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

	[Category("First Vbp")]
	[DisplayName("Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public ProfileSettings FirstVbpSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ProfileSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("First Vbp")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	[DisplayName("Include Based on Numer")]
	public bool FirstVbpBasedNumber
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

	[Category("First Vbp")]
	[DisplayName("Number of Profile")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public int FirstVbpNumber
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

	[Category("Second Vbp")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool SecondVbpEnable
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
	[DisplayName("Settings")]
	[Category("Second Vbp")]
	public ProfileSettings SecondVbpSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ProfileSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	[DisplayName("Include Based on Numer")]
	[Category("Second Vbp")]
	public bool SecondVbpBasedNumber
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	[DisplayName("Number of Profile")]
	[Category("Second Vbp")]
	public int SecondVbpNumber
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

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	[Category("Third Vbp")]
	public bool ThirdVbpEnable
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

	[DisplayName("Settings")]
	[Category("Third Vbp")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	public ProfileSettings ThirdVbpSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ProfileSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	[DisplayName("Include Based on Numer")]
	[Category("Third Vbp")]
	public bool ThirdVbpBasedNumber
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	[Category("Third Vbp")]
	[DisplayName("Number of Profile")]
	public int ThirdVbpNumber
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

	[Category("Trend Retracement Enables")]
	[DisplayName("Enable Retracement")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	public bool enableSwingRetr
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

	[Category("Trend Retracement Enables")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
	[DisplayName("38.2%")]
	public bool enableRetr38
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

	[DisplayName("50%")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	[Category("Trend Retracement Enables")]
	public bool enableRetr50
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

	[DisplayName("61.8")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	[Category("Trend Retracement Enables")]
	public bool enableRetr62
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
	[DisplayName("75%")]
	[Category("Trend Retracement Enables")]
	public bool enableRetr75
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

	[DisplayName("Exclude previous retracements")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
	[Category("Trend Retracement Enables")]
	public bool excludeOldRetr
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	[DisplayName("Show Lines")]
	[Category("Developing")]
	public bool enableDevLines
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1)]
	[DisplayName("Trend Up Color Line")]
	[Category("Developing")]
	public Color trendColorUp
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

	[Category("Developing")]
	[DisplayName("Trend Down Color Line")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	public Color trendColorDown
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

	[DisplayName("Swing Up Color Line")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3)]
	[Category("Developing")]
	public Color swingColorUp
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

	[Category("Developing")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 4)]
	[DisplayName("Swing Down Color Line")]
	public Color swingColorDown
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

	[Category("Developing")]
	[DisplayName("Vert. Line Starting Point")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	public Color VSwingLineColor
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

	[StaticStructAllocator(SubCategory = "Range 1", CategoryIndex = 8, PropertyIndex = 0)]
	[Category("Support Zones")]
	[DisplayName("Color")]
	public Color SuppColor1
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

	[Category("Support Zones")]
	[DisplayName("Min Number +")]
	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 8, PropertyIndex = 1)]
	public int SuppRange2
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

	[DisplayName("Color")]
	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 8, PropertyIndex = 2)]
	[Category("Support Zones")]
	public Color SuppColor2
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

	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 8, PropertyIndex = 3)]
	[DisplayName("Min Number +")]
	[Category("Support Zones")]
	public int SuppRange3
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

	[Category("Support Zones")]
	[DisplayName("Color")]
	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 8, PropertyIndex = 4)]
	public Color SuppColor3
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

	[Category("Support Zones")]
	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 8, PropertyIndex = 5)]
	[DisplayName("Min Number +")]
	public int SuppRange4
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

	[Category("Support Zones")]
	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 8, PropertyIndex = 6)]
	[DisplayName("Color")]
	public Color SuppColor4
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

	[Category("Resistence Zones")]
	[DisplayName("Color")]
	[StaticStructAllocator(SubCategory = "Range 1", CategoryIndex = 9, PropertyIndex = 0)]
	public Color ResColor1
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

	[DisplayName("Min Number +")]
	[Category("Resistence Zones")]
	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 9, PropertyIndex = 1)]
	public int ResRange2
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

	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 9, PropertyIndex = 2)]
	[Category("Resistence Zones")]
	[DisplayName("Color")]
	public Color ResColor2
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

	[Category("Resistence Zones")]
	[DisplayName("Min Number +")]
	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 9, PropertyIndex = 3)]
	public int ResRange3
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

	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 9, PropertyIndex = 4)]
	[DisplayName("Color")]
	[Category("Resistence Zones")]
	public Color ResColor3
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

	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 9, PropertyIndex = 5)]
	[Category("Resistence Zones")]
	[DisplayName("Min Number +")]
	public int ResRange4
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

	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 9, PropertyIndex = 6)]
	[Category("Resistence Zones")]
	[DisplayName("Color")]
	public Color ResColor4
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisibleEncryptor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 6;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_af271e62bca64cb1bd7376e6543250e0 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555363));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B251566 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED02E7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7429B4B0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x56440C0D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316AC5D8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisibleEncryptor(ScopeEncryptor.HiddenModelDecider setup, MapResponderLocator.TransformableUserEncryptor vis, int flags_pool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool initopen, bool isattr)
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
	private RequesterTagExplorer EncryptLocalSelector(int indexinfo, int sum_ord, Color temp)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer EncryptConfigurableInitializer(int position_res, double ivk, Color comp, int t2, DashStyle pred3, bool removex4 = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CheckMixedResponder(int size_config, int end_selection, double dir, double config2, Color cust3, bool islast4, bool visitor5open, bool isresult6, bool updatevar17)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CompressAttribute(int endident, int ivklength, double state, double param2, Color t3, int task4min, DashStyle init5, bool iskey6 = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator reference, bool checkcfg, MapResponderLocator.TokenParameterViewer res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncryptMonoService(WrapperDecorator spec, SingletonHandlerConnection.ObjectAuthenticatorLocator selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeExternalSchema(int v_size, WrapperDecorator.RegListSelector selection, int column_state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncryptAccessibleValue(WrapperDecorator def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodePassiveTracker(WrapperDecorator v, WrapperDecorator.RegListSelector vis, MapResponderLocator.EfficientStructRequester res, out bool ord2, out bool token3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EncodeAdaptableList(WrapperDecorator first, WrapperDecorator.RegListSelector map, MapResponderLocator.EfficientStructRequester field)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EncryptRandomLocator(FilteredObjectReg res, double cust)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QuerySender()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveVisitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeDividedParser(List<MapResponderLocator.GeneratorResponder> var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool nokey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAutomatableValidator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VisibleEncryptor SimulateCombinedReg()
	{
		return null;
	}
}
