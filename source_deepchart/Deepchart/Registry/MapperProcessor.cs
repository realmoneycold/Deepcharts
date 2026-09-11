using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace Deepchart.Registry;

internal class MapperProcessor : LocatorRequest
{
	[Serializable]
	internal struct RangeSettings
	{
		internal static object GenerateFlexibleRecordHandler;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("First Range")]
		public bool EnableRange0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("First Range")]
		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		public Color VolumeColor1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("First Range")]
		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		public Color BidColor1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("First Range")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		[DisplayName("Ask Color")]
		public Color AskColor1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[Category("Second Range")]
		public bool EnableRange1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Second Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Volume Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		[Category("Second Range")]
		public Color VolumeColor2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[Category("Second Range")]
		public Color BidColor2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Second Range")]
		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		public Color AskColor2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Third Range")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		public bool EnableRange2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Third Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[Category("Third Range")]
		[DisplayName("Volume Color")]
		public Color VolumeColor3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
		[DisplayName("Bid Color")]
		[Category("Third Range")]
		public Color BidColor3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Third Range")]
		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		public Color AskColor3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Fourth Range")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		public bool EnableRange3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fourth Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
		[Category("Fourth Range")]
		public Color BidColor4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Fourth Range")]
		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		public Color AskColor4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		[DisplayName("Volume Color")]
		[Category("Fourth Range")]
		public Color VolumeColor4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Fifth Range")]
		public bool EnableRange4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fifth Range")]
		[DisplayName("Value")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int Range4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fifth Range")]
		[DisplayName("Bid Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
		public Color BidColor5
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Fifth Range")]
		[DisplayName("Ask Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
		public Color AskColor5
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Fifth Range")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
		[DisplayName("Volume Color")]
		public Color VolumeColor5
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		public void Migrate()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RangeSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateEditableHandlerContext()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DisableDecorator()
		{
			return null;
		}
	}

	internal enum EncryptorVisualStatus
	{
		Volume,
		Delta,
		Imbalance,
		DominantVolume,
		VolumeDominantDelta,
		DeltaPercentage
	}

	[Serializable]
	internal struct ColorSettings
	{
		internal enum OperationalPublisherDecider
		{
			None,
			Fixed,
			FadingColor,
			MultipleColor
		}

		internal enum InstanceNameTruncOptions
		{
			Intensity,
			Opacity
		}

		internal enum RemoteFinalizerLocator
		{
			Automatic,
			UserDefined
		}

		internal static object SimulateJoinedArgumentConsumer;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Color mode")]
		[Category("General")]
		public OperationalPublisherDecider MethodColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (OperationalPublisherDecider)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
		[Category("General")]
		public EncryptorVisualStatus ColorCalculation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (EncryptorVisualStatus)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[DisplayName("Fading mode")]
		[Category("General")]
		public InstanceNameTruncOptions FadingColorMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (InstanceNameTruncOptions)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Min. Vol. Diff. for Imbalance")]
		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 2)]
		[Category("General")]
		public int MinimumDifferenceImbalance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 3)]
		[Category("General")]
		public bool IncludeZeroOnImbalance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(MaxValue = 2147483647.0, CategoryIndex = 0, PropertyIndex = 4)]
		[Category("General")]
		public bool ColorOnlyDominantSide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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
		[DisplayName("Background Inferior Side")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		public Color ColorInferiorSide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		[Category("Color")]
		public Color FixedVolColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
		[Category("Color")]
		public Color FixedBidColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public Color FixedAskColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
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

		[Category("Range")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		public RemoteFinalizerLocator RangeDefining
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RemoteFinalizerLocator)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
		[Category("Range")]
		public RangeSettings Range
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RangeSettings)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ColorSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateConvertibleConsumerTemplate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AttachConnectedTemplateTag()
		{
			return null;
		}
	}

	internal enum RegSharerPolicyKinds
	{
		Volume,
		AskBidSplit,
		Delta,
		DeltaAndTotalVolume
	}

	internal enum LocatorSeriesValuesFormulaType
	{
		Volume,
		AggregateTrades,
		[Display(Name = "Order (MBO)")]
		Order,
		[Display(Name = "Number Orders (MBO)")]
		NumberOrders,
		[Display(Name = "Number Trades")]
		NumberTrades
	}

	internal enum ViewerShellBarItemVisibility
	{
		BarRelative,
		AutoValue,
		ManualValue
	}

	internal enum PrintSystemDesiredAccess
	{
		Box,
		Profile,
		MirrorProfile
	}

	internal enum VerticalPositionValues
	{
		Automatic,
		Manual
	}

	internal enum GeneralElementReg
	{
		Fixed,
		BarBased
	}

	internal enum RunType
	{
		Body,
		Candle
	}

	internal enum RegInstallationFlags
	{
		Left,
		Center
	}

	internal enum LocalDistributorWriterType
	{
		Dynamic,
		Fixed
	}

	internal enum RemoteThreadAllocatorState
	{
		Automatic,
		Normal,
		K
	}

	internal enum EncryptorCausalitySynchronousWork
	{
		None,
		Bar,
		UpAndDown
	}

	internal enum LocalViewerRegOptions
	{
		[Display(Name = "1")]
		One = 1,
		[Display(Name = "2")]
		Two,
		[Display(Name = "3")]
		Three,
		[Display(Name = "4")]
		Four
	}

	internal enum RegEventTagEntryFieldId
	{
		[Display(Name = "1/1")]
		OneOne,
		[Display(Name = "0/1")]
		None,
		[Display(Name = "1/2")]
		OneHalf,
		[Display(Name = "1/3")]
		OneThree,
		[Display(Name = "2/3")]
		TwoThree,
		[Display(Name = "1/4")]
		OneFourth,
		[Display(Name = "2/4")]
		TwoFourth,
		[Display(Name = "3/4")]
		ThreeFourth
	}

	private class VisualHandlerDecider
	{
		public MapResponderLocator.EfficientStructRequester _SimpleWriterDecider;

		public RequesterTagExplorer[] m_CustomizableConfigurationElements;

		public RequesterTagExplorer deciderValueTracer;

		public bool _IsConcreteEncryptorDecider;

		private static VisualHandlerDecider AttachVisualValidatorReg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VisualHandlerDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VisualHandlerDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MonitorDistributor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VisualHandlerDecider AttachActiveFormatterGateway()
		{
			return null;
		}
	}

	private class JoinedAggregatorDecider
	{
		public AllocatorCompilerEvent<VisualHandlerDecider> modularExplorer;

		public int deciderAnnotationTreeDepth;

		public int _IdentifiableInterpreterDeciderLevel;

		public bool _IsTracerBuilderDecider;

		public bool m_IsDeciderTreeTester;

		public long m_AdvancedCalculatorDeciderFlag;

		public long notifierCheckerPnts;

		public long _ConsumerStructDist;

		public int adaptableInspectorDeciderAge;

		public int m_FinderDistributorLevel;

		public int m_DefinitionModelPerc;

		public int m_ExpandableFactoryDeciderNum;

		public RequesterTagExplorer m_BuilderHandlerDecider;

		public RequesterTagExplorer m_DeciderTesterWriter;

		public RequesterTagExplorer deciderHandlerEncryptor;

		public RequesterTagExplorer _GroupedEventDecider;

		public RequesterTagExplorer m_DeciderWriterAggregator;

		public RequesterTagExplorer m_AdjustableListenerDecider;

		public RequesterTagExplorer deciderEncryptorInterpreter;

		public int m_ReceiverRequesterAge;

		public int deciderAggregatorCalculatorPos;

		public long m_InterpreterInspectorDeciderCounter;

		public bool m_IsDynamicTransmitter;

		public double m_InspectorCompiler;

		public double m_TransformerDistributor;

		public bool isTreeValue;

		public int m_RandomCompilerDeciderStep;

		public int _ExtendedCacheDeciders;

		public int m_StaticTokenizerDeciderLength;

		public int _ReadableContainerDeciderVal;

		public int deciderCalculatorFactoryCap;

		public int m_ReadableAggregatorWrappers;

		internal static JoinedAggregatorDecider SimulateFilteredGatewayCompiler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinedAggregatorDecider()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static JoinedAggregatorDecider()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachElement()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JoinedAggregatorDecider ArrangeEmitter()
		{
			return null;
		}
	}

	private class WrapperDriver
	{
		public int wrapperAuditorOffset;

		public long editableNodeCount;

		public long wrapperStrategyErrorCode;

		public long m_ServiceCheckerRank;

		public Common.SetExplorerWrapper m_WrapperFinalizer;

		public Common.SetExplorerWrapper connectedProcessorWrapper;

		public Common.SetExplorerWrapper scopePoolWrapper;

		internal static WrapperDriver ReflectEncryptor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WrapperDriver()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperDriver()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateCentralContainerInspector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WrapperDriver DefineFunction()
		{
			return null;
		}
	}

	private class SingletonStub
	{
		public int[] definitionManagerElements;

		public int[] m_FilterControllerItems;

		public Color[] _SingletonCollectorData;

		public Color[] m_OrderedExplorerSingletonArray;

		public Color[] _AuthorizerSets;

		public bool _IsInterruptibleParserSingleton;

		public int _LoggerConnectionCount;

		public int m_FlexibleParameterSingletonDepth;

		public bool _IsDetailedMapper;

		public bool isCustomizableContainerSingleton;

		public bool isActiveDistributor;

		public EncryptorVisualStatus m_SingletonState;

		public ColorSettings.OperationalPublisherDecider m_SingletonFinder;

		public ColorSettings.RemoteFinalizerLocator singletonConverter;

		public Color _ViewerSingleton;

		internal static SingletonStub SimulateOrderedTransactionError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SingletonStub()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SingletonStub()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAlphabeticErrorMapper()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SingletonStub SimulateSegmentedMapperMatcher()
		{
			return null;
		}
	}

	private enum KeyTipVerticalPlacement
	{
		Bid,
		Ask,
		Delta,
		Volume
	}

	private enum FunctionPoolOptions
	{
		Volume,
		Bid,
		Ask,
		None
	}

	[CompilerGenerated]
	private RegSharerPolicyKinds _MonoResponderReg;

	[CompilerGenerated]
	private PrintSystemDesiredAccess m_RegFinalizerSelector;

	[CompilerGenerated]
	private ViewerShellBarItemVisibility m_RegSelectorToken;

	[CompilerGenerated]
	private double _ScalableArgumentReg;

	[CompilerGenerated]
	private int _RegTokenTokenizerValue;

	[CompilerGenerated]
	private LocatorSeriesValuesFormulaType _IsolatedCollectorReg;

	[CompilerGenerated]
	private int m_SeparatedExecutorRegErrorCode;

	[CompilerGenerated]
	private int m_LogicalConnectionRegId;

	[CompilerGenerated]
	private bool _IsBufferProject;

	[CompilerGenerated]
	private VerticalPositionValues _TransferableStateReg;

	[CompilerGenerated]
	private int m_AttachedWorkerRegScore;

	[CompilerGenerated]
	private int m_CompressorQueueVol;

	[CompilerGenerated]
	private GeneralElementReg m_ParserEnumerator;

	[CompilerGenerated]
	private int _TokenizerGeneratorRegSize;

	[CompilerGenerated]
	private RunType generatorChooserReg;

	[CompilerGenerated]
	private RegInstallationFlags _RegChooserRecommender;

	[CompilerGenerated]
	private bool _IsEfficientBridgeReg;

	[CompilerGenerated]
	private int _CompilerDicInterval;

	[CompilerGenerated]
	private ColorSettings _RecommenderAllocatorReg;

	[CompilerGenerated]
	private float m_RegAllocatorProc;

	[CompilerGenerated]
	private int _IterableValueRegInterval;

	[CompilerGenerated]
	private LocalDistributorWriterType sortedSharerReg;

	[CompilerGenerated]
	private float regProcModel;

	[CompilerGenerated]
	private float m_LogicalProxy;

	[CompilerGenerated]
	private float regModelProgram;

	[CompilerGenerated]
	private RemoteThreadAllocatorState _RegProgramTree;

	[CompilerGenerated]
	private ColorSettings _TreeProxyReg;

	[CompilerGenerated]
	private bool isPortableCalculatorReg;

	[CompilerGenerated]
	private float processorRole;

	[CompilerGenerated]
	private bool m_IsJoinedArgument;

	[CompilerGenerated]
	private bool _IsIntegratedPolicyReg;

	[CompilerGenerated]
	private Color _ReadableEditor;

	[CompilerGenerated]
	private int _RegProxyFactoryVol;

	[CompilerGenerated]
	private bool isGenericWriterReg;

	[CompilerGenerated]
	private int remoteSystemLength;

	[CompilerGenerated]
	private Color accessibleSystemReg;

	[CompilerGenerated]
	private Color _OperationalStrategyReg;

	[CompilerGenerated]
	private int m_RegFactoryNodeCap;

	[CompilerGenerated]
	private bool _IsStaticRequester;

	[CompilerGenerated]
	private int m_ScheduledEngineInterval;

	[CompilerGenerated]
	private bool isCommonTransactionReg;

	[CompilerGenerated]
	private Color basicStubReg;

	[CompilerGenerated]
	private bool m_IsTaskTransmitter;

	[CompilerGenerated]
	private Color m_AlphabeticTracer;

	[CompilerGenerated]
	private int queuePublisherLimit;

	[CompilerGenerated]
	private bool m_IsRegNodeInspector;

	[CompilerGenerated]
	private ResponsiveStructLocator m_FinderValueList;

	[CompilerGenerated]
	private bool isRegInspectorConsumer;

	[CompilerGenerated]
	private string consumerLocatorRegContent;

	[CompilerGenerated]
	private int _DicAdapterValue;

	[CompilerGenerated]
	private bool m_IsContextTask;

	[CompilerGenerated]
	private int m_TransformerSenderFreq;

	[CompilerGenerated]
	private bool isRegLocatorExtractor;

	[CompilerGenerated]
	private int m_StaticAnnotationRegCnt;

	[CompilerGenerated]
	private Color m_AutomatedRecordReg;

	[CompilerGenerated]
	private EncryptorCausalitySynchronousWork _ExtractorDeciderReg;

	[CompilerGenerated]
	private int interpreterEngineFreq;

	[CompilerGenerated]
	private Color _RegDeciderWrapper;

	[CompilerGenerated]
	private float tokenSummarizer;

	[CompilerGenerated]
	private double roleManager;

	[CompilerGenerated]
	private double responsiveTask;

	[CompilerGenerated]
	private bool m_IsStatelessSolverReg;

	[CompilerGenerated]
	private int m_RegWrapperIteratorFreq;

	[CompilerGenerated]
	private bool _IsSimpleAuditorReg;

	[CompilerGenerated]
	private int _PublisherCalcLevel;

	[CompilerGenerated]
	private Color dynamicVisitorReg;

	[CompilerGenerated]
	private int m_VisibleListRegDepth;

	[CompilerGenerated]
	private bool isAdapterLogger;

	[CompilerGenerated]
	private int orderRecommenderLimit;

	[CompilerGenerated]
	private int virtualFinalizerRegVal;

	[CompilerGenerated]
	private Color m_TagStream;

	[CompilerGenerated]
	private LocalViewerRegOptions m_ManagerContext;

	[CompilerGenerated]
	private LocalViewerRegOptions m_RegIteratorEngine;

	[CompilerGenerated]
	private LocalViewerRegOptions regEngineMatcher;

	[CompilerGenerated]
	private RegEventTagEntryFieldId m_ConvertibleSelectorReg;

	[CompilerGenerated]
	private RegEventTagEntryFieldId _AlphabeticStack;

	private double _InterruptibleTokenReg;

	private double _RegMatcherSchema;

	private double m_SchemaResolverReg;

	private double _CustomizableTokenizerReg;

	private int m_AccessibleSenderCnt;

	private int internalGeneratorRegPerc;

	private int _JoinedChooserRegValue;

	private bool _IsConnectedRecommenderReg;

	private bool m_IsRegResolverSynchronizer;

	private bool _IsModularAllocatorReg;

	private int errorFinalizerId;

	private int randomProcRegScore;

	private int _LogicalWatcherPos;

	private int _SegmentedModelRegPosition;

	private DateTime _RegSynchronizerDecryptor;

	private List<JoinedAggregatorDecider> regDecryptorDefinitions;

	private bool isDefinitionInterpreterReg;

	private bool isRegInterpreterProvider;

	private JoinedAggregatorDecider literalProgramReg;

	private List<WrapperDriver> _OrderedExplorers;

	private List<WrapperDriver> m_ResponsiveTreeRegs;

	private long[] m_MixedProxyRegs;

	private long[] visualFactoryRegItems;

	private bool m_IsControllableNodeReg;

	private int m_RegProviderDispatcherRate;

	private double _CalcCommand;

	private Color _RegDispatcherTransmitter;

	private SingletonStub attachedExtractor;

	private SingletonStub detailedSet;

	private int m_RegTransmitterMemberScore;

	private object m_ActiveInspectorRegObj;

	private bool m_IsAdjustableConsumerReg;

	private double _LoggerModule;

	private bool m_IsRegMemberMonitor;

	private bool _IsRegMonitorObject;

	private bool m_IsObjectClientReg;

	public bool isSymbolicLocatorReg;

	public TimeSpan m_RegClientAttribute;

	public TimeSpan m_ParameterProgram;

	private List<MapNotifier> m_RegAttributeSets;

	private List<MapNotifier> setWatcherRegs;

	private List<MapNotifier> regWatcherErrors;

	private Color m_RegErrorStream;

	private bool m_IsEditableExtractorReg;

	private bool m_IsRegStreamChain;

	private long _AdjustableUserScore;

	private long regChainVerifierStep;

	private long regVerifierServerLevel;

	private float m_ExternalDeciderReg;

	private bool isRegServerSender;

	[CompilerGenerated]
	private int _PoolMapperFreq;

	private static MapperProcessor GenerateCentralProcessorSender;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, SubCategory = "Typology")]
	[DisplayName("Type")]
	[Category("General")]
	public RegSharerPolicyKinds FootType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegSharerPolicyKinds)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, SubCategory = "Typology")]
	public PrintSystemDesiredAccess ShowStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PrintSystemDesiredAccess)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, SubCategory = "Profile Proproption")]
	[DisplayName("Proportion Type")]
	public ViewerShellBarItemVisibility FootProportion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerShellBarItemVisibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, SubCategory = "Profile Proproption", DecimalPosToShow = 1, IncrementValue = 0.1)]
	[DisplayName("Proportion Stv. Dev (Auto)")]
	public double FootProportionAutoDev
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, MinValue = 1.0, MaxValue = 65535.0, SubCategory = "Profile Proproption")]
	[Category("General")]
	[DisplayName("Proportion Value (Manual)")]
	public int FootProportionManualValue
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, SubCategory = "Data Settings")]
	public LocatorSeriesValuesFormulaType InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorSeriesValuesFormulaType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, SubCategory = "Data Settings", MinValue = 0.0, MaxValue = 2147483647.0)]
	[Category("General")]
	public int FilterMin
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7, SubCategory = "Data Settings", MinValue = 0.0, MaxValue = 2147483647.0)]
	[Category("General")]
	public int FilterMax
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8, SubCategory = "Data Settings")]
	[Category("General")]
	public bool UseMboForTradesCounter
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, SubCategory = "Tick Grouping")]
	public VerticalPositionValues AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VerticalPositionValues)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, SubCategory = "Tick Grouping")]
	public int AutoGroupFactory
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, SubCategory = "Tick Grouping", MaxValue = 600.0)]
	[Category("General")]
	public int ManualTicks
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, SubCategory = "Tick Grouping")]
	[Category("General")]
	public GeneralElementReg GroupMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneralElementReg)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, SubCategory = "Bar Style")]
	[Category("Plot Settings")]
	public int BarMarkerWidth
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, SubCategory = "Bar Style")]
	[Category("Plot Settings")]
	public RunType OutsideBarStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RunType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, SubCategory = "Bar Style")]
	public RegInstallationFlags MarkerAlignment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegInstallationFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, SubCategory = "Bar Style")]
	[Category("Plot Settings")]
	public bool ShowOutsideBorder
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, SubCategory = "Bar Style", MaxValue = 500.0, IncrementValue = 20.0)]
	[Category("Plot Settings")]
	public int MaxBarsToShow
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
	[DisplayName("Coloration")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5, SubCategory = "Background")]
	public ColorSettings Background
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ColorSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 6, SubCategory = "Background", MaxValue = 3.0, DecimalPosToShow = 2, IncrementValue = 0.25)]
	[Category("Plot Settings")]
	public float BorderWidth
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 7, SubCategory = "Background")]
	public int BackOpacity
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 8, SubCategory = "Text")]
	public LocalDistributorWriterType FontSizeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocalDistributorWriterType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Text Size (dynamic) - min.")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 9, SubCategory = "Text", MaxValue = 50.0, DecimalPosToShow = 1, IncrementValue = 1.0)]
	[Category("Plot Settings")]
	public float MinFontSize
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 10, SubCategory = "Text", MaxValue = 50.0, DecimalPosToShow = 1, IncrementValue = 1.0)]
	[Category("Plot Settings")]
	[DisplayName("Text Size (dynamic) - max.")]
	public float MaxFontSize
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
	[DisplayName("Text Size (fixed)")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 11, SubCategory = "Text", MaxValue = 50.0, DecimalPosToShow = 1, IncrementValue = 1.0)]
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 12, SubCategory = "Text")]
	public RemoteThreadAllocatorState TextFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RemoteThreadAllocatorState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Coloration")]
	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 13, SubCategory = "Text")]
	public ColorSettings Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ColorSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Plot Settings")]
	[DisplayName("Dynamic text size")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 14, SubCategory = "Text")]
	public bool EnableDynamicTextSize
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 15, SubCategory = "Text", MaxValue = 50.0, DecimalPosToShow = 2, IncrementValue = 0.2)]
	public float IncreaseDynamicTextSize
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
	[DisplayName("Show Text for Zero Values")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 16, SubCategory = "Text")]
	public bool ShowZeroOnText
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

	[Category("POC")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0, SubCategory = "Volume")]
	public bool EnablePoc
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

	[Category("POC")]
	[DisplayName("Border Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, SubCategory = "Volume")]
	public Color PocBorderColor
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

	[Category("POC")]
	[DisplayName("Border Width")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2, SubCategory = "Volume")]
	public int PocBorderWidth
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

	[Category("POC")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0, SubCategory = "Delta")]
	public bool EnableDeltaPoc
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

	[DisplayName("Minumum Delta")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, SubCategory = "Delta", MaxValue = 2147483647.0)]
	[Category("POC")]
	public int DeltaPocMinimumDelta
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2, SubCategory = "Delta")]
	[DisplayName("Ask Border Color")]
	[Category("POC")]
	public Color DeltaPocAskBorderColor
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

	[Category("POC")]
	[DisplayName("Bid Border Color")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3, SubCategory = "Delta")]
	public Color DeltaPocBidBorderColor
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

	[Category("POC")]
	[DisplayName("Border Width")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4, SubCategory = "Delta")]
	public int DeltaPocBorderWidth
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Value Area")]
	public bool VAEnable
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, MaxValue = 100.0)]
	[Category("Value Area")]
	[DisplayName("% Value Area")]
	public int VAPerc
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

	[Category("Value Area")]
	[DisplayName("Highlight")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	public bool VAHighlight
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

	[Category("Value Area")]
	[DisplayName("Outside Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	public Color VABackColor
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
	[DisplayName("Show Line")]
	[Category("Value Area")]
	public bool VAShowLine
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

	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 5)]
	[Category("Value Area")]
	public Color VALineColor
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

	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 6, MaxValue = 10.0)]
	[DisplayName("Line Width")]
	[Category("Value Area")]
	public int VALineWidth
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Enable Sound")]
	[Category("Alert Settings")]
	public bool EnableAlert
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1, IsAlert = true)]
	[DisplayName("Alert Sound")]
	[Category("Alert Settings")]
	public ResponsiveStructLocator AlertSound
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Enable Message")]
	[Category("Alert Settings")]
	public bool EnableAlertMsg
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 3, MaxValue = 2147483647.0)]
	[Category("Alert Settings")]
	public string AlertMessage
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

	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 4, MaxValue = 2147483647.0)]
	[Category("Alert Settings")]
	public int AlertMinimumVolume
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Enable")]
	[Category("Single Print")]
	public bool EnableSinglePrint
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

	[Category("Single Print")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int SinglePrintMinValue
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

	[DisplayName("Enable Only on High or Low")]
	[Category("Single Print")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 2)]
	public bool SinglePrintOnlyHL
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 3, MaxValue = 5.0, MinValue = 1.0)]
	[Category("Single Print")]
	[DisplayName("Border Width")]
	public int SinglePrintBorderWidth
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 4)]
	[DisplayName("Border Color")]
	[Category("Single Print")]
	public Color SinglePrintBorderColor
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

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[DisplayName("Enable")]
	[Category("Ratio")]
	public EncryptorCausalitySynchronousWork RatioMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorCausalitySynchronousWork)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 1, MaxValue = 150.0, MinValue = 1.0)]
	[Category("Ratio")]
	[DisplayName("Tick Offset")]
	public int RatioTickOffset
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

	[Category("Ratio")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 2)]
	[DisplayName("Text Color")]
	public Color RatioTextColor
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

	[DisplayName("Text size")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 3, MaxValue = 50.0, DecimalPosToShow = 2, IncrementValue = 0.2)]
	[Category("Ratio")]
	public float RatioTextSize
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

	[Category("Ratio")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 4, DecimalPosToShow = 2, MaxValue = 2147483647.0)]
	public double MinRatio
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

	[Category("Ratio")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 5, DecimalPosToShow = 2, MaxValue = 2147483647.0)]
	public double MaxRatio
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

	[Category("Vol Cluster")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 0, MaxValue = 2147483647.0)]
	public bool EnableCluster
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

	[Category("Vol Cluster")]
	[DisplayName("Min. Volume")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 1, MaxValue = 2147483647.0, MinValue = 1.0)]
	public int ClusterVolume
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

	[Category("Vol Cluster")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[DisplayName("Dynamic increase based on automatic tick grouping")]
	public bool ClusterIncreaseBasedTick
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

	[Category("Vol Cluster")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 3, MaxValue = 7.0, MinValue = 0.0)]
	public int ClusterLineWidth
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

	[Category("Vol Cluster")]
	[DisplayName("Back Color")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 4)]
	public Color ClusterColor
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

	[Category("Vol Cluster")]
	[DisplayName("Opacity")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 5, MaxValue = 100.0, MinValue = 1.0)]
	public int ClusterOpacity
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

	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 0)]
	[Category("Pullback")]
	public bool EnablePullback
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

	[Category("Pullback")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int PullbackMinSourceBarTicks
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

	[Category("Pullback")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int PullbackMinPullbackTicks
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

	[Category("Pullback")]
	[DisplayName("Bar Color")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 3)]
	public Color PullbackBarColor
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

	[Category("Sizing (multi column)")]
	[DisplayName("Number of columns")]
	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 0)]
	public LocalViewerRegOptions SizeNumberColumns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocalViewerRegOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Sizing (multi column)")]
	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 1)]
	[DisplayName("Position")]
	public LocalViewerRegOptions SizePosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocalViewerRegOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 2)]
	[DisplayName("Size")]
	[Category("Sizing (multi column)")]
	public LocalViewerRegOptions SizeSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocalViewerRegOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 0, IsVisible = false)]
	[Category("Advanced")]
	public RegEventTagEntryFieldId Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegEventTagEntryFieldId)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Advanced")]
	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 1, IsVisible = false)]
	public RegEventTagEntryFieldId Offset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegEventTagEntryFieldId)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public int Version
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
	static MapperProcessor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555480));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(-117581714 ^ -1491412768 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5741FF6E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE73C9E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF53E8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32 == 0)
		{
			num = 3;
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
	public MapperProcessor(ScopeEncryptor.HiddenModelDecider setup, MapResponderLocator.TransformableUserEncryptor counter, int procPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool removeinit, bool requiresb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenHiddenSelector()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EvaluateFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PostFormatter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreLocalResponder(ColorSettings ident, SingletonStub attr, bool setfilter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool taskneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CustomizeCompiler(JoinedAggregatorDecider task, MapResponderLocator.GeneratorResponder pol, int min_serv, List<RequesterTagExplorer> t2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private KeyTipVerticalPlacement SaveMixedService(int mininit)
	{
		return (KeyTipVerticalPlacement)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ManageSorter(int length_def, int insert_SECONDAt, int comp_count, int reg2_Z, bool rejectdef3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int MeasureContainer(int info_Position, JoinedAggregatorDecider result, int position_dir, bool evaluatecol2)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int SplitInspector(int var1counter, JoinedAggregatorDecider cfg)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator param, bool isattr, MapResponderLocator.TokenParameterViewer state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool OpenAccessibleList(JoinedAggregatorDecider spec, SingletonHandlerConnection.ObjectAuthenticatorLocator counter, bool isc, MapResponderLocator.TokenParameterViewer cfg2, int v3_counter, bool readcounter4)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SavePassiveLocator(MapResponderLocator.GeneratorResponder reference, int position_caller, bool loadcontrol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayMapper(RequesterTagExplorer spec, int ID_pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SaveRandomProvider(MapResponderLocator.GeneratorResponder v, int length_caller, bool isfield, int v2end)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreDynamicParser(RequesterTagExplorer value, int pol_end)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer OpenReadableProgram(int flagsfirst, bool overridevisitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SaveDividedPublisher(int size_first, double visitor, Color serv, int position_instance2, bool applyvisitor3 = true, bool isdef4 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer StoreIsolatedParameter(int insertINFOAt, JoinedAggregatorDecider second, bool addthird, double ident2, float pred3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveSeparatedProxy(MapResponderLocator.GeneratorResponder var1, int no__b, bool writetag, bool setx2, bool isident3, bool allowconfig4 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SaveScalableSet(int numres)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeSpec(int row_i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenScopeModule(JoinedAggregatorDecider asset, VisualHandlerDecider pol, KeyTipVerticalPlacement helper, int mean_key2, long token3_X)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FlushProfiler(JoinedAggregatorDecider v, VisualHandlerDecider cust, KeyTipVerticalPlacement comp, EncryptorVisualStatus spec2, int row_item3, bool removeconnection4, bool isasset5, out FunctionPoolOptions cfg6, out long second7)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int SaveGeneralValidator(int[] reference, long custstart)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color OpenResponsiveReg(JoinedAggregatorDecider first, VisualHandlerDecider pred, KeyTipVerticalPlacement proc, int vis2, SingletonStub caller3, out int token4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveSetFormatter(JoinedAggregatorDecider setup, SingletonStub pol, bool comparec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreSortedGateway(JoinedAggregatorDecider var1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuildContext(MapResponderLocator.GeneratorResponder task, int caller_High, bool excludeserv, bool getitem2 = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PresentBuffer(int removeIAt, JoinedAggregatorDecider cfg, bool rejecttemp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool issetup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool requiresconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isvar1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetMonitor(bool caninfo, bool iscol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveState(float last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachAdvancedSenderVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MapperProcessor AttachOrderedVisitorDecryptor()
	{
		return null;
	}
}
