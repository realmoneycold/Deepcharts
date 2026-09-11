using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal class EncryptorMonitor : LocatorRequest
{
	internal enum ValueLookupType
	{
		Minute,
		VolBars,
		Range
	}

	[CompilerGenerated]
	private ValueLookupType modularSpec;

	[CompilerGenerated]
	private int policyEnginePos;

	[CompilerGenerated]
	private int m_SingletonProgramPos;

	[CompilerGenerated]
	private Color m_ProjectExplorer;

	[CompilerGenerated]
	private Color m_EncryptorChain;

	[CompilerGenerated]
	private bool _IsSharerConsumer;

	[CompilerGenerated]
	private int _DispatcherSenderFlag;

	[CompilerGenerated]
	private int programRoleVol;

	[CompilerGenerated]
	private int detachedEncryptorCap;

	[CompilerGenerated]
	private bool m_IsDividedEncryptor;

	private RequesterTagExplorer m_SortedEncryptor;

	private DateTime _ResolverState;

	private DateTime _ConfigurationEncryptor;

	private double encryptorArgument;

	private double encryptorRecommender;

	private double m_MonoEncryptor;

	private double calcDecider;

	private int m_BuilderBufferFlag;

	private int localTesterCount;

	private int m_EditableEncryptorPosition;

	private int m_EncryptorBridgeVal;

	private int _BasicEncryptorFreq;

	private bool _IsScalableEncryptor;

	private bool m_IsExternalEncryptor;

	private bool m_IsVirtualEncryptor;

	private int m_ModuleEncryptorPerc;

	private bool isExplorerFinder;

	private int m_EncryptorSelectorId;

	private ValueLookupType responderManager;

	private int m_ConsumerTokenizerCap;

	private int _ExternalDecoratorValue;

	private int roleDistributorVol;

	private bool isFinderDecryptor;

	private int flexibleEncryptorIndex;

	private Color _EncryptorObject;

	private Color controllableOrder;

	private static EncryptorMonitor SimulateAttachedList;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public ValueLookupType ParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueLookupType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2000.0)]
	public int Param1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2000.0)]
	public int Param2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public Color UpBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public Color DownBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public bool ShowFilledBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public int CandleWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 7.0, IncrementValue = 1.0)]
	public int BorderWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 100.0, IncrementValue = 5.0)]
	[Category("Plot")]
	public int Opacity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Plot")]
	public bool ShowVerticalLineOnClose
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EncryptorMonitor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 3;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e != 0)
		{
			num = 0;
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555355)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ECD6A7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -1770283498 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6b3eda098e1a4d3aa281067d349fea8d), MapResponderLocator.BasicRecordReg.Overlay));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EncryptorMonitor(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor attr, int ruleend)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool allowspec, bool isvisitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer InsertRequester(int reference_Y, double pred)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer EncodeCustomMonitor(int position_init, Color ord)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckAttachedState(bool comparetask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator value, bool loadivk, MapResponderLocator.TokenParameterViewer tag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool appendasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CombineLogger()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EncryptorMonitor SimulateOperationalVerifier()
	{
		return null;
	}
}
