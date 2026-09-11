using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.Location;

internal class StatelessCalcLocator
{
	internal enum RunnerCheckerKinds
	{
		None,
		Volume,
		Delta,
		DeltaAndTotalVolume,
		BidAskVolume
	}

	internal enum EncryptorFunctionSymbolFields
	{
		Daily,
		Resettable
	}

	internal enum DriverRelativeLocation
	{
		Volume,
		NumberTrades
	}

	internal enum AllocatorErrorSet
	{
		Volume,
		Delta,
		Imbalance
	}

	[Serializable]
	internal struct RangeSettings
	{
		internal static object GetDefinition;

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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[DisplayName("Volume Color")]
		[Category("First Range")]
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

		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
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

		[DisplayName("Ask Color")]
		[Category("First Range")]
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
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[DisplayName("Enable")]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
		[Category("Second Range")]
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

		[Category("Second Range")]
		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
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

		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
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

		[DisplayName("Volume Color")]
		[Category("Third Range")]
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

		[Category("Third Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		[DisplayName("Ask Color")]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
		[Category("Fourth Range")]
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		[Category("Fourth Range")]
		[DisplayName("Ask Color")]
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

		[Category("Fourth Range")]
		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
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
		internal static bool RemoveSelector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateSimpleMatcherReporter()
		{
			return null;
		}
	}

	[Serializable]
	internal struct PeakValleySettings
	{
		internal static object DetachResponder;

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
		[DisplayName("Minimum Volume")]
		[Category("Peak")]
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

		[DisplayName("Show Line")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
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

		[DisplayName("Line Width")]
		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 10.0)]
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
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6)]
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

		[DisplayName("Enable")]
		[Category("Valley")]
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

		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		[DisplayName("Highlight")]
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
		[DisplayName("Maximum Volume")]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[DisplayName("Highlight Color")]
		[Category("Valley")]
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

