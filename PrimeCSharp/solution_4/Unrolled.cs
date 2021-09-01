
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrimeSieveCS
{ 
	class Unrolled
	{
		public static unsafe void ClearFactor(uint factor, byte* ptr, uint limit){
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
			}
		}

		public static unsafe void ClearFactor3(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 3){
				startPtr[0] |= 16;
				startPtr[0] |= 128;
				startPtr[1] |= 4;
				startPtr[1] |= 32;
				startPtr[2] |= 1;
				startPtr[2] |= 8;
				startPtr[2] |= 64;
				startPtr[3] |= 2;
				startPtr += 3;
			}

			if(startPtr + 0 > endPtr)return;
			startPtr[0] |= 16;
			if(startPtr + 0 > endPtr)return;
			startPtr[0] |= 128;
			if(startPtr + 1 > endPtr)return;
			startPtr[1] |= 4;
			if(startPtr + 1 > endPtr)return;
			startPtr[1] |= 32;
			if(startPtr + 2 > endPtr)return;
			startPtr[2] |= 1;
			if(startPtr + 2 > endPtr)return;
			startPtr[2] |= 8;
			if(startPtr + 2 > endPtr)return;
			startPtr[2] |= 64;
			if(startPtr + 3 > endPtr)return;
			startPtr[3] |= 2;
			}
			public static unsafe void ClearFactor5(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 6){
				startPtr[1] |= 16;
				startPtr[2] |= 2;
				startPtr[2] |= 64;
				startPtr[3] |= 8;
				startPtr[4] |= 1;
				startPtr[4] |= 32;
				startPtr[5] |= 4;
				startPtr[5] |= 128;
				startPtr += 5;
			}

			if(startPtr + 1 > endPtr)return;
			startPtr[1] |= 16;
			if(startPtr + 2 > endPtr)return;
			startPtr[2] |= 2;
			if(startPtr + 2 > endPtr)return;
			startPtr[2] |= 64;
			if(startPtr + 3 > endPtr)return;
			startPtr[3] |= 8;
			if(startPtr + 4 > endPtr)return;
			startPtr[4] |= 1;
			if(startPtr + 4 > endPtr)return;
			startPtr[4] |= 32;
			if(startPtr + 5 > endPtr)return;
			startPtr[5] |= 4;
			if(startPtr + 5 > endPtr)return;
			startPtr[5] |= 128;
			}
			public static unsafe void ClearFactor7(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 10){
				startPtr[3] |= 1;
				startPtr[3] |= 128;
				startPtr[4] |= 64;
				startPtr[5] |= 32;
				startPtr[6] |= 16;
				startPtr[7] |= 8;
				startPtr[8] |= 4;
				startPtr[9] |= 2;
				startPtr += 7;
			}

			if(startPtr + 3 > endPtr)return;
			startPtr[3] |= 1;
			if(startPtr + 3 > endPtr)return;
			startPtr[3] |= 128;
			if(startPtr + 4 > endPtr)return;
			startPtr[4] |= 64;
			if(startPtr + 5 > endPtr)return;
			startPtr[5] |= 32;
			if(startPtr + 6 > endPtr)return;
			startPtr[6] |= 16;
			if(startPtr + 7 > endPtr)return;
			startPtr[7] |= 8;
			if(startPtr + 8 > endPtr)return;
			startPtr[8] |= 4;
			if(startPtr + 9 > endPtr)return;
			startPtr[9] |= 2;
			}
			public static unsafe void ClearFactor9(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 14){
				startPtr[5] |= 1;
				startPtr[6] |= 2;
				startPtr[7] |= 4;
				startPtr[8] |= 8;
				startPtr[9] |= 16;
				startPtr[10] |= 32;
				startPtr[11] |= 64;
				startPtr[12] |= 128;
				startPtr += 9;
			}

			if(startPtr + 5 > endPtr)return;
			startPtr[5] |= 1;
			if(startPtr + 6 > endPtr)return;
			startPtr[6] |= 2;
			if(startPtr + 7 > endPtr)return;
			startPtr[7] |= 4;
			if(startPtr + 8 > endPtr)return;
			startPtr[8] |= 8;
			if(startPtr + 9 > endPtr)return;
			startPtr[9] |= 16;
			if(startPtr + 10 > endPtr)return;
			startPtr[10] |= 32;
			if(startPtr + 11 > endPtr)return;
			startPtr[11] |= 64;
			if(startPtr + 12 > endPtr)return;
			startPtr[12] |= 128;
			}
			public static unsafe void ClearFactor11(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 18){
				startPtr[7] |= 16;
				startPtr[8] |= 128;
				startPtr[10] |= 4;
				startPtr[11] |= 32;
				startPtr[13] |= 1;
				startPtr[14] |= 8;
				startPtr[15] |= 64;
				startPtr[17] |= 2;
				startPtr += 11;
			}

			if(startPtr + 7 > endPtr)return;
			startPtr[7] |= 16;
			if(startPtr + 8 > endPtr)return;
			startPtr[8] |= 128;
			if(startPtr + 10 > endPtr)return;
			startPtr[10] |= 4;
			if(startPtr + 11 > endPtr)return;
			startPtr[11] |= 32;
			if(startPtr + 13 > endPtr)return;
			startPtr[13] |= 1;
			if(startPtr + 14 > endPtr)return;
			startPtr[14] |= 8;
			if(startPtr + 15 > endPtr)return;
			startPtr[15] |= 64;
			if(startPtr + 17 > endPtr)return;
			startPtr[17] |= 2;
			}
			public static unsafe void ClearFactor13(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 23){
				startPtr[10] |= 16;
				startPtr[12] |= 2;
				startPtr[13] |= 64;
				startPtr[15] |= 8;
				startPtr[17] |= 1;
				startPtr[18] |= 32;
				startPtr[20] |= 4;
				startPtr[21] |= 128;
				startPtr += 13;
			}

			if(startPtr + 10 > endPtr)return;
			startPtr[10] |= 16;
			if(startPtr + 12 > endPtr)return;
			startPtr[12] |= 2;
			if(startPtr + 13 > endPtr)return;
			startPtr[13] |= 64;
			if(startPtr + 15 > endPtr)return;
			startPtr[15] |= 8;
			if(startPtr + 17 > endPtr)return;
			startPtr[17] |= 1;
			if(startPtr + 18 > endPtr)return;
			startPtr[18] |= 32;
			if(startPtr + 20 > endPtr)return;
			startPtr[20] |= 4;
			if(startPtr + 21 > endPtr)return;
			startPtr[21] |= 128;
			}
			public static unsafe void ClearFactor15(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 29){
				startPtr[14] |= 1;
				startPtr[15] |= 128;
				startPtr[17] |= 64;
				startPtr[19] |= 32;
				startPtr[21] |= 16;
				startPtr[23] |= 8;
				startPtr[25] |= 4;
				startPtr[27] |= 2;
				startPtr += 15;
			}

			if(startPtr + 14 > endPtr)return;
			startPtr[14] |= 1;
			if(startPtr + 15 > endPtr)return;
			startPtr[15] |= 128;
			if(startPtr + 17 > endPtr)return;
			startPtr[17] |= 64;
			if(startPtr + 19 > endPtr)return;
			startPtr[19] |= 32;
			if(startPtr + 21 > endPtr)return;
			startPtr[21] |= 16;
			if(startPtr + 23 > endPtr)return;
			startPtr[23] |= 8;
			if(startPtr + 25 > endPtr)return;
			startPtr[25] |= 4;
			if(startPtr + 27 > endPtr)return;
			startPtr[27] |= 2;
			}
			public static unsafe void ClearFactor17(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 35){
				startPtr[18] |= 1;
				startPtr[20] |= 2;
				startPtr[22] |= 4;
				startPtr[24] |= 8;
				startPtr[26] |= 16;
				startPtr[28] |= 32;
				startPtr[30] |= 64;
				startPtr[32] |= 128;
				startPtr += 17;
			}

			if(startPtr + 18 > endPtr)return;
			startPtr[18] |= 1;
			if(startPtr + 20 > endPtr)return;
			startPtr[20] |= 2;
			if(startPtr + 22 > endPtr)return;
			startPtr[22] |= 4;
			if(startPtr + 24 > endPtr)return;
			startPtr[24] |= 8;
			if(startPtr + 26 > endPtr)return;
			startPtr[26] |= 16;
			if(startPtr + 28 > endPtr)return;
			startPtr[28] |= 32;
			if(startPtr + 30 > endPtr)return;
			startPtr[30] |= 64;
			if(startPtr + 32 > endPtr)return;
			startPtr[32] |= 128;
			}
			public static unsafe void ClearFactor19(byte* ptr, uint limit){
			var startPtr = ptr;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 41){
				startPtr[22] |= 16;
				startPtr[24] |= 128;
				startPtr[27] |= 4;
				startPtr[29] |= 32;
				startPtr[32] |= 1;
				startPtr[34] |= 8;
				startPtr[36] |= 64;
				startPtr[39] |= 2;
				startPtr += 19;
			}

			if(startPtr + 22 > endPtr)return;
			startPtr[22] |= 16;
			if(startPtr + 24 > endPtr)return;
			startPtr[24] |= 128;
			if(startPtr + 27 > endPtr)return;
			startPtr[27] |= 4;
			if(startPtr + 29 > endPtr)return;
			startPtr[29] |= 32;
			if(startPtr + 32 > endPtr)return;
			startPtr[32] |= 1;
			if(startPtr + 34 > endPtr)return;
			startPtr[34] |= 8;
			if(startPtr + 36 > endPtr)return;
			startPtr[36] |= 64;
			if(startPtr + 39 > endPtr)return;
			startPtr[39] |= 2;
			}
		}
}