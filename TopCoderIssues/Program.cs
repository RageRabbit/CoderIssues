using System;
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

            #region old calls

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

            #endregion

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
}
