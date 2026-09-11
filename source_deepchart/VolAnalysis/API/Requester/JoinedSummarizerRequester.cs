using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class JoinedSummarizerRequester : ListView
{
	public static readonly DependencyProperty operationalDicRequester;

	public static readonly DependencyProperty requesterAuthorizerPolicy;

	public static readonly DependencyProperty logicalDistributorRequester;

	internal static JoinedSummarizerRequester SimulateGlobalAuthenticatorCollection;

	public string EmptyText
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

	public Style EmptyTextStyle
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

	public Style EmptyBorderStyle
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
	static JoinedSummarizerRequester()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 8;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c != 0)
		{
			num = 0;
		}
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num3 != 9)
				{
					if (num3 == 989)
					{
						goto IL_0013;
					}
					goto case 1;
				}
				logicalDistributorRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30A6E234 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556701)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556701)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556701))));
				return;
			case 1:
			{
				requesterAuthorizerPolicy = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E7656D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556701)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
				int num2 = 9;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12 == 0)
				{
					num2 = 1;
				}
				num3 = num2;
				goto IL_0013;
			}
			case 0:
				{
					WriterCommandResolver.ReflectDefinitionSelector();
					operationalDicRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AA8BC97 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556701)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
					num = 1;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11 == 0)
					{
						num = 6;
					}
					break;
				}
				IL_0013:
				num = num3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JoinedSummarizerRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateDetachedCollectionAnnotation()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JoinedSummarizerRequester SimulateExtendedAnnotationSummarizer()
	{
		return null;
	}
}
