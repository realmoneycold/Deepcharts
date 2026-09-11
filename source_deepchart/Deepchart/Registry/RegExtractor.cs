using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegExtractor
{
	public double activeReg;

	public int configurableSubscriberNum;

	public int m_AdjustableRegId;

	internal static RegExtractor SimulateModularConfiguration;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegExtractor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegExtractor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateLocalRecommender()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegExtractor GenerateConfigurableStruct()
	{
		return null;
	}
}
