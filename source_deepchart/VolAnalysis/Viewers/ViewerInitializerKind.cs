namespace VolAnalysis.Viewers;

internal enum ViewerInitializerKind
{
	None = 0,
	AdvDom = 1,
	AdvTimeAndSales = 2,
	CorrelationViewer = 4,
	Chart = 8,
	Scanner = 0x10,
	CompactDom = 0x20
}
