using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaAPI.Chart;

namespace Deepchart.Management;

internal class AllocatorInterpreterResolver : LocatorRequest
{
	internal enum StaticThreadViewer
	{
		Bars,
		ZigZag
	}

	[CompilerGenerated]
	private StaticThreadViewer _ProviderField;

	[CompilerGenerated]
	private int _SchemaSynchronizerIdx;

	[CompilerGenerated]
	private double m_ResolverFunctionAllocator;

	[CompilerGenerated]
	private SequentialAttributeReg.PropertyPosition m_AllocatorFunctionSystem;

	[CompilerGenerated]
	private double m_OperationalInitializer;

	[CompilerGenerated]
	private int _InternalStateAllocators;

	[CompilerGenerated]
	private int m_AdaptableTransmitterAllocatorAge;

	[CompilerGenerated]
	private DashStyle _ScalableObserverAllocator;

	[CompilerGenerated]
	private Color m_ControllableTemplate;

	[CompilerGenerated]
	private Color m_CustomizableEngineAllocator;

	[CompilerGenerated]
	private int _AllocatorSystemConfigurationRank;

	[CompilerGenerated]
	private DashStyle _ConfigurationSubscriberAllocator;

	[CompilerGenerated]
	private Color m_CacheFormatter;

	[CompilerGenerated]
	private Color enumeratorParameter;

	[CompilerGenerated]
	private int _LiteralEmitterAllocatorId;

	[CompilerGenerated]
	private DashStyle m_SequentialVisitorAllocator;

	[CompilerGenerated]
	private Color m_IntegratedBuilderAllocator;

	[CompilerGenerated]
	private Color advancedGatewayViewer;

	private Common.WriterWrapperHandler executorAdapter;

	private Common.WriterWrapperHandler chooserObject;

	private double allocatorSubscriberProc;

	private double m_AdaptableElement;

	private int portableClientAllocatorDist;

	private int m_GroupedStubAllocatorIndex;

	private SequentialAttributeReg allocatorProcState;

	private SequentialAttributeReg.LocatorBridgeRequester m_AuditorProgram;

	private bool _IsIntegratedThread;

	private int modularObjectAllocators;

	private int allocatorStateTransmitterNum;

	private int m_ElementPoolCounter;

	private int m_ConnectedTokenAllocatorRank;

	private double _FlexibleCompilerAllocator;

	private double _AllocatorTransmitterObserver;

	private bool m_IsMonoExtractorAllocator;

	private RequesterTagExplorer allocatorObserverEngine;

	private RequesterTagExplorer senderSystem;

	private RequesterTagExplorer _SegmentedProfile;

	private static AllocatorInterpreterResolver ProcessBuilder;

	[Category("General")]
	[DisplayName("Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public StaticThreadViewer Mode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (StaticThreadViewer)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Bars")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 1000000000.0)]
	[Category("General")]
	public int Bars
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, DecimalPosToShow = 2, IncrementValue = 0.25)]
	public double StdDevValue
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

	[Category("Zig Zag Settings")]
	[DisplayName("Zig Zag Mode")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public SequentialAttributeReg.PropertyPosition ZigZagMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SequentialAttributeReg.PropertyPosition)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0)]
	[DisplayName("Zig Zag Abs. Rev")]
	[Category("Zig Zag Settings")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[DisplayName("Zig Zag Tick Rev./Highest Lowest")]
	[Category("Zig Zag Settings")]
	public int ZigZagTickHLParam
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

	[DisplayName("Line width")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Mid - Plot settings")]
	public int MidLineWidth
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

	[Category("Mid - Plot settings")]
	[DisplayName("Line style")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public DashStyle MidLineStyle
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[DisplayName("Positive color")]
	[Category("Mid - Plot settings")]
	public Color MidPositiveColor
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

	[Category("Mid - Plot settings")]
	[DisplayName("Negative color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public Color MidNegativeColor
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

	[Category("Up - Plot settings")]
	[DisplayName("Line width")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public int UpLineWidth
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

	[DisplayName("Line style")]
	[Category("Up - Plot settings")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public DashStyle UpLineStyle
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

	[Category("Up - Plot settings")]
	[DisplayName("Positive color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public Color UpPositiveColor
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

	[Category("Up - Plot settings")]
	[DisplayName("Negative color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
	public Color UpNegativeColor
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

	[Category("Dn - Plot settings")]
	[DisplayName("Line width")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public int DnLineWidth
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

	[Category("Dn - Plot settings")]
	[DisplayName("Line style")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1)]
	public DashStyle DnLineStyle
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

	[Category("Dn - Plot settings")]
	[DisplayName("Positive color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public Color DnPositiveColor
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
	[DisplayName("Negative color")]
	[Category("Dn - Plot settings")]
	public Color DnNegativeColor
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
	static AllocatorInterpreterResolver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 5;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d1ef8d827c2b4164b57bd771db4dc028 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555551));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x594D229E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60e044da66db4b08896730b7f82d59f6), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AABEE4F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c), MapResponderLocator.BasicRecordReg.Statistics);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FAE625 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x623037A9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7EE07157 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorInterpreterResolver(ScopeEncryptor.HiddenModelDecider setup, MapResponderLocator.TransformableUserEncryptor cust, int max_control)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isconfig, bool istoken)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool requiresinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignExternalList(SequentialAttributeReg.LocatorBridgeRequester def, int flags_vis, int consumer_Low, double last2, double reg3, bool isreg4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMember()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer AssignPassiveVerifier(RequesterTagExplorer init, int row_visitor, int IDtemplate, double item2, double visitor3, int mintoken4, Color visitor5, Color last6, DashStyle value7, bool countinfo8)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MergeCollector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AllocatorInterpreterResolver InsertStream()
	{
		return null;
	}
}
