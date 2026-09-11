using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.IO;

internal class WriterSet : Window, IComponentConnector
{
	[CompilerGenerated]
	private string m_WriterNodeContent;

	[CompilerGenerated]
	private double m_SharerWriter;

	internal TextBox txtName;

	internal NumUpDown nudBalance;

	internal Button btnCancel;

	internal Button btnAdd;

	private bool _IsAdjustableWriter;

	internal static WriterSet AttachConvertibleValue;

	public string AccName
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
	public double ParseQueue()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void ChangeExtractor(double first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriterSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenWorker(object setup, RoutedEventArgs visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogBasicProvider(object last, RoutedEventArgs cfg)
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
	void IComponentConnector.Connect(int position_i, object counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterSet()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReceiveNode()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WriterSet DecompressAuditor()
	{
		return null;
	}
}
