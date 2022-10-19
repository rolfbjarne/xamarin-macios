#if !__MACCATALYST__
using System;
using Foundation;

using System.Runtime.InteropServices;

using ObjCRuntime;

namespace AppKit {

	public partial class NSWorkspace {

#if NET
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("macos11.0")]
#if MONOMAC
		[Obsolete ("Starting with macos11.0 use 'NSWorkspace.OpenUrls' with completion handler.", DiagnosticId = "BI1234", UrlFormat = "https://github.com/xamarin/xamarin-macios/wiki/Obsolete")]
#endif
		[UnsupportedOSPlatform ("maccatalyst")]
#else
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use 'NSWorkspace.OpenUrls' with completion handler.")]
#endif
		public virtual bool OpenUrls (NSUrl [] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor, string [] identifiers)
		{
			// Ignore the passed in argument, because if you pass it in we will crash on cleanup.
			return _OpenUrls (urls, bundleIdentifier, options, descriptor, null);
		}

#if NET
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("macos11.0")]
#if MONOMAC
		[Obsolete ("Starting with macos11.0 use 'NSWorkspace.OpenUrls' with completion handler.", DiagnosticId = "BI1234", UrlFormat = "https://github.com/xamarin/xamarin-macios/wiki/Obsolete")]
#endif
		[UnsupportedOSPlatform ("maccatalyst")]
#else
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use 'NSWorkspace.OpenUrls' with completion handler.")]
#endif
		public virtual bool OpenUrls (NSUrl [] urls, string bundleIdentifier, NSWorkspaceLaunchOptions options, NSAppleEventDescriptor descriptor)
		{
			return _OpenUrls (urls, bundleIdentifier, options, descriptor, null);
		}

		[Advice ("Use 'NSWorkSpace.IconForContentType' instead.")]
		public virtual NSImage IconForFileType (string fileType)
		{
			var nsFileType = NSString.CreateNative (fileType);
			try {
				return IconForFileType (nsFileType);
			} finally {
				NSString.ReleaseNative (nsFileType);
			}
		}

		[Advice ("Use 'NSWorkSpace.IconForContentType' instead.")]
		public virtual NSImage IconForFileType (HfsTypeCode typeCode)
		{
			var nsFileType = GetNSFileType ((uint) typeCode);
			return IconForFileType (nsFileType);
		}

		[DllImport (Constants.FoundationLibrary)]
		extern static IntPtr NSFileTypeForHFSTypeCode (uint /* OSType = int32_t */ hfsFileTypeCode);

		private static IntPtr GetNSFileType (uint fourCcTypeCode)
		{
			return NSFileTypeForHFSTypeCode (fourCcTypeCode);
		}

#if !NET
		[Obsolete ("Use the overload that takes 'out NSError' instead.")]
		public virtual NSRunningApplication LaunchApplication (NSUrl url, NSWorkspaceLaunchOptions options, NSDictionary configuration, NSError error)
		{
			return LaunchApplication (url, options, configuration, out error);
		}
#endif
	}
}
#endif // !__MACCATALYST__
