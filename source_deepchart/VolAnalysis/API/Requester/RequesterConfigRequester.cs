using Deepchart.DecisionMaking;
using VolumetricaProtcol.Trading;

namespace VolAnalysis.API.Requester;

internal delegate void RequesterConfigRequester(string Symbol, long OldOrderID, long OrderID, OrderInfoMsg.OrderStateEnum newStatus, ScopeHandlerDecider.ResponsiveSpecGeneratorTypes ordType, ScopeHandlerDecider.SequentialErrorRegType ordExpire, decimal PendingQuantity, decimal FilledQuantity, double Price, bool isOcoOrd, double AvgPrice = 0.0, OrderInfoMsg.ErrorReasonEnum errReason = OrderInfoMsg.ErrorReasonEnum.Unknown);
