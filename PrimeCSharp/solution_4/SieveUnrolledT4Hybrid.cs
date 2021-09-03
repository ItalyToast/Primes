using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Linq;

namespace PrimeSieveCS
{
    readonly struct SieveUnrolledT4HybridRunner : ISieveRunner
    {
        public ISieve RunSieve(uint sieveSize) => new SieveUnrolledT4Hybrid(sieveSize).RunSieve();
    }

    class SieveUnrolledT4Hybrid : ISieve
    {
        readonly uint sieveSize;
        readonly uint halfLimit;
        readonly ulong[] bits;

        public string Name => "italytoast-UnrolledT4-hybrid";

        public uint SieveSize => sieveSize;

        public SieveUnrolledT4Hybrid(uint size)
        {
            const int wordBits = sizeof(ulong) * 8;

            sieveSize = size;
            halfLimit = (size + 1) / 2;
            bits = new ulong[(int)(halfLimit / wordBits + 100)];
        }

        public IEnumerable<uint> EnumeratePrimes()
        {
            yield return 2;
            for (uint num = 3; num <= sieveSize; num += 2)
                if ((bits[(num / 2) / 64] & (1UL << (int)(num / 2))) == 0)
                    yield return num;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe static void ClearBitsStride8BlocksUnrolled(byte* ptr, uint start, uint factor, uint limit, uint blocksize)
        {
            Span<(uint, byte)> strides = stackalloc (uint, byte)[8];
            for (uint i = 0; i < 8; i++)
            {
                var s = start + factor * i;
                strides[(int)i] = (s / 8, (byte)(1 << ((int)s % 8)));
            }

            var bytecount = limit / 8;
            var blockStart = start / 8;

            while (blockStart <= bytecount)
            {
                for (int stride = 0; stride < 8; stride++)
                {
                    var (index, mask) = strides[stride];
                    var blockEnd = Math.Min(bytecount + 1, index + blocksize);
                    var blockEndPtr = ptr + blockEnd;

                    var i0 = ptr + index;
                    var i1 = ptr + index + factor;
                    var i2 = ptr + index + factor * 2;
                    var i3 = ptr + index + factor * 3;

                    uint factor4 = factor * 4;
                    for (; i3 < blockEndPtr;)
                    {
                        i0[0] |= mask;
                        i1[0] |= mask;
                        i2[0] |= mask;
                        i3[0] |= mask;

                        i0 += factor4;
                        i1 += factor4;
                        i2 += factor4;
                        i3 += factor4;
                    }

                    for (; i0 < blockEndPtr; i0 += factor)
                    {
                        i0[0] |= mask;
                    }

                    strides[stride] = ((uint)(i0 - ptr), mask);
                }

                blockStart += blocksize;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe static void ClearBitsStride8BlocksUnrolledV2(byte* ptr, uint start, uint factor, uint limit, uint blocksize)
        {
            Span<uint> masks = stackalloc uint[8];
            Span<ulong> offsets = stackalloc ulong[8];

            for (int i = 0; i < 8; i++)
            {
                var s = start + factor * i;
                masks[i] = (byte)(1 << ((int)s % 8));
                offsets[i] = (ulong)((s) / 8 - start / 8);
            }

            var ptrStart = ptr + start / 8;
            var ptrEnd = ptr + limit / 8 + 1;

            
            var p0 = ptrStart + offsets[0];
            var p1 = ptrStart + offsets[1];
            var p2 = ptrStart + offsets[2];
            var p3 = ptrStart + offsets[3];
            var p4 = ptrStart + offsets[4];
            var p5 = ptrStart + offsets[5];
            var p6 = ptrStart + offsets[6];
            var p7 = ptrStart + offsets[7];


            while (p0 <= ptrEnd - factor)
            {
                p0[0] |= (byte)masks[0];
                p1[0] |= (byte)masks[1];
                p2[0] |= (byte)masks[2];
                p3[0] |= (byte)masks[3];
                p4[0] |= (byte)masks[4];
                p5[0] |= (byte)masks[5];
                p6[0] |= (byte)masks[6];
                p7[0] |= (byte)masks[7];

                p0 += factor;
                p1 += factor;
                p2 += factor;
                p3 += factor;
                p4 += factor;
                p5 += factor;
                p6 += factor;
                p7 += factor;
            }

            for (int i = 0; i < 8; i++)
            {
                p0[offsets[i]] |= (byte)masks[i];
                if (p0 + offsets[i] > ptrEnd) break;
            }


        }

        /// <summary>
        /// Calculate the primes up to the specified limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        unsafe public SieveUnrolledT4Hybrid RunSieve()
        {
            uint factor = 3;
            uint halfFactor = factor >> 1;
            uint halfRoot = ((uint)(Math.Sqrt(sieveSize) + 1)) >> 1;

            // We ignore even numbers by using values that track half of the actuals, and the only
            // number we keep in original form is the prime factor we're walking through the sieve
            fixed (ulong* ptr = bits)
                while (true)
                {
                    // Scan for the next unset bit which means it is a prime factor
                    var segment = ptr[halfFactor / 64];
                    var offset = halfFactor % 64;
                    segment = ~segment; //since we only have access to TrailingZeroCount, we have to flip all the bits
                    segment >>= (int)offset;
                    var jump = BitOperations.TrailingZeroCount(segment);
                    if (jump == 64)
                    {
                        halfFactor += 64 - offset;
                        continue;
                    }

                    //scan finnished - restoring factor
                    halfFactor += (uint)jump;
                    factor = (halfFactor << 1) + 1;
                    halfFactor++;

                    if (halfFactor > halfRoot) break;

                    //marking with a rolling mask if we can get enough bits in the ulong.
                    //Half factor of 20 seems to be optimal. (~3 bits / ulong) 
                    if (factor < 20)
                    {
                        Unrolled.ClearFactor(factor, ptr, halfLimit);
                        //ClearBitsDense((byte*)ptr, (factor * factor) / 2, factor, halfLimit);
                        //ClearBitsSparse(ptr, (factor * factor) / 2, factor, halfLimit);
                    }
                    else
                    {
                        ClearBitsStride8BlocksUnrolledV2((byte*)ptr, (factor * factor) / 2, factor, halfLimit, 0x4000);
                    }
                }
            //var refprime = new SieveStride8(1000000).RunSieve().EnumeratePrimes().ToList();

            //var myprimes = EnumeratePrimes().ToHashSet();
            //myprimes.ExceptWith(refprime);
            return this;
        }
    }
}
