using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolumetricaProtcol.Trading;

namespace VolAnalysis.Wrapping;

internal delegate void LogicalEngineWrapper(WriterServerRecommender accSender, string Symbol, bool IsSnapshot, long OldOrderID, long OrderID, OrderInfoMsg.OrderStateEnum newStatus, ScopeHandlerDecider.ResponsiveSpecGeneratorTypes ordType, ScopeHandlerDecider.SequentialErrorRegType ordExpire, decimal PendingQuantity, decimal FilledQuantity, double Price, ScopeHandlerDecider.ComparatorProfilerReg? ocoSide, double AvgPrice = 0.0, double? CommissionsPaid = null, OrderInfoMsg.ErrorReasonEnum errReason = OrderInfoMsg.ErrorReasonEnum.Unknown);
