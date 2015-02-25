using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SoftWx.Numerics;

namespace TopCoderIssues
{
    public class ProjectEuler
    {
        public static void Run()
        {
            Problem148();
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
            const int ROWS = 100000;
            //var nums = new List<int>() { 0, 1, 0 };
            //for (int i = 0; i<ROWS; i++)
            //{
            //    var newNums = new List<int>() { 0 };
            //    for (int j=1; j<nums.Count; j++)
            //    {
            //        newNums.Add(nums[j - 1] + nums[j]);
            //    }
            //    newNums.Add(0);
            //    nums = newNums;
            //}

            var nums = new List<int>() { 2 };
            var count = 6; //3 rows
            var countDivisible = 0;
            for (int i = 4; i <= ROWS; i++)
            {
                count += i;
                var countDivisibleLocal = 0;
                var newNums = new List<int>();
                for (int j = 0; j < nums.Count; j++)
                {
                    var newnum = 0;
                    if (j == 0)
                    {
                        newnum = nums[j] + 1;
                    }
                    else
                    {
                        newnum = nums[j - 1] + nums[j];
                    }
                    newNums.Add(newnum);
                    if (newnum % 7 == 0)
                    {
                        if (i % 2 != 0 && j == nums.Count - 1)
                        {
                            continue;
                        }
                        countDivisibleLocal += 2;
                    }
                }
                var lastnum = newNums.Last();
                if (i % 2 == 0)
                {

                    newNums.Add(lastnum);

                }
                else
                {
                    if (lastnum % 7 == 0)
                    {
                        countDivisibleLocal++;
                    }
                }
                countDivisible += countDivisibleLocal;
                var fullNums = i % 2 == 0 ? newNums.Concat(newNums.Reverse<int>().Skip(2)) : newNums.Concat(newNums.Reverse<int>().Skip(1));
                var fullnumsStr = string.Format("1 {0} 1", string.Join(" ", fullNums));
                nums = newNums;
            }
        }
    }
}
