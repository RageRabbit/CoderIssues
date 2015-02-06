﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
using SoftWx.Numerics;

namespace TopCoderIssues
{
	class Program
	{
		static void Main(string[] args)
		{
			//var diff = (new EllysPairs()).getDifference(new int[] { 5, 1, 8, 8, 13, 7, 6, 2, 1, 9, 5, 11, 3, 4 });
			//var frogSteps = (new TheFrog()).getMinimum(30000, new int[] { 17, 25281, 5775, 2825, 14040 }, new int[] { 55, 26000, 5791, 3150, 14092 });
			//var ellysFigurine = (new EllysFigurines()).getMoves(new string[] 
			//	{"XXX..XXX..XXX.",
			//	 ".X..X....X...X",
			//	 ".X..X....X...X",
			//	 ".X..X....X...X",
			//	 ".X...XXX..XXX.",
			//	 "..............",
			//	 "...XX...XXX...",
			//	 "....X......X..",
			//	 "....X....XXX..",
			//	 "....X......X..",
			//	 "...XXX..XXX..."},
			//	 1, 2);
			//var ellysFigurine = (new EllysFigurines()).getMoves(new string[] { "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X", ".X.X.X.X.X.X.X.", "X.X.X.X.X.X.X.X" }, 1, 1);

			//var ellysReversals = (new EllysReversals()).getMin(new string[] 
			//{ "aaaababbabbbabbababbabbaaaabbabaaabbaabaaabaaaabab", "aabbbaabbbabaabbabaaababaaaaaabbaaaabbaababbabbbbb", "bbaabbabbbaabbbaababaaaaaababbaabbbaabababbbabbaba", 
			//	"abaaabbbaaabbbaababbabbbababbabbbaabaaabababaaabab", "ababaabbbbbbbaababaaaabbabbabababaaabbbbbaababaaba", "abbabbbaabbbabbaabbbbabbbabbababaababaaaaaabaababa", 
			//	"ababbbaabaabaabbabaaaaabaaabaabaabbbbababbaaababaa", "baaaababaabaaaabaaabaabbbabbbbbbabaabaabbababbaaaa", "bbabaabaabbabbaabaababbbbbabaabababbaaabaaaaababba", 
			//	"ababaabbbaaabbbbabaaabbbbaaaaaabaaabbbaaababaaabba", "bbbbbababbabbaaaabbababbabaaaabbbbaabbaaaabaaaabbb", "ababaaaabaaabaaaaaaaaabbabababbaabababbbababababba", 
			//	"bbbbabbaaaabaabbabbabbbaaabaababbaabbabbaaaabbbaab", "bbbaabbbaabaaababaaaabbbbbaabaabbaaaaabbbaabbbbbaa", "aaaaaaaaaaaabaaaaababaaabaababababbaabaababababaab", 
			//	"bbbaaaabbabbabbabbbbabbbbaabbabbbbbbbbbaaabbababbb", "bbbbababaaaaabababaababbaaaaabaaaaaaabbbbaabbbbbaa", "abababaabbbbbbbbbaabbaabbbbabbabababbababaabaabbba", 
			//	"abababaaaabbbbabbbaabaaaaabbabbabbababbbabbbbbbbba", "abbaabbbababbaaaaaabbbbaaabbbaaaaabaaaabbaabbaabaa", "bbaabbaabbaaaabbababbaabbabaaabbaaaabaabbaabbbaabb", 
			//	"abaabaabbabbaabaaabaaaabbbaababbbabbaabbbbaaabaaaa", "bababbaabaaabaaababaababbbbabbbbbabbababbababbaaaa", "babbbaaaababbaaabbabbabaabaabababaaabbabbbbbaaabba", 
			//	"babaabbbababababababaaaabbbbaaabaaabbabaabaaaaaaaa", "baaabaaabaaaabbbabbbaabaaabbabbbbbaabbbaababbbabaa", "baabababbabaabbabaaaabbbbabbabbabbabaaabaabbbabbaa", 
			//	"bbabbbbabbbbbbbaaabbaaaabaaaabbaaabaabbbabbaabaaba", "abbbbaaaabbabbaaaaabbabaaabbbaababbabbbbbbaaaabbbb", "abaaaabbaaababbaaabbbaaaaaabaabbababababaabaabbbaa", 
			//	"bbbaabaaaaaaababaaaaaabaaababbbbaaaaabaabaaaaababa", "abbaaaabaabbbbaababaaabaaaaabaaaaaabbbabaaaaababab", "abaabbbaabaabaababbbabbaaabbbaaababbababbabbaaabaa", 
			//	"bababbabbbbbbabbbbbababbbaabbaaaaaaaaaabbbaabbbbaa", "babaabbaabbaaabbbabbbaabbbbaababbbaaaabbbaaabbbaaa", "ababbaabbabbbbaabbbabbbaaaaababaabbbabbbbbabababaa", 
			//	"ababbaaababaaabbbaaabaaabbbababbabbbababbbaabababa", "baabaabbabababbabaababbbaaaabbbababbabbbbbaaababba", "babbbbbbbbaaaaabababbaabbbbbaaabbbaaabbbbbaaaababb", 
			//	"aaaaaabbbbaaaabbbbbaaabbaaababbbaaabbaabaaaababbab", "baaabbaababbbabaabbbbaaaabaababbbaaabbbabbabbaabab", "aabbbabbbbaabaabbabbbabbbbababbbaaababaabaaabbaabb", 
			//	"baabaabbabbaaabbbaaaaabaaaaaaabaaabbbbbbbabbbaaaba", "aabbbbbbbabbbaaaabbbbabbbaaaaaaabaabaaabaaaababbba", "bbabbaabbabbabbbabaaabbbbbaaababbabbaababbabbbbaab", 
			//	"baabaabaabaabaababaabbbaaaaababbbbabaababaabaabbbb", "aaabaaaababaabbbabaaabaaaabbababbbbbaaababbabaaabb", "abbabbabababaaaaabbaabbaabbaabbbababbaabbbaabbbbab", 
			//	"abababbbbabbbbabbababaababaabbbbaababbbaabaababbaa", "bbbabbbababbabaababbbbabbabbabbbabbabbaaababaabbaa" });

			//var thearray = (new TheArray()).find(3, 5, 2, 4);
			//var thearray = (new TheArray()).find(97, 53, -92, 441);
			//var thearray2 = (new TheArray()).find(99, 3, -743, -619);
			//var olympiad1 = (new TheOlympiadInInformatics()).find(new int[] { 513015310, 823743897, 602330461, 599197621, 739547947, 473899575, 956245034, 129880661, 978154689, 757668547, 458702019, 632160141, 18710830, 460745944, 307396601, 69069630, 627797830, 706195756, 797936447, 872475724, 680594034, 700801398, 80603502, 813200223, 108521614, 949567009, 594106449, 863314907, 900162655, 892153729, 641158466, 579063450, 475015012, 342160697, 24980664, 754222718, 877221509, 280495305, 591125098, 660075704, 499174339 }, 1);
			//var olympiad2 = (new TheOlympiadInInformatics()).find(new int[] { 743026697, 516109685, 429341009, 166028661, 272315096, 751345535, 145232580, 397430042, 327772572, 725361884, 748024221, 824494040, 223739692, 550633065, 849243669, 215494686, 807425864, 510562621, 847699519, 18682227, 783879505, 278718562, 849732924, 295336791, 656785024, 595000343, 998780684, 23020318, 150942944, 815936936, 217676019, 567944632, 6922888, 104542672, 60168777 }, 267760033 );
			//var olympiad3 = (new TheOlympiadInInformatics()).find(new int[] { 95, 23, 87, 23, 82, 78, 59, 44, 12 }, 70);
			//var olympiad4 = (new TheOlympiadInInformatics()).find(new int[] { 999999999 }, 1000000000);
			//var olympiad5 = (new TheOlympiadInInformatics()).find(new int[] { 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912, 536870912 }, 10);

			//var team = (new TeamContestEasy()).worstRank(new int[] { 5, 7, 3, 5, 7, 3, 5, 7, 3 });
//			var team = (new TeamContestEasy()).worstRank(new int[] {610297,849870,523999,6557,976530,731458,7404,795100,147040,110947,159692,40785,4949,2903,1688,37278,620703,28156,16823,1159,12132,971379,5916,1159,988589,
//12215,133,1490,911360,920059,544070,40249,514852,852,745070,1105,715897,714696,589133,698317,5683,631612,16453,101000,764881,101,2053,754661});

			//CormenBookTasks.Task_1_1_1and2_InsertSort(new int[] { 5, 2, 4, 6, 1, 3 }, true);
			//CormenBookTasks.Task_1_1_4(new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 });
			//CormenBookTasks.Task_1_2_1_SelectionSort(new int?[] { 5, 2, 4, 6, 1, 3 });
			//CormenBookTasks.Task_1_2_3_RemoveDuplicates(new int[] { 5, 2, 2, 4, 6, 1, 3, 4 });
			//CormenBookTasks.Task_1_2_4_GornerScheme(new int[] { 5, 2, 4 }, 2);
			//CormenBookTasks.Task_1_3_1and2_MergeSort(new int[] { 3, 41, 52, 26, 38, 57, 9, 49 });
			//CormenBookTasks.Task_1_3_4_InsertSortRecursive(new int[] { 3, 41, 52, 26, 38, 57, 9, 49 });
			//CormenBookTasks.Task_1_3_5_BSearch(new int[] { 3, 41, 52, 26, 38, 57, 9, 49 }, 38);
			//CormenBookTasks.Task_1_3_InversionCount(new int[] { 3, 41, 52, 26, 38, 57, 9, 49 });
			//CormenBookTasks.Task_8_1_1_QuickSort(new int[] { 13, 19, 9, 5, 12, 8, 7, 4, 11, 2, 6, 21 });

			//BitMaskTests.Test1();

			//TopCoder2012.Run();
			//ProjectEuler.Run();
			//GoogleCodeJam.Run();
			TopCoder.Run();
		}
	}

	public class BitMaskTests
	{
		public static void Test1()
		{
			int d = 9; //1001 - length=4
			var afirst = d & (1 << (4 - 1));

			int a = 5;
			while (a > 0)
			{
				var alast = a & 1;
				a = a >> 1;
			}
			int b = a << 1;
			int c = a >> 1;
		}
	}

	public class BTree
	{
		BTree Left { get; set; }
		BTree Right { get; set; }
		int Value { get; set; }

		public BTree(int value)
		{
			Value = value;
		}

		public void Insert(int value, bool ignoreDuplicates = false)
		{
			if (value <= Value)
			{
				if (ignoreDuplicates && value == Value)
				{
					return;
				}
				if (Left == null)
				{
					Left = new BTree(value);
				}
				else
				{
					Left.Insert(value, ignoreDuplicates);
				}
			}
			else if (value > Value)
			{
				if (Right == null)
				{
					Right = new BTree(value);
				}
				else
				{
					Right.Insert(value, ignoreDuplicates);
				}
			}
		}

		public void DeepWalk(List<int> result)
		{
			if (Left != null)
			{
				Left.DeepWalk(result);				
			}
			result.Add(Value);
			if (Right != null)
			{
				Right.DeepWalk(result);
			}
		}
	}

	public class CormenBookTasks
	{
		public static int[] Task_1_1_1and2_InsertSort(int[] input, bool desc = false)
		{
			for (int i = 1; i < input.Length; i++)
			{
				var j = i - 1;
				var key = input[i];
				while (j >= 0 && (desc ? input[j] < key : input[j] > key))
				{
					var temp = input[j + 1];
					input[j + 1] = input[j];
					input[j] = temp;
					j--;
				}
			}
			return input;
		}

		public static int[] Task_1_1_4(int[] A, int[] B)
		{
			var C = new int[A.Length+1];
			var ost = 0;
			for (int i = A.Length - 1; i >= 0; i--)
			{
				C[i + 1] = (A[i] + B[i] + ost) % 2;
				ost = (A[i] + B[i] + ost) / 2;
			}
			C[0] = ost;
			return C;
		}

		public static int[] Task_1_2_1_SelectionSort(int?[] input)
		{
			var output = new int[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				var minJ = -1;
				for (int j = 0; j < input.Length; j++)
				{
					if (!input[j].HasValue)
					{
						continue;
					}
					if (minJ == -1 || input[j] < input[minJ])
					{
						minJ = j;
					}
				}
				output[i] = input[minJ].Value;
				input[minJ] = null;
			}
			return output;
		}

		public static int[] Task_1_2_3_RemoveDuplicates(int[] input)
		{
			var tree = new BTree(input[0]);
			for (int i = 1; i < input.Length; i++)
			{
				tree.Insert(input[i], true);
			}
			var res = new List<int>();
			tree.DeepWalk(res);
			return res.ToArray();
		}

		public static int Task_1_2_4_GornerScheme(int[] input, int x)
		{
			var temp = input[0];
			for (var i = 1; i < input.Length; i++)
			{
				temp = temp * x + input[i];
			}
			return temp;
		}

		public static int[] Task_1_3_1and2_MergeSort(int[] input)
		{
			Action<int, int, int> merge = (i, k, j) => 
			{
				var res = new List<int>();
				var i1 = i;
				var j1 = k + 1;
				while (i1 <= k && j1 <= j)
				{
					if (input[i1] < input[j1])
					{
						res.Add(input[i1]);
						i1++;
					}
					else
					{
						res.Add(input[j1]);
						j1++;
					}
				}
				while (i1 <= k)
				{
					res.Add(input[i1]);
					i1++;
				}
				while (j1 <= j)
				{
					res.Add(input[j1]);
					j1++;
				}
				for (int k1 = i; k1 <= j; k1++)
				{
					input[k1] = res[k1 - i];
				}
			};

			Action<int, int> sort = null;
			sort = (i, j) => 
			{
				if (i >= j)
				{
					return;
				}
				sort(i, i + (j - i) / 2);
				sort(i + (j - i) / 2 + 1, j);
				merge(i, i + (j - i) / 2, j);
			};

			sort(0, input.Length - 1);

			return input;
		}

		public static int[] Task_1_3_4_InsertSortRecursive(int[] input)
		{
			Action<int, int> sort = null;
			sort = (start, end) => 
			{
				if (end == start)
				{
					return;
				}
				sort(start, end - 1);
				int k = end;
				while (input[k] < input[k - 1] && k > 0)
				{
					int swap = input[k];
					input[k] = input[k - 1];
					input[k - 1] = swap;
					k--;
				}
			};

			sort(0, input.Length - 1);

			return input;
		}

		public static int Task_1_3_5_BSearch(int[] input, int num)
		{
			Func<int, int, int> search = null;
			search = (start, end) => 
			{
				if (start == end)
				{
					return start;
				}
				int m = start + (end - start) / 2;
				if (input[m] >= num)
					return search(start, m);
				return search(m + 1, end);
			};

			Array.Sort(input);
			var res = search(0, input.Length - 1);
			return res;
		}

		public static int Task_1_3_InversionCount(int[] input)
		{
			int inversionCount = 0;

			Action<int, int> sort = null;
			sort = (start, end) => 
			{
				if (end == start)
				{
					return;
				}
				int k = start + (end - start) / 2;
				sort(start, k);
				sort(k + 1, end);
				int i = start;
				int j = k + 1;
				var n = new List<int>();
				while (i <= k && j <= end)
				{
					if (input[i] > input[j])
					{
						inversionCount++; //!!!
						n.Add(input[j]);
						j++;
					}
					else
					{
						n.Add(input[i]);
						i++;
					}
				}
				while (i <= k)
				{
					n.Add(input[i]);
					i++;
				}
				while (j <= end)
				{
					n.Add(input[j]);
					j++;
				}
				for (int i2 = start; i2 <= end; i2++)
				{
					input[i2] = n[i2 - start];
				}
			};

			sort(0, input.Length - 1);
			return inversionCount;
		}

		public static void Task_7_2_4_Heapify(int[] input, int i)
		{
			bool exit = false;
			while (!exit)
			{
				int left = (i + 1) * 2 - 1;
				int right = (i + 1) * 2;
				int max = i;
				if (left < input.Length && input[i] < input[left])
				{
					max = left;
				}
				if (right < input.Length && input[i] < input[right])
				{
					max = right;
				}
				if (max != i)
				{
					int temp = input[i];
					input[i] = input[max];
					input[max] = temp;
					i = max;
				}
				else
				{
					exit = true;
				}
			}
		}

		public static void Task_8_1_1_QuickSort(int[] input)
		{
			Action<int, int> QSort = null;
			QSort = (int left, int right) =>
			{
				int i = left, j = right;
				var pivot = input[(left + right) / 2];

				while (i <= j)
				{
					while (input[i] < pivot)
					{
						i++;
					}

					while (input[j] > pivot)
					{
						j--;
					}

					if (i <= j)
					{
						// Swap
						var tmp = input[i];
						input[i] = input[j];
						input[j] = tmp;

						i++;
						j--;
					}
				}

				// Recursive calls
				if (left < j)
				{
					QSort(left, j);
				}

				if (i < right)
				{
					QSort(i, right);
				}
			};

			QSort(0, input.Length - 1);
		}
	}

	public class EllysPairs
	{
		public int getDifference(int[] knowledge)
		{
			Array.Sort(knowledge);
			List<int> sums = new List<int>();
			for (var i = 0; i < knowledge.Length / 2; i++)
			{
				sums.Add(knowledge[i] + knowledge[knowledge.Length - 1 - i]);
			}
			int[] sumsA = sums.ToArray();
			Array.Sort(sumsA);
			return sumsA[sumsA.Length - 1] - sumsA[0];
		}
	}

	public class EllysFigurines
	{
		private int? Check(string[] board, int R, int C, int rV, int cV)
		{
			int moves = 0;
			int i = 0;
			while (rV > 0)
			{
				if (rV % 2 == 1)
				{
					moves++;
					for (int i1 = i; i1 < i + R && i1 < board.Length; i1++)
					{
						string str = "";
						for (int j1 = 0; j1 < board[0].Length; j1++)
						{
							str += '.';
						}
						board[i1] = str;
					}
				}
				rV /= 2;
				i++;
			}

			i = 0;
			while (cV > 0)
			{
				if (cV % 2 == 1)
				{
					moves++;
					for (int i1 = i; i1 < i + C && i1 < board[0].Length; i1++)
					{
						for (int j1 = 0; j1 < board.Length; j1++)
						{
							board[j1] = board[j1].Insert(i1, ".");
							board[j1] = board[j1].Remove(i1 + 1, 1);
						}						
					}
				}
				cV /= 2;
				i++;
			}

			foreach (var s in board)
			{
				if (s.Contains("X"))
				{
					return null;
				}
			}
			return moves;
		}

		public int getMoves_my(string[] board, int R, int C)
		{
			int rV = (int)Math.Pow(2, board.Length);
			int cV = (int)Math.Pow(2, board[0].Length);
			int minRes = int.MaxValue;
			for (int i = 0; i < rV; i++)
			{
				for (int j = 0; j < cV; j++)
				{
					string[] boardTemp = new string[board.Length];
					for (int k = 0; k < board.Length; k++)
					{
						boardTemp[k] = board[k];
					}
					int? res = Check(boardTemp, R, C, i, j);
					minRes = res.HasValue ? Math.Min(res.Value, minRes) : minRes;
				}
			}
			return minRes;
		}

		//official
		public int solveMask(int mask, int L)
		{
			int i = 0;
			int steps = 0;
			// We can assume there to be at most 15 elements in the set
			// it will not affect the result.
			while (i < 15)
			{
				if ((mask & (1 << i)) > 0)
				{
					// We must remove the i-th element, why not
					// remove the L consecutive ones starting at i?
					steps++;
					i += L;
				}
				else
				{
					i++;
				}
			}
			return steps;
		}

		public int getMoves(string[] board, int R, int C)
		{
			int h = board.Length, w = board[0].Length;
			int best = 15; //A high number. 15 is high enough (remove each column in one step)
			// Using bit masks, we can iterate through all sub-sets
			// of rows to pick:
			for (int mask = 0; mask < (1 << w); mask++)
			{
				// Find the set of columns that must be covered.
				// That is, the number of columns that contain X even
				// after covering the rows in mask:
				int m2 = 0;
				for (int i = 0; i < h; i++)
				{
					if ((mask & (1 << i)) == 0)
					{
						for (int j = 0; j < w; j++)
						{
							if (board[i][j] == 'X')
							{
								m2 |= (1 << j);
							}
						}
					}
				}
				//   Minimum cost to cover the picked rows
				// + Minimum cost to cover the necessary columns:
				best = Math.Min(best, solveMask(m2, C) + solveMask(mask, R));
			}
			return best;
		}
	}

	public class EllysReversals
	{
		private bool isEqual(char[] w1, char[] w2)
		{
			if (w1.Length != w2.Length)
			{
				return false;
			}
			for (int i = 0; i < w1.Length; i++)
			{
				if (w1[i] != w2[i])
				{
					return false;
				}
			}
			return true;
		}

		public int getMin(string[] words)
		{
			bool[] doubles = new bool[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				if (doubles[i])
				{
					continue;
				}
				char[] w1 = words[i].Substring(0, 2 * (words[i].Length / 2) + (words[i].Length == 1 ? 1 : 0)).ToCharArray();
				Array.Sort(w1);
				for (int j = i + 1; j < words.Length; j++)
				{
					char[] w2 = words[j].Substring(0, 2 * (words[j].Length / 2) + (words[j].Length == 1 ? 1 : 0)).ToCharArray();
					Array.Sort(w2);
					if (isEqual(w1, w2))
					{
						doubles[i] = doubles[j] = true;
						break;
					}
				}
			}
			int cnt = 0;
			foreach (bool d in doubles)
			{
				cnt += (d ? 0 : 1);
			}
			return cnt;
		}
	}

	public class TheFrog
	{
		bool check(double distance, int[] L, int[] R)
		{
			for (int i = 0; i < L.Length; i++)
			{
				int steps = (int)(L[i] / distance);
				if ((steps + 1) * distance < R[i])
					return false;
			}
			return true;
		}

		public double getMinimum(int D, int[] L, int[] R)
		{
			double bestDistance = double.MaxValue;
			for (int i = 0; i < L.Length; i++)
			{
				for (int j = 1; j <= L[i]; j++)
				{
					double distance = (double)L[i] / j;
					if (check(distance, L, R))
					{
						bestDistance = Math.Min(bestDistance, distance);
					}
				}
				for (int j = 1; j <= R[i]; j++)
				{
					double distance = (double)R[i] / j;
					if (check(distance, L, R))
					{
						bestDistance = Math.Min(bestDistance, distance);
					}
				}
			}
			return bestDistance;
		}
	}

	public class TheArray
	{
		public int find(int n, int d, int first, int last)
		{
			if (d == 0)
			{
				return first;
			}
			for (int i = 0; i < n - 2; i++)
			{
				if (last < first)
				{
					last += d;
				}
				else
				{
					first += d;
				}
			}
			return Math.Max(first, last);
		}
	}

	public class TheOlympiadInInformatics
	{
		private int bsearch(int[] sums, int numstart, int numend, int k)
		{
			int numstartcount = 0, numendcount = 0, numcount = 0;
			int num = numstart + (numend - numstart) / 2;
			foreach (int sum in sums)
			{
				numstartcount += (sum / numstart);
				numendcount += (sum / numend);
				numcount += (sum / num);
			}
			if (numstart == numend || numend - numstart == 1)
			{
				return numstartcount > k ? numstart : 0;
			}
			else if (numcount > k)
			{
				return bsearch(sums, num, numend, k);
			}
			else
			{
				return bsearch(sums, numstart, num, k);				
			}
		}

		public int find(int[] sums, int k)
		{
			int max = 0;
			bool same = false;
			for (int i = 0; i < sums.Length; i++)
			{
				max = Math.Max(max, sums[i]);
				same = (i == 0 ? false : sums[i] == sums[i - 1] ? true : same);
			}
			
			if (k == 0 || same)
			{
				return max;
			}

			int res = bsearch(sums, 1, max, k);

			return res;
		}
	}

	public class TeamContestEasy
	{
		public int worstRank(int[] strength)
		{
			var str = new List<int>(strength);
			str.Sort(0, 3, null);
			int ourTeam = str[1] + str[2];
			str.RemoveRange(0, 3);
			str.Sort();
			str.RemoveRange(0, str.Count / 3);
			int rating = 0;
			while (str.Count > 0)
			{
				int newTeam = str[0];
				str.RemoveAt(0);
				int i = str.FindIndex(delegate(int v) { return v + newTeam > ourTeam; });
				if (i > -1)
				{
					rating++;
					str.RemoveAt(i);
				}
			}
			return 1 + rating;
		}

