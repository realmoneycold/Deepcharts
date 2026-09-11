using System.Runtime.CompilerServices;
using Deepchart.Location;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaProtcol.Info;

[ProtoContract]
internal class ServerResponseMsg : IExtensible, ITransformableExtractorLocator
{
	private IExtension __pbn__extensionData;

	internal static ServerResponseMsg ReceiveField;

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
	public ContractRespMsg contractIDResp
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
	public SymbolSearchRespMsg SymbolSearchRespMsg
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
	internal static bool DecompressEnumerator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerResponseMsg AttachSimpleSpecSystem()
	{
		return null;
	}
}
