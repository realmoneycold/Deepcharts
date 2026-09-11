using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;
using VolumetricaAPI.Serializer;

namespace VolAnalysis.Models;

[Serializable]
internal class DomTemplateItemClass
{
	internal static DomTemplateItemClass CheckDefinition;

	public List<PropSaveClass> XMLPropDom
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

	public List<PropSaveClass> XMLPropVbp
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

	public WrapperTextBoxMode? CurrentTheme
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
	public DomTemplateItemClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DomTemplateItemClass()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GenerateSequentialExtractor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DomTemplateItemClass SimulateTransformableFinder()
	{
		return null;
	}
}