		//incorrect
		public int worstRank2(int[] strength)
		{
			int targetStrength = strength[0] + strength[1] + strength[2] - Math.Min(strength[0], Math.Min(strength[1], strength[2]));
			var str = new List<int>(strength);
			str.RemoveAt(0);
			str.RemoveAt(0);
			str.RemoveAt(0);
			var strArr = str.ToArray();
			//Array.Sort(strength);

			int[] arr = new int[strArr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i;
			}

			int maxCount = 0;

			while (true)
			{
				int i = 0;
				for (i = 0; i < arr.Length - 1; i++)
				{
					if (arr[i] < arr[i + 1])
					{
						int min = i + 1;
						for (int j = i + 2; j < arr.Length; j++)
						{
							if (arr[j] > arr[i])
							{
								min = arr[j] < arr[min] ? j : min;
							}
						}
						int swap = arr[i];
						arr[i] = arr[min];
						arr[min] = swap;
						
						int j2 = i + 1;
						int j2end = arr.Length - 1;
						while (j2end - j2 >= 0)
						{
							swap = arr[j2];
							arr[j2] = arr[j2end];
							arr[j2end] = swap;
							j2++;
							j2end--;
						}
						break;
					}
				}
				if (i == arr.Length - 1)
				{
					break;
				}

				int count = 0;
				for (int k = 0; k < arr.Length; k += 3)
				{
					int strengthTeam = strArr[arr[k]] + strArr[arr[k + 1]] + strArr[arr[k + 2]] - Math.Min(strArr[arr[k]], Math.Min(strArr[arr[k + 1]], strArr[arr[k + 2]]));
					count += strengthTeam > targetStrength ? 1 : 0;
				}
				maxCount = Math.Max(count, maxCount);
			}

			return 1 + maxCount;
		}
	}

	public class TopCoder
	{
		public static void Run()
		{
			//(new SRM576.TheExperimentDiv2()).determineHumidity(new int[] { 92, 11, 1000, 14, 3 }, 2, new int[] { 0, 3 });
			//(new SRM576.ArcadeManao()).shortestLadder(new string[] {"XXXX", "...X", "XXXX"}, 1, 1);
			//(new SRM576.CharacterBoard2()).countGenerators(new string[] { "dea", "abc" }, 7, 1, 1);
			//(new SRM576.CharacterBoard2()).countGenerators(new string[] { "xyxxy" }, 6, 1, 0);
			//(new SRM576.CharacterBoard2()).countGenerators(new string[] {"gogogo", "jijiji", "rarara"}, 6, 0, 0);
			//(new SRM576.CharacterBoard()).countGenerators(new string[] { "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa", "aaaaaaaaaa" }, 1000000000, 0, 0);
			//(new SRM576.CharacterBoard()).countGenerators(new string[] {"abababacac", "aaacacacbb", "ccabababab"}, 8827, 104, 6022);
			//(new SRM576.TheExperiment()).countPlacements(new string[] { "341156" }, 3, 3, 6, 10);
			//(new SRM576.TheExperiment()).countPlacements(new string[] { "999112999" }, 2, 4, 21, 30);
			//(new SRM576.TheExperiment()).countPlacements(new string[] { "59059", "110", "1132230231" }, 1, 5, 10, 20);
			//(new SRM576.TheExperiment()).countPlacements(new string[] { "111111111111111111111111", "111111111111111111111111111", "11111111111111111111111" }, 12, 8, 4, 2700);
			//(new SRM576.TheExperiment()).countPlacements(new string[] { "88949553710676480" }, 5, 2, 8, 12);			
			//(new TCO2013.Round2B.FruitTrees()).maxDist(899, 1073, 1147);
			//(new SRM577.EllysNewNickname()).getLength("ayayayayayaya");
			//(new SRM577.EllysRoomAssignmentsDiv2()).getProbability(new string[] { "539 457 277 929 180 296 820 319 839 199 210 989 88", 
			//	"5 1033 1132 479 1023 425 340 828 843 934 1124 434 ", 
			//	"264 206 1117 569 388 351 972 348 176 1182 832" });
			//(new SRM577.EllysCoprimesDiv2()).getCount(new int[] { 2200, 42, 2184, 17 }); 
			//(new SRM577.EllysCoprimesDiv2()).getCount(new int[] { 55780, 44918, 55653, 4762, 41536, 40083, 79260, 7374, 24124, 91858, 7856,
			//													 12999, 64025, 12706, 19770, 71495, 32817, 79309, 53779, 8421, 97984, 34586,
			//													 893, 64549, 77792, 12143, 52732, 94416, 54207, 51811, 80845, 67079, 14829,
			//													 25350, 22976, 23932, 62273, 58871, 82358, 13283, 33667, 64263, 1337, 42666});
			//(new SRM577.EllysRoomAssignmentsDiv1()).getAverage(new string[] {"1924 1242 1213 1217 2399 1777 2201 2301 1683 2045 ", "1396 2363 1560 2185 1496 2244 2117 2207 2098 1319 ",
			//										 "2216 1223 1256 2359 2394 1572 2151 2191 2147 2253 ", "1633 2217 2211 1591 1310 1209 1430 1445 1988 2030 ",
			//										 "1947 1202 1203"});
			//(new SRM577.EllysChessboard()).minCost(new string[] {"##..####",
			//													 "#####..#",
			//													 "..#.#...",
			//													 "#..##.##",
			//													 ".#.###.#",
			//													 "####.###",
			//													 "#.#...#.",
			//													 "##....#."});
			//(new SRM578.DeerInZooDivTwo()).getminmax(654, 321);
			
			//(new SRM578.GooseInZooDivTwo()).count(new string[] { "vvv" }, 0);
			//(new SRM578.GooseInZooDivTwo()).count(new string[] { ".vv..v.........v....", "....v.......vv...vvv", "...vv.v....v..vv....", "v......v....vv...v..", "..v..v..vv.v..vv....", "..v....v.v.....v...v", ".v......v..vv...v...", "vv..............v...", "..v..v.....vv.v.v..v", "v.........vv...v....", "......v..v.v.....v..", ".....v.....v....v..v", "..v.v....v.v.....v..", "..v.......vvv.....v.", "....v....v.vv.....v.", ".v...v.............v", "..vv.....v.........v", "..v.................", "v.........v.........", "v...........v....v..", "v.......v..........." }, 1);
			//(new SRM578.GooseInZooDivTwo()).count(new string[] { ".vv..v.........v....", "....v.......vv...vvv", "...vv.v....v..vv....", "v......v....vv...v..", "..v..v..vv.v..vv....", "..v....v.v.....v...v", ".v......v..vv...v...", "vv..............v...", "..v..v.....vv.v.v..v", "v.........vv...v....", "......v..v.v.....v..", ".....v.....v....v..v", "..v.v....v.v.....v..", "..v.......vvv.....v.", "....v....v.vv.....v.", ".v...v.............v", "..vv.....v.........v", "..v.................", "v.........v.........", "v...........v....v..", "v.......v..........." }, 0);
			//(new SRM578.GooseInZooDivTwo()).count(new string[] {"vvvvv..vvvv.vvv..v..v.....v...v..v.vvv....v.vvv.vv", "v.vvv.vvvv.....vv.vvv.vvv...vvvvvv.....v.v..v..v.v", "v.v..v.....v..vv.v...v..vvvv..v.v..vvv.v.vv.vv....", "v.vvv.vv.vv..v.vvv.vvvv..v...v...v...v..vvv...vv.v", "vvvv...vv....vv..vvvvv....v...v..vvvvvv.....v..vv.", ".vv.v.vv.v.v...v.v...v.vv...v.v.v.vvvv...v..v.v.v.", "....v..v...vvv..v.....v.vvvv.v...v.v..vv..vvvvv.v.", ".vvvv.v.vvvv...vv.vvv........vv..v.vv.v.v...v..vvv", ".vvv.v..vvv...vvv.vvv.vvv.vvvvv...vvvv.v.v.....v.v", ".v.vv.vv..v.v.vvv.vv.v....vvv.vv.vv.vvvv...v.v...v", "....v..v.vvv.v..vvvvvv.....v..vv...v...v.vvvv.v..v", "..v.vv.vvv..v..vv.vv.vv...vv.v....vv.v.v....vvvvv.", "v...v..vv..vvvv.vvvvv..v.v.v..vv.v.vvvv..vvvvvv..v", "....vv..v.v.v...vvvvvvv....vvv.vvv.v.v.v.v.vvvvv..", "vvvv.vvv.vvv.vvvvvv....v.vv...v..v.vv....vv.vv.v..", ".vv.v..vv.......v...v..vvvvv.v.v..vv..vvvv.v.vv..v", "vvv..v.vv...v...vv.vv..v...v.vvv..vvv.....v....v.v", "....v.v..vv..vv...v.v.v.vvv...v.vvvvvv..vvvvvv..vv", ".v.v.v.vv.v..vvvvv.v.vvvv....vv..v.vv...vv.v..v..v", "...v.v...v........vv..v.vv...vvvv.v...vv..v...vv..", ".v.vvvv.v...vv....v.vvvvvv.v.vvvvvvv..vv.....vv.v.", "..vv..v......vvvvvvvvv...vvvvvvvvv..vvvvv.v....v..", "..v.v.v...vvv.v.v.vv.vv.vv.v.vvv.vv.v.vvv.v....v..", "vvvvvvvvvvv..v.vvv.vv.v.v.vv.vvvvvv.v...v...vvv.vv", "v..v.vv.v.vvv...vv.v..v.vv....v.vv.v.vvvv..vvv.vvv", ".v..vv...v.v.vvvvv.v...vv.vv.v.....v...vvvvv.v....", "...vvvvvv.v.vv.vv.v..v.vvv.v....v.v..v.v..vvvvv...", "vv..vvvvv...vvv..v...vv.v.v.vvvv....vvvvvvvv...v..", "vv..vv..vv.vvv.v.v..v.v.......vvv.vvv..vvv.v.v.v..", "vvv.v.v....vv.v.v.v.vv..vv..vvvvv.v...vvvvvv.....v", ".vv.v.v.vv...v...vv..v.v.v..vvvv.vv..vv...vv...vv.", ".vvvvv..v.....v.vv.vvv...vv...v...vvv.vvvv.v.v.vv.", "vvvvvv.vv.v..v....v.vvvvvvvvvvvvvvvv.vvv..vv.v...v", "..v.vv..vvvv.vv.vv..vv..vvvv.vv.vv..vv.vv....v.vv.", "..v..vv......vvvvv...vv.v....vv..v..v..vvv.vv.v...", ".v..v...v.v.vv.vv.v..vvv.v.v.vvvvv.vvvvvv....vv.vv", ".v.vvv..vvv.vvvv..vvv.vvv.v..v.vvv.vvvvv.vv....v.v", ".vvv.v..v...v..v..vvv.v.....vvvvvvvvvv.v...vv.vvvv", "vvvvv..v...v.v...vv..vv..v.vv..v...vv..v.vvvvv..vv", ".v..v.v...v.vv..vvvv....vv...v....v..vv.vvvvvvv..v", "v.vvvvvv.v.vvvvvvv...v.v.vvvvvvv.vvvv.vv..v..v..vv", "vvvv..v.v.v...v.v..v..v..v.vvvvvv.v...vv.v.vv.vv..", ".vv.v..vvv.v...vvvv..vvv.vv...vvv..v.vv.....v.v...", ".vvv.vv...vvvv....vv...v.v....v.v..v..vvv.v..vv.vv", ".vv...v.vvv.....v..vv.v.v...v.vv...vvv.v...v.vv.v.", "vv.vv....vvv.vv..vvvv..vvv.....vv.v...vvvvv.v..v.v", ".vv.....vv.v.vvv...v..vv.v...vvvv..v.v.vvvv..vvvvv", "v.v.vv...vv..vvvv..v..vv...vv...vvv.vvvvvvvvvv.v.v", "vvvv..v.vvv...vvvvvv...vv....vvvv....vv..vvvv..v.v", "v.v....vv.vv.v.v.v...v.....vvv.vvv.v...v.vvvvv.vv."}, 0);
			//(new SRM578.WolfInZooDivTwo()).count(5, new string[] { "0 1" }, new string[] { "2 4" });
			//(new SRM578.WolfInZooDivTwo()).count(3, new string[] { "1" }, new string[] { "2" });
			//(new SRM578.WolfInZooDivTwo()).count(10, new string[] { "0 4 2 7" }, new string[] { "3 9 5 9" });
			//(new TCO2013.Round2C.DancingFoxes()).minimalDays(new string[] {"NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNYNNNNNNNNNNNNN", "NNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNN", "NNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNY", "NNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNYYNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNYNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNYNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNYNNNN", "NNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNN", "NNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNYNNNNYNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNYNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNYNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNYNN", "NNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYN", "NNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNYNNNNYNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNYN", "NNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNN", "NNNNNNNNYNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNYNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNYNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNN", "NNYNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNY", "NNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNN", "NNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNYNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNYNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNYNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNYNNNNNNNNNNN", "NNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYYNNNNNNNNNNNNNNNNNN", "NNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNN", "NYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNN", "NNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNN", "NNNNNNNYNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "YNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNYNNN", "NNNNNNNYNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNYNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNN", "NNNNNYNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNYNNNNNNNN", "NNNNNNNNNNNNNNNYNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNYNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN", "NNNNYNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNN"});
			//(new SRM579.UndoHistory()).minPresses(new string[] { "tomorrow", "topcoder" });
			//(new SRM579.UndoHistory()).minPresses(new string[] { "ba", "a", "a", "b", "ba" });
			//(new SRM596.ColorfulRoad()).getMin("RBRGBGBGGBGRGGG");
			//CormenBookTasks.Task_7_2_4_Heapify(new int[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 }, 2);
			//(new SRM580.ShoutterDiv2()).count(
			//	new int[] { 9, 26, 8, 35, 3, 58, 91, 24, 10, 26, 22, 18, 15, 12, 15, 27, 15, 60, 76, 19, 12, 16, 37, 35, 25, 4, 22, 47, 65, 3, 2, 23, 26, 33, 7, 11, 34, 74, 67, 32, 15, 45, 20, 53, 60, 25, 74, 13, 44, 51 },
			//	new int[] { 26, 62, 80, 80, 52, 83, 100, 71, 20, 73, 23, 32, 80, 37, 34, 55, 51, 86, 97, 89, 17, 81, 74, 94, 79, 85, 77, 97, 87, 8, 70, 46, 58, 70, 97, 35, 80, 76, 82, 80, 19, 56, 65, 62, 80, 49, 79, 28, 75, 78 });
			//(new SRM580.EelAndRabbit()).getmax(new int[] { 2, 4, 3, 2, 2, 1, 10 }, new int[] { 2, 6, 3, 7, 0, 2, 0 });
			//(new SRM580.EelAndRabbit()).getmax(
			//	new int[] { 50, 38, 3, 43, 7, 7, 81, 22, 93, 59, 51, 39, 84, 29, 17, 15, 32, 84, 8, 46, 92, 86, 6, 6, 90, 22, 40, 15, 28, 79 },
			//	new int[] { 64, 63, 42, 74, 44, 77, 73, 52, 22, 41, 38, 39, 18, 23, 90, 40, 38, 25, 27, 84, 48, 49, 25, 46, 39, 30, 54, 35, 18, 26 });
			//(new SRM581.SurveillanceSystem()).getContainerInfo("-X--XX", new int[] { 1, 2 }, 3);
			//(new SRM581.SurveillanceSystem()).getContainerInfo("-XXXXX-", new int[] { 2 }, 3);
			//(new SRM581.SurveillanceSystem()).getContainerInfo("------X-XX-", new int[] { 3, 0, 2, 0 }, 5);
			//(new SRM581.SurveillanceSystem()).getContainerInfo("-XX--X-XX-X-X--X---XX-X---XXXX-----X", new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 7);
			//(new SRM627.ManySquares()).howManySquares(new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 3, 3 });
			//(new SRM627.HappyLetterDiv2()).getHappyLetter("aabc");
			//(new SRM627.BubbleSortWithReversals()).getMinSwaps(new int[] {33, 550, 602, 859, 216, 109, 884, 550, 494, 213, 109, 494, 550, 216, 965, 884, 422, 859}, 13);
			//(new SRM627.HappyLetterDiv1()).getHappyLetters("aabbacccc");
			//(new SRM628.InvariantSets()).countSets(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 0, 27, 26, 25, 28, 30, 31, 32, 29, 35, 34, 37, 36, 33, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 38 });
			//(new SRM628.DivisorsPower()).findArgument(9109555799784049);
			//(new SRM628.CircuitsConstruction()).maximizeResistance("BAAXBXXBXAXXBBAXXBXXAAXXX", new int[] { 17, 7, 21, 102, 56, 72, 88, 15, 9, 192, 16, 8, 30 });
			//(new SRM626.SumOfPower()).findSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
			//(new SRM626.FixedDiceGameDiv2()).getExpectation(11, 13);
			//(new SRM625.AddMultiply()).makeExpression(0);
			//(new SRM625.IncrementingSequence()).canItBeDone(2, new int[] { 22, 13, 19, 7, 2, 16, 16, 1, 10, 6, 10, 24, 15, 21, 4, 18, 10, 3, 11, 5, 20, 25, 5, 13, 25 });
			//(new TCCC_2004_Online_Round_4.Dijkstra()).findMinRouteLength(new string[] 
			//{
			//	".....B.",
			//	".#####.",
			//	".#...#.",
			//	".#E#.#.",
			//	".###.#.",
			//	"......."
			//});
			//(new TCCC_2004_Online_Round_4.BombMan()).shortestPath(new string[] { "B#################################################", "##################################################", "##################################################", "##################################.###############", "##################################################", "##################################################", "##########################.#######################", "##################################################", "####################.#############################", "##################################################", "##################################################", "##################################################", "###############.##################################", "##################################################", "##################################################", "##################################################", "##########.#######################################", "##################################################", "##################################################", "##################################################", "#####.########################.###################", "##################################################", "##################################################", "################################.#################", "##################################################", "##################################################", "#######################################.##########", "##################################################", "##################################################", "##################################################", "#########################################.########", "##################################################", "##################################################", "###########################################.######", "##################################################", "#########################################.########", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "##################################################", "#################################################E" }, 100);
			//(new TCCC_2004_Online_Round_4.BombMan()).shortestPath(new string[] {"E..###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###..", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "###...###...###...###...###...###...###...###...##", "...###...###...###...###...###...###...###...###..", "...###...###...###...###...###...###...###...###.B"}, 100);
			//(new TCCC_2004_Online_Round_4.BombMan()).shortestPath(new string[] {"#...###########.########.####..####.##..###..#.###", "#.#.....#..#.######.#.###.#.####...##...#.###.##.#", ".#########..####..#..#####....#####..#.##..###..##", "...##..#..#..###.########.#.#.#....##..#.##.#####.", "##.#.###..#..##..##.########.#####.###.#..#..#####", "##.######.#.##.#.##.#.######.###.#####.#.#.#######", "#....#.##.#.##.#.###.#.#.####.#####.#.####..#.#..#", "##...####...##.#..#####.###..####.##..##...####...", "#.....##..######.#.#...#...####..#......#....#.###", "#..######.#.#.##.....#.#...####.....##.####.#...##", "#.#.##.###.#.#..#..#.##....##.##.##.#.#..###..#.#.", "..#.#######..#############.###...####..#.#.####...", ".#.##.#.####.#.#.#####.#.#.##.#.######..##.#####.#", "#...##.#####...##########..#####..##..##..##.####.", "#.#....#..#...##.##.#######...#.#######.##.###.#.#", "..#.#.####.#############.####.####.#.#..###.####.#", "#.#.######.###.##.##.####.####.####.########.##.##", "#.#####.##.###.##.#..#.#.###.####.####.#.###..##.#", "####.##.#.#..#####.##..#....#...#########.###.#.#.", ".#.#.#.###.##.##.####..#.......#####...###.####.##", "#...####.##.#.##..#.#.##...#...#.##...#.###..#..##", "..##.#.#..###.##.#...#.#...#.##.###.##..###...#.#.", ".#..##..#..#.#######.####.###..########..######.##", "##....######..#.######.....#...##.#.#..##.####.#..", "#####.######.####.#####.#.#..#####..##..#..####..#", "#.#####.##.###..###.###..B##..##..#..#.#.###..##.#", "##.#.#.######################...###.###..###.#####", "..#..#.##.#######.##..#.###.###.#.##.###..##...##.", "####...###.#..####..#..#.###.###..#.###..#####..##", "#..###.####...#.#.####.##.#..#..###.###.##########", ".###....#...##..#####.##..#..##.###...#.###....##.", "####.##.#.##..#.#####.##....###.#.#..##...#.##..##", "#..#..#.##.##...###.#.##.#.#.##...##..##..###..###", "..###.####.##..#..###..##.###......#.#..##..#.#.#.", "#.##.##.#.#...##.#..###..###.#.#####..#.##.#...###", "######.##..#######.#...##.##....###..#.#.##.######", ".#.##..##.....####.##.#.##.##.#..##.######.##...##", "##.###..####.###.##.#.######.#.###.###..######.###", ".##.#..##.#########..###.##.###.######..#####.....", "######.##.#.####.###..#.##..##.##.#..##.#####....#", "....######...##..#..#.#############.######...###..", ".##.####...#...####.#####..#.#..##.###.#########.#", "####..##..#####.#####.#.##.##.##..#.##..#.#.##.###", ".#.###.###..##..#.#.##.######..#..###.##.#.#..#...", "..##..######.#..###.#..#.########.###.#.##..#.#.#.", ".###...##.###..##.######.###.###...#####.###.##..#", "#..##.#...#.#.##.##...#.###############....###.#.#", "##.###...##..#.#.##.#..###...#.#####.###..##.#.###", ".#.#####.....#####.####.#.#.##.######.#.#..##..###", "E##...##.##..#.###.##.#..#..##...##.##..#.##...#.."}, 100);
			//(new TCCC_2004_Online_Round_4.BombMan()).shortestPath(new string[] { "..#####", "B.#####", "..#####", "#######", "####...", "####.E." }, 4);
			//(new SRM625.PalindromePermutations()).palindromeProbability("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhff");
			//(new SRM624.CostOfDancing()).minimum(39, new int[] {973, 793, 722, 573, 521, 568, 845, 674, 595, 310, 284, 794, 913, 93, 129, 758, 108, 433, 181, 163, 96, 932, 703, 989, 884, 420, 615, 991, 364, 657, 421, 336, 801, 142, 908, 321, 709, 752, 346, 656, 413, 629, 801});
			//(new SRM624.BuildingHeightsEasy()).minimum(12, new int[] { 25, 18, 38, 1, 42, 41, 14, 16, 19, 46, 42, 39, 38, 31, 43, 37, 26, 41, 33, 37, 45, 27, 19, 24, 33, 11, 22, 20, 36, 4, 4 });
			//(new SRM624.BuildingHeights()).minimum(new int[] { 986, 1367, 1033, 2045, 88, 2103, 382, 1577, 990, 2439, 359, 1963, 1332, 2051, 759, 1086, 444, 1713, 1600, 2037, 714, 160, 849, 497, 1280, 1372, 1625, 1968, 1870, 98, 2309, 1707, 1464, 841, 1251, 1552, 1796, 1633, 1980, 285, 423, 1190, 2247, 1755, 740, 1857, 340, 1184, 2422, 791, 2072, 635, 2302, 420, 2483, 1081, 643, 1607, 548, 12, 1704, 356, 1719, 2020, 49, 1821, 2423, 1844, 2305, 1902, 980, 228, 591, 2078, 1982, 182, 1434, 1173, 217, 1355, 1963, 2289, 841, 616, 1560, 823, 1696, 2203, 1282, 1095, 1066, 1837, 303, 1636, 1356, 351, 957, 1278, 1046, 761, 2031, 877, 988, 1473, 454, 1821, 1655, 739, 493, 723, 946, 1307, 1863, 1786, 1922, 923, 1461, 1117, 1977, 1594, 2212, 1894, 2282, 1366, 1030, 2490, 1716, 838, 119, 1613, 450, 2150, 2489, 290, 1122, 1794, 2110, 1628, 1384, 1455, 1203, 2329, 261, 565, 467, 2183, 1487, 779, 2151, 2315, 1224, 714, 1709, 1005, 2079, 1590, 994, 146, 1279, 1113, 1758, 1728, 2114, 598, 2017, 2087, 2391, 479, 67, 127, 1933, 1269, 1307, 2193, 1833, 625, 727, 2172, 1403, 378, 1986, 126, 1091, 46, 2483, 670, 487, 976, 815, 1765, 940, 1425, 2345, 553, 2022, 1861, 1492, 765, 2339, 1558, 891, 1771, 326, 1049, 316, 2158, 1674, 1042, 1829, 576, 1419, 167, 2054, 1362, 1564, 888, 883, 2051, 1863, 549, 167, 1655, 1973, 11, 1059, 347, 724, 50, 1111, 562, 1607, 853, 1185, 1932, 1901, 1500, 442, 2426, 41, 2270, 502, 312, 1288, 1407, 1673, 352, 2294, 55, 1254, 508, 603, 272, 1014, 1428, 283, 2073, 1774, 1006, 2122, 1736, 419, 81, 1440, 455, 2012, 840, 806, 1305, 2118, 2199, 1075, 1471, 10, 1214, 377, 534, 417, 1522, 1940, 1670, 881, 42, 1942, 1895, 321, 1076, 1467, 2094, 933, 2440, 181, 203, 20, 1620, 658, 884, 1312, 1463, 2188, 929, 1161, 2114, 2399, 22, 828, 275, 555, 1244, 648, 2494, 1766, 1528, 1388, 59, 2274, 560, 2486, 92, 1506, 918, 1384, 1686, 2472, 1403, 806, 1981, 1138, 2117, 2296, 2178, 545, 2308, 1791, 443, 2330, 1470, 2069, 1736, 1566, 216, 582, 2183, 595, 821, 2241, 1721, 1380, 1078, 1812, 385, 847, 695, 2071, 818, 950, 376, 299, 2087, 1344, 1446, 616, 1888, 1253, 1259, 2330, 2434, 1580, 750, 1670, 645, 965, 1103, 1679, 411, 1923, 271, 2131, 2154, 1348, 295, 1391, 2194, 989, 961, 512, 790, 188, 2162, 1729, 383, 1107, 2344, 2270, 1211, 1102, 951, 1145, 182, 1700, 314, 2178, 1516, 1416, 1357, 778, 2190, 1627, 409, 1843, 475, 2055, 733, 1520, 1895, 545, 883, 185, 2084, 1896, 1913, 1318, 1854, 1756, 1087, 565, 1710, 2037, 1709, 743, 88, 874, 420, 1603, 1141, 628, 2381, 830, 2255, 1641, 1524, 1581, 47, 1109, 1952, 1941, 505, 335, 2125, 1441, 2230, 1537, 258, 1584, 2145, 197, 1000, 206, 1085, 208, 948, 1173, 2433, 1367, 1627, 1073, 847, 359, 754, 1953, 851, 1129, 1033, 897, 2237, 484, 338, 1594, 2170, 2462, 1886, 752, 351, 2143, 2335, 2495, 2339, 834, 200, 924, 2393, 2499, 948, 2325, 217, 74, 2249, 1063, 433, 502, 515, 1283, 1630, 399, 2180, 219, 2235, 1369, 664, 1904, 1330, 49, 155, 1680, 1043, 1341, 526, 882, 1026, 2077, 657, 2270, 2075, 456, 946, 1144, 529, 694, 2206, 2313, 47, 1573, 2448, 529, 1971, 979, 2099, 557, 2347, 262, 1313, 28, 310, 319, 1708, 1352, 1660, 1085, 1085, 1537, 2014, 593, 1307, 1588, 1048, 2252, 1583, 429, 1798, 1289, 1593, 1844, 1713, 1540, 2372, 35, 1370, 822, 592, 1216, 1083, 1904, 96, 1392, 2222, 1803, 1596, 233, 1739, 1532, 1770, 1252, 2125, 1928, 1692, 2024, 531, 774, 1304, 2328, 914, 397, 524, 126, 788, 1747, 161, 2158, 69, 2104, 2225, 1151, 1507, 2320, 1395, 1228, 474, 1842, 313, 2213, 873, 2082, 2316, 1849, 361, 359, 225, 891, 1133, 1528, 2071, 898, 1924, 1446, 2376, 1564, 692, 1388, 1221, 2112, 991, 2297, 2115, 2497, 2117, 2361, 76, 1442, 1702, 388, 6, 1426, 1321, 2322, 2127, 533, 180, 2351, 1424, 164, 1378, 2346, 2414, 2154, 1291, 2289, 1217, 834, 28, 1289, 1798, 1018, 2437, 1412, 2366, 905, 124, 1293, 2347, 677, 533, 2352, 2102, 705, 1025, 580, 1238, 57, 1782, 1513, 1572, 2012, 1358, 1485, 1665, 1500, 125, 1733, 1185, 152, 1873, 482, 21, 1809, 745, 2386, 214, 868, 1179, 1412, 1544, 563, 115, 2498, 1267, 1140, 577, 4, 48, 2359, 1516, 471, 1870, 1725, 808, 2386, 724, 2284, 470, 761, 2436, 2342, 1242, 2456, 502, 1987, 1194, 2067, 1706, 1224, 978, 750, 1786, 1093, 747, 552, 1084, 175, 1908, 2483, 1385, 923, 453, 2106, 148, 112, 843, 2223, 2396, 1312, 483, 2331, 5, 577, 1138, 1859, 63, 2331, 1425, 620, 2406, 2403, 1369, 1691, 2347, 967, 1095, 930, 2494, 502, 912, 1378, 1424, 216, 2336, 423, 328, 678, 1498, 223, 1990, 1980, 1405, 846, 56, 42, 204, 1470, 1225, 1629, 2090, 1130, 383, 2310, 1673, 229, 777, 267, 10, 770, 768, 921, 999, 1043, 2488, 834, 318, 315, 1512, 1815, 537, 2353, 146, 1941, 2050, 202, 835, 2254, 523, 2059, 234, 112, 2040, 1968, 1274, 1212, 2196, 2050, 330, 2205, 1671, 2449, 1977, 1521, 2344, 1964, 1207, 161, 2279, 218, 827, 1667, 1422, 972, 2460, 971, 25, 794, 2076, 548, 1704, 1161, 2011, 95, 628, 784, 159, 323, 1685, 488, 1379, 2207, 437, 855, 80, 280, 319, 1286, 1792, 1449, 355, 118, 1967, 1776, 1089, 1926, 1598, 2466, 1571, 1174, 513, 2126, 1186, 1375, 2221, 1814, 1011, 2379, 2136, 1547, 366, 2367, 1254, 2154, 721, 1333, 1285, 2391, 1470, 576, 191, 1824, 693, 2158, 2451, 634, 435, 1548, 599, 2006, 1573, 2463, 1631, 259, 189, 1351, 2072, 1199, 81, 559, 246, 1799, 425, 351, 1452, 2498, 535, 237, 2388, 2004, 812, 1431, 179, 357, 1088, 129, 2342, 374, 1676, 440, 2379, 2101, 1754, 362, 2359, 1942, 1712, 782, 641, 645, 192, 2238, 2443, 617, 1440, 1394, 614, 826, 482, 1853, 1681, 1294, 2135, 1859, 502, 2074, 1987, 343, 2448, 1162, 2134, 2326, 2114, 1387, 187, 824, 828, 751, 1605, 320, 1395, 1797, 1409, 1337, 1265, 1700, 1582, 730, 25, 2064, 82, 1705, 2209, 1069, 1063, 210, 642, 549, 1904, 589, 563, 1537, 1767, 176, 423, 1953, 2352, 102, 1555, 1456, 1774, 1801, 2104, 682, 637, 2220, 1234, 1071, 449, 1258, 634, 1883, 463, 342, 451, 377, 1903, 1092, 2278, 1306, 533, 340, 1694, 2299, 1867, 968, 603, 1718, 1069, 2158, 2026, 342, 1458, 481, 2376, 947, 201, 1109, 2017, 2001, 1218, 150, 1383, 532, 1843, 685, 909, 97, 629, 686, 254, 1161, 2377, 1947, 959, 1743, 414, 413, 2313, 334, 70, 690, 2028, 380, 22, 1903, 1326, 1574, 1863, 2194, 1075, 580, 1195, 1309, 2464, 537, 1994, 872, 1985, 122, 1557, 2238, 1282, 285, 536, 1092, 879, 2301, 1504, 691, 134, 426, 232, 2161, 805, 254, 415, 982, 1827, 1129, 675, 1753, 561, 721, 562, 524, 109, 55, 1395, 2093, 1528, 1803, 682, 1661, 2087, 1217, 252, 465, 1017, 607, 8, 2, 2384, 1591, 2163, 2040, 1844, 1429, 521, 23, 58, 47, 1775, 618, 2119, 2336, 1141, 2227, 1242, 1387, 1819, 269, 689, 1352, 1929, 1627, 68, 1032, 943, 2436, 491, 2302, 2438, 374, 1393, 2100, 2414, 2088, 2380, 1786, 962, 2437, 685, 1589, 554, 303, 276, 546, 30, 1518, 1932, 700, 638, 1472, 2052, 1419, 1950, 971, 2450, 1745, 907, 1792, 1546, 2196, 2166, 1790, 647, 931, 230, 526, 1568, 1191, 463, 2252, 279, 2368, 1407, 555, 414, 288, 924, 1197, 987, 1561, 1521, 1890, 479, 970, 1713, 1781, 214, 1471, 2424, 612, 1166, 2089, 1253, 1812, 1871, 1482, 1189, 939, 1525, 503, 690, 655, 371, 948, 1209, 2136, 1235, 984, 832, 2222, 1397, 1204, 463, 727, 2174, 2175, 7, 1239, 1145, 1283, 702, 1162, 871, 807, 1825, 1594, 2288, 514, 32, 164, 1016, 2073, 819, 1386, 521, 879, 2373, 1755, 1863, 2057, 328, 759, 760, 2143, 1485, 433, 1817, 344, 524, 1814, 1626, 77, 475, 1348, 883, 2300, 1793, 671, 313, 1824, 2186, 180, 249, 504, 418, 2121, 235, 290, 227, 2097, 2346, 555, 1707, 606, 1549, 2043, 2390, 865, 1238, 413, 1530, 1715, 490, 2005, 1915, 1372, 1804, 1207, 894, 968, 1883, 580, 2499, 983, 2435, 416, 603, 169, 2058, 829, 1117, 1903, 235, 1675, 1360, 1783, 70, 1250, 1500, 1307, 514, 529, 1874, 2355, 33, 140, 1227, 688, 198, 972, 507, 2080, 403, 1858, 1914, 338, 2273, 16, 1858, 1830, 2197, 475, 85, 1283, 2149, 1444, 1918, 1070, 1545, 917, 1229, 2059, 297, 602, 765, 1682, 2093, 1991, 1221, 2290, 1815, 1728, 722, 2217, 1085, 135, 1406, 2209, 1503, 764, 391, 1199, 90, 475, 1333, 1090, 770, 750, 2160, 1167, 1666, 888, 725, 1963, 341, 1489, 2496, 2433, 2332, 1216, 2222, 498, 443, 443, 1566, 379, 1930, 472, 1440, 932, 87, 1830, 982, 176, 1156, 2314, 117, 777, 1916, 2276, 1943, 2433, 2015, 1519, 747, 2355, 1860, 742, 1139, 543, 1958, 861, 1040, 1252, 155, 1457, 1631, 2084, 1928, 1922, 1867, 866, 1251, 1700, 2393, 2406, 1514, 10, 682, 2281, 1137, 1477, 2213, 652, 495, 460, 1858, 2354, 1201, 497, 396, 658, 209, 287, 1910, 1715, 1744, 2392, 1299, 23, 1813, 2017, 889, 1915, 1217, 2133, 672, 1582, 2142, 205, 1362, 2131, 1681, 2426, 1634, 2176, 385, 991, 881, 1586, 339, 1277, 1095, 1899, 1563, 1856, 1114, 806, 599, 1264, 829, 2411, 780, 569, 677, 848, 201, 1348, 2429, 1195, 1553, 142, 825, 733, 68, 1310, 1760, 1804, 1152, 141, 889, 1491, 1417, 836, 2241, 1831, 1543, 854, 1489, 2142, 2117, 1169, 2052, 397, 1737, 229, 96, 789, 428, 25, 1983, 1980, 1518, 1659, 1565, 437, 1820, 824, 2241, 472, 964, 629, 814, 1232, 316, 554, 1915, 1859, 260, 903, 1500, 2376, 2071, 2403, 1624, 159, 1483, 1720, 2299, 1911, 596, 634, 242, 2113, 1144, 1806, 50, 464, 1482, 2290, 2287, 1297, 1770, 600, 1381, 938, 5, 795, 296, 264, 549, 647, 1492, 1471, 549, 615, 1629, 884, 2334, 279, 294, 429, 912, 1887, 1394, 2056, 1193, 295, 1371, 174, 84, 1157, 1470, 705, 608, 1702, 1642, 612, 2496, 1937, 2228, 544, 1435, 1219, 2014, 836, 1833, 2494, 1719, 519, 273, 864, 2299, 1184, 250, 1192, 2091, 1442, 1486, 961, 467, 421, 2117, 789, 1126, 224, 2490, 267, 2188, 1338, 1056, 767, 1881, 2490, 1985, 247, 825, 169, 240, 1395, 687, 1864, 2258, 486, 1900, 8, 529, 1490, 301, 867, 1303, 2120, 1287, 919, 408, 2412, 2495, 1749, 1531, 1034, 586, 1438, 1800, 2467, 279, 136, 213, 2456, 304, 1804, 1350, 991, 1168, 1108, 328, 567, 2467, 2208, 908, 267, 574, 2210, 2386, 1861, 1981, 1645, 624, 827, 894, 2154, 1860, 1479, 2443, 11, 297, 222, 146, 1861, 177, 449, 17, 1526, 291, 1184, 1485, 1970, 602, 1451, 1678, 361, 570, 2251, 71, 455, 463, 903, 2100, 1087, 1729, 1845, 2092, 2440, 2175, 887, 2450, 2472, 1108, 1447, 684, 1284, 747, 700, 1661, 2390, 735, 646, 1859, 188, 948, 2388, 549, 1517, 991, 1971, 1972, 1453, 373, 423, 1391, 953, 1119, 2335, 892, 793, 721, 2193, 2116, 1828, 2491, 300, 1963, 737, 2351, 2475, 1978, 586, 1972, 1337, 2125, 420, 76, 173, 1936, 1066, 995, 259, 1371, 219, 2033, 1613, 1171, 651, 1447, 914, 296, 1019, 606, 2411, 1698, 1948, 210, 1160, 1537, 1413, 2487, 1014, 850, 1958, 1202, 474, 2377, 1278, 1999, 665, 1195, 493, 2275, 65, 712, 660, 530, 1882, 1310, 1976, 1648, 457, 1847, 1105, 368, 1044, 553, 1929, 2204, 2089, 841, 1042, 602, 1690, 499, 1804, 1016, 1728, 1933, 514, 1244, 627, 1006, 1018, 2044, 569, 529, 73, 1303, 691, 900, 450, 1147, 246, 1554, 1514, 1290, 958, 2295, 2345, 546, 635, 886, 2500, 1177, 1384, 655, 2192, 1963, 87, 1557, 706, 713, 1414, 576, 1608, 1983, 1104, 1680, 2137, 1794, 80, 86, 441, 1677, 491, 1954, 466, 301, 600, 1662, 846, 1235, 47, 2197, 1263, 283, 351, 2306, 2245, 1789, 1362, 451, 2, 275, 2378, 1609, 2257, 981, 2141, 745, 275, 1072, 830, 715, 248, 173, 1520, 2066, 473, 2120, 1227, 170, 2206, 126, 2367, 968, 408, 1569, 773, 152, 858, 986, 1954, 2211, 1260, 1831, 171, 2369, 1664, 2311, 613, 1938, 2234, 295, 1504, 1334, 467, 1875, 899, 2291, 346, 977, 2460, 1403, 1102, 1178, 1222, 1509, 1599, 846, 513, 1308, 1831, 1318, 1018, 591, 2001, 40, 459, 1164, 1203, 2423, 1953, 936, 217, 956, 2269, 2035, 1682, 2019, 1825, 2028, 496, 637, 2282, 1597, 666, 1004, 606, 1116, 1849, 2470, 2423, 1180, 139, 2292, 1770, 2139, 1184, 1080, 2154, 2386, 2354, 1606, 821, 71, 1413, 1942, 957, 595, 1460, 1634, 1474, 807, 1122, 1255, 2404, 639, 2258, 1861, 1755, 1607, 1830, 529, 1638, 820, 1673, 2259, 459, 356, 2190, 112, 241, 2043, 570, 2413, 965, 1982, 706, 1922, 1428, 2166, 2407, 401, 472, 1028, 508, 1727, 1666, 1617, 1087, 2272, 2075, 1768, 301, 1212, 88, 1973, 970, 1898, 2328, 659, 861, 1420, 1554, 1430, 1332, 18, 912, 2038, 791, 2339, 555, 697, 1592, 2378, 1724, 951, 1605, 2242, 67, 1543, 2013, 994, 811, 1165, 2205, 2250, 1989, 2027, 499, 668, 1537 });
			//(new SRM624.BuildingHeights()).minimum(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4000 });
			//(new SRM623.CatchTheBeatEasy()).ableToCatchAll(new int[] { -1, 1, 0 }, new int[] { 1, 3, 4 });
			//(new SRM623.CatchTheBeatEasy()).ableToCatchAll(new int[] {0,0,0,0}, new int[] {0,0,0,0});
			//(new SRM623.CatAndRat()).getTime(1, 1000, 1, 2);
			//(new SRM623.ApplesAndPears()).getArea(new string[] { "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" }, 2);
			//(new SRM623.UniformBoard()).getBoard(new string[] { "PPAAPA..AP", "PPA.APAP..", "..P.AA.PPP", "P.P..APAA.", "P.P..P.APA", "PPA..AP.AA", "APP..AAPAA", "P.P.AP...P", ".P.A.PAPPA", "..PAPAP..P" }, 10);
			//(new SRM622.FibonacciDiv2()).find(1000000);
			//(new SRM622.BoxesDiv2()).findSize(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 });
			//(new SRM629.RectangleCoveringEasy()).solve(3,5,4,6);
			//(new SRM629.CandyMaking()).findSuitableDensity(
			//	new int[] { 1234, 1541, 3321, 1234, 123, 123, 3414, 123, 12, 2442, 1421, 1223, 3232, 1123, 2121 },
			//	new int[] { 3213, 1231, 232143, 44312, 132132, 142424, 123123, 41341, 41244, 21312, 232131, 2312, 2322, 11, 2223 }				
			//	);
			//(new SRM622.Subsets()).findSubset(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 7, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 });
			//(new SRM629.RectangleCovering()).minimumNumber(21, 5, 
			//	new int[] {6, 5, 8},
			//	new int[] { 8, 8, 6 });
			//(new SRM629.CandyAddict()).solve(new int[] { 1 }, new int[] { 1 }, new int[] { 1000000000 });
//			(new SRM629.CandyCollection()).solve(
//				new int[] {12,9,0,16,9,18,12,3,6,0,8,2,10,6,5,2,14,10,5,13},
//new int[] {895,704,812,323,334,674,665,142,712,254,869,548,645,663,758,38,860,724,742,530},
//new int[] {1,4,7,11,15,8,18,13,17,17,19,14,7,11,4,1,15,19,3,16},
//new int[] {779,317,36,191,843,289,107,41,943,265,649,447,806,891,730,371,351,7,102,394});
			//(new SRM621.TwoWaysSorting()).sortingMethod(new string[] { "abcdef", "bcdef", "cdef", "def", "ef", "f", "topcoder" });
			//(new SRM621.NumbersChallenge()).MinNumber(new int[] { 883, 66392, 3531, 28257, 1, 14131, 57, 1, 25, 88474, 4, 1, 110, 6, 1769, 220, 442, 7064, 7, 13 });
			//(new SRM620.CandidatesSelectionEasy()).sort(new string[] { "XXYWZWWYXZ", "YZZZYWYZYW", "ZYZZWZYYWW", "ZWZWZWZXYW", "ZYXWZXWYXY", "YXXXZWXWXW", "XWWYZWXYXY", "XYYXYWYXWY", "ZZYXZYZXYY", "WXZXWYZWYY" }, 3);
			//(new SRM620.PairGameEasy()).able(2,2,2,999);
			//(new SRM620.PairGame()).maxSum(1, 1000000, 1000000, 1);
			//(new SRM619.GoodCompanyDivTwo()).countGood(
			//	new int[] {-1, 0, 0, 1, 1, 3, 0, 2, 0, 5, 2, 5, 5, 6, 1, 2, 11, 12, 10, 4, 7, 16, 10, 9, 12, 18, 15, 23, 20, 7, 4}, 
			//	new int[] {4, 6, 4, 7, 7, 1, 2, 8, 1, 7, 2, 4, 2, 9, 11, 1, 10, 11, 4, 6, 11, 7, 2, 8, 9, 9, 10, 10, 9, 8, 8}
			//	//new int[] {-1, 0, 1, 1, 1, 0, 2, 5},
			//	//new int[] {1, 1, 2, 3, 4, 5, 3, 3}
			//);
			//(new SRM619.ChooseTheBestOne()).countNumber(1234);
			//(new SRM619.SplitStoneGame()).winOrLose(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 3, 1, 9, 1, 3, 1, 1, 1, 1, 1 });
			//(new SRM619.EmployManager()).maximumEarnings(
			//	new int[] { 2, 2, 0, 1, 4, 0, 1, 0, 0, 4 },
			//	new string[] { "0100451253", "1010518123", "0102989242", "0020093171", "4590045480", "5189400676", "1893500826", "2121468008", "5247872007", "3321066870" });
			//(new SRM618.WritingWords()).write("ABC");
			//(new SRM618.LongWordsDiv2()).find("TOPCODER");
			//var srm = new SRM632.PotentialGeometricSequence();
			//var ans = srm.numberOfSubsequences(new int[] { 1, 3, 5, 5, 5, 5, 64, 4, 23, 2, 3, 4, 5, 4, 3 });
			(new SRM633.Target()).draw(5);
		}

