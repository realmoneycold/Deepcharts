using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Registry;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace Deepchart.Management;

internal class CompressorParser : LocatorRequest
{
	internal enum DeciderAppLockerRuleActionType
	{
		Volume,
		Trades
	}

	internal enum DeciderSpec
	{
		Fixed,
		FadingColor
	}

	[CompilerGenerated]
	private string m_SegmentedTokenizerTxt;

	[CompilerGenerated]
	private bool m_IsAlphabeticLogger;

	[CompilerGenerated]
	private bool m_IsExpandableTracker;

	[CompilerGenerated]
	private int _AllocatorTagCap;

	[CompilerGenerated]
	private bool _IsAllocatorSchema;

	[CompilerGenerated]
	private DeciderAppLockerRuleActionType fieldConnection;

	[CompilerGenerated]
	private DeciderSpec m_AllocatorMap;

	[CompilerGenerated]
	private double m_EngineMap;

	private Common.WriterWrapperHandler _VisibleCacheAllocator;

	private VisualWrapperRequester<long> _AllocatorConsumer;

	private Common.WriterWrapperHandler controllableAuditorAllocator;

	private VisualWrapperRequester<long> m_WorkerStruct;

	private long combinedSolverIdx;

	private double _AllocatorNotifier;

	private double commonCommandAllocator;

	private double customFormatterAllocator;

	private EncryptorCacheBuffer.Series_Prop monitorInspector;

	private MapResponderLocator.ExpandableModelAllocator m_AllocatorDecorator;

	private MapResponderLocator.GeneratorResponder _ScopeProgramAllocator;

	private ScheduledObjectReg m_AllocatorPublisher;

	private bool m_IsDicAllocator;

	internal static CompressorParser SimulateFlexibleProgramPublisher;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, DialogValueWindow = typeof(CentralFunctionLocator))]
	[Category("General")]
	[DisplayName("Symbol")]
	public string Symbol
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool WidthBasedVolume
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	public bool ColorBasedOnDelta
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MaxValue = 250.0, IncrementValue = 5.0)]
	[DisplayName("% max width based volume")]
	public int MaxPercWidthVolume
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

	[Category("Volume/Delta")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	[DisplayName("Border based on Open/Close")]
	public bool BorderBasedOpenClose
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	[Category("Volume/Delta")]
	public DeciderAppLockerRuleActionType DeltaInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderAppLockerRuleActionType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	[Category("Volume/Delta")]
	public DeciderSpec ColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderSpec)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6, MinValue = 0.75, MaxValue = 4.0, IncrementValue = 0.2, DecimalPosToShow = 2)]
	[Category("Volume/Delta")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompressorParser()
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
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c == 0)
					{
						num2 = 3;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0061;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_0061;
				IL_0061:
				WrapperStreamEditor.PresentConfiguration();
				WriterCommandResolver.ReflectDefinitionSelector();
				Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555518));
				MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F487381 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319DE6BD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee), MapResponderLocator.BasicRecordReg.Overlay);
				sortedPublisherWrapper.SetList(new List<string>
				{
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6B3108A6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2c4b807f2d234a1db471f24a593fc425),
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED6DFF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8),
					WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30A5B528 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64)
				});
				DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompressorParser(ScopeEncryptor.HiddenModelDecider var1, MapResponderLocator.TransformableUserEncryptor ord, int column_third)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isres, bool iscol)
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
	public override void DecodeListener(bool removetask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InsertWriter(MapResponderLocator.GeneratorResponder reference)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WatchConverter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseAttachedTemplate(bool isres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssignBasicTag(MapResponderLocator.GeneratorResponder def, bool movecfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateOperationalChecker(MapResponderLocator.GeneratorResponder first, bool updatesecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateEditablePublisherParameter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompressorParser SimulateIntegratedParameterProxy()
	{
		return null;
	}
}
