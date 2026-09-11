using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.TradeCopier;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class ScheduledDriver : INotifyPropertyChanged
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFeedConnection_OnStatusChanged_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReceiverValue.RegWLanProfileConnectionType newStatus;

		public ScheduledDriver _003C_003E4__this;

		public LocatorSelectorTransaction connection;

		internal static object SimulateIterableProfileEditor;

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
		static _003CFeedConnection_OnStatusChanged_003Ed__50()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EvaluateMember()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateModularCacheSubscriber()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessBuffer_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ScheduledDriver _003C_003E4__this;

		public CancellationToken token;

		private DateTime? _003CdtLastCheckSyncro_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachLocalSubscriberClient;

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
		static _003CProcessBuffer_003Ed__57()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DirectVisitor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CloseDecryptor()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private PropertyChangedEventHandler _ConvertibleAggregatorDriver;

	[CompilerGenerated]
	private TradeCopierGroupSettings driverSolver;

	private bool m_IsStrategyServer;

	[CompilerGenerated]
	private bool m_IsDriverRecord;

	[CompilerGenerated]
	private AllocatorRecord m_VirtualSingletonDriver;

	[CompilerGenerated]
	private ObservableCollection<AllocatorRecord> joinedAuthorizerDriver;

	[CompilerGenerated]
	private ObservableCollection<AllocatorRecord> _GroupedInitializerDriver;

	private TradeCopierGroupStatusEnum m_FlexibleChainDriver;

	private HashSet<string> _ProcDriver;

	internal HashSet<string> _ReceiverStub;

	private CancellationTokenSource m_DriverNotifier;

	private static ScheduledDriver AttachSegmentedBuilder;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public TradeCopierGroupSettings Settings
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

	public TradeCopierGroupStatusEnum Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TradeCopierGroupStatusEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool IsNotRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool HasWarning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public ObservableCollection<AllocatorRecord> AccountParentItemsSource
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

	public ObservableCollection<AllocatorRecord> AccountChildsInfo
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private bool ExcludeExecutor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void RunTransferableReporter(bool isres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public AllocatorRecord MapGlobalProc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void MoveBuilder(AllocatorRecord setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScheduledDriver(TradeCopierGroupSettings config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadRole(GeneratorBuilder instance, ControllableDecider reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunScopeValue(WriterServerRecommender first, ScopeHandlerDecider.LocatorNotifierMonitor second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceLogicalTracker(WriterServerRecommender asset, ScopeHandlerDecider.ComparatorTracerAllocator cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlGeneralList(WriterServerRecommender info, ScopeHandlerDecider.ViewerConnectionCommand vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunResponsiveLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlSetVerifier()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceSortedProvider(TradeCopierAccountSettings first, bool issecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceVisibleParser(LocatorSelectorTransaction task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFeedConnection_OnStatusChanged_003Ed__50))]
	private Task ForceSequentialProgram(LocatorSelectorTransaction task, ReceiverValue.RegWLanProfileConnectionType counter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceTransformablePublisher(AllocatorRecord instance, LocatorSelectorTransaction pol, bool rejecttag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void PatchLogger()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunSimpleProxy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RunDetailedSet(IEnumerable<ScheduledDriver> param, out string caller)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortAuditor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessBuffer_003Ed__57))]
	private void ForceStatelessModule(CancellationToken v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool RunActiveDecorator(ScheduledDriver setup)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool ForceFilteredValidator(TradeCopierAccountSettings spec)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void ControlPortableReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScheduledDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachCommonCollector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScheduledDriver SplitConnection()
	{
		return null;
	}
}
