using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class LocatorHandlerModel : Menu
{
	public static readonly DependencyProperty _ControllerDispatcher;

	private static LocatorHandlerModel AttachCustomSummarizerDictionary;

	public Visibility ArrowVisibility
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
	public LocatorHandlerModel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorHandlerModel()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fba289398733422f859a60f7abb79212 == 0)
		{
			num = 4;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		WriterCommandResolver.ReflectDefinitionSelector();
		_ControllerDispatcher = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B98F071 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556702)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAttachedDictionaryEngine()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorHandlerModel GenerateBasicEngineStack()
	{
		return null;
	}
}
