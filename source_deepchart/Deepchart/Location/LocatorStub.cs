using System.Runtime.CompilerServices;
using System.Windows.Threading;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal static class LocatorStub
{
	private static LocatorStub CloneBridge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteLogger(Dispatcher first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PlanTester(string first, RouteOptionKind map = (RouteOptionKind)0, int? pool = 5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorStub()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePortableAttribute()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorStub AttachSymbolicBuilder()
	{
		return null;
	}
}
