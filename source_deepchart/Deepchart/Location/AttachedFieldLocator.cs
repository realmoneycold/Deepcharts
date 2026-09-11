using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace Deepchart.Location;

[ProtoContract]
internal class AttachedFieldLocator : IExtensible
{
	[ProtoContract]
	internal enum ViewerXlReferenceStyle
	{
		[ProtoEnum(Name = "FLAT")]
		Flat,
		[ProtoEnum(Name = "CANCEL")]
		Cancel,
		[ProtoEnum(Name = "FLAT_CANCEL")]
		viewerMonitorConnection
	}

	private IExtension _InterruptibleProcessorLocator;

	[CompilerGenerated]
	private string adjustableSynchronizerLocatorStr;

	[CompilerGenerated]
	private long[] locatorChooserCreators;

	[CompilerGenerated]
	private ViewerXlReferenceStyle scopeEncryptorLocator;

	internal static AttachedFieldLocator SimulateMonoSetServer;

	[ProtoMember(1)]
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

	[ProtoMember(/*Could not decode attribute arguments.*/)]
	public long[] IdentifyGlobalAggregator
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

	[ProtoMember(3)]
	public ViewerXlReferenceStyle DeleteServer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ViewerXlReferenceStyle)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool ignoreitem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AttachedFieldLocator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttachedFieldLocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachExternalServerModule()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AttachedFieldLocator AttachAccessibleModuleDecorator()
	{
		return null;
	}
}
