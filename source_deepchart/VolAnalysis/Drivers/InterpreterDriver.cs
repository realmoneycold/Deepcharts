using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Controls;
using VolAnalysis.Creations;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Grid;
using VolumetricaControls;

namespace VolAnalysis.Drivers;

internal class InterpreterDriver : Window, IComponentConnector
{
	private enum ViewerTreeBufferStatus
	{
		VarPerc,
		VarOpenPerc
	}

	private enum AccessibleFactoryDriverKinds
	{
		BidPL,
		BidOffer,
		BuyCancel,
		BidQty,
		BidPrice,
		AskPrice,
		AskQty,
		SellCancel,
		AskOffer,
		AskPL
	}

	private enum AllocatorViewerConfigStatus
	{
		None = 0,
		Open = 2,
		High = 3,
		Low = 4
	}

	private class FormatterPredictor
	{
		public long m_VisitorRequestRate;

		public bool isSortedCollectionWrapper;

		public int m_WrapperNodeScore;

		public decimal Qty;

		private static FormatterPredictor SimulateStaticMapperMatcher;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormatterPredictor()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormatterPredictor()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SolveFinalizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FormatterPredictor FillResolver()
		{
			return null;
		}
	}

	private class CommonMapperDecider
	{
		public List<FormatterPredictor> _DeciderAnalyzerSystems;

		public List<FormatterPredictor> m_DeciderResponderServers;

		internal static CommonMapperDecider GenerateJoinedTransmitterProc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CommonMapperDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CommonMapperDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachConvertibleProcIterator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CommonMapperDecider AttachConnectedIteratorPredicate()
		{
			return null;
		}
	}

	private class LocatorProjectMatcher
	{
		public SpecTagDecider m_DetachedInspectorLocator;

		public SpecTagDecider _DecoratorAdapterLocator;

		public SpecTagDecider _LocatorMatcherTask;

		public SpecTagDecider groupedInterpreterLocator;

		public SpecTagDecider _TransformerObject;

		public SpecTagDecider _LocatorAdapterChecker;

		public int _ExpandableDistributorLocatorStep;

		public int Qty;

		public int m_ServiceReporterRate;

		[CompilerGenerated]
		private readonly bool m_IsIdentifiableViewerLocator;

		private static LocatorProjectMatcher AttachExpandablePredicateExplorer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocatorProjectMatcher(bool containsparam)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public bool CloseDynamicPolicy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LocatorProjectMatcher()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAutomatableExplorerSpec()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LocatorProjectMatcher SimulateCombinedSpecSystem()
		{
			return null;
		}
	}

	private enum LanguageVersion
	{
		Price
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CChangeSymbol_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		public FontWeight flushLock;

		public ResponsiveSingleton newSymb;

		private TaskAwaiter _003C_003Eu__1;

		private static object MeasureDistributor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CChangeSymbol_003Ed__77()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SplitCreator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAccessibleEditorCache()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFullReset_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		public FontWeight bookLockAction;

		public bool needInit;

		private CancellationToken _003Ctoken_003E5__2;

		private CustomDecider _003ColdSymbContr_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private LocatorSelectorTransaction _003CfeedConnection_003E5__4;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private static object CancelElement;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CFullReset_003Ed__86()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAdaptableSubscriberClient()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NewEncryptor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadTemplate_003Ed__142 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		public LoggerRecord item;

		private ScalableRequester _003Cdlg_003E5__2;

		private DomTemplateItemClass _003CtempItem_003E5__3;

		private TaskAwaiter<DomTemplateItemClass> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		internal static object AttachDynamicExecutorViewer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CLoadTemplate_003Ed__142()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EnableFunction()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachDividedAdapterAttribute()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnTradingOpenClose_003Ed__116 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LocatorSelectorTransaction sender;

		public InterpreterDriver _003C_003E4__this;

		private static object SimulateIsolatedAttributeBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003COnTradingOpenClose_003Ed__116()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSeparatedBuilderCollector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JoinSynchronizer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CdgwBook_SizeChanged_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ResumeSingleton;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CdgwBook_SizeChanged_003Ed__81()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateScopeManagerMember()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FlushAnalyzer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003ClblSymbol_Click_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object MatchWorker;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003ClblSymbol_Click_003Ed__76()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PrepareSolver()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateSetVisitorDecryptor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmEnableFund_Click_003Ed__138 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		internal static object AttachSortedDecryptorDefinition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CtsmEnableFund_Click_003Ed__138()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BuildQueue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateSequentialSelectorInitializer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmSettingsDom_Click_003Ed__140 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AttachTransformableInitializerResponder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CtsmSettingsDom_Click_003Ed__140()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateGenericResponderAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecodeProfile()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmTempSaveAs_Click_003Ed__143 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InterpreterDriver _003C_003E4__this;

