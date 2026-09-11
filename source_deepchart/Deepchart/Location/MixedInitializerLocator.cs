using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

[ProtoContract]
internal class MixedInitializerLocator : IExtensible
{
	private IExtension _LocatorProcDecider;

	internal static MixedInitializerLocator SimulateGenericSpecSystem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool checkinit)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MixedInitializerLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MixedInitializerLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSimpleSystemProfiler()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MixedInitializerLocator AttachDetailedProfilerComparator()
	{
		return null;
	}
}
