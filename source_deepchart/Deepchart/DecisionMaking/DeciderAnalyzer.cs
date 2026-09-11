using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderAnalyzer : Window, IComponentConnector
{
	private EditableSingletonWrapper _HiddenDecider;

	internal Border cntMain;

	private bool m_IsDeciderResponder;

	private static DeciderAnalyzer SimulatePortableFinder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal List<ReceiverValue.LiteralSharerLocator> CountState()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderAnalyzer()
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
	void IComponentConnector.Connect(int ident_start, object result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void EnsureAttachedPublisher(object i, bool? reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderAnalyzer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateSymbolicWatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderAnalyzer SimulateConcreteProfile()
	{
		return null;
	}
}
