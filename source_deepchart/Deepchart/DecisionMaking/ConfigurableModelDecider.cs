using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal static class ConfigurableModelDecider
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTutorialHighlightElementAndShowMessage_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public FrameworkElement element;

		public CancellationToken token;

		public bool outerMargin;

		public bool pulse;

		public PlacementMode? placement;

		public string title;

		public string message;

		public int durationSecs;

		private AdornerLayer _003Clayer_003E5__2;

		private SummarizerFormatter _003Cadorner_003E5__3;

		private Storyboard _003Csb_003E5__4;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private static object SimulateScheduledServiceSchema;

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
		static _003CTutorialHighlightElementAndShowMessage_003Ed__0()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateMonoSchemaValue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReplaceResolver()
		{
			return null;
		}
	}

	internal static ConfigurableModelDecider GenerateFlexibleProxySet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTutorialHighlightElementAndShowMessage_003Ed__0))]
	public static Task<bool> DecideSegmentedHandler(FrameworkElement config, string ivk, string consumer, CancellationToken cust2, bool setselection3 = true, int column_task4 = 5, bool explicitreg5 = true, PlacementMode? var16 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurableModelDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FlushEncryptor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConfigurableModelDecider SimulateIntegratedServerModule()
	{
		return null;
	}
}
