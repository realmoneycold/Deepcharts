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

namespace Deepchart.Registry;

internal class GlobalWatcherReg : LocatorRequest
{
	internal enum DividedSpecSingletonMode
	{
		Line,
		Text,
		LineAndText
	}

	[CompilerGenerated]
	private int regCompilerProcessorSize;

	[CompilerGenerated]
	private int customErrorRegVal;

	[CompilerGenerated]
	private bool m_IsProcessorQueueReg;

	[CompilerGenerated]
	private DividedSpecSingletonMode m_QueueDicReg;

	[CompilerGenerated]
	private int _EventObserverInterval;

	[CompilerGenerated]
	private DashStyle dicRoleReg;

	[CompilerGenerated]
	private Color regRolePublisher;

	[CompilerGenerated]
	private Color _PublisherAdapterReg;

	[CompilerGenerated]
	private int dividedStreamRegFreq;

	[CompilerGenerated]
	private float m_RegAdapterManager;

	[CompilerGenerated]
	private Color m_DetailedProxy;

	[CompilerGenerated]
	private Color _RemoteChainReg;

	private RequesterTagExplorer _CalculatorEnumerator;

	private RequesterTagExplorer m_IdentifiableVerifierReg;

	private RequesterTagExplorer orderedDecoratorWriter;

	private RequesterTagExplorer regManagerCalc;

	private int regCalcLoggerDepth;

	private int _AdvancedConfigurationRegCounter;

	private double extractorWorker;

	private double _SortedConfiguration;

	private int regLoggerContextVal;

	private int contextCommandRegPos;

	private int m_NotifierMaps;

	private int m_GeneralDictionaryRegFreq;

	private double _LocalElementReg;

	private double m_RegCommandModule;

	private double readableViewerReg;

	private double _PassiveAnalyzerReg;

	private static GlobalWatcherReg SimulatePassiveEnumeratorSynchronizer;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MinValue = 1.0)]
	[DisplayName("Left bars")]
	public int LeftLength
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 0.0)]
	[DisplayName("Right bars")]
	public int RightLength
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
	[DisplayName("Filter swing")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 0.0)]
	public bool FilterSwing
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

	public DividedSpecSingletonMode DisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DividedSpecSingletonMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MinValue = 1.0)]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Plot Settings")]
	public DashStyle LineStyle
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Plot Settings")]
	public Color HighColor
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public Color LowColor
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public int TextTickOffset
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5, DecimalPosToShow = 2, MaxValue = 50.0, IncrementValue = 0.2)]
	public float TextSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	public Color HighTextColor
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
	[Category("Plot Settings")]
	public Color LowTextColor
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
	static GlobalWatcherReg()
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
					Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555606));
					MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699B0EFD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5B9391C1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5), MapResponderLocator.BasicRecordReg.Statistics);
					sortedPublisherWrapper.SetList(new List<string>
					{
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8E7CB8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x42AD0520 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_624b474964114179bb2ea3d4c0497999),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(-117581714 ^ -1103105426 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7819773D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eca23e1b791747c78ba1f3f94ba21ecf)
					});
					DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
					return;
				}
				case 1:
					break;
				}
				goto IL_0151;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_0151;
				IL_0151:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d4bf668f65b4434aa0b052a960d00de5 != 0)
				{
					num2 = 5;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalWatcherReg(ScopeEncryptor.HiddenModelDecider ident, MapResponderLocator.TransformableUserEncryptor cont, int column_res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isinstance, bool overridevis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer OpenEfficientContext(int configPosition, double second, Color serv)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer OpenTransferableBuffer(int no__setup, double second, bool countconsumer)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool stripinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAdaptableSynchronizerSingleton()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalWatcherReg NewObject()
	{
		return null;
	}
}
