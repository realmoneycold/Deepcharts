using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class CollectorAllocator : LocatorRequest
{
	[CompilerGenerated]
	private int _AllocatorSharerSize;

	[CompilerGenerated]
	private int _InterruptibleSubscriberAllocatorRank;

	[CompilerGenerated]
	private int _DividedProcAllocatorTotal;

	[CompilerGenerated]
	private bool _IsAllocatorContext;

	[CompilerGenerated]
	private ResponsiveStructLocator _StaticPredicates;

	private int m_AllocatorServiceInterpreterCount;

	internal static CollectorAllocator EvaluateExtractor;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, IncrementValue = 50.0, MaxValue = 10000.0)]
	[Category("Imbalance Settings")]
	[DisplayName("Min % Imbalance")]
	public int MinImb
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

	[Category("Imbalance Settings")]
	[DisplayName("Min Diagonal Comparison")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public int MinDiag
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

	[Category("Imbalance Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 500.0)]
	[DisplayName("Lookback Period")]
	public int LookPeriod
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, IsAlert = true)]
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
	static CollectorAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_750f724efa0642d1a1bee294e56e9147 != 0)
		{
			num = 5;
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555545));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6B314880 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c4b807f2d234a1db471f24a593fc425), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C1298 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FAE4C9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F3929B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x781963A5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eca23e1b791747c78ba1f3f94ba21ecf)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollectorAllocator(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor pred, int consumerlength)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isitem, bool containsivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool usedef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateHiddenInitializer(bool doident)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool configstop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool nolast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TrackFinder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CollectorAllocator SimulateLocalTokenElement()
	{
		return null;
	}
}
