using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Models;
using VolumetricaControls;

namespace VolAnalysis.Wrapping;

internal class ValueListener : Window, IComponentConnector, IStyleConnector
{
	private OcoStrategyParam dynamicWrapper;

	private int emitterWrapperVol;

	private bool m_IsThreadAllocator;

	private OcoStrategyParam wrapperProxy;

	private ObservableCollection<OcoBracketStrategyParam> _CollectorWrapper;

	private ObservableCollection<OcoBracketStrategyParam> _WrapperConfig;

	internal ListView lswOcoList;

	internal Grid grdProp;

	internal TextBoxWatermark txtName;

	internal ComboBox cmbSizeMode;

	internal RadioButton rdbOcoStop;

	internal RadioButton rdbOcoTarget;

	internal NumUpDown nudOcoQty;

	internal NumUpDown nudBE;

	internal RadioButton tdbOcoTicks;

	internal RadioButton rdbOcoMoney;

	internal NumUpDown nudValue;

	internal NumUpDown nudTrailing;

	internal Button btnAddBracket;

	internal BadgeHeaderCounter bdgStop;

	internal ListView lswStopBrackets;

	internal BadgeHeaderCounter bdgTarget;

	internal ListView lswTargetBrackets;

	internal Button btnAddStrategy;

	internal Button btnRemoveOco;

	internal Button btnSaveOco;

	private bool m_IsSummarizerSharer;

	private static ValueListener GenerateActiveFinder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueListener(string def = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveTransmitter(object first, NotifyCollectionChangedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeProc(object info, NotifyCollectionChangedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CoverCombinedStrategy(object key, SelectionChangedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartPredicate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int WrapIdentifiableHandler(bool instancestop, int offsetselection)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapInternalSolver(object init, RoutedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncapsulateAdjustableNotifier(object res, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VerifyProfiler(object var1, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunComparator(object value, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EvaluateStrategy(object res, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WrapModularFinder(object instance, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncapsulateLocalWatcher(object asset, DependencyPropertyChangedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int max_asset, object second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int idx_ident, object ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool DirectContext(OcoStrategyParam spec)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueListener()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateFilteredWatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ValueListener SimulatePortableProfile()
	{
		return null;
	}
}
