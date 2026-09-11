using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Deepchart.DecisionMaking;
using Deepchart.Registry;
using VolAnalysis.IO;

namespace VolAnalysis.Wrapping;

internal class WrapperSender : DeciderAuthorizerNotifier
{
	[CompilerGenerated]
	private readonly string automatableWrapperMsg;

	private string _WrapperFactoryDescr;

	private ReceiverValue.RegWLanProfileConnectionType m_WrapperClient;

	private string matcherWrapperStr;

	private double basicParser;

	private double m_WrapperRole;

	[CompilerGenerated]
	private ObservableCollection<SchemaDecryptor> _WrapperInspector;

	private static WrapperSender StopService;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public ReceiverValue.RegWLanProfileConnectionType Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ReceiverValue.RegWLanProfileConnectionType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Currency
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double DailyPl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double OpenPl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public ObservableCollection<SchemaDecryptor> Accounts
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
	[SpecialName]
	[CompilerGenerated]
	public string CoverReadableList()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WrapperSender(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperSender()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdaptSchema()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WrapperSender AttachGroupedValidator()
	{
		return null;
	}
}
