using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace VolAnalysis.Generators;

internal class GeneratorResolver : LocatorRequest
{
	internal enum DeciderCachingMode
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggreateTrades
	}

	[CompilerGenerated]
	private DeciderCachingMode _LiteralGenerator;

	[CompilerGenerated]
	private int _LocalGeneratorVal;

	[CompilerGenerated]
	private int automatableContainerTotal;

	[CompilerGenerated]
	private double initializerCalc;

	[CompilerGenerated]
	private float _TransformableGenerator;

	[CompilerGenerated]
	private Color passiveGenerator;

	[CompilerGenerated]
	private bool m_IsInterruptibleGenerator;

	[CompilerGenerated]
	private bool _IsCommandGenerator;

	[CompilerGenerated]
	private bool isExpandableStream;

	[CompilerGenerated]
	private int _SegmentedResolverFlag;

	[CompilerGenerated]
	private Color scheduledHandlerWriter;

	[CompilerGenerated]
	private bool _IsFlexibleGenerator;

	[CompilerGenerated]
	private int operationalGeneratorLevel;

	[CompilerGenerated]
	private Color orderedGenerator;

	[CompilerGenerated]
	private bool isReadableAdapter;

	[CompilerGenerated]
	private int m_GeneratorTokenCnt;

	[CompilerGenerated]
	private Color _OrderRequester;

	[CompilerGenerated]
	private bool isInspectorNotifier;

	[CompilerGenerated]
	private int _TokenizerCalculatorPosition;

	[CompilerGenerated]
	private Color logicalGenerator;

	[CompilerGenerated]
	private Color integratedGenerator;

	[CompilerGenerated]
	private bool _IsGeneratorDecorator;

	[CompilerGenerated]
	private int m_DefinitionPublisherInterval;

	[CompilerGenerated]
	private Color m_SenderOrder;

	[CompilerGenerated]
	private bool _IsBasicGenerator;

	[CompilerGenerated]
	private int _AlphabeticEvaluatorSize;

	[CompilerGenerated]
	private Color _ProgramGenerator;

	[CompilerGenerated]
	private bool m_IsGeneratorLogger;

	[CompilerGenerated]
	private int _CustomGeneratorVal;

	[CompilerGenerated]
	private Color m_RequestObject;

	[CompilerGenerated]
	private bool _IsTransformerGenerator;

	[CompilerGenerated]
	private int _TesterWatcherLength;

	[CompilerGenerated]
	private Color identifiableConnection;

	[CompilerGenerated]
	private Color _AutomatedGenerator;

	[CompilerGenerated]
	private bool isAdjustableGenerator;

	[CompilerGenerated]
	private int m_GeneratorMapErrorCode;

	[CompilerGenerated]
	private Color _CustomSharerEncryptor;

	[CompilerGenerated]
	private bool m_IsConvertibleGenerator;

	[CompilerGenerated]
	private int m_CombinedWrapperRegFlag;

	[CompilerGenerated]
	private int _ModelMapFlag;

	[CompilerGenerated]
	private Color _SegmentedGenerator;

	[CompilerGenerated]
	private Color _ScalableGenerator;

	[CompilerGenerated]
	private bool isGeneratorObserver;

	[CompilerGenerated]
	private int scheduledGeneratorIdx;

	[CompilerGenerated]
	private Color m_TesterGenerator;

	[CompilerGenerated]
	private bool isClientGenerator;

	[CompilerGenerated]
	private int _FieldGeneratorIdx;

	[CompilerGenerated]
	private Color monoGenerator;

	[CompilerGenerated]
	private Color generatorEditor;

	[CompilerGenerated]
	private bool m_IsGeneratorSet;

	[CompilerGenerated]
	private int responsiveGeneratorValue;

	[CompilerGenerated]
	private Color _ControllerGateway;

	[CompilerGenerated]
	private Color generatorEngine;

	[CompilerGenerated]
	private bool m_IsDetailedGenerator;

	[CompilerGenerated]
	private int interpreterMemberPerc;

	[CompilerGenerated]
	private Color joinedGenerator;

	[CompilerGenerated]
	private Color m_ProxyChain;

	[CompilerGenerated]
	private bool m_IsGeneratorEncryptor;

	[CompilerGenerated]
	private int sortedGeneratorLength;

	[CompilerGenerated]
	private Color _PortableGenerator;

	[CompilerGenerated]
	private bool _IsConfigurableReceiver;

	[CompilerGenerated]
	private int generatorCheckerCount;

	[CompilerGenerated]
	private int _GeneratorProjectDist;

	[CompilerGenerated]
	private Color extractorGenerator;

	[CompilerGenerated]
	private Color _SimpleGenerator;

	[CompilerGenerated]
	private bool isSymbolicGenerator;

	[CompilerGenerated]
	private int _GeneratorEventCap;

	[CompilerGenerated]
	private int m_AutomatableIteratorRegFreq;

	[CompilerGenerated]
	private Color _StrategyAuthenticator;

	[CompilerGenerated]
	private Color generatorValue;

	[CompilerGenerated]
	private bool m_IsExpandableGenerator;

	[CompilerGenerated]
	private int _ConsumerDecoratorLevel;

	[CompilerGenerated]
	private int staticReceiverGeneratorCap;

	[CompilerGenerated]
	private Color responsiveConverter;

	[CompilerGenerated]
	private Color _GeneratorChooser;

	private Common.WriterWrapperHandler[] generatorModels;

	private int m_CompressorGeneratorId;

	private int m_FinderFieldValue;

	private long filterFinalizerRank;

	internal static GeneratorResolver SimulateAlphabeticDecryptorDefinition;

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public DeciderCachingMode InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderCachingMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Data Settings")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 7.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
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

	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 30.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Plot Settings")]
	public Color TextColor
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
	public bool AutoTextFormat
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
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public bool ReverseOrder
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

	[Category("Tot Volume")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool UseTotVolumeThreshold
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

	[Category("Tot Volume")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold Volume")]
	public int TotVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[Category("Tot Volume")]
	[DisplayName("Threshold Color")]
	public Color TotVolumeColor
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

	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	[Category("Bid Volume")]
	public bool UseBidVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold Volume")]
	[Category("Bid Volume")]
	public int BidVolumeThreshold
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

	[Category("Bid Volume")]
	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public Color BidVolumeColor
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

	[DisplayName("Use Threshold")]
	[Category("Ask Volume")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 0)]
	public bool UseAskVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Ask Volume")]
	[DisplayName("Threshold Volume")]
	public int AskVolumeThreshold
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

	[Category("Ask Volume")]
	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 4, PropertyIndex = 2)]
	public Color AskVolumeColor
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 0)]
	[DisplayName("Use Threshold")]
	[Category("Delta Volume")]
	public bool UseDeltaVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold Volume")]
	[Category("Delta Volume")]
	public int DeltaVolumeThreshold
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

	[Category("Delta Volume")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 2)]
	[DisplayName("Threshold Color Ask")]
	public Color DeltaVolumeAskColor
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

	[Category("Delta Volume")]
	[DisplayName("Threshold Color Bid")]
	[StaticStructAllocator(CategoryIndex = 5, PropertyIndex = 3)]
	public Color DeltaVolumeBidColor
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

	[Category("Max. Delta Volume")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 0)]
	public bool UseMaxDeltaVolumeThreshold
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

	[Category("Max. Delta Volume")]
	[DisplayName("Threshold Volume")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int MaxDeltaVolumeThreshold
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

	[Category("Max. Delta Volume")]
	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 6, PropertyIndex = 2)]
	public Color MaxDeltaVolumeColor
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

	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 0)]
	[Category("Min. Delta Volume")]
	public bool UseMinDeltaVolumeThreshold
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

	[Category("Min. Delta Volume")]
	[DisplayName("Threshold Volume")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int MinDeltaVolumeThreshold
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

	[Category("Min. Delta Volume")]
	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 7, PropertyIndex = 2)]
	public Color MinDeltaVolumeColor
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

	[Category("Tot. NT")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 0)]
	public bool UseTotNTVolumeThreshold
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

	[Category("Tot. NT")]
	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold")]
	public int TotNTVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 8, PropertyIndex = 2)]
	[DisplayName("Threshold Color")]
	[Category("Tot. NT")]
	public Color TotNTVolumeColor
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

	[Category("Delta NT")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 0)]
	public bool UseDeltaNTVolumeThreshold
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

	[Category("Delta NT")]
	[DisplayName("Threshold")]
	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int DeltaNTVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 2)]
	[Category("Delta NT")]
	[DisplayName("Threshold Color Ask")]
	public Color DeltaNTAskColor
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

	[StaticStructAllocator(CategoryIndex = 9, PropertyIndex = 3)]
	[DisplayName("Threshold Color Bid")]
	[Category("Delta NT")]
	public Color DeltaNTBidColor
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

	[Category("Delta HL")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 0)]
	public bool UseDeltaHLVolumeThreshold
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

	[Category("Delta HL")]
	[DisplayName("Threshold")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int DeltaHLVolumeThreshold
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

	[Category("Delta HL")]
	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 10, PropertyIndex = 2)]
	public Color DeltaHLVolumeColor
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

	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 0)]
	[DisplayName("Use Threshold")]
	[Category("Delta %")]
	public bool UseDeltaPercVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Positive Threshold")]
	[Category("Delta %")]
	public int DeltaPercVolumeThresholdPos
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

	[Category("Delta %")]
	[DisplayName("Negative Threshold")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int DeltaPercVolumeThresholdNeg
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

	[Category("Delta %")]
	[DisplayName("Positive Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 3)]
	public Color DeltaPercPosColor
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

	[Category("Delta %")]
	[DisplayName("Negative Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 11, PropertyIndex = 4)]
	public Color DeltaPercNegColor
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

	[Category("Vol (s)")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 0)]
	public bool UseVolSVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold")]
	[Category("Vol (s)")]
	public int VolSVolumeThreshold
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

	[DisplayName("Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 12, PropertyIndex = 2)]
	[Category("Vol (s)")]
	public Color VolSVolumeColor
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

	[Category("Cot H")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 0)]
	public bool UseCotHVolumeThreshold
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

	[Category("Cot H")]
	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[DisplayName("Threshold")]
	public int CotHVolumeThreshold
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

	[Category("Cot H")]
	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 2)]
	[DisplayName("Threshold Color Ask")]
	public Color CotHAskColor
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

	[Category("Cot H")]
	[DisplayName("Threshold Color Bid")]
	[StaticStructAllocator(CategoryIndex = 13, PropertyIndex = 3)]
	public Color CotHBidColor
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

	[Category("Cot L")]
	[StaticStructAllocator(CategoryIndex = 14, PropertyIndex = 0)]
	[DisplayName("Use Threshold")]
	public bool UseCotLVolumeThreshold
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

	[Category("Cot L")]
	[DisplayName("Threshold")]
	[StaticStructAllocator(CategoryIndex = 14, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int CotLVolumeThreshold
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

	[DisplayName("Threshold Color Ask")]
	[Category("Cot L")]
	[StaticStructAllocator(CategoryIndex = 14, PropertyIndex = 2)]
	public Color CotLAskColor
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

	[Category("Cot L")]
	[DisplayName("Threshold Color Bid")]
	[StaticStructAllocator(CategoryIndex = 14, PropertyIndex = 3)]
	public Color CotLBidColor
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

	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 15, PropertyIndex = 0)]
	[Category("Cot Bar")]
	public bool UseCotBarVolumeThreshold
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

	[Category("Cot Bar")]
	[DisplayName("Threshold")]
	[StaticStructAllocator(CategoryIndex = 15, PropertyIndex = 1, MaxValue = 2147483647.0)]
	public int CotBarVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 15, PropertyIndex = 2)]
	[Category("Cot Bar")]
	[DisplayName("Threshold Color Ask")]
	public Color CotBarAskColor
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

	[DisplayName("Threshold Color Bid")]
	[StaticStructAllocator(CategoryIndex = 15, PropertyIndex = 3)]
	[Category("Cot Bar")]
	public Color CotBarBidColor
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

	[Category("Time (s)")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 16, PropertyIndex = 0)]
	public bool UseTimeSVolumeThreshold
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

	[StaticStructAllocator(CategoryIndex = 16, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("Time (s)")]
	[DisplayName("Threshold")]
	public int TimeSVolumeThreshold
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

	[Category("Time (s)")]
	[StaticStructAllocator(CategoryIndex = 16, PropertyIndex = 2)]
	[DisplayName("Threshold Color")]
	public Color TimeSVolumeColor
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

	[Category("Bar Ratio")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 17, PropertyIndex = 0)]
	public bool UseBarRatioVolumeThreshold
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

	[DisplayName("> Threshold")]
	[Category("Bar Ratio")]
	[StaticStructAllocator(CategoryIndex = 17, PropertyIndex = 1, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	public int BarRatioVolumeThresholdPos
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

	[Category("Bar Ratio")]
	[DisplayName("< Threshold")]
	[StaticStructAllocator(CategoryIndex = 17, PropertyIndex = 2, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	public int BarRatioVolumeThresholdNeg
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

	[DisplayName("> Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 17, PropertyIndex = 3)]
	[Category("Bar Ratio")]
	public Color BarRatioPosColor
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

	[DisplayName("< Threshold Color")]
	[Category("Bar Ratio")]
	[StaticStructAllocator(CategoryIndex = 17, PropertyIndex = 4)]
	public Color BarRatioNegColor
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

	[Category("HRT")]
	[DisplayName("Use Threshold")]
	[StaticStructAllocator(CategoryIndex = 18, PropertyIndex = 0)]
	public bool UseHRTVolumeThreshold
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

	[Category("HRT")]
	[DisplayName("> Threshold")]
	[StaticStructAllocator(CategoryIndex = 18, PropertyIndex = 1, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	public int HRTVolumeThresholdPos
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

	[StaticStructAllocator(CategoryIndex = 18, PropertyIndex = 2, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	[DisplayName("< Threshold")]
	[Category("HRT")]
	public int HRTVolumeThresholdNeg
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

	[StaticStructAllocator(CategoryIndex = 18, PropertyIndex = 3)]
	[DisplayName("> Threshold Color")]
	[Category("HRT")]
	public Color HRTPosColor
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

	[StaticStructAllocator(CategoryIndex = 18, PropertyIndex = 4)]
	[DisplayName("< Threshold Color")]
	[Category("HRT")]
	public Color HRTNegColor
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

	[Category("LRT")]
	[StaticStructAllocator(CategoryIndex = 19, PropertyIndex = 0)]
	[DisplayName("Use Threshold")]
	public bool UseLRTVolumeThreshold
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

	[DisplayName("> Threshold")]
	[StaticStructAllocator(CategoryIndex = 19, PropertyIndex = 1, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	[Category("LRT")]
	public int LRTVolumeThresholdPos
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

	[StaticStructAllocator(CategoryIndex = 19, PropertyIndex = 2, MaxValue = 2147483647.0, DecimalPosToShow = 4, IncrementValue = 0.001)]
	[DisplayName("< Threshold")]
	[Category("LRT")]
	public int LRTVolumeThresholdNeg
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

	[StaticStructAllocator(CategoryIndex = 19, PropertyIndex = 3)]
	[DisplayName("> Threshold Color")]
	[Category("LRT")]
	public Color LRTPosColor
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

	[Category("LRT")]
	[DisplayName("< Threshold Color")]
	[StaticStructAllocator(CategoryIndex = 19, PropertyIndex = 4)]
	public Color LRTNegColor
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
	static GeneratorResolver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6b3eda098e1a4d3aa281067d349fea8d == 0)
		{
			num = 1;
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555506));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A3EC94 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x744DDF9A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_063232c07bf344ff9a39b9bbfee37650), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A3D090 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -224835691 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AE2415 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneratorResolver(ScopeEncryptor.HiddenModelDecider def, MapResponderLocator.TransformableUserEncryptor pred, int state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool updatereference, bool forceresult)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecodeArgument(int asset, out string visitor, out string consumer, out Color key2, out bool pred3)
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
	public override void DecodeListener(bool compareparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DetachConsumer(bool outputconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GenerateVisualError(MapResponderLocator.GeneratorResponder reference, bool skippred)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool readitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool updateident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSegmentedDefinitionSelector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneratorResolver MeasureRecommender()
	{
		return null;
	}
}
