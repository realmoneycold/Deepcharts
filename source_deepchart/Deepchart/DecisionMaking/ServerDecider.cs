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
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Threading;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.Drivers;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Models;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.DecisionMaking;

internal class ServerDecider : Window, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public string m_ConfigReporterLabel;

		private static _003C_003Ec__DisplayClass61_0 GenerateCustomizableReporterTransmitter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool EnsureSegmentedTokenizer(Workspace x)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass61_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAutomatedTransmitterProc()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass61_0 AttachJoinedProcIterator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_1
	{
		public LoggerRecord m_RoleAuditor;

		internal static _003C_003Ec__DisplayClass61_1 InstantiateParameter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass61_1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ConcatInitializer(Workspace x)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass61_1()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AssembleProxy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass61_1 AttachExpandableExplorerSpec()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddNewChartToGroup_003Ed__73 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Window callerWindow;

		public ServerDecider _003C_003E4__this;

		public CommonSystemReg chartGroup;

		public DetailedEncryptor chartGroupWnd;

		private CentralFunctionLocator _003CfrmSymbol_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SimulateInterruptibleWorkerSolver;

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
		static _003CAddNewChartToGroup_003Ed__73()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateIterableSolverNotifier()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateHiddenNotifierInterpreter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CChangeCurrentWorkspace_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool needFlushLock;

		public ServerDecider _003C_003E4__this;

		public Workspace work;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AddAggregator;

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
		static _003CChangeCurrentWorkspace_003Ed__45()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateLocalQueueExtractor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachConfigurableExtractorFinder()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CChangeSymbolLink_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int LinkNumber;

		public ResponsiveSingleton newSymb;

		private TaskAwaiter _003C_003Eu__1;

		internal static object PauseLogger;

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
		static _003CChangeSymbolLink_003Ed__54()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachScheduledWatcherProfile()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ConcatNode()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CChangeTradingSymbolLink_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int LinkNumber;

		public ResponsiveSingleton newSymb;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateExternalEditorCache;

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
		static _003CChangeTradingSymbolLink_003Ed__55()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAccessibleCacheSubscriber()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachPassiveSubscriberClient()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCloseWorkspace_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Workspace workToClose;

		public bool confirmSave;

		public ServerDecider _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ReadSummarizer;

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
		static _003CCloseWorkspace_003Ed__96()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateDynamicViewerAdapter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MoveEngine()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateEmptyWorkspace_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool needFlushLock;

		public ServerDecider _003C_003E4__this;

		private Workspace _003CnewWork_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object SaveStack;

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
		static _003CCreateEmptyWorkspace_003Ed__70()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateIsolatedBuilderCollector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachSeparatedCollectorStream()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDetachFromChartGroup_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CommonSystemReg senderGroup;

		public CheckerParser chartElement;

		public ServerDecider _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object CombineThread;

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
		static _003CDetachFromChartGroup_003Ed__83()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachVirtualManagerMember()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachScopeMemberProcessor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateAdvDomForm_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RecommenderWriter oldClass;

		public ServerDecider _003C_003E4__this;

		private RecommenderWriter _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateLogicalProcessorSender;

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
		static _003CDuplicateAdvDomForm_003Ed__86()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateGeneralSenderVisitor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AssetFinalizer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateAdvTS_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FilteredAllocator oldClass;

		public ServerDecider _003C_003E4__this;

		private FilteredAllocator _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateSetDecryptorDefinition;

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
		static _003CDuplicateAdvTS_003Ed__89()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateSortedDefinitionSelector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateVisibleSelectorInitializer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateChartForm_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LocatorObserver oldClass;

		public ServerDecider _003C_003E4__this;

		private LocatorObserver _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateSequentialInitializerResponder;

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
		static _003CDuplicateChartForm_003Ed__84()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateTransformableResponderAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DecompressWrapper()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateCompactDomForm_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ControllerEncryptor oldClass;

		public ServerDecider _003C_003E4__this;

		private ControllerEncryptor _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachSimpleServiceSchema;

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
		static _003CDuplicateCompactDomForm_003Ed__87()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateDetailedSchemaValue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateVisualValueTracker()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateCorrChart_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EfficientAdapterLocator oldClass;

		public ServerDecider _003C_003E4__this;

		private EfficientAdapterLocator _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateStatelessTrackerList;

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
		static _003CDuplicateCorrChart_003Ed__85()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachActiveListLocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CloneDriver()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateHorizontalDomForm_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CalculatorLocator oldClass;

		public ServerDecider _003C_003E4__this;

		private CalculatorLocator _003CnewClass_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachSharer;

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
		static _003CDuplicateHorizontalDomForm_003Ed__88()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateSymbolicProviderParser()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateConcreteParserProgram()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGlobalCrossUpdVoid_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		public Workspace gc_currWork;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AttachCentralProgramPublisher;

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
		static _003CGlobalCrossUpdVoid_003Ed__52()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DefineChain()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateOrderedParameterProxy()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CKeyboardShortcutCallback_003Ed__116 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HotKeyActionEnum hotKeyAction;

		public ServerDecider _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SearchListener;

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
		static _003CKeyboardShortcutCallback_003Ed__116()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ManageDistributor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateCommonServerModule()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnContentRendered_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		public EventArgs e;

		internal static object AttachControllableModuleDecorator;

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
		static _003COnContentRendered_003Ed__28()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LeadElement()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateEfficientValidatorReg()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CResetWorkspaceTS_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachTransferableRegFormatter;

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
		static _003CResetWorkspaceTS_003Ed__48()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateLiteralFormatterGateway()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachGlobalGatewayCompiler()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveWorkspace_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool isUserCall;

		public ServerDecider _003C_003E4__this;

		public Workspace workToSave;

		public bool forceNew;

		public bool isShutdown;

		private LoggerRecord _003CpickerItem_003E5__2;

		private long _003CtaskId_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object GenerateDetachedCompilerPolicy;

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
		static _003CSaveWorkspace_003Ed__62()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateExtendedPolicySorter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EncodeEnumerator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowWorkspace_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Workspace newWork;

		private List<GeneratorConverter>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SimulateAttachedContainerInspector;

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
		static _003CShowWorkspace_003Ed__46()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JoinSingleton()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ResumeCalculator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartTutorial_003Ed__130 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateFlexibleErrorMapper;

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
		static _003CStartTutorial_003Ed__130()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FlushWorker()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachIntegratedMatcherReporter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWorkspaceChanged_Click_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		public Workspace work;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateStaticReporterTransmitter;

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
		static _003CWorkspaceChanged_Click_003Ed__44()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateCustomizableTransmitterProc()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateAutomatedProcIterator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWorkspace_Loaded_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string p_workspaceToSelect;

		public List<LoggerRecord> items;

		public ServerDecider _003C_003E4__this;

		private _003C_003Ec__DisplayClass61_1 _003C_003E8__1;

		private _003C_003Ec__DisplayClass61_0 _003C_003E8__2;

		private List<Workspace> _003CworksParsed_003E5__2;

		private List<Task> _003CpendTaskList_003E5__3;

		private List<Task> _003CchartTaskList_003E5__4;

		private List<LoggerRecord>.Enumerator _003C_003E7__wrap4;

		private long _003CloadTaskId_003E5__6;

		private TaskAwaiter<Workspace> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object BuildExtractor;

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
		static _003CWorkspace_Loaded_003Ed__61()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateConvertiblePredicateExplorer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GetWatcher()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmDownloadData_Click_003Ed__108 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private WriterTracker _003CnewDownForm_003E5__2;

		private DividedDriver _003CsplashFrm_003E5__3;

		private List<string>.Enumerator _003C_003E7__wrap3;

		private ResponsiveSingleton _003CSymbInfoGlobal_003E5__5;

		private List<string>.Enumerator _003C_003E7__wrap5;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateExpandableSpecSystem;

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
		static _003CtsmDownloadData_Click_003Ed__108()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachAutomatableSystemProfiler()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DetachCache()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmFeedSett_Click_003Ed__119 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateGroupedComparatorStrategy;

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
		static _003CtsmFeedSett_Click_003Ed__119()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateIdentifiableStrategyRecord()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachInternalAnalyzerWorker()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewAdvDom_Click_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymb_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object ControlViewer;

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
		static _003CtsmNewAdvDom_Click_003Ed__92()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateInterruptibleSolverNotifier()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateIterableNotifierInterpreter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewChart_Click_003Ed__72 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachHiddenInterpreterQueue;

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
		static _003CtsmNewChart_Click_003Ed__72()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TrackCollector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RestartStream()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewCompactDom_Click_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymb_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateConfigurableFinderWatcher;

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
		static _003CtsmNewCompactDom_Click_003Ed__93()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateMixedWatcherProfile()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CollectProcessor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewCorrVwr_Click_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private GeneratorProxy _003CnewParam_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateMonoEditorCache;

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
		static _003CtsmNewCorrVwr_Click_003Ed__90()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateExternalCacheSubscriber()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateAccessibleSubscriberClient()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewHorizontalDom_Click_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymb_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachPassiveClientExecutor;

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
		static _003CtsmNewHorizontalDom_Click_003Ed__94()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAdaptableExecutorViewer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateRandomViewerAdapter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewProfileChart_Click_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymbol_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateDynamicAdapterAttribute;

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
		static _003CtsmNewProfileChart_Click_003Ed__74()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MergeAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateDividedBuilderCollector()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewScanner_Click_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymb_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachIsolatedCollectorStream;

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
		static _003CtsmNewScanner_Click_003Ed__91()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSeparatedStreamManager()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateScalableManagerMember()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewTS_Click_003Ed__75 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private CentralFunctionLocator _003CfrmSymbol_003E5__2;

		private SingletonRunner _003Cfrm_chart_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateVirtualMemberProcessor;

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
		static _003CtsmNewTS_Click_003Ed__75()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateScopeProcessorSender()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachLogicalSenderVisitor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmNewWork_Click_003Ed__101 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		internal static object AttachGeneralVisitorDecryptor;

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
		static _003CtsmNewWork_Click_003Ed__101()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WriteParser()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateSetDefinitionSelector()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmToolBigTrades_Click_003Ed__132 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ServerDecider _003C_003E4__this;

		private GeneratorConfigurationArgument.TransferableValueReg _003CsymbSelected_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachSortedSelectorInitializer;

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
		static _003CtsmToolBigTrades_Click_003Ed__132()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateVisibleInitializerResponder()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InstantiateProxy()
		{
			return null;
		}
	}

	private string m_DecoratorElementCategory;

	internal string m_SeparatedDeciderCategory;

	private string _RecommenderTrackerStatus;

	internal string deciderPoolID;

	public ToolAllConfig m_DeciderError;

	public ScopeLocator activeDecider;

	public ResponsiveRequester m_GenericDecider;

	private LogicalLocator deciderExecutor;

	public CustomizableEncryptor integratedDecider;

	internal static bool _IsSolverSelector;

	private Task _StatelessHandler;

	private int m_DeciderModuleValue;

	private int m_ScheduledDeciderVal;

	private ResponsiveSingleton m_ModularDecider;

	private DateTime globalDecider;

	private double _MixedDecider;

	private SemaphoreSlim m_DeciderPredicate;

	private ServerAllocator _DetailedDecider;

	private object m_PortableDeciderObj;

	internal bool _IsDeciderSolver;

	private bool isChooserStub;

	private LocatorDefinitionStream m_IntegratedProcessor;

	private bool _IsSubscriberRunner;

	private bool m_IsChooserDecider;

	internal Grid grdMain;

	internal MenuItem tsmNew;

	internal MenuItem tsmNewTS;

	internal MenuItem tsmNewAdvDom;

	internal MenuItem tsmNewHorizontalDom;

	internal MenuItem tsmNewCompactDom;

	internal MenuItem tsmNewCorrVwr;

	internal MenuItem tsmNewChart;

	internal MenuItem tsmNewProfileChart;

	internal MenuItem tsmNewScanner;

	internal MenuItem tsmNewStatistics;

	internal MenuItem tsmAlerts;

	internal MenuItem tsmEnableAlertSound;

	internal MenuItem tsmEnableAlertMsg;

	internal MenuItem tsmEnableAlertWebinar;

	internal MenuItem tsmAlertTrading;

	internal MenuItem tsmReplayData;

	internal MenuItem tsmSymbRoll;

	internal MenuItem tsmDownloadData;

	internal MenuItem tsmDeleteData;

	internal MenuItem tsmMigrateDb;

	internal MenuItem tsmSymbolMng;

	internal MenuItem tsmOptions;

	internal MenuItem tsmShowLog;

	internal MenuItem tsmShowCalendar;

	internal MenuItem tsmToolBigTrades;

	internal MenuItem tsmToolFreeRam;

	internal MenuItem tsmTrading;

	internal MenuItem tsmStrategyRep;

	internal MenuItem tsmShowOrders;

	internal MenuItem tsmShowPort;

	internal MenuItem tsmTradeCopier;

	internal MenuItem tsmWindow;

	internal MenuItem tsmTileVertically;

	internal MenuItem tsmTileHorizontally;

	internal MenuItem tsmArrange;

	internal MenuItem tsmAboutMeeting;

	internal MenuItem tsmAboutInfo;

	internal MenuItem tsmWebsite;

	internal MenuItem tsmHelp;

	internal Label lblWork;

	internal RegDistributorBuffer drpWorkspace;

	internal WrapperPolicy menuFeedDropdown;

	internal IconButton btnMinimize;

	internal IconButton btnClose;

	internal TextBlock txtSystemWarning;

	private bool isSpecDecider;

	private static ServerDecider GenerateGroupedProgram;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ServerDecider(Action<string> last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideEfficientValidator(ref MSG init, ref bool cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnContentRendered_003Ed__28))]
	protected override void OnContentRendered(EventArgs item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureTransferableReg(object i, CancelEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineLiteralFormatter(object i, SessionEndingCancelEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureGlobalGateway(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveEditor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool SaveCache()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideCustomSorter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResponsiveRequester OpenClient()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecideBasicInspector(Point info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecideOperationalTransaction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CallAdapter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureEditableMapper(bool requiresinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecideIntegratedMatcher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EnsureStaticReporter(Action<string> ident)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GeneralGenerator EnsureCustomizableTransmitter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWorkspaceChanged_Click_003Ed__44))]
	private void WorkspaceChanged_Click(object sender, Workspace work)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeCurrentWorkspace_003Ed__45))]
	private Task DetermineAutomatedProc(Workspace init, bool hasattr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShowWorkspace_003Ed__46))]
	private Task DecideJoinedIterator(Workspace init)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncludeProcessor(Workspace param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetWorkspaceTS_003Ed__48))]
	internal Task DetermineConnectedExplorer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void EnsureExpandableSpec(Workspace def, int endcol, ResponsiveSingleton c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void EnsureAutomatableSystem(Workspace value, int previouspol, ResponsiveSingleton control)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void EnsureCombinedProfiler(Workspace instance, int offset_cfg, ResponsiveSingleton pool, DateTime v2, double token3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGlobalCrossUpdVoid_003Ed__52))]
	private Task ObserveSelector(Workspace var1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DecideIdentifiableStrategy(int first_max, ResponsiveSingleton cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeSymbolLink_003Ed__54))]
	internal Task PopResponder(int var1_ID, ResponsiveSingleton second)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeTradingSymbolLink_003Ed__55))]
	internal Task DecideAdjustableWorker(int start_task, ResponsiveSingleton visitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CustomDecider DetermineInterruptibleSolver(ResponsiveSingleton param)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EnsureIterableNotifier(Workspace setup)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenWorkspace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineHiddenInterpreter(Workspace setup, List<UserMonitorInfo> token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureModularQueue(List<UserMonitorInfo> var1, List<UserMonitorInfo> b, LocatorBridge filter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWorkspace_Loaded_003Ed__61))]
	private void DetermineLocalExtractor(List<LoggerRecord> key, string visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveWorkspace_003Ed__62))]
	public Task DetermineConfigurableFinder(Workspace init, bool loadpred = true, bool comparepool = false, bool noivk2 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecideMixedWatcher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetermineScheduledProfile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineMonoEditor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SplitProgram(object config, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LeadPublisher(bool novalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CancelParameter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TimeZoneInfo PlayProxy(ReceiverValue.TimeZoneList param)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateEmptyWorkspace_003Ed__70))]
	private Task EnsureRandomViewer(bool isreference = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> InterruptServer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewChart_Click_003Ed__72))]
	private void EnsureReadableAttribute(object item, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddNewChartToGroup_003Ed__73))]
	public Task EnsureDividedBuilder(Window init, CommonSystemReg attr, DetailedEncryptor serv)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewProfileChart_Click_003Ed__74))]
	private void EnsureIsolatedCollector(object last, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewTS_Click_003Ed__75))]
	private void FilterReg(object item, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Workspace_Save(object sender, Workspace e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Workspace_SaveAs(object sender, Workspace e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureScalableManager(WrapperTextBoxMode value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideVirtualMember(object spec, EventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PeekCompiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DispatcherOperation FlushPolicy(Action asset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureGeneralVisitor(object var1, EventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDetachFromChartGroup_003Ed__83))]
	public void EnsureResponsiveDecryptor(CommonSystemReg value, CheckerParser vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateChartForm_003Ed__84))]
	public void SelectInspector(LocatorObserver item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateCorrChart_003Ed__85))]
	public void DetermineSortedSelector(EfficientAdapterLocator spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateAdvDomForm_003Ed__86))]
	public void BuildError(RecommenderWriter init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateCompactDomForm_003Ed__87))]
	public void PresentMapper(ControllerEncryptor item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateHorizontalDomForm_003Ed__88))]
	public void EnsureTransformableAuthorizer(CalculatorLocator var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateAdvTS_003Ed__89))]
	internal void DecideGenericService(FilteredAllocator config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewCorrVwr_Click_003Ed__90))]
	private void EnsureSimpleSchema(object spec, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewScanner_Click_003Ed__91))]
	private void DecideDetailedValue(object i, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewAdvDom_Click_003Ed__92))]
	private void StartIterator(object setup, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewCompactDom_Click_003Ed__93))]
	private void DecideStatelessList(object info, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewHorizontalDom_Click_003Ed__94))]
	private void DecideActiveLocator(object param, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineFilteredVerifier(object key, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCloseWorkspace_003Ed__96))]
	private void EnsurePortableProvider(Workspace asset, bool isselection = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideSymbolicParser(object asset, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineConcreteProgram(object first, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureCentralPublisher(object var1, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int DecideAdvancedParameter(Window i, Window vis)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmNewWork_Click_003Ed__101))]
	private void tsmNewWork_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tsmCloseWork_Click(object sender, Workspace workspace)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DirectHandler(object var1, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureAlphabeticSet(object v, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureSegmentedServer(object res, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineCommonModule(object reference, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupState(object setup, EventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmDownloadData_Click_003Ed__108))]
	private void DetermineRemoteValidator(object reference, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineEfficientReg(object first, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureTransferableFormatter(object ident, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideLiteralGateway(object setup, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessChecker(object asset, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideDetachedPolicy(object value, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineExtendedSorter(object def, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchPool(object param, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CKeyboardShortcutCallback_003Ed__116))]
	private void EnsureAttachedInspector(HotKeyActionEnum key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideBasicTransaction(object key, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideOperationalError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmFeedSett_Click_003Ed__119))]
	private void tsmFeedSett_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineFlexibleMapper(object init, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineEditableMatcher(object res, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableGenerator(object init, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureStaticTransmitter(nint[] instance, ViewerInitializerKind connection, bool servreguired, int value2_Ptr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlanProject(object i, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureAutomatedIterator(object res, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckRole(object item, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineConvertibleExplorer(object def, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureConnectedSpec(object key, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideExpandableSystem(object init, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartTutorial_003Ed__130))]
	private Task DecideAutomatableProfiler(CancellationToken task)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdaptWriter(object asset, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmToolBigTrades_Click_003Ed__132))]
	private void EnsureGroupedStrategy(object spec, RoutedEventArgs ivk)
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
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int value_Position, object pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void DecideIdentifiableRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void SendReceiver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void DecideAdjustableSolver(List<string> first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private void EnsureInterruptibleNotifier(EventArgs info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void DetermineIterableInterpreter(AllocatorAdapter res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CalcSingleton(AllocatorAdapter instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void EnsureModularExtractor(AllocatorAdapter spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ScanFunction()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerDecider AttachInternalConnection()
	{
		return null;
	}
}
