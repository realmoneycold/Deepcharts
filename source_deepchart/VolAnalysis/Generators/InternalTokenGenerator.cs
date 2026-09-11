using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Deepchart.Management;
using ProtoBuf;
using VolAnalysis.Drivers;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Generators;

[ProtoContract]
internal class InternalTokenGenerator : IExtensible
{
	private IExtension m_ScalableConverter;

	[CompilerGenerated]
	private long generatorWriterSingletons;

	[CompilerGenerated]
	private long _GeneratorSingletonAggregatorDist;

	[CompilerGenerated]
	private readonly List<CentralServerDriver> generatorAggregatorSchemaList;

	[CompilerGenerated]
	private AllocatorCertControlStoreType _OrderInitializer;

	[CompilerGenerated]
	private bool isGeneratorSchemaProcessor;

	[CompilerGenerated]
	private int _SetDecoratorGeneratorOffset;

	private static InternalTokenGenerator DecodeValue;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long DestroyJoinedCalc
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
	public long GenerateExpandableMap
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

	[ProtoMember(3)]
	public List<CentralServerDriver> AdaptCompressor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[ProtoMember(4)]
	public AllocatorCertControlStoreType CloseInternalGateway
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorCertControlStoreType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(5)]
	public bool Success
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
	public int GenerateModularInspector
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
	IExtension IExtensible.GetExtensionObject(bool isitem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InternalTokenGenerator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InternalTokenGenerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCombinedLoggerTester()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InternalTokenGenerator StartList()
	{
		return null;
	}
}
