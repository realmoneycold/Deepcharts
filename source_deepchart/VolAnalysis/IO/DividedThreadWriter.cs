using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class DividedThreadWriter : JsonConverter<string>
{
	internal static DividedThreadWriter SimulateIdentifiableFinalizerResolver;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string Read(ref Utf8JsonReader config, Type token, JsonSerializerOptions dir)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Utf8JsonWriter res, string second, JsonSerializerOptions state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DividedThreadWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DividedThreadWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachInternalGatewayCompiler()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DividedThreadWriter GenerateAdjustableCompilerPolicy()
	{
		return null;
	}
}
