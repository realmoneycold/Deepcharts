using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Generators;

internal static class SegmentedModelGenerator
{
	private class LocatorRecordGateway
	{
		private class AdaptableServerWriter
		{
			public TaskCompletionSource functionComparator;

			public object _SegmentedRecommenderWriterObj;

			public Action<byte[]> _TransformableCheckerWriter;

			internal static AdaptableServerWriter AttachEfficientRequesterFilter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AdaptableServerWriter()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AdaptableServerWriter()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool SimulateTransferableFilterWriter()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static AdaptableServerWriter GenerateLiteralWriterConverter()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCheckIfConnectionToCloseTask_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public LocatorRecordGateway _003C_003E4__this;

			public CancellationToken token;

			private TaskAwaiter _003C_003Eu__1;

			internal static object GenerateGlobalConverterAggregator;

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
			static _003CCheckIfConnectionToCloseTask_003Ed__15()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool MergeProc()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object InsertIterator()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CConnectAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public LocatorRecordGateway _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<(bool, string)> _003C_003Eu__2;

			private static object GenerateCustomUserLogger;

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
			static _003CConnectAsync_003Ed__14()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool GenerateAttachedLoggerTester()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object CountSpec()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetHistDepthRawBytes_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public LocatorRecordGateway _003C_003E4__this;

			public int HourToReq;

			public string VolumetricaSymb;

			public Action<byte[]> processCallback;

			public long? iniUnixTimeMs;

			public bool includeMbo;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private AdaptableServerWriter _003CtcsCompInfo_003E5__2;

			private TaskAwaiter _003C_003Eu__2;

			private static object LoadSystem;

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
			static _003CGetHistDepthRawBytes_003Ed__18()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool GenerateFlexibleAuditorAuthenticator()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object GenerateEditableAuthenticatorCollection()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetRawStringStats_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public LocatorRecordGateway _003C_003E4__this;

			private string _003CretString_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private AdaptableServerWriter _003CtcsCompInfo_003E5__3;

			private TaskAwaiter _003C_003Eu__2;

			internal static object SimulateIntegratedCollectionAnnotation;

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
			static _003CGetRawStringStats_003Ed__17()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool WriteRecord()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object PlanHandler()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CWss_Closed_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			internal static object SimulateAutomatedDictionaryEngine;

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
			static _003CWss_Closed_003Ed__13()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool GenerateJoinedEngineStack()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object SimulateConvertibleStackCalc()
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CWss_Error_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			internal static object AssembleState;

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
			static _003CWss_Error_003Ed__12()
			{
				WrapperStreamEditor.AnalyzeRecord();
				WrapperStreamEditor.CoverPortableElement();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool PatchArgument()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object GenerateAutomatableThreadMap()
			{
				return null;
			}
		}

		private InternalResolverRequester _AnnotationHandler;

		private DateTime? m_LocatorEventStruct;

		private SemaphoreSlim _LocatorFormatterElement;

		private string _LocatorGatewayEngineText;

		private long _ConsumerAuthorizerDist;

		private Dictionary<long, AdaptableServerWriter> simpleConfigDic;

		private CancellationToken locatorStructWrapper;

		private DateTime _InternalServiceLocator;

