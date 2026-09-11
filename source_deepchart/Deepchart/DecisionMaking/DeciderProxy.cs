using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderProxy : Window, IComponentConnector
{
	[CompilerGenerated]
	private List<UserMonitorInfo> _CombinedDeciders;

	private Dictionary<int, List<RadioButton>> m_ScopeSingletonDic;

	internal TextBlock lblMessage;

	internal Grid grdGroups;

	internal Button btnCancel;

	internal Button btnConfirm;

	private bool isPolicySummarizer;

	private static DeciderProxy AssessPool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal List<UserMonitorInfo> EnsureFilteredModule()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void DeterminePortableDecorator(List<UserMonitorInfo> ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderProxy(int row_instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineStatelessSet(object def, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineActiveServer(object res, RoutedEventArgs cfg)
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
	void IComponentConnector.Connect(int offsetident, object vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderProxy()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AnalyzeTracer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderProxy PausePredictor()
	{
		return null;
	}
}
