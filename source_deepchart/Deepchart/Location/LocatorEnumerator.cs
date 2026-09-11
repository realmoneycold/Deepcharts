using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

internal class LocatorEnumerator : LocatorRequest
{
	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes _ExtendedProc;

	[CompilerGenerated]
	private int m_SimpleServiceNum;

	[CompilerGenerated]
	private int _ConnectionLocatorErrorCode;

	[CompilerGenerated]
	private int _DecoratorSenderLevel;

	[CompilerGenerated]
	private double m_ExecutorLocator;

	[CompilerGenerated]
	private double m_SubscriberLocator;

	[CompilerGenerated]
	private double mapLocator;

	[CompilerGenerated]
	private Color _GenericWrapperLocator;

	[CompilerGenerated]
	private Color m_DetachedFinalizerLocator;

	[CompilerGenerated]
	private Color m_StructWrapper;

	[CompilerGenerated]
	private int m_GroupedContextLocatorCounter;

	private IntegratedMapperWriter _ExpandableChainLocator;

	private IntegratedMapperWriter m_IdentifiableInspectorLocator;

	private IntegratedMapperWriter _GeneralInterpreterLocator;

	private static LocatorEnumerator AttachSimpleSubscriber;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[DisplayName("Average Type")]
	[Category("Average")]
	public IntegratedMapperWriter.ProgramSingletonTypes AvgType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (IntegratedMapperWriter.ProgramSingletonTypes)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[Category("Average")]
	[DisplayName("AO Length 1")]
	public int ShortPeriod
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
	[Category("Average")]
	[DisplayName("AO Length 1")]
	public int LongPeriod
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

	[Category("Average")]
	[DisplayName("Average Length")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	public int AverageGraphPeriod
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

	[Category("Level Settings")]
	[DisplayName("Middle Level")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	public double MiddleLineLevel
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

	[DisplayName("Lower Level")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	[Category("Level Settings")]
	public double LowerLineLevel
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, MinValue = 0.0, MaxValue = 100.0, IncrementValue = 1.0)]
	[DisplayName("High Level")]
	public double HigherLineLevel
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

	[Category("Level Settings")]
	[DisplayName("Middle Level Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public Color MiddleLineColor
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

	[Category("Level Settings")]
	[DisplayName("Lower Level Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public Color LowerLineColor
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

	[Category("Level Settings")]
	[DisplayName("Higher Level Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	public Color HigherLineColor
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	[DisplayName("Level Width")]
	[Category("Level Settings")]
	public int LevelWidth
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
	static LocatorEnumerator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555331)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30A408C8 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556C711A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80), MapResponderLocator.BasicRecordReg.Oscillator));
		int num = 5;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d9f03e0b6eff4bfaa3ef2502f54df2d2 == 0)
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
	public LocatorEnumerator(ScopeEncryptor.HiddenModelDecider reference, MapResponderLocator.TransformableUserEncryptor counter, int filterY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool haslast, bool verifycol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IdentifyGeneralServer(Color info, double token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool isinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindResponsiveModule(bool isfirst)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isvalue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool readi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachDetailedClient()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LocatorEnumerator SimulateVisualExecutor()
	{
		return null;
	}
}
