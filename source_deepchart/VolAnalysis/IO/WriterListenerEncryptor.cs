using System.Runtime.InteropServices;

namespace VolAnalysis.IO;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 11)]
internal struct WriterListenerEncryptor
{
	internal static readonly WriterListenerEncryptor _ConnectedCacheWriterList/* Not supported: data(01 00 00 00 00 00 00 00 00 02 03) */;
}
