using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal class IdentifiableElementEncryptor : LocatorRequest
{
	internal enum CompressorWriterStatus
	{
		Volume,
		Delta,
		VolumeAndDelta
	}

	internal enum LocatorIconSize
	{
		Tick,
		SecToClose,
		Close
	}

	[CompilerGenerated]
	private CompressorWriterStatus profileMap;

	[CompilerGenerated]
	private LocatorIconSize _EncryptorPolicy;

	[CompilerGenerated]
	private int encryptorNotifierPosition;

	[CompilerGenerated]
	private SequentialAttributeReg.PropertyPosition _EncryptorParser;

	[CompilerGenerated]
	private double configurationBridge;

	[CompilerGenerated]
	private int _AuthenticatorEncryptorValue;

	[CompilerGenerated]
	private int encryptorCompressorLimit;

	[CompilerGenerated]
	private bool isParserState;

	[CompilerGenerated]
	private Color _ContainerEncryptor;

	[CompilerGenerated]
	private Color encryptorSubscriber;

	[CompilerGenerated]
	private int _StaticTemplateCount;

	[CompilerGenerated]
	private bool _IsEncryptorProfiler;

	[CompilerGenerated]
	private ResponsiveStructLocator _AttachedFunctionList;

	private int _EncryptorEncryptorRank;

	private int _CentralDispatcherEncryptorId;

	private bool m_IsEncryptorDictionary;

	private bool _IsConnectedVisitor;

	private bool _IsAuthorizerTask;

	private bool _IsModuleWrapper;

	private bool m_IsAdjustableBridge;

	private bool m_IsSegmentedManagerEncryptor;

	private bool isEncryptorAllocator;

	private SequentialAttributeReg m_CustomizableQueue;

	private RequesterTagExplorer m_EncryptorConfig;

	private static IdentifiableElementEncryptor GenerateDetailedExecutorViewer;

	[DisplayName("Calculation Mode")]
	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public CompressorWriterStatus DetectorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CompressorWriterStatus)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Calculation Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public LocatorIconSize CalcMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorIconSize)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[DisplayName("Maximum Seconds To Close")]
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

	[DisplayName("Zig Zag Mode")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Zig Zag Settings")]
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

	[Category("Zig Zag Settings")]
	[DisplayName("Absolute Reversal")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0)]
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

	[DisplayName("Tick Reversal/Highest Lowest")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[DisplayName("Text - Font Size")]
	[Category("Plot Settings")]
	public int FontSize
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

	[DisplayName("Marker - Enable")]
	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public bool MarkerEnable
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

	[DisplayName("Up Reversal Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[Category("Plot Settings")]
	public Color MarkerPositive
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

	[DisplayName("Down Reversal Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Plot Settings")]
	public Color MarkerNegative
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
	[DisplayName("Opacity")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, MaxValue = 100.0)]
	public int MarkerOpacity
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
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
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

	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1, IsAlert = true)]
	[Category("Alert Sound")]
	[DisplayName("Alert Name")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifiableElementEncryptor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555407));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7EE036F7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f482d0926ed04ceaae77c6b64bb93d11), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3191D3E2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E455EB7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29CA5F66 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C64AA ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE7320E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
		int num = 6;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_92a80b805f714a3989464429277034d3 == 0)
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
	public IdentifiableElementEncryptor(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor caller, int flagsrule)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool ignorevar1, bool noattr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer EncryptIdentifiableObserver(Color item)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isasset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator info, bool isivk, MapResponderLocator.TokenParameterViewer c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EncodeInternalProcessor(bool isres, bool cfgopen)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool moveparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool acceptinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StartCalculator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IdentifiableElementEncryptor SimulateStatelessAdapterAttribute()
	{
		return null;
	}
}
