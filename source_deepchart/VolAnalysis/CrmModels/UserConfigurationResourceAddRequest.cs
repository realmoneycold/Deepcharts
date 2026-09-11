using System;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace VolAnalysis.CrmModels;

[Serializable]
internal class UserConfigurationResourceAddRequest
{
	internal static UserConfigurationResourceAddRequest PlayObject;

	public Guid? FolderId
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

	public string Category
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserConfigurationResourceAddRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserConfigurationResourceAddRequest()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateLiteralListLocator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserConfigurationResourceAddRequest SimulateGlobalLocatorVerifier()
	{
		return null;
	}
}
