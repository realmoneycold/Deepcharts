using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaProtcol.Info;

[ProtoContract]
internal class SymbolSearchRespMsg : IExtensible
{
	private IExtension __pbn__extensionData;

	private static SymbolSearchRespMsg SimulateSegmentedTemplateTag;

	[ProtoMember(1)]
	public List<SymbolRegistryMsg> Symbols
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
	public SymbolSearchRespMsg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SymbolSearchRespMsg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateCommonTagChecker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymbolSearchRespMsg AttachControllableCheckerTokenizer()
	{
		return null;
	}
}
