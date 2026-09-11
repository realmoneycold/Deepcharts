using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderContainer : INotifyPropertyChanged
{
	private bool isJoinedSender;

	private double _RandomDecider;

	internal int deciderTransmitterLength;

	internal int _ProxyReceiverRate;

	internal int m_InitializerVisitorDist;

	internal bool _IsExtendedDecider;

	[CompilerGenerated]
	private PropertyChangedEventHandler? deciderFilter;

	private static DeciderContainer? GenerateResponsiveSolver;

	public bool IsDownloading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double ProgressValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderContainer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderContainer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSetNotifier()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderContainer? SimulateSortedInterpreter()
	{
		return null;
	}
}
