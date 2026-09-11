using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Models;

[Serializable]
internal class HotKeyAction : INotifyPropertyChanged
{
	private string _Combination;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static HotKeyAction SimulateGroupedDecorator;

	public HotKeyCategoryEnum Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HotKeyCategoryEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public HotKeyActionEnum Action
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (HotKeyActionEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Combination
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

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
	public HotKeyAction(HotKeyActionEnum p_action, string p_combination)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HotKeyAction()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateIdentifiableValidator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HotKeyAction GenerateInternalCompressor()
	{
		return null;
	}
}
