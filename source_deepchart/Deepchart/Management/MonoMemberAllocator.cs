using System.Runtime.CompilerServices;
using Deepchart.Location;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

[ProtoContract]
internal class MonoMemberAllocator : IExtensible
{
	private IExtension logicalServerAllocator;

	[CompilerGenerated]
	private LocatorQueueTransferProtocol readableRequesterAllocator;

	[CompilerGenerated]
	private long centralConverterCap;

	[CompilerGenerated]
	private double _IsolatedReporterAllocator;

	internal static MonoMemberAllocator TestCreator;

	[ProtoMember(1)]
	public LocatorQueueTransferProtocol AllocateScalableBuffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorQueueTransferProtocol)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long ParsePolicy
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
	public double ReleaseSetTag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool valueinstall)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MonoMemberAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MonoMemberAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateFlexibleRoleController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MonoMemberAllocator ParseElement()
	{
		return null;
	}
}
