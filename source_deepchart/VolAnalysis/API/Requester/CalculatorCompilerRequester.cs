using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProtoBuf;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

[ProtoContract]
internal class CalculatorCompilerRequester : IExtensible
{
	private IExtension m_IntegratedDecoratorRequester;

	[CompilerGenerated]
	private string m_ClientServiceName;

	[CompilerGenerated]
	private long _ExplorerClientScore;

	[CompilerGenerated]
	private long _RandomMapperRequesterNum;

	internal static CalculatorCompilerRequester SimulateTransferableEvaluatorPool;

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
	public long QueryCentralGenerator
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
	public long PauseTracker
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	IExtension IExtensible.GetExtensionObject(bool stripinit)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CalculatorCompilerRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CalculatorCompilerRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachLiteralPoolTracer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CalculatorCompilerRequester AttachGlobalTracerPredictor()
	{
		return null;
	}
}
