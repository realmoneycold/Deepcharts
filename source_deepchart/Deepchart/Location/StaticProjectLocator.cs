using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class StaticProjectLocator : LocatorRequest
{
	internal enum LocatorDitherType
	{
		Tick,
		SecToClose,
		Close
	}

	[CompilerGenerated]
	private LocatorDitherType _AccessibleDecoratorLocator;

	[CompilerGenerated]
	private int modularMatcherLocatorStep;

	[CompilerGenerated]
	private int _ProgramBridgeErrorCode;

	[CompilerGenerated]
	private int m_ConvertibleAdapterLocatorLimit;

	[CompilerGenerated]
	private int editableCollectionRate;

	[CompilerGenerated]
	private int strategyLocatorVol;

	[CompilerGenerated]
	private int _EfficientTaskLocatorTotal;

	[CompilerGenerated]
	private int transmitterConfigScore;

	[CompilerGenerated]
	private bool _IsElementAnalyzer;

	[CompilerGenerated]
	private ResponsiveStructLocator _LocatorPoolList;

	[CompilerGenerated]
	private bool _IsMonoCheckerLocator;

	[CompilerGenerated]
	private string _TesterLocatorContent;

	private int modelIteratorPos;

	private int localComparatorVol;

	private int _SequentialResolverCounter;

	private int _AutomatedAuthorizerLocatorPerc;

	private int _EditorLocatorRank;

	private int visitorProgramOffset;

	private int _LocatorSelectorErrorCode;

	private int m_ValueErrorFreq;

	private double _DecoratorToken;

	private bool _IsLocatorDriver;

	private bool isLocatorTransaction;

	private bool _IsDicLocator;

	private bool m_IsRandomTracerLocator;

	private static StaticProjectLocator AttachGlobalTrackerList;

	[Category("General")]
	[DisplayName("Calculation Mode")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public LocatorDitherType CalcMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorDitherType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Maximum Seconds To Close")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[DisplayName("Lookback Period")]
	public int LookBackBar
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Minimum Lateral Number Bar")]
	[Category("General")]
	public int MinNumBarRange
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[DisplayName("Maximum Lateral Number Bar")]
	[Category("General")]
	public int MaxNumBarRange
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	[DisplayName("Minimum Volume")]
	[Category("General")]
	public int MinVolume
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MinValue = 1.0, MaxValue = 100.0)]
	[Category("General")]
	[DisplayName("Maximum % Difference")]
	public int MaxVolPerc
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7)]
	[Category("General")]
	[DisplayName("Tick Offset")]
	public int TickOffset
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
	[DisplayName("Enable")]
	[Category("Alert Sound")]
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
	[DisplayName("Alert Name")]
	[Category("Alert Sound")]
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

	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Message Popup")]
	public bool EnableMessagePopup
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

	[Category("Message Popup")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public string MessageText
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
	static StaticProjectLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_417a8e7d4ded4e479645e4b4774c2a2f == 0)
		{
			num = 3;
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555578)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486D3050 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x71ED62AB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e67915ea45e148ff9390e0e453404ac8), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator.m_LocatorManagerPos);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StaticProjectLocator(ScopeEncryptor.HiddenModelDecider i, MapResponderLocator.TransformableUserEncryptor token, int c_amount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isdef, bool notoken)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool appendinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AssetList(bool isspec, bool iscont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool allowres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateDetachedListLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StaticProjectLocator SaveUser()
	{
		return null;
	}
}
