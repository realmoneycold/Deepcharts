using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.Registry;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.IO;

internal class WriterAggregator : Window, IComponentConnector
{
	[CompilerGenerated]
	private string m_WriterConverterText;

	[CompilerGenerated]
	private bool isInterruptibleWriter;

	[CompilerGenerated]
	private ObservableCollection<DetailedDecryptorReg<AnnotationType>> _SingletonManager;

	internal ComboBox cmbExportMode;

	internal CheckBox ckbExtendedOnly;

	internal DataGrid dgwAnnTypes;

	internal Button btnCancel;

	internal Button btnExport;

	private bool isAdvancedWriter;

	internal static WriterAggregator SimulatePortableWatcher;

	internal string Extension
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal bool WriteHiddenWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void LogModularSolver(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal ObservableCollection<DetailedDecryptorReg<AnnotationType>> WriteConfigurableInterpreter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void SearchList(ObservableCollection<DetailedDecryptorReg<AnnotationType>> var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriterAggregator(List<AnnotationType> reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MonitorDefinition(object key, RoutedEventArgs map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordInternalSynchronizer(object info, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecordAdjustableSingleton(object ident, SelectionChangedEventArgs cfg)
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int row_asset, object attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterAggregator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateSymbolicProfile()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WriterAggregator ReflectThread()
	{
		return null;
	}
}
