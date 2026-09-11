using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

[ProtoContract]
internal class RequesterManagerWrapper : IExtensible
{
	private IExtension m_RequesterWrapperWriter;

	[CompilerGenerated]
	private long _RequesterWriterChooserTotal;

	[CompilerGenerated]
	private long filteredLoggerRequesterPosition;

	[CompilerGenerated]
	private long requesterChooserAggregatorVol;

	[CompilerGenerated]
	private bool _IsExternalSystemRequester;

	[CompilerGenerated]
	private AllocatorChainRecommender m_MixedSelector;

	[CompilerGenerated]
	private string _RequesterAggregatorConnectionStatus;

	[CompilerGenerated]
	private double modularObserverRequester;

	private static RequesterManagerWrapper SimulateCentralBufferMonitor;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long PrepareTransformer
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long FetchJoinedEngine
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long FetchExpandableDic
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

	[ProtoMember(4)]
	public bool RequestGroupedTask
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
	public AllocatorChainRecommender RequestAdjustableFormatter
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

	[DefaultValue("")]
	[ProtoMember(6)]
	public string AccountId
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

	[ProtoMember(7)]
	public double RestartLogger
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
	IExtension IExtensible.GetExtensionObject(bool excludekey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterManagerWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequesterManagerWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RestartParameter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RequesterManagerWrapper GenerateOrderedStateArgument()
	{
		return null;
	}
}
