using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderAuthorizerNotifier : INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler deciderChainFinder;

	private static DeciderAuthorizerNotifier ResumeSender;

	public event PropertyChangedEventHandler PropertyChanged
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
	protected void EnsureActiveGenerator(string config = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderAuthorizerNotifier()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderAuthorizerNotifier()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PeekVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderAuthorizerNotifier FlushDecryptor()
	{
		return null;
	}
}
