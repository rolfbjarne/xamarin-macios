//
// Authors:
//   Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014 Xamarin Inc
//

#nullable enable

#if !MONOMAC

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

using ObjCRuntime;
using Foundation;

namespace ImageIO {

	public partial class CGImageSource {

		// CGImageSource.h
		[DllImport (Constants.ImageIOLibrary)]
		extern static /* CGImageMetadataRef __nullable */ IntPtr CGImageSourceCopyMetadataAtIndex (
			/* CGImageSourceRef __nonnull */ IntPtr isrc, /* size_t */ nint idx,
			/* CFDictionaryRef __nullable */ IntPtr options);

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[UnsupportedOSPlatform ("macos")]
#endif
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CGImageMetadata? CopyMetadata (nint index, NSDictionary? options)
		{
			var result = CGImageSourceCopyMetadataAtIndex (Handle, index, options.GetHandle ());
			return (result == IntPtr.Zero) ? null : new CGImageMetadata (result, true);
		}

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[UnsupportedOSPlatform ("macos")]
#endif
		public CGImageMetadata? CopyMetadata (nint index, CGImageOptions? options)
		{
			using var o = options?.ToDictionary ();
			return CopyMetadata (index, o);
		}

		// CGImageSource.h
#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[UnsupportedOSPlatform ("macos")]
#endif
		[DllImport (Constants.ImageIOLibrary)]
		extern static void CGImageSourceRemoveCacheAtIndex (/* CGImageSourceRef __nonnull */ IntPtr isrc,
			/* size_t */ nint index);

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[UnsupportedOSPlatform ("macos")]
#endif
		public void RemoveCache (nint index)
		{
			CGImageSourceRemoveCacheAtIndex (Handle, index);
		}
	}
}

#endif // !MONOMAC
