using System;
using System.Collections.Generic;
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

internal class LocatorReceiver : LocatorRequest
{
	internal enum ExtractorRequester
	{
		ImbalanceDiagonal,
		ImbalanceHorizontal,
		DeltaPercentageHorizontal
	}

	private class AllocatorTemplateField
	{
		public RequesterTagExplorer compressorMonitorAllocator;

		public RequesterTagExplorer connectedQueueAllocator;

		public int m_LocalSystemScore;

		public int _FlexibleEventAllocatorRate;

		public int _EncryptorEditorUserVol;

		public int m_AllocatorFieldParserValue;

		public bool isMapDispatcher;

		private static AllocatorTemplateField SimulatePassiveVisitorDecryptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllocatorTemplateField()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllocatorTemplateField()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAdaptableDecryptorDefinition()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllocatorTemplateField SimulateRandomDefinitionSelector()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private ExtractorRequester _OperationalProcessorLocator;

	[CompilerGenerated]
	private int _OrderedSynchronizerLocatorRate;

	[CompilerGenerated]
	private int _LiteralWorkerValue;

	[CompilerGenerated]
	private bool isMixedEncryptorLocator;

	[CompilerGenerated]
	private int transferableServerIdx;

	[CompilerGenerated]
	private int m_WrapperChainLevel;

	[CompilerGenerated]
	private int portableTagLocatorLevel;

	[CompilerGenerated]
	private int m_LocatorRecommenderSize;

	[CompilerGenerated]
	private bool _IsInternalObserverLocator;

	[CompilerGenerated]
	private Color m_FinalizerInspector;

	[CompilerGenerated]
	private Color _ExtractorPool;

	[CompilerGenerated]
	private bool _IsTransformableControllerLocator;

	[CompilerGenerated]
	private bool m_IsGlobalConverterLocator;

	[CompilerGenerated]
	private Color contextInterpreter;

	[CompilerGenerated]
	private Color m_FilteredHandler;

	[CompilerGenerated]
	private bool _IsChainDistributor;

	[CompilerGenerated]
	private ResponsiveStructLocator m_InspectorViewerList;

	[CompilerGenerated]
	private bool isHiddenValueLocator;

	[CompilerGenerated]
	private string virtualWorkerName;

	private List<AllocatorTemplateField> _InterpreterSenderList;

	private int locatorFilterPos;

	private long simpleFunctionLocatorCnt;

	private AllocatorCompilerEvent<MapResponderLocator.GeneralSystemWriter> _LocatorWatcher;

	private List<MapResponderLocator.GeneralSystemWriter> centralExtractorLocators;

	private static LocatorReceiver GenerateLiteralServiceSchema;

	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 0)]
	[Category("Imbalance Settings")]
	[DisplayName("Calculation mode")]
	public ExtractorRequester CalculationMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ExtractorRequester)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Imbalance Settings")]
	[DisplayName("Minimum %")]
	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 1, MaxValue = 10000.0)]
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

	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Minimum Delta Value")]
	[Category("Imbalance Settings")]
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
	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 3)]
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
	[DisplayName("Min. Num. of Consecutive")]
	[StaticStructAllocator(SubCategory = "Data Settings", CategoryIndex = 0, PropertyIndex = 4, MaxValue = 20.0, MinValue = 1.0)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, SubCategory = "Tick Grouping", MaxValue = 600.0)]
	[Category("Imbalance Settings")]
	public int TickGroupingTicks
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 0, MaxValue = 500.0)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 1, MaxValue = 10.0)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 2)]
	public bool ResetOnSessionOpen
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Fresh Zone", CategoryIndex = 1, PropertyIndex = 3)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Fresh Zone", CategoryIndex = 1, PropertyIndex = 4)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 5)]
	public bool EnableTriggeredZone
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 6)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 7)]
	public Color BuyTrigColor
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

	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 8)]
	[Category("Plot Settings")]
	public Color SellTrigColor
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

	[StaticStructAllocator(SubCategory = "Alert Sound", CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Alerts")]
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

	[StaticStructAllocator(SubCategory = "Alert Sound", CategoryIndex = 2, PropertyIndex = 1, IsAlert = true)]
	[DisplayName("Alert Name")]
	[Category("Alerts")]
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

	[Category("Alerts")]
	[DisplayName("Enable")]
	[StaticStructAllocator(SubCategory = "Message Popup", CategoryIndex = 2, PropertyIndex = 2)]
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

	[StaticStructAllocator(SubCategory = "Message Popup", CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Alerts")]
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
	static LocatorReceiver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 2;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7 != 0)
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555418)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F511931 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F675E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator._FormatterElementPnts);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocatorReceiver(ScopeEncryptor.HiddenModelDecider param, MapResponderLocator.TransformableUserEncryptor cont, int serv_Low)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool deletevalue, bool isattr)
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
	public override void DecodeListener(bool havefirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ClearMixedAuthorizer(int end_ident, int cont_min, Color consumer, double visitor2, bool includepred3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer IdentifyScheduledService(int num_i, int cont_offset, Color c, double attr2, bool isvis3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindMonoSchema(int rescounter, int result_size, int controlZ, bool isx2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindExternalValue(bool isreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool removetask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateGlobalSchemaValue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorReceiver SimulateDetachedValueTracker()
	{
		return null;
	}
}
