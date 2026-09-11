using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class ReadableDictionaryReg : DeciderAuthorizerNotifier
{
	[CompilerGenerated]
	private ScopeHandlerDecider.AdaptableFactoryDecider m_ResolverDefinition;

	[CompilerGenerated]
	private ObservableCollection<ScopeHandlerDecider.DeciderStrategyTransformer> _ParameterAuthorizer;

	internal static ReadableDictionaryReg SimulateModularChain;

	public ScopeHandlerDecider.AdaptableFactoryDecider Symbol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public ObservableCollection<ScopeHandlerDecider.DeciderStrategyTransformer> Positions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
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
	public ReadableDictionaryReg(ScopeHandlerDecider.AdaptableFactoryDecider param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReadableDictionaryReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachLocalOrder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReadableDictionaryReg AttachConfigurableListener()
	{
		return null;
	}
}
