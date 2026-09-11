using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Management;

internal class SetAllocator : Window, IComponentConnector
{
	[CompilerGenerated]
	private GeneratorConfigurationArgument.TransferableValueReg simpleFactory;

	private string[] _ControllerAllocatorArray;

	private PropertyView _AllocatorLogger;

	internal TabControl tbc;

	internal TabItem tbiFirst;

	internal RadioButton rdbAuto;

	internal Grid grdFirst;

	internal TextBoxWatermark txtAutoName;

	internal TextBoxWatermark txtAutoDesc;

	internal ComboBox cmbAutoExchange;

	internal TextBoxWatermark txtIsin;

	internal RadioButton rdbManual;

	internal Button btnCancel;

	internal Button btnNext;

	internal TabItem tbiSecond;

	internal Grid grdSecond;

	internal Border cntSecond;

	internal Button btnPrevious;

	internal Button btnConfirm;

	private bool m_IsProcBuilder;

	internal static SetAllocator AttachFilteredProfile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal GeneratorConfigurationArgument.TransferableValueReg ManageExternalAttribute()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void LeadServer(GeneratorConfigurationArgument.TransferableValueReg v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignHiddenEditor(object instance, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PostProvider(object init, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignLocalSubscriber(object instance, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseConfigurableClient(object def, RoutedEventArgs token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateMixedExecutor(object i, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ManageParameter(object task, RoutedEventArgs cust)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int insert_VAt, object selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool AssignMonoAdapter(GeneratorConfigurationArgument.RegTaskInitializer asset)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePortableEditor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SetAllocator AttachSymbolicCache()
	{
		return null;
	}
}
