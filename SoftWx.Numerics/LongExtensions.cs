//Copyright ©2013 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// 5/18/2013
// <authors> Steve Hatchett

using System;
using System.Numerics;

namespace SoftWx.Numerics {
    /// <summary>
    /// Extension methods that operate on long vlaues.
    /// </summary>
    public static class LongExtensions {
        private static readonly long maxPrime = 9223372036854775783L;

        /// <summary>
        /// Computes the greatest common divisor of two values.
        /// </summary>
        /// <param name="value1">The value.</param></param></param>
        /// <param name="value2">The other value.</param>
        /// <returns>The greatest common divisor of the two values.</returns>
        public static long Gcd(this long value1, long value2) {
            return (long)UlongExtensions.Gcd(AbsUlong(value1), AbsUlong(value2));
        }

        /// <summary>
        /// Determines if the specified values are coprime to each other.
        /// </summary>
        /// <param name="value1">The value to be tested.</param>
        /// <param name="value2">The other value to be tested.</param>
        /// <returns>True if the values are coprime to each other, otherwise, false.</returns>
        public static bool IsCoprime(this long value1, long value2) {
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
        public static bool IsCoprimeToPrime(this long value, long primeValue) {
            if (primeValue < 2) throw new ArgumentOutOfRangeException("primeValue");
            return UlongExtensions.IsCoprimeToPrime(AbsUlong(value), (ulong)primeValue);
        }

        /// <summary>
        /// Computes the number nearest, but not larger than the specified start
        /// value that is coprime to another specified value. Returns 1 if no
        /// coprime was found before reaching long.MinValue.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="value2">The value to test against.</param>
        /// <returns>The largest value that is less than or equal to the start value
        /// and also coprime to the other specified value.</returns>
        public static long NearestCoprimeFloor(this long start, long value2) {
            while ((start > long.MinValue) && !IsCoprime(start, value2)) start--;
            if ((start == long.MinValue) && !IsCoprime(start, value2)) return 1;
            return start;
        }

        /// <summary>
        /// Determines if the specified value is a prime number.
        /// </summary>
        /// <remarks>This method chooses the best algorithm to use based on
        /// the magnitude of the specified value. For smaller values, a
        /// simple trial division algorithm is used. For larger values, a 
        /// deterministic version of the Miller-Rabin algorithm is used.</remarks>
        /// <param name="value">The long value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrime(this long value) {
            if (value <= 1) return false;
            return ((ulong)value).IsPrime();
        }

        /// <summary>
        /// Computes the prime number nearest, but not smaller than the specified start value.
        /// Returns zero if no solutions are in the range of start value to long.MaxValue.
        /// </summary>
        /// <param name="value">The start value.</param>
        /// <returns>The nearest prime number that is greater than or equal to the initial value.</returns>
        public static long NearestPrimeCeiling(this long value) {
            if (value <= 2) return 2;
            if (value > maxPrime) return 0;
            return (long)(((ulong)value).NearestPrimeCeiling());
        }

        /// <summary>
        /// Computes the prime number nearest, but not greater than the specified start value.
        /// Returns zero if the start value is less than 2.
        /// </summary>
        /// <param name="value">The largest value that is a prime number, and is less than
        /// or equal to the start value.</param>
        /// <returns>The nearest prime number that is less than or equal to the initial value.</returns>
        public static long NearestPrimeFloor(this long value) {
            if (value < 2) return 0;
            return (long)(((ulong)value).NearestPrimeFloor());
        }

        /// <summary>
        /// Compute the mod of a number raised to the specified power.
        /// </summary>
        /// <remarks>Overflow safe for all input values. </remarks>
        /// <param name="b">The base number.</param>
        /// <param name="e">The exponent applied to the base number.</param>
        /// <param name="m">The modulo value.</param>
        /// <returns>The mod of the base number raised to the specified power.</returns>
        public static long ModPow(long b, long e, long m) {
            if (e < 0 || m < 1) return -1;
            ulong bu = AbsUlong(b);
            long result = (long)UlongExtensions.ModPow(bu, (ulong)e, (ulong)m);
            if (((e & 1) == 0) && (b < 0)) result = -result;
            return result;
        }

        /// <summary>
        /// Returns as a ulong the absolute value of the specified long value.
        /// Absolute value of long.MinValue is properly handled, without overflow.
        /// </summary>
        /// <param name="value">The value whose absolute value is desired.</param>
        /// <returns>The ulong absolute value.</returns>
        public static ulong AbsUlong(this long value) {
            unchecked {
                ulong u1 = (ulong)(value >> 63);
                return (((ulong)value) + u1) ^ u1;
            }
        }
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