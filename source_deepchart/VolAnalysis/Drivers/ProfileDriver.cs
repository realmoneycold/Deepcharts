using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Windows.Media;
using Deepchart.Management;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Drivers;

internal class ProfileDriver
{
	[CompilerGenerated]
	private float commandDriver;

	[CompilerGenerated]
	private Color m_WriterDispatcher;

	[CompilerGenerated]
	private AlignmentX _SimpleHandlerDriver;

	[CompilerGenerated]
	private bool m_IsResponsiveConfigDriver;

	[CompilerGenerated]
	private bool isSeparatedDeciderDriver;

	[CompilerGenerated]
	private bool _IsDriverRequester;

	[CompilerGenerated]
	private Color _EngineDriver;

	[CompilerGenerated]
	private bool isDriverLocator;

	[CompilerGenerated]
	private bool m_IsPoolDriver;

	[CompilerGenerated]
	private bool m_IsInternalThread;

	[CompilerGenerated]
	private bool _IsParameterDriver;

	[CompilerGenerated]
	private bool m_IsExtendedCollection;

	[CompilerGenerated]
	private bool _IsMonitorStrategy;

	[CompilerGenerated]
	private bool m_IsDriverReg;

	[CompilerGenerated]
	private bool isIteratorAllocator;

	[CompilerGenerated]
	private bool m_IsDriverSelector;

	[CompilerGenerated]
	private bool _IsControllerInitializer;

	[CompilerGenerated]
	private Color m_StrategyLogger;

	[CompilerGenerated]
	private Color _MixedConnectionDriver;

	[CompilerGenerated]
	private Color _RemoteCompiler;

	[CompilerGenerated]
	private Color m_DriverSender;

	[CompilerGenerated]
	private Color _ModularDefinitionDriver;

	[CompilerGenerated]
	private Color m_LiteralVisitorDriver;

	[CompilerGenerated]
	private Color m_OperationalClientDriver;

	[CompilerGenerated]
	private Color m_CollectorPolicy;

	[CompilerGenerated]
	private Color setChooserDriver;

	[CompilerGenerated]
	private Color m_DriverCalc;

	[CompilerGenerated]
	private Color _TransferableAttributeDriver;

	[CompilerGenerated]
	private Color _DriverPredictor;

	[CompilerGenerated]
	private Color controllerVerifier;

	[CompilerGenerated]
	private Color m_GlobalAnnotationDriver;

	[CompilerGenerated]
	private bool isDriverFinalizer;

	[CompilerGenerated]
	private Color automatedDistributor;

	[CompilerGenerated]
	private Color m_ExtractorProfiler;

	[CompilerGenerated]
	private int activeDicDriverTotal;

	[CompilerGenerated]
	private DashStyle _SymbolicCalculatorDriver;

	[CompilerGenerated]
	private bool isRemoteEmitterDriver;

	[JsonIgnore]
	[StaticStructAllocator(IsVisible = false)]
	public bool StyleChanged;

	private static ProfileDriver AttachControllableMember;

	[Category("Text Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, DecimalPosToShow = 1, IncrementValue = 1.0, MinValue = 1.0, MaxValue = 40.0)]
	public float FontSize
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public Color FontColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[Category("Text Settings")]
	[DisplayName("Alignment")]
	public AlignmentX TextAlign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (AlignmentX)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Text Settings")]
	[DisplayName("Show order id")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	public bool ShowOrderID
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

	[Category("Text Settings")]
	[DisplayName("Show price")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	public bool ShowOrderPrice
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

	[Category("Text Settings")]
	[DisplayName("Show PL")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	public bool ShowPL
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6)]
	[Category("Text Settings")]
	public Color ArrowTextColor
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

	[Category("Actions")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Orders - enable left")]
	public bool OrderActionLeftEnable
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[DisplayName("Orders - enable right")]
	[Category("Actions")]
	public bool OrderActionRightEnable
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Actions")]
	[DisplayName("Positions - enable left")]
	public bool PositionActionLeftEnable
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	[DisplayName("Positions - show SL/TP on left")]
	[Category("Actions")]
	public bool PositionActionLeftShowSLTP
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

	[DisplayName("Positions - show flat on left")]
	[Category("Actions")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public bool PositionActionLeftShowFlat
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

	[Category("Actions")]
	[DisplayName("Positions - enable right")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	public bool PositionActionRightEnable
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

	[Category("Actions")]
	[DisplayName("Positions - show SL/TP on right")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	public bool PositionActionRightShowSLTP
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

	[DisplayName("Positions - show flat on right")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7)]
	[Category("Actions")]
	public bool PositionActionRightShowFlat
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

	[Category("Ask Confirmations")]
	[DisplayName("OCO Group creation on SL/TP")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool AskConfirmOCOGroupCreationOnSLTP
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

	[Category("Ask Confirmations")]
	[DisplayName("Skip order price warning confirmation")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public bool AskConfirmSkipOrderPriceWarning
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[Description("Limit Color")]
	[Category("Buy Order")]
	public Color BuyLimitColor
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[Description("Stop Color")]
	[Category("Buy Order")]
	public Color BuyStopColor
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	[Category("Buy Order")]
	[Description("Stop Limit Color")]
	public Color BuyStopLimitColor
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

	[Category("Buy Order")]
	[Description("Filled Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public Color BuyMarketColor
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

	[Description("Bracket Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	[Category("Buy Order")]
	public Color BuyBracketColor
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
	[Description("Enter Arrow Color")]
	[Category("Buy Order")]
	public Color BuyEnterArrowColor
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 6)]
	[Description("Exit Arrow Color")]
	[Category("Buy Order")]
	public Color BuyExitArrowColor
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

	[Category("Sell Order")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[Description("Limit Color")]
	public Color SellLimitColor
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

	[Description("Stop Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	[Category("Sell Order")]
	public Color SellStopColor
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

	[Category("Sell Order")]
	[Description("Stop Limit Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public Color SellStopLimitColor
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

	[Category("Sell Order")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	[Description("Filled Color")]
	public Color SellMarketColor
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

	[Category("Sell Order")]
	[Description("Bracket Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
	public Color SellBracketColor
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
	[Description("Filled Arrow Color")]
	[Category("Sell Order")]
	public Color SellEnterArrowColor
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

	[Category("Sell Order")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6)]
	[Description("Exit Arrow Color")]
	public Color SellExitArrowColor
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

	[Category("Entry/Exit Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool EntryExitLinkLineEnable
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	[DisplayName("Buy - Line color")]
	[Category("Entry/Exit Line")]
	public Color EntryExitLinkLineBuyColor
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

	[Category("Entry/Exit Line")]
	[DisplayName("Sell - Line color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	public Color EntryExitLinkLineSellColor
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

	[DisplayName("Line width")]
	[Category("Entry/Exit Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	public int EntryExitLinkLineWidth
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

	[Category("Entry/Exit Line")]
	[DisplayName("Line style")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public DashStyle EntryExitLinkLineStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Entry/Exit Line")]
	[DisplayName("Show on top")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public bool EntryExitLinkForeground
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
	public ProfileDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProfileDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateRemoteProcessor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ProfileDriver RateEditor()
	{
		return null;
	}
}
