using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class RequesterAnalyzer : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private ObservableCollection<ScheduledDriver> _AdaptableRequester;

	private ICollectionView _AutomatableRequester;

	private string _PassiveRequesterName;

	internal TabControl tbcGroups;

	internal Button btnAddGroup;

	private bool _IsConfigurableRequester;

	internal static RequesterAnalyzer SendConsumer;

	private ObservableCollection<ScheduledDriver> Groups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterAnalyzer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestGeneralSchema(object key, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestResponsiveValue(object init, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestSetTracker(object item, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QuerySortedList(object spec, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchVisibleLocator(object init, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InstantiateConverter(object first, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestTransformableProvider(object value, CancelEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int key_count, object cust)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int res, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequesterAnalyzer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ValidateTemplate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RequesterAnalyzer GenerateInterruptibleConfiguration()
	{
		return null;
	}
}
