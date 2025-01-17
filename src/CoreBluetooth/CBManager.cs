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
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 13.0 and later, 'maccatalyst' 12.2 and later. 'CBManager._SAuthorization' is only supported on: 'ios' 13.1 and later, 'maccatalyst' 13.1 and later.
					return _SAuthorization;
#pragma warning restore CA1416
				} else {
					// in iOS 13.0 this was, shortly (deprecated in 13.1), an instance property
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 13.0 and later, 'maccatalyst' 12.2 and later. 'CBManager._IAuthorization' is only supported on: 'maccatalyst' 13.0 and later.
					return new CBCentralManager ()._IAuthorization;
#pragma warning restore CA1416
				}
			}
		}
	}
}
#endif
