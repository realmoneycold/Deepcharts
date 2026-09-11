using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Registry;
using ProtoBuf;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

[ProtoContract]
internal class TokenIteratorDecider : IExtensible
{
	private IExtension _DeciderSynchronizerRole;

	[CompilerGenerated]
	private VirtualCollectionWriter m_DeciderIteratorProc;

	[CompilerGenerated]
	private VisibleSelectorReg m_ObserverList;

	[CompilerGenerated]
	private DecryptorNodeLocator m_ResponsiveReceiverDecider;

	private static TokenIteratorDecider AttachGlobalPoolTracer;

	[ProtoMember(1)]
	public VirtualCollectionWriter StoreAuthenticator
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
	public VisibleSelectorReg TraverseRandomReporter
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
	public DecryptorNodeLocator InsertStack
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
	IExtension IExtensible.GetExtensionObject(bool calcitem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TokenIteratorDecider()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenIteratorDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDetachedTracerPredictor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TokenIteratorDecider SaveObject()
	{
		return null;
	}
}
