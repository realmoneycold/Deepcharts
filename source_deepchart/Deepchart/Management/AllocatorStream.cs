using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaAPI.Chart;

namespace Deepchart.Management;

internal class AllocatorStream : LocatorRequest
{
	private class WrapperDecider
	{
		public Common.WriterWrapperHandler _CommonFieldWrapper;

		public Common.WriterWrapperHandler portableAuthenticatorWrapper;

		public Common.WriterWrapperHandler _WrapperWatcher;

		public Common.WriterWrapperHandler wrapperController;

		internal static WrapperDecider ParseWrapper;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateGeneralListLocator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperDecider AssetConfiguration()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private int engineDecryptorFreq;

	[CompilerGenerated]
	private bool _IsAutomatableInterpreterAllocator;

	[CompilerGenerated]
	private bool _IsProjectAllocator;

	[CompilerGenerated]
	private Color scheduledResolverAllocator;

	[CompilerGenerated]
	private Color genericFunctionAllocator;

	[CompilerGenerated]
	private Color configurableCollector;

	[CompilerGenerated]
	private int m_ErrorAllocatorIndex;

	[CompilerGenerated]
	private DashStyle procWatcher;

	[CompilerGenerated]
	private Color allocatorCreator;

	[CompilerGenerated]
	private Color dynamicSystemAllocator;

	[CompilerGenerated]
	private Color m_InterruptibleConfigurationAllocator;

	[CompilerGenerated]
	private Color m_AllocatorSet;

	[CompilerGenerated]
	private Color _DividedSubscriberAllocator;

	[CompilerGenerated]
	private Color m_AllocatorBuffer;

	[CompilerGenerated]
	private Color internalProcAllocator;

	[CompilerGenerated]
	private Color _AdaptableStateAllocator;

	[CompilerGenerated]
	private int _AllocatorMapperPnts;

	[CompilerGenerated]
	private int m_SolverAllocatorPerc;

	[CompilerGenerated]
	private int m_AllocatorAuthorizerInterval;

	private TimeSpan allocatorSpec;

	private TimeSpan m_ScalableTransmitterAllocator;

	private TimeSpan encryptorWrapper;

	private bool _IsInterruptibleWatcher;

	private double m_CustomizableObserverAllocator;

	private double allocatorStack;

	private double _AllocatorAttribute;

	private double allocatorUser;

	private int recordModulePerc;

	private int m_AllocatorTransactionRank;

	private int literalEngineAllocatorLength;

	private int _VisitorDecryptorRate;

	private int m_AllocatorAuthenticatorPerc;

	private bool isScheduledEditor;

	private long _ProxyAllocatorPos;

	private long _AllocatorIteratorLevel;

	private RequesterTagExplorer _SequentialEmitterAllocator;

	private RequesterTagExplorer _AllocatorSummarizer;

	private RequesterTagExplorer m_IntegratedVisitorAllocator;

	private RequesterTagExplorer _PortableBuilderAllocator;

	private RequesterTagExplorer _DynamicServer;

	private RequesterTagExplorer aggregatorToken;

	private RequesterTagExplorer m_GroupedClientAllocator;

	private RequesterTagExplorer m_AllocatorSynchronizer;

	private MapResponderLocator.ExpandableModelAllocator _ValueAllocator;

	private bool isModuleBuilder;

	private Dictionary<int, WrapperDecider> allocatorAllocatorDic;

	private IMonoCalcViewer _PredictorDictionary;

	internal static AllocatorStream CancelCompressor;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[DisplayName("RTH - opening range (min)")]
	public int OpeningRangeMinutes
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public bool EnableProjections
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public bool EnableZones
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
	[DisplayName("High color")]
	[StaticStructAllocator(SubCategory = "Range", CategoryIndex = 1, PropertyIndex = 0)]
	public Color ORHighColor
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
	[DisplayName("Mid color")]
	[StaticStructAllocator(SubCategory = "Range", CategoryIndex = 1, PropertyIndex = 1)]
	public Color ORMidColor
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
	[DisplayName("Low color")]
	[StaticStructAllocator(SubCategory = "Range", CategoryIndex = 1, PropertyIndex = 2)]
	public Color ORLowColor
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
	[DisplayName("Line width")]
	[StaticStructAllocator(SubCategory = "Range", CategoryIndex = 1, PropertyIndex = 3, MaxValue = 8.0)]
	public int ORLineWidth
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

