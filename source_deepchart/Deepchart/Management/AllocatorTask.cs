using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using Deepchart.DecisionMaking;
using VolAnalysis.Creations;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Connection.Enums;
using VolumetricaControls;

namespace Deepchart.Management;

internal class AllocatorTask : Window, IComponentConnector
{
	internal class EncryptorConverterClient
	{
		[CompilerGenerated]
		private string m_EncryptorClientMapperID;

		[CompilerGenerated]
		private double m_MapperGatewayEncryptor;

		[CompilerGenerated]
		private double templateService;

		[CompilerGenerated]
		private double readableMapperEncryptor;

		[CompilerGenerated]
		private string m_ComparatorResponderTag;

		private static EncryptorConverterClient EncryptSynchronizer;

		public string Desc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double All
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

		public double Long
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

		public double Short
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

		public string Currency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConverterClient()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConverterClient(string task, double reg, double temp, double init2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConverterClient(string value, double result, double tag, double config2, CurrencyEnum? visitor3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConverterClient(string v, double b, double util, double info2, string res3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConverterClient(string spec, double token, double temp, double cust2, string v3, CurrencyEnum? setup4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EncryptorConverterClient()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncodeSingleton()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EncryptorConverterClient FilterCalculator()
		{
			return null;
		}
	}

	internal class IterablePredictorAllocator
	{
		[CompilerGenerated]
		private string identifiableWrapperAllocatorCategory;

		[CompilerGenerated]
		private DateTime? m_ElementObserver;

		[CompilerGenerated]
		private double allocatorContextBridge;

		[CompilerGenerated]
		private decimal advancedTag;

		[CompilerGenerated]
		private string allocatorBridgeServiceStatus;

		[CompilerGenerated]
		private DateTime _AllocatorServiceResolver;

		[CompilerGenerated]
		private double _AllocatorInterpreterFunction;

		[CompilerGenerated]
		private decimal _ResolverSystemAllocator;

		[CompilerGenerated]
		private double m_SummarizerTransaction;

		[CompilerGenerated]
		private double _VisualModuleAllocator;

		[CompilerGenerated]
		private double _FunctionConfigurationAllocator;

		[CompilerGenerated]
		private bool m_IsAllocatorSystemSubscriber;

		[CompilerGenerated]
		private bool _IsVisitorSummarizer;

		[CompilerGenerated]
		private string _IterableParserCategory;

		private static IterablePredictorAllocator JoinAnalyzer;

		public string EntryDTDisplay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public double EntryPrice
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

		public decimal EntryQuantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string ExitDTDisplay
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public double ExitPrice
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

		public decimal ExitQuantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double ProfitLoss
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

		public double MaxDrawdown
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

		public double MaxRunup
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

		public bool IsEntry
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

		public bool IsLastClose
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

		public string Currency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public string AllocateAlphabeticTokenizer()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void AssignSegmentedEvaluator(string def)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public DateTime? AllocateControllableTracer()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void StoreUser(DateTime? instance)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public string WatchAnnotation()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void AllocateAttachedRole(string reference)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public DateTime LoadEngine()
		{
			return (DateTime)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void ReleaseFlexibleRequester(DateTime param)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IterablePredictorAllocator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IterablePredictorAllocator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachOperationalMatcherReporter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IterablePredictorAllocator PeekSolver()
		{
			return null;
		}
	}

	internal class RegRegReporter
	{
		internal class TransferableBufferRequester
		{
			[CompilerGenerated]
			private DateTime m_ProfilerTracker;

			[CompilerGenerated]
			private string _SimpleFactoryRequesterTxt;

			[CompilerGenerated]
			private double observerRunner;

			[CompilerGenerated]
			private ulong m_FilterElementRequesterPosition;

			[CompilerGenerated]
			private decimal m_StaticSchemaRequester;

			[CompilerGenerated]
			private double m_ConnectedValueRequester;

			[CompilerGenerated]
			private double dividedConfigRequester;

			[CompilerGenerated]
			private double m_ElementParameterRequester;

			internal static TransferableBufferRequester AttachTransferableConsumerTemplate;

			public DateTime DT
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (DateTime)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private set
				{
				}
			}

			public string Name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private set
				{
				}
			}

			public double Price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				private set
				{
				}
			}

			public decimal Quantity
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return (decimal)(object)null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				set
				{
				}
			}

			public double ProfitLoss
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			public ulong QueryMixedFormatter()
			{
				return 0uL;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			private void QueryScheduledGateway(ulong instance_High)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			public double ExcludeTracker()
			{
				return 0.0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			public void RequestAdaptableInspector(double reference)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			public double ConfigureDynamicError()
			{
				return 0.0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			[CompilerGenerated]
			public void RequestReadableMapper(double value)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TransferableBufferRequester(string init, ulong reg_offset, DateTime res, double key2)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TransferableBufferRequester()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool GenerateLiteralTemplateTag()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TransferableBufferRequester AttachGlobalTagChecker()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private ulong _RegReporterRequesterAge;

		[CompilerGenerated]
		private DateTime? m_ManagerProc;

		[CompilerGenerated]
		private DateTime? m_InterruptibleTokenizerReg;

		[CompilerGenerated]
		private string m_GenericSubscriberContent;

		[CompilerGenerated]
		private double requesterThreadReg;

		[CompilerGenerated]
		private decimal _AlphabeticExecutor;

		public List<TransferableBufferRequester> m_ThreadTesterRegList;

		private GeneratorConfigurationArgument.TransferableValueReg _TesterServiceReg;

		[CompilerGenerated]
		private double _RegServiceController;

		[CompilerGenerated]
		private double _ControllerParserReg;

		[CompilerGenerated]
		private double _RegParserDriver;

		[CompilerGenerated]
		private double driverConverterReg;

		[CompilerGenerated]
		private double? m_DetachedProject;

		[CompilerGenerated]
		private decimal? m_CustomizableGeneratorReg;

		internal static RegRegReporter SimulateEditableTransmitterProc;

		public string Symbol
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public double EntryPrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public CurrencyEnum? Currency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		public decimal Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (decimal)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public double ProfitLoss
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public ulong ReflectLocalServer()
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void AnalyzeDefinition(ulong i_high)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public DateTime? SaveScheduledValidator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void SaveMonoReg(DateTime? def)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public DateTime? SetService()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void SavePassiveCompiler(DateTime? info)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public string SaveRandomSorter()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void SaveDynamicContainer(string asset)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegRegReporter(GeneratorConfigurationArgument.TransferableValueReg task, string b, ulong fieldend, DateTime? ivk2, double pol3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public double SaveScopeTransmitter()
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void OpenLogicalProc(double task)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public double SaveResponsivePredicate()
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void DisperseSetExplorer(double asset)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public double SaveTransformableComparator()
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		private void DecompressGateway(double ident)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public double? ContainsDetailedHandler()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void SaveVisualContext(double? first)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public decimal? WriteActiveMonitor()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void HandleFilteredState(decimal? reference)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calculate(bool UseCommission, int? maxContrs, int? maxTradeDD, int? maxTradeRunup)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RegRegReporter()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachIntegratedProcIterator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RegRegReporter PrepareQueue()
		{
			return null;
		}
	}

	internal class ModularCreatorViewer<T>
	{
		internal class StrategyObserver
		{
			public string convertibleCollectorDescr;

			public double observerSender;

			public double _SetObserver;

			public double TotalBalance;

			public double symbolicPolicyDecider;

			public double _IsolatedArgumentDecider;

			internal static object AttachDetachedCheckerTokenizer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StrategyObserver()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static StrategyObserver()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool SimulateExtendedTokenizerEvaluator()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object AttachCustomEvaluatorPool()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Values_003Ed__4 : IEnumerable<StrategyObserver>, IEnumerable, IEnumerator<StrategyObserver>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private StrategyObserver _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public ModularCreatorViewer<T> _003C_003E4__this;

			private T[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			internal static object SimulateAttachedPoolTracer;

			StrategyObserver IEnumerator<StrategyObserver>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003Cget_Values_003Ed__4(int _003C_003E1__state)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				return true;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<StrategyObserver> IEnumerable<StrategyObserver>.GetEnumerator()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static _003Cget_Values_003Ed__4()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AttachBasicTracerPredictor()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object SimulateOperationalPredictorTransformer()
			{
				return null;
			}
		}

		private Dictionary<T, StrategyObserver> m_GroupedObserverViewerDic;

		internal static object GenerateCustomizablePredicateExplorer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModularCreatorViewer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[IteratorStateMachine(typeof(ModularCreatorViewer<>._003Cget_Values_003Ed__4))]
		public IEnumerable<StrategyObserver> PostReporter()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyObserver ArrangeMapper(T instance, string vis, RegRegReporter temp)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ViewConcreteTemplate(DataGrid i, bool wantreg, CurrencyEnum? consumer)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ModularCreatorViewer()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAutomatedExplorerSpec()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateJoinedSpecSystem()
		{
			return null;
		}
	}

	private Color m_RemoteAllocator;

	private Color randomAllocator;

	private Color serviceAnnotation;

	private Dictionary<string, List<string>> m_GatewayInitializerDic;

	private bool _IsCalcConverter;

	private HashSet<string> containerAllocator;

	private HashSet<int> m_ObserverNotifier;

	private Dictionary<string, GeneratorConfigurationArgument.TransferableValueReg> sorterTaskMap;

	private InternalSingletonSingleton m_CombinedMap;

	private InternalSingletonSingleton profileAllocator;

	private InternalSingletonSingleton _AdapterContainer;

	private InternalSingletonSingleton _RemotePolicy;

	private InternalSingletonSingleton _SymbolicVerifier;

	private InternalSingletonSingleton m_ProfilerConsumer;

	private InternalSingletonSingleton _SimpleAllocator;

	private int? _GeneralAllocator;

	private int? _SegmentedAllocator;

	private int? _AllocatorList;

	private int? m_TokenizerQueue;

	private int? simpleTask;

	private bool isSortedAllocator;

	private List<ScopeHandlerDecider.StatelessTagWriter> m_AllocatorProviders;

	internal Border brdTop;

	internal ComboBoxWithHeader cmbBroker;

	internal ComboBoxWithHeader cmbAccount;

	internal IconButton btnSettings;

	internal Popup popSettings;

	internal CheckBox ckbAllSymbols;

	internal Button btnSelectSymbols;

	internal CheckBox ckbIniDt;

	internal DatePickerControl dtpIniDt;

	internal CheckBox ckbEndDt;

	internal DatePickerControl dtpEndDt;

	internal CheckBox ckbUseCommission;

	internal CheckBox ckbHypDailyDrawdown;

	internal NumUpDown nudHypDailyDrawdown;

	internal CheckBox ckbHypDailyRunup;

	internal NumUpDown nudHypDailyRunup;

	internal CheckBox ckbHypMaxContracts;

	internal NumUpDown nudHypMaxContracts;

	internal CheckBox ckbHypTradeDrawdown;

	internal NumUpDown nudHypTradeDrawdown;

	internal CheckBox ckbHypTradeRunup;

	internal NumUpDown nudHypTradeRunup;

	internal Button btnExportCsv;

	internal Button btnGenerate;

	internal Border brdTopCompact;

	internal TabControl tbcGeneral;

	internal TabItem tbpStrategyPerformance;

	internal DataGrid dgwStrategyPerf;

	internal TabItem tbpTradeList;

	internal DataGrid lswTradeList;

	internal TabItem tbpSymbolPerf;

	internal DataGrid dgwSymbPerf;

	internal TabItem tbpChart;

	internal TabItem tbpEqCurve;

	internal ContentControl hstEqCurve;

	internal TabItem tbpEqLong;

	internal ContentControl hstEqLong;

	internal TabItem tbpEqShort;

	internal ContentControl hstEqShort;

	internal TabItem tbpDW;

	internal ContentControl hstDW;

	internal TabItem tbpEqWithDW;

	internal ContentControl hstEqWithDW;

	internal TabItem tbpDailyPL;

	internal ContentControl hstDailyPL;

	internal TabItem tbpTradeAnalysis;

	internal ContentControl hstTradeAnalysis;

	internal TabItem tbpTimeAnalysis;

	internal TabItem tbpTimeHour;

	internal DataGrid dgwHourAnalysis;

	internal TabItem tbpTimeDaily;

	internal DataGrid dgwDailyAnalysis;

	internal TabItem tbpTimeMonthly;

	internal DataGrid dgwMonthlyAnalysis;

	internal TabItem tbpTimeYearly;

	internal DataGrid dgwYearlyAnalysis;

	private bool isProjectMap;

	private static AllocatorTask GenerateVisibleAnalyzer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorTask(bool allowtask = false, List<ScopeHandlerDecider.StatelessTagWriter> vis = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DeciderReceiverAdapter SortUser(InternalSingletonSingleton ident, float reg = 99f, float temp = 1f)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private InternalSingletonSingleton ReleaseStatelessProgram(ContentControl v, bool insertvis = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignActivePublisher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ValidateSingleton(object def, SelectionChangedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocatePortableProxy(object key, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AwakeAnalyzer(object task, RoutedPropertyChangedEventArgs<object> pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateConcreteServer(object i, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignCentralModule(object v, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssessNotifier(object item, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AnalyzeInterpreter(object spec, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PauseQueue(object i, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignSegmentedFormatter(object value, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateCommonGateway(object config, EventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReplaceWatcher(InternalSingletonSingleton instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetProfile(Grid value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Label ReleaseEfficientSorter(Grid instance, string selection, int flags_control, int mean_item2, Brush item3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Rectangle ReleaseTransferableContainer(Grid info, Brush ord, int poolmax)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseLiteralInspector(List<RegRegReporter> info, Dictionary<ulong, RegRegReporter> selection, ScopeHandlerDecider.StatelessTagWriter template, DateTime? vis2, DateTime? config3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateGlobalTransaction(StreamWriter asset)
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
	void IComponentConnector.Connect(int offset_config, object map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorTask()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSequentialWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorTask GenerateTransformableSolver()
	{
		return null;
	}
}
