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

namespace VolAnalysis.Controls;

internal class FundamentalControl : UserControl, IComponentConnector
{
	public static readonly DependencyProperty _WrapperModule;

	public static readonly DependencyProperty m_WrapperObserver;

	public static readonly DependencyProperty poolTracker;

	public static readonly DependencyProperty emitterSubscriber;

	public static readonly DependencyProperty _AggregatorConfiguration;

	internal Border brdVar;

	internal Border brdVarOpen;

	internal Border brdVolume;

	internal Border brdTrades;

	internal Border brdSusp;

	internal Border brdAuctionImb;

	internal Border brdAuctionPrice;

	private bool m_IsWrapperProc;

	private static FundamentalControl SimulateAutomatedRegFormatter;

	public GridLength VarGridLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength VarOpenGridLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength VolumeGridLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength AuctionGridLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength SuspensionGridLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FundamentalControl()
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
	void IComponentConnector.Connect(int param_count, object ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FundamentalControl()
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 7;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_21ef691e600947e1a0ecbfcfd6fb68bb == 0)
		{
			num = 9;
		}
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
						if (num2 == 989)
						{
							break;
						}
						goto case 1;
					}
					WriterCommandResolver.ReflectDefinitionSelector();
					_WrapperModule = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -113543104 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555927)), new PropertyMetadata((object)new GridLength(1.0, (GridUnitType)2)));
					num3 = 1;
					continue;
				case 0:
					emitterSubscriber = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AABD957 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555927)), new PropertyMetadata((object)new GridLength(0.0)));
					_AggregatorConfiguration = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3FDEDE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555927)), new PropertyMetadata((object)new GridLength(0.0)));
					return;
				case 1:
					m_WrapperObserver = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE77238 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555927)), new PropertyMetadata((object)new GridLength(1.0, (GridUnitType)2)));
					poolTracker = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x31919124 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777499)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555927)), new PropertyMetadata((object)new GridLength(1.0, (GridUnitType)2)));
					num3 = 1;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_18db9a7992884283b79f04fae3fd54fd == 0)
					{
						num3 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachJoinedFormatterGateway()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FundamentalControl AttachConvertibleGatewayCompiler()
	{
		return null;
	}
}
