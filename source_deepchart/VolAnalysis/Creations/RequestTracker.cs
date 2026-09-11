using System.Runtime.CompilerServices;
using SharpDX;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal class RequestTracker
{
	public Vector2 StartPoint;

	public Vector2 EndPoint;

	internal static RequestTracker ExcludeElement;

	public Vector2 this[int reference]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Vector2)(object)null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequestTracker(Vector2 reference, Vector2 col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequestTracker(float param, float ivk, float rule, float counter2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestTracker()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CreateEmitter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RequestTracker SimulateRandomSpecSystem()
	{
		return null;
	}
}
