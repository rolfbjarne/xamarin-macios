#nullable enable

namespace NetworkExtension {
	/// <summary>Provides options for starting a VPN connection.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos17.0")]
	public class NEVpnConnectionStartOptions : DictionaryContainer {

#if !COREBUILD
		/// <summary>Creates a new <see cref="NEVpnConnectionStartOptions" /> instance.</summary>
		public NEVpnConnectionStartOptions () : base (new NSMutableDictionary ()) { }
		/// <param name="dictionary">The dictionary.</param>
		///         <summary>Creates a new <see cref="NEVpnConnectionStartOptions" /> instance.</summary>
		public NEVpnConnectionStartOptions (NSDictionary dictionary) : base (dictionary) { }

		/// <summary>Gets or sets the username.</summary>
		public NSString? Username {
			get {
				return GetNSStringValue (NEVpnConnectionStartOptionInternal.Username);
			}
			set {
				SetStringValue (NEVpnConnectionStartOptionInternal.Username, value);
			}
		}

		/// <summary>Gets or sets the password.</summary>
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
