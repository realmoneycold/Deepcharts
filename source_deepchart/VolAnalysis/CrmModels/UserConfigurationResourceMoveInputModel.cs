using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserConfigurationResourceMoveInputModel
{
	private static UserConfigurationResourceMoveInputModel EnableOrder;

	public Guid ResourceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Guid)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public Guid? ParentId
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
	public UserConfigurationResourceMoveInputModel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserConfigurationResourceMoveInputModel()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EncryptListener()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserConfigurationResourceMoveInputModel EncodeDistributor()
	{
		return null;
	}
}
