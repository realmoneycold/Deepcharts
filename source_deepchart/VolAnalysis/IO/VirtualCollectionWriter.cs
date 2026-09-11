using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

[ProtoContract]
internal class VirtualCollectionWriter : IExtensible
{
	private IExtension m_ActiveMemberWriter;

	[CompilerGenerated]
	private long m_TransferablePredictorDepth;

	[CompilerGenerated]
	private string controllableEnumeratorText;

	[CompilerGenerated]
	private int writerLocatorTrackerCount;

	[CompilerGenerated]
	private bool isConfigurableDeciderWriter;

	[CompilerGenerated]
	private long _WriterTrackerSchemaFlag;

	[CompilerGenerated]
	private bool m_IsWriterSchemaMatcher;

	[CompilerGenerated]
	private string m_FlexibleListWriterTag;

	[CompilerGenerated]
	private string m_SymbolicListenerWriterStr;

	[CompilerGenerated]
	private string _WriterMatcherAggregatorCategory;

	private static VirtualCollectionWriter GenerateOperationalGeneratorRunner;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long RecordLogicalComparator
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

	[DefaultValue("")]
	[ProtoMember(2)]
	public string ContractName
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
	public int WriteVisibleBuffer
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

	[ProtoMember(4)]
	public bool WriteGenericArgument
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
	public long SortRecommender
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

	[ProtoMember(6)]
	public bool WriteFilteredEvaluator
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

	[DefaultValue("")]
	[ProtoMember(7)]
	public string WriteConcretePredictor
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

	[DefaultValue("")]
	[ProtoMember(8)]
	public string LogOrderedTree
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

	[ProtoMember(9)]
	[DefaultValue("")]
	public string PerformCommonProject
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
	IExtension IExtensible.GetExtensionObject(bool outputspec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VirtualCollectionWriter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VirtualCollectionWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CallDistributor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VirtualCollectionWriter ParseCreator()
	{
		return null;
	}
}
