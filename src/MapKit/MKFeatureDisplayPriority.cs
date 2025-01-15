using System;
using ObjCRuntime;

#nullable enable

namespace MapKit {

#if NET
	[SupportedOSPlatform ("tvos12.2")]
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("maccatalyst15.0")]
#endif
	// .net does not allow float-based enumerations
	public static class MKFeatureDisplayPriority {
		public const float Required = 1000f;
		public const float DefaultHigh = 750f;
		public const float DefaultLow = 250f;
	}
}
