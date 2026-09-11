using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VolAnalysis.Viewers;

[StructLayout(LayoutKind.Auto)]
[InlineArray(2)]
internal struct OperationalCacheViewer<T>
{
	[CompilerGenerated]
	private T m_CheckerTransformer;
}
