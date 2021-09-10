﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrimeSieveCS
{ 
	class UnrolledSparse
	{
		public static unsafe void ClearFactor(uint factor, ulong* ptr, uint limit){
			switch(factor){
				case 21: ClearFactor21((byte*)ptr, limit); break;
				case 22: ClearFactor22((byte*)ptr, limit); break;
				case 23: ClearFactor23((byte*)ptr, limit); break;
				case 24: ClearFactor24((byte*)ptr, limit); break;
				case 25: ClearFactor25((byte*)ptr, limit); break;
				case 26: ClearFactor26((byte*)ptr, limit); break;
				case 27: ClearFactor27((byte*)ptr, limit); break;
				case 28: ClearFactor28((byte*)ptr, limit); break;
				case 29: ClearFactor29((byte*)ptr, limit); break;
				case 30: ClearFactor30((byte*)ptr, limit); break;
				case 31: ClearFactor31((byte*)ptr, limit); break;
				case 32: ClearFactor32((byte*)ptr, limit); break;
				case 33: ClearFactor33((byte*)ptr, limit); break;
				case 34: ClearFactor34((byte*)ptr, limit); break;
				case 35: ClearFactor35((byte*)ptr, limit); break;
				case 36: ClearFactor36((byte*)ptr, limit); break;
				case 37: ClearFactor37((byte*)ptr, limit); break;
				case 38: ClearFactor38((byte*)ptr, limit); break;
				case 39: ClearFactor39((byte*)ptr, limit); break;
				case 40: ClearFactor40((byte*)ptr, limit); break;
				case 41: ClearFactor41((byte*)ptr, limit); break;
				case 42: ClearFactor42((byte*)ptr, limit); break;
				case 43: ClearFactor43((byte*)ptr, limit); break;
				case 44: ClearFactor44((byte*)ptr, limit); break;
				case 45: ClearFactor45((byte*)ptr, limit); break;
				case 46: ClearFactor46((byte*)ptr, limit); break;
				case 47: ClearFactor47((byte*)ptr, limit); break;
				case 48: ClearFactor48((byte*)ptr, limit); break;
				case 49: ClearFactor49((byte*)ptr, limit); break;
				case 50: ClearFactor50((byte*)ptr, limit); break;
				case 51: ClearFactor51((byte*)ptr, limit); break;
				case 52: ClearFactor52((byte*)ptr, limit); break;
				case 53: ClearFactor53((byte*)ptr, limit); break;
				case 54: ClearFactor54((byte*)ptr, limit); break;
				case 55: ClearFactor55((byte*)ptr, limit); break;
				case 56: ClearFactor56((byte*)ptr, limit); break;
				case 57: ClearFactor57((byte*)ptr, limit); break;
				case 58: ClearFactor58((byte*)ptr, limit); break;
				case 59: ClearFactor59((byte*)ptr, limit); break;
				case 60: ClearFactor60((byte*)ptr, limit); break;
				case 61: ClearFactor61((byte*)ptr, limit); break;
				case 62: ClearFactor62((byte*)ptr, limit); break;
				case 63: ClearFactor63((byte*)ptr, limit); break;
				case 64: ClearFactor64((byte*)ptr, limit); break;
				case 65: ClearFactor65((byte*)ptr, limit); break;
				case 66: ClearFactor66((byte*)ptr, limit); break;
				case 67: ClearFactor67((byte*)ptr, limit); break;
				case 68: ClearFactor68((byte*)ptr, limit); break;
				case 69: ClearFactor69((byte*)ptr, limit); break;
				case 70: ClearFactor70((byte*)ptr, limit); break;
				case 71: ClearFactor71((byte*)ptr, limit); break;
				case 72: ClearFactor72((byte*)ptr, limit); break;
				case 73: ClearFactor73((byte*)ptr, limit); break;
				case 74: ClearFactor74((byte*)ptr, limit); break;
				case 75: ClearFactor75((byte*)ptr, limit); break;
				case 76: ClearFactor76((byte*)ptr, limit); break;
				case 77: ClearFactor77((byte*)ptr, limit); break;
				case 78: ClearFactor78((byte*)ptr, limit); break;
				case 79: ClearFactor79((byte*)ptr, limit); break;
				case 80: ClearFactor80((byte*)ptr, limit); break;
				case 81: ClearFactor81((byte*)ptr, limit); break;
				case 82: ClearFactor82((byte*)ptr, limit); break;
				case 83: ClearFactor83((byte*)ptr, limit); break;
				case 84: ClearFactor84((byte*)ptr, limit); break;
				case 85: ClearFactor85((byte*)ptr, limit); break;
				case 86: ClearFactor86((byte*)ptr, limit); break;
				case 87: ClearFactor87((byte*)ptr, limit); break;
				case 88: ClearFactor88((byte*)ptr, limit); break;
				case 89: ClearFactor89((byte*)ptr, limit); break;
				case 90: ClearFactor90((byte*)ptr, limit); break;
				case 91: ClearFactor91((byte*)ptr, limit); break;
				case 92: ClearFactor92((byte*)ptr, limit); break;
				case 93: ClearFactor93((byte*)ptr, limit); break;
				case 94: ClearFactor94((byte*)ptr, limit); break;
				case 95: ClearFactor95((byte*)ptr, limit); break;
				case 96: ClearFactor96((byte*)ptr, limit); break;
				case 97: ClearFactor97((byte*)ptr, limit); break;
				case 98: ClearFactor98((byte*)ptr, limit); break;
				case 99: ClearFactor99((byte*)ptr, limit); break;
				case 100: ClearFactor100((byte*)ptr, limit); break;
			}
		}

		public static unsafe void ClearFactor21(byte* ptr, uint limit)
		{
			var startPtr = ptr + 27;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 5;
			var p3 = startPtr + 8;
			var p4 = startPtr + 11;
			var p5 = startPtr + 13;
			var p6 = startPtr + 16;
			var p7 = startPtr + 18;

			while (p0 < endPtr - 21){  //- 24){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 21;
				p1 += 21;
				p2 += 21;
				p3 += 21;
				p4 += 21;
				p5 += 21;
				p6 += 21;
				p7 += 21;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 2;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 64;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 8;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 1;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 32;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 4;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 128;
		}
		public static unsafe void ClearFactor22(byte* ptr, uint limit)
		{
			var startPtr = ptr + 30;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 5;
			var p3 = startPtr + 8;
			var p4 = startPtr + 11;
			var p5 = startPtr + 14;
			var p6 = startPtr + 16;
			var p7 = startPtr + 19;

			while (p0 < endPtr - 22){  //- 25){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 22;
				p1 += 22;
				p2 += 22;
				p3 += 22;
				p4 += 22;
				p5 += 22;
				p6 += 22;
				p7 += 22;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 1;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 64;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 16;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 4;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 1;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 64;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 16;
		}
		public static unsafe void ClearFactor23(byte* ptr, uint limit)
		{
			var startPtr = ptr + 33;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 2;
			var p2 = startPtr + 5;
			var p3 = startPtr + 8;
			var p4 = startPtr + 11;
			var p5 = startPtr + 14;
			var p6 = startPtr + 17;
			var p7 = startPtr + 20;

			while (p0 < endPtr - 23){  //- 27){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 23;
				p1 += 23;
				p2 += 23;
				p3 += 23;
				p4 += 23;
				p5 += 23;
				p6 += 23;
				p7 += 23;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 2 > endPtr) return;
			p0[2] |= 128;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 64;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 32;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 16;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 8;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 4;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 2;
		}
		public static unsafe void ClearFactor24(byte* ptr, uint limit)
		{
			var startPtr = ptr + 36;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 6;
			var p3 = startPtr + 9;
			var p4 = startPtr + 12;
			var p5 = startPtr + 15;
			var p6 = startPtr + 18;
			var p7 = startPtr + 21;

			while (p0 < endPtr - 24){  //- 28){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 24;
				p1 += 24;
				p2 += 24;
				p3 += 24;
				p4 += 24;
				p5 += 24;
				p6 += 24;
				p7 += 24;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 1;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 1;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 1;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 1;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 1;
		}
		public static unsafe void ClearFactor25(byte* ptr, uint limit)
		{
			var startPtr = ptr + 39;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 6;
			var p3 = startPtr + 9;
			var p4 = startPtr + 12;
			var p5 = startPtr + 15;
			var p6 = startPtr + 18;
			var p7 = startPtr + 21;

			while (p0 < endPtr - 25){  //- 29){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 25;
				p1 += 25;
				p2 += 25;
				p3 += 25;
				p4 += 25;
				p5 += 25;
				p6 += 25;
				p7 += 25;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 2;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 4;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 8;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 16;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 32;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 64;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 128;
		}
		public static unsafe void ClearFactor26(byte* ptr, uint limit)
		{
			var startPtr = ptr + 42;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 6;
			var p3 = startPtr + 10;
			var p4 = startPtr + 13;
			var p5 = startPtr + 16;
			var p6 = startPtr + 19;
			var p7 = startPtr + 23;

			while (p0 < endPtr - 26){  //- 31){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 26;
				p1 += 26;
				p2 += 26;
				p3 += 26;
				p4 += 26;
				p5 += 26;
				p6 += 26;
				p7 += 26;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 16;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 64;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 1;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 4;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 16;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 64;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 1;
		}
		public static unsafe void ClearFactor27(byte* ptr, uint limit)
		{
			var startPtr = ptr + 45;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 7;
			var p3 = startPtr + 10;
			var p4 = startPtr + 14;
			var p5 = startPtr + 17;
			var p6 = startPtr + 20;
			var p7 = startPtr + 24;

			while (p0 < endPtr - 27){  //- 32){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 27;
				p1 += 27;
				p2 += 27;
				p3 += 27;
				p4 += 27;
				p5 += 27;
				p6 += 27;
				p7 += 27;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 128;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 4;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 32;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 1;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 8;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 64;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 2;
		}
		public static unsafe void ClearFactor28(byte* ptr, uint limit)
		{
			var startPtr = ptr + 49;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 7;
			var p3 = startPtr + 10;
			var p4 = startPtr + 14;
			var p5 = startPtr + 17;
			var p6 = startPtr + 21;
			var p7 = startPtr + 24;

			while (p0 < endPtr - 28){  //- 34){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 28;
				p1 += 28;
				p2 += 28;
				p3 += 28;
				p4 += 28;
				p5 += 28;
				p6 += 28;
				p7 += 28;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 16;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 16;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 1;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 16;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 1;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 16;
		}
		public static unsafe void ClearFactor29(byte* ptr, uint limit)
		{
			var startPtr = ptr + 52;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 7;
			var p3 = startPtr + 11;
			var p4 = startPtr + 15;
			var p5 = startPtr + 18;
			var p6 = startPtr + 22;
			var p7 = startPtr + 25;

			while (p0 < endPtr - 29){  //- 35){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 29;
				p1 += 29;
				p2 += 29;
				p3 += 29;
				p4 += 29;
				p5 += 29;
				p6 += 29;
				p7 += 29;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 2;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 64;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 8;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 1;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 32;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 4;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 128;
		}
		public static unsafe void ClearFactor30(byte* ptr, uint limit)
		{
			var startPtr = ptr + 56;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 7;
			var p3 = startPtr + 11;
			var p4 = startPtr + 15;
			var p5 = startPtr + 19;
			var p6 = startPtr + 22;
			var p7 = startPtr + 26;

			while (p0 < endPtr - 30){  //- 37){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 30;
				p1 += 30;
				p2 += 30;
				p3 += 30;
				p4 += 30;
				p5 += 30;
				p6 += 30;
				p7 += 30;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 1;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 64;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 16;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 4;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 1;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 64;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 16;
		}
		public static unsafe void ClearFactor31(byte* ptr, uint limit)
		{
			var startPtr = ptr + 60;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 3;
			var p2 = startPtr + 7;
			var p3 = startPtr + 11;
			var p4 = startPtr + 15;
			var p5 = startPtr + 19;
			var p6 = startPtr + 23;
			var p7 = startPtr + 27;

			while (p0 < endPtr - 31){  //- 38){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 31;
				p1 += 31;
				p2 += 31;
				p3 += 31;
				p4 += 31;
				p5 += 31;
				p6 += 31;
				p7 += 31;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 3 > endPtr) return;
			p0[3] |= 128;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 64;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 32;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 16;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 8;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 4;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 2;
		}
		public static unsafe void ClearFactor32(byte* ptr, uint limit)
		{
			var startPtr = ptr + 64;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 8;
			var p3 = startPtr + 12;
			var p4 = startPtr + 16;
			var p5 = startPtr + 20;
			var p6 = startPtr + 24;
			var p7 = startPtr + 28;

			while (p0 < endPtr - 32){  //- 40){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 32;
				p1 += 32;
				p2 += 32;
				p3 += 32;
				p4 += 32;
				p5 += 32;
				p6 += 32;
				p7 += 32;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 1;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 1;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 1;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 1;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 1;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 1;
		}
		public static unsafe void ClearFactor33(byte* ptr, uint limit)
		{
			var startPtr = ptr + 68;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 8;
			var p3 = startPtr + 12;
			var p4 = startPtr + 16;
			var p5 = startPtr + 20;
			var p6 = startPtr + 24;
			var p7 = startPtr + 28;

			while (p0 < endPtr - 33){  //- 41){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 33;
				p1 += 33;
				p2 += 33;
				p3 += 33;
				p4 += 33;
				p5 += 33;
				p6 += 33;
				p7 += 33;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 2;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 4;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 8;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 16;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 32;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 64;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 128;
		}
		public static unsafe void ClearFactor34(byte* ptr, uint limit)
		{
			var startPtr = ptr + 72;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 8;
			var p3 = startPtr + 13;
			var p4 = startPtr + 17;
			var p5 = startPtr + 21;
			var p6 = startPtr + 25;
			var p7 = startPtr + 30;

			while (p0 < endPtr - 34){  //- 43){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 34;
				p1 += 34;
				p2 += 34;
				p3 += 34;
				p4 += 34;
				p5 += 34;
				p6 += 34;
				p7 += 34;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 16;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 64;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 1;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 4;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 16;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 64;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
		}
		public static unsafe void ClearFactor35(byte* ptr, uint limit)
		{
			var startPtr = ptr + 76;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 9;
			var p3 = startPtr + 13;
			var p4 = startPtr + 18;
			var p5 = startPtr + 22;
			var p6 = startPtr + 26;
			var p7 = startPtr + 31;

			while (p0 < endPtr - 35){  //- 44){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 35;
				p1 += 35;
				p2 += 35;
				p3 += 35;
				p4 += 35;
				p5 += 35;
				p6 += 35;
				p7 += 35;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 128;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 4;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 32;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 1;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 8;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 64;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 2;
		}
		public static unsafe void ClearFactor36(byte* ptr, uint limit)
		{
			var startPtr = ptr + 81;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 9;
			var p3 = startPtr + 13;
			var p4 = startPtr + 18;
			var p5 = startPtr + 22;
			var p6 = startPtr + 27;
			var p7 = startPtr + 31;

			while (p0 < endPtr - 36){  //- 46){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 36;
				p1 += 36;
				p2 += 36;
				p3 += 36;
				p4 += 36;
				p5 += 36;
				p6 += 36;
				p7 += 36;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 16;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 1;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 16;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 1;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 16;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 1;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 16;
		}
		public static unsafe void ClearFactor37(byte* ptr, uint limit)
		{
			var startPtr = ptr + 85;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 9;
			var p3 = startPtr + 14;
			var p4 = startPtr + 19;
			var p5 = startPtr + 23;
			var p6 = startPtr + 28;
			var p7 = startPtr + 32;

			while (p0 < endPtr - 37){  //- 47){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 37;
				p1 += 37;
				p2 += 37;
				p3 += 37;
				p4 += 37;
				p5 += 37;
				p6 += 37;
				p7 += 37;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 2;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 64;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 8;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 1;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 32;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 4;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 128;
		}
		public static unsafe void ClearFactor38(byte* ptr, uint limit)
		{
			var startPtr = ptr + 90;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 9;
			var p3 = startPtr + 14;
			var p4 = startPtr + 19;
			var p5 = startPtr + 24;
			var p6 = startPtr + 28;
			var p7 = startPtr + 33;

			while (p0 < endPtr - 38){  //- 49){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 38;
				p1 += 38;
				p2 += 38;
				p3 += 38;
				p4 += 38;
				p5 += 38;
				p6 += 38;
				p7 += 38;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 64;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 16;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 4;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 1;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 64;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 16;
		}
		public static unsafe void ClearFactor39(byte* ptr, uint limit)
		{
			var startPtr = ptr + 95;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 4;
			var p2 = startPtr + 9;
			var p3 = startPtr + 14;
			var p4 = startPtr + 19;
			var p5 = startPtr + 24;
			var p6 = startPtr + 29;
			var p7 = startPtr + 34;

			while (p0 < endPtr - 39){  //- 50){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 39;
				p1 += 39;
				p2 += 39;
				p3 += 39;
				p4 += 39;
				p5 += 39;
				p6 += 39;
				p7 += 39;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 4 > endPtr) return;
			p0[4] |= 128;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 64;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 32;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 16;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 8;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 4;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 2;
		}
		public static unsafe void ClearFactor40(byte* ptr, uint limit)
		{
			var startPtr = ptr + 100;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 10;
			var p3 = startPtr + 15;
			var p4 = startPtr + 20;
			var p5 = startPtr + 25;
			var p6 = startPtr + 30;
			var p7 = startPtr + 35;

			while (p0 < endPtr - 40){  //- 52){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 40;
				p1 += 40;
				p2 += 40;
				p3 += 40;
				p4 += 40;
				p5 += 40;
				p6 += 40;
				p7 += 40;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 1;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 1;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 1;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 1;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 1;
		}
		public static unsafe void ClearFactor41(byte* ptr, uint limit)
		{
			var startPtr = ptr + 105;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 10;
			var p3 = startPtr + 15;
			var p4 = startPtr + 20;
			var p5 = startPtr + 25;
			var p6 = startPtr + 30;
			var p7 = startPtr + 35;

			while (p0 < endPtr - 41){  //- 54){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 41;
				p1 += 41;
				p2 += 41;
				p3 += 41;
				p4 += 41;
				p5 += 41;
				p6 += 41;
				p7 += 41;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 2;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 4;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 8;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 16;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 32;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 64;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 128;
		}
		public static unsafe void ClearFactor42(byte* ptr, uint limit)
		{
			var startPtr = ptr + 110;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 10;
			var p3 = startPtr + 16;
			var p4 = startPtr + 21;
			var p5 = startPtr + 26;
			var p6 = startPtr + 31;
			var p7 = startPtr + 37;

			while (p0 < endPtr - 42){  //- 55){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 42;
				p1 += 42;
				p2 += 42;
				p3 += 42;
				p4 += 42;
				p5 += 42;
				p6 += 42;
				p7 += 42;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 16;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 64;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 1;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 4;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 16;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 64;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 1;
		}
		public static unsafe void ClearFactor43(byte* ptr, uint limit)
		{
			var startPtr = ptr + 115;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 11;
			var p3 = startPtr + 16;
			var p4 = startPtr + 22;
			var p5 = startPtr + 27;
			var p6 = startPtr + 32;
			var p7 = startPtr + 38;

			while (p0 < endPtr - 43){  //- 57){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 43;
				p1 += 43;
				p2 += 43;
				p3 += 43;
				p4 += 43;
				p5 += 43;
				p6 += 43;
				p7 += 43;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 128;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 4;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 32;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 1;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 8;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 64;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 2;
		}
		public static unsafe void ClearFactor44(byte* ptr, uint limit)
		{
			var startPtr = ptr + 121;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 11;
			var p3 = startPtr + 16;
			var p4 = startPtr + 22;
			var p5 = startPtr + 27;
			var p6 = startPtr + 33;
			var p7 = startPtr + 38;

			while (p0 < endPtr - 44){  //- 59){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 44;
				p1 += 44;
				p2 += 44;
				p3 += 44;
				p4 += 44;
				p5 += 44;
				p6 += 44;
				p7 += 44;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 16;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 1;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 16;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 1;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 16;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 1;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 16;
		}
		public static unsafe void ClearFactor45(byte* ptr, uint limit)
		{
			var startPtr = ptr + 126;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 11;
			var p3 = startPtr + 17;
			var p4 = startPtr + 23;
			var p5 = startPtr + 28;
			var p6 = startPtr + 34;
			var p7 = startPtr + 39;

			while (p0 < endPtr - 45){  //- 60){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 45;
				p1 += 45;
				p2 += 45;
				p3 += 45;
				p4 += 45;
				p5 += 45;
				p6 += 45;
				p7 += 45;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 2;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 64;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 8;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 1;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 32;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 4;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 128;
		}
		public static unsafe void ClearFactor46(byte* ptr, uint limit)
		{
			var startPtr = ptr + 132;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 11;
			var p3 = startPtr + 17;
			var p4 = startPtr + 23;
			var p5 = startPtr + 29;
			var p6 = startPtr + 34;
			var p7 = startPtr + 40;

			while (p0 < endPtr - 46){  //- 62){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 46;
				p1 += 46;
				p2 += 46;
				p3 += 46;
				p4 += 46;
				p5 += 46;
				p6 += 46;
				p7 += 46;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 1;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 64;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 16;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 4;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 1;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 64;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 16;
		}
		public static unsafe void ClearFactor47(byte* ptr, uint limit)
		{
			var startPtr = ptr + 138;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 5;
			var p2 = startPtr + 11;
			var p3 = startPtr + 17;
			var p4 = startPtr + 23;
			var p5 = startPtr + 29;
			var p6 = startPtr + 35;
			var p7 = startPtr + 41;

			while (p0 < endPtr - 47){  //- 64){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 47;
				p1 += 47;
				p2 += 47;
				p3 += 47;
				p4 += 47;
				p5 += 47;
				p6 += 47;
				p7 += 47;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 5 > endPtr) return;
			p0[5] |= 128;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 64;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 32;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 16;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 8;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 4;
			if(p0 + 41 > endPtr) return;
			p0[41] |= 2;
		}
		public static unsafe void ClearFactor48(byte* ptr, uint limit)
		{
			var startPtr = ptr + 144;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 12;
			var p3 = startPtr + 18;
			var p4 = startPtr + 24;
			var p5 = startPtr + 30;
			var p6 = startPtr + 36;
			var p7 = startPtr + 42;

			while (p0 < endPtr - 48){  //- 66){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 48;
				p1 += 48;
				p2 += 48;
				p3 += 48;
				p4 += 48;
				p5 += 48;
				p6 += 48;
				p7 += 48;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 1;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 1;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 1;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 1;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 1;
		}
		public static unsafe void ClearFactor49(byte* ptr, uint limit)
		{
			var startPtr = ptr + 150;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 12;
			var p3 = startPtr + 18;
			var p4 = startPtr + 24;
			var p5 = startPtr + 30;
			var p6 = startPtr + 36;
			var p7 = startPtr + 42;

			while (p0 < endPtr - 49){  //- 67){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 49;
				p1 += 49;
				p2 += 49;
				p3 += 49;
				p4 += 49;
				p5 += 49;
				p6 += 49;
				p7 += 49;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 2;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 4;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 8;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 16;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 32;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 64;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 128;
		}
		public static unsafe void ClearFactor50(byte* ptr, uint limit)
		{
			var startPtr = ptr + 156;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 12;
			var p3 = startPtr + 19;
			var p4 = startPtr + 25;
			var p5 = startPtr + 31;
			var p6 = startPtr + 37;
			var p7 = startPtr + 44;

			while (p0 < endPtr - 50){  //- 69){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 50;
				p1 += 50;
				p2 += 50;
				p3 += 50;
				p4 += 50;
				p5 += 50;
				p6 += 50;
				p7 += 50;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 16;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 64;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 1;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 4;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 16;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 64;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 1;
		}
		public static unsafe void ClearFactor51(byte* ptr, uint limit)
		{
			var startPtr = ptr + 162;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 13;
			var p3 = startPtr + 19;
			var p4 = startPtr + 26;
			var p5 = startPtr + 32;
			var p6 = startPtr + 38;
			var p7 = startPtr + 45;

			while (p0 < endPtr - 51){  //- 71){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 51;
				p1 += 51;
				p2 += 51;
				p3 += 51;
				p4 += 51;
				p5 += 51;
				p6 += 51;
				p7 += 51;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 128;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 4;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 32;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 1;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 8;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 64;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 2;
		}
		public static unsafe void ClearFactor52(byte* ptr, uint limit)
		{
			var startPtr = ptr + 169;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 13;
			var p3 = startPtr + 19;
			var p4 = startPtr + 26;
			var p5 = startPtr + 32;
			var p6 = startPtr + 39;
			var p7 = startPtr + 45;

			while (p0 < endPtr - 52){  //- 73){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 52;
				p1 += 52;
				p2 += 52;
				p3 += 52;
				p4 += 52;
				p5 += 52;
				p6 += 52;
				p7 += 52;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 16;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 1;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 16;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 1;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 16;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 1;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 16;
		}
		public static unsafe void ClearFactor53(byte* ptr, uint limit)
		{
			var startPtr = ptr + 175;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 13;
			var p3 = startPtr + 20;
			var p4 = startPtr + 27;
			var p5 = startPtr + 33;
			var p6 = startPtr + 40;
			var p7 = startPtr + 46;

			while (p0 < endPtr - 53){  //- 74){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 53;
				p1 += 53;
				p2 += 53;
				p3 += 53;
				p4 += 53;
				p5 += 53;
				p6 += 53;
				p7 += 53;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 2;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 64;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 8;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 1;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 32;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 4;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 128;
		}
		public static unsafe void ClearFactor54(byte* ptr, uint limit)
		{
			var startPtr = ptr + 182;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 13;
			var p3 = startPtr + 20;
			var p4 = startPtr + 27;
			var p5 = startPtr + 34;
			var p6 = startPtr + 40;
			var p7 = startPtr + 47;

			while (p0 < endPtr - 54){  //- 76){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 54;
				p1 += 54;
				p2 += 54;
				p3 += 54;
				p4 += 54;
				p5 += 54;
				p6 += 54;
				p7 += 54;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 1;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 64;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 16;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 4;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 1;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 64;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 16;
		}
		public static unsafe void ClearFactor55(byte* ptr, uint limit)
		{
			var startPtr = ptr + 189;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 6;
			var p2 = startPtr + 13;
			var p3 = startPtr + 20;
			var p4 = startPtr + 27;
			var p5 = startPtr + 34;
			var p6 = startPtr + 41;
			var p7 = startPtr + 48;

			while (p0 < endPtr - 55){  //- 78){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 55;
				p1 += 55;
				p2 += 55;
				p3 += 55;
				p4 += 55;
				p5 += 55;
				p6 += 55;
				p7 += 55;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 6 > endPtr) return;
			p0[6] |= 128;
			if(p0 + 13 > endPtr) return;
			p0[13] |= 64;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 32;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 16;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 8;
			if(p0 + 41 > endPtr) return;
			p0[41] |= 4;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 2;
		}
		public static unsafe void ClearFactor56(byte* ptr, uint limit)
		{
			var startPtr = ptr + 196;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 14;
			var p3 = startPtr + 21;
			var p4 = startPtr + 28;
			var p5 = startPtr + 35;
			var p6 = startPtr + 42;
			var p7 = startPtr + 49;

			while (p0 < endPtr - 56){  //- 80){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 56;
				p1 += 56;
				p2 += 56;
				p3 += 56;
				p4 += 56;
				p5 += 56;
				p6 += 56;
				p7 += 56;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 1;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 1;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 1;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 1;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 1;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 1;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 1;
		}
		public static unsafe void ClearFactor57(byte* ptr, uint limit)
		{
			var startPtr = ptr + 203;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 14;
			var p3 = startPtr + 21;
			var p4 = startPtr + 28;
			var p5 = startPtr + 35;
			var p6 = startPtr + 42;
			var p7 = startPtr + 49;

			while (p0 < endPtr - 57){  //- 82){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 57;
				p1 += 57;
				p2 += 57;
				p3 += 57;
				p4 += 57;
				p5 += 57;
				p6 += 57;
				p7 += 57;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 2;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 4;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 8;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 16;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 32;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 64;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 128;
		}
		public static unsafe void ClearFactor58(byte* ptr, uint limit)
		{
			var startPtr = ptr + 210;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 14;
			var p3 = startPtr + 22;
			var p4 = startPtr + 29;
			var p5 = startPtr + 36;
			var p6 = startPtr + 43;
			var p7 = startPtr + 51;

			while (p0 < endPtr - 58){  //- 84){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 58;
				p1 += 58;
				p2 += 58;
				p3 += 58;
				p4 += 58;
				p5 += 58;
				p6 += 58;
				p7 += 58;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 16;
			if(p0 + 14 > endPtr) return;
			p0[14] |= 64;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 1;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 4;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 16;
			if(p0 + 43 > endPtr) return;
			p0[43] |= 64;
			if(p0 + 51 > endPtr) return;
			p0[51] |= 1;
		}
		public static unsafe void ClearFactor59(byte* ptr, uint limit)
		{
			var startPtr = ptr + 217;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 15;
			var p3 = startPtr + 22;
			var p4 = startPtr + 30;
			var p5 = startPtr + 37;
			var p6 = startPtr + 44;
			var p7 = startPtr + 52;

			while (p0 < endPtr - 59){  //- 86){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 59;
				p1 += 59;
				p2 += 59;
				p3 += 59;
				p4 += 59;
				p5 += 59;
				p6 += 59;
				p7 += 59;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 128;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 4;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 32;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 8;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 64;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 2;
		}
		public static unsafe void ClearFactor60(byte* ptr, uint limit)
		{
			var startPtr = ptr + 225;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 15;
			var p3 = startPtr + 22;
			var p4 = startPtr + 30;
			var p5 = startPtr + 37;
			var p6 = startPtr + 45;
			var p7 = startPtr + 52;

			while (p0 < endPtr - 60){  //- 88){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 60;
				p1 += 60;
				p2 += 60;
				p3 += 60;
				p4 += 60;
				p5 += 60;
				p6 += 60;
				p7 += 60;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 16;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 1;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 16;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 16;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 1;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 16;
		}
		public static unsafe void ClearFactor61(byte* ptr, uint limit)
		{
			var startPtr = ptr + 232;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 15;
			var p3 = startPtr + 23;
			var p4 = startPtr + 31;
			var p5 = startPtr + 38;
			var p6 = startPtr + 46;
			var p7 = startPtr + 53;

			while (p0 < endPtr - 61){  //- 90){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 61;
				p1 += 61;
				p2 += 61;
				p3 += 61;
				p4 += 61;
				p5 += 61;
				p6 += 61;
				p7 += 61;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 2;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 64;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 8;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 1;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 32;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 4;
			if(p0 + 53 > endPtr) return;
			p0[53] |= 128;
		}
		public static unsafe void ClearFactor62(byte* ptr, uint limit)
		{
			var startPtr = ptr + 240;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 15;
			var p3 = startPtr + 23;
			var p4 = startPtr + 31;
			var p5 = startPtr + 39;
			var p6 = startPtr + 46;
			var p7 = startPtr + 54;

			while (p0 < endPtr - 62){  //- 92){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 62;
				p1 += 62;
				p2 += 62;
				p3 += 62;
				p4 += 62;
				p5 += 62;
				p6 += 62;
				p7 += 62;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 1;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 64;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 16;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 4;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 1;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 64;
			if(p0 + 54 > endPtr) return;
			p0[54] |= 16;
		}
		public static unsafe void ClearFactor63(byte* ptr, uint limit)
		{
			var startPtr = ptr + 248;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 7;
			var p2 = startPtr + 15;
			var p3 = startPtr + 23;
			var p4 = startPtr + 31;
			var p5 = startPtr + 39;
			var p6 = startPtr + 47;
			var p7 = startPtr + 55;

			while (p0 < endPtr - 63){  //- 94){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 63;
				p1 += 63;
				p2 += 63;
				p3 += 63;
				p4 += 63;
				p5 += 63;
				p6 += 63;
				p7 += 63;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 7 > endPtr) return;
			p0[7] |= 128;
			if(p0 + 15 > endPtr) return;
			p0[15] |= 64;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 32;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 16;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 8;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 4;
			if(p0 + 55 > endPtr) return;
			p0[55] |= 2;
		}
		public static unsafe void ClearFactor64(byte* ptr, uint limit)
		{
			var startPtr = ptr + 256;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 16;
			var p3 = startPtr + 24;
			var p4 = startPtr + 32;
			var p5 = startPtr + 40;
			var p6 = startPtr + 48;
			var p7 = startPtr + 56;

			while (p0 < endPtr - 64){  //- 96){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 64;
				p1 += 64;
				p2 += 64;
				p3 += 64;
				p4 += 64;
				p5 += 64;
				p6 += 64;
				p7 += 64;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 1;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 1;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 1;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 1;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 1;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 1;
			if(p0 + 56 > endPtr) return;
			p0[56] |= 1;
		}
		public static unsafe void ClearFactor65(byte* ptr, uint limit)
		{
			var startPtr = ptr + 264;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 16;
			var p3 = startPtr + 24;
			var p4 = startPtr + 32;
			var p5 = startPtr + 40;
			var p6 = startPtr + 48;
			var p7 = startPtr + 56;

			while (p0 < endPtr - 65){  //- 98){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 65;
				p1 += 65;
				p2 += 65;
				p3 += 65;
				p4 += 65;
				p5 += 65;
				p6 += 65;
				p7 += 65;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 2;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 4;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 8;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 16;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 32;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 64;
			if(p0 + 56 > endPtr) return;
			p0[56] |= 128;
		}
		public static unsafe void ClearFactor66(byte* ptr, uint limit)
		{
			var startPtr = ptr + 272;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 16;
			var p3 = startPtr + 25;
			var p4 = startPtr + 33;
			var p5 = startPtr + 41;
			var p6 = startPtr + 49;
			var p7 = startPtr + 58;

			while (p0 < endPtr - 66){  //- 100){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 66;
				p1 += 66;
				p2 += 66;
				p3 += 66;
				p4 += 66;
				p5 += 66;
				p6 += 66;
				p7 += 66;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 16;
			if(p0 + 16 > endPtr) return;
			p0[16] |= 64;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 1;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 4;
			if(p0 + 41 > endPtr) return;
			p0[41] |= 16;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 64;
			if(p0 + 58 > endPtr) return;
			p0[58] |= 1;
		}
		public static unsafe void ClearFactor67(byte* ptr, uint limit)
		{
			var startPtr = ptr + 280;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 17;
			var p3 = startPtr + 25;
			var p4 = startPtr + 34;
			var p5 = startPtr + 42;
			var p6 = startPtr + 50;
			var p7 = startPtr + 59;

			while (p0 < endPtr - 67){  //- 102){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 67;
				p1 += 67;
				p2 += 67;
				p3 += 67;
				p4 += 67;
				p5 += 67;
				p6 += 67;
				p7 += 67;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 128;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 4;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 32;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 1;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 8;
			if(p0 + 50 > endPtr) return;
			p0[50] |= 64;
			if(p0 + 59 > endPtr) return;
			p0[59] |= 2;
		}
		public static unsafe void ClearFactor68(byte* ptr, uint limit)
		{
			var startPtr = ptr + 289;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 17;
			var p3 = startPtr + 25;
			var p4 = startPtr + 34;
			var p5 = startPtr + 42;
			var p6 = startPtr + 51;
			var p7 = startPtr + 59;

			while (p0 < endPtr - 68){  //- 104){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 68;
				p1 += 68;
				p2 += 68;
				p3 += 68;
				p4 += 68;
				p5 += 68;
				p6 += 68;
				p7 += 68;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 16;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 1;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 16;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 1;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 16;
			if(p0 + 51 > endPtr) return;
			p0[51] |= 1;
			if(p0 + 59 > endPtr) return;
			p0[59] |= 16;
		}
		public static unsafe void ClearFactor69(byte* ptr, uint limit)
		{
			var startPtr = ptr + 297;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 17;
			var p3 = startPtr + 26;
			var p4 = startPtr + 35;
			var p5 = startPtr + 43;
			var p6 = startPtr + 52;
			var p7 = startPtr + 60;

			while (p0 < endPtr - 69){  //- 106){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 69;
				p1 += 69;
				p2 += 69;
				p3 += 69;
				p4 += 69;
				p5 += 69;
				p6 += 69;
				p7 += 69;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 2;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 64;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 8;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 1;
			if(p0 + 43 > endPtr) return;
			p0[43] |= 32;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 4;
			if(p0 + 60 > endPtr) return;
			p0[60] |= 128;
		}
		public static unsafe void ClearFactor70(byte* ptr, uint limit)
		{
			var startPtr = ptr + 306;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 17;
			var p3 = startPtr + 26;
			var p4 = startPtr + 35;
			var p5 = startPtr + 44;
			var p6 = startPtr + 52;
			var p7 = startPtr + 61;

			while (p0 < endPtr - 70){  //- 108){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 70;
				p1 += 70;
				p2 += 70;
				p3 += 70;
				p4 += 70;
				p5 += 70;
				p6 += 70;
				p7 += 70;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 1;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 64;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 16;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 4;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 1;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 64;
			if(p0 + 61 > endPtr) return;
			p0[61] |= 16;
		}
		public static unsafe void ClearFactor71(byte* ptr, uint limit)
		{
			var startPtr = ptr + 315;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 8;
			var p2 = startPtr + 17;
			var p3 = startPtr + 26;
			var p4 = startPtr + 35;
			var p5 = startPtr + 44;
			var p6 = startPtr + 53;
			var p7 = startPtr + 62;

			while (p0 < endPtr - 71){  //- 110){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 71;
				p1 += 71;
				p2 += 71;
				p3 += 71;
				p4 += 71;
				p5 += 71;
				p6 += 71;
				p7 += 71;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 8 > endPtr) return;
			p0[8] |= 128;
			if(p0 + 17 > endPtr) return;
			p0[17] |= 64;
			if(p0 + 26 > endPtr) return;
			p0[26] |= 32;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 16;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 8;
			if(p0 + 53 > endPtr) return;
			p0[53] |= 4;
			if(p0 + 62 > endPtr) return;
			p0[62] |= 2;
		}
		public static unsafe void ClearFactor72(byte* ptr, uint limit)
		{
			var startPtr = ptr + 324;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 18;
			var p3 = startPtr + 27;
			var p4 = startPtr + 36;
			var p5 = startPtr + 45;
			var p6 = startPtr + 54;
			var p7 = startPtr + 63;

			while (p0 < endPtr - 72){  //- 112){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 72;
				p1 += 72;
				p2 += 72;
				p3 += 72;
				p4 += 72;
				p5 += 72;
				p6 += 72;
				p7 += 72;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 1;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 1;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 1;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 1;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 1;
			if(p0 + 54 > endPtr) return;
			p0[54] |= 1;
			if(p0 + 63 > endPtr) return;
			p0[63] |= 1;
		}
		public static unsafe void ClearFactor73(byte* ptr, uint limit)
		{
			var startPtr = ptr + 333;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 18;
			var p3 = startPtr + 27;
			var p4 = startPtr + 36;
			var p5 = startPtr + 45;
			var p6 = startPtr + 54;
			var p7 = startPtr + 63;

			while (p0 < endPtr - 73){  //- 114){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 73;
				p1 += 73;
				p2 += 73;
				p3 += 73;
				p4 += 73;
				p5 += 73;
				p6 += 73;
				p7 += 73;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 2;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 4;
			if(p0 + 27 > endPtr) return;
			p0[27] |= 8;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 16;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 32;
			if(p0 + 54 > endPtr) return;
			p0[54] |= 64;
			if(p0 + 63 > endPtr) return;
			p0[63] |= 128;
		}
		public static unsafe void ClearFactor74(byte* ptr, uint limit)
		{
			var startPtr = ptr + 342;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 18;
			var p3 = startPtr + 28;
			var p4 = startPtr + 37;
			var p5 = startPtr + 46;
			var p6 = startPtr + 55;
			var p7 = startPtr + 65;

			while (p0 < endPtr - 74){  //- 116){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 74;
				p1 += 74;
				p2 += 74;
				p3 += 74;
				p4 += 74;
				p5 += 74;
				p6 += 74;
				p7 += 74;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 16;
			if(p0 + 18 > endPtr) return;
			p0[18] |= 64;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 1;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 4;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 16;
			if(p0 + 55 > endPtr) return;
			p0[55] |= 64;
			if(p0 + 65 > endPtr) return;
			p0[65] |= 1;
		}
		public static unsafe void ClearFactor75(byte* ptr, uint limit)
		{
			var startPtr = ptr + 351;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 19;
			var p3 = startPtr + 28;
			var p4 = startPtr + 38;
			var p5 = startPtr + 47;
			var p6 = startPtr + 56;
			var p7 = startPtr + 66;

			while (p0 < endPtr - 75){  //- 118){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 75;
				p1 += 75;
				p2 += 75;
				p3 += 75;
				p4 += 75;
				p5 += 75;
				p6 += 75;
				p7 += 75;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 128;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 4;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 32;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 1;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 8;
			if(p0 + 56 > endPtr) return;
			p0[56] |= 64;
			if(p0 + 66 > endPtr) return;
			p0[66] |= 2;
		}
		public static unsafe void ClearFactor76(byte* ptr, uint limit)
		{
			var startPtr = ptr + 361;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 19;
			var p3 = startPtr + 28;
			var p4 = startPtr + 38;
			var p5 = startPtr + 47;
			var p6 = startPtr + 57;
			var p7 = startPtr + 66;

			while (p0 < endPtr - 76){  //- 121){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 76;
				p1 += 76;
				p2 += 76;
				p3 += 76;
				p4 += 76;
				p5 += 76;
				p6 += 76;
				p7 += 76;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 16;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 1;
			if(p0 + 28 > endPtr) return;
			p0[28] |= 16;
			if(p0 + 38 > endPtr) return;
			p0[38] |= 1;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 16;
			if(p0 + 57 > endPtr) return;
			p0[57] |= 1;
			if(p0 + 66 > endPtr) return;
			p0[66] |= 16;
		}
		public static unsafe void ClearFactor77(byte* ptr, uint limit)
		{
			var startPtr = ptr + 370;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 19;
			var p3 = startPtr + 29;
			var p4 = startPtr + 39;
			var p5 = startPtr + 48;
			var p6 = startPtr + 58;
			var p7 = startPtr + 67;

			while (p0 < endPtr - 77){  //- 123){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 77;
				p1 += 77;
				p2 += 77;
				p3 += 77;
				p4 += 77;
				p5 += 77;
				p6 += 77;
				p7 += 77;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 2;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 64;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 8;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 1;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 32;
			if(p0 + 58 > endPtr) return;
			p0[58] |= 4;
			if(p0 + 67 > endPtr) return;
			p0[67] |= 128;
		}
		public static unsafe void ClearFactor78(byte* ptr, uint limit)
		{
			var startPtr = ptr + 380;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 19;
			var p3 = startPtr + 29;
			var p4 = startPtr + 39;
			var p5 = startPtr + 49;
			var p6 = startPtr + 58;
			var p7 = startPtr + 68;

			while (p0 < endPtr - 78){  //- 125){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 78;
				p1 += 78;
				p2 += 78;
				p3 += 78;
				p4 += 78;
				p5 += 78;
				p6 += 78;
				p7 += 78;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 1;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 64;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 16;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 4;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 1;
			if(p0 + 58 > endPtr) return;
			p0[58] |= 64;
			if(p0 + 68 > endPtr) return;
			p0[68] |= 16;
		}
		public static unsafe void ClearFactor79(byte* ptr, uint limit)
		{
			var startPtr = ptr + 390;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 9;
			var p2 = startPtr + 19;
			var p3 = startPtr + 29;
			var p4 = startPtr + 39;
			var p5 = startPtr + 49;
			var p6 = startPtr + 59;
			var p7 = startPtr + 69;

			while (p0 < endPtr - 79){  //- 127){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 79;
				p1 += 79;
				p2 += 79;
				p3 += 79;
				p4 += 79;
				p5 += 79;
				p6 += 79;
				p7 += 79;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 9 > endPtr) return;
			p0[9] |= 128;
			if(p0 + 19 > endPtr) return;
			p0[19] |= 64;
			if(p0 + 29 > endPtr) return;
			p0[29] |= 32;
			if(p0 + 39 > endPtr) return;
			p0[39] |= 16;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 8;
			if(p0 + 59 > endPtr) return;
			p0[59] |= 4;
			if(p0 + 69 > endPtr) return;
			p0[69] |= 2;
		}
		public static unsafe void ClearFactor80(byte* ptr, uint limit)
		{
			var startPtr = ptr + 400;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 20;
			var p3 = startPtr + 30;
			var p4 = startPtr + 40;
			var p5 = startPtr + 50;
			var p6 = startPtr + 60;
			var p7 = startPtr + 70;

			while (p0 < endPtr - 80){  //- 130){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 80;
				p1 += 80;
				p2 += 80;
				p3 += 80;
				p4 += 80;
				p5 += 80;
				p6 += 80;
				p7 += 80;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 1;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 1;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 1;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 1;
			if(p0 + 50 > endPtr) return;
			p0[50] |= 1;
			if(p0 + 60 > endPtr) return;
			p0[60] |= 1;
			if(p0 + 70 > endPtr) return;
			p0[70] |= 1;
		}
		public static unsafe void ClearFactor81(byte* ptr, uint limit)
		{
			var startPtr = ptr + 410;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 20;
			var p3 = startPtr + 30;
			var p4 = startPtr + 40;
			var p5 = startPtr + 50;
			var p6 = startPtr + 60;
			var p7 = startPtr + 70;

			while (p0 < endPtr - 81){  //- 132){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 81;
				p1 += 81;
				p2 += 81;
				p3 += 81;
				p4 += 81;
				p5 += 81;
				p6 += 81;
				p7 += 81;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 2;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 4;
			if(p0 + 30 > endPtr) return;
			p0[30] |= 8;
			if(p0 + 40 > endPtr) return;
			p0[40] |= 16;
			if(p0 + 50 > endPtr) return;
			p0[50] |= 32;
			if(p0 + 60 > endPtr) return;
			p0[60] |= 64;
			if(p0 + 70 > endPtr) return;
			p0[70] |= 128;
		}
		public static unsafe void ClearFactor82(byte* ptr, uint limit)
		{
			var startPtr = ptr + 420;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 20;
			var p3 = startPtr + 31;
			var p4 = startPtr + 41;
			var p5 = startPtr + 51;
			var p6 = startPtr + 61;
			var p7 = startPtr + 72;

			while (p0 < endPtr - 82){  //- 134){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 82;
				p1 += 82;
				p2 += 82;
				p3 += 82;
				p4 += 82;
				p5 += 82;
				p6 += 82;
				p7 += 82;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 16;
			if(p0 + 20 > endPtr) return;
			p0[20] |= 64;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 1;
			if(p0 + 41 > endPtr) return;
			p0[41] |= 4;
			if(p0 + 51 > endPtr) return;
			p0[51] |= 16;
			if(p0 + 61 > endPtr) return;
			p0[61] |= 64;
			if(p0 + 72 > endPtr) return;
			p0[72] |= 1;
		}
		public static unsafe void ClearFactor83(byte* ptr, uint limit)
		{
			var startPtr = ptr + 430;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 21;
			var p3 = startPtr + 31;
			var p4 = startPtr + 42;
			var p5 = startPtr + 52;
			var p6 = startPtr + 62;
			var p7 = startPtr + 73;

			while (p0 < endPtr - 83){  //- 136){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 83;
				p1 += 83;
				p2 += 83;
				p3 += 83;
				p4 += 83;
				p5 += 83;
				p6 += 83;
				p7 += 83;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 128;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 4;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 32;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 1;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 8;
			if(p0 + 62 > endPtr) return;
			p0[62] |= 64;
			if(p0 + 73 > endPtr) return;
			p0[73] |= 2;
		}
		public static unsafe void ClearFactor84(byte* ptr, uint limit)
		{
			var startPtr = ptr + 441;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 21;
			var p3 = startPtr + 31;
			var p4 = startPtr + 42;
			var p5 = startPtr + 52;
			var p6 = startPtr + 63;
			var p7 = startPtr + 73;

			while (p0 < endPtr - 84){  //- 139){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 84;
				p1 += 84;
				p2 += 84;
				p3 += 84;
				p4 += 84;
				p5 += 84;
				p6 += 84;
				p7 += 84;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 16;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 1;
			if(p0 + 31 > endPtr) return;
			p0[31] |= 16;
			if(p0 + 42 > endPtr) return;
			p0[42] |= 1;
			if(p0 + 52 > endPtr) return;
			p0[52] |= 16;
			if(p0 + 63 > endPtr) return;
			p0[63] |= 1;
			if(p0 + 73 > endPtr) return;
			p0[73] |= 16;
		}
		public static unsafe void ClearFactor85(byte* ptr, uint limit)
		{
			var startPtr = ptr + 451;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 21;
			var p3 = startPtr + 32;
			var p4 = startPtr + 43;
			var p5 = startPtr + 53;
			var p6 = startPtr + 64;
			var p7 = startPtr + 74;

			while (p0 < endPtr - 85){  //- 141){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 85;
				p1 += 85;
				p2 += 85;
				p3 += 85;
				p4 += 85;
				p5 += 85;
				p6 += 85;
				p7 += 85;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 2;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 64;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 8;
			if(p0 + 43 > endPtr) return;
			p0[43] |= 1;
			if(p0 + 53 > endPtr) return;
			p0[53] |= 32;
			if(p0 + 64 > endPtr) return;
			p0[64] |= 4;
			if(p0 + 74 > endPtr) return;
			p0[74] |= 128;
		}
		public static unsafe void ClearFactor86(byte* ptr, uint limit)
		{
			var startPtr = ptr + 462;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 21;
			var p3 = startPtr + 32;
			var p4 = startPtr + 43;
			var p5 = startPtr + 54;
			var p6 = startPtr + 64;
			var p7 = startPtr + 75;

			while (p0 < endPtr - 86){  //- 143){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 86;
				p1 += 86;
				p2 += 86;
				p3 += 86;
				p4 += 86;
				p5 += 86;
				p6 += 86;
				p7 += 86;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 1;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 64;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 16;
			if(p0 + 43 > endPtr) return;
			p0[43] |= 4;
			if(p0 + 54 > endPtr) return;
			p0[54] |= 1;
			if(p0 + 64 > endPtr) return;
			p0[64] |= 64;
			if(p0 + 75 > endPtr) return;
			p0[75] |= 16;
		}
		public static unsafe void ClearFactor87(byte* ptr, uint limit)
		{
			var startPtr = ptr + 473;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 10;
			var p2 = startPtr + 21;
			var p3 = startPtr + 32;
			var p4 = startPtr + 43;
			var p5 = startPtr + 54;
			var p6 = startPtr + 65;
			var p7 = startPtr + 76;

			while (p0 < endPtr - 87){  //- 146){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 87;
				p1 += 87;
				p2 += 87;
				p3 += 87;
				p4 += 87;
				p5 += 87;
				p6 += 87;
				p7 += 87;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 10 > endPtr) return;
			p0[10] |= 128;
			if(p0 + 21 > endPtr) return;
			p0[21] |= 64;
			if(p0 + 32 > endPtr) return;
			p0[32] |= 32;
			if(p0 + 43 > endPtr) return;
			p0[43] |= 16;
			if(p0 + 54 > endPtr) return;
			p0[54] |= 8;
			if(p0 + 65 > endPtr) return;
			p0[65] |= 4;
			if(p0 + 76 > endPtr) return;
			p0[76] |= 2;
		}
		public static unsafe void ClearFactor88(byte* ptr, uint limit)
		{
			var startPtr = ptr + 484;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 22;
			var p3 = startPtr + 33;
			var p4 = startPtr + 44;
			var p5 = startPtr + 55;
			var p6 = startPtr + 66;
			var p7 = startPtr + 77;

			while (p0 < endPtr - 88){  //- 148){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 88;
				p1 += 88;
				p2 += 88;
				p3 += 88;
				p4 += 88;
				p5 += 88;
				p6 += 88;
				p7 += 88;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 1;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 1;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 1;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 1;
			if(p0 + 55 > endPtr) return;
			p0[55] |= 1;
			if(p0 + 66 > endPtr) return;
			p0[66] |= 1;
			if(p0 + 77 > endPtr) return;
			p0[77] |= 1;
		}
		public static unsafe void ClearFactor89(byte* ptr, uint limit)
		{
			var startPtr = ptr + 495;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 22;
			var p3 = startPtr + 33;
			var p4 = startPtr + 44;
			var p5 = startPtr + 55;
			var p6 = startPtr + 66;
			var p7 = startPtr + 77;

			while (p0 < endPtr - 89){  //- 150){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 89;
				p1 += 89;
				p2 += 89;
				p3 += 89;
				p4 += 89;
				p5 += 89;
				p6 += 89;
				p7 += 89;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 2;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 4;
			if(p0 + 33 > endPtr) return;
			p0[33] |= 8;
			if(p0 + 44 > endPtr) return;
			p0[44] |= 16;
			if(p0 + 55 > endPtr) return;
			p0[55] |= 32;
			if(p0 + 66 > endPtr) return;
			p0[66] |= 64;
			if(p0 + 77 > endPtr) return;
			p0[77] |= 128;
		}
		public static unsafe void ClearFactor90(byte* ptr, uint limit)
		{
			var startPtr = ptr + 506;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 22;
			var p3 = startPtr + 34;
			var p4 = startPtr + 45;
			var p5 = startPtr + 56;
			var p6 = startPtr + 67;
			var p7 = startPtr + 79;

			while (p0 < endPtr - 90){  //- 153){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 90;
				p1 += 90;
				p2 += 90;
				p3 += 90;
				p4 += 90;
				p5 += 90;
				p6 += 90;
				p7 += 90;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 16;
			if(p0 + 22 > endPtr) return;
			p0[22] |= 64;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 1;
			if(p0 + 45 > endPtr) return;
			p0[45] |= 4;
			if(p0 + 56 > endPtr) return;
			p0[56] |= 16;
			if(p0 + 67 > endPtr) return;
			p0[67] |= 64;
			if(p0 + 79 > endPtr) return;
			p0[79] |= 1;
		}
		public static unsafe void ClearFactor91(byte* ptr, uint limit)
		{
			var startPtr = ptr + 517;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 23;
			var p3 = startPtr + 34;
			var p4 = startPtr + 46;
			var p5 = startPtr + 57;
			var p6 = startPtr + 68;
			var p7 = startPtr + 80;

			while (p0 < endPtr - 91){  //- 155){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 91;
				p1 += 91;
				p2 += 91;
				p3 += 91;
				p4 += 91;
				p5 += 91;
				p6 += 91;
				p7 += 91;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 128;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 4;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 32;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 1;
			if(p0 + 57 > endPtr) return;
			p0[57] |= 8;
			if(p0 + 68 > endPtr) return;
			p0[68] |= 64;
			if(p0 + 80 > endPtr) return;
			p0[80] |= 2;
		}
		public static unsafe void ClearFactor92(byte* ptr, uint limit)
		{
			var startPtr = ptr + 529;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 23;
			var p3 = startPtr + 34;
			var p4 = startPtr + 46;
			var p5 = startPtr + 57;
			var p6 = startPtr + 69;
			var p7 = startPtr + 80;

			while (p0 < endPtr - 92){  //- 158){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 92;
				p1 += 92;
				p2 += 92;
				p3 += 92;
				p4 += 92;
				p5 += 92;
				p6 += 92;
				p7 += 92;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 16;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 1;
			if(p0 + 34 > endPtr) return;
			p0[34] |= 16;
			if(p0 + 46 > endPtr) return;
			p0[46] |= 1;
			if(p0 + 57 > endPtr) return;
			p0[57] |= 16;
			if(p0 + 69 > endPtr) return;
			p0[69] |= 1;
			if(p0 + 80 > endPtr) return;
			p0[80] |= 16;
		}
		public static unsafe void ClearFactor93(byte* ptr, uint limit)
		{
			var startPtr = ptr + 540;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 23;
			var p3 = startPtr + 35;
			var p4 = startPtr + 47;
			var p5 = startPtr + 58;
			var p6 = startPtr + 70;
			var p7 = startPtr + 81;

			while (p0 < endPtr - 93){  //- 160){
				p0[0] |= 16;
				p1[0] |= 2;
				p2[0] |= 64;
				p3[0] |= 8;
				p4[0] |= 1;
				p5[0] |= 32;
				p6[0] |= 4;
				p7[0] |= 128;

				p0 += 93;
				p1 += 93;
				p2 += 93;
				p3 += 93;
				p4 += 93;
				p5 += 93;
				p6 += 93;
				p7 += 93;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 2;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 64;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 8;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 1;
			if(p0 + 58 > endPtr) return;
			p0[58] |= 32;
			if(p0 + 70 > endPtr) return;
			p0[70] |= 4;
			if(p0 + 81 > endPtr) return;
			p0[81] |= 128;
		}
		public static unsafe void ClearFactor94(byte* ptr, uint limit)
		{
			var startPtr = ptr + 552;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 23;
			var p3 = startPtr + 35;
			var p4 = startPtr + 47;
			var p5 = startPtr + 59;
			var p6 = startPtr + 70;
			var p7 = startPtr + 82;

			while (p0 < endPtr - 94){  //- 163){
				p0[0] |= 4;
				p1[0] |= 1;
				p2[0] |= 64;
				p3[0] |= 16;
				p4[0] |= 4;
				p5[0] |= 1;
				p6[0] |= 64;
				p7[0] |= 16;

				p0 += 94;
				p1 += 94;
				p2 += 94;
				p3 += 94;
				p4 += 94;
				p5 += 94;
				p6 += 94;
				p7 += 94;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 1;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 64;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 16;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 4;
			if(p0 + 59 > endPtr) return;
			p0[59] |= 1;
			if(p0 + 70 > endPtr) return;
			p0[70] |= 64;
			if(p0 + 82 > endPtr) return;
			p0[82] |= 16;
		}
		public static unsafe void ClearFactor95(byte* ptr, uint limit)
		{
			var startPtr = ptr + 564;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 11;
			var p2 = startPtr + 23;
			var p3 = startPtr + 35;
			var p4 = startPtr + 47;
			var p5 = startPtr + 59;
			var p6 = startPtr + 71;
			var p7 = startPtr + 83;

			while (p0 < endPtr - 95){  //- 165){
				p0[0] |= 1;
				p1[0] |= 128;
				p2[0] |= 64;
				p3[0] |= 32;
				p4[0] |= 16;
				p5[0] |= 8;
				p6[0] |= 4;
				p7[0] |= 2;

				p0 += 95;
				p1 += 95;
				p2 += 95;
				p3 += 95;
				p4 += 95;
				p5 += 95;
				p6 += 95;
				p7 += 95;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 11 > endPtr) return;
			p0[11] |= 128;
			if(p0 + 23 > endPtr) return;
			p0[23] |= 64;
			if(p0 + 35 > endPtr) return;
			p0[35] |= 32;
			if(p0 + 47 > endPtr) return;
			p0[47] |= 16;
			if(p0 + 59 > endPtr) return;
			p0[59] |= 8;
			if(p0 + 71 > endPtr) return;
			p0[71] |= 4;
			if(p0 + 83 > endPtr) return;
			p0[83] |= 2;
		}
		public static unsafe void ClearFactor96(byte* ptr, uint limit)
		{
			var startPtr = ptr + 576;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 24;
			var p3 = startPtr + 36;
			var p4 = startPtr + 48;
			var p5 = startPtr + 60;
			var p6 = startPtr + 72;
			var p7 = startPtr + 84;

			while (p0 < endPtr - 96){  //- 168){
				p0[0] |= 1;
				p1[0] |= 1;
				p2[0] |= 1;
				p3[0] |= 1;
				p4[0] |= 1;
				p5[0] |= 1;
				p6[0] |= 1;
				p7[0] |= 1;

				p0 += 96;
				p1 += 96;
				p2 += 96;
				p3 += 96;
				p4 += 96;
				p5 += 96;
				p6 += 96;
				p7 += 96;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 1;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 1;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 1;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 1;
			if(p0 + 60 > endPtr) return;
			p0[60] |= 1;
			if(p0 + 72 > endPtr) return;
			p0[72] |= 1;
			if(p0 + 84 > endPtr) return;
			p0[84] |= 1;
		}
		public static unsafe void ClearFactor97(byte* ptr, uint limit)
		{
			var startPtr = ptr + 588;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 24;
			var p3 = startPtr + 36;
			var p4 = startPtr + 48;
			var p5 = startPtr + 60;
			var p6 = startPtr + 72;
			var p7 = startPtr + 84;

			while (p0 < endPtr - 97){  //- 170){
				p0[0] |= 1;
				p1[0] |= 2;
				p2[0] |= 4;
				p3[0] |= 8;
				p4[0] |= 16;
				p5[0] |= 32;
				p6[0] |= 64;
				p7[0] |= 128;

				p0 += 97;
				p1 += 97;
				p2 += 97;
				p3 += 97;
				p4 += 97;
				p5 += 97;
				p6 += 97;
				p7 += 97;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 2;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 4;
			if(p0 + 36 > endPtr) return;
			p0[36] |= 8;
			if(p0 + 48 > endPtr) return;
			p0[48] |= 16;
			if(p0 + 60 > endPtr) return;
			p0[60] |= 32;
			if(p0 + 72 > endPtr) return;
			p0[72] |= 64;
			if(p0 + 84 > endPtr) return;
			p0[84] |= 128;
		}
		public static unsafe void ClearFactor98(byte* ptr, uint limit)
		{
			var startPtr = ptr + 600;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 24;
			var p3 = startPtr + 37;
			var p4 = startPtr + 49;
			var p5 = startPtr + 61;
			var p6 = startPtr + 73;
			var p7 = startPtr + 86;

			while (p0 < endPtr - 98){  //- 173){
				p0[0] |= 4;
				p1[0] |= 16;
				p2[0] |= 64;
				p3[0] |= 1;
				p4[0] |= 4;
				p5[0] |= 16;
				p6[0] |= 64;
				p7[0] |= 1;

				p0 += 98;
				p1 += 98;
				p2 += 98;
				p3 += 98;
				p4 += 98;
				p5 += 98;
				p6 += 98;
				p7 += 98;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 4;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 16;
			if(p0 + 24 > endPtr) return;
			p0[24] |= 64;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 1;
			if(p0 + 49 > endPtr) return;
			p0[49] |= 4;
			if(p0 + 61 > endPtr) return;
			p0[61] |= 16;
			if(p0 + 73 > endPtr) return;
			p0[73] |= 64;
			if(p0 + 86 > endPtr) return;
			p0[86] |= 1;
		}
		public static unsafe void ClearFactor99(byte* ptr, uint limit)
		{
			var startPtr = ptr + 612;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 25;
			var p3 = startPtr + 37;
			var p4 = startPtr + 50;
			var p5 = startPtr + 62;
			var p6 = startPtr + 74;
			var p7 = startPtr + 87;

			while (p0 < endPtr - 99){  //- 175){
				p0[0] |= 16;
				p1[0] |= 128;
				p2[0] |= 4;
				p3[0] |= 32;
				p4[0] |= 1;
				p5[0] |= 8;
				p6[0] |= 64;
				p7[0] |= 2;

				p0 += 99;
				p1 += 99;
				p2 += 99;
				p3 += 99;
				p4 += 99;
				p5 += 99;
				p6 += 99;
				p7 += 99;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 16;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 128;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 4;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 32;
			if(p0 + 50 > endPtr) return;
			p0[50] |= 1;
			if(p0 + 62 > endPtr) return;
			p0[62] |= 8;
			if(p0 + 74 > endPtr) return;
			p0[74] |= 64;
			if(p0 + 87 > endPtr) return;
			p0[87] |= 2;
		}
		public static unsafe void ClearFactor100(byte* ptr, uint limit)
		{
			var startPtr = ptr + 625;
			var endPtr = ptr + limit / 8 + 1;

			var p0 = startPtr + 0;
			var p1 = startPtr + 12;
			var p2 = startPtr + 25;
			var p3 = startPtr + 37;
			var p4 = startPtr + 50;
			var p5 = startPtr + 62;
			var p6 = startPtr + 75;
			var p7 = startPtr + 87;

			while (p0 < endPtr - 100){  //- 178){
				p0[0] |= 1;
				p1[0] |= 16;
				p2[0] |= 1;
				p3[0] |= 16;
				p4[0] |= 1;
				p5[0] |= 16;
				p6[0] |= 1;
				p7[0] |= 16;

				p0 += 100;
				p1 += 100;
				p2 += 100;
				p3 += 100;
				p4 += 100;
				p5 += 100;
				p6 += 100;
				p7 += 100;
			}

			if(p0 + 0 > endPtr) return;
			p0[0] |= 1;
			if(p0 + 12 > endPtr) return;
			p0[12] |= 16;
			if(p0 + 25 > endPtr) return;
			p0[25] |= 1;
			if(p0 + 37 > endPtr) return;
			p0[37] |= 16;
			if(p0 + 50 > endPtr) return;
			p0[50] |= 1;
			if(p0 + 62 > endPtr) return;
			p0[62] |= 16;
			if(p0 + 75 > endPtr) return;
			p0[75] |= 1;
			if(p0 + 87 > endPtr) return;
			p0[87] |= 16;
		}
	}
}