using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class EditableEditorWriter
{
	public string Value;

	public object m_WriterMemberDeciderObj;

	internal static EditableEditorWriter PresentSet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditableEditorWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EditableEditorWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateConnectedFinalizerResolver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EditableEditorWriter RemoveModule()
	{
		return null;
	}
}
