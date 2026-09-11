using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(object), typeof(Visibility))]
internal class IsSelectedItemVisibileConverter : IValueConverter
{
	private static IsSelectedItemVisibileConverter CheckTemplate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object setup, Type cfg, object field, CultureInfo result2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object key, Type vis, object control, CultureInfo map2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsSelectedItemVisibileConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsSelectedItemVisibileConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateSequentialTracerPredictor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsSelectedItemVisibileConverter SimulateTransformablePredictorTransformer()
	{
		return null;
	}
}
