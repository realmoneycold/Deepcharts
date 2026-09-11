using System.Runtime.InteropServices;

namespace VolAnalysis.Drivers;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct DriverLoggerDispatcher
{
	internal static readonly DriverLoggerDispatcher m_SolverProfile/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
