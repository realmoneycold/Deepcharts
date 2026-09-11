using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

[ProtoContract]
internal class LiteralStubAllocator : IExtensible
{
	private IExtension sequentialObjectAllocator;

	[CompilerGenerated]
	private readonly List<string> integratedTokenAllocators;

	[CompilerGenerated]
	private string m_PortableCompilerAllocatorText;

	[CompilerGenerated]
	private int m_ProcPoolCnt;

	[CompilerGenerated]
	private int dividedVisitorCnt;

	private static LiteralStubAllocator SimulateAdvancedStateArgument;

	[ProtoMember(1)]
	public List<string> Exchanges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(2)]
	[DefaultValue("")]
	public string ModifyMixedError
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
	public int Limit
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int Offset
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
	IExtension IExtensible.GetExtensionObject(bool isasset)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LiteralStubAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LiteralStubAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateOrderedArgumentConsumer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LiteralStubAllocator GenerateAlphabeticConsumerTemplate()
	{
		return null;
	}
}
