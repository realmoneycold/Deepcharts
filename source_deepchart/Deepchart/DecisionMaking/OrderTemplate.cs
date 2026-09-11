using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class OrderTemplate
{
	internal static OrderTemplate GenerateSimpleCheckerTokenizer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrderTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderTemplate()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDetailedTokenizerEvaluator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OrderTemplate GenerateVisualEvaluatorPool()
	{
		return null;
	}
}
