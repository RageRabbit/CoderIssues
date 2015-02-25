using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoderIssues
{
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
                    var p = data[i * 2 + 2].Split(' ').Select(pe => double.Parse(pe.Replace(".", ","))).ToArray();
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
}
