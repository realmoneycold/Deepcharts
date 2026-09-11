using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace VolAnalysis.Creations;

internal class SingletonReg : LocatorRequest
{
	internal enum LineStackingStrategy
	{
		Weak,
		Medium,
		Strong
	}

	[CompilerGenerated]
	private int m_SubscriberCheckerPosition;

	[CompilerGenerated]
	private bool isSingletonNode;

	[CompilerGenerated]
	private int _IntegratedValueSingletonCap;

	[CompilerGenerated]
	private int _SingletonProxyCap;

	[CompilerGenerated]
	private LineStackingStrategy m_TransferableBridgeSingleton;

	[CompilerGenerated]
	private Color _AggregatorTree;

	[CompilerGenerated]
	private LineStackingStrategy m_TracerFinalizer;

	[CompilerGenerated]
	private LineStackingStrategy singletonTransaction;

	[CompilerGenerated]
	private int m_SingletonSelectorDist;

	private bool isArgumentList;

	private int sortedEncryptorSingletonOffset;

	private int identifiableTemplateValue;

	private int _HiddenEventSingletonLimit;

	private int m_SingletonSubscriberSize;

	private int m_SingletonDriverPosition;

	private bool isBuilderSingleton;

	private bool m_IsExtendedHandlerSingleton;

	private int m_MixedConnectionSingletonNum;

	private VisualWrapperRequester<long> _ResponsiveCollector;

	private Common.WriterWrapperHandler m_SimpleChainSingleton;

	private VisualWrapperRequester<long> segmentedWriterSingleton;

	private Common.WriterWrapperHandler scopeExtractorSingleton;

	private RequesterTagExplorer bufferDistributor;

	private AllocatorCompilerEvent<MapResponderLocator.EfficientStructRequester> singletonContext;

	private int _JoinedCompilerSingletonId;

	private int m_IsolatedSystemValue;

	private int _FactorySharerVol;

	private int _MapperSingletonFreq;

	private double centralAuditor;

	private double _SingletonSystem;

	private double m_ModularEnumeratorSingleton;

	private double m_AuditorSingleton;

	private int loggerQueueFreq;

	private int _SingletonInitializerLength;

	private int globalVisitorSingletonFlag;

	private Common.WriterWrapperHandler _TokenSingleton;

	private VisualWrapperRequester<long> singletonConfig;

	private long singletonFieldScore;

	internal static SingletonReg ExecuteNotifier;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public int TickOffset
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool CappingMarkerEnabled
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public int CappingRangeParam
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

	[Category("Capping Marker")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public int CappingNumComparison
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("Capping Marker")]
	public LineStackingStrategy CappingMaxMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LineStackingStrategy)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	[Category("Capping Marker")]
	public Color CappingBothColor
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

	[Category("Filter")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Mode Vol")]
	public LineStackingStrategy IntensityModeVol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LineStackingStrategy)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[DisplayName("Mode Delta")]
	[Category("Filter")]
	public LineStackingStrategy IntensityModeDelta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LineStackingStrategy)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[Category("Filter")]
	public int FilterDevNumBar
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
	static SingletonReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_31f2f38a8f424bcd81d6651f48d18c36 == 0)
		{
			num = 0;
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
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555659)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE88617B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3785A561 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator._OrderThreadVol);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonReg(ScopeEncryptor.HiddenModelDecider i, MapResponderLocator.TransformableUserEncryptor caller, int position_dic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool moveinit, bool applycounter)
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
	public override void DecodeListener(bool explicitkey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CompressStream(int column_def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator asset, bool containspol, MapResponderLocator.TokenParameterViewer third)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyCommonRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool firstneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyControllableHandler(bool useinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SetProcessor(bool testres, int sizeconnection, Color consumer, int def2amount)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateFilteredManagerMember()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingletonReg SimulatePortableMemberProcessor()
	{
		return null;
	}
}
