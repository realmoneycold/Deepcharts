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
using VolAnalysis.IO;
using VolumetricaAPI;

namespace VolAnalysis.Wrapping;

internal class CustomizableWrapper : LocatorRequest
{
	internal enum LocatorViewerProgramKind
	{
		High,
		Low,
		Open,
		Close,
		Volume
	}

	[CompilerGenerated]
	private LocatorViewerProgramKind dividedWrapper;

	[CompilerGenerated]
	private int _VirtualWrapperVal;

	[CompilerGenerated]
	private bool isSegmentedTree;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes synchronizerTokenizer;

	[CompilerGenerated]
	private int _CollectorGatewayInterval;

	[CompilerGenerated]
	private int _SymbolicWrapperVol;

	[CompilerGenerated]
	private Color m_VisualWrapper;

	[CompilerGenerated]
	private Color m_FieldWrapper;

	[CompilerGenerated]
	private Color wrapperAuthenticator;

	[CompilerGenerated]
	private int m_IntegratedConsumerLevel;

	private VisualWrapperRequester<double> _WrapperWorker;

	private Common.WriterWrapperHandler m_EncryptorListener;

	private IntegratedMapperWriter m_OperationalWrapper;

	internal static CustomizableWrapper CallNode;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[Category("General")]
	public LocatorViewerProgramKind InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (LocatorViewerProgramKind)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0, MaxValue = 1000.0)]
	[Category("General")]
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

	[Category("Average")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	public bool ActivateAvg
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

	[DisplayName("Average Type")]
	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
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

	[DisplayName("Length")]
	[Category("Average")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	public int AvgPeriod
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

	[Category("Levels")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0, MinValue = 1.0, MaxValue = 1000.0)]
	public int LevelValue
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[Category("Levels")]
	public Color ZeroColor
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

	[Category("Levels")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public Color OverboughtColor
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

	[Category("Levels")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	public Color OversoldColor
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

	[Category("Levels")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4, MinValue = 1.0, MaxValue = 5.0)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomizableWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555357));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5B923CD1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x214226BD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803), MapResponderLocator.BasicRecordReg.Oscillator);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5EDD35D1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6b3eda098e1a4d3aa281067d349fea8d) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
		int num = 5;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12 != 0)
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
	public CustomizableWrapper(ScopeEncryptor.HiddenModelDecider instance, MapResponderLocator.TransformableUserEncryptor reg, int c)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool verifyident, bool iscont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer WrapBasicArgument(double first, Color pol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool compareinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadAggregator(bool extractdef)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool itemneeded)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool includeinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ParseAuditor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CustomizableWrapper GenerateIntegratedProgram()
	{
		return null;
	}
}
