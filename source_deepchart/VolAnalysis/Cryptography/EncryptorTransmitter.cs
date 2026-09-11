using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Deepchart.Management;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Chart;

namespace VolAnalysis.Cryptography;

internal class EncryptorTransmitter
{
	[CompilerGenerated]
	private Color m_IterableNode;

	[CompilerGenerated]
	private Color _TransactionGenerator;

	[CompilerGenerated]
	private float remoteEncryptor;

	[CompilerGenerated]
	private Color m_FinalizerEncryptor;

	[CompilerGenerated]
	private Color m_AdjustableEncryptor;

	[CompilerGenerated]
	private int commandInspectorNum;

	[CompilerGenerated]
	private bool _IsEncryptorAdapter;

	[CompilerGenerated]
	private Color streamContainer;

	[CompilerGenerated]
	private DashStyle m_MapPolicy;

	[CompilerGenerated]
	private bool isSeparatedEncryptor;

	[CompilerGenerated]
	private Color? m_CompilerEncryptor;

	[CompilerGenerated]
	private string commandEncryptorDescr;

	private static EncryptorTransmitter SimulateAlphabeticCollector;

	[Category("Chart Area")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0, EnableTransparent = false)]
	[DisplayName("Back Color")]
	public Color BackColor
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

	[Category("Chart Area")]
	[DisplayName("Border Color")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1, EnableTransparent = false)]
	public Color BorderColor
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, MaxValue = 64.0, IncrementValue = 0.5, DecimalPosToShow = 2)]
	[DisplayName("Text Size")]
	[Category("Chart Area")]
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

	[Category("Chart Area")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3, EnableTransparent = false)]
	[DisplayName("Text Color")]
	public Color ForeColor
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

	[DisplayName("Crosshair")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4, EnableTransparent = false)]
	[Category("Chart Area")]
	public Color CrosshairColor
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

	[Category("Chart Area")]
	[DisplayName("Series Marker Margin (px)")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 5, MaxValue = 1000.0)]
	public int SeriesMarkerMarginPixel
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

	[Category("Grid")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool MajGridEnabled
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

	[Category("Grid")]
	[DisplayName("Line Color")]
	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 1, EnableTransparent = false)]
	public Color MajGridLineColor
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

	[StaticStructAllocator(CategoryIndex = 1, PropertyIndex = 2, EnableTransparent = false)]
	[DisplayName("Line Style")]
	[Category("Grid")]
	public DashStyle MajGridLineStyle
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

	[DisplayName("Anchor Points - Enable Static Color")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 0)]
	[Category("User Annotations")]
	public bool AnnUseStaticAnchorColor
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

	[Category("User Annotations")]
	[StaticStructAllocator(CategoryIndex = 2, PropertyIndex = 1)]
	[DisplayName("Anchor Points - Static Color")]
	public Color? AnnStaticAnchorColor
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

	[Category("Extra")]
	[DisplayName("Name")]
	[StaticStructAllocator(CategoryIndex = 3, PropertyIndex = 0)]
	public string FormName
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EncryptorTransmitter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EncryptorTransmitter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CollectExtractor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EncryptorTransmitter SimulateCommonManager()
	{
		return null;
	}
}
