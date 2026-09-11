using System;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal delegate void OrderedTransmitterReg(DateTime utcDt, string Symbol, long OrderId, GroupedHandlerWrapperKind Action, double Price, int PendingQty, bool isAsk, int NewExecQty, int TotExecQty);
