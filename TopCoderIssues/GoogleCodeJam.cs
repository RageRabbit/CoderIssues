using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderIssues
{
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
                    solve = (v, len, d, l, D) =>
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
}
