using System;
using System.ComponentModel.DataAnnotations;

namespace VolAnalysis.TradeCopier;

[Serializable]
internal enum TradeCopierResyncroModeEnum
{
	None,
	[Display(Name = "Full market at best price")]
	FullMarketAtBestPrice,
	[Display(Name = "Close only at best price")]
	CloseOnlyAtBestPrice
}
