using System.Runtime.InteropServices;

namespace Deepchart.Registry;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 31)]
internal struct WriterStub
{
	internal static readonly WriterStub internalProcReg/* Not supported: data(01 00 00 00 00 00 00 00 00 02 03 00 00 00 01 01 00 00 00 04 03 00 00 00 02 02 00 00 00 05 06) */;
}
