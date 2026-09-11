using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Deepchart.Location;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class FilterRequester : INotifyPropertyChanged
{
	private LocatorStateAction requesterElement;

	private string separatedRequesterTitle;

	private Visibility _IteratorEvaluator;

	private double _RequesterParameter;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_EditableRequester;

	private static FilterRequester AttachMonoCreator;

	public LocatorStateAction Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LocatorStateAction)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Message
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

	public Visibility ProgressBarVisibility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double ProgressValue
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
	public FilterRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SplitConfig()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FilterRequester LeadConfiguration()
	{
		return null;
	}
}
