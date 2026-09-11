using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

[ProtoContract]
internal class ViewerSorterValidator : IExtensible
{
	private IExtension viewerValidatorExecutor;

	[CompilerGenerated]
	private bool _IsViewerExecutorSingleton;

	private static ViewerSorterValidator MergePolicy;

	[ProtoMember(1)]
	public bool ViewControllableModel
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
	IExtension IExtensible.GetExtensionObject(bool canfirst)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViewerSorterValidator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViewerSorterValidator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InsertSorter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ViewerSorterValidator GenerateCustomAllocatorTree()
	{
		return null;
	}
}
