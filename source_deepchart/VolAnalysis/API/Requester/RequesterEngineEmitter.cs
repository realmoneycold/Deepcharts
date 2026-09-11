using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

[ProtoContract]
internal class RequesterEngineEmitter : IExtensible
{
	[ProtoContract]
	internal enum LocatorExtractorQueueEnum
	{
		Minute = 0,
		Daily = 1,
		Volume = 3
	}

	private IExtension _ComparatorPolicy;

	[CompilerGenerated]
	private long emitterAttributeRequesterAge;

	[CompilerGenerated]
	private LocatorExtractorQueueEnum _MapCalc;

	[CompilerGenerated]
	private int _DistributorCollectorRate;

	[CompilerGenerated]
	private long m_ActiveFunctionRequesterId;

	[CompilerGenerated]
	private long _SetContainerRequesterPos;

	[CompilerGenerated]
	private bool isDynamicClient;

	internal static RequesterEngineEmitter GenerateCustomizableRequesterFilter;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long ScanFilter
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
	public LocatorExtractorQueueEnum QueryPortableAllocator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorExtractorQueueEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int QueryCentralRunner
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long CloseAuditor
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
	public long QueryControllableRequester
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

	[ProtoMember(6)]
	public bool FormatEngine
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
	IExtension IExtensible.GetExtensionObject(bool hasinit)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterEngineEmitter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequesterEngineEmitter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAutomatedFilterWriter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RequesterEngineEmitter BuildResponder()
	{
		return null;
	}
}
