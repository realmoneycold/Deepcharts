using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

internal class LogicalAuditorViewer : LocatorRequest
{
	internal enum SortedValidatorDeciderState
	{
		PriceSlope,
		High,
		Low
	}

	internal enum LocatorTokenizerCalculator
	{
		PerBar,
		Total
	}

	[CompilerGenerated]
	private int subscriberViewerId;

	[CompilerGenerated]
	private int m_SynchronizerViewerAge;

	[CompilerGenerated]
	private int _SegmentedConverterViewerPnts;

	[CompilerGenerated]
	private int groupedEnumeratorVol;

	[CompilerGenerated]
	private int _ViewerObjectTotal;

	[CompilerGenerated]
	private int _DynamicChainViewerScore;

	[CompilerGenerated]
	private int m_ActiveStructViewerPerc;

	[CompilerGenerated]
	private SortedValidatorDeciderState controllableAdapterViewer;

	[CompilerGenerated]
	private bool _IsConvertibleBridgeViewer;

	[CompilerGenerated]
	private ResponsiveStructLocator m_ViewerAnalyzerList;

	[CompilerGenerated]
	private bool _IsViewerState;

	[CompilerGenerated]
	private string _SorterFilterLabel;

	private int _ExternalControllerViewerRank;

	private List<int> _VisitorServiceList;

	private List<int> hiddenMapViewers;

	private EncryptorCacheBuffer.Series_Prop m_FormatterViewer;

	private long m_MemberIteratorAge;

	private long _ConnectedRegViewerDepth;

	private bool? m_ViewerContainer;

	internal static LogicalAuditorViewer CombineTester;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2000.0)]
	[DisplayName("Minimum tick breakout")]
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

	[DisplayName("Minimum delta %")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 100.0)]
	public int MinDeltaPercDiff
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
	[DisplayName("Minimum per bar volume")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int MinPerBarVolume
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

	[DisplayName("Minimum cluster volume")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("General")]
	public int MinClusterVolume
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
	[DisplayName("Tick grouping")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 1.0, MaxValue = 2000.0)]
	public int TickGrouping
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

	[DisplayName("Highest/Lowest min bars")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MinValue = 2.0, MaxValue = 100.0)]
	[Category("General")]
	public int HighestLowestMinBars
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

	[DisplayName("Highest/Lowest nearness bars")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 1000.0)]
	[Category("General")]
	public int HighestLowestNearness
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

	[Category("Marker Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public SortedValidatorDeciderState PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SortedValidatorDeciderState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Alert Sound")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, IsAlert = true)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	[Category("Message Popup")]
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
	static LogicalAuditorViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555459));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3FAED2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B24D1AC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AE5F6B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF57AA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x594D1D40 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60e044da66db4b08896730b7f82d59f6)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator.m_ActiveEngineLocatorPosition);
		int num = 5;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_55101681db37471584ccbfc0c7771c3f == 0)
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
	public LogicalAuditorViewer(ScopeEncryptor.HiddenModelDecider def, MapResponderLocator.TransformableUserEncryptor cont, int control_Z)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool configstop, bool istoken)
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
	public override void DecodeListener(bool removevalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool rejectinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenInitializer(bool isspec, bool isconnection)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CombineResponder(bool insertparam, int counter, int helpermax, bool isfirst2, bool getconfig3, out bool counter4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TestNode()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LogicalAuditorViewer CallAuditor()
	{
		return null;
	}
}
