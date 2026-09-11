using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Management;
using VolAnalysis.Models;

namespace VolAnalysis.Wrapping;

internal class MixedWrapper
{
	internal enum GroupedInspectorRequesterType
	{
		Fixed,
		RiskStop,
		RiskTarget
	}

	[CompilerGenerated]
	private bool _IsWrapperTester;

	[CompilerGenerated]
	private GroupedInspectorRequesterType wrapperValue;

	[CompilerGenerated]
	private int m_AutomatedListAge;

	[CompilerGenerated]
	private bool m_IsCentralResponder;

	[CompilerGenerated]
	private bool m_IsWrapperEngine;

	[CompilerGenerated]
	private Color monoWrapper;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum _WrapperStub;

	[CompilerGenerated]
	private int _GeneralWrapperErrorCode;

	[CompilerGenerated]
	private bool m_IsIdentifiableWrapper;

	[CompilerGenerated]
	private Color _AdaptableWrapper;

	[CompilerGenerated]
	private OcoBracketStrategyModeEnum centralWrapper;

	[CompilerGenerated]
	private int m_VisibleObjectErrorCode;

	[CompilerGenerated]
	private bool m_IsHiddenWrapper;

	[CompilerGenerated]
	private bool _IsClientInspector;

	[CompilerGenerated]
	private bool m_IsListenerWrapper;

	[CompilerGenerated]
	private bool _IsWrapperResponder;

	[CompilerGenerated]
	private bool isScheduledPolicy;

	private static MixedWrapper WriteProcessor;

	[StaticStructAllocator(IsVisible = false)]
	public bool IsLong
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public GroupedInspectorRequesterType QuantityMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GroupedInspectorRequesterType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0, MaxValue = 2147483647.0)]
	[Category("General")]
	public int Quantity
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public bool EnableBackground
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Stop")]
	public bool EnableStop
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
	[Category("Stop")]
	public Color StopColor
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Stop")]
	public OcoBracketStrategyModeEnum StopMode
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("Stop")]
	public int StopValue
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

	[Category("Target")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool EnableTarget
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

	[Category("Target")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public Color TargetColor
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

	[Category("Target")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public OcoBracketStrategyModeEnum TargetMode
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("Target")]
	public int TargetValue
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[DisplayName("Entry")]
	[Category("Label")]
	public bool LabelShowEntry
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[DisplayName("Profit/Loss")]
	[Category("Label")]
	public bool LabelShowPnl
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	[DisplayName("Risk/Reward")]
	[Category("Label")]
	public bool LabelShowRR
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	[Category("Label")]
	[DisplayName("Price +/-")]
	public bool LabelShowPriceAbs
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

	[DisplayName("Price offset")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	[Category("Label")]
	public bool LabelShowPriceOffset
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
	public MixedWrapper GetSystem()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MixedWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MixedWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateCustomizableVerifier()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MixedWrapper AttachAutomatedProvider()
	{
		return null;
	}
}
