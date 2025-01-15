//
// CVMetalTexture.cs: Implementation of the CVMetalTexture class
//
// Author:
//   Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2012-2015 Xamarin Inc
//
//

using System;
using System.Runtime.InteropServices;

using ObjCRuntime;
using CoreFoundation;
using Foundation;
using Metal;

#if !NET
using NativeHandle = System.IntPtr;
#endif

#nullable enable

namespace CoreVideo {

#if NET
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("tvos12.2")]
#else
	[MacCatalyst (15, 0)]
#endif
	public class CVMetalTexture : NativeObject {
		[Preserve (Conditional = true)]
		internal CVMetalTexture (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		[DllImport (Constants.CoreVideoLibrary)]
		extern static /* id<MTLTexture> __nullable */ IntPtr CVMetalTextureGetTexture (
			/* CVMetalTextureRef __nonnull */ IntPtr image);

		[DllImport (Constants.CoreVideoLibrary)]
		extern static /* Boolean */ byte CVMetalTextureIsFlipped (/* CVMetalTextureRef __nonnull */ IntPtr image);

		[DllImport (Constants.CoreVideoLibrary)]
		extern static void CVMetalTextureGetCleanTexCoords (/* CVMetalTextureRef __nonnull */ IntPtr image,
			/* float[2] */ IntPtr lowerLeft, /* float[2] */ IntPtr lowerRight, /* float[2] */ IntPtr upperRight,
			/* float[2] */ IntPtr upperLeft);

		public IMTLTexture? Texture {
			get {
				return Runtime.GetINativeObject<IMTLTexture> (CVMetalTextureGetTexture (Handle), owns: false);
			}
		}

		public bool IsFlipped {
			get {
				return CVMetalTextureIsFlipped (Handle) != 0;
			}
		}

		public void GetCleanTexCoords (out float [] lowerLeft, out float [] lowerRight, out float [] upperRight, out float [] upperLeft)
		{
			lowerLeft = new float [2];
			lowerRight = new float [2];
			upperRight = new float [2];
			upperLeft = new float [2];

			unsafe {
				fixed (float* ll = lowerLeft, lr = lowerRight, ur = upperRight, ul = upperLeft) {
					CVMetalTextureGetCleanTexCoords (Handle, (IntPtr) ll, (IntPtr) lr, (IntPtr) ur, (IntPtr) ul);
				}
			}
		}
	}
}
