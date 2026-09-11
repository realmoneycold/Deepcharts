using System.Runtime.CompilerServices;
using Deepchart.Location;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Generators;

internal class GeneratorBuilder
{
	public LocatorSelectorTransaction m_FilterAggregator;

	[CompilerGenerated]
	private ReceiverValue.LiteralSharerLocator generatorFinder;

	private static GeneratorBuilder GenerateExternalCreator;

	public ReceiverValue.LiteralSharerLocator BrokerInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneratorBuilder(ReceiverValue.LiteralSharerLocator asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GeneratorBuilder()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateAccessibleToken()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneratorBuilder RateCache()
	{
		return null;
	}
}
