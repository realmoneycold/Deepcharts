using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;
using VolumetricaProtcol.Info;

namespace VolAnalysis.Generators;

[ProtoContract]
internal class GeneratorProfilerPublisher : IExtensible
{
	private IExtension connectedResolverGenerator;

	[CompilerGenerated]
	private string m_AdaptableCommandGeneratorStr;

	[CompilerGenerated]
	private SymbolCategoryEnum m_ComparatorServer;

	[CompilerGenerated]
	private string _GeneratorPublisherWriterDescr;

	private static GeneratorProfilerPublisher AttachDetailedSystemProfiler;

	[ProtoMember(1)]
	[DefaultValue("")]
	public string ReceiveTransaction
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

	[ProtoMember(2, Name = "category")]
	public SymbolCategoryEnum Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SymbolCategoryEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(3, Name = "isin")]
	[DefaultValue("")]
	public string Isin
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool noasset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneratorProfilerPublisher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GeneratorProfilerPublisher()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateVisualProfilerComparator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneratorProfilerPublisher SimulateStatelessComparatorStrategy()
	{
		return null;
	}
}
