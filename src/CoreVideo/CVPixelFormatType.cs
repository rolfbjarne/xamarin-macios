// 
// CVPixelFormatType.cs
//
// Authors: Mono Team
//     
// Copyright 2011 Novell, Inc
// Copyright 2011-2014, 2016 Xamarin Inc
// Copyright 2020 Microsoft Corporation
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

#nullable enable

namespace CoreVideo {
	/// <summary>An enumeration of known pixel formats.</summary>
	public enum CVPixelFormatType : uint {
		/// <summary>To be added.</summary>
		CV1Monochrome = 0x00000001,
		/// <summary>To be added.</summary>
		CV2Indexed = 0x00000002,
		/// <summary>To be added.</summary>
		CV4Indexed = 0x00000004,
		/// <summary>To be added.</summary>
		CV8Indexed = 0x00000008,
		/// <summary>To be added.</summary>
		CV1IndexedGray_WhiteIsZero = 0x00000021,
		/// <summary>To be added.</summary>
		CV2IndexedGray_WhiteIsZero = 0x00000022,
		/// <summary>To be added.</summary>
		CV4IndexedGray_WhiteIsZero = 0x00000024,
		/// <summary>To be added.</summary>
		CV8IndexedGray_WhiteIsZero = 0x00000028,
		/// <summary>To be added.</summary>
		CV16BE555 = 0x00000010,
		/// <summary>To be added.</summary>
		CV24RGB = 0x00000018,
		/// <summary>To be added.</summary>
		CV32ARGB = 0x00000020,
		/// <summary>To be added.</summary>
		CV16LE555 = 0x4c353535,
		/// <summary>To be added.</summary>
		CV16LE5551 = 0x35353531,
		/// <summary>To be added.</summary>
		CV16BE565 = 0x42353635,
		/// <summary>To be added.</summary>
		CV16LE565 = 0x4c353635,
		/// <summary>To be added.</summary>
		CV24BGR = 0x32344247,
		/// <summary>To be added.</summary>
		CV32BGRA = 0x42475241,
		/// <summary>To be added.</summary>
		CV32ABGR = 0x41424752,
		/// <summary>To be added.</summary>
		CV32RGBA = 0x52474241,
		/// <summary>To be added.</summary>
		CV64ARGB = 0x62363461,
		/// <summary>To be added.</summary>
		CV48RGB = 0x62343872,
		/// <summary>To be added.</summary>
		CV32AlphaGray = 0x62333261,
		/// <summary>To be added.</summary>
		CV16Gray = 0x62313667,
		/// <summary>30-bit RGB, 10-bit big endian samples, 2 unused padding bits (at most significant end).</summary>
		CV30RGB_r210 = 0x72323130, // 'r210'
		/// <summary>To be added.</summary>
		CV422YpCbCr8 = 0x32767579,
		/// <summary>To be added.</summary>
		CV4444YpCbCrA8 = 0x76343038,
		/// <summary>To be added.</summary>
		CV4444YpCbCrA8R = 0x72343038,
		/// <summary>To be added.</summary>
		CV444YpCbCr8 = 0x76333038,
		/// <summary>To be added.</summary>
		CV422YpCbCr16 = 0x76323136,
		/// <summary>To be added.</summary>
		CV422YpCbCr10 = 0x76323130,
		/// <summary>To be added.</summary>
		CV444YpCbCr10 = 0x76343130,
		/// <summary>To be added.</summary>
		CV420YpCbCr8Planar = 0x79343230,
		/// <summary>To be added.</summary>
		CV420YpCbCr8PlanarFullRange = 0x66343230,
		/// <summary>To be added.</summary>
		CV422YpCbCr_4A_8BiPlanar = 0x61327679,
		/// <summary>To be added.</summary>
		CV420YpCbCr8BiPlanarVideoRange = 0x34323076,
		/// <summary>To be added.</summary>
		CV420YpCbCr8BiPlanarFullRange = 0x34323066,
		/// <summary>To be added.</summary>
		CV422YpCbCr8_yuvs = 0x79757673,
		/// <summary>To be added.</summary>
		CV422YpCbCr8FullRange = 0x79757666,
		/// <summary>To be added.</summary>
		CV30RGB = 0x5231306b,
		/// <summary>To be added.</summary>
		CV4444AYpCbCr8 = 0x79343038,
		/// <summary>To be added.</summary>
		CV4444AYpCbCr16 = 0x79343136,
		// Since 5.1
		/// <summary>To be added.</summary>
		OneComponent8 = 0x4C303038,
		/// <summary>To be added.</summary>
		TwoComponent8 = 0x32433038,
		// Since 6.0
		/// <summary>To be added.</summary>
		OneComponent16Half = 0x4C303068, // 'L00h'
		/// <summary>To be added.</summary>
		OneComponent32Float = 0x4C303066, // 'L00f'
		/// <summary>To be added.</summary>
		TwoComponent16Half = 0x32433068, // '2C0h'
		/// <summary>To be added.</summary>
		TwoComponent32Float = 0x32433066, // '2C0f'
		/// <summary>To be added.</summary>
		CV64RGBAHalf = 0x52476841, // 'RGhA'
		/// <summary>To be added.</summary>
		CV128RGBAFloat = 0x52476641, // 'RGfA'
		/// <summary>To be added.</summary>
		CV30RgbLePackedWideGamut = 0x77333072, // 'w30r'
		/// <summary>To be added.</summary>
		CV14BayerGrbg = 0x67726234, // 'grb4',
		/// <summary>To be added.</summary>
		CV14BayerRggb = 0x72676734, // 'rgg4',
		/// <summary>To be added.</summary>
		CV14BayerBggr = 0x62676734, // 'bgg4',
		/// <summary>To be added.</summary>
		CV14BayerGbrg = 0x67627234, // 'gbr4',
		/// <summary>To be added.</summary>
		Argb2101010LEPacked = 0x6C313072, // 'l10r'
		/// <summary>To be added.</summary>
		DisparityFloat16 = 0x68646973, // hdis
		/// <summary>To be added.</summary>
		DisparityFloat32 = 0x66646973, // fdis
		/// <summary>To be added.</summary>
		DepthFloat16 = 0x68646570, // hdep
		/// <summary>To be added.</summary>
		DepthFloat32 = 0x66646570, // fdep
		/// <summary>To be added.</summary>
		CV420YpCbCr10BiPlanarVideoRange = 0x78343230, // x420
		/// <summary>To be added.</summary>
		CV422YpCbCr10BiPlanarVideoRange = 0x78343232, // x422
		/// <summary>To be added.</summary>
		CV444YpCbCr10BiPlanarVideoRange = 0x78343434, // x444
		/// <summary>To be added.</summary>
		CV420YpCbCr10BiPlanarFullRange = 0x78663230, // xf20
		/// <summary>To be added.</summary>
		CV422YpCbCr10BiPlanarFullRange = 0x78663232, // xf22
		/// <summary>To be added.</summary>
		CV444YpCbCr10BiPlanarFullRange = 0x78663434, // xf44
		CV422YpCbCr8BiPlanarVideoRange = 0x34323276, // '422v'
		CV422YpCbCr8BiPlanarFullRange = 0x34323266, // '422f'
		CV444YpCbCr8BiPlanarVideoRange = 0x34343476, // '444v'
		CV444YpCbCr8BiPlanarFullRange = 0x34343466, // '444f'
		OneComponent10 = 0x4c303130, // 'L010'
		OneComponent12 = 0x4c303132, // 'L012'
		OneComponent16 = 0x4c303136, // 'L016'
		TwoComponent16 = 0x32433136, // '2C16'
		CV16VersatileBayer = 0x62703136, // 'bp16'
		CV96VersatileBayerPacked12 = ('b' << 24) + ('t' << 16) + ('p' << 8) + '2', // 'btp2'
		CV64Rgba_DownscaledProResRaw = 0x62703634, // 'bp64'
		CV64RgbaLE = 0x6C363472,

