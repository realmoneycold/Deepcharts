using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class LocatorFinderVisitor : LocatorRequest
{
	[CompilerGenerated]
	private int _VisitorSchemaLocatorId;

	[CompilerGenerated]
	private bool m_IsLocatorMap;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes centralLocatorLocator;

	[CompilerGenerated]
	private int m_LocatorSchemaAnalyzerPosition;

	[CompilerGenerated]
	private double _ConcreteQueueLocator;

	[CompilerGenerated]
	private double _AnalyzerDefinitionLocator;

	[CompilerGenerated]
	private double _VisibleMonitorLocator;

	[CompilerGenerated]
	private Color m_DividedServiceDriver;

	[CompilerGenerated]
	private Color publisherSchema;

	[CompilerGenerated]
	private Color _DividedWriterLocator;

	[CompilerGenerated]
	private int _DictionarySingletonRank;

	private VisualWrapperRequester<double> m_LocatorDefinitionTracker;

	private IntegratedMapperWriter m_SegmentedCompressorLocator;

	private double locatorTrackerStream;

	private double _LocatorStreamCache;

	internal static LocatorFinderVisitor GenerateScheduledFunctionReceiver;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MinValue = 1.0)]
	[Category("Settings")]
	public int Length
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Average")]
	[DisplayName("Enable")]
	public bool ActivateAvg
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Average")]
	[DisplayName("Average Type")]
	public IntegratedMapperWriter.ProgramSingletonTypes AvgType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IntegratedMapperWriter.ProgramSingletonTypes)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[DisplayName("Length")]
	[Category("Average")]
	public int AvgPeriod
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

	[DisplayName("Middle Level")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	[Category("Level Settings")]
	public double MiddleLineLevel
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	[DisplayName("Low Level")]
	public double LowerLineLevel
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

	[DisplayName("High Level")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	[Category("Level Settings")]
	public double HigherLineLevel
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

	[Category("Level Settings")]
	[DisplayName("Middle Level Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public Color MiddleLineColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	[DisplayName("Low Level Color")]
	[Category("Level Settings")]
	public Color LowerLineColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
	[DisplayName("High Level Color")]
	[Category("Level Settings")]
	public Color HigherLineColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6)]
	[DisplayName("Level Width")]
	[Category("Level Settings")]
	public int LevelWidth
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
	static LocatorFinderVisitor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555777)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(-1023941699 ^ -234606576 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE763AE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), MapResponderLocator.BasicRecordReg.Oscillator));
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f == 0)
		{
			num = 5;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			if (num2 == 988)
			{
				num = num2;
				continue;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorFinderVisitor(ScopeEncryptor.HiddenModelDecider def, MapResponderLocator.TransformableUserEncryptor counter, int helperPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool createreference, bool comparemap)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyPortableExplorer(Color task, double map)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool applylast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifySymbolicSpec(bool containsinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool useparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateMonoReceiverField()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorFinderVisitor ReplaceRequester()
	{
		return null;
	}
}
