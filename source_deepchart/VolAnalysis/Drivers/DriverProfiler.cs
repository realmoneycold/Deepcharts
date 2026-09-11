using System;
using System.Runtime.CompilerServices;
using System.Windows;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class DriverProfiler<T> where T : Enum
{
	[CompilerGenerated]
	private T m_DriverController;

	[CompilerGenerated]
	private FrameworkElement _IteratorAnalyzer;

	internal static object GenerateGenericWatcher;

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

	public FrameworkElement Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverProfiler(T reference, FrameworkElement vis = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DriverProfiler()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StopAuthorizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AdaptService()
	{
		return null;
	}
}
