using System.Runtime.InteropServices;

namespace Deepchart.Registry;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct ModularTreeReg
{
	internal static readonly ModularTreeReg m_RegPolicyStrategy/* Not supported: data(01 00 00 00 01 01 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
