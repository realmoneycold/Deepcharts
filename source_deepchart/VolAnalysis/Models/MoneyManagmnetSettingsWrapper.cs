using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Models;

[Serializable]
internal class MoneyManagmnetSettingsWrapper
{
	private static MoneyManagmnetSettingsWrapper AttachDetailedCache;

	public List<MoneyManagmentAccountSettings> CurrentSettings
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

	public List<MoneyManagmnetSettingsScheduleWrapper> Schedule
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
	public MoneyManagmnetSettingsWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MoneyManagmnetSettingsWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool StartSynchronizer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MoneyManagmnetSettingsWrapper ScanSingleton()
	{
		return null;
	}
}