		private static LocatorRecordGateway GenerateDetachedWriterConverter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public bool ReadTransaction()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocatorRecordGateway(string key, int indexOfb)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CWss_Error_003Ed__12))]
		private Task AddDecorator(HiddenLocatorLocator asset, Exception visitor)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CWss_Closed_003Ed__13))]
		private Task ClearAdvancedCalc(HiddenLocatorLocator reference, bool deleteord, string serv, WebSocketCloseStatus? pred2)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__14))]
		public Task<bool> AnalyzeReg()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CCheckIfConnectionToCloseTask_003Ed__15))]
		private Task ClearAlphabeticThread(CancellationToken last)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompressGateway(HiddenLocatorLocator reference, ArraySegment<byte> pol)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CGetRawStringStats_003Ed__17))]
		internal Task<string> FindCommonTask()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CGetHistDepthRawBytes_003Ed__18))]
		internal Task<bool> ReplacePolicy(string key, bool ismap, int helper, long? asset2, Action<byte[]> pol3)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T ExcludeContainer<T>(ArraySegment<byte> setup)
		{
			return (T)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private Task? CreateInspector()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LocatorRecordGateway()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EncryptDefinition()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LocatorRecordGateway SimulateCustomAggregatorFactory()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public SingletonHandlerConnection.ExecutorBridge transformableNotifierLocator;

		public bool isLocatorElementFinalizer;

		public List<SingletonHandlerConnection.BuilderWriterDecider> m_ResponsiveProfileWrapperList;

		public HashSet<ulong> listenerEmitter;

		public List<SingletonHandlerConnection.AlphabeticEventLocator> m_SeparatedBuilders;

		public bool m_IsLocatorEngineContext;

		public DateTime _LocatorWrapperChain;

		public int? locatorFinalizerInspector;

		public List<SingletonHandlerConnection.ExecutorBridge> _VisibleStubList;

		public bool isGlobalLocatorLocator;

		public long _HiddenQueueLocatorPosition;

		public TimeZoneInfo _TreeAttribute;

		internal static _003C_003Ec__DisplayClass13_0 GenerateAttachedFactoryUser;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ClearDetachedConnection(byte[] byteRead)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec__DisplayClass13_0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachBasicUserLogger()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass13_0 ResumeAuthorizer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnectToVolServer_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LocatorRecordGateway> _003C_003Et__builder;

		public string server;

		private LocatorRecordGateway _003CserverMng_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object AttachFlexibleTesterNode;

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
		static _003CConnectToVolServer_003Ed__10()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachEditableNodeAuditor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateIntegratedAuditorAuthenticator()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetHistDepth_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<SingletonHandlerConnection.ExecutorBridge>> _003C_003Et__builder;

		public bool includeMbo;

		public int? msBaseRes;

		public TimeZoneInfo exchTz;

		public string VolSymb;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		public long? iniUnixTimeMs;

		public int? numberOfHours;

		private TaskAwaiter<LocatorRecordGateway> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private static object PrepareTracker;

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
		static _003CGetHistDepth_003Ed__13()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SelectList()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachAutomatedAnnotationSummarizer()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRawStringStats_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		private TaskAwaiter<LocatorRecordGateway> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object BuildVerifier;

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
		static _003CGetRawStringStats_003Ed__12()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachConvertibleDictionaryEngine()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateConnectedEngineStack()
		{
			return null;
		}
	}

	private static Dictionary<string, int> m_GeneratorOrderUserDic;

	private static Dictionary<string, string[]> _ScalableCompressorGeneratorMap;

	private static Dictionary<string, LocatorRecordGateway> m_ScheduledLocatorGeneratorMap;

	internal static SegmentedModelGenerator SimulateHiddenParameterProxy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SegmentedModelGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616 == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 9)
				{
					if (num2 == 989)
					{
						goto IL_0013;
					}
					goto case 0;
				}
				_ScalableCompressorGeneratorMap.Add(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE88DF29 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), new string[1] { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2142E96B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803) });
				num = 4;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 0:
				{
					WriterCommandResolver.ReflectDefinitionSelector();
					m_ScheduledLocatorGeneratorMap = new Dictionary<string, LocatorRecordGateway>();
					m_GeneratorOrderUserDic = new Dictionary<string, int>();
					_ScalableCompressorGeneratorMap = new Dictionary<string, string[]>();
					_ScalableCompressorGeneratorMap.Add("", new string[1] { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE7E676 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938) });
					int num3 = 9;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf == 0)
					{
						num3 = 9;
					}
					num2 = num3;
					goto IL_0013;
				}
				IL_0013:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectToVolServer_003Ed__10))]
	private static Task<LocatorRecordGateway> ClosePortableAggregator(string reference)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ArrangeBuffer(string ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRawStringStats_003Ed__12))]
	public static Task<string> GenerateConcreteUser()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetHistDepth_003Ed__13))]
	public static Task<List<SingletonHandlerConnection.ExecutorBridge>> PostState(string last, TimeZoneInfo second, int? filter, bool wanttask2, int? task3 = null, long? res4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TrackSet()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SegmentedModelGenerator GenerateLocalSetServer()
	{
		return null;
	}
}
