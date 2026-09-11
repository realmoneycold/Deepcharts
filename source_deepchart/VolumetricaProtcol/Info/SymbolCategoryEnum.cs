using ProtoBuf;

namespace VolumetricaProtcol.Info;

[ProtoContract]
internal enum SymbolCategoryEnum
{
	Future = 1,
	Forex,
	Index,
	Spot,
	Option,
	Stock,
	Etf,
	Crypto,
	CryptoFuture,
	CryptoPerpetual
}
