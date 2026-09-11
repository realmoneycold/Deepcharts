using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Models;

[Serializable]
internal class MoneyManagmnetSettingsScheduleWrapper
{
	private static MoneyManagmnetSettingsScheduleWrapper GetFunction;

	public MoneyManagmentAccountSettings Settings
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

	public DateTime ExpireUtc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoneyManagmnetSettingsScheduleWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MoneyManagmnetSettingsScheduleWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RemoveReceiver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MoneyManagmnetSettingsScheduleWrapper SimulateSimpleEditor()
	{
		return null;
	}
}
