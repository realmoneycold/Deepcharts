using System.Runtime.CompilerServices;
using Deepchart.Registry;
using ProtoBuf;
using VolAnalysis.API.Requester;
using VolAnalysis.Creations;
using VolAnalysis.Drivers;
using VolAnalysis.Viewers;

namespace VolAnalysis.Wrapping;

[ProtoContract]
internal class IsolatedTransactionWrapper : IExtensible
{
	private IExtension _OrderManager;

	[CompilerGenerated]
	private ControllerConverter m_WrapperReceiverAdapter;

	[CompilerGenerated]
	private FilteredErrorDriver m_SpecSorter;

	[CompilerGenerated]
	private ModularModelReg _WrapperAdapterVerifier;

	[CompilerGenerated]
	private RequesterManagerWrapper activeValidatorWrapper;

	[CompilerGenerated]
	private ConnectionTracerRequester distributorStrategy;

	[CompilerGenerated]
	private RemoteTreeViewer m_WrapperVerifierTransaction;

	[CompilerGenerated]
	private IntegratedBridgeSingleton m_ServiceDispatcher;

	[CompilerGenerated]
	private CalculatorCompilerRequester wrapperTransactionValidator;

	internal static IsolatedTransactionWrapper SimulateRandomValidatorReg;

	[ProtoMember(1)]
	public ControllerConverter WrapInterruptibleReg
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

	[ProtoMember(2)]
	public FilteredErrorDriver PostExplorer
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
	public ModularModelReg SearchProfiler
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

	[ProtoMember(4)]
	public RequesterManagerWrapper EncapsulateExternalError
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

	[ProtoMember(5)]
	public ConnectionTracerRequester PlayBuffer
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

	[ProtoMember(6)]
	public RemoteTreeViewer EncapsulateReadableIterator
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

	[ProtoMember(7)]
	public IntegratedBridgeSingleton CheckSeparatedSpec
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

	[ProtoMember(8)]
	public CalculatorCompilerRequester CoverScopeComparator
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
	IExtension IExtensible.GetExtensionObject(bool readvar1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IsolatedTransactionWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IsolatedTransactionWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InterruptAdapter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IsolatedTransactionWrapper EnableAttribute()
	{
		return null;
	}
}
