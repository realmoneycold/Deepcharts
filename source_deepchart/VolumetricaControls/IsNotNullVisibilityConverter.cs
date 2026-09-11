using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(object), typeof(Visibility))]
internal class IsNotNullVisibilityConverter : IValueConverter
{
	private static IsNotNullVisibilityConverter WriteState;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object task, Type col, object third, CultureInfo config2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object instance, Type ord, object control, CultureInfo reference2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsNotNullVisibilityConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsNotNullVisibilityConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PlanArgument()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsNotNullVisibilityConverter AttachSortedEvaluatorPool()
	{
		return null;
	}
}
