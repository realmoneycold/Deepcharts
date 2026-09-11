using System;
using VolAnalysis.Creations;
using VolAnalysis.Generators;

namespace VolAnalysis.Drivers;

internal delegate void DriverRequestList(DateTime utcDt, string Symbol, double Price, int Vol, SingletonHandlerConnection.EncryptorCreatorNode TradeType, ulong AggrOrderID, ulong CounterOrderID, int mktCenterID, OSVersion AggrMode, double BidPrice, double AskPrice, double VolMultiplier);
