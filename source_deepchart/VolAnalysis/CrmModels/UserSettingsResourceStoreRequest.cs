using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserSettingsResourceStoreRequest
{
	private static UserSettingsResourceStoreRequest CombineAuditor;

	public UserSettingsResourceTypeEnum Resource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (UserSettingsResourceTypeEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserSettingsResourceStoreRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserSettingsResourceStoreRequest()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateVirtualExtractorFinder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserSettingsResourceStoreRequest AttachScopeFinderWatcher()
	{
		return null;
	}
}
