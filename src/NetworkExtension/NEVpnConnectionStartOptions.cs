#nullable enable

namespace NetworkExtension {
	/// <summary>To be added.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos17.0")]
	public class NEVpnConnectionStartOptions : DictionaryContainer {

#if !COREBUILD
		/// <summary>To be added.</summary>
		public NEVpnConnectionStartOptions () : base (new NSMutableDictionary ()) { }
		/// <param name="dictionary">The dictionary.</param>
		///         <summary>To be added.</summary>
		public NEVpnConnectionStartOptions (NSDictionary dictionary) : base (dictionary) { }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public NSString? Username {
			get {
				return GetNSStringValue (NEVpnConnectionStartOptionInternal.Username);
			}
			set {
				SetStringValue (NEVpnConnectionStartOptionInternal.Username, value);
			}
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
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
