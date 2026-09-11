using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderClient : LocatorRequest
{
	internal enum WriterMergeOption
	{
		PriceSlope,
		High,
		Low
	}

	[CompilerGenerated]
	private string interruptibleChooserDeciderTitle;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes checkerCollection;

	[CompilerGenerated]
	private int m_SymbolicSpecDeciderIdx;

	[CompilerGenerated]
	private int _IsolatedSelectorDeciderRate;

	[CompilerGenerated]
	private int _CustomStubDeciderDepth;

	[CompilerGenerated]
	private Color _TransferableTagDecider;

	[CompilerGenerated]
	private Color _ControllableChooser;

	[CompilerGenerated]
	private int _DeciderElementFreq;

	[CompilerGenerated]
	private bool _IsDeciderContext;

	[CompilerGenerated]
	private bool m_IsConfigurableCollectorViewer;

	[CompilerGenerated]
	private int deciderProfileFlag;

	[CompilerGenerated]
	private int _TransformablePolicyDeciderPosition;

	[CompilerGenerated]
	private int _OrderedArgumentDeciderErrorCode;

	[CompilerGenerated]
	private bool isQueueSet;

	[CompilerGenerated]
	private Color connectionValue;

	[CompilerGenerated]
	private Color m_DeciderRecord;

	[CompilerGenerated]
	private Color m_DeciderToken;

	[CompilerGenerated]
	private Color automatedSubscriberDecider;

	[CompilerGenerated]
	private int synchronizerDeciderDist;

	[CompilerGenerated]
	private Color _DeciderIterator;

	[CompilerGenerated]
	private int _DeciderRoleDist;

	[CompilerGenerated]
	private double dictionaryFinder;

	[CompilerGenerated]
	private bool _IsDeciderProc;

	[CompilerGenerated]
	private ResponsiveStructLocator operationalSummarizerDeciders;

	[CompilerGenerated]
	private bool m_IsStackAnnotation;

	[CompilerGenerated]
	private string _DeciderExtractorTag;

	[CompilerGenerated]
	private WriterMergeOption m_MonoLoggerDecider;

	private MapResponderLocator.ExpandableModelAllocator connectedGeneratorDecider;

	private EncryptorCacheBuffer.Series_Prop _AuditorDecider;

	private VisibleLocatorLocator m_ValidatorTracer;

	private int scalableProfilerLength;

	private int _ExpandableTransactionIdx;

	private int m_CombinedDriverDeciderVal;

	private RequesterTagExplorer m_ResponsivePublisherDecider;

	private double _DeciderEvaluator;

	private IntegratedMapperWriter _ComparatorDecider;

	private double? _ValueTree;

	private static DeciderClient ObserveMap;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, DialogValueWindow = typeof(CentralFunctionLocator))]
	[DisplayName("Symbol")]
	public string TickSymbol
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[DisplayName("Average Type")]
	[Category("General")]
	public IntegratedMapperWriter.ProgramSingletonTypes SmoothAverageType
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

	[DisplayName("Length")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 1.0, MaxValue = 2147483647.0)]
	public int SmoothLength
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

	[Category("General")]
	[DisplayName("Level above")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MinValue = 0.0, MaxValue = 2147483647.0)]
	public int LevelAbove
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

	[Category("General")]
	[DisplayName("Level below")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = -2147483647.0, MaxValue = 0.0)]
	public int LevelBelow
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

	[Category("General")]
	[DisplayName("Buy Zone Color")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	public Color ZoneBuyColor
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

	[DisplayName("Sell Zone Color")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6)]
	public Color ZoneSellColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7, MaxValue = 100.0)]
	[DisplayName("Opacity")]
	[Category("General")]
	public int ZoneOpacity
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Enable")]
	[Category("Simulation")]
	public bool SimulationEnable
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

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Simulation")]
	public bool SimulationStopReverse
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Contracts")]
	[Category("Simulation")]
	public int SimulationContracts
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
	[Category("Simulation")]
	[DisplayName("Stop Ticks")]
	public int SimulationStopTicks
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

	[Category("Simulation")]
	[DisplayName("Target Ticks")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, MaxValue = 2147483647.0)]
	public int SimulationTargetTicks
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

	[Category("Simulation")]
	[DisplayName("Export CSV")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	public bool ExportCsv
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	[Category("Simulation")]
	[DisplayName("Entry buy")]
	public Color SimulationEntryBuyColor
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7)]
	[DisplayName("Exit buy")]
	[Category("Simulation")]
	public Color SimulationExitBuyColor
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

	[DisplayName("Entry sell")]
	[Category("Simulation")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 8)]
	public Color SimulationEntrySellColor
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

	[DisplayName("Exit sell")]
	[Category("Simulation")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 9)]
	public Color SimulationExitSellColor
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

	[Category("Simulation")]
	[DisplayName("Arrow Text Size")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 10, MaxValue = 2147483647.0)]
	public int SimulationArrowTextSize
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

	[Category("Simulation")]
	[DisplayName("Text color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 11)]
	public Color SimulationArrowTextColor
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

	[DisplayName("Summary Text Size")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 12, MaxValue = 2147483647.0)]
	[Category("Simulation")]
	public int SimulationSummaryTextSize
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 13, DecimalPosToShow = 2, IncrementValue = 0.25)]
	[DisplayName("Commissions")]
	[Category("Simulation")]
	public double SimulationCommissions
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

	[DisplayName("Enable")]
	[Category("Alert Sound")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool EnableAlertSound
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, IsAlert = true)]
	[Category("Alert Sound")]
	[DisplayName("Alert Name")]
	public ResponsiveStructLocator AlertName
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

	[Category("Message Popup")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool EnableMessagePopup
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

	[Category("Message Popup")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public string MessageText
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[Category("Marker Settings")]
	public WriterMergeOption PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WriterMergeOption)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderClient()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001f;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 5;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2a4868de9f89474892002d95a55b688b != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					break;
				}
				goto IL_00c9;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_00c9;
				IL_00c9:
				WrapperStreamEditor.PresentConfiguration();
				WriterCommandResolver.ReflectDefinitionSelector();
				DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555375)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4A8FA9E0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9BCF0F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba), MapResponderLocator.BasicRecordReg.Statistics), EditableSetLocator.locatorPredicateCnt);
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderClient(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor reg, int control_Position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool containslast, bool iscol)
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
	public override void DecodeListener(bool applyinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool requireslast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DeleteDefinition(MapResponderLocator.GeneratorResponder info, bool iscaller)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer DecideSeparatedPublisher(int reference_Y, Color result)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateIdentifiableGateway()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderClient GenerateInternalDeciderObject()
	{
		return null;
	}
}
