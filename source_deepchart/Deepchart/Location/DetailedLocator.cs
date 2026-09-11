using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Location;

internal class DetailedLocator : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private MoneyManagmentAccountSettings queueTokenizer;

	private ObservableCollection<MoneyManagmentAccountSettings.SymbolSetting> _OperationalLocator;

	private PropertyView m_OrderedLocator;

	internal ContentControl cntProp;

	internal Button btnAddSymbol;

	internal DataGrid dgwSymbols;

	internal Border bdgSchedule;

	internal CheckBox ckbInhibitChanges;

	internal Button btnCancel;

	internal Button btnSet;

	private bool _IsLocatorGateway;

	private static DetailedLocator HandleInterpreter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public MoneyManagmentAccountSettings MonitorResponder()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void PopAuthorizer(MoneyManagmentAccountSettings param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DetailedLocator(string i, string result, MoneyManagmentAccountSettings c, bool extractvis2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReceiveVisitor(object item, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindGenericSchema(object key, RoutedEventArgs cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifySimpleValue(object param, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyDetailedTracker(object reference, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveInitializer(object v, RoutedEventArgs cust)
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
	void IComponentConnector.Connect(int no__setup, object cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IStyleConnector.Connect(int identcounter, object pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DetailedLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachExternalObject()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DetailedLocator GenerateAccessibleRequest()
	{
		return null;
	}
}
