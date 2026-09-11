using System;
using System.Runtime.CompilerServices;
using System.Windows;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class ServerMonitor : ResourceDictionary
{
	private WrapperTextBoxMode? driverPublisher;

	private WrapperTextBoxMode _SegmentedDriver;

	private Uri orderedFilter;

	private Uri _EventDriver;

	private Uri _SequentialDriver;

	private Uri m_DriverDecryptor;

	internal static ServerMonitor AttachGlobalSender;

	public Uri DarkSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Uri BlueSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Uri LightSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Uri PurpleSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServerMonitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void MatchMapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerMonitor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDetachedVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ServerMonitor SimulateExtendedDecryptor()
	{
		return null;
	}
}
