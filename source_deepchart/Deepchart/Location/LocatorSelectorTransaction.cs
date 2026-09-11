using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.DecisionMaking;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.Drivers;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaProtcol.Trading;

namespace Deepchart.Location;

internal abstract class LocatorSelectorTransaction
{
	internal enum TransformerViewerKind
	{
		None = 0,
		All = 2
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnect_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public LocatorSelectorTransaction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object VisitStrategy;

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
		static _003CConnect_003Ed__159()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateVisibleHandlerContext()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachSequentialContextBuffer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisconnect_003Ed__160 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LocatorSelectorTransaction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SimulateTransformableBufferMonitor;

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
		static _003CDisconnect_003Ed__160()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PatchBuffer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object StopMonitor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistBarsAsync_003Ed__197 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickMultiplier)> _003C_003Et__builder;

		private static object AdaptState;

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
		static _003CGetHistBarsAsync_003Ed__197()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateVisualConsumerTemplate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachStatelessTemplateTag()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistDataAsync_003Ed__196 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> _003C_003Et__builder;

		internal static object AttachActiveTagChecker;

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
		static _003CGetHistDataAsync_003Ed__196()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ValidateWrapper()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PushConfig()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchSymbols_003Ed__200 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ReceiverValue.FlexibleRegDecider>> _003C_003Et__builder;

		internal static object GenerateSymbolicEvaluatorPool;

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
		static _003CSearchSymbols_003Ed__200()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CalcRecommender()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateCentralTracerPredictor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendOrdersListMsg_003Ed__169 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		internal static object GenerateAdvancedPredictorTransformer;

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
		static _003CSendOrdersListMsg_003Ed__169()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AnalyzeDriver()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateAlphabeticAllocatorTree()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetStatus_003Ed__156 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LocatorSelectorTransaction _003C_003E4__this;

		public ReceiverValue.RegWLanProfileConnectionType newStatus;

		private TaskAwaiter _003C_003Eu__1;

		private Delegate[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		internal static object GenerateSegmentedTreeGenerator;

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
		static _003CSetStatus_003Ed__156()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachCommonGeneratorRunner()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReplaceRequest()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTriggerConnectionLost_003Ed__161 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		internal static object GenerateRemoteProjectObserver;

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
		static _003CTriggerConnectionLost_003Ed__161()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachEfficientObserverRole()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachTransferableRoleController()
		{
			return null;
		}
	}

	public static string locatorDriverDicDescr;

	protected readonly string _ConfigCreatorLabel;

	public static Action<string> m_EfficientParserLocator;

	[CompilerGenerated]
	private static Lock _LocatorTransactionThread;

	[CompilerGenerated]
	private static LocatorEditorDriver userTransformer;

	[CompilerGenerated]
	private static LogicalEngineWrapper locatorDicToken;

	[CompilerGenerated]
	private static DeciderManagerObject m_LocatorThreadExplorer;

	[CompilerGenerated]
	private static ActiveErrorEncryptor _LocatorTokenUser;

	[CompilerGenerated]
	private static ProcessorEditor m_LocatorExplorerProfiler;

	public static Dictionary<string, GeneratorConfigurationArgument.TransferableValueReg> monoFormatterDic;

	[CompilerGenerated]
	private RequesterRequesterProgram m_MonoCollectionLocator;

	[CompilerGenerated]
	private Action<LocatorSelectorTransaction> profilerSummarizer;

	public static Action<ReceiverValue.Feed, string> m_TransferableMapper;

	protected ConcreteAggregatorDecider m_LocatorUserLogger;

	protected internal WrapperValidatorHandler virtualRecord;

	protected internal RegServerComparator localStub;

	protected internal ConfigurationAuditor m_TesterDecorator;

	protected internal ViewerPoolSelector scalableBridge;

	protected long m_LocatorProfilerTransformerPnts;

	protected TransformerViewerKind _ScheduledMonitorReg;

	protected Dictionary<string, string> loggerSummarizerLocatorMap;

	[CompilerGenerated]
	private bool isAutomatedRunnerLocator;

	public static FlexibleMemberReg m_RandomComparatorLocator;

	public SemaphoreSlim m_SortedWorkerLocator;

	public SemaphoreSlim commonModuleLocator;

