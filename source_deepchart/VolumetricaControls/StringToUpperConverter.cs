using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(string), typeof(string))]
internal class StringToUpperConverter : IValueConverter
{
	internal static StringToUpperConverter AttachModularReporterTransmitter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object param, Type token, object third, CultureInfo reg2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object ConvertBack(object param, Type vis, object filter, CultureInfo x2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StringToUpperConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StringToUpperConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateLocalTransmitterProc()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StringToUpperConverter GenerateConfigurableProcIterator()
	{
		return null;
	}
}
