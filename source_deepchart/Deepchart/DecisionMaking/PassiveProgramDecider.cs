using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

[ProtoContract]
internal class PassiveProgramDecider : IExtensible
{
	private IExtension locatorProcessor;

	[CompilerGenerated]
	private readonly List<AuditorComparatorDecider> _DeciderExtractorEvaluators;

	private static PassiveProgramDecider GenerateResponsiveReporterTransmitter;

	[ProtoMember(1)]
	public List<AuditorComparatorDecider> Symbols
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool updatekey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveProgramDecider()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PassiveProgramDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSetTransmitterProc()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PassiveProgramDecider VisitPredicate()
	{
		return null;
	}
}
