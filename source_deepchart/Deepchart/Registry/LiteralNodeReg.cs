using System.Runtime.InteropServices;

namespace Deepchart.Registry;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct LiteralNodeReg
{
	internal static readonly LiteralNodeReg regStrategyAnnotation/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
