using System;

namespace VolumetricaAPI.Chart;

[Serializable]
internal enum SeriesType
{
	Line = 1,
	Candlestick = 2,
	OHLC = 4,
	Bars = 0x10,
	StackedBars = 0x20,
	Text = 0x40,
	Hidden = 0x80,
	Square = 0x100,
	Cicle = 0x200,
	Diamond = 0x400,
	TriangleUp = 0x800,
	TriangleDown = 0x1000,
	Cross = 0x2000,
	Ignore = 0x4000,
	BrokerLine = 0x8000,
	TriangleLeft = 0x10000,
	TriangleRight = 0x20000,
	Area = 0x40000,
	Range = 0x80000,
	ContLine = 0x100000,
	Triangle = 0x200000,
	CandleBody = 0x400000
}
