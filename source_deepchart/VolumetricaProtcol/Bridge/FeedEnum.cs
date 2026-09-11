using ProtoBuf;

namespace VolumetricaProtcol.Bridge;

[ProtoContract]
internal enum FeedEnum
{
	IQFeed = 1,
	MetaTrader5 = 2,
	[ProtoEnum(Name = "CQG")]
	Cqg = 3,
	Directa = 4,
	[ProtoEnum(Name = "IB")]
	Ib = 5,
	Rithmic = 6,
	Webank = 7,
	Sella = 8,
	IWBank = 9,
	VolRT = 11,
	MetaTrader4 = 12,
	DxFeed = 13,
	VolVirtual = 14,
	FutuAPI = 15,
	GainCapital = 16,
	VolumetricaRt = 17,
	VQuote = 18,
	Giotto = 19,
	Sphera = 20,
	Binance = 21,
	Coinbase = 22,
	DxFeedDelayed = 23,
	DxFeedData = 24,
	DxFeedProp = 25,
	VolumetricaFxData = 26,
	VolumetricaFxProp = 27,
	VSim = 28,
	RithmicRAPI = 29
}
