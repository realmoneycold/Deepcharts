using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaServer;

[ProtoContract]
internal class HistResponseMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	internal static HistResponseMsg GenerateFilteredComparatorStrategy;

	[DefaultValue("")]
	[ProtoMember(1)]
	public string contractName
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

	[ProtoMember(2, Name = "tickList")]
	public List<TickInfo> tickLists
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(3, Name = "minuteList")]
	public List<MinuteInfo> minuteLists
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(4)]
	public bool isLastRec
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

	[ProtoMember(5)]
	[DefaultValue("")]
	public string logId
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
	public HistResponseMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HistResponseMsg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePortableStrategyRecord()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HistResponseMsg AwakeFinalizer()
	{
		return null;
	}
}
