using System.Runtime.InteropServices;

namespace VolAnalysis.API.Requester;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 11)]
internal struct StatelessVisitorRequester
{
	internal static readonly StatelessVisitorRequester m_ConvertibleArgumentRequester/* Not supported: data(01 00 00 00 00 00 00 00 00 02 03) */;
}
