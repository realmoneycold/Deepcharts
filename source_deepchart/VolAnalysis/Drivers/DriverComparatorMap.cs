using System.Runtime.InteropServices;

namespace VolAnalysis.Drivers;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct DriverComparatorMap
{
	internal static readonly DriverComparatorMap _ResponsiveConnectionDriver/* Not supported: data(01 00 00 00 01 01 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
