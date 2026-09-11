using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class ExternalSingleton : Window, IComponentConnector
{
	private DeciderSharer m_ActiveSingleton;

	internal ListView lswTimeframes;

	internal Button btnRemove;

	internal Button btnModify;

	internal Button btnAdd;

	internal Button btnCancel;

	internal Button btnConfirm;

	private bool m_IsPredictorSingleton;

	internal static ExternalSingleton AttachOperationalResponder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExternalSingleton(DeciderSharer key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureGroupedArgument()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyIdentifiableConsumer(object asset, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExecuteStrategy(object v, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ControlRecord(object task, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InstantiateInterruptibleEditor(object key, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunContext(object reference, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyHiddenSubscriber(object init, SelectionChangedEventArgs cust)
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
	void IComponentConnector.Connect(int keyoffset, object map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExternalSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateFlexibleAuthorizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExternalSingleton SimulateEditableService()
	{
		return null;
	}
}
