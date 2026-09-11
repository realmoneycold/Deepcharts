using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Connection.Enums;

namespace VolumetricaAPI.Symbols;

[Serializable]
internal abstract class SymbInfoBase
{
	private struct RemoteUserGenerator
	{
		public double Price;

		public double[] m_EditableComparatorArray;

		private static object InitCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoteUserGenerator(double key, double[] pred)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoteUserGenerator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ObserveSubscriber()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MonitorClient()
		{
			return null;
		}
	}

	private struct CombinedAttributeEncryptor
	{
		public int _EncryptorSystemCreatorLength;

		public int[] _ParserContainers;

		internal static object AttachInternalSorterContainer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombinedAttributeEncryptor(int startitem, int[] counter)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CombinedAttributeEncryptor()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachAdjustableContainerInspector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachAdapter()
		{
			return null;
		}
	}

	protected string _exchName;

	private TickCategoryEnum _category;

	protected int category;

	private decimal _TradableQuantityMinimum;

	private decimal _TradableQuantityIncrement;

	private string formatTickDec;

	private int _tickNumDecPlace;

	private static RemoteUserGenerator[] ItalianDoubleTickList;

	private static CombinedAttributeEncryptor[] ItalianIntTickList;

	private static RemoteUserGenerator[] HKDoubleTickList;

	private static CombinedAttributeEncryptor[] HKIntTickList;

	private static RemoteUserGenerator[] EtfDoubleTickList;

	private static CombinedAttributeEncryptor[] EtfIntTickList;

	private static SymbInfoBase RateMatcher;

	[DisplayName("Symbol Name")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
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

	[Category("General")]
	[DisplayName("Exchange Abbreviation")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public string ExchangeName
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public string Description
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
	public CurrencyEnum? BaseCurrency
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("General")]
	public CurrencyEnum? QuoteCurrency
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

	[DisplayName("Size Type")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Tick Size")]
	public TickSizeTypeEnum TypeTickSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TickSizeTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Tick Size")]
	[Category("Tick Size")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 8, IncrementValue = 0.25, MinValue = 0.0, MaxValue = 500.0)]
	public double TickSize
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

	[Category("Tick Size")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Tick Category (Italian Stocks)")]
	public TickCategoryEnum Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TickCategoryEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Category("Tick Size")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[DisplayName("Is /32")]
	public bool IsThirtySecondTick
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0, DecimalPosToShow = 2, IncrementValue = 0.25, MinValue = 0.0, MaxValue = 25000.0)]
	[DisplayName("Tick Value")]
	public double TickValue
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

	[Category("Trading")]
	[DisplayName("Order Commission")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5)]
	public double OrderCommission
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

	[Category("Trading")]
	[DisplayName("Commission Per Contract")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public bool IsCommissionPerContract
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3, MinValue = 0.0, MaxValue = 50000.0)]
	[DisplayName("Margin")]
	[Category("Trading")]
	public int Margin
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4, MinValue = 0.0, DecimalPosToShow = 5)]
	[DisplayName("Quantity Minimum")]
	[Category("Trading")]
	public decimal TradableQuantityMinimum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5, MinValue = 0.0, DecimalPosToShow = 5)]
	[DisplayName("Quantity Increment")]
	[Category("Trading")]
	public decimal TradableQuantityIncrement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	protected abstract void ExchangeNameSetted(string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string FormatPrice(double value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetStringFormatDec(int numDec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerCalculatorStack FromPinT(int PinT)
	{
		return (ViewerCalculatorStack)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetModPinT(int pInT, int numTicks)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPintOnTick(SingletonHandlerConnection.ObjectAuthenticatorLocator tick)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisualMatcherLocator FromPrice(double Price)
	{
		return (VisualMatcherLocator)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IntAddSubTicks(int PinT, int Tick)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IntAddSubTicks(int PinT, int Tick, out int p)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double RoundToCorrectPrice(double Price)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double RoundUpToCorrectPrice(double Price)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double RoundDownToCorrectPrice(double Price)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RoundToCorrectPinT(double PinT)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double DoubleAddSubTicks(double Price, int Tick)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDoubleTicksDiff(double IniPrice, double EndPrice)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIntTicksDiff(int IniPinT, int EndPinT)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public decimal CalculateTradingQtyFromPnl(double openPrice, double closePrice, double pnl)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double CalculatePriceOffsetFromPnl(decimal quantity, double pnl)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CalculateTickOffsetFromPnl(decimal quantity, double pnl)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double AddPriceOffsetFromPnl(decimal quantity, double price, double money)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double CalculatePnl(double openPrice, double closePrice, double quantity)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SymbInfoBase()
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
					if (num == 989)
					{
						goto end_IL_0012;
					}
					goto case 0;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					CreateItalianTickSize();
					return;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 3;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b8a398ef849b48a09f0c26204f046be9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CreateItalianTickSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SymbInfoBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAdaptableIteratorPredicate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymbInfoBase GenerateRandomPredicateExplorer()
	{
		return null;
	}
}
