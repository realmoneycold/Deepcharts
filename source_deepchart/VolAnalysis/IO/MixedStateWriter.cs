using System;

namespace VolAnalysis.IO;

internal delegate void MixedStateWriter(DateTime utcDt, string Symbol, double Price, int Qty, int NumOffers, bool isAsk, double VolMultiplier, double bestBboBid, double bestBboAsk);
