using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.API.Requester;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

[ProtoContract]
internal class DetailedTagLocator : IExtensible, ITransformableExtractorLocator
{
	private IExtension m_BasicList;

	[CompilerGenerated]
	private long operationalObserverLocators;

	[CompilerGenerated]
	private DetachedFormatterRequester _LocatorCreatorCommand;

	[CompilerGenerated]
	private RequesterEngineEmitter m_OrderedMapperLocator;

	private static DetailedTagLocator SimulateExtendedAllocatorTree;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long RequestId
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
	public DetachedFormatterRequester ClearRandomPredicate
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

	[ProtoMember(3)]
	public RequesterEngineEmitter FindDividedSystem
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
	IExtension IExtensible.GetExtensionObject(bool acceptasset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DetailedTagLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DetailedTagLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateCustomTreeGenerator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DetailedTagLocator FilterManager()
	{
		return null;
	}
}
