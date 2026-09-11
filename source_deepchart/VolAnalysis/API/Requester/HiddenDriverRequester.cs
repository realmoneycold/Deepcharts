using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

[ProtoContract]
internal class HiddenDriverRequester : IExtensible
{
	private IExtension m_AutomatedStackRequester;

	[CompilerGenerated]
	private readonly List<GroupedExtractorAllocator> m_RemoteCheckerRequesterList;

	private static HiddenDriverRequester AttachReadableCompilerPolicy;

	[ProtoMember(1)]
	public List<GroupedExtractorAllocator> Symbols
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool isres)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HiddenDriverRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HiddenDriverRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InsertContainer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HiddenDriverRequester WatchInspector()
	{
		return null;
	}
}
