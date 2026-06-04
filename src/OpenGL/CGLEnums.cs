//
// Author: Kenneth J. Pouncey
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

#nullable enable

namespace OpenGL {
	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[SupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' Framework instead.")]
	public enum CGLErrorCode : uint {
		/// <summary>To be added.</summary>
		NoError = 0,        /* no error */
		/// <summary>Indicates bad attribute.</summary>
		BadAttribute = 10000,   /* invalid pixel format attribute  */
		/// <summary>Indicates bad property.</summary>
		BadProperty = 10001,    /* invalid renderer property       */
		/// <summary>Indicates bad pixel format.</summary>
		BadPixelFormat = 10002, /* invalid pixel format            */
		/// <summary>Indicates bad renderer info.</summary>
		BadRendererInfo = 10003,    /* invalid renderer info           */
		/// <summary>Indicates bad context.</summary>
		BadContext = 10004, /* invalid context                 */
		/// <summary>Indicates bad drawable.</summary>
		BadDrawable = 10005,    /* invalid drawable                */
		/// <summary>Indicates bad display.</summary>
		BadDisplay = 10006, /* invalid graphics device         */
		/// <summary>Indicates bad state.</summary>
		BadState = 10007,   /* invalid context state           */
		/// <summary>Indicates bad value.</summary>
		BadValue = 10008,   /* invalid numerical value         */
		/// <summary>Indicates bad match.</summary>
		BadMatch = 10009,   /* invalid share context           */
		/// <summary>Indicates bad enumeration.</summary>
		BadEnumeration = 10010, /* invalid enumerant               */
		/// <summary>Indicates bad off screen.</summary>
		BadOffScreen = 10011,   /* invalid offscreen drawable      */
		/// <summary>Indicates bad full screen.</summary>
		BadFullScreen = 10012,  /* invalid offscreen drawable      */
		/// <summary>Indicates bad window.</summary>
		BadWindow = 10013,  /* invalid window                  */
		/// <summary>Indicates bad address.</summary>
		BadAddress = 10014, /* invalid pointer                 */
		/// <summary>Indicates bad code module.</summary>
		BadCodeModule = 10015,  /* invalid code module             */
		/// <summary>Indicates bad alloc.</summary>
		BadAlloc = 10016,   /* invalid memory allocation       */
		/// <summary>Indicates bad connection.</summary>
		BadConnection = 10017,  /* invalid CoreGraphics connection */

	}

	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[SupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' Framework instead.")]
	public enum CGLPixelFormatAttribute : uint {
		/// <summary>To be added.</summary>
		AllRenderers = 1,
		/// <summary>Indicates double buffer.</summary>
		DoubleBuffer = 5,
		/// <summary>Indicates stereo.</summary>
		Stereo = 6,
		/// <summary>Indicates aux buffers.</summary>
		AuxBuffers = 7,
		/// <summary>Indicates color size.</summary>
		ColorSize = 8,
		/// <summary>Indicates alpha size.</summary>
		AlphaSize = 11,
		/// <summary>Indicates depth size.</summary>
		DepthSize = 12,
		/// <summary>Indicates stencil size.</summary>
		StencilSize = 13,
		/// <summary>Indicates accum size.</summary>
		AccumSize = 14,
		/// <summary>Indicates minimum policy.</summary>
		MinimumPolicy = 51,
		/// <summary>Indicates maximum policy.</summary>
		MaximumPolicy = 52,
		/// <summary>Indicates off screen.</summary>
		OffScreen = 53,
		/// <summary>Indicates full screen.</summary>
		FullScreen = 54,
		/// <summary>Indicates sample buffers.</summary>
		SampleBuffers = 55,
		/// <summary>Indicates samples.</summary>
		Samples = 56,
		/// <summary>Indicates aux depth stencil.</summary>
		AuxDepthStencil = 57,
		/// <summary>Indicates color float.</summary>
		ColorFloat = 58,
		/// <summary>Indicates multisample.</summary>
		Multisample = 59,
		/// <summary>Indicates supersample.</summary>
		Supersample = 60,
		/// <summary>Indicates sample alpha.</summary>
		SampleAlpha = 61,
		/// <summary>Indicates renderer i d.</summary>
		RendererID = 70,
		/// <summary>Indicates single renderer.</summary>
		SingleRenderer = 71,
		/// <summary>Indicates no recovery.</summary>
		NoRecovery = 72,
		/// <summary>Indicates accelerated.</summary>
		Accelerated = 73,
		/// <summary>Indicates closest policy.</summary>
		ClosestPolicy = 74,
		/// <summary>Indicates robust.</summary>
		Robust = 75,
		/// <summary>Indicates backing store.</summary>
		BackingStore = 76,
		/// <summary>Indicates m p safe.</summary>
		MPSafe = 78,
		/// <summary>Indicates window.</summary>
		Window = 80,
		/// <summary>Indicates multi screen.</summary>
		MultiScreen = 81,
		/// <summary>Indicates compliant.</summary>
		Compliant = 83,
		/// <summary>Indicates screen mask.</summary>
		ScreenMask = 84,
		/// <summary>Indicates pixel buffer.</summary>
		PixelBuffer = 90,
		/// <summary>Indicates remote pixel buffer.</summary>
		RemotePixelBuffer = 91,
		/// <summary>Indicates allow offline renderers.</summary>
		AllowOfflineRenderers = 96,
		/// <summary>Indicates accelerated compute.</summary>
		AcceleratedCompute = 97,
		/// <summary>Indicates virtual screen count.</summary>
		VirtualScreenCount = 128,
	}

}
