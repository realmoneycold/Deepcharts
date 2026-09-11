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

namespace VolAnalysis.Generators;

internal class ControllableProviderGenerator : UserControl, IComponentConnector
{
	private object m_GeneratorEventValueObj;

	private Action<object> _FinalizerDispatcher;

	private Action m_ObjectChooser;

	private PropertyView _EditableProfiler;

	private Type _ValueChooserGenerator;

	private Func<string, bool> externalCollectorGenerator;

	internal Grid grdMain;

	internal Button btnCancel;

	internal Button btnApply;

	internal Button btnSave;

	private bool _IsConfigurableCollectionGenerator;

	internal static ControllableProviderGenerator SerializeMonitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public object CloseDetailedDriver()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void CreateVisualSharer(object info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ControllableProviderGenerator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ControllableProviderGenerator(Action<object> task, Action ord = null, Type field = null, Func<string, bool> caller2 = null, bool checkresult3 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool CloseSequentialConfiguration(Window i)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateTransformableRecommender(object config, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveWrapper(object value, RoutedEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeConfig(object first, RoutedEventArgs caller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int row_res, object map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ControllableProviderGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachIntegratedMapTask()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ControllableProviderGenerator GenerateStaticTaskBridge()
	{
		return null;
	}
}
