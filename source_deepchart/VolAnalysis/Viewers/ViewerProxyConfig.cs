using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class ViewerProxyConfig
{
	private static bool _IsViewerConfigLocator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerProxyConfig()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}
}
