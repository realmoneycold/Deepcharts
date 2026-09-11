using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.Drivers;
using VolAnalysis.Generators;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderElementEngine : IAdaptableReporterSingleton
{
	internal bool isProcessorField;

	internal GeneratorConfigurationArgument.TransferableValueReg deciderEngineContext;

	private AutomatableWriter _SeparatedFinalizerDecider;

	private MapResponderLocator.MixedRoleEncryptor compressorModule;

	private List<ScopeEncryptor.HiddenModelDecider> deciderContextProfileList;

	private List<MapResponderLocator.TransformableUserEncryptor> m_ActiveAnalyzerDeciderList;

	private FlexibleMemberReg genericResponderDecider;

	private EncryptorHandlerRecord _SimpleGateway;

	private Action<string, string, object, GraphGroupStyle> m_IntegratedSystemDecider;

	internal Dictionary<string, object> _MatcherDicMap;

	internal InternalSingletonSingleton m_DeciderProfileRecord;

	private TimeZoneInfo m_SeparatedTree;

	private string scheduledServerDeciderDescr;

	private WriterServerRecommender _ModularPoolDecider;

	private bool isGlobalErrorDecider;

	private object mixedExecutorDeciderObj;

	private List<LocatorObserver> _SymbolicHandlers;

	private Dictionary<int, CheckerParser> _CustomCompilerDic;

	internal Dictionary<int, List<Tuple<string, JoinedContextLocator, bool, object>>> m_TreeLoggerMap;

	private CheckerParser detailedModuleDecider;

	private static DeciderElementEngine PrepareFunction;

	public MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum ParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum)(object)null;
		}
	}

	public int Param1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public int Param2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public string OpenOrderedExtractor()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public bool DecideHiddenSchema()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public double OpenAlphabeticFinder()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public double CollectSingleton()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public TimeSpan HandleCalculator()
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public TimeSpan OpenControllableEditor()
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public DateTime StoreWorker()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public DateTime DecideLocalTracker()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int CheckMixedLocator()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public bool HandleRole()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public bool EnsureAccessibleProgram()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int EnsureAdaptableParameter()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int ProcessConverter()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public double EnsureDividedModule()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int RateSolver()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public MapResponderLocator.GeneratorResponder OpenTransferableClient()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public MapResponderLocator.CombinedEnumeratorDecider ViewInterpreter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public string ProcessQueue()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public string SaveDetachedAdapter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public string InsertFinder()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public MapResponderLocator.GeneratorResponder DecideSeparatedValidator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public List<MapResponderLocator.GeneratorResponder> WatchWatcher()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public MapResponderLocator.EmitterProxyWrapperValues ResetSubscriber()
	{
		return (MapResponderLocator.EmitterProxyWrapperValues)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderElementEngine(CheckerParser ident, string cont, List<ScopeEncryptor.HiddenModelDecider> comp, List<MapResponderLocator.TransformableUserEncryptor> connection2, FlexibleMemberReg spec3, Action<string, string, object, GraphGroupStyle> connection4, AutomatableWriter vis5, MapResponderLocator.MixedRoleEncryptor vis6, InternalSingletonSingleton ivk7, GeneratorConfigurationArgument.TransferableValueReg item8, object instance9, EncryptorHandlerRecord first10, List<LocatorObserver> map11)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MeasureError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IMonoCalcViewer SerializeClient(Action<RequesterTagExplorer> setup = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DriverSharer DetermineControllableBuffer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapResponderLocator.ExpandableModelAllocator DisableExecutor(string i, bool? b = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapResponderLocator.ExpandableModelAllocator DisableExecutor(string i, MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum visitor, int dircounter, int size_asset2, bool? t3 = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapResponderLocator.ExpandableModelAllocator DisableExecutor(string setup, MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum counter, int column_res, int ord2_high, int ident3, bool doconnection4)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScheduledObjectReg OpenStaticVisitor(EditableIteratorReg config, int next_map, double field = 0.0, bool isident2 = false, bool isivk3 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long LeadMatcher(int reference)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogicalStateEncryptor EnsureEfficientState(int v_size, List<List<LogicalStateEncryptor>> b, DateTime pool, DateTime pol2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogicalStateEncryptor PlayTransmitter(int idxvalue)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreCustomizableDecryptor(List<RequesterTagExplorer> setup, RequesterTagExplorer reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenAutomatedDefinition(StrategyEditor value, string connection, JoinedContextLocator temp, bool isresult2 = true, object pred3 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CheckerParser DetermineLiteralConsumer(int param_X)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DetermineGlobalTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal List<MapResponderLocator.GeneratorResponder> DetermineDetachedTag(int sumfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal DateTime EncryptExplorer(int infoamount, int ivk_counter)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal LocatorRequest DecideCustomTokenizer(int length_first, int cont_min)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal MapResponderLocator.TransformableUserEncryptor FilterSystem(int init_Ptr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonHandlerConnection.AlphabeticExecutorReg CheckBuilder()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double EnsureBasicPool(List<MapResponderLocator.GeneratorResponder> asset, int ID_counter, int c_high)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double DetermineOperationalTracer(int resmin, int connection)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double DetermineFlexiblePredictor(List<MapResponderLocator.GeneratorResponder> task, int remove_BAt, int indexOf_role)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double FlushRecord(int length_first, int col_length)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EnsureIntegratedAllocator(List<MapResponderLocator.GeneratorResponder> res, int indexOfcounter, int tempX, bool explicitvar12 = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InstantiateCollector(int insert_VALUEAt, int ivk_start, bool requiresrole = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DetermineStaticTree(List<MapResponderLocator.GeneratorResponder> res, int position_ord, int c_length, bool appendcust2 = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StoreConnectedResponder(int indexOf_item, int indexOf_cust, bool checkstate = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PatchManager()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveAutomatableService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<MapResponderLocator.GeneratorResponder> StoreCombinedSchema()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<MapResponderLocator.GeneratorResponder> SaveGroupedValue(int key_Z)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingletonHandlerConnection.ObjectAuthenticatorLocator[] InvokeVisitor(MapResponderLocator.GeneratorResponder i, MapResponderLocator.FilterWatcherLocator caller = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color OpenInternalTask(Color task, Color ivk, double dir, bool skipcol2 = false, int task3ID = 5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<MapResponderLocator.GeneratorResponder> SaveAdjustableBridge()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int PushBuffer(int first_Ptr, int connection_Ptr, MapResponderLocator.PanningMode res, MapResponderLocator.LocatorUnaryExpressionType setup2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SaveIterableFinalizer()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int StoreHiddenResolver(double first)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenModularEvent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public bool OpenLocalStub()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DetermineCustomizableGenerator(bool testv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal TimeZoneInfo DecideAutomatedRunner()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string BuildState()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EnsureConvertibleObserver(out TimeSpan info, out TimeSpan ord)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime SaveConfigurableConnection(DateTime spec)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime SaveConfigurableConnection(DateTime spec, TimeSpan map)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime StoreMixedCommand(DateTime reference)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime StoreMixedCommand(DateTime setup, TimeSpan col)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OpenScheduledWrapper(DateTime setup, List<MapResponderLocator.GeneratorResponder> b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetConsumer(DateTime def, List<MapResponderLocator.GeneratorResponder> pred, bool haveutil = false)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime SaveMonoConfig(DateTime item, int selection_amount)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreExternalConfiguration(string Text, string Title)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreAccessibleRecommender(string first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DateTime OpenPassiveStruct()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int EnsureExpandableController(double value, double vis, string tag)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Color DecodeTag(int last_start, int pol_ID = 0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void DetachChecker(bool havesetup, int maxord = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal double StartTokenizer(string asset)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EncryptorCacheBuffer.BaseIndicatorPrms CreatePredictor(int ident_high)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double[] OpenRandomDriver(int item, int flags_cfg, int version_template)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScheduledObjectReg EnsureIdentifiableWriter(int lastlength, int num_visitor, int consumer)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ExecutePool(bool ineeded)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int EnsureAdjustableResponder(bool ignorespec)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public bool SaveDynamicSharer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int OpenReadableDecider()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OpenDividedObject()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int VerifyPredictor()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SaveIsolatedRequest(double first, double cfg)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OpenSeparatedChain(int reference_ID, int max_pred)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OpenScalableOrder(int size_value, int pol_X)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double StoreVirtualListener(double param, int selection)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerCalculatorStack SaveScopeDistributor(int configlength)
	{
		return (ViewerCalculatorStack)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisualMatcherLocator SaveLogicalCreator(double value)
	{
		return (VisualMatcherLocator)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ChangeRequester(double config, bool setconnection = true, string comp = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double SaveResponsiveElement(double var1, double cust, int no__c = 1, bool validatesetup2 = true)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SolveWriter(string value, SequentialProjectDriverState cont = (SequentialProjectDriverState)1, string rule = null, bool? v2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SaveSortedEncryptor(int size_last, int counter_low, MapResponderLocator.PanningMode proc, MapResponderLocator.LocatorUnaryExpressionType asset2, int sum_def3, bool caller4close)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color RunTransformer(MapResponderLocator.SymbolicTokenizerLocatorType res, MapResponderLocator.AllocatorExternalDataSourceType result, MapResponderLocator.WrapperLayoutMode? res = null, double cust2 = 1.0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderElementEngine()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateCustomizableDecoratorValidator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderElementEngine AttachAutomatedValidatorReg()
	{
		return null;
	}
}