	[CompilerGenerated]
	private CancellationToken m_ExpandableObjectReg;

	protected JoinedInterpreterDecider integratedClientLocator;

	protected bool isSequentialFunction;

	private ReceiverValue.RegWLanProfileConnectionType m_LocatorTransformerConfig;

	[CompilerGenerated]
	private ReceiverValue.LiteralSharerLocator _CombinedVerifierLocator;

	[CompilerGenerated]
	private ReceiverValue.Feed configurableErrorLocator;

	[CompilerGenerated]
	private int _ProcSorterValue;

	[CompilerGenerated]
	private bool m_IsSummarizerConverterLocator;

	[CompilerGenerated]
	private ScopeHandlerDecider.ScopeWatcherRegOptions _RunnerStrategy;

	[CompilerGenerated]
	private ScopeHandlerDecider.AllocatorMemberAttributes m_IsolatedPredictorLocator;

	[CompilerGenerated]
	private ScopeHandlerDecider.DriverAttributesToIgnore fieldContainer;

	[CompilerGenerated]
	private bool m_IsLocatorConfigValue;

	[CompilerGenerated]
	private bool m_IsLocatorControllerFunction;

	[CompilerGenerated]
	private bool m_IsDynamicReporterLocator;

	[CompilerGenerated]
	private bool _IsWriterCacheField;

	[CompilerGenerated]
	private bool isConverterExtractorLocator;

	[CompilerGenerated]
	private bool _IsControllableSystemLocator;

	[CompilerGenerated]
	private bool m_IsReadableAnalyzerRequester;

	[CompilerGenerated]
	private bool _IsTracerProc;

	[CompilerGenerated]
	private bool isLocatorValueNotifier;

	[CompilerGenerated]
	private bool m_IsLocatorFunctionLocator;

	[CompilerGenerated]
	private Dictionary<string, WriterServerRecommender> m_VirtualListLocatorDic;

	[CompilerGenerated]
	private Lock _CustomSetLocator;

	[CompilerGenerated]
	private JoinedTokenizerRegFlags m_AccessibleAuditor;

	public static int? alphabeticRecordLocator;

	public static int? m_ViewerSelectorMonitor;

	protected static int consumerNotifiers;

	private static DetachedRequesterWrapper _BasicEventLocator;

	internal static LocatorSelectorTransaction ResumeVisitor;

