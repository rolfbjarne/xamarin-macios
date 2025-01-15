// 
// SecStatusCodeExtensions.cs
//
// Authors:
//	Alex Soto (alexsoto@microsoft.com)
// 
// Copyright 2018 Xamarin Inc.
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Foundation;

namespace Security {
#if NET
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("tvos12.2")]
#endif
	public static class SecStatusCodeExtensions {

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("macos12.0")]
#endif
		[DllImport (Constants.SecurityLibrary)]
		extern static /* CFStringRef */ IntPtr SecCopyErrorMessageString (
			/* OSStatus */ SecStatusCode status,
			/* void * */ IntPtr reserved); /* always null */

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("macos12.0")]
#endif
		public static string GetStatusDescription (this SecStatusCode status)
		{
			var ret = SecCopyErrorMessageString (status, IntPtr.Zero);
			return Runtime.GetNSObject<NSString> (ret, owns: true);
		}
	}
}
