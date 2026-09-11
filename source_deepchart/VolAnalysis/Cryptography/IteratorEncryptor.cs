using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal class IteratorEncryptor : LocatorRequest
{
	internal enum DeciderInspectorEventFlags
	{
		Intrabar,
		All,
		ExtremeOnly,
		HighOnly,
		LowOnly,
		WickOnly
	}

	internal enum WriterUserActivationMode
	{
		Zones,
		Marker,
		MarkerAndZones
	}

	internal enum ThreadControllerKind
	{
		BarDirection,
		Low,
		High
	}

	private class DetailedSpecGenerator
	{
		public RequesterTagExplorer _JoinedStackGenerator;

		public RequesterTagExplorer _GeneratorParameter;

		public int m_GenericIteratorCount;

		public int _GeneratorErrorVal;

		public int _CentralObserverDepth;

		public int _GeneratorRecordCnt;

		public bool m_IsSortedEmitterGenerator;

		internal static DetailedSpecGenerator StopError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedSpecGenerator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DetailedSpecGenerator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AdaptMapper()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DetailedSpecGenerator SimulateVisualCompilerPolicy()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private int visibleListenerEncryptorInterval;

	[CompilerGenerated]
	private int _HandlerStreamCount;

	[CompilerGenerated]
	private DeciderInspectorEventFlags encryptorProvider;

	[CompilerGenerated]
	private int m_AutomatableLocatorEncryptorCount;

	[CompilerGenerated]
	private WriterUserActivationMode m_CalcRequester;

	[CompilerGenerated]
	private ThreadControllerKind m_EncryptorDriver;

	[CompilerGenerated]
	private int _GlobalAuditorEncryptorLevel;

	[CompilerGenerated]
	private int groupedCacheEncryptorLimit;

	[CompilerGenerated]
	private bool isEncryptorInterpreter;

	[CompilerGenerated]
	private Color encryptorProcessor;

	[CompilerGenerated]
	private Color m_ServerPublisher;

	[CompilerGenerated]
	private bool _IsTransactionEncryptor;

	[CompilerGenerated]
	private bool _IsControllableParameter;

	[CompilerGenerated]
	private Color tokenizerGenerator;

	[CompilerGenerated]
	private Color m_ActiveBufferEncryptor;

	[CompilerGenerated]
	private bool isEncryptorProxy;

	[CompilerGenerated]
	private ResponsiveStructLocator orderedErrorEncryptorList;

	[CompilerGenerated]
	private bool isEncryptorChecker;

	[CompilerGenerated]
	private string m_StubEnumeratorText;

	private List<DetailedSpecGenerator> extendedMatcherEncryptorList;

	private int _EncryptorValueErrorCode;

	private long interruptiblePoolEncryptorPerc;

	private long controllableFieldEncryptorValue;

	internal static IteratorEncryptor UpdateReceiver;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Minimum Tick Vol")]
	[Category("Unfinished Settings")]
	public int MinTickVol
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Max Unfinished Threshold")]
	[Category("Unfinished Settings")]
	public int MaxUnfVol
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[Category("Unfinished Settings")]
	public DeciderInspectorEventFlags IncludeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderInspectorEventFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 20.0, MinValue = 1.0)]
	[DisplayName("Min. Num. of Consecutive Zero")]
	[Category("Unfinished Settings")]
	public int MinNumConsUnf
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
	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Mode")]
	public WriterUserActivationMode PlotMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WriterUserActivationMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 1)]
	[DisplayName("Marker Price")]
	[Category("Plot Settings")]
	public ThreadControllerKind PlotMarkerPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ThreadControllerKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 2, MaxValue = 500.0)]
	[DisplayName("Num. Extended Bars")]
	[Category("Plot Settings")]
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

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 3, MaxValue = 10.0)]
	[Category("Plot Settings")]
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

	[StaticStructAllocator(SubCategory = "General", CategoryIndex = 1, PropertyIndex = 4)]
	[Category("Plot Settings")]
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
	[StaticStructAllocator(SubCategory = "Fresh Zone", CategoryIndex = 1, PropertyIndex = 5)]
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
	[StaticStructAllocator(SubCategory = "Fresh Zone", CategoryIndex = 1, PropertyIndex = 6)]
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
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 7)]
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
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 8)]
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
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 9)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Triggered Zone", CategoryIndex = 1, PropertyIndex = 10)]
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

	[Category("Alerts")]
	[DisplayName("Enable")]
	[StaticStructAllocator(SubCategory = "Alert Sound", CategoryIndex = 2, PropertyIndex = 0)]
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

	[StaticStructAllocator(SubCategory = "Message Popup", CategoryIndex = 2, PropertyIndex = 2)]
	[Category("Alerts")]
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

	[Category("Alerts")]
	[StaticStructAllocator(SubCategory = "Message Popup", CategoryIndex = 2, PropertyIndex = 3)]
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
	static IteratorEncryptor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2 != 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555638));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x46C27D8C ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B24BF50 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -128636410 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3FFAFA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IteratorEncryptor(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor token, int tagcounter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool removespec, bool requiresmap)
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
	public override void DecodeListener(bool countident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ConvertFactory(int v, int columnsecond, Color rule, double config2, bool testsecond3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CountUser(int referencecounter, int ID_ivk, Color state, double cont2, bool isreg3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeVirtualDecorator(int next_v, int previoussecond, int length_tag, bool containscounter2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetTester(bool isparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool stripinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateVisibleSubscriberClient()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IteratorEncryptor PresentEnumerator()
	{
		return null;
	}
}
