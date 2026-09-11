using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class ExtendedBufferWriter
{
	public int _WriterAnalyzerDefinitionLength;

	public int _WriterDefinitionFilterCount;

	public bool isFilteredEmitterWriter;

	public bool _IsDetachedSingletonWriter;

	public bool m_IsControllableModelEncryptor;

	public bool isRemoteValidator;

	private static ExtendedBufferWriter AttachGeneralBufferMonitor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtendedBufferWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExtendedBufferWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WriteHandler()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExtendedBufferWriter AttachSetStateArgument()
	{
		return null;
	}
}
