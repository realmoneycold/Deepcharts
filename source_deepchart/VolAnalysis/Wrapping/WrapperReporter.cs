using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace VolAnalysis.Wrapping;

internal class WrapperReporter : ResourceDictionary
{
	private WrapperTextBoxMode? stateAggregator;

	private WrapperTextBoxMode auditorTemplate;

	private Uri m_IsolatedWrapper;

	private Uri m_EncryptorConnection;

	private Uri listenerSender;

	private static WrapperReporter AttachExtendedDefinition;

	public Uri DefaultSource
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

	public Uri StandardSource
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
	public WrapperReporter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FillInitializer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperReporter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCustomSelector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WrapperReporter GenerateAttachedInitializer()
	{
		return null;
	}
}
