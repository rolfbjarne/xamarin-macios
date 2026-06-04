// Copyright 2015 Xamarin Inc. All rights reserved.

#nullable enable

#if IOS || MONOMAC

namespace CoreSpotlight {

	public partial class CSSearchableItemAttributeSet {

		public INSSecureCoding? this [CSCustomAttributeKey key] {
			get {
				return ValueForCustomKey (key);
			}
			set {
				SetValue (value, key);
			}
		}

		// Manually deal with these properties until we get BindAs working
		/// <summary>Gets or sets the is user created.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public bool? IsUserCreated {
			get {
				return _IsUserCreated?.BoolValue;
			}
			set {
				_IsUserCreated = value.HasValue ? new NSNumber (value.Value) : null;
			}
		}

		/// <summary>Gets or sets the is user owned.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public bool? IsUserOwned {
			get {
				return _IsUserOwned?.BoolValue;
			}
			set {
				_IsUserOwned = value.HasValue ? new NSNumber (value.Value) : null;
			}
		}

		/// <summary>Gets or sets the is user curated.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public bool? IsUserCurated {
			get {
				return _IsUserCurated?.BoolValue;
			}
			set {
				_IsUserCurated = value.HasValue ? new NSNumber (value.Value) : null;
			}
		}
	}
}

#endif
