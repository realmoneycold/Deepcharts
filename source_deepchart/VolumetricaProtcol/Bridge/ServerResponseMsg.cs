using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaProtcol.Bridge;

[ProtoContract]
internal class ServerResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	private static ServerResponseMsg GenerateIterableParserProgram;

	[ProtoMember(1, Name = "status")]
	public ConnectionStatusEnum Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ConnectionStatusEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(2, Name = "msg")]
	[DefaultValue("")]
	public string Msg
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
	public int infoPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(4)]
	public int dataPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(5)]
	public int tradingPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(6)]
	public int histPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
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
	internal static bool GenerateHiddenProgramPublisher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerResponseMsg GenerateModularPublisherParameter()
	{
		return null;
	}
}
