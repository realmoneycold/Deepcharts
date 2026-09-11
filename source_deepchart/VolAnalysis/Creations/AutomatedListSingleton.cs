using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class AutomatedListSingleton : DefaultJsonTypeInfoResolver
{
	internal static AutomatedListSingleton GenerateMixedMapperMatcher;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override JsonTypeInfo GetTypeInfo(Type param, JsonSerializerOptions result)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutomatedListSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AutomatedListSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateScheduledMatcherReporter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AutomatedListSingleton MeasureMember()
	{
		return null;
	}
}
