using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.DecisionMaking;

internal class PassiveTrackerDecider : LocatorRequest
{
	internal enum IsolatedConnectionRegValues
	{
		None,
		TillInteraction,
		TillEndWindow
	}

	internal enum LocatorCodeMarkerEvent
	{
		[Display(Name = "Composite")]
		AllBars,
		[Display(Name = "Multiple")]
		MultipleProfile,
		[Display(Name = "Visible")]
		VisibleBars,
		[Display(Name = "Custom")]
		CustomTime,
		[Display(Name = "Latest")]
		LastsProfile
	}

	internal enum SimplePredictorViewer
	{
		Minute,
		Days,
		Weeks,
		Months,
		Volume
	}

	internal enum GeneratorCellTreeOpType
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggregateTrades,
		NumberOfTrades,
		[Display(Name = "Number Orders (MBO)")]
		NumberOrders
	}

	internal enum ViewerCompressorBuilderValues
	{
		Volume,
		AskBidVolume,
		Delta,
		DeltaAndTotalVolume,
		DeltaPercentage
	}

	internal enum SeparatedStateReg
	{
		LeftRightBar,
		HighestLowest,
		AbsoluteReversal,
		TickReversal
	}

	internal enum GlyphFontSizingType
	{
		No,
		Dash,
		Solid
	}

	[Serializable]
	internal struct RangeSettings
	{
		private static object SimulateCustomBufferMonitor;

		[Category("First Range")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		public bool EnableRange0
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

		[Category("First Range")]
		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		public Color VolumeColor1
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[DisplayName("Bid Color")]
		[Category("First Range")]
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
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[DisplayName("Enable")]
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
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
		[DisplayName("Value")]
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
		[DisplayName("Volume Color")]
		[Category("Second Range")]
		public Color VolumeColor2
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

		[Category("Second Range")]
		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[DisplayName("Ask Color")]
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[Category("Third Range")]
		[DisplayName("Enable")]
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

		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
		[Category("Third Range")]
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

		[Category("Third Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[DisplayName("Volume Color")]
		public Color VolumeColor3
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

		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Fourth Range")]
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

		[DisplayName("Value")]
		[Category("Fourth Range")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 2147483647.0)]
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
		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
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
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		[DisplayName("Volume Color")]
		[Category("Fourth Range")]
		public Color VolumeColor4
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
		internal static bool GenerateAttachedMonitorState()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachBasicStateArgument()
		{
			return null;
		}
	}

	[Serializable]
	internal struct PeakValleySettings
	{
		private static object AttachOperationalArgumentConsumer;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Peak")]
		public bool PeakEnable
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[DisplayName("Highlight")]
		[Category("Peak")]
		public bool PeakHighlight
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
		[Category("Peak")]
		[DisplayName("Minimum Volume")]
		public int PeakMinVol
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

		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		[DisplayName("Highlight Color")]
		public Color PeakBackColor
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
		[DisplayName("Show Line")]
		[Category("Peak")]
		public bool PeakLineEnable
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

		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		[DisplayName("Extend Line")]
		public IsolatedConnectionRegValues PeakExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (IsolatedConnectionRegValues)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 10.0)]
		[Category("Peak")]
		[DisplayName("Line Width")]
		public int PeakLineWidth
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

		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7)]
		[DisplayName("Line Color")]
		public Color PeakLineColor
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

		[Category("Valley")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		public bool ValleyEnable
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

		[DisplayName("Highlight")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		[Category("Valley")]
		public bool ValleyHighlight
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0)]
		[Category("Valley")]
		[DisplayName("Maximum Volume")]
		public int ValleyMaxVol
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

		[Category("Valley")]
		[DisplayName("Highlight Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		public Color ValleyBackColor
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

		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[DisplayName("Show Line")]
		public bool ValleyLineEnabled
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

		[DisplayName("Extend Line")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
		[Category("Valley")]
		public IsolatedConnectionRegValues ValleyExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (IsolatedConnectionRegValues)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Valley")]
		[DisplayName("Line Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
		public Color ValleyLineColor
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7, MaxValue = 10.0)]
		[DisplayName("Line Width")]
		[Category("Valley")]
		public int ValleyLineWidth
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetPeakMin(int value)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PeakValleySettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateFlexibleConsumerTemplate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FlushViewer()
		{
			return null;
		}
	}

	internal enum LocatorEntityCreationStatus
	{
		Volume,
		Delta,
		DeltaPerc
	}

	[Serializable]
	internal struct ColorSettings
	{
		internal enum LocatorConnectionSubscriberState
		{
			None,
			Fixed,
			FadingColor,
			MultipleColor
		}

		internal enum LocatorExecutorMapKind
		{
			Automatic,
			UserDefined
		}

		internal static object AttachAutomatedEvaluatorPool;

		[Category("General")]
		[DisplayName("Color mode")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		public LocatorConnectionSubscriberState MethodColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (LocatorConnectionSubscriberState)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("General")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		public LocatorEntityCreationStatus ColorCalculation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (LocatorEntityCreationStatus)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		public Color FixedVolColor
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

		[Category("Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		public Color FixedBidColor
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

		[Category("Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public Color FixedAskColor
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[Category("Color")]
		public Color FixedLineColor
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

		[Category("Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		public LocatorExecutorMapKind RangeDefining
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (LocatorExecutorMapKind)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
		public RangeSettings Range
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RangeSettings)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ColorSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BuildStream()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PresentManager()
		{
			return null;
		}
	}

	[Serializable]
	internal struct TextSettings
	{
		private static object GetMember;

		[Category("Settings")]
		[StaticStructAllocator(DecimalPosToShow = 2, IncrementValue = 0.2, MaxValue = 50.0)]
		public float FontSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Color")]
		public Color FixedBidColor
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

		[Category("Color")]
		public Color FixedAskColor
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

		[Category("Color")]
		public Color FixedVolColor
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
		static TextSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RemoveProcessor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateAutomatableAllocatorTree()
		{
			return null;
		}
	}

	[Serializable]
	internal struct VWapDevSettings
	{
		internal static object GenerateCombinedTreeGenerator;

		[Category("First Envelope")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		public bool W1_Enabled
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[Category("First Envelope")]
		[DisplayName("Std. Dev. Param")]
		public double W1_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("First Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		public Color W1_UpperColor
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

		[Category("First Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		public Color W1_LowerColor
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

		[Category("First Envelope")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
		public int W1_LineWidth
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

		[Category("First Envelope")]
		[DisplayName("Envelope style")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		public DashStyle W1_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Second Envelope")]
		public bool W2_Enabled
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[Category("Second Envelope")]
		[DisplayName("Std. Dev. Param")]
		public double W2_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Second Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public Color W2_UpperColor
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

		[Category("Second Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		public Color W2_LowerColor
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[Category("Second Envelope")]
		[DisplayName("Line Width")]
		public int W2_LineWidth
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

		[DisplayName("Envelope style")]
		[Category("Second Envelope")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
		public DashStyle W2_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Third Envelope")]
		public bool W3_Enabled
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

		[DisplayName("Std. Dev. Param")]
		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		public double W3_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[DisplayName("Upper Color")]
		[Category("Third Envelope")]
		public Color W3_UpperColor
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
		[Category("Third Envelope")]
		[DisplayName("Lower Color")]
		public Color W3_LowerColor
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

		[Category("Third Envelope")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		public int W3_LineWidth
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

		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
		[DisplayName("Envelope style")]
		public DashStyle W3_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		[Category("Fourth Envelope")]
		public bool W4_Enabled
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

		[Category("Fourth Envelope")]
		[DisplayName("Std. Dev. Param")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		public double W4_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		[Category("Fourth Envelope")]
		public Color W4_UpperColor
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
		[DisplayName("Lower Color")]
		[Category("Fourth Envelope")]
		public Color W4_LowerColor
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

		[DisplayName("Line Width")]
		[Category("Fourth Envelope")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		public int W4_LineWidth
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
		[Category("Fourth Envelope")]
		[DisplayName("Envelope style")]
		public DashStyle W4_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fifth Envelope")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
		[DisplayName("Enable")]
		public bool W5_Enabled
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[DisplayName("Std. Dev. Param")]
		[Category("Fifth Envelope")]
		public double W5_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
		[Category("Fifth Envelope")]
		public Color W5_UpperColor
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
		[DisplayName("Lower Color")]
		[Category("Fifth Envelope")]
		public Color W5_LowerColor
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
		[Category("Fifth Envelope")]
		[DisplayName("Line Width")]
		public int W5_LineWidth
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

		[Category("Fifth Envelope")]
		[DisplayName("Envelope style")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
		public DashStyle W5_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VWapDevSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachGroupedGeneratorRunner()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ScanDefinition()
		{
			return null;
		}
	}

	internal enum WrapperRenameItemCompletionResult
	{
		Automatic,
		Manual
	}

	internal enum WriterVsTaskWaitOptions
	{
		Automatic,
		PercentualPeriod,
		WindowWidth,
		FixedBars
	}

	internal enum FilteredReporterDeciderTypes
	{
		Automatic,
		Solid,
		Hollow,
		Line,
		Combined
	}

	internal enum RegRecordAuditorFlags
	{
		None,
		Show,
		Developing,
		ExtendShifted
	}

	internal enum EmfPlusFlags
	{
		None,
		Filter,
		Splitted,
		Triple
	}

	internal enum HidUsagePage
	{
		Rth,
		Custom,
		Eth
	}

	private class WriterBridge
	{
		public DateTime _TesterPredictor;

		public int _LiteralFieldWriterNum;

		public int poolProviderCounter;

		internal static WriterBridge InsertServer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WriterBridge()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WriterBridge()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateIsolatedParserProgram()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WriterBridge AttachSeparatedProgramPublisher()
		{
			return null;
		}
	}

	private class DeciderCompilerTokenizer
	{
		public MapResponderLocator.EfficientStructRequester deciderCacheContainer;

		public RequesterTagExplorer[] _SequentialVerifierDeciders;

		public bool _IsProgramSynchronizer;

		public bool m_IsDeciderTokenizerTransmitter;

		public bool isDeciderContainerFilter;

		public bool _IsDeciderTransmitterAttribute;

		public bool isFlexibleRecommenderDecider;

		public RequesterTagExplorer _FilterCollectorDecider;

		public RequesterTagExplorer m_DeciderAttributeSharer;

		public bool _IsParameterTree;

		internal static DeciderCompilerTokenizer GenerateScalablePublisherParameter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeciderCompilerTokenizer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DeciderCompilerTokenizer()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachVirtualParameterProxy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DeciderCompilerTokenizer ResetFormatter()
		{
			return null;
		}
	}

	private class AllocatorMatcherAuditor
	{
		public DateTime generalAdapterAllocator;

		public DateTime _SorterDictionary;

		public AllocatorCompilerEvent<DeciderCompilerTokenizer> m_SegmentedInitializerAllocator;

		public bool isProgramTransmitter;

		public int _AllocatorCacheCommandIndex;

		public int _SortedTaskAllocatorRate;

		public int m_ExternalDefinitions;

		public long m_AllocatorAuditorFormatterIndex;

		public long m_SharerGeneratorDepth;

		public int _AllocatorCommandProgramStep;

		public long _SetContainerAllocatorSize;

		public long m_LocalProfileAllocatorNum;

		public long m_ExplorerRunnerSize;

		public int m_AllocatorFormatterEditorErrorCode;

		public int _TemplateFilterOffset;

		public int m_AllocatorProgramDispatcherSize;

		public int m_BasicListAllocatorIdx;

		public int m_JoinedProviderAllocatorIndex;

		public int allocatorEditorVerifierCount;

		public int m_StaticControllerAllocatorLevel;

		public long _FilteredLoggerAllocatorInterval;

		public long _TransformableStructAllocatorLength;

		public int validatorFilterPerc;

		public int virtualEncryptorAllocatorErrorCode;

		public int externalRecordAllocatorStep;

		public int m_OrderedPredictorDepth;

		public int m_DispatcherStrategyAllocatorInterval;

		public int _AlphabeticPredictorAllocatorVal;

		public int allocatorVerifierHandlerErrorCode;

		public bool isStrategyTransformerAllocator;

		public double iterableWrapperAllocator;

		public double _IdentifiableModuleAllocator;

		public int m_VisualDictionaryAllocatorId;

		public int m_OperationalCalculatorAllocatorFlag;

		public long _SortedProfilerCount;

		public long _AttachedRoleAllocators;

		public long _ResponsiveArgumentAllocatorScore;

		public long allocatorHandlerManagerCount;

		public double combinedTemplateAllocator;

		public double receiverLogger;

		public bool isOrderNotifier;

		public LogicalStateEncryptor advancedCompressorAllocator;

		public MapNotifier _EfficientFieldAllocator;

		public RequesterTagExplorer[] m_AccessibleMonitorAllocatorData;

		public List<RequesterTagExplorer> _AllocatorTransformerProcessorList;

		public RequesterTagExplorer m_OrderedParserAllocator;

		public RequesterTagExplorer m_AllocatorManagerReg;

		public RequesterTagExplorer allocatorProcessorFinalizer;

		public RequesterTagExplorer _AllocatorRegModel;

		public RequesterTagExplorer _AllocatorFinalizerFactory;

		public RequesterTagExplorer _AutomatedConnectionAllocator;

		public RequesterTagExplorer m_AllocatorModelReceiver;

		public RequesterTagExplorer factoryProfilerAllocator;

		public RequesterTagExplorer _AllocatorReceiverEnumerator;

		public double configurableInspectorAllocator;

		public int viewerBuilderCacheCnt;

		public double m_ParameterAggregator;

		public double _AllocatorProfilerExecutor;

		public RequesterTagExplorer _CentralLocatorAllocator;

		public RequesterTagExplorer m_AllocatorEnumeratorFinder;

		public int? _DefinitionWatcher;

		public int? _AllocatorExecutorStream;

		private static AllocatorMatcherAuditor SerializeGateway;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllocatorMatcherAuditor()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllocatorMatcherAuditor()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DisableCompiler()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllocatorMatcherAuditor SimulateResponsiveModuleDecorator()
		{
			return null;
		}
	}

	private class VisibleRegDecider
	{
		public int[] deciderCollectorUsers;

		public int[] detachedViewerDeciderItems;

		public Color[] m_DistributorObjectData;

		public Color[] _IterableFieldDeciderItems;

		public Color[] _ManagerGatewayItems;

		public bool _IsCentralDictionaryDecider;

		public int compressorResponderErrorCode;

		public bool isAutomatableSchemaDecider;

		public LocatorEntityCreationStatus deciderSharerWrapper;

		public ColorSettings.LocatorConnectionSubscriberState remoteNodeDecider;

		public ColorSettings.LocatorExecutorMapKind m_SingletonSharer;

		internal static VisibleRegDecider PlanSorter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VisibleRegDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VisibleRegDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VisitContainer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VisibleRegDecider CheckInspector()
		{
			return null;
		}
	}

	private class WrapperObject
	{
		public double resolverWrapper;

		public EncryptorCacheBuffer.Series_Prop wrapperConverter;

		public EncryptorCacheBuffer.Series_Prop m_AlphabeticWatcher;

		internal static WrapperObject InstantiateTransaction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperObject()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperObject()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AssembleError()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperObject SimulateGenericCompilerPolicy()
		{
			return null;
		}
	}

	private enum WdCalendarType
	{
		Bid,
		Ask,
		Delta,
		Volume,
		DeltaPerc
	}

	private enum SingletonServiceKind
	{
		Volume,
		Bid,
		Ask
	}

	[CompilerGenerated]
	private ViewerCompressorBuilderValues m_IdentifiablePredictor;

	[CompilerGenerated]
	private LocatorCodeMarkerEvent _FunctionLocator;

	[CompilerGenerated]
	private SimplePredictorViewer m_ConvertibleAuditorWriter;

	[CompilerGenerated]
	private int segmentedAdapterDeciderCounter;

	[CompilerGenerated]
	private DateTime _DeciderValidatorValue;

	[CompilerGenerated]
	private DateTime _AlphabeticMemberDecider;

	[CompilerGenerated]
	private GeneratorCellTreeOpType deciderValueAnnotation;

	[CompilerGenerated]
	private int _AttachedProgramDeciderAge;

	[CompilerGenerated]
	private int m_AnnotationTracerDeciderLength;

	[CompilerGenerated]
	private WrapperRenameItemCompletionResult m_DeciderTracerTree;

	[CompilerGenerated]
	private int attachedTesterStep;

	[CompilerGenerated]
	private int m_DeciderTreeBuilderCounter;

	[CompilerGenerated]
	private ColorSettings _DeciderBuilderTester;

	[CompilerGenerated]
	private bool m_IsReadableProcessor;

	[CompilerGenerated]
	private TextSettings m_ParserProxy;

	[CompilerGenerated]
	private WriterVsTaskWaitOptions scalableDispatcherDecider;

	[CompilerGenerated]
	private double _TokenizerFilter;

	[CompilerGenerated]
	private int m_ControllableProcValue;

	[CompilerGenerated]
	private double deciderTesterHandler;

	[CompilerGenerated]
	private int sortedConnectionDeciderScore;

	[CompilerGenerated]
	private int m_DynamicStackDeciderAge;

	[CompilerGenerated]
	private int m_BasicValidatorDeciderValue;

	[CompilerGenerated]
	private float m_ClientReporter;

	[CompilerGenerated]
	private bool _IsDeciderHandlerWriter;

	[CompilerGenerated]
	private FilteredReporterDeciderTypes _DeciderWriterEncryptor;

	[CompilerGenerated]
	private bool isElementChecker;

	[CompilerGenerated]
	private bool isLiteralValueDecider;

	[CompilerGenerated]
	private bool isViewerEmitterResolver;

	[CompilerGenerated]
	private bool m_IsLocalAnnotationDecider;

	[CompilerGenerated]
	private bool _IsEncryptorAggregatorDecider;

	[CompilerGenerated]
	private Color dividedTracerDecider;

	[CompilerGenerated]
	private RegRecordAuditorFlags m_DeciderAggregatorInterpreter;

	[CompilerGenerated]
	private IsolatedConnectionRegValues _DefinitionController;

	[CompilerGenerated]
	private Color scopeTreeDecider;

	[CompilerGenerated]
	private int m_DeciderInterpreterCalculatorIdx;

	[CompilerGenerated]
	private TimeSpan m_UserRunner;

	[CompilerGenerated]
	private int m_VisualBuilderDeciderPerc;

	[CompilerGenerated]
	private int _SimpleTesterDeciderFreq;

	[CompilerGenerated]
	private bool isConcreteHandlerDecider;

	[CompilerGenerated]
	private ResponsiveStructLocator deciderCalculatorInspectorList;

	[CompilerGenerated]
	private bool isDeciderInspectorFactory;

	[CompilerGenerated]
	private bool isJoinedWriterDecider;

	[CompilerGenerated]
	private int m_ActiveTransactionInterval;

	[CompilerGenerated]
	private bool _IsIdentifiableEncryptorDecider;

	[CompilerGenerated]
	private Color m_FactoryEventDecider;

	[CompilerGenerated]
	private bool _IsCompressorTransaction;

	[CompilerGenerated]
	private GlyphFontSizingType m_DeciderEventListener;

	[CompilerGenerated]
	private IsolatedConnectionRegValues annotationChooser;

	[CompilerGenerated]
	private Color _IntegratedInspector;

	[CompilerGenerated]
	private int _DeciderListenerCompilerFlag;

	[CompilerGenerated]
	private bool _IsAdvancedAggregatorDecider;

	[CompilerGenerated]
	private bool isProxyParser;

	[CompilerGenerated]
	private bool isDeciderCompilerCache;

	[CompilerGenerated]
	private int _DeciderCacheTokenizerPosition;

	[CompilerGenerated]
	private bool _IsAdaptableInterpreterDecider;

	[CompilerGenerated]
	private bool _IsAttributeAuditor;

	[CompilerGenerated]
	private bool isDeciderTokenizerContainer;

	[CompilerGenerated]
	private int m_DeciderContainerTransmitterPosition;

	[CompilerGenerated]
	private Color _ModularSynchronizer;

	[CompilerGenerated]
	private bool _IsSenderProject;

	[CompilerGenerated]
	private IsolatedConnectionRegValues m_AuditorTag;

	[CompilerGenerated]
	private int m_DeciderTransmitterFilterNum;

	[CompilerGenerated]
	private Color m_AutomatableProfile;

	[CompilerGenerated]
	private bool isContainerAttribute;

	[CompilerGenerated]
	private bool _IsExpandableCalculatorDecider;

	[CompilerGenerated]
	private int m_ScheduledStackStep;

	[CompilerGenerated]
	private Color m_DeciderFilterAttribute;

	[CompilerGenerated]
	private bool m_IsDeciderAttributeCollector;

	[CompilerGenerated]
	private IsolatedConnectionRegValues deciderCollectorSharer;

	[CompilerGenerated]
	private Color runnerLocator;

	[CompilerGenerated]
	private int _SolverTrackerScore;

	[CompilerGenerated]
	private bool m_IsGroupedInspectorDecider;

	[CompilerGenerated]
	private Color dictionaryResolver;

	[CompilerGenerated]
	private int _AdjustableFactoryDeciderLimit;

	[CompilerGenerated]
	private DashStyle identifiableEngine;

	[CompilerGenerated]
	private int _SegmentedRequestTotal;

	[CompilerGenerated]
	private PeakValleySettings deciderSharerUser;

	[CompilerGenerated]
	private bool m_IsExpandableAdapter;

	[CompilerGenerated]
	private bool isRandomEventDecider;

	[CompilerGenerated]
	private Color _DeciderUserWrapper;

	[CompilerGenerated]
	private bool _IsExtendedListenerDecider;

	[CompilerGenerated]
	private bool _IsStaticCompilerDecider;

	[CompilerGenerated]
	private IsolatedConnectionRegValues _DeciderWrapperConsumer;

	[CompilerGenerated]
	private Color memberObserver;

	[CompilerGenerated]
	private int _PredicateSetRank;

	[CompilerGenerated]
	private DashStyle m_ObjectManager;

	[CompilerGenerated]
	private bool m_IsTransmitterCollector;

	[CompilerGenerated]
	private VWapDevSettings _FilterSharer;

	[CompilerGenerated]
	private DashStyle m_DeciderConsumerWorker;

	[CompilerGenerated]
	private bool _IsWorkerCollectionDecider;

	[CompilerGenerated]
	private bool m_IsReadableCacheDecider;

	[CompilerGenerated]
	private bool m_IsCollectionThreadDecider;

	[CompilerGenerated]
	private Color m_DeciderThreadMatcher;

	[CompilerGenerated]
	private Color _ConvertibleAuthenticatorDecider;

	[CompilerGenerated]
	private Color _AggregatorTemplate;

	[CompilerGenerated]
	private EmfPlusFlags m_ExternalSingletonDecider;

	[CompilerGenerated]
	private HidUsagePage _AttributeUser;

	[CompilerGenerated]
	private TimeSpan m_AuthorizerStrategy;

	[CompilerGenerated]
	private TimeSpan calcTask;

	[CompilerGenerated]
	private bool m_IsLiteralSolver;

	private bool _IsEditableParserDecider;

	private bool m_IsAnnotationFunction;

	private string _VirtualAllocatorDeciderTitle;

	private List<AllocatorMatcherAuditor> generalConverterDeciderList;

	private bool isSortedPredicate;

	private int deciderMatcherDecoratorIndex;

	private int deciderDecoratorCompressorInterval;

	private int filteredControllerDeciderDepth;

	private int deciderCompressorDicAge;

	private bool _IsSequentialTaskDecider;

	private double _FlexibleReporterDecider;

	private int userWorkerPnts;

	private bool m_IsInspectorPublisher;

	private int m_VisibleVerifierDeciderDist;

	private int m_AuthenticatorComparatorTotal;

	private DateTime deciderDicRequester;

	private bool m_IsRequestAggregator;

	private List<MapResponderLocator.GeneratorResponder> genericExplorerList;

	private int _ServerFormatterFlag;

	private int _DetachedRecommenderDeciderRate;

	private int _IterableRegDeciderVol;

	private VisibleRegDecider _CommonStack;

	private Color m_CentralViewerDecider;

	private long _ExtendedTokenizerDepth;

	private DateTime deciderRequesterEmitter;

	private int automatableFieldDeciderPos;

	private int _SharerStackIndex;

	private int deciderEmitterSenderId;

	private bool _IsRemoteDictionaryDecider;

	private int _DeciderSenderDeciderRank;

	private bool m_IsAttributeParameter;

	private bool isDeciderProviderDecider;

	private int _ConsumerThreadInterval;

	private int m_WorkerMatcherAge;

	private TimeSpan deciderProviderRequest;

	private TimeSpan m_CreatorConsumer;

	private long m_FilterElementPosition;

	private long _DeciderRequestConfigurationCap;

	private bool _IsDeciderConfigurationCreator;

	private EncryptorCacheBuffer.Series_Prop m_SetState;

	private EncryptorCacheBuffer.Series_Prop m_RegSpecSubscriber;

	private EncryptorCacheBuffer.Series_Prop collectionDecorator;

	private List<WrapperObject> threadCompressors;

	private IMonoCalcViewer _BasicExecutor;

	private FilteredReporterDeciderTypes _SenderInterpreter;

	private HashSet<DateTime> _RunnerSolver;

	private List<WriterBridge> _DeciderCreatorProfilers;

	[CompilerGenerated]
	private int m_ConnectedHandlerCount;

	internal static PassiveTrackerDecider GenerateBasicProgramPublisher;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, SubCategory = "Typology")]
	public ViewerCompressorBuilderValues VbpType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerCompressorBuilderValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, SubCategory = "Typology")]
	public LocatorCodeMarkerEvent VbpPeriod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorCodeMarkerEvent)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, SubCategory = "Typology")]
	public SimplePredictorViewer LengthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SimplePredictorViewer)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MinValue = 1.0, MaxValue = 1800000.0, SubCategory = "Typology")]
	public int LengthValue
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, ShowLongDateTimeFormat = true, SubCategory = "Custom Date/Time")]
	[DisplayName("Start Date/Time")]
	[Category("General")]
	public DateTime IniCustomDt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, ShowLongDateTimeFormat = true, SubCategory = "Custom Date/Time")]
	[DisplayName("End Date/Time")]
	public DateTime EndCustomDt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, SubCategory = "Data Settings")]
	public GeneratorCellTreeOpType InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorCellTreeOpType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MinValue = 0.0, MaxValue = 2147483647.0, SubCategory = "Data Settings")]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MinValue = 0.0, MaxValue = 2147483647.0, SubCategory = "Data Settings")]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, SubCategory = "Tick grouping")]
	public WrapperRenameItemCompletionResult AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WrapperRenameItemCompletionResult)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, MinValue = 1.0, SubCategory = "Tick grouping")]
	public int AutoGroupFactory
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5, MinValue = 1.0, MaxValue = 600.0, SubCategory = "Tick grouping")]
	public int ManualTicks
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, SubCategory = "Background/Text")]
	public ColorSettings Background
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ColorSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, SubCategory = "Background/Text")]
	public bool ShowText
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, SubCategory = "Background/Text")]
	public TextSettings Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TextSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, SubCategory = "Width/Offset", DefaultCollapsed = 1)]
	[Category("Plot Settings")]
	public WriterVsTaskWaitOptions WidthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WriterVsTaskWaitOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Current Width")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, MaxValue = 500.0, SubCategory = "Width/Offset")]
	public double WidthCurrLength
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5, MaxValue = 500.0, SubCategory = "Width/Offset")]
	[DisplayName("Current Offset")]
	[Category("Plot Settings")]
	public int VbpCurrOffset
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
	[DisplayName("Previous Width")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6, MaxValue = 500.0, SubCategory = "Width/Offset")]
	public double WidthPrevLength
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

	[Category("Plot Settings")]
	[DisplayName("Previous Offset")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7, MaxValue = 500.0, SubCategory = "Width/Offset")]
	public int VbpPrevOffset
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 8, MinValue = 0.0, MaxValue = 1000.0, SubCategory = "Visual Appearance", DefaultCollapsed = 1)]
	public int NumberOfProfile
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 9, MaxValue = 100.0, SubCategory = "Visual Appearance")]
	public int VbpOpacity
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 10, MaxValue = 6.0, DecimalPosToShow = 2, IncrementValue = 0.5, SubCategory = "Visual Appearance")]
	[Category("Plot Settings")]
	public float BorderWidth
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 11, SubCategory = "Visual Appearance")]
	public bool ShowAboveBars
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 12, SubCategory = "Visual Appearance")]
	public FilteredReporterDeciderTypes VisualStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FilteredReporterDeciderTypes)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Align to the right ")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 13, SubCategory = "Visual Appearance")]
	public bool ShowOnTheRight
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
	[DisplayName("Mirroring")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 14, SubCategory = "Visual Appearance")]
	public bool AlignToRight
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 15, SubCategory = "Visual Appearance")]
	public bool AlwaysVisible
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

	[Category("Point of Control")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0, SubCategory = "POC")]
	public bool PocEnable
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

	[Category("Point of Control")]
	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, SubCategory = "POC")]
	public bool PocHighlight
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

	[Category("Point of Control")]
	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2, SubCategory = "POC")]
	public Color PocBackColor
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

	[DisplayName("Show Line")]
	[Category("Point of Control")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3, SubCategory = "POC")]
	public RegRecordAuditorFlags PocLineMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegRecordAuditorFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4, SubCategory = "POC")]
	[Category("Point of Control")]
	public IsolatedConnectionRegValues PocExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedConnectionRegValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Point of Control")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5, SubCategory = "POC")]
	public Color PocLineColor
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

	[Category("Point of Control")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 6, SubCategory = "POC")]
	public int PocLineWidth
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

	[Category("Point of Control")]
	[DisplayName("Dev. Poc Start Time")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 7, SubCategory = "POC")]
	public TimeSpan PocDevStartTime
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 8, SubCategory = "POC")]
	[Category("Point of Control")]
	[DisplayName("Shifted Poc Tick Grouping")]
	public int ShiftPocTick
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

	[Category("Point of Control")]
	[DisplayName("Opacity Poc Grouping")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 9, MaxValue = 100.0, SubCategory = "POC")]
	public int PocGroupOpacity
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

	[Category("Point of Control")]
	[DisplayName("Enable Alert")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 10, SubCategory = "Alert Shift Poc")]
	public bool EnableShiftPocAlert
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

	[Category("Point of Control")]
	[DisplayName("Alert Sound")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 11, SubCategory = "Alert Shift Poc", IsAlert = true)]
	public ResponsiveStructLocator ShiftPocAlert
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

	[Category("Point of Control")]
	[DisplayName("Message Popup")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 12, SubCategory = "Alert Shift Poc")]
	public bool EnableShiftPocPopup
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[Category("Value Area")]
	[DisplayName("Enable")]
	public bool VAEnable
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

	[Category("Value Area")]
	[DisplayName("% Value Area")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 100.0)]
	public int VAPerc
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

	[Category("Value Area")]
	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public bool VAHighlight
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

	[Category("Value Area")]
	[DisplayName("Outside Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	public Color VABackColor
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

	[Category("Value Area")]
	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
	public bool VAShowLine
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

	[Category("Value Area")]
	[DisplayName("Developing")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
	public GlyphFontSizingType VADeveloping2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GlyphFontSizingType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Value Area")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6)]
	public IsolatedConnectionRegValues VAExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedConnectionRegValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Value Area")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 7)]
	public Color VALineColor
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

	[Category("Value Area")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 8, MaxValue = 10.0)]
	public int VALineWidth
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

	[Category("Hidden")]
	[StaticStructAllocator(IsVisible = false)]
	public bool VADeveloping
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, SubCategory = "General")]
	public bool PeakEnable
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, SubCategory = "General")]
	public bool ValleyEnable
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

	[Category("Peak And Valley")]
	[DisplayName("Sensitivity")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2, MaxValue = 1000.0, SubCategory = "General")]
	public int PVSensitivity
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, MaxValue = 1000.0, SubCategory = "General")]
	[Category("Peak And Valley")]
	[DisplayName("Exclude High/Low")]
	public bool PVExcludeHL
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

	[Category("Peak And Valley")]
	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4, SubCategory = "Peak", DefaultCollapsed = 1)]
	public bool PeakHighlight
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5, SubCategory = "Peak")]
	[DisplayName("Filter outside Value Area")]
	[Category("Peak And Valley")]
	public bool PeakOnlyOutsideVA
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

	[Category("Peak And Valley")]
	[DisplayName("Minimum Volume")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6, MaxValue = 2147483647.0, SubCategory = "Peak")]
	public int PeakMinVol
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

	[Category("Peak And Valley")]
	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 7, SubCategory = "Peak")]
	public Color PeakBackColor
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

	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 8, SubCategory = "Peak")]
	[Category("Peak And Valley")]
	public bool PeakLineEnable
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

	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 9, SubCategory = "Peak")]
	[Category("Peak And Valley")]
	public IsolatedConnectionRegValues PeakExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedConnectionRegValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Peak And Valley")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 10, MaxValue = 10.0, SubCategory = "Peak")]
	public int PeakLineWidth
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 11, SubCategory = "Peak")]
	[DisplayName("Line Color")]
	[Category("Peak And Valley")]
	public Color PeakLineColor
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

	[Category("Peak And Valley")]
	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 12, SubCategory = "Valley", DefaultCollapsed = 1)]
	public bool ValleyHighlight
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

	[Category("Peak And Valley")]
	[DisplayName("Filter outside Value Area")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 13, SubCategory = "Valley")]
	public bool ValleyOnlyOutsideVA
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

	[DisplayName("Maximum Volume")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 14, MaxValue = 2147483647.0, SubCategory = "Valley")]
	[Category("Peak And Valley")]
	public int ValleyMaxVol
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 15, SubCategory = "Valley")]
	[Category("Peak And Valley")]
	[DisplayName("Highlight Color")]
	public Color ValleyBackColor
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

	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 16, SubCategory = "Valley")]
	[Category("Peak And Valley")]
	public bool ValleyLineEnabled
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 17, SubCategory = "Valley")]
	[DisplayName("Extend Line")]
	[Category("Peak And Valley")]
	public IsolatedConnectionRegValues ValleyExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedConnectionRegValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 18, SubCategory = "Valley")]
	[DisplayName("Line Color")]
	[Category("Peak And Valley")]
	public Color ValleyLineColor
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 19, MaxValue = 10.0, SubCategory = "Valley")]
	[DisplayName("Line Width")]
	[Category("Peak And Valley")]
	public int ValleyLineWidth
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 20, SubCategory = "Business zone", DefaultCollapsed = 1)]
	[Category("Peak And Valley")]
	[DisplayName("Enable")]
	public bool PVBusinessZoneEnable
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

	[Category("Peak And Valley")]
	[DisplayName("Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 21, SubCategory = "Business zone")]
	public Color PVBusinessZoneColor
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
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 22, SubCategory = "Business zone")]
	[Category("Peak And Valley")]
	public int PVBusinessZoneLineWidth
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 23, SubCategory = "Business zone")]
	[DisplayName("Background")]
	[Category("Peak And Valley")]
	public DashStyle PVBusinessZoneLineStyle
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 24, SubCategory = "Business zone", MaxValue = 100.0)]
	[DisplayName("Opacity (%)")]
	public int PVBusinessZoneOpacity
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

	[StaticStructAllocator(IsVisible = false)]
	[DisplayName("Appearance")]
	[Category("Peak And Valley")]
	public PeakValleySettings PVSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PeakValleySettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("VWAP")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0, SubCategory = "VWAP")]
	public bool VwapEnable
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

	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, SubCategory = "VWAP")]
	[Category("VWAP")]
	public bool VwapHighlight
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

	[Category("VWAP")]
	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2, SubCategory = "VWAP")]
	public Color VwapBackColor
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

	[Category("VWAP")]
	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3, SubCategory = "VWAP")]
	public bool VwapShowLine
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

	[Category("VWAP")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4, SubCategory = "VWAP")]
	[DisplayName("Developing VWAP")]
	public bool ShowDevVwap
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5, SubCategory = "VWAP")]
	[DisplayName("Extend Line")]
	[Category("VWAP")]
	public IsolatedConnectionRegValues VwapExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IsolatedConnectionRegValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Line Color")]
	[Category("VWAP")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 6, SubCategory = "VWAP")]
	public Color VwapLineColor
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 7, SubCategory = "VWAP")]
	[DisplayName("Line Width")]
	[Category("VWAP")]
	public int VwapLineWidth
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 8, SubCategory = "VWAP")]
	[DisplayName("Line style")]
	[Category("VWAP")]
	public DashStyle VwapLineStyle
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 9, SubCategory = "Envelopes")]
	[DisplayName("Envelope Enabled")]
	[Category("VWAP")]
	public bool VWapEnvEnabled
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 10, SubCategory = "Envelopes")]
	[Category("VWAP")]
	[DisplayName("Envelope Settings")]
	public VWapDevSettings VWapEnvSett
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VWapDevSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("VWAP")]
	[DisplayName("Envelope style")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 11, SubCategory = "Envelopes")]
	public DashStyle VWapEnvelopeStyle
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	[DisplayName("Enable Summary")]
	[Category("Summary")]
	public bool SummaryEnable
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1)]
	[Category("Summary")]
	[DisplayName("Volume Summary")]
	public bool SummaryEnableVolume
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

	[Category("Summary")]
	[DisplayName("Trade Summary")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	public bool SummaryEnableNumTrade
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3)]
	[DisplayName("Text Color")]
	[Category("Summary")]
	public Color SummaryTextColor
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
	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 4)]
	public Color SummaryAskColor
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

	[Category("Summary")]
	[DisplayName("Bid Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 5)]
	public Color SummaryBidColor
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

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 8, PropertyIndex = 0)]
	[DisplayName("Filter Mode")]
	[Category("Filter/Split time")]
	public EmfPlusFlags FilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EmfPlusFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Filter/Split time")]
	[DisplayName("Filter Time")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 8, PropertyIndex = 1)]
	public HidUsagePage FilterTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HidUsagePage)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Filter/Split time")]
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 8, PropertyIndex = 2, DefaultCollapsed = 1)]
	public TimeSpan IniSession
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

	[Category("Filter/Split time")]
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 8, PropertyIndex = 3)]
	public TimeSpan EndSession
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

	[Category("Filter/Split time")]
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 8, PropertyIndex = 4)]
	public bool UseEndSessionAsStartDay
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

	[StaticStructAllocator(IsVisible = false)]
	[Category("Hidden")]
	public bool CustomOnLastBar
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

	[Category("Hidden")]
	[StaticStructAllocator(IsVisible = false)]
	public string DrawingUserName
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

	[Category("Hidden")]
	[StaticStructAllocator(IsVisible = false)]
	public string MergeProfileStr
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

	private bool IsProfileChartView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool IsSomethingDev
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool IsSomethingExtended
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public int Version
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
	static PassiveTrackerDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001f;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 1;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_00c16e707ebf4bec83c8b759d6aa24e6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0056;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_0056;
				IL_0056:
				WrapperStreamEditor.PresentConfiguration();
				WriterCommandResolver.ReflectDefinitionSelector();
				Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555701));
				MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(--1765916663 ^ 0x408BD50D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30A5ACC6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64), MapResponderLocator.BasicRecordReg.Volume);
				sortedPublisherWrapper.SetList(new List<string>
				{
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x78190E1B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eca23e1b791747c78ba1f3f94ba21ecf),
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C0D80 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80),
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x72712783 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659)
				});
				DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts, strippred2: false, isinit3: false, isinit4: true);
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveTrackerDecider(ScopeEncryptor.HiddenModelDecider var1, MapResponderLocator.TransformableUserEncryptor caller, int statelow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreAdvancedQueue(int insert_SPECAt, int? pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureTransformableTransaction(int previous_spec, int? second, object filter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveConsumer(int nextvalue, int? pol, object dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeTemplate(int item_offset, int? result, object comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int DecideDetailedMatcher(DateTime info)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int DetermineVisualReporter(DateTime def)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool excludesetup, bool addord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanTokenizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string DetermineActiveProc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineFilteredIterator(int v_High, bool noattr, double template, Color item2, Color def3, int visitor4X, DashStyle init5)
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
	private void DeterminePortablePredicate(ColorSettings last, VisibleRegDecider reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private WdCalendarType DecideSymbolicExplorer(int param_Position)
	{
		return (WdCalendarType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterTagExplorer EvaluateTransformer(int offsetspec, int position_b, int num_consumer, bool issecond2, int maxcfg3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DeciderCompilerTokenizer DetermineCentralSystem(int version_init, int caller, int rule_start, bool ivk2install)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int RestartTree(int specPtr, int ivk_max, bool isconsumer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EnsureOrderedComparator(DateTime init)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideAlphabeticStrategy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CollectProject(DateTime setup, DateTime caller, int idxcontrol, int def2_max, bool var13needed, bool reference4reguired)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator info, bool isb, MapResponderLocator.TokenParameterViewer util)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineCommonHandler(SingletonHandlerConnection.ObjectAuthenticatorLocator setup, bool comparereg, MapResponderLocator.TokenParameterViewer field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DeciderCompilerTokenizer DetermineControllableContext(int param, int attrhigh)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer StoreController(int versionparam, double attr, double control, Color ord2, int res3_Low, Color res4, bool caller5stop, bool doparam6, DashStyle ord7 = DashStyle.Dash)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DetermineEfficientMonitor(double asset, Color attr, int util_Ptr, bool isreg2, bool acceptivk3, DashStyle vis4 = DashStyle.Dash)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DetermineTransferableState(Color var1, bool extractsecond = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewFilter(int flagsinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideGlobalConsumer(MapResponderLocator.GeneratorResponder def, int nextpred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MergeConverter(AllocatorMatcherAuditor value, out int pol, out int temp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureExtendedTag(int previous_init, int vis_Position, bool ignoretag, bool stripivk2, bool iscont3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchFactory(int i_Position, bool isconnection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideAttachedTokenizer(int info_length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideBasicEvaluator(AllocatorMatcherAuditor setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecideOperationalPool(AllocatorMatcherAuditor ident, MapResponderLocator.EfficientStructRequester map, out bool util, out bool config2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetNode(AllocatorMatcherAuditor last, DeciderCompilerTokenizer token, WdCalendarType helper, out SingletonServiceKind first2, out long cont3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int SerializeAuditor(int[] res, long connection_offset)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color DisableAuthenticator(AllocatorMatcherAuditor init, DeciderCompilerTokenizer visitor, WdCalendarType tag, int info2_offset, VisibleRegDecider counter3, out bool spec4, out int reference5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineStaticAllocator(int task_start, VisibleRegDecider vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineCustomizableTree(int taskhigh, bool havesecond, out double third, out double config2, out double col3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VisitSummarizer(bool verifyident, int startpred, bool excludepool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureJoinedRunner(MapResponderLocator.GeneratorResponder item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool outputtask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureConvertibleProject(bool checkkey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool defopen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssembleStack(int insert_INFOAt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateOperationalPublisherParameter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PassiveTrackerDecider AttachFlexibleParameterProxy()
	{
		return null;
	}
}
