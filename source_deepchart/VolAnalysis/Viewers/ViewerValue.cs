using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace VolAnalysis.Viewers;

internal class ViewerValue : LocatorRequest
{
	internal enum LocatorMethodRequiredEnum
	{
		Volume,
		[Display(Name = "Orders (MBO)")]
		Order,
		AggregateTrades
	}

	internal enum FormRegionKindConstants
	{
		None,
		Manual,
		Auto
	}

	internal enum IntegratedConfigurationWriterValues
	{
		None,
		EnableAutoTime,
		EnableCustomTime
	}

	[CompilerGenerated]
	private int m_CalcViewerPnts;

	[CompilerGenerated]
	private LocatorMethodRequiredEnum m_JoinedViewer;

	[CompilerGenerated]
	private int _CommandCalculatorPnts;

	[CompilerGenerated]
	private int _ConvertibleTreeId;

	[CompilerGenerated]
	private FormRegionKindConstants _ViewerProvider;

	[CompilerGenerated]
	private double m_TracerDefinition;

	[CompilerGenerated]
	private int viewerWorkerIdx;

	[CompilerGenerated]
	private IntegratedConfigurationWriterValues m_ViewerTracer;

	[CompilerGenerated]
	private FormRegionKindConstants detailedViewer;

	[CompilerGenerated]
	private double _LiteralAuthenticator;

	[CompilerGenerated]
	private int scheduledViewerDepth;

	[CompilerGenerated]
	private TimeSpan notifierTree;

	[CompilerGenerated]
	private bool m_IsOrderedViewer;

	[CompilerGenerated]
	private int _IteratorTransmitters;

	[CompilerGenerated]
	private bool isTransactionBuffer;

	[CompilerGenerated]
	private int notifierViewerFlag;

	[CompilerGenerated]
	private Color _ViewerTransaction;

	[CompilerGenerated]
	private Color m_IntegratedViewer;

	[CompilerGenerated]
	private bool _IsFilteredViewer;

	[CompilerGenerated]
	private int m_RandomViewerPosition;

	[CompilerGenerated]
	private int m_SetConfigurationCnt;

	[CompilerGenerated]
	private bool m_IsDefinitionTag;

	[CompilerGenerated]
	private bool _IsViewerDefinition;

	[CompilerGenerated]
	private int _AdjustableViewerDepth;

	[CompilerGenerated]
	private bool m_IsSequentialPredicate;

	[CompilerGenerated]
	private bool isStatelessViewer;

	[CompilerGenerated]
	private float treeViewer;

	[CompilerGenerated]
	private Color viewerBuffer;

	private RequesterTagExplorer operationalViewer;

	private long m_InterpreterProviderInterval;

	private long _CustomizableProfileCounter;

	private int modularViewerCap;

	private IMonoCalcViewer m_ViewerTag;

	private Color viewerVerifier;

	private Color m_QueueViewer;

	private DateTime groupedViewer;

	private bool isViewerStrategy;

	private int publisherOrderScore;

	private Common.WriterWrapperHandler _ViewerVisitor;

	private VisualWrapperRequester<long> viewerConfiguration;

	private int m_ViewerServiceAge;

	private Common.WriterWrapperHandler _CustomViewer;

	private VisualWrapperRequester<long> m_WriterViewer;

	private bool m_IsSubscriberInterpreter;

	private MapNotifier treeVerifier;

	private MapNotifier _CollectionSpec;

	private int _ScalableStubFreq;

	private int m_PortableViewerStep;

	private double m_LiteralRunner;

	private bool _IsStructEnumerator;

	private int m_EvaluatorAdapterRate;

	private TimeSpan _ViewerComparator;

	private TimeSpan providerChain;

