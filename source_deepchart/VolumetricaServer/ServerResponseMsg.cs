using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaServer;

[ProtoContract]
internal class ServerResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	internal static ServerResponseMsg PatchSpec;

	[ProtoMember(1)]
	public HistResponseMsg HistResp
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

	[ProtoMember(2)]
	public HistResponseV2Msg HistRespV2
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
	public ServerResponseMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerResponseMsg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateSimplePredicateExplorer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerResponseMsg SimulateDetailedExplorerSpec()
	{
		return null;
	}
}
