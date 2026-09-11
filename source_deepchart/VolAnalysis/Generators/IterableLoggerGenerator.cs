using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.Drivers;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaProtcol.Bridge;
using VolumetricaProtcol.Info;
using VolumetricaProtcol.Trading;

namespace VolAnalysis.Generators;

internal class IterableLoggerGenerator : LocatorSelectorTransaction
{
	private class EncryptorNotifierParser
	{
		public TaskCompletionSource<object> encryptorParserAuthenticator;

		public InternalResolverRequester _ConfigCommand;

		public object _HandlerNotifierObj;

		internal static EncryptorNotifierParser DetachParser;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorNotifierParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EncryptorNotifierParser()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool StartProgram()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EncryptorNotifierParser SimulateStatelessArgumentConsumer()
		{
			return null;
		}
	}

	private class ListenerResponderWrapper
	{
		public object wrapperResponderDefinitionObj;

		public GeneratorConfigurationArgument.TransferableValueReg m_WrapperDefinitionSender;

		private static ListenerResponderWrapper GenerateActiveConsumerTemplate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ListenerResponderWrapper()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ListenerResponderWrapper()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateFilteredTemplateTag()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ListenerResponderWrapper AttachPortableTagChecker()
		{
			return null;
		}
	}

	private class FilterPoolReg
	{
		public Dictionary<int, int> regPredicateProfileMap;

		public Dictionary<int, int> regPoolStructMap;

		public int _RegProfileDecoratorFlag;

		internal static FilterPoolReg RunServer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilterPoolReg()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FilterPoolReg()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateConcreteTokenizerEvaluator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FilterPoolReg AttachCentralEvaluatorPool()
		{
			return null;
		}
	}

	private class FilteredVerifierDecider
	{
		public decimal activeInitializer;

		public int m_ProfilePredicateValue;

		private static FilteredVerifierDecider GenerateAdvancedPoolTracer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilteredVerifierDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FilteredVerifierDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateOrderedTracerPredictor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FilteredVerifierDecider CloseFormatter()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public IterableLoggerGenerator sequentialRecommenderDecider;

		public CancellationToken? m_IterableRecommender;

		internal static _003C_003Ec__DisplayClass47_0 AttachRemoteGeneratorRunner;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task? DetermineSeparatedRunner()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass47_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateEfficientRunnerProject()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass47_0 FormatInspector()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass53_0<T> where T : class
	{
		public TaskCompletionSource<object> m_DeciderTemplateFunction;

		private static object SimulateLiteralObserverRole;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass53_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DetermineScalableProject()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass53_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ProcessError()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MergeMapper()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCancellAllAndFlat_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] Contracts;

		public IterableLoggerGenerator _003C_003E4__this;

		public string AccountId;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateExtendedModelRequester;

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
		static _003CCancellAllAndFlat_003Ed__92()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachCustomRequesterFilter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ConvertTransmitter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCancellAllOrders_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] Contracts;

		public IterableLoggerGenerator _003C_003E4__this;

		public string AccountId;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateBasicWriterConverter;

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
		static _003CCancellAllOrders_003Ed__91()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachOperationalConverterAggregator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateFlexibleAggregatorFactory()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCloseAllConnectionAsync_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public bool skipStatusAssign;

		public bool isLost;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateEditableFactoryUser;

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
		static _003CCloseAllConnectionAsync_003Ed__51()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateIntegratedUserLogger()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateStaticLoggerTester()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCloseVolBridge_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter<VolumetricaProtcol.Bridge.ServerResponseMsg> _003C_003Eu__1;

		internal static object PlanProfiler;

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
		static _003CCloseVolBridge_003Ed__43()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAutomatedNodeAuditor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachJoinedAuditorAuthenticator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnect_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		public string IPEndLocal;

		private ReceiverValue.RegWLanProfileConnectionType _003ColdStatus_003E5__2;

		private object _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<(bool, string)> _003C_003Eu__2;

		private Exception _003Cex_003E5__4;

