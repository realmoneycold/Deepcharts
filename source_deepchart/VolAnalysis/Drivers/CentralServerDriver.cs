using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

[ProtoContract]
internal class CentralServerDriver : IExtensible
{
	private IExtension m_DriverConfigDecider;

	[CompilerGenerated]
	private long m_DriverDeciderConnectionAge;

	[CompilerGenerated]
	private double m_DriverConnectionDefinition;

	[CompilerGenerated]
	private double visualProcDriver;

	[CompilerGenerated]
	private double creatorChooser;

	[CompilerGenerated]
	private double m_PredicateDic;

	[CompilerGenerated]
	private int combinedThreadFreq;

	[CompilerGenerated]
	private int m_IntegratedFieldDriverAge;

	[CompilerGenerated]
	private int driverDefinitionVisitorCnt;

	[CompilerGenerated]
	private int m_CombinedMonitorDriverPos;

	[CompilerGenerated]
	private bool m_IsVisitorClientDriver;

	[CompilerGenerated]
	private double m_SorterCreator;

	[CompilerGenerated]
	private readonly List<ConverterMapperWriter> m_AdaptableDriverDriverList;

	private static CentralServerDriver AttachInterruptibleVerifierProvider;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long ArrangeSpec
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

	[ProtoMember(2, Name = "open")]
	public double Open
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(3, Name = "close")]
	public double Close
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(4, Name = "high")]
	public double High
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(5, Name = "low")]
	public double Low
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public int PlayArgument
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
	public int EnableTag
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
	public int RunAttachedAuditor
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
	public int ControlFlexibleAnnotation
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

	[ProtoMember(10)]
	public bool DestroyStaticEngine
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

	[ProtoMember(11)]
	public double ImplementJoinedDic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(12, Name = "Vbp")]
	public List<ConverterMapperWriter> RevertConnectedMap
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool applyreference)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CentralServerDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CentralServerDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RunProgram()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CentralServerDriver AttachHiddenParserProgram()
	{
		return null;
	}
}
