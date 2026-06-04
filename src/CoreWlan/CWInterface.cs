// Copyright 2014 Xamarin Inc. All rights reserved.
#if !__MACCATALYST__

#nullable enable

using CoreFoundation;

namespace CoreWlan {
	/// <summary>To be added.</summary>
	public unsafe partial class CWInterface {
		/// <summary>To be added.</summary>
		public CWChannel []? SupportedWlanChannels {
			get {
				NSSet? channels = _SupportedWlanChannels;
				return channels?.ToArray<CWChannel> ();
			}
		}

		/// <summary>To be added.</summary>
		public CWNetwork []? CachedScanResults {
			get {
				NSSet? results = _CachedScanResults;
				return results?.ToArray<CWNetwork> ();
			}
		}

		/// <summary>To be added.</summary>
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
		///         <summary>To be added.</summary>
		public CWNetwork []? ScanForNetworksWithSsid (NSData ssid, out NSError error)
		{
			NSSet? networks = _ScanForNetworksWithSsid (ssid, out error);
			return networks?.ToArray<CWNetwork> ();
		}

		/// <param name="networkName">The network name.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>To be added.</summary>
		public CWNetwork []? ScanForNetworksWithName (string networkName, out NSError error)
		{
			NSSet? networks = _ScanForNetworksWithName (networkName, out error);
			return networks?.ToArray<CWNetwork> ();
		}

		/// <param name="ssid">The ssid.</param>
		///         <param name="includeHidden">The include hidden.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>To be added.</summary>
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
		///         <summary>To be added.</summary>
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
