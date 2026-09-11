using System.Runtime.CompilerServices;
using Deepchart.Location;
using ProtoBuf;
using VolAnalysis.Generators;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

[ProtoContract]
internal class SortedEventSingleton : IExtensible, ITransformableExtractorLocator
{
	private IExtension _ProcTransmitter;

	[CompilerGenerated]
	private long m_SingletonTransformerPoolFlag;

	[CompilerGenerated]
	private MixedChainSingleton m_HiddenHandlerSingleton;

	[CompilerGenerated]
	private InternalTokenGenerator extendedConnectionSingleton;

	private static SortedEventSingleton JoinMember;

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
	public MixedChainSingleton JoinEvaluator
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
	public InternalTokenGenerator FlushPredictor
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
	IExtension IExtensible.GetExtensionObject(bool excluderes)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SortedEventSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SortedEventSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ResumeProcessor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SortedEventSingleton SimulateFlexibleObserverRole()
	{
		return null;
	}
}
