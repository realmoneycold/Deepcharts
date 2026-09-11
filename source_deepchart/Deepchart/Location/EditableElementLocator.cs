using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class EditableElementLocator : ContentControl
{
	public static readonly DependencyProperty m_ProjectTask;

	public static readonly DependencyProperty _LocatorDictionarySingleton;

	protected static readonly RoutedEvent _LocatorValidatorStack;

	internal static EditableElementLocator AnalyzeDistributor;

	public int Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool Rotate
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

	public event RoutedEventHandler RotationStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EditableElementLocator()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 9)
					{
						m_ProjectTask = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x78677882 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_bb3801db3d634a8f97973394c9549a6c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777220)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)), (PropertyMetadata)new FrameworkPropertyMetadata((object)16));
						num2 = 1;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto IL_0032;
				case 1:
					_LocatorDictionarySingleton = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3192F21E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ce5e6360b5bf4130971d08218eea5aed != 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0172;
				IL_0032:
				if (num == 989)
				{
					break;
				}
				goto IL_0172;
				IL_0172:
				_LocatorValidatorStack = EventManager.RegisterRoutedEvent(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F4B62FB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), (RoutingStrategy)1, Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777302)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556698))));
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditableElementLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAlphabeticConverterAggregator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EditableElementLocator CompressToken()
	{
		return null;
	}
}
