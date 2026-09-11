using System;
using System.Runtime.CompilerServices;

namespace Deepchart.DecisionMaking;

internal class DeciderProviderCreator
{
	internal static ModuleHandle _SymbolicSubscriberDecider;

	private static DeciderProviderCreator SimulateDividedTemplateTag;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle GeneratePortableTesterNode(int token)
	{
		return _SymbolicSubscriberDecider.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle AttachSymbolicNodeAuditor(int token)
	{
		return _SymbolicSubscriberDecider.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderProviderCreator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderProviderCreator()
	{
		_SymbolicSubscriberDecider = typeof(DeciderProviderCreator).Assembly.GetModules()[0].ModuleHandle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WatchContextBuffer()
	{
		return SimulateDividedTemplateTag == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderProviderCreator SimulateSeparatedCheckerTokenizer()
	{
		return SimulateDividedTemplateTag;
	}
}
