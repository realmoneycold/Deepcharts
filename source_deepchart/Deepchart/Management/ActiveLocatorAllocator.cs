using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace Deepchart.Management;

internal class ActiveLocatorAllocator : UserControl, IComponentConnector
{
	private static List<SolidColorBrush> allocatorRequestChains;

	public static readonly DependencyProperty _GlobalMatcherAllocator;

	private ContextMenu cmsMenu;

	[CompilerGenerated]
	private Action<int> allocatorChainPredicate;

	[CompilerGenerated]
	private Action<bool> concreteCacheAllocator;

	private Separator sepTradingSymbol;

	private MenuItem lnkTradingSymb;

	private bool isEvaluatorCompiler;

	internal IconButton btnLink;

	private bool m_IsSolverStack;

	private static ActiveLocatorAllocator AttachLocalChooserFunction;

	public Visibility LinkTradingSymbolVisibility
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
	[SpecialName]
	[CompilerGenerated]
	public void ObserveFormatter(Action<int> res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void MonitorGateway(Action<int> init)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AllocateFilteredStrategy(Action<bool> info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AssignPortableRecord(Action<bool> def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ActiveLocatorAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseSortedReporter(object item, RoutedEventArgs ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateVisibleTransmitter(object var1, RoutedEventArgs reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AssignSequentialProc(int rowfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReceiveModule(bool isreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateGenericPredicate(object def, RoutedEventArgs cont)
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
	void IComponentConnector.Connect(int setup_min, object visitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ActiveLocatorAllocator()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0023;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					num2 = 7;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					WriterCommandResolver.ReflectDefinitionSelector();
					allocatorRequestChains = new List<SolidColorBrush>
					{
						Brushes.Transparent,
						Brushes.Red,
						Brushes.Green,
						Brushes.Blue,
						Brushes.Magenta,
						Brushes.Purple,
						Brushes.Yellow,
						Brushes.Cyan,
						Brushes.Pink
					};
					_GlobalMatcherAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF1AE4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555938)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)2));
					return;
				case 1:
					break;
				}
				goto IL_0130;
				IL_0023:
				if (num == 990)
				{
					break;
				}
				goto IL_0130;
				IL_0130:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 3;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fe802903a1eb42299453510511b5e65f == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CustomizeRecommender()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ActiveLocatorAllocator SearchStruct()
	{
		return null;
	}
}
