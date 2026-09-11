using System;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class HiddenLocatorLocator : IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public HiddenLocatorLocator _AllocatorDriverDecorator;

		public CancellationTokenSource m_RemoteThread;

		private static _003C_003Ec__DisplayClass54_0 DefineEditor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass54_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task? EncryptTree()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass54_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateConfigurableModuleDecorator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass54_0 SimulateMixedDecoratorValidator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAttachAsync_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public WebSocket _socket;

		public CancellationTokenSource _socketToken;

		public CancellationTokenSource _pingToken;

		private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

		private CancellationTokenSource _003C_receiveToken_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object ManageClient;

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
		static _003CAttachAsync_003Ed__54()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateMonoRegFormatter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateExternalFormatterGateway()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectionClosed_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public bool isUnexpceted;

		public string reason;

		public WebSocketCloseStatus? status;

		private TaskAwaiter _003C_003Eu__1;

		internal static object LeadAdapter;

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
		static _003CConnectionClosed_003Ed__66()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachPassiveCompilerPolicy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachAdaptablePolicySorter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisconnectAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public string reason;

		public WebSocketCloseStatus closeStatus;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		internal static object NewCollector;

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
		static _003CDisconnectAsync_003Ed__53()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachDynamicContainerInspector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateReadableInspectorTransaction()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnsureSocketClose_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebSocket _socket;

		public HiddenLocatorLocator _003C_003E4__this;

		public WebSocketCloseStatus closeStatus;

		public string reason;

		private CancellationTokenSource _003CtimeoutToken_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateDividedTransactionError;

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
		static _003CEnsureSocketClose_003Ed__55()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncodeProcessor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachSeparatedMapperMatcher()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CIntSendAsync_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public WebSocket p_socket;

		public byte[] bytes;

		public int offset;

		public int count;

		public WebSocketMessageType msgType;

		private bool _003CsemaphoreAcquired_003E5__2;

		private CancellationTokenSource _003CsendToken_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateScalableMatcherReporter;

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
		static _003CIntSendAsync_003Ed__65()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateVirtualReporterTransmitter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PeekDefinition()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CManageApplicationKeepAlive_003Ed__68 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public CancellationTokenSource p_token;

		public CancellationToken p_socketToken;

		private TaskAwaiter _003C_003Eu__1;

		internal static object FlushSelector;

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
		static _003CManageApplicationKeepAlive_003Ed__68()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MatchInitializer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateResponsivePredicateExplorer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CManageClient_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public WebSocket p_socket;

		public CancellationToken p_receiveToken;

		public CancellationTokenSource p_socketToken;

		public CancellationTokenSource p_keepAliveToken;

		public CancellationTokenSource p_pingToken;

		private int _003CmsgIndex_003E5__2;

		private byte[] _003CmsgBytes_003E5__3;

		private byte[] _003Cbuffer_003E5__4;

		private ArraySegment<byte> _003C_buffer_003E5__5;

		private WebSocketCloseStatus? _003CcloseStatus_003E5__6;

		private string _003CcloseReason_003E5__7;

		private object _003C_003E7__wrap7;

		private int _003C_003E7__wrap8;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__2;

		private static object AttachSetExplorerSpec;

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
		static _003CManageClient_003Ed__67()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSortedSpecSystem()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BuildSchema()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendProtobufAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HiddenLocatorLocator _003C_003E4__this;

		public object message;

		private bool _003CsemaphoreAcquired_003E5__2;

		private CancellationTokenSource _003CsendToken_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateSequentialProfilerComparator;

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
		static _003CSendProtobufAsync_003Ed__64()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateTransformableComparatorStrategy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachGenericStrategyRecord()
		{
			return null;
		}
	}

	private int _LocatorSolverVisitorCounter;

	private int _SimpleQueueLocatorInterval;

	private int m_CentralMonitorLocatorCnt;

	[CompilerGenerated]
	private TimeSpan m_LocatorFinderSchema;

	[CompilerGenerated]
	private TimeSpan? m_ConcreteWriterLocator;

	[CompilerGenerated]
	private object _ConfigurationFactoryObj;

	[CompilerGenerated]
	private bool isVisibleCompressorLocator;

	[CompilerGenerated]
	private string _DividedProviderLocatorText;

	[CompilerGenerated]
	private string m_LocatorVisitorAnalyzerID;

	private CentralSynchronizerReg segmentedGeneratorLocator;

	private InternalTesterWrapper m_ExtendedContainerLocator;

	private AllocatorFilterChecker dicExplorer;

	private RegSetError m_LocatorSchemaDefinition;

	private AllocatorFilterChecker _InspectorMap;

	private AllocatorAggregatorWorker _ControllableMember;

	private GroupedProcessorRequester m_ResponderRecord;

	private AllocatorAggregatorWorker m_FilteredListenerLocator;

	private Action<object> _LocalTreeLocator;

	private Guid? separatedStrategy;

	private Guid? _PassiveTemplateLocator;

	private WebSocket literalPredictor;

	protected SemaphoreSlim _AnalyzerTrackerLocator;

	private SemaphoreSlim _ProjectAuthenticator;

	private ManualResetEvent logicalCalcLocator;

	private CancellationTokenSource readableEmitterLocator;

	private DateTime _StatelessAttributeLocator;

	private MemoryStream _InternalLogger;

	private static HiddenLocatorLocator AttachConvertibleFactoryUser;

	public bool Connected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public object Tag
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

	public string Description
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public Guid? IdentifyScalableState()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public TimeSpan ClearScopeConsumer()
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void FlushGenerator(TimeSpan v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public TimeSpan? ClearResponsiveChecker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void SelectObserver(TimeSpan? init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public CancellationTokenSource ClearVisiblePool()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool AssignSimpleAllocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void DetachConverter(bool var1stop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public string ControlLogger()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void FindPortableRole(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HiddenLocatorLocator(int lengthitem, int num_result = 30, string temp = null, string ident2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ArrangeComparator(CentralSynchronizerReg config, InternalTesterWrapper token, AllocatorFilterChecker helper = null, RegSetError setup2 = null, AllocatorFilterChecker ident3 = null, AllocatorAggregatorWorker param4 = null, GroupedProcessorRequester ident5 = null, AllocatorAggregatorWorker col6 = null, Action<object> param7 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisconnectAsync_003Ed__53))]
	public Task ClearHiddenMatcher(string info = null, WebSocketCloseStatus attr = WebSocketCloseStatus.NormalClosure)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAttachAsync_003Ed__54))]
	public Task ClearModularReporter(WebSocket config, string pred, CancellationTokenSource rule, CancellationTokenSource reg2 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnsureSocketClose_003Ed__55))]
	protected Task IdentifyLocalTransmitter(WebSocket first, string cont, WebSocketCloseStatus control)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindConfigurableProc(byte[] ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindMixedIterator(byte[] instance, int offset_reg, int start_control)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IdentifyScheduledPredicate(string reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearMonoExplorer(object setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SplitArgument(WebSocket reference, byte[] attr, WebSocketMessageType helper, int position_counter2, int insert_IVK3At)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task IdentifyAccessibleSystem(byte[] first)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task IdentifyPassiveProfiler(byte[] param, int contlow, int comp_counter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PlayTag(string info)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendProtobufAsync_003Ed__64))]
	public Task IdentifyRandomStrategy(object reference)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIntSendAsync_003Ed__65))]
	protected Task InterruptTokenizer(WebSocket ident, byte[] attr, WebSocketMessageType helper, int reg2_end, int setup3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectionClosed_003Ed__66))]
	private Task ClearReadableHandler(bool setparam, string vis, WebSocketCloseStatus? field)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CManageClient_003Ed__67))]
	private Task IdentifyDividedContext(Guid setup, WebSocket ivk, CancellationTokenSource dir, CancellationTokenSource asset2, CancellationTokenSource var13, CancellationToken ident4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CManageApplicationKeepAlive_003Ed__68))]
	private Task IdentifyIsolatedBuffer(CancellationToken ident, CancellationTokenSource pred)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HiddenLocatorLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachConnectedUserLogger()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HiddenLocatorLocator GenerateExpandableLoggerTester()
	{
		return null;
	}
}
