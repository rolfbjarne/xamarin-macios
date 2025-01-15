//
// SCNJavaScript.cs: JSC bridge
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2014 Xamarin Inc. All rights reserved.
//

using System;
using System.Runtime.InteropServices;

using ObjCRuntime;
using JavaScriptCore;

#nullable enable

namespace SceneKit {
#if NET
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("tvos12.2")]
#endif
	public static class SCNJavaScript {
		[DllImport (Constants.SceneKitLibrary)]
		static extern void SCNExportJavaScriptModule (IntPtr context);

		public static void ExportModule (JSContext context)
		{
			if (context is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (context));

			SCNExportJavaScriptModule (context.Handle);
		}
	}
}
