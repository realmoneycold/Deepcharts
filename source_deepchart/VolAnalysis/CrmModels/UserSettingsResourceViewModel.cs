using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserSettingsResourceViewModel
{
	private static UserSettingsResourceViewModel SaveLogger;

	public string Link
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
	public UserSettingsResourceViewModel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserSettingsResourceViewModel()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DeleteTester()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserSettingsResourceViewModel SimulateSeparatedInterpreterQueue()
	{
		return null;
	}
}
