using System;
using System.Runtime.InteropServices;

using ObjCRuntime;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using Foundation;

namespace MediaAccessibility {

	[TV (13,0), Mac (10,15), iOS (13,0)]
	public static partial class MAImageCaptioning {

		[DllImport (Constants.MediaAccessibilityLibrary)]
		// __attribute__((cf_returns_retained))
		static extern /* CFStringRef _Nullable */ IntPtr MAImageCaptioningCopyCaption (/* CFURLRef _Nonnull */ IntPtr url, /* CFErrorRef _Nullable * */ out IntPtr error);

		static public string GetCaption (NSUrl url, out NSError error)
		{
			if (url == null)
				throw new ArgumentNullException (nameof (url));

			var result = MAImageCaptioningCopyCaption (url.Handle, out var e);
			error = e == IntPtr.Zero ? null : new NSError (e);
			return CFString.FetchString (result, releaseHandle: true);
		}

		[DllImport (Constants.MediaAccessibilityLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		static extern bool MAImageCaptioningSetCaption (/* CFURLRef _Nonnull */ IntPtr url, /* CFStringRef _Nullable */ IntPtr @string, /* CFErrorRef _Nullable * */ out IntPtr error);

		static public bool SetCaption (NSUrl url, string @string, out NSError error)
		{
			if (url == null)
				throw new ArgumentNullException (nameof (url));

			var s = NSString.CreateNative (@string);
			try {
				var result = MAImageCaptioningSetCaption (url.Handle, s, out var e);
				error = e == IntPtr.Zero ? null : new NSError (e);
				return result;
			} finally {
				NSString.ReleaseNative (s);
			}
		}

		[DllImport (Constants.MediaAccessibilityLibrary)]
		// __attribute__((cf_returns_retained))
		static extern /* CFStringRef _Nonnull */ IntPtr MAImageCaptioningCopyMetadataTagPath ();

		static public string GetMetadataTagPath ()
		{
			return CFString.FetchString (MAImageCaptioningCopyMetadataTagPath (), releaseHandle: true);
		}
	}
}
