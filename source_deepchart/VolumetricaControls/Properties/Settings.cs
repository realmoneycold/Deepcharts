using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolumetricaControls.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	internal static Settings AttachSeparatedArgumentConsumer;

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
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 4;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f != 0)
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
		defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateScalableConsumerTemplate()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Settings SimulateVirtualTemplateTag()
	{
		return null;
	}
}
