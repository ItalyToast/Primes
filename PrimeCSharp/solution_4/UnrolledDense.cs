
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrimeSieveCS
{ 
	class UnrolledDense
	{
		/// <summary>
        /// Clears the factors using generated code up to a factor of 63
        /// </summary>
		public static unsafe void ClearFactor(uint factor, ulong* ptr, uint limit){
			switch(factor){
				case 3: ClearFactor3(ptr, limit); break;
				case 5: ClearFactor5(ptr, limit); break;
				case 7: ClearFactor7(ptr, limit); break;
				case 9: ClearFactor9(ptr, limit); break;
				case 11: ClearFactor11(ptr, limit); break;
				case 13: ClearFactor13(ptr, limit); break;
				case 15: ClearFactor15(ptr, limit); break;
				case 17: ClearFactor17(ptr, limit); break;
				case 19: ClearFactor19(ptr, limit); break;
				case 21: ClearFactor21(ptr, limit); break;
				case 23: ClearFactor23(ptr, limit); break;
				case 25: ClearFactor25(ptr, limit); break;
				case 27: ClearFactor27(ptr, limit); break;
				case 29: ClearFactor29(ptr, limit); break;
				case 31: ClearFactor31(ptr, limit); break;
				case 33: ClearFactor33(ptr, limit); break;
				case 35: ClearFactor35(ptr, limit); break;
				case 37: ClearFactor37(ptr, limit); break;
				case 39: ClearFactor39(ptr, limit); break;
				case 41: ClearFactor41(ptr, limit); break;
				case 43: ClearFactor43(ptr, limit); break;
				case 45: ClearFactor45(ptr, limit); break;
				case 47: ClearFactor47(ptr, limit); break;
				case 49: ClearFactor49(ptr, limit); break;
				case 51: ClearFactor51(ptr, limit); break;
				case 53: ClearFactor53(ptr, limit); break;
				case 55: ClearFactor55(ptr, limit); break;
				case 57: ClearFactor57(ptr, limit); break;
				case 59: ClearFactor59(ptr, limit); break;
				case 61: ClearFactor61(ptr, limit); break;
				case 63: ClearFactor63(ptr, limit); break;
				default: throw new ArgumentOutOfRangeException("factor");
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor3(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10;
			mask |= 0x80;
			mask |= 0x400;
			mask |= 0x2000;
			mask |= 0x10000;
			mask |= 0x80000;
			mask |= 0x400000;
			mask |= 0x2000000;
			mask |= 0x10000000;
			mask |= 0x80000000;
			mask |= 0x400000000;
			mask |= 0x2000000000;
			mask |= 0x10000000000;
			mask |= 0x80000000000;
			mask |= 0x400000000000;
			mask |= 0x2000000000000;
			mask |= 0x10000000000000;
			mask |= 0x80000000000000;
			mask |= 0x400000000000000;
			mask |= 0x2000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 3){
				mask = startPtr[0];
				mask |= 0x1;
				mask |= 0x8;
				mask |= 0x40;
				mask |= 0x200;
				mask |= 0x1000;
				mask |= 0x8000;
				mask |= 0x40000;
				mask |= 0x200000;
				mask |= 0x1000000;
				mask |= 0x8000000;
				mask |= 0x40000000;
				mask |= 0x200000000;
				mask |= 0x1000000000;
				mask |= 0x8000000000;
				mask |= 0x40000000000;
				mask |= 0x200000000000;
				mask |= 0x1000000000000;
				mask |= 0x8000000000000;
				mask |= 0x40000000000000;
				mask |= 0x200000000000000;
				mask |= 0x1000000000000000;
				mask |= 0x8000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x4;
				mask |= 0x20;
				mask |= 0x100;
				mask |= 0x800;
				mask |= 0x4000;
				mask |= 0x20000;
				mask |= 0x100000;
				mask |= 0x800000;
				mask |= 0x4000000;
				mask |= 0x20000000;
				mask |= 0x100000000;
				mask |= 0x800000000;
				mask |= 0x4000000000;
				mask |= 0x20000000000;
				mask |= 0x100000000000;
				mask |= 0x800000000000;
				mask |= 0x4000000000000;
				mask |= 0x20000000000000;
				mask |= 0x100000000000000;
				mask |= 0x800000000000000;
				mask |= 0x4000000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x2;
				mask |= 0x10;
				mask |= 0x80;
				mask |= 0x400;
				mask |= 0x2000;
				mask |= 0x10000;
				mask |= 0x80000;
				mask |= 0x400000;
				mask |= 0x2000000;
				mask |= 0x10000000;
				mask |= 0x80000000;
				mask |= 0x400000000;
				mask |= 0x2000000000;
				mask |= 0x10000000000;
				mask |= 0x80000000000;
				mask |= 0x400000000000;
				mask |= 0x2000000000000;
				mask |= 0x10000000000000;
				mask |= 0x80000000000000;
				mask |= 0x400000000000000;
				mask |= 0x2000000000000000;
				startPtr[2] |= mask;
				
				startPtr += 3;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor5(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000;
			mask |= 0x20000;
			mask |= 0x400000;
			mask |= 0x8000000;
			mask |= 0x100000000;
			mask |= 0x2000000000;
			mask |= 0x40000000000;
			mask |= 0x800000000000;
			mask |= 0x10000000000000;
			mask |= 0x200000000000000;
			mask |= 0x4000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 5){
				mask = startPtr[0];
				mask |= 0x8;
				mask |= 0x100;
				mask |= 0x2000;
				mask |= 0x40000;
				mask |= 0x800000;
				mask |= 0x10000000;
				mask |= 0x200000000;
				mask |= 0x4000000000;
				mask |= 0x80000000000;
				mask |= 0x1000000000000;
				mask |= 0x20000000000000;
				mask |= 0x400000000000000;
				mask |= 0x8000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x10;
				mask |= 0x200;
				mask |= 0x4000;
				mask |= 0x80000;
				mask |= 0x1000000;
				mask |= 0x20000000;
				mask |= 0x400000000;
				mask |= 0x8000000000;
				mask |= 0x100000000000;
				mask |= 0x2000000000000;
				mask |= 0x40000000000000;
				mask |= 0x800000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1;
				mask |= 0x20;
				mask |= 0x400;
				mask |= 0x8000;
				mask |= 0x100000;
				mask |= 0x2000000;
				mask |= 0x40000000;
				mask |= 0x800000000;
				mask |= 0x10000000000;
				mask |= 0x200000000000;
				mask |= 0x4000000000000;
				mask |= 0x80000000000000;
				mask |= 0x1000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x2;
				mask |= 0x40;
				mask |= 0x800;
				mask |= 0x10000;
				mask |= 0x200000;
				mask |= 0x4000000;
				mask |= 0x80000000;
				mask |= 0x1000000000;
				mask |= 0x20000000000;
				mask |= 0x400000000000;
				mask |= 0x8000000000000;
				mask |= 0x100000000000000;
				mask |= 0x2000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4;
				mask |= 0x80;
				mask |= 0x1000;
				mask |= 0x20000;
				mask |= 0x400000;
				mask |= 0x8000000;
				mask |= 0x100000000;
				mask |= 0x2000000000;
				mask |= 0x40000000000;
				mask |= 0x800000000000;
				mask |= 0x10000000000000;
				mask |= 0x200000000000000;
				mask |= 0x4000000000000000;
				startPtr[4] |= mask;
				
				startPtr += 5;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor7(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000;
			mask |= 0x80000000;
			mask |= 0x4000000000;
			mask |= 0x200000000000;
			mask |= 0x10000000000000;
			mask |= 0x800000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 7){
				mask = startPtr[0];
				mask |= 0x4;
				mask |= 0x200;
				mask |= 0x10000;
				mask |= 0x800000;
				mask |= 0x40000000;
				mask |= 0x2000000000;
				mask |= 0x100000000000;
				mask |= 0x8000000000000;
				mask |= 0x400000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x2;
				mask |= 0x100;
				mask |= 0x8000;
				mask |= 0x400000;
				mask |= 0x20000000;
				mask |= 0x1000000000;
				mask |= 0x80000000000;
				mask |= 0x4000000000000;
				mask |= 0x200000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1;
				mask |= 0x80;
				mask |= 0x4000;
				mask |= 0x200000;
				mask |= 0x10000000;
				mask |= 0x800000000;
				mask |= 0x40000000000;
				mask |= 0x2000000000000;
				mask |= 0x100000000000000;
				mask |= 0x8000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x40;
				mask |= 0x2000;
				mask |= 0x100000;
				mask |= 0x8000000;
				mask |= 0x400000000;
				mask |= 0x20000000000;
				mask |= 0x1000000000000;
				mask |= 0x80000000000000;
				mask |= 0x4000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x20;
				mask |= 0x1000;
				mask |= 0x80000;
				mask |= 0x4000000;
				mask |= 0x200000000;
				mask |= 0x10000000000;
				mask |= 0x800000000000;
				mask |= 0x40000000000000;
				mask |= 0x2000000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x10;
				mask |= 0x800;
				mask |= 0x40000;
				mask |= 0x2000000;
				mask |= 0x100000000;
				mask |= 0x8000000000;
				mask |= 0x400000000000;
				mask |= 0x20000000000000;
				mask |= 0x1000000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x8;
				mask |= 0x400;
				mask |= 0x20000;
				mask |= 0x1000000;
				mask |= 0x80000000;
				mask |= 0x4000000000;
				mask |= 0x200000000000;
				mask |= 0x10000000000000;
				mask |= 0x800000000000000;
				startPtr[6] |= mask;
				
				startPtr += 7;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor9(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000000;
			mask |= 0x2000000000000;
			mask |= 0x400000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 9){
				mask = startPtr[0];
				mask |= 0x8;
				mask |= 0x1000;
				mask |= 0x200000;
				mask |= 0x40000000;
				mask |= 0x8000000000;
				mask |= 0x1000000000000;
				mask |= 0x200000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x4;
				mask |= 0x800;
				mask |= 0x100000;
				mask |= 0x20000000;
				mask |= 0x4000000000;
				mask |= 0x800000000000;
				mask |= 0x100000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x2;
				mask |= 0x400;
				mask |= 0x80000;
				mask |= 0x10000000;
				mask |= 0x2000000000;
				mask |= 0x400000000000;
				mask |= 0x80000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x1;
				mask |= 0x200;
				mask |= 0x40000;
				mask |= 0x8000000;
				mask |= 0x1000000000;
				mask |= 0x200000000000;
				mask |= 0x40000000000000;
				mask |= 0x8000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x100;
				mask |= 0x20000;
				mask |= 0x4000000;
				mask |= 0x800000000;
				mask |= 0x100000000000;
				mask |= 0x20000000000000;
				mask |= 0x4000000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x80;
				mask |= 0x10000;
				mask |= 0x2000000;
				mask |= 0x400000000;
				mask |= 0x80000000000;
				mask |= 0x10000000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x40;
				mask |= 0x8000;
				mask |= 0x1000000;
				mask |= 0x200000000;
				mask |= 0x40000000000;
				mask |= 0x8000000000000;
				mask |= 0x1000000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x20;
				mask |= 0x4000;
				mask |= 0x800000;
				mask |= 0x100000000;
				mask |= 0x20000000000;
				mask |= 0x4000000000000;
				mask |= 0x800000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x10;
				mask |= 0x2000;
				mask |= 0x400000;
				mask |= 0x80000000;
				mask |= 0x10000000000;
				mask |= 0x2000000000000;
				mask |= 0x400000000000000;
				startPtr[8] |= mask;
				
				startPtr += 9;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor11(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 11){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x40000;
				mask |= 0x20000000;
				mask |= 0x10000000000;
				mask |= 0x8000000000000;
				mask |= 0x4000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x200;
				mask |= 0x100000;
				mask |= 0x80000000;
				mask |= 0x40000000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1;
				mask |= 0x800;
				mask |= 0x400000;
				mask |= 0x200000000;
				mask |= 0x100000000000;
				mask |= 0x80000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x4;
				mask |= 0x2000;
				mask |= 0x1000000;
				mask |= 0x800000000;
				mask |= 0x400000000000;
				mask |= 0x200000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x10;
				mask |= 0x8000;
				mask |= 0x4000000;
				mask |= 0x2000000000;
				mask |= 0x1000000000000;
				mask |= 0x800000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x40;
				mask |= 0x20000;
				mask |= 0x10000000;
				mask |= 0x8000000000;
				mask |= 0x4000000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100;
				mask |= 0x80000;
				mask |= 0x40000000;
				mask |= 0x20000000000;
				mask |= 0x10000000000000;
				mask |= 0x8000000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x400;
				mask |= 0x200000;
				mask |= 0x100000000;
				mask |= 0x80000000000;
				mask |= 0x40000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x2;
				mask |= 0x1000;
				mask |= 0x800000;
				mask |= 0x400000000;
				mask |= 0x200000000000;
				mask |= 0x100000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x8;
				mask |= 0x4000;
				mask |= 0x2000000;
				mask |= 0x1000000000;
				mask |= 0x800000000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x20;
				mask |= 0x10000;
				mask |= 0x8000000;
				mask |= 0x4000000000;
				mask |= 0x2000000000000;
				mask |= 0x1000000000000000;
				startPtr[10] |= mask;
				
				startPtr += 11;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor13(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 1;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000;
			mask |= 0x200000000;
			mask |= 0x400000000000;
			mask |= 0x800000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 14){
				mask = startPtr[0];
				mask |= 0x100;
				mask |= 0x200000;
				mask |= 0x400000000;
				mask |= 0x800000000000;
				mask |= 0x1000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x200;
				mask |= 0x400000;
				mask |= 0x800000000;
				mask |= 0x1000000000000;
				mask |= 0x2000000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x400;
				mask |= 0x800000;
				mask |= 0x1000000000;
				mask |= 0x2000000000000;
				mask |= 0x4000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x800;
				mask |= 0x1000000;
				mask |= 0x2000000000;
				mask |= 0x4000000000000;
				mask |= 0x8000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x1000;
				mask |= 0x2000000;
				mask |= 0x4000000000;
				mask |= 0x8000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x1;
				mask |= 0x2000;
				mask |= 0x4000000;
				mask |= 0x8000000000;
				mask |= 0x10000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x2;
				mask |= 0x4000;
				mask |= 0x8000000;
				mask |= 0x10000000000;
				mask |= 0x20000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x4;
				mask |= 0x8000;
				mask |= 0x10000000;
				mask |= 0x20000000000;
				mask |= 0x40000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x8;
				mask |= 0x10000;
				mask |= 0x20000000;
				mask |= 0x40000000000;
				mask |= 0x80000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x10;
				mask |= 0x20000;
				mask |= 0x40000000;
				mask |= 0x80000000000;
				mask |= 0x100000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x20;
				mask |= 0x40000;
				mask |= 0x80000000;
				mask |= 0x100000000000;
				mask |= 0x200000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x40;
				mask |= 0x80000;
				mask |= 0x100000000;
				mask |= 0x200000000000;
				mask |= 0x400000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x80;
				mask |= 0x100000;
				mask |= 0x200000000;
				mask |= 0x400000000000;
				mask |= 0x800000000000000;
				startPtr[12] |= mask;
				
				startPtr += 13;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor15(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 1;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000000;
			mask |= 0x8000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 16){
				mask = startPtr[0];
				mask |= 0x4000;
				mask |= 0x20000000;
				mask |= 0x100000000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x400;
				mask |= 0x2000000;
				mask |= 0x10000000000;
				mask |= 0x80000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x40;
				mask |= 0x200000;
				mask |= 0x1000000000;
				mask |= 0x8000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x4;
				mask |= 0x20000;
				mask |= 0x100000000;
				mask |= 0x800000000000;
				mask |= 0x4000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x2000;
				mask |= 0x10000000;
				mask |= 0x80000000000;
				mask |= 0x400000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x200;
				mask |= 0x1000000;
				mask |= 0x8000000000;
				mask |= 0x40000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x20;
				mask |= 0x100000;
				mask |= 0x800000000;
				mask |= 0x4000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x2;
				mask |= 0x10000;
				mask |= 0x80000000;
				mask |= 0x400000000000;
				mask |= 0x2000000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x1000;
				mask |= 0x8000000;
				mask |= 0x40000000000;
				mask |= 0x200000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x100;
				mask |= 0x800000;
				mask |= 0x4000000000;
				mask |= 0x20000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x10;
				mask |= 0x80000;
				mask |= 0x400000000;
				mask |= 0x2000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x1;
				mask |= 0x8000;
				mask |= 0x40000000;
				mask |= 0x200000000000;
				mask |= 0x1000000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x800;
				mask |= 0x4000000;
				mask |= 0x20000000000;
				mask |= 0x100000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x80;
				mask |= 0x400000;
				mask |= 0x2000000000;
				mask |= 0x10000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x8;
				mask |= 0x40000;
				mask |= 0x200000000;
				mask |= 0x1000000000000;
				mask |= 0x8000000000000000;
				startPtr[14] |= mask;
				
				startPtr += 15;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor17(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 2;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000;
			mask |= 0x200000000;
			mask |= 0x4000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 19){
				mask = startPtr[0];
				mask |= 0x8;
				mask |= 0x100000;
				mask |= 0x2000000000;
				mask |= 0x40000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x80;
				mask |= 0x1000000;
				mask |= 0x20000000000;
				mask |= 0x400000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x800;
				mask |= 0x10000000;
				mask |= 0x200000000000;
				mask |= 0x4000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x8000;
				mask |= 0x100000000;
				mask |= 0x2000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4;
				mask |= 0x80000;
				mask |= 0x1000000000;
				mask |= 0x20000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x40;
				mask |= 0x800000;
				mask |= 0x10000000000;
				mask |= 0x200000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x400;
				mask |= 0x8000000;
				mask |= 0x100000000000;
				mask |= 0x2000000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x4000;
				mask |= 0x80000000;
				mask |= 0x1000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x2;
				mask |= 0x40000;
				mask |= 0x800000000;
				mask |= 0x10000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x20;
				mask |= 0x400000;
				mask |= 0x8000000000;
				mask |= 0x100000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x200;
				mask |= 0x4000000;
				mask |= 0x80000000000;
				mask |= 0x1000000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x2000;
				mask |= 0x40000000;
				mask |= 0x800000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x1;
				mask |= 0x20000;
				mask |= 0x400000000;
				mask |= 0x8000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x10;
				mask |= 0x200000;
				mask |= 0x4000000000;
				mask |= 0x80000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x100;
				mask |= 0x2000000;
				mask |= 0x40000000000;
				mask |= 0x800000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x1000;
				mask |= 0x20000000;
				mask |= 0x400000000000;
				mask |= 0x8000000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x10000;
				mask |= 0x200000000;
				mask |= 0x4000000000000;
				startPtr[16] |= mask;
				
				startPtr += 17;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor19(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 2;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 21){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x4000000;
				mask |= 0x200000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x1;
				mask |= 0x80000;
				mask |= 0x4000000000;
				mask |= 0x200000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1000;
				mask |= 0x80000000;
				mask |= 0x4000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x20;
				mask |= 0x1000000;
				mask |= 0x80000000000;
				mask |= 0x4000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x20000;
				mask |= 0x1000000000;
				mask |= 0x80000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x400;
				mask |= 0x20000000;
				mask |= 0x1000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x8;
				mask |= 0x400000;
				mask |= 0x20000000000;
				mask |= 0x1000000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x8000;
				mask |= 0x400000000;
				mask |= 0x20000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x100;
				mask |= 0x8000000;
				mask |= 0x400000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x2;
				mask |= 0x100000;
				mask |= 0x8000000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x2000;
				mask |= 0x100000000;
				mask |= 0x8000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x40;
				mask |= 0x2000000;
				mask |= 0x100000000000;
				mask |= 0x8000000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x40000;
				mask |= 0x2000000000;
				mask |= 0x100000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x800;
				mask |= 0x40000000;
				mask |= 0x2000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x10;
				mask |= 0x800000;
				mask |= 0x40000000000;
				mask |= 0x2000000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x10000;
				mask |= 0x800000000;
				mask |= 0x40000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200;
				mask |= 0x10000000;
				mask |= 0x800000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x4;
				mask |= 0x200000;
				mask |= 0x10000000000;
				mask |= 0x800000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x4000;
				mask |= 0x200000000;
				mask |= 0x10000000000000;
				startPtr[18] |= mask;
				
				startPtr += 19;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor21(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 3;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000;
			mask |= 0x2000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 24){
				mask = startPtr[0];
				mask |= 0x40;
				mask |= 0x8000000;
				mask |= 0x1000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x20;
				mask |= 0x4000000;
				mask |= 0x800000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x10;
				mask |= 0x2000000;
				mask |= 0x400000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x8;
				mask |= 0x1000000;
				mask |= 0x200000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4;
				mask |= 0x800000;
				mask |= 0x100000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x2;
				mask |= 0x400000;
				mask |= 0x80000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x1;
				mask |= 0x200000;
				mask |= 0x40000000000;
				mask |= 0x8000000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x100000;
				mask |= 0x20000000000;
				mask |= 0x4000000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x80000;
				mask |= 0x10000000000;
				mask |= 0x2000000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x40000;
				mask |= 0x8000000000;
				mask |= 0x1000000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x20000;
				mask |= 0x4000000000;
				mask |= 0x800000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x10000;
				mask |= 0x2000000000;
				mask |= 0x400000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x8000;
				mask |= 0x1000000000;
				mask |= 0x200000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x4000;
				mask |= 0x800000000;
				mask |= 0x100000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x2000;
				mask |= 0x400000000;
				mask |= 0x80000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x1000;
				mask |= 0x200000000;
				mask |= 0x40000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x800;
				mask |= 0x100000000;
				mask |= 0x20000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x400;
				mask |= 0x80000000;
				mask |= 0x10000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x200;
				mask |= 0x40000000;
				mask |= 0x8000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x100;
				mask |= 0x20000000;
				mask |= 0x4000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x80;
				mask |= 0x10000000;
				mask |= 0x2000000000000;
				startPtr[20] |= mask;
				
				startPtr += 21;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor23(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 4;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100;
			mask |= 0x80000000;
			mask |= 0x40000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 27){
				mask = startPtr[0];
				mask |= 0x2000;
				mask |= 0x1000000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x40000;
				mask |= 0x20000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1;
				mask |= 0x800000;
				mask |= 0x400000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x20;
				mask |= 0x10000000;
				mask |= 0x8000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400;
				mask |= 0x200000000;
				mask |= 0x100000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x8000;
				mask |= 0x4000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100000;
				mask |= 0x80000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x4;
				mask |= 0x2000000;
				mask |= 0x1000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x80;
				mask |= 0x40000000;
				mask |= 0x20000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x1000;
				mask |= 0x800000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x20000;
				mask |= 0x10000000000;
				mask |= 0x8000000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x400000;
				mask |= 0x200000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x10;
				mask |= 0x8000000;
				mask |= 0x4000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x200;
				mask |= 0x100000000;
				mask |= 0x80000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x4000;
				mask |= 0x2000000000;
				mask |= 0x1000000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80000;
				mask |= 0x40000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x2;
				mask |= 0x1000000;
				mask |= 0x800000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x40;
				mask |= 0x20000000;
				mask |= 0x10000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x800;
				mask |= 0x400000000;
				mask |= 0x200000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x10000;
				mask |= 0x8000000000;
				mask |= 0x4000000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x200000;
				mask |= 0x100000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x8;
				mask |= 0x4000000;
				mask |= 0x2000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x100;
				mask |= 0x80000000;
				mask |= 0x40000000000000;
				startPtr[22] |= mask;
				
				startPtr += 23;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor25(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 4;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 29){
				mask = startPtr[0];
				mask |= 0x20000;
				mask |= 0x40000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x8;
				mask |= 0x10000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x4000;
				mask |= 0x8000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x1;
				mask |= 0x2000000;
				mask |= 0x4000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x800;
				mask |= 0x1000000000;
				mask |= 0x2000000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x400000;
				mask |= 0x800000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100;
				mask |= 0x200000000;
				mask |= 0x400000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x80000;
				mask |= 0x100000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x20;
				mask |= 0x40000000;
				mask |= 0x80000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x10000;
				mask |= 0x20000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x4;
				mask |= 0x8000000;
				mask |= 0x10000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x2000;
				mask |= 0x4000000000;
				mask |= 0x8000000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x1000000;
				mask |= 0x2000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x400;
				mask |= 0x800000000;
				mask |= 0x1000000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x200000;
				mask |= 0x400000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80;
				mask |= 0x100000000;
				mask |= 0x200000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x40000;
				mask |= 0x80000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x10;
				mask |= 0x20000000;
				mask |= 0x40000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x8000;
				mask |= 0x10000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x2;
				mask |= 0x4000000;
				mask |= 0x8000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x1000;
				mask |= 0x2000000000;
				mask |= 0x4000000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x800000;
				mask |= 0x1000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x200;
				mask |= 0x400000000;
				mask |= 0x800000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x100000;
				mask |= 0x200000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x40;
				mask |= 0x80000000;
				mask |= 0x100000000000000;
				startPtr[24] |= mask;
				
				startPtr += 25;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor27(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 5;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 32){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x400000000;
				mask |= 0x2000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x1000000;
				mask |= 0x8000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x4000;
				mask |= 0x20000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x10;
				mask |= 0x80000000;
				mask |= 0x400000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x200000;
				mask |= 0x1000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x800;
				mask |= 0x4000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x2;
				mask |= 0x10000000;
				mask |= 0x80000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x40000;
				mask |= 0x200000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x100;
				mask |= 0x800000000;
				mask |= 0x4000000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x2000000;
				mask |= 0x10000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x8000;
				mask |= 0x40000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x20;
				mask |= 0x100000000;
				mask |= 0x800000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x400000;
				mask |= 0x2000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x1000;
				mask |= 0x8000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x4;
				mask |= 0x20000000;
				mask |= 0x100000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80000;
				mask |= 0x400000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200;
				mask |= 0x1000000000;
				mask |= 0x8000000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x4000000;
				mask |= 0x20000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x10000;
				mask |= 0x80000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x40;
				mask |= 0x200000000;
				mask |= 0x1000000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x800000;
				mask |= 0x4000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x2000;
				mask |= 0x10000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x8;
				mask |= 0x40000000;
				mask |= 0x200000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x100000;
				mask |= 0x800000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x400;
				mask |= 0x2000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x1;
				mask |= 0x8000000;
				mask |= 0x40000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x20000;
				mask |= 0x100000000000;
				startPtr[26] |= mask;
				
				startPtr += 27;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor29(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 6;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 35){
				mask = startPtr[0];
				mask |= 0x2;
				mask |= 0x40000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x1000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x40000;
				mask |= 0x800000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x1000;
				mask |= 0x20000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x40;
				mask |= 0x800000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x1;
				mask |= 0x20000000;
				mask |= 0x400000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x800000;
				mask |= 0x10000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x20000;
				mask |= 0x400000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x800;
				mask |= 0x10000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x20;
				mask |= 0x400000000;
				mask |= 0x8000000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x10000000;
				mask |= 0x200000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x400000;
				mask |= 0x8000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x10000;
				mask |= 0x200000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x400;
				mask |= 0x8000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x10;
				mask |= 0x200000000;
				mask |= 0x4000000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x8000000;
				mask |= 0x100000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200000;
				mask |= 0x4000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x8000;
				mask |= 0x100000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x200;
				mask |= 0x4000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x8;
				mask |= 0x100000000;
				mask |= 0x2000000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x4000000;
				mask |= 0x80000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x100000;
				mask |= 0x2000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x4000;
				mask |= 0x80000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x100;
				mask |= 0x2000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x4;
				mask |= 0x80000000;
				mask |= 0x1000000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x2000000;
				mask |= 0x40000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x80000;
				mask |= 0x1000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x2000;
				mask |= 0x40000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x80;
				mask |= 0x1000000000;
				startPtr[28] |= mask;
				
				startPtr += 29;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor31(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 7;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000;
			mask |= 0x8000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 38){
				mask = startPtr[0];
				mask |= 0x40000000;
				mask |= 0x2000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x10000000;
				mask |= 0x800000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x4000000;
				mask |= 0x200000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x1000000;
				mask |= 0x80000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400000;
				mask |= 0x20000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x100000;
				mask |= 0x8000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x40000;
				mask |= 0x2000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x10000;
				mask |= 0x800000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000;
				mask |= 0x200000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x1000;
				mask |= 0x80000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x400;
				mask |= 0x20000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x100;
				mask |= 0x8000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x40;
				mask |= 0x2000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x10;
				mask |= 0x800000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x4;
				mask |= 0x200000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x1;
				mask |= 0x80000000;
				mask |= 0x4000000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x20000000;
				mask |= 0x1000000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x8000000;
				mask |= 0x400000000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x2000000;
				mask |= 0x100000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x800000;
				mask |= 0x40000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x200000;
				mask |= 0x10000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x80000;
				mask |= 0x4000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x20000;
				mask |= 0x1000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x8000;
				mask |= 0x400000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x2000;
				mask |= 0x100000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x800;
				mask |= 0x40000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x200;
				mask |= 0x10000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x80;
				mask |= 0x4000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x20;
				mask |= 0x1000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x8;
				mask |= 0x400000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x2;
				mask |= 0x100000000;
				mask |= 0x8000000000000000;
				startPtr[30] |= mask;
				
				startPtr += 31;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor33(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 8;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 41){
				mask = startPtr[0];
				mask |= 0x2;
				mask |= 0x400000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x8;
				mask |= 0x1000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x20;
				mask |= 0x4000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x80;
				mask |= 0x10000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x200;
				mask |= 0x40000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x800;
				mask |= 0x100000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x2000;
				mask |= 0x400000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x8000;
				mask |= 0x1000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x20000;
				mask |= 0x4000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x80000;
				mask |= 0x10000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x200000;
				mask |= 0x40000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x800000;
				mask |= 0x100000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x2000000;
				mask |= 0x400000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x8000000;
				mask |= 0x1000000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x20000000;
				mask |= 0x4000000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x1;
				mask |= 0x200000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x4;
				mask |= 0x800000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x10;
				mask |= 0x2000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x40;
				mask |= 0x8000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x100;
				mask |= 0x20000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x400;
				mask |= 0x80000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x1000;
				mask |= 0x200000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x4000;
				mask |= 0x800000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x10000;
				mask |= 0x2000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x40000;
				mask |= 0x8000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x100000;
				mask |= 0x20000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x400000;
				mask |= 0x80000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x1000000;
				mask |= 0x200000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x4000000;
				mask |= 0x800000000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x10000000;
				mask |= 0x2000000000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x40000000;
				mask |= 0x8000000000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x100000000;
				startPtr[32] |= mask;
				
				startPtr += 33;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor35(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 9;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 44){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x40000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x2000;
				mask |= 0x1000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x80000;
				mask |= 0x40000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x2000000;
				mask |= 0x1000000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x80000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x4;
				mask |= 0x2000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100;
				mask |= 0x80000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x4000;
				mask |= 0x2000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x100000;
				mask |= 0x80000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x4000000;
				mask |= 0x2000000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x100000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x8;
				mask |= 0x4000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x200;
				mask |= 0x100000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x8000;
				mask |= 0x4000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x200000;
				mask |= 0x100000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x8000000;
				mask |= 0x4000000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x10;
				mask |= 0x8000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400;
				mask |= 0x200000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x10000;
				mask |= 0x8000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x400000;
				mask |= 0x200000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x10000000;
				mask |= 0x8000000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x400000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x20;
				mask |= 0x10000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x800;
				mask |= 0x400000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x20000;
				mask |= 0x10000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x800000;
				mask |= 0x400000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x20000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x1;
				mask |= 0x800000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x40;
				mask |= 0x20000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x1000;
				mask |= 0x800000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x40000;
				mask |= 0x20000000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x1000000;
				mask |= 0x800000000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x40000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x2;
				mask |= 0x1000000000;
				startPtr[34] |= mask;
				
				startPtr += 35;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor37(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 10;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 47){
				mask = startPtr[0];
				mask |= 0x20000;
				mask |= 0x40000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x8000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1;
				mask |= 0x2000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x400;
				mask |= 0x800000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x100000;
				mask |= 0x200000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x40000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x8;
				mask |= 0x10000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x2000;
				mask |= 0x4000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x800000;
				mask |= 0x1000000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x200000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x40;
				mask |= 0x80000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x10000;
				mask |= 0x20000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x4000000;
				mask |= 0x8000000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x1000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x200;
				mask |= 0x400000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80000;
				mask |= 0x100000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x20000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x4;
				mask |= 0x8000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x1000;
				mask |= 0x2000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x400000;
				mask |= 0x800000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x100000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x20;
				mask |= 0x40000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x8000;
				mask |= 0x10000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x2000000;
				mask |= 0x4000000000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x800000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x100;
				mask |= 0x200000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x40000;
				mask |= 0x80000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x10000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x2;
				mask |= 0x4000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x800;
				mask |= 0x1000000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x200000;
				mask |= 0x400000000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x80000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x10;
				mask |= 0x20000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x4000;
				mask |= 0x8000000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x1000000;
				mask |= 0x2000000000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x400000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x80;
				mask |= 0x100000000000;
				startPtr[36] |= mask;
				
				startPtr += 37;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor39(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 11;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 50){
				mask = startPtr[0];
				mask |= 0x80000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x40;
				mask |= 0x200000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x100000;
				mask |= 0x800000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x400000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x200;
				mask |= 0x1000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x800000;
				mask |= 0x4000000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x2000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x1000;
				mask |= 0x8000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x2;
				mask |= 0x10000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x8000;
				mask |= 0x40000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x20000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x10;
				mask |= 0x80000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x40000;
				mask |= 0x200000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x100000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80;
				mask |= 0x400000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200000;
				mask |= 0x1000000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x800000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400;
				mask |= 0x2000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x1000000;
				mask |= 0x8000000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x4000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x2000;
				mask |= 0x10000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x8000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x4;
				mask |= 0x20000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x10000;
				mask |= 0x80000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x40000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x20;
				mask |= 0x100000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x80000;
				mask |= 0x400000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x200000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x100;
				mask |= 0x800000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x400000;
				mask |= 0x2000000000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x1000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x800;
				mask |= 0x4000000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x2000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x1;
				mask |= 0x8000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x4000;
				mask |= 0x20000000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x10000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x8;
				mask |= 0x40000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x20000;
				mask |= 0x100000000000000;
				startPtr[38] |= mask;
				
				startPtr += 39;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor41(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 13;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100;
			mask |= 0x2000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 54){
				mask = startPtr[0];
				mask |= 0x4000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x8;
				mask |= 0x100000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x200000;
				mask |= 0x4000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x8000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x10000;
				mask |= 0x200000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x400000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x800;
				mask |= 0x10000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x20000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x40;
				mask |= 0x800000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x1000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x2;
				mask |= 0x40000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x80000;
				mask |= 0x1000000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x2000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x4000;
				mask |= 0x80000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x100000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x200;
				mask |= 0x4000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x8000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x10;
				mask |= 0x200000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400000;
				mask |= 0x8000000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x10000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x20000;
				mask |= 0x400000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x800000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x1000;
				mask |= 0x20000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x40000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x80;
				mask |= 0x1000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x2000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x4;
				mask |= 0x80000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x100000;
				mask |= 0x2000000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x4000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x8000;
				mask |= 0x100000000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x200000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x400;
				mask |= 0x8000000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x10000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x20;
				mask |= 0x400000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x800000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x1;
				mask |= 0x20000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x40000;
				mask |= 0x800000000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x1000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x2000;
				mask |= 0x40000000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x80000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x100;
				mask |= 0x2000000000000;
				startPtr[40] |= mask;
				
				startPtr += 41;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor43(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 14;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 57){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x4000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x20000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x100;
				mask |= 0x8000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x40000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x200;
				mask |= 0x10000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x80000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x400;
				mask |= 0x20000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x100000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x800;
				mask |= 0x40000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x200000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x1000;
				mask |= 0x80000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x400000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x2000;
				mask |= 0x100000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x800000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x4000;
				mask |= 0x200000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x1000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x8000;
				mask |= 0x400000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x2000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x10000;
				mask |= 0x800000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x4000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x20000;
				mask |= 0x1000000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x8000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x40000;
				mask |= 0x2000000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x10000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x80000;
				mask |= 0x4000000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x20000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x100000;
				mask |= 0x8000000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x40000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x200000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x1;
				mask |= 0x80000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x400000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x2;
				mask |= 0x100000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x800000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x4;
				mask |= 0x200000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x1000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x8;
				mask |= 0x400000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x2000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x10;
				mask |= 0x800000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x4000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x20;
				mask |= 0x1000000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x8000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x40;
				mask |= 0x2000000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x10000000;
				startPtr[42] |= mask;
				
				startPtr += 43;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor45(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 15;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 60){
				mask = startPtr[0];
				mask |= 0x200000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x4000;
				mask |= 0x800000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x10000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x200000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4;
				mask |= 0x800000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x10000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x200;
				mask |= 0x40000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x800000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x10000;
				mask |= 0x2000000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x40000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x800000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x10;
				mask |= 0x2000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x40000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x800;
				mask |= 0x100000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x2000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x40000;
				mask |= 0x8000000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x100000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x2000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x40;
				mask |= 0x8000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x100000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x2000;
				mask |= 0x400000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x8000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x100000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x2;
				mask |= 0x400000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x8000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x100;
				mask |= 0x20000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x400000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x8000;
				mask |= 0x1000000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x20000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x400000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x8;
				mask |= 0x1000000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x20000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x400;
				mask |= 0x80000000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x1000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x20000;
				mask |= 0x4000000000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x80000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x1000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x20;
				mask |= 0x4000000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x80000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x1000;
				mask |= 0x200000000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x4000000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x80000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x1;
				mask |= 0x200000000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x4000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x80;
				mask |= 0x10000000000000;
				startPtr[44] |= mask;
				
				startPtr += 45;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor47(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 17;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000;
			mask |= 0x8000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 64){
				mask = startPtr[0];
				mask |= 0x400000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x20000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1000;
				mask |= 0x800000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x40000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x2000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x100;
				mask |= 0x80000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x4000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x200000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x10;
				mask |= 0x8000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x400000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x20000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x1;
				mask |= 0x800000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x40000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x2000;
				mask |= 0x1000000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x80000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x4000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200;
				mask |= 0x100000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x8000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x20;
				mask |= 0x10000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x800000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x40000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x2;
				mask |= 0x1000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x80000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x4000;
				mask |= 0x2000000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x100000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x8000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x400;
				mask |= 0x200000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x10000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x800000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x40;
				mask |= 0x20000000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x1000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x80000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x4;
				mask |= 0x2000000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x100000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x8000;
				mask |= 0x4000000000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x200000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x10000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x800;
				mask |= 0x400000000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x20000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x1000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x80;
				mask |= 0x40000000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x2000000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x100000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x8;
				mask |= 0x4000000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x200000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x10000;
				mask |= 0x8000000000000000;
				startPtr[46] |= mask;
				
				startPtr += 47;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor49(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 18;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 67){
				mask = startPtr[0];
				mask |= 0x200000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x40000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x8;
				mask |= 0x10000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x2000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x80;
				mask |= 0x100000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x20000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x4000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x800;
				mask |= 0x1000000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x200000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x40000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x8000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x1;
				mask |= 0x2000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x400000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x80000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x10;
				mask |= 0x20000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x4000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x800000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x100;
				mask |= 0x200000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x40000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x8000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x1000;
				mask |= 0x2000000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x400000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x80000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x10000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x2;
				mask |= 0x4000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x800000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x100000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x20;
				mask |= 0x40000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x8000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x1000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x200;
				mask |= 0x400000000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x80000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x10000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x2000;
				mask |= 0x4000000000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x800000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x100000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x20000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x4;
				mask |= 0x8000000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x1000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x200000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x40;
				mask |= 0x80000000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x10000000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x2000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x400;
				mask |= 0x800000000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x100000000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x20000000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x4000;
				mask |= 0x8000000000000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x1000000000000;
				startPtr[48] |= mask;
				
				startPtr += 49;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor51(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 20;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x100000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 71){
				mask = startPtr[0];
				mask |= 0x80;
				mask |= 0x400000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x200000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x100000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x80000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x40;
				mask |= 0x200000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x100000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x80000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x40000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x20;
				mask |= 0x100000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x80000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x40000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x20000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x10;
				mask |= 0x80000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x40000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x20000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x10000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x8;
				mask |= 0x40000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x20000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x10000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x8000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x4;
				mask |= 0x20000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x10000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x8000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x4000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x2;
				mask |= 0x10000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x8000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x4000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x2000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x1;
				mask |= 0x8000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x4000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x2000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x1000;
				mask |= 0x8000000000000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x4000000000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x2000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x1000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x800;
				mask |= 0x4000000000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x2000000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x1000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x800000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x400;
				mask |= 0x2000000000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x1000000000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x800000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x400000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x200;
				mask |= 0x1000000000000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x800000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x400000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x200000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x100;
				mask |= 0x800000000000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x400000000000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x200000000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x100000;
				startPtr[50] |= mask;
				
				startPtr += 51;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor53(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 21;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 74){
				mask = startPtr[0];
				mask |= 0x2000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x4000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x8000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x10000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x20;
				mask |= 0x400000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x800000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x1000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x2000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x8;
				mask |= 0x100000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x200000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x400000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x800000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x1000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x2;
				mask |= 0x40000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x80000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x100000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x200000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400;
				mask |= 0x8000000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x10000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x20000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x40000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x80000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x100;
				mask |= 0x2000000000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x4000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x8000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x10000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x20000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x40;
				mask |= 0x800000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x1000000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x2000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x4000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x8000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x10;
				mask |= 0x200000000000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x400000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x800000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x1000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x2000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x4;
				mask |= 0x80000000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x100000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x200000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x400000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x800;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x1;
				mask |= 0x20000000000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x40000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x80000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x100000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x200;
				mask |= 0x4000000000000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x8000000000000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x10000000000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x20000000;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x40000;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x80;
				mask |= 0x1000000000000000;
				startPtr[52] |= mask;
				
				startPtr += 53;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor55(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 23;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 78){
				mask = startPtr[0];
				mask |= 0x80000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x400000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x2000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x10;
				mask |= 0x800000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x20000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x800000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x20;
				mask |= 0x1000000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x8000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x40000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x200000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x1000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x8000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x40;
				mask |= 0x2000000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x10000000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x80000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x400000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x2000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x10000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x80;
				mask |= 0x4000000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x20000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x100000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x800000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x4000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x20000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x100;
				mask |= 0x8000000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x40000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x200000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x1000000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x8000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x40000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x200;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x1;
				mask |= 0x80000000000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x400000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x2000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x10000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x80000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x400;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x2;
				mask |= 0x100000000000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x800000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x4000000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x20000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x100000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x800;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x4;
				mask |= 0x200000000000000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x1000000000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x8000000000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x40000000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x200000;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x1000;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x8;
				mask |= 0x400000000000000;
				startPtr[52] |= mask;
				
				mask = startPtr[53];
				mask |= 0x2000000000000;
				startPtr[53] |= mask;
				
				mask = startPtr[54];
				mask |= 0x10000000000;
				startPtr[54] |= mask;
				
				startPtr += 55;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor57(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 25;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 82){
				mask = startPtr[0];
				mask |= 0x20000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x400;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x8;
				mask |= 0x1000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x20000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x8000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x2000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x40000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x800;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x10;
				mask |= 0x2000000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x40000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x800000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x10000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x200000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x4000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x80000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x1000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x20;
				mask |= 0x4000000000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x80000000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x1000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x20000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x400000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x8000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x100000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x2000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x40;
				mask |= 0x8000000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x100000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x2000000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x40000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x800000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x10000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x200000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x4000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x80;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x1;
				mask |= 0x200000000000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x4000000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x80000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x1000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x20000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x400000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x8000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x100;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x2;
				mask |= 0x400000000000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x8000000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x100000000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x2000000000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x40000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x800000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x10000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x200;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x4;
				mask |= 0x800000000000000;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x10000000000000;
				startPtr[52] |= mask;
				
				mask = startPtr[53];
				mask |= 0x200000000000;
				startPtr[53] |= mask;
				
				mask = startPtr[54];
				mask |= 0x4000000000;
				startPtr[54] |= mask;
				
				mask = startPtr[55];
				mask |= 0x80000000;
				startPtr[55] |= mask;
				
				mask = startPtr[56];
				mask |= 0x1000000;
				startPtr[56] |= mask;
				
				startPtr += 57;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor59(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 27;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 86){
				mask = startPtr[0];
				mask |= 0x80;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x4;
				mask |= 0x2000000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x100000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x8000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x20000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x1000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x80000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x200000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x10000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x800;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x40;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x2;
				mask |= 0x1000000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x80000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x4000000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x200000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x10000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x800000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x40000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x2000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x100000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x8000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x400;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x20;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x1;
				mask |= 0x800000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x40000000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x2000000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x100000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x8000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x400000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x20000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x1000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x80000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x4000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x200;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x10;
				mask |= 0x8000000000000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x400000000000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x20000000000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x1000000000000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x80000000000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x4000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x200000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x10000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x800000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x40000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x2000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x100;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x8;
				mask |= 0x4000000000000000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x200000000000000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x10000000000000;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x800000000000;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x40000000000;
				startPtr[52] |= mask;
				
				mask = startPtr[53];
				mask |= 0x2000000000;
				startPtr[53] |= mask;
				
				mask = startPtr[54];
				mask |= 0x100000000;
				startPtr[54] |= mask;
				
				mask = startPtr[55];
				mask |= 0x8000000;
				startPtr[55] |= mask;
				
				mask = startPtr[56];
				mask |= 0x400000;
				startPtr[56] |= mask;
				
				mask = startPtr[57];
				mask |= 0x20000;
				startPtr[57] |= mask;
				
				mask = startPtr[58];
				mask |= 0x1000;
				startPtr[58] |= mask;
				
				startPtr += 59;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor61(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 29;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x10;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 90){
				mask = startPtr[0];
				mask |= 0x2;
				mask |= 0x4000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x800000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x100000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x20000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x4000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x800000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x20000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x4000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x800000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x100000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x20000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x4000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x800000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x100000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x20000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x4000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x800;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x100;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x20;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x4;
				mask |= 0x8000000000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x1000000000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x200000000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x40000000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x8000000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x1000000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x200000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x40000000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x8000000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x1000000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x200000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x40000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x8000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x1000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x200000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x40000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x8000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x1000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x200;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x40;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x8;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x1;
				mask |= 0x2000000000000000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x400000000000000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x80000000000000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x10000000000000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x2000000000000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x400000000000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x80000000000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x10000000000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x2000000000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x400000000;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x80000000;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x10000000;
				startPtr[52] |= mask;
				
				mask = startPtr[53];
				mask |= 0x2000000;
				startPtr[53] |= mask;
				
				mask = startPtr[54];
				mask |= 0x400000;
				startPtr[54] |= mask;
				
				mask = startPtr[55];
				mask |= 0x80000;
				startPtr[55] |= mask;
				
				mask = startPtr[56];
				mask |= 0x10000;
				startPtr[56] |= mask;
				
				mask = startPtr[57];
				mask |= 0x2000;
				startPtr[57] |= mask;
				
				mask = startPtr[58];
				mask |= 0x400;
				startPtr[58] |= mask;
				
				mask = startPtr[59];
				mask |= 0x80;
				startPtr[59] |= mask;
				
				mask = startPtr[60];
				mask |= 0x10;
				startPtr[60] |= mask;
				
				startPtr += 61;
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static unsafe void ClearFactor63(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 31;
			var endPtr = ptr + limit / 64 + 1;

			ulong mask = startPtr[0];
			mask |= 0x1;
			mask |= 0x8000000000000000;
			startPtr[0] = mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 94){
				mask = startPtr[0];
				mask |= 0x4000000000000000;
				startPtr[0] |= mask;
				
				mask = startPtr[1];
				mask |= 0x2000000000000000;
				startPtr[1] |= mask;
				
				mask = startPtr[2];
				mask |= 0x1000000000000000;
				startPtr[2] |= mask;
				
				mask = startPtr[3];
				mask |= 0x800000000000000;
				startPtr[3] |= mask;
				
				mask = startPtr[4];
				mask |= 0x400000000000000;
				startPtr[4] |= mask;
				
				mask = startPtr[5];
				mask |= 0x200000000000000;
				startPtr[5] |= mask;
				
				mask = startPtr[6];
				mask |= 0x100000000000000;
				startPtr[6] |= mask;
				
				mask = startPtr[7];
				mask |= 0x80000000000000;
				startPtr[7] |= mask;
				
				mask = startPtr[8];
				mask |= 0x40000000000000;
				startPtr[8] |= mask;
				
				mask = startPtr[9];
				mask |= 0x20000000000000;
				startPtr[9] |= mask;
				
				mask = startPtr[10];
				mask |= 0x10000000000000;
				startPtr[10] |= mask;
				
				mask = startPtr[11];
				mask |= 0x8000000000000;
				startPtr[11] |= mask;
				
				mask = startPtr[12];
				mask |= 0x4000000000000;
				startPtr[12] |= mask;
				
				mask = startPtr[13];
				mask |= 0x2000000000000;
				startPtr[13] |= mask;
				
				mask = startPtr[14];
				mask |= 0x1000000000000;
				startPtr[14] |= mask;
				
				mask = startPtr[15];
				mask |= 0x800000000000;
				startPtr[15] |= mask;
				
				mask = startPtr[16];
				mask |= 0x400000000000;
				startPtr[16] |= mask;
				
				mask = startPtr[17];
				mask |= 0x200000000000;
				startPtr[17] |= mask;
				
				mask = startPtr[18];
				mask |= 0x100000000000;
				startPtr[18] |= mask;
				
				mask = startPtr[19];
				mask |= 0x80000000000;
				startPtr[19] |= mask;
				
				mask = startPtr[20];
				mask |= 0x40000000000;
				startPtr[20] |= mask;
				
				mask = startPtr[21];
				mask |= 0x20000000000;
				startPtr[21] |= mask;
				
				mask = startPtr[22];
				mask |= 0x10000000000;
				startPtr[22] |= mask;
				
				mask = startPtr[23];
				mask |= 0x8000000000;
				startPtr[23] |= mask;
				
				mask = startPtr[24];
				mask |= 0x4000000000;
				startPtr[24] |= mask;
				
				mask = startPtr[25];
				mask |= 0x2000000000;
				startPtr[25] |= mask;
				
				mask = startPtr[26];
				mask |= 0x1000000000;
				startPtr[26] |= mask;
				
				mask = startPtr[27];
				mask |= 0x800000000;
				startPtr[27] |= mask;
				
				mask = startPtr[28];
				mask |= 0x400000000;
				startPtr[28] |= mask;
				
				mask = startPtr[29];
				mask |= 0x200000000;
				startPtr[29] |= mask;
				
				mask = startPtr[30];
				mask |= 0x100000000;
				startPtr[30] |= mask;
				
				mask = startPtr[31];
				mask |= 0x80000000;
				startPtr[31] |= mask;
				
				mask = startPtr[32];
				mask |= 0x40000000;
				startPtr[32] |= mask;
				
				mask = startPtr[33];
				mask |= 0x20000000;
				startPtr[33] |= mask;
				
				mask = startPtr[34];
				mask |= 0x10000000;
				startPtr[34] |= mask;
				
				mask = startPtr[35];
				mask |= 0x8000000;
				startPtr[35] |= mask;
				
				mask = startPtr[36];
				mask |= 0x4000000;
				startPtr[36] |= mask;
				
				mask = startPtr[37];
				mask |= 0x2000000;
				startPtr[37] |= mask;
				
				mask = startPtr[38];
				mask |= 0x1000000;
				startPtr[38] |= mask;
				
				mask = startPtr[39];
				mask |= 0x800000;
				startPtr[39] |= mask;
				
				mask = startPtr[40];
				mask |= 0x400000;
				startPtr[40] |= mask;
				
				mask = startPtr[41];
				mask |= 0x200000;
				startPtr[41] |= mask;
				
				mask = startPtr[42];
				mask |= 0x100000;
				startPtr[42] |= mask;
				
				mask = startPtr[43];
				mask |= 0x80000;
				startPtr[43] |= mask;
				
				mask = startPtr[44];
				mask |= 0x40000;
				startPtr[44] |= mask;
				
				mask = startPtr[45];
				mask |= 0x20000;
				startPtr[45] |= mask;
				
				mask = startPtr[46];
				mask |= 0x10000;
				startPtr[46] |= mask;
				
				mask = startPtr[47];
				mask |= 0x8000;
				startPtr[47] |= mask;
				
				mask = startPtr[48];
				mask |= 0x4000;
				startPtr[48] |= mask;
				
				mask = startPtr[49];
				mask |= 0x2000;
				startPtr[49] |= mask;
				
				mask = startPtr[50];
				mask |= 0x1000;
				startPtr[50] |= mask;
				
				mask = startPtr[51];
				mask |= 0x800;
				startPtr[51] |= mask;
				
				mask = startPtr[52];
				mask |= 0x400;
				startPtr[52] |= mask;
				
				mask = startPtr[53];
				mask |= 0x200;
				startPtr[53] |= mask;
				
				mask = startPtr[54];
				mask |= 0x100;
				startPtr[54] |= mask;
				
				mask = startPtr[55];
				mask |= 0x80;
				startPtr[55] |= mask;
				
				mask = startPtr[56];
				mask |= 0x40;
				startPtr[56] |= mask;
				
				mask = startPtr[57];
				mask |= 0x20;
				startPtr[57] |= mask;
				
				mask = startPtr[58];
				mask |= 0x10;
				startPtr[58] |= mask;
				
				mask = startPtr[59];
				mask |= 0x8;
				startPtr[59] |= mask;
				
				mask = startPtr[60];
				mask |= 0x4;
				startPtr[60] |= mask;
				
				mask = startPtr[61];
				mask |= 0x2;
				startPtr[61] |= mask;
				
				mask = startPtr[62];
				mask |= 0x1;
				mask |= 0x8000000000000000;
				startPtr[62] |= mask;
				
				startPtr += 63;
			}
		}
	}
}