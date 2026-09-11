using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

[ProtoContract]
internal class RoleExtractorDecider : IExtensible
{
	private IExtension deciderProcAuditor;

	[CompilerGenerated]
	private bool isStackPool;

	[CompilerGenerated]
	private int _AccessibleVisitorDeciderErrorCode;

	internal static RoleExtractorDecider GenerateDividedGatewayCompiler;

	[ProtoMember(1, Name = "connected")]
	public bool Connected
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
	IExtension IExtensible.GetExtensionObject(bool calckey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RoleExtractorDecider()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleExtractorDecider()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateIsolatedCompilerPolicy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RoleExtractorDecider FilterStream()
	{
		return null;
	}
}
