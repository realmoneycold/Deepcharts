using System;

namespace VolAnalysis.Wrapping;

internal delegate void WrapperHandlerRequester(DateTime utcDt, string Symbol, ComparatorModuleKind BidAskInfo, double Price, int Vol, int mktCenterID, double VolMultiplier);