		/* Lossless pixel formats */

		/// <summary>Lossless-compressed form of <see cref="CV32BGRA" />.</summary>
		Lossless_32BGRA = ('&' << 24) + ('B' << 16) + ('G' << 8) + 'A', // '&BGA'

		/// <summary>Lossless-compressed form of <see cref="CV64RGBAHalf" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossless_64RGBAHalf = ('&' << 24) + ('R' << 16) + ('h' << 8) + 'A', // '&RhA'

		/// <summary>Lossless-compressed form of <see cref="CV420YpCbCr8BiPlanarVideoRange" />. >No CVPlanarPixelBufferInfo struct.</summary>
		Lossless_420YpCbCr8BiPlanarVideoRange = ('&' << 24) + ('8' << 16) + ('v' << 8) + '0', // '&8v0'

		/// <summary>Lossless-compressed form of <see cref="CV420YpCbCr8BiPlanarFullRange" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossless_420YpCbCr8BiPlanarFullRange = ('&' << 24) + ('8' << 16) + ('f' << 8) + '0', // '&8f0'

		/// <summary>Lossless-compressed form of <see cref="CV420YpCbCr10BiPlanarVideoRange" />. No CVPlanarPixelBufferInfo struct. Compressed-packed with bo padding bits between pixels.</summary>
		Lossless_420YpCbCr10PackedBiPlanarVideoRange = ('&' << 24) + ('x' << 16) + ('v' << 8) + '0', // '&xv0'

