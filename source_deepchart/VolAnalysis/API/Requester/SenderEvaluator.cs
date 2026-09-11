using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaControls;

namespace VolAnalysis.API.Requester;

internal class SenderEvaluator : Control
{
	public static readonly DependencyProperty m_RequesterSynchronizerMember;

	public static readonly DependencyProperty m_GeneralDriverRequester;

	public static readonly DependencyProperty m_HiddenStackRequester;

	public static readonly DependencyProperty _HiddenTransformer;

	public static readonly DependencyProperty requesterMemberPool;

	public static readonly DependencyProperty poolHandlerRequester;

	public static readonly DependencyProperty m_RecommenderMatcher;

	public static readonly DependencyProperty _StatelessProject;

	public static readonly DependencyProperty m_HandlerTransmitterRequester;

	public static readonly DependencyProperty automatedCheckerRequester;

	private RowDefinition m_CollectionConverter;

	private IconButton btnExpand;

	private static SenderEvaluator JoinList;

	public object Content
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

	public string HeaderText
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

	public Brush HeaderBackcolor
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

	public Brush HeaderTextColor
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

	public double HeaderFontsize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Brush HeaderStroke
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

	public Visibility HeaderVisibility
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

	public bool IsExpanded
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

	public Style IconCollapseStyle
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

	public FrameworkElement HeaderAction
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
	static SenderEvaluator()
	{
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 12;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85ba16e4dce54edcb3824b8a2ce69527 == 0)
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 12)
				{
					if (num2 != 992)
					{
						break;
					}
					goto IL_0013;
				}
				m_RequesterSynchronizerMember = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486E7710 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777246)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				m_GeneralDriverRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7EE33BDB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777226)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3786F087 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3)));
				m_HiddenStackRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x62337D69 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new SolidColorBrush(Colors.DimGray)));
				num = 4;
				continue;
			case 4:
				_HiddenTransformer = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AD6A3B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new SolidColorBrush(Colors.White)));
				num = 6;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c134208b4ea4777b9fe8986b1148b1d == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				automatedCheckerRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x62337E47 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777322)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((PropertyChangedCallback)null));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677))));
				num = 2;
				continue;
			case 1:
				WriterCommandResolver.ReflectDefinitionSelector();
				num2 = 12;
				goto IL_0013;
			case 0:
				break;
			case 2:
				return;
				IL_0013:
				num = num2;
				continue;
			}
			requesterMemberPool = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x721175C6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777260)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)14.0));
			poolHandlerRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x46C17624 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777474)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)new SolidColorBrush(Colors.DimGray)));
			m_RecommenderMatcher = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8C8C40 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777328)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)(Visibility)0));
			_StatelessProject = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x196C1ED1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85d190cf4c4a4d04b10953a29bb27a0f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777221)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)false));
			m_HandlerTransmitterRequester = DependencyProperty.Register(WrapperStreamEditor.EncapsulateCommonSynchronizer(-189226311 ^ -1630738381 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(16777402)), Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556677)), (PropertyMetadata)new FrameworkPropertyMetadata((object)null));
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RequestDetachedEncryptor(object setup, RoutedEventArgs selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SenderEvaluator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ResumeLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SenderEvaluator PeekVerifier()
	{
		return null;
	}
}
