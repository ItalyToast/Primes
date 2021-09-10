
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrimeSieveCS
{ 
	class Unrolled
	{
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
			}
		}

		public static unsafe void ClearFactor3(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

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
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 3){
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
		public static unsafe void ClearFactor5(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

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
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 5){
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
		public static unsafe void ClearFactor7(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x1000000;
			mask |= 0x80000000;
			mask |= 0x4000000000;
			mask |= 0x200000000000;
			mask |= 0x10000000000000;
			mask |= 0x800000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 7){
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
				
				mask = 0;
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
		public static unsafe void ClearFactor9(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x10000000000;
			mask |= 0x2000000000000;
			mask |= 0x400000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 9){
				mask = 0;
				mask |= 0x8;
				mask |= 0x1000;
				mask |= 0x200000;
				mask |= 0x40000000;
				mask |= 0x8000000000;
				mask |= 0x1000000000000;
				mask |= 0x200000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x800;
				mask |= 0x100000;
				mask |= 0x20000000;
				mask |= 0x4000000000;
				mask |= 0x800000000000;
				mask |= 0x100000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x400;
				mask |= 0x80000;
				mask |= 0x10000000;
				mask |= 0x2000000000;
				mask |= 0x400000000000;
				mask |= 0x80000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x200;
				mask |= 0x40000;
				mask |= 0x8000000;
				mask |= 0x1000000000;
				mask |= 0x200000000000;
				mask |= 0x40000000000000;
				mask |= 0x8000000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x20000;
				mask |= 0x4000000;
				mask |= 0x800000000;
				mask |= 0x100000000000;
				mask |= 0x20000000000000;
				mask |= 0x4000000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x10000;
				mask |= 0x2000000;
				mask |= 0x400000000;
				mask |= 0x80000000000;
				mask |= 0x10000000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x8000;
				mask |= 0x1000000;
				mask |= 0x200000000;
				mask |= 0x40000000000;
				mask |= 0x8000000000000;
				mask |= 0x1000000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x4000;
				mask |= 0x800000;
				mask |= 0x100000000;
				mask |= 0x20000000000;
				mask |= 0x4000000000000;
				mask |= 0x800000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
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
		public static unsafe void ClearFactor11(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 0;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x1000000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 11){
				mask = 0;
				mask |= 0x80;
				mask |= 0x40000;
				mask |= 0x20000000;
				mask |= 0x10000000000;
				mask |= 0x8000000000000;
				mask |= 0x4000000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x100000;
				mask |= 0x80000000;
				mask |= 0x40000000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x800;
				mask |= 0x400000;
				mask |= 0x200000000;
				mask |= 0x100000000000;
				mask |= 0x80000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x2000;
				mask |= 0x1000000;
				mask |= 0x800000000;
				mask |= 0x400000000000;
				mask |= 0x200000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x8000;
				mask |= 0x4000000;
				mask |= 0x2000000000;
				mask |= 0x1000000000000;
				mask |= 0x800000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x20000;
				mask |= 0x10000000;
				mask |= 0x8000000000;
				mask |= 0x4000000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x80000;
				mask |= 0x40000000;
				mask |= 0x20000000000;
				mask |= 0x10000000000000;
				mask |= 0x8000000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x200000;
				mask |= 0x100000000;
				mask |= 0x80000000000;
				mask |= 0x40000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x1000;
				mask |= 0x800000;
				mask |= 0x400000000;
				mask |= 0x200000000000;
				mask |= 0x100000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x4000;
				mask |= 0x2000000;
				mask |= 0x1000000000;
				mask |= 0x800000000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
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
		public static unsafe void ClearFactor13(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 1;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x100000;
			mask |= 0x200000000;
			mask |= 0x400000000000;
			mask |= 0x800000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 14){
				mask = 0;
				mask |= 0x100;
				mask |= 0x200000;
				mask |= 0x400000000;
				mask |= 0x800000000000;
				mask |= 0x1000000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x400000;
				mask |= 0x800000000;
				mask |= 0x1000000000000;
				mask |= 0x2000000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x800000;
				mask |= 0x1000000000;
				mask |= 0x2000000000000;
				mask |= 0x4000000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x1000000;
				mask |= 0x2000000000;
				mask |= 0x4000000000000;
				mask |= 0x8000000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x2000000;
				mask |= 0x4000000000;
				mask |= 0x8000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x2000;
				mask |= 0x4000000;
				mask |= 0x8000000000;
				mask |= 0x10000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x4000;
				mask |= 0x8000000;
				mask |= 0x10000000000;
				mask |= 0x20000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x8000;
				mask |= 0x10000000;
				mask |= 0x20000000000;
				mask |= 0x40000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x10000;
				mask |= 0x20000000;
				mask |= 0x40000000000;
				mask |= 0x80000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x20000;
				mask |= 0x40000000;
				mask |= 0x80000000000;
				mask |= 0x100000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x40000;
				mask |= 0x80000000;
				mask |= 0x100000000000;
				mask |= 0x200000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x80000;
				mask |= 0x100000000;
				mask |= 0x200000000000;
				mask |= 0x400000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x100000;
				mask |= 0x200000000;
				mask |= 0x400000000000;
				mask |= 0x800000000000000;
				startPtr[12] |= mask;
				
				startPtr += 13;
			}
		}
		public static unsafe void ClearFactor15(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 1;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x1000000000000;
			mask |= 0x8000000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 16){
				mask = 0;
				mask |= 0x4000;
				mask |= 0x20000000;
				mask |= 0x100000000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x2000000;
				mask |= 0x10000000000;
				mask |= 0x80000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x200000;
				mask |= 0x1000000000;
				mask |= 0x8000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x20000;
				mask |= 0x100000000;
				mask |= 0x800000000000;
				mask |= 0x4000000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x10000000;
				mask |= 0x80000000000;
				mask |= 0x400000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x1000000;
				mask |= 0x8000000000;
				mask |= 0x40000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x100000;
				mask |= 0x800000000;
				mask |= 0x4000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x10000;
				mask |= 0x80000000;
				mask |= 0x400000000000;
				mask |= 0x2000000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x8000000;
				mask |= 0x40000000000;
				mask |= 0x200000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x800000;
				mask |= 0x4000000000;
				mask |= 0x20000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x80000;
				mask |= 0x400000000;
				mask |= 0x2000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x8000;
				mask |= 0x40000000;
				mask |= 0x200000000000;
				mask |= 0x1000000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x4000000;
				mask |= 0x20000000000;
				mask |= 0x100000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x400000;
				mask |= 0x2000000000;
				mask |= 0x10000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x40000;
				mask |= 0x200000000;
				mask |= 0x1000000000000;
				mask |= 0x8000000000000000;
				startPtr[14] |= mask;
				
				startPtr += 15;
			}
		}
		public static unsafe void ClearFactor17(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 2;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x10000;
			mask |= 0x200000000;
			mask |= 0x4000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 19){
				mask = 0;
				mask |= 0x8;
				mask |= 0x100000;
				mask |= 0x2000000000;
				mask |= 0x40000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x1000000;
				mask |= 0x20000000000;
				mask |= 0x400000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x10000000;
				mask |= 0x200000000000;
				mask |= 0x4000000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x100000000;
				mask |= 0x2000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x80000;
				mask |= 0x1000000000;
				mask |= 0x20000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x800000;
				mask |= 0x10000000000;
				mask |= 0x200000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x8000000;
				mask |= 0x100000000000;
				mask |= 0x2000000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x80000000;
				mask |= 0x1000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x40000;
				mask |= 0x800000000;
				mask |= 0x10000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x400000;
				mask |= 0x8000000000;
				mask |= 0x100000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x4000000;
				mask |= 0x80000000000;
				mask |= 0x1000000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x40000000;
				mask |= 0x800000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x20000;
				mask |= 0x400000000;
				mask |= 0x8000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x200000;
				mask |= 0x4000000000;
				mask |= 0x80000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x2000000;
				mask |= 0x40000000000;
				mask |= 0x800000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x20000000;
				mask |= 0x400000000000;
				mask |= 0x8000000000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x200000000;
				mask |= 0x4000000000000;
				startPtr[16] |= mask;
				
				startPtr += 17;
			}
		}
		public static unsafe void ClearFactor19(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 2;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x10000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 21){
				mask = 0;
				mask |= 0x80;
				mask |= 0x4000000;
				mask |= 0x200000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x80000;
				mask |= 0x4000000000;
				mask |= 0x200000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x80000000;
				mask |= 0x4000000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x1000000;
				mask |= 0x80000000000;
				mask |= 0x4000000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x20000;
				mask |= 0x1000000000;
				mask |= 0x80000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x20000000;
				mask |= 0x1000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x400000;
				mask |= 0x20000000000;
				mask |= 0x1000000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x400000000;
				mask |= 0x20000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x8000000;
				mask |= 0x400000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x100000;
				mask |= 0x8000000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x100000000;
				mask |= 0x8000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x2000000;
				mask |= 0x100000000000;
				mask |= 0x8000000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x2000000000;
				mask |= 0x100000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x40000000;
				mask |= 0x2000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x800000;
				mask |= 0x40000000000;
				mask |= 0x2000000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x800000000;
				mask |= 0x40000000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x10000000;
				mask |= 0x800000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x200000;
				mask |= 0x10000000000;
				mask |= 0x800000000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x200000000;
				mask |= 0x10000000000000;
				startPtr[18] |= mask;
				
				startPtr += 19;
			}
		}
		public static unsafe void ClearFactor21(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 3;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x10000000;
			mask |= 0x2000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 24){
				mask = 0;
				mask |= 0x40;
				mask |= 0x8000000;
				mask |= 0x1000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x4000000;
				mask |= 0x800000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x2000000;
				mask |= 0x400000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x1000000;
				mask |= 0x200000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x800000;
				mask |= 0x100000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x400000;
				mask |= 0x80000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x200000;
				mask |= 0x40000000000;
				mask |= 0x8000000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x100000;
				mask |= 0x20000000000;
				mask |= 0x4000000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x80000;
				mask |= 0x10000000000;
				mask |= 0x2000000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x8000000000;
				mask |= 0x1000000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x20000;
				mask |= 0x4000000000;
				mask |= 0x800000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x2000000000;
				mask |= 0x400000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x1000000000;
				mask |= 0x200000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x800000000;
				mask |= 0x100000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x400000000;
				mask |= 0x80000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x200000000;
				mask |= 0x40000000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x100000000;
				mask |= 0x20000000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x80000000;
				mask |= 0x10000000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x40000000;
				mask |= 0x8000000000000;
				startPtr[18] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x20000000;
				mask |= 0x4000000000000;
				startPtr[19] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x10000000;
				mask |= 0x2000000000000;
				startPtr[20] |= mask;
				
				startPtr += 21;
			}
		}
		public static unsafe void ClearFactor23(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 4;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x100;
			mask |= 0x80000000;
			mask |= 0x40000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 27){
				mask = 0;
				mask |= 0x2000;
				mask |= 0x1000000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x20000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x800000;
				mask |= 0x400000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x10000000;
				mask |= 0x8000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x200000000;
				mask |= 0x100000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x4000000000;
				mask |= 0x2000000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x100000;
				mask |= 0x80000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x2000000;
				mask |= 0x1000000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x40000000;
				mask |= 0x20000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x800000000;
				mask |= 0x400000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x20000;
				mask |= 0x10000000000;
				mask |= 0x8000000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x400000;
				mask |= 0x200000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x8000000;
				mask |= 0x4000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x100000000;
				mask |= 0x80000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x2000000000;
				mask |= 0x1000000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x80000;
				mask |= 0x40000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x1000000;
				mask |= 0x800000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x20000000;
				mask |= 0x10000000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x400000000;
				mask |= 0x200000000000000;
				startPtr[18] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x8000000000;
				mask |= 0x4000000000000000;
				startPtr[19] |= mask;
				
				mask = 0;
				mask |= 0x200000;
				mask |= 0x100000000000;
				startPtr[20] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x4000000;
				mask |= 0x2000000000000;
				startPtr[21] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x80000000;
				mask |= 0x40000000000000;
				startPtr[22] |= mask;
				
				startPtr += 23;
			}
		}
		public static unsafe void ClearFactor25(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 4;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x100000000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 29){
				mask = 0;
				mask |= 0x20000;
				mask |= 0x40000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x10000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x8000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x2000000;
				mask |= 0x4000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x1000000000;
				mask |= 0x2000000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x400000;
				mask |= 0x800000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x200000000;
				mask |= 0x400000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x80000;
				mask |= 0x100000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x40000000;
				mask |= 0x80000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x20000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x8000000;
				mask |= 0x10000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x4000000000;
				mask |= 0x8000000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x1000000;
				mask |= 0x2000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x800000000;
				mask |= 0x1000000000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x200000;
				mask |= 0x400000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x100000000;
				mask |= 0x200000000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x80000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x20000000;
				mask |= 0x40000000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x10000000000;
				startPtr[18] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x4000000;
				mask |= 0x8000000000000;
				startPtr[19] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x2000000000;
				mask |= 0x4000000000000000;
				startPtr[20] |= mask;
				
				mask = 0;
				mask |= 0x800000;
				mask |= 0x1000000000000;
				startPtr[21] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x400000000;
				mask |= 0x800000000000000;
				startPtr[22] |= mask;
				
				mask = 0;
				mask |= 0x100000;
				mask |= 0x200000000000;
				startPtr[23] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x80000000;
				mask |= 0x100000000000000;
				startPtr[24] |= mask;
				
				startPtr += 25;
			}
		}
		public static unsafe void ClearFactor27(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 5;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x100000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 32){
				mask = 0;
				mask |= 0x80;
				mask |= 0x400000000;
				mask |= 0x2000000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x1000000;
				mask |= 0x8000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x20000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x80000000;
				mask |= 0x400000000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x200000;
				mask |= 0x1000000000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x4000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x2;
				mask |= 0x10000000;
				mask |= 0x80000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x200000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x800000000;
				mask |= 0x4000000000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x2000000;
				mask |= 0x10000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x40000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x100000000;
				mask |= 0x800000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x400000;
				mask |= 0x2000000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x8000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x20000000;
				mask |= 0x100000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x80000;
				mask |= 0x400000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x1000000000;
				mask |= 0x8000000000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x4000000;
				mask |= 0x20000000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x80000000000;
				startPtr[18] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x200000000;
				mask |= 0x1000000000000000;
				startPtr[19] |= mask;
				
				mask = 0;
				mask |= 0x800000;
				mask |= 0x4000000000000;
				startPtr[20] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x10000000000;
				startPtr[21] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x40000000;
				mask |= 0x200000000000000;
				startPtr[22] |= mask;
				
				mask = 0;
				mask |= 0x100000;
				mask |= 0x800000000000;
				startPtr[23] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x2000000000;
				startPtr[24] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x8000000;
				mask |= 0x40000000000000;
				startPtr[25] |= mask;
				
				mask = 0;
				mask |= 0x20000;
				mask |= 0x100000000000;
				startPtr[26] |= mask;
				
				startPtr += 27;
			}
		}
		public static unsafe void ClearFactor29(ulong* ptr, uint limit)
		{
			var startPtr = ptr + 6;
			var endPtr = ptr + limit / 64 + 1;
			ulong mask = 0;

			mask |= 0x1000000000;
			startPtr[0] |= mask;
			startPtr++;

			while (startPtr <= endPtr){  //- 35){
				mask = 0;
				mask |= 0x2;
				mask |= 0x40000000;
				mask |= 0x800000000000000;
				startPtr[0] |= mask;
				
				mask = 0;
				mask |= 0x1000000;
				mask |= 0x20000000000000;
				startPtr[1] |= mask;
				
				mask = 0;
				mask |= 0x40000;
				mask |= 0x800000000000;
				startPtr[2] |= mask;
				
				mask = 0;
				mask |= 0x1000;
				mask |= 0x20000000000;
				startPtr[3] |= mask;
				
				mask = 0;
				mask |= 0x40;
				mask |= 0x800000000;
				startPtr[4] |= mask;
				
				mask = 0;
				mask |= 0x1;
				mask |= 0x20000000;
				mask |= 0x400000000000000;
				startPtr[5] |= mask;
				
				mask = 0;
				mask |= 0x800000;
				mask |= 0x10000000000000;
				startPtr[6] |= mask;
				
				mask = 0;
				mask |= 0x20000;
				mask |= 0x400000000000;
				startPtr[7] |= mask;
				
				mask = 0;
				mask |= 0x800;
				mask |= 0x10000000000;
				startPtr[8] |= mask;
				
				mask = 0;
				mask |= 0x20;
				mask |= 0x400000000;
				mask |= 0x8000000000000000;
				startPtr[9] |= mask;
				
				mask = 0;
				mask |= 0x10000000;
				mask |= 0x200000000000000;
				startPtr[10] |= mask;
				
				mask = 0;
				mask |= 0x400000;
				mask |= 0x8000000000000;
				startPtr[11] |= mask;
				
				mask = 0;
				mask |= 0x10000;
				mask |= 0x200000000000;
				startPtr[12] |= mask;
				
				mask = 0;
				mask |= 0x400;
				mask |= 0x8000000000;
				startPtr[13] |= mask;
				
				mask = 0;
				mask |= 0x10;
				mask |= 0x200000000;
				mask |= 0x4000000000000000;
				startPtr[14] |= mask;
				
				mask = 0;
				mask |= 0x8000000;
				mask |= 0x100000000000000;
				startPtr[15] |= mask;
				
				mask = 0;
				mask |= 0x200000;
				mask |= 0x4000000000000;
				startPtr[16] |= mask;
				
				mask = 0;
				mask |= 0x8000;
				mask |= 0x100000000000;
				startPtr[17] |= mask;
				
				mask = 0;
				mask |= 0x200;
				mask |= 0x4000000000;
				startPtr[18] |= mask;
				
				mask = 0;
				mask |= 0x8;
				mask |= 0x100000000;
				mask |= 0x2000000000000000;
				startPtr[19] |= mask;
				
				mask = 0;
				mask |= 0x4000000;
				mask |= 0x80000000000000;
				startPtr[20] |= mask;
				
				mask = 0;
				mask |= 0x100000;
				mask |= 0x2000000000000;
				startPtr[21] |= mask;
				
				mask = 0;
				mask |= 0x4000;
				mask |= 0x80000000000;
				startPtr[22] |= mask;
				
				mask = 0;
				mask |= 0x100;
				mask |= 0x2000000000;
				startPtr[23] |= mask;
				
				mask = 0;
				mask |= 0x4;
				mask |= 0x80000000;
				mask |= 0x1000000000000000;
				startPtr[24] |= mask;
				
				mask = 0;
				mask |= 0x2000000;
				mask |= 0x40000000000000;
				startPtr[25] |= mask;
				
				mask = 0;
				mask |= 0x80000;
				mask |= 0x1000000000000;
				startPtr[26] |= mask;
				
				mask = 0;
				mask |= 0x2000;
				mask |= 0x40000000000;
				startPtr[27] |= mask;
				
				mask = 0;
				mask |= 0x80;
				mask |= 0x1000000000;
				startPtr[28] |= mask;
				
				startPtr += 29;
			}
		}
	}
}