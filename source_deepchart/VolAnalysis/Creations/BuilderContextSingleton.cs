using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal class BuilderContextSingleton
{
	public object m_SingletonContextMapperObj;

	public nint m_TransformableAdapterSingletonPtr;

	public object[] _SingletonMapperSystemArray;

	public int commandRequesterIdx;

	private static BuilderContextSingleton EncodeLocatorVerifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuilderContextSingleton(object init, nint counter, object[] dic, int token2_counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BuilderContextSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FilterVerifierProvider()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BuilderContextSingleton SimulateScalableTagChecker()
	{
		return null;
	}
}
