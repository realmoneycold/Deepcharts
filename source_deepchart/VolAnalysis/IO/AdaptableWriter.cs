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

internal class AdaptableWriter : Window, IComponentConnector
{
	[CompilerGenerated]
	private int segmentedWriterLength;

	[CompilerGenerated]
	private bool isThreadDistributor;

	internal TextBlock lblTitle;

	internal NumUpDown nud;

	internal CheckBox ckbBasedOnMinute;

	internal Button btnCancel;

	internal Button btnSet;

	private bool _IsWriterConfiguration;

	internal static AdaptableWriter AttachSortedSingleton;

	public int DaysToLoad
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
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
	public bool WriteAttachedTransaction()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void RecordBasicError(bool extractasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdaptableWriter(int idx_res, bool havepol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteLiteralCompiler(object spec, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogGlobalPolicy(object last, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableDecorator(object i, RoutedEventArgs reg)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int asset_Ptr, object attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdaptableWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateVisibleCalculator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AdaptableWriter InstantiateSender()
	{
		return null;
	}
}
