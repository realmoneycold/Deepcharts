using System.Runtime.InteropServices;

namespace VolAnalysis.IO;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
internal struct ReadableFieldWriter
{
	internal static readonly ReadableFieldWriter encryptorDecoratorWriter/* Not supported: data(01 00 00 00 01 01 00 00 00 02 00 00 00 00 00 00 00 00 03 04) */;
}
