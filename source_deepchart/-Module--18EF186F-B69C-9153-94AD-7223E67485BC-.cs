using System.Runtime.CompilerServices;
using VolAnalysis.API.Requester;
using VolAnalysis.IO;
using VolAnalysis.Wrapping;

internal class _003CModule_003E_007B18EF186F_002DB69C_002D9153_002D94AD_002D7223E67485BC_007D
{
	public static byte getContextILegacyEvidenceAdapter;

	private static _003CModule_003E_007B18EF186F_002DB69C_002D9153_002D94AD_002D7223E67485BC_007D InstantiateTokenizerEvaluator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	unsafe static _003CModule_003E_007B18EF186F_002DB69C_002D9153_002D94AD_002D7223E67485BC_007D()
	{
		//The blocks IL_000f, IL_0013, IL_0017, IL_0088, IL_0096, IL_00ed, IL_00fd, IL_0110, IL_011d, IL_0161, IL_017e, IL_018c, IL_01a0, IL_01c2, IL_0200, IL_020e, IL_0218, IL_025e, IL_0293, IL_029e, IL_02cc, IL_02df, IL_0301, IL_030c, IL_031f, IL_032e, IL_0338, IL_036a, IL_0375, IL_0388, IL_039b, IL_03ae, IL_045b, IL_048e, IL_049c, IL_050c, IL_0517, IL_0525, IL_0539, IL_0585, IL_05b1, IL_05e2, IL_05fa are reachable both inside and outside the pinned region starting at IL_0145. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		WrapperStreamEditor.AnalyzeRecord();
		WrapperStreamEditor.CoverPortableElement();
		WrapperStreamEditor.PresentConfiguration();
		WriterCommandResolver.ReflectDefinitionSelector();
		int num = 1;
		int num2 = *(sbyte*)(&num);
		int num3 = 25;
		int num7 = default(int);
		byte b = default(byte);
		int num4 = default(int);
		byte[] array8 = default(byte[]);
		object[] array9 = default(object[]);
		int num8 = default(int);
		int num6 = default(int);
		sbyte[] array3 = default(sbyte[]);
		long[] array6 = default(long[]);
		object[] array7 = default(object[]);
		byte* ptr2 = default(byte*);
		while (true)
		{
			ref sbyte reference;
			int num5;
			switch (num3)
			{
			default:
				if (num7 != 34)
				{
					if (num7 == 1014)
					{
						goto IL_0013;
					}
					goto case 3;
				}
				goto case 15;
			case 13:
				b = *ptr2;
				num3 = 14;
				break;
			case 6:
				return;
			case 21:
				ptr2 += 8;
				num4--;
				goto case 15;
			case 0:
				ptr2 += 8;
				num3 = 17;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708 == 0)
				{
					num3 = 6;
				}
				break;
			case 19:
				if (1 < b)
				{
					if (2 < b || 2 > b)
					{
						goto case 1;
					}
					num3 = 11;
					break;
				}
				num3 = 12;
				break;
			case 22:
				array8 = new byte[1];
				array9 = new object[1];
				num3 = 24;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803 == 0)
				{
					num3 = 6;
				}
				break;
			case 5:
			case 11:
				array9[num4 - 1] = new object[*(int*)Unsafe.AsPointer(ref array6[num4 - 1])];
				array8[num4 - 1] = 5;
				num3 = 15;
				break;
			case 14:
				ptr2++;
				if (b >= 1 && b <= 5)
				{
					if (3 < b)
					{
						goto case 18;
					}
					if (3 <= b)
					{
						goto case 23;
					}
					goto case 19;
				}
				goto case 1;
			case 3:
				ptr2 += 8;
				num3 = 7;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333 == 0)
				{
					num3 = 21;
				}
				break;
			case 15:
			case 17:
			case 20:
				if (num8 == 1)
				{
					num3 = 6;
					break;
				}
				goto case 13;
			case 23:
				array7[*(int*)(ptr2 + num6)] = array9[num4 - 1];
				num3 = 21;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_750f724efa0642d1a1bee294e56e9147 != 0)
				{
					num3 = 2;
				}
				break;
			case 12:
				if (1 > b)
				{
				}
				goto case 1;
			case 8:
				num8 = 1;
				goto case 15;
			case 9:
			case 16:
				reference = ref array3[*(int*)(ptr2 + num6)];
				reference = (sbyte)(*(int*)Unsafe.AsPointer(ref array6[num4 - 1]));
				num3 = 3;
				break;
			case 18:
				if (4 < b)
				{
					if (5 < b || 5 > b)
					{
						goto case 1;
					}
					goto case 8;
				}
				num5 = 2;
				goto IL_000f;
			case 2:
				if (4 > b)
				{
					goto case 1;
				}
				num3 = 1;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3 != 0)
				{
					num3 = 16;
				}
				break;
			case 25:
				num6 = num2 * 4;
				num3 = 22;
				break;
			case 1:
			case 4:
			case 10:
			case 26:
				*(int*)Unsafe.AsPointer(ref array6[num4]) = *(int*)(ptr2 + num6);
				array8[num4] = 0;
				num4++;
				num3 = 26;
				if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_31f2f38a8f424bcd81d6651f48d18c36 == 0)
				{
					num3 = 0;
				}
				break;
			case 7:
				num4--;
				num5 = 34;
				goto IL_000f;
			case 24:
				{
					_ = new int[1];
					sbyte[] array = new sbyte[1];
					while (true)
					{
						fixed (sbyte[] array2 = array)
						{
							array3 = array;
							long[] array4 = new long[1];
							fixed (long[] array5 = array4)
							{
								array6 = array4;
								array7 = new object[7];
								byte* ptr = (byte*)Unsafe.AsPointer(ref ConfigurableTokenizerRequester.requesterPredicateModule);
								ptr2 = ptr;
								num3 = 20;
								while (true)
								{
									switch (num3)
									{
									default:
										if (num7 != 34)
										{
											if (num7 == 1014)
											{
												goto IL_0013_2;
											}
											goto case 3;
										}
										goto case 15;
									case 13:
										b = *ptr2;
										num3 = 14;
										continue;
									case 6:
										return;
									case 21:
										ptr2 += 8;
										num4--;
										goto case 15;
									case 0:
										ptr2 += 8;
										num3 = 17;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_4d9096fd915e49d381ca886fe6751708 == 0)
										{
											num3 = 6;
										}
										continue;
									case 19:
										if (1 < b)
										{
											if (2 < b || 2 > b)
											{
												goto case 1;
											}
											num3 = 11;
											continue;
										}
										num3 = 12;
										continue;
									case 22:
										array8 = new byte[1];
										array9 = new object[1];
										num3 = 24;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_aaf0588c508e4c34ae6abd63346b4803 == 0)
										{
											num3 = 6;
										}
										continue;
									case 5:
									case 11:
										array9[num4 - 1] = new object[*(int*)Unsafe.AsPointer(ref array6[num4 - 1])];
										array8[num4 - 1] = 5;
										num3 = 15;
										continue;
									case 14:
										ptr2++;
										if (b >= 1 && b <= 5)
										{
											if (3 < b)
											{
												goto case 18;
											}
											if (3 <= b)
											{
												goto case 23;
											}
											goto case 19;
										}
										goto case 1;
									case 3:
										ptr2 += 8;
										num3 = 7;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_250f6577073e41c7b48f940a404b5333 == 0)
										{
											num3 = 21;
										}
										continue;
									case 15:
									case 17:
									case 20:
										if (num8 == 1)
										{
											num3 = 6;
											continue;
										}
										goto case 13;
									case 23:
										array7[*(int*)(ptr2 + num6)] = array9[num4 - 1];
										num3 = 21;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_750f724efa0642d1a1bee294e56e9147 != 0)
										{
											num3 = 2;
										}
										continue;
									case 12:
										if (1 > b)
										{
										}
										goto case 1;
									case 8:
										num8 = 1;
										goto case 15;
									case 9:
									case 16:
										reference = ref array3[*(int*)(ptr2 + num6)];
										reference = (sbyte)(*(int*)Unsafe.AsPointer(ref array6[num4 - 1]));
										num3 = 3;
										continue;
									case 18:
										if (4 < b)
										{
											if (5 < b || 5 > b)
											{
												goto case 1;
											}
											goto case 8;
										}
										num5 = 2;
										goto IL_000f_2;
									case 2:
										if (4 > b)
										{
											goto case 1;
										}
										num3 = 1;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_c9fce0547d174d16b7e43d2b06b930d3 != 0)
										{
											num3 = 16;
										}
										continue;
									case 25:
										num6 = num2 * 4;
										num3 = 22;
										continue;
									case 1:
									case 4:
									case 10:
									case 26:
										*(int*)Unsafe.AsPointer(ref array6[num4]) = *(int*)(ptr2 + num6);
										array8[num4] = 0;
										num4++;
										num3 = 26;
										if (_003CModule_003E_007B277b4d12_002Dccaf_002D49e3_002Dbc83_002D4bcb71f7b9f3_007D.m_8e4e3c1c55b249eebd4bdeff64db9c4e.m_31f2f38a8f424bcd81d6651f48d18c36 == 0)
										{
											num3 = 0;
										}
										continue;
									case 7:
										num4--;
										num5 = 34;
										goto IL_000f_2;
									case 24:
										{
											_ = new int[1];
											array = new sbyte[1];
											break;
										}
										IL_0013_2:
										num3 = num7;
										continue;
										IL_000f_2:
										num7 = num5;
										goto IL_0013_2;
									}
									break;
								}
							}
						}
					}
				}
				IL_0013:
				num3 = num7;
				break;
				IL_000f:
				num7 = num5;
				goto IL_0013;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AssembleEvaluatorPool()
	{
		return InstantiateTokenizerEvaluator == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static _003CModule_003E_007B18EF186F_002DB69C_002D9153_002D94AD_002D7223E67485BC_007D PatchPoolTracer()
	{
		return InstantiateTokenizerEvaluator;
	}
}
