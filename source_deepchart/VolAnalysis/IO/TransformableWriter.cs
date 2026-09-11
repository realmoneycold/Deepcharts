using System.Runtime.CompilerServices;
using System.Windows;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class TransformableWriter : ResourceDictionary
{
	internal static TransformableWriter WatchExecutor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransformableWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetachSystem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TransformableWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ConvertViewer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TransformableWriter CountAdapter()
	{
		return null;
	}
}
