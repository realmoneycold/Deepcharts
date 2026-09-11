using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

[ProtoContract]
internal class AllocatorSenderValidator : IExtensible
{
	private IExtension modularQueueAllocator;

	internal static AllocatorSenderValidator ResetMatcher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool isres)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorSenderValidator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorSenderValidator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachLogicalMapperMatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorSenderValidator DisableTransmitter()
	{
		return null;
	}
}
