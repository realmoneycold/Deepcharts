using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Creations;

internal class DetailedSingleton : Window, IComponentConnector
{
	private List<RemoteViewer> _SingletonInterpreterList;

	private WriterServerRecommender singletonDispatcher;

	private string _SingletonWrapperTxt;

	internal RowDefinition rowDefBuyStops;

	internal RowDefinition rowDefBuyLimits;

	internal RowDefinition rowDefSellStops;

	internal RowDefinition rowDefSellLimits;

	internal ComboBoxWithHeader cmbMode;

	internal Grid grdBuyStops;

	internal ListView lswBuyStops;

	internal Grid grdBuyLimits;

	internal ListView lswBuyLimits;

	internal Grid grdSellStops;

	internal ListView lswSellStops;

	internal Grid grdSellLimits;

	internal ListView lswSellLimits;

	internal Button btnCancel;

	internal Button btnCreate;

	private bool isOperationalSingleton;

	internal static DetailedSingleton SimulateDetailedInterpreter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DetailedSingleton(WriterServerRecommender i, string cust, bool getres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureConvertibleSpec(object ident, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyConnectedSystem(object value, RoutedEventArgs token)
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
	void IComponentConnector.Connect(int var1X, object pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DetailedSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachVisualQueue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DetailedSingleton SimulateStatelessExtractor()
	{
		return null;
	}
}