		private LoggerRecord _003CpickerItem_003E5__2;

		private ScalableRequester _003Cdlg_003E5__3;

		private DomTemplateItemClass _003CnewTemp_003E5__4;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		internal static object AttachDetailedServiceSchema;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CtsmTempSaveAs_Click_003Ed__143()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool StartCache()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateStatelessValueTracker()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private ResponsiveSingleton tokenizerDriver;

	private CustomDecider _GroupedDriver;

	private int _FlexibleDriverAge;

	private int _SequentialSummarizerLength;

	private int m_DriverHandlerInterval;

	private int _SpecDecoratorRate;

	private int customPublisherSize;

	private int customDriverErrorCode;

	private double sequentialProject;

	private bool isIsolatedDriver;

	internal bool _IsDriverConfig;

	private bool m_IsContextValidator;

	private bool isAttachedDriver;

	private Workspace _SimpleDriver;

	private CalculatorLocator deciderDriver;

	private CalculatorLocator.OperationalTagLocator _DriverConnection;

	private DeciderVerifierViewer _ResponsiveDriver;

	private GeneratorConfigurationArgument.TransferableValueReg _DriverDefinition;

	private WriterServerRecommender driverVisitor;

	private HashSet<string> m_SeparatedDriver;

	private ServerDecider _MapperEncryptor;

	private ContextMenu cmsOrder;

	private bool _IsMixedDriver;

	private bool m_IsModularDriver;

	private decimal m_SubscriberStack;

	private bool isDriverClient;

	private double m_DriverChooser;

	private bool isModularPool;

	private bool m_IsDriverAttribute;

	private bool m_IsLiteralDriver;

	private decimal m_OperationalDriver;

	private double m_SolverSchema;

	private double m_SetDriver;

	private DateTime transferableDriver;

	private DateTime _GlobalDriver;

	private double segmentedLogger;

	private double _InterruptibleBridge;

	private double m_DriverAnnotation;

	private double _ScheduledProject;

	private double m_DriverDic;

	private int activeDriverLevel;

	private int driverCalculators;

	private double symbolicDriver;

	private double remoteDriver;

	private double driverEmitter;

	private double m_StubProc;

	private double m_MixedTracker;

	private double factoryAnnotation;

	private double m_DicMonitor;

	private long? _RandomDriver;

	private int? receiverDriver;

	private SingletonHandlerConnection.BridgeEnumerator passiveDriver;

	private bool m_IsRequestDriver;

	private TimeSpan _ListDriver;

	private BuilderWriter m_AutomatableDriver;

	private int m_DriverSchemaRank;

	private bool _IsContainerDefinition;

	private decimal generalDriver;

	private JoinedInterpreterDecider m_DriverSubscriber;

	private bool isStaticProfile;

	private Columns m_ResolverConverter;

	private Columns portableDriver;

	private Columns operationalAdapter;

	private Columns efficientDriver;

	private Columns driverResolver;

	private Columns _ModuleDefinition;

	private Columns m_ParserMapper;

	private Columns _EditableDriver;

	private Columns _MemberCommand;

	private Columns _DriverParser;

	private Columns _StackDriver;

	private Columns m_DividedMember;

	private AllocatorCompilerEvent<LocatorProjectMatcher> _DynamicDriver;

	private List<LocatorProjectMatcher> m_GenericDriverList;

	private List<LocatorProjectMatcher> _ConverterDriverList;

	private int _TransferableRecordDist;

	private int m_DriverMapperNum;

	private int m_DriverTrackerNum;

	private int m_DriverResponderCnt;

	private int _DriverFinderLength;

	private int _ExplorerDriverId;

	private int driverDictionaryVol;

	private int _DriverErrorPos;

	private int m_StackTrackerScore;

	private int _EditableRegRank;

	private int m_StreamCacheAge;

	private int _ArgumentStackFreq;

	private int expandableDriverLevel;

	private int _DriverTracerCap;

	private int m_SortedDriverLevel;

	private int m_ScalableDriverFlag;

	private int m_InternalDriverDepth;

	private decimal _DicCalc;

	private bool m_IsDriverServer;

	private SpecTagDecider iterableDriver;

	private int m_StreamAuthorizerTotal;

	private int driverProcLevel;

	private int _FilteredDriverLimit;

	private int _FieldDriverRank;

	private int _StaticDriverFlag;

	private int _DriverMonitorDepth;

	private int m_EvaluatorSetCap;

	private int converterResponderAge;

	private int _DriverDriverTotal;

	private int factoryDefinitionInterval;

	private int _DriverIteratorInterval;

	private int _DriverStrategyValue;

