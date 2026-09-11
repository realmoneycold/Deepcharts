using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

[ProtoContract]
internal class StaticDecoratorWriter : IExtensible
{
	private IExtension _IterableTemplate;

	[CompilerGenerated]
	private bool m_IsOrderedMonitorWriter;

	[CompilerGenerated]
	private int m_VirtualParserErrorCode;

	private static StaticDecoratorWriter SimulateVisualComparatorStrategy;

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
	IExtension IExtensible.GetExtensionObject(bool isvar1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StaticDecoratorWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StaticDecoratorWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachStatelessStrategyRecord()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StaticDecoratorWriter SimulateActiveRecordHandler()
	{
		return null;
	}
}
