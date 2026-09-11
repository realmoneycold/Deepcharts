using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Creations;

internal class SingletonMatcher : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CbtnCalculate_Click_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SingletonMatcher _003C_003E4__this;

		private static object DecodeWatcher;

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
		static _003CbtnCalculate_Click_003Ed__4()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DetachProfile()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateGroupedSpecSystem()
		{
			return null;
		}
	}

	private GeneratorConfigurationArgument.TransferableValueReg _ModularFinder;

	private CombinedObjectGenerator iterableContext;

	private PropertyView separatedSingleton;

	internal ContentControl cntProp;

	internal Button btnCalculate;

	private bool isCommandAggregator;

	private static SingletonMatcher CombineRequester;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonMatcher(GeneratorConfigurationArgument.TransferableValueReg key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnCalculate_Click_003Ed__4))]
	private void InstantiateSetProcessor(object param, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int config_high, object second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonMatcher()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachVirtualEncryptor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingletonMatcher SimulateScopeChooser()
	{
		return null;
	}
}
