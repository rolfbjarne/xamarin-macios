#nullable enable

using System;
using ObjCRuntime;
using Foundation;

namespace HomeKit {

	partial class HMCharacteristic {
		public bool SupportsEventNotification {
			get {
				foreach (var p in Properties) {
					if (p == HMCharacteristicPropertyInternal.SupportsEventNotification)
						return true;
				}
				return false;
			}
		}

		public bool Readable {
			get {
				foreach (var p in Properties) {
					if (p == HMCharacteristicPropertyInternal.Readable)
						return true;
				}
				return false;
			}
		}

		public bool Writable {
			get {
				foreach (var p in Properties) {
					if (p == HMCharacteristicPropertyInternal.Writable)
						return true;
				}
				return false;
			}
		}

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		public bool Hidden {
			get {
				foreach (var p in Properties) {
					if (p == HMCharacteristicPropertyInternal.Hidden)
						return true;
				}
				return false;
			}
		}
	}
}
