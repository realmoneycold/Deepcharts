using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.Management;

internal class NodeAllocator : LocatorRequest
{
	internal enum EncryptorCommandEditorFlags
	{
		Volume,
		AggregateTrades,
		[Display(Name = "Number Trades")]
		Trades,
		[Display(Name = "Aggr. Order (MBO)")]
		Order,
		[Display(Name = "Number Orders (MBO)")]
		NumberOrders
	}

	internal enum ModularExtractorAllocator
	{
		Classic,
		MultiRange
	}

	[CompilerGenerated]
	private EncryptorCommandEditorFlags modularStubAllocator;

	[CompilerGenerated]
	private ModularExtractorAllocator connectedObjectAllocator;

	[CompilerGenerated]
	private bool m_IsPolicyMapper;

	[CompilerGenerated]
	private int _FlexibleTokenAllocatorStep;

	[CompilerGenerated]
	private int m_AggregatorFilterCounter;

	[CompilerGenerated]
	private bool m_IsMonoCompilerAllocator;

	[CompilerGenerated]
	private int _IterableConsumerLocatorCnt;

	[CompilerGenerated]
	private int m_LogicalExtractorAllocatorNum;

	[CompilerGenerated]
	private bool m_IsReadableQueueAllocator;

	[CompilerGenerated]
	private int m_AllocatorGeneratorFreq;

	[CompilerGenerated]
	private int allocatorTesterInterval;

	[CompilerGenerated]
	private bool m_IsIsolatedMonitor;

	[CompilerGenerated]
	private int _AllocatorListenerCount;

	[CompilerGenerated]
	private int m_ScopeSynchronizerLength;

	[CompilerGenerated]
	private bool m_IsIsolatedEventAllocator;

	[CompilerGenerated]
	private double stackCache;

	[CompilerGenerated]
	private int _AnalyzerAllocatorCounter;

	[CompilerGenerated]
	private Color m_AllocatorEvaluator;

	[CompilerGenerated]
	private DashStyle m_AllocatorRequest;

	[CompilerGenerated]
	private bool m_IsExtendedDistributorAllocator;

	[CompilerGenerated]
	private double remoteMemberAllocator;

	[CompilerGenerated]
	private int m_WrapperCalculatorPosition;

	[CompilerGenerated]
	private Color m_ChainAllocator;

	[CompilerGenerated]
	private DashStyle _AllocatorPredicate;

	[CompilerGenerated]
	private bool m_IsRandomServerAllocator;

	[CompilerGenerated]
	private int _SimpleRequesterAllocatorCnt;

	[CompilerGenerated]
	private Color subscriberAuthorizer;

	private EncryptorCacheBuffer.Series_Prop[] allocatorRecommenders;

	private EncryptorCacheBuffer.Series_Prop editorBridge;

	private EncryptorCacheBuffer.Series_Prop m_GeneralReporterAllocator;

	private EncryptorCacheBuffer.Series_Prop _SegmentedThreadAllocator;

	private EncryptorCacheBuffer.Series_Prop m_ModuleRole;

	private long _SortedGatewayAllocatorLength;

	private long m_ActiveGeneratorLimit;

	private long dictionaryArgumentStep;

	private long m_AllocatorCalcLimit;

	private long m_MatcherExecutorOffset;

	private long _SetSorterAllocators;

	private RequesterTagExplorer _CalculatorTemplate;

	private ulong localAdapterAllocatorStep;

	private long m_BasicInitializerAllocatorErrorCode;

	private double _AllocatorSender;

	private ulong projectStateAge;

	private long _ExplorerAllocatorPnts;

	private double joinedTaskAllocator;

	internal static NodeAllocator MatchElement;

	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Mode", CategoryIndex = 0, PropertyIndex = 0)]
	public EncryptorCommandEditorFlags InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorCommandEditorFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Mode", CategoryIndex = 0, PropertyIndex = 1)]
	public ModularExtractorAllocator DeltaMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ModularExtractorAllocator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Enable")]
	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Range 1", CategoryIndex = 0, PropertyIndex = 2)]
	public bool Range1Enabled
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

	[Category("Ranges")]
	[DisplayName("Minimum")]
	[StaticStructAllocator(SubCategory = "Range 1", CategoryIndex = 0, PropertyIndex = 3, MaxValue = 2147483647.0)]
	public int Range1Min
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

