using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal class GeneralWriter : LocatorRequest
{
	[CompilerGenerated]
	private int _GeneralStreams;

	[CompilerGenerated]
	private int policyWriterVal;

	[CompilerGenerated]
	private int _DetachedPrograms;

	[CompilerGenerated]
	private Color _InspectorComparator;

	[CompilerGenerated]
	private Color writerSystem;

	[CompilerGenerated]
	private int _EditableParserDriverScore;

	[CompilerGenerated]
	private bool isControllableWriter;

	[CompilerGenerated]
	private bool isWriterAnalyzer;

	[CompilerGenerated]
	private int _InternalWriterErrorCode;

	[CompilerGenerated]
	private int sorterCalculatorAge;

	private double m_MapState;

	private IMonoCalcViewer m_WriterDefinition;

	private int _FilterWriterVol;

	private static GeneralWriter AttachPortableBuilder;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 2147483647.0)]
	public int MinNumTicks
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 2147483647.0)]
	[Category("General")]
	public int MaxNumTicks
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 8.0)]
	[Category("Plot Settings")]
	[DisplayName("Line Width")]
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

	[DisplayName("Up Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Plot Settings")]
	public Color UpColor
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
	[DisplayName("Down Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public Color DownColor
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

	[DisplayName("Back Opacity")]
	[Category("Plot Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3, MaxValue = 100.0)]
	public int RectangleOpacity
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

	[DisplayName("Reset Start Day")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("Extension")]
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

	[Category("Extension")]
	[DisplayName("Remove Line On Shadow Triggered")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
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

	[Category("Extension")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2, MaxValue = 2147483647.0)]
	public int MaxBarsExtension
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

	[DisplayName("% breakout")]
	[Category("Extension")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3, MaxValue = 2147483647.0)]
	public int PercBreakout
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
	static GeneralWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_936f4d96a3fd441b9dcf927f91358655 != 0)
		{
			num = 4;
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
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555334));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x530FBDD8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0bc27ac9f2bd46bca41590fe99075f1a), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FA87D7 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4), MapResponderLocator.BasicRecordReg.Statistics);
		sortedPublisherWrapper.SetList(new List<string>
		{
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4D83AAF4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fba289398733422f859a60f7abb79212),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AAB8F95 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c),
			WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F48574D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e)
		});
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GeneralWriter(ScopeEncryptor.HiddenModelDecider init, MapResponderLocator.TransformableUserEncryptor attr, int idxutil)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isconfig, bool readcaller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer RecordSequentialFormatter(int vPosition, double attr, double rule, bool appendreference2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachSymbolicCollector()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneralWriter GenerateConcreteStream()
	{
		return null;
	}
}
