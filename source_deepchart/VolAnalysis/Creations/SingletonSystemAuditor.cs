using System.Runtime.InteropServices;

namespace VolAnalysis.Creations;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct SingletonSystemAuditor
{
	internal static readonly SingletonSystemAuditor cacheProfile/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
