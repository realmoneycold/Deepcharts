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
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderComparatorExplorer : IntegratedServerWrapper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAndStoreTicks_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public bool forceVolServer;

		public DeciderComparatorExplorer _003C_003E4__this;

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

		private SingletonHandlerConnection.ObjectAuthenticatorLocator _003ClastTick_003E5__9;

		private DateTime? _003ClastDtExchDt_003E5__10;

		private long _003CCvl_003E5__11;

		private ulong _003CLastAggrID_003E5__12;

		private int _003CSumVolOrd_003E5__13;

		private long _003ClblWorkId_003E5__14;

		private DateTime _003CreqIniDt_003E5__15;

		private DateTime _003CreqEndDt_003E5__16;

		private TaskAwaiter<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> _003C_003Eu__1;

		internal static object FlushCollector;

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
		static _003CDownloadAndStoreTicks_003Ed__11()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MatchStream()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PrepareManager()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnsureEnoughData_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DeciderComparatorExplorer _003C_003E4__this;

		public DateTime iniExchDt;

		public bool forceVolServer;

		public List<CancellationToken> p_tokens;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object AttachCustomizableAllocatorTree;

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
		static _003CEnsureEnoughData_003Ed__10()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAutomatedTreeGenerator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BuildSender()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFillInitData_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DeciderComparatorExplorer _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object PresentVisitor;

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
		static _003CFillInitData_003Ed__9()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateConnectedProjectObserver()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateExpandableObserverRole()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerableForLastSession_003Ed__19 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DeciderComparatorExplorer _003C_003E4__this;

		private FontWeight queueLockAction;

		public FontWeight _003C_003E3__queueLockAction;

		private bool isRevOrder;

		public bool _003C_003E3__isRevOrder;

		private CancellationToken token;

		public CancellationToken _003C_003E3__token;

		private bool _003CneedToCheckRep_003E5__2;

		private byte[] _003CfileBytes_003E5__3;

		private SingletonHandlerConnection.ObjectAuthenticatorLocator _003CtickToAdd_003E5__4;

		private int _003CnumBytesPerLine_003E5__5;

		private int _003CnumLine_003E5__6;

		private int _003Ck_003E5__7;

		private static _003CGetEnumerableForLastSession_003Ed__19 SimulateAutomatableRoleController;

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
		public _003CGetEnumerableForLastSession_003Ed__19(int _003C_003E1__state)
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
		static _003CGetEnumerableForLastSession_003Ed__19()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DetachInitializer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CGetEnumerableForLastSession_003Ed__19 StartResponder()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerableForSessionDate_003Ed__17 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DeciderComparatorExplorer _003C_003E4__this;

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

		private SingletonHandlerConnection.ObjectAuthenticatorLocator _003CtickToAdd_003E5__4;

		private int _003CnumBytesPerLine_003E5__5;

		private int _003CnumLine_003E5__6;

		private int _003Ck_003E5__7;

		private static _003CGetEnumerableForSessionDate_003Ed__17 ScanAuthorizer;

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
		public _003CGetEnumerableForSessionDate_003Ed__17(int _003C_003E1__state)
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
		static _003CGetEnumerableForSessionDate_003Ed__17()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachInternalDefinitionSelector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CGetEnumerableForSessionDate_003Ed__17 GenerateAdjustableSelectorInitializer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CIntLoadData_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CentralAllocator currQueue;

		public TransformerService cacheSession;

		public bool isLastContract;

		public DeciderComparatorExplorer _003C_003E4__this;

		public DateTime? lastReplayDt;

		public object helperData;

		public OrderedAllocator request;

		private int[] _003CfrmIndexList_003E5__2;

		private string _003Cpath_003E5__3;

		private bool _003CisCompressed_003E5__4;

		private bool _003CneedAdjTick_003E5__5;

		private bool _003CneedNotAdjTick_003E5__6;

		private int _003CChartCount_003E5__7;

		private Stopwatch _003CswSingle_003E5__8;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateInterruptibleInitializerResponder;

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
		static _003CIntLoadData_003Ed__16()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateIterableResponderAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateHiddenAuthorizerService()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DeciderComparatorExplorer _003C_003E4__this;

		public OrderedAllocator request;

		public CentralAllocator currQueue;

		public bool isLastContract;

		public DateTime? lastReplayDt;

		private long _003ClblWorkId_003E5__2;

		private int _003CendIndex_003E5__3;

		private Stopwatch _003CswTotal_003E5__4;

		private bool _003CretValue_003E5__5;

		private int _003CcacheIndex_003E5__6;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object GenerateModularServiceSchema;

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
		static _003CLoadData_003Ed__14()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachLocalSchemaValue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateConfigurableValueTracker()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public DeciderComparatorExplorer _003C_003E4__this;

		public CentralAllocator histQueue;

		public OrderedAllocator request;

		public bool isLastContract;

		public DateTime? lastReplayDt;

		public LocatorTesterEditor session;

		public object helperData;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object AttachMixedTrackerList;

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
		static _003CLoadData_003Ed__15()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachScheduledListLocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateMonoLocatorVerifier()
		{
			return null;
		}
	}

	private List<TransformerService> m_MonoValues;

	internal static DeciderComparatorExplorer QueryUser;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public override IReadOnlyList<LocatorTesterEditor> JoinConfiguration()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderComparatorExplorer(CustomDecider first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override LocatorEditorSelector StoreAutomatableSchema(DateTime var1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DetachCreator(int minreference, LocatorEditorSelector cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SaveGroupedTracker(LocatorEditorSelector i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenOperationalMember()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFillInitData_003Ed__9))]
	public override Task SaveFlexibleProcessor(LocatorSelectorTransaction def, CancellationToken pol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnsureEnoughData_003Ed__10))]
	public override Task<bool> OpenEditableSender(DateTime info, List<CancellationToken> visitor = null, bool readfilter = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAndStoreTicks_003Ed__11))]
	private Task<bool> DetermineVirtualPolicy(DateTime v, DateTime? attr, bool isthird, bool setup2open, List<CancellationToken> last3 = null, bool isv4 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MatchDriver(SingletonHandlerConnection.ObjectAuthenticatorLocator reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureScopeSorter(LocatorEditorSelector def, SingletonHandlerConnection.ObjectAuthenticatorLocator map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__14))]
	public override Task<bool> OpenStaticDecryptor(CentralAllocator instance, OrderedAllocator caller, bool hascontrol, DateTime? caller2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__15))]
	public override Task<bool> OpenStaticDecryptor(CentralAllocator first, OrderedAllocator token, bool isfilter, DateTime? connection2, LocatorTesterEditor col3, object ivk4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIntLoadData_003Ed__16))]
	private Task<bool> EnsureLogicalContainer(CentralAllocator value, OrderedAllocator b, bool fieldreguired, DateTime? token2, TransformerService config3, object cust4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerableForSessionDate_003Ed__17))]
	public override IEnumerable<object> SaveCustomizableDefinition(DateTime asset, bool nocfg, bool isconsumer, CancellationToken pol2, FontWeight reg3 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object[] SaveAutomatedSelector(DateTime task, bool includereg, bool excludethird, CancellationToken info2, FontWeight visitor3 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerableForLastSession_003Ed__19))]
	public override IEnumerable<object> BuildRequest(bool loadconfig, CancellationToken pol, FontWeight helper = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object[] OpenConvertibleResponder(FontWeight ident = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetOrder(FontWeight key = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object OpenExpandableService(FontWeight i = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderComparatorExplorer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MoveLogger()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderComparatorExplorer SaveTester()
	{
		return null;
	}
}
