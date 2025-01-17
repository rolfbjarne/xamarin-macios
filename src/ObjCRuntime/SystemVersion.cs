#nullable enable

using System;
using System.Runtime.InteropServices;

using Foundation;

#if !COREBUILD
namespace ObjCRuntime {
	internal static class SystemVersion {
#if __MACOS__
#if NET
		// NSProcessInfo.ProcessInfo.OperatingSystemVersion is only available
		// in macOS 10.10, which means we can only use it in .NET (we support
		// macOS 10.14+), and not legacy (where we support macOS 10.9+)
		static NSOperatingSystemVersion? osx_version;
		internal static bool CheckmacOS (int major, int minor)
		{
			if (osx_version is null)
				osx_version = NSProcessInfo.ProcessInfo.OperatingSystemVersion;

			var osx_major = osx_version.Value.Major;
			var osx_minor = osx_version.Value.Minor;
			return osx_major > major || (osx_major == major && osx_minor >= minor);
		}
#else
		const int sys1 = 1937339185;
		const int sys2 = 1937339186;

		// Deprecated in OSX 10.8 - but no good alternative is (yet) available
#if NET
		[SupportedOSPlatform ("macos12.0")]
		[ObsoletedOSPlatform ("macos10.8")]
#else
		[Deprecated (PlatformName.MacOSX, 10, 8)]
#endif
		[DllImport ("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
		static extern int Gestalt (int selector, out int result);

		static int osx_major, osx_minor;

		internal static bool CheckmacOS (int major, int minor)
		{
			if (osx_major == 0) {
				Gestalt (sys1, out osx_major);
				Gestalt (sys2, out osx_minor);
			}
			return osx_major > major || (osx_major == major && osx_minor >= minor);
		}
#endif // NET
#elif __IOS__ || __MACCATALYST__ || __TVOS__
		// These three can be used interchangeably, the OS versions are the same.
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static bool CheckiOS (int major, int minor)
		{
			return UIKit.UIDevice.CurrentDevice.CheckSystemVersion (major, minor);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static bool ChecktvOS (int major, int minor)
		{
			return UIKit.UIDevice.CurrentDevice.CheckSystemVersion (major, minor);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static bool CheckMacCatalyst (int major, int minor)
		{
			return UIKit.UIDevice.CurrentDevice.CheckSystemVersion (major, minor);
		}
#else
#error Unknown platform
#endif

		[SupportedOSPlatformGuard ("ios13.0")]
		[SupportedOSPlatformGuard ("maccatalyst")]
		[SupportedOSPlatformGuard ("macos")]
		[SupportedOSPlatformGuard ("tvos13.0")]
		internal static bool IsAtLeastXcode11 {
			get {
				if (is_at_least_xcode_11 is null) {
#if __MACOS__
					is_at_least_xcode_11 = true;
#elif __MACCATALYST__
					is_at_least_xcode_11 = true;
#elif __IOS__
					is_at_least_xcode_11 = OperatingSystem.IsIOSVersionAtLeast (13, 0);
#elif __TVOS__
					is_at_least_xcode_11 = OperatingSystem.IsTvOSVersionAtLeast (13, 0);
#else
#error Unknown platform
#endif
				}
				return is_at_least_xcode_11.Value;
			}
		}
		static bool? is_at_least_xcode_11;

		[SupportedOSPlatformGuard ("ios15.0")]
		[SupportedOSPlatformGuard ("maccatalyst15.0")]
		[SupportedOSPlatformGuard ("macos12.0")]
		[SupportedOSPlatformGuard ("tvos15.0")]
		internal static bool IsAtLeastXcode13 {
			get {
				if (is_at_least_xcode_13 is null) {
#if __MACOS__
					is_at_least_xcode_13 = true;
#elif __MACCATALYST__
					is_at_least_xcode_13 = OperatingSystem.IsMacCatalystVersionAtLeast (15, 0);
#elif __IOS__
					is_at_least_xcode_13 = OperatingSystem.IsIOSVersionAtLeast (15, 0);
#elif __TVOS__
					is_at_least_xcode_13 = OperatingSystem.IsTvOSVersionAtLeast (15, 0);
#else
#error Unknown platform
#endif
				}
				return is_at_least_xcode_13.Value;
			}
		}
		static bool? is_at_least_xcode_13;

		[SupportedOSPlatformGuard ("ios17.0")]
		[SupportedOSPlatformGuard ("maccatalyst17.0")]
		[SupportedOSPlatformGuard ("macos14.0")]
		[SupportedOSPlatformGuard ("tvos17.0")]
		internal static bool IsAtLeastXcode15 {
			get {
				if (is_at_least_xcode_15 is null) {
#if __MACOS__
					is_at_least_xcode_15 = OperatingSystem.IsMacOSVersionAtLeast (14, 0);
#elif __MACCATALYST__
					is_at_least_xcode_15 = OperatingSystem.IsMacCatalystVersionAtLeast (17, 0);
#elif __IOS__
					is_at_least_xcode_15 = OperatingSystem.IsIOSVersionAtLeast (17, 0);
#elif __TVOS__
					is_at_least_xcode_15 = OperatingSystem.IsTvOSVersionAtLeast (17, 0);
#else
#error Unknown platform
#endif
				}
				return is_at_least_xcode_15.Value;
			}
		}
		static bool? is_at_least_xcode_15;

		[SupportedOSPlatformGuard ("ios18.0")]
		[SupportedOSPlatformGuard ("maccatalyst18.0")]
		[SupportedOSPlatformGuard ("macos15.0")]
		[SupportedOSPlatformGuard ("tvos18.0")]
		internal static bool IsAtLeastXcode16 {
			get {
				if (is_at_least_xcode_16 is null) {
#if __MACOS__
					is_at_least_xcode_16 = OperatingSystem.IsMacOSVersionAtLeast (15, 0);
#elif __MACCATALYST__
					is_at_least_xcode_16 = OperatingSystem.IsMacCatalystVersionAtLeast (18, 0);
#elif __IOS__
					is_at_least_xcode_16 = OperatingSystem.IsIOSVersionAtLeast (18, 0);
#elif __TVOS__
					is_at_least_xcode_16 = OperatingSystem.IsTvOSVersionAtLeast (18, 0);
#else
#error Unknown platform
#endif
				}
				return is_at_least_xcode_16.Value;
			}
		}
		static bool? is_at_least_xcode_16;
	}
}
#endif
