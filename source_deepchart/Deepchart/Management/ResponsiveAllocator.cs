using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class ResponsiveAllocator
{
	[CompilerGenerated]
	private bool isCombinedAllocator;

	[CompilerGenerated]
	private float _AllocatorInspector;

	[CompilerGenerated]
	private float advancedAllocator;

	[CompilerGenerated]
	private float m_ConfigRecord;

	[CompilerGenerated]
	private float m_StateInspector;

	internal static ResponsiveAllocator AttachJoinedParser;

	public bool Visible
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

	public float X
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

	public float Y
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

	public float Width
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

	public float Height
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResponsiveAllocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResponsiveAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateConvertibleProgram()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ResponsiveAllocator AttachConnectedPublisher()
	{
		return null;
	}
}
