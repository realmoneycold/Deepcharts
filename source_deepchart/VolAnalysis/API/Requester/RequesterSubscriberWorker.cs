using System.Runtime.InteropServices;

namespace VolAnalysis.API.Requester;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct RequesterSubscriberWorker
{
	internal static readonly RequesterSubscriberWorker _CustomizableProc/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