		public class SRM572
		{
			public class DIV2
			{
				public class EasyHomework
				{
					public string determineSign(int[] A)
					{
						int negCount = 0;
						foreach (int a in A)
						{
							if (a == 0)
							{
								return "ZERO";
							}
							negCount += (a < 0 ? 1 : 0);
						}
						return negCount % 2 == 0 ? "POSITIVE" : "NEGATIVE";
					}
				}
			}
		}

		public class SRM575
		{
			public static void Run()
			{
				//(new Div2.TheSwapsDivTwo()).find(new int[] { 1, 47 });
				//(new Div2.TheSwapsDivTwo()).find(new int[] { 22, 16, 36, 35, 14, 9, 33, 6, 28, 12, 18, 14, 47, 46, 29, 22, 14, 17, 4, 15, 28, 6, 39, 24, 47, 37 });
				//(new Div2.TheNumberGameDivTwo()).find((long)Math.Pow(10, 18));

			}

			public class Div2
			{
				public class TheSwapsDivTwo
				{
					public int find(int[] sequence)
					{
						int count = 0;
						bool haveEqual = false;
						for (int i = 0; i < sequence.Length; i++)
						{
							for (int j = i + 1; j < sequence.Length; j++)
							{
								if (!haveEqual && sequence[i] == sequence[j])
									haveEqual = true;
								count += sequence[i] != sequence[j] ? 1 : 0;
							}
						}
						return count + (haveEqual ? 1 : 0);
					}
				}

				public class TheNumberGameDivTwo
				{
					private Dictionary<long, bool> pathsCache = new Dictionary<long, bool>();

					private bool search(long n)
					{
						if (pathsCache.ContainsKey(n))
							return pathsCache[n];
						Dictionary<long, bool> paths = new Dictionary<long, bool>();
						for (long i = 2; i <= Math.Sqrt(n); i++)
						{
							if (n % i == 0)
							{
								paths.Add(n - i, true);
								paths.Add(n - (n / i), true);
							}
						}
						if (paths.Count == 0)
							return false;
						bool anyPrime = false;
						List<long> keys = new List<long>();
						foreach (long p in paths.Keys)
						{
							keys.Add(p);
						}
						foreach (long path in keys)
						{
							paths[path] = search(path);
							anyPrime = anyPrime || !paths[path];
						}
						pathsCache.Add(n, anyPrime);
						return anyPrime;
					}

					public string find(long n)
					{
						bool res = search(n);
						return res ? "John" : "Brus";
					}
				}

				public class TheTilesDivTwo
				{
					int[] dx = new int[] { 0, 1, -1, -1, 0 };
					int[] dy = new int[] { 1, 0, 0, -1, 1 };

					int best = 0;

					private void search(int x, int y, string[] board, bool[,] used, int count)
					{
						best = Math.Max(best, count);
						for (int i = x; i < board.Length; i += 2)
						{
							for (int j = y; j < board[0].Length; j += 2)
							{
								if (i == x && j == y)
									continue;
								if (board[i][j] == 'X')
									continue;
								for (int turn = 0; turn < 4; turn++)
								{
									int di1 = i + dx[turn];
									int dj1 = j + dy[turn];
									int di2 = i + dx[turn + 1];
									int dj2 = j + dy[turn + 1];
									if (di1 >= 0 && di1 < board.Length && dj1 >= 0 && dj2 < board[0].Length && !used[di1, dj1] && !used[di2, dj2])
									{
										used[di1, dj1] = true;
										used[di2, dj2] = true;
										search(i, j, board, used, count + 1);
										used[di1, dj1] = false;
										used[di2, dj2] = false;
									}
								}
							}
						}
					}

					public int find(string[] board)
					{
						if (board.Length <= 1 || board[0].Length <= 1)
							return 0;
						bool[,] used = new bool[board.Length, board[0].Length];
						search(0, 0, board, used, 0);

						return 0;
					}
				}
			}
		}

		public class SRM576
		{
			public class TheExperimentDiv2
			{
				public int[] determineHumidity(int[] intensity, int L, int[] leftEnd)
				{
					int[] absorbed = new int[leftEnd.Length];
					int N = intensity.Length;
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < leftEnd.Length; j++)
						{
							if (leftEnd[j] <= i && leftEnd[j] + L - 1 >= i)
							{
								absorbed[j] += intensity[i];
								break;
							}
						}
					}
					return absorbed;
				}
			}

			public class ArcadeManao
			{
				private void search(string[] level, int ladder, int i, int j, bool[,] used)
				{
					//used[i, j] = true;
					int j2 = j;
					while (j2 >= 0 && !used[i, j2] && level[i][j2] == 'X')
					{
						used[i, j2] = true;
						for (int i2 = i - 1; i - i2 <= ladder && i2 >= 0; i2--)
						{
							if (!used[i2, j2] && level[i2][j2] == 'X')
								search(level, ladder, i2, j2, used);
						}
						for (int i2 = i + 1; i2 - i <= ladder && i2 < level.Length; i2++)
						{
							if (!used[i2, j2] && level[i2][j2] == 'X')
								search(level, ladder, i2, j2, used);
						}
						j2--;
					}
					j2 = j + 1;
					while (j2 < level[0].Length && !used[i, j2] && level[i][j2] == 'X')
					{
						used[i, j2] = true;
						for (int i2 = i - 1; i - i2 <= ladder && i2 >= 0; i2--)
						{
							if (!used[i2,j2] && level[i2][j2] == 'X')
								search(level, ladder, i2, j2, used);
						}
						for (int i2 = i + 1; i2 - i <= ladder && i2 < level.Length; i2++)
						{
							if (!used[i2, j2] && level[i2][j2] == 'X')
								search(level, ladder, i2, j2, used);
						}
						j2++;
					}
				}

