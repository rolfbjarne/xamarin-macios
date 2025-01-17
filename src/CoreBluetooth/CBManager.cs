#if IOS
using System;
using ObjCRuntime;

#nullable enable

namespace CoreBluetooth {
	public partial class CBManager {

		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public static CBManagerAuthorization Authorization {
			get {
				// in iOS 13.1 / Watch 6.1 this is a static property, like other [tv|mac]OS
				if (SystemVersion.CheckiOS (13, 1)) {
					return _SAuthorization;
				} else {
					// in iOS 13.0 this was, shortly (deprecated in 13.1), an instance property
					return new CBCentralManager ()._IAuthorization;
				}
			}
		}
	}
}
#endif
