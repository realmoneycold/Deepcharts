using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserConfigurationWrapperViewModel
{
	internal static UserConfigurationWrapperViewModel IncludeDic;

	public List<UserConfigurationFolderHeaderViewModel> Folders
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

	public List<UserConfigurationResourceHeaderViewModel> Resources
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
	public UserConfigurationWrapperViewModel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserConfigurationWrapperViewModel()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReceiveThread()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserConfigurationWrapperViewModel GenerateGenericAdapterAttribute()
	{
		return null;
	}
}
