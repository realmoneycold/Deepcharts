using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.Location;

internal class MapperConfiguration : LocatorRequest
{
	internal enum RegBILOP
	{
		None,
		TillInteraction,
		TillEndWindow
	}

	internal enum GeneratorTagMode
	{
		[Display(Name = "Multiple")]
		MultipleProfile,
		[Display(Name = "Latest")]
		LastsProfile
	}

	internal enum RegSocialAttachmentKind
	{
		Volume,
		Order,
		AggregateTrades,
		NumberOfTrades
	}

	internal enum StatelessDicEncryptor
	{
		Volume,
		AskBidVolume,
		Delta,
		DeltaAndTotalVolume,
		DeltaPercentage
	}

	internal enum LocatorStubAllocator
	{
		LeftRightBar,
		HighestLowest,
		AbsoluteReversal,
		TickReversal
	}

	internal enum VisualMapEncryptorState
	{
		Swing,
		[Display(Name = "VWap")]
		VWap
	}

	internal enum RegSolverVisitorKinds
	{
		ProfileAndLines,
		LinesOnly
	}

	[Serializable]
	internal struct RangeSettings
	{
		internal static object SolveRequest;

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("First Range")]
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

		[Category("Second Range")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
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

		[DisplayName("Value")]
		[Category("Second Range")]
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
		[Category("Second Range")]
		[DisplayName("Volume Color")]
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

		[DisplayName("Ask Color")]
		[Category("Second Range")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
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
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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

		[Category("Third Range")]
		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
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

		[Category("Third Range")]
		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
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

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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

		[DisplayName("Bid Color")]
		[Category("Fourth Range")]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		[DisplayName("Ask Color")]
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

		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
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
		internal static bool AttachAutomatedPoolTracer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateJoinedTracerPredictor()
		{
			return null;
		}
	}

	[Serializable]
	internal struct PeakValleySettings
	{
		internal static object IncludeListener;

		[Category("Peak")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
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

		[Category("Peak")]
		[DisplayName("Highlight")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
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

		[Category("Peak")]
		[DisplayName("Minimum Volume")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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
		[DisplayName("Highlight Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
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
		public RegBILOP PeakExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RegBILOP)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Peak")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 10.0)]
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
		[DisplayName("Line Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7)]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[Category("Valley")]
		[DisplayName("Enable")]
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

		[Category("Valley")]
		[DisplayName("Highlight")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
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

		[DisplayName("Maximum Volume")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0)]
		[Category("Valley")]
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

		[DisplayName("Show Line")]
		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
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
		public RegBILOP ValleyExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RegBILOP)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
		[DisplayName("Line Color")]
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

		[Category("Valley")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7, MaxValue = 10.0)]
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
		internal static bool ReceiveDistributor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateExpandableAllocatorTree()
		{
			return null;
		}
	}

	internal enum ConfigGenerator
	{
		Volume,
		Delta,
		DeltaPerc
	}

	[Serializable]
	internal struct ColorSettings
	{
		internal enum LocatorSubscriberDispatcherOptions
		{
			None,
			Fixed,
			FadingColor,
			MultipleColor
		}

		internal enum MonoProxyDecider
		{
			Automatic,
			UserDefined
		}

		internal static object MonitorEncryptor;

		[Category("General")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Color mode")]
		public LocatorSubscriberDispatcherOptions MethodColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (LocatorSubscriberDispatcherOptions)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("General")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		public ConfigGenerator ColorCalculation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (ConfigGenerator)(object)null;
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

		[Category("Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[Category("Range")]
		public MonoProxyDecider RangeDefining
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (MonoProxyDecider)(object)null;
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
		internal static bool GenerateInternalMemberProcessor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateAdjustableProcessorSender()
		{
			return null;
		}
	}

	[Serializable]
	internal struct TextSettings
	{
		internal static object GenerateInterruptibleSenderVisitor;

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
		internal static bool GenerateIterableVisitorDecryptor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectEnumerator()
		{
			return null;
		}
	}

	[Serializable]
	internal struct VWapDevSettings
	{
		internal static object PostSynchronizer;

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("First Envelope")]
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

		[Category("First Envelope")]
		[DisplayName("Std. Dev. Param")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[Category("First Envelope")]
		[DisplayName("Upper Color")]
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

		[DisplayName("Lower Color")]
		[Category("First Envelope")]
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

		[Category("Second Envelope")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
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

		[DisplayName("Upper Color")]
		[Category("Second Envelope")]
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

		[Category("Second Envelope")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
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

		[Category("Second Envelope")]
		[DisplayName("Envelope style")]
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

		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[DisplayName("Std. Dev. Param")]
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

		[Category("Third Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
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

		[Category("Third Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		[Category("Third Envelope")]
		[DisplayName("Line Width")]
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
		[DisplayName("Envelope style")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		[DisplayName("Enable")]
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

		[Category("Fourth Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
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

		[Category("Fourth Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
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

		[Category("Fourth Envelope")]
		[DisplayName("Line Width")]
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

		[Category("Fourth Envelope")]
		[DisplayName("Envelope style")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Fifth Envelope")]
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
		[Category("Fifth Envelope")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
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

		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
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

		[Category("Fifth Envelope")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
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

		[DisplayName("Envelope style")]
		[Category("Fifth Envelope")]
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
		internal static bool AttachLocalSelectorInitializer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CustomizeCalculator()
		{
			return null;
		}
	}

	internal enum RequesterTargetClass
	{
		Automatic,
		Manual
	}

	internal enum HtmlItemStyle
	{
		Automatic,
		PercentualPeriod,
		WindowWidth,
		FixedBars
	}

	internal enum ExplorerConsumerEncryptorOptions
	{
		Automatic,
		Solid,
		Hollow,
		Line,
		Combined
	}

	internal enum UserConsumerDeciderFlags
	{
		None,
		Show,
		Developing,
		ExtendShifted
	}

	private class EncryptorConsumerRole
	{
		public MapResponderLocator.EfficientStructRequester m_RoleFinderEncryptor;

		public RequesterTagExplorer[] templateFormatters;

		public bool _IsCustomTree;

		public bool m_IsEfficientProgram;

		public bool isTaskDriver;

		public bool isGroupedSorter;

		public bool isEncryptorFinderTokenizer;

		public RequesterTagExplorer transferableTransmitterEncryptor;

		public RequesterTagExplorer _TokenizerDistributorEncryptor;

		public bool m_IsListenerFactory;

		internal static EncryptorConsumerRole FilterSubscriber;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EncryptorConsumerRole()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EncryptorConsumerRole()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachScalableParameterProxy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static EncryptorConsumerRole GenerateVirtualProxySet()
		{
			return null;
		}
	}

	private class SeparatedConnectionDriver
	{
		public AllocatorCompilerEvent<EncryptorConsumerRole> m_StaticCollection;

		public bool _IsMixedDefinitionDriver;

		public int _CalculatorAuthenticatorPnts;

		public int localPredicateVal;

		public int m_ModularVisitorDriverIndex;

		public long literalClientDriverSize;

		public long m_OperationalChooserDriverCap;

		public int _DriverContainerLength;

		public long _ControllableComparatorDepth;

		public long tokenObserverPosition;

		public long m_DriverInspectorFreq;

		public int setAttributeDriverVol;

		public int specCollectionRank;

		public int _TransferableAnnotationDriverId;

		public int _GlobalDicDriverIdx;

		public int m_ActiveCalculatorDriverNum;

		public long m_SymbolicEmitterDriverOffset;

		public long remoteReceiverDriverDepth;

		public int m_EngineProviderPosition;

		public int m_RandomRequestDriverLimit;

		public int passiveListDriverId;

		public int _ModuleWorkerDist;

		public int automatableSchemaDriverLevel;

		public int m_DriverListenerRank;

		public int driverValidatorStep;

		public bool m_IsDriverStub;

		public double _GeneralSubscriberDriver;

		public double m_DriverCompressorAggregator;

		public int m_StatelessWorkerId;

		public int m_PortableResolverDriverSize;

		public long m_AuthenticatorFactoryRank;

		public long _DriverAggregatorSingletonVol;

		public long m_JoinedRecommenderPos;

		public long m_FunctionSorterId;

		public double _SingletonAuthorizerDriver;

		public double m_ModularRecommender;

		public bool m_IsEfficientParserDriver;

		public RequesterTagExplorer[] driverAuthorizerInitializers;

		public List<RequesterTagExplorer> editableStackDriverList;

		public RequesterTagExplorer dynamicConverterDriver;

		public RequesterTagExplorer _PublisherNode;

		public RequesterTagExplorer automatedServer;

		public RequesterTagExplorer driverInitializerChain;

		public RequesterTagExplorer joinedComparator;

		public RequesterTagExplorer _WorkerWrapper;

		public RequesterTagExplorer driverChainExecutor;

		public RequesterTagExplorer genericMapperDriver;

		public RequesterTagExplorer fieldSelector;

		public double m_FormatterTask;

		public int m_ExecutorAttributeAge;

		public double _ExpandableTrackerDriver;

		public double _SortedResponderDriver;

		private static SeparatedConnectionDriver PeekViewer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SeparatedConnectionDriver()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SeparatedConnectionDriver()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateLogicalServerModule()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SeparatedConnectionDriver MatchAttribute()
		{
			return null;
		}
	}

	private class DicDistributorRequester
	{
		public int[] m_IdentifiableWriterRequesterElements;

		public int[] requesterDistributorUsers;

		public Color[] globalInspectors;

		public Color[] virtualChooserRequesterArray;

		public Color[] m_ProgramRecordArray;

		public bool m_IsFinderChecker;

		public int _AdjustableAggregatorRequesterCounter;

		public bool isReporterTransmitter;

		public ConfigGenerator stackTag;

		public ColorSettings.LocatorSubscriberDispatcherOptions userResolverRequester;

		public ColorSettings.MonoProxyDecider m_RequesterResolverNode;

		internal static DicDistributorRequester PrepareBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DicDistributorRequester()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DicDistributorRequester()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSetValidatorReg()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DicDistributorRequester SimulateSortedRegFormatter()
		{
			return null;
		}
	}

	private class LocatorParameterManager
	{
		public double mixedConfiguration;

		public EncryptorCacheBuffer.Series_Prop m_FlexibleTransaction;

		public EncryptorCacheBuffer.Series_Prop m_LocatorAllocatorState;

		internal static LocatorParameterManager BuildManager;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocatorParameterManager()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LocatorParameterManager()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSequentialGatewayCompiler()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LocatorParameterManager GetProcessor()
		{
			return null;
		}
	}

	private enum AllocatorFinderProjectTypes
	{
		Not,
		Up,
		Down
	}

	private enum NodeTesterRequesterValues
	{
		Bid,
		Ask,
		Delta,
		Volume,
		DeltaPerc
	}

	private enum ScalableEventLocatorEnum
	{
		Volume,
		Bid,
		Ask
	}

	[CompilerGenerated]
	private StatelessDicEncryptor _RandomParserLocator;

	[CompilerGenerated]
	private VisualMapEncryptorState _AttachedAnnotation;

	[CompilerGenerated]
	private bool isControllableDictionary;

	[CompilerGenerated]
	private RegSolverVisitorKinds solverCollection;

	[CompilerGenerated]
	private LocatorStubAllocator m_SortedCollectionLocator;

	[CompilerGenerated]
	private double _ComparatorCompiler;

	[CompilerGenerated]
	private int m_LocatorAuditorAnnotationNum;

	[CompilerGenerated]
	private int locatorAnnotationMemberPerc;

	[CompilerGenerated]
	private bool _IsLocatorMemberCollector;

	[CompilerGenerated]
	private LocatorStubAllocator _CommonRunnerLocator;

	[CompilerGenerated]
	private double m_IntegratedComparatorLocator;

	[CompilerGenerated]
	private int combinedWorkerLocatorPosition;

	[CompilerGenerated]
	private int m_ConfigurableModuleLocatorRate;

	[CompilerGenerated]
	private int _LocatorCollectorFactoryValue;

	[CompilerGenerated]
	private int m_IsolatedClientLocatorPos;

	[CompilerGenerated]
	private int _DynamicVerifierLocatorFreq;

	[CompilerGenerated]
	private RegSocialAttachmentKind locatorFactoryDictionary;

	[CompilerGenerated]
	private int m_SpecResolverCount;

	[CompilerGenerated]
	private int m_LocatorDictionaryValidatorStep;

	[CompilerGenerated]
	private RequesterTargetClass m_ControllableErrorLocator;

	[CompilerGenerated]
	private int m_InitializerServiceIdx;

	[CompilerGenerated]
	private int m_ValidatorHandlerLocatorRate;

	[CompilerGenerated]
	private ColorSettings _VirtualPredictorLocator;

	[CompilerGenerated]
	private bool isCustomReporterLocator;

	[CompilerGenerated]
	private TextSettings _TransformablePredictor;

	[CompilerGenerated]
	private HtmlItemStyle m_HandlerSingletonLocator;

	[CompilerGenerated]
	private double resolverGatewayViewer;

	[CompilerGenerated]
	private int m_AlphabeticSystemLocatorVal;

	[CompilerGenerated]
	private double requesterResponder;

	[CompilerGenerated]
	private int locatorSingletonStackDepth;

	[CompilerGenerated]
	private int locatorStackModelPerc;

	[CompilerGenerated]
	private float controllableTokenizer;

	[CompilerGenerated]
	private int objectAuthenticatorOffset;

	[CompilerGenerated]
	private bool isThreadReg;

	[CompilerGenerated]
	private ExplorerConsumerEncryptorOptions m_LocatorModelSorter;

	[CompilerGenerated]
	private bool _IsControllableInspector;

	[CompilerGenerated]
	private bool isBasicListLocator;

	[CompilerGenerated]
	private bool isScalableSetLocator;

	[CompilerGenerated]
	private bool _IsMixedProvider;

	[CompilerGenerated]
	private bool isSorterRoleLocator;

	[CompilerGenerated]
	private Color _RolePublisherLocator;

	[CompilerGenerated]
	private UserConsumerDeciderFlags _LocatorPublisherEvaluator;

	[CompilerGenerated]
	private RegBILOP _ResponsiveRecordLocator;

	[CompilerGenerated]
	private Color _LocatorEvaluatorResolver;

	[CompilerGenerated]
	private int locatorResolverStubTotal;

	[CompilerGenerated]
	private TimeSpan _EditableEventLocator;

	[CompilerGenerated]
	private int m_CustomizableResolverValue;

	[CompilerGenerated]
	private int m_ConfigurationIteratorNum;

	[CompilerGenerated]
	private bool _IsModularReporter;

	[CompilerGenerated]
	private ResponsiveStructLocator m_ScheduledFormatterLocators;

	[CompilerGenerated]
	private bool isServiceAuditor;

	[CompilerGenerated]
	private bool _IsAutomatableGatewayLocator;

	[CompilerGenerated]
	private int _LocatorStubParameterIndex;

	[CompilerGenerated]
	private bool _IsLocatorParameterAllocator;

	[CompilerGenerated]
	private Color m_AuthenticatorAnnotation;

	[CompilerGenerated]
	private bool m_IsActiveStub;

	[CompilerGenerated]
	private bool isAlphabeticTracker;

	[CompilerGenerated]
	private RegBILOP _FlexibleStructLocator;

	[CompilerGenerated]
	private Color iteratorMember;

	[CompilerGenerated]
	private int allocatorManagerLocatorOffset;

	[CompilerGenerated]
	private bool isConnectedElementLocator;

	[CompilerGenerated]
	private bool m_IsRemoteEngineLocator;

	[CompilerGenerated]
	private int managerStateLocatorErrorCode;

	[CompilerGenerated]
	private bool isLocatorStatePredicate;

	[CompilerGenerated]
	private bool _IsLocatorPredicateArgument;

	[CompilerGenerated]
	private int locatorArgumentEnumeratorCounter;

	[CompilerGenerated]
	private Color _AnnotationSubscriber;

	[CompilerGenerated]
	private bool isJoinedWrapperLocator;

	[CompilerGenerated]
	private RegBILOP enumeratorConnectionLocator;

	[CompilerGenerated]
	private int _ConnectionExecutorLocatorPnts;

	[CompilerGenerated]
	private Color _AuditorCollector;

	[CompilerGenerated]
	private bool m_IsLocatorExecutorSubscriber;

	[CompilerGenerated]
	private int m_LocatorSubscriberMapSize;

	[CompilerGenerated]
	private Color locatorMapDispatcher;

	[CompilerGenerated]
	private bool _IsHandlerAnalyzer;

	[CompilerGenerated]
	private RegBILOP activeFinalizerLocator;

	[CompilerGenerated]
	private Color genericContextLocator;

	[CompilerGenerated]
	private int m_AnnotationFactorySize;

	[CompilerGenerated]
	private PeakValleySettings _DetachedChainLocator;

	[CompilerGenerated]
	private bool isDividedAnalyzer;

	[CompilerGenerated]
	private bool m_IsGroupedInspectorLocator;

	[CompilerGenerated]
	private Color locatorDispatcherResponder;

	[CompilerGenerated]
	private bool _IsExpandableInterpreterLocator;

	[CompilerGenerated]
	private bool m_IsIdentifiableDistributorLocator;

	[CompilerGenerated]
	private RegBILOP m_GeneralViewerLocator;

	[CompilerGenerated]
	private Color memberDictionary;

	[CompilerGenerated]
	private int _ResponderProxyLocatorPnts;

	[CompilerGenerated]
	private bool m_IsLocatorProxyOrder;

	[CompilerGenerated]
	private VWapDevSettings literalSenderLocator;

	[CompilerGenerated]
	private bool isOrderPolicyLocator;

	[CompilerGenerated]
	private bool _IsExternalProgramLocator;

	[CompilerGenerated]
	private bool isTransferableConsumerLocator;

	[CompilerGenerated]
	private Color _ProxyProc;

	[CompilerGenerated]
	private Color symbolicSharerLocator;

	[CompilerGenerated]
	private Color m_LocatorPolicyReceiver;

	private bool m_IsLocatorReceiverRecommender;

	private bool isFilterLogger;

	private string _TokenizerElementTitle;

	private List<SeparatedConnectionDriver> locatorRecommenderFilterList;

	private bool m_IsIterableBridgeLocator;

	private int _SeparatedTokenizerLocatorLevel;

	private int m_AttachedRequesterLocatorTotal;

	private int portableTokenizerCnt;

	private int m_InterruptibleCalculatorLocatorNum;

	private bool m_IsEfficientContext;

	private double m_FilterRegLocator;

	private int adjustableFieldLocatorPos;

	private bool m_IsConfigurableEvaluator;

	private int _LocatorRegWatcherPosition;

	private DateTime _RunnerTemplate;

	private bool m_IsVisualProject;

	private List<MapResponderLocator.GeneratorResponder> _LocatorWatcherRequestList;

	private int requestProfileLocatorDepth;

	private int m_GlobalPredictorErrorCode;

	private int m_ConverterCompressorLimit;

	private DicDistributorRequester m_LocatorProfileDecryptor;

	private Color _ScopeProcessorLocator;

	private long _LocatorDecryptorChooserLength;

	private DateTime m_LocatorChooserNode;

	private int m_LocatorNodeCreatorCnt;

	private int m_DetailedSynchronizerLocatorPosition;

	private int _OperationalEncryptorLocatorPosition;

	private bool m_IsLocatorCreatorProc;

	private int m_LocatorProcCommandDepth;

	private bool m_IsOrderedTagLocator;

	private int m_MonoDistributorLevel;

	private int collectorValidatorScore;

	private long mixedObserverLocatorCnt;

	private long m_ContextSorterDist;

	private LocatorStubAllocator m_CommandDeciderLocator;

	private int m_EditableInitializerAge;

	private double m_PortableMapperLocator;

	private double m_ProcStub;

	private long m_InternalInitializerLocatorPos;

	private AllocatorFinderProjectTypes m_LocatorDeciderServer;

	private double m_ListenerExecutor;

	private double m_TransformableValueLocator;

	private double m_LocatorServerCompiler;

	private double _ParameterMapper;

	private double _EditableMatcher;

	private double _ProjectVerifier;

	private int m_CompressorConnectionStep;

	private int locatorCompilerSpecFreq;

	private int m_SpecTransmitterLocatorIdx;

	private int _LocatorTransmitterBuilderIndex;

	private int _FactoryHandlerSize;

	private int locatorBuilderSolverInterval;

	private int advancedFormatterDist;

	private int _GlobalFunctionLocatorCnt;

	private bool m_IsStructArgument;

	private EncryptorCacheBuffer.Series_Prop _BuilderToken;

	private EncryptorCacheBuffer.Series_Prop hiddenExtractorLocator;

	private EncryptorCacheBuffer.Series_Prop _LocatorSolverFinder;

	private List<LocatorParameterManager> generalProfiles;

	private IMonoCalcViewer formatterSubscriber;

	private ExplorerConsumerEncryptorOptions m_SimpleNotifierLocator;

	[CompilerGenerated]
	private int _InterpreterManagerDist;

	internal static MapperConfiguration SerializeDefinition;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public StatelessDicEncryptor VbpType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (StatelessDicEncryptor)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public VisualMapEncryptorState LengthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VisualMapEncryptorState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Include reversal bar")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public bool SwingIncludeRevBar
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

	[Category("General")]
	[DisplayName("Display mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	public RegSolverVisitorKinds DisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegSolverVisitorKinds)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, SubCategory = "Main Swing Settings")]
	[Category("Swing Settings")]
	public LocatorStubAllocator SwingType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorStubAllocator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0, SubCategory = "Main Swing Settings")]
	[DisplayName("Abs. Rev")]
	[Category("Swing Settings")]
	public double SwingAbsParam
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0, SubCategory = "Main Swing Settings")]
	[Category("Swing Settings")]
	[DisplayName("Tick Rev./Highest Lowest")]
	public int SwingTickHLParam
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 2147483647.0, SubCategory = "Main Swing Settings")]
	[Category("Swing Settings")]
	[DisplayName("Right bar")]
	public int SwingRightBar
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, SubCategory = "Swing Stop Settings")]
	[Category("Swing Settings")]
	public bool EnableStopSwing
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5, SubCategory = "Swing Stop Settings")]
	[Category("Swing Settings")]
	public LocatorStubAllocator SwingStopType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorStubAllocator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Abs. Rev")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6, DecimalPosToShow = 2, MaxValue = 100.0, SubCategory = "Swing Stop Settings")]
	[Category("Swing Settings")]
	public double SwingStopAbsParam
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

	[Category("Swing Settings")]
	[DisplayName("Tick Rev./Highest Lowest")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7, MaxValue = 2147483647.0, SubCategory = "Swing Stop Settings")]
	public int SwingStopTickHLParam
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

	[DisplayName("Right bar")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 8, MaxValue = 2147483647.0, SubCategory = "Swing Stop Settings")]
	[Category("Swing Settings")]
	public int SwingStopRightBar
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

	[Category("VWap Swing")]
	[DisplayName("Swing min ticks")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MaxValue = 2147483647.0)]
	public int SwingVWapMinTicks
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

	[DisplayName("Swing max ticks")]
	[Category("VWap Swing")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int SwingVWapMaxTicks
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

	[Category("VWap Swing")]
	[DisplayName("VWap break ticks")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int SwingVWapBreakout
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0, SubCategory = "Data Settings")]
	[Category("Data Settings")]
	public RegSocialAttachmentKind InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegSocialAttachmentKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MinValue = 0.0, MaxValue = 2147483647.0, SubCategory = "Data Settings")]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2, MinValue = 0.0, MaxValue = 2147483647.0, SubCategory = "Data Settings")]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3, SubCategory = "Tick grouping")]
	public RequesterTargetClass AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RequesterTargetClass)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4, MinValue = 1.0, SubCategory = "Tick grouping")]
	[Category("Data Settings")]
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5, MinValue = 1.0, MaxValue = 600.0, SubCategory = "Tick grouping")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0, SubCategory = "Background/Text")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, SubCategory = "Background/Text")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2, SubCategory = "Background/Text")]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3, SubCategory = "Width/Offset", DefaultCollapsed = 1)]
	public HtmlItemStyle WidthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HtmlItemStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Current Width")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4, MaxValue = 500.0, SubCategory = "Width/Offset")]
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

	[Category("Plot Settings")]
	[DisplayName("Current Offset")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5, MaxValue = 500.0, SubCategory = "Width/Offset")]
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6, MaxValue = 500.0, SubCategory = "Width/Offset")]
	[Category("Plot Settings")]
	[DisplayName("Previous Width")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 7, MaxValue = 500.0, SubCategory = "Width/Offset")]
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 8, MaxValue = 100.0, SubCategory = "Visual Appearance", DefaultCollapsed = 1)]
	[Category("Plot Settings")]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 9, MaxValue = 6.0, DecimalPosToShow = 2, IncrementValue = 0.5, SubCategory = "Visual Appearance")]
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 10, MinValue = 1.0, MaxValue = 1000.0, SubCategory = "Visual Appearance")]
	[Category("Plot Settings")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 11, SubCategory = "Visual Appearance")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 12, SubCategory = "Visual Appearance")]
	public ExplorerConsumerEncryptorOptions VisualStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ExplorerConsumerEncryptorOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 13, SubCategory = "Visual Appearance")]
	[Category("Plot Settings")]
	[DisplayName("Align to the right ")]
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 14, SubCategory = "Visual Appearance")]
	[DisplayName("Mirroring")]
	[Category("Plot Settings")]
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
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 15, SubCategory = "Visual Appearance")]
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
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, SubCategory = "POC")]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, SubCategory = "POC")]
	[Category("Point of Control")]
	[DisplayName("Highlight")]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2, SubCategory = "POC")]
	[DisplayName("Highlight Color")]
	[Category("Point of Control")]
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

	[Category("Point of Control")]
	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, SubCategory = "POC")]
	public UserConsumerDeciderFlags PocLineMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (UserConsumerDeciderFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Point of Control")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4, SubCategory = "POC")]
	public RegBILOP PocExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegBILOP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Line Color")]
	[Category("Point of Control")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5, SubCategory = "POC")]
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
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6, SubCategory = "POC")]
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
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 7, SubCategory = "POC")]
	[DisplayName("Dev. Poc Start Time")]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 8, SubCategory = "POC")]
	[DisplayName("Shifted Poc Tick Grouping")]
	[Category("Point of Control")]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 9, MaxValue = 100.0, SubCategory = "POC")]
	[DisplayName("Opacity Poc Grouping")]
	[Category("Point of Control")]
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

	[DisplayName("Enable Alert")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 10, SubCategory = "Alert Shift Poc")]
	[Category("Point of Control")]
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
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 11, SubCategory = "Alert Shift Poc", IsAlert = true)]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 12, SubCategory = "Alert Shift Poc")]
	[Category("Point of Control")]
	[DisplayName("Message Popup")]
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

	[Category("Value Area")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, MaxValue = 100.0)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	[DisplayName("Highlight")]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	[Category("Value Area")]
	[DisplayName("Outside Color")]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
	[DisplayName("Developing")]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 6)]
	[DisplayName("Extend Line")]
	[Category("Value Area")]
	public RegBILOP VAExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegBILOP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 7)]
	[DisplayName("Line Color")]
	[Category("Value Area")]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 8, MaxValue = 10.0)]
	[DisplayName("Line Width")]
	[Category("Value Area")]
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0, SubCategory = "General")]
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
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1, SubCategory = "General")]
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
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2, MaxValue = 1000.0, SubCategory = "General")]
	[DisplayName("Sensitivity")]
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3, MaxValue = 1000.0, SubCategory = "General")]
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 4, SubCategory = "Peak", DefaultCollapsed = 1)]
	[DisplayName("Highlight")]
	[Category("Peak And Valley")]
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

	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 5, MaxValue = 2147483647.0, SubCategory = "Peak")]
	[DisplayName("Minimum Volume")]
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 6, SubCategory = "Peak")]
	[DisplayName("Highlight Color")]
	[Category("Peak And Valley")]
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 7, SubCategory = "Peak")]
	[Category("Peak And Valley")]
	[DisplayName("Show Line")]
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 8, SubCategory = "Peak")]
	[Category("Peak And Valley")]
	[DisplayName("Extend Line")]
	public RegBILOP PeakExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegBILOP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Peak And Valley")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 9, MaxValue = 10.0, SubCategory = "Peak")]
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

	[Category("Peak And Valley")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 10, SubCategory = "Peak")]
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 11, SubCategory = "Valley", DefaultCollapsed = 1)]
	[Category("Peak And Valley")]
	[DisplayName("Highlight")]
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
	[DisplayName("Maximum Volume")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 12, MaxValue = 2147483647.0, SubCategory = "Valley")]
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

	[Category("Peak And Valley")]
	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 13, SubCategory = "Valley")]
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

	[Category("Peak And Valley")]
	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 14, SubCategory = "Valley")]
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

	[Category("Peak And Valley")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 15, SubCategory = "Valley")]
	public RegBILOP ValleyExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegBILOP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Peak And Valley")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 16, SubCategory = "Valley")]
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

	[Category("Peak And Valley")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 17, MaxValue = 10.0, SubCategory = "Valley")]
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

	[Category("Peak And Valley")]
	[DisplayName("Appearance")]
	[StaticStructAllocator(IsVisible = false)]
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
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0, SubCategory = "VWAP")]
	[DisplayName("Enable")]
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1, SubCategory = "VWAP")]
	[DisplayName("Highlight")]
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

	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 2, SubCategory = "VWAP")]
	[Category("VWAP")]
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
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 3, SubCategory = "VWAP")]
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
	[DisplayName("Developing VWAP")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 4, SubCategory = "VWAP")]
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

	[Category("VWAP")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 5, SubCategory = "VWAP")]
	public RegBILOP VwapExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegBILOP)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 6, SubCategory = "VWAP")]
	[Category("VWAP")]
	[DisplayName("Line Color")]
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

	[Category("VWAP")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 7, SubCategory = "VWAP")]
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

	[Category("VWAP")]
	[DisplayName("Envelope Enabled")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 8, SubCategory = "Envelopes")]
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 9, SubCategory = "Envelopes")]
	[DisplayName("Envelope Settings")]
	[Category("VWAP")]
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

	[Category("Summary")]
	[DisplayName("Enable Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 0)]
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

	[Category("Summary")]
	[DisplayName("Volume Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 1)]
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

	[DisplayName("Trade Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 2)]
	[Category("Summary")]
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

	[Category("Summary")]
	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 3)]
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

	[Category("Summary")]
	[DisplayName("Ask Color")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 4)]
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
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 5)]
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
	static MapperConfiguration()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fda3ec9e68d948bab93a408edb4fbf43 != 0)
		{
			num = 4;
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555731));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F506AE5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E42D0D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -1589802056 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3785A7E9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3785A117 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator.m_ActiveEngineLocatorPosition);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapperConfiguration(ScopeEncryptor.HiddenModelDecider item, MapResponderLocator.TransformableUserEncryptor pol, int dir_Z)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isident, bool countcol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PatchCalc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindAutomatableController(int config, bool containsvisitor, double serv, Color config2, Color res3, int column_visitor4, DashStyle ident5)
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
	private void IdentifyCombinedModel(ColorSettings reference, DicDistributorRequester attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool appendres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NodeTesterRequesterValues SortMap(int setup_X)
	{
		return (NodeTesterRequesterValues)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterTagExplorer IdentifyIdentifiableFilter(int info, int remove_CUSTAt, int remove_PROCAt, bool rejectinstance2, int maxinfo3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EncryptorConsumerRole SendSubscriber(int idxdef, int attr, int endfield, bool excludeconnection2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int FindAdjustableInitializer(int start_reference, int vis_Ptr, bool servclose)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyInterruptibleResponder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyIterableAuthorizer(int lengthlast, double ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CalcAdapter(AllocatorFinderProjectTypes info, double cont, int ID_pool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddAttribute(DateTime key, DateTime vis, int consumer_high, int flags_def2, bool iscounter3, bool usecaller4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindLocalValue(MapResponderLocator.GeneratorResponder asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator init, bool isresult, MapResponderLocator.TokenParameterViewer comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyConfigurableTracker(SingletonHandlerConnection.ObjectAuthenticatorLocator v, bool ignoreb, MapResponderLocator.TokenParameterViewer proc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EncryptorConsumerRole FindMixedList(int idx_config, int row_ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer IdentifyScheduledLocator(double task, Color reg, int start_tag, bool isitem2 = true, bool allowinfo3 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer IdentifyMonoVerifier(Color key, bool forcevis = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyExternalProvider(int start_info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindAccessibleParser(MapResponderLocator.GeneratorResponder res, int cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExcludeVisitor(SeparatedConnectionDriver setup, out int pred, out int state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyAdaptablePublisher(int key_min, int flagsreg, bool deletedic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearRandomParameter(int item_length, bool loadcaller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QuerySelector(int first_ID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool assetneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveInitializer(SeparatedConnectionDriver v, MapResponderLocator.EfficientStructRequester map, out bool dir, out bool attr2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindDividedServer(SeparatedConnectionDriver first, EncryptorConsumerRole ivk, NodeTesterRequesterValues dir, out ScalableEventLocatorEnum last2, out long map3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ClearIsolatedModule(int[] item, long row_cust)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color OpenService(SeparatedConnectionDriver key, EncryptorConsumerRole cust, NodeTesterRequesterValues dir, int insert_SETUP2At, DicDistributorRequester t3, out bool second4, out int cust5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CombineSchema(int indexOf_key, DicDistributorRequester result)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyVirtualReg(int columnparam, bool custneeded, out double dic, out double caller2, out double def3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CallTracker(bool isreference, int vis, bool readpool)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyLogicalGateway(MapResponderLocator.GeneratorResponder reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool comparespec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeLocator(bool isreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool stripconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearResponsivePolicy(int def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateIntegratedSetServer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MapperConfiguration GenerateStaticServerModule()
	{
		return null;
	}
}
