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
using VolumetricaAPI.Chart;

namespace VolAnalysis.Viewers;

internal class EnumeratorInspector : LocatorRequest
{
	private class ResponsiveDeciderDriver
	{
		public long Ticks;

		public List<int> customListList;

		internal static ResponsiveDeciderDriver SimulateModularVisitorDecryptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResponsiveDeciderDriver()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ResponsiveDeciderDriver()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateLocalDecryptorDefinition()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ResponsiveDeciderDriver AnalyzeThread()
		{
			return null;
		}
	}

	internal enum RegPresetColorValues
	{
		AbsoluteReversal,
		TickReversal
	}

	internal enum GeneratorRawUIStateTargets
	{
		Minute,
		Hour
	}

	internal enum DeciderFormattingContext
	{
		Not,
		Up,
		Down
	}

	[CompilerGenerated]
	private RegPresetColorValues parameterComparator;

	[CompilerGenerated]
	private double _CentralCollectorViewer;

	[CompilerGenerated]
	private int m_ControllerCollectionPosition;

	[CompilerGenerated]
	private Color _IdentifiableExecutor;

	[CompilerGenerated]
	private Color m_ViewerManager;

	[CompilerGenerated]
	private int m_ActiveFilterVal;

	[CompilerGenerated]
	private GeneratorRawUIStateTargets m_NodeSummarizer;

	[CompilerGenerated]
	private int m_ViewerProfilerVol;

	[CompilerGenerated]
	private int _InspectorDecoratorVol;

	[CompilerGenerated]
	private bool _IsConfigurableTokenizerViewer;

	[CompilerGenerated]
	private double _ViewerExtractor;

	[CompilerGenerated]
	private int m_ViewerProcVal;

	[CompilerGenerated]
	private Color m_CustomizableAuditorViewer;

	[CompilerGenerated]
	private DashStyle _LogicalConverterViewer;

	private DeciderFormattingContext segmentedChainViewer;

	private int m_ViewerElements;

	private int _ViewerMemberId;

	private int genericTreeIdx;

	private double attachedCollection;

	private double m_ViewerAuthenticator;

	private double viewerProgram;

	private double m_ViewerProject;

	private double dynamicStructViewer;

	private int _ServiceFormatters;

	private EncryptorCacheBuffer.Series_Prop _ViewerContext;

	private EncryptorCacheBuffer.Series_Prop m_IterableModelEncryptor;

	private bool m_IsOrderStub;

	private DateTime m_SequentialOrder;

	private int scopeExecutorAge;

	private List<ResponsiveDeciderDriver> m_ActiveAdapterViewers;

	private List<DateTime> viewerProxys;

	private TimeSpan m_ViewerConfig;

	private TimeSpan interruptibleObject;

	internal static EnumeratorInspector AttachLiteralTrackerList;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[DisplayName("Zig Zag Mode")]
	[Category("Zig Zag Settings")]
	public RegPresetColorValues ZigZagMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegPresetColorValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Zig Zag Settings")]
	[DisplayName("Zig Zag Abs. Rev")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0, IncrementValue = 0.25)]
	public double ZigZagAbsParam
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 500.0, IncrementValue = 2.0)]
	[Category("Zig Zag Settings")]
	[DisplayName("Zig Zag Tick Rev")]
	public int ZigZagTickParam
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

	[Category("Zig Zag Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Color Up")]
	public Color ZigUpColor
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

	[DisplayName("Color Down")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[Category("Zig Zag Settings")]
	public Color ZigDownColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 20.0)]
	[Category("Zig Zag Settings")]
	[DisplayName("Line Width")]
	public int ZigLineWidth
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

	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Record Time")]
	public GeneratorRawUIStateTargets RecordTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorRawUIStateTargets)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[DisplayName("Length")]
	[Category("Average")]
	public int RecordLength
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

	[DisplayName("Days")]
	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public int AverageDays
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MinValue = 0.0, MaxValue = 10000000.0, IncrementValue = 50.0)]
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Level Settings")]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	[Category("Level Settings")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EnumeratorInspector()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a6126685ec5c4a2e965639c5e5a991af == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555689));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C4DDE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7EE06C6B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4D83D53E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fba289398733422f859a60f7abb79212) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnumeratorInspector(ScopeEncryptor.HiddenModelDecider item, MapResponderLocator.TransformableUserEncryptor cust, int res_ID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isspec, bool verifyord)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ViewGeneralGateway(int indexOf_ident, Color visitor, int pool, DashStyle config2, bool ispol3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool moveinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveResponsiveCompiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool setfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ObserveSetPolicy(long indexOf_key)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateGlobalListLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EnumeratorInspector GenerateDetachedLocatorVerifier()
	{
		return null;
	}
}
