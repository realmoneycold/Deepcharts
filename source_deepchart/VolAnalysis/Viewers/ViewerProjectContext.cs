using System.Runtime.InteropServices;

namespace VolAnalysis.Viewers;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct ViewerProjectContext
{
	internal static readonly ViewerProjectContext m_CustomizableChainViewer/* Not supported: data(01 00 00 00 01 01 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
