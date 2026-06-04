// 
// CoreVideo.cs
//
// Authors: Mono Team
//     
// Copyright 2011 Novell, Inc
// Copyright 2011-2014 Xamarin Inc
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
using CoreFoundation;

#nullable enable

namespace CoreVideo {

	// CVPixelBuffer.h
	/// <summary>A struct that describes planar components.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVPlanarComponentInfo {
	/// <summary>The byte offset of this component within the plane.</summary>
		public /* int32_t */ int Offset;
	/// <summary>The number of bytes per row for this component.</summary>
		public /* uint32_t */ uint RowBytes;
	}

	// CVPixelBuffer.h
	/// <summary>A struct that holds the <see cref="CoreVideo.CVPlanarComponentInfo" />s of APlanar buffer.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVPlanarPixelBufferInfo {
	/// <summary>The component info array for each plane.</summary>
		public CVPlanarComponentInfo [] ComponentInfo;
	}

	// CVPixelBuffer.h
	/// <summary>A struct that defines the <see cref="CoreVideo.CVPlanarComponentInfo" />s of a YCbCr planar buffer.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVPlanarPixelBufferInfo_YCbCrPlanar {
	/// <summary>The component info for the Y (luma) plane.</summary>
		public CVPlanarComponentInfo ComponentInfoY;
	/// <summary>The component info for the Cb (blue chroma) plane.</summary>
		public CVPlanarComponentInfo ComponentInfoCb;
	/// <summary>The component info for the Cr (red chroma) plane.</summary>
		public CVPlanarComponentInfo ComponentInfoCr;
	}

	/// <summary>Implements a YCbCr biplanar buffer description.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVPlanarPixelBufferInfo_YCbCrBiPlanar {
		/// <summary>A descriptor for the Y buffer.</summary>
		public CVPlanarComponentInfo ComponentInfoY;
		/// <summary>A descriptor for the Cb/CR buffer.</summary>
		public CVPlanarComponentInfo ComponentInfoCbCr;
	}

	/// <summary>A struct that describes a display timestamp.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVTimeStamp {
	/// <summary>The version of this time stamp structure.</summary>
		public UInt32 Version;
	/// <summary>The video time scale (units per second).</summary>
		public Int32 VideoTimeScale;
	/// <summary>The video time in video time scale units.</summary>
		public Int64 VideoTime;
	/// <summary>The host time in Mach absolute time units.</summary>
		public UInt64 HostTime;
	/// <summary>The rate scalar indicating the playback rate.</summary>
		public double RateScalar;
	/// <summary>The video refresh period in video time scale units.</summary>
		public Int64 VideoRefreshPeriod;
	/// <summary>The SMPTE time code associated with this time stamp.</summary>
		public CVSMPTETime SMPTETime;
	/// <summary>Flags indicating the validity of various fields.</summary>
		public UInt64 Flags;
	/// <summary>Reserved for future use.</summary>
		public UInt64 Reserved;
	}

	/// <summary>Encodes an SMPTE timestamp.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVSMPTETime {
	/// <summary>The subframe count within the current frame.</summary>
		public Int16 Subframes;
	/// <summary>The number of subframes per frame.</summary>
		public Int16 SubframeDivisor;
	/// <summary>The frame counter value.</summary>
		public UInt32 Counter;
	/// <summary>The SMPTE time type (e.g., 24fps, 25fps, 30fps).</summary>
		public UInt32 Type;
	/// <summary>Flags indicating the SMPTE time state.</summary>
		public UInt32 Flags;
	/// <summary>The hours component of the SMPTE time code.</summary>
		public Int16 Hours;
	/// <summary>The minutes component of the SMPTE time code.</summary>
		public Int16 Minutes;
	/// <summary>The seconds component of the SMPTE time code.</summary>
		public Int16 Seconds;
	/// <summary>The frames component of the SMPTE time code.</summary>
		public Int16 Frames;
	}

#if !XAMCORE_5_0
	/// <summary>Encapsulates the description of a custom extended-pixel fill algorithm.</summary>
	///     <altmember cref="CoreVideo.CVFillExtendedPixelsCallBack" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct CVFillExtendedPixelsCallBackData {
	/// <summary>The version of this callback data structure.</summary>
		public nint /* CFIndex */ Version;
	/// <summary>The callback function to fill extended pixels.</summary>
		public CVFillExtendedPixelsCallBack FillCallBack;
	/// <summary>User-defined data passed to the callback.</summary>
		public IntPtr UserInfo;
	}

	/// <param name="pixelBuffer">The pixel buffer.</param>
	///     <param name="refCon">The ref con.</param>
	///     <summary>A delegate that defines the function used to pad buffers that use a custom pixel format.</summary>
	///     <altmember cref="CoreVideo.CVFillExtendedPixelsCallBackData" />
	public delegate bool CVFillExtendedPixelsCallBack (IntPtr pixelBuffer, IntPtr refCon);
#endif // !XAMCORE_5_0

	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
#if XAMCORE_5_0
	public unsafe struct CVFillExtendedPixelsCallBackData {
#else
	[NativeName ("CVFillExtendedPixelsCallBackData")]
	public unsafe struct CVFillExtendedPixelsCallBackDataStruct {
#endif
		public nint /* CFIndex */ Version;
		public delegate* unmanaged<IntPtr, IntPtr, byte> FillCallBack;
		public IntPtr UserInfo;
#if !COREBUILD
		public unsafe bool CallFillCallback (CVPixelBuffer buffer)
		{
			if (FillCallBack is null)
				throw new InvalidOperationException ($"The callback is null.");
			var rv = FillCallBack (buffer.GetCheckedHandle (), UserInfo);
			GC.KeepAlive (buffer);
			return rv != 0;
		}
#endif
	}

}
