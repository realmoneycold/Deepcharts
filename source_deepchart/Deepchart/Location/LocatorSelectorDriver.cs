using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class LocatorSelectorDriver : UserControl, IComponentConnector, IStyleConnector
{
	internal Grid grdContainer;

	internal Button btnSubRemove;

	internal Button btnSubReplace;

	internal Button btnSubAdd;

	internal DataGrid dgwSub;

	private bool m_IsLocatorDriverTransaction;

	internal static LocatorSelectorDriver LeadDecider;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorSelectorDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorSelectorDriver(bool getlast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearRemoteChecker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CancelPredicate(object init, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayExplorer(object item, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NewSpec(object first, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InterruptSystem(object config, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearDetachedPredictor(object v, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyExtendedTransformer(List<GeneratorConfigurationArgument.RegTaskInitializer> def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeStrategy(List<GeneratorConfigurationArgument.RegTaskInitializer> item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int referencestart, object counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int no__info, object ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorSelectorDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CancelObject()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorSelectorDriver GenerateAdaptableAnalyzerWorker()
	{
		return null;
	}
}
