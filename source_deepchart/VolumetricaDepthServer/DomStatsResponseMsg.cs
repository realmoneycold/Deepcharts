using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaDepthServer;

[ProtoContract]
internal class DomStatsResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	private static DomStatsResponseMsg SimulateInternalValueTracker;

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
	[DefaultValue("")]
	public string JsonData
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
	IExtension IExtensible.GetExtensionObject(bool createIfMissing)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DomStatsResponseMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DomStatsResponseMsg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CloneWorker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DomStatsResponseMsg SimulateInterruptibleListLocator()
	{
		return null;
	}
}
