using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal class AllocatorCompilerEvent<T>
{
	internal enum Disposition
	{

	}

	[CompilerGenerated]
	private sealed class _003CGetKeyValuesCond_003Ed__40 : IEnumerable<KeyValuePair<int, T>>, IEnumerable, IEnumerator<KeyValuePair<int, T>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<int, T> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int StartPrice;

		public int _003C_003E3__StartPrice;

		private Disposition p_dir;

		public Disposition _003C_003E3__p_dir;

		private bool includeEquals;

		public bool _003C_003E3__includeEquals;

		private int _003CindHigh_003E5__2;

		private int _003CindLow_003E5__3;

		private int _003CmaxHigh_003E5__4;

		private int _003CmaxLow_003E5__5;

		private int _003Ck_003E5__6;

		internal static object GenerateExternalIteratorPredicate;

		KeyValuePair<int, T> IEnumerator<KeyValuePair<int, T>>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (KeyValuePair<int, T>)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetKeyValuesCond_003Ed__40(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<int, T>> IEnumerable<KeyValuePair<int, T>>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CGetKeyValuesCond_003Ed__40()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SimulateAccessiblePredicateExplorer()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RateTransmitter()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetValuesCond_003Ed__41 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int StartPrice;

		public int _003C_003E3__StartPrice;

		private Disposition p_dir;

		public Disposition _003C_003E3__p_dir;

		private bool includeEquals;

		public bool _003C_003E3__includeEquals;

		private int _003CindHigh_003E5__2;

		private int _003CindLow_003E5__3;

		private int _003CmaxHigh_003E5__4;

		private int _003CmaxLow_003E5__5;

		private int _003Ck_003E5__6;

		internal static object FormatProc;

		T IEnumerator<T>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetValuesCond_003Ed__41(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CGetValuesCond_003Ed__41()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ViewIterator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateDynamicProfilerComparator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_KeyValues_003Ed__38 : IEnumerable<KeyValuePair<int, T>>, IEnumerable, IEnumerator<KeyValuePair<int, T>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<int, T> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int _003Ck_003E5__2;

		private static object SimulateReadableComparatorStrategy;

		KeyValuePair<int, T> IEnumerator<KeyValuePair<int, T>>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (KeyValuePair<int, T>)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003Cget_KeyValues_003Ed__38(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<int, T>> IEnumerable<KeyValuePair<int, T>>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003Cget_KeyValues_003Ed__38()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachDividedStrategyRecord()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WatchSystem()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_SortedHLValues_003Ed__36 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int _003Ck_003E5__2;

		private static object AttachSeparatedHandlerContext;

		T IEnumerator<T>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003Cget_SortedHLValues_003Ed__36(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003Cget_SortedHLValues_003Ed__36()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CountComparator()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoadStrategy()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_SortedLHValues_003Ed__34 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int _003Ck_003E5__2;

		private static object SimulateScopeMonitorState;

		T IEnumerator<T>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003Cget_SortedLHValues_003Ed__34(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003Cget_SortedLHValues_003Ed__34()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SerializeHandler()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GenerateGeneralArgumentConsumer()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_Values_003Ed__32 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public AllocatorCompilerEvent<T> _003C_003E4__this;

		private int _003Ck_003E5__2;

		private static object WriteBuffer;

		T IEnumerator<T>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003Cget_Values_003Ed__32(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003Cget_Values_003Ed__32()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AttachSetTemplateTag()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VisitState()
		{
			return null;
		}
	}

	private T[] mixedProcessorAllocatorElements;

	private T[] m_AllocatorExtractorDistributorData;

	private int _AdjustableRegAllocatorOffset;

	private int _RequesterStackCheckerNum;

	private int _JoinedUserLevel;

	private int m_AllocatorQueueMemberStep;

	private int allocatorEventServerFreq;

	private int _DistributorRequesterAllocatorDist;

	private int m_MemberReporterAllocatorTotal;

	private bool _IsChooserSchema;

	private int _AllocatorServerThreadTotal;

	private static object PrepareLocator;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public T this[int referencemax]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (T)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int FinalizeRandomRunner()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public int ReleaseReadableObserver()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AllocatorCompilerEvent(bool islast = true, int indexreg = 4, int rulemax = 4)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(int p_key, T p_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(int Key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReflectPool(int tasksize, out T vis)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReleaseModularChecker(int setupLow)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int AssignLocalTokenizer(int idxres, int pred_count)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int CustomizeTransformer(int ident_High, int next_reg, out int proc)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllocateMixedPool(int rowitem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseScheduledTracer(ref T[] var1, int tokenPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003Cget_Values_003Ed__32))]
	public IEnumerable<T> JoinAggregator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003Cget_SortedLHValues_003Ed__34))]
	public IEnumerable<T> AllocateScopeWriter()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003Cget_SortedHLValues_003Ed__36))]
	public IEnumerable<T> MatchTester()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003Cget_KeyValues_003Ed__38))]
	public IEnumerable<KeyValuePair<int, T>> SelectAuditor()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003CGetKeyValuesCond_003Ed__40))]
	public IEnumerable<KeyValuePair<int, T>> MeasureGenerator(int def_max, Disposition caller, bool isc = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(AllocatorCompilerEvent<>._003CGetValuesCond_003Ed__41))]
	public IEnumerable<T> AssignExternalTransformer(int versionres, Disposition token, bool deletepool = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T ReleaseAccessibleAllocator(int positioninit)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T CancelObserver(int ID_spec)
	{
		return (T)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AllocatorCompilerEvent()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateCustomizableDictionaryEngine()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AttachAutomatedEngineStack()
	{
		return null;
	}
}
