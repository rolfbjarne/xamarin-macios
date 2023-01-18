using System;
using Foundation;
using ObjCRuntime;

namespace NS {
	// [Introduced (PlatformName.iOS, 9, 0)]
	// [Introduced (PlatformName.TvOS, 9, 0)]
	// [Introduced (PlatformName.MacOSX, 10, 15)]
	// [BaseType (typeof (NSObject))]
	// [DisableDefaultCtor]
	// public interface ISomething {
	// 	[NoTV]
	// 	[Introduced (PlatformName.iOS, 14, 0)]
	// 	[Introduced (PlatformName.MacCatalyst, 14, 0)]
	// 	[Export ("microphoneEnabled", ArgumentSemantic.Assign)]
	// 	bool MicrophoneEnabled {
	// 		[Bind ("isMicrophoneEnabled")]
	// 		get;
	// 		[Introduced (PlatformName.iOS, 14, 0)]
	// 		[Introduced (PlatformName.MacCatalyst, 14, 0)]
	// 		set;
	// 	}
	// }


	[Introduced (PlatformName.iOS, 9, 0)]
	[Introduced (PlatformName.TvOS, 10, 0)]
	[Introduced (PlatformName.MacOSX, 11, 0)]
	[Introduced (PlatformName.MacCatalyst, 13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	[Sealed]
	interface ISomething {
		[NoTV]
		[Introduced (PlatformName.MacCatalyst, 13, 1)]
		[Export ("microphoneEnabled", ArgumentSemantic.Assign)]
		bool MicrophoneEnabled {
			[Bind ("isMicrophoneEnabled")]
			get;
			[Introduced (PlatformName.iOS, 10, 0)]
			[Introduced (PlatformName.MacCatalyst, 13, 1)]
			set;
		}
	}
}
