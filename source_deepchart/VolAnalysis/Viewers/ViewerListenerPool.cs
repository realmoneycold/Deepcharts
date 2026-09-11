using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

[ProtoContract]
internal class ViewerListenerPool : IExtensible
{
	private IExtension m_FinalizerTemplate;

	[CompilerGenerated]
	private long _PassiveVisitorViewerOffset;

	[CompilerGenerated]
	private long mapperDictionaryIndex;

	private static ViewerListenerPool SimulateActiveStrategyRecord;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long ApplyAdjustableGateway
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long HandleHiddenSorter
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool isspec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerListenerPool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerListenerPool()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateFilteredRecordHandler()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerListenerPool SimulatePortableHandlerContext()
	{
		return null;
	}
}
