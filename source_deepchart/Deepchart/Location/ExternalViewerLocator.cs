using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class ExternalViewerLocator : LocatorRequest
{
	internal enum AttachedValidatorSingletonOptions
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		[Display(Name = "Number Orders (MBO)")]
		NumberOrders,
		AggregatedVolume,
		[Display(Name = "Number Agg. Trade")]
		AggregatedTrades,
		[Display(Name = "Number Trades")]
		NumberTrades
	}

	[CompilerGenerated]
	private AttachedValidatorSingletonOptions _SelectorList;

	[CompilerGenerated]
	private int m_BridgeCommandValue;

	[CompilerGenerated]
	private int transferableSenderLocatorPnts;

	private int m_SymbolicProgramLocatorLimit;

	private EncryptorCacheBuffer.Series_Prop m_ReceiverTracker;

	private static ExternalViewerLocator GenerateVirtualSolverNotifier;

	[Category("Data Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public AttachedValidatorSingletonOptions InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AttachedValidatorSingletonOptions)(object)null;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExternalViewerLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555396));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699B0B7F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3785CC27 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E455C73 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a7061df8d09141e9a6cc560bc78e9163 == 0)
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
	public ExternalViewerLocator(ScopeEncryptor.HiddenModelDecider spec, MapResponderLocator.TransformableUserEncryptor second, int rulecounter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool removereference, bool appendsecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveVisualSynchronizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool iskey)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isspec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool explicitreference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindOperationalTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateScopeNotifierInterpreter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExternalViewerLocator FlushToken()
	{
		return null;
	}
}
