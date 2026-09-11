using System.ComponentModel;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class TransactionRequester : INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler m_ChooserConnection;

	private string encryptorRequesterContent;

	private string m_RequesterAuthenticatorText;

	private static TransactionRequester SimulateHiddenSharer;

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

	public string FileName
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TransactionRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TransactionRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AddTracer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TransactionRequester AssessPredictor()
	{
		return null;
	}
}