	[StaticStructAllocator(SubCategory = "Range", CategoryIndex = 1, PropertyIndex = 4)]
	[DisplayName("Line style")]
	[Category("Plot Settings")]
	public DashStyle ORLineStyle
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

	[StaticStructAllocator(SubCategory = "Summary", CategoryIndex = 1, PropertyIndex = 5)]
	[DisplayName("Neutral color")]
	[Category("Plot Settings")]
	public Color StructureNeutralColor
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
	[StaticStructAllocator(SubCategory = "Summary", CategoryIndex = 1, PropertyIndex = 6)]
	[DisplayName("Positive color")]
	public Color StructurePositiveColor
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
	[DisplayName("Negative color")]
	[StaticStructAllocator(SubCategory = "Summary", CategoryIndex = 1, PropertyIndex = 7)]
	public Color StructureNegativeColor
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

	[StaticStructAllocator(SubCategory = "Projections", CategoryIndex = 1, PropertyIndex = 8)]
	[Category("Plot Settings")]
	[DisplayName("Protection color")]
	public Color StructureProjectionsProtectionColor
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

	[StaticStructAllocator(SubCategory = "Projections", CategoryIndex = 1, PropertyIndex = 9)]
	[DisplayName("Average color")]
	[Category("Plot Settings")]
	public Color StructureProjectionsAvgColor
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

	[StaticStructAllocator(SubCategory = "Projections", CategoryIndex = 1, PropertyIndex = 10)]
	[DisplayName("Projection color")]
	[Category("Plot Settings")]
	public Color StructureProjectionsStdDevColor
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

	[StaticStructAllocator(SubCategory = "Zones", CategoryIndex = 1, PropertyIndex = 11)]
	[DisplayName("Support")]
	[Category("Plot Settings")]
	public Color TFollowSupportColor
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
	[StaticStructAllocator(SubCategory = "Zones", CategoryIndex = 1, PropertyIndex = 12)]
	[DisplayName("Resistence")]
	public Color TFollowResistenceColor
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

	[DisplayName("Opacity")]
	[StaticStructAllocator(SubCategory = "Zones", CategoryIndex = 1, PropertyIndex = 13)]
	[Category("Plot Settings")]
	public int TFollowOpacity
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
	[DisplayName("Bar extensionsion")]
	[StaticStructAllocator(SubCategory = "Zones", CategoryIndex = 1, PropertyIndex = 14)]
	public int TFollowExtendBars
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
	[DisplayName("Line width")]
	[StaticStructAllocator(SubCategory = "Zones", CategoryIndex = 1, PropertyIndex = 15)]
	public int TFollowLineWidth
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
	static AllocatorStream()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555385)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x68D01914 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fba289398733422f859a60f7abb79212), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x17CF5F5B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator.m_ActiveEngineLocatorPosition);
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_af271e62bca64cb1bd7376e6543250e0 != 0)
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
	public AllocatorStream(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor vis, int res_X)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isinstance, bool iscfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer MonitorProxy(Color v)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseActiveError(Color i, string ord)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CloneServer(int setup_min, double attr, Color temp, bool isinit2, string second3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer AttachModule()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ReleaseSymbolicReporter(int start_reference, int sizeb, Color c, double result2)
	{
		return null;
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
	public override void DecodeListener(bool isv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator def, bool includeresult, MapResponderLocator.TokenParameterViewer rule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool writeres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool iskey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateConcreteTransmitter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PostReg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AssignAdvancedIterator(out int first, out int b, out int filter)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateOrderedPredicate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateAdaptableReceiverField()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorStream SimulateRandomFieldEnumerator()
	{
		return null;
	}
}
