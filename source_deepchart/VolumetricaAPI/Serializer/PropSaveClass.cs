using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using VolAnalysis.Wrapping;

namespace VolumetricaAPI.Serializer;

[Serializable]
[XmlInclude(typeof(Point))]
[XmlInclude(typeof(Size))]
internal struct PropSaveClass
{
	internal static object GenerateIsolatedProfilerComparator;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public object Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropSaveClass(string n, object v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropSaveClass()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateSeparatedComparatorStrategy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AttachScalableStrategyRecord()
	{
		return null;
	}
}
