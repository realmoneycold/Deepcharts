using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class RegStructDecorator : LocatorRequest
{
	[CompilerGenerated]
	private SequentialAttributeReg.PropertyPosition decoratorCreatorReg;

	[CompilerGenerated]
	private double m_FieldAuthorizer;

	[CompilerGenerated]
	private int _AttachedBridgeRegFreq;

	[CompilerGenerated]
	private Color _EfficientValueReg;

	[CompilerGenerated]
	private Color _IterableSharerReg;

	[CompilerGenerated]
	private int _CalcFactoryTotal;

	[CompilerGenerated]
	private Color activeObserver;

	[CompilerGenerated]
	private float sortedCalculatorReg;

	[CompilerGenerated]
	private Color m_ConfigController;

	[CompilerGenerated]
	private int _PortablePolicyRegDepth;

	[CompilerGenerated]
	private Color _IntegratedWriterReg;

	[CompilerGenerated]
	private bool m_IsGenericSystemReg;

	[CompilerGenerated]
	private bool m_IsRegCreatorOrder;

	[CompilerGenerated]
	private bool m_IsLocalSolver;

	[CompilerGenerated]
	private bool m_IsCacheDic;

	[CompilerGenerated]
	private bool _IsSortedTracer;

	private EncryptorCacheBuffer.Series_Prop orderAuthenticatorReg;

	private SequentialAttributeReg _AuthenticatorHandlerReg;

	private SequentialAttributeReg.LocatorBridgeRequester _DictionaryFactory;

	private RequesterTagExplorer regHandlerProject;

	internal static RegStructDecorator GenerateAccessibleEnumeratorSynchronizer;

	[DisplayName("Zig Zag Mode")]
	[Category("Zig Zag Settings")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0)]
	[DisplayName("Zig Zag Abs. Rev")]
	[Category("Zig Zag Settings")]
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 2147483647.0)]
	[Category("Zig Zag Settings")]
	[DisplayName("Zig Zag Tick Rev./Highest Lowest")]
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

	[Category("Zig Zag Settings")]
	[DisplayName("Color Up")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	public Color ZigUpColor
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

	[DisplayName("Color Down")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[Category("Zig Zag Settings")]
	public Color ZigDownColor
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

	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 20.0)]
	[Category("Zig Zag Settings")]
	public int ZigLineWidth
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

	[Category("Retracement Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, DecimalPosToShow = 2, MaxValue = 100.0)]
	[DisplayName("Background Color")]
	public Color BackRetrColor
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0, IncrementValue = 1.0)]
	[Category("Retracement Settings")]
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

	[Category("Retracement Settings")]
	[DisplayName("Font Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public Color FontRetrColor
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

	[Category("Retracement Settings")]
	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 20.0)]
	public int RetrLineWidth
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

	[DisplayName("Line Color")]
	[Category("Retracement Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public Color RetrLineColor
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

	[Category("Retracement Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	[DisplayName("Show 38.2%")]
	public bool EnableRetr38
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

	[Category("Retracement Settings")]
	[DisplayName("Show 50%")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	public bool EnableRetr50
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 7)]
	[Category("Retracement Settings")]
	[DisplayName("Show 61.8%")]
	public bool EnableRetr62
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 8)]
	[DisplayName("Show 75%")]
	[Category("Retracement Settings")]
	public bool EnableRetr75
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

	[Category("Retracement Settings")]
	[DisplayName("Extend right")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 9)]
	public bool ExtendRight
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
	static RegStructDecorator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2dd8778fa57c426d8c5e395d36005605 == 0)
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555778));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4F4DED2A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x727113B7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659), MapResponderLocator.BasicRecordReg.Statistics);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C37A8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A0A3D28 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2a4868de9f89474892002d95a55b688b)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RegStructDecorator(ScopeEncryptor.HiddenModelDecider v, MapResponderLocator.TransformableUserEncryptor attr, int res_Y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool explicitinstance, bool ispol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool validatei)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer StoreConcreteSystem(int key_X, int b, double util, double config2, Color ident3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer SaveCentralProfiler(string value, bool connectionclose)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SaveStatelessSingleton(SingletonHandlerConnection.ObjectAuthenticatorLocator first, bool acceptb, MapResponderLocator.TokenParameterViewer res)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool canspec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreAdvancedComparator(SequentialAttributeReg.LocatorBridgeRequester value, int selection_ID, int version_field, double reg2, double attr3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CustomizeContainer(bool updateitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SearchInspector()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachPassiveSynchronizerSingleton()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RegStructDecorator CreateConverter()
	{
		return null;
	}
}
