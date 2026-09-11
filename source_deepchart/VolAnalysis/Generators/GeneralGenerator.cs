using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Generators;

internal class GeneralGenerator
{
	[CompilerGenerated]
	private string m_DetailedDecryptorLabel;

	[CompilerGenerated]
	private string generatorCollectionTag;

	[CompilerGenerated]
	private string trackerAnalyzerTag;

	[CompilerGenerated]
	private int identifiableGeneratorVol;

	private static GeneralGenerator GenerateGlobalDecryptor;

	public string LastVersion
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

	public string BetaVersions
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

	public string LegacyVersion
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

	public int SymbolVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneralGenerator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GeneralGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MoveModel()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneralGenerator AttachExtendedSelector()
	{
		return null;
	}
}
