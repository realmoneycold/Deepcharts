using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RemoteStreamReg : LocatorRequest
{
	internal enum CalculatorProfileOptions
	{
		PriceSlope,
		High,
		Low
	}

	internal enum AllocatorWorkloadGroupParameterType
	{
		SecToClose,
		Close
	}

	[CompilerGenerated]
	private int identifiableChainRegErrorCode;

	[CompilerGenerated]
	private int m_StrategyTransactionRegFlag;

	[CompilerGenerated]
	private int isolatedRecordAge;

	[CompilerGenerated]
	private int m_SharerWrapperRank;

	[CompilerGenerated]
	private int m_ContextTagInterval;

	[CompilerGenerated]
	private int advancedTransformerRegFreq;

	[CompilerGenerated]
	private int _ConnectedBufferId;

	[CompilerGenerated]
	private int _RecordRequestRate;

	[CompilerGenerated]
	private AllocatorWorkloadGroupParameterType _SynchronizerState;

	[CompilerGenerated]
	private int m_GeneralConfigurationRegNum;

	[CompilerGenerated]
	private CalculatorProfileOptions m_RegTransactionStub;

	[CompilerGenerated]
	private bool _IsLocalDictionaryReg;

	[CompilerGenerated]
	private int _SynchronizerMatcherFlag;

	[CompilerGenerated]
	private double _RegStubAnnotation;

	[CompilerGenerated]
	private float regAnnotationRecord;

	[CompilerGenerated]
	private int _EventConsumerLevel;

	[CompilerGenerated]
	private Color _InitializerMapper;

	[CompilerGenerated]
	private Color m_RegRecordSolver;

	[CompilerGenerated]
	private Color _RegSolverAuditor;

	[CompilerGenerated]
	private bool m_IsReadableElementReg;

	[CompilerGenerated]
	private ResponsiveStructLocator m_MapProcessorList;

	[CompilerGenerated]
	private bool m_IsPassiveViewerReg;

	[CompilerGenerated]
	private string m_PassiveExplorerCategory;

	private int editorCompressorVal;

	private int hiddenAnalyzerRegVol;

	private int m_CommonRunnerSize;

	private EncryptorCacheBuffer.Series_Prop m_AuditorVisitorReg;

	private bool? m_BuilderCompiler;

	private RequesterTagExplorer _RegVisitorList;

	private static RemoteStreamReg AttachSetWatcherProfile;

	[Category("Parameters")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2147483647.0)]
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

	[Category("Parameters")]
	[DisplayName("Min. volume increase")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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
	[DisplayName("Min. body ticks")]
	[Category("Parameters")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 2.0, MaxValue = 2147483647.0)]
	[DisplayName("Min price ticks increase")]
	[Category("Parameters")]
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

	[Category("Parameters")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	[DisplayName("Min. horizontal delta")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 2147483647.0)]
	[DisplayName("Min. % imbalance")]
	[Category("Parameters")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8)]
	[DisplayName("Calculation Mode")]
	[Category("Parameters")]
	public AllocatorWorkloadGroupParameterType CalcMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorWorkloadGroupParameterType)(object)null;
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

	[Category("Marker Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public CalculatorProfileOptions PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CalculatorProfileOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Enable")]
	[Category("Contract Calculation")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Contract Calculation")]
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

	[Category("Contract Calculation")]
	[DisplayName("Tick value divider")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 2147483647.0, MinValue = 1.0)]
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

	[DisplayName("Font Size")]
	[Category("Contract Calculation")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MaxValue = 30.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4, MaxValue = 500.0, MinValue = 0.0)]
	[DisplayName("Tick offset")]
	[Category("Contract Calculation")]
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

	[Category("Contract Calculation")]
	[DisplayName("Back Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
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
	[Category("Contract Calculation")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7)]
	[DisplayName("Text Color")]
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

	[DisplayName("Enable")]
	[Category("Alert Sound")]
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

	[Category("Alert Sound")]
	[DisplayName("Alert Name")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, IsAlert = true)]
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

	[Category("Message Popup")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RemoteStreamReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555465));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8E2C88 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x2BDBBF73 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3191DB0E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF50BE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319D9E2B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE8805FD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator.m_ActiveEngineLocatorPosition);
		int num = 6;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_47575d9b57264043a9089ccece41b17e == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			if (num2 == 988)
			{
				num = num2;
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoteStreamReg(ScopeEncryptor.HiddenModelDecider def, MapResponderLocator.TransformableUserEncryptor visitor, int res_length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isv, bool isreg)
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
	public override void DecodeListener(bool isitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool explicitkey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeValue(bool definstall)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveStaticPool(bool firstneeded, out int map, out int role)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SaveCustomizableTracer(int asset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateSortedProfileEditor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemoteStreamReg FindEngine()
	{
		return null;
	}
}
