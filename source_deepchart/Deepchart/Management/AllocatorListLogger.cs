using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class AllocatorListLogger : JsonConverter<double>
{
	internal static AllocatorListLogger SolveSolver;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override double Read(ref Utf8JsonReader param, Type b, JsonSerializerOptions proc)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Utf8JsonWriter config, double col, JsonSerializerOptions third)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorListLogger()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorListLogger()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAutomatedStackCalc()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorListLogger GenerateJoinedCalcDic()
	{
		return null;
	}
}
