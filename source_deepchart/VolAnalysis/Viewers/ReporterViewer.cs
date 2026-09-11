using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class ReporterViewer : Window, IComponentConnector
{
	private Array _TransformableViewer;

	private Action<object> m_FinderBuffer;

	internal Grid grd;

	internal ListView lbxCol;

	internal Button btnUp;

	internal Button btnDown;

	internal Button btnApply;

	internal Button btnOK;

	private bool _IsFunctionViewer;

	internal static ReporterViewer AttachSetEnumerator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReporterViewer(Array reference, Action<object> ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplaySimpleInitializer(object key, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdaptModel(object task, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveVisualAuthorizer(object config, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewStatelessService(object item, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayActiveSchema(object i, RoutedEventArgs pred)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int assetY, object attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReporterViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateSortedSynchronizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReporterViewer SimulateVisibleSingleton()
	{
		return null;
	}
}
