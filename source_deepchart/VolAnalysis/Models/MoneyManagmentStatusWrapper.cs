using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Models;

[Serializable]
internal class MoneyManagmentStatusWrapper
{
	internal static MoneyManagmentStatusWrapper AttachAdvancedStream;

	public List<MonenyManagmentStatusAccount> AccountsStatus
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
	public MoneyManagmentStatusWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MoneyManagmentStatusWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateOrderedManager()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MoneyManagmentStatusWrapper CloseFinder()
	{
		return null;
	}
}
