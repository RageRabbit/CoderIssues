//Copyright ©2013 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// 5/18/2013
// <authors> Steve Hatchett

using System;
using System.Numerics;

namespace SoftWx.Numerics {
    /// <summary>
    /// Extension methods that operate on ulong (64 bit unsigned integer) values.
    /// </summary>
    public static class UlongExtensions {
        // truncated square root of maximum ulong value
        private static readonly ulong sqrtMax = (ulong)Math.Sqrt(ulong.MaxValue);
        private static readonly ulong maxPrime = 18446744073709551557;

        /// <summary>
        /// Computes the greatest common divisor of two values.
        /// </summary>
        /// <param name="value1">The value.</param>
        /// <param name="value2">The other value.</param>
        /// <returns>The greatest common divisor of the two values.</returns>
        public static ulong Gcd(this ulong value1, ulong value2) {
            if (value1 > value2) {
                ulong t = value1;
                value1 = value2;
                value2 = t;
            }
            if (value1 == 0) return value2;
            while (true) {
                ulong r = value2 % value1;
                if (r == 0) return value1;
                if (r == 1) return 1;
                value2 = value1;
                value1 = r;
            }
        }

        /// <summary>
        /// Determines if the specified values are coprime to each other.
        /// </summary>
        /// <param name="value1">The value to be tested.</param>
        /// <param name="value2">The other value to be tested.</param>
        /// <returns>True if the values are coprime to each other, otherwise, false.</returns>
        public static bool IsCoprime(this ulong value1, ulong value2) {
            // 25% of possible pairings are even num to even num so handle them
            // with a bit twiddle that's much faster than GCD function. If they
            // are both even, then they can't be coprime (2 is common divisor).
            return ((((value1 | value2) & 1) != 0)
                    && (Gcd(value1, value2) == 1));
        }

        /// <summary>
        /// Determines if the specified value is coprime to the specified prime number.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="primeValue">The prime number to test against.</param>
        /// <returns>True if the value is coprime to the prime number, otherwise, false.</returns>
        public static bool IsCoprimeToPrime(this ulong value, ulong primeValue) {
            return ((primeValue > value) || ((value % primeValue) == 0));
        }

        /// <summary>
        /// Computes the number nearest, but not larger than the specified start
        /// value that is coprime to another specified value. Returns 1 if no
        /// coprime was found before reaching ulong.MinValue.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="value2">The value to test against.</param>
        /// <returns>The largest value that is less than or equal to the start value
        /// and also coprime to the other specified value.</returns>
        public static ulong NearestCoprimeFloor(this ulong start, ulong value2) {
            if (start == 0) return (value2 == 1) ? 0UL : 1UL;
            while (!IsCoprime(start, value2)) start--;
            return start;
        }

        /// <summary>
        /// Determines if the specified value is a prime number.
        /// </summary>
        /// <remarks>This method chooses the best algorithm to use based on
        /// the magnitude of the specified value. For smaller values, a
        /// simple trial division algorithm is used. For larger values, a 
        /// deterministic version of the Miller-Rabin algorithm is used.</remarks>
        /// <param name="value">The value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrime(this ulong value) {
            if (value <= uint.MaxValue) {
                return ((uint)value).IsPrime();
            } else {
                if ((value & 1) == 0) return value == 2;
                return value.IsPrimeMR();
            }
        }

        /// <summary>
        /// Computes the prime number nearest, but not smaller than the specified start value.
        /// Returns zero if no solutions are in the range of start value to ulong.MaxValue.
        /// </summary>
        /// <param name="value">The start value.</param>
        /// <returns>The nearest prime number that is greater than or equal to the initial value.</returns>
        public static ulong NearestPrimeCeiling(this ulong value) {
            if (value <= 2) return 2;
            if (value > maxPrime) return 0;
            value |= 1; // all primes must be odd numbers
            while (!IsPrime(value)) value += 2;
            return value;
        }

