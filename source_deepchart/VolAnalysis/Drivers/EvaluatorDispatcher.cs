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
using VolumetricaAPI.Chart;

namespace VolAnalysis.Drivers;

internal class EvaluatorDispatcher : LocatorRequest
{
	internal enum MyAppDISPIDs
	{
		Left,
		Right
	}

	internal enum RegTargetMachineType
	{
		Minute,
		Hour,
		Day,
		Week
	}

	[CompilerGenerated]
	private float m_DriverExtractor;

	[CompilerGenerated]
	private int genericConverterDriverLength;

	[CompilerGenerated]
	private DashStyle expandableMapperDriver;

	[CompilerGenerated]
	private MyAppDISPIDs sortedTrackerDriver;

	[CompilerGenerated]
	private int m_AllocatorComparatorSize;

	[CompilerGenerated]
	private bool isDriverProgram;

	[CompilerGenerated]
	private RegTargetMachineType loggerMap;

	[CompilerGenerated]
	private int m_DriverStreamLength;

	[CompilerGenerated]
	private Color m_DriverRole;

	[CompilerGenerated]
	private Color m_PublisherRole;

	[CompilerGenerated]
	private Color m_ModelDriver;

	[CompilerGenerated]
	private Color m_RoleSender;

	[CompilerGenerated]
	private Color m_CacheDriver;

	[CompilerGenerated]
	private bool isDriverProcessor;

	[CompilerGenerated]
	private TimeSpan m_AdapterObject;

	[CompilerGenerated]
	private TimeSpan _TagDriver;

	private TimeSpan scalableResponderDriver;

	private TimeSpan m_InternalFinderDriver;

	private double _ConsumerAggregator;

	private double driverRecommender;

	private double _ConfigurableContainer;

	private bool _IsSelectorServer;

	private DateTime _TokenizerEmitter;

	internal static EvaluatorDispatcher BuildReceiver;

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, DecimalPosToShow = 2, MaxValue = 50.0, IncrementValue = 0.2)]
	public float FontSize
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 6.0, IncrementValue = 1.0)]
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("Plot Settings")]
	public MyAppDISPIDs LabelAlign
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (MyAppDISPIDs)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 1.0)]
	[Category("Plot Settings")]
	public int PeriodToShow
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Custom Reference - TF")]
	[DisplayName("Enable")]
	public bool EnableCustomReference
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

	[DisplayName("Param type")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Custom Reference - TF")]
	public RegTargetMachineType TimeFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegTargetMachineType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[DisplayName("Param value")]
	[Category("Custom Reference - TF")]
	public int NumTf
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Pivot Point")]
	[Category("Color Settings")]
	public Color PivotColor
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[DisplayName("R1")]
	[Category("Color Settings")]
	public Color R1Color
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

	[Category("Color Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("R2")]
	public Color R2Color
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

	[Category("Color Settings")]
	[DisplayName("S1")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public Color S1Color
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

	[Category("Color Settings")]
	[DisplayName("S2")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
	public Color S2Color
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Custom time session (Exchange time zone)")]
	public bool CustomTimeEnabled
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[DisplayName("Ini Time")]
	[Category("Custom time session (Exchange time zone)")]
	public TimeSpan CustomTimeIni
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	[Category("Custom time session (Exchange time zone)")]
	[DisplayName("End Time")]
	public TimeSpan CustomTimeEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EvaluatorDispatcher()
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
					if (num == 989)
					{
						goto end_IL_0012;
					}
					goto case 0;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555522)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE0E77D1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3785B937 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), MapResponderLocator.BasicRecordReg.Statistics));
					return;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 3;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eb00c3cda9204a6f95c5ebb885c0c9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EvaluatorDispatcher(ScopeEncryptor.HiddenModelDecider config, MapResponderLocator.TransformableUserEncryptor ivk, int util)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool assetclose, bool writereg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RequesterTagExplorer ForceEditableEvaluator(int mean_param, double visitor, Color field, string ident2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool excludefirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int RunIntegratedPool()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ForceStaticTracer(RegTargetMachineType res, int pred_size)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool hasitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateConvertibleDecoratorValidator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EvaluatorDispatcher GetEnumerator()
	{
		return null;
	}
}