		[Category("Valley")]
		[DisplayName("Line Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
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
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6, MaxValue = 10.0)]
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
		static PeakValleySettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachVisualTransmitterProc()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateStatelessProcIterator()
		{
			return null;
		}
	}

	[Serializable]
	internal struct ColorSettings
	{
		internal enum EncryptorAuditorCacheFlags
		{
			None,
			Fixed,
			FadingColor,
			MultipleColor
		}

		internal enum EncryptorLineBreaks
		{
			Automatic,
			UserDefined
		}

		private static object AttachActiveIteratorPredicate;

		[Category("General")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		public EncryptorAuditorCacheFlags MethodColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (EncryptorAuditorCacheFlags)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[Category("General")]
		public AllocatorErrorSet ColorCalculation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (AllocatorErrorSet)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("General")]
		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 2)]
		[DisplayName("Min. Vol. Diff. for Imbalance")]
		public int MinimumDifferenceImbalance
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

		[Category("General")]
		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 3)]
		public bool IncludeZeroOnImbalance
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

		[Category("General")]
		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 4)]
		public bool ColorOnlyDominantSide
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		[DisplayName("Background Inferior Side")]
		[Category("General")]
		public Color ColorInferiorSide
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

		[Category("Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		public EncryptorLineBreaks RangeDefining
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (EncryptorLineBreaks)(object)null;
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
		internal static bool ControlValue()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GeneratePortableExplorerSpec()
		{
			return null;
		}
	}

	[Serializable]
	internal struct TextSettings
	{
		internal static object RunList;

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
		internal static bool SimulateConcreteSystemProfiler()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachCentralProfilerComparator()
		{
			return null;
		}
	}

	internal enum WrapperRetargetingLaunchScenario
	{
		Automatic,
		Manual
	}

	internal enum RequesterProcessorType
	{
		Automatic,
		Normal
	}

	private class CreatorBufferAllocator
	{
		public MapResponderLocator.EfficientStructRequester m_AllocatorSetMapper;

		public RequesterTagExplorer[] _BufferSolverAllocators;

		public bool m_IsGlobalAuditorAllocator;

		public bool _IsConcreteCommandAllocator;

		public bool isAllocatorMapperAuthorizer;

		public bool isAllocatorSolverSpec;

		public bool isHiddenFormatterAllocator;

		internal static CreatorBufferAllocator StoreSet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorBufferAllocator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CreatorBufferAllocator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RateServer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CreatorBufferAllocator AttachTransferableArgumentConsumer()
		{
			return null;
		}
	}

	private class CombinedThreadSingleton
	{
		public AllocatorCompilerEvent<CreatorBufferAllocator> _ControllerLogger;

		public bool _IsSeparatedStrategySingleton;

		public int _SingletonProcessorPerc;

		public int requestFilterPosition;

		public int _SingletonExecutorVal;

		public long _MonoGeneratorSingletonAge;

		public long m_SingletonEditorCnt;

		public int m_SchemaSingletonPerc;

		public long clientSingletonAge;

		public long _ControllableInterpreterSingletonIdx;

		public long m_MatcherStructFreq;

		public int m_TracerDispatcherTotal;

		public int creatorStubPos;

		public int _IdentifiableSummarizerLevel;

		public long _ConnectedDispatcherSingletons;

		public long m_MixedTesterStep;

		public int m_ProcessorInspectorLength;

		public int m_SingletonListenerIndex;

		public int m_GeneralWrapperSingletonFlag;

		public int m_TransferableInitializerStep;

		public int _TrackerChainOffset;

		public bool m_IsSetComparator;

		public long m_SelectorObjectEncryptorIndex;

		public long m_NotifierArgumentDist;

		public int specContainerSize;

		public int _SynchronizerFactoryVal;

		public RequesterTagExplorer singletonTagProc;

		public RequesterTagExplorer m_DynamicQueueSingleton;

		public RequesterTagExplorer detailedSummarizerSingleton;

		public RequesterTagExplorer operationalConfigurationSingleton;

		public RequesterTagExplorer _ProcSpecSingleton;

		public RequesterTagExplorer _StatelessProxy;

		private static CombinedThreadSingleton SimulateLiteralConsumerTemplate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombinedThreadSingleton()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CombinedThreadSingleton()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateGlobalTemplateTag()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CombinedThreadSingleton AttachDetachedTagChecker()
		{
			return null;
		}
	}

	private class ScheduledErrorDecider
	{
		public int[] accessibleAuthenticators;

		public int[] modularExecutorDeciderData;

		public Color[] m_DeciderDecoratorDicElements;

		public Color[] _ElementStackElements;

		public Color[] deciderCompressorRequesterElements;

		public bool _IsEfficientInspector;

		public int _GlobalModuleDeciderLength;

		public bool _IsDeciderDicEmitter;

		public ColorSettings.EncryptorAuditorCacheFlags m_DeciderRequesterSender;

		public ColorSettings.EncryptorLineBreaks _PortableAttributeRequester;

		internal static ScheduledErrorDecider InsertFormatter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ScheduledErrorDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ScheduledErrorDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateCustomTokenizerEvaluator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ScheduledErrorDecider SimulateAttachedEvaluatorPool()
		{
			return null;
		}
	}

	private class WrapperContainerSingleton
	{
		public AllocatorCompilerEvent<MapResponderLocator.EfficientStructRequester> orderedProxyWrapper;

		public int _WrapperSingletonParameterValue;

		public int _SimpleCollectorWrapperStep;

		public double efficientConfigWrapper;

		private static WrapperContainerSingleton GenerateBasicPoolTracer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperContainerSingleton()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperContainerSingleton()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LoadSorter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperContainerSingleton AttachFlexiblePredictorTransformer()
		{
			return null;
		}
	}

	private enum AllocatorDistributionPointInfo
	{
		Bid,
		Ask,
		Delta,
		Volume
	}

	private enum DeciderRelativeHeaderPosition
	{
		Volume,
		Bid,
		Ask,
		None
	}

	[CompilerGenerated]
	private EncryptorFunctionSymbolFields customizableEmitterLocator;

	[CompilerGenerated]
	private DriverRelativeLocation _SequentialAttributeLocator;

	[CompilerGenerated]
	private RunnerCheckerKinds setAggregatorLocator;

	[CompilerGenerated]
	private WrapperRetargetingLaunchScenario m_LocatorDicThread;

	[CompilerGenerated]
	private int _VisualBufferLocatorAge;

	[CompilerGenerated]
	private int locatorThreadTokenPos;

	[CompilerGenerated]
	private ColorSettings m_SenderProcessor;

	[CompilerGenerated]
	private bool isAdvancedProjectLocator;

	[CompilerGenerated]
	private TextSettings m_StackRole;

	[CompilerGenerated]
	private RequesterProcessorType mapperProfile;

	[CompilerGenerated]
	private int locatorTokenExplorerTotal;

	[CompilerGenerated]
	private int _LocatorExplorerUserCap;

	[CompilerGenerated]
	private bool _IsLocatorUserProfiler;

	[CompilerGenerated]
	private bool m_IsLocatorProfilerLogger;

	[CompilerGenerated]
	private bool _IsAdaptableDecoratorLocator;

	[CompilerGenerated]
	private Color _LocatorLoggerTransformer;

	[CompilerGenerated]
	private bool isLocatorTransformerSummarizer;

	[CompilerGenerated]
	private Color _StaticMatcherLocator;

	[CompilerGenerated]
	private int _AccessibleAdapterLocatorValue;

	[CompilerGenerated]
	private bool _IsLocatorSummarizerController;

	[CompilerGenerated]
	private int _ModularTaskLocatorFreq;

	[CompilerGenerated]
	private bool _IsLocalMember;

	[CompilerGenerated]
	private Color m_ConvertibleCheckerLocator;

	[CompilerGenerated]
	private bool isEfficientAuthorizerLocator;

	[CompilerGenerated]
	private Color _MonoTracerLocator;

	[CompilerGenerated]
	private int locatorConfigConverterCount;

	[CompilerGenerated]
	private int m_AutomatedParserLocatorIndex;

	[CompilerGenerated]
	private PeakValleySettings modelPublisher;

	[CompilerGenerated]
	private bool isFieldLogger;

	[CompilerGenerated]
	private Color _LocatorControllerValue;

	[CompilerGenerated]
	private Color m_AggregatorTransaction;

	[CompilerGenerated]
	private Color m_RandomCollectionLocator;

	[CompilerGenerated]
	private bool isStatelessSchema;

	[CompilerGenerated]
	private Color sortedRunnerLocator;

	[CompilerGenerated]
	private DashStyle _LocatorConverterFunction;

	[CompilerGenerated]
	private int m_CommonComparatorLocatorOffset;

	[CompilerGenerated]
	private bool m_IsFilteredOrder;

	[CompilerGenerated]
	private Color integratedWorkerLocator;

	[CompilerGenerated]
	private Color _ExpandableInterpreter;

	[CompilerGenerated]
	private float combinedModuleLocator;

	[CompilerGenerated]
	private float _ScalableReceiver;

	[CompilerGenerated]
	private float m_AccessibleInspector;

	public DeciderReceiverAdapter _ConfigurableClientLocator;

	public DeciderReceiverAdapter isolatedVerifierLocator;

	private WrapperContainerSingleton m_EfficientServer;

	private CombinedThreadSingleton m_DynamicErrorLocator;

	private bool m_IsControllablePredictorLocator;

	private int _VirtualReporterLocatorCap;

	private double _RoleResolver;

	private int m_SelectorMapLength;

	private int controllableDefinitionRate;

	private MapNotifier valueExtractorLocator;

	private RequesterTagExplorer locatorFunctionNotifier;

	private RequesterTagExplorer _LocatorExtractorLocator;

	private RequesterTagExplorer m_LocatorNotifierQueue;

	private int _PublisherStubInterval;

	private ScheduledErrorDecider m_CustomSystemLocator;

	private Color m_ManagerEngine;

	private bool _IsDispatcherConfig;

	private bool isCustomArgument;

	private bool isAlphabeticListLocator;

	private bool isDividedDic;

	private InternalSingletonSingleton _EvaluatorParameter;

	private DeciderRunner _LocatorLocatorMonitor;

	private GeneratorConfigurationArgument.TransferableValueReg basicSetLocator;

	private int m_LocatorQueueWriterStep;

	private int _MonitorCompressorLocatorScore;

	private int locatorWriterProviderStep;

	private int m_ResolverAllocatorLength;

	private int _VisualVerifierTotal;

	private int _ScalableRecordLocatorPerc;

	private bool m_IsResponsiveEventLocator;

	private bool isEditableFormatterLocator;

	private static StatelessCalcLocator SimulateStatelessMemberProcessor;

	[StaticStructAllocator(IsVisible = false)]
	public EncryptorFunctionSymbolFields Period
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorFunctionSymbolFields)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public DriverRelativeLocation InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DriverRelativeLocation)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, IsVisible = false)]
	[Category("General")]
	public RunnerCheckerKinds VbpType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RunnerCheckerKinds)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public WrapperRetargetingLaunchScenario AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WrapperRetargetingLaunchScenario)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0)]
	[Category("General")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 1.0, MaxValue = 600.0)]
	[Category("General")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Plot Settings")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Plot Settings")]
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public RequesterProcessorType TextFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RequesterProcessorType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
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

	[Category("Visual Appearance")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MaxValue = 100.0)]
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

	[Category("Visual Appearance")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public bool ShowFilledVbp
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
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

	[DisplayName("Highlight Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	[DisplayName("Show Line")]
	[Category("Point of Control")]
	public bool PocShowLine
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

	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	[Category("Point of Control")]
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
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

	[Category("Value Area")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
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

	[DisplayName("% Value Area")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 100.0)]
	[Category("Value Area")]
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

	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	[Category("Value Area")]
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

	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6, MaxValue = 10.0)]
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, MaxValue = 1000.0)]
	[Category("Peak And Valley")]
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
	[DisplayName("Appearance")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
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

	[Category("Summary")]
	[DisplayName("Enable Summary")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
	[Category("Summary")]
	[DisplayName("Text Color")]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	[Category("Summary")]
	[DisplayName("Ask Color")]
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

	[DisplayName("Bid Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	[Category("Summary")]
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

	[Category("Price Line")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	public bool EnablePriceLine
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

	[Category("Price Line")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1)]
	public Color PriceLineColor
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

	[Category("Price Line")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	[DisplayName("Line Style")]
	public DashStyle PriceLineStyle
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3, MaxValue = 8.0)]
	[DisplayName("Line Width")]
	[Category("Price Line")]
	public int PriceLineWidth
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

	[Category("Last Filled Qty")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0)]
	public bool EnableLastFillQty
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

	[Category("Last Filled Qty")]
	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1)]
	public Color LastFillTextColor
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
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 2)]
	[Category("Last Filled Qty")]
	public Color LastFillBackground
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

	[DisplayName("Text Size")]
	[Category("Last Filled Qty")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 3, DecimalPosToShow = 2, IncrementValue = 0.2, MaxValue = 50.0)]
	public float LastFillTextSize
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

	[StaticStructAllocator(IsVisible = false)]
	public float TotVolWidthCA
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

	[StaticStructAllocator(IsVisible = false)]
	public float DeltaWidthCA
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatelessCalcLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EncodeRecord(bool taskclose)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JoinContext(object var1, DeciderReceiverAdapter reg, DeciderReceiverAdapter serv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindVirtualTransaction(DeciderReceiverAdapter res, float cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PeekMonitor(DeciderRunner spec, InternalSingletonSingleton reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearLogicalMapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindGeneralMatcher(GeneratorConfigurationArgument.TransferableValueReg asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareConsumer(bool checkitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindSetTransmitter(SingletonHandlerConnection.ObjectAuthenticatorLocator task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSortedProc(SingletonHandlerConnection.ObjectAuthenticatorLocator task, bool countcust, bool overridehelper)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CreatorBufferAllocator ClearVisibleIterator(int last)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifySequentialPredicate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindTransformableExplorer(IEnumerable<MapResponderLocator.EfficientStructRequester> task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearGenericSpec()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IdentifySimpleSystem(bool isdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearDetailedProfiler(object value, bool istoken)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartTransformer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearStatelessStrategy(ColorSettings instance, ScheduledErrorDecider ord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private AllocatorDistributionPointInfo FindActiveRecord(int offset_v)
	{
		return (AllocatorDistributionPointInfo)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearFilteredHandler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterTagExplorer VerifyRunner(int next_init, int cust_High, bool addpool, int task2start)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer IdentifySymbolicBuffer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CreatorBufferAllocator ClearConcreteMonitor(int row_info, int idx_caller)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int IdentifyCentralState(int last)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ClearAdvancedArgument(double task, Color cont, int indexOf_state, bool forcesetup2 = true, DashStyle attr3 = DashStyle.Dash)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DirectModel(CombinedThreadSingleton ident, MapResponderLocator.EfficientStructRequester counter, out bool c, out bool reg2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseRequester(CombinedThreadSingleton setup, CreatorBufferAllocator attr, AllocatorDistributionPointInfo third, out DeciderRelativeHeaderPosition attr2, out long def3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int IdentifySegmentedTag(int[] config, long num_token)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color IdentifyCommonChecker(CombinedThreadSingleton instance, CreatorBufferAllocator cfg, AllocatorDistributionPointInfo role, int reg2, ScheduledErrorDecider pred3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyControllableTokenizer(ScheduledErrorDecider var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreAggregator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<(DeciderReceiverAdapter, float?)> RateFactory()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FindTransferableTracer(List<(DeciderReceiverAdapter, float?)> setup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatelessCalcLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateActiveProcessorSender()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StatelessCalcLocator ControlExtractor()
	{
		return null;
	}
}
