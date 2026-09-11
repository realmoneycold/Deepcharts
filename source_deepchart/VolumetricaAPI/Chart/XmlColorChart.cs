using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Xml.Serialization;
using VolAnalysis.Wrapping;

namespace VolumetricaAPI.Chart;

[Serializable]
internal class XmlColorChart
{
	private Color color_;

	private static XmlColorChart EvaluateCompiler;

	[XmlAttribute]
	public string Web
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmlColorChart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmlColorChart(Color c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color ToColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromColor(Color c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Color(XmlColorChart x)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator XmlColorChart(Color c)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static XmlColorChart()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachCentralProjectObserver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static XmlColorChart SimulateAdvancedObserverRole()
	{
		return null;
	}
}
