using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.API.Requester;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Drivers;

internal class DriverWrapper : Window, IComponentConnector
{
	[CompilerGenerated]
	private List<VirtualRequester> visualEvaluatorList;

	private string _AutomatedRecordCategory;

	private string externalDriverContent;

	private string driverObjectContent;

	private bool isExplorerTracer;

	private List<string> _DictionaryServerList;

	internal ComboBoxWithHeader cmbBroker;

	internal DataGrid dgwAccounts;

	internal Button btnCancel;

	internal Button btnSelect;

	private bool _IsDetachedDriver;

	private static DriverWrapper AttachReadableToken;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal List<VirtualRequester> VerifyStrategy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void RunIterableWatcher(List<VirtualRequester> item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverWrapper(bool calcvalue, string pol = null, string serv = null, List<string> last2 = null, bool rejectcust3 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetachExplorer(object value, SelectionChangedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceGroupedBuffer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanSystem(object param, RoutedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteProfiler(object i, RoutedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlComparator(object asset, RoutedEventArgs cont)
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
	void IComponentConnector.Connect(int start_def, object selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncryptStruct()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DriverWrapper SimulateIsolatedEmitter()
	{
		return null;
	}
}