		private static object AttachConvertibleAuthenticatorCollection;

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
		static _003CConnect_003Ed__47()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachConnectedCollectionAnnotation()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PatchContext()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectionClosed_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool isUnexpected;

		public IterableLoggerGenerator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object GenerateAutomatableSummarizerDictionary;

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
		static _003CConnectionClosed_003Ed__49()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachCombinedDictionaryEngine()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateGroupedEngineStack()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectionError_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		internal static object AttachIdentifiableStackCalc;

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
		static _003CConnectionError_003Ed__50()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachInternalProxySet()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateAdjustableSetServer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateOcoGroupForOrders_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string AccountId;

		public ScopeHandlerDecider.RegFieldFinderEnum groupType;

		public List<long> orgOrderIds;

		public IterableLoggerGenerator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object GenerateInterruptibleServerModule;

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
		static _003CCreateOcoGroupForOrders_003Ed__94()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateIterableModuleDecorator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateHiddenDecoratorValidator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisconnect_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public bool isUserAction;

		private bool _003Clocked_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private static object GenerateModularValidatorReg;

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
		static _003CDisconnect_003Ed__52()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachLocalRegFormatter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachConfigurableFormatterGateway()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CElaborateQueue_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter _003C_003Eu__1;

		private static object PauseDriver;

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
		static _003CElaborateQueue_003Ed__63()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateScheduledCompilerPolicy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachMonoPolicySorter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteHttpBridgeRequest_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<VolumetricaProtcol.Bridge.ServerResponseMsg> _003C_003Et__builder;

		public int? p_bridgePort;

		public string bridgeAddress;

		public ClientRequestMsg clientReq;

		private int _003CbridgePort_003E5__2;

		private int _003CnumTry_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private HttpWebRequest _003CwebReq_003E5__4;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private TaskAwaiter<WebResponse> _003C_003Eu__3;

		internal static object ReplaceObject;

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
		static _003CExecuteHttpBridgeRequest_003Ed__45()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SetRequest()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExcludeChain()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteWssRequest_003Ed__53<T> : IAsyncStateMachine where T : class
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public ITransformableExtractorLocator clientMsg;

		public IterableLoggerGenerator _003C_003E4__this;

		public InternalResolverRequester socket;

		public long timeoutMs;

		public object helperData;

		private _003C_003Ec__DisplayClass53_0<T> _003C_003E8__1;

		private Stopwatch _003Csw_003E5__2;

