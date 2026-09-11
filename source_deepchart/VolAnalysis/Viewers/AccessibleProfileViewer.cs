using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class AccessibleProfileViewer : JsonConverterFactory
{
	private static AccessibleProfileViewer GenerateModularInspectorTransaction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvert(Type ident)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override JsonConverter CreateConverter(Type res, JsonSerializerOptions pol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AccessibleProfileViewer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccessibleProfileViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateLocalTransactionError()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AccessibleProfileViewer GenerateConfigurableErrorMapper()
	{
		return null;
	}
}