		/// <summary>Lossless-compressed form of <see cref="CV422YpCbCr10BiPlanarVideoRange" />. No CVPlanarPixelBufferInfo struct. Compressed-packed with bo padding bits between pixels.</summary>
		Lossless_422YpCbCr10PackedBiPlanarVideoRange = ('&' << 24) + ('x' << 16) + ('v' << 8) + '2', // '&xv2'

		/// <summary>Lossless-compressed form of <see cref="CV420YpCbCr10BiPlanarFullRange" />. No CVPlanarPixelBufferInfo struct. Compressed-packed with bo padding bits between pixels.</summary>
		Lossless_420YpCbCr10PackedBiPlanarFullRange = ('&' << 24) + ('x' << 16) + ('f' << 8) + '0', // '&xf0'

		/// <summary>Lossless-compressed form of <see cref="CV30RGBLE_8A_BiPlanar" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossless_30RGBLE_8A_BiPlanar                  = ('&' << 24) + ('b' << 16) + ('3' << 8) + '8', // '&b38'
		/// <summary>Lossless-compressed form of <see cref="CV30RGBLEPackedWideGamut" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossless_30RGBLEPackedWideGamut               = ('&' << 24) + ('w' << 16) + ('3' << 8) + 'r', // '&w3r'

		/* Lossy pixel formats */

		/// <summary>Lossy-compressed form of <see cref="CV32BGRA" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossy_32BGRA = ('-' << 24) + ('B' << 16) + ('G' << 8) + 'A', // '-BGA'

		/// <summary>Lossy-compressed form of <see cref="CV420YpCbCr8BiPlanarVideoRange" />. No CVPlanarPixelBufferInfo struct.</summary>
		Lossy_420YpCbCr8BiPlanarVideoRange = ('-' << 24) + ('8' << 16) + ('v' << 8) + '0', // '-8v0'

		/// <summary>Lossy-compressed form of <see cref="CV420YpCbCr8BiPlanarFullRange" />. >No CVPlanarPixelBufferInfo struct.</summary>
		Lossy_420YpCbCr8BiPlanarFullRange = ('-' << 24) + ('8' << 16) + ('f' << 8) + '0', // '-8f0'

		/// <summary>Lossy-compressed form of <see cref="CV420YpCbCr10BiPlanarVideoRange" />. No CVPlanarPixelBufferInfo struct. Compressed-packed with bo padding bits between pixels.</summary>
		Lossy_420YpCbCr10PackedBiPlanarVideoRange = ('-' << 24) + ('x' << 16) + ('v' << 8) + '0', // '-xv0'

