using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

[ProtoContract]
internal class ConvertibleTokenizerReg : IExtensible
{
	private IExtension singletonRecordLocator;

	[CompilerGenerated]
	private string m_RegInspectorLocatorCategory;

	[CompilerGenerated]
	private long[] regConsumerExtractorItems;

	internal static ConvertibleTokenizerReg LeadSubscriber;

	[ProtoMember(1)]
	[DefaultValue("")]
	public string AccountId
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long[] ArrangeIdentifiableMap
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
	IExtension IExtensible.GetExtensionObject(bool skipreference)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConvertibleTokenizerReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConvertibleTokenizerReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GeneratePassiveModuleDecorator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConvertibleTokenizerReg AttachAdaptableDecoratorValidator()
	{
		return null;
	}
}
