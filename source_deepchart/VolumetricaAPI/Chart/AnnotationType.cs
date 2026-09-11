using System;
using System.ComponentModel.DataAnnotations;

namespace VolumetricaAPI.Chart;

[Serializable]
internal enum AnnotationType
{
	Line,
	Rectangle,
	Ellipse,
	Pencil,
	ParallelLines,
	PriceProjection,
	PriceRetracement,
	PriceFan,
	HorizontalLine,
	VerticalLine,
	Text,
	Diamond,
	Volume,
	Pie,
	Circle,
	Triangle,
	[Display(Name = "Volume Profile")]
	VbpProfile,
	Candlestick,
	Square,
	HorizontalRay,
	MultiTextLine,
	BackgroundBar,
	MultiRectangle,
	ArrowUp,
	ArrowDown,
	DiamondLine,
	ArrowRight,
	ArrowLeft,
	PosCalculator,
	ButtonStack,
	[Display(Name = "VWAP Anchored")]
	VWAPAnchored,
	RulerLine,
	Pitchfork,
	Heatmap,
	Meter
}
