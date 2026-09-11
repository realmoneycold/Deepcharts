using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderCalculatorEvent
{
	public ObservableCollection<SequentialResolverViewer> _InspectorEngine;

	public DeciderListWriter m_FilteredRecommenderDecider;

	internal static DeciderCalculatorEvent AttachConnectedResolverEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderCalculatorEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderCalculatorEvent()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateExpandableEventStub()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderCalculatorEvent GuideSubscriber()
	{
		return null;
	}
}
