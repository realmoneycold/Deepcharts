using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.TradeCopier;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Generators;

internal class HiddenGenerator : Window, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private TradeCopierGroupSettings _TransmitterDic;

	private ObservableCollection<string> _OrderProvider;

	private TradeCopierAccountSettings generatorAuthorizer;

	private ObservableCollection<TradeCopierAccountSettings> _GeneratorMember;

	internal TextBox txtInpName;

	internal ComboBox cmbCopyMode;

	internal NumUpDown nudCopyDelayMs;

	internal ComboBox cmbResyncroMode;

	internal ComboBox cmbPendingOrderExpLogic;

	internal NumUpDown nudPendingOrderExpSecs;

	internal NumUpDown nudSyncroTimeoutSecs;

	internal NumUpDown nudSyncroAttemptDelaySecs;

	internal IconButton btnAccountParent;

	internal Button btnAddChildAccount;

	internal ListView lswChildrenAccounts;

	internal Button btnAddSymb;

	internal ListView lswSymbols;

	internal NumUpDown nudBracketChildTickMargin;

	internal NumUpDown nudBracketInsertFallback;

	internal NumUpDown nudOcoCancelFallback;

	internal NumUpDown nudOcoTrailingFallback;

	internal Button btnCancel;

	internal Button btnConfirm;

	private bool isRandomGenerator;

	private static HiddenGenerator AttachCombinedPublisher;

	public TradeCopierGroupSettings Settings
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
	public HiddenGenerator(TradeCopierGroupSettings init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateRandomProcessor(object res, RoutedEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateDynamicSender(object res, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateReadableVisitor(object init, SelectionChangedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateDividedDecryptor(object first, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateIsolatedDefinition(object spec, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateSeparatedSelector(object spec, RoutedEventArgs connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CountRunner(object param, RoutedEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadProject(object param, RoutedEventArgs second)
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
	void IComponentConnector.Connect(int numreference, object counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int taskcounter, object reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HiddenGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateGroupedParameter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HiddenGenerator AttachIdentifiableProxy()
	{
		return null;
	}
}
