using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal static class BasicControllerAllocator
{
	public static Func<string, string> joinedLoggerAllocator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BasicControllerAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}
}
