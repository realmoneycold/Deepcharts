using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegWatcherStream
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public HttpListenerContext _AllocatorNotifierPublisherList;

		private static _003C_003Ec__DisplayClass31_0 GenerateStatelessBufferMonitor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<HttpListenerWebSocketContext>? AllocateCustomMap()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass31_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateActiveMonitorState()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass31_0 ControlPublisher()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCloseAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RegWatcherStream _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GeneratePortableArgumentConsumer;

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
		static _003CCloseAsync_003Ed__30()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateSymbolicConsumerTemplate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateConcreteTemplateTag()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessIncomingRequest_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RegWatcherStream _003C_003E4__this;

		public CancellationToken cancellationToken;

		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		private TaskAwaiter<HttpListenerContext> _003C_003Eu__1;

		private string _003Cip_003E5__2;

		private Dictionary<string, string> _003Cdict_003E5__3;

		private HttpListenerWebSocketContext _003CwebSocketContext_003E5__4;

		private TaskAwaiter<HttpListenerWebSocketContext> _003C_003Eu__2;

		private HiddenLocatorLocator _003CwebSocketConnection_003E5__5;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private static object TrackServer;

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
		static _003CProcessIncomingRequest_003Ed__31()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAdvancedCheckerTokenizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachOrderedTokenizerEvaluator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RegWatcherStream _003C_003E4__this;

		public CancellationToken appToken;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AttachAlphabeticEvaluatorPool;

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
		static _003CStartAsync_003Ed__29()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateSegmentedPoolTracer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachCommonTracerPredictor()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private Uri _SorterChecker;

	[CompilerGenerated]
	private bool isExtendedDefinitionReg;

	[CompilerGenerated]
	private TimeSpan? streamConfig;

	private CancellationTokenSource m_ConcreteInterpreterReg;

	private SemaphoreSlim bufferPublisher;

	private TransformableDecryptorReg configurableProviderReg;

	private CentralSynchronizerReg regErrorChain;

	private InternalTesterWrapper _RegStreamVerifier;

	private AllocatorFilterChecker regChainServer;

	private RegSetError _LocalElement;

	private AllocatorFilterChecker engineHandler;

	private AllocatorAggregatorWorker _RegVerifierSender;

	private GroupedProcessorRequester requestSingleton;

	private AllocatorAggregatorWorker _ExplorerEmitter;

	private int _DetailedDispatcherRegs;

	private HttpListener checkerAggregators;

	private int hiddenProfilerVol;

	private static RegWatcherStream StopStrategy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public Uri OpenTransferableNode()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void ViewMap(Uri setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool SaveDetachedCollection()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void AccessExtendedAnnotation(bool comparekey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public TimeSpan? SaveAttachedDictionary()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void CountEvent(TimeSpan? instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegWatcherStream(string ident, int start_reg = 15, int positionpool = 4194304)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreConcreteModel(TransformableDecryptorReg setup, CentralSynchronizerReg selection, InternalTesterWrapper proc, AllocatorFilterChecker first2 = null, RegSetError key3 = null, AllocatorFilterChecker spec4 = null, AllocatorAggregatorWorker cfg5 = null, GroupedProcessorRequester spec6 = null, AllocatorAggregatorWorker instance7 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveCentralRequester()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartAsync_003Ed__29))]
	public Task RestartCollection(CancellationToken def)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCloseAsync_003Ed__30))]
	public Task DirectAnnotation()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessIncomingRequest_003Ed__31))]
	private Task SaveAlphabeticConverter(CancellationToken res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string CollectDictionary(HttpListenerContext instance, bool readivk = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T HandleEngine<T>(HttpListenerContext last, string col)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<string> SetupStack(string first, bool writereg = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void StoreCalc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task<HttpListenerContext>? RateDic()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWatcherStream()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdaptRecord()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegWatcherStream GenerateGroupedAuditorAuthenticator()
	{
		return null;
	}
}
