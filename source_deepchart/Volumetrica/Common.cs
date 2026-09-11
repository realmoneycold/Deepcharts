using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Deepchart.DecisionMaking;
using Deepchart.Management;
using Microsoft.Win32;
using VolAnalysis.Drivers;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Volumetrica;

internal class Common
{
	internal delegate void TransformableEncryptorAllocator(string Msg, string Title = "", DriverAlignment dialogType = DriverAlignment.None, Window sender = null, TestManagementServiceVersion dialogState = TestManagementServiceVersion.Info, int? p_timerSeconds = null);

	internal delegate bool AllocatorSelectorSchema(string Msg, string Title = "", DriverAlignment dialogType = DriverAlignment.None, Window sender = null, TestManagementServiceVersion dialogState = TestManagementServiceVersion.Info, int? p_timerSeconds = null, string? cancelBtnText = null, string? confirmBtnText = null);

	private static readonly nint _RegMemberObjectPtr;

	private static bool m_IsRegMonitorClient;

	private static double m_AutomatableMatcherReg;

	public static TimeZoneInfo _RegObjectAttribute;

	public static TransformableEncryptorAllocator regClientSet;

	public static AllocatorSelectorSchema adaptableSchemaReg;

	private static long[] _AnalyzerConfigs;

	private static double[] _GroupedResolverRegData;

	internal static Common AttachSymbolicMonitorState;

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostStrategy(nint ident, nint vis, int insert_PROCAt, int connection2_offset, int offsetcol3, int previous_map4, uint cfg5_low);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DefineRecord(nint def, int min_connection, int min_template, int second2, int offset_info3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime StoreOrderedRequester()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveAlphabeticFilter(DataGrid asset, int next_ivk = 0, ListSortDirection c = ListSortDirection.Ascending)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int StoreSegmentedWriter(string key)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveCommonConverter(Point config)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenControllableAggregator(Point v)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SaveRemoteFactory(int end_v, int nextcfg)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CancelConsumer(out DateTime init)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint StoreTransferableLogger(ulong keycount)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double[] NewTag(double key, int position_token, double util = 0.0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int OpenGlobalNode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenDetachedAuditor(int info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveExtendedAuthenticator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveCustomCollection(string def, out int attr)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenAttachedAnnotation(string instance, out string token)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string OpenBasicSummarizer(string asset, string ivk = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ResumeTransformer(string task, int indexOfattr)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int PeekAllocator(string asset, int visitorPosition)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StoreEditableStack(string key, int ivk)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenIntegratedCalc(string spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool PrepareRunner()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenCustomizableThread()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UpdateObserver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveJoinedTask()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RegistryKey PresentController(string ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int StoreConnectedDispatcher()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int StoreExpandableFinalizer(string spec)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveAutomatableResolver(int ident)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DetachWriter(Type task, object reg, string control, object def2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FileStream StartConverter(string v, bool colopen, bool applydic = true, int sum_ivk2 = 4096, bool isspec3 = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] StoreIdentifiableConnection(string i)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ArraySegment<byte> SaveInternalContainer(string param, ref byte[] pol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T FindAncestor<T>(DependencyObject obj) where T : DependencyObject
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyObject SaveAdjustableInspector(DependencyObject setup)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FrameworkElement VerifyLogger(UIElement first, string second)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MenuItem RunTester(ContextMenu info, string second)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MenuItem OpenHiddenMapper(MenuItem asset, string connection)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenModularMatcher(Window first)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int? OpenLocalReporter(string spec)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FileStream StoreConfigurableTransmitter(string config, string attr, out string pool, int counter2max = 3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FileStream CloseAnnotation(string task, string b, int indexOf_consumer = 3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SaveScheduledIterator(double setup, decimal pred)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenMonoPredicate(decimal init, List<ScopeHandlerDecider.EditableControllerDecider> cont)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupEngine(ScopeHandlerDecider.WrapperRequesterTester v)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StoreAccessibleSpec(string spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenPassiveSystem(string res)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FormatDic()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveRandomComparator(string asset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime ProcessMap(DateTime var1, TimeSpan second)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime StoreReadableRecord(DateTime config, TimeZoneInfo reg, TimeZoneInfo state)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double OpenDividedHandler(StringBuilder config)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int OpenIsolatedContext(double value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SaveSeparatedBuffer(decimal first)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int CountResolver(string var1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int LoadEvent(StringBuilder config)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveScopeArgument(string asset)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OpenLogicalConsumer(string reference, string pol, out DateTime state)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime OpenGeneralTemplate(string v, string pred = "dd/MM/yyyy HH:mm:ss.fff", int max_control = 0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TimeSpan SaveResponsiveTag(string key, string selection = "HH:mm:ss.fff", int filter_size = 0)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime SaveSetChecker(StringBuilder task, string ord = "dd/MM/yyyy HH:mm:ss.fff", int helper_offset = 0)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string OpenSortedTokenizer(int index_setup, char cfg = '0')
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double CheckRecommender(double asset, double counter)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double OpenSequentialPool(double reference, double col)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double StoreTransformableTracer(double item, double attr)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] OpenGenericPredictor(DateTime ident)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime StoreSimpleTransformer(byte[] param, int custmin)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DateTime AdaptDecider(BinaryReader var1)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SaveVisualTree(ScopeHandlerDecider.EncryptorMarginProperty def)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string InvokeRequest(ScopeHandlerDecider.ResponsiveSpecGeneratorTypes item)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenActiveRunner(Control spec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Common()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Common()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_85ba16e4dce54edcb3824b8a2ce69527 != 0)
		{
			num = 8;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 9)
				{
					if (num2 == 989)
					{
						goto IL_0013;
					}
					goto case 1;
				}
				_RegMemberObjectPtr = new IntPtr(-1);
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_b662fc1314f140988b34a0144a3464c6 != 0)
				{
					num = 4;
				}
				break;
			case 1:
			{
				WriterCommandResolver.ReflectDefinitionSelector();
				int num3 = 2;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_d31258d3a4894c03ac95c76f9ac2cfba != 0)
				{
					num3 = 9;
				}
				num2 = num3;
				goto IL_0013;
			}
			case 0:
				{
					_RegObjectAttribute = TimeZoneInfo.Local;
					_AnalyzerConfigs = new long[12]
					{
						1L, 10L, 100L, 1000L, 10000L, 100000L, 1000000L, 10000000L, 100000000L, 1000000000L,
						10000000000L, 100000000000L
					};
					_GroupedResolverRegData = new double[13]
					{
						1.0, 0.1, 0.01, 0.001, 0.0001, 1E-05, 1E-06, 1E-07, 1E-08, 1E-09,
						1E-10, 1E-11, 1E-12
					};
					return;
				}
				IL_0013:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachConcreteStateArgument()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Common GenerateCentralArgumentConsumer()
	{
		return null;
	}
}