		/// <summary>Lossy-compressed form of <see cref="CV422YpCbCr10BiPlanarVideoRange" />. No CVPlanarPixelBufferInfo struct. Compressed-packed with bo padding bits between pixels.</summary>
		Lossy_422YpCbCr10PackedBiPlanarVideoRange = ('-' << 24) + ('x' << 16) + ('v' << 8) + '2', // '-xv2'

		CV1Monochrome    = 0x00000001,
		CV2Indexed       = 0x00000002,
		CV4Indexed       = 0x00000004,
		CV8Indexed       = 0x00000008,
		CV1IndexedGray_WhiteIsZero = 0x00000021,
		CV2IndexedGray_WhiteIsZero = 0x00000022,
		CV4IndexedGray_WhiteIsZero = 0x00000024,
		CV8IndexedGray_WhiteIsZero = 0x00000028,
		CV16BE555        = 0x00000010,
		CV16LE555        = ('L' << 24) + ('5' << 16) + ('5' << 8) + '5', // 'L555'
		CV16LE5551       = ('5' << 24) + ('5' << 16) + ('5' << 8) + '1', // '5551'
		CV16BE565        = ('B' << 24) + ('5' << 16) + ('6' << 8) + '5', // 'B565'
		CV16LE565        = ('L' << 24) + ('5' << 16) + ('6' << 8) + '5', // 'L565'
		CV24RGB          = 0x00000018,
		CV24BGR          = ('2' << 24) + ('4' << 16) + ('B' << 8) + 'G', // '24BG'
		CV32ARGB         = 0x00000020,
		CV32BGRA         = ('B' << 24) + ('G' << 16) + ('R' << 8) + 'A', // 'BGRA'
		CV32ABGR         = ('A' << 24) + ('B' << 16) + ('G' << 8) + 'R', // 'ABGR'
		CV32RGBA         = ('R' << 24) + ('G' << 16) + ('B' << 8) + 'A', // 'RGBA'
		CV64ARGB         = ('b' << 24) + ('6' << 16) + ('4' << 8) + 'a', // 'b64a'
		CV64RGBALE       = ('l' << 24) + ('6' << 16) + ('4' << 8) + 'r', // 'l64r'
		CV48RGB          = ('b' << 24) + ('4' << 16) + ('8' << 8) + 'r', // 'b48r'
		CV32AlphaGray    = ('b' << 24) + ('3' << 16) + ('2' << 8) + 'a', // 'b32a'
		CV16Gray         = ('b' << 24) + ('1' << 16) + ('6' << 8) + 'g', // 'b16g'
		CV30RGB          = ('R' << 24) + ('1' << 16) + ('0' << 8) + 'k', // 'R10k'
		CV30RGB_r210     = ('r' << 24) + ('2' << 16) + ('1' << 8) + '0', // 'r210'
		CV422YpCbCr8     = ('2' << 24) + ('v' << 16) + ('u' << 8) + 'y', // '2vuy'
		CV4444YpCbCrA8   = ('v' << 24) + ('4' << 16) + ('0' << 8) + '8', // 'v408'
		CV4444YpCbCrA8R  = ('r' << 24) + ('4' << 16) + ('0' << 8) + '8', // 'r408'
		CV4444AYpCbCr8   = ('y' << 24) + ('4' << 16) + ('0' << 8) + '8', // 'y408'
		CV4444AYpCbCr16  = ('y' << 24) + ('4' << 16) + ('1' << 8) + '6', // 'y416'
		CV4444AYpCbCrFloat    = ('r' << 24) + ('4' << 16) + ('f' << 8) + 'l', // 'r4fl'
		CV444YpCbCr8     = ('v' << 24) + ('3' << 16) + ('0' << 8) + '8', // 'v308'
		CV422YpCbCr16    = ('v' << 24) + ('2' << 16) + ('1' << 8) + '6', // 'v216'
		CV422YpCbCr10    = ('v' << 24) + ('2' << 16) + ('1' << 8) + '0', // 'v210'
		CV444YpCbCr10    = ('v' << 24) + ('4' << 16) + ('1' << 8) + '0', // 'v410'
		CV420YpCbCr8Planar = ('y' << 24) + ('4' << 16) + ('2' << 8) + '0', // 'y420'
		CV420YpCbCr8PlanarFullRange    = ('f' << 24) + ('4' << 16) + ('2' << 8) + '0', // 'f420'
		CV422YpCbCr_4A_8BiPlanar = ('a' << 24) + ('2' << 16) + ('v' << 8) + 'y', // 'a2vy'
		CV420YpCbCr8BiPlanarVideoRange = ('4' << 24) + ('2' << 16) + ('0' << 8) + 'v', // '420v'
		CV420YpCbCr8BiPlanarFullRange  = ('4' << 24) + ('2' << 16) + ('0' << 8) + 'f', // '420f'
		CV422YpCbCr8BiPlanarVideoRange = ('4' << 24) + ('2' << 16) + ('2' << 8) + 'v', // '422v'
		CV422YpCbCr8BiPlanarFullRange  = ('4' << 24) + ('2' << 16) + ('2' << 8) + 'f', // '422f'
		CV444YpCbCr8BiPlanarVideoRange = ('4' << 24) + ('4' << 16) + ('4' << 8) + 'v', // '444v'
		CV444YpCbCr8BiPlanarFullRange  = ('4' << 24) + ('4' << 16) + ('4' << 8) + 'f', // '444f'
		CV422YpCbCr8_yuvs = ('y' << 24) + ('u' << 16) + ('v' << 8) + 's', // 'yuvs'
		CV422YpCbCr8FullRange = ('y' << 24) + ('u' << 16) + ('v' << 8) + 'f', // 'yuvf'
		OneComponent8  = ('L' << 24) + ('0' << 16) + ('0' << 8) + '8', // 'L008'
		TwoComponent8  = ('2' << 24) + ('C' << 16) + ('0' << 8) + '8', // '2C08'
		CV30RGBLEPackedWideGamut = ('w' << 24) + ('3' << 16) + ('0' << 8) + 'r', // 'w30r'
		ARGB2101010LEPacked = ('l' << 24) + ('1' << 16) + ('0' << 8) + 'r', // 'l10r'
		CV40ARGBLEWideGamut      = ('w' << 24) + ('4' << 16) + ('0' << 8) + 'a', // 'w40a'
		CV40ARGBLEWideGamutPremultiplied = ('w' << 24) + ('4' << 16) + ('0' << 8) + 'm', // 'w40m'
		OneComponent10      = ('L' << 24) + ('0' << 16) + ('1' << 8) + '0', // 'L010'
		OneComponent12      = ('L' << 24) + ('0' << 16) + ('1' << 8) + '2', // 'L012'
		OneComponent16      = ('L' << 24) + ('0' << 16) + ('1' << 8) + '6', // 'L016'
		TwoComponent16      = ('2' << 24) + ('C' << 16) + ('1' << 8) + '6', // '2C16'
		OneComponent16Half  = ('L' << 24) + ('0' << 16) + ('0' << 8) + 'h', // 'L00h'
		OneComponent32Float = ('L' << 24) + ('0' << 16) + ('0' << 8) + 'f', // 'L00f'
		TwoComponent16Half  = ('2' << 24) + ('C' << 16) + ('0' << 8) + 'h', // '2C0h'
		TwoComponent32Float = ('2' << 24) + ('C' << 16) + ('0' << 8) + 'f', // '2C0f'
		CV64RGBAHalf          = ('R' << 24) + ('G' << 16) + ('h' << 8) + 'A', // 'RGhA'
		CV128RGBAFloat        = ('R' << 24) + ('G' << 16) + ('f' << 8) + 'A', // 'RGfA'
		CV14Bayer_GRBG        = ('g' << 24) + ('r' << 16) + ('b' << 8) + '4', // 'grb4'
		CV14Bayer_RGGB        = ('r' << 24) + ('g' << 16) + ('g' << 8) + '4', // 'rgg4'
		CV14Bayer_BGGR        = ('b' << 24) + ('g' << 16) + ('g' << 8) + '4', // 'bgg4'
		CV14Bayer_GBRG        = ('g' << 24) + ('b' << 16) + ('r' << 8) + '4', // 'gbr4'
		DisparityFloat16	 = ('h' << 24) + ('d' << 16) + ('i' << 8) + 's', // 'hdis'
		DisparityFloat32	 = ('f' << 24) + ('d' << 16) + ('i' << 8) + 's', // 'fdis'
		DepthFloat16	     = ('h' << 24) + ('d' << 16) + ('e' << 8) + 'p', // 'hdep'
		DepthFloat32	     = ('f' << 24) + ('d' << 16) + ('e' << 8) + 'p', // 'fdep'
		CV420YpCbCr10BiPlanarVideoRange = ('x' << 24) + ('4' << 16) + ('2' << 8) + '0', // 'x420'
		CV422YpCbCr10BiPlanarVideoRange = ('x' << 24) + ('4' << 16) + ('2' << 8) + '2', // 'x422'
		CV444YpCbCr10BiPlanarVideoRange = ('x' << 24) + ('4' << 16) + ('4' << 8) + '4', // 'x444'
		CV420YpCbCr10BiPlanarFullRange  = ('x' << 24) + ('f' << 16) + ('2' << 8) + '0', // 'xf20'
		CV422YpCbCr10BiPlanarFullRange  = ('x' << 24) + ('f' << 16) + ('2' << 8) + '2', // 'xf22'
		CV444YpCbCr10BiPlanarFullRange  = ('x' << 24) + ('f' << 16) + ('4' << 8) + '4', // 'xf44'
		CV420YpCbCr8VideoRange_8A_TriPlanar   = ('v' << 24) + ('0' << 16) + ('a' << 8) + '8', // 'v0a8'
		CV16VersatileBayer    = ('b' << 24) + ('p' << 16) + ('1' << 8) + '6', // 'bp16'
		CV96VersatileBayerPacked12      = ('b' << 24) + ('t' << 16) + ('p' << 8) + '2', // 'btp2'
		CV64RGBA_DownscaledProResRAW    = ('b' << 24) + ('p' << 16) + ('6' << 8) + '4', // 'bp64'
		CV422YpCbCr16BiPlanarVideoRange       = ('s' << 24) + ('v' << 16) + ('2' << 8) + '2', // 'sv22'
		CV444YpCbCr16BiPlanarVideoRange       = ('s' << 24) + ('v' << 16) + ('4' << 8) + '4', // 'sv44'
		CV444YpCbCr16VideoRange_16A_TriPlanar = ('s' << 24) + ('4' << 16) + ('a' << 8) + 's', // 's4as'
		CV30RGBLE_8A_BiPlanar                 = ('b' << 24) + ('3' << 16) + ('a' << 8) + '8', // 'b3a8'
	}

#if !COREBUILD
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public static class CVPixelFormatTypeExtensions {

		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreVideoLibrary)]
		static extern byte CVIsCompressedPixelFormatAvailable (uint pixelFormatType);

		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static bool IsCompressedPixelFormatAvailable (this CVPixelFormatType type)
			=> CVIsCompressedPixelFormatAvailable ((uint) type) != 0;

		/// <summary>Get the pixel format type's FourCC code as a string.</summary>
		/// <param name="type">The pixel format type to convert to a string.</param>
		/// <summary>The pixel format type's FourCC code as a string.</summary>
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public static string? ToFourCharCodeString (this CVPixelFormatType type)
		{
			var rv = CVPixelFormatTypeCopyFourCharCodeString (type);
			return CFString.FromHandle (rv, owns: false);
		}
	}
#endif
}
