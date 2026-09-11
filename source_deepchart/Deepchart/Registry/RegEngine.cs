using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Registry;

internal class RegEngine : Window, IComponentConnector
{
	internal Image imgToDisplay;

	internal IconButton btnClose;

	private bool isRegMatcher;

	internal static RegEngine AttachTransferableStream;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegEngine(string task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveScheduledWatcher(object task, RoutedEventArgs pred)
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
	void IComponentConnector.Connect(int info_start, object result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void SaveMonoProfile(object? sender, EventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegEngine()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NewWrapper()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegEngine SimulateGlobalMember()
	{
		return null;
	}
}
