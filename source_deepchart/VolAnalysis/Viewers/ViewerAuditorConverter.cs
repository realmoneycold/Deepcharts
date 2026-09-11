using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Viewers;

internal class ViewerAuditorConverter : LocatorRequest
{
	internal enum ReadOnlyAttributeValue
	{
		StandardDeviation,
		PricePercentage
	}

	[CompilerGenerated]
	private ReadOnlyAttributeValue m_ViewerConverterChain;

	[CompilerGenerated]
	private bool m_IsViewerChainStruct;

	[CompilerGenerated]
	private double summarizerSynchronizer;

	[CompilerGenerated]
	private bool m_IsIdentifiableQueueViewer;

	[CompilerGenerated]
	private double _ViewerStructAdapter;

	[CompilerGenerated]
	private bool _IsCustomResponder;

	[CompilerGenerated]
	private double m_ViewerAdapterBridge;

	[CompilerGenerated]
	private DateTime viewerBridgeController;

	[CompilerGenerated]
	private DateTime _TransformerExecutor;

	[CompilerGenerated]
	private Color m_ListenerBuilder;

	[CompilerGenerated]
	private DashStyle _DecoratorObject;

	[CompilerGenerated]
	private int m_SpecLocatorVol;

	[CompilerGenerated]
	private Color _PassiveStrategyViewer;

	[CompilerGenerated]
	private DashStyle _SymbolicVisitorViewer;

	[CompilerGenerated]
	private int m_ViewerControllerMapLevel;

	[CompilerGenerated]
	private Color isolatedConfigurationViewer;

	[CompilerGenerated]
	private DashStyle _InterruptibleDeciderViewer;

	[CompilerGenerated]
	private int m_ViewerMapRegCounter;

	[CompilerGenerated]
	private Color m_DetailedObserver;

	[CompilerGenerated]
	private DashStyle _IterableServiceViewer;

	[CompilerGenerated]
	private int viewerRegModuleDepth;

	[CompilerGenerated]
	private Color m_CommonWriterViewer;

	[CompilerGenerated]
	private DashStyle _SeparatedComparatorViewer;

	[CompilerGenerated]
	private int _LocalAggregatorViewerDist;

	[CompilerGenerated]
	private Color _ResponsiveCompilerViewer;

	[CompilerGenerated]
	private DashStyle m_DetachedEventViewer;

	[CompilerGenerated]
	private int viewerModuleGeneratorTotal;

	[CompilerGenerated]
	private Color _ViewerGeneratorTester;

	[CompilerGenerated]
	private DashStyle m_TesterValueViewer;

	[CompilerGenerated]
	private int m_JoinedEditorViewerPosition;

	private bool isListenerProfiler;

	private bool isValueCalcViewer;

	private string m_ScalableGatewayCategory;

	private double _DetailedSetViewer;

	private double m_ScheduledSharerViewer;

	private double _FilteredCollectionGenerator;

	private double m_LocatorStack;

	private int orderedRunnerViewerIdx;

	private bool _IsViewerCalcProvider;

	private bool m_IsIntegratedAllocatorViewer;

	private DateTime viewerProviderWorker;

	private bool _IsFilteredSenderViewer;

	private EncryptorCacheBuffer.Series_Prop _LogicalStream;

	private EncryptorCacheBuffer.Series_Prop _WorkerTracerViewer;

	private EncryptorCacheBuffer.Series_Prop subscriberAnalyzer;

	private EncryptorCacheBuffer.Series_Prop statelessAuditor;

	private EncryptorCacheBuffer.Series_Prop m_RandomTrackerViewer;

	private EncryptorCacheBuffer.Series_Prop adjustableCompressorViewer;

	private EncryptorCacheBuffer.Series_Prop m_ObjectFormatter;

