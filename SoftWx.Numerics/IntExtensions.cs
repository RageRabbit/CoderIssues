// Copyright ©2013 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// 1/3/2013
// <authors> Steve Hatchett

using System;

namespace SoftWx.Numerics {
    /// <summary>
    /// Extension methods that operate on int (32 bit signed integer) values.
    /// </summary>
    public static class IntExtensions {

        /// <summary>
        /// Computes the greatest common divisor of two values.
        /// </summary>
        /// <param name="value1">The value.</param></param></param>
        /// <param name="value2">The other value.</param>
        /// <returns>The greatest common divisor of the two values.</returns>
        public static int Gcd(this int value1, int value2) {
            return (int)UintExtensions.Gcd(AbsUint(value1), AbsUint(value2));
        }

        /// <summary>
        /// Determines if the specified values are coprime to each other.
        /// </summary>
        /// <param name="value1">The value to be tested.</param>
        /// <param name="value2">The other value to be tested.</param>
        /// <returns>True if the values are coprime to each other, otherwise, false.</returns>
        public static bool IsCoprime(this int value1, int value2) {
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
        public static bool IsCoprimeToPrime(this int value, int primeValue) {
            if (primeValue < 2) throw new ArgumentOutOfRangeException("primeValue");
            return UintExtensions.IsCoprimeToPrime(AbsUint(value), (uint)primeValue);
        }

        /// <summary>
        /// Computes the number nearest, but not larger than the specified start
        /// value that is coprime to another specified value. Returns 1 if no
        /// coprime was found before reaching int.MinValue.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="value2">The value to test against.</param>
        /// <returns>The largest value that is less than or equal to the start value
        /// and also coprime to the other specified value.</returns>
        public static int NearestCoprimeFloor(this int start, int value2) {
            while ((start > int.MinValue) && !IsCoprime(start, value2)) start--;
            if ((start == int.MinValue) && !IsCoprime(start, value2)) return 1;
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
        public static bool IsPrime(this int value) {
            if (value <= 1) return false;
            return ((uint)value).IsPrime();
        }

        /// <summary>
        /// Computes the prime number nearest, but not smaller than the specified start value.
        /// Because int.MaxValue is a prime number, all inputs will produced a valid prime.
        /// </summary>
        /// <param name="value">The start value.</param>
        /// <returns>The nearest prime number that is greater than or equal to the initial value.</returns>
        public static int NearestPrimeCeiling(this int value) {
            if (value <= 2) return 2;
            return (int)(((uint)value).NearestPrimeCeiling());
        }

        /// <summary>
        /// Computes the prime number nearest, but not greater than the specified start value.
        /// Returns zero if the start value is less than 2.
        /// </summary>
        /// <param name="value">The largest value that is a prime number, and is less than
        /// or equal to the start value.</param>
        /// <returns>The nearest prime number that is less than or equal to the initial value.</returns>
        public static int NearestPrimeFloor(this int value) {
            if (value < 2) return 0;
            return (int)(((uint)value).NearestPrimeFloor());
        }

        /// <summary>
        /// Compute the mod of a number raised to the specified power.
        /// </summary>
        /// <remarks>Overflow safe for all input values. </remarks>
        /// <param name="b">The base number.</param>
        /// <param name="e">The exponent applied to the base number.</param>
        /// <param name="m">The modulo value.</param>
        /// <returns>The mod of the base number raised to the specified power.</returns>
        public static int ModPow(int b, int e, int m) {
            if (e < 0 || m < 1) return -1;
            uint bu = AbsUint(b);
            int result = (int) UintExtensions.ModPow(bu, (uint)e, (uint)m);
            if (((e & 1) == 0) && (b < 0)) result = -result;
            return result;
        }

        /// <summary>
        /// Computes a hash value for the specified value.
        /// </summary>
        /// <remarks>This is a very simple and fast hash function. It's
        /// a heavily simplified version of Murmur Hash. It's meant for use
        /// with hash tables, and is entirely unsuited for crytographic uses.</remarks>
        /// <param name="val">The value to be hashed.</param>
        /// <returns>A hash value derived from the specified value.</returns>
        public static int Hash(this int val) {
            unchecked {
                val *= 0x5bd1e995;
                val ^= val >> 24;
                return val * 0x5bd1e995;
            }
        }

        /// <summary>
        /// Returns as a uint the absolute value of the specified int value.
        /// Absolute value of int.MinValue is properly handled, without overflow.
        /// </summary>
        /// <param name="value">The value whose absolute value is desired.</param>
        /// <returns>The uint absolute value.</returns>
        public static uint AbsUint(this int value) {
            unchecked {
                uint u1 = (uint)(value >> 31);
                return (((uint)value) + u1) ^ u1;
            }
        }

        /// <summary>
        /// Returns the integer logarithm base 2 (Floor(Log2(number))) of the specified number.
        /// </summary>
        /// <remarks>Example: Log2(10) returns 3.</remarks>
        /// <param name="number">The number whose base 2 log is desired.</param>
        /// <returns>The base 2 log of the number greater than 0, or 0 when the number
        /// is less than or equal to 0.</returns>
        public static int Log2(this int value) {
            return (value >= 0) ? (int)(((uint)value).Log2()) : 0;
        }

        /// <summary>
        /// Determines if the specified value is a power of 2.
        /// </summary>
        /// <param name="value">The value to be tested as a power of 2.</param>
        /// <returns>True if the value is a power of 2, otherwise false.</returns>
        public static bool IsPowerOf2(this int value) {
            return (value > 0) && ((value & (value - 1)) == 0);
        }

        /// <summary>
        /// Returns the nearest power of 2 that's equal or less than the specified number.
        /// </summary>
        /// <remarks>Example: PowerOf2Floor(10) returns 8.</remarks>
        /// <param name="number">The number whose nearest power of 2 is desired.</param>
        /// <returns>The nearest power of 2 that's equal or less than the value parameter,
        /// or 0 if the value is less than or equal to 0.</returns>
        public static int PowerOf2Floor(this int value) {
            return (value >= 0) ? (int)(((uint)value).PowerOf2Floor()) : 0;
        }

        /// <summary>
        /// Returns the nearest power of 2 that's equal or greater than the specified number.
        /// </summary>
        /// <remarks>Example: PowerOf2Ceiling(10) returns 16.</remarks>
        /// <param name="number">The number whose nearest power of 2 is desired.</param>
        /// <returns>The nearest power of 2 that's equal or greater than the value parameter,
        /// or 0 if the result would be greater than the type's maximum value.</returns>
        public static int PowerOf2Ceiling(this int value) {
            return (value >= 1) ? (int)(((uint)value).PowerOf2Ceiling() & 0x7fffffffu) : 1;
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