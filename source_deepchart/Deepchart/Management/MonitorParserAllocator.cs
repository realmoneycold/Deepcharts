using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using VolAnalysis.API.Requester;
using VolAnalysis.Cryptography;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;
using VolumetricaAPI;

namespace Deepchart.Management;

internal class MonitorParserAllocator : LocatorRequest
{
	internal enum ViewerMode
	{
		Volume,
		Trades
	}

	internal enum GeneralTaskDecider
	{
		Automatic,
		Manual,
		Auto2
	}

	internal enum GeneratorAdhocOutlinerAction
	{
		Weak,
		Medium,
		Strong
	}

	[CompilerGenerated]
	private ViewerMode _EditableTransformerAllocator;

	[CompilerGenerated]
	private int _ParserConnectionAllocatorPerc;

	[CompilerGenerated]
	private GeneralTaskDecider m_VisibleRole;

	[CompilerGenerated]
	private GeneratorAdhocOutlinerAction allocatorConnectionInspector;

	[CompilerGenerated]
	private GeneratorAdhocOutlinerAction convertibleManagerAllocator;

	[CompilerGenerated]
	private int enumeratorStreamFreq;

	[CompilerGenerated]
	private int m_ExpandableProcessorAllocatorId;

	[CompilerGenerated]
	private int allocatorInspectorLocatorPosition;

	[CompilerGenerated]
	private int _StructProgramCounter;

	[CompilerGenerated]
	private Color _PassiveRegAllocator;

	[CompilerGenerated]
	private Color extractorLocator;

	private RequesterTagExplorer separatedFinalizerAllocator;

	private int m_ExecutorProjectValue;

	private VisualWrapperRequester<long> m_FunctionConfiguration;

	private Common.WriterWrapperHandler locatorMatcherAllocator;

	private VisualWrapperRequester<long> _DetailedModelAllocator;

	private Common.WriterWrapperHandler integratedValue;

	private int allocatorMatcherCacheScore;

	private int _AllocatorCacheAuditorCount;

	private int _SymbolicFactoryAllocatorCounter;

	private int _AllocatorAuditorCommandLevel;

	private double m_AllocatorCommandFormatter;

	private double formatterProgramAllocator;

	private double m_AutomatableFunctionAllocator;

	private double decoratorIterator;

	internal static MonitorParserAllocator GenerateSymbolicProcessorSender;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	public ViewerMode InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[Category("General")]
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2)]
	public GeneralTaskDecider CalculationMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneralTaskDecider)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Mode Vol")]
	[Category("General")]
	public GeneratorAdhocOutlinerAction IntensityModeVol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorAdhocOutlinerAction)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[DisplayName("Mode Delta")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	public GeneratorAdhocOutlinerAction IntensityModeDelta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (GeneratorAdhocOutlinerAction)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 2147483647.0)]
	public int MinDelta
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 6, MaxValue = 2147483647.0)]
	public int MaxDelta
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
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 7, MaxValue = 2147483647.0)]
	public int MinVol
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 8, MaxValue = 2147483647.0)]
	[Category("General")]
	public int MaxVol
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
	[Category("Color Settings")]
	public Color ColorAsk
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1)]
	[Category("Color Settings")]
	public Color ColorBid
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
	static MonitorParserAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555661)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x56447FDB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), WrapperStreamEditor.EncapsulateCommonSynchronizer(-1023941699 ^ -1800168370 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator._OrderThreadVol);
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e == 0)
		{
			num = 3;
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
	public MonitorParserAllocator(ScopeEncryptor.HiddenModelDecider setup, MapResponderLocator.TransformableUserEncryptor b, int role_length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool isv, bool isvisitor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DecodeListener(bool instancestop)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool removeitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenGenericReceiver(bool countinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AssignEfficientBuffer(bool containsinfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer AssignTransferableMonitor(bool writeitem, int row_pred, Color template, int cfg2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachConcreteSenderVisitor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MonitorParserAllocator SimulateCentralVisitorDecryptor()
	{
		return null;
	}
}
