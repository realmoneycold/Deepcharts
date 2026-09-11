using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

[ProtoContract]
internal class StructTokenizerSingleton : IExtensible
{
	private IExtension m_ProgramRecommender;

	[CompilerGenerated]
	private int _EngineMemberNum;

	private static StructTokenizerSingleton ValidateFinalizer;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int Value
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
	IExtension IExtensible.GetExtensionObject(bool extractfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StructTokenizerSingleton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructTokenizerSingleton()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePortableContextBuffer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StructTokenizerSingleton GenerateSymbolicBufferMonitor()
	{
		return null;
	}
}
