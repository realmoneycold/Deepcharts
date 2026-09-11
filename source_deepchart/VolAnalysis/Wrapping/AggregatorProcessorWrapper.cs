using System.Runtime.CompilerServices;

namespace VolAnalysis.Wrapping;

internal class AggregatorProcessorWrapper
{
	public bool m_IsCommonAuthenticatorWrapper;

	public bool m_IsTransmitterStack;

	public bool isWrapperProcessorPool;

	private static AggregatorProcessorWrapper DisableHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AggregatorProcessorWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AggregatorProcessorWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachStaticEngineStack()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AggregatorProcessorWrapper SimulateCustomizableStackCalc()
	{
		return null;
	}
}
