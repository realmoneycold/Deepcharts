using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class AuthorizerWriter
{
	[CompilerGenerated]
	private bool _IsScalableWriter;

	internal static AuthorizerWriter ResetManager;

	[DisplayName("Compress")]
	public bool RecordGroupedPool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AuthorizerWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthorizerWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SerializeMember()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AuthorizerWriter DisableProcessor()
	{
		return null;
	}
}
