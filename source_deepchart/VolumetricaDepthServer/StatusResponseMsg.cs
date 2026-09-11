using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaDepthServer;

[ProtoContract]
internal class StatusResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	internal static StatusResponseMsg GenerateConnectedWriterConverter;

	[ProtoMember(1, Name = "FeedConnected")]
	public List<string> FeedConnecteds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(2, Name = "ConnLost")]
	public List<string> ConnLosts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool createIfMissing)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StatusResponseMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusResponseMsg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateExpandableConverterAggregator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StatusResponseMsg GuideEnumerator()
	{
		return null;
	}
}