	protected bool UseVolServer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool Connected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public ReceiverValue.RegWLanProfileConnectionType Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ReceiverValue.RegWLanProfileConnectionType)(object)null;
		}
	}

	public ReceiverValue.LiteralSharerLocator BrokerInfo
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

	public double OpenPL
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	public double DailyPL
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static Lock ProcessStaticResolver()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearCustomizableEvent(Lock instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static Dictionary<string, GeneratorConfigurationArgument.TransferableValueReg> FindProc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void FindConvertibleCommand(Dictionary<string, GeneratorConfigurationArgument.TransferableValueReg> task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearStaticEvent(LocatorEditorDriver reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void IdentifyCustomizableStub(LocatorEditorDriver res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ValidateList(WriterServerRecommender value, HashSet<string> token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void FindJoinedCommand(LogicalEngineWrapper asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void FindConvertibleWrapper(LogicalEngineWrapper res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearExpandableConfiguration(DeciderManagerObject spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void StopOrder(DeciderManagerObject config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLocator(WriterServerRecommender last, string cust, bool cinstall, long column_setup2, long reg3_Low, OrderInfoMsg.OrderStateEnum instance4, ScopeHandlerDecider.ResponsiveSpecGeneratorTypes connection5, ScopeHandlerDecider.SequentialErrorRegType map6, decimal visitor7, decimal def8, double t9, ScopeHandlerDecider.ComparatorProfilerReg? task10, double ident11, double? selection12, OrderInfoMsg.ErrorReasonEnum spec13, decimal var114, ScopeHandlerDecider.ViewerFinalizerIterator ident15, ScopeHandlerDecider.ViewerFinalizerIterator.ConfigurableResponderDecider ivk16, int sum_cont17)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ClearSymbolicConverter(WriterServerRecommender task, ScopeHandlerDecider.LocatorNotifierMonitor cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void IdentifyGroupedCompressor(ActiveErrorEncryptor setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearIdentifiableDriver(ActiveErrorEncryptor asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcProvider(WriterServerRecommender task, ScopeHandlerDecider.ComparatorTracerAllocator ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearAdjustableIterator(ProcessorEditor value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void ClearInterruptiblePredicate(ProcessorEditor spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddParser(WriterServerRecommender ident, string map, string dir, ScopeHandlerDecider.ViewerConnectionCommand.VisibleBufferSingletonState visitor2, ScopeHandlerDecider.ModelCache cfg3 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void CalcParser(RequesterRequesterProgram key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ClearModularSystem(RequesterRequesterProgram item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AnalyzeParameter(Action<LocatorSelectorTransaction> asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void FindMixedStrategy(Action<LocatorSelectorTransaction> asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public CancellationToken InitSystem()
	{
		return (CancellationToken)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void CalculateGroupedStruct(CancellationToken reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ReceiverValue.Feed FindHiddenExplorer()
	{
		return (ReceiverValue.Feed)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void PostMonitor(ReceiverValue.Feed instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public int FindConfigurableProfiler()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void IdentifyMixedComparator(int first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool FindMonoRecord()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ClearExternalHandler(bool setvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ScopeHandlerDecider.ScopeWatcherRegOptions FindPassiveBuffer()
	{
		return (ScopeHandlerDecider.ScopeWatcherRegOptions)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void IdentifyAdaptableMonitor(ScopeHandlerDecider.ScopeWatcherRegOptions ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ScopeHandlerDecider.AllocatorMemberAttributes IdentifyDynamicArgument()
	{
		return (ScopeHandlerDecider.AllocatorMemberAttributes)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void FindReadableConsumer(ScopeHandlerDecider.AllocatorMemberAttributes asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ScopeHandlerDecider.DriverAttributesToIgnore ProcessIsolatedTag()
	{
		return (ScopeHandlerDecider.DriverAttributesToIgnore)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void DisConnectSeparatedChecker(ScopeHandlerDecider.DriverAttributesToIgnore init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool IdentifyVirtualEvaluator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void IdentifyScopePool(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool MatchController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void PrepareModel(bool countinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool RemoveSortedTree()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ClearVisibleGenerator(bool forceres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool ObserveTransformableProject()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void FindGenericObserver(bool ignorereference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool ClearDetailedController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ClearVisualModel(bool taskstop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool IdentifyActiveFilter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ControlAuthenticator(bool countinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool RunAnnotation()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ClearConcreteFactory(bool isinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool FindAdvancedLogger()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void DirectStack(bool allowlast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool CollectDic()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void IdentifyCommonAuthenticator(bool setspec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool IdentifyRemoteAnnotation()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void FinalizeEfficientSummarizer(bool nosetup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, WriterServerRecommender> ViewFinalizer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void FindGlobalStack(Dictionary<string, WriterServerRecommender> param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public Lock DisposeAttachedMap()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void IdentifyBasicTask(Lock last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public JoinedTokenizerRegFlags ClearFlexibleDispatcher()
	{
		return (JoinedTokenizerRegFlags)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected void ClearEditableFinalizer(JoinedTokenizerRegFlags asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AssessProgram(int key_Z, CancellationToken ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorSelectorTransaction(ReceiverValue.LiteralSharerLocator init, ConcreteAggregatorDecider cfg, RegServerComparator dic, ConfigurationAuditor pred2, ViewerPoolSelector ord3, WrapperValidatorHandler vis4, CancellationToken value5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetStatus_003Ed__156))]
	protected Task ClearOrderedLogger(ReceiverValue.RegWLanProfileConnectionType ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StoreAdaptableDriver(ReceiverValue.LiteralSharerLocator last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnect_003Ed__159))]
	public virtual Task<bool> Connect(string spec = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisconnect_003Ed__160))]
	public virtual Task StoreDynamicDecider(bool isparam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTriggerConnectionLost_003Ed__161))]
	public virtual Task ViewQueue(string task)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void PauseParameter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSegmentedNode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ConcatSet(GeneratorConfigurationArgument.ModuleLoggerKind? task)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ClearControllableAuthenticator(GeneratorConfigurationArgument.ModuleLoggerKind config)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long FindRemoteCollection()
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool LoadSubscriber(out int config, out int ord)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object ResetClient()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendOrdersListMsg_003Ed__169))]
	public virtual Task SerializeExecutor(object var1)
	{
		return null;
	}

	public abstract void SaveCommonEditor(object task, ScopeHandlerDecider.ViewerFinalizerIterator.ConfigurableResponderDecider cont, double state, double pred2 = 0.0);

	public abstract void StorePassiveCompressor(object instance, ScopeHandlerDecider.ViewerFinalizerIterator.ConfigurableResponderDecider b, long filter, double second2, double second3 = 0.0);

	public abstract void StoreEfficientClient(object spec, string map, long filter_amount);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayResolver(object value, ScopeHandlerDecider.EmitterBufferLocator.LocatorContextInterpreter second, long min_role, double value2 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenLiteralViewer(object info, ScopeHandlerDecider.EmitterBufferLocator.LocatorContextInterpreter map, long state_Z, double asset2 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenResponsiveEmitter(object value, string token, long procLow, long pol2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task SaveGlobalAdapter(string v, string token, long flags_res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task StoreSetEncryptor(string spec, string[] ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task VisitBuilder(string key, string[] selection)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task EnableConnection(string setup, string[] reg)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task CheckCollector(string reference, ScopeHandlerDecider.RegFieldFinderEnum cfg, List<long> proc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task InstantiateStream(string i, long vis_ID, List<long> field)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task DisableViewer(List<ReceiverValue.AdvancedConverterWriter> asset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GeneratorConfigurationArgument.TransferableValueReg FindEfficientAnnotation(string last)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string IdentifyTransferableSummarizer(string item)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ClearLiteralDictionary(string v)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool ClearGlobalEngine(string init, string connection, out string util, out string x2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string MoveGateway(string value, ReceiverValue.Feed counter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SaveCompiler(string param, ReceiverValue.Feed? cont = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string IdentifyCustomDic(string def, GeneratorConfigurationArgument.RegTaskInitializer reg, int indexOf_rule, int visitor2High, int row_selection3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string IdentifyAttachedThread(ReceiverValue.Feed config, string visitor, int offsetproc, int col2_count, int x3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string CombineContainer(string item, int lengthcounter, int consumer, int version_x2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ClearOperationalTask(string item, string counter, out int role, out int result2, out int info3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IdentifyFlexibleBridge(ReceiverValue.Feed i, string cfg, string util, out int ivk2, out int result3, out int config4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string FindEditableDispatcher(int version_asset, int regY)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task OpenDividedRequest(ReceiverValue.AdvancedConverterWriter[] ident, bool ismap = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistDataAsync_003Ed__196))]
	public virtual Task<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> SaveSeparatedOrder(GeneratorConfigurationArgument.ModuleLoggerKind res, string vis, DateTime util, DateTime? connection2 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistBarsAsync_003Ed__197))]
	public virtual Task<(List<SingletonHandlerConnection.SetControllerRequester>, int?)> CountCache(GeneratorConfigurationArgument.ModuleLoggerKind init, string pol, ReceiverValue.RandomTreeRegValues serv, int config2Low, bool readlast3, DateTime reference4, DateTime? instance5 = null)
	{
		return null;
	}

	public abstract long StoreAccessibleStruct(string ident, bool iscounter);

	public abstract Task<long> OpenExternalRecommender(string param, bool isivk);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchSymbols_003Ed__200))]
	public virtual Task<List<ReceiverValue.FlexibleRegDecider>> SaveReadableObject(string ident, string[] result, int c_offset, int counter2, CancellationToken map3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task StoreIsolatedChain(string setup, bool skipmap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorSelectorTransaction()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b8a398ef849b48a09f0c26204f046be9 != 0)
		{
			num = 3;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 989)
				{
					num = num2;
					break;
				}
				goto case 0;
			case 0:
				locatorDriverDicDescr = null;
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba != 0)
				{
					num = 1;
				}
				break;
			case 1:
				_LocatorTransactionThread = new Lock();
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool ChangeMapper(GeneratorConfigurationArgument.TransferableValueReg instance)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateFlexibleModelRequester()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorSelectorTransaction SimulateEditableRequesterFilter()
	{
		return null;
	}
}
