using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Models;

[Serializable]
internal class GeneralSettings
{
	[Serializable]
	internal class GeneralProp
	{
		private static GeneralProp SimulateInterruptibleEditorCache;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Language")]
		[Category("General")]
		public SyntaxRemoveOptions Language
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (SyntaxRemoveOptions)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[JsonIgnore]
		[Category("General")]
		public ResponsiveStructLocator TimeZoneList
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[Category("General")]
		[DisplayName("Theme")]
		public WrapperTextBoxMode ThemeMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (WrapperTextBoxMode)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("General")]
		[DisplayName("Notification sounds")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		public DeciderChainPolicyType AlertSoundsProfile
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DeciderChainPolicyType)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[DisplayName("Time&Sales")]
		[Category("Alert Settings")]
		public RandomReceiverDriverState AlertWorkTimeSales
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (RandomReceiverDriverState)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Alert Settings")]
		[DisplayName("Drawing Tools")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		public RandomReceiverDriverState AlertWorkDrawingTools
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (RandomReceiverDriverState)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Refresh Time(ms)")]
		[DisplayName("Chart")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, DecimalPosToShow = 0, IncrementValue = 25.0, MinValue = 50.0, MaxValue = 10000.0)]
		public int MSRefreshChart
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

		[DisplayName("Time Sales")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 0, IncrementValue = 25.0, MinValue = 50.0, MaxValue = 10000.0)]
		[Category("Refresh Time(ms)")]
		public int MSRefreshTS
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

		[Category("Refresh Time(ms)")]
		[DisplayName("Smart Dom")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, DecimalPosToShow = 0, IncrementValue = 25.0, MinValue = 50.0, MaxValue = 10000.0)]
		public int MSRefreshDom
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

		[Category("Refresh Time(ms)")]
		[DisplayName("Advanced Dom")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, DecimalPosToShow = 0, IncrementValue = 25.0, MinValue = 50.0, MaxValue = 10000.0)]
		public int MSRefreshAdvDom
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, DecimalPosToShow = 0, IncrementValue = 250.0, MinValue = 50.0, MaxValue = 10000.0)]
		[DisplayName("Scanner")]
		[Category("Refresh Time(ms)")]
		public int MSRefreshScanner
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
		[DisplayName("Editable copied annotation")]
		[Category("Chart")]
		public bool ChartEditAnnFromOther
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
		[DisplayName("Default Cursor")]
		[Category("Chart")]
		public EfficientAllocatorTypes ChartCursorDefault
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (EfficientAllocatorTypes)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		[DisplayName("Global crosshair always on (if crosshair)")]
		[Category("Chart")]
		public bool ChartGlobalCrosshairAlwaysOn
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
		[DisplayName("Hand hover - Drag X & Y")]
		[Category("Chart")]
		public bool ChartHandHoverDragXAndY
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

		[Category("Chart")]
		[DisplayName("Axis Y - Default move mode")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		public AxisMoveModeEnum ChartAxisYDefaultMoveMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (AxisMoveModeEnum)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Chart")]
		[DisplayName("Annotations - stop on last bar")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
		public bool ChartAnnotationsBlockLastBar
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

		[Category("Chart")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 6)]
		[DisplayName("Chart tabs - compact mode")]
		public bool ChartCompactTabs
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

		[DisplayName("Daily P/L - Display Mode")]
		[Category("Trading")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
		public DriverBuildControllerUpdate TradingPlMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (DriverBuildControllerUpdate)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Trading")]
		[DisplayName("Open P/L - Display Mode")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
		public RandomWrapperValues TradingOpenPlMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (RandomWrapperValues)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2, MinValue = -32768.0, MaxValue = 32767.0)]
		[Category("Trading")]
		[DisplayName("Breakeven - Ticks")]
		public int TradingBreakevenTicks
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
		[DisplayName("Simulation - Stop order condition")]
		[Category("Trading")]
		public LocatorBufferType SimStopEvaluation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (LocatorBufferType)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Trading")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
		[DisplayName("Trading panel - Show balance")]
		public bool TradingShowBalanceOnTradingPanel
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

		[Category("Trading")]
		[DisplayName("Trading panel - Show equity")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
		public bool TradingShowEquityOnTradingPanel
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

		[DisplayName("Trading panel - Show contract details")]
		[Category("Trading")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 6)]
		public bool TradingShowContractDetailsOnTradingPanel
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

		[DisplayName("Frequency limitation - max orders per second")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 7)]
		[Category("Trading")]
		public int TradingMaxUserOrdersPerSecond
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 8)]
		[Category("Trading")]
		[DisplayName("Frequency limitation - pause time (seconds)")]
		public int TradingMaxTotalOrdersPauseSeconds
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

		[Category("Various")]
		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
		[DisplayName("Strategy report - Text Size")]
		public int StrategyFontSize
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

		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
		[Category("Various")]
		public bool ControlBarAlwaysOnTop
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

		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
		[Category("Various")]
		[DisplayName("Database Folder")]
		public string DBFolder
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

		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, DecimalPosToShow = 0, IncrementValue = 1.0, MinValue = 1.0, MaxValue = 8.0)]
		[Category("Various")]
		public int ParallelGpuCount
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

		[DisplayName("Screenshot mode")]
		[Category("Various")]
		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
		public AdjustableDeciderEnum ScreenshotMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (AdjustableDeciderEnum)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Various")]
		[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6)]
		public bool CheckRealTimeDelay
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

		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
		[Category("Alert Trading")]
		[DisplayName("Discard nearly sounds")]
		public bool TradingDiscardNearlySounds
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
		[Category("Alert Trading")]
		public bool EnableOrderSubmitted
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

		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2, IsFile = true, FilePattern = "Audio (*.wav)|*.wav")]
		[Category("Alert Trading")]
		public string OrderSubmittedAlert
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

		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
		[Category("Alert Trading")]
		public bool EnableOrderFilled
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

		[Category("Alert Trading")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4, IsFile = true, FilePattern = "Audio (*.wav)|*.wav")]
		public string OrderFilledAlert
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

		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
		[Category("Alert Trading")]
		public bool EnableOrderCancelled
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

		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 6, IsFile = true, FilePattern = "Audio (*.wav)|*.wav")]
		[Category("Alert Trading")]
		public string OrderCancelledAlert
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

		[Category("Alert Trading")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 7)]
		public bool EnableOrderRejected
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

		[Category("Alert Trading")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 8, IsFile = true, FilePattern = "Audio (*.wav)|*.wav")]
		public string OrderRejectedAlert
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

		[Category("Alert Trading")]
		[DisplayName("Highlight window on filled")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 9)]
		public bool EnableWindowHighlightOnFilled
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

		[Category("Alert Trading")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 10)]
		public int HighlightSeconds
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

		[Category("Alert Trading")]
		[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 11)]
		public Color HighlightColor
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
		public string SelectedTimeZone
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GeneralProp()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GeneralProp()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AwakeTester()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GeneralProp CalcNode()
		{
			return null;
		}
	}

	[Serializable]
	internal class ToolbarProp
	{
		internal static ToolbarProp SimulateModularClientExecutor;

		[Category("Chart - Annotations")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Horizontal line")]
		public bool ChartAnnHorizontalLine
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[DisplayName("Vertical line")]
		[Category("Chart - Annotations")]
		public bool ChartAnnVerticalLine
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[DisplayName("Ray")]
		[Category("Chart - Annotations")]
		public bool ChartAnnRay
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

		[Category("Chart - Annotations")]
		[DisplayName("Line")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		public bool ChartAnnLine
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

		[Category("Chart - Annotations")]
		[DisplayName("Parallel line")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
		public bool ChartAnnParallelLine
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

		[DisplayName("Ruler")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		[Category("Chart - Annotations")]
		public bool ChartAnnRuler
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

		[Category("Chart - Annotations")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6)]
		[DisplayName("Rectangle")]
		public bool ChartAnnRectangle
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

		[Category("Chart - Annotations")]
		[DisplayName("Ellipse")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7)]
		public bool ChartAnnEllipse
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

		[Category("Chart - Annotations")]
		[DisplayName("Text")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8)]
		public bool ChartAnnText
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 9)]
		[DisplayName("Pencil")]
		[Category("Chart - Annotations")]
		public bool ChartAnnPencil
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

		[Category("Chart - Annotations")]
		[DisplayName("Fibonacci retracement")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 10)]
		public bool ChartAnnPriceRetr
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

		[Category("Chart - Annotations")]
		[DisplayName("Fibonacci projection")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 11)]
		public bool ChartAnnPriceProj
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

		[Category("Chart - Annotations")]
		[DisplayName("Fibonacci fan")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 12)]
		public bool ChartAnnPriceFan
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

		[DisplayName("Volume profile")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 13)]
		[Category("Chart - Annotations")]
		public bool ChartAnnVolProfile
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

		[DisplayName("VWAP")]
		[Category("Chart - Annotations")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 14)]
		public bool ChartAnnVwap
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

		[Category("Chart - Annotations")]
		[DisplayName("Buy calculator")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 15)]
		public bool ChartAnnBuyCalc
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

		[Category("Chart - Annotations")]
		[DisplayName("Sell calculator")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 16)]
		public bool ChartAnnSellCalc
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
		public ToolbarProp()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ToolbarProp()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateLocalExecutorViewer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ToolbarProp SimulateConfigurableViewerAdapter()
		{
			return null;
		}
	}

	[Serializable]
	internal class HotKeyStore
	{
		internal static HotKeyStore AttachMixedAdapterAttribute;

		public HotKeyActionEnum Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return (HotKeyActionEnum)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		public string Combination
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HotKeyStore()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HotKeyStore()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateScheduledAttributeBuilder()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HotKeyStore GenerateMonoBuilderCollector()
		{
			return null;
		}
	}

	[Serializable]
	internal class TimeframePreset
	{
		internal static TimeframePreset ReplaceEngine;

		public string Id
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeframePreset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeframePreset(string id)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TimeframePreset()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAccessibleStreamManager()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeframePreset ExcludeCalc()
		{
			return null;
		}
	}

	internal Dictionary<HotKeyActionEnum, HotKeyAction> HotKeysActionDict;

	internal Dictionary<string, string> AlertSoundsDict;

	internal Dictionary<string, AdaptableDecider> TradingQtyDict;

	private static GeneralSettings SimulateDetachedResponder;

	public GeneralProp general
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

	public ToolbarProp Toolbar
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

	public List<TransactionRequester> AlertSounds
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

	public List<AdaptableDecider> TradingQtyInfos
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

	public List<HotKeyStore> HotkeyShortcuts
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

	public List<TimeframePreset> Timeframes
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Init(bool setDefault)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddHotKeyAction(HotKeyActionEnum action, string defaultCombination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneralSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GeneralSettings()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateExtendedAuthorizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneralSettings GenerateCustomService()
	{
		return null;
	}
}