		private CancellationTokenSource _003CrequestToken_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

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
		static _003CExecuteWssRequest_003Ed__53()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReadListener()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateDynamicMapperMatcher()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFlatAllPositions_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] Contracts;

		public IterableLoggerGenerator _003C_003E4__this;

		public string AccountId;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateReadableMatcherReporter;

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
		static _003CFlatAllPositions_003Ed__93()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SaveToken()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateIsolatedTransmitterProc()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFlatPosition_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string AccountId;

		public IterableLoggerGenerator _003C_003E4__this;

		public string Contract;

		public long PositionId;

		private TaskAwaiter _003C_003Eu__1;

		private static object OpenEmitter;

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
		static _003CFlatPosition_003Ed__90()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateScalableIteratorPredicate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TestChooser()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetContractID_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<long> _003C_003Et__builder;

		public string p_ContractName;

		public IterableLoggerGenerator _003C_003E4__this;

		public bool isTrading;

		private string _003CContractName_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<VolumetricaProtcol.Info.ServerResponseMsg> _003C_003Eu__2;

		private GeneratorConfigurationArgument.TransferableValueReg _003CsymbInfo_003E5__3;

		private string _003CfeedName_003E5__4;

		internal static object CallFunction;

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
		static _003CGetContractID_003Ed__55()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ParseReceiver()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateGeneralSystemProfiler()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetContractNameFromContractId_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public bool isTrading;

		public long ContractId;

		private TaskAwaiter<VolumetricaProtcol.Info.ServerResponseMsg> _003C_003Eu__1;

		internal static object SimulateResponsiveProfilerComparator;

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
		static _003CGetContractNameFromContractId_003Ed__56()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateSetComparatorStrategy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FillSingleton()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetDomSnapshot_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public string ContractName;

		public bool NeedFullDepth;

		private TaskAwaiter<long> _003C_003Eu__1;

		private TaskAwaiter<EditableWrapperReg> _003C_003Eu__2;

		private static object AttachVisibleRecordHandler;

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
		static _003CGetDomSnapshot_003Ed__60()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateSequentialHandlerContext()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReceiveWorker()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistBarIntAsync2_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickGrouping)> _003C_003Et__builder;

		public string ContractName;

		public IterableLoggerGenerator _003C_003E4__this;

		public int resValue;

		public ReceiverValue.RandomTreeRegValues resType;

		public bool requestVbp;

		public DateTime iniUtcDt;

		public DateTime? endUtcDt;

		private GeneratorConfigurationArgument.TransferableValueReg _003CsymbInfo_003E5__2;

		private List<SingletonHandlerConnection.SetControllerRequester> _003CminList_003E5__3;

		private RequesterEngineEmitter.LocatorExtractorQueueEnum _003CresTypeProto_003E5__4;

		private DetailedTagLocator _003CreqMsg_003E5__5;

		private DetailedTagLocator _003C_003E7__wrap5;

		private RequesterEngineEmitter _003C_003E7__wrap6;

		private RequesterEngineEmitter _003C_003E7__wrap7;

		private TaskAwaiter<long> _003C_003Eu__1;

		private TaskAwaiter<SortedEventSingleton> _003C_003Eu__2;

		private static object GenerateGenericBufferMonitor;

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
		static _003CGetHistBarIntAsync2_003Ed__66()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateSimpleMonitorState()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachDetailedStateArgument()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistBarIntAsync_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<SingletonHandlerConnection.SetControllerRequester>> _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public GeneratorConfigurationArgument.ModuleLoggerKind Category;

		public string ContractName;

		public ReceiverValue.RandomTreeRegValues resType;

		public int resValue;

		public bool requestVbp;

		public DateTime iniUtcDt;

		public DateTime? endUtcDt;

		private TaskAwaiter<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickGrouping)> _003C_003Eu__1;

		private static object SimulateVisualArgumentConsumer;

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
		static _003CGetHistBarIntAsync_003Ed__65()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MonitorExtractor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachActiveTemplateTag()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistBarsAsync_003Ed__68 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickMultiplier)> _003C_003Et__builder;

		public string ContractName;

		public IterableLoggerGenerator _003C_003E4__this;

		public ReceiverValue.RandomTreeRegValues resType;

		public int resValue;

		public bool requestVbp;

		public DateTime iniUtcDt;

		public DateTime? endUtcDt;

		public GeneratorConfigurationArgument.ModuleLoggerKind Category;

		private List<SingletonHandlerConnection.SetControllerRequester> _003CcurrMinList_003E5__2;

		private string _003CvolumetricaSymb_003E5__3;

		private TaskAwaiter<List<SingletonHandlerConnection.SetControllerRequester>> _003C_003Eu__1;

		private List<SingletonHandlerConnection.SetControllerRequester> _003C_003E7__wrap3;

		private TaskAwaiter<(List<SingletonHandlerConnection.SetControllerRequester> data, int? vbpTickGrouping)> _003C_003Eu__2;

		internal static object GenerateFilteredTagChecker;

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
		static _003CGetHistBarsAsync_003Ed__68()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulatePortableCheckerTokenizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateSymbolicTokenizerEvaluator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistDataAsync_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> _003C_003Et__builder;

		public string ContractName;

		public IterableLoggerGenerator _003C_003E4__this;

		public DateTime iniUtcDt;

		public DateTime? endUtcDt;

		public GeneratorConfigurationArgument.ModuleLoggerKind Category;

		private string _003CvolumetricaSymb_003E5__2;

		private List<SingletonHandlerConnection.ObjectAuthenticatorLocator> _003CcurrTickList_003E5__3;

		private TaskAwaiter<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> _003C_003Eu__1;

		private List<SingletonHandlerConnection.ObjectAuthenticatorLocator> _003C_003E7__wrap3;

		private DateTime _003CiniIntradayDt_003E5__5;

		internal static object ReflectCache;

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
		static _003CGetHistDataAsync_003Ed__67()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateCentralPoolTracer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachAdvancedTracerPredictor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistDataIntAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> _003C_003Et__builder;

		public string ContractName;

		public IterableLoggerGenerator _003C_003E4__this;

		public DateTime iniUtcDt;

		public DateTime? endUtcDt;

		private GeneratorConfigurationArgument.TransferableValueReg _003CsymbInfo_003E5__2;

		private List<SingletonHandlerConnection.ObjectAuthenticatorLocator> _003CtickList_003E5__3;

		private DetailedTagLocator _003CreqMsg_003E5__4;

		private DetailedTagLocator _003C_003E7__wrap4;

		private DetachedFormatterRequester _003C_003E7__wrap5;

		private DetachedFormatterRequester _003C_003E7__wrap6;

		private TaskAwaiter<long> _003C_003Eu__1;

		private TaskAwaiter<SortedEventSingleton> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		internal static object CustomizeExecutor;

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
		static _003CGetHistDataIntAsync_003Ed__64()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachAlphabeticTransformerAllocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ManageAdapter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessTradingBracketInfo_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public BracketInfoMsg newInfo;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object SimulateCommonTreeGenerator;

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
		static _003CProcessTradingBracketInfo_003Ed__82()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachControllableGeneratorRunner()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateRemoteRunnerProject()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessTradingOrderInfo_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public OrderInfoMsg newInfo;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object CancelStream;

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
		static _003CProcessTradingOrderInfo_003Ed__81()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateTransferableObserverRole()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateLiteralRoleController()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessTradingPositionInfo_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public PositionInfoMsg newInfo;

		public bool isSnapshot;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object GenerateGlobalControllerModel;

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
		static _003CProcessTradingPositionInfo_003Ed__83()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachDetachedModelRequester()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateExtendedRequesterFilter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessTradingQueue_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VolumetricaProtcol.Trading.ServerResponseMsg responseMsg;

		public IterableLoggerGenerator _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		private List<PositionInfoMsg>.Enumerator _003C_003E7__wrap3;

		private List<OrderInfoMsg>.Enumerator _003C_003E7__wrap4;

		private List<BracketInfoMsg>.Enumerator _003C_003E7__wrap5;

		private static object SimulateCustomFilterWriter;

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
		static _003CProcessTradingQueue_003Ed__78()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JoinSelector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateOperationalAggregatorFactory()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProcessTradingSymbolPnls_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<AccountSymbolsPnlResponse> pnlMsgs;

		public IterableLoggerGenerator _003C_003E4__this;

		private List<AccountSymbolsPnlResponse>.Enumerator _003C_003E7__wrap1;

		private AccountSymbolsPnlResponse _003CcurrPLMsg_003E5__3;

		private int _003CindContr_003E5__4;

		private TaskAwaiter<string> _003C_003Eu__1;

		private static object GenerateFlexibleFactoryUser;

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
		static _003CProcessTradingSymbolPnls_003Ed__80()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FlushAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachIntegratedLoggerTester()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestAccountListAndSnapshot_003Ed__73 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		private VolumetricaProtcol.Trading.ServerResponseMsg _003CsnapshotResp_003E5__2;

		private TaskAwaiter<VolumetricaProtcol.Trading.ServerResponseMsg> _003C_003Eu__1;

		private List<PositionInfoMsg>.Enumerator _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__2;

		private List<OrderInfoMsg>.Enumerator _003C_003E7__wrap3;

		private List<BracketInfoMsg>.Enumerator _003C_003E7__wrap4;

		private static object GenerateStaticTesterNode;

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
		static _003CRequestAccountListAndSnapshot_003Ed__73()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateCustomizableNodeAuditor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAutomatedAuditorAuthenticator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestDailyPLForSymbolsAsync_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public List<ReceiverValue.AdvancedConverterWriter> FeedSymbols;

		private EncryptorVerifierQueue _003CclientReq_003E5__2;

		private long[] _003CcontIDToSub_003E5__3;

		private int _003CindArr_003E5__4;

		private List<ReceiverValue.AdvancedConverterWriter>.Enumerator _003C_003E7__wrap4;

		private TaskAwaiter<long> _003C_003Eu__1;

		private TaskAwaiter<VolumetricaProtcol.Trading.ServerResponseMsg> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		internal static object BuildList;

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
		static _003CRequestDailyPLForSymbolsAsync_003Ed__76()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PresentLocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachConnectedAnnotationSummarizer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestToBridge_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public string IPEndLocal;

		private ConnectionStatusEnum _003CbridgeConnected_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<VolumetricaProtcol.Bridge.ServerResponseMsg> _003C_003Eu__2;

		internal static object SimulateExpandableSummarizerDictionary;

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
		static _003CRequestToBridge_003Ed__44()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAutomatableDictionaryEngine()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateCombinedEngineStack()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSearchSymbols_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ReceiverValue.FlexibleRegDecider>> _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public string filter;

		public string[] exchanges;

		public int limit;

		public int offest;

		private TaskAwaiter<VolumetricaProtcol.Info.ServerResponseMsg> _003C_003Eu__1;

		internal static object AttachGroupedStackCalc;

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
		static _003CSearchSymbols_003Ed__57()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ScanParameter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ExecuteProxy()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendOrdersListMsg_003Ed__75 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public object newTradingMsg;

		internal static object ControlSet;

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
		static _003CSendOrdersListMsg_003Ed__75()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateInterruptibleModuleDecorator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RunModule()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSubscribeSymbolsAsync_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReceiverValue.AdvancedConverterWriter[] Symbols;

		public IterableLoggerGenerator _003C_003E4__this;

		public bool p_needFullDepth;

		private HiddenDriverRequester _003CsubList_003E5__2;

		private ReceiverValue.AdvancedConverterWriter[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ReceiverValue.AdvancedConverterWriter _003CcurrSymb_003E5__5;

		private TaskAwaiter<long> _003C_003Eu__1;

		private TaskAwaiter<EditableWrapperReg> _003C_003Eu__2;

		private static object AttachHiddenValidatorReg;

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
		static _003CSubscribeSymbolsAsync_003Ed__59()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachModularRegFormatter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RestartReg()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTriggerConnectionLost_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IterableLoggerGenerator _003C_003E4__this;

		public string reason;

		private TaskAwaiter _003C_003Eu__1;

		private static object DirectFormatter;

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
		static _003CTriggerConnectionLost_003Ed__48()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CloseGateway()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateScheduledPolicySorter()
		{
			return null;
		}
	}

	public bool _IsEfficientTransformerGenerator;

	private ManualResetEvent _ArgumentDicGenerator;

	private bool _IsLiteralMapGenerator;

	private InternalResolverRequester _DicAuditorGenerator;

	private InternalResolverRequester m_LocalObserverGenerator;

	private InternalResolverRequester m_TransformableTesterGenerator;

	private InternalResolverRequester passiveClientGenerator;

	private Dictionary<long, FilteredVerifierDecider> bufferSpecMap;

	private SemaphoreSlim _InterruptibleFieldGenerator;

	private Lock _GeneratorAuditorConverter;

	private Dictionary<string, Task<VolumetricaProtcol.Info.ServerResponseMsg>> _GeneratorConverterPredictorDic;

	private Dictionary<string, long> _StrategyModelMap;

	private Dictionary<long, string> _FlexibleEditorGeneratorDic;

	private Dictionary<long, string> _CollectionDefinitionDic;

	private Dictionary<long, string> sortedAnalyzerMap;

	private Dictionary<string, long> operationalSetGeneratorMap;

	private Dictionary<long, string> _OrderedEngineGeneratorMap;

	private Dictionary<long, string> logicalEncryptorGeneratorMap;

	private Dictionary<long, string> _IntegratedCheckerGeneratorMap;

	private Lock generatorPredictorConnection;

	private int connectionMonitorGeneratorVol;

	private bool isBasicProjectGenerator;

	private List<DeciderEvaluatorExplorer> m_GeneratorMonitorBuilders;

	private int builderFinderGeneratorSize;

	private int m_GeneratorFinderRunnerLevel;

	private int m_CustomExtractorGeneratorIdx;

	private int generatorRunnerCalcTotal;

	private string m_AutomatedEventGeneratorStr;

	private TransformerViewerKind? generatorCalcOrder;

	private bool _IsAttachedSelector;

	private ActionBlock<VolumetricaProtcol.Trading.ServerResponseMsg> _ChooserLocator;

	private ConcurrentDictionary<long, EncryptorNotifierParser> adjustableValueGeneratorMap;

	private StreamWriter m_ScopeConverter;

	internal static IterableLoggerGenerator SimulateEfficientPredictorTransformer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IterableLoggerGenerator(ReceiverValue.LiteralSharerLocator task, TransformerViewerKind? selection, ConcreteAggregatorDecider tag, RegServerComparator token2, ConfigurationAuditor res3, ViewerPoolSelector visitor4, WrapperValidatorHandler param5, CancellationToken reference6)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreAdaptableDriver(ReceiverValue.LiteralSharerLocator key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateMixedProfiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GenerateScheduledComparator<T>(ArraySegment<byte> v)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCloseVolBridge_003Ed__43))]
	public static Task HandleDic()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestToBridge_003Ed__44))]
	private Task CreateExternalRecord(string var1, CancellationToken connection)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExecuteHttpBridgeRequest_003Ed__45))]
	private static Task<VolumetricaProtcol.Bridge.ServerResponseMsg> StoreMap(string def, int? ord, ClientRequestMsg util)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RateTask(CancellationToken key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnect_003Ed__47))]
	public override Task<bool> Connect(string config = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTriggerConnectionLost_003Ed__48))]
	public override Task ViewQueue(string instance)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectionClosed_003Ed__49))]
	private Task CreateAdaptableBuffer(HiddenLocatorLocator def, bool loadcol, string helper, WebSocketCloseStatus? task2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectionError_003Ed__50))]
	private Task CloseRandomMonitor(HiddenLocatorLocator value, Exception ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCloseAllConnectionAsync_003Ed__51))]
	private Task CloseDynamicState(bool acceptlast, bool overridetoken = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisconnect_003Ed__52))]
	public override Task StoreDynamicDecider(bool isparam)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExecuteWssRequest_003Ed__53<>))]
	public Task<T> GenerateReadableArgument<T>(InternalResolverRequester setup, ITransformableExtractorLocator caller, long temp = 60000L, object col2 = null) where T : class
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override long StoreAccessibleStruct(string setup, bool iscol)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetContractID_003Ed__55))]
	public override Task<long> OpenExternalRecommender(string task, bool isord)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetContractNameFromContractId_003Ed__56))]
	private Task<string> InsertEvent(long res_counter, bool stripvis)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSearchSymbols_003Ed__57))]
	public override Task<List<ReceiverValue.FlexibleRegDecider>> SaveReadableObject(string instance, string[] visitor, int role, int reference2Low, CancellationToken counter3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateIsolatedTemplate(HiddenLocatorLocator value, ArraySegment<byte> cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSubscribeSymbolsAsync_003Ed__59))]
	public override Task OpenDividedRequest(ReceiverValue.AdvancedConverterWriter[] first, bool iscaller = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetDomSnapshot_003Ed__60))]
	public override Task StoreIsolatedChain(string setup, bool selectionclose)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConvertConnection(HiddenLocatorLocator ident, ArraySegment<byte> connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CElaborateQueue_003Ed__63))]
	private Task GenerateScalableChecker(CancellationToken task)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistDataIntAsync_003Ed__64))]
	private Task<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> CreateVirtualTokenizer(GeneratorConfigurationArgument.ModuleLoggerKind def, string second, DateTime consumer, DateTime? caller2 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistBarIntAsync_003Ed__65))]
	private Task<List<SingletonHandlerConnection.SetControllerRequester>> ResetConfig(GeneratorConfigurationArgument.ModuleLoggerKind def, string pred, ReceiverValue.RandomTreeRegValues temp, int caller2_counter, bool verifyvis3, DateTime reference4, DateTime? res5 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistBarIntAsync2_003Ed__66))]
	private Task<(List<SingletonHandlerConnection.SetControllerRequester>, int?)> GenerateLogicalPool(GeneratorConfigurationArgument.ModuleLoggerKind i, string visitor, ReceiverValue.RandomTreeRegValues consumer, int index_config2, bool issecond3, DateTime connection4, DateTime? token5 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistDataAsync_003Ed__67))]
	public override Task<List<SingletonHandlerConnection.ObjectAuthenticatorLocator>> SaveSeparatedOrder(GeneratorConfigurationArgument.ModuleLoggerKind i, string cfg, DateTime filter, DateTime? cfg2 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistBarsAsync_003Ed__68))]
	public override Task<(List<SingletonHandlerConnection.SetControllerRequester>, int?)> CountCache(GeneratorConfigurationArgument.ModuleLoggerKind info, string cont, ReceiverValue.RandomTreeRegValues serv, int vis2, bool isattr3, DateTime connection4, DateTime? res5 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableRecommender(HiddenLocatorLocator reference, ArraySegment<byte> pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteStruct(MixedChainSingleton res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSetTransformer(InternalTokenGenerator res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool LoadSubscriber(out int task, out int token)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestAccountListAndSnapshot_003Ed__73))]
	private Task GenerateSortedAllocator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ResetClient()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendOrdersListMsg_003Ed__75))]
	public override Task SerializeExecutor(object def)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRequestDailyPLForSymbolsAsync_003Ed__76))]
	public override Task DisableViewer(List<ReceiverValue.AdvancedConverterWriter> first)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSharer(HiddenLocatorLocator item, ArraySegment<byte> col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessTradingQueue_003Ed__78))]
	private Task CloseSequentialGenerator(VolumetricaProtcol.Trading.ServerResponseMsg var1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssembleObject(BalanceMsg reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessTradingSymbolPnls_003Ed__80))]
	private Task GenerateGenericProject(List<AccountSymbolsPnlResponse> ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessTradingOrderInfo_003Ed__81))]
	private Task StopChain(OrderInfoMsg last)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessTradingBracketInfo_003Ed__82))]
	private Task GenerateDetailedRole(BracketInfoMsg setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CProcessTradingPositionInfo_003Ed__83))]
	private Task SortListener(PositionInfoMsg info, bool readattr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveCommonEditor(object config, ScopeHandlerDecider.ViewerFinalizerIterator.ConfigurableResponderDecider second, double control, double last2 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StorePassiveCompressor(object res, ScopeHandlerDecider.ViewerFinalizerIterator.ConfigurableResponderDecider cfg, long insert_FIELDAt, double counter2, double ident3 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreEfficientClient(object ident, string cust, long serv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayResolver(object first, ScopeHandlerDecider.EmitterBufferLocator.LocatorContextInterpreter cfg, long temp, double task2 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenLiteralViewer(object ident, ScopeHandlerDecider.EmitterBufferLocator.LocatorContextInterpreter b, long helper_offset, double counter2 = 0.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenResponsiveEmitter(object asset, string b, long indexOf_serv, long res2_amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFlatPosition_003Ed__90))]
	public override Task SaveGlobalAdapter(string item, string cont, long temp_min)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCancellAllOrders_003Ed__91))]
	public override Task StoreSetEncryptor(string spec, string[] visitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCancellAllAndFlat_003Ed__92))]
	public override Task VisitBuilder(string task, string[] map)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFlatAllPositions_003Ed__93))]
	public override Task EnableConnection(string setup, string[] visitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateOcoGroupForOrders_003Ed__94))]
	public override Task CheckCollector(string init, ScopeHandlerDecider.RegFieldFinderEnum cust, List<long> filter)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GenerateStatelessModel(object var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void CloseActiveRequester(object init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IterableLoggerGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachTransferableTransformerAllocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IterableLoggerGenerator NewBuilder()
	{
		return null;
	}
}
