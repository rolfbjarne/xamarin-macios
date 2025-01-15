#nullable enable

using System.Runtime.Versioning;

using Foundation;

namespace NetworkExtension {

#if NET
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("tvos17.0")]
#endif
	public class NEVpnConnectionStartOptions : DictionaryContainer {

#if !COREBUILD
		public NEVpnConnectionStartOptions () : base (new NSMutableDictionary ()) { }
		public NEVpnConnectionStartOptions (NSDictionary dictionary) : base (dictionary) { }

		public NSString? Username {
			get {
				return GetNSStringValue (NEVpnConnectionStartOptionInternal.Username);
			}
			set {
				SetStringValue (NEVpnConnectionStartOptionInternal.Username, value);
			}
		}

		public NSString? Password {
			get {
				return GetNSStringValue (NEVpnConnectionStartOptionInternal.Password);
			}
			set {
				SetStringValue (NEVpnConnectionStartOptionInternal.Password, value);
			}
		}
#endif
	}
}
