using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Drivers;

internal class IterableExplorerDriver : LocatorRequest
{
	internal enum AllocatorConfigNodeSubType
	{
		Tick,
		SecToClose,
		Close
	}

	[CompilerGenerated]
	private AllocatorConfigNodeSubType driverOrder;

	[CompilerGenerated]
	private int m_DriverTesterCap;

	[CompilerGenerated]
	private int m_FilteredDictionaryDriverLength;

	[CompilerGenerated]
	private int m_StaticErrorDriverCount;

	[CompilerGenerated]
	private int _DriverWatcherAge;

	[CompilerGenerated]
	private int _CentralTracerDriverRate;

	[CompilerGenerated]
	private int m_DriverContextRate;

	[CompilerGenerated]
	private bool m_IsVisualServerDriver;

	[CompilerGenerated]
	private ResponsiveStructLocator _TokenDriverList;

	[CompilerGenerated]
	private bool m_IsAuditorBridge;

	[CompilerGenerated]
	private string m_DriverQueueName;

	private int m_RemotePredicateDist;

	private int m_DispatcherTransformerSize;

	private int integratedProcDriverValue;

	private int m_CombinedFieldDriverCount;

	private int m_AdaptableMonitorDriverFreq;

	private double m_LocalDriverDriver;

	private bool isDetailedIteratorDriver;

	private bool isAdjustableStrategyDriver;

	private bool isDriverValue;

	private bool _IsDriverAdapter;

	internal static IterableExplorerDriver AdaptList;

	[DisplayName("Calculation Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public AllocatorConfigNodeSubType CalcMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorConfigNodeSubType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Maximum Seconds To Close")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public int MaxSecToClose
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
	[DisplayName("Lookback Period")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public int LookBackBar
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

	[DisplayName("Minimum Body Tick")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MinValue = 1.0)]
	public int MinBodyTick
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 1.0)]
	[Category("General")]
	[DisplayName("Minimum Volume")]
	public int MinVolume
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

	[DisplayName("Minimum Imbalance")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MinValue = 1.0, MaxValue = 1000.0)]
	public int MinImbalance
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
	[DisplayName("Tick Offset")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6)]
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

	[Category("Alert Sound")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, IsAlert = true)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Message Popup")]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
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
	static IterableExplorerDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555564)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE887197 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x623039B7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator.m_LocatorManagerPos);
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c4b807f2d234a1db471f24a593fc425 == 0)
		{
			num = 0;
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
	public IterableExplorerDriver(ScopeEncryptor.HiddenModelDecider info, MapResponderLocator.TransformableUserEncryptor caller, int num_control)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isdef, bool testsecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlScopeDecorator(bool removei, bool isivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateVisualAttributeBuilder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IterableExplorerDriver SimulateStatelessBuilderCollector()
	{
		return null;
	}
}
