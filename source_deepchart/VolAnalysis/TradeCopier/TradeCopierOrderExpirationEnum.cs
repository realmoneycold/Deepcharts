using System;

namespace VolAnalysis.TradeCopier;

[Serializable]
internal enum TradeCopierOrderExpirationEnum
{
	None,
	ToMarketAfterMs,
	CancelAfterMs
}
