using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolumetricaProtcol.Shared;

[ProtoContract]
internal class Decimal : IExtensible
{
	private IExtension __pbn__extensionData;

	private static Decimal SimulateGeneralMapperMatcher;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long Significand
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int Exponent
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
	IExtension IExtensible.GetExtensionObject(bool createIfMissing)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator decimal(Decimal v)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Decimal(decimal v)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Decimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Decimal()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateResponsiveMatcherReporter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Decimal GenerateSetReporterTransmitter()
	{
		return null;
	}
}
