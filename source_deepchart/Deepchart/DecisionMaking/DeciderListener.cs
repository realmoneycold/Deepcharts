using System.Runtime.CompilerServices;
using System.Windows.Media;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.DecisionMaking;

internal class DeciderListener
{
	[CompilerGenerated]
	private Color _DeciderCompiler;

	[CompilerGenerated]
	private int _StreamAttributeCnt;

	[CompilerGenerated]
	private DashStyle _DeciderCache;

	private static DeciderListener AttachExpandableParameter;

	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int LineWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public DashStyle LStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderListener()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderListener()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateAutomatableProxy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderListener GenerateCombinedSet()
	{
		return null;
	}
}
