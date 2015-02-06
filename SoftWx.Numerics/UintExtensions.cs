// Copyright ©2013 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// 7/12/2013
// <authors> Steve Hatchett

using System;

namespace SoftWx.Numerics {
    /// <summary>
    /// Extension methods that operate on uint (32 bit unsigned integer) values.
    /// </summary>
    /// <remarks>Many of the bit fiddling methods are the result of benchmarking
    /// various alternate algorithms presented on Sean Eron Anderson's page
    /// http://graphics.stanford.edu/~seander/bithacks.html
    /// sometimes with minor improvements for C#, and choosing compact
    /// alternatives that perform well in C# for the uint (unsigned 32 bit integer) 
    /// data type.</remarks>
    public static class UintExtensions {
        // truncated square root of maximum uint value
        private static readonly uint sqrtMax = (uint)Math.Sqrt(uint.MaxValue);
        private static readonly uint maxPrime = 4294967291;
        
        /// <summary>
        /// Computes the greatest common divisor of two values.
        /// </summary>
        /// <param name="value1">The value.</param>
        /// <param name="value2">The other value.</param>
        /// <returns>The greatest common divisor of the two values.</returns>
        public static uint Gcd(this uint value1, uint value2) {
            if (value1 > value2) {
                uint t = value1;
                value1 = value2;
                value2 = t;
            }
            if (value1 == 0) return value2;
            while (true) {
                uint r = value2 % value1;
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
        public static bool IsCoprime(this uint value1, uint value2) {
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
        public static bool IsCoprimeToPrime(this uint value, uint primeValue) {
            return ((primeValue > value) || ((value % primeValue) == 0));
        }

        /// <summary>
        /// Computes the nearest number less than or equal to the specified start
        /// value that is coprime to another specified value. Returns 1 if no
        /// coprime was found before reaching uint.MinValue.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="value2">The value to test against.</param>
        /// <returns>The largest value that is less than or equal to the start value
        /// and also coprime to the other specified value.</returns>
        public static uint NearestCoprimeFloor(this uint start, uint value2) {
            if (start == 0) return (value2 == 1) ? 1u : 0u;
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
        public static bool IsPrime(this uint value) {
            if ((value & 1) == 0) return value == 2;
            if (value < 1000000) {
                return value.IsPrimeTrial();
            } else {
                return value.IsPrimeMR();
            }
        }

        /// <summary>
        /// Computes the prime number nearest, but not smaller than the specified start value.
        /// Returns zero if no solutions are in the range of start value to uint.MaxValue.
        /// </summary>
        /// <param name="value">The start value.</param>
        /// <returns>The nearest prime number that is greater than or equal to the initial value.</returns>
        public static uint NearestPrimeCeiling(this uint value) {
            if (value <= 2) return 2;
            if (value > maxPrime) return 0;
            value |= 1; // all primes must be odd numbers, so start with odd number
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
        public static uint NearestPrimeFloor(this uint value) {
            switch (value) {
                case 0:
                case 1: return 0;
                case 2: return 2;
            }
            value = (value - 1) | 1; // all primes must be odd numbers, so start with odd number
            while (!IsPrime(value)) value -= 2;
            return value;
        }

        /// <summary>
        /// Determines if the specified value is a prime number, using
        /// a trial division algorithm.
        /// </summary>
        /// <remarks>Uses a simple trial division algorithm, which is fast
        /// for small values, but relatively slow for primality testing of
        /// large values.</remarks>
        /// <param name="value">The value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrimeTrial(this uint value) {
            if (value < 2) return false;
            if ((value & 1) == 0) return value == 2;
            if ((value % 3) == 0) return value == 3;
            // for smaller values (up to several million), it's faster
            // to use i*i in the loop termination condition rather than
            // precomputing the square root of the value.
            //if (value == uint.MaxValue) return true;
            for (uint i = 5, skip = 2; (i <= sqrtMax) && (i * i <= value); i += skip, skip = 6 - skip) {
                if (value % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Determines if the specified value is a prime number, using
        /// a trial division algorithm.
        /// </summary>
        /// <remarks>Uses a simple trial division algorithm, which is fast
        /// for small values, but relatively slow for primality testing of
        /// large values.</remarks>
        /// <param name="value">The value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrimeTrialSqrt(this uint value) {
            if ((value & 1) == 0) return value == 2;
            if (value == 1) return false;
            if ((value % 3) == 0) return value == 3;
            uint endVal = (uint)((value > int.MaxValue) ? Math.Sqrt(value) : Math.Sqrt((int)value));
            for (uint i = 5, skip = 2; i <= endVal; i += skip, skip = 6 - skip) {
                if (value % i == 0) return false;
            }
            return true;
        }

        // precomputed witnesses and the maximum value up to which they guarantee primality
        private static readonly ulong[] witnesses1 = new ulong[] { 9345883071009581737 };
        private const uint witnesses1Max = 341531;
        private static readonly ulong[] witnesses2 = new ulong[] { 336781006125, 9639812373923155 };
        private const uint witnesses2Max = 1050535501;
        private static readonly ulong[] witnesses3 = new ulong[] { 2, 7, 61 };

        /// <summary>
        /// Determines if the specified value is a prime number, using the
        /// Miller-Rabin algorithm.
        /// </summary>
        /// <remarks>This implementation is guaranteed to deterministically
        /// decide primality for all positive value inputs.</remarks>
        /// <param name="value">The value to be tested for primality.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns> 
        public static bool IsPrimeMR(this uint value) {
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
            if (value >= witnesses2Max) return InternalIsPrimeMR(value, witnesses3);
            else if (value >= witnesses1Max) return InternalIsPrimeMR(value, witnesses2);
            else return InternalIsPrimeMR(value, witnesses1);
        }

        /// <summary>
        /// Determines if the specified value is a prime number, using the
        /// Miller-Rabin algorithm.
        /// </summary>
        /// <remarks>This implementation is guaranteed to deterministically
        /// decide primality for all positive value inputs.</remarks>
        /// <param name="value">The value to be tested for primality.</param>
        /// <param name="witnesses">The witnesses to be used.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        public static bool IsPrimeMR(this uint value, ulong[] witnesses) {
            if (value < 2) return false;
            if ((value & 1) == 0) return (value == 2);
            return InternalIsPrimeMR(value, witnesses);
        }
        /// <summary>
        /// Determines if the specified odd, >= 3 value is a prime number, using the
        /// Miller-Rabin algorithm.
        /// </summary>
        /// <param name="value">The int value to be tested for primality.</param>
        /// <param name="witnesses">The witnesses to be used.</param>
        /// <returns>True if the value is prime, otherwise, false.</returns>
        private static bool InternalIsPrimeMR(uint value, ulong[] witnesses) {
            // compute n − 1 as (2^s)·d (where d is odd)
            uint valLessOne = value - 1;
            uint d = valLessOne / 2; // we know that value is odd and valLessOne is even, so unroll 1st iter of loop
            uint s = 1;
            while ((d & 1) == 0) {
                d /= 2;
                s++;
            }
            // test value against each witness
            for (uint i = 0; i < witnesses.Length; i++) {
                uint a;
                ulong aL = witnesses[i];
                if (aL >= value) {
                    aL %= value;
                    if (aL < 2) continue;
                }
                a = (uint)aL;
                if (a == valLessOne) continue;
                uint x = InternalModPow(a, d, value); // overflow safe version of x = Math.Pow(a, d) % value
                if (x == 1) continue;
                for (uint r = 1; (x != valLessOne) && (r < s); r++) {
                    x = (uint)((x * (ulong)x) % value); // overflow safe version of x = (x * x) % value
                    if (x == 1) return false;
                }
                if (x != valLessOne) return false;
            }
            // witnesses confirm value is prime
            return true;
        }

        /// <summary>
        /// Compute the mod of a number raised to the specified power.
        /// </summary>
        /// <remarks>Overflow safe for all input values. </remarks>
        /// <param name="b">The base number.</param>
        /// <param name="e">The exponent applied to the base number.</param>
        /// <param name="m">The modulo value.</param>
        /// <returns>The mod of the base number raised to the specified power.</returns>
        public static uint ModPow(this uint b, uint e, uint m) {
            if (b == 0 || m == 0) return 0;
            return InternalModPow(b, e, m);
        }
        private static uint InternalModPow(uint b, uint e, uint m) {
            switch (e) {
                case 0: return 1;
                case 1: return b % m;
                case 2: return (b > sqrtMax) ? (uint)((b * (ulong)b) % m) : (b * b) % m;
                default:
                    uint result = 1;
                    if (m > sqrtMax) {
                        while (true) {
                            if ((e & 1) != 0) {
                                result = (uint)((result * (ulong)b) % m);
                                if (e == 1) return result;
                            }
                            e /= 2;
                            b = (uint)((b * (ulong)b) % m);
                        }
                    } else {
                        b %= m;
                        while (true) {
                            if ((e & 1) != 0) {
                                result = (result * b) % m;
                                if (e == 1) return result;
                            }
                            e /= 2;
                            b = (b * b) % m;
                        }
                    }
            }
        }

        /// <summary>
        /// Computes a hash value for the specified value.
        /// </summary>
        /// <remarks>This is a very simple and fast hash function. It's
        /// a heavily simplified version of Murmur Hash. It's meant for use
        /// with hash tables, and is entirely unsuited for crytographic uses.</remarks>
        /// <param name="val">The value to be hashed.</param>
        /// <returns>A hash value derived from the specified value.</returns>
        public static uint Hash(this uint val) {
            unchecked {
                val *= 0x5bd1e995;
                val ^= val >> 24;
                return val * 0x5bd1e995;
            }
        }

        /// <summary>
        /// Returns the integer logarithm base 2 (Floor(Log2(number))) of the specified number.
        /// </summary>
        /// <remarks>Example: Log2(10) returns 3.</remarks>
        /// <param name="number">The number whose base 2 log is desired.</param>
        /// <returns>The base 2 log of the number greater than 0, or 0 when the number
        /// equals 0.</returns>
        public static uint Log2(this uint value) {
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            return DeBruijnLSBsSet[unchecked((value | value >> 16) * 0x07c4acddu) >> 27];
        }

        /// <summary>
        /// Determines if the specified value is a power of 2.
        /// </summary>
        /// <param name="value">The value to be tested as a power of 2.</param>
        /// <returns>True if the value is a power of 2, otherwise false.</returns>
        public static bool IsPowerOf2(this uint value) {
            return (value != 0) && ((value & (value - 1)) == 0);
        }

        /// <summary>
        /// Returns the nearest power of 2 that's equal or less than the specified number.
        /// </summary>
        /// <remarks>Example: PowerOf2Floor(10) returns 8.</remarks>
        /// <param name="number">The number whose nearest power of 2 is desired.</param>
        /// <returns>The nearest power of 2 that's equal or less than the value parameter,
        /// or 0 if the value is 0.</returns>
        public static uint PowerOf2Floor(this uint value) {
            return HighBit(value);
        }

        /// <summary>
        /// Returns the nearest power of 2 that's equal or greater than the specified number.
        /// </summary>
        /// <remarks>Example: PowerOf2Ceiling(10) returns 16.</remarks>
        /// <param name="number">The number whose nearest power of 2 is desired.</param>
        /// <returns>The nearest power of 2 that's equal or greater than the value parameter,
        /// or 0 if the result would be greater than the type's maximum value.</returns>
        public static uint PowerOf2Ceiling(this uint value) {
            switch (value) {
                case 0:
                case 1: return 1;
            }
            value--;
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            return unchecked((value | (value >> 16)) + 1);
        }

        /// <summary>Returns the most significant set bit of the specified number.</summary>
        /// <remarks>Example: HighBit(10) returns 8, i.e. high bit of 00001010 is 00001000.</remarks>
        /// <param name="value">The value whose most significant bit is desired.</param>
        /// <returns>The value parameter's the most significant bit.</returns>
        public static uint HighBit(this uint value) {
            switch (value) {
                case 0: return 0;
                case 1: return 1;
            }
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            value |= value >> 16;
            return (value >> 1) + 1;
        }

        /// <summary>Returns the least significant set bit of the specified number.</summary>
        /// <remarks>Example: LowBit(10) returns 2, i.e. low bit of 00001010 is 00000010.</remarks>
        /// <param name="value">The value whose least significant bit is desired.</param>
        /// <returns>The value parameter's the least significant bit.</returns>
        public static uint LowBit(this uint value) {
            return unchecked(value & (1u + ~value));
        }

        // bit position lookup table where all bits set after most significant bit
        private static byte[] DeBruijnLSBsSet = new byte[] {
            0, 9, 1, 10, 13, 21, 2, 29, 11, 14, 16, 18, 22, 25, 3, 30,
            8, 12, 20, 28, 15, 17, 24, 7, 19, 27, 23, 6, 26, 5, 4, 31
        };
        // bit position lookup table where all bits zero after most significant bit
        private static byte[] DeBruijnPow2 = new byte[] {
            0, 1, 28, 2, 29, 14, 24, 3, 30, 22, 20, 15, 25, 17, 4, 8, 
            31, 27, 13, 23, 21, 19, 16, 7, 26, 12, 18, 6, 11, 5, 10, 9
        };

        /// <summary>Returns the most significant set bit position of the specified number,
        /// or 32 if no bits were set. The least significant bit position is 0.</summary>
        /// <remarks>Example: HighBitPosition(10) returns 3, i.e. high bit of 00001010 is position 3.</remarks>
        /// <param name="value">The value whose most significant bit position is desired.</param>
        /// <returns>The value parameter's most significant bit position.</returns>
        public static byte HighBitPosition(this uint value) {
            switch (value) {
                case 0: return 32;
                case 1: return 0;
            }
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            return DeBruijnLSBsSet[unchecked((value | value >> 16) * 0x07c4acddu) >> 27];
        }

        /// <summary>Returns the least significant set bit position of the specified number,
        /// or 32 if no bits were set. The least significant bit position is 0.</summary>
        /// <remarks>Example: LowBitPosition(10) returns 1, i.e. low bit of 00001010 is position 1.</remarks>
        /// <param name="value">The value whose least significant bit position is desired.</param>
        /// <returns>The value parameter's least significant bit position.</returns>
        public static byte LowBitPosition(this uint value) {
            return (value != 0) ? DeBruijnPow2[unchecked(LowBit(value) * 0x077cb531u) >> 27] : (byte)32;
        }

        /// <summary>Returns the count of leading zero bits in the specified number.</summary>
        /// <remarks>Example: LeadingZeroBits(10) returns 4, i.e. 00001010 has 4 leading 0 bits.</remarks>
        /// <param name="value">The value whose leading zero bit count is desired.</param>
        /// <returns>The count of the value parameter's leading zero bits.</returns>
        public static byte LeadingZeroBits(this uint value) {
            return (byte)((value != 0) ? 31 - HighBitPosition(value) : 32);
        }

        /// <summary>Returns the count of trailinging zero bits in the specified number.</summary>
        /// <remarks>Example: TrailingZeroBits(10) returns 1, i.e. 00001010 has 1 trailing 0 bit.</remarks>
        /// <param name="value">The value whose trailing zero bit count is desired.</param>
        /// <returns>The count of the value parameter's trailing zero bits.</returns>
        public static byte TrailingZeroBits(this uint value) {
            return LowBitPosition(value);
        }

        /// <summary>
        /// Returns the specified number with all bits reversed 
        /// (i.e. 01000000000000000000000001001101 is returned as 
        /// 10110010000000000000000000000010).
        /// </summary>
        /// <param name="value">The value to be reversed.</param>
        /// <returns>The reversed bits of the specified number.</returns>
        public static uint ReverseBits(this uint value) {
            value = ((value >> 1) & 0x55555555u) | ((value & 0x55555555u) << 1);
            value = ((value >> 2) & 0x33333333u) | ((value & 0x33333333u) << 2);
            value = ((value >> 4) & 0x0F0F0F0Fu) | ((value & 0x0F0F0F0Fu) << 4);
            value = ((value >> 8) & 0x00FF00FFu) | ((value & 0x00FF00FFu) << 8);
            return (value >> 16) | (value << 16);
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