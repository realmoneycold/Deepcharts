using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class DriverState : UserControl, IComponentConnector
{
	public static readonly DependencyProperty m_ConfigConverter;

	public static readonly DependencyProperty m_MonoWorkerDriver;

	public static readonly DependencyProperty _AuditorProvider;

	[CompilerGenerated]
	private string m_DriverDistributorDescr;

	[CompilerGenerated]
	private RoutedEventHandler m_Click;

	internal Button btnCnt;

	internal Grid btnGrd;

	internal Ellipse crcEnabled;

	internal FieldMapper txtAbbr;

	private bool m_IsBridgeDriver;

	internal static DriverState GenerateIterableElementEmitter;

	public bool IsIndicatorEnabled
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

	public string Abbreviation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Header
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event RoutedEventHandler Click
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
	[SpecialName]
	[CompilerGenerated]
	public string ForceScopeInspector()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void ParseParser(string reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForcePassiveModule(object item, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ForceAdaptableDecorator(DependencyObject i, DependencyPropertyChangedEventArgs result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ForceRandomValidator(DependencyObject setup, DependencyPropertyChangedEventArgs cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RunDynamicReg(DependencyObject first, DependencyPropertyChangedEventArgs cont)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	void IComponentConnector.Connect(int spec_offset, object connection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverState()
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		m_ConfigConverter = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F265C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555937)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false, new PropertyChangedCallback(ForceAdaptableDecorator)));
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_42fbc1ba04824a6bbb0b9900cd13a5de == 0)
		{
			num = 7;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 989)
				{
					num = num2;
					continue;
				}
				break;
			case 0:
				return;
			case 1:
				break;
			}
			m_MonoWorkerDriver = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9B9005 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555937)), (PropertyMetadata)new FrameworkPropertyMetadata((object)"", new PropertyChangedCallback(ForceRandomValidator)));
			_AuditorProvider = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8FF72E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555937)), (PropertyMetadata)new FrameworkPropertyMetadata((object)"", new PropertyChangedCallback(RunDynamicReg)));
			num = 7;
			if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7f5e62e6715e481fa3aefa1c945abcc4 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReflectWrapper()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DriverState GenerateModularEncryptorChooser()
	{
		return null;
	}
}
