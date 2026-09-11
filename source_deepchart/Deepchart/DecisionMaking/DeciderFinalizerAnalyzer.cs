using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderFinalizerAnalyzer : LocatorRequest
{
	internal enum DeciderSubjectIdentifierType
	{
		DayBegin,
		Always
	}

	internal enum DeciderImportState
	{
		Tick,
		Percentual
	}

	[CompilerGenerated]
	private DeciderSubjectIdentifierType deciderAnalyzerResponder;

	[CompilerGenerated]
	private DeciderImportState _RemoteFieldDecider;

	[CompilerGenerated]
	private double _CustomizableDictionaryDecider;

	[CompilerGenerated]
	private double m_ResponderSystemDecider;

	[CompilerGenerated]
	private bool _IsDeciderSystemServer;

	[CompilerGenerated]
	private int m_ConnectedExecutorCap;

	[CompilerGenerated]
	private Color m_CommonSchemaDecider;

	[CompilerGenerated]
	private Color _HiddenNodeDecider;

	private IMonoCalcViewer deciderServerPool;

	internal static DeciderFinalizerAnalyzer SimulateSymbolicStreamManager;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public DeciderSubjectIdentifierType GapMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderSubjectIdentifierType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public DeciderImportState CalculationMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderImportState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, DecimalPosToShow = 2, IncrementValue = 0.25)]
	[Category("General")]
	public double PercValue
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, MaxValue = 10000.0)]
	[Category("General")]
	public double TickValue
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[Category("General")]
	public bool TriggerWholeBar
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MaxValue = 100.0)]
	[Category("Color Settings")]
	public int BackgroundOpacity
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

	[Category("Color Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
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

	[Category("Color Settings")]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderFinalizerAnalyzer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85ba16e4dce54edcb3824b8a2ce69527 == 0)
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
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555411)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3B8E2E1A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a9738adb7db44381b9b07370fcb97909), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F512C7F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7), MapResponderLocator.BasicRecordReg.Statistics));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderFinalizerAnalyzer(ScopeEncryptor.HiddenModelDecider param, MapResponderLocator.TransformableUserEncryptor selection, int dir_low)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isres, bool ignoresecond)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool hasvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool loadi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer VerifyTokenizer(int mean_first, double cfg, double rule)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateConcreteManagerMember()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderFinalizerAnalyzer AttachCentralMemberProcessor()
	{
		return null;
	}
}
