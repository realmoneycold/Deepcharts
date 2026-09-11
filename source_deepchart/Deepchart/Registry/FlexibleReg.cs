using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Registry;

internal class FlexibleReg : Window, IComponentConnector
{
	[CompilerGenerated]
	private int scheduledRegValue;

	[CompilerGenerated]
	private bool m_IsTransmitterReg;

	[CompilerGenerated]
	private int _ExpandableRegAge;

	[CompilerGenerated]
	private int m_FilteredRegScore;

	internal NumUpDown nudDaysToLoad;

	internal CheckBox ckbBasedOnMin;

	internal NumUpDown nudParam1;

	internal Label lblParam2;

	internal NumUpDown nudParam2;

	internal Button btnCancel;

	internal Button btnConfirm;

	private bool isVisibleChooser;

	internal static FlexibleReg AttachIntegratedSchema;

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
		set
		{
		}
	}

	public bool BasedOnMinute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Param1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Param2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlexibleReg(bool readkey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlexibleReg(int mean_reference, bool visitorclose, int min_control, int setup2_count, bool deletepred3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreModularClient(object var1, RoutedEventArgs ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveLocalExecutor(object var1, RoutedEventArgs ivk)
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
	void IComponentConnector.Connect(int start_instance, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FlexibleReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachStaticValue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FlexibleReg PlanMember()
	{
		return null;
	}
}
