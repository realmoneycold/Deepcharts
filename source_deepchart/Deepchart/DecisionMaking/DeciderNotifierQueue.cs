using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal static class DeciderNotifierQueue
{
	public static string _DividedTesterDeciderTitle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderNotifierQueue()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}
}