	private int m_DriverEvaluatorSize;

	private int m_CentralDriverPosition;

	private int m_VisualDriverIndex;

	private int integratedDriverLevel;

	private bool m_IsSymbolicAuthorizer;

	private bool isAllocatorDriver;

	private bool isMixedExecutor;

	private bool isRandomDic;

	private bool _IsProjectProfile;

	private Dictionary<long, FormatterPredictor> _CombinedDriverMap;

	private Dictionary<long, CommonMapperDecider> m_AdaptableDriverMap;

	private Lock m_LocalDriver;

	private long m_DriverLoggerPerc;

	private long detailedDriverInterval;

	private FormatterPredictor mapperFinder;

	private int m_AdjustableDriverPos;

	private int dispatcherDriverDist;

	private int _ExtendedDriverPos;

	private int _EvaluatorSingletonPerc;

	private int m_ComparatorDriverTotal;

	private decimal driverMap;

	private double _AlphabeticDriver;

	private bool m_IsDriverTransformer;

	private bool m_IsTrackerExplorer;

	private bool m_IsTaskDecryptor;

	private int _VisibleDriverCnt;

	private int responderDictionaryValue;

	private object m_RecommenderPredicateObj;

	private DateTime _DriverSummarizer;

	private DateTime m_BasicDriver;

	private int m_DriverObserverRate;

	private int m_ServiceDriverInterval;

	internal Grid grdTop;

	internal StackPanel topLeftPnl;

	internal IconButton lblSymbol;

	internal ActiveLocatorAllocator lnkBtn;

	internal MenuItem btnSettings;

	internal MenuItem tsiDuplicateDom;

	internal MenuItem tsmSettingsDom;

	internal MenuItem tsmEnableFund;

	internal MenuItem tsmSettingProp;

	internal MenuItem tsmAlwaysOnTop;

	internal MenuItem tsmTemplate;

	internal MenuItem tsmTempLoad;

	internal MenuItem tsmTempSaveAs;

	internal TopRightPnl pnlTopRight;

	internal ComboBoxWithHeader cmbBroker;

	internal ComboBoxWithHeader cmbAccount;

	internal StaticRecordReg ctrlContractTradingInfo;

	internal FundamentalControl fndCtrl;

	internal FlexibleMemberAllocator domContainer;

	internal Border pnlTradingBtm;

	internal NumUpDown nudQty;

	internal NumUpDown nudPrice;

	internal ComboBoxWithHeader cmbOrderType;

	internal Button btnBuy;

	internal Button btnSell;

	internal Border pnlOcoStrategy;

	internal CheckBox ckbUseOco;

	internal RadioButton rdbOcoServer;

	internal RadioButton rdbOcoClient;

	internal IconStatusControl icoOcoStatus;

	internal ComboBox cmbOcoStrategy;

	internal IconButton btnOcoStrategy;

	private bool isDriverTransmitter;

