using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using Deepchart.Registry;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

[ProtoContract]
internal class MixedChainSingleton : IExtensible
{
	private IExtension m_WatcherStream;

	[CompilerGenerated]
	private long simpleWriterSingletonCount;

	[CompilerGenerated]
	private long singletonPoolGateways;

	[CompilerGenerated]
	private readonly List<RegResolverDecryptor> singletonGatewayStructs;

	[CompilerGenerated]
	private AllocatorCertControlStoreType _ControllableControllerRequester;

	[CompilerGenerated]
	private bool isSegmentedExtractorSingleton;

	internal static MixedChainSingleton AttachConvertibleConverterAggregator;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long InstantiateDetachedUser
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
	public long EnsureAttachedNode
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

	[ProtoMember(3)]
	public List<RegResolverDecryptor> Ticks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(4)]
	public AllocatorCertControlStoreType SerializeResolver
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorCertControlStoreType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(5)]
	public bool Success
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool forcevar1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MixedChainSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MixedChainSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GetService()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MixedChainSingleton RemoveSchema()
	{
		return null;
	}
}
