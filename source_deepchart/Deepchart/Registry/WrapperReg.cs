using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class WrapperReg : Window, IComponentConnector
{
	[CompilerGenerated]
	private object _RegIteratorObj;

	internal TextBlock lblTitle;

	internal ComboBox cmbEnum;

	internal Button btnCancel;

	internal Button btnSet;

	private bool isSymbolicReg;

	internal static WrapperReg GenerateSequentialCalculator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public object CalcField()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AddEnumerator(object param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WrapperReg(string reference, Type cfg, object comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ValidateChooser(object i, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PushFunction(object info, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveSymbolicList(object reference, RoutedEventArgs caller)
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
	void IComponentConnector.Connect(int item_offset, object vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateTransformableAnalyzer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WrapperReg AttachGenericWorker()
	{
		return null;
	}
}
