using System.Runtime.CompilerServices;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class GlobalAllocator
{
	public VisualRequester _ConcreteAllocator;

	public int globalAttributeLimit;

	public ReceiverValue.AxisName activeState;

	public object Window;

	public int? _ProcessorAllocator;

	public int? _HiddenAllocator;

	public long? allocatorReg;

	private static GlobalAllocator SimulateReadableField;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalAllocator(VisualRequester init, int vishigh)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateDividedEnumerator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalAllocator DeleteAggregator()
	{
		return null;
	}
}
