using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal struct DriverServerProc
{
	public string Text;

	public bool Bold;

	public float definitionServer;

	internal static object GenerateSeparatedStrategyRecord;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverServerProc(string info, float token, bool containstemplate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(DriverServerProc info, DriverServerProc second)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(DriverServerProc setup, DriverServerProc map)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object info)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverServerProc()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JoinSchema()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ResumeValue()
	{
		return null;
	}
}
