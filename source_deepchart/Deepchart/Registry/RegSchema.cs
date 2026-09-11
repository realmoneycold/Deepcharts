using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegSchema : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartTimer_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RegSchema _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachAdvancedProgramPublisher;

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
		static _003CStartTimer_003Ed__12()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateOrderedPublisherParameter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAlphabeticParameterProxy()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private string _ConvertibleUserCategory;

	[CompilerGenerated]
	private string _RegResolverTxt;

	private CancellationTokenSource externalReg;

	private int combinedRegVal;

	private bool m_IsAutomatableReg;

	internal TextBox txtEmail;

	internal TextBox txtLicKey;

	internal Button btnCancel;

	internal Button btnLogIn;

	private bool isRegSynchronizer;

	internal static RegSchema AttachExpandableVerifier;

	internal string Email
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal string DeclineCommonServer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void StoreControllableModule(string task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegSchema(string last, string cont, bool isfilter = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartTimer_003Ed__12))]
	private void OpenConcreteParser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreCentralProgram(object ident, CancelEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveAdvancedPublisher(object param, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreOrderedParameter(object var1, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int paramPosition, object result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegSchema()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAutomatableProvider()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegSchema GenerateCombinedParser()
	{
		return null;
	}
}
