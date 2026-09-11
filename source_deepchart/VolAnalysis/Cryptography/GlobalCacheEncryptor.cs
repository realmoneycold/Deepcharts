using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal static class GlobalCacheEncryptor
{
	public static string[] groupedBufferEncryptorElements;

	public static string[] verifierHandlerArray;

	public static Dictionary<ReceiverValue.Feed, string[]> queueRecordMap;

	internal static GlobalCacheEncryptor AttachGlobalTreeGenerator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalCacheEncryptor()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		ReceiverValue.Feed feed = default(ReceiverValue.Feed);
		int num4 = default(int);
		ReceiverValue.Feed[] values = default(ReceiverValue.Feed[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 13 && num2 == 994)
						{
							goto end_IL_0012;
						}
						goto case 2;
					case 6:
						queueRecordMap[feed] = new string[12]
						{
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4D828EEC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fba289398733422f859a60f7abb79212),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x68FB907D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4592ab8348f046599a6c9b4946ce02b4),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E54753 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x486C5C50 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1734725d750c4f95acbd5511d9f0e707),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE8877A9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(-1081762276 ^ -839541817 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_2ea89dc7adc644ac872bdb9b263ac659),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B240E44 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x37AF5A1A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_481904f020864cc4b6606bac6b4a09ef),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319C5A97 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(--1158490401 ^ 0x746723EF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x78643A4E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_bb3801db3d634a8f97973394c9549a6c),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x41780AF1 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aae4aafced0345eba92ee791dabe4490)
						};
						goto IL_05ac;
					case 2:
						if (num4 >= values.Length)
						{
							return;
						}
						goto case 4;
					case 1:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 0;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						feed = values[num4];
						if (feed != ReceiverValue.Feed.VolRT)
						{
							num3 = 11;
							if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 6;
					case 0:
						WrapperStreamEditor.PresentConfiguration();
						WriterCommandResolver.ReflectDefinitionSelector();
						groupedBufferEncryptorElements = new string[12]
						{
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x29E5723D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(--626244216 ^ 0x251DD9B6 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_46e95ad839704ca099af4c1d66957282),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A2D9D2 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9AC20B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(-928601225 ^ -2014638087 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_486bef38c6dc43b2a5d747998dacf8e3),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5190E2DC ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a94928d087944a3a8c0c12288fcb8e70),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AE8099 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x4B24DC34 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3138f03dcd314813a20eb010aba69f0c),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x623188B9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_08dae726799141e1901ebb35e52034f0),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316A0ACE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30A5A658 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_f0747386a46e466ca881dd960833ea64),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1504C32 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ccd483989b5e477dadf241757c38ebb6)
						};
						verifierHandlerArray = new string[12]
						{
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x20954A2A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0xE88DDA9 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_90951de339d84ad683a6674050ecd020),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319D466B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B6370C5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(--160250047 ^ 0x4F4FA40F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_e99229823e2a43a69bc8d17570f6938c),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F33071 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699BEF9B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E92ADFF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x20954B9A ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_44601b03c0d2455aaacef613651d5743),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x360CAE50 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E4588EB ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2),
							WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319D4785 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee)
						};
						num3 = 5;
						continue;
					case 3:
						if (feed != ReceiverValue.Feed.Sphera)
						{
							queueRecordMap[feed] = new string[12]
							{
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F2A28D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5AAB4C03 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_877aca160c5349ef8f66247ed3998e6c),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3A3F9A20 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_7003fd80329c4635b4c85faee4c70335),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6A77A098 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x316ABE66 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x41780AFD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aae4aafced0345eba92ee791dabe4490),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B9BE33D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5644C2BF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4927a804aec14346a37832ec9fd79d32),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(--1158490401 ^ 0x1E9EA40E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c5abe416376142b28cc93d87a3c6e0f5),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7E45226D ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_64fb42df218c4a83b207dfafc0a085d2),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x26AF51DD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_725b7bd8a51b45dfbb4ae5d07cf0363e),
								WrapperStreamEditor.EncapsulateCommonSynchronizer(0x7B637125 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f)
							};
							goto IL_05ac;
						}
						num3 = 6;
						continue;
					case 5:
						break;
						IL_05ac:
						num4++;
						num3 = 3;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_47575d9b57264043a9089ccece41b17e == 0)
						{
							num3 = 2;
						}
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			queueRecordMap = new Dictionary<ReceiverValue.Feed, string[]>();
			values = Enum.GetValues<ReceiverValue.Feed>();
			num4 = 0;
			num = 13;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateDetachedGeneratorRunner()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalCacheEncryptor SimulateExtendedRunnerProject()
	{
		return null;
	}
}
