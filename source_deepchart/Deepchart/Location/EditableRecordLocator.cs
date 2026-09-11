using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace Deepchart.Location;

internal class EditableRecordLocator : LocatorRequest
{
	internal enum RegJsonReaderOptions
	{
		None,
		TillInteraction,
		TillEndWindow
	}

	internal enum FactoryListenerDeciderOptions
	{
		[Display(Name = "Composite")]
		AllBars,
		[Display(Name = "Multiple")]
		MultipleProfile,
		[Display(Name = "Visible")]
		VisibleBars,
		[Display(Name = "Custom")]
		CustomTime
	}

	internal enum RandomGatewayAllocator
	{
		Minute,
		Days,
		Weeks,
		Months,
		Volume
	}

	internal enum SimpleSorterAllocatorOptions
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggregateTrades,
		NumberOfTrades
	}

	[Serializable]
	internal struct PeakValleySettings
	{
		internal static object ReplaceBridge;

		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Enable")]
		public bool PeakEnable
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

		[Category("Peak")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
		[DisplayName("Minimum Volume")]
		public int PeakMinVol
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[DisplayName("Extend Line")]
		[Category("Peak")]
		public RegJsonReaderOptions PeakExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RegJsonReaderOptions)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 10.0)]
		[Category("Peak")]
		[DisplayName("Line Width")]
		public int PeakLineWidth
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
		[DisplayName("Line Color")]
		[Category("Peak")]
		public Color PeakLineColor
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
		[DisplayName("Enable")]
		[Category("Valley")]
		public bool ValleyEnable
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

		[Category("Valley")]
		[DisplayName("Maximum Volume")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 2147483647.0)]
		public int ValleyMaxVol
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

		[Category("Valley")]
		[DisplayName("Extend Line")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public RegJsonReaderOptions ValleyExtendMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (RegJsonReaderOptions)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[DisplayName("Line Color")]
		[Category("Valley")]
		public Color ValleyLineColor
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

		[Category("Valley")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4, MaxValue = 10.0)]
		[DisplayName("Line Width")]
		public int ValleyLineWidth
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetPeakMin(int value)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PeakValleySettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SetDispatcher()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateEfficientSpecSystem()
		{
			return null;
		}
	}

	[Serializable]
	internal struct VWapDevSettings
	{
		private static object AttachTransferableSystemProfiler;

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("First Envelope")]
		public bool W1_Enabled
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[DisplayName("Std. Dev. Param")]
		[Category("First Envelope")]
		public double W1_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
		[Category("First Envelope")]
		[DisplayName("Upper Color")]
		public Color W1_UpperColor
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

		[Category("First Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
		public Color W1_LowerColor
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

		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
		[DisplayName("Line Width")]
		[Category("First Envelope")]
		public int W1_LineWidth
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

		[Category("First Envelope")]
		[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
		[DisplayName("Envelope style")]
		public DashStyle W1_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Second Envelope")]
		[DisplayName("Enable")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
		public bool W2_Enabled
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

		[Category("Second Envelope")]
		[DisplayName("Std. Dev. Param")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		public double W2_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Second Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
		public Color W2_UpperColor
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

		[Category("Second Envelope")]
		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
		[DisplayName("Lower Color")]
		public Color W2_LowerColor
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
		[DisplayName("Line Width")]
		[Category("Second Envelope")]
		public int W2_LineWidth
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

		[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
		[DisplayName("Envelope style")]
		[Category("Second Envelope")]
		public DashStyle W2_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Third Envelope")]
		public bool W3_Enabled
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[DisplayName("Std. Dev. Param")]
		[Category("Third Envelope")]
		public double W3_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
		[DisplayName("Upper Color")]
		[Category("Third Envelope")]
		public Color W3_UpperColor
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

		[DisplayName("Lower Color")]
		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
		public Color W3_LowerColor
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

		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
		[DisplayName("Line Width")]
		[Category("Third Envelope")]
		public int W3_LineWidth
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

		[DisplayName("Envelope style")]
		[Category("Third Envelope")]
		[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 5)]
		public DashStyle W3_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
		[DisplayName("Enable")]
		[Category("Fourth Envelope")]
		public bool W4_Enabled
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

		[DisplayName("Std. Dev. Param")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[Category("Fourth Envelope")]
		public double W4_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[Category("Fourth Envelope")]
		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
		public Color W4_UpperColor
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

		[Category("Fourth Envelope")]
		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 3)]
		public Color W4_LowerColor
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

		[Category("Fourth Envelope")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 4)]
		public int W4_LineWidth
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

		[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 5)]
		[DisplayName("Envelope style")]
		[Category("Fourth Envelope")]
		public DashStyle W4_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Enable")]
		[Category("Fifth Envelope")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
		public bool W5_Enabled
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

		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.5, MinValue = 0.25, MaxValue = 6.0)]
		[DisplayName("Std. Dev. Param")]
		[Category("Fifth Envelope")]
		public double W5_StdDevParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[DisplayName("Upper Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
		[Category("Fifth Envelope")]
		public Color W5_UpperColor
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

		[DisplayName("Lower Color")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 3)]
		[Category("Fifth Envelope")]
		public Color W5_LowerColor
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

		[Category("Fifth Envelope")]
		[DisplayName("Line Width")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 4)]
		public int W5_LineWidth
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

		[Category("Fifth Envelope")]
		[DisplayName("Envelope style")]
		[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 5)]
		public DashStyle W5_LineSyle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				return (DashStyle)(object)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static VWapDevSettings()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateLiteralProfilerComparator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateGlobalComparatorStrategy()
		{
			return null;
		}
	}

	internal enum AllocatorQualityMode
	{
		Automatic,
		Manual
	}

	internal enum AttachedHandlerDriverEnum
	{
		Show,
		Developing,
		ExtendShifted
	}

	internal enum VirtualControllerDecider
	{
		None,
		Filter,
		Splitted
	}

	private class MonoTemplateWriter
	{
		public MapResponderLocator.EfficientStructRequester m_InterpreterWriter;

		public bool m_IsProfileProfiler;

		public bool _IsLocalFinder;

		public bool isRoleConnection;

		public bool _IsPoolDic;

		public bool _IsWriterFinalizer;

		public RequesterTagExplorer connectedWorkerWriter;

		public RequesterTagExplorer _WriterContainer;

		public bool _IsReadableCacheWriter;

		internal static MonoTemplateWriter GenerateStaticTemplateTag;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonoTemplateWriter()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonoTemplateWriter()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateCustomizableTagChecker()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonoTemplateWriter SimulateAutomatedCheckerTokenizer()
		{
			return null;
		}
	}

	private class ExecutorGenerator
	{
		public AllocatorCompilerEvent<MonoTemplateWriter> generatorDefinition;

		public bool isPortableTracerGenerator;

		public int m_TesterModelVol;

		public int m_GeneratorCalculatorIdx;

		public int m_SimpleSystemGeneratorCnt;

		public long m_GeneratorRequesterCnt;

		public long m_SymbolicAdapterGeneratorIndex;

		public int m_ConfigReceiverNum;

		public long m_GeneratorPredicateErrorCode;

		public long m_TransformerTesterValue;

		public long generatorManagerDepth;

		public int m_ExpandableFormatterGeneratorPnts;

		public int _InterruptibleEventStep;

		public int _StaticEvaluatorGeneratorCap;

		public int separatedExplorerGeneratorLength;

		public int _GeneratorRoleTotal;

		public long _CommonAuthorizerGeneratorFreq;

		public long generatorContextPnts;

		public int m_RoleNotifierCap;

		public int authenticatorRegLimit;

		public int generatorParserSize;

		public int concreteHandlerPnts;

		public int _GeneratorVisitorPnts;

		public int _GeneratorInitializerPerc;

		public int _VisualMemberGeneratorScore;

		public bool _IsArgumentCollection;

		public double dynamicMapperGenerator;

		public double _GeneratorService;

		public int visibleProfilerGeneratorDist;

		public int generatorElementTotal;

		public long m_FactoryGeneratorDist;

		public long _GeneratorRequests;

		public long stateTaskCnt;

		public long m_TreeGeneratorNum;

		public double _MapClient;

		public double _AdvancedProfiler;

		public bool m_IsScopePublisherGenerator;

		public RequesterTagExplorer[] m_GlobalWriterGeneratorData;

		public List<RequesterTagExplorer> _GeneratorRecommenderList;

		public RequesterTagExplorer _AdvancedSingletonGenerator;

		public RequesterTagExplorer _ProxyGenerator;

		public RequesterTagExplorer visualEngineViewer;

		public RequesterTagExplorer iteratorAuthorizer;

		public RequesterTagExplorer concreteStack;

		public RequesterTagExplorer generatorReporter;

		public RequesterTagExplorer alphabeticAggregatorGenerator;

		public RequesterTagExplorer m_HiddenSchemaGenerator;

		public RequesterTagExplorer m_RandomProcessorGenerator;

		public double _CentralConfigurationGenerator;

		public int generatorServerRank;

		public double _FormatterTag;

		public double _GeneratorValidator;

		private static ExecutorGenerator GenerateJoinedTokenizerEvaluator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExecutorGenerator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExecutorGenerator()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IncludeChain()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExecutorGenerator SimulateConnectedPoolTracer()
		{
			return null;
		}
	}

	private class IterableMatcherSingleton
	{
		public double m_SingletonMap;

		public EncryptorCacheBuffer.Series_Prop _SingletonSolver;

		public EncryptorCacheBuffer.Series_Prop m_FilteredCalc;

		private static IterableMatcherSingleton GenerateExpandableTracerPredictor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IterableMatcherSingleton()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IterableMatcherSingleton()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachAutomatablePredictorTransformer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IterableMatcherSingleton SimulateCombinedTransformerAllocator()
		{
			return null;
		}
	}

	private enum LocatorUserInteractionType
	{
		Volume,
		Bid,
		Ask
	}

	[CompilerGenerated]
	private FactoryListenerDeciderOptions scheduledEventLocator;

	[CompilerGenerated]
	private RandomGatewayAllocator enumeratorDecorator;

	[CompilerGenerated]
	private int m_LocatorExtractorNotifierPerc;

	[CompilerGenerated]
	private DateTime m_LocatorNotifierLocator;

	[CompilerGenerated]
	private SimpleSorterAllocatorOptions locatorLocatorQueue;

	[CompilerGenerated]
	private int tokenizerFieldOffset;

	[CompilerGenerated]
	private int locatorQueueMonitorCount;

	[CompilerGenerated]
	private AllocatorQualityMode m_LocatorMonitorWriter;

	[CompilerGenerated]
	private int _LocatorWriterCompressorValue;

	[CompilerGenerated]
	private int _LocatorCompressorProviderFlag;

	[CompilerGenerated]
	private int m_ProviderGeneratorLocatorErrorCode;

	[CompilerGenerated]
	private bool m_IsListSorter;

	[CompilerGenerated]
	private AttachedHandlerDriverEnum locatorGeneratorContainer;

	[CompilerGenerated]
	private RegJsonReaderOptions automatableFormatterLocator;

	[CompilerGenerated]
	private Color _ResponsiveVisitor;

	[CompilerGenerated]
	private int _DetailedSenderScore;

	[CompilerGenerated]
	private TimeSpan wrapperSynchronizer;

	[CompilerGenerated]
	private int flexibleGatewayLocatorPerc;

	[CompilerGenerated]
	private int m_LocatorContainerListenerFlag;

	[CompilerGenerated]
	private bool m_IsLocatorListenerTree;

	[CompilerGenerated]
	private int _LocatorTreeTemplateCount;

	[CompilerGenerated]
	private bool _IsConnectedStructLocator;

	[CompilerGenerated]
	private bool _IsReadableMember;

	[CompilerGenerated]
	private RegJsonReaderOptions m_AdvancedEvent;

	[CompilerGenerated]
	private Color _LocatorTemplateCalc;

	[CompilerGenerated]
	private int remoteElementLocatorAge;

	[CompilerGenerated]
	private int scheduledTrackerCount;

	[CompilerGenerated]
	private bool _IsJoinedEngineLocator;

	[CompilerGenerated]
	private PeakValleySettings _ActiveWrapperLocator;

	[CompilerGenerated]
	private bool _IsGenericFinalizerLocator;

	[CompilerGenerated]
	private RegJsonReaderOptions locatorCalcEmitter;

	[CompilerGenerated]
	private Color locatorEmitterAttribute;

	[CompilerGenerated]
	private int m_AttributeAggregatorLocatorIdx;

	[CompilerGenerated]
	private bool _IsLocatorAggregatorBuffer;

	[CompilerGenerated]
	private bool _IsExternalAttribute;

	[CompilerGenerated]
	private VWapDevSettings _DetachedContextLocator;

	[CompilerGenerated]
	private bool m_IsGroupedChainLocator;

	[CompilerGenerated]
	private bool isLocatorBufferProject;

	[CompilerGenerated]
	private bool isLocatorProjectDecorator;

	[CompilerGenerated]
	private Color m_ExpandableInspectorLocator;

	[CompilerGenerated]
	private Color identifiableInterpreterLocator;

	[CompilerGenerated]
	private Color generalDistributorLocator;

	[CompilerGenerated]
	private float m_DecoratorMatcherLocator;

	[CompilerGenerated]
	private VirtualControllerDecider _LiteralViewerLocator;

	[CompilerGenerated]
	private TimeSpan m_ValueCreator;

	[CompilerGenerated]
	private TimeSpan m_ExternalSenderLocator;

	private bool _IsTransferableProgramLocator;

	private bool _IsRunnerAuditor;

	private string m_LocatorMatcherAdapterTag;

	private List<ExecutorGenerator> m_SymbolicConsumerLocatorList;

	private bool isIterableSharerLocator;

	private int m_DetachedSubscriberIndex;

	private int _SeparatedBridgeLocatorInterval;

	private int m_AttachedTokenizerLocatorIndex;

	private int m_InterruptibleRequesterLocatorRank;

	private bool m_IsAdjustableCalculatorLocator;

	private double scopeFieldLocator;

	private int expandableStackInterval;

	private bool _IsLocatorAdapterTask;

	private DateTime locatorTaskChecker;

	private bool m_IsLocatorCheckerAuthorizer;

	private List<MapResponderLocator.GeneratorResponder> m_LocatorAuthorizerTracerList;

	private int scalableInspectorCounter;

	private int m_CalculatorSynchronizerErrorCode;

	private long detailedProcessorLocatorOffset;

	private DateTime locatorTracerParser;

	private int m_FieldEncryptorCounter;

	private int _ConverterProfileAge;

	private int m_LocatorParserCollectionScore;

	private int _CollectionRunnerLocatorSize;

	private bool m_IsOperationalSynchronizerLocator;

	private bool isRequestParser;

	private long _VisitorClientVal;

	private long customSynchronizerTotal;

	private EncryptorCacheBuffer.Series_Prop _OrderedEncryptorLocator;

	private EncryptorCacheBuffer.Series_Prop m_RunnerComparatorLocator;

	private EncryptorCacheBuffer.Series_Prop m_LocatorComparatorWorker;

	private List<IterableMatcherSingleton> _MixedTagLocators;

	private IMonoCalcViewer _LocatorWorkerModule;

	private MapResponderLocator.PanningMode _PortableObserverLocator;

	private static EditableRecordLocator SimulateTransformableExecutorViewer;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public FactoryListenerDeciderOptions VbpPeriod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FactoryListenerDeciderOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public RandomGatewayAllocator LengthType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RandomGatewayAllocator)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MinValue = 1.0, MaxValue = 1800000.0)]
	public int LengthValue
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
	[DisplayName("Start Date/Time")]
	[Category("Custom Period")]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Data Settings")]
	public SimpleSorterAllocatorOptions InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (SimpleSorterAllocatorOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MinValue = 0.0, MaxValue = 2147483647.0)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MinValue = 0.0, MaxValue = 2147483647.0)]
	[Category("Data Settings")]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[Category("Auto Grouping")]
	public AllocatorQualityMode AutoGrouping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorQualityMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Auto Grouping")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MinValue = 1.0)]
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

	[Category("Auto Grouping")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2, MinValue = 1.0, MaxValue = 600.0)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0, MinValue = 1.0, MaxValue = 1000.0)]
	public int NumberOfProfile
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

	[Category("Point of Control")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	public bool PocEnable
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

	[Category("Point of Control")]
	[DisplayName("Show Line")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1)]
	public AttachedHandlerDriverEnum PocLineMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AttachedHandlerDriverEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Extend Line")]
	[Category("Point of Control")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	public RegJsonReaderOptions PocExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegJsonReaderOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	[DisplayName("Line Color")]
	[Category("Point of Control")]
	public Color PocLineColor
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

	[Category("Point of Control")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 4)]
	public int PocLineWidth
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 5)]
	[Category("Point of Control")]
	[DisplayName("Dev. Poc Start Time")]
	public TimeSpan PocDevStartTime
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 6)]
	[DisplayName("Shifted Poc Tick Grouping")]
	[Category("Point of Control")]
	public int ShiftPocTick
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

	[Category("Point of Control")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 7, MaxValue = 100.0)]
	[DisplayName("Opacity Poc Grouping")]
	public int PocGroupOpacity
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
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
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

	[Category("Value Area")]
	[DisplayName("% Value Area")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, MaxValue = 100.0)]
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

	[DisplayName("Show Line")]
	[Category("Value Area")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
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

	[Category("Value Area")]
	[DisplayName("Developing")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 3)]
	public bool VADeveloping
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
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 4)]
	public RegJsonReaderOptions VAExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegJsonReaderOptions)(object)null;
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

	[Category("Value Area")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 6, MaxValue = 10.0)]
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

	[Category("Peak And Valley")]
	[DisplayName("Sensitivity")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0, MaxValue = 1000.0)]
	public int PVSensitivity
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

	[Category("Peak And Valley")]
	[DisplayName("Exclude High/Low")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1, MaxValue = 1000.0)]
	public bool PVExcludeHL
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

	[DisplayName("Appearance")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	[Category("Peak And Valley")]
	public PeakValleySettings PVSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (PeakValleySettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Enable")]
	[Category("VWAP")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0)]
	public bool VwapEnable
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

	[Category("VWAP")]
	[DisplayName("Extend Line")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1)]
	public RegJsonReaderOptions VwapExtendMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegJsonReaderOptions)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("VWAP")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 2)]
	[DisplayName("Line Color")]
	public Color VwapLineColor
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

	[Category("VWAP")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 3)]
	public int VwapLineWidth
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

	[Category("VWAP")]
	[DisplayName("Developing VWAP")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 4)]
	public bool ShowDevVwap
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 5)]
	[DisplayName("Envelope Enabled")]
	[Category("VWAP")]
	public bool VWapEnvEnabled
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

	[Category("VWAP")]
	[DisplayName("Envelope Settings")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 6)]
	public VWapDevSettings VWapEnvSett
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VWapDevSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Summary")]
	[DisplayName("Enable Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 0)]
	public bool SummaryEnable
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

	[Category("Summary")]
	[DisplayName("Volume Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 1)]
	public bool SummaryEnableVolume
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

	[DisplayName("Trade Summary")]
	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 2)]
	public bool SummaryEnableNumTrade
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

	[DisplayName("Text Color")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 3)]
	[Category("Summary")]
	public Color SummaryTextColor
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

	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 4)]
	[DisplayName("Ask Color")]
	public Color SummaryAskColor
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

	[DisplayName("Bid Color")]
	[Category("Summary")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 5)]
	public Color SummaryBidColor
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

	[DisplayName("Font size")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 6, DecimalPosToShow = 2, IncrementValue = 0.2, MaxValue = 50.0)]
	[Category("Summary")]
	public float SummaryFontSize
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

	[DisplayName("Filter Mode")]
	[Category("Custom time session (Exchange time zone)")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 0)]
	public VirtualControllerDecider FilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (VirtualControllerDecider)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Custom time session (Exchange time zone)")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 1)]
	public TimeSpan IniSession
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

	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 2)]
	[Category("Custom time session (Exchange time zone)")]
	public TimeSpan EndSession
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

	[Category("Hidden")]
	[StaticStructAllocator(IsVisible = false)]
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

	[StaticStructAllocator(IsVisible = false)]
	public bool IsSomethingDev
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool IsSomethingExtended
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EditableRecordLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60e044da66db4b08896730b7f82d59f6 != 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555643));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5644219B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE0E222D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a39879ad80d54c83bf12466671d12537), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE755D2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C7C84 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x781971F1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eca23e1b791747c78ba1f3f94ba21ecf),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9BB29F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditableRecordLocator(ScopeEncryptor.HiddenModelDecider info, MapResponderLocator.TransformableUserEncryptor b, int field_ID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool iskey, bool ismap)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SerializeNode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindGeneralFormatter(int first_Z, bool attrreguired, double pool, Color selection2, Color pol3, int min_spec4, DashStyle cfg5)
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
	public override void DecodeListener(bool testv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MonoTemplateWriter WriteAuthenticator(int flags_instance, int cont_Ptr, int rule, bool isx2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ClearSetCompiler(int last_Z, int reg_amount, bool testfilter)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearSortedPolicy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyVisibleSorter(DateTime var1, DateTime cont, int rolecount, int cont2_offset, bool isfirst3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator first, bool isvis, MapResponderLocator.TokenParameterViewer role)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindSequentialContainer(SingletonHandlerConnection.ObjectAuthenticatorLocator res, bool novis, MapResponderLocator.TokenParameterViewer temp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MonoTemplateWriter ClearTransformableInspector(int insertKEYAt, int reg_low)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer ClearGenericTransaction(double config, Color vis, int rescounter, bool updateconfig2 = true, bool isivk3 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindSimpleError(int previousi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearDetailedMapper(MapResponderLocator.GeneratorResponder value, int counter_end)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearVisualMatcher(ExecutorGenerator first, out int attr, out int comp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvokeMap(int first_end, int IDsecond, bool acceptcontrol, bool createx2, bool asset3install)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActiveTransmitter(int nextparam, bool explicitcaller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyFilteredProc(int positionres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveTransformableFunction(bool noi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindPortableIterator(ExecutorGenerator i, MapResponderLocator.EfficientStructRequester connection, out bool c, out bool visitor2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int ClearSymbolicPredicate(int[] i, long nextcont)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddAdapter(bool testinfo, int column_token, bool isdic)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssessAttribute(MapResponderLocator.GeneratorResponder v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool writeasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindOrderedProfiler(bool isinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool removev)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearAlphabeticComparator(int previous_first)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RemoveSingleton()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EditableRecordLocator AttachSimpleAdapterAttribute()
	{
		return null;
	}
}
