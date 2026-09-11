using System.Runtime.InteropServices;

namespace VolAnalysis.API.Requester;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
internal struct VirtualConnectionRequester
{
	internal static readonly VirtualConnectionRequester m_AdjustableTracerRequester/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 01 01 00 00 00 03 00 00 00 02 02 00 00 00 04) */;
}
