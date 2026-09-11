using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace Deepchart.DecisionMaking;

internal class DeciderChooserSpec : LocatorRequest
{
	internal enum SortedFunctionViewer
	{
		Volume,
		Trades
	}

	internal enum PopulateMode
	{
		Fixed,
		FadingColor
	}

	[CompilerGenerated]
	private string visibleCompilerMsg;

	[CompilerGenerated]
	private MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum _OperationalProc;

	[CompilerGenerated]
	private int _DeciderSpecSelectorPnts;

	[CompilerGenerated]
	private int m_DeciderSelectorStubCnt;

	[CompilerGenerated]
	private bool m_IsIntegratedResponderDecider;

	[CompilerGenerated]
	private bool m_IsPassiveProgramEncryptor;

	[CompilerGenerated]
	private SortedFunctionViewer scheduledSystemDecider;

	[CompilerGenerated]
	private PopulateMode deciderStubTag;

	[CompilerGenerated]
	private double _PredictorModel;

	private Common.WriterWrapperHandler m_CustomizableCompressor;

	private VisualWrapperRequester<long> deciderTagPolicy;

	private Common.WriterWrapperHandler _DeciderPolicyArgument;

	private long _ArgumentSubscriberDeciderLimit;

	private RequesterTagExplorer _DeciderSubscriberSummarizer;

	private EncryptorCacheBuffer.Series_Prop modularServerDecider;

	private MapResponderLocator.ExpandableModelAllocator _GlobalPoolDecider;

	private int mixedErrorDeciderStep;

	private int _SeparatedEvaluatorGeneratorFlag;

	private MapResponderLocator.GeneratorResponder schemaTransmitter;

	private ScheduledObjectReg m_DetailedExecutorDecider;

	internal static DeciderChooserSpec EnableRequest;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, DialogValueWindow = typeof(CentralFunctionLocator))]
	[Category("General")]
	[DisplayName("Symbol")]
	public string Symbol
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
	[DisplayName("Param Type")]
	[Category("General")]
	public MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum ParamType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MapResponderLocator.PassiveFactoryAllocator.ParamTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Param 1")]
	[StaticStructAllocator(MaxValue = 1000000.0, DecimalPosToShow = 0, CategoryIndex = 0, PropertyIndex = 2)]
	public int Param1
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
	[DisplayName("Param 2")]
	[StaticStructAllocator(MaxValue = 1000000.0, DecimalPosToShow = 0, CategoryIndex = 0, PropertyIndex = 3)]
	public int Param2
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool ColorBasedOnDelta
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

	[Category("Volume/Delta")]
	[DisplayName("Border based on Open/Close")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public bool BorderBasedOpenClose
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public SortedFunctionViewer DeltaInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SortedFunctionViewer)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	[Category("Volume/Delta")]
	public PopulateMode ColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PopulateMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, MinValue = 0.75, MaxValue = 4.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
	[Category("Volume/Delta")]
	public double StdDevForColoring
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderChooserSpec()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 2;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_af271e62bca64cb1bd7376e6543250e0 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555514));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(--160250047 ^ 0x3928CD93 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x564464DB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), MapResponderLocator.BasicRecordReg.Overlay);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B63D779 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderChooserSpec(ScopeEncryptor.HiddenModelDecider first, MapResponderLocator.TransformableUserEncryptor connection, int fieldlow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool ignoreconfig, bool setconnection)
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
	public override void DecodeListener(bool evaluatedef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool istask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetermineEfficientHandler(MapResponderLocator.GeneratorResponder asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureTransferableContext()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureLiteralBuffer(bool checktask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureGlobalMonitor(MapResponderLocator.GeneratorResponder item, bool iscfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool calcdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer MergeFilter(int itemstart, double pol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachExtendedListLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderChooserSpec AttachCustomLocatorVerifier()
	{
		return null;
	}
}
