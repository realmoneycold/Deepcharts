using System.Runtime.InteropServices;

namespace VolAnalysis.Creations;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct RoleTester
{
	internal static readonly RoleTester _PassiveValidatorSingleton/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
