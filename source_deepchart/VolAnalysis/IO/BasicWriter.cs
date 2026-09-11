using System.Runtime.CompilerServices;
using System.Threading;
using VolAnalysis.Wrapping;

namespace VolAnalysis.IO;

internal static class BasicWriter
{
	internal static CancellationTokenSource _WriterCalc;

	internal static SemaphoreSlim finderSharer;

	internal static Lock _AggregatorCreator;

	private static bool m_IsSolverAnalyzer;

	private static bool m_IsSetWriter;

	private static BasicWriter DecodeElement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool WriteCommonService()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static void RecordControllableSchema(bool isparam)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static bool RecordEfficientTracker()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal static void FormatComparator(bool isv)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BasicWriter()
	{
		WrapperStreamEditor.AnalyzeRecord();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0012;
					}
					goto case 0;
				case 1:
					WrapperStreamEditor.CoverPortableElement();
					num2 = 0;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_3df83f77032d4ee0900e7546d970a13f != 0)
					{
						num2 = 5;
					}
					break;
				case 0:
					WrapperStreamEditor.PresentConfiguration();
					WriterCommandResolver.ReflectDefinitionSelector();
					_WriterCalc = new CancellationTokenSource();
					finderSharer = new SemaphoreSlim(1);
					num2 = 5;
					if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_10626ce2002c4909aed2c06dd7abb3d4 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					_AggregatorCreator = new Lock();
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SimulateDetailedSolver()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BasicWriter StartEncryptor()
	{
		return null;
	}
}
