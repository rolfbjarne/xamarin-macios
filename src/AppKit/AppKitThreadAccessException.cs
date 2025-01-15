using System;
using System.Runtime.Versioning;

#nullable enable

namespace AppKit {
#if NET
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("maccatalyst15.0")]
#endif
	public class AppKitThreadAccessException : Exception {
		public AppKitThreadAccessException () : base ("AppKit Consistency error: you are calling a method that can only be invoked from the UI thread.")
		{
		}
	}
}
