// Copyright ©2012 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// 7/15/2013
// <authors> Steve Hatchett

using System;
using System.Numerics;

namespace SoftWx.Numerics {
    /// <summary>
    /// Class for generating random BigInteger values. RandomBigInteger uses an underlying
    /// Random or RandomNumberGenerator object to help it generate random BigInteger values.
    /// By default, a Random object created with a default seed is used, but this can be
    /// replaced by setting a specific random number generator.
    /// </summary>
    public class RandomBigInteger {
        private BigInteger minValue;	// minimum random value
        private BigInteger range;		// the range of potential random values (less minValue)
        private int rangeBits;			// the number of bits in the range
        private int rangeShift;			// the number of bit positions in an 8 bit value that have to be shifted to obey range constraint
        private byte[] bytes;			// the byte array that receives initial random bytes
        private Random random;
        private System.Security.Cryptography.RandomNumberGenerator rng;

        // hide parameterless constructor
        private RandomBigInteger() { }

        /// <summary>
        /// Create a new instance of RandomBigInteger for generating numbers of the specified bit 
        /// length, (i.e. where all generated numbers will be of the specified bit length, with 
        /// the most significant bit set).
        /// </summary>
        /// <remarks>Example: If a bitCount of 4 were specified, the RandomBigInteger would generate
        /// random values from 8 to 15 (i.e. binary 1000 to 1111).</remarks>
        /// <param name="bitCount">The bit length for random values.</param>
        public RandomBigInteger(int bitCount)
            : this(BigInteger.One << (bitCount - 1), BigInteger.One << bitCount, bitCount) { }

        /// <summary>
        /// Create a new instance of RandomBigInteger for generating numbers from the specified
        /// minimum value, up to, but not including the specified maximum value.
        /// </summary>
        /// <remarks>Specifying a range (maxValue-minValue) that is not a power of 2 can result
        /// in slower random number generation, because occassionally BigIntegerRandom will need to
        /// compute multiple values before one is generated that is within the range.</remarks>
        /// <param name="minValue">The inclusive lower bound of the random numbers returned.</param>
        /// <param name="maxValue">The exclusive upper bound of the random numbers returned.</param>
        public RandomBigInteger(BigInteger minValue, BigInteger maxValue)
            : this(minValue, maxValue, 0) { }

        private RandomBigInteger(BigInteger minValue, BigInteger maxValue, int bitCount) {
            if (minValue >= maxValue) throw new ArgumentOutOfRangeException("minValue must be less than maxValue");
            if (bitCount < 0) throw new ArgumentOutOfRangeException("bitCount must be greater than 0");

            this.minValue = minValue;
            this.range = (maxValue - minValue) - 1;
            this.rangeBits = (bitCount == 0) ? range.BitLength() : bitCount;

            // make byte array have an extra bit so we can insert a zero
            // in the most significant bit to ensure we get values >= 0
            // (the most significant bit is interpreted as sign bit in
            // the BigInteger constructor that takes a byte array).
            this.bytes = new byte[((this.rangeBits + 7 + 1) / 8)];
            this.rangeShift = ((this.bytes.Length) * 8) - this.rangeBits - 1;
            this.random = new Random();
        }

        /// <summary>
        /// Sets the underlying random number generator used by the BigIntegerRandom to
        /// generate random BigIntegers. 
        /// </summary>
        /// <remarks>If a Random type generator and a RandomNumberGenerator type generator
        /// are set, the RandomNumberGenerator type will be used.If a random number generator
        /// is not explicitly set, a Random object created with the default seed will be used
        /// by BigIntegerRandom.</remarks>
        /// <param name="rng">The Random object that will be used to generate random BigIntegers.</param>
        public void SetRandomNumberGenerator(Random rng) {
            this.random = rng;
        }

        /// <summary>
        /// Sets the underlying random number generator used by the BigIntegerRandom to
        /// generate random BigIntegers. 
        /// </summary>
        /// <remarks>If a Random type generator and a RandomNumberGenerator type generator
        /// are set, the RandomNumberGenerator type will be used.If a random number generator
        /// is not explicitly set, a Random object created with the default seed will be used
        /// by BigIntegerRandom.</remarks>
        /// <param name="rng">The RandomNumberGenerator object that will be used to generate random BigIntegers.</param>
        public void SetRandomNumberGenerator(System.Security.Cryptography.RandomNumberGenerator rng) {
            this.rng = rng;
        }

        /// <summary>Return a random BigInteger value.</summary>
        /// <returns>A random BigInteger value.</returns>
        public BigInteger Next() {
            BigInteger result;
            do {
                // generate random bytes
                if (this.rng != null) {
                    this.rng.GetBytes(this.bytes);
                } else {
                    if (this.random == null) this.random = new Random();
                    this.random.NextBytes(this.bytes);
                }
                // clear the sign bit
                this.bytes[this.bytes.Length - 1] &= 0x7f;

                // clear unneeded bits of the most significant byte
                if (this.rangeShift != 0) this.bytes[this.bytes.Length - 1] >>= this.rangeShift;

                // convert bytes to a BigInteger
                result = new BigInteger(this.bytes);
            } while (result > range); // if the generated number is outside the range, try again
            return result + minValue;
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