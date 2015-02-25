using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderIssues
{
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
            var C = new int[A.Length + 1];
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
}