        /// <summary>
        /// Computes the prime number nearest, but not greater than the specified start value.
        /// Returns zero if the start value is less than 2.
        /// </summary>
        /// <param name="value">The largest value that is a prime number, and is less than
        /// or equal to the start value.</param>
        /// <returns>The nearest prime number that is less than or equal to the initial value.</returns>
        public static ulong NearestPrimeFloor(this ulong value) {
            switch (value) {
                case 0:
                case 1: return 0;
                case 2: return 2;
            }
            value = (value - 1) | 1; // all primes must be odd numbers, so start with odd number
            while (!IsPrime(value)) value -= 2;
            return value;
        }

        // precomputed witnesses and the maximum value up to which they guarantee primality
        private static readonly ulong[] witnesses1 = new ulong[] { 9345883071009581737 };
        private const ulong witnesses1Max = 341531;
        private static readonly ulong[] witnesses2 = new ulong[] { 336781006125, 9639812373923155 };
        private const uint witnesses2Max = 1050535501;
        private static readonly ulong[] witnesses3 = new ulong[] { 4230279247111683200, 14694767155120705706, 16641139526367750375 };
        private const ulong witnesses3Max = 350269456337;
        private static readonly ulong[] witnesses4 = new ulong[] { 2, 141889084524735, 1199124725622454117, 11096072698276303650 };
        private const ulong witnesses4Max = 55245642489451;
        private static readonly ulong[] witnesses5 = new ulong[] { 2, 4130806001517, 149795463772692060, 186635894390467037, 3967304179347715805 };
        private const ulong witnesses5Max = 7999252175582851;
        private static readonly ulong[] witnesses6 = new ulong[] { 2, 123635709730000, 9233062284813009, 43835965440333360, 761179012939631437, 1263739024124850375 };
        private const ulong witnesses6Max = 585226005592931977;
        private static readonly ulong[] witnesses7 = new ulong[] { 2, 325, 9375, 28178, 450775, 9780504, 1795265022 };
        
        /// <summary>
        /// Determines if the specified value is a prime number, using the
        /// Miller-Rabin algorithm.
        /// </summary>
        /// <remarks>This implementation is guaranteed to deterministically
        /// decide primality for all positive value inputs.</remarks>
        /// <param name="value">The ulong value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrimeMR(this ulong value) {
            // take care of the simple cases of small primes and the
            // common composites having those primes as factors
            if ((value & 1) == 0) return value == 2;
            if (value == 1) return false;
            if ((value % 3) == 0) return value == 3;
            if ((value % 5) == 0) return value == 5;
            if (((value % 7) == 0) || ((value % 11) == 0) || ((value % 13) == 0)
                || ((value % 17) == 0) || ((value % 19) == 0) || ((value % 23) == 0)
                || ((value % 29) == 0) || ((value % 31) == 0) || ((value % 37) == 0)
                || ((value % 41) == 0) || ((value % 43) == 0)) {
                return (value <= 43);
            }
            // perform Miller-Rabin with most efficient witness array for the value being tested
            BigInteger bValue = (BigInteger)value;
            if (value >= witnesses6Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 7, witnesses7);
            else if (value >= witnesses5Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 6, witnesses6);
            else if (value >= witnesses4Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 5, witnesses5);
            else if (value >= witnesses3Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 4, witnesses4);
            else if (value >= witnesses2Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 3, witnesses3);
            else if (value >= witnesses1Max) return BigIntegerExtensions.InternalIsPrimeMR(bValue, 2, witnesses2);
            else return BigIntegerExtensions.InternalIsPrimeMR(bValue, 1, witnesses1);
        }

        /// <summary>
        /// Compute the mod of a number raised to the specified power.
        /// </summary>
        /// <remarks>Overflow safe for all input values. </remarks>
        /// <param name="b">The base number.</param>
        /// <param name="e">The exponent applied to the base number.</param>
        /// <param name="m">The modulo value.</param>
        /// <returns>The mod of the base number raised to the specified power.</returns>
        public static ulong ModPow(ulong b, ulong e, ulong m) {
            if (b == 0 || m == 0) return 0;
            switch (e) {
                case 0: return 1;
                case 1: return b % m;
                case 2: return (b <= sqrtMax) ? (b * b) % m : (ulong)BigInteger.ModPow(b, e, m);
                default: return (ulong)BigInteger.ModPow(b, e, m);
            }
        }
        // TODO - implement bit fiddling methods for 64 bit unsigned ints
    }
}
/*
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/