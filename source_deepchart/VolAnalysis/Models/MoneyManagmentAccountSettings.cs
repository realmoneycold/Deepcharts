using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Models;

[Serializable]
internal class MoneyManagmentAccountSettings
{
	[Serializable]
	internal class SymbolSetting
	{
		internal static SymbolSetting GenerateVisibleLocatorVerifier;

		[StaticStructAllocator(IsVisible = false)]
		public string Name
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

		[Category("Limit Quantity")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, IsVisible = false)]
		public bool LimitQtyEnable
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

		[Category("Limit Quantity")]
		[DisplayName("Maximum")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, IsVisible = false)]
		public int LimitQtyValue
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
		[DisplayName("Enable")]
		[Category("Limit Trading Hours (Exchange timezone)")]
		public bool LimitTradingHoursEnable
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
		[DisplayName("Begin")]
		[Category("Limit Trading Hours (Exchange timezone)")]
		public TimeSpan TradingHoursIniTime
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

		[DisplayName("End")]
		[Category("Limit Trading Hours (Exchange timezone)")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public TimeSpan TradingHoursEndTime
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SymbolSetting()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SymbolSetting()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IncludeStruct()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SymbolSetting AttachTransformableProviderParser()
		{
			return null;
		}
	}

	[Serializable]
	internal enum ValueUnitEnum
	{
		Money,
		Percentage
	}

	[Serializable]
	internal enum ActionEnum
	{
		DailyPause,
		TimedPause,
		Flat
	}

	private static MoneyManagmentAccountSettings UpdateEmitter;

	[StaticStructAllocator(IsVisible = false)]
	public string ConnectionHash
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

	[StaticStructAllocator(IsVisible = false)]
	public string? AccountId
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

	[StaticStructAllocator(IsVisible = false)]
	public bool InhibitChangesUntilNextSession
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
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public bool EnableMoneyManagment
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
	[DisplayName("Symbols - All categories")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public bool SymbolIncludeAllCategory
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
	[DisplayName("Symbols - Filter category")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public GeneratorConfigurationArgument.ModuleLoggerKind SymbolFilterCategory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorConfigurationArgument.ModuleLoggerKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Symbols - Exclude not listed")]
	[Category("General")]
	public bool ExcludeSymbolNotListed
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

	[Category("Daily Loss Limit")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool DLLEnable
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

	[DisplayName("Value")]
	[Category("Daily Loss Limit")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2)]
	public double DLLValue
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[DisplayName("Unit")]
	[Category("Daily Loss Limit")]
	public ValueUnitEnum DLLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Daily Profit Limit")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool DPLEnable
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 2)]
	[Category("Daily Profit Limit")]
	[DisplayName("Value")]
	public double DPLValue
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Unit")]
	[Category("Daily Profit Limit")]
	public ValueUnitEnum DPLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Daily Profit Limit")]
	[DisplayName("Include open positions")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public bool DPLIncludeOpenPositions
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

	[Category("Trail Loss Limit")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool TLLEnable
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

	[Category("Trail Loss Limit")]
	[DisplayName("Action")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public ActionEnum TLLAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	[Category("Trail Loss Limit")]
	[DisplayName("Value")]
	public double TLLValue
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

	[Category("Trail Loss Limit")]
	[DisplayName("Unit")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public ValueUnitEnum TLLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Trail Loss Limit")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
	[DisplayName("Include open positions")]
	public bool TLLIncludeOpenPositions
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

	[Category("Trail Loss Limit")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
	[DisplayName("Pause time (minutes)")]
	public int TLLTimedMins
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

	[Category("Portfolio Loss Limit")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public bool PortLLEnable
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

	[Category("Portfolio Loss Limit")]
	[DisplayName("Action")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	public ActionEnum PortLLAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Portfolio Loss Limit")]
	[DisplayName("Value")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public double PortLLValue
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	[DisplayName("Unit")]
	[Category("Portfolio Loss Limit")]
	public ValueUnitEnum PortLLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
	[DisplayName("Pause time (minutes)")]
	[Category("Portfolio Loss Limit")]
	public int PortLLTimedMins
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

	[Category("Portfolio Profit Limit")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	public bool PortPLEnable
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

	[Category("Portfolio Profit Limit")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	[DisplayName("Action")]
	public ActionEnum PortPLAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Portfolio Profit Limit")]
	[DisplayName("Value")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	public double PortPLValue
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

	[Category("Portfolio Profit Limit")]
	[DisplayName("Unit")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	public ValueUnitEnum PortPLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Pause time (minutes)")]
	[Category("Portfolio Profit Limit")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public int PortPLTimedMins
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Position Loss Limit")]
	public bool PosLLEnable
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

	[Category("Position Loss Limit")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
	[DisplayName("Action")]
	public ActionEnum PosLLAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Position Loss Limit")]
	[DisplayName("Value")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	public double PosLLValue
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

	[DisplayName("Unit")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	[Category("Position Loss Limit")]
	public ValueUnitEnum PosLLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
	[DisplayName("Cumulative per symbol")]
	[Category("Position Loss Limit")]
	public bool PosLLCumulativePerSymbol
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

	[Category("Position Loss Limit")]
	[DisplayName("Pause time (minutes)")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
	public int PosLLTimedMins
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

	[Category("Position Profit Limit")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool PosPLEnable
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
	[DisplayName("Action")]
	[Category("Position Profit Limit")]
	public ActionEnum PosPLAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Position Profit Limit")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	[DisplayName("Value")]
	public double PosPLValue
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3)]
	[Category("Position Profit Limit")]
	[DisplayName("Unit")]
	public ValueUnitEnum PosPLUnit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ValueUnitEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 4)]
	[Category("Position Profit Limit")]
	[DisplayName("Cumulative per symbol")]
	public bool PosPLCumulativePerSymbol
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

	[Category("Position Profit Limit")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 5)]
	[DisplayName("Pause time (minutes)")]
	public int PosPLTimedMins
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0, IsVisible = false)]
	[DisplayName("Enable")]
	[Category("Trade Limits")]
	public bool MaxTradesLimitEnable
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1, IsVisible = false)]
	[DisplayName("Max number of trades per day")]
	[Category("Trade Limits")]
	public int MaxTradesLimitValue
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

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Limit Trading Hours (EST timezone)")]
	public bool LimitTradingHoursEnable
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

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 1)]
	[DisplayName("Begin")]
	[Category("Limit Trading Hours (EST timezone)")]
	public TimeSpan LimitTradingHoursIniTime
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

	[Category("Limit Trading Hours (EST timezone)")]
	[DisplayName("End")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 2)]
	public TimeSpan LimitTradingHoursEndTime
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

	[StaticStructAllocator(IsVisible = false)]
	public SymbolSetting[] SymbolQtys
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
	public bool Validate(out string reason)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoneyManagmentAccountSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MoneyManagmentAccountSettings()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachVisibleExtractor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MoneyManagmentAccountSettings GenerateSequentialFinder()
	{
		return null;
	}
}
