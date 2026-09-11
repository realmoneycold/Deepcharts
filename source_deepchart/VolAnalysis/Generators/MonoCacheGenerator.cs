using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Generators;

internal static class MonoCacheGenerator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAwaitWithTimeout_003Ed__3<TResult> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public Task<TResult> task;

		public long timeoutMs;

		private CancellationTokenSource _003CtimeoutCancellationTokenSource_003E5__2;

		private TaskAwaiter<Task> _003C_003Eu__1;

		private TaskAwaiter<TResult> _003C_003Eu__2;

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
		static _003CAwaitWithTimeout_003Ed__3()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateResponsiveHandlerContext()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PlanRecord()
		{
			return null;
		}
	}

	internal static MonoCacheGenerator ProcessContainer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<bool> CloseRemoteSummarizer(this WaitHandle setup, int col_counter = -1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<bool> CreateEfficientDictionary(this WaitHandle reference, CancellationToken cont, int positioncomp = -1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<bool> CloseTransferableEngine(this WaitHandle value, CancellationToken pol, TimeSpan c)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAwaitWithTimeout_003Ed__3<>))]
	public static Task<T> GenerateLiteralStack<T>(this Task<T> instance, long result_Y)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MonoCacheGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachReadableContainerInspector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MonoCacheGenerator SimulateDividedInspectorTransaction()
	{
		return null;
	}
}
