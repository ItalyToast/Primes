
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrimeSieveCS
{
	class Dense
	{
	public static unsafe void ClearFactor(uint factor, byte* ptr, uint limit){
	switch(factor){	case 3: ClearFactor3(ptr, limit); break;
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
			var start = 4;
			var startPtr = ptr + start / 8;
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

			startPtr[0] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[0] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[1] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[1] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[2] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[2] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[2] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[3] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor5(byte* ptr, uint limit){
			var start = 12;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 5){
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

			startPtr[1] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[2] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[2] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[3] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[4] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[4] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[5] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[5] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor7(byte* ptr, uint limit){
			var start = 24;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 7){
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

			startPtr[3] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[3] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[4] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[5] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[6] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[7] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[8] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[9] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor9(byte* ptr, uint limit){
			var start = 40;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 9){
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

			startPtr[5] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[6] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[7] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[8] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[9] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[10] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[11] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[12] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor11(byte* ptr, uint limit){
			var start = 60;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 11){
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

			startPtr[7] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[8] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[10] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[11] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[13] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[14] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[15] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[17] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor13(byte* ptr, uint limit){
			var start = 84;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 13){
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

			startPtr[10] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[12] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[13] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[15] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[17] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[18] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[20] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[21] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor15(byte* ptr, uint limit){
			var start = 112;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 15){
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

			startPtr[14] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[15] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[17] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[19] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[21] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[23] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[25] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[27] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor17(byte* ptr, uint limit){
			var start = 144;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 17){
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

			startPtr[18] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[20] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[22] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[24] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[26] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[28] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[30] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[32] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		public static unsafe void ClearFactor19(byte* ptr, uint limit){
			var start = 180;
			var startPtr = ptr + start / 8;
			var endPtr = ptr + limit / 8 + 1;
			while (startPtr < endPtr - 19){
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

			startPtr[22] |= 16;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[24] |= 128;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[27] |= 4;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[29] |= 32;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[32] |= 1;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[34] |= 8;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[36] |= 64;
		startPtr += 1;
		if(startPtr >= endPtr)return;
			startPtr[39] |= 2;
		startPtr += 1;
		if(startPtr >= endPtr)return;
		}
		}
}