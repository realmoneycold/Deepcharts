using System;
using System.ComponentModel.DataAnnotations;

namespace VolAnalysis.TradeCopier;

[Serializable]
internal enum TradeCopierCopyModeEnum
{
	[Display(Name = "Orders -> Orders")]
	OrdersToMarket,
	[Display(Name = "Orders -> Market")]
	OrdersToOrders
}
