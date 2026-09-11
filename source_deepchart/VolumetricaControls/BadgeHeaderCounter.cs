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

namespace VolumetricaControls;

internal class BadgeHeaderCounter : UserControl, IComponentConnector
{
	public static DependencyProperty elementValue;

	public static DependencyProperty m_RegStateValue;

	public static DependencyProperty _RegWorkerSharer;

	internal TextBlock PART_Header;

	internal TextBlock PART_Badge;

	private bool m_IsVirtualGeneratorReg;

	internal static BadgeHeaderCounter GenerateActiveObserverRole;

	public string Text
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

	public long Counter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Style HeaderStyle
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BadgeHeaderCounter()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						m_RegStateValue = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B27F36C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777293)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556732)), (PropertyMetadata)new FrameworkPropertyMetadata((object)0L));
						_RegWorkerSharer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--1896610954 ^ 0xF4D88EF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556732)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
						num3 = 2;
						continue;
					case 1:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 0;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4aea322dc74d4ca8a8e3084082c14c16 != 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
						FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556732)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556732))));
						return;
					case 0:
						break;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			WrapperStreamEditor.PresentConfiguration();
			WriterCommandResolver.ReflectDefinitionSelector();
			elementValue = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4E641E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556732)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
			num = 9;
			if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_97a289ab9e4343719653fa0c716e5f20 != 0)
			{
				num = 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BadgeHeaderCounter()
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
	void IComponentConnector.Connect(int columnasset, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachFilteredRoleController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BadgeHeaderCounter VerifySorter()
	{
		return null;
	}
}
