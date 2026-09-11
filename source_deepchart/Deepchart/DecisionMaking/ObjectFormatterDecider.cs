using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class ObjectFormatterDecider : Exception
{
	internal static ObjectFormatterDecider EncodeMember;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ObjectFormatterDecider(string value = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectFormatterDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FilterProcessor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ObjectFormatterDecider JoinSender()
	{
		return null;
	}
}