	internal static ViewerAuditorConverter AttachIdentifiableContainerInspector;

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 0)]
	public ReadOnlyAttributeValue EnvelopeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ReadOnlyAttributeValue)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 1, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	[Category("Envelope")]
	[DisplayName("First - Enable")]
	public bool FirstEnvEnable
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

	[DisplayName("First - Dev. Val")]
	[Category("Envelope")]
	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 2, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	public double FirstEnvStdDev
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

	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 3, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	[DisplayName("Second - Enable")]
	[Category("Envelope")]
	public bool SecondEnvEnable
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

	[DisplayName("Second - Dev. Val")]
	[Category("Envelope")]
	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 4, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	public double SecondEnvStdDev
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

	[DisplayName("Third - Enable")]
	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 5, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	[Category("Envelope")]
	public bool ThirdEnvEnable
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

	[StaticStructAllocator(SubCategory = "Envelopes", CategoryIndex = 0, PropertyIndex = 6, IncrementValue = 0.25, DecimalPosToShow = 2, MinValue = 0.25)]
	[DisplayName("Third - Dev. Val")]
	[Category("Envelope")]
	public double ThirdEnvStdDev
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

	[Category("General")]
	[StaticStructAllocator(SubCategory = "Date/Time", CategoryIndex = 0, PropertyIndex = 4, ShowLongDateTimeFormat = true)]
	[DisplayName("Start Date/Time")]
	public DateTime IniCustomDt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("End Date/Time")]
	[StaticStructAllocator(SubCategory = "Date/Time", CategoryIndex = 0, PropertyIndex = 5, ShowLongDateTimeFormat = true)]
	public DateTime EndCustomDt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(SubCategory = "VWAP", CategoryIndex = 1, PropertyIndex = 0)]
	public Color VWAPLineColor
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
	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "VWAP", CategoryIndex = 1, PropertyIndex = 1)]
	public DashStyle VWAPLineStyle
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

	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(SubCategory = "VWAP", CategoryIndex = 1, PropertyIndex = 2)]
	public int VWAPLineWith
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
	[DisplayName("Line Color")]
	[StaticStructAllocator(SubCategory = "Env. 1 +", CategoryIndex = 1, PropertyIndex = 0)]
	public Color Ev1UpLineColor
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
	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 1 +", CategoryIndex = 1, PropertyIndex = 1)]
	public DashStyle Ev1UpLineStyle
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

	[StaticStructAllocator(SubCategory = "Env. 1 +", CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	public int Ev1UpLineWith
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

	[StaticStructAllocator(SubCategory = "Env. 1 -", CategoryIndex = 1, PropertyIndex = 3)]
	[Category("Plot Settings")]
	[DisplayName("Line Color")]
	public Color Ev1DnLineColor
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
	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 1 -", CategoryIndex = 1, PropertyIndex = 4)]
	public DashStyle Ev1DnLineStyle
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

	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(SubCategory = "Env. 1 -", CategoryIndex = 1, PropertyIndex = 5)]
	public int Ev1DnLineWith
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

	[DisplayName("Line Color")]
	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Env. 2 +", CategoryIndex = 1, PropertyIndex = 6)]
	public Color Ev2UpLineColor
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
	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 2 +", CategoryIndex = 1, PropertyIndex = 7)]
	public DashStyle Ev2UpLineStyle
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

	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(SubCategory = "Env. 2 +", CategoryIndex = 1, PropertyIndex = 8)]
	public int Ev2UpLineWith
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
	[StaticStructAllocator(SubCategory = "Env. 2 -", CategoryIndex = 1, PropertyIndex = 9)]
	[DisplayName("Line Color")]
	public Color Ev2DnLineColor
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

	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 2 -", CategoryIndex = 1, PropertyIndex = 10)]
	[Category("Plot Settings")]
	public DashStyle Ev2DnLineStyle
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

	[DisplayName("Line Width")]
	[Category("Plot Settings")]
	[StaticStructAllocator(SubCategory = "Env. 2 -", CategoryIndex = 1, PropertyIndex = 11)]
	public int Ev2DnLineWith
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
	[DisplayName("Line Color")]
	[StaticStructAllocator(SubCategory = "Env. 3 +", CategoryIndex = 1, PropertyIndex = 12)]
	public Color Ev3UpLineColor
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
	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 3 +", CategoryIndex = 1, PropertyIndex = 13)]
	public DashStyle Ev3UpLineStyle
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

	[StaticStructAllocator(SubCategory = "Env. 3 +", CategoryIndex = 1, PropertyIndex = 14)]
	[DisplayName("Line Width")]
	[Category("Plot Settings")]
	public int Ev3UpLineWith
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

	[StaticStructAllocator(SubCategory = "Env. 3 -", CategoryIndex = 1, PropertyIndex = 15)]
	[DisplayName("Line Color")]
	[Category("Plot Settings")]
	public Color Ev3DnLineColor
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

	[DisplayName("Line Style")]
	[StaticStructAllocator(SubCategory = "Env. 3 -", CategoryIndex = 1, PropertyIndex = 16)]
	[Category("Plot Settings")]
	public DashStyle Ev3DnLineStyle
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

	[StaticStructAllocator(SubCategory = "Env. 3 -", CategoryIndex = 1, PropertyIndex = 17)]
	[Category("Plot Settings")]
	[DisplayName("Line Width")]
	public int Ev3DnLineWith
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

	[StaticStructAllocator(IsVisible = false)]
	[Category("Hidden")]
	public bool CustomOnLastBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	[Category("Hidden")]
	public string DrawingUserName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerAuditorConverter()
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
					Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555769));
					MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E42E75 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F482F61 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), MapResponderLocator.BasicRecordReg.Volume);
					sortedPublisherWrapper.SetList(new List<string>
					{
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x57419E18 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A0A30F4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2a4868de9f89474892002d95a55b688b)
					});
					sortedPublisherWrapper.Hidden = true;
					DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
					return;
				}
				case 1:
					break;
				}
				goto IL_003c;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_003c;
				IL_003c:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 5;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0bc27ac9f2bd46bca41590fe99075f1a != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerAuditorConverter(ScopeEncryptor.HiddenModelDecider var1, MapResponderLocator.TransformableUserEncryptor b, int indexOf_template)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isident, bool isreg)
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
	public override void DecodeListener(bool removeitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator task, bool validateb, MapResponderLocator.TokenParameterViewer field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool requiresdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReceiveParameter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ObserveGenericMapper(AllocatorCompilerEvent<MapResponderLocator.GeneralSystemWriter[]> reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GuideSet(AllocatorCompilerEvent<MapResponderLocator.GeneralSystemWriter[]> param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachInternalOrderListener()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerAuditorConverter ValidateTransformer()
	{
		return null;
	}
}
