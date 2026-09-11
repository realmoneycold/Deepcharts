using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal class EncryptorSystem : LocatorRequest
{
	internal enum RegLogoutAction
	{
		PriceSlope,
		High,
		Low
	}

	internal enum SeparatedVerifierWriterFlags
	{
		SecToClose,
		Close
	}

	internal enum LocatorRequesterFieldType
	{
		Automatic,
		FixedContract,
		FixedAll
	}

	[CompilerGenerated]
	private int m_EncryptorCreatorPos;

	[CompilerGenerated]
	private int m_EncryptorNodeDist;

	[CompilerGenerated]
	private int m_TreeDeciderPos;

	[CompilerGenerated]
	private int m_ScalableCollectionTotal;

	[CompilerGenerated]
	private int m_CollectorEncryptorValue;

	[CompilerGenerated]
	private int _VisualDicEncryptorCnt;

	[CompilerGenerated]
	private int _LogicalAuthenticatorStep;

	[CompilerGenerated]
	private int m_EncryptorPredicateCap;

	[CompilerGenerated]
	private SeparatedVerifierWriterFlags transferableMapEncryptor;

	[CompilerGenerated]
	private int _SharerSummarizerPos;

	[CompilerGenerated]
	private int _EncryptorSorters;

	[CompilerGenerated]
	private RegLogoutAction m_EncryptorTemplate;

	[CompilerGenerated]
	private bool _IsSetTransmitterEncryptor;

	[CompilerGenerated]
	private int encryptorEventFreq;

	[CompilerGenerated]
	private double m_AggregatorFinder;

	[CompilerGenerated]
	private float _ScopeLogger;

	[CompilerGenerated]
	private int encryptorTesterSize;

	[CompilerGenerated]
	private Color m_RemoteFinalizerEncryptor;

	[CompilerGenerated]
	private Color m_AdjustableAdapterEncryptor;

	[CompilerGenerated]
	private Color m_TransmitterAnalyzer;

	[CompilerGenerated]
	private bool isSeparatedCompilerEncryptor;

	[CompilerGenerated]
	private ResponsiveStructLocator m_OperationalNotifiers;

	[CompilerGenerated]
	private bool m_IsArgumentStrategy;

	[CompilerGenerated]
	private string encryptorCollectionName;

	[CompilerGenerated]
	private LocatorRequesterFieldType randomSetEncryptor;

	[CompilerGenerated]
	private int m_OperationalElementOffset;

	[CompilerGenerated]
	private int _EncryptorObserverAge;

	[CompilerGenerated]
	private double expandableCommandEncryptor;

	[CompilerGenerated]
	private bool _IsEncryptorDecryptor;

	[CompilerGenerated]
	private Color attachedProject;

	[CompilerGenerated]
	private Color _ProjectGenerator;

	[CompilerGenerated]
	private Color m_CreatorBuffer;

	[CompilerGenerated]
	private Color m_RequesterEncryptor;

	[CompilerGenerated]
	private int _TransformableEditorEncryptorRank;

	[CompilerGenerated]
	private Color _CompilerLogger;

	[CompilerGenerated]
	private int efficientUserEncryptorCap;

	[CompilerGenerated]
	private double encryptorEngine;

	[CompilerGenerated]
	private bool _IsBridgeCollector;

	[CompilerGenerated]
	private int _EncryptorPublisherDist;

	[CompilerGenerated]
	private bool m_IsConnectedInspectorEncryptor;

	[CompilerGenerated]
	private TimeSpan encryptorFunction;

	[CompilerGenerated]
	private TimeSpan m_ExtractorCalc;

	private int _EncryptorEmitterFlag;

	private int responderCollectionRate;

	private int recommenderModuleLevel;

	private EncryptorCacheBuffer.Series_Prop generalSingletonEncryptor;

	private bool? tagEncryptor;

	private RequesterTagExplorer _BridgeSelector;

	private bool _IsAdvancedProjectEncryptor;

	private EncryptorCacheBuffer.Series_Prop _StrategyObject;

	private VisibleLocatorLocator _EncryptorOrder;

	internal static EncryptorSystem GenerateSequentialCacheSubscriber;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[Category("Parameters")]
	[DisplayName("Min. delta %")]
	public int MinDeltaPercentual
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

	[Category("Parameters")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Min. volume")]
	public int MinTotalVolume
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

	[DisplayName("Min. volume increase")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("Parameters")]
	public int MinVolumeIncrease
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MinValue = 2.0, MaxValue = 2147483647.0)]
	[Category("Parameters")]
	[DisplayName("Min. body ticks")]
	public int MinBarTicks
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

	[Category("Parameters")]
	[DisplayName("Min price ticks increase")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 2.0, MaxValue = 2147483647.0)]
	public int MinPriceTicksIncrease
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	[DisplayName("Min. horizontal delta")]
	[Category("Parameters")]
	public int MinHorizDeltaPercNum
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

	[DisplayName("Min. % imbalance")]
	[Category("Parameters")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 2147483647.0)]
	public int MinDetectionImbalancePerc
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7, MaxValue = 2147483647.0)]
	[DisplayName("Min. number imbalance")]
	[Category("Parameters")]
	public int MinDetectionImbalanceNum
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

	[Category("Parameters")]
	[DisplayName("Calculation Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8)]
	public SeparatedVerifierWriterFlags CalcMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SeparatedVerifierWriterFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Parameters")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 9)]
	[DisplayName("Seconds To Close")]
	public int MaxSecToClose
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 500.0, MinValue = -500.0)]
	[Category("Marker Settings")]
	public int TickOffset
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Marker Settings")]
	public RegLogoutAction PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegLogoutAction)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Contract Calculation")]
	public bool CC_Enable
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

	[DisplayName("Max loss")]
	[Category("Contract Calculation")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int CC_MaxLoss
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 2147483647.0, MinValue = 1.0)]
	[DisplayName("Tick value divider")]
	[Category("Contract Calculation")]
	public double CC_TickValueDivider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MaxValue = 30.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
	[Category("Contract Calculation")]
	[DisplayName("Font Size")]
	public float CC_FontSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Contract Calculation")]
	[DisplayName("Tick offset")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4, MaxValue = 500.0, MinValue = 0.0)]
	public int CC_TickOffset
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
	[Category("Contract Calculation")]
	[DisplayName("Back Color")]
	public Color CC_BackColor
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

	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
	[Category("Contract Calculation")]
	public Color CC_BuyTextColor
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

	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7)]
	[Category("Contract Calculation")]
	public Color CC_SellTextColor
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

	[Category("Alert Sound")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public bool EnableAlertSound
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, IsAlert = true)]
	[DisplayName("Alert Name")]
	[Category("Alert Sound")]
	public ResponsiveStructLocator AlertName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[Category("Message Popup")]
	public bool EnableMessagePopup
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	[Category("Message Popup")]
	public string MessageText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[Category("Simulation")]
	[DisplayName("Size Calculation")]
	public LocatorRequesterFieldType SizeCalculation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorRequesterFieldType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Contracts")]
	[Category("Simulation")]
	public int SimulationContracts
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Stop Ticks")]
	[Category("Simulation")]
	public int SimulationStopTicks
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, MaxValue = 2147483647.0, DecimalPosToShow = 1)]
	[DisplayName("Target Ticks")]
	[Category("Simulation")]
	public double SimulationTargetTicks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Simulation")]
	[DisplayName("Export CSV")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public bool ExportCsv
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

	[Category("Simulation")]
	[DisplayName("Entry buy")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5)]
	public Color SimulationEntryBuyColor
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

	[Category("Simulation")]
	[DisplayName("Exit buy")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6)]
	public Color SimulationExitBuyColor
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

	[Category("Simulation")]
	[DisplayName("Entry sell")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 7)]
	public Color SimulationEntrySellColor
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

	[Category("Simulation")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 8)]
	[DisplayName("Exit sell")]
	public Color SimulationExitSellColor
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

	[Category("Simulation")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 9, MaxValue = 2147483647.0)]
	[DisplayName("Arrow Text Size")]
	public int SimulationArrowTextSize
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

	[Category("Simulation")]
	[DisplayName("Text color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 10)]
	public Color SimulationArrowTextColor
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

	[Category("Simulation")]
	[DisplayName("Summary Text Size")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 11, MaxValue = 2147483647.0)]
	public int SimulationSummaryTextSize
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 12, DecimalPosToShow = 2, IncrementValue = 0.25)]
	[DisplayName("Commissions")]
	[Category("Simulation")]
	public double SimulationCommissions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Enable")]
	[Category("Filter HL")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	public bool EnableFilterHL
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

	[Category("Filter HL")]
	[DisplayName("Length")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
	public int LengthHL
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

	[DisplayName("Enable")]
	[Category("Filter time session (Exchange time zone)")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	public bool FilterTimeEnabled
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

	[Category("Filter time session (Exchange time zone)")]
	[DisplayName("Ini Time")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1)]
	public TimeSpan FilterTimeIni
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Filter time session (Exchange time zone)")]
	[DisplayName("End Time")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	public TimeSpan FilterTimeEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EncryptorSystem()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee == 0)
		{
			num = 2;
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555468)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED1559 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C7660 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator.m_JoinedElementLocatorTotal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EncryptorSystem(ScopeEncryptor.HiddenModelDecider asset, MapResponderLocator.TransformableUserEncryptor second, int num_proc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool verifyinfo, bool writepred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool haveparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool injectitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncryptAutomatedPredictor(bool removevar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncryptJoinedTransformer(bool evaluateconfig, out int b, out int control)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeConvertibleAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CheckConnectedTree(int ID_first)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReceiveCalc()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EncryptorSystem GenerateGenericClientExecutor()
	{
		return null;
	}
}
