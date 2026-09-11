using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class AllocatorAdapter : Window, IComponentConnector
{
	[CompilerGenerated]
	private ViewerInitializerKind deciderPolicy;

	[CompilerGenerated]
	private nint[] _IntegratedAggregatorArray;

	[CompilerGenerated]
	private bool isTransferableState;

	private List<CheckBox> m_MonoAllocators;

	private List<CheckBox> _LogicalAllocatorList;

	private Action<AllocatorAdapter> systemConsumer;

	internal StackPanel stkWindow;

	internal StackPanel stkMonitor;

	internal CheckBox ckbAllWindow;

	internal Button btnCancel;

	internal Button btnPosition;

	private bool m_IsThreadAdapter;

	private static AllocatorAdapter GenerateExtendedVisitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ViewerInitializerKind ReleaseAdjustableInterpreter()
	{
		return (ViewerInitializerKind)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void AssignInterruptibleQueue(ViewerInitializerKind spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public nint[] ReleaseHiddenFinder()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void AllocateModularWatcher(nint[] last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool RunConfigurableEditor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void SearchParser(bool writekey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorAdapter(Action<AllocatorAdapter> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MonitorAuthorizer(object var1, RoutedEventArgs pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateInternalNotifier(object reference, RoutedEventArgs pol)
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
	void IComponentConnector.Connect(int def_High, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorAdapter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DeleteModel()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorAdapter GenerateAttachedDefinition()
	{
		return null;
	}
}
