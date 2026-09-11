using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Deepchart.DecisionMaking;
using VolAnalysis.Creations;
using VolAnalysis.Wrapping;
using VolumetricaAPI;
using VolumetricaControls;

namespace VolAnalysis.Drivers;

internal class LogicalDriver : Window, IComponentConnector
{
	private class DeciderChooserSelector<T>
	{
		public Dictionary<T, FormatterContainer> calcConsumerMap;

		public bool isSpecStubDecider;

		private static object AttachInterruptibleQueueExtractor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeciderChooserSelector()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DeciderChooserSelector()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RunCollector()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EvaluateStream()
		{
			return null;
		}
	}

	private class FormatterContainer
	{
		public Common.WriterWrapperHandler _ValueRecommender;

		internal static FormatterContainer TrackManager;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FormatterContainer()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormatterContainer()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateLocalProfileEditor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FormatterContainer GenerateConfigurableEditorCache()
		{
			return null;
		}
	}

	private enum ConsumerRequesterState
	{
		Time,
		Daily
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBuildChart_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LogicalDriver _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object SimulateExternalExecutorViewer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CBuildChart_003Ed__41()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAccessibleViewerAdapter()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GeneratePassiveAdapterAttribute()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPlotResults_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LogicalDriver _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object AttachAdaptableAttributeBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CPlotResults_003Ed__45()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ViewAuthorizer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SimulateDynamicCollectorStream()
		{
			return null;
		}
	}

	private ServerDecider _DriverCreator;

	private ResponsiveSingleton _DriverConfiguration;

	private List<Dictionary<DateTime, FormatterContainer>> m_AuthorizerFormatterMap;

	private List<Dictionary<DateTime, FormatterContainer>> _DriverMatcherDic;

	private bool[] driverCompilerItems;

	private bool[] m_ControllableDriverData;

	private bool[] m_ControllerMemberData;

	private TimeSpan hiddenDriver;

	private TimeSpan customizableDriver;

	private int _ConcreteDriverLength;

	private double m_CacheCollector;

	private double _AutomatedDriver;

	private double concreteTester;

	private DateTime _AlphabeticGenerator;

	private DateTime statelessDriver;

	private DateTime m_ErrorProc;

	private bool isIsolatedExtractor;

	private InternalSingletonSingleton monoDriver;

	private bool m_IsSystemVisitor;

	private DateTime sortedRequester;

	private int driverAuditorSize;

	private int _AdaptableReporterRate;

	private int _AccessibleDriverDist;

	private bool m_IsDriverProject;

	private ConsumerRequesterState _ScopeMap;

	private bool m_IsReadableDriver;

	private bool m_IsErrorWriter;

	private bool isDriverDecorator;

	private bool m_IsAdvancedDriver;

	private bool _IsTransferableCalc;

	private bool _IsDriverProxy;

	private bool m_IsTracerField;

	private bool m_IsOrderedDriver;

	private DateTime m_TransformableDriver;

	private DateTime _IteratorProfiler;

	private SingletonHandlerConnection.SetControllerRequester comparatorStrategy;

	private int m_ConfigurableDriverPnts;

	internal IconButton lblSymbol;

	internal ComboBox cmbTf;

	internal Label lblDays;

	internal CheckBox ckbD_1;

	internal CheckBox ckbD_2;

	internal CheckBox ckbD_3;

	internal CheckBox ckbD_4;

	internal CheckBox ckbD_5;

	internal CheckBox ckbD_6;

	internal CheckBox ckbD_7;

	internal CheckBox ckbD_8;

	internal CheckBox ckbD_9;

	internal CheckBox ckbD_10;

	internal CheckBox ckbD_11;

	internal CheckBox ckbD_12;

	internal CheckBox ckbD_13;

	internal CheckBox ckbD_14;

	internal CheckBox ckbD_15;

	internal CheckBox ckbD_16;

	internal CheckBox ckbD_17;

	internal CheckBox ckbD_18;

	internal CheckBox ckbD_19;

	internal CheckBox ckbD_20;

	internal CheckBox ckbD_21;

	internal CheckBox ckbD_22;

	internal CheckBox ckbD_23;

	internal CheckBox ckbD_24;

	internal CheckBox ckbD_25;

	internal CheckBox ckbD_26;

	internal CheckBox ckbD_27;

	internal CheckBox ckbD_28;

	internal CheckBox ckbD_29;

	internal CheckBox ckbD_30;

	internal CheckBox ckbD_31;

	internal Label lblDayOfWeek;

	internal CheckBox ckbDW_1;

	internal CheckBox ckbDW_2;

	internal CheckBox ckbDW_3;

	internal CheckBox ckbDW_4;

	internal CheckBox ckbDW_5;

	internal Label lblMonths;

	internal CheckBox ckbM_1;

	internal CheckBox ckbM_2;

	internal CheckBox ckbM_3;

	internal CheckBox ckbM_4;

	internal CheckBox ckbM_5;

	internal CheckBox ckbM_6;

	internal CheckBox ckbM_7;

	internal CheckBox ckbM_8;

	internal CheckBox ckbM_9;

	internal CheckBox ckbM_10;

	internal CheckBox ckbM_11;

	internal CheckBox ckbM_12;

	internal DateTimePickerControl dtpIniDate;

	internal CheckBox ckbUseEndDate;

	internal DateTimePickerControl dtpEndDate;

	internal TimePickerControl dtpIniTime;

	internal TimePickerControl dtpEndTime;

	internal RadioButton rdbTime;

	internal RadioButton rdbDaily;

	internal RadioButton rdbDay;

	internal RadioButton rdbNone;

	internal RadioButton rdbDayWeek;

	internal RadioButton rdbDayMonth;

	internal RadioButton rdbMonthYear;

	internal RadioButton rdbYear;

	internal ComboBox cmbMetric;

	internal ComboBox cmbUnit;

	internal ComboBox cmbStat;

	internal CheckBox ckbCum;

	internal RadioButton rdbLine;

	internal RadioButton rdbColumn;

	internal RadioButton rdbSpliSame;

	internal RadioButton rdbSplitMulti;

	internal Button btnBuild;

	internal ContentControl cntChrt;

	private bool isConnectedDriver;

	internal static LogicalDriver StartFunction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LogicalDriver(ServerDecider value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBuildChart_003Ed__41))]
	private Task RunOperationalProc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CallStream(SingletonHandlerConnection.SetControllerRequester task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlEditablePredicate(SingletonHandlerConnection.SetControllerRequester def)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTime ControlIntegratedExplorer(DateTime task)
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPlotResults_003Ed__45))]
	private Task ControlStaticSpec()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double SolveSender(FormatterContainer reference)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int RunAutomatedProfiler(DateTime var1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DeciderReceiverAdapter FindDecryptor(float info = 99f, float map = 1f)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunConvertibleStrategy(int position_config, Color pred)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceConnectedRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecompressInitializer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceAutomatableContext()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitAuthorizer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ControlGroupedMonitor(object setup, RoutedEventArgs vis)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceIdentifiableState(object param, RoutedEventArgs counter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunInternalExtractor(object init, MouseButtonEventArgs cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloneTracker(object setup, MouseButtonEventArgs col)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceInterruptibleWatcher(object ident, MouseButtonEventArgs pol)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.1.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int item_low, object reg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private int ControlIterableProfile(DateTime var1, DateTime result)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LogicalDriver()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachStatelessFinder()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LogicalDriver ExecuteField()
	{
		return null;
	}
}
