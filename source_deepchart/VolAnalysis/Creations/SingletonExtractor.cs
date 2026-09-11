using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class SingletonExtractor
{
	[CompilerGenerated]
	private readonly bool m_IsSingletonCompiler;

	internal static SingletonExtractor RunNotifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public bool GenerateJoinedPool()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonExtractor(bool canfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonExtractor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateHiddenChain()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingletonExtractor TrackQueue()
	{
		return null;
	}
}
