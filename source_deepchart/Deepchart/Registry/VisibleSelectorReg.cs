using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

[ProtoContract]
internal class VisibleSelectorReg : IExtensible
{
	private IExtension _RegNodeConsumer;

	[CompilerGenerated]
	private bool isVirtualTokenReg;

	internal static VisibleSelectorReg AttachCustomTransformerAllocator;

	[ProtoMember(1)]
	public bool CountThread
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
	IExtension IExtensible.GetExtensionObject(bool gettask)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisibleSelectorReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisibleSelectorReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAttachedAllocatorTree()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VisibleSelectorReg CombineOrder()
	{
		return null;
	}
}
