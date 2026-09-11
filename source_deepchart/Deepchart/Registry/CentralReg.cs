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
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis;
using VolAnalysis.API.Requester;
using VolAnalysis.Controls;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Grid;
using VolumetricaControls;

namespace Deepchart.Registry;

internal class CentralReg : Window, IComponentConnector
{
	private class StateEnumerator
	{
		public int _PredicateConnectionLevel;

		public AdjustableConnectionRequester _TransferableSharerLocator;

		internal static StateEnumerator PresentWatcher;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateEnumerator(AdjustableConnectionRequester task, int second_Y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StateEnumerator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GetProfile()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StateEnumerator AttachGenericSchemaValue()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CFillMenu_003Eb__39_3_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateSimpleValueTracker;

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
		static _003C_003CFillMenu_003Eb__39_3_003Ed()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DetachSubscriber()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object StartClient()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CtsmGraphSett_Click_003Eb__47_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SimulateStatelessLocatorVerifier;

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
		static _003C_003CtsmGraphSett_Click_003Eb__47_0_003Ed()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachActiveVerifierProvider()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ControlAdapter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInvScanner_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object ResetVerifier;

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
		static _003CInvScanner_003Ed__41()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateEditableReporterTransmitter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateIntegratedTransmitterProc()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadDefaultSettings_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		public bool callLoad;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateStaticProcIterator;

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
		static _003CLoadDefaultSettings_003Ed__29()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachCustomizableIteratorPredicate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAutomatedPredicateExplorer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadScanner_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		public FontWeight gridLockAction;

		private CancellationToken _003CloadingToken_003E5__2;

		private List<Tuple<CommonGenerator.DecryptorRequester, Task<ModificationKind>>> _003ChistTaskResults_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ck_003E5__4;

		private TaskAwaiter<ModificationKind> _003C_003Eu__2;

		internal static object GenerateJoinedExplorerSpec;

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
		static _003CLoadScanner_003Ed__40()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InstantiateSet()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AssembleServer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadTemplate_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		public LoggerRecord item;

		private ScalableRequester _003Cdlg_003E5__2;

		private GeneratorConverter.ValidatorSenderEncryptor _003CnewProp_003E5__3;

		private TaskAwaiter<GeneratorConverter.ValidatorSenderEncryptor> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object AttachExpandableProfilerComparator;

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
		static _003CLoadTemplate_003Ed__61()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAutomatableComparatorStrategy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AdaptValidator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReloadForReplay_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ResponsiveSingleton[] s;

		public CentralReg _003C_003E4__this;

		private bool _003ConceDone_003E5__2;

		private ResponsiveSingleton[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponsiveSingleton _003CcurrS_003E5__5;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SortReg;

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
		static _003CReloadForReplay_003Ed__33()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachIdentifiableHandlerContext()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SendFilter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveSymbol_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		public string symb;

		private static object ValidateWriter;

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
		static _003CRemoveSymbol_003Ed__35()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateInterruptibleInterpreterQueue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateIterableQueueExtractor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRollSymbol_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		public ResponsiveSingleton s;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateHiddenExtractorFinder;

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
		static _003CRollSymbol_003Ed__32()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachModularFinderWatcher()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachLocalWatcherProfile()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateGraphSettings_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool needGridLock;

		public CentralReg _003C_003E4__this;

		public bool updateAlsoCells;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateConfigurableProfileEditor;

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
		static _003CUpdateGraphSettings_003Ed__46()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateMixedEditorCache()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateScheduledCacheSubscriber()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmAddRes_Click_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private CommonGenerator _003CnewRes_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private static object ConcatAuthenticator;

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
		static _003CtsmAddRes_Click_003Ed__49()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachExternalClientExecutor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SetAnnotation()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmGraphSett_Click_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object ExcludeSummarizer;

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
		static _003CtsmGraphSett_Click_003Ed__47()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CreateDictionary()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReadEngine()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmSaveTmp_Click_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private LoggerRecord _003CpickerItem_003E5__2;

		private ScalableRequester _003Cdlg_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		internal static object QueryStack;

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
		static _003CtsmSaveTmp_Click_003Ed__59()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateReadableCollectorStream()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateDividedStreamManager()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CtsmSymbolSett_Click_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CentralReg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AttachIsolatedManagerMember;

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
		static _003CtsmSymbolSett_Click_003Ed__48()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OpenMap()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachScalableProcessorSender()
		{
			return null;
		}
	}

	private GeneratorConverter m_TransformableReg;

	private DeciderVerifierViewer m_RegDefinition;

	internal ServerDecider m_InterpreterReg;

	private Dictionary<ResponsiveSingleton, StateEnumerator> _FilteredCalculatorMap;

	private Dictionary<long, PredictorList> _RecommenderModelMap;

	private int m_ExtendedRegOffset;

	private bool _IsControllerController;

	private int m_AllocatorProgramCount;

	private int concreteRegPos;

	private int _ConfigurableRegCap;

	private Workspace _TaskSingleton;

	private bool isDetailedReg;

	private CancellationTokenSource m_OrderedReg;

	private JoinedInterpreterDecider sorterTransformer;

	[CompilerGenerated]
	private bool m_IsProviderReg;

	internal StackPanel topLeftPnl;

	internal IconButton btnShowHideRank;

	internal MenuItem tsmSettings;

	internal MenuItem tsmResolutions;

	internal MenuItem tsmAddRes;

	internal MenuItem tsmAlwaysTop;

	internal MenuItem tsmSymbolSett;

	internal MenuItem tsmGraphSett;

	internal MenuItem tsmLoadTmp;

	internal MenuItem tsmSaveTmp;

	internal ActiveLocatorAllocator lnkBtn;

	internal TopRightPnl pnlTopRight;

	internal Border stkRank;

	internal NumUpDown nudRankTop;

	internal NumUpDown nudRankWorst;

	internal FlexibleMemberAllocator scannerContainer;

	internal TextBlock lblCopyright;

	private bool _IsRegDispatcher;

	private static CentralReg AttachModularStruct;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CentralReg(ServerDecider v, GeneratorConverter reg, bool tagneeded, Workspace value2, bool getinfo3 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveCustomizableExplorer(WrapperTextBoxMode setup, bool isb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveAutomatedSpec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenJoinedSystem(int assetPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveConvertibleProfiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssembleFilter(object item, RoutedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PatchWriter(bool rejectinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenCombinedHandler(LocatorStateAction value, string selection = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadDefaultSettings_003Ed__29))]
	private void OpenGroupedContext(bool extractkey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveIdentifiableBuffer(object instance, Columns token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveInternalInterpreter(object v, MouseButtonEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRollSymbol_003Ed__32))]
	internal Task ValidateSynchronizer(ResponsiveSingleton setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReloadForReplay_003Ed__33))]
	internal Task SaveInterruptibleExtractor(ResponsiveSingleton[] def)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AwakeCalculator(GeneratorConfigurationArgument.TransferableValueReg[] init, bool explicitpol, bool tempinstall)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSymbol_003Ed__35))]
	internal Task SaveHiddenWatcher(string setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreModularProfile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreLocalEditor(EncryptorCacheBuffer.Series_Prop item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenConfigurableCache(bool extractdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveMixedSubscriber()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadScanner_003Ed__40))]
	internal Task SaveScheduledClient(FontWeight last)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInvScanner_003Ed__41))]
	internal Task StoreMonoExecutor()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ReplaceFinder(ResponsiveSingleton setup, SingletonHandlerConnection.ObjectAuthenticatorLocator vis, bool isrole)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetWatcher(ResponsiveSingleton reference, LocatorQueueTransferProtocol caller, object comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool StorePassiveAttribute(CommonGenerator.DecryptorRequester reference, int? ivk, List<SingletonHandlerConnection.ObjectAuthenticatorLocator> res)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SaveAdaptableBuilder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateGraphSettings_003Ed__46))]
	private Task ReadCache(bool includevalue = true, bool usesecond = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmGraphSett_Click_003Ed__47))]
	private void QuerySubscriber(object init, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmSymbolSett_Click_003Ed__48))]
	private void SaveReadableManager(object i, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmAddRes_Click_003Ed__49))]
	private void OpenDividedMember(object asset, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool ObserveAuthorizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void MonitorService(bool issetup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreIsolatedProcessor(object init, CancelEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenAdapter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenScalableVisitor(object var1, SizeChangedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreVirtualDecryptor(object first, EventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CallCollector(object last, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CtsmSaveTmp_Click_003Ed__59))]
	private void SaveLogicalSelector(object i, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeManager(object first, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadTemplate_003Ed__61))]
	private void SaveResponsiveResponder(LoggerRecord value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SolveProcessor(object def, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveSortedService(object res, RoutedPropertyChangedEventArgs<decimal?> ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveVisibleSchema(object var1, RoutedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncludeDecryptor(object item, RoutedPropertyChangedEventArgs<decimal?> pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreTransformableTracker(object def, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenGenericList()
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
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int offsetinit, object reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_003CFillMenu_003Eb__39_3_003Ed))]
	[CompilerGenerated]
	private void SaveSimpleLocator(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_003CtsmGraphSett_Click_003Eb__47_0_003Ed))]
	[CompilerGenerated]
	private void SaveDetailedVerifier(object key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CentralReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DefineBridge()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CentralReg SimulateConfigurableDriver()
	{
		return null;
	}
}
