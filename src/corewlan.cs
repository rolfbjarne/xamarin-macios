// corewlan.cs: bindings for CoreWLAN
//
// Author:
//   Ashok Gelal, Chris Hamons
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using CoreFoundation;
using Security;

namespace CoreWlan {

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWChannel : NSCoding, NSSecureCoding, NSCopying {
		/// <summary>Gets the channel number.</summary>
		[Export ("channelNumber")]
		nint ChannelNumber { get; }

		/// <summary>Gets the channel band.</summary>
		[Export ("channelWidth")]
		CWChannelWidth ChannelWidth { get; }

		/// <summary>Gets the channel width.</summary>
		[Export ("channelBand")]
		CWChannelBand ChannelBand { get; }

		/// <param name="channel">The channel to compare with.</param>
		/// <summary>Determines whether this channel is equal to the specified channel.</summary>
		/// <returns><see langword="true" /> if the channels are equal; otherwise, <see langword="false" />.</returns>
		[Export ("isEqualToChannel:")]
		bool IsEqualToChannel (CWChannel channel);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWConfiguration : NSSecureCoding, NSMutableCopying {
		[Export ("networkProfiles", ArgumentSemantic.Copy)]
		[Internal]
		NSOrderedSet _NetworkProfiles { get; }

		/// <summary>Gets the network name (SSID).</summary>
		[Export ("requireAdministratorForAssociation", ArgumentSemantic.Assign)]
		bool RequireAdministratorForAssociation { get; }

		/// <summary>Gets the SSID data.</summary>
		[Export ("requireAdministratorForPower", ArgumentSemantic.Assign)]
		bool RequireAdministratorForPower { get; }

		/// <summary>Gets the BSSID.</summary>
		[Export ("requireAdministratorForIBSSMode", ArgumentSemantic.Assign)]
		bool RequireAdministratorForIbssMode { get; }

		/// <summary>Gets the WLAN channel.</summary>
		[Export ("rememberJoinedNetworks", ArgumentSemantic.Assign)]
		bool RememberJoinedNetworks { get; }

		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (CWConfiguration configuration);

		/// <param name="configuration">The configuration to initialize with.</param>
		/// <summary>Creates a mutable network profile from the specified configuration.</summary>
		/// <returns>A new mutable network profile.</returns>
		[Export ("isEqualToConfiguration:")]
		bool IsEqualToConfiguration (CWConfiguration configuration);

		/// <summary>Creates a new mutable network profile.</summary>
		/// <returns>A new mutable network profile.</returns>
		[Static]
		[Export ("configuration")]
		CWConfiguration Create ();

		[Static]
		[Export ("configurationWithConfiguration:")]
		CWConfiguration Create (CWConfiguration configuration);
	}

	[NoMacCatalyst]
	[BaseType (typeof (CWConfiguration))]
	interface CWMutableConfiguration {

		[Export ("networkProfiles", ArgumentSemantic.Copy)]
		NSOrderedSet<CWNetworkProfile> NetworkProfiles { get; set; }

		[Export ("requireAdministratorForAssociation")]
		bool RequireAdministratorForAssociation { get; set; }

		/// <summary>Gets or sets whether the network requires a password.</summary>
		[Export ("requireAdministratorForPower", ArgumentSemantic.Assign)]
		bool RequireAdministratorForPower { get; set; }

		/// <summary>Gets or sets the SSID data.</summary>
		[Deprecated (PlatformName.MacOSX, 11, 0)]
		[Export ("requireAdministratorForIBSSMode", ArgumentSemantic.Assign)]
		bool RequireAdministratorForIbssMode { get; set; }

		/// <summary>Gets or sets the security type.</summary>
		[Export ("rememberJoinedNetworks", ArgumentSemantic.Assign)]
		bool RememberJoinedNetworks { get; set; }
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWInterface {
		/// <summary>Gets the network name (SSID).</summary>
		[Export ("powerOn", ArgumentSemantic.Assign)]
		bool PowerOn { get; }

		/// <summary>Gets the SSID data.</summary>
		[NullAllowed]
		[Export ("interfaceName", ArgumentSemantic.Copy)]
		string InterfaceName { get; }

		[NullAllowed]
		[Export ("supportedWLANChannels")]
		[Internal]
		NSSet _SupportedWlanChannels { get; }

		/// <summary>Gets the country code.</summary>
		[NullAllowed]
		[Export ("wlanChannel")]
		CWChannel WlanChannel { get; }

		/// <summary>Gets the noise measurement in dBm.</summary>
		[Export ("activePHYMode")]
		CWPhyMode ActivePHYMode { get; }

		/// <summary>Gets the received signal strength indicator (RSSI) in dBm.</summary>
		[NullAllowed]
		[Export ("ssid")]
		string Ssid { get; }

		/// <summary>Gets the security type of the network.</summary>
		[NullAllowed]
		[Export ("ssidData")]
		NSData SsidData { get; }

		/// <summary>Gets the beacon interval.</summary>
		[NullAllowed]
		[Export ("bssid")]
		string Bssid { get; }

		/// <summary>Gets whether the network is an IBSS (ad-hoc) network.</summary>
		[Export ("rssiValue")]
		nint RssiValue { get; }

		/// <summary>Gets the BSSID.</summary>
		[Export ("noiseMeasurement")]
		nint NoiseMeasurement { get; }

		/// <summary>Gets the information element data.</summary>
		[Export ("security")]
		CWSecurity Security { get; }

		/// <summary>Gets the WLAN channel.</summary>
		[Export ("transmitRate")]
		double TransmitRate { get; }

		/// <summary>Gets or sets whether the interface power is on.</summary>
		[NullAllowed]
		[Export ("countryCode")]
		string CountryCode { get; }

		/// <summary>Gets the name of the Wi-Fi interface.</summary>
		[Export ("interfaceMode")]
		CWInterfaceMode InterfaceMode { get; }

		/// <summary>Gets the supported WLAN channels.</summary>
		[Export ("transmitPower")]
		nint TransmitPower { get; }

		/// <summary>Gets the active PHY mode.</summary>
		[NullAllowed]
		[Export ("hardwareAddress")]
		string HardwareAddress { get; }

		/// <summary>Gets the current RSSI measurement.</summary>
		[Export ("deviceAttached", ArgumentSemantic.Assign)]
		bool DeviceAttached { get; }

		/// <summary>Gets the current noise measurement.</summary>
		[Export ("serviceActive")]
		bool ServiceActive { get; }

		[NullAllowed]
		[Export ("cachedScanResults")]
		[Internal]
		NSSet _CachedScanResults { get; }

		/// <summary>Gets the current transmit rate in Mbps.</summary>
		[NullAllowed]
		[Export ("configuration")]
		CWConfiguration Configuration { get; }

		[NullAllowed]
		[Static]
		[Export ("interfaceNames")]
		[Internal]
		NSSet _InterfaceNames { get; }

		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use 'CWWiFiClient.FromName' instead.")]
		[Export ("initWithInterfaceName:")]
		NativeHandle Constructor ([NullAllowed] string name);

		/// <param name="power">Whether to power on or off.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Sets the power state of the Wi-Fi interface.</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		[Export ("setPower:error:")]
		bool SetPower (bool power, out NSError error);

		/// <param name="channel">The channel to set.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Sets the WLAN channel for the interface.</summary>
		/// <returns><see langword="true" /> if the change was successful; otherwise, <see langword="false" />.</returns>
		[Export ("setWLANChannel:error:")]
		bool SetWlanChannel (CWChannel channel, out NSError error);

		/// <param name="key">The WEP key data.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Sets the WEP key for the interface.</summary>
		/// <returns><see langword="true" /> if the key was set; otherwise, <see langword="false" />.</returns>
		[Export ("setPairwiseMasterKey:error:")]
		bool SetPairwiseMasterKey ([NullAllowed] NSData key, out NSError error);

		[Export ("setWEPKey:flags:index:error:")]
		bool SetWEPKey ([NullAllowed] NSData key, CWCipherKeyFlags flags, nint index, out NSError error);

		[return: NullAllowed]
		[Export ("scanForNetworksWithSSID:error:")]
		[Internal]
		NSSet _ScanForNetworksWithSsid ([NullAllowed] NSData ssid, out NSError error);

		[return: NullAllowed]
		[Export ("scanForNetworksWithName:error:")]
		[Internal]
		NSSet _ScanForNetworksWithName ([NullAllowed] string networkName, out NSError error);

		/// <param name="network">The network to associate with.</param>
		/// <param name="password">The password for the network.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Associates with the specified network using a password.</summary>
		/// <returns><see langword="true" /> if associated; otherwise, <see langword="false" />.</returns>
		[Export ("associateToNetwork:password:error:")]
		bool AssociateToNetwork (CWNetwork network, [NullAllowed] string password, out NSError error);

		/// <param name="network">The network to associate with.</param>
		/// <param name="identity">The identity for 802.1X authentication.</param>
		/// <param name="username">The username for authentication.</param>
		/// <param name="password">The password for authentication.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Disassociates from the current network.</summary>
		/// <returns><see langword="true" /> on success; otherwise, <see langword="false" />.</returns>
		[Export ("associateToEnterpriseNetwork:identity:username:password:error:")]
		bool AssociateToEnterpriseNetwork (CWNetwork network, [NullAllowed] SecIdentity identity, [NullAllowed] string username, [NullAllowed] string password, out NSError error);

		[Deprecated (PlatformName.MacOSX, 11, 0)]
		[Export ("startIBSSModeWithSSID:security:channel:password:error:")]
		bool StartIbssModeWithSsid (NSData ssidData, CWIbssModeSecurity security, nuint channel, [NullAllowed] string password, out NSError error);

		/// <summary>Gets the hardware address (MAC address) of the interface.</summary>
		[Export ("disassociate")]
		void Disassociate ();

		/// <param name="configuration">The configuration to commit.</param>
		/// <param name="authorization">The authorization reference.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Commits the specified configuration with authorization.</summary>
		/// <returns><see langword="true" /> if the configuration was committed; otherwise, <see langword="false" />.</returns>
		[Export ("commitConfiguration:authorization:error:")]
		bool CommitConfiguration (CWConfiguration configuration, [NullAllowed] NSObject authorization, out NSError error);

		[Export ("scanForNetworksWithSSID:includeHidden:error:")]
		[return: NullAllowed]
		[Internal]
		NSSet _ScanForNetworksWithSsid ([NullAllowed] NSData ssid, bool includeHidden, [NullAllowed] out NSError error);

		[Export ("scanForNetworksWithName:includeHidden:error:")]
		[return: NullAllowed]
		[Internal]
		NSSet _ScanForNetworksWithName ([NullAllowed] string networkName, bool includeHidden, [NullAllowed] out NSError error);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWNetwork : NSSecureCoding, NSCopying {
		/// <summary>Gets the SSID of the network profile.</summary>
		[NullAllowed]
		[Export ("ssid")]
		string Ssid { get; }

		/// <summary>Gets the SSID data of the network profile.</summary>
		[NullAllowed]
		[Export ("ssidData")]
		NSData SsidData { get; }

		/// <summary>Gets the security type.</summary>
		[NullAllowed]
		[Export ("bssid")]
		string Bssid { get; }

		/// <summary>Gets all network profiles.</summary>
		[NullAllowed]
		[Export ("wlanChannel")]
		CWChannel WlanChannel { get; }

		/// <summary>Gets the preferred network profiles in order.</summary>
		[Export ("rssiValue")]
		nint RssiValue { get; }

		/// <summary>Gets whether to remember joined networks.</summary>
		[Export ("noiseMeasurement")]
		nint NoiseMeasurement { get; }

		/// <summary>Gets whether to require administrator for associated networks.</summary>
		[NullAllowed]
		[Export ("informationElementData")]
		NSData InformationElementData { get; }

		/// <summary>Gets whether to require administrator for power changes.</summary>
		[NullAllowed]
		[Export ("countryCode")]
		string CountryCode { get; }

		/// <summary>Gets whether to require administrator for IBSS mode.</summary>
		[Export ("beaconInterval")]
		nint BeaconInterval { get; }

		/// <summary>Gets the enabled network interfaces.</summary>
		[Export ("ibss")]
		bool Ibss { get; }

		/// <param name="network">The network to check.</param>
		/// <summary>Determines whether a network profile is equal to the specified network.</summary>
		/// <returns><see langword="true" /> if equal; otherwise, <see langword="false" />.</returns>
		[Export ("isEqualToNetwork:")]
		bool IsEqualToNetwork (CWNetwork network);

		/// <param name="security">The security type to filter by.</param>
		/// <summary>Gets whether the profile is a member of the specified security type.</summary>
		/// <returns><see langword="true" /> if it is a member; otherwise, <see langword="false" />.</returns>
		[Export ("supportsSecurity:")]
		bool SupportsSecurity (CWSecurity security);

		/// <param name="phyMode">The PHY mode to filter by.</param>
		/// <summary>Gets whether the profile supports the specified PHY mode.</summary>
		/// <returns><see langword="true" /> if supported; otherwise, <see langword="false" />.</returns>
		[Export ("supportsPHYMode:")]
		bool SupportsPhyMode (CWPhyMode phyMode);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWNetworkProfile : NSCoding, NSSecureCoding, NSCopying, NSMutableCopying {
		/// <summary>Gets the SSID.</summary>
		[NullAllowed]
		[Export ("ssid", ArgumentSemantic.Copy)]
		string Ssid { get; }

		/// <summary>Gets the SSID data.</summary>
		[Export ("ssidData", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSData SsidData { get; }

		/// <summary>Gets the security type.</summary>
		[Export ("security", ArgumentSemantic.Assign)]
		CWSecurity Security { get; }

		/// <summary>Gets all network profiles.</summary>
		/// <returns>An array of network profiles.</returns>
		[Static]
		[Export ("networkProfile")]
		NSObject NetworkProfile ();

		/// <param name="networkProfile">The network profile to set.</param>
		/// <summary>Sets the preferred order for a network profile.</summary>
		
		[Export ("initWithNetworkProfile:")]
		NativeHandle Constructor (CWNetworkProfile networkProfile);

		/// <param name="networkProfile">The network profile to remove.</param>
		/// <summary>Removes the specified network profile.</summary>
		/// <returns><see langword="true" /> if removed; otherwise, <see langword="false" />.</returns>
		[Static]
		[Export ("networkProfileWithNetworkProfile:")]
		NSObject NetworkProfileWithNetworkProfile (CWNetworkProfile networkProfile);

		/// <param name="networkProfile">The network profile to add.</param>
		/// <summary>Adds the specified network profile.</summary>
		/// <returns><see langword="true" /> if added; otherwise, <see langword="false" />.</returns>
		[Export ("isEqualToNetworkProfile:")]
		bool IsEqualToNetworkProfile (CWNetworkProfile networkProfile);
	}

	[NoMacCatalyst]
	[BaseType (typeof (CWNetworkProfile))]
	interface CWMutableNetworkProfile : NSCoding, NSSecureCoding, NSCopying, NSMutableCopying {
		[NullAllowed]
		[Export ("ssidData", ArgumentSemantic.Copy)]
		NSData SsidData { get; set; }

		[Export ("security", ArgumentSemantic.Assign)]
		CWSecurity Security { get; set; }
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWWiFiClient {
		/// <summary>Gets all Wi-Fi interface names.</summary>
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		ICWEventDelegate Delegate { get; set; }

		/// <summary>Gets all available Wi-Fi interfaces.</summary>
		[Export ("interface")]
		[NullAllowed]
		CWInterface MainInterface { get; }

		/// <param name="name">The name of the interface.</param>
		/// <summary>Gets the Wi-Fi interface with the specified name.</summary>
		/// <returns>The Wi-Fi interface, or <see langword="null" />.</returns>
		[return: NullAllowed]
		[Export ("interfaceWithName:")]
		CWInterface FromName ([NullAllowed] string name);

		/// <summary>Gets the default Wi-Fi interface.</summary>
		[Export ("interfaces")]
		[NullAllowed]
		CWInterface [] Interfaces { get; }

		/// <summary>Gets the interfaces managed by this client.</summary>
		[Deprecated (PlatformName.MacOSX, 14, 0, message: "Use the 'GetInterfaceNames' instance method instead.")]
		[NullAllowed]
		[Export ("interfaceNames")]
		[Static]
		string [] InterfaceNames { get; }

		[Mac (14, 0)]
		[return: NullAllowed]
		[Export ("interfaceNames")]
		string [] GetInterfaceNames ();

		/// <summary>Gets or sets the delegate.</summary>
		[Export ("sharedWiFiClient")]
		[Static]
		CWWiFiClient SharedWiFiClient { get; }

		/// <param name="type">The event type to start monitoring.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Starts monitoring for the specified event type.</summary>
		/// <returns><see langword="true" /> on success; otherwise, <see langword="false" />.</returns>
		[Export ("startMonitoringEventWithType:error:")]
		bool StartMonitoringEvent (CWEventType type, out NSError error);

		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Stops monitoring all event types.</summary>
		/// <returns><see langword="true" /> on success; otherwise, <see langword="false" />.</returns>
		[Export ("stopMonitoringAllEventsAndReturnError:")]
		bool StopMonitoringAllEvents (out NSError error);

		/// <param name="type">The event type to stop monitoring.</param>
		/// <param name="error">On return, contains any error that occurred.</param>
		/// <summary>Stops monitoring the specified event type.</summary>
		/// <returns><see langword="true" /> on success; otherwise, <see langword="false" />.</returns>
		[Export ("stopMonitoringEventWithType:error:")]
		bool StopMonitoringEvent (CWEventType type, out NSError error);
	}

	interface ICWEventDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CWEventDelegate {
		/// <summary>Called when the power state of an interface changes.</summary>
		[Export ("clientConnectionInterrupted")]
		void ClientConnectionInterrupted ();

		/// <summary>Called when the SSID changes.</summary>
		[Export ("clientConnectionInvalidated")]
		void ClientConnectionInvalidated ();

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when the BSSID changes.</summary>
		[Export ("powerStateDidChangeForWiFiInterfaceWithName:")]
		void PowerStateDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when the country code changes.</summary>
		[Export ("ssidDidChangeForWiFiInterfaceWithName:")]
		void SsidDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when the interface mode changes.</summary>
		[Export ("bssidDidChangeForWiFiInterfaceWithName:")]
		void BssidDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when the security type changes.</summary>
		[Export ("countryCodeDidChangeForWiFiInterfaceWithName:")]
		void CountryCodeDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when the scan cache is updated.</summary>
		[Export ("linkDidChangeForWiFiInterfaceWithName:")]
		void LinkDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <param name="rssi">The new RSSI value.</param>
		/// <param name="transmitRate">The new transmit rate.</param>
		/// <summary>Called when the link quality changes.</summary>
		[Export ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:")]
		void LinkQualityDidChangeForWiFi (string interfaceName, int rssi, double transmitRate);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when a virtual interface state changes.</summary>
		[Export ("modeDidChangeForWiFiInterfaceWithName:")]
		void ModeDidChangeForWiFi (string interfaceName);

		/// <param name="interfaceName">The name of the interface.</param>
		/// <summary>Called when a range report is available.</summary>
		[Export ("scanCacheUpdatedForWiFiInterfaceWithName:")]
		void ScanCacheUpdatedForWiFi (string interfaceName);
	}
}
