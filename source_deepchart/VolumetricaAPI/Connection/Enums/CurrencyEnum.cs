using System;
using System.ComponentModel.DataAnnotations;

namespace VolumetricaAPI.Connection.Enums;

[Serializable]
internal enum CurrencyEnum
{
	[Display(Name = "€")]
	Eur,
	[Display(Name = "$")]
	Usd,
	Aud,
	Gbp,
	Xcd,
	Xof,
	Nzd,
	Nok,
	Xaf,
	Zar,
	Xpf,
	Clp,
	Dkk,
	Inr,
	Rub,
	Try,
	Dzd,
	Mru,
	Mad,
	Ils,
	Jod,
	Bnd,
	Sgd,
	Hkd,
	Chf,
	Ang,
	Shp,
	Fkp,
	Cad,
	Brl,
	Czk,
	Usdt,
	Usdc,
	Btc,
	Eth,
	Jpy,
	Sek,
	Cnh,
	Cop,
	Huf,
	Krw,
	Mxn,
	Twd
}
