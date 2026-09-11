using System.Runtime.InteropServices;

namespace Deepchart.Management;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct AllocatorProcessorModel
{
	internal static readonly AllocatorProcessorModel m_IsolatedComparator/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
