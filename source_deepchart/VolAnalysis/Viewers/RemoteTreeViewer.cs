using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Viewers;

[ProtoContract]
internal class RemoteTreeViewer : IExtensible
{
	private IExtension scopeBufferViewer;

	[CompilerGenerated]
	private long _CompilerRecordPosition;

	[CompilerGenerated]
	private long templateWatcherErrorCode;

	[CompilerGenerated]
	private long generalTagViewerValue;

	[CompilerGenerated]
	private string viewerParameterSorterName;

	internal static RemoteTreeViewer SetupDecorator;

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long MeasureVisibleArgument
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long PatchConfiguration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long ViewVisualEvaluator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ProtoMember(4)]
	[DefaultValue("")]
	public string AccountId
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
	IExtension IExtensible.GetExtensionObject(bool removeconfig)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoteTreeViewer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RemoteTreeViewer()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateRemoteCheckerTokenizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemoteTreeViewer AttachEfficientTokenizerEvaluator()
	{
		return null;
	}
}
