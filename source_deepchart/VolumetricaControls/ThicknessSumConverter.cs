using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(Thickness), typeof(Thickness))]
internal class ThicknessSumConverter : IValueConverter
{
	internal static ThicknessSumConverter SetupTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object config, Type col, object dir, CultureInfo value2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object i, Type reg, object dic, CultureInfo ident2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ThicknessSumConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThicknessSumConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAccessibleSystemProfiler()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ThicknessSumConverter AttachPassiveProfilerComparator()
	{
		return null;
	}
}
