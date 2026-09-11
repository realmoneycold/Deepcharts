using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

[ProtoContract]
internal class GroupedExtractorAllocator : IExtensible
{
	private IExtension mixedReporter;

	[CompilerGenerated]
	private long _ProxySetErrorCode;

	[CompilerGenerated]
	private bool m_IsPolicyTokenizer;

	[CompilerGenerated]
	private bool _IsAllocatorCalcExplorer;

	internal static GroupedExtractorAllocator SimulateSeparatedContainerInspector;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long VisitWrapper
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
	public bool ReceiveTransformableTokenizer
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

	[ProtoMember(3)]
	public bool AdaptDriver
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
	IExtension IExtensible.GetExtensionObject(bool iskey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupedExtractorAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GroupedExtractorAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateScalableInspectorTransaction()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GroupedExtractorAllocator AttachVirtualTransactionError()
	{
		return null;
	}
}
