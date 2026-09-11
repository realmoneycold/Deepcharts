using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Volumetrica.Diagnostic;

internal static class Static
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInfoUpdateTask_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken token;

		private TaskAwaiter _003C_003Eu__1;

		internal static object CancelCollector;

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
		static _003CInfoUpdateTask_003Ed__7()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAdaptableInspectorTransaction()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NewManager()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadExtraInfo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken userToken;

		private HttpClient _003ChttpClient_003E5__2;

		private TaskAwaiter<GeneralInitializerAllocator?> _003C_003Eu__1;

		private LocatorDefinitionStream _003C_003E7__wrap2;

		private TaskAwaiter<double?> _003C_003Eu__2;

		private double _003C_003E7__wrap3;

		internal static object InterruptMember;

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
		static _003CLoadExtraInfo_003Ed__12()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateReadableMapperMatcher()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachDividedMatcherReporter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMeasureDownloadAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double?> _003C_003Et__builder;

		public string url;

		public long maxBytes;

		public TimeSpan maxBudget;

		public CancellationToken userToken;

		public HttpClient http;

		private HttpRequestMessage _003Creq_003E5__2;

		private CancellationTokenSource _003CtimeoutCts_003E5__3;

		private CancellationTokenSource _003Clinked_003E5__4;

		private long _003Cbytes_003E5__5;

		private bool _003CtimedOut_003E5__6;

		private Stopwatch _003Csw_003E5__7;

		private Queue<(double t, long b)> _003Cwindow_003E5__8;

		private double _003CstableRate_003E5__9;

		private int _003CstableHits_003E5__10;

		private HttpResponseMessage _003Cresp_003E5__11;

		private Stream _003Cstream_003E5__12;

		private byte[] _003Cbuffer_003E5__13;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private object _003C_003E7__wrap13;

		private int _003C_003E7__wrap14;

		private ValueTaskAwaiter<int> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		private static object SimulateIsolatedReporterTransmitter;

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
		static _003CMeasureDownloadAsync_003Ed__13()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSeparatedTransmitterProc()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateScalableProcIterator()
		{
			return null;
		}
	}

	private static LocatorDefinitionStream m_AllocatorPolicyResponder;

	private static PerformanceCounter m_TrackerTokenizerAllocator;

	private static PerformanceCounter allocatorResponderDecider;

	private static Process localListAllocator;

	private static TimeSpan allocatorTokenizerAnnotation;

	private static DateTime m_BasicProviderAllocator;

	internal static Static SimulateConcreteArgumentConsumer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LocatorDefinitionStream FilterTree(CancellationToken instance)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInfoUpdateTask_003Ed__7))]
	private static Task JoinGenerator(CancellationToken key)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AllocateOperationalMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AssignFlexibleTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool AssignEditableBridge()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string AssignIntegratedDispatcher(string def, string second)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadExtraInfo_003Ed__12))]
	public static Task AssignStaticFinalizer(CancellationToken res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMeasureDownloadAsync_003Ed__13))]
	public static Task<double?> ReleaseCustomizableResolver(HttpClient task, string caller, TimeSpan template, long asset2counter, CancellationToken info3 = default(CancellationToken))
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Static()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						goto end_IL_0012;
					}
					goto case 0;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					m_AllocatorPolicyResponder = new LocatorDefinitionStream();
					return;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PostWatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Static SimulateAdvancedTemplateTag()
	{
		return null;
	}
}
