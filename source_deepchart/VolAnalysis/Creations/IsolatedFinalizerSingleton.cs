using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class IsolatedFinalizerSingleton : JsonConverter<float>
{
	private static IsolatedFinalizerSingleton IncludeQueue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float Read(ref Utf8JsonReader item, Type cust, JsonSerializerOptions consumer)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Utf8JsonWriter i, float second, JsonSerializerOptions dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsolatedFinalizerSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsolatedFinalizerSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachConnectedThreadMap()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsolatedFinalizerSingleton AttachExpandableMapTask()
	{
		return null;
	}
}
