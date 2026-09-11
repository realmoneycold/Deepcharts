using System;

namespace VolumetricaAPI.Chart;

[Serializable]
internal enum ControlState
{
	Pointer,
	Hand,
	HandX,
	HandY,
	HandXY,
	XZooming,
	YResizing,
	Line,
	HorizontalLine,
	VerticalLine,
	ParallelLines,
	PriceProjection,
	PriceRetracement,
	PriceFan,
	Rectangle,
	Ellipse,
	Pencil,
	VolumeProfile,
	Crosshair,
	ZoomRange,
	BuyLimit,
	SellLimit,
	BuyStop,
	SellStop,
	BuyStopLimit,
	SellStopLimit,
	TrailingBuy,
	TrailingSell,
	Text,
	HorizontalRay,
	GlobalCrosshair,
	Ruler,
	RulerAnnotation,
	BuyCalculator,
	SellCalculator,
	VWAP,
	Pitchfork
}
