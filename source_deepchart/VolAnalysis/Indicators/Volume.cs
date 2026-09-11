using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace VolAnalysis.Indicators;

internal class Volume : LocatorRequest
{
	[Serializable]
	internal struct RangeSettings
	{
		internal static object MoveCommand;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("First Range")]
		[DisplayName("Bid Color")]
		public Color BidColor1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("First Range")]
		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		public Color AskColor1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[Category("Second Range")]
		public bool EnableRange1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Second Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		[DisplayName("Bid Color")]
		[Category("Second Range")]
		public Color BidColor2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[Category("Second Range")]
		public Color AskColor2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Third Range")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		public bool EnableRange2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Third Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[DisplayName("Bid Color")]
		[Category("Third Range")]
		public Color BidColor3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
		[DisplayName("Ask Color")]
		[Category("Third Range")]
		public Color AskColor3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		[Category("Fourth Range")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		public bool EnableRange3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 2147483647.0)]
		[Category("Fourth Range")]
		[DisplayName("Value")]
		public int Range3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fourth Range")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		[DisplayName("Bid Color")]
		public Color BidColor4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
		[Category("Fourth Range")]
		public Color AskColor4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		static RangeSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateDividedVerifierProvider()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateIsolatedProviderParser()
		{
			return null;
		}
	}

	internal enum AllocatorSynthesizerEmphasis
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggregateTrades
	}

	internal enum LocatorCacheAllocatorFlags
	{
		Total,
		Counter
	}

	internal enum EncryptorProgramExplorerState
	{
		None,
		Fading,
		DeltaFading,
		DeltaRange,
		VolumeSlope,
		PriceSlope
	}

	internal enum ListenerCacheDeciderFlags
	{
		Volume,
		Trade
	}

	private class TrackerStrategy
	{
		public long _TransactionTaskStep;

		public int executorEmitterPnts;

		public VisualWrapperRequester<long> m_PredictorUser;

		private static TrackerStrategy SimulateGenericGatewayCompiler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TrackerStrategy()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TrackerStrategy()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateSimpleCompilerPolicy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TrackerStrategy InitToken()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private AllocatorSynthesizerEmphasis deciderStackValidator;

	[CompilerGenerated]
	private int responderViewerValue;

	[CompilerGenerated]
	private int m_RecommenderViewerLimit;

	[CompilerGenerated]
	private LocatorCacheAllocatorFlags controllableBridgeViewer;

	[CompilerGenerated]
	private bool isViewerPredicateInitializer;

	[CompilerGenerated]
	private int _ViewerInitializerDecryptorStep;

	[CompilerGenerated]
	private int m_ConvertibleBridgeLevel;

	[CompilerGenerated]
	private EncryptorProgramExplorerState logicalModel;

	[CompilerGenerated]
	private ListenerCacheDeciderFlags _DecryptorRequestViewer;

	[CompilerGenerated]
	private RangeSettings _ViewerRequestRequester;

	[CompilerGenerated]
	private Color m_RandomNotifier;

	[CompilerGenerated]
	private float viewerRequesterReporter;

	[CompilerGenerated]
	private Color connectionAdapter;

	[CompilerGenerated]
	private Color convertibleControllerViewer;

	[CompilerGenerated]
	private bool isFilteredToken;

	[CompilerGenerated]
	private bool m_IsSubscriberCompressor;

	[CompilerGenerated]
	private int externalMapViewerCnt;

	[CompilerGenerated]
	private int viewerReporterFunctionLength;

	[CompilerGenerated]
	private int _ViewerFunctionRoleFreq;

	[CompilerGenerated]
	private int m_ViewerRoleThreadStep;

	[CompilerGenerated]
	private bool isHiddenRegViewer;

	[CompilerGenerated]
	private bool _IsViewerThreadSchema;

	[CompilerGenerated]
	private Color m_ConnectedModuleViewer;

	[CompilerGenerated]
	private Color m_DividedGeneratorViewer;

	[CompilerGenerated]
	private int _ProgramCommandRank;

	[CompilerGenerated]
	private bool _IsViewerSchemaEngine;

	[CompilerGenerated]
	private ResponsiveStructLocator _BufferFunctionList;

	[CompilerGenerated]
	private bool _IsReadableTesterViewer;

	[CompilerGenerated]
	private string monoValueViewerMsg;

	[CompilerGenerated]
	private bool m_IsEditableCalcViewer;

	[CompilerGenerated]
	private int _ViewerEngineDriverCap;

	private long passiveNotifierLimit;

	private long viewerDriverEncryptorAge;

	private long m_ViewerEncryptorWrapperIndex;

	private bool isEfficientProviderViewer;

	private Color[] extendedWorkerViewers;

	private int localStructPnts;

	private RequesterTagExplorer globalTracerViewer;

	private RequesterTagExplorer m_ExecutorTemplate;

	private Common.WriterWrapperHandler _TransferableNotifierViewer;

	private VisualWrapperRequester<long> m_VirtualTransactionViewer;

	private Dictionary<long, TrackerStrategy> wrapperProfileViewerMap;

	private TrackerStrategy profilePredictorViewer;

	private bool m_IsLiteralChecker;

	private long viewerPredictorEmitterScore;

	internal static Volume InsertManager;

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public AllocatorSynthesizerEmphasis InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorSynthesizerEmphasis)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("Data Settings")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("Data Settings")]
	public LocatorCacheAllocatorFlags Display
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorCacheAllocatorFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Calculation Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool CalculationBasedOnSeconds
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

	[Category("Calculation Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 360.0)]
	public int NumberOfSeconds
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MaxValue = 2147483647.0)]
	public int MinimumTotVolume
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[Category("Plot Settings")]
	public EncryptorProgramExplorerState BackgroundMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorProgramExplorerState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Delta Input Data")]
	[Category("Plot Settings")]
	public ListenerCacheDeciderFlags DeltaData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ListenerCacheDeciderFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Plot Settings")]
	public RangeSettings DeltaRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RangeSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	public Color NeutralColor
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

	[Category("Text Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public float TextSize
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

	[Category("Text Settings")]
	[DisplayName("Fixed/Positive Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public Color PositiveColor
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

	[Category("Text Settings")]
	[DisplayName("Negative color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public Color NegativeeColor
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	[Category("Text Settings")]
	public bool TextBasedOnDelta
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

	[Category("Marker Settings")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Enable")]
	public bool MarkerEnable
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

	[Category("Marker Settings")]
	[DisplayName("Max Vol")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int MarkerMaxVol
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Diff. Vol")]
	public int MarkerDiffVol
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

	[DisplayName("Max. Delta")]
	[Category("Marker Settings")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3, MaxValue = 2147483647.0)]
	public int MarkerMaxDelta
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4, MaxValue = 2147483647.0)]
	[Category("Marker Settings")]
	[DisplayName("Diff. Delta")]
	public int MarkerDiffDelta
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

	[DisplayName("Full delta absorption")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5, MaxValue = 2147483647.0)]
	[Category("Marker Settings")]
	public bool MarkerFullDeltaAbsorption
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

	[Category("Marker Settings")]
	[DisplayName("Calculate on close")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6, MaxValue = 2147483647.0)]
	public bool MarkerOnlyOnClose
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

	[Category("Marker Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Bid absorption")]
	public Color MarkerBidAbsorption
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

	[Category("Marker Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Ask absorption")]
	public Color MarkerAskAbsorption
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

	[Category("Marker Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2, MaxValue = 100.0)]
	[DisplayName("Opacity")]
	public int MarkerOpacity
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

	[Category("Marker Alert")]
	[DisplayName("Enable Sound")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0, MaxValue = 2147483647.0)]
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

	[Category("Marker Alert")]
	[DisplayName("Alert Sound")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, IsAlert = true)]
	public ResponsiveStructLocator AlertSound
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

	[Category("Marker Alert")]
	[DisplayName("Enable Message")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public bool EnableAlertMsg
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

	[Category("Marker Alert")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3, MaxValue = 2147483647.0)]
	public string AlertMessage
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

	[Category("Average Volume")]
	public bool EnableAverage
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

	[Category("Average Volume")]
	public int NumOfDays
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Volume()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555694));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x209488B6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x196E3671 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85d190cf4c4a4d04b10953a29bb27a0f), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8FB1AE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE0E459B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Volume(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor second, int filter_end)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isspec, bool ignorecust)
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
	public override void DecodeListener(bool isinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator ident, bool forcecont, MapResponderLocator.TokenParameterViewer dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBuffer(bool explicitspec, bool isattr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DisplayVisibleContainer(Color init)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer PresentState()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool ignorespec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachCustomProviderParser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Volume AttachAttachedParserProgram()
	{
		return null;
	}
}
