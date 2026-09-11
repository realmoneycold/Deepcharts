using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Deepchart.DecisionMaking;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Cryptography;

internal class CommonSenderEncryptor
{
	private static Hashtable _AlphabeticInitializerEncryptor;

	private static Hashtable adaptableDeciderEncryptor;

	private static Hashtable m_ScheduledControllerEncryptor;

	private static bool isContextObserver;

	private static bool _IsEncryptorObserverDecryptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lLHifFIsCLsZtjvFfN0i()
	{
		if (!_IsEncryptorObserverDecryptor)
		{
			int num = 74565;
			_IsEncryptorObserverDecryptor = true;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			isContextObserver = num == 1193046;
			currentDomain.AssemblyResolve += DeleteEvaluator;
			WriterCommandResolver.ReflectDefinitionSelector();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly DeleteEvaluator(object key, ResolveEventArgs cust)
	{
		lock (_AlphabeticInitializerEncryptor)
		{
			string text = cust.Name.Trim();
			object obj = _AlphabeticInitializerEncryptor[text];
			if (obj == null)
			{
				try
				{
					string text2 = CheckSeparatedCommand(text);
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly in assemblies)
					{
						if (assembly.GetName().Name.ToUpper() == text2.ToUpper())
						{
							if (!isContextObserver)
							{
								return assembly;
							}
							if (text.Contains(assembly.GetName().Version.ToString()))
							{
								return assembly;
							}
						}
					}
				}
				catch
				{
				}
			}
			if (obj == null)
			{
				try
				{
					RSACryptoServiceProvider.UseMachineKeyStore = true;
					string text3 = CheckSeparatedCommand(text);
					string text4 = (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? WrapperStreamEditor.EncapsulateCommonSynchronizer(0x556F184E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_78cc182abdb84b4a9b967cb4df53fd80) : (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? WrapperStreamEditor.EncapsulateCommonSynchronizer(0x3E91067B ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_50b6686643c0435a864c66b8b6b4d7ed) : ((!RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !RuntimeInformation.IsOSPlatform(OSPlatform.Create(WrapperStreamEditor.EncapsulateCommonSynchronizer(0x1F52579F ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_fa88bc87aed54be9ad541e6eb6088ee7)))) ? WrapperStreamEditor.EncapsulateCommonSynchronizer(0x742AD092 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333) : WrapperStreamEditor.EncapsulateCommonSynchronizer(0x52A0A02E ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_ad988de0321245748764c114d1eb58f7))));
					string text5 = text4.ToString();
					text5 = ((IntPtr.Size != 8) ? (text5 + WrapperStreamEditor.EncapsulateCommonSynchronizer(0x319EED61 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d23bc6a4d9924263a3fe2278d6a2baee)) : (text5 + WrapperStreamEditor.EncapsulateCommonSynchronizer(0x2F4B3FBF ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_6a268b5872564c18954b160ecf04500e)));
					string text6 = WrapperStreamEditor.EncapsulateCommonSynchronizer(0x42AE18BE ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_624b474964114179bb2ea3d4c0497999) + Convert.ToBase64String(WrapperStreamEditor.JoinDispatcher(Encoding.Unicode.GetBytes(text3)));
					string name = WrapperStreamEditor.EncapsulateCommonSynchronizer(0x699844A5 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616) + Convert.ToBase64String(WrapperStreamEditor.JoinDispatcher(Encoding.Unicode.GetBytes(text3 + text4)));
					string name2 = WrapperStreamEditor.EncapsulateCommonSynchronizer(0x6A740BE4 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f) + Convert.ToBase64String(WrapperStreamEditor.JoinDispatcher(Encoding.Unicode.GetBytes(text3 + text5)));
					Stream manifestResourceStream = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556850)).Assembly.GetManifestResourceStream(name2);
					if (manifestResourceStream == null)
					{
						manifestResourceStream = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556850)).Assembly.GetManifestResourceStream(name);
					}
					if (manifestResourceStream == null)
					{
						manifestResourceStream = Type.GetTypeFromHandle(DeciderProviderCreator.GeneratePortableTesterNode(33556850)).Assembly.GetManifestResourceStream(text6);
					}
					if (manifestResourceStream != null)
					{
						try
						{
							WrapperStreamEditor.ReadableGatewayEncryptor readableGatewayEncryptor = new WrapperStreamEditor.ReadableGatewayEncryptor(manifestResourceStream);
							readableGatewayEncryptor.BjD0Mdo690().Position = 0L;
							byte[] array = new byte[manifestResourceStream.Length];
							readableGatewayEncryptor.EncryptRandomFinalizer(array, 0, array.Length);
							readableGatewayEncryptor.MoveChecker();
							bool flag = false;
							Assembly assembly2 = null;
							try
							{
								assembly2 = Assembly.Load(array);
							}
							catch (FileLoadException)
							{
								flag = true;
							}
							catch (BadImageFormatException)
							{
								flag = true;
							}
							if (flag)
							{
								string text7 = adaptableDeciderEncryptor[text6] as string;
								if (text7 == null)
								{
									text7 = WrapperStreamEditor.EncapsulateCommonSynchronizer(0x69984485 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1612b9924ad849609afe1e85493cd616) + Convert.ToBase64String(WrapperStreamEditor.JoinDispatcher(array));
									adaptableDeciderEncryptor.Add(text6, text7);
								}
								string text8 = Path.Combine(Path.Combine(Path.GetTempPath(), text7.ToString()), text3 + WrapperStreamEditor.EncapsulateCommonSynchronizer(0x5FE45382 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_cd88cb71dc7b44ebbd7083c10fa12938));
								if (!File.Exists(text8) || !m_ScheduledControllerEncryptor.ContainsKey(text8))
								{
									try
									{
										m_ScheduledControllerEncryptor[text8] = null;
										if (!Directory.Exists(Path.GetDirectoryName(text8)))
										{
											Directory.CreateDirectory(Path.GetDirectoryName(text8));
										}
										FileStream fileStream = new FileStream(text8, FileMode.Create, FileAccess.Write);
										fileStream.Write(array, 0, array.Length);
										fileStream.Close();
									}
									catch
									{
									}
								}
								assembly2 = Assembly.LoadFile(text8);
								_AlphabeticInitializerEncryptor.Add(text, assembly2);
							}
							else
							{
								_AlphabeticInitializerEncryptor.Add(text, assembly2);
							}
							return assembly2;
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				return null;
			}
			return (Assembly)obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string CheckSeparatedCommand(string config)
	{
		string text = config.Trim();
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CommonSenderEncryptor()
	{
		WrapperStreamEditor.PresentConfiguration();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CommonSenderEncryptor()
	{
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		_AlphabeticInitializerEncryptor = new Hashtable();
		adaptableDeciderEncryptor = new Hashtable();
		m_ScheduledControllerEncryptor = new Hashtable();
		isContextObserver = false;
		_IsEncryptorObserverDecryptor = false;
	}
}
