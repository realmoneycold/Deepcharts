using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Location;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class GeneratorProxy
{
	internal enum WriterVisitor
	{
		Bars,
		DynamicLine
	}

	[CompilerGenerated]
	private int compilerComparatorLength;

	[CompilerGenerated]
	private AllocatorBinaryExpressionType _DeciderTester;

	[CompilerGenerated]
	private int m_SynchronizerPredictorPos;

	[CompilerGenerated]
	private WriterVisitor m_VisualDecider;

	[CompilerGenerated]
	private RegVisitStatus m_DeciderHandler;

	[CompilerGenerated]
	private double _SimpleDecider;

	[CompilerGenerated]
	private bool m_IsDeciderWriter;

	[CompilerGenerated]
	private int portableConverterStep;

	[CompilerGenerated]
	private bool m_IsConcreteDecider;

	[CompilerGenerated]
	private int aggregatorDeciderRank;

	[CompilerGenerated]
	private Color joinedDecider;

	[CompilerGenerated]
	private List<SortedTracerLocator> m_InterpreterDeciderList;

	[CompilerGenerated]
	private bool _IsInterruptibleReporter;

	[CompilerGenerated]
	private bool isDeciderCalculator;

	[CompilerGenerated]
	private int _IdentifiableDeciders;

	private static GeneratorProxy SimulateStatelessEditor;

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, MaxValue = 10000.0)]
	[Category("General")]
	[DisplayName("Days to load")]
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

	[Category("General")]
	[DisplayName("TF type")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	public AllocatorBinaryExpressionType tfType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AllocatorBinaryExpressionType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 1440.0)]
	[DisplayName("TF")]
	public int TF
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
	public WriterVisitor DisplayMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WriterVisitor)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[Category("Calculation")]
	[DisplayName("Mode")]
	public RegVisitStatus CalculationMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (RegVisitStatus)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DisplayName("Zig Zag Abs. Rev")]
	[Category("Calculation")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, DecimalPosToShow = 2, MaxValue = 100.0)]
	public double ZigZagRev
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

	[DisplayName("Enable")]
	[Category("Retracements")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	public bool ShowRetracements
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

	[Category("Retracements")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[DisplayName("Line width")]
	public int RetracementLineWidth
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

	[Category("Reference level")]
	[DisplayName("Enable")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public bool EnableReferenceLevel
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

	[Category("Reference level")]
	[DisplayName("Line width")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 1)]
	public int ReferenceLineWidth
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

	[Category("Reference level")]
	[DisplayName("Line color")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 2)]
	public Color ReferenceLineColor
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
	[StaticStructAllocator(IsVisible = false)]
	[DisplayName("Symbols")]
	public List<SortedTracerLocator> Symbols
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[StaticStructAllocator(IsVisible = false)]
	public bool RankingShown
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

	[StaticStructAllocator(IsVisible = false)]
	public bool RankingEnable
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

	[StaticStructAllocator(IsVisible = false)]
	public int RankingNumber
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
	public GeneratorProxy()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GeneratorProxy()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ExecuteSynchronizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GeneratorProxy ControlSingleton()
	{
		return null;
	}
}
