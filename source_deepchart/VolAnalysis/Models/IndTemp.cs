using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Cryptography;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Serializer;

namespace VolAnalysis.Models;

[Serializable]
internal class IndTemp
{
	private static IndTemp SimulateCustomizableProvider;

	public List<PropSaveClass> paramProp
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

	public List<EncryptorCacheBuffer.Series_Prop> seriesProp
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
	public IndTemp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndTemp()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UpdateElement()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IndTemp AttachJoinedProgram()
	{
		return null;
	}
}
