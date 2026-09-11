using System;
using System.Collections.Generic;
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

namespace VolAnalysis.Generators;

internal class ComparatorGenerator : LocatorRequest
{
	internal enum DeciderJsonDataType
	{
		PriceSlope,
		High,
		Low
	}

	private class SequentialAggregatorLocator
	{
		public RequesterTagExplorer m_CalculatorProcessorLocator;

		public int procServerId;

		public int commandCompilerCap;

		public int _LocatorFieldSynchronizerPnts;

		public int m_SetBufferLocatorOffset;

		public bool _IsLocatorProcessorEncryptor;

		private static SequentialAggregatorLocator GenerateControllableMatcherReporter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SequentialAggregatorLocator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SequentialAggregatorLocator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachRemoteReporterTransmitter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SequentialAggregatorLocator AttachEfficientTransmitterProc()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private int mixedGeneratorRank;

	[CompilerGenerated]
	private int isolatedGeneratorFlag;

	[CompilerGenerated]
	private int m_MixedCommandErrorCode;

	[CompilerGenerated]
	private int _TransferableGeneratorCounter;

	[CompilerGenerated]
	private int _ConnectedGeneratorPos;

	[CompilerGenerated]
	private int objectGeneratorDepth;

	[CompilerGenerated]
	private int _AnnotationInitializerScore;

	[CompilerGenerated]
	private DeciderJsonDataType adaptableGenerator;

	[CompilerGenerated]
	private bool m_IsSenderGenerator;

	[CompilerGenerated]
	private int recordEventFreq;

	[CompilerGenerated]
	private int m_CollectionObjectRate;

	[CompilerGenerated]
	private bool _IsGenericStream;

	[CompilerGenerated]
	private int m_ConvertibleDecoratorCap;

	[CompilerGenerated]
	private int _InternalGeneratorTotal;

	[CompilerGenerated]
	private int m_ComparatorInspectorFlag;

	[CompilerGenerated]
	private bool m_IsSetGenerator;

	[CompilerGenerated]
	private Color _GeneratorInspector;

	[CompilerGenerated]
	private Color attachedGenerator;

	[CompilerGenerated]
	private bool m_IsObjectController;

	[CompilerGenerated]
	private ResponsiveStructLocator m_IterableGenerators;

	[CompilerGenerated]
	private bool isNotifierEnumerator;

	[CompilerGenerated]
	private string generatorStrategyStatus;

	private List<SequentialAggregatorLocator> m_EfficientGenerators;

	private int senderStrategyFreq;

	private int notifierGeneratorRate;

	private int executorManagerIndex;

	private EncryptorCacheBuffer.Series_Prop m_GeneratorGateway;

	private long m_GeneratorAuthenticatorPosition;

	internal static ComparatorGenerator GuideThread;

	[Category("Trinity Settings")]
	[DisplayName("Maximum number of bars after reversal")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MinValue = 1.0, MaxValue = 2000.0)]
	public int BarReversalMargin
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2000.0)]
	[DisplayName("Minimum tick breakout")]
	[Category("Trinity Settings")]
	public int TickBreakoutMargin
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

	[DisplayName("Minimum delta % difference")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 100.0)]
	[Category("Trinity Settings")]
	public int MinDeltaPercDifference
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

	[DisplayName("Minimum delta value difference")]
	[Category("Trinity Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 2147483647.0)]
	public int MinDeltaAbsDifference
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MaxValue = 2000.0)]
	[DisplayName("Maximum tick of poc distance")]
	[Category("Trinity Settings")]
	public int PocNearnessTick
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 100.0)]
	[DisplayName("Highest/Lowest reversal bar")]
	[Category("Trinity Settings")]
	public int HighestLowestRefBar
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 500.0, MinValue = -500.0)]
	[Category("Marker Settings")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Marker Settings")]
	public DeciderJsonDataType PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderJsonDataType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Imbalance Settings")]
	public bool EnableImbalance
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 10000.0)]
	[DisplayName("Minimum Imbalance %")]
	[Category("Imbalance Settings")]
	public int MinImbalancePerc
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

	[Category("Imbalance Settings")]
	[DisplayName("Minimum Volume Diff.")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int MinImbalanceVol
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

	[Category("Imbalance Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public bool IncludeZeroOnImbalance
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

	[Category("Imbalance Settings")]
	[DisplayName("Min. Num. of Consecutive Imb.")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, MaxValue = 20.0, MinValue = 1.0)]
	public int MinNumConsImb
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0, MaxValue = 500.0)]
	[Category("Imbalance Plot Settings")]
	[DisplayName("Num. Extended Bars")]
	public int ExtendedBars
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

	[Category("Imbalance Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 10.0)]
	public int LineWidth
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

	[Category("Imbalance Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public bool TriggerOnlyTouch
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	[Category("Imbalance Fresh Zone")]
	public Color BuyColor
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

	[Category("Imbalance Fresh Zone")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	public Color SellColor
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

	[Category("Alert Sound")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
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

	[Category("Alert Sound")]
	[DisplayName("Alert Name")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, IsAlert = true)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorGenerator()
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
				case 0:
				{
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555472));
					MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FAA3B1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A3D2E0 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7), MapResponderLocator.BasicRecordReg.Volume);
					sortedPublisherWrapper.SetList(new List<string>
					{
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3F970A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AAB95DD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c)
					});
					DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator.m_ActiveEngineLocatorPosition);
					return;
				}
				case 1:
					break;
				}
				goto IL_0102;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_0102;
				IL_0102:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 5;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_00c16e707ebf4bec83c8b759d6aa24e6 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ComparatorGenerator(ScopeEncryptor.HiddenModelDecider ident, MapResponderLocator.TransformableUserEncryptor map, int third_high)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isconfig, bool isvis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateExpandableGenerator(bool isreference, int remove_TOKENAt, bool istemplate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer GuidePublisher(int remove_INFOAt, int position_attr, Color filter, double x2, bool istask3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CreateCombinedProject(int item, int nextmap, Color res, double reg2, bool requiresconfig3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseGroupedObserver(int def_low, int reg_X, int column_serv, bool rejectpred2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseIdentifiableRole()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseInternalSender()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateDetailedViewerAdapter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ComparatorGenerator GenerateVisualAdapterAttribute()
	{
		return null;
	}
}
