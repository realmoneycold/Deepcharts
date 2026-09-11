using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using VolAnalysis.Wrapping;

namespace VolumetricaControls;

[ValueConversion(typeof(decimal), typeof(string))]
internal class DecimalStringConverter : IMultiValueConverter
{
	internal static DecimalStringConverter SimulateAutomatableEventStub;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object LogExternalTester(object last, Type caller, object comp, CultureInfo asset2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Convert(object[] config, Type cont, object dic, CultureInfo init2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object LeadLogger(object key, Type col, object temp, CultureInfo cont2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object[] ConvertBack(object spec, Type[] selection, object field, CultureInfo reference2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DecimalStringConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecimalStringConverter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCombinedStubConnection()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DecimalStringConverter StartReg()
	{
		return null;
	}
}
