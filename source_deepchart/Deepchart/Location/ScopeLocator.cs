using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class ScopeLocator : Window, IComponentConnector
{
	internal DataGrid dgwLogs;

	internal DataGrid dgwConnLogs;

	private bool isSeparatedConfig;

	internal static ScopeLocator SimulateJoinedTracker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScopeLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifySymbolicProvider(object info, CancelEventArgs attr)
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
	void IComponentConnector.Connect(int no__value, object pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScopeLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PresentCreator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScopeLocator GenerateConnectedLocator()
	{
		return null;
	}
}
