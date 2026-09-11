using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.Management;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class ScalableRequester : Window, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartTimer_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ScalableRequester _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object AdaptDecorator;

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
		static _003CStartTimer_003Ed__16()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateVisualTrackerList()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachStatelessListLocator()
		{
			return null;
		}
	}

	private int commonExplorerRate;

	private CancellationTokenSource m_ReadableRequester;

	private string m_DetailedQueueTag;

	private string orderedRequesterContent;

	private bool isRequesterInspector;

	private TaskCompletionSource<bool> _RequesterProcessor;

	internal Border brdIcon;

	internal TextBlock lblTitle;

	internal TextBlock lblMsg;

	internal Button btnNo;

	internal Button btnYes;

	private bool isSequentialRequester;

	internal static ScalableRequester AttachConfigurableCompressor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenExecutor(object task, string ord, string dic = "", DriverAlignment vis2 = DriverAlignment.None, TestManagementServiceVersion pred3 = TestManagementServiceVersion.Info, int? def4 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CombineViewer(object param, string connection, string template = "", DriverAlignment value2 = DriverAlignment.None, TestManagementServiceVersion visitor3 = TestManagementServiceVersion.Info, int? map4 = null, string selection5 = null, string connection6 = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TestAdapter(string reference, string pred = "", DriverAlignment serv = DriverAlignment.None, Window counter2 = null, TestManagementServiceVersion config3 = TestManagementServiceVersion.Info, int? x4 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ScalableRequester CallAttribute(Window asset, string selection, string c = "", DriverAlignment result2 = DriverAlignment.None, TestManagementServiceVersion setup3 = TestManagementServiceVersion.Info, int? reference4 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RequestLogicalVisitor(string config, string pol = "", DriverAlignment field = DriverAlignment.None, Window x2 = null, TestManagementServiceVersion task3 = TestManagementServiceVersion.Info, int? task4 = null, string cfg5 = null, string ord6 = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScalableRequester(string setup, string counter, DriverAlignment role, TestManagementServiceVersion first2, int? var13 = null, TaskCompletionSource<bool> cust4 = null, int? col5 = null, string value6 = null, string second7 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestGeneralDecryptor(string setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssetStream(object param, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchSetSelector(object var1, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestSortedInitializer(object param, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartTimer_003Ed__16))]
	private void FindProcessor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchSequentialAuthorizer(object ident, CancelEventArgs col)
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
	void IComponentConnector.Connect(int remove_VAt, object cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScalableRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateMixedDriver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScalableRequester CollectNotifier()
	{
		return null;
	}
}
