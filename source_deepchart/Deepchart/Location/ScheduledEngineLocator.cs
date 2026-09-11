using System.Runtime.InteropServices;

namespace Deepchart.Location;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct ScheduledEngineLocator
{
	internal static readonly ScheduledEngineLocator automatableWrapperLocator/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
