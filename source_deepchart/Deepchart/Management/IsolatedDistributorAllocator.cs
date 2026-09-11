using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.Management;

internal class IsolatedDistributorAllocator : LocatorRequest
{
	internal enum TransformableSchemaViewerKind
	{
		Automatic,
		Letters,
		Blocks
	}

	internal enum ScalableWatcherSingletonFlags
	{
		None,
		TillInteraction,
		TillEndWindow
	}

	internal enum CombinedClientLocatorOptions
	{
		[Display(Name = "Composite")]
		AllBars,
		[Display(Name = "Multiple")]
		MultipleProfile,
		[Display(Name = "Custom")]
		CustomTime
	}

	internal enum SenderParameterKinds
	{
		Minute,
		Days,
		Weeks,
		Months
	}

	[Serializable]
	internal struct RangeSettings
	{
		internal static object SimulateVisualGatewayCompiler;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("First Range")]
		[DisplayName("Enable")]
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		[Category("First Range")]
		[DisplayName("Ask Color")]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
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

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[Category("Third Range")]
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
		[Category("Third Range")]
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
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

		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
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
		[Category("Fourth Range")]
		[DisplayName("Enable")]
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
		[DisplayName("Value")]
		[Category("Fourth Range")]
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
		[DisplayName("Bid Color")]
		[Category("Fourth Range")]
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
		internal static bool GenerateStatelessCompilerPolicy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PopElement()
		{
			return null;
		}
	}

	[Serializable]
	internal struct PeakValleySettings
	{
		internal static object CloneEmitter;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[Category("Peak")]
		[DisplayName("Enable")]
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
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[DisplayName("Highlight")]
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
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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
		[Category("Peak")]
		[DisplayName("Show Line")]
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		[DisplayName("Extend Line")]
		[Category("Peak")]
		public ScalableWatcherSingletonFlags PeakExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (ScalableWatcherSingletonFlags)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 10.0)]
		[Category("Peak")]
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7)]
		[DisplayName("Line Color")]
		[Category("Peak")]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		[DisplayName("Highlight")]
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

		[Category("Valley")]
		[DisplayName("Maximum Volume")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0)]
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[Category("Valley")]
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

		[Category("Valley")]
		[DisplayName("Extend Line")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
		public ScalableWatcherSingletonFlags ValleyExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (ScalableWatcherSingletonFlags)(object)null;
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

		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7, MaxValue = 10.0)]
		[DisplayName("Line Width")]
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
		internal static bool AttachEncryptor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ArrangeChooser()
		{
			return null;
		}
	}

	[Serializable]
	internal struct VWapDevSettings
	{
		private static object ReflectFunction;

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
		[DisplayName("Upper Color")]
		[Category("First Envelope")]
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
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		[DisplayName("Lower Color")]
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

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
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

		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[Category("Second Envelope")]
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

		[Category("Third Envelope")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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

		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
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

		[DisplayName("Enable")]
		[Category("Fourth Envelope")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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
		[Category("Fourth Envelope")]
		[DisplayName("Lower Color")]
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
		[DisplayName("Upper Color")]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VWapDevSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateCentralErrorMapper()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DefineField()
		{
			return null;
		}
	}

	internal enum EncryptorOletxTransactionStatus
	{
		None,
		Last,
		All
	}

	internal enum MonoCollectorRegKinds
	{
		Automatic,
		Manual
	}

	internal enum ViewerDWriteFontFeatureTag
	{
		Fixed,
		FadingColor,
		MultipleColor
	}

	internal enum ConfigurableVerifierLocatorEnum
	{
		Volume,
		Delta,
		Time
	}

	internal enum RegPolicySystemOptions
	{
		Automatic,
		UserDefined
	}

	internal enum XdcMakeToolDispID
	{
		Body,
		Candle
	}

	internal enum ResourceStatusReason
	{
		Automatic,
		PercentualPeriod,
		WindowWidth,
		FixedBars
	}

	internal enum UIHierarchyElement
	{
		None,
		Show,
		Developing,
		ExtendShifted
	}

	internal enum StateExecutorOptions
	{
		None,
		Filter,
		Splitted,
		Triple
	}

	internal enum SessionMode
	{
		Rth,
		Custom,
		Eth
	}

	private class DetailedAuthorizerWriter
	{
		public DateTime _IterableBuilderWriter;

		public int queueCollectorSize;

		public int m_WriterEngineIndex;

		public int m_SegmentedDispatcherLimit;

		public int m_AdjustableObserverRate;

		internal static DetailedAuthorizerWriter ExecuteDecryptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedAuthorizerWriter()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DetailedAuthorizerWriter()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachAdjustableCollectorStream()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DetailedAuthorizerWriter AttachInterruptibleStreamManager()
		{
			return null;
		}
	}

	private class RequesterConverter
	{
		public int m_OrderedAnalyzerRequesterCounter;

		public RequesterRole m_SequentialTransactionRequester;

		public int stateRequesterRank;

		public long _ExtendedEncryptorRequesterOffset;

		public long _AdapterMatcherPos;

		public long sortedAuthenticatorRequesterScore;

		internal static RequesterConverter RunInitializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequesterConverter()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RequesterConverter()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EvaluateResponder()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RequesterConverter TrackAuthorizer()
		{
			return null;
		}
	}

	private class RequesterRole
	{
		public int _AdaptableFilterRequesterRank;

		public int groupedWatcherLevel;

		public List<RequesterTagExplorer> automatableElementRequesterList;

		public List<RequesterConverter> _PassiveParameterRequesters;

		public bool isTransformerStruct;

		public int m_ConfigurableModelRequesterFreq;

		public int _StatelessVerifierRequesterIdx;

		public bool m_IsConvertibleTokenizerRequester;

		public bool isRequesterSelectorStream;

		public bool isSeparatedVisitorRequester;

		public bool m_IsControllableObject;

		public bool _IsEditableArgumentRequester;

		public RequesterTagExplorer visualManagerRequester;

		public RequesterTagExplorer globalWrapperRequester;

		internal static RequesterRole GenerateLocalSenderVisitor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequesterRole()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RequesterRole()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DirectSchema()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RequesterRole GenerateMixedDecryptorDefinition()
		{
			return null;
		}
	}

	private class WrapperCalc
	{
		public DateTime m_WrapperConsumer;

		public DateTime errorRecommender;

		public AllocatorCompilerEvent<RequesterConverter> connectionDispatcher;

		public AllocatorCompilerEvent<RequesterRole> portableFunction;

		public bool m_IsChainRecord;

		public int _CustomSummarizerWrapperDepth;

		public int m_VirtualTemplatePnts;

		public int _CustomizableProgramWrapperCnt;

		public long m_ExecutorWrapperValue;

		public long m_AuthorizerWrapperRate;

		public int m_DividedTrackerWrapperCap;

		public long virtualFormatterWrapperErrorCode;

		public long _DynamicHandlerLength;

		public long separatedSorterValue;

		public long _SymbolicContextWrapperCnt;

		public int visualProfilerWrapperRank;

		public int m_WrapperCompilerNum;

		public int m_OperationalPredictorWrapperCap;

		public int _ResolverDecryptorVal;

		public int _PredicateWrapperCount;

		public int _StatelessTaskCount;

		public int _PublisherRunnerPosition;

		public int extractorWrapperIdx;

		public int _InternalMatcherCap;

		public int wrapperDicTotal;

		public int m_AttachedProjectWrapperPnts;

		public int m_ExternalProviderWrapperPos;

		public int _JoinedQueueWrapperScore;

		public int m_WrapperChooserVal;

		public int wrapperMapperStep;

		public int m_ExpandableErrorWrapperPerc;

		public int m_SharerDecryptorErrorCode;

		public int combinedChainWrapperPerc;

		public int m_InterruptibleSharerWrapperInterval;

		public bool isWrapperCreator;

		public double m_ValueCompressor;

		public double _ConnectionWrapper;

		public int m_RecommenderEnumeratorVol;

		public int elementWrapperLevel;

		public long visibleRecommenderWrapperStep;

		public long _ExecutorSynchronizerAge;

		public long _StackGatewayCount;

		public long m_WrapperSelectorPosition;

		public double m_AutomatedRecordWrapper;

		public double configurableExtractor;

		public bool m_IsRecordEncryptor;

		public RequesterTagExplorer[] m_BasicDecryptorWrappers;

		public LogicalStateEncryptor _AdjustableEnumeratorWrapper;

		public MapNotifier m_ModularEncryptorWrapper;

		public MapNotifier wrapperArgument;

		public List<RequesterTagExplorer> _PolicyGatewayList;

		public RequesterTagExplorer m_ProcEmitter;

		public RequesterTagExplorer _MixedCompressor;

		public RequesterTagExplorer m_StaticSynchronizerWrapper;

		public RequesterTagExplorer decryptorSynchronizer;

		public RequesterTagExplorer iterableOrderWrapper;

		public List<RequesterTagExplorer> proxySystemList;

		public RequesterTagExplorer m_SequentialAttributeWrapper;

		public RequesterTagExplorer m_CompressorWrapper;

		public RequesterTagExplorer _ConcreteSorterWrapper;

		public RequesterTagExplorer _ExecutorBuffer;

		public RequesterTagExplorer wrapperBuffer;

		public double m_EncryptorSharerProgram;

		public int m_CheckerWrapperSize;

		public double _WrapperTransformer;

		public double finderWrapper;

		public int _WrapperEvaluatorRate;

		public int m_ListenerArgumentCnt;

		public DateTime wrapperTracer;

		public bool _IsInitializerContainer;

		public char _WrapperThread;

		public int m_GatewayWrapperCap;

		public HashSet<int> m_ConcreteEvaluator;

		public bool _IsPassiveMemberWrapper;

		public bool m_IsGenericServerWrapper;

		private static WrapperCalc SimulateScheduledDefinitionSelector;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperCalc()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperCalc()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HandleList()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperCalc SimulateExternalInitializerResponder()
		{
			return null;
		}
	}

	private class SegmentedChooserGenerator
	{
		public int[] m_GeneratorTaskElements;

		public int[] generatorChains;

		public Color[] m_ScalableModelGeneratorArray;

		public Color[] m_GeneratorSelectorElements;

		public Color[] _ScheduledCompressorGeneratorData;

		public Color?[] _GeneratorViewerElements;

		public bool _IsBufferRunner;

		public int _GeneratorConsumerStep;

		public bool _IsMonoLocatorGenerator;

		public ConfigurableVerifierLocatorEnum m_GeneratorQueue;

		public ViewerDWriteFontFeatureTag m_ListenerSpec;

		public RegPolicySystemOptions responsiveCacheGenerator;

		private static SegmentedChooserGenerator GenerateAccessibleResponderAuthorizer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SegmentedChooserGenerator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SegmentedChooserGenerator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RateProvider()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SegmentedChooserGenerator AttachAdaptableServiceSchema()
		{
			return null;
		}
	}

	private class ManagerFunction
	{
		public double isolatedTokenizerDriver;

		public EncryptorCacheBuffer.Series_Prop _StubHandler;

		public EncryptorCacheBuffer.Series_Prop _ExpandableReceiver;

		internal static ManagerFunction ViewProgram;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerFunction()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ManagerFunction()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachDynamicValueTracker()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ManagerFunction GenerateReadableTrackerList()
		{
			return null;
		}
	}

	private enum RequestertimeUnitType
	{
		Volume,
		Bid,
		Ask
	}

	[CompilerGenerated]
	private int m_AllocatorEmitterVisitorId;

	[CompilerGenerated]
	private TransformableSchemaViewerKind _CommandEditor;

	[CompilerGenerated]
	private CombinedClientLocatorOptions m_AllocatorVisitorBuilder;

	[CompilerGenerated]
	private SenderParameterKinds _AllocatorBuilderClient;

	[CompilerGenerated]
	private int _ProgramVerifierLimit;

	[CompilerGenerated]
	private EncryptorOletxTransactionStatus clientStubAllocator;

	[CompilerGenerated]
	private DateTime extendedMemberAllocator;

	[CompilerGenerated]
	private DateTime m_StubObjectAllocator;

	[CompilerGenerated]
	private MonoCollectorRegKinds _RemoteServerAllocator;

	[CompilerGenerated]
	private int m_EngineServiceIdx;

	[CompilerGenerated]
	private int randomRequesterAllocatorId;

	[CompilerGenerated]
	private ConfigurableVerifierLocatorEnum m_SimpleReporterAllocator;

	[CompilerGenerated]
	private ViewerDWriteFontFeatureTag inspectorProfile;

	[CompilerGenerated]
	private int _StatelessConnectionScore;

	[CompilerGenerated]
	private int m_AllocatorObjectTokenFreq;

	[CompilerGenerated]
	private Color _GeneralThreadAllocator;

	[CompilerGenerated]
	private Color m_SegmentedGatewayAllocator;

	[CompilerGenerated]
	private Color _SortedSorterAllocator;

	[CompilerGenerated]
	private RegPolicySystemOptions _ConcreteParameter;

	[CompilerGenerated]
	private RangeSettings m_MapperDic;

	[CompilerGenerated]
	private Color _SetAdapterAllocator;

	[CompilerGenerated]
	private Color sorterCommand;

	[CompilerGenerated]
	private Color localInitializerAllocator;

	[CompilerGenerated]
	private Color compressorModel;

	[CompilerGenerated]
	private bool _IsVisitorExecutor;

	[CompilerGenerated]
	private Color basicTaskAllocator;

	[CompilerGenerated]
	private bool isJoinedContainerAllocator;

	[CompilerGenerated]
	private Color _TokenCompilerAllocator;

	[CompilerGenerated]
	private int _CompilerExtractorAllocatorVol;

	[CompilerGenerated]
	private XdcMakeToolDispID staticProfileAllocator;

	[CompilerGenerated]
	private Color m_StructStruct;

	[CompilerGenerated]
	private Color requesterQueue;

	[CompilerGenerated]
	private ResourceStatusReason m_StrategyProvider;

	[CompilerGenerated]
	private double m_FilteredStream;

	[CompilerGenerated]
	private int m_AllocatorExtractorQueueScore;

	[CompilerGenerated]
	private double m_FilteredListAllocator;

	[CompilerGenerated]
	private int _EditorStrategyFreq;

	[CompilerGenerated]
	private int m_AllocatorQueueEventCnt;

	[CompilerGenerated]
	private int allocatorEventDistributorFlag;

	[CompilerGenerated]
	private float _AllocatorDistributorMember;

	[CompilerGenerated]
	private bool isPredicateFactory;

	[CompilerGenerated]
	private bool _IsArgumentEnumerator;

	[CompilerGenerated]
	private bool _IsActiveController;

	[CompilerGenerated]
	private bool _IsParameterMonitor;

	[CompilerGenerated]
	private bool _IsMemberServerAllocator;

	[CompilerGenerated]
	private bool _IsAllocatorServerRequester;

	[CompilerGenerated]
	private Color m_AllocatorRequesterReporter;

	[CompilerGenerated]
	private UIHierarchyElement _TransformableProviderAllocator;

	[CompilerGenerated]
	private ScalableWatcherSingletonFlags _NotifierDictionary;

	[CompilerGenerated]
	private Color _VirtualControllerAllocator;

	[CompilerGenerated]
	private int m_CacheModelValue;

	[CompilerGenerated]
	private TimeSpan m_ExternalLoggerAllocator;

	[CompilerGenerated]
	private int m_AllocatorReporterThreadPerc;

	[CompilerGenerated]
	private int _DecoratorTokenizerPosition;

	[CompilerGenerated]
	private bool _IsSimpleProgram;

	[CompilerGenerated]
	private int dispatcherHandlerRank;

	[CompilerGenerated]
	private bool m_IsHandlerPool;

	[CompilerGenerated]
	private Color _AlphabeticStructAllocator;

	[CompilerGenerated]
	private bool isIterableEncryptorAllocator;

	[CompilerGenerated]
	private bool m_IsVerifierTransformer;

	[CompilerGenerated]
	private int m_IdentifiableRecordAllocatorPnts;

	[CompilerGenerated]
	private bool isVisualPredictorAllocator;

	[CompilerGenerated]
	private ScalableWatcherSingletonFlags operationalWrapperAllocator;

	[CompilerGenerated]
	private Color attachedModuleAllocator;

	[CompilerGenerated]
	private int m_ResponsiveDictionaryAllocatorInterval;

	[CompilerGenerated]
	private int m_CombinedCalculatorAllocatorNum;

	[CompilerGenerated]
	private bool isThreadGatewayAllocator;

	[CompilerGenerated]
	private PeakValleySettings m_GatewaySorterAllocator;

	[CompilerGenerated]
	private bool isAllocatorSorterAdapter;

	[CompilerGenerated]
	private int _AdvancedRoleAllocatorFreq;

	[CompilerGenerated]
	private bool isProfilerValidator;

	[CompilerGenerated]
	private Color _EfficientArgumentAllocator;

	[CompilerGenerated]
	private int accessibleTemplateAllocatorDist;

	[CompilerGenerated]
	private DashStyle m_OrderedCompressorAllocator;

	[CompilerGenerated]
	private ScalableWatcherSingletonFlags m_AllocatorAdapterInitializer;

	[CompilerGenerated]
	private bool _IsStrategyManager;

	[CompilerGenerated]
	private bool isAllocatorInitializerTask;

	[CompilerGenerated]
	private bool m_IsAutomatedFieldAllocator;

	[CompilerGenerated]
	private Color allocatorTaskContainer;

	[CompilerGenerated]
	private Color handlerProcessor;

	[CompilerGenerated]
	private Color m_ConfigurableMonitorAllocator;

	[CompilerGenerated]
	private StateExecutorOptions stateReporter;

	[CompilerGenerated]
	private SessionMode _ManagerFinalizer;

	[CompilerGenerated]
	private TimeSpan setDecorator;

	[CompilerGenerated]
	private TimeSpan m_CentralParserAllocator;

	[CompilerGenerated]
	private bool _IsContainerProfileAllocator;

	private bool isProcessorModel;

	private bool isTransferableConnectionAllocator;

	private string _ProfileListAllocatorStr;

	private List<WrapperCalc> finalizerReceiverList;

	private bool isEngineExplorer;

	private int m_ProjectEditorFreq;

	private int writerLoggers;

	private int _ActiveInspectorAllocators;

	private int _AllocatorListProviderPos;

	private int m_AllocatorProviderControllerSize;

	private bool m_IsInternalProxy;

	private double _FlexibleNotifier;

	private int _ModelProfilerAge;

	private bool _IsMatcherAggregator;

	private int m_FactoryEnumeratorLimit;

	private DateTime m_ProxyRunner;

	private bool _IsAllocatorControllerLogger;

	private List<MapResponderLocator.GeneratorResponder> m_GlobalLocatorAllocatorList;

	private int m_AllocatorLoggerStructCap;

	private int _ConcreteMatcherAllocatorFreq;

	private SegmentedChooserGenerator hiddenCacheAllocator;

	private Color m_VisibleAuditorAllocator;

	private long _ControllableCommandAllocatorFlag;

	private DateTime m_SorterEvaluator;

	private int _CommonFormatterAllocatorPosition;

	private int structEncryptorAllocatorCount;

	private int _AllocatorEncryptorRecordPosition;

	private bool isRecordPredictorAllocator;

	private int _CustomProgramAllocatorPerc;

	private bool m_IsReceiverExecutor;

	private bool _IsAllocatorPredictorWrapper;

	private int _ScopeEditorAllocatorTotal;

	private int detachedDispatcherAllocatorPos;

	private TimeSpan allocatorWrapperModule;

	private TimeSpan m_StaticTransaction;

	private bool isAllocatorModuleDictionary;

	private bool m_IsProfilerFinder;

	private double _StatelessVerifierAllocator;

	private EncryptorCacheBuffer.Series_Prop m_AllocatorDictionaryCalculator;

	private EncryptorCacheBuffer.Series_Prop mixedStrategyAllocator;

	private IMonoCalcViewer m_AllocatorCalculatorRole;

	private HashSet<DateTime> allocatorRoleArgument;

	private HashSet<DateTime> _AdjustableHandlerAllocator;

	private List<DetailedAuthorizerWriter> _JoinedBufferList;

	private TransformableSchemaViewerKind m_VirtualTask;

	private int _AllocatorArgumentTemplateDepth;

	private int allocatorTemplateCompressorIdx;

	private bool isAllocatorCompressorField;

	[CompilerGenerated]
	private int _AllocatorFieldMonitorOffset;

	private static IsolatedDistributorAllocator MatchEncryptor;

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 0, MinValue = 1.0, MaxValue = 1440.0)]
	public int TpoBaseMinute
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
	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 1)]
	public TransformableSchemaViewerKind DisplayType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TransformableSchemaViewerKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 2)]
	[Category("General")]
	public CombinedClientLocatorOptions TpoPeriod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CombinedClientLocatorOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 3)]
	public SenderParameterKinds LengthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SenderParameterKinds)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 4, MinValue = 1.0, MaxValue = 1800000.0)]
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

	[Category("General")]
	[DisplayName("Split TPO")]
	[StaticStructAllocator(SubCategory = "Typology", CategoryIndex = 0, PropertyIndex = 5)]
	public EncryptorOletxTransactionStatus SplitTPO
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorOletxTransactionStatus)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Start Date/Time")]
	[StaticStructAllocator(SubCategory = "Custom Date/Time", CategoryIndex = 0, PropertyIndex = 6, ShowLongDateTimeFormat = true)]
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

	[DisplayName("End Date/Time")]
	[Category("General")]
	[StaticStructAllocator(SubCategory = "Custom Date/Time", CategoryIndex = 0, PropertyIndex = 7, ShowLongDateTimeFormat = true)]
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

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Tick Grouping", CategoryIndex = 0, PropertyIndex = 8)]
	public MonoCollectorRegKinds AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MonoCollectorRegKinds)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Tick Grouping", CategoryIndex = 0, PropertyIndex = 9, MinValue = 1.0)]
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

	[StaticStructAllocator(SubCategory = "Tick Grouping", CategoryIndex = 0, PropertyIndex = 10, MinValue = 1.0, MaxValue = 600.0)]
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Color mode")]
	public ConfigurableVerifierLocatorEnum ColorCalculation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConfigurableVerifierLocatorEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Background/Text")]
	[DisplayName("Color reference")]
	public ViewerDWriteFontFeatureTag MethodColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerDWriteFontFeatureTag)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 2)]
	public int MinTextSize
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 3)]
	public int MaxTextSize
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Colors", CategoryIndex = 1, PropertyIndex = 4)]
	public Color FixedVolColor
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Colors", CategoryIndex = 1, PropertyIndex = 5)]
	public Color FixedBidColor
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Colors", CategoryIndex = 1, PropertyIndex = 6)]
	public Color FixedAskColor
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Colors", CategoryIndex = 1, PropertyIndex = 7)]
	public RegPolicySystemOptions ColorRangeDefining
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegPolicySystemOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Colors", CategoryIndex = 1, PropertyIndex = 8)]
	public RangeSettings ColorRange
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

	[StaticStructAllocator(SubCategory = "Initial Blocks", CategoryIndex = 1, PropertyIndex = 9)]
	[Category("Background/Text")]
	public Color ColorA
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Initial Blocks", CategoryIndex = 1, PropertyIndex = 10)]
	public Color ColorB
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Initial Blocks", CategoryIndex = 1, PropertyIndex = 11)]
	public Color ColorC
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Initial Blocks", CategoryIndex = 1, PropertyIndex = 12)]
	public Color ColorD
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Open/Close", CategoryIndex = 1, PropertyIndex = 13)]
	public bool ColorEnableOpen
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

	[StaticStructAllocator(SubCategory = "Open/Close", CategoryIndex = 1, PropertyIndex = 14)]
	[Category("Background/Text")]
	public Color ColorOpen
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Open/Close", CategoryIndex = 1, PropertyIndex = 15)]
	public bool ColorEnableClose
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

	[Category("Background/Text")]
	[StaticStructAllocator(SubCategory = "Open/Close", CategoryIndex = 1, PropertyIndex = 16)]
	public Color ColorClose
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Bar Marker", CategoryIndex = 2, PropertyIndex = 0, MaxValue = 5.0)]
	public int BarMarkerWidth
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
	[StaticStructAllocator(SubCategory = "Bar Marker", CategoryIndex = 2, PropertyIndex = 1)]
	public XdcMakeToolDispID BarMarketStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (XdcMakeToolDispID)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Up Color")]
	[StaticStructAllocator(SubCategory = "Bar Marker", CategoryIndex = 2, PropertyIndex = 2)]
	public Color BarMarkerUpColor
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

	[DisplayName("Down Color")]
	[StaticStructAllocator(SubCategory = "Bar Marker", CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Plot Settings")]
	public Color BarMarkerDownColor
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Width/Offset", CategoryIndex = 2, PropertyIndex = 5, DefaultCollapsed = 1)]
	public ResourceStatusReason WidthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ResourceStatusReason)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Current Width")]
	[StaticStructAllocator(SubCategory = "Width/Offset", CategoryIndex = 2, PropertyIndex = 6, MaxValue = 500.0)]
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

	[StaticStructAllocator(SubCategory = "Width/Offset", CategoryIndex = 2, PropertyIndex = 7, MaxValue = 500.0)]
	[DisplayName("Current Offset")]
	[Category("Plot Settings")]
	public int TpoCurrOffset
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
	[StaticStructAllocator(SubCategory = "Width/Offset", CategoryIndex = 2, PropertyIndex = 8, MaxValue = 500.0)]
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
	[StaticStructAllocator(SubCategory = "Width/Offset", CategoryIndex = 2, PropertyIndex = 9, MaxValue = 500.0)]
	public int TpoPrevOffset
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
	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 10, MinValue = 0.0, MaxValue = 1000.0, DefaultCollapsed = 1)]
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
	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 11, MaxValue = 100.0)]
	public int TpoOpacity
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
	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 12, MaxValue = 6.0, DecimalPosToShow = 2, IncrementValue = 0.5)]
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
	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 13)]
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

	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 15)]
	[Category("Plot Settings")]
	[DisplayName("Align to the right")]
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

	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 16)]
	[Category("Plot Settings")]
	[DisplayName("Mirroring")]
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
	[StaticStructAllocator(SubCategory = "Visual Appearance", CategoryIndex = 2, PropertyIndex = 17)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Point of Control")]
	public UIHierarchyElement PocLineMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (UIHierarchyElement)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Point of Control")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	public ScalableWatcherSingletonFlags PocExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ScalableWatcherSingletonFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Line Color")]
	[Category("Point of Control")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
	[Category("Point of Control")]
	[DisplayName("Line Width")]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7)]
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

	[Category("Point of Control")]
	[DisplayName("Shifted Poc Tick Grouping")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 8)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 9, MaxValue = 100.0)]
	[Category("Point of Control")]
	[DisplayName("Opacity Poc Grouping")]
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

	[Category("Value Area")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 100.0)]
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

	[Category("Value Area")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	[DisplayName("Outside Color")]
	[Category("Value Area")]
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	[DisplayName("Show Line")]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
	[DisplayName("Show Background")]
	[Category("Value Area")]
	public bool VAShowBackground
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 6)]
	[DisplayName("Background Opacity")]
	[Category("Value Area")]
	public int VAOpacity
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
	[DisplayName("Developing")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 7)]
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

	[Category("Value Area")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 8)]
	public ScalableWatcherSingletonFlags VAExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ScalableWatcherSingletonFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 9)]
	[Category("Value Area")]
	[DisplayName("Line Color")]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 10, MaxValue = 10.0)]
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

	[DisplayName("Sensitivity")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0, MaxValue = 1000.0)]
	[Category("Peak And Valley")]
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
	[DisplayName("Exclude High/Low")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 1000.0)]
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

	[DisplayName("Appearance")]
	[Category("Peak And Valley")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
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

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	[Category("Single prints")]
	public bool SinglePrintEnable
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

	[Category("Single prints")]
	[DisplayName("Min. ticks")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, MinValue = 1.0, MaxValue = 32767.0)]
	public int SinglePrintMinTicks
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

	[Category("Single prints")]
	[DisplayName("Include High/Low")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	public bool SinglePrintIncludeHighLow
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

	[DisplayName("Line color")]
	[Category("Single prints")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	public Color SinglePrintLineColor
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4, MaxValue = 10.0)]
	[Category("Single prints")]
	[DisplayName("Line Width")]
	public int SinglePrintLineWidth
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5)]
	[DisplayName("Line Width")]
	[Category("Single prints")]
	public DashStyle SinglePrintLineStyle
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

	[DisplayName("Extended")]
	[Category("Single prints")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6)]
	public ScalableWatcherSingletonFlags SinglePrintExtensionMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ScalableWatcherSingletonFlags)(object)null;
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

	[Category("Summary")]
	[DisplayName("Volume Summary")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	[DisplayName("Trade Summary")]
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

	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
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

	[Category("Summary")]
	[DisplayName("Ask Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
	[DisplayName("Bid Color")]
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

	[Category("Filter/Split time")]
	[DisplayName("Filter Mode")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 7, PropertyIndex = 0)]
	public StateExecutorOptions FilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (StateExecutorOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Filter/Split time")]
	[DisplayName("Filter Time")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 7, PropertyIndex = 1)]
	public SessionMode FilterTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SessionMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Filter/Split time")]
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 7, PropertyIndex = 2)]
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
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 7, PropertyIndex = 3)]
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
	[StaticStructAllocator(SubCategory = "Custom time (Exchange time zone)", CategoryIndex = 7, PropertyIndex = 4)]
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

	[Category("Hidden")]
	[StaticStructAllocator(IsVisible = false)]
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

	[StaticStructAllocator(IsVisible = false)]
	[Category("Hidden")]
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
	[Category("Hidden")]
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

	[StaticStructAllocator(IsVisible = false)]
	[Category("Hidden")]
	public string SplitProfileStr
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
	static IsolatedDistributorAllocator()
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
				case 0:
				{
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555612));
					MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8F87EE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F0164 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), MapResponderLocator.BasicRecordReg.Volume);
					sortedPublisherWrapper.SetList(new List<string>
					{
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE0E203B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x574195D6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED7DFD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8)
					});
					DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts, strippred2: false, isinit3: false, isinit4: true);
					return;
				}
				case 1:
					break;
				}
				goto IL_012a;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_012a;
				IL_012a:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 4;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d0c3908a433e462894124f3b1a35946b == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsolatedDistributorAllocator(ScopeEncryptor.HiddenModelDecider ident, MapResponderLocator.TransformableUserEncryptor ivk, int controlhigh)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreCentralInterpreter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreAdvancedQueue(int lengthconfig, int? pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignCustomTemplate(int last, int? map, object consumer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseAttachedTag(int remove_VAR1At, int? caller, object tag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseBasicChecker(int task_end, int? token, object role)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseOperationalTokenizer(int init_min, int? token, object consumer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ReleaseFlexibleEvaluator(DateTime v)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ReleaseEditablePool(DateTime info)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool includeinit, bool readreg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignIntegratedTracer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateCustomizableTransformer(SegmentedChooserGenerator task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool overridelast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer UpdateContext(int endinstance, int connection, int consumer_end)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterTagExplorer ReleaseJoinedTree(int row_def, int pol_High, int flags_dir, char col2, int t3_Low)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterConverter PresentMonitor(int tasklow, int counter_start)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int AssignConnectedRunner(int nextreference, int attr_low)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseExpandableProject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeConsumer(DateTime var1, int cont, int filtercounter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseCombinedRole(DateTime reference, DateTime ivk, int sizethird, int spec2_X, bool wantident3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseGroupedController(WrapperCalc item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator setup, bool istoken, MapResponderLocator.TokenParameterViewer rule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateIdentifiableModel(SingletonHandlerConnection.ObjectAuthenticatorLocator def, bool rejecttoken, MapResponderLocator.TokenParameterViewer temp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterConverter ExecuteTokenizer(int previoustask, int num_attr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseAdjustableDefinition(double instance, Color ord, int util, bool isvar12 = true, bool acceptfirst3 = false, DashStyle config4 = DashStyle.Dash, AnnotationType spec5 = AnnotationType.HorizontalLine, byte param6_offset = byte.MaxValue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseInterruptibleSelector(int next_reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunTracer(int res_offset, int attr_offset, int proc_Z)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EvaluatePredictor(DateTime task)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseModularAuthorizer(MapResponderLocator.GeneratorResponder value, int visHigh, int index_comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RestartAllocator(WrapperCalc task, out int visitor, out int third)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateConfigurableSchema(WrapperCalc info, int position_counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseMixedValue(int instance_Low, int visitor_Z, bool validatedir, bool extractfirst2, bool canconfig3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignScheduledTracker(int idx_reference, bool injectselection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseMonoList(int defstart)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool lastopen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseExternalLocator(WrapperCalc config, RequesterRole pred, out bool dir, out bool map2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignAccessibleVerifier(WrapperCalc param, RequesterRole ivk, out RequestertimeUnitType third, out long asset2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int AllocatePassiveProvider(int[] config, long start_cust)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color ReleaseAdaptableParser(WrapperCalc var1, RequesterRole cont, int template_offset, SegmentedChooserGenerator cont2, out bool asset3, out int col4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ViewRequester(int resHigh, SegmentedChooserGenerator pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessFilter(int mean_ident, bool verifycont, out double helper, out double col2, out double ivk3, bool setdef4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateReadableParameter(bool readconfig, int num_selection, bool fieldclose)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool rejectsetup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateDividedProxy(bool explicitinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool injectparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchAggregator(int instance_max)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PrepareChooser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsolatedDistributorAllocator AttachSetEditorCache()
	{
		return null;
	}
}
