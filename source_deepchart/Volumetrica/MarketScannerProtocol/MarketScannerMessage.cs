using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Volumetrica.MarketScannerProtocol;

[Serializable]
internal class MarketScannerMessage
{
	internal static MarketScannerMessage AttachScopeMatcherReporter;

	public string Country
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

	public List<MarketSymbolInfo> Symbols
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

	public byte[] XmlSymbolInfo
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
	public MarketScannerMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MarketScannerMessage()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ParseEmitter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MarketScannerMessage ChangeEncryptor()
	{
		return null;
	}
}
