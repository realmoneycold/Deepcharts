using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaAPI.Chart;

namespace Deepchart.DecisionMaking;

internal class HandlerAggregator : LocatorRequest
{
	internal enum AdaptableStackWriter
	{
		Volume,
		[Display(Name = "Order (MBO)")]
		Order,
		AggregateTrades
	}

	[CompilerGenerated]
	private AdaptableStackWriter _WriterInterpreter;

	[CompilerGenerated]
	private int _DeciderSetCnt;

	[CompilerGenerated]
	private int _DeciderOrderValue;

	[CompilerGenerated]
	private bool _IsIdentifiableWriterDecider;

	[CompilerGenerated]
	private int _AdvancedEncryptorDeciderLength;

	[CompilerGenerated]
	private double m_SenderDic;

	[CompilerGenerated]
	private Color _FilterCollection;

	[CompilerGenerated]
	private DashStyle _AdaptableAggregatorDecider;

	[CompilerGenerated]
	private int deciderDefinitionId;

	private int expandableInterpreterDeciderOffset;

	private long m_GroupedCalculatorDeciderId;

	private Common.WriterWrapperHandler m_DeciderSorter;

	private VisualWrapperRequester<long> deciderTemplate;

	private RequesterTagExplorer m_AdjustableInspectorDecider;

	internal static HandlerAggregator AttachMonoEmitterEncryptor;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2147483647.0)]
	[Category("General")]
	public AdaptableStackWriter InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AdaptableStackWriter)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("General")]
	public bool ResetAtStartSession
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, IncrementValue = 1.0, MaxValue = 10000.0, MinValue = 1.0)]
	[Category("Average")]
	public int Length
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

	[DisplayName("Type Average")]
	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, IncrementValue = 0.25)]
	public double StdDevValue
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

	[Category("Zero Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public Color ZeroLineColor
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

	[Category("Zero Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public DashStyle ZeroLineStyle
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

	[Category("Zero Line")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MinValue = 1.0, MaxValue = 6.0)]
	public int ZeroLineWidth
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
	static HandlerAggregator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 2;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_624b474964114179bb2ea3d4c0497999 != 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555383));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5B923C33 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4DC462 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), MapResponderLocator.BasicRecordReg.Volume);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x781908B5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_eca23e1b791747c78ba1f3f94ba21ecf) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandlerAggregator(ScopeEncryptor.HiddenModelDecider instance, MapResponderLocator.TransformableUserEncryptor second, int filter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool getres, bool outputresult)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer GuideProgram(Color instance, int min_token, DashStyle state)
	{
		return null;
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
	private RequesterTagExplorer InitPublisher(Color res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isres)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureVisualInspector(bool novalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool forceinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool injectspec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SplitRecommender()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandlerAggregator AttachAccessibleChooserFunction()
	{
		return null;
	}
}
