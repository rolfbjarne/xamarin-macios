// Copyright 2014 Xamarin Inc. All rights reserved.
#if !__MACCATALYST__

#nullable enable

using CoreFoundation;

namespace CoreWlan {
	/// <summary>Represents a Wi-Fi network interface.</summary>
	public unsafe partial class CWInterface {
		/// <summary>Gets the channels supported by this wireless interface.</summary>
		public CWChannel []? SupportedWlanChannels {
			get {
				NSSet? channels = _SupportedWlanChannels;
				return channels?.ToArray<CWChannel> ();
			}
		}

		/// <summary>Gets the cached scan results from the last network scan.</summary>
		public CWNetwork []? CachedScanResults {
			get {
				NSSet? results = _CachedScanResults;
				return results?.ToArray<CWNetwork> ();
			}
		}

		/// <summary>Gets the names of all available Wi-Fi interfaces.</summary>
		public static string []? InterfaceNames {
			get {
				NSSet? interfaceNames = _InterfaceNames;
				if (interfaceNames is not null)
					return Array.ConvertAll (interfaceNames.ToArray<NSString> (), item => (string) item);
				return null;
			}
		}

		/// <param name="ssid">The ssid.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Scans for networks matching the specified SSID data.</summary>
		public CWNetwork []? ScanForNetworksWithSsid (NSData ssid, out NSError error)
		{
			NSSet? networks = _ScanForNetworksWithSsid (ssid, out error);
			return networks?.ToArray<CWNetwork> ();
		}

		/// <param name="networkName">The network name.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Scans for networks matching the specified network name.</summary>
		public CWNetwork []? ScanForNetworksWithName (string networkName, out NSError error)
		{
			NSSet? networks = _ScanForNetworksWithName (networkName, out error);
			return networks?.ToArray<CWNetwork> ();
		}

		/// <param name="ssid">The ssid.</param>
		///         <param name="includeHidden">The include hidden.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Scans for networks matching the specified SSID data, optionally including hidden networks.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public CWNetwork []? ScanForNetworksWithSsid (NSData ssid, bool includeHidden, out NSError? error)
		{
			NSSet? networks = _ScanForNetworksWithSsid (ssid, includeHidden, out error);
			return networks?.ToArray<CWNetwork> ();
		}

		/// <param name="networkName">The network name.</param>
		///         <param name="includeHidden">The include hidden.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>Scans for networks matching the specified network name, optionally including hidden networks.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public CWNetwork []? ScanForNetworksWithName (string networkName, bool includeHidden, out NSError? error)
		{
			NSSet? networks = _ScanForNetworksWithName (networkName, includeHidden, out error);
			return networks?.ToArray<CWNetwork> ();
		}

	}
}
#endif // !__MACCATALYST__
