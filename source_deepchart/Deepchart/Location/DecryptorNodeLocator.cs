using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

[ProtoContract]
internal class DecryptorNodeLocator : IExtensible
{
	private IExtension m_LiteralArgument;

	[CompilerGenerated]
	private long separatedCalculatorLocatorVol;

	internal static DecryptorNodeLocator ChangeToken;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long CreateProvider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool isfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DecryptorNodeLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecryptorNodeLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateStaticRoleController()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DecryptorNodeLocator SimulateCustomizableControllerModel()
	{
		return null;
	}
}
