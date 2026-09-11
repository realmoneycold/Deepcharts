using ProtoBuf;

namespace Deepchart.Location;

[ProtoContract]
internal enum LocatorQueueTransferProtocol
{
	Imbalance,
	TimeEndAuct,
	PriceEndAuct,
	ControlPrice,
	VarControlP,
	RegularType,
	ReferencePrice,
	PrevReferencePrice,
	CumulativeVol,
	TotalTrades,
	StockNumber
}
