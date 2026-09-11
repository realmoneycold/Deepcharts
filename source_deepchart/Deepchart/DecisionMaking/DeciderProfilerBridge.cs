using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderProfilerBridge : LocatorRequest
{
	internal enum TransferableMatcherAllocatorEnum
	{
		High,
		Low,
		Center,
		PriceSlope,
		DeltaSign
	}

	internal enum DateFilter
	{
		MaxMinDeltaVolume,
		TotalVolume,
		DeltaVolume,
		DeltaPercentual,
		TotalTrade,
		DeltaTrade,
		Extension,
		CotHigh,
		CotLow,
		CotBar,
		BidAskBarPercentual,
		Ratio,
		Time
	}

	internal enum AllocatorJsonTokenType
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggregateTrades
	}

	[CompilerGenerated]
	private AllocatorJsonTokenType _CustomizableSchemaDecider;

	[CompilerGenerated]
	private int _DeciderBridgeDecryptorOffset;

	[CompilerGenerated]
	private int m_TracerDecryptorNum;

	[CompilerGenerated]
	private float m_GenericModule;

	[CompilerGenerated]
	private float m_DecryptorCalc;

	[CompilerGenerated]
	private bool _IsDecryptorCalcDecider;

	[CompilerGenerated]
	private bool isDeciderCalcClient;

	[CompilerGenerated]
	private bool m_IsCommonNodeDecider;

	[CompilerGenerated]
	private double _SummarizerViewer;

	[CompilerGenerated]
	private bool isHiddenMapperDecider;

	[CompilerGenerated]
	private TransferableMatcherAllocatorEnum objectDefinition;

	private int parameterListLength;

	private ScheduledObjectReg[] m_DeciderClientElementItems;

	internal static DeciderProfilerBridge StopList;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("Data Settings")]
	public AllocatorJsonTokenType InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorJsonTokenType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
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

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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

	[Category("Text Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 50.0, IncrementValue = 0.5, DecimalPosToShow = 2)]
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

	[Category("Text Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 50.0, IncrementValue = 0.5, DecimalPosToShow = 2)]
	[DisplayName("Smaller Font size")]
	public float SmallerFontSize
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
	[Category("Text Settings")]
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	[Category("Text Settings")]
	[DisplayName("Absolute Sign")]
	public bool TextAbs
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

	[Category("Coloring Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool OpacityBasedOnRatio
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

	[Category("Coloring Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1, MaxValue = 2147483647.0, IncrementValue = 0.1, DecimalPosToShow = 5)]
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

	[Category("Coloring Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public bool ColorTextBasedOnDelta
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
	[Category("Price Settings")]
	public TransferableMatcherAllocatorEnum PlotPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (TransferableMatcherAllocatorEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderProfilerBridge()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555765));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A0A694E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2a4868de9f89474892002d95a55b688b), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E42F03 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180), MapResponderLocator.BasicRecordReg.Statistics);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A0A5CE4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2a4868de9f89474892002d95a55b688b),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360C7AC2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x41BD363 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_42fbc1ba04824a6bbb0b9900cd13a5de),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E92175F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderProfilerBridge(ScopeEncryptor.HiddenModelDecider asset, MapResponderLocator.TransformableUserEncryptor counter, int indexOf_third)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool islast, bool isconnection)
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
	public override void DecodeListener(bool identstop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncludePublisher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool issetup)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool canfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdaptLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderProfilerBridge SimulateGroupedSorterContainer()
	{
		return null;
	}
}
