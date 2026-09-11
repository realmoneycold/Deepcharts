using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(GridLength), typeof(GridLength))]
internal class GridLengthVisibilityConverter : IValueConverter
{
	private static GridLengthVisibilityConverter SimulateInterruptibleErrorMapper;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object info, Type visitor, object filter, CultureInfo asset2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object instance, Type cust, object temp, CultureInfo second2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GridLengthVisibilityConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GridLengthVisibilityConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RunSorter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GridLengthVisibilityConverter GenerateHiddenMatcherReporter()
	{
		return null;
	}
}
