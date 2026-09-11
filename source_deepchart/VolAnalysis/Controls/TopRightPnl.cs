using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.Controls;

internal class TopRightPnl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty passiveListenerLocator;

	public static readonly DependencyProperty logicalTreeLocator;

	public static readonly DependencyProperty _LocatorTransactionDic;

	internal IconButton btnHelp;

	internal IconButton btnMinimize;

	internal IconButton btnRestore;

	internal IconButton btnClose;

	private bool isAutomatedPredictor;

	internal static TopRightPnl AttachRandomWorkerSolver;

	public Visibility MinimizeVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Visibility ResizeVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Visibility HelpVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TopRightPnl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearAttachedTree(object init, SizeChangedEventArgs attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearBasicGenerator(object reference, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindOperationalRunner(object v, RoutedEventArgs b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearFlexibleProject(object ident, RoutedEventArgs second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyEditableObserver(object setup, RoutedEventArgs pred)
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
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int lastID, object second)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TopRightPnl()
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0674567192e14314b84a58d33d035031 != 0)
		{
			num = 5;
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
					break;
				}
				goto case 1;
			case 1:
				_LocatorTransactionDic = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FAD8A1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555942)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)2));
				return;
			case 0:
				passiveListenerLocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E92303D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555942)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)0));
				logicalTreeLocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316A9718 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555942)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)0));
				num = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDynamicSolverNotifier()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TopRightPnl AttachReadableNotifierInterpreter()
	{
		return null;
	}
}
