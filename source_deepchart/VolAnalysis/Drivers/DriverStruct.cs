using System.Runtime.CompilerServices;
using Deepchart.Registry;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class DriverStruct
{
	[CompilerGenerated]
	private RegMap m_PortableSubscriberDriver;

	[CompilerGenerated]
	private RegMap automatableConverter;

	private static DriverStruct SimulateOrderedStream;

	public RegMap Cut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public RegMap Copy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverStruct()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverStruct()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAlphabeticManager()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DriverStruct GenerateSegmentedMember()
	{
		return null;
	}
}