	[StaticStructAllocator(SubCategory = "Range 1", CategoryIndex = 0, PropertyIndex = 4, MaxValue = 2147483647.0)]
	[DisplayName("Maximum")]
	[Category("Ranges")]
	public int Range1Max
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

	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 0, PropertyIndex = 5)]
	[DisplayName("Enable")]
	[Category("Ranges")]
	public bool Range2Enabled
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

	[DisplayName("Minimum")]
	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 0, PropertyIndex = 6, MaxValue = 2147483647.0)]
	[Category("Ranges")]
	public int Range2Min
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

	[Category("Ranges")]
	[DisplayName("Maximum")]
	[StaticStructAllocator(SubCategory = "Range 2", CategoryIndex = 0, PropertyIndex = 7, MaxValue = 2147483647.0)]
	public int Range2Max
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

	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 0, PropertyIndex = 8)]
	[DisplayName("Enable")]
	[Category("Ranges")]
	public bool Range3Enabled
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

	[Category("Ranges")]
	[DisplayName("Minimum")]
	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 0, PropertyIndex = 9, MaxValue = 2147483647.0)]
	public int Range3Min
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

	[DisplayName("Maximum")]
	[StaticStructAllocator(SubCategory = "Range 3", CategoryIndex = 0, PropertyIndex = 10, MaxValue = 2147483647.0)]
	[Category("Ranges")]
	public int Range3Max
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

	[DisplayName("Enable")]
	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 0, PropertyIndex = 11)]
	public bool Range4Enabled
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

	[DisplayName("Minimum")]
	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 0, PropertyIndex = 12, MaxValue = 2147483647.0)]
	public int Range4Min
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

	[Category("Ranges")]
	[StaticStructAllocator(SubCategory = "Range 4", CategoryIndex = 0, PropertyIndex = 13, MaxValue = 2147483647.0)]
	[DisplayName("Maximum")]
	public int Range4Max
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 1", CategoryIndex = 1, PropertyIndex = 0)]
	public bool LevelEnable
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 1", CategoryIndex = 1, PropertyIndex = 1, MinValue = 0.0, MaxValue = 10000000.0, IncrementValue = 50.0)]
	public double LevelValue
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 1", CategoryIndex = 1, PropertyIndex = 2)]
	public int LevelLineWidth
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

	[StaticStructAllocator(SubCategory = "Level 1", CategoryIndex = 1, PropertyIndex = 3)]
	[Category("Threshold")]
	public Color LevelLineColor
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 1", CategoryIndex = 1, PropertyIndex = 4)]
	public DashStyle LevelLineStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 2", CategoryIndex = 1, PropertyIndex = 5)]
	public bool Level2Enable
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

	[StaticStructAllocator(SubCategory = "Level 2", CategoryIndex = 1, PropertyIndex = 6, MinValue = 0.0, MaxValue = 10000000.0, IncrementValue = 50.0)]
	[Category("Threshold")]
	public double Level2Value
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 2", CategoryIndex = 1, PropertyIndex = 7)]
	public int Level2LineWidth
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 2", CategoryIndex = 1, PropertyIndex = 8)]
	public Color Level2LineColor
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

	[Category("Threshold")]
	[StaticStructAllocator(SubCategory = "Level 2", CategoryIndex = 1, PropertyIndex = 9)]
	public DashStyle Level2LineStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DashStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "Struggle", CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Marker")]
	public bool StruggleMarkerEnable
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

	[StaticStructAllocator(SubCategory = "Struggle", CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Min. delta")]
	[Category("Marker")]
	public int StrubbleMinDelta
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

	[Category("Marker")]
	[StaticStructAllocator(SubCategory = "Struggle", CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Color")]
	public Color StruggleMakerColor
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NodeAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_bb3801db3d634a8f97973394c9549a6c == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555398));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x564427BD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8FB3B6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED1833 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C7AE8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AE5581 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316ADFB0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NodeAllocator(ScopeEncryptor.HiddenModelDecider value, MapResponderLocator.TransformableUserEncryptor col, int ID_res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool rejectdef, bool useselection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer AssignFlexibleTag(int indexOffirst, Color pol, int size_res, DashStyle instance2, bool ist3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator first, bool loadmap, MapResponderLocator.TokenParameterViewer c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseEditableChecker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseIntegratedTokenizer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateResponsiveExtractorFinder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NodeAllocator AttachSetFinderWatcher()
	{
		return null;
	}
}
