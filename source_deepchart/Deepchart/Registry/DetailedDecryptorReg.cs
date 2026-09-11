using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class DetailedDecryptorReg<T> : INotifyPropertyChanged where T : Enum
{
	private bool _IsCompressorObserver;

	[CompilerGenerated]
	private T m_BasicDefinition;

	[CompilerGenerated]
	private PropertyChangedEventHandler adapterObserver;

	private static object SortSchema;

	public bool Checked
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

	public T Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
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
	public DetailedDecryptorReg(T config)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DetailedDecryptorReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateStatelessSubscriber()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SimulateActiveClient()
	{
		return null;
	}
}
