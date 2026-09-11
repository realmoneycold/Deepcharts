using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class SingletonQueue : Window, IComponentConnector
{
	[CompilerGenerated]
	private string singletonSummarizerLabel;

	internal TextBlock lblTitle;

	internal TextBox txtInput;

	internal Button btnCancel;

	internal Button btnSave;

	private bool _IsRecordProc;

	internal static SingletonQueue AttachIdentifiableParameter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public string InstantiateGlobalContainer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void DestroyDetachedInspector(string ident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonQueue(string config, string map = "", string util = "Save")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormatChecker(object var1, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyLiteralSorter(object v, RoutedEventArgs ivk)
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
	void IComponentConnector.Connect(int idx_var1, object counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonQueue()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachInternalCommand()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingletonQueue CloneCalc()
	{
		return null;
	}
}