	internal static ViewerValue AddAllocator;

	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public int DaysToLoad
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
	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 1)]
	public LocatorMethodRequiredEnum InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorMethodRequiredEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 2, MinValue = 0.0, MaxValue = 2147483647.0)]
	public int FilterMin
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

	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 3, MinValue = 0.0, MaxValue = 2147483647.0)]
	[Category("General")]
	public int FilterMax
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

	[DisplayName("Filter Mode")]
	[StaticStructAllocator(SubCategory = "Filter POC", CategoryIndex = 0, PropertyIndex = 4, MaxValue = 10000000.0, IncrementValue = 50.0)]
	[Category("General")]
	public FormRegionKindConstants FilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FormRegionKindConstants)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Auto Std. Dev")]
	[StaticStructAllocator(SubCategory = "Filter POC", CategoryIndex = 0, PropertyIndex = 5, MaxValue = 4.0, IncrementValue = 0.5, DecimalPosToShow = 2)]
	[Category("General")]
	public double FilterStdDev
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

	[Category("General")]
	[DisplayName("Manual Min. Vol.")]
	[StaticStructAllocator(SubCategory = "Filter POC", CategoryIndex = 0, PropertyIndex = 6, MaxValue = 10000000.0, IncrementValue = 50.0)]
	public int FilterMinVol
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
	[DisplayName("Enable")]
	[StaticStructAllocator(SubCategory = "Filter POC (RTH)", CategoryIndex = 0, PropertyIndex = 7)]
	public IntegratedConfigurationWriterValues RthFilterEnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IntegratedConfigurationWriterValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Filter Mode")]
	[StaticStructAllocator(SubCategory = "Filter POC (RTH)", CategoryIndex = 0, PropertyIndex = 8)]
	public FormRegionKindConstants RthFilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FormRegionKindConstants)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Auto Std. Dev")]
	[StaticStructAllocator(SubCategory = "Filter POC (RTH)", CategoryIndex = 0, PropertyIndex = 9, MaxValue = 4.0, IncrementValue = 0.5, DecimalPosToShow = 2)]
	public double RthFilterStdDev
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

	[StaticStructAllocator(SubCategory = "Filter POC (RTH)", CategoryIndex = 0, PropertyIndex = 10, MaxValue = 10000000.0, IncrementValue = 50.0)]
	[DisplayName("Manual Min. Vol.")]
	[Category("General")]
	public int RthFilterMinVol
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
	[DisplayName("Ini time session (Exchange time zone)")]
	[StaticStructAllocator(SubCategory = "Filter POC (RTH)", CategoryIndex = 0, PropertyIndex = 11)]
	public TimeSpan RthIniSession
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

	[Category("Plot Settings")]
	[DisplayName("Show rectangle")]
	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 0)]
	public bool POC_ShowRectangle
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

	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 1, MaxValue = 8.0)]
	public int POC_LineWidth
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

	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Plot Settings")]
	[DisplayName("Show background")]
	public bool POC_ShowBackground
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

	[Category("Plot Settings")]
	[DisplayName("Back Opacity")]
	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 3, MaxValue = 100.0)]
	public int POC_Opacity
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

	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 4)]
	[Category("Plot Settings")]
	[DisplayName("Bid Color")]
	public Color POC_BidColor
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

	[DisplayName("Ask Color")]
	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Highlight", CategoryIndex = 1, PropertyIndex = 5)]
	public Color POC_AskColor
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

	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 6)]
	[Category("Plot Settings")]
	[DisplayName("Enable")]
	public bool ExtendPOC
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

	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 7, MaxValue = 8.0)]
	public int ExtendLineWidth
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 8, MaxValue = 2147483647.0)]
	public int MaxBarsExtension
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

	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 9)]
	[DisplayName("Reset Start Day")]
	[Category("Plot Settings")]
	public bool ExtendResetOnStart
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

	[DisplayName("Remove Line On Shadow Triggered")]
	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 10)]
	public bool ExtendShadowTriggered
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

	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 11, MaxValue = 2147483647.0)]
	[DisplayName("Tick margin breakout")]
	[Category("Plot Settings")]
	public int TickMarginBreakout
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Extend POC", CategoryIndex = 1, PropertyIndex = 12)]
	[DisplayName("Hide line on breakout")]
	public bool HideTriggeredLine
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

	[StaticStructAllocator(SubCategory = "Duration on extension", CategoryIndex = 1, PropertyIndex = 13)]
	[DisplayName("Enable")]
	[Category("Plot Settings")]
	public bool EnableDurationText
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

	[StaticStructAllocator(SubCategory = "Duration on extension", CategoryIndex = 1, PropertyIndex = 14, MaxValue = 50.0, DecimalPosToShow = 2, IncrementValue = 0.2)]
	[Category("Plot Settings")]
	[DisplayName("Text size")]
	public float DurationFontSize
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

	[DisplayName("Text Color")]
	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Duration on extension", CategoryIndex = 1, PropertyIndex = 15)]
	public Color DurationTextColor
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerValue()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_00c16e707ebf4bec83c8b759d6aa24e6 != 0)
		{
			num = 6;
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555335)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486D5DE2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5B93E48B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5), MapResponderLocator.BasicRecordReg.Volume));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerValue(ScopeEncryptor.HiddenModelDecider setup, MapResponderLocator.TransformableUserEncryptor pol, int role_offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isinit, bool evaluateivk)
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
	private void ObserveTransformableGateway(RequesterTagExplorer config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer RemoveBuffer(int task_amount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DisplaySimplePolicy(int config_Low, double caller)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ObserveDetailedSorter(int task_Position)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool outputlast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayVisualContainer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStatelessInspector(bool isreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool readvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool taskreguired)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAdvancedMember()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerValue GenerateOrderedProcessor()
	{
		return null;
	}
}
