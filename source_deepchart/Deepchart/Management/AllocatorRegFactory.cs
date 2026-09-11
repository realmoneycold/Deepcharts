using System.Runtime.InteropServices;

namespace Deepchart.Management;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct AllocatorRegFactory
{
	internal static readonly AllocatorRegFactory _AlphabeticTemplate/* Not supported: data(01 00 00 00 01 01 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
