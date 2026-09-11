using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal static class AutomatableStubWriter
{
	internal static AutomatableStubWriter TestWorker;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Size WriteCentralObject(Window var1)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Rectangle RecordAdvancedRequest(out nint v)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AutomatableStubWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachFlexibleCalcDic()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AutomatableStubWriter SimulateEditableDicThread()
	{
		return null;
	}
}
