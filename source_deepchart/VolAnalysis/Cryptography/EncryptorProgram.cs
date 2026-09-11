using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Cryptography;

internal class EncryptorProgram : LocatorRequest
{
	internal enum RoleTemplateAllocatorMode
	{
		Box,
		Line,
		BoxAndLine
	}

	internal enum DeciderFigureHorizontalAnchor
	{
		Fixed,
		DeltaFixed,
		DeltaFading
	}

	[CompilerGenerated]
	private int mapReporterNum;

	[CompilerGenerated]
	private int m_EncryptorExplorerDist;

	[CompilerGenerated]
	private int consumerEncryptorTotal;

	[CompilerGenerated]
	private Color m_WorkerEnumerator;

	[CompilerGenerated]
	private Color _ConvertibleEncryptor;

	[CompilerGenerated]
	private RoleTemplateAllocatorMode concreteEncryptor;

	[CompilerGenerated]
	private bool isInternalEncryptor;

	[CompilerGenerated]
	private int _ExtendedDecoratorIndex;

	[CompilerGenerated]
	private DashStyle roleEncryptor;

	[CompilerGenerated]
	private Color m_DividedFormatter;

	[CompilerGenerated]
	private DeciderFigureHorizontalAnchor _OperationalTag;

	[CompilerGenerated]
	private bool _IsFinderEncryptor;

	private bool isFormatterOrder;

	private int _EncryptorTokenizerLength;

	private int _UserProjectFlag;

	private long _EncryptorDistributorInterval;

	private RequesterTagExplorer m_ExplorerAnnotation;

	private Common.WriterWrapperHandler _EncryptorTracker;

	private IMonoCalcViewer m_InspectorSharer;

	private static EncryptorProgram GenerateDetachedSchema;

	[Category("Box Settings")]
	[DisplayName("Tick Range")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 1000.0)]
	public int BoxTickRange
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

	[Category("Box Settings")]
	[DisplayName("Minimum Number Trades")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, MaxValue = 1000.0)]
	public int MinFilterTrade
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 1000.0)]
	[Category("Box Settings")]
	[DisplayName("Breakout Tick Margin")]
	public int TickMargin
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
	[DisplayName("Ask Color")]
	[Category("Box Settings")]
	public Color AskColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[DisplayName("Bid Color")]
	[Category("Box Settings")]
	public Color BidColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5)]
	[DisplayName("Display Mode")]
	[Category("Box Settings")]
	public RoleTemplateAllocatorMode DisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RoleTemplateAllocatorMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Enable")]
	[Category("Projection Settings")]
	public bool ProjectionEnable
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

	[DisplayName("Number of Bar")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, MaxValue = 5000.0)]
	[Category("Projection Settings")]
	public int ProjectionBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[DisplayName("Line Width")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2)]
	[Category("Projection Settings")]
	public int ProjectionLineWidth
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

	[Category("Projection Settings")]
	[DisplayName("Line Style")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 3)]
	public DashStyle ProjectionLineStyle
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

	[Category("Projection Settings")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 4)]
	public Color ProjectionLineColor
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

	[Category("Projection Settings")]
	[DisplayName("Color Mode")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 5)]
	public DeciderFigureHorizontalAnchor ProjectionColorMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DeciderFigureHorizontalAnchor)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 6)]
	[Category("Projection Settings")]
	public bool ExtendTillCloseCross
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
	static EncryptorProgram()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		DicSender.DetermineScopeCompiler(Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33555352)), new MapResponderLocator.SortedPublisherWrapper(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x196F396F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85d190cf4c4a4d04b10953a29bb27a0f), WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29CA4572 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf), MapResponderLocator.BasicRecordReg.Volume), EditableSetLocator._OrderThreadVol);
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_10626ce2002c4909aed2c06dd7abb3d4 != 0)
		{
			num = 6;
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
	public EncryptorProgram(ScopeEncryptor.HiddenModelDecider var1, MapResponderLocator.TransformableUserEncryptor token, int state_Low)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BuildObject(bool referenceclose, bool stripvis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StoreSequentialChooser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer CheckLiteralRecord(int last_start, int offset_cust, double consumer, double v2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RequesterTagExplorer EncodeGlobalHandler(int indextask, double cont)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckDetachedContext(bool comparespec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OpenDetailedEnumerator(bool isinit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateExtendedValue()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EncryptorProgram DeleteFactory()
	{
		return null;
	}
}
