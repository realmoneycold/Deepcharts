using System.Runtime.InteropServices;

namespace VolAnalysis.Viewers;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct ViewerContextProxy
{
	internal static readonly ViewerContextProxy logicalStructViewer/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
