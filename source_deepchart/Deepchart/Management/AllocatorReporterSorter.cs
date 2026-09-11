using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal struct AllocatorReporterSorter
{
	public string Text;

	public EditableFinalizerAllocator m_ExplorerExplorer;

	private static object SimulateSymbolicTreeGenerator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorReporterSorter(string task, EditableFinalizerAllocator selection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(AllocatorReporterSorter asset, AllocatorReporterSorter map)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(AllocatorReporterSorter instance, AllocatorReporterSorter ivk)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object instance)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorReporterSorter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CalcSharer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AddDecider()
	{
		return null;
	}
}
