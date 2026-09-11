using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

[ProtoContract]
internal class FilteredErrorDriver : IExtensible
{
	private IExtension _GlobalTask;

	[CompilerGenerated]
	private long driverHandlerConfigVol;

	[CompilerGenerated]
	private string staticTracerDriverTag;

	internal static FilteredErrorDriver GenerateStatelessProfilerComparator;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long RunTransferableFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(2)]
	[DefaultValue("")]
	public string AccountId
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
	IExtension IExtensible.GetExtensionObject(bool appendlast)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FilteredErrorDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilteredErrorDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateActiveComparatorStrategy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FilteredErrorDriver SimulateFilteredStrategyRecord()
	{
		return null;
	}
}
