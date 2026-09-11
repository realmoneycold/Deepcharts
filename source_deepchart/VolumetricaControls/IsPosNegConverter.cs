using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(object), typeof(int))]
internal class IsPosNegConverter : IValueConverter
{
	private static IsPosNegConverter SimulateGenericTransformerAllocator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object key, Type cfg, object helper, CultureInfo reg2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object asset, Type ivk, object control, CultureInfo attr2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsPosNegConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsPosNegConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StopEvaluator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsPosNegConverter AdaptPool()
	{
		return null;
	}
}
