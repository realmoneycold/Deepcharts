using System.Runtime.CompilerServices;
using System.Windows.Media;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class WriterEditor
{
	[CompilerGenerated]
	private Color editableWriter;

	[CompilerGenerated]
	private int m_StubWriterIndex;

	private static WriterEditor GenerateGroupedServer;

	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Opacity
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
	public WriterEditor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterEditor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateIdentifiableModule()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WriterEditor GenerateInternalRecommender()
	{
		return null;
	}
}
