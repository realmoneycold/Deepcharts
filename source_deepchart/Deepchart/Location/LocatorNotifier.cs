using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class LocatorNotifier
{
	internal static byte[] m_LocalLocatorItems;

	internal static byte[] passiveLocators;

	internal static LocatorNotifier AttachRandomChain;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorNotifier()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorNotifier()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InterruptWrapper()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorNotifier GenerateReadableListener()
	{
		return null;
	}
}
