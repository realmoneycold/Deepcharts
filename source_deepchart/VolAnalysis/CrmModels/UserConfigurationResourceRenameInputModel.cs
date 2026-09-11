using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserConfigurationResourceRenameInputModel
{
	private static UserConfigurationResourceRenameInputModel FilterCreator;

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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserConfigurationResourceRenameInputModel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserConfigurationResourceRenameInputModel()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateBasicPublisherParameter()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserConfigurationResourceRenameInputModel SimulateOperationalParameterProxy()
	{
		return null;
	}
}
