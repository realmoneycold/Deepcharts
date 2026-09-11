using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class AllocatorParameter : LocatorRequest
{
	[CompilerGenerated]
	private double _AllocatorRunner;

	[CompilerGenerated]
	private int _ObserverAttributeCounter;

	[CompilerGenerated]
	private int m_AllocatorFilters;

	[CompilerGenerated]
	private double m_ExternalControllerAllocator;

	[CompilerGenerated]
	private double _AlphabeticLoggerAllocator;

	[CompilerGenerated]
	private double iterableStructAllocator;

	[CompilerGenerated]
	private Color m_CompilerSingleton;

	[CompilerGenerated]
	private Color _AllocatorAggregator;

	[CompilerGenerated]
	private Color _AllocatorChecker;

	[CompilerGenerated]
	private int _IdentifiableEncryptorAllocatorVal;

	private double m_StaticFinder;

	private double _RoleCompressor;

	private double allocatorWorker;

	private double elementGenerator;

	private double m_MapperWrapper;

	private double m_ConsumerReporter;

	private double randomThread;

	private double visualRecordAllocator;

	private double allocatorElement;

	private double operationalPredictorAllocator;

	private double _PoolElement;

	private List<double> m_InspectorCreatorList;

	private List<double> m_WriterAllocatorList;

	private List<double> _AttachedWrapperAllocatorList;

	private List<double> m_AllocatorPolicyList;

	private List<double> responsiveModuleAllocators;

	private double m_ConcreteSystem;

	private double m_CombinedDictionaryAllocator;

	private double _AllocatorTracker;

	private double _AllocatorResponder;

	private double _AllocatorTokenizer;

	private double m_AllocatorDecider;

	private double _AdvancedCalculatorAllocator;

	private double efficientRoleAllocator;

	private double _AccessibleArgumentAllocator;

	private double orderedTemplateAllocator;

	private double distributorTransaction;

	private List<double> m_TreeReceivers;

	private List<double> m_TransferableSynchronizerList;

	private List<double> m_AllocatorAnnotationList;

	private List<double> _AutomatedCompressorAllocatorList;

	private List<double> allocatorDefinitionList;

	private static AllocatorParameter CountMember;

	[DisplayName("Smoothing Alpha")]
	[Category("Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MinValue = 0.001, IncrementValue = 0.001, DecimalPosToShow = 3)]
	public double Alpha
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

	[Category("Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 5.0)]
	[DisplayName("Cycle A Length")]
	public int Length_A
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

	[Category("Settings")]
	[DisplayName("Cycle B Length")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 5.0)]
	public int Length_B
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, DecimalPosToShow = 2, MinValue = -1.0, MaxValue = 1.0, IncrementValue = 0.1)]
	[DisplayName("Middle Level")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MinValue = -1.0, MaxValue = 1.0, IncrementValue = 0.1)]
	[DisplayName("Low Level")]
	[Category("Level Settings")]
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, DecimalPosToShow = 2, MinValue = -1.0, MaxValue = 1.0, IncrementValue = 0.1)]
	[DisplayName("High Level")]
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
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

	[Category("Level Settings")]
	[DisplayName("Low Level Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
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

	[Category("Level Settings")]
	[DisplayName("High Level Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
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
	static AllocatorParameter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_063232c07bf344ff9a39b9bbfee37650 == 0)
		{
			num = 3;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555427)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED28C5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5EDD2AFF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6b3eda098e1a4d3aa281067d349fea8d), MapResponderLocator.BasicRecordReg.Oscillator));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorParameter(ScopeEncryptor.HiddenModelDecider def, MapResponderLocator.TransformableUserEncryptor vis, int stateamount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isres, bool insertcont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateScopeServer(Color config, double pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool readinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachOperationalProviderParser()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorParameter ResetSender()
	{
		return null;
	}
}
