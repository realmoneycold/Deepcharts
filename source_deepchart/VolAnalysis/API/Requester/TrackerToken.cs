using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using ProtoBuf;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

[ProtoContract]
internal class TrackerToken : IExtensible, ITransformableExtractorLocator
{
	private IExtension m_ConsumerProfile;

	[CompilerGenerated]
	private long _GeneralFinderRequesterErrorCode;

	[CompilerGenerated]
	private HiddenDriverRequester _RequesterAttributeEnumerator;

	[CompilerGenerated]
	private PassiveProgramDecider enumeratorCollectionRequester;

	[CompilerGenerated]
	private StaticDecoratorWriter _RequesterCollectionBuilder;

	internal static TrackerToken AttachExternalModuleDecorator;

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
	public HiddenDriverRequester DirectAuditor
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
	public PassiveProgramDecider HandleAnnotation
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

	[ProtoMember(4, Name = "ping")]
	public StaticDecoratorWriter FetchPassivePredicate
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
	IExtension IExtensible.GetExtensionObject(bool usev)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrackerToken()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TrackerToken()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateAccessibleDecoratorValidator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TrackerToken SimulatePassiveValidatorReg()
	{
		return null;
	}
}
