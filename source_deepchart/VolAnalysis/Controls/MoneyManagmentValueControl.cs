using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Deepchart.DecisionMaking;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Controls;

internal class MoneyManagmentValueControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty filteredContext;

	public static readonly DependencyProperty TargetProperty;

	public static readonly DependencyProperty m_ProgramStruct;

	public static readonly DependencyProperty _HiddenAuditorAllocator;

	private bool isVisibleCommandAllocator;

	internal static MoneyManagmentValueControl AttachScheduledFieldEnumerator;

	public double? Current
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

	public double? Target
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

	public ConvertibleRequesterKinds? ColorStatus
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

	public string? Currency
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
	public MoneyManagmentValueControl()
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
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int spec_min, object b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MoneyManagmentValueControl()
	{
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
						filteredContext = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37858BA7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), typeof(double?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555939)));
						num2 = 3;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6db8a9ff1ed94f33a96a80de2654f93f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0032;
				case 0:
					TargetProperty = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x574081D2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69), typeof(double?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555939)));
					m_ProgramStruct = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE0E02E7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537), typeof(ConvertibleRequesterKinds?), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555939)));
					num2 = 4;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b662fc1314f140988b34a0144a3464c6 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
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
				_HiddenAuditorAllocator = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F5106BF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555939)));
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachMonoEnumeratorSynchronizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MoneyManagmentValueControl SimulateExternalSynchronizerSingleton()
	{
		return null;
	}
}
