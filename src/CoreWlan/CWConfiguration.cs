// Copyright 2014 Xamarin Inc. All rights reserved.
#if !__MACCATALYST__

#nullable enable

using CoreFoundation;

namespace CoreWlan {
	/// <summary>Represents a Wi-Fi network configuration.</summary>
	public unsafe partial class CWConfiguration {
		/// <summary>Gets the network profiles associated with this configuration.</summary>
		public CWNetworkProfile []? NetworkProfiles {
			get {
				NSOrderedSet profiles = _NetworkProfiles;
				return profiles?.ToArray<CWNetworkProfile> ();
			}
		}
	}
}
#endif
