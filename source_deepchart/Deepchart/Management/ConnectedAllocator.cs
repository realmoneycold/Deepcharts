using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis;
using VolAnalysis.Controls;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Management;

internal class ConnectedAllocator : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private PortfolioSettings m_AllocatorGateway;

	private DetachedAllocator _AllocatorSorter;

	internal StackPanel topLeftPnl;

	internal TextBlock tslTitle;

	internal ComboBoxWithHeader cmbAccounts;

	internal MenuItem tsmAlwaysOnTop;

	internal TopRightPnl pnlTopRight;

	internal ScrollViewer scrlOverview;

	internal ContentControl cntOverview;

	internal ScrollViewer scrlAccountDetail;

	internal ContentControl cntAccountDetail;

	internal Grid grdAccountDetail;

	private bool m_IsFlexibleAllocator;

	private static ConnectedAllocator AttachRemoteCollector;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public PortfolioSettings GuideSelector()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void AllocateCombinedRecord(PortfolioSettings reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConnectedAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveClient(PortfolioSettings task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseCustomTransaction(object param, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignAttachedError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Apply(object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseBasicMapper(object param, SelectionChangedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseOperationalMatcher(object asset, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CallBuilder(object param, CancelEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseEditableTransmitter(object asset, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeStream(object config, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssetManager(object key, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateCustomizablePredicate(object info, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateAutomatedExplorer(object config, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindSender(object spec, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignConvertibleSystem(object value, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseConnectedProfiler(object i, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignExpandableComparator(object reference, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int initY, object reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int idx_def, object connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectedAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExcludeGenerator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConnectedAllocator SimulateTransferableManager()
	{
		return null;
	}
}
