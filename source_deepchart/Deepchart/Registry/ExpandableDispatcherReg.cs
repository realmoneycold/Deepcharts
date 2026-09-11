using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class ExpandableDispatcherReg : DeciderAuthorizerNotifier
{
	[CompilerGenerated]
	private readonly SchemaDecryptor regCreator;

	private bool m_IsFilteredTransmitterReg;

	private tagDBBOOKMARK _JoinedInspector;

	private string? matcherSynchronizerName;

	private double? _ExternalTransaction;

	private double? _TokenWrapper;

	private double? simpleEvent;

	private double? m_FilterProc;

	private double? orderReg;

	private double? dispatcherWatcher;

	private double? detachedMemberReg;

	private double? setMonitorReg;

	private double? schemaMatcher;

	private double? scopeObjectReg;

	private double? sequentialClientReg;

	private double? m_RegAuthenticator;

	private double? m_RegHandler;

	private double? globalAttributeReg;

	private double? customSetReg;

	private double? _RegProject;

	internal static ExpandableDispatcherReg AttachSymbolicAttribute;

	public SchemaDecryptor AccountVieModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public bool Enabled
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

	public tagDBBOOKMARK Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (tagDBBOOKMARK)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string? ResumeIn
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

	public ConvertibleRequesterKinds? DailyLossColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? DailyLossLimitSet
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

	public double? DailyLossLimitCurrent
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

	public ConvertibleRequesterKinds? TrailLossColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? TrailLossLimitSet
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

	public double? TrailLossLimitCurrent
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

	public ConvertibleRequesterKinds? DailyProfitColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? DailyProfitLimitSet
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

	public double? DailyProfitLimitCurrent
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

	public ConvertibleRequesterKinds? PortfolioLossLimitColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? PortfolioLossLimitSet
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

	public double? PortfolioLossLimitCurrent
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

	public ConvertibleRequesterKinds? PortfolioGainLimitColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? PortfolioGainLimitCurrent
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

	public double? PortfolioGainLimitSet
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

	public ConvertibleRequesterKinds? PositionLossLimitColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? PositionLossLimitSet
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

	public double? PositionLossLimitCurrent
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

	public ConvertibleRequesterKinds? PositionGainLimitColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? PositionGainLimitSet
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

	public double? PositionGainLimitCurrent
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

	public ConvertibleRequesterKinds? MaxTradeCountColorStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public double? MaxTradeCountSet
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

	public double? MaxTradeCountCurrent
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
	public ExpandableDispatcherReg(SchemaDecryptor task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpandableDispatcherReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateConcreteBuilder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExpandableDispatcherReg TrackInterpreter()
	{
		return null;
	}
}
