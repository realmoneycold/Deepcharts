using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class DriverAggregator : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectedPageChanged_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DriverAggregator _003C_003E4__this;

		public int newPage;

		public bool isBack;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateSeparatedAttributeBuilder;

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
		static _003CSelectedPageChanged_003Ed__17()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CountSchema()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachVirtualCollectorStream()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CbtnNext_Click_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DriverAggregator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object SimulateScopeStreamManager;

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
		static _003CbtnNext_Click_003Ed__19()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateLogicalManagerMember()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateGeneralMemberProcessor()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CbtnPrevious_Click_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DriverAggregator _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object WriteVerifier;

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
		static _003CbtnPrevious_Click_003Ed__18()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateSetSenderVisitor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachSortedVisitorDecryptor()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private Func<bool?, Task> m_DriverSingleton;

	[CompilerGenerated]
	private Action<WrapperTextBoxMode, DeciderChainPolicyType> m_ReceiverProxy;

	[CompilerGenerated]
	private Func<List<ReceiverValue.LiteralSharerLocator>, Task> _DriverAuthorizers;

	[CompilerGenerated]
	private Action _JoinedDriver;

	private int m_DriverInitializerVal;

	private ServerDecider _AutomatedViewer;

	private UIElement _DriverChain;

	internal Image imgVolLogo;

	internal TextBlock txtTitle;

	internal TextBlock txtSubTitle;

	internal Border brdContainer;

	internal Button btnPrevious;

	internal Button btnNext;

	internal Button btnEnd;

	private bool isDriverExecutor;

	internal static DriverAggregator SimulateCentralCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ControlRandomSubscriber(Func<bool?, Task> init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ControlDynamicClient(Func<bool?, Task> key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ForceDividedViewer(Action<WrapperTextBoxMode, DeciderChainPolicyType> i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void RunIsolatedAdapter(Action<WrapperTextBoxMode, DeciderChainPolicyType> info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void JoinValidator(Func<List<ReceiverValue.LiteralSharerLocator>, Task> task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void RunVirtualCollector(Func<List<ReceiverValue.LiteralSharerLocator>, Task> init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ControlLogicalManager(Action v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ForceGeneralMember(Action init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverAggregator(ServerDecider value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectedPageChanged_003Ed__17))]
	private Task ForceMonoFinder(int indexOfparam, bool iscont)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnPrevious_Click_003Ed__18))]
	private void ForceExternalWatcher(object key, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CbtnNext_Click_003Ed__19))]
	private void ForceAccessibleProfile(object ident, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CancelProgram(object info, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int config_counter, object connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void RunAdaptableCache(TransformableConfigWrapper item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverAggregator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateAdvancedSubscriber()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DriverAggregator GenerateOrderedClient()
	{
		return null;
	}
}