				public int shortestLadder(string[] level, int coinRow, int coinColumn)
				{
					int maxLadder = level.Length - coinRow;
					for (int i = 1; i < maxLadder; i++)
					{
						bool[,] used = new bool[level.Length, level[0].Length];
						search(level, i, level.Length - 1, 0, used);
						if (used[coinRow - 1, coinColumn - 1])
							return i;
					}
					return maxLadder;
				}
			}

			public class CharacterBoard2
			{
				public int countGenerators(string[] fragment, int W, int i0, int j0)
				{
					long N = fragment.Length;
					long M = fragment[0].Length;
					long count = 0;
					for (long len = 1; len <= W; len++)
					{
						bool[] mult = new bool[len];
						char?[] generator = new char?[len];
						bool notFit = false;
						for (long i = 0; i < N; i++)
						{
							for (long j = 0; j < M; j++)
							{
								long pos = ((i + (long)i0) * (long)W + j + (long)j0) % len;
								//if (pos < 0 || pos >= len)
								//	continue;
								if (generator[pos].HasValue && generator[pos].Value != fragment[(int)i][(int)j])
								{
									notFit = true;
									break;
								}
								generator[pos] = fragment[(int)i][(int)j];
							}
							if (notFit)
								break;
						}
						if (notFit)
							continue;
						long newcount = 1;
						foreach (char? c in generator)
						{
							if (c == null)
								newcount = (newcount * 26) % 1000000009;
						}
						count = (count + newcount) % 1000000009;
					}
					return (int)count;
				}
			}


			public class TheExperiment_old
			{
				int count = 0;

				private void search(int i, bool prevFull, int Mcount, string intensity, int M, int L, int A, int B)
				{
					for (int j = i; j < intensity.Length; j++)
					{
						int i2 = j;
						int sum = 0;
						int len = 0;
						while (i2 < intensity.Length && sum < A && len <= L)
						{
							sum += int.Parse("" + intensity[i2]);
							i2++;
							len++;
						}
						if (sum >= A && sum <= B && len > 0 && len <= L)
						{
							while (sum <= B && i2 <= intensity.Length && len <= L)
							{
								if (Mcount + 1 == M)
								{
									if (len == L || (prevFull && j == i))
										count++;
								}
								else
									search(i2, (prevFull && j == i) || len == L, Mcount + 1, intensity, M, L, A, B);
								if (i2 >= intensity.Length)
									break;
								sum += int.Parse("" + intensity[i2]);
								i2++;
								len++;
							}
						}
						if (!prevFull && (Mcount > 0))
							break;
					}
				}

				public int countPlacements(string[] intensity, int M, int L, int A, int B)
				{
					search(0, false, 0, string.Join("", intensity), M, L, A, B);
					return count;
				}
			}

			public class TheExperiment
			{
				int count = 0;

				Dictionary<int, int> cache = new Dictionary<int, int>();

				private int search(int i, bool prevFull, int Mcount, string intensity, int M, int L, int A, int B)
				{
					//if (cache.ContainsKey(i))
					//{
					//	return cache[i];
					//}
					//if (Mcount == M && prevFull)
					//{
					//	if (!cache.ContainsKey(i))
					//		cache.Add(i, 0);
					//	cache[i]++;
					//	count++;
					//}
					int localcount = 0;
					for (int j = i; j < intensity.Length; j++)
					{
						int i2 = j;
						int sum = 0;
						int len = 0;
						while (i2 < intensity.Length && sum < A && len <= L)
						{
							sum += int.Parse("" + intensity[i2]);
							i2++;
							len++;
						}
						while (sum >= A && sum <= B && i2 <= intensity.Length && len > 0 && len <= L)
						{
							if (Mcount + 1 == M)
							{
								if (len == L || (prevFull && j == i))
								{
									localcount++;
									count++;
								}
							}
							else
								localcount += search(i2, (prevFull && j == i) || len == L, Mcount + 1, intensity, M, L, A, B);
							if (i2 >= intensity.Length)
								break;
							sum += int.Parse("" + intensity[i2]);
							i2++;
							len++;
						}
						if (!prevFull && (Mcount > 0))
							break;
					}
					//cache.Add(i, localcount);
					return localcount;
				}

				public int countPlacements(string[] intensity, int M, int L, int A, int B)
				{
					int res = search(0, false, 0, string.Join("", intensity), M, L, A, B);
					return count;
				}
			}

