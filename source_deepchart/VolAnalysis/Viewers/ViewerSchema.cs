using System.Runtime.CompilerServices;
using VolAnalysis.Models;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class ViewerSchema
{
	internal enum OrderedDispatcherRegTypes
	{
		Quantity,
		Euro,
		Risk
	}

	internal enum WatcherDecryptorState
	{
		Single_SL_TP,
		Multi_SL_TP
	}

	[CompilerGenerated]
	private bool m_IsAutomatableViewer;

	[CompilerGenerated]
	private bool isViewerEngine;

	[CompilerGenerated]
	private string m_AdvancedViewerText;

	[CompilerGenerated]
	private bool m_IsEngineProxy;

	[CompilerGenerated]
	private OrderedDispatcherRegTypes viewerDriver;

	[CompilerGenerated]
	private decimal m_ViewerEncryptor;

	[CompilerGenerated]
	private string _BasicViewerContent;

	[CompilerGenerated]
	private string _CreatorIteratorContent;

	[CompilerGenerated]
	private bool isPoolChooser;

	[CompilerGenerated]
	private WatcherDecryptorState _CentralViewer;

	[CompilerGenerated]
	private bool? wrapperViewer;

	[CompilerGenerated]
	private bool m_IsConfigurableViewer;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum _CustomizableViewer;

	[CompilerGenerated]
	private int viewerProfileId;

	[CompilerGenerated]
	private bool m_IsLogicalViewer;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum _ValidatorEmitter;

	[CompilerGenerated]
	private int m_ViewerPredictorId;

	[CompilerGenerated]
	private bool m_IsSegmentedViewer;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum objectRequest;

	[CompilerGenerated]
	private int _ViewerEmitterLimit;

	[CompilerGenerated]
	private int? m_RegTester;

	[CompilerGenerated]
	private bool isResolverViewer;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum m_ViewerGateway;

	[CompilerGenerated]
	private int _ComparatorRequesterRate;

	[CompilerGenerated]
	private int? m_DynamicViewer;

	[CompilerGenerated]
	private string moduleValueName;

	[CompilerGenerated]
	private bool m_IsActiveViewer;

	[CompilerGenerated]
	private bool m_IsControllableViewer;

	[CompilerGenerated]
	private int _GeneratorCalcTotal;

	[CompilerGenerated]
	private bool m_IsPortableStub;

	internal static ViewerSchema AttachDividedChooser;

	public bool TradingEnabled
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

	public bool ShowHistFills
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

	public string TradeSymbName
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

	public bool ShowHistoricalOrder
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

	public OrderedDispatcherRegTypes QuantityType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OrderedDispatcherRegTypes)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public decimal Quantity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string BrokerId
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

	public string AccountId
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

	public bool UseOcoStrategy
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

	public WatcherDecryptorState OcoMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WatcherDecryptorState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool? IsOcoServerSide
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

	public bool OcoSingleSLEnable
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

	public OcoBracketStrategyModeEnum OcoSingleSLMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OcoBracketStrategyModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int OcoSingleSLValue
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

	public bool OcoSingleTPEnable
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

	public OcoBracketStrategyModeEnum OcoSingleTPMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OcoBracketStrategyModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int OcoSingleTPValue
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

	public bool OcoSingleBeEnable
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

	public OcoBracketStrategyModeEnum OcoSingleBeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OcoBracketStrategyModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int OcoSingleBeTrigger
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

	public int? OcoSingleBeOffset
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

	public bool OcoSingleTrailEnable
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

	public OcoBracketStrategyModeEnum OcoSingleTrailMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OcoBracketStrategyModeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int OcoSingleTrailTrigger
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

	public int? OcoSingleTrailOffset
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

	public string StrategyName
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

	public bool TradingPanelShown
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

	public bool UseBidAskTicksDiff
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

	public int BidAskTicksDiff
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

	public bool AutoTradingEnabled
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
	public ViewerSchema()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerSchema()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncodeSharer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerSchema GenerateSeparatedReceiver()
	{
		return null;
	}
}
