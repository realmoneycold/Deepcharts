using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	private static Settings GenerateCommonStream;

	public static Settings Default
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Settings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Settings()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 0;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_60156e5c0ec94000a5cf1a08286d7c69 != 0)
		{
			num = 0;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 988)
				{
					goto IL_0013;
				}
				break;
			case 0:
				break;
			}
			break;
			IL_0013:
			num = num2;
		}
		WriterCommandResolver.ReflectDefinitionSelector();
		defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReplaceGenerator()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Settings AttachRemoteMember()
	{
		return null;
	}
}
