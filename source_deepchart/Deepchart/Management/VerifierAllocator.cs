using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Threading;
using Deepchart.Location;
using VolAnalysis.Drivers;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

namespace Deepchart.Management;

internal static class VerifierAllocator
{
	private static object m_StrategyAllocatorObj;

	public static ObservableCollection<WriterEvaluator> _HandlerAllocator;

	public static ObservableCollection<WriterEvaluator> m_TransferableAllocator;

	internal static Dispatcher m_AutomatedIterator;

	private static VerifierAllocator AttachVirtualCalculator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VerifierAllocator()
	{
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		int num = 1;
		if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c88679d8ea9744a2b513c895acb6ada3 != 0)
		{
			num = 1;
		}
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num3 != 9)
				{
					if (num3 != 989)
					{
						break;
					}
					goto IL_0013;
				}
				_HandlerAllocator = new ObservableCollection<WriterEvaluator>();
				num = 0;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_1cf7c7250fd04150b2cea2d18122be7f == 0)
				{
					num = 2;
				}
				continue;
			case 1:
			{
				WriterCommandResolver.ReflectDefinitionSelector();
				m_StrategyAllocatorObj = new object();
				int num2 = 9;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3ea68908a97946f9b64b384edc690658 != 0)
				{
					num2 = 6;
				}
				num3 = num2;
				goto IL_0013;
			}
			case 0:
				break;
				IL_0013:
				num = num3;
				continue;
			}
			break;
		}
		m_TransferableAllocator = new ObservableCollection<WriterEvaluator>();
		BindingOperations.EnableCollectionSynchronization((IEnumerable)_HandlerAllocator, m_StrategyAllocatorObj);
		BindingOperations.EnableCollectionSynchronization((IEnumerable)m_TransferableAllocator, m_StrategyAllocatorObj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReleaseTransformableDecorator(ReceiverValue.Feed v, string b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AssignGenericValidator(LocatorSelectorTransaction last, string pred, SequentialProjectDriverState field, bool? item2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AssignSimpleReg(string param, SequentialProjectDriverState attr = (SequentialProjectDriverState)1, string helper = null, bool? value2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AssignDetailedFormatter(Exception item, SequentialProjectDriverState result = (SequentialProjectDriverState)3, string rule = null, bool? counter2 = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SortSummarizer(SequentialProjectDriverState res, string connection, bool? serv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AttachScopeAnalyzer()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VerifierAllocator FlushDistributor()
	{
		return null;
	}
}
