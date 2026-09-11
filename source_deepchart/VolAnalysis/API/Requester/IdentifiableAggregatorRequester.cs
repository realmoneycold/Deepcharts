using System.Runtime.InteropServices;

namespace VolAnalysis.API.Requester;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 46)]
internal struct IdentifiableAggregatorRequester
{
	internal static readonly IdentifiableAggregatorRequester m_RequesterAnnotationSubscriber/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03 00 00 00 01 01 00 00 00 04 00 00 00 02 02 00 00 00 05 00 00 00 03 03 00 00 00 06) */;
}
