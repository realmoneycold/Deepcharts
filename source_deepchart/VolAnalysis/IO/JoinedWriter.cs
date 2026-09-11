using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.IO;

internal class JoinedWriter : Window, IComponentConnector, IStyleConnector
{
	internal IterableLocator m_RunnerWriter;

	internal SeparatedLocator m_CustomWriter;

	internal RequesterDistributor _AllocatorWriter;

	internal RequesterUser publisherWriter;

	[CompilerGenerated]
	private IList _RecordWriterList;

	[CompilerGenerated]
	private bool isMixedWriter;

	[CompilerGenerated]
	private bool m_IsWriterState;

	private object _BufferStreamObj;

	private int _StatelessWriterPerc;

	private bool _IsIdentifiableWriter;

	internal ListView lswConfigs;

	internal IconButton btnCancel;

	internal TextBoxWatermark txtSaveAs;

	internal StackPanel stkAdd;

	internal IconButton btnSaveAs;

	internal StackPanel stkDlg;

	internal IconButton btnAddNew;

	private bool _IsWriterTag;

	internal static JoinedWriter PatchVisitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public IList DisconnectLogicalCollector()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ExecuteGeneralStream(IList init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool RecordSetMember()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void WriteSortedProcessor(bool isinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool LogSequentialVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void ReceiveManager(bool doinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoinedWriter(IList i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteScheduledInterpreter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ConcatAnalyzer(string reference, int meansecond)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReplaceWorker(object asset, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogAccessibleFinder(object ident, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExcludeNotifier(object last, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordAdaptableProfile(object def, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogRandomEditor(object def, MouseButtonEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordDynamicCache(object key, MouseButtonEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveFinder(object setup, DragEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteDividedClient(object info, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordIsolatedExecutor(object first, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordSeparatedViewer(object setup, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CombineCache(object var1, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestSubscriber(object item, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CallClient(object value, RoutedEventArgs result)
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
	void IComponentConnector.Connect(int i_high, object second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int parammin, object ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static JoinedWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StopDecryptor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JoinedWriter AdaptDefinition()
	{
		return null;
	}
}
