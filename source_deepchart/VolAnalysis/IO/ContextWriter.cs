using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Registry;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class ContextWriter
{
	[CompilerGenerated]
	private readonly ReadableDictionaryReg simpleWriterDic;

	public Dictionary<long, ScopeHandlerDecider.DeciderStrategyTransformer> Positions;

	private static ContextWriter AttachCommonVisitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public ReadableDictionaryReg RecordFilteredTransaction()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContextWriter(ReadableDictionaryReg res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachControllableDecryptor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ContextWriter GenerateRemoteDefinition()
	{
		return null;
	}
}
