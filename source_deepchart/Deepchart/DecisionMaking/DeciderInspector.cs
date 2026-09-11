using System.ComponentModel;
using System.Runtime.CompilerServices;
using Deepchart.Location;
using Deepchart.Management;
using VolAnalysis.Wrapping;

namespace Deepchart.DecisionMaking;

internal class DeciderInspector
{
	[CompilerGenerated]
	private bool _IsDeciderFactory;

	[CompilerGenerated]
	private bool _IsTokenSpec;

	[CompilerGenerated]
	private ResponsiveStructLocator _DeciderEvents;

	[CompilerGenerated]
	private bool m_IsCommonProject;

	[CompilerGenerated]
	private string _AdvancedDeciderTag;

	[CompilerGenerated]
	private bool m_IsMemberClient;

	[CompilerGenerated]
	private int isolatedThreadSize;

	private static DeciderInspector GenerateTransferableVisitor;

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 0)]
	[DisplayName("Enable")]
	public bool EnableAlert
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 1)]
	[Category("General")]
	public bool OnlyOncePerBar
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 2, IsAlert = true)]
	[DisplayName("Alert Sound")]
	[Category("General")]
	public ResponsiveStructLocator alertValue
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

	[Category("General")]
	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 3)]
	[DisplayName("Show Message")]
	public bool MessageAlert
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

	[StaticStructAllocator(CategoryIndex = 0, PropertyIndex = 4)]
	[DisplayName("Custom Message")]
	[Category("General")]
	public string CustomMsg
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

	[Category("Tick Nearness")]
	public bool EnableTickNearness
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

	[Category("Tick Nearness")]
	public int TickNearness
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
	public DeciderInspector()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeciderInspector UpdatePredicate()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeciderInspector()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ViewSubscriber()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeciderInspector AttachGlobalDefinition()
	{
		return null;
	}
}
