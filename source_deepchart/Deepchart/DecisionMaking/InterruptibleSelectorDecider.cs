using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Creations;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class InterruptibleSelectorDecider : IntegratedServerWrapper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAndStoreMinutes_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public bool forceVolServer;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public List<CancellationToken> p_tokens;

		public DateTime? exchEndDt;

		public DateTime exchStartDt;

		public bool isAppend;

		public bool loadLastData;

		private LocatorSelectorTransaction _003ChistConn_003E5__2;

		private List<CancellationToken> _003Ctokens_003E5__3;

		private DateTime _003CexchCurrIniDt_003E5__4;

		private DateTime _003CexchCurrEndDt_003E5__5;

		private DateTime _003CcurrentIniSessionDt_003E5__6;

		private DateTime _003CnextIniSessionDt_003E5__7;

		private LocatorEditorSelector _003CcurrentCache_003E5__8;

		private SingletonHandlerConnection.SetControllerRequester _003ClastBar_003E5__9;

		private DateTime _003CnextBarExDt_003E5__10;

		private long _003ClblWorkId_003E5__11;

		private DateTime _003CreqIniDt_003E5__12;

		private DateTime _003CreqEndDt_003E5__13;

		private TaskAwaiter<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickMultiplier)> _003C_003Eu__1;

		private static object GenerateDetailedMapperMatcher;

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
		static _003CDownloadAndStoreMinutes_003Ed__14()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateVisualMatcherReporter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MonitorReceiver()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnsureEnoughData_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public DateTime iniExchDt;

		public bool forceVolServer;

		public List<CancellationToken> p_tokens;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object SimulateActiveTransmitterProc;

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
		static _003CEnsureEnoughData_003Ed__13()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachFilteredProcIterator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachPortableIteratorPredicate()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFillInitData_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object ArrangeSingleton;

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
		static _003CFillInitData_003Ed__12()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachConcreteExplorerSpec()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateCentralSpecSystem()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerableForLastSession_003Ed__23 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public InterruptibleSelectorDecider _003C_003E4__this;

		private FontWeight queueLockAction;

		public FontWeight _003C_003E3__queueLockAction;

		private bool isRevOrder;

		public bool _003C_003E3__isRevOrder;

		private CancellationToken token;

		public CancellationToken _003C_003E3__token;

		private bool _003CneedToCheckRep_003E5__2;

		private byte[] _003CfileBytes_003E5__3;

		private SingletonHandlerConnection.SetControllerRequester _003CbarToAdd_003E5__4;

		private int _003CnumBytesPerLine_003E5__5;

		private int _003CnumLine_003E5__6;

		private int _003Ck_003E5__7;

		internal static _003CGetEnumerableForLastSession_003Ed__23 DefineWorker;

		object IEnumerator<object>.Current
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
		public _003CGetEnumerableForLastSession_003Ed__23(int _003C_003E1__state)
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
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
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
		static _003CGetEnumerableForLastSession_003Ed__23()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CustomizeSolver()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CGetEnumerableForLastSession_003Ed__23 GenerateAlphabeticComparatorStrategy()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerableForSessionDate_003Ed__21 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public InterruptibleSelectorDecider _003C_003E4__this;

		private FontWeight queueLockAction;

		public FontWeight _003C_003E3__queueLockAction;

		private DateTime exchDt;

		public DateTime _003C_003E3__exchDt;

		private bool fallbackToPrevious;

		public bool _003C_003E3__fallbackToPrevious;

		private bool isRevOrder;

		public bool _003C_003E3__isRevOrder;

		private CancellationToken token;

		public CancellationToken _003C_003E3__token;

		private bool _003CneedToCheckRep_003E5__2;

		private byte[] _003CfileBytes_003E5__3;

		private SingletonHandlerConnection.SetControllerRequester _003CbarToAdd_003E5__4;

		private int _003CnumBytesPerLine_003E5__5;

		private int _003CnumLine_003E5__6;

		private int _003Ck_003E5__7;

		internal static _003CGetEnumerableForSessionDate_003Ed__21 AttachSegmentedStrategyRecord;

		object IEnumerator<object>.Current
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
		public _003CGetEnumerableForSessionDate_003Ed__21(int _003C_003E1__state)
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
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
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
		static _003CGetEnumerableForSessionDate_003Ed__21()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MeasureQueue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CGetEnumerableForSessionDate_003Ed__21 AttachControllableHandlerContext()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CIntLoadData_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public ViewerTracerNotifier cacheSession;

		public CentralAllocator histQueue;

		public bool isLastContract;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public DateTime? lastReplayDt;

		public OrderedAllocator request;

		public object helperData;

		private string _003Cpath_003E5__2;

		private bool _003CisCompressed_003E5__3;

		private int[] _003CfrmIndexList_003E5__4;

		private bool _003CneedAdjBar_003E5__5;

		private bool _003CneedNotAdjBar_003E5__6;

		private int _003CChartCount_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

		internal static object LeadFinder;

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
		static _003CIntLoadData_003Ed__20()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CancelWatcher()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PlayProfile()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public OrderedAllocator request;

		public CentralAllocator histQueue;

		public bool isLastContract;

		public DateTime? lastReplayDt;

		private long _003ClblWorkId_003E5__2;

		private int _003CendIndex_003E5__3;

		private bool _003CretValue_003E5__4;

		private int _003CcacheIndex_003E5__5;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object SimulateLiteralStateArgument;

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
		static _003CLoadData_003Ed__18()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InterruptCache()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EnableSubscriber()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public InterruptibleSelectorDecider _003C_003E4__this;

		public CentralAllocator histQueue;

		public OrderedAllocator request;

		public bool isLastContract;

		public DateTime? lastReplayDt;

		public LocatorTesterEditor session;

		public object helperData;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object EncryptClient;

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
		static _003CLoadData_003Ed__19()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncodeExecutor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FilterViewer()
		{
			return null;
		}
	}

	private List<ViewerTracerNotifier> _DeciderEvaluatorComparators;

	private SingletonHandlerConnection.SetControllerRequester m_SymbolicStubDecider;

	private DateTime iterableRequest;

	private bool _IsSenderRequest;

	internal static InterruptibleSelectorDecider ExcludeConverter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public override IReadOnlyList<LocatorTesterEditor> JoinConfiguration()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InterruptibleSelectorDecider(CustomDecider instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocatorEditorSelector StoreAutomatableSchema(DateTime item)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DetachCreator(int position_v, LocatorEditorSelector cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SaveGroupedTracker(LocatorEditorSelector key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenOperationalMember()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFillInitData_003Ed__12))]
	public override Task SaveFlexibleProcessor(LocatorSelectorTransaction ident, CancellationToken map)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnsureEnoughData_003Ed__13))]
	public override Task<bool> OpenEditableSender(DateTime value, List<CancellationToken> ord = null, bool isrule = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAndStoreMinutes_003Ed__14))]
	private Task<bool> DetermineDividedReg(DateTime instance, DateTime? map, bool isdic, bool removeinstance2, List<CancellationToken> info3 = null, bool wantlast4 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MatchDriver(SingletonHandlerConnection.ObjectAuthenticatorLocator reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchTester(LocatorEditorSelector def, DateTime result, double temp, int t2_ID, SingletonHandlerConnection.EncryptorPolicyStatementAttribute ident3, bool extractvar14, ref SingletonHandlerConnection.SetControllerRequester v5, ref DateTime item6)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideSeparatedGateway(LocatorEditorSelector last, SingletonHandlerConnection.SetControllerRequester map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__18))]
	public override Task<bool> OpenStaticDecryptor(CentralAllocator setup, OrderedAllocator ivk, bool isrule, DateTime? second2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__19))]
	public override Task<bool> OpenStaticDecryptor(CentralAllocator ident, OrderedAllocator vis, bool skipfilter, DateTime? param2, LocatorTesterEditor res3, object map4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIntLoadData_003Ed__20))]
	private Task<bool> DetermineScalableCompiler(CentralAllocator init, OrderedAllocator pol, bool addproc, DateTime? last2, ViewerTracerNotifier x3, object v4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerableForSessionDate_003Ed__21))]
	public override IEnumerable<object> SaveCustomizableDefinition(DateTime config, bool insertcounter, bool notemp, CancellationToken vis2, FontWeight init3 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object[] SaveAutomatedSelector(DateTime last, bool isresult, bool isdir, CancellationToken selection2, FontWeight map3 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerableForLastSession_003Ed__23))]
	public override IEnumerable<object> BuildRequest(bool var1open, CancellationToken col, FontWeight serv = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object[] OpenConvertibleResponder(FontWeight v = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetOrder(FontWeight reference = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object OpenExpandableService(FontWeight var1 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterruptibleSelectorDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CreateAggregator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InterruptibleSelectorDecider SimulateLiteralLocatorVerifier()
	{
		return null;
	}
}
