using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(object), typeof(bool))]
internal class IsNotNullConverter : IValueConverter
{
	internal static IsNotNullConverter SimulateScopeConsumerTemplate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object param, Type b, object dic, CultureInfo attr2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object last, Type second, object filter, CultureInfo cont2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsNotNullConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsNotNullConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachLogicalTemplateTag()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsNotNullConverter DisableMonitor()
	{
		return null;
	}
}
