using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal static class AutomatableAllocator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<(FrameworkElement element, string message, PlacementMode? placement, bool outerMargin, FrameworkElement parent)> steps;

		public CancellationToken token;

		private List<(FrameworkElement element, string message, PlacementMode? placement, bool outerMargin, FrameworkElement parent)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object GenerateLiteralProgramPublisher;

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
		static _003CStart_003Ed__6()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ProcessProcessor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateDetachedParameterProxy()
		{
			return null;
		}
	}

	public static bool m_IsScheduledAllocator;

	public static bool _IsAllocatorService;

	public static bool isExtendedSharer;

	public static bool isInterpreterAllocator;

	public static bool _IsTagSingleton;

	public static bool _IsAllocatorResolver;

	private static AutomatableAllocator SimulateLogicalChooser;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStart_003Ed__6))]
	internal static Task Start(List<(FrameworkElement element, string message, PlacementMode? placement, bool outerMargin, FrameworkElement parent)> steps, CancellationToken token)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AutomatableAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MatchObject()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AutomatableAllocator GenerateResponsiveReceiver()
	{
		return null;
	}
}