	private static InterpreterDriver AttachControllableAttribute;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ResponsiveSingleton AssociateLocalQueue()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void ProfileConfigurableExtractor(ResponsiveSingleton value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InterpreterDriver(ServerDecider res, ResponsiveSingleton visitor, CalculatorLocator template, Workspace item2, bool writepol3, bool ismap4 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunSegmentedParameter(WrapperTextBoxMode ident, bool ispred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunCommonProxy(int first_High)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunControllableSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceRemoteServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlEfficientModule(LocatorStateAction param, string result = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormatArgument(bool referenceneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewConsumer(object first, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003ClblSymbol_Click_003Ed__76))]
	private void ForceGlobalReg(object init, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeSymbol_003Ed__77))]
	internal Task ControlDetachedFormatter(ResponsiveSingleton spec, FontWeight visitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertChecker(object var1, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceCustomCompiler(bool skipparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConvertEvaluator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CdgwBook_SizeChanged_003Ed__81))]
	private void ForceBasicSorter(object first, SizeChangedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunOperationalContainer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task ControlFlexibleInspector(bool acceptres)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlEditableTransaction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFullReset_003Ed__86))]
	private Task ForceStaticMapper(FontWeight v, bool isord = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void PlanGenerator(object init = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunAutomatedReporter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunJoinedTransmitter(bool keyopen, bool isconnection = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstantiateObserver(SingletonHandlerConnection.ObjectAuthenticatorLocator v, bool ivkneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AssembleRole(LocatorQueueTransferProtocol setup, object cont)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ForceExpandablePredicate(bool containsv)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunAutomatableExplorer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTime RunCombinedSpec(DateTime last)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool RunGroupedSystem(int? res, List<SingletonHandlerConnection.ObjectAuthenticatorLocator> connection, int? tag, List<SingletonHandlerConnection.AlphabeticExecutorReg> ivk2, out bool first3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RunIdentifiableProfiler(bool readconfig, bool isresult)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendChooser(object info, KeyEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlAdjustableCalculator(object reference, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PushReceiver(object var1, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunIterableWorker(Action value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long ForceHiddenSolver(long first_High, double connection, string res)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal long RunModularNotifier(string key, ScopeHandlerDecider.ResponsiveSpecGeneratorTypes visitor, bool removecontrol, double visitor2 = 0.0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RunLocalInterpreter(long key_length, string cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AnalyzeCalculator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunMixedExtractor(WriterServerRecommender item, HashSet<string> visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CompressWorker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunMonoWatcher(object spec, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunExternalProfile(object res, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetInterpreter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunPassiveCache(object reference, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlAdaptableSubscriber(object v, RoutedPropertyChangedEventArgs<decimal?> ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceRandomClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QueryWatcher(object key, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceReadableViewer(object first, SelectionChangedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveEditor(object res, SelectionChangedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnTradingOpenClose_003Ed__116))]
	private Task RunIsolatedAttribute(LocatorSelectorTransaction last, ReceiverValue.RegWLanProfileConnectionType attr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunSeparatedBuilder(LocatorSelectorTransaction value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CombineClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunVirtualStream(WriterServerRecommender key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunScopeManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlLogicalMember(object param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlGeneralProcessor(bool loadinfo = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceResponsiveSender(object spec, SelectionChangedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SolveCollector(object ident, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FillStream(object config, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunVisibleDefinition(object config, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceSequentialSelector(object param, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReceiveProcessor(object asset, EventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunGenericResponder(ComboBox first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceSimpleAuthorizer(object asset, MouseButtonEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceDetailedService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveDefinition(List<string> param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlStatelessValue(object param, EventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunActiveTracker(object ident, CancelEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceFilteredList(object def, SizeChangedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunPortableLocator(object key, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ArrangeService(object param, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmEnableFund_Click_003Ed__138))]
	private void RunConcreteProvider(object setup, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PostValue(object info, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmSettingsDom_Click_003Ed__140))]
	private void RunAdvancedProgram(object instance, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlOrderedPublisher(object item, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadTemplate_003Ed__142))]
	private void SearchLocator(LoggerRecord value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmTempSaveAs_Click_003Ed__143))]
	private void ManageVerifier(object last, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunCommonSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SplitParser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceRemoteModule()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceEfficientDecorator(bool istask = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceTransferableValidator(object reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunLiteralReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunGlobalFormatter(bool verifykey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float ControlDetachedGateway(AccessibleFactoryDriverKinds v, bool forceivk = false)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlExtendedCompiler(AccessibleFactoryDriverKinds info, bool tokenreguired = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Columns ControlCustomPolicy(DeciderVerifierViewer asset, string reg, Color helper, Color last2, Color? first3, bool allowreference4, double v5, bool comparecfg6 = false, ScalableParserWrapperFlags def7 = ScalableParserWrapperFlags.Center)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceAttachedSorter(int specmin)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceBasicContainer(int meani)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlOperationalInspector(int defHigh, SingletonHandlerConnection.IteratorStrategyDriver.RegElementSummarizer counter, bool removedir)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool PeekGateway(bool moveres = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlEditableError(LocatorProjectMatcher item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunIntegratedMapper(int max_init, AllocatorViewerConfigStatus counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceStaticMatcher(int indexOf_init, AllocatorViewerConfigStatus ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectContainer(int maxinfo, LocatorProjectMatcher cfg = null, bool isdir = true, bool? ord2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceAutomatedTransmitter(LanguageVersion reference, int token_min, LocatorProjectMatcher filter, bool comparevisitor2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ForceJoinedProc(int mindef, SpecTagDecider result)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RunConvertibleIterator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunConnectedPredicate(bool rejectv = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceExpandableExplorer(IEnumerable<long> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeReporter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetachTransmitter(ExtendedBufferWriter v, MouseButtonEventArgs ivk, ref bool dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceGroupedProfiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanIterator(ExtendedBufferWriter last, MouseEventArgs cont, ref bool serv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecutePredicate(ExtendedBufferWriter key, MouseButtonEventArgs ivk, ref bool template)
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
	void IComponentConnector.Connect(int task_low, object pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void RunAdjustableAnalyzer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool ControlInterruptibleWorker(OcoStrategyParam value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool ControlIterableSolver(OcoStrategyParam info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void ControlHiddenNotifier()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void TrackComparator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateRemoteBuilder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InterpreterDriver SimulateEfficientCollector()
	{
		return null;
	}
}
