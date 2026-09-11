using System.Runtime.InteropServices;

namespace VolAnalysis.Drivers;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct DispatcherComparatorDriver
{
	internal static readonly DispatcherComparatorDriver centralSchema/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
