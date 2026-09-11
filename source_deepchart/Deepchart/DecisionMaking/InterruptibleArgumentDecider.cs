using System.Runtime.InteropServices;

namespace Deepchart.DecisionMaking;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct InterruptibleArgumentDecider
{
	internal static readonly InterruptibleArgumentDecider m_DeciderEmitterProvider/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
