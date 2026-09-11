using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class StatelessBuilderViewer : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private bool? setIterator;

	private bool isViewerTransactionDefinition;

	internal RadioButton ckbDelayedFeed;

	internal RadioButton ckbRealtimeFeed;

	private bool m_IsViewerDefinitionTree;

	internal static StatelessBuilderViewer GenerateLogicalEditorCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal bool? SendAttribute()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void DisplayFilteredRecord(bool? setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatelessBuilderViewer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewVisualProfiler(object setup, RoutedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveStatelessComparator(object value, RoutedEventArgs result)
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
	void IComponentConnector.Connect(int instance, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatelessBuilderViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateGeneralCacheSubscriber()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StatelessBuilderViewer PrepareReceiver()
	{
		return null;
	}
}