			public class CharacterBoard
			{
				public int countGenerators(string[] fragment, int W, int i0, int j0)
				{
					long N = fragment.Length;
					long M = fragment[0].Length;
					long count = 0;

					long localLen = (N + i0) * W + M + j0;
					bool notFitLocal = false;
					char?[] generator_base = new char?[localLen];
					for (long i = 0; i < N; i++)
					{
						for (long j = 0; j < M; j++)
						{
							long pos = ((i + (long)i0) * (long)W + j + (long)j0);
							if (generator_base[pos].HasValue && generator_base[pos].Value != fragment[(int)i][(int)j])
							{
								notFitLocal = true;
								break;
							}
							generator_base[pos] = fragment[(int)i][(int)j];
						}
						if (notFitLocal)
							break;
					}
					long localcount = 1;
					if (!notFitLocal)
					{
						foreach (char? c in generator_base)
						{
							if (c == null)
								localcount = (localcount * 26) % 1000000009;
						}
					}

					long len = 1;
					for (len = 1; len <= W && len < localLen; len++)
					{
						char?[] generator = new char?[len];
						bool notFit = false;
						for (long i = 0; i < N; i++)
						{
							for (long j = 0; j < M; j++)
							{
								long pos = ((i + (long)i0) * (long)W + j + (long)j0) % len;
								if (generator[pos].HasValue && generator[pos].Value != fragment[(int)i][(int)j])
								{
									notFit = true;
									break;
								}
								generator[pos] = fragment[(int)i][(int)j];
							}
							if (notFit)
								break;
						}
						if (notFit)
							continue;
						long newcount = 1;
						foreach (char? c in generator)
						{
							if (c == null)
								newcount = (newcount * 26) % 1000000009;
						}
						count = (count + newcount) % 1000000009;
					}
					long addCount = 0;
					if (len <= W && localcount > 0)
						addCount = (W - len) * localcount % 1000000009;
					

					return (int)count;
				}
			}
		}

		public class SRM577
		{
			public class EllysNewNickname
			{
				public int getLength(string nickname)
				{
					List<char> vowels = new List<char>();
					vowels.AddRange(new char[] { 'a', 'e', 'i', 'o', 'u', 'y' });
					int vcons = 0;
					int vminus = 0;
					foreach (char c in nickname)
					{
						if (vowels.Contains(c))
							vcons++;
						else
							vcons = 0;
						if (vcons > 1)
							vminus++;
					}
					return nickname.Length - vminus;
				}
			}

			public class EllysRoomAssignmentsDiv2
			{
				public double getProbability(string[] ratings)
				{
					List<int> ratNums = new List<int>();
					string r = string.Join("", ratings);
					foreach (string rin in r.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
					{
						ratNums.Add(int.Parse(rin));
					}

					if (ratNums.Count <= 20)
						return 1.0;

					int myrating = ratNums[0];
					ratNums.Sort();
					ratNums.Reverse();

					int rooms = ratNums.Count / 20 + (ratNums.Count % 20 != 0 ? 1 : 0);

					double prob = 0.0;

					int ind = ratNums.IndexOf(myrating);
					if (ind == 0)
						prob = 1.0;
					else if (ind / rooms > 0)
						prob = 1.0 / rooms;

					return prob;
				}
			}

			public class EllysCoprimesDiv2
			{
				private int gcd(int a, int b)
				{
					if (a < b)
						return gcd(b, a);
					if (b == 0)
						return a;
					else
						return gcd(b, a % b);
				}

				private int pathLen(int a, int b)
				{
					if (gcd(a, b) == 1)
						return 0;
					int pathlenmin = int.MaxValue;
					for (int i = a + 1; i < b; i++)
					{
						int gcd_ai = gcd(a, i);
						int gcd_ib = gcd(i, b);
						if (gcd_ai == 1 && gcd_ib == 1)
						{
							pathlenmin = 1;
							break;
						}
						else if (gcd_ai == 1 && gcd_ib > 1)
							pathlenmin = Math.Min(1 + pathLen(i, b), pathlenmin);
						else if (gcd_ai > 1 && gcd_ib == 1)
							pathlenmin = Math.Min(1 + pathLen(a, i), pathlenmin);
					}
					return pathlenmin == int.MaxValue ? 0 : pathlenmin;
				}

				public int getCount(int[] numbers)
				{
					//{2200, 42, 2184, 17}
					//2185 -> 2185-2199 <- 2200
					List<int> nums = new List<int>(numbers);
					nums.Sort();
					int addCount = 0;
					for (int i = 0; i < nums.Count - 1; i++)
					{
						if (gcd(nums[i + 1], nums[i]) > 1)
						{
							addCount += pathLen(nums[i], nums[i + 1]);
						}
					}
					return addCount;
				}
			}

			public class EllysRoomAssignmentsDiv1
			{
				public double getAverage(string[] ratings)
				{
					// 15 9 7 5 2
					// (15 9 7) (5 2)
					// (15 9 7), (15 7 9), (9 15 7), (9 7 15), (7 15 9), (7 9 15)
					// (5 2), (2 5)

					List<int> ratNums = new List<int>();
					string r = string.Join("", ratings);
					foreach (string rin in r.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
					{
						ratNums.Add(int.Parse(rin));
					}

					double anotherAverage = getAverage(ratNums); //from official explanation
					return anotherAverage;

					int myrating = ratNums[0];
					ratNums.Sort();
					ratNums.Reverse();

					int rooms = ratNums.Count / 20 + (ratNums.Count % 20 != 0 ? 1 : 0);

					int ind = ratNums.IndexOf(myrating);
					double average = 0.0;
					double[] averageNumbers = new double[ratNums.Count];
					for (int i = 0; i < ratNums.Count; i++)
					{
						average = (double)ratNums[i] * (1.0 / rooms);
						averageNumbers[i / rooms] += average;
					}
					double averageSum = 0.0;
					foreach (double an in averageNumbers)
						averageSum += an * (1.0 / rooms);
					double averageNum = averageSum / (double)rooms;
					return averageNum;
				}

				double getAverage(List<int> ratings)
				{
					// Assume we have already turned the initial string array into
					// a integer array of N ratings.

					int elly = 0; //Elly's index
					int ellysRating = ratings[0];
					int N = ratings.Count;
					// Sort the ratings in decreasing order.
					// We will need Elly's index, update it accordingly
					for (int i = 0; i < N; i++)
					{
						for (int j = i + 1; j < N; j++)
						{
							if (ratings[j] > ratings[i])
							{
								int tmp = ratings[j];
								ratings[j] = ratings[i];
								ratings[i] = tmp;
							}
						}
						if (ratings[i] == ellysRating)
						{
							elly = i;
						}
					}
					// Number of rooms:
					int R = (N + 19) / 20;


					// Find the average for each of the groups:
					List<double> groupAverage = new List<double>();
					int i2 = 0;
					while (i2 < N)
					{
						// Most groups have R coders, the last one might have N%R coders
						int j = Math.Min(i2 + R, N);
						if (i2 <= elly && elly < j)
						{ //Elly is in this group,
							//Elly's room will always pick Elly:
							groupAverage.Add(ellysRating);
						}
						else
						{
							// Find the average of the ratings in this group
							double sum = 0;
							for (int k = i2; k < j; k++)
							{
								sum += ratings[k];
							}
							groupAverage.Add(sum / (j - i2));
						}
						i2 = j;
					}
					// Sum of all the group averages:
					double sumAll = 0;
					for (int i = 0; i < groupAverage.Count; i++)
					{
						sumAll += groupAverage[i];
					}

					int T = N / R;
					double res = 0;
					if (N % R == 0)
					{
						// The groups are evenly split
						res = sumAll / T;
					}
					else if (elly / R == T)
					{
						// Elly is in the last group
						res = sumAll / (T + 1);
					}
					else
					{
						double p1 = (N % R) / (double)R; //Probability Elly's room has T+1
						double p0 = 1 - p1;              //Probability it has T

						res = p1 * (sumAll / (T + 1))
							+ p0 * (sumAll - groupAverage[T]) / T;
					}
					return res;
				}
			}

			public class EllysChessboard
			{
				private int calc(string[] board, int x, int y, bool[,] usedUp)
				{
					bool[,] used = (bool[,])usedUp.Clone();
					used[x, y] = true;
					bool found = true;
					int distSum = 0;
					while (found)
					{
						found = false;
						List<int> x1 = new List<int>();
						List<int> y1 = new List<int>();
						int minDist = 0;
						for (int i = 0; i < board.Length; i++)
						{
							for (int j = 0; j < board[i].Length; j++)
							{
								if (board[i][j] == '#' && !used[i, j])
								{
									found = true;
									int dist = 0;
									for (int i2 = 0; i2 < board.Length; i2++)
									{
										for (int j2 = 0; j2 < board[i].Length; j2++)
										{
											if (i2 == i && j2 == j)
												continue;
											if (used[i2, j2])
											{
												int currentDist = Math.Abs(i2 - i) + Math.Abs(j2 - j);
												if (dist == 0 || currentDist > dist)
												{
													dist = currentDist;
												}
											}
										}
									}
									if (minDist == 0 || dist < minDist)
									{
										minDist = dist;
										x1.Clear();
										x1.Add(i);
										y1.Clear();
										y1.Add(j);
									}
									else if (dist == minDist)
									{
										x1.Add(i);
										y1.Add(j);
									}
								}
							}
						}
						if (found)
						{
							distSum += minDist;
							if (x1.Count > 1)
							{
								for (int d = 0; d < x1.Count; d++)
								{

								}
							}
							else
								used[x1[0], y1[0]] = true;
						}
					}
					return distSum;
				}

				public int minCost(string[] board)
				{
					int mincost = int.MaxValue;
					for (int i = 0; i < board.Length; i++)
					{
						for (int j = 0; j < board[i].Length; j++)
						{
							//if (board[i][j] == '#')
							//	mincost = Math.Min(mincost, calc(board, i, j));
						}
					}
					return mincost == int.MaxValue ? 0 : mincost;
				}
			}
		}

		public class SRM578
		{
			public class DeerInZooDivTwo
			{
				public int[] getminmax(int N, int K)
				{
					int min = Math.Max(N - K, 0);
					int max = Math.Max(N - K / 2 - (K % 2 == 1 ? 1 : 0), 0);
					return new int[] { min, max };
				}
			}

			public class GooseInZooDivTwo
			{
				const long Modulo = 1000000007;

				private void fill(int i, int j, int dist, string[] field, bool[,] used)
				{
					used[i, j] = true;
					
					// Abs(i+dx) + Abs(j+dy) == dist

					for (int dx = -dist; dx <= dist; dx++)
					{
						for (int dy = -(dist - Math.Abs(dx)); dy <= dist - Math.Abs(dx); dy++)
						{
							int i2 = i + dx;
							int j2 = j + dy;
							if (i2 < 0 || i2 >= field.Length || j2 < 0 || j2 >= field[0].Length)
								continue;
							if (field[i2][j2] == 'v' && !used[i2, j2])
								fill(i2, j2, dist, field, used);
						}
					}
				}

				private long Cnk(long n, long k, int[,] hash)
				{
					if (n < k)
						return 0;
					if (n == k)
						return 1;
					if (k == 1)
						return n;
					if (hash[n, k] != 0)
						return hash[n, k];
					long res = (Cnk(n - 1, k, hash) + Cnk(n - 1, k - 1, hash)) % Modulo;
					hash[n, k] = (int)res;
					return res;
				}

				private int getRasp(int n)
				{
					// C(n,k) = (n!) / (k!*(n-k)!) = ((k+1)*(k+2)*...*n) / (1*2*3*...*(n-k))

					// C(4,2) = 1*2*3*4 / (1*2*1*2) = 24 / 4 = 6

					// C(n,k) = C(n-1,k) + C(n-1,k-1)

					long res = 0;
					int[,] hash = new int[n+1, n+1]; 
					for (int k = 1; k <= n; k++)
					{
						long currentRes = Cnk(n, k, hash);
						res = (res + currentRes) % Modulo;
					}

					return (int)res;
				}

				public int count(string[] field, int dist)
				{
					int N = field.Length;
					int M = field[0].Length;
					bool[,] used = new bool[N, M];
					
					int numFlocks = 0;
					for (int i = 0; i < N; i++)
					{
						for (int j = 0; j < M; j++)
						{
							if (field[i][j] == 'v' && !used[i, j])
							{
								numFlocks++;
								fill(i, j, dist, field, used);
							}
						}
					}

					if (numFlocks <= 1)
						return numFlocks;

					int res = getRasp(numFlocks);
					return res;
				}
			}

			public class WolfInZooDivTwo
			{
				const int max = 350;
				int[,] dp = new int[max, max];
				List<int> Li = new List<int>();
				List<int> Ri = new List<int>();
				int n;

				int DP(int last, int pos)
				{
					if (pos > n) return 1;

					int ret = dp[last, pos];
					if (ret != 0) return ret;

					ret = 0;
					bool flag = true;
					for (var i = 0; i < Li.Count; i++)
					{
						if (Ri[i] == pos && Li[i] > last)
							flag = false;
					}

					if (flag) ret = DP(last, pos + 1);
					ret = (ret + DP(pos, pos + 1)) % 1000000007;
					dp[last, pos] = ret;
					return ret;
				}

				public int count(int N, string[] L, string[] R)
				{
					n = N;
					L = string.Join("", L).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					R = string.Join("", R).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

					foreach (var l in L)
						Li.Add(int.Parse(l));
					
					foreach (var r in R)
						Ri.Add(int.Parse(r));

					int res = DP(0, 1);
					return res;
				}
			}
		}

		public class SRM579
		{
			public class PrimalUnlicensedCreatures
			{
				public int maxWins(int initialLevel, int[] grezPower)
				{
					List<int> gpList = new List<int>(grezPower);
					gpList.Sort();
					int level = initialLevel;
					int wins = 0;
					foreach (int gp in gpList)
					{
						if (level <= gp)
							break;
						level += gp / 2;
						wins++;
					}
					return wins;
				}
			}

			public class UndoHistory
			{
				public int minPresses(string[] lines)
				{
					Dictionary<string, string> hash = new Dictionary<string, string>();
					hash.Add("", "");
					int presses = 0;
					string buf = string.Empty;
					foreach (string line in lines)
					{
						string l = line;
						while (l.Length > 0)
						{
							bool lStart = (l.Length == line.Length);
							if (lStart && hash.ContainsKey(l) && l.Length > 2)
							{
								presses += 2;
								break;
							}
							if (lStart && !string.IsNullOrEmpty(buf) && l.StartsWith(buf))
							{
								l = l.Substring(buf.Length);
								continue;
							}
							if (lStart)
							{
								string hMax = string.Empty;
								foreach (string h in hash.Keys)
								{
									if (l.StartsWith(h) && h.Length > (buf == string.Empty ? 1 : 0))
									{
										if (hMax == string.Empty || h.Length > hMax.Length)
											hMax = h;
									}
								}
								if (hMax != string.Empty)
								{
									buf = string.Empty;
									l = l.Substring(hMax.Length);
									presses += 2;
									continue;
								}
							}
							if (lStart && !string.IsNullOrEmpty(buf))
							{
								buf = string.Empty;
								presses += 2;
							}
							buf += l[0];
							if (!hash.ContainsKey(buf))
								hash.Add(buf, buf);
							l = l.Substring(1);
							presses++;
						}
						presses++;
					}
					return presses;
				}
			}
		}

		public class SRM580
		{
			public class ShoutterDiv2
			{
				public int count(int[] s, int[] t)
				{
					int count = 0;
					for (int i = 0; i < s.Length - 1; i++)
					{
						for (int j = i + 1; j < s.Length; j++)
						{
							if ((s[j] > t[i] && t[j] > t[i]) || (s[j] < s[i] && t[j] < s[i]))
							{
								continue;
							}
							count++;
						}
					}
					return count;
				}
			}

			public class EelAndRabbit
			{
				public int getmax(int[] l, int[] t)
				{
					int count = 0;
					
					for (int i = 0; i < l.Length; i++)
					{
						for (int j = i; j < l.Length; j++)
						{
							int x = t[i];
							int y = t[j];
							int c = 0;
							for (int k = 0; k < l.Length; k++)
							{
								bool kInX = t[k] <= x && x <= t[k] + l[k];
								bool kInY = t[k] <= y && y <= t[k] + l[k];
								if (kInX || kInY)
								{
									c++;
								}
							}
							if (c > count)
							{
								count = c;
							}
						}
					}

					return count;
				}
			}
		}

		public class SRM581
		{
			public class SurveillanceSystem
			{
				Dictionary<string, int> variantsHash = new Dictionary<string, int>();
				int[] variants = null;

				private int place(string containers, int s, int[] reports, bool[] usedReports, int L)
				{
					List<int> leftReports = new List<int>();
					for (int i = 0; i < reports.Length; i++)
					{
						if (!usedReports[i])
						{
							leftReports.Add(reports[i]);
						}
					}

					if (leftReports.Count == 0)
					{
						return 0;
					}

					string hashkey = containers.Substring(s) + "Y" + string.Join("U", leftReports);
					if (variantsHash.ContainsKey(hashkey))
					{
						return variantsHash[hashkey];
					}
					
					int variantsCount = 0;
					for (int i = s; i < containers.Length - L + 1; i++)
					{
						int count = 0;
						for (int j = i; j < i + L; j++)
						{
							count += containers[j] == 'X' ? 1 : 0;
						}

						for (int r = 0; r < reports.Length; r++)
						{
							if (!usedReports[r] && reports[r] == count)
							{
								usedReports[r] = true;
								variantsCount += 1 + place(containers, i + 1, reports, usedReports, L);
								usedReports[r] = false;
							}
						}
					}

					variantsHash.Add(hashkey, variantsCount);
					//if (variantsCount > 0)
					//{
					//	for (int i = s; i < s + L; i++)
					//	{
					//		variants[i] += variantsCount;
					//	}
					//}
					variants[s] += variantsCount;

					return variantsCount;
				}

				public string getContainerInfo(string containers, int[] reports, int L)
				{
					variants = new int[containers.Length];
					place(containers, 0, reports, new bool[reports.Length], L);

					string res = null;
					//for (int i = 0; i < usedCount.Length; i++)
					//{

					//	if (usedCount[i] == variantsCount && variantsCount != 0)
					//	{
					//		res += 'x';
					//	}
					//	else if (usedCount[i] == 0)
					//	{
					//		res += '-';
					//	}
					//	else
					//	{
					//		res += '?';
					//	}
					//}
					return res;
				}
			}
		}

		public class SRM582
		{
			public class SemiPerfectSquare
			{
				public string check(int N)
				{
					for (int i = 2; i < Math.Sqrt(N); i++)
					{
						if (N % i == 0 && (N / i) % i == 0)
						{
							int l = N / (i * i);
							if (l >= i)
							{
								continue;
							}
							return "Yes";
						}
					}
					return "No";
				}
			}
		}

		public class SRM596
		{
			public class IncrementAndDoubling
			{
				public int getMin(int[] desiredArray)
				{
					int steps = 0;
					bool found = true;
					while (found)
					{
						found = false;

						for (int i = 0; i < desiredArray.Length; i++)
						{
							if (desiredArray[i] == 0)
								continue;
							if (desiredArray[i] > 1)
								found = true;
							steps += desiredArray[i] % 2;
							desiredArray[i] = desiredArray[i] / 2;
						}
						if (found)
							steps++;
					}
					return steps;
				}
			}

			public class FoxAndSightseeing
			{
				public int getMin(int[] position)
				{
					if (position.Length < 3)
					{
						int sum = 0;
						for (int i = 1; i < position.Length; i++)
						{
							sum += Math.Abs(position[i] - position[i - 1]);
						}
						return sum;
					}
					int minsum = -1;
					for (int k = 1; k < position.Length - 1; k++)
					{
						int sumlocal = 0;
						for (int j = 1; j < position.Length; j++)
						{
							if (j == k)
								continue;
							if (j - 1 == k)
								sumlocal += Math.Abs(position[j] - position[j - 2]);
							else
								sumlocal += Math.Abs(position[j] - position[j - 1]);
						}
						if (minsum == -1 || sumlocal < minsum)
							minsum = sumlocal;
					}
					return minsum;
				}
			}

			public class ColorfulRoad
			{
				int minsum = -1;

				void search(char c, int pos, string road, int sum)
				{
					if (pos == road.Length)
					{
						if (minsum == -1 || sum < minsum)
							minsum = sum;
					}
					char newC = c == 'R' ? 'G' : c == 'G' ? 'B' : 'R';
					for (int i = pos; i < road.Length; i++)
					{
						if (road[i] == newC)
							search(newC, i + 1, road, sum + (i - pos + 1) * (i - pos + 1));
					}
				}

				public int getMin(String road)
				{
					if (string.IsNullOrEmpty(road) || road[0] != 'R')
						return -1;
					search(road[0], 1, road, 0);
					return minsum;
				}
			}

			//i don't know
			public class BitwiseAnd
			{
				/*
				 101 
				 110
				 
				 011
				 
				 */

				//public long[] lexSmallest(long[] subset, int N)
				//{
				//	for (int i = 0; i < subset.Length - 1; i++)
				//		for (int j = i + 1; j < subset.Length; j++)
				//			if ((subset[i] & subset[j]) == 0)
				//				return new long[0];
					
				//	for (int i = subset.Length; i < N; i++)
				//	{
				//		int[] newnum = new int[60];

				//	}
				//}
			}

			public class SparseFactorialDiv2
			{
				/*
				 F(9) =   9*8 *5 = 360
				 F(10) = 10*9 *6*1 = 540
				 F(11) = 11*10*7*2 = 1540
				 F(12) = 12*11*8*3
				 F(13) = 13*12*9*4
				 F(14) = 14*13*10*5
				 F(15) = 15*14*11*6
				 F(16) = 16*15*12*7
				 F(17) = 17*16*13*8*1
				 F(18) = 18*17*14*9*2
				 */

				//public long getCount(long lo, long hi, long divisor)
				//{
				//	//for (long num=lo; num<=hi;
				//}
			}
		}

		public class SRM618
		{
			public class WritingWords
			{
				public int write(String word)
				{
					int ac = (int)'A';
					var total = 0;
					foreach (var ch in word)
					{
						total += (int)ch - ac + 1;
					}
					return total;
				}
			}

			public class LongWordsDiv2
			{
				public String find(String word)
				{
					if (word.Length <= 1)
					{
						return "Likes";
					}
					var prev = word[0];
					for (int i = 1; i < word.Length; i++)
					{
						if (word[i] == prev)
						{
							return "Dislikes";
						}
						prev = word[i];
					}
					for (int i = 0; i < word.Length; i++)
					{
						for (int j = i + 1; j < word.Length; j++)
						{
							for (int i2 = j + 1; i2 < word.Length; i2++)
							{
								if (word[i] != word[i2])
								{
									continue;
								}
								for (int j2 = i2 + 1; j2 < word.Length; j2++)
								{
									if (word[j] == word[j2])
									{
										return "Dislikes";
									}
								}
							}
						}
					}
					return "Likes";
				}
			}
		}

		public class SRM619
		{
			public class GoodCompanyDivTwo
			{
				public int countGood(int[] superior, int[] workType)
				{
					if (superior.Length == 1)
					{
						return 1;
					}
					int count = 0;
					for (int i = 0; i < superior.Length; i++)
					{
						var y = i;
						var emp = new List<int>();
						for (int j = i + 1; j < superior.Length; j++)
						{
							if (superior[j] == i)
							{
								emp.Add(j);
							}
						}
						var wt = emp.Select(e=>workType[e]).ToList();
						wt.Add(workType[i]);
						count += wt.Distinct().Count() == wt.Count ? 1 : 0;
					}
					return count;
				}
			}

			public class ChooseTheBestOne
			{
				public int countNumber(int N)
				{
					var nums = Enumerable.Range(1, N).ToList();
					long k = 0;
					long round = 1;
					while (nums.Count > 1)
					{
						long steps = round * round * round;
						long nextK = (k + steps - 1) % nums.Count;
						nums.RemoveAt((int)nextK);
						k = nextK;
						round++;
					}
					return nums[0];
				}
			}

			public class EmployManager
			{
				public int maximumEarnings(int[] value, String[] earning)
				{
					var total = 0;
					for (int i = 0; i < value.Length; i++)
					{
						for (int j = 0; j < i; j++)
						{
							total -= int.Parse(earning[i][j] + "");
						}
					}
					for (int i = 0; i < value.Length; i++)
					{
						var iTotal = 0;
						for (int j = 0; j < value.Length; j++)
						{
							iTotal += int.Parse(earning[i][j] + "");
						}
						if (value[i] < iTotal)
						{
							total += iTotal - value[i];
						}
					}
					return total;
				}
			}

			public class SplitStoneGame
			{
				public string winOrLose(int[] number)
				{
					if (number.Length <= 2)
					{
						return "LOSE";
					}
					var nums = new List<int>(number);
					var isShinyMove = true;
					while (nums.Count > 2)
					{
						var num = 0;
						for (int i = 0; i < nums.Count; i++)
						{
							if (nums[i] > 1)
							{
								num = nums[i];
								nums.RemoveAt(i);
								break;
							}
						}
						if (num == 0)
						{
							return isShinyMove ? "LOSE" : "WIN";
						}
						nums[0] += 1;
						nums[1] += num - 1;
						isShinyMove = !isShinyMove;
					}
					return isShinyMove ? "LOSE" : "WIN";
				}
			}
		}

		public class SRM620
		{
			public class CandidatesSelectionEasy
			{
				public int[] sort(String[] score, int x)
				{
					var scoreI = new Dictionary<int, string>();
					for (int i = 0; i < score.Length; i++)
					{
						scoreI.Add(i, score[i]);
					}
					var sorted = scoreI.OrderBy(s => s,
						Comparer<KeyValuePair<int, string>>.Create(
						(sk1, sk2) =>
						{
							return sk1.Value[x] == sk2.Value[x] ? sk1.Key.CompareTo(sk2.Key) : sk1.Value[x].CompareTo(sk2.Value[x]);
						})).Select(kv => kv.Key).ToArray();
					return sorted;
				}
			}

			public class PairGameEasy
			{
				bool possible = false;

				private void gen(int a, int b, int c, int d)
				{
					if (possible)
					{
						return;
					}
					if (a == c && b == d)
					{
						possible = true;
						return;
					}
					if (a > c || b > d)
					{
						return;
					}
					gen(a + b, b, c, d);
					gen(a, a + b, c, d);
				}

				public String able(int a, int b, int c, int d)
				{
					possible = false;
					gen(a, b, c, d);
					return possible ? "Able to generate" : "Not able to generate";
				}
			}

			public class PairGame
			{
				public int maxSum2(int a, int b, int c, int d)
				{
					var sw = Stopwatch.StartNew();
					var abH = new HashSet<string>();
					var a1 = a;
					var b1 = b;
					var key = a1 + "-" + b1;
					while (a1 > 0 && b1 > 0)
					{
						key = a1 + "-" + b1;
						abH.Add(key);
						if (a1 > b1)
						{
							a1 = a1 - b1;
						}
						else
						{
							b1 = b1 - a1;
						}
					}
					sw.Stop();

					var c1 = c;
					var d1 = d;
					key = c1 + "-" + d1;
					var isFound = false;
					while (c1 > 0 && d1 > 0)
					{
						key = c1 + "-" + d1;
						if (abH.Contains(key))
						{
							isFound = true;
							break;
						}
						if (c1 > d1)
						{
							c1 = c1 - d1;
						}
						else
						{
							d1 = d1 - c1;
						}
					}
					return isFound ? c1 + d1 : -1;
				}

				public int maxSum(int a, int b, int c, int d)
				{
					while (a > 0 && b > 0 && c > 0 && d > 0)
					{
						if (a == c && b == d)
						{
							return a + b;
						}
						if (Math.Max(a, b) > Math.Max(c, d))
						{
							if (a > b)
							{
								a -= b;
							}
							else
							{
								b -= a;
							}
						}
						else
						{
							if (c > d)
							{
								c -= d;
							}
							else
							{
								d -= c;
							}
						}
					}
					return -1;
				}
			}
		}

		public class SRM621
		{
			public class TwoWaysSorting
			{
				private bool IsBigger(string a, string b)
				{
					for (int i = 0; i < Math.Min(a.Length, b.Length); i++ )
					{
						if (a[i] == b[i])
						{
							continue;
						}
						return (int)a[i] > (int)b[i];
					}
					return a.Length > b.Length;
				}

				public String sortingMethod(String[] stringList)
				{
					var isLex = true;
					var isLength = true;
					for (int i = 0; i < stringList.Length - 1; i++)
					{
						if (stringList[i].Length >= stringList[i + 1].Length)
						{
							isLength = false;
						}
						if (IsBigger(stringList[i], stringList[i + 1]))
						{
							isLex = false;
						}
					}
					if (!isLex && !isLength)
					{
						return "none";
					}
					if (isLex && isLength)
					{
						return "both";
					}
					return isLex ? "lexicographically" : "lengths";					
				}
			}

			public class NumbersChallenge
			{
				HashSet<int> sums = new HashSet<int>();

				private void search(int[] S, int start, int sum)
				{
					sums.Add(sum);

					if (start == S.Length - 1)
					{
						return;
					}

					search(S, start + 1, sum);
					if (start < S.Length - 1)
					{
						search(S, start + 1, sum + S[start + 1]);
					}
				}

				public int MinNumber(int[] S)
				{
					sums.Clear();
					for (int i = 0; i < S.Length; i++)
					{
						search(S, i, S[i]);
					}
					var sumsArr = sums.ToArray();
					Array.Sort(sumsArr);
					int min = 0;
					for (int i = 0; i < sumsArr.Length; i++)
					{
						if (sumsArr[i] - min > 1)
						{
							return min + 1;
						}
						min = sumsArr[i];
					}
					return min + 1;
				}
			}
		}

		public class SRM622
		{
			public class FibonacciDiv2
			{
				public int find(int N)
				{
					if (N >= 0 && N <= 2)
					{
						return 0;
					}
					int a0 = 0;
					int a1 = 1;
					int minDist = -1;
					while (a1 <= N)
					{
						int a0_new = a1;
						int a1_new = a0 + a1;
						a0 = a0_new;
						a1 = a1_new;
						minDist = minDist == -1 ? Math.Min(Math.Abs(a0 - N), Math.Abs(a1 - N)) : Math.Min(minDist, Math.Min(Math.Abs(a0 - N), Math.Abs(a1 - N)));
					}
					return minDist;
				}
			}

			public class BoxesDiv2
			{
				public int findSize(int[] candyCounts)
				{
					Array.Sort(candyCounts);
					var cc = new List<int>(candyCounts);
					while (cc.Count > 1)
					{
						var cc_new = new List<int>();
						for (int i = 0; i < cc.Count; i += 2)
						{
							if (i + 1 == cc.Count)
							{
								cc_new.Add(cc[i]);
								break;
							}
							int b1 = cc[i];
							int b1i = 1;
							while (b1i < b1)
							{
								b1i *= 2;
							}
							int b2 = cc[i + 1];
							int b2i = 1;
							while (b2i < b2)
							{
								b2i *= 2;
							}
							int bNew = Math.Max(b1i, b2i) * 2;
							cc_new.Add(bNew);
						}
						cc = cc_new.OrderBy(n => n).ToList();
					}
					int box = cc[0];
					return box;
				}
			}

			public class Subsets
			{
				int count = 0;

				private void search(int[] diffNums, Dictionary<int, int> nd, int lastused, int lastusedIndex, int sum, double mult)
				{
					for (int n = lastusedIndex + 1; n < diffNums.Length; n++)
					{
						var num = diffNums[n];
						var exit = false;
						int lastMult = 1;
						for (int i = 1; i <= nd[num]; i++)
						{
							var newsum = sum + num * i;
							lastMult *= num;
							var newmult = mult * lastMult;
							if (newsum > newmult)
							{
								count++;
							}
							if (newsum > newmult || num == 1)
							{
								search(diffNums, nd, num, n, newsum, newmult);
							}
							else
							{
								exit = true;
								break;
							}
						}
						if (exit && lastMult == num)
						{
							break;
						}
					}
				}

				public int findSubset(int[] numbers)
				{
					Array.Sort(numbers);
					var nd = new Dictionary<int, int>();
					foreach (var num in numbers)
					{
						if (!nd.ContainsKey(num))
						{
							nd.Add(num, 0);
						}
						nd[num]++;
					}

					var diffNums = nd.Keys.ToArray();

					count = 0;
					search(diffNums, nd, 0, -1, 0, 1);

					return count;
				}
			}

			public class BuildingRoutes
			{
				public int build(String[] dist, int T)
				{
					var roads = new int[dist.Length, dist[0].Length];
					for (int i = 0; i < dist.Length; i++)
					{
						for (int j = 0; j < dist[0].Length; j++)
						{
							roads[i, j] = int.Parse("" + dist[i][j]);
						}
					}

					return 0;
				}
			}
		}

		public class SRM623
		{
			public class CatchTheBeatEasy
			{
				public String ableToCatchAll(int[] x, int[] y)
				{
					var xyList = new List<Tuple<int, int>>();
					for (int i = 0; i < x.Length; i++)
					{
						xyList.Add(new Tuple<int, int>(x[i], y[i]));
					}
					var xyListSorted = xyList.OrderBy(e => e.Item2).ToList();
					var startX = 0;
					var startY = 0;
					while (xyListSorted.Count > 0)
					{
						var xySmallList = new List<Tuple<int, int>>() { xyListSorted[0] };
						xyListSorted.RemoveAt(0);
						foreach (var xyS in xyListSorted.ToArray())
						{
							if (xyS.Item2 == xySmallList[0].Item2)
							{
								xySmallList.Add(xyS);
								xyListSorted.RemoveAt(0);
							}
							else
							{
								break;
							}
						}
						if (xySmallList.Count > 1)
						{
							for (int i = 1; i < xySmallList.Count; i++)
							{
								if (xySmallList[i].Item1 != xySmallList[0].Item1)
								{
									return "Not able to catch";
								}
							}
						}
						if (Math.Abs(xySmallList[0].Item2 - startY) < Math.Abs(xySmallList[0].Item1 - startX))
						{
							return "Not able to catch";
						}
						startX = xySmallList[0].Item1;
						startY = xySmallList[0].Item2;
					}
					return "Able to catch";
				}
			}

			public class CatAndRat
			{
				public double getTime(int R, int T, int Vrat, int Vcat)
				{
					if (Vrat >= Vcat)
					{
						return -1.0;
					}
					double c = 2 * Math.PI * R;
					double dist = T * Vrat;
					if (dist > c / 2)
					{
						dist = c / 2;
						//double min = Math.Min(c - dist % c, dist % c);
						//for (double t1 = 1; t1 < T; t1++)
						//{
						//	double newdist = (T - t1) * Vrat;
						//	double avmin = Math.Min(c - newdist % c, newdist % c);
						//	if (avmin > min)
						//	{
						//		dist = newdist;
						//		min = avmin;
						//	}
						//}
						//dist = min;
					}
					else
					{

						//vcat * tc - dist = vrat * tc => vcat*tc - vrat*tc = dist => (vcat - vrat) * tc = dist
						
					}
					double tCatch = dist / (Vcat - Vrat);
					return tCatch;
				}
			}

			public class ApplesAndPears
			{
				public int getArea(String[] board, int K)
				{
					int Acount = 0;
					int Pcount = 0;
					int Ecount = 0;
					for (int i = 0; i < board.Length; i++)
					{
						for (int j = 0; j < board[0].Length; j++)
						{
							Acount += board[i][j] == 'A' ? 1 : 0;
							Pcount += board[i][j] == 'P' ? 1 : 0;
							Ecount += board[i][j] == '.' ? 1 : 0;
						}
					}

					var Amem = new int[50, 50, 50, 50];
					var Pmem = new int[50, 50, 50, 50];
					var Emem = new int[50, 50, 50, 50];

					int maxArea = 1;

					for (int i = 0; i < board.Length; i++)
					{
						for (int j = 0; j < board[0].Length; j++)
						{							
							for (int i2 = i; i2 < board.Length; i2++)
							{
								for (int j2 = j; j2 < board[0].Length; j2++)
								{
									int A = 0;
									int P = 0;
									int E = 0;
									if (i == 0 && j == 0)
									{										
										for (int i3 = i; i3 <= i2; i3++)
										{
											for (int j3 = j; j3 <= j2; j3++)
											{
												A += board[i3][j3] == 'A' ? 1 : 0;
												P += board[i3][j3] == 'P' ? 1 : 0;
												E += board[i3][j3] == '.' ? 1 : 0;
											}
										}
									}
									else if (i > 0)
									{
										A = Amem[i - 1, j, i2, j2];
										P = Pmem[i - 1, j, i2, j2];
										E = Emem[i - 1, j, i2, j2];
										for (int j3 = j; j3 <= j2; j3++)
										{
											A -= board[i - 1][j3] == 'A' ? 1 : 0;
											P -= board[i - 1][j3] == 'P' ? 1 : 0;
											E -= board[i - 1][j3] == '.' ? 1 : 0;
										}
									}
									else if (j > 0)
									{
										A = Amem[i, j - 1, i2, j2];
										P = Pmem[i, j - 1, i2, j2];
										E = Emem[i, j - 1, i2, j2];
										for (int i3 = i; i3 <= i2; i3++)
										{											
											A -= board[i3][j-1] == 'A' ? 1 : 0;
											P -= board[i3][j-1] == 'P' ? 1 : 0;
											E -= board[i3][j-1] == '.' ? 1 : 0;
										}
									}

									Amem[i, j, i2, j2] = A;
									Pmem[i, j, i2, j2] = P;
									Emem[i, j, i2, j2] = E;

									int area = (i2 - i + 1) * (j2 - j + 1);

									if (K == 0)
									{
										if (A == 0 && P == 0 || A == 0 && E == 0 || P == 0 && E == 0)
										{
											maxArea = Math.Max(area, maxArea);
										}
									}
									else
									{
										if (A + P <= K && Ecount - E >= A + P)
										{
											maxArea = Math.Max(area, maxArea);
										}
										else if (Acount - A >= area - A && P * 2 + E <= K && (P == 0 || E > 0 || Ecount - E >= 1))
										{
											maxArea = Math.Max(area, maxArea);
										}
										else if (Pcount - P >= area - P && A * 2 + E <= K && (A == 0 || E > 0 || Ecount - E >= 1))
										{
											maxArea = Math.Max(area, maxArea);
										}
									}
								}
							}
						}
					}

					return maxArea;
				}
			}

			public class UniformBoard
			{
				public int getBoard(String[] board, int K)
				{
					int Ac = 0;
					int Pc = 0;
					int Ec = 0;
					for (int i = 0; i < board.Length; i++)
					{
						for (int j = 0; j < board[0].Length; j++)
						{
							Ac += board[i][j] == 'A' ? 1 : 0;
							Pc += board[i][j] == 'P' ? 1 : 0;
							Ec += board[i][j] == '.' ? 1 : 0;
						}
					}

					if (Ac == 0)
					{
						return 0;
					}

					int maxArea = 1;

					for (int i = 0; i < board.Length; i++)
					{
						for (int j = 0; j < board[0].Length; j++)
						{
							for (int i2 = i; i2 < board.Length; i2++)
							{
								for (int j2 = j; j2 < board[0].Length; j2++)
								{
									int A = 0;
									int P = 0;
									int E = 0;
									for (int i3 = i; i3 <= i2; i3++)
									{
										for (int j3 = j; j3 <= j2; j3++)
										{
											A += board[i3][j3] == 'A' ? 1 : 0;
											P += board[i3][j3] == 'P' ? 1 : 0;
											E += board[i3][j3] == '.' ? 1 : 0;
										}
									}

									int area = (i2 - i + 1) * (j2 - j + 1);

									if (K == 0)
									{
										if (P == 0 && E == 0)
										{
											maxArea = Math.Max(maxArea, area);
										}
									}
									else
									{
										if (Ac - A >= area - A && E + P * 2 <= K && (P == 0 || E > 0 || Ec - E >= 1))
										{
											maxArea = Math.Max(maxArea, area);
										}
									}
								}
							}
						}
					}

					return maxArea;
				}
			}
		}

		public class SRM624
		{
			public class CostOfDancing
			{
				public int minimum(int K, int[] danceCost)
				{
					Array.Sort(danceCost);
					int sum = 0;
					for (int i = 0; i < K && i < danceCost.Length; i++)
					{
						sum += danceCost[i];
					}
					return sum;
				}
			}

			public class BuildingHeightsEasy
			{
				public int minimum(int M, int[] heights)
				{
					Array.Sort(heights);
					var addDict = new Dictionary<int, int>();
					for (int i = 1; i <= 50; i++)
					{
						var addHeights = new List<int>();
						for (int j = 0; j < heights.Length; j++)
						{
							if (heights[j] > i)
							{
								break;
							}
							addHeights.Add(i - heights[j]);
						}
						if (addHeights.Count >= M)
						{
							var add = addHeights.ToArray();
							Array.Sort(add);
							addDict.Add(i, 0);
							for (int k = 0; k < M; k++)
							{
								addDict[i] += add[k];
							}
						}
					}
					var min = -1;
					foreach (var kv in addDict)
					{
						min = min == -1 ? kv.Value : Math.Min(min, kv.Value);
					}
					return min;
				}
			}

			public class BuildingHeights
			{
				public int minimum(int[] heights)
				{
					Array.Sort(heights);
					var addHeights = new int[heights.Length + 1];
					for (int i = 0; i <= heights.Length; i++)
					{
						addHeights[i] = -1;
					}
					var max = -1;
					for (int i = 0; i < heights.Length; i++)
					{
						max = max == -1 ? heights[i] : Math.Max(heights[i], max);
					}
					for (int i = 1; i <= max; i++)
					{
						var addH = new List<int>();
						for (int j = 0; j < heights.Length; j++)
						{
							if (heights[j] > i)
							{
								break;
							}
							addH.Add(i - heights[j]);
						}
						var addH_arr = addH.ToArray();
						if (addH_arr.Length == 0)
						{
							continue;
						}

						Array.Sort(addH_arr);

						var sum = 0;
						for (int k = 0; k < addH_arr.Length; k++)
						{
							sum += addH_arr[k];
							addHeights[k + 1] = addHeights[k + 1] == -1 ? sum : Math.Min(addHeights[k + 1], sum);
						}
					}

					var res = 0;
					for (int M = 1; M <= heights.Length; M++)
					{						
						res = M == 1 ? addHeights[M] : res ^ addHeights[M];
					}
					return res;					
				}
			}
		}

		public class SRM625
		{
			public class AddMultiply
			{
				public int[] makeExpression(int y)
				{
					for (int i = 2; i <= 500; i++)
					{
						for (int j = 2; j <= 500; j++)
						{
							for (int k = 2; k <= 500; k++)
							{
								if (i * j + k == y)
								{
									return new int[] { i, j, k };
								}
								else if (i * j - k == y)
								{
									return new int[] { i, j, -k };
								}
							}
						}	
					}
					return null;
				}
			}

			public class IncrementingSequence
			{
				public String canItBeDone(int k, int[] A)
				{
					var used = new bool[A.Length];
					Array.Sort(A);
					for (int n = 1; n <= A.Length; n++)
					{
						var found = false;
						for (int i = 0; i < A.Length; i++)
						{
							if ((A[i] == n && !used[i]) || (n > A[i] && (n - A[i]) % k == 0 && !used[i]))
							{
								used[i] = true;
								found = true;
								break;
							}
						}
						if (!found)
						{
							return "IMPOSSIBLE";
						}
					}					
					return "POSSIBLE";
				}
			}

			public class PalindromePermutations
			{
				public double palindromeProbability(String word)
				{
					var d = new Dictionary<char, int>();
					foreach (var c in word)
					{
						if (!d.ContainsKey(c))
						{
							d.Add(c, 0);
						}
						d[c]++;
					}
					var fact = new double[51];
					fact[0] = 1;
					for (int i = 1; i <= 50; i++)
					{
						fact[i] = i * fact[i - 1];
					}
					double denom = fact[word.Length];
					foreach (var kv in d)
					{
						denom /= fact[kv.Value];
					}

					var oddCount = d.Count(dElem => dElem.Value % 2 == 1);
					if (oddCount > 1 || word.Length % 2 != oddCount)
					{
						return 0.0;
					}

					double nom = fact[word.Length / 2];
					foreach (var kv in d)
					{
						nom /= fact[kv.Value / 2];
					}
					double ans = nom / denom;
					return ans;
				}
			}
		}

		public class SRM626
		{
			public class SumOfPower
			{
				public int findSum(int[] array)
				{
					int sum = 0;
					for (int i = 0; i < array.Length; i++)
					{
						sum += array[i] * array.Length + i * (array.Length - 1 - i) * array[i];
					}
					return sum;
				}
			}

			public class FixedDiceGameDiv2
			{
				public double getExpectation(int a, int b)
				{
					double sum = 0;
					double count = 0;
					for (int ai = 1; ai <= a; ai++)
					{
						for (int bi = 1; bi <= b; bi++)
						{
							if (ai > bi)
							{
								sum += ai;
								count++;
							}
						}
					}
					double av = sum / count;
					av = Math.Round(av, 9);
					return av;
				}				
			}

			public class FixedDiceGameDiv1
			{
				public double getExpectation(int a, int b, int c, int d)
				{
					double sum = 0;
					double count = 0;
					for (int ai = 1; ai <= a; ai++)
					{
						for (int bi = 1; bi <= b; bi++)
						{
							for (int ci = 1; ci <= c; ci++)
							{
								for (int di = 1; di <= d; di++)
								{
									if (ai > bi)
									{
										sum += ai;
										count++;
									}
								}
							}
							
						}
					}
					double av = sum / count;
					av = Math.Round(av, 9);
					return av;
				}
			}
		}

		public class SRM627
		{
			public class ManySquares
			{
				public int howManySquares(int[] sticks)
				{
					var sd = new Dictionary<int, int>();
					foreach (var st in sticks)
					{
						if (!sd.ContainsKey(st))
						{
							sd.Add(st, 0);
						}
						sd[st]++;
					}
					var count = 0;
					foreach (var sdk in sd)
					{
						count += sdk.Value / 4;
					}
					return count;
				}
			}

			public class HappyLetterDiv2
			{
				public char getHappyLetter(String letters)
				{
					var cd = new Dictionary<char, int>();
					foreach (var c in letters)
					{
						if (!cd.ContainsKey(c))
						{
							cd.Add(c, 0);
						}
						cd[c]++;
					}
					char happyC = '.';
					foreach (var cdk in cd)
					{
						int sum = 0;
						foreach (var cdk2 in cd)
						{
							if (cdk2.Key == cdk.Key)
							{
								continue;
							}
							sum += cdk2.Value;
						}
						if (cdk.Value > sum)
						{
							happyC = cdk.Key;
							break;
						}
					}
					return happyC;
				}
			}

			public class BubbleSortWithReversals
			{
				int MinSwapCount = -1;

				private int BubbleSort(int[] A)
				{
					var b = A.ToArray();
					int swapCount = 0;
					for (int i = b.Length - 1; i > 1; i--)
					{
						for (int j = 0; j < i; j++)
						{
							if (b[j] > b[j + 1])
							{
								int x = b[j + 1];
								b[j + 1] = b[j];
								b[j] = x;
								swapCount++;
							}
						}
					}
					return swapCount;
				}

				private void MakeReverse(int[] A, int K, int start)
				{
					if (K == 0)
					{
						return;
					}					
					for (int len = 0; len < A.Length - start + 1; len++)
					{
						var b = A.ToArray();
						if (len > 0)
						{							
							Array.Reverse(b, start, len);
							var swapCount = BubbleSort(b);
							MinSwapCount = MinSwapCount == -1 ? swapCount : Math.Min(swapCount, MinSwapCount);
						}
						int newK = len > 0 ? K-1 : K;
						int newStart = len == 0 ? start + 1 : start + len;
						MakeReverse(b, newK, newStart);
					}
				}

				public int getMinSwaps(int[] A, int K)
				{
					MinSwapCount = -1;
					MakeReverse(A, Math.Min(K, A.Length), 0);
					return MinSwapCount;
				}
			}

			public class HappyLetterDiv1
			{
				public String getHappyLetters(String letters)
				{
					var cd = new Dictionary<char, int>();
					foreach (var c in letters)
					{
						if (!cd.ContainsKey(c))
						{
							cd.Add(c, 0);
						}
						cd[c]++;
					}
					List<char> happyC = new List<char>();
					foreach (var cdk in cd)
					{
						int sum = 0;
						foreach (var cdk2 in cd)
						{
							if (cdk2.Key == cdk.Key)
							{
								continue;
							}
							sum += cdk2.Value;
						}
						if (cdk.Value > sum)
						{
							happyC.Add(cdk.Key);
						}
					}
					var happyCArr = happyC.ToArray();
					Array.Sort(happyCArr);
					var happy = new string(happyCArr);
					return happy;
				}
			}
		}

		public class SRM628
		{
			public class BishopMove
			{
				public int howManyMoves(int r1, int c1, int r2, int c2)
				{
					if (r1 == r2 && c1 == c2)
					{
						return 0;
					}
					if (Math.Abs(r1 - r2) % 2 != Math.Abs(c1 - c2) % 2)
					{
						return -1;
					}
					if (Math.Abs(r1 - r2) == Math.Abs(c1 - c2))
					{
						return 1;
					}
					return 2;
				}
			}

			public class BracketExpressions
			{
				private bool check(string expression)
				{
					var opened = new Stack<char>();
					foreach (var c in expression)
					{
						switch (c)
						{
							case '{':
							case '[':
							case '(':
								opened.Push(c);
								break;
							case '}':
								if (opened.Count == 0 || opened.Pop() != '{')
								{
									return false;
								}
								break;
							case ']':
								if (opened.Count == 0 || opened.Pop() != '[')
								{
									return false;
								}
								break;
							case ')':
								if (opened.Count == 0 || opened.Pop() != '(')
								{
									return false;
								}
								break;
						}
					}
					return opened.Count == 0;
				}

				public String ifPossible(String expression)
				{
					var brackets = new char[] { '{', '}','[',']', '(', ')' };
					if (expression.Length == 0)
					{
						return "possible";
					}
					if (expression.Length == 1)
					{
						return "impossible";
					}
					var exprL = new List<string>();
					exprL.Add(expression);
					if (expression.IndexOf('X') > -1)
					{
						var foundX = true;						
						while (foundX)
						{
							var newExprL = new List<string>();
							foundX = false;
							foreach (var expr in exprL)
							{
								var eI = expr.IndexOf('X');
								if (eI > -1)
								{
									foundX = true;
									foreach (var b in brackets)
									{
										var newExpr = expr.Substring(0, eI) + b + (eI < expr.Length - 1 ? expr.Substring(eI + 1) : "");
										newExprL.Add(newExpr);
									}
								}
							}
							if (foundX)
							{
								exprL = newExprL;
							}
						}						
					}
					foreach (var expr in exprL)
					{
						if (check(expr))
						{
							return "possible";
						}
					}
					return "impossible";
				}
			}

			public class InvariantSets
			{
				int count = 1;

				private bool checkSet(int[] f, List<int> set)
				{
					if (set.Count == 0)
					{
						return false;
					}
					foreach (var s in set)
					{
						if (!set.Contains(f[s]))
						{
							return false;
						}
					}
					return true;
				}

				private void makeSets(int[] f, List<int> set, int start)
				{
					for (int i = start; i < f.Length; i++)
					{
						set.Add(i);
						if (checkSet(f, set))
						{
							count++;
						}
						makeSets(f, set, i + 1);
						set.Remove(i);
					}
				}

				public long countSets2(int[] f)
				{
					count = 1;
					makeSets(f, new List<int>(), 0);
					return count;
				}

				private long Cnk(int n, int k)
				{
					/*
					 Cnk = n! / (k! * (n-k)!) = ((k+1)*(k+1)* ... *n) / (n-k)!
					 */

					if (n == k)
					{
						return 1;
					}
					if (k > n)
					{
						return 0;
					}

					var nom = new List<int>();
					for (int nomi = k + 1; nomi <= n; nomi++)
					{
						nom.Add(nomi);
					}
					var denom = new List<int>();
					for (int denomi = 2; denomi <= (n - k); denomi++)
					{
						denom.Add(denomi);
					}
					
					long c = 1;
					var i = -1;
					foreach (var nomd in nom)
					{
						c *= nomd;
						i = -1;
						for (int denomi = denom.Count - 1; denomi >= 0; denomi--)
						{
							if (c % denom[denomi] == 0)
							{
								i = denomi;
								break;
							}
						}
						if (i >= 0)
						{
							c /= denom[i];
							denom.RemoveAt(i);
						}
					}
					if (i == -1)
					{
						long d = 1;
						foreach (var denomd in denom)
						{
							d *= denomd;
						}
						c /= d;						
					}


					return c;
				}

				public long countSets(int[] f)
				{
					long countCnk = 1;

					for (int i = 1; i < f.Length; i++)
					{
						long cnk = Cnk(f.Length, i);
						countCnk += cnk;
					}

					return countCnk;
				}

				/*
				 {1,2,0}
   				 {0,1,2}
 
				 */
			}

			public class DivisorsPower
			{
				private double GetNthRoot(double d, double n)
				{
					double l = Math.Log(d, 10);
					double ln = l / n;
					double ans = Math.Pow(10, ln);
					double ans2 = Math.Round(ans, 0);
					return ans2;
				}

				private long DivisortCount(long num)
				{
					long count = 2;
					for (long i = 2; i <= Math.Sqrt(num); i++)
					{
						if (num % i == 0)
						{
							count += i * i == num ? 1 : 2;
						}
					}
					return count;
				}

				private bool Check(long n, long pow, out long ansL)
				{
					double ans = GetNthRoot(n, pow);
					ansL = (long)ans;
					long n2 = ansL;
					for (int i = 2; i <= pow; i++)
					{
						n2 *= ansL;
					}
					if (DivisortCount(ansL) == pow && n2 == n)
					{
						return true;
					}
					return false;
				}

				public long findArgument(long n)
				{
					long res = -1;
					
					long pow = 2;
					long ansL = -1;
					if (Check(n, pow, out ansL))
					{
						return ansL;
					}
					while (ansL >= 2)
					{
						pow++;
						if (Check(n, pow, out ansL))
						{
							return ansL;
						}
					}

					return res;
				}
			}

			public class CircuitsConstruction
			{
				public int maximizeResistance(String circuit, int[] conductors)
				{
					var counts = new Stack<int>();
					for (int i = circuit.Length - 1; i >= 0; i--)
					{
						if (circuit[i] == 'X')
						{
							counts.Push(1);
						}
						else
						{
							var p = counts.Pop();
							var q = counts.Pop();
							if (circuit[i] == 'A')
							{
								counts.Push(p + q);
							}
							else
							{
								counts.Push(Math.Max(p, q));
							}
						}
					}
					var c = counts.Pop();
					Array.Sort(conductors);
					var sum = 0;
					for (int i = conductors.Length - 1; i > conductors.Length - 1 - c; i--)
					{
						sum += conductors[i];
					}
					return sum;
				}
			}
		}

		public class SRM629
		{
			public class RectangleCoveringEasy
			{
				public int solve(int holeH, int holeW, int boardH, int boardW)
				{
					if ((Math.Min(holeH, holeW) <= Math.Min(boardH, boardW)
						&& Math.Max(holeH, holeW) < Math.Max(boardH, boardW)) ||
					Math.Min(holeH, holeW) < Math.Min(boardH, boardW)
						&& Math.Max(holeH, holeW) <= Math.Max(boardH, boardW))
					{
						return 1;
					}
					return -1;
				}
			}

			public class CandyMaking
			{
				public double findSuitableDensity(int[] containerVolume, int[] desiredWeight)
				{
					if (containerVolume.Length <= 1)
					{
						return 0;
					}
					double minDiff = -1;
					for (int c = 0; c < containerVolume.Length; c++)
					{
						double density = (double)desiredWeight[c] / (double)containerVolume[c];
						double difference = 0;
						for (int i = 0; i < containerVolume.Length; i++)
						{
							difference += Math.Abs((double)desiredWeight[i] - (double)containerVolume[i] * density);
						}
						minDiff = minDiff == -1 ? difference : Math.Min(difference, minDiff);
					}
					return minDiff;
				}
			}

			public class CandyAddict
			{
				private long calc(long x, long y, long z)
				{
					long sum = 0;
					long candyCount = 0;
					for (int d = 0; d < z; d++)
					{
						sum += x;
						if (candyCount == 0)
						{
							candyCount += sum / y;
							sum = sum % y;
						}
						candyCount--;
					}
					return sum;
				}

				public long[] solve(int[] X, int[] Y, int[] Z)
				{
					var ans = new long[X.Length];
					for (int i = 0; i < X.Length; i++)
					{
						ans[i] = calc(X[i], Y[i], Z[i]);
					}
					return ans;
				}
			}

			public class RectangleCovering
			{
				public int minimumNumber(int holeH, int holeW, int[] boardH, int[] boardW)
				{
					var canPossiblyHover = false;
					var boards = new List<Tuple<int, int>>();
					for (int i = 0; i < boardH.Length; i++)
					{
						boards.Add(new Tuple<int, int>(boardH[i], boardW[i]));
						if (Math.Min(boardH[i], boardW[i]) > Math.Min(holeH, holeW) && Math.Max(boardH[i], boardW[i]) >= Math.Max(holeH, holeW)
							|| Math.Min(boardH[i], boardW[i]) >= Math.Min(holeH, holeW) && Math.Max(boardH[i], boardW[i]) > Math.Max(holeH, holeW))
						{
							return 1;
						}
						if (Math.Max(boardH[i], boardW[i]) > Math.Min(holeH, holeW))
						{
							canPossiblyHover = true;
						}
					}
					if (!canPossiblyHover)
					{
						return -1;
					}

					var boardsPH = boards.Where(b => Math.Max(b.Item1, b.Item2) > holeH).
						OrderByDescending(b => Math.Min(b.Item1, b.Item2) > holeH ? Math.Max(b.Item1, b.Item2) : Math.Min(b.Item1, b.Item2)).ToList();
					var countPH = 0;
					var sumPHFound = false;
					if (boardsPH.Count > 0)
					{
						var sumPH = 0;
						var i = 0;
						while (sumPH < holeW && i < boardsPH.Count)
						{
							sumPH += Math.Min(boardsPH[i].Item1, boardsPH[i].Item2) > holeH ? Math.Max(boardsPH[i].Item1, boardsPH[i].Item2) : Math.Min(boardsPH[i].Item1, boardsPH[i].Item2);
							i++;
						}
						if (sumPH >= holeW)
						{
							countPH = i;
							sumPHFound = true;
						}
					}

					var boardsPW = boards.Where(b => Math.Max(b.Item1, b.Item2) > holeW).
						OrderByDescending(b => Math.Min(b.Item1, b.Item2) > holeW ? Math.Max(b.Item1, b.Item2) : Math.Min(b.Item1, b.Item2)).ToList();
					var countPW = 0;
					var sumPWFound = false;
					if (boardsPW.Count > 0)
					{
						var sumPW = 0;
						var i = 0;
						while (sumPW < holeH && i < boardsPW.Count)
						{
							sumPW += Math.Min(boardsPW[i].Item1, boardsPW[i].Item2) > holeW ? Math.Max(boardsPW[i].Item1, boardsPW[i].Item2) : Math.Min(boardsPW[i].Item1, boardsPW[i].Item2);
							i++;
						}
						if (sumPW >= holeH)
						{
							countPW = i;
							sumPWFound = true;
						}
					}

					if (!sumPHFound && !sumPWFound)
					{
						return -1;
					}

					if (sumPHFound && !sumPWFound)
					{
						return countPH;
					}

					if (!sumPHFound && sumPWFound)
					{
						return countPW;
					}

					return Math.Min(countPH, countPW);
				}
			}

			public class CandyCollection
			{
				public int solve(int[] Type1, int[] Number1, int[] Type2, int[] Number2)
				{
					var flavourShapeCountD = new List<Tuple<int, int, int>>();
					for (int i = 0; i < Type1.Length; i++)
					{
						var shape = i;
						var flavour1 = Type1[i];
						var count1 = Number1[i];
						var flavour2 = Type2[i];
						var count2 = Number2[i];
						flavourShapeCountD.Add(new Tuple<int, int, int>(flavour1, shape, count1));
						flavourShapeCountD.Add(new Tuple<int, int, int>(flavour1, shape, Math.Min(count1, count2)));
						flavourShapeCountD.Add(new Tuple<int, int, int>(flavour2, shape, count2));
						flavourShapeCountD.Add(new Tuple<int, int, int>(flavour2, shape, Math.Min(count1, count2)));
					}
					var sorted = flavourShapeCountD.OrderBy(fsc => fsc.Item3);
					var usedShapes = new bool[Type1.Length, 2];
					var usedFlavours = new bool[Type1.Length];
					var allCount = 0;
					foreach (var fsc in sorted)
					{
						if (usedFlavours.All(uf => uf))
						{
							break;
						}
						if (usedFlavours[fsc.Item1])
						{
							continue;
						}						
						if (usedShapes[fsc.Item2, 0] && usedShapes[fsc.Item2, 1])
						{
							continue;
						}
						usedFlavours[fsc.Item1] = true;
						if (Type1[fsc.Item2] == fsc.Item1)
						{
							usedShapes[fsc.Item2, 0] = true;
						}
						else
						{
							usedShapes[fsc.Item2, 1] = true;
						}
					}
					for (int i = 0; i < usedShapes.Length; i++)
					{
						if (usedShapes[i, 0] && usedShapes[i,1])
						{
							allCount += Math.Min(Number1[i], Number2[i]) + 1;
						}
						else if (usedShapes[i, 0])
						{
							//allCount += num
						}
					}
					return allCount;
				}
			}
		}

		public class SRM630
		{
			public class DoubleLetter
			{
				public String ableToSolve(String S)
				{
					if (S.Length % 2 == 1)
					{
						return "Impossible";
					}
					while (S.Length > 0)
					{
						var findI = -1;
						for (int i = 1; i < S.Length; i++)
						{
							if (S[i] == S[i - 1])
							{
								findI = i;
								break;
							}
						}
						if (findI == -1)
						{
							return "Impossible";
						}
						var newS = S.Substring(0, findI - 1) + S.Substring(findI + 1);
						S = newS;
					}
					return "Possible";
				}
			}

			public class Egalitarianism3Easy
			{
				Dictionary<int, int> sums = new Dictionary<int, int>();

				private void search(int[,] dist, int ai, int sum)
				{
					//for (int j=ai; j<
				}

				public int maxCities(int n, int[] a, int[] b, int[] len)
				{
					var dist = new int[a.Length + 1, b.Length + 1];
					for (int i = 0; i < a.Length; i++)
					{
						dist[a[i], b[i]] = len[i];
						dist[b[i], a[i]] = len[i];
					}
					for (int i = 1; i <= a.Length; i++)
					{
						search(dist, i, 0);
					}

					return 0;
				}
			}
		}

		public class SRM632
		{
			public class RunningAroundPark
			{
				public int numberOfLap(int N, int[] d)
				{
					int laps = 1;
					for (int i = 1; i < d.Length; i++)
					{
						if (d[i] <= d[i-1])
						{
							laps++;
						}
					}
					return laps;
				}
			}

			public class PotentialGeometricSequence
			{
				public int numberOfSubsequences(int[] d)
				{
					var total = d.Length;
					for (int i = 0; i < d.Length - 1; i++)
					{
						for (int j = i + 1; j < d.Length; j++)
						{
							int dif = d[i+1] - d[i];
							var found = true;
							for (int k = i+2; k <= j; k++)
							{
								if (d[k] - d[k - 1] != dif)
								{
									found = false;
									break;
								}
							}
							if (found)
							{
								total++;
							}
						}
					}
					return total;
				}
			}

			public class GoodSubset
			{
				public int numberOfSubsets(int goodValue, int[] d)
				{
					long total = 0;
					var dhash = new Dictionary<long, long>();
					long oneValuesCount = 0;
					foreach (var dv in d)
					{
						oneValuesCount += dv == 1 ? 1 : 0;
						if (dv > goodValue || dv <= 0)
						{
							continue;
						}
						if (!dhash.ContainsKey(dv))
						{
							dhash.Add(dv, 0);
						}
						dhash[dv]++;
					}
					var dvalues = dhash.Keys.OrderByDescending(v => v).ToArray();					
					for (int i = 0; i < dvalues.Length; i++)
					{
						var value = dvalues[i];
						if (value == 1)
						{
							continue;
						}
						if (value == goodValue)
						{
							total = (total + dhash[value]) % 1000000007;
						}
						if (goodValue % value != 0)
						{
							continue;
						}
						long koef = d[value];
						long valuePrev = goodValue;
						while (value > 1)
						{							
							value = valuePrev / value;
							valuePrev = value;
							if (!dhash.ContainsKey(value) || value != 1)
							{
								break;
							}
							koef = (koef * dhash[value]) % 1000000007;
							if (value == 1)
							{
								total = koef + oneValuesCount;
								break;
							}
							
						}
					}

					return 0;
				}
			}
		}

		public class SRM633
		{
			public class Target
			{
				private void drawrect(int x, int y, int n, int len, char[,] res)
				{
					for (int i = x; i < x + len; i++)
					{
						res[i, y] = '#';
						res[i, n - y - 1] = '#';
					}

					for (int i = y; i < len + y; i++)
					{
						res[x, i] = '#';
						res[n - x - 1, i] = '#';
					}
				}

				public string[] draw(int n)
				{
					var res = new char[n, n];
					for (int i = 0; i < n; i++)
					{
						for (int j = 0; j < n; j++)
						{
							res[i, j] = ' ';
						}
					}
					var len = n;
					for (int i = 0; i < n; i+=2)
					{
						drawrect(i, i, n, len, res);
						len -= 4;
						if (len < 1)
						{
							break;
						}
					}
					var r = new string[n];
					for (int i = 0; i < n; i++)
					{
						var s = string.Empty;
						for (int j = 0; j < n; j++)
						{
							s += res[i, j];
						}
						r[i] = s;
					}
					return r;
				}
			}
		}

		public class TCO2013
		{
			public class Round2B
			{
				public class FruitTrees
				{
					//public int maxDist(int apple, int kiwi, int grape)
					//{
					//	if (apple == 1 || kiwi == 1 || grape == 1)
					//		return 0;
					//	int N = 2000;

					//	int[] p = new int[] { apple, kiwi, grape };
					//	int treeMax = p.Max();
					//	int[] pnew = (int[])p.Clone();
					//	for (int j = 0; j < p.Length; j++)
					//		while (pnew[j] < treeMax)
					//			pnew[j] += p[j];
					//}

					//Official Solution - not mine!

					int gcd(int a, int b)
					{
						while (b != 0)
						{
							int c = b;
							b = a % b;
							a = c;
						}
						return a;
					}

					int mind(int x, int m, int y, int n)
					{
						//assume x < y, else just swap
						if (x < y)
						{
							return mind(y, n, x, m);
						}
						//Offset y -> 0, x -> x - y
						x -= y;
						int g = gcd(m, n);
						return Math.Min(x % g, (g - x % g) % g);

					}

					public int maxDist(int apple, int kiwi, int grape)
					{
						int res = -1;
						//fix grape tree at 0:
						for (int a = 0; a < apple; a++)
						{
							for (int k = 0; k < kiwi; k++)
							{
								// minimum distance between apple and grape trees
								int p = mind(a, apple, 0, grape);
								// minimum distance between kiwi and grape trees
								int q = mind(k, kiwi, 0, grape);
								// minimum distance between apple and kiwi trees
								int r = mind(a, apple, k, kiwi);
								// The minimum of them all is the result:
								res = Math.Max(res, Math.Min(Math.Min(p, q), r));
							}
						}
						return res;
					}
				}
			}

			public class Round2C
			{
				public class DancingFoxes
				{
					int minStep = -1;

					private void search(int i, string[] friendship, bool[] used, int step)
					{
						if (minStep > -1 && step > minStep)
							return;
						if (i == 1)
						{
							if (minStep == -1 || step < minStep)
								minStep = step;
							return;
						}
						for (int j = 0; j < friendship.Length; j++)
						{
							if (i != j && friendship[i][j] == 'Y' && !used[j])
							{
								used[j] = true;
								search(j, friendship, used, step + 1);
								used[j] = false;
							}
						}
					}

					public int minimalDays(string[] friendship)
					{
						int N = friendship.Length;
						if (friendship[0][1] == 'Y')
							return 0;
						bool[] used = new bool[N];
						used[0] = true;
						minStep = -1;
						search(0, friendship, used, -1);
						return minStep;
					}
				}
			}
		}		
	
		public class TCCC_2004_Online_Round_4
		{
			public class Dijkstra
			{
				public int findMinRouteLength(string[] maze)
				{
					var length = new int[maze.Length, maze[0].Length];
					var bi = 0;
					var bj = 0;
					var ei = 0;
					var ej = 0;
					var q = new List<Tuple<int, int>>();
					for (int i = 0; i < maze.Length; i++)
					{
						for (int j = 0; j < maze[0].Length; j++)
						{
							if (maze[i][j] == '#')
							{
								continue;
							}
							q.Add(new Tuple<int, int>(i, j));
							if (maze[i][j] == 'B')
							{
								bi = i;
								bj = j;
							}
							else
							{								
								length[i, j] = int.MaxValue / 2;
								if (maze[i][j] == 'E')
								{
									ei = i;
									ej = j;
								}
							}
						}
					}

					var di = new int[] { 1, 0, -1, 0 };
					var dj = new int[] { 0, -1, 0, 1 };

					while (q.Count > 0)
					{
						Tuple<int,int> min = q[0];
						var minLen = length[min.Item1, min.Item2];
						for (int k = 1; k < q.Count; k++)
						{
							min = length[q[k].Item1, q[k].Item2] < length[min.Item1, min.Item2] ? q[k] : min;
						}
						q.Remove(min);

						for (int k = 0; k < di.Length; k++)
						{
							var ni = min.Item1 + di[k];
							var nj = min.Item2 + dj[k];
							if (ni < 0 || ni >= maze.Length || nj < 0 || nj >= maze[0].Length || maze[ni][nj] == '#')
							{
								continue;
							}
							var alt = length[min.Item1, min.Item2] + 1;
							if (alt < length[ni, nj])
							{
								length[ni, nj] = alt;
							}
						}
					}
					var eDist = length[ei, ej];
					return eDist == 0 ? -1 : eDist;
				}
			}

			public class PriorityQueue<T> where T : IComparable<T>
			{
				List<T> data = new List<T>();

				public int Count { get { return data.Count; } }

				public void Enqueue(T item)
				{
					data.Add(item);
					int ci = data.Count - 1;
					while (ci > 0)
					{
						int pi = (ci - 1) / 2;
						if (data[ci].CompareTo(data[pi]) >= 0)
							break;
						T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
						ci = pi;
					}
				}

				public T Dequeue()
				{
					// Assumes pq isn't empty
					int li = data.Count - 1;
					T frontItem = data[0];
					data[0] = data[li];
					data.RemoveAt(li);

					--li;
					int pi = 0;
					while (true)
					{
						int ci = pi * 2 + 1;
						if (ci > li) break;
						int rc = ci + 1;
						if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
							ci = rc;
						if (data[pi].CompareTo(data[ci]) <= 0) break;
						T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
						pi = ci;
					}
					return frontItem;
				}
			}

			public class BombMan
			{
				public class Node: IComparable<Node>
				{
					public int priority { get; set; }
					public Tuple<int, int, int> value { get; set; }

					public int CompareTo(Node other)
					{
						return this.priority.CompareTo(other.priority);
					}
				}

				public int shortestPath2(String[] maze, int bombs)
				{
					var length = new int[maze.Length, maze[0].Length, bombs + 1];
					var bi = 0;
					var bj = 0;
					var ei = 0;
					var ej = 0;
					var q = new Dictionary<int, List<Tuple<int, int, int>>>();
					var pq = new Dictionary<int, PriorityQueue<Node>>();
					for (int i = 0; i < maze.Length; i++)
					{
						for (int j = 0; j < maze[0].Length; j++)
						{
							for (int k = 0; k <= bombs; k++)
							{
								if (!pq.ContainsKey(k))
								{
									pq.Add(k, new PriorityQueue<Node>());
								}
								if (!q.ContainsKey(k))
								{
									q.Add(k, new List<Tuple<int, int, int>>());
								}
								q[k].Add(new Tuple<int, int, int>(i, j, k));
								if (maze[i][j] == 'B')
								{
									bi = i;
									bj = j;
								}
								else
								{
									length[i, j, k] = int.MaxValue / 2;
									if (maze[i][j] == 'E')
									{
										ei = i;
										ej = j;
									}
								}
							}
						}
					}

					var di = new int[] { 1, 0, -1, 0 };
					var dj = new int[] { 0, -1, 0, 1 };

					var found = true;
					while (found)
					{
						found = false;
						for (int b = 0; b <= bombs; b++)
						{
							if (q[b].Count == 0)
							{
								continue;
							}
							Tuple<int, int, int> min = null;
							var ki = 0;
							for (int k = 0; k < q[b].Count; k++)
							{
								if (min == null || length[q[b][k].Item1, q[b][k].Item2, q[b][k].Item3] < length[min.Item1, min.Item2, min.Item3])
								{
									min = q[b][k];
									ki = k;
								}
							}
							q[b].RemoveAt(ki);

							for (int k = 0; k < di.Length; k++)
							{
								var ni = min.Item1 + di[k];
								var nj = min.Item2 + dj[k];
								if (ni < 0 || ni >= maze.Length || nj < 0 || nj >= maze[0].Length)
								{
									continue;
								}
								if (maze[ni][nj] == '#')
								{
									if (b == bombs)
									{
										continue;
									}
									var alt = length[min.Item1, min.Item2, b] + 3;
									if (alt < length[ni, nj, b + 1])
									{
										length[ni, nj, b + 1] = alt;
										//pq[b+1].Enqueue(
									}
									found = true;
								}
								else
								{
									var alt = length[min.Item1, min.Item2, b] + 1;
									if (alt < length[ni, nj, b])
									{
										length[ni, nj, b] = alt;
									}
									found = true;
								}
							}
						}
					}
					var eDist = 0;
					for (int b = 0; b <= bombs; b++)
					{
						eDist = eDist == 0 || length[ei, ej, b] < eDist ? length[ei, ej, b] : eDist;
					}
					return eDist == int.MaxValue / 2 ? -1 : eDist;
				}

				public int shortestPath(String[] maze, int bombs)
				{
					var length = new int[maze.Length, maze[0].Length, bombs + 1];
					var visited = new bool[maze.Length, maze[0].Length, bombs + 1];
					var bi = 0;
					var bj = 0;
					var ei = 0;
					var ej = 0;
					var pq = new Dictionary<int, PriorityQueue<Node>>();
					for (int i = 0; i < maze.Length; i++)
					{
						for (int j = 0; j < maze[0].Length; j++)
						{
							for (int k = 0; k <= bombs; k++)
							{
								if (!pq.ContainsKey(k))
								{
									pq.Add(k, new PriorityQueue<Node>());
								}
								
								if (maze[i][j] == 'B')
								{
									bi = i;
									bj = j;
									//if (k == 0)
									//{
									//	pq[k].Enqueue(new Node() { priority = 0, value = new Tuple<int, int, int>(i, j, k) });
									//}
									pq[k].Enqueue(new Node() { priority = k == 0 ? 0 : int.MaxValue / 2, value = new Tuple<int, int, int>(i, j, k) });
								}
								else
								{
									length[i, j, k] = int.MaxValue / 2;
									if (maze[i][j] == 'E')
									{
										ei = i;
										ej = j;
									}
									pq[k].Enqueue(new Node() { priority = int.MaxValue / 2, value = new Tuple<int, int, int>(i, j, k) });
								}
							}
						}
					}

					var di = new int[] { 1, 0, -1, 0 };
					var dj = new int[] { 0, -1, 0, 1 };

					var found = true;
					while (found)
					{
						found = false;
						for (int b = 0; b <= bombs; b++)
						{
							if (pq[b].Count == 0)
							{
								continue;
							}

							var minNode = pq[b].Dequeue();

							if (visited[minNode.value.Item1, minNode.value.Item2, minNode.value.Item3])
							{
								continue;
							}
							visited[minNode.value.Item1, minNode.value.Item2, minNode.value.Item3] = true;

							for (int k = 0; k < di.Length; k++)
							{
								var ni = minNode.value.Item1 + di[k];
								var nj = minNode.value.Item2 + dj[k];
								if (ni < 0 || ni >= maze.Length || nj < 0 || nj >= maze[0].Length)
								{
									continue;
								}
								if (maze[ni][nj] == '#')
								{
									if (b == bombs)
									{
										continue;
									}
									var alt = length[minNode.value.Item1, minNode.value.Item2, b] + 3;
									if (alt < length[ni, nj, b + 1])
									{
										length[ni, nj, b + 1] = alt;
										pq[b + 1].Enqueue(new Node() { priority = alt, value = new Tuple<int, int, int>(ni, nj, b + 1) });
									}
									found = true;
								}
								else
								{
									var alt = length[minNode.value.Item1, minNode.value.Item2, b] + 1;
									if (alt < length[ni, nj, b])
									{
										length[ni, nj, b] = alt;
										pq[b].Enqueue(new Node() { priority = alt, value = new Tuple<int, int, int>(ni, nj, b) });
									}
									found = true;
								}
							}
						}
					}
					var eDist = 0;
					for (int b = 0; b <= bombs; b++)
					{
						eDist = eDist == 0 || length[ei, ej, b] < eDist ? length[ei, ej, b] : eDist;
					}
					return eDist == int.MaxValue / 2 ? -1 : eDist;
				}
			}
		}
	}

	public class TopCoder2012
	{
		public static void Run()
		{
			//Round1A.ProblemA_PasswordProblem();
			Round1A.ProblemB_KingdomRush();
		}

		public class Round1A
		{
			public static void ProblemA_PasswordProblem()
			{
				Func<int, int, double[], string> solve = (int A, int B, double[] p) =>
				{
					double ks1 = 2 + B;
					double[] ks = new double[A + 3];
					ks[A + 1] = 2 + B;
					ks[A + 2] = A + B + 1;
					
					for (int i = 0; i < (1 << A); i++)
					{
						ks[0] = 1;
						var i2 = i;
						for (int j = 0; j < A; j++)
						{
							if ((1 & i2) == 0)
							{
								ks[0] *= p[A - j - 1];
							}
							else
							{
								ks[0] *= 1 - p[A - j - 1];
							}
							i2 = i2 >> 1;
						}
						for (int j = 0; j < A; j++)
						{
							if ((i >> j) > 0)
							{
								ks[j + 1] += ks[0] * (j * 2 + (B - A) + 1 + B + 1);
							}
							else
							{
								ks[j + 1] += ks[0] * (j * 2 + (B - A) + 1);
							}
						}
					}
					ks[0] = double.MaxValue;
					return ks.Min().ToString("F6").Replace(',', '.');
				};

				Func<int, int, double[], string> solveFast = (int A, int B, double[] p) =>
				{
					double best = B + 2;
					double x = 1;
					for (int i = 0; i < A; i++)
					{
						x *= p[i];
						best = Math.Min(best, (B - i) + (A - i - 1) + (B + 1) * (1 - x));
						// B + A - 2*i - 1
						//0 >> B + A - 1
						//1 >> B + A - 2 - 1
					}
					return best.ToString("F6").Replace(',', '.');
				};

				var data = File.ReadAllLines("input.1a.a.large");
				var cases = int.Parse(data[0]);
				var output = new List<string>();
				for (int i = 0; i < cases; i++)
				{
					var a = data[i * 2 + 1].Split(' ')[0];
					var b = data[i * 2 + 1].Split(' ')[1];
					var p = data[i * 2 + 2].Split(' ').Select(pe => double.Parse(pe.Replace(".",","))).ToArray();
					//var res = solve(int.Parse(a), int.Parse(b), p);
					var res = solveFast(int.Parse(a), int.Parse(b), p);
					output.Add(string.Format("Case #{0}: {1}", (i + 1).ToString(), res));
				}
				File.WriteAllLines("output.1a.a", output.ToArray());
			}

			public static void ProblemB_KingdomRush()
			{
				Func<int[], int[], int> solveFollowingRules = (int[] l1, int[] l2) => 
				{
					int stars = 0;
					int steps = 0;
					var level = new int[l1.Length];
					var tooBad = false;
					while (stars < 2 * l1.Length)
					{
						steps++;
						var found = false;
						for (int i = 0; i < l1.Length; i++)
						{
							if (level[i] < 2 && l2[i] <= stars)
							{
								stars += 2 - level[i];
								level[i] = 2;
								found = true;
								break;
							}
						}
						if (found)
						{
							continue;
						}
						int best = -1;
						for (int i = 0; i < l1.Length; i++)
						{
							if (level[i] == 0 && l1[i] <= stars)
							{
								if (best == -1 || l2[i] > l2[best])
									best = i;
							}
						}
						if (best == -1)
						{
							tooBad = true;
							break;
						}
						level[best] = 1;
						stars++;					
					}
					return stars == 2 * l1.Length ? steps : -1;
					//printf("Case #%d: ",test);
					//if (sum == 2*n)
					//	printf("%d\n",steps);
					//else
					//	printf("Too Bad\n");
				};

				var data = File.ReadAllLines("input.1a.b.large");
				var output = new List<string>();
				var cases = int.Parse(data[0]);
				int k = 1;
				for (int i = 0; i < cases; i++)
				{
					var levelCount = int.Parse(data[k]);
					k++;
					var levelsOne = new List<int>();
					var levelsTwo = new List<int>();
					for (int j = 0; j < levelCount; j++)
					{
						levelsOne.Add(int.Parse(data[k].Split(' ')[0]));
						levelsTwo.Add(int.Parse(data[k].Split(' ')[1]));
						k++;
					}
					var res = solveFollowingRules(levelsOne.ToArray(), levelsTwo.ToArray());
					output.Add(string.Format("Case #{0}: {1}", (i + 1).ToString(), res == -1 ? "Too Bad" : res.ToString()));
				}
				File.WriteAllLines("output.1a.b", output.ToArray());
			}
		}
	}

	public class GoogleCodeJam
	{
		public static void Run()
		{
			//Year2012.Round1C.ProblemA_DiamondInheritance();
			//Year2013.Qualification.D_Treasure();
			//Treasure.Entry();
			Year2012.Round2.A_SwingingWild();
		}

		public class Year2010
		{
			public class Round1A
			{
				public static void ProblemA_Rotate()
				{
					

					var data = File.ReadAllLines("a-small-practice.in");
					var cases = int.Parse(data[0]);
					int l = 1;
					for (int i = 1; i <= cases; i++)
					{
						int N = int.Parse(data[l].Split(' ')[0]);
						int K = int.Parse(data[l].Split(' ')[1]);
						l++;
						var board = new List<string>();
						for (int j = 0; j < N; j++)
						{
							board.Add(data[l]);
							l++;
						}
					}
				}
			}

			public class Round2B
			{
				public static void ProblemA_File_Fix_it()
				{
					Func<List<string>, List<string>, int> solve = (nlist, mlist) => 
					{
						var mkdirCount = 0;
						mlist.Sort();
						foreach (var mpath in mlist)
						{
							if (nlist.Contains(mpath))
								continue;
							var mpathnew = mpath;
							while (!nlist.Contains(mpathnew))
							{
								mkdirCount++;
								nlist.Add(mpathnew);
								if (mpathnew.LastIndexOf("/") <= 0)
									break;
								mpathnew = mpathnew.Substring(0, mpathnew.LastIndexOf("/"));
							}
						}
						return mkdirCount;
					};

					var data = File.ReadAllLines("A-large-practice (4).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					int k = 1;
					for (int i = 0; i < cases; i++)
					{
						var N = int.Parse(data[k].Split(' ')[0]);
						var M = int.Parse(data[k].Split(' ')[1]);
						k++;
						var nl = new List<string>();
						for (int j = 0; j < N; j++)
						{
							nl.Add(data[k].Trim());
							k++;
						}
						var ml = new List<string>();
						for (int j = 0; j < M; j++)
						{
							ml.Add(data[k].Trim());
							k++;
						}
						var res = solve(nl, ml);
						output.Add("Case #" + (i + 1).ToString() + ": " + res.ToString());
					}
					File.WriteAllLines("output.1b", output.ToArray());
				}

				public static void ProblemB_Picking_Up_Chicks()
				{
					Func<int, int, int, int, int[], int[], int> solve = (n, k, b, t, xi, vi) =>
					{
						var swaps = new Dictionary<int, int>();
						for (int i = 0; i < xi.Length; i++)
						{
							if (xi[i] + vi[i] * t < b)
								continue;
							swaps.Add(i, 0);
							for (int j = i + 1; j < xi.Length; j++)
							{
								if (vi[j] >= vi[i])
									continue;
								//x1+v1*t = x2+v2*t
								//(v1-v2)*t = x2-x1
								//t = (x2-x1)/(v1-v2)
								//t < T - problem!

								double tj = ((double)xi[j] - (double)xi[i]) / ((double)vi[i] - (double)vi[j]);
								if (tj < t)
								{
									if (xi[i] + vi[i] * tj + vi[j] * (t - tj) < b)
										swaps[i]++;
								}
							}
						}
						var count = swaps.Keys.Count;
						var swapsCounts = swaps.Values.ToList();
						swapsCounts.Sort();
						return count < k ? -1 : swapsCounts.Take(k).Sum();
					};

					var data = File.ReadAllLines("B-large-practice (3).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					int pl = 1;
					for (int i = 0; i < cases; i++)
					{
						var N = int.Parse(data[pl].Split(' ')[0]);
						var K = int.Parse(data[pl].Split(' ')[1]);
						var B = int.Parse(data[pl].Split(' ')[2]);
						var T = int.Parse(data[pl].Split(' ')[3]);
						pl++;
						var Xi = data[pl].Split(' ').Select(s => int.Parse(s)).ToArray();
						pl++;
						var Vi = data[pl].Split(' ').Select(s => int.Parse(s)).ToArray();
						pl++;
						var res = solve(N, K, B, T, Xi, Vi);
						output.Add("Case #" + (i + 1).ToString() + ": " + (res == -1 ? "IMPOSSIBLE" : res.ToString()));
					}
					File.WriteAllLines("output.1b.3", output.ToArray());
				}

				//not finished
				public static void ProblemC_Your_Rank_Is_Pure()
				{
					//Func<int, int

					var data = File.ReadAllLines("c-small-practice.in");
					var cases = int.Parse(data[0]);
					for (int i = 1; i <= cases; i++)
					{
					}
				}
			}
		}

		public class Year2012
		{
			public class Round1B
			{
				public static void ProblemA_Safety_in_Numbers()
				{
					//x1 x2 x3
					//sum = (x1+x2+x3)
					//(p1+p2+p3)=1
					//x1 ->x1 + sum*p1 = x2 + sum*p2 = x3 + sum*p3
					//sum*(p1-p2) = x2-x1 -> p1 - p2 = (x2 - x1)/sum
					//x1/sum+p1 = x2/sum+p2

					Func<List<int>, string> solve = (si) =>
					{
						var ans = "";
						var sum = si.Sum();
						double l = 0;
						double r = 1;
						for (int i = 0; i < si.Count; i++)
						{
							l = 0;
							r = 1;
							for (int it = 0; it < 500; it++)
							{
								double mid = (l + r) / 2;
								double score = si[i] + sum * mid;
								double need = 0;
								for (int j = 0; j < si.Count; j++)
								{
									if (i == j)
										continue;
									if (si[j] < score)
										need += (score - si[j]) / sum; //si[j]+sum*p = score -> (score - si[j])/sum = p
								}
								if (need + mid > 1)
									r = mid;
								else
									l = mid;
							}
							ans += ((l + r) * 50).ToString("F6").Replace(",", ".") + " ";
						}
						return ans.Trim();
					};

					var data = File.ReadAllLines("A-small-practice (4).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					for (int i = 0; i < cases; i++)
					{
						var Si = data[i + 1].Split(' ').Select(s => int.Parse(s)).ToList();
						Si.RemoveAt(0);
						var res = solve(Si);
						output.Add("Case #" + (i + 1).ToString() + ": " + res);
					}
					File.WriteAllLines("output.1a", output.ToArray());
				}

				public static void ProblemC_Equal_Sums()
				{
					Func<List<int>, Tuple<string, string>> solve = (nums) =>
					{
						var l = nums.Count;
						for (int i = 1; i < (1 << l); i++)
						{
							var iID = new HashSet<int>();
							for (int j = 0; j < l; j++)
							{
								if ((1 & (i >> j)) > 0)
									iID.Add(j);
							}
							var sum1 = iID.Select(id => nums[id]).Sum();
							for (int i2 = 1; i2 < (1 << l); i2++)
							{
								if ((i & i2) > 0)
									continue;
								var i2ID = new HashSet<int>();
								for (int j2 = 0; j2 < l; j2++)
								{
									if ((1 & (i2 >> j2)) > 0)
										i2ID.Add(j2);
								}
								var sum2 = i2ID.Select(id => nums[id]).Sum();
								if (sum1 == sum2)
								{
									return new Tuple<string, string>(
										string.Join(" ", iID.Select(id => nums[id].ToString())),
										string.Join(" ", i2ID.Select(id => nums[id].ToString()))
									);
								}
							}
						}
						return new Tuple<string, string>(null, null);
					};

					var data = File.ReadAllLines("C-small-practice (4).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					for (int i = 0; i < cases; i++)
					{
						var Num = data[i + 1].Split(' ').Select(s => int.Parse(s)).ToList();
						Num.RemoveAt(0);
						var res = solve(Num);
						output.Add("Case #" + (i + 1).ToString() + ":");
						if (string.IsNullOrEmpty(res.Item1))
						{
							output.Add("Impossible");
						}
						else
						{
							output.Add(res.Item1);
							output.Add(res.Item2);
						}
					}
					File.WriteAllLines("output.1a", output.ToArray());
				}
			}

			public class Round1C
			{
				public static void ProblemA_DiamondInheritance()
				{
					//5
					//2 2 3
					//1 4
					//1 5
					//1 5
					//0

					//		1
					//	2		3
					//	4	   /
					//		5

					//		1
					//	2
					//		3

					Func<Dictionary<int, List<int>>, bool> solve = (inh) =>
					{
						if (!inh.Any(i => i.Value.Count > 1))
							return false;
						
						foreach (var i in inh.Keys)
						{
							if (inh[i].Count < 2)
								continue;

							var queue = new Queue<int>();
							queue.Enqueue(i);
							var used = new HashSet<int>();
							while (queue.Count > 0)
							{
								var el = queue.Dequeue();
								if (used.Contains(el))
								{
									return true;
								}
								used.Add(el);
								if (inh.ContainsKey(el))
								{
									foreach (var j in inh[el])
										queue.Enqueue(j);
								}
							}
						}
						return false;
					};

					var data = File.ReadAllLines("A-large-practice (5).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					int k = 1;
					for (int i = 0; i < cases; i++)
					{
						var N = int.Parse(data[k]);
						k++;
						var inh = new Dictionary<int, List<int>>();
						for (int j = 0; j < N; j++)
						{
							var nums = data[k].Split(' ').Select(s => int.Parse(s)).ToList();
							nums.RemoveAt(0);
							inh.Add(j + 1, nums);
							k++;
						}
						
						var res = solve(inh);
						output.Add("Case #" + (i + 1).ToString() + ": " + (res ? "Yes" : "No"));
					}
					File.WriteAllLines("output.1a", output.ToArray());
				}

				public static void ProblemC_BoxFactory()
				{
					//10 1 20 2 25 3
					//10 2 30 3 20 1
					
					// 1)
					//<--	20 2 25 3			
					//		10 2 30 3 20 1

					//<--	20 2 25 3
					//<--	30 3 20 1

					//2)
					//		10 1 20 2 25 3
					//<--	30 3 20 1

					//<--	20 2 25 3
					//<--	30 3 20 1

					Func<int, List<int>, int, List<int>, long> solve = (N, boxes, M, toys) =>
					{
						long[] a = new long[N];
						int[] A = new int[N];
						long[] b = new long[M];
						int[] B = new int[M];
						for (int i = 0; i < N; i++)
						{
							a[i] = boxes[2 * i];
							A[i] = boxes[2 * i + 1];
						}
						for (int i = 0; i < M; i++)
						{
							b[i] = toys[2 * i];
							B[i] = toys[2 * i + 1];
						}

						long[,] cumA = new long[N + 1, 101];
						long[,] cumB = new long[M + 1, 101];

						for (int typ = 1; typ <= 100; typ++)
						{
							cumA[0, typ] = 0;
							for (int i = 0; i < N; i++)
							{
								cumA[i + 1, typ] = cumA[i, typ];
								if (A[i] == typ)
									cumA[i + 1, typ] += a[i];
							}
							cumB[0, typ] = 0;
							for (int i = 0; i < M; i++)
							{
								cumB[i + 1, typ] = cumB[i, typ];
								if (B[i] == typ)
									cumB[i + 1, typ] += b[i];
							}
						}

						long[,] dp = new long[N + 1, M + 1];
						dp[0, 0] = 0;
						for (int i = 0; i < N; i++)
							for (int j = 0; j <= M; j++)
							{
								for (int ni = i + 1; ni <= N; ni++)
									for (int nj = j; nj <= M; nj++)
									{
										int typ = A[i];
										long countA = cumA[ni, typ] - cumA[i, typ];
										long countB = cumB[nj, typ] - cumB[j, typ];
										dp[ni, nj] = Math.Max(dp[ni, nj], dp[i, j] + Math.Min(countA, countB));
									}
							}

						var ans = dp[N, M];
						return ans;
					};

					var data = File.ReadAllLines("A-small-practice.in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					int k = 1;
					for (int i = 0; i < cases; i++)
					{
						var N = int.Parse(data[k].Split(' ')[0]);
						var M = int.Parse(data[k].Split(' ')[1]);
						k++;
						var B = data[k].Split(' ').Select(s => int.Parse(s)).ToList();
						k++;
						var T = data[k].Split(' ').Select(s => int.Parse(s)).ToList();
						k++;
						var res = solve(N, B, M, T);
						output.Add("Case #" + (i + 1).ToString() + ": " + res.ToString());
					}
					File.WriteAllLines("output.1a", output.ToArray());
				}
			}

			public class Round2
			{
				public class A
				{
					public string solve()
					{
						int n = int.Parse(Console.ReadLine());
						long[] d = new long[n];
						long[] l = new long[n];
						long[] m = new long[n];

						for (int i = 0; i < n; ++i)
						{
							string[] s = Console.ReadLine().Split(' ');
							d[i] = long.Parse(s[0]);
							l[i] = long.Parse(s[1]);
						}

						m[0] = d[0];

						for (int i = 1; i < n; ++i)
						{
							for (int j = 0; j < i; ++j)
							{
								long dist = d[i] - d[j];
								if (m[j] >= dist)
								{
									m[i] = Math.Max(m[i], Math.Min(l[i], dist));
								}
							}
						}

						long end = long.Parse(Console.ReadLine());
						for (int i = 0; i < n; ++i)
						{
							if (d[i] + m[i] >= end)
							{
								return "YES";
							}
						}
						return "NO";
					}

					public static void Entry()
					{
						var instance = new A();
						int n = int.Parse(Console.ReadLine());

						for (int i = 1; i <= n; ++i)
						{
							Console.WriteLine("Case #{0}: {1}", i, instance.solve());
						}
					}
				}

				public class B
				{
					public string solve()
					{
						string[] ss = Console.ReadLine().Split();
						int n = int.Parse(ss[0]);
						int w = int.Parse(ss[1]);
						int l = int.Parse(ss[2]);
						int[] r = new int[n];
						int[] ri = new int[n];
						int[] ww = new int[n];
						int[] ll = new int[n];

						ss = Console.ReadLine().Split();
						for (int i = 0; i < n; ++i)
						{
							r[i] = int.Parse(ss[i]);
							ri[i] = i;
						}

						Array.Sort(r, ri);
						bool flip = w > l;
						if (flip)
						{
							w ^= l;
							l ^= w;
							w ^= l;
						}

						int cw = w + 1;
						int cl = 0;
						int cln = -r[n - 1];

						for (int i = n - 1; i >= 0; --i)
						{
							cw += r[i];
							if (cw > w)
							{
								cw = 0;
								cl = cln + r[i];
								cln = cl + r[i];
							}

							ww[i] = cw;
							ll[i] = cl;
							cw += r[i];
						}

						if (flip)
						{
							int[] q = ww;
							ww = ll;
							ll = q;
						}

						string[] res = new string[2 * n];

						for (int i = 0; i < n; ++i)
						{
							int j = Array.IndexOf(ri, i);
							res[2 * i] = ww[j].ToString();
							res[2 * i + 1] = ll[j].ToString();
						}

						return string.Join(" ", res);
					}

					public static void Entry()
					{
						var instance = new B();
						int n = int.Parse(Console.ReadLine());

						for (int i = 1; i <= n; ++i)
						{
							Console.WriteLine("Case #{0}: {1}", i, instance.solve());
						}
					}
				}


				public static void A_SwingingWild()
				{
					var found = false;

					Action<int, int, List<int>, List<int>, int> solve = null;
					solve =	(v, len, d, l, D) => 
					{
						if (d[v] + len >= D)
						{
							found = true;
							return;
						}
						for (int v1 = v + 1; v1 < d.Count; v1++)
						{
							if (d[v] + len < d[v1])
								break;
							var newlen = Math.Min(d[v1] - d[v], l[v1]);
							solve(v1, newlen, d, l, D);
							if (found)
								return;
						}
					};

					var data = File.ReadAllLines("A-small-practice (7).in");
					var cases = int.Parse(data[0]);
					var output = new List<string>();
					int k = 1;
					for (int i = 0; i < cases; i++)
					{
						var N = int.Parse(data[k]);
						var dl = new Dictionary<int, int>();
						var d = new List<int>();
						var l = new List<int>();
						k++;
						for (int j = 0; j < N; j++)
						{
							d.Add(int.Parse(data[k].Split(' ')[0]));
							l.Add(int.Parse(data[k].Split(' ')[1]));
							k++;
						}
						var D = int.Parse(data[k]);
						k++;
						found = false;
						solve(0, Math.Min(d[0], l[0]), d, l, D);
						output.Add("Case #" + (i + 1).ToString() + ": " + (found ? "YES" : "NO"));
					}
					File.WriteAllLines("output.txt", output.ToArray());
				}
			}
		}

		public class Year2013
		{
			public class Qualification
			{
				public static void C_Fair_and_Square()
				{
					Func<long, long, long> solve = (a, b) => 
					{
						long count = 0;
						long i = (long)Math.Pow(10, a.ToString().Length / 4);
						while (true)
						{
							string x1 = i.ToString() + new string(i.ToString().Reverse().ToArray());
							long x1n = long.Parse(x1);
							if (x1n * x1n >= a && x1n * x1n <= b &&
								(x1n * x1n).ToString() == new string((x1n * x1n).ToString().Reverse().ToArray()))
								count++;

							string x2 = i.ToString() + (i.ToString().Length > 1 ? new string(i.ToString().Reverse().Skip(1).ToArray()) : "");
							long x2n = long.Parse(x2);
							if (x2n * x2n >= a && x2n * x2n <= b &&
								(x2n * x2n).ToString() == new string((x2n * x2n).ToString().Reverse().ToArray()))
								count++;

							if (x2n * x2n >= b)
								break;

							i++;
						}
						return count;
					};

					var data = File.ReadAllLines("C-large-practice-1.in");
					var output = new List<string>();
					var cases = int.Parse(data[0]);
					for (int i = 0; i < cases; i++)
					{
						long A = long.Parse(data[i + 1].Split(' ')[0]);
						long B = long.Parse(data[i + 1].Split(' ')[1]);
						long res = solve(A, B);
						output.Add("Case #" + (i + 1).ToString() + ": " + res.ToString());
					}
					File.WriteAllLines("output.txt", output.ToArray());
				}

				public static void D_Treasure()
				{
					Func<List<int>, List<int>, List<List<int>>, string> solve = (keys, req, provide) => 
					{
						var chestNum = req.Count;
						var used = new bool[chestNum];
						var seq = new List<int>();
						var found = false;
						
						Action search = null;
						search = () => 
						{
							if (seq.Count == chestNum)
							{
								found = true;
								return;
							}
							for (int i = 0; i < chestNum; i++)
							{
								if (!used[i] && keys.Contains(req[i]))
								{
									seq.Add(i + 1);
									used[i] = true;
									keys.Remove(req[i]);
									keys.AddRange(provide[i]);
									search();
									if (found)
										return;
									foreach (var j2 in provide[i])
										keys.Remove(j2);
									keys.Add(req[i]);
									used[i] = false;
									seq.Remove(i + 1);
								}
							}
						};

						search();
						return found ? string.Join(" ", seq) : "IMPOSSIBLE";
					};

					var data = File.ReadAllLines("D-small-practice.in");
					var output = new List<string>();
					var cases = int.Parse(data[0]);
					int k = 1;
					for (int i = 0; i < cases; i++)
					{
						long K = long.Parse(data[k].Split(' ')[0]);
						long N = long.Parse(data[k].Split(' ')[1]);
						k++;
						var keys = data[k].Split(' ').Select(d => int.Parse(d)).ToList();
						k++;
						var req = new List<int>();
						var provide = new List<List<int>>();
						for (int j = 0; j < N; j++)
						{
							req.Add(int.Parse(data[k].Split(' ')[0]));
							provide.Add(data[k].Split(' ').Skip(2).Select(d => int.Parse(d)).ToList());
							k++;
						}

						var requirements = req.ToList();
						var provides = provide.SelectMany(pr => pr).ToList();
						provides.AddRange(keys);
						var isGood = true;
						foreach (var r in requirements)
						{
							if (!provides.Contains(r))
							{
								isGood = false;
								break;
							}
							provides.Remove(r);
						}

						var res = isGood ? solve(keys, req, provide) : "IMPOSSIBLE";
						output.Add("Case #" + (i + 1).ToString() + ": " + res);
					}
					File.WriteAllLines("output.txt", output.ToArray());
				}
			}

			class Treasure
			{
				class Chest
				{
					public int key;
					public int[] keys;
				}

				class Solver
				{
					Dictionary<int, int> map;

					private int[] MapKeys(int[] keys)
					{
						int[] counts = new int[map.Count];
						for (int i = 0; i < keys.Length; i++)
						{
							int key;
							if (map.TryGetValue(keys[i], out key))
							{
								counts[key] += 1;
							}
						}
						return counts;
					}

					private bool SolutionExists(Chest[] chests, bool[] used, int[] keys)
					{
						bool loop = true;
						while (loop)
						{
							loop = false;
							for (int i = 0; i < chests.Length; i++)
							{
								if (!used[i] && keys[chests[i].key] > 0)
								{
									for (int k = 0; k < keys.Length; k++)
									{
										keys[k] += chests[i].keys[k];
									}
									used[i] = true;
									loop = true;
								}
							}
						}

						for (int i = 0; i < used.Length; i++)
						{
							if (!used[i])
							{
								return false;
							}
						}
						return true;
					}

					public string Solve(int[] keys, Chest[] chests)
					{
						map = new Dictionary<int, int>();
						for (int i = 0; i < chests.Length; i++)
						{
							if (!map.ContainsKey(chests[i].key))
							{
								map[chests[i].key] = map.Count;
							}
							chests[i].key = map[chests[i].key];
						}

						keys = MapKeys(keys);
						for (int i = 0; i < chests.Length; i++)
						{
							chests[i].keys = MapKeys(chests[i].keys);
						}

						int[] answer = new int[chests.Length];
						bool[] used = new bool[chests.Length];
						for (int i = 0; i < chests.Length; i++)
						{
							bool found = false;
							for (int j = 0; j < chests.Length; j++)
							{
								if (!used[j] && keys[chests[j].key] > 0)
								{
									bool[] used2 = (bool[])used.Clone();
									int[] keys2 = (int[])keys.Clone();
									used2[j] = true;
									keys2[chests[j].key] -= 1;
									for (int k = 0; k < keys2.Length; k++)
									{
										keys2[k] += chests[j].keys[k];
									}
									if (SolutionExists(chests, used2, (int[])keys2.Clone()))
									{
										answer[i] = j;
										used[j] = true;
										found = true;
										keys = keys2;
										break;
									}
								}
							}
							if (!found)
							{
								return "IMPOSSIBLE";
							}
						}

						StringBuilder sb = new StringBuilder();
						for (int i = 0; i < chests.Length; i++)
						{
							if (i > 0)
							{
								sb.Append(' ');
							}
							sb.Append(answer[i] + 1);
						}

						return sb.ToString();
					}
				}

				public static void Entry()
				{
					//string filename = "sample2";
					//string filename = "D-small-attempt0";
					string filename = "D-large";
					using (StreamReader reader = new StreamReader("D-small-practice.in"))
					{
						using (StreamWriter writer = new StreamWriter("output.txt"))
						{
							int T = Int32.Parse(reader.ReadLine());
							Solver solver = new Solver();
							for (int i = 0; i < T; i++)
							{
								string[] tmp = reader.ReadLine().Split();
								int k = Int32.Parse(tmp[0]);
								int n = Int32.Parse(tmp[1]);

								int[] keys = new int[k];
								tmp = reader.ReadLine().Split();
								for (int j = 0; j < k; j++)
								{
									keys[j] = Int32.Parse(tmp[j]);
								}

								Chest[] chests = new Chest[n];
								for (int j = 0; j < n; j++)
								{
									chests[j] = new Chest();
									tmp = reader.ReadLine().Split();
									chests[j].key = Int32.Parse(tmp[0]);
									chests[j].keys = new int[Int32.Parse(tmp[1])];
									for (int l = 0; l < chests[j].keys.Length; l++)
									{
										chests[j].keys[l] = Int32.Parse(tmp[l + 2]);
									}
								}
								writer.WriteLine("Case #" + (i + 1) + ": " + solver.Solve(keys, chests));
							}
						}
					}
				}
			}
		}
	}

	public class ProjectEuler
	{
		public static void Run()
		{
			Problem146();
		}

		public static HashSet<long> esieve(int limit)
		{
			HashSet<long> primes = new HashSet<long>();
			primes.Add(2);
			for (long i = 3; i < limit; i += 2)
			{
				primes.Add(i);
			}
			long j = 3;
			while (j < limit)
			{
				while (!primes.Contains(j) && j < limit)
				{
					j++;
				}
				for (long j2 = j + j; j2 < limit; j2 += j)
				{
					if (primes.Contains(j2))
					{
						primes.Remove(j2);
					}
				}
				j++;
			}
			return primes;
		}

		public static List<int> primes(int limit)
		{
			var sw = Stopwatch.StartNew();
			var primes = new List<int>();
			primes.Add(2);
			var check = true;
			for (int i = 3; i < limit; i += 2)
			{
				check = true;
				int l = (int)Math.Sqrt(i);
				for (int p = 0; p < primes.Count; p++)
				{
					if (primes[p] > l)
					{
						break;
					}
					if (i % primes[p] == 0)
					{
						check = false;
						break;
					}
				}
				if (check)
				{
					primes.Add(i);
				}
			}
			sw.Stop();
			Console.WriteLine("Primes construction: " + sw.Elapsed);
			return primes;
		}

		public static bool MillerRabin_IsPrime(int n, int k)
		{
			if (n < 2)
			{
				return false;
			}
			if (n != 2 && n % 2 == 0)
			{
				return false;
			}
			int s = n - 1;
			while (s % 2 == 0)
			{
				s >>= 1;
			}
			Random r = new Random();
			for (int i = 0; i < k; i++)
			{
				double a = r.Next((int)n - 1) + 1;
				int temp = s;
				int mod = (int)Math.Pow(a, (double)temp) % n;
				while (temp != n - 1 && mod != 1 && mod != n - 1)
				{
					mod = (mod * mod) % n;
					temp = temp * 2;
				}
				if (mod != n - 1 && temp % 2 == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static void Problem94()
		{
			long N = (long)Math.Pow(10, 9);
			//int N = 20;

			long sum = 0;
			long i = -1;
			while (true)
			{
				i++;
				long a = (1 + 2 * i);
				
				long p1 = (3 * a + 1) / 2;
				if (p1 <= N / 2)
				{
					//double sq1 = Math.Sqrt((double)(p1 * (p1 - a) * (p1 - a) * (p1 - a - 1)));
					var s1 = (double)(p1 * (p1 - a - 1));
					double sq1 = Math.Floor(Math.Sqrt(s1));
					if (s1 == sq1 * sq1 && sq1 != 0 && a * 3 + 1 < N)
						sum += p1 * 2;
				}

				long p2 = (3 * a - 1) / 2;
				if (p2 > N / 2)
					break;
				//double sq2 = Math.Sqrt((double)(p2 * (p2 - a) * (p2 - a) * (p2 - a + 1)));
				var s2 = (double)(p2 * (p2 - a + 1));
				double sq2 = Math.Floor(Math.Sqrt(s2));
				if (s2 == sq2 * sq2 && sq2 != 0 && a - 1 > 0)
					sum += p2 * 2;
			}
			Console.WriteLine(sum);
			Console.ReadLine();
		}

		public static void Problem95()
		{
			const int N = 1000000;
			var primes = esieve(N);
			var amic = new Dictionary<long, long>();
			amic.Add(1, 0);
			for (long i = 2; i <= N; i++)
			{
				long sum = 1;
				if (!primes.Contains(i))
				{
					for (long j = 2; j <= Math.Sqrt(i); j++)
					{
						if (i % j == 0)
						{
							sum += j;
							if (i / j != j)
							{
								sum += i / j;
							}
						}
					}
				}
				amic.Add(i, sum);
			}

			var maxSteps = 0;
			long smallestNum = 0;
			for (int i = 0; i < amic.Keys.Count; i++)
			{
				var num = amic[i + 1];
				var numList = new List<long>() { i + 1, num };
				var steps = 2;
				var isFound = false;
				while (amic.ContainsKey(num))
				{
					num = amic[num];
					if (numList.Contains(num))
					{
						isFound = true;
						steps = numList.Count - numList.LastIndexOf(num) + 1;
						numList.RemoveRange(0, numList.LastIndexOf(num));
						break;
					}
					numList.Add(num);
					steps++;
				}
				if (isFound)
				{
					if (steps > maxSteps)
					{
						maxSteps = steps;
						smallestNum = numList.Min();
					}
					else if (steps == maxSteps)
					{
						smallestNum = Math.Min(smallestNum, numList.Min());
					}
				}
			}

			Console.WriteLine(smallestNum);
		}

		public static void Problem121()
		{
			//3
			//(1/2) (1/3) (1/4) (1/5)
			//(1/2)*(1/3)*(1/4)*(4/5) = 4/120 (1 2 3)
			//(1/2)*(1/3)*(3/4)*(1/5) = 3/120 (1 2 4)
			//(1/2)*(2/3)*(1/4)*(1/5) = 2/120 (1 3 4)
			//(1/2)*(1/3)*(1/4)*(1/5) = 1/120 (2 3 4)
			//(1/2)*(1/3)*(1/4)*(1/5) = 1/120 (1 2 3 4)

			int n = 15;
			long upSum = 0;
			for (int i = 0; i < (1 << n); i++)
			{
				long up = 1;
				int cntRed = 0;
				for (int j = 0; j < n; j++)
				{
					if ((1 & (i >> j)) > 0)
					{
						cntRed++;
						up *= j + 1;
					}
				}
				if (cntRed < (n - cntRed))
				{
					upSum += up;
				}
			}
			long down = 1;
			for (int i = 2; i <= n + 1; i++)
			{
				down *= i;
			}

			long answer = down / upSum;
		}

		public static void Problem130()
		{
			// 11111 / 41
			// 111 / 41 = 2 R 29
			// 291 / 41 = 7 R 4
			// 41 / 41 = 1 R 0

			int count = 0;
			long foundNumSum = 0;
			int N = 25;
			long num = 90;
			while (count < N)
			{
				num++;
				if (num % 2 == 0 || num % 5 == 0)
				{
					continue;
				}
				int iCount = 1;
				long iNum = 1;
				while (iNum < num)
				{
					iCount++;
					iNum = iNum * 10 + 1;
				}
				long R = iNum % num;
				iNum = R;
				while (R > 0)
				{
					while (iNum < num)
					{
						iCount++;
						iNum = iNum * 10 + 1;
					}
					R = iNum % num;
					iNum = R;
				}

				if ((num - 1) % iCount == 0)
				{
					bool isComposite = false;
					for (int i = 2; i < Math.Sqrt(num); i++)
					{
						if (num % i == 0)
						{
							isComposite = true;
							break;
						}
					}
					if (!isComposite)
					{
						continue;
					}
					foundNumSum += num;
					count++;
				}
			}
			Console.WriteLine(foundNumSum);
		}

		//not ended!
		public static void Problem132()
		{
			//var N = (decimal)Math.Pow(10, 1);
			//const int stepN = 5;
			//const int primeFactorsNeededCount = 4;

			var N = (long)Math.Pow(10, 9);
			const int stepN = 20;
			const int primeFactorsNeededCount = 40;

			//var primes = esieve(1000000).Where(p => p.ToString().EndsWith("1")).ToArray();
			var primes = esieve(1000000).ToArray();
			//var primes = esieve(1000000).Where(p => p.ToString().EndsWith("1") || p.ToString().EndsWith("3") || p.ToString().EndsWith("7") || p.ToString().EndsWith("9")).ToArray();
			
			var primesINum = new decimal[primes.Length];
			
			decimal step = (decimal)Math.Pow(10, stepN);
			decimal stepI = 1;
			for (var i = 1; i < stepN; i++)
			{
				stepI = stepI * 10 + 1;
			}
			//long iNum = 0;
			//long R = 0;
			//long Test = 9091;
			//for (int i = 0; i < N / stepN; i++)
			//{
			//	for (var j = 0; j < primes.Length; j++)
			//	{
			//		primesINum[j] = (primesINum[j] * step + stepI) % primes[j];
			//	}
			//	//iNum = iNum * step + stepI;
			//	//R = iNum % Test;
			//	//iNum = R;
			//}
			
			//BigInteger.

			var primeFactors = new List<long>();
			long primeFactorsSum = 0;
			int count = 0;

			var N2 = (int)Math.Pow(10, 9);
			var ten = BigInteger.Parse("10");
			for (int i = 0; i < primes.Length; i++)
			{
				if (BigInteger.ModPow(ten, N2, primes[i]) == 1)
				{
					primeFactorsSum += primes[i];
					primeFactors.Add(primes[i]);
					count++;
					if (count == primeFactorsNeededCount)
					{
						break;
					}
				}
			}

			//for (int i = 0; i < primes.Length; i++)
			//{
			//	decimal iNum = 0;
			//	decimal R = 0;
			//	var RHash = new HashSet<decimal>();
			//	var isCycling = false;
			//	for (int j = 0; j < N / stepN; j++)
			//	{
			//		iNum = iNum * step + stepI;
			//		R = iNum % (decimal)primes[i];
			//		//if (R == 0)
			//		//{
			//		//	break;
			//		//}
			//		if (RHash.Contains(R) && !RHash.Contains(0))
			//		{
			//			isCycling = true;
			//			break;
			//		}
			//		else if (R != 0)
			//		{
			//			RHash.Add(R);
			//		}
			//		iNum = R;
			//	}
			//	if (!isCycling && R == 0)
			//	{
			//		primeFactorsSum += primes[i];
			//		primeFactors.Add(primes[i]);
			//		count++;
			//		if (count == primeFactorsNeededCount)
			//		{
			//			break;
			//		}
			//	}
			//}

			
			//for (var i = 0; i < primes.Length; i++)
			//{
			//	if (primesINum[i] == 0)
			//	{
			//		primeFactorsSum += primes[i];
			//		primeFactors.Add(primes[i]);
			//		count++;
			//		if (count == primeFactorsNeededCount)
			//		{
			//			break;
			//		}
			//	}
			//}
			Console.WriteLine(primeFactorsSum);
			//if (R == 0)
			//{
			//	//gotcha!
			//}
		}

		public static void Problem133()
		{
			//R(n) = (10^n - 1)/9
			//R(n) % p == 0   ->  10^n % 9*p == 1
			//R(10^n) % p == 0  ->  10^(10*n) % 9*p == 1

			const int N = 100000;
			var primes = esieve(N).ToArray();
			var m = BigInteger.Pow(10, 20);
			long sum = 0;
			foreach (var p in primes)
			{
				if (BigInteger.ModPow(10, m, 9 * p) != 1)
				{
					sum += p;
				}
			}
			Console.WriteLine(sum);
		}

		public static void Problem134()
		{
			//19 23 - 1219
			//23*x = 1219 (1219/23 = 53)
			//23*{X1,X2} = 23*X2 % 10 = 9 -> X2 = 3 (only)

			//    23
			//* 
			//    xx
			//=
			// yyy19

			int N = 1000000;
			var primes = esieve(N + 100).ToArray();
			long sum = 0;
			for (int i = 0; i < primes.Length - 1; i++)
			{
				if (primes[i] < 5)
				{
					continue;
				}
				if (primes[i] > N)
				{
					break;
				}
				var p1 = primes[i];
				var p1Len = p1.ToString().Length;
				long mult = 1;
				for (int j = 0; j < p1Len; j++)
				{
					mult = mult * 10;
				}
				var p2 = primes[i + 1];
				long start = 1;
				while ((start * mult + p1) % p2 != 0)
				{
					start++;
					if (long.MaxValue / (start * mult + p1) < 10)
					{
						//alarm
					}
				}
				sum += (start * mult + p1);
			}
			Console.WriteLine(sum);
		}

		public static void Problem136()
		{
			//x*x-y*y-z*z=n
			//(x-y)*(x+y)-z*z=n
			//(x-y)*(x+y)=n+z*z

			//y=z+d x=y+d=z+2*d
			//(z+2*d)^2 - (z+d)^2 - z^2 = n
			//z^2 + 4*z*d + 4*d^2 - z^2 - 2*z*d - d^2 - z^2 = n
			//-z^2 + 2*z*d + 3*d^2 = n
			//u=3*d-z v=d+z
			//u*v = n ((3*d-z)*(d+z) = 3*d^2 + 3*z*d - z*d - z^2 = -z^2 + 2*z*d + 3*d^2)
			//d = (u+v)/4
			//z = (3*v-u)/4

			//var res = new Dictionary<int, int>();
			const long N = 50000000;
			var res = new int[N];
			for (long u = 1; u < N; u++)
			{
				for (long v = u; u * v < N; v++)
				{
					if ((u + v) % 4 == 0 && (3 * v - u) % 4 == 0)
					{
						res[u * v]++;
					}
				}
			}
			var count = res.Where(k => k == 1).Count();
			Console.WriteLine(count - 1); //!!!
		}

		public static void Problem138()
		{
			//b == c
			//p = (a+b+c)/2 = (a+2*b)/2 = a/2 + b
			//S = sqrt(p(p-a)(p-b)(p-b))
			//S = sqrt((a/2+b)(a/2+b-a)(a/2+b-b)(a/2+b-b))
			//S = sqrt((a/2+b)(b-a/2)(a/2)(a/2)) = (a/2)*sqrt((b+a/2)*(b-a/2))
			//h = a + 1
			//S = (h * a)/2 = ((a+1)*a)/2

			//a = 16, b = 17, h = 15
			//p = (16 + 17*2)/2 = 8+17 = 25
			//S = sqrt(25*(25-16)*(25-17)*(25-17)) = sqrt(25*9*8*8) = 5*3*8

			//http://www.mathblog.dk/project-euler-138-special-isosceles-triangles/

			long result = 0;

			long x = 0;
			long y = -1;
			var lList = new List<long>();
			for (int i = 0; i < 12; i++)
			{
				long xnew = -9 * x + -4 * y + 4;
				long ynew = -20 * x + -9 * y + 8;

				x = xnew;
				y = ynew;

				var newL = Math.Abs(y);
				lList.Add(newL);
				result += newL;
			}

			//int count = 0;
			//double b = 2;
			//double h = 0;
			//double Lsum = 0;
			//var mylList = new List<double>();
			//while (count < 12)
			//{
			//	h = b - 1;
			//	var sq = Math.Sqrt((b / 2) * (b / 2) + h * h);
			//	if (Math.Floor(sq) == sq)
			//	{
			//		var newL = sq;
			//		mylList.Add(newL);
			//		Lsum += newL;
			//		count++;
			//	}

			//	h = b + 1;
			//	//sq = Math.Sqrt((double)(b / 2) * (double)(b / 2) + (double)(h) * (double)(h));
			//	sq = Math.Sqrt((b / 2) * (b / 2) + h * h);
			//	if (Math.Floor(sq) == sq)
			//	{
			//		var newL = sq;
			//		mylList.Add(newL);
			//		Lsum += newL;
			//		count++;
			//	}

			//	b += 2;
			//}				
		}

		public static void Problem146()
		{
			const int limit = 150000000;
			var add = new int[] { 1, 3, 7, 9, 13, 27 };
			long sum = 0;
			var sw = Stopwatch.StartNew();
			for (long i = 10; i < limit; i += 10)
			{
				long bi2 = i * i;
				long bi2i = bi2 + add[0];
				if (!(new BigInteger(bi2i)).IsPrime())
				{
					continue;
				}

				bi2i += 2;
				var check = true;
				for (int a = 1; a < add.Length; a++)
				{
					while (!(new BigInteger(bi2i).IsPrime()))
					{
						bi2i += 2;
					}

					if (bi2i != bi2 + add[a])					
					{
						check = false;
						break;
					}

					bi2i += 2;
				}
				if (check)
				{
					sum += i;
				}
				if (i % 100000 == 0)
				{
					Console.WriteLine("Passed: " + i);
				}
			}
			sw.Stop();
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine(sum);
		}
	
        public static void Problem148()
        {

        }
    }
}
