using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Connection.Enums;

namespace VolAnalysis.Creations;

internal class ResponsiveSingleton
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnsureEnoughData_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ResponsiveSingleton _003C_003E4__this;

		public DateTime iniExchDt;

		public string cacheKey;

		public List<CancellationToken> p_tokens;

		public bool forceVolServer;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ck_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__2;

		internal static object AttachIntegratedIteratorPredicate;

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
		static _003CEnsureEnoughData_003Ed__34()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateStaticPredicateExplorer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateCustomizableExplorerSpec()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFillInitData_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ResponsiveSingleton _003C_003E4__this;

		public LocatorSelectorTransaction feedConnection;

		public CancellationToken token;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ck_003E5__2;

		internal static object FillCommand;

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
		static _003CFillInitData_003Ed__33()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FindWrapper()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IncludeConfig()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetContinuosList_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<OrderedAllocator>> _003C_003Et__builder;

		public ResponsiveSingleton _003C_003E4__this;

		public FontWeight queueLockAction;

		public DateTime p_IniDt;

		public EncryptorCacheBuffer.RolloverTypeEnum p_RollType;

		public string cacheKey;

		private LocatorSelectorTransaction _003CfeedConn_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateConnectedComparatorStrategy;

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
		static _003CGetContinuosList_003Ed__35()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DecompressRecommender()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GuideStruct()
		{
			return null;
		}
	}

	public GeneratorConfigurationArgument.TransferableValueReg configurationSingleton;

	public List<CustomDecider> m_ListenerProcessorList;

	[CompilerGenerated]
	private CustomDecider m_AccessibleSingleton;

	public DateTime m_DetachedSingleton;

	[CompilerGenerated]
	private bool isTokenizerEncryptor;

	[CompilerGenerated]
	private bool _IsSingletonTask;

	private bool m_IsAdaptableSingleton;

	[CompilerGenerated]
	private ReceiverValue.AxisName randomSingleton;

	public ManualResetEvent _ModuleTester;

	private SemaphoreSlim m_ExpandableSingleton;

	private static ResponsiveSingleton GenerateOrderedViewer;

	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public bool SymbolShouldNeedRollover
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

	public bool SymbolShouldNeedRollback
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

	public LocatorSelectorTransaction Connection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int StopFactory()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public CustomDecider InstantiateGroupedState()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void MapIdentifiableArgument(CustomDecider task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ReceiverValue.AxisName AssessInterpreter()
	{
		return (ReceiverValue.AxisName)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AnalyzeQueue(ReceiverValue.AxisName i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public PriceReferenceEnum CompressFinder()
	{
		return (PriceReferenceEnum)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public GeneratorConfigurationArgument.RemoteContextLocatorKinds EnsureExternalBuilder()
	{
		return (GeneratorConfigurationArgument.RemoteContextLocatorKinds)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResponsiveSingleton(GeneratorConfigurationArgument.TransferableValueReg last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFillInitData_003Ed__33))]
	public Task InstantiateExtendedMatcher(LocatorSelectorTransaction key, CancellationToken map)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnsureEnoughData_003Ed__34))]
	public Task EnsureCustomReporter(string def, DateTime cust, List<CancellationToken> pool = null, bool rejectfirst2 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetContinuosList_003Ed__35))]
	public Task<List<OrderedAllocator>> ConvertTree(string reference, DateTime attr, EncryptorCacheBuffer.RolloverTypeEnum rule, FontWeight reference2 = (FontWeight)0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int DestroyBasicProc(DateTime config, bool updateord = true)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadRunner(string first, out DateTime? reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetProject(string ident, out DateTime? ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyEditableExplorer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureIntegratedSpec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlanModel(DateTime v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DestroyAutomatedComparator(CustomDecider spec, CustomDecider cfg)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyJoinedStrategy(bool requiresconfig = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InstantiateWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InstantiateConnectedHandler(DateTime setup)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PatchAggregator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResponsiveSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateAlphabeticAdapter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ResponsiveSingleton CollectInterpreter()
	{
		return null;
	}
}
