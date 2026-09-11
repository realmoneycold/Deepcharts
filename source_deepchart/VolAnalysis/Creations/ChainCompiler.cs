using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Deepchart.Management;
using VolAnalysis.CrmModels;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace VolAnalysis.Creations;

internal static class ChainCompiler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoad_003Ed__2<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public LoggerRecord item;

		public object sender;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

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
		static _003CLoad_003Ed__2()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GenerateAttachedIteratorPredicate()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JoinInterpreter()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSave_003Ed__3<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public T data;

		public LoggerRecord item;

		public byte[] image;

		public bool asyncExecution;

		public bool isUserCall;

		public object sender;

		private TaskAwaiter<UserConfigurationResourceHeaderViewModel> _003C_003Eu__1;

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
		static _003CSave_003Ed__3()
		{
			WrapperStreamEditor.AnalyzeRecord();
			WrapperStreamEditor.CoverPortableElement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PeekExtractor()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FlushFinder()
		{
			return null;
		}
	}

	private static string functionStubDescr;

	private static string m_ConnectionSchemaLabel;

	private static ChainCompiler ResumeListener;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoad_003Ed__2<>))]
	public static Task<T> Load<T>(object sender, LoggerRecord item)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSave_003Ed__3<>))]
	public static Task<bool> Save<T>(object sender, LoggerRecord item, T data, byte[] image = null, bool isUserCall = true, bool asyncExecution = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ChainCompiler()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_71c3251926b349349f088dbe00fd81cf != 0)
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 989)
				{
					num = num2;
					break;
				}
				return;
			case 0:
				return;
			case 1:
				WriterCommandResolver.ReflectDefinitionSelector();
				functionStubDescr = WrapperStreamEditor.EncapsulateCommonSynchronizer(-189226311 ^ -1028327935 ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_845ac754e1384440b19ee1152e50ad12);
				m_ConnectionSchemaLabel = WrapperStreamEditor.EncapsulateCommonSynchronizer(0x30F3F4CD ^ _003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_40eea5bdecae4eab88fb94f74d66de22);
				num = 3;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3ea68908a97946f9b64b384edc690658 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PeekDistributor()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ChainCompiler AttachEditableProvider()
	{
		return null;
	}
}
