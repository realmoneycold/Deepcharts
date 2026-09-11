using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class LocatorReg : DataTemplateSelector
{
	internal static LocatorReg GenerateGroupedParser;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override DataTemplate SelectTemplate(object first, DependencyObject ivk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LocatorReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InvokeInitializer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorReg SimulateAdjustableConnection()
	{
		return null;
	}
}
