using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class ChooserTracer : LocatorRequest
{
	internal enum DriverLongRowSetCols
	{
		None,
		Manual
	}

	[CompilerGenerated]
	private int requesterWriterFlag;

	[CompilerGenerated]
	private int globalRunnerIdx;

	[CompilerGenerated]
	private Color portableRequester;

	[CompilerGenerated]
	private Color _RequesterChooser;

	[CompilerGenerated]
	private bool isAggregatorField;

	[CompilerGenerated]
	private bool _IsConnectionCalculator;

	[CompilerGenerated]
	private int m_RequesterAggregatorDepth;

	[CompilerGenerated]
	private DriverLongRowSetCols _RequesterConnection;

	[CompilerGenerated]
	private int iterableRequesterScore;

	[CompilerGenerated]
	private bool m_IsRequesterTracer;

	[CompilerGenerated]
	private bool m_IsAutomatedEmitter;

	[CompilerGenerated]
	private bool m_IsRequesterField;

	private IMonoCalcViewer _TransformableRequester;

	private Color _CalculatorRequester;

	private Color requesterCompiler;

	private DateTime m_SymbolicRequester;

	private RequesterTagExplorer m_RequesterEmitter;

	private RequesterTagExplorer m_RequesterAttribute;

	private MapNotifier customRequester;

	private MapNotifier m_MonoRequester;

	private int interruptibleRequesterPos;

	private int _TransferableRequesterRate;

	private bool _IsSpecSpec;

	private long _RequesterEnumeratorAge;

	private static ChooserTracer AttachStatelessViewer;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public int DaysToLoad
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 8.0)]
	[Category("General")]
	public int LineWidth
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	[Category("General")]
	public Color BadHighColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[Category("General")]
	public Color BadLowColor
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	public bool ShowRectangle
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	[Category("General")]
	public bool ShowBackground
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 100.0)]
	public int Opacity
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

	[Category("Filter Settings")]
	[DisplayName("Filter Mode")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 10000000.0, IncrementValue = 50.0)]
	public DriverLongRowSetCols FilterMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DriverLongRowSetCols)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 10000000.0, IncrementValue = 50.0)]
	[Category("Filter Settings")]
	[DisplayName("Manual Min. Vol.")]
	public int FilterMinVol
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

	[Category("Extend Settings")]
	[DisplayName("Enabled Extended")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool EnableExtended
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

	[Category("Extend Settings")]
	[DisplayName("Reset Start Day")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	public bool ExtendResetOnStart
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	[Category("Extend Settings")]
	[DisplayName("Remove Line On Shadow Triggered")]
	public bool ExtendShadowTriggered
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ChooserTracer()
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
				case 0:
				{
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555332));
					MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x530FBDA4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0bc27ac9f2bd46bca41590fe99075f1a), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6A776286 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f), MapResponderLocator.BasicRecordReg.Volume);
					sortedPublisherWrapper.SetList(new List<string>
					{
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE7255A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938),
						WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316AC894 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708)
					});
					DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper, EditableSetLocator._FormatterElementPnts);
					return;
				}
				case 1:
					break;
				}
				goto IL_0046;
				IL_001f:
				if (num == 989)
				{
					break;
				}
				goto IL_0046;
				IL_0046:
				WrapperStreamEditor.CoverPortableElement();
				num2 = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fca8d5179fb5447fb3d3bee814625c4b == 0)
				{
					num2 = 5;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChooserTracer(ScopeEncryptor.HiddenModelDecider key, MapResponderLocator.TransformableUserEncryptor pred, int tag_counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool uselast, bool overridecfg)
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
	private RequesterTagExplorer RequestSetDecorator(int ident, bool verifyord)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer QuerySortedValidator(int idxconfig, double cfg, bool dorule)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool wantvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FetchVisibleReg(bool canv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool islast)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SendEvaluator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChooserTracer ValidatePool()
	{
		return null;
	}
}
