using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.IO;

internal class GenericWriter : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private GeneratorProxy m_TransformableProfiler;

	private ObservableCollection<SortedTracerLocator> _ProcessorWriter;

	private PropertyView locatorWriter;

	internal ContentControl cntParam;

	internal Button btnAddSymb;

	internal ListView lswSymbols;

	internal PropertyView ppg_param;

	internal Button btnCancel;

	internal Button btnOk;

	private bool m_IsPortableWriter;

	private static GenericWriter ReplaceTransformer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public GeneratorProxy CloseStrategy()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void RecordScheduledQueue(GeneratorProxy info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenericWriter(GeneratorProxy value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogInterruptibleSingleton(object var1, SelectionChangedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordIterableCalculator(object ident, MouseButtonEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EvaluateSpec(object item, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordModularWorker(object spec, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteLocalSolver(object task, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DirectComparator(object var1, RoutedEventArgs token)
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
	void IComponentConnector.Connect(int task_count, object caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int first, object cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GenericWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExcludeTree()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GenericWriter CreateGenerator()
	{
		return null;
	}
}
