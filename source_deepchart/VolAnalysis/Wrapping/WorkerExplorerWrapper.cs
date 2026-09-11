using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using Deepchart.Management;
using Deepchart.Registry;
using VolAnalysis.Creations;
using VolAnalysis.IO;
using VolAnalysis.Viewers;
using VolumetricaAPI.Serializer;

namespace VolAnalysis.Wrapping;

internal class WorkerExplorerWrapper
{
	private static JsonSerializerOptions _StatelessListWrapper;

	private static WorkerExplorerWrapper SimulateVirtualRecordHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerExplorerWrapper()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						_StatelessListWrapper.Converters.Add(new AdjustableDeciderReg());
						_StatelessListWrapper.Converters.Add(new DividedThreadWriter());
						_StatelessListWrapper.Converters.Add(new AllocatorListLogger());
						num3 = 2;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_a23f0048ee434ce4927bda4dccce091f != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						_StatelessListWrapper.Converters.Add(new IsolatedFinalizerSingleton());
						_StatelessListWrapper.Converters.Add(new AccessibleProfileViewer());
						return;
					case 0:
						WrapperStreamEditor.PresentConfiguration();
						num3 = 3;
						continue;
					case 1:
						WrapperStreamEditor.CoverPortableElement();
						num3 = 1;
						if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b662fc1314f140988b34a0144a3464c6 == 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						break;
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
			WriterCommandResolver.ReflectDefinitionSelector();
			_StatelessListWrapper = new JsonSerializerOptions
			{
				WriteIndented = true,
				TypeInfoResolver = new AutomatedListSingleton(),
				NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals
			};
			num = 6;
			if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_13c2fdf904b14b4391d71d3a27f00180 != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JsonNode MeasureRunner(XElement info, Type pol = null, bool isrole = false, bool createvis2 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool SplitProject(Type task)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Type WrapRemoteConnection(Type ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static JsonNode WrapEfficientCommand(string reference, Type result)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T WrapTransferableWrapper<T>(string reference)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object EncapsulateLiteralConfig(string v, Type cust)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CoverGlobalConfiguration<T>(string setup, bool getreg = false)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string WrapDetachedRecommender<T>(T res)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CoverExtendedStruct(object task, Type cust)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EncodeConverter<T>(string spec, T b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool JoinFactory(Type key)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<PropSaveClass> ResumeUser(object i, bool isvisitor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<PropSaveClass> PeekLogger(object v, bool createmap)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<PropSaveClass> FlushTester(object spec, bool isvis)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WrapIntegratedChain(string asset, object selection, bool skipdir = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<PropSaveClass> PrepareAuditor(object task, bool iscounter = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CoverCustomizableListener<T>(List<PropSaveClass> config, T vis, bool ishelper = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object EncapsulateAutomatedDistributor(List<PropSaveClass> info, Type col, bool appendtag = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T BuildAnnotation<T>(List<PropSaveClass> spec, bool ispred = false)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object PresentSummarizer(Type config, List<PropSaveClass> selection, bool evaluateproc = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetDictionary<T>(string task, bool iscaller = false)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T RemoveEngine<T>(T setup, bool usevis = false)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T EncapsulateAutomatableEncryptor<T>(T key, bool removeselection = false)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DetachCalc<T>(T reference, T b, bool includethird = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CoverGroupedFunction(object setup, List<PropSaveClass> token, bool outpututil)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EncapsulateIdentifiableReceiver(object res, List<PropSaveClass> b, bool gettemp = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WorkerExplorerWrapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachScopeHandlerContext()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WorkerExplorerWrapper SimulateLogicalContextBuffer()
	{
		return null;
	}
}
