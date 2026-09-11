using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Media;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class AdjustableDeciderReg : JsonConverter<Color>
{
	private static AdjustableDeciderReg AttachAutomatableTaskBridge;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Color Read(ref Utf8JsonReader last, Type cfg, JsonSerializerOptions role)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Utf8JsonWriter var1, Color token, JsonSerializerOptions field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AdjustableDeciderReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdjustableDeciderReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCombinedBridgeDispatcher()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AdjustableDeciderReg SimulateGroupedDispatcherFinalizer()
	{
		return null;
	}
}
