using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class AdaptableBuilderAllocator<T> : JsonConverter<T> where T : struct, Enum
{
	internal static object AttachInterruptiblePolicySorter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override T Read(ref Utf8JsonReader last, Type visitor, JsonSerializerOptions dir)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Utf8JsonWriter item, T attr, JsonSerializerOptions dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdaptableBuilderAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdaptableBuilderAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachIterableSorterContainer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AttachHiddenContainerInspector()
	{
		return null;
	}
}
