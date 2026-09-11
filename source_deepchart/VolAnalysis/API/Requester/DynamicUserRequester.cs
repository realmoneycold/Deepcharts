using System.Runtime.CompilerServices;
using System.Windows.Media;
using VolAnalysis.Wrapping;

namespace VolAnalysis.API.Requester;

internal class DynamicUserRequester
{
	[CompilerGenerated]
	private string m_RequesterPolicyQueueTag;

	[CompilerGenerated]
	private Color m_RequesterQueueReceiver;

	internal static DynamicUserRequester SimulateSegmentedFactoryUser;

	public string Name
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

	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (Color)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DynamicUserRequester()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DynamicUserRequester()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachCommonUserLogger()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DynamicUserRequester GenerateControllableLoggerTester()
	{
		return null;
	}
}
