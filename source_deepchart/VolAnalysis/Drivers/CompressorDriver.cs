using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Creations;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Drivers;

internal class CompressorDriver : Window, IEfficientFactorySingleton, IComponentConnector
{
	[CompilerGenerated]
	private EventHandler<RoutedEventArgs> convertibleDriver;

	[CompilerGenerated]
	private EventHandler<RoutedEventArgs> m_VirtualDriver;

	[CompilerGenerated]
	private EventHandler<RoutedEventArgs> _ComparatorExplorer;

	internal Grid grd;

	internal Border brdContent;

	internal Button btnApply;

	internal Button btnOK;

	private bool _IsMonoAdapter;

	private static CompressorDriver ScanChooser;

	public bool ApplyVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event EventHandler<RoutedEventArgs> CancelClick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<RoutedEventArgs> ApplyClick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<RoutedEventArgs> SaveClick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompressorDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunGlobalVerifier(object param, RoutedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlDetachedProvider(object key, CancelEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetContent(PropertyView first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlExtendedParser(object def, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceCustomProgram(object first, RoutedEventArgs pol)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int configZ, object col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompressorDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateActiveQueue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompressorDriver GenerateFilteredExtractor()
	{
		return null;
	}
}
