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
using VolAnalysis.Wrapping;

namespace Deepchart.Registry;

internal class DetailedInterpreterReg : LocatorRequest
{
	internal enum EncryptorTaskState
	{
		High,
		Low,
		Open,
		Close,
		Volume
	}

	[CompilerGenerated]
	private EncryptorTaskState m_AttributeDriver;

	[CompilerGenerated]
	private int m_OrderedProviderRegLength;

	[CompilerGenerated]
	private bool m_IsRegEditorBuilder;

	[CompilerGenerated]
	private IntegratedMapperWriter.ProgramSingletonTypes m_FlexibleDispatcherReg;

	[CompilerGenerated]
	private int m_ScheduledTransmitterRegPerc;

	[CompilerGenerated]
	private int expandableMemberRegSize;

	[CompilerGenerated]
	private int _BuilderMapperRegLevel;

	[CompilerGenerated]
	private Color mapperCompressorReg;

	[CompilerGenerated]
	private Color m_SpecNotifier;

	[CompilerGenerated]
	private int m_FilteredMonitorRegId;

	private VisualWrapperRequester<double> workerTracker;

	private double detachedObjectReg;

	private double m_RegCompressorCompiler;

	private int m_ThreadConfigurationNum;

	private int m_SetClientRegRate;

	private IntegratedMapperWriter m_ScopeAttributeReg;

	internal static DetailedInterpreterReg AttachGeneralFinderWatcher;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public EncryptorTaskState InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (EncryptorTaskState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MinValue = 1.0)]
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

	[Category("Average")]
	[DisplayName("Average Type")]
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

	[Category("Average")]
	[DisplayName("Length")]
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

	[Category("Level Settings")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public int OverBoughtLevel
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
	[Category("Level Settings")]
	public int OverSoldLevel
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 2)]
	public Color OverBourghtColor
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

	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 3)]
	[Category("Level Settings")]
	public Color OverSoldColor
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
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 4)]
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
	static DetailedInterpreterReg()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		Type? typeFromHandle = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555555));
		MapResponderLocator.SortedPublisherWrapper sortedPublisherWrapper = new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5B93C759 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F39325 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22), MapResponderLocator.BasicRecordReg.Oscillator);
		sortedPublisherWrapper.SetList(new List<string> { WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699B4C87 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616) });
		DicSender.DetermineScopeCompiler(typeFromHandle, sortedPublisherWrapper);
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_0674567192e14314b84a58d33d035031 == 0)
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
	public DetailedInterpreterReg(ScopeEncryptor.HiddenModelDecider reference, MapResponderLocator.TransformableUserEncryptor cont, int util_length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool configreguired, bool isresult)
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
	private void QueryDecryptor(Color setup, double b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool containsinstance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StoreReadablePublisher(bool isconfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool checkinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool skipv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateResponsiveWatcherProfile()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DetailedInterpreterReg GenerateSetProfileEditor()
	{
		return null;
	}
}
