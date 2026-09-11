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

namespace VolAnalysis;

internal class PropDialog : Window, IComponentConnector
{
	private Action<object> _EncryptorValidator;

	private PropertyView m_ReadableAllocator;

	internal Grid grd;

	internal Border brdContent;

	internal Button btnApply;

	internal Button btnOK;

	private bool isStaticEncryptor;

	private static PropDialog AttachEditableAuthorizer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public object PlayServer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public void NewModule(object last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropDialog(string spec, object ord, Action<object> tag = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeExternalExecutor(object res, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckAccessibleViewer(object v, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CancelSet(object info, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int config, object ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropDialog()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateIntegratedService()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PropDialog SimulateStaticSchema()
	{
		return null;
	}
}
