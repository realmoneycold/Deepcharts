using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaDepthServer;

[ProtoContract]
internal class ServerResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	private static ServerResponseMsg FillEncryptor;

	[ProtoMember(1)]
	public HistResponseMsg HistResponse
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
	public StatusResponseMsg StatusResp
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
	public DomStatsResponseMsg DomStatsResp
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
	internal static bool FindChooser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerResponseMsg IncludeFunction()
	{
		return null;
	}
}
