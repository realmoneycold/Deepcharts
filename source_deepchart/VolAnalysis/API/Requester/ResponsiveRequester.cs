using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.Location;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class ResponsiveRequester : Window, IComponentConnector
{
	internal DataGrid dgw;

	private bool m_IsGeneratorStream;

	internal static ResponsiveRequester SimulateRandomOrder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResponsiveRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestExternalFinder(List<IsolatedWorkerLocator> item, bool mapstop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestAccessibleWatcher(Point ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchPassiveProfile(object param, CancelEventArgs connection)
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
	void IComponentConnector.Connect(int defhigh, object token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResponsiveRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateDynamicListener()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ResponsiveRequester MoveObserver()
	{
		return null;
	}
}
