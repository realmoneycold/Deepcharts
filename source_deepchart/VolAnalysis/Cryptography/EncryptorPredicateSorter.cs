using System.Runtime.InteropServices;

namespace VolAnalysis.Cryptography;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 19)]
internal struct EncryptorPredicateSorter
{
	internal static readonly EncryptorPredicateSorter _AuthenticatorSubscriber/* Not supported: data(01 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00 00 03) */;
}
