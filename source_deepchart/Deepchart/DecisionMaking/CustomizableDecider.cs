using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.Registry;
using VolAnalysis;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.DecisionMaking;

internal class CustomizableDecider : Window, IComponentConnector
{
	private RegInitializer modelDecider;

	private Action<RegInitializer, ToolConfiguration> deciderFinalizer;

	private PropertyView _CommonDecider;

	private ToolConfiguration m_PredicateSpec;

	private ToolConfiguration _PortableThread;

	internal ContentControl cnt;

	internal Button btnDiscard;

	internal Button btnSave;

	private bool m_IsStubThread;

	internal static CustomizableDecider AttachInterruptibleConnection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomizableDecider(RegInitializer ident, Action<RegInitializer, ToolConfiguration> col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideConfigurableEncryptor(object instance, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseProc(object asset, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineScheduledFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureMonoReceiver(ToolConfiguration var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineExternalField(object info, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideAccessibleEnumerator(object def, RoutedEventArgs counter)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int referencePosition, object pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomizableDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachIterableCommand()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CustomizableDecider ReflectDic()
	{
		return null;
	}
}
