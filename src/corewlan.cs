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
using Foundation;
using CoreFoundation;
using ObjCRuntime;
using Security;
using System;

#if !NET
using NativeHandle=System.IntPtr;
#endif

namespace CoreWlan {

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWChannel : NSCoding, NSSecureCoding, NSCopying {
		[Export ("channelNumber")]
		nint ChannelNumber { get; }
 
		[Export ("channelWidth")]
		CWChannelWidth ChannelWidth { get; }
 
		[Export ("channelBand")]
		CWChannelBand ChannelBand { get; }
 
		[Export ("isEqualToChannel:")]
		bool IsEqualToChannel (CWChannel channel);
	}

	[NoMacCatalyst]
	[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
	[BaseType (typeof (NSObject))]
	interface CW8021XProfile : NSCoding, NSCopying {
		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("userDefinedName", ArgumentSemantic.Copy)]
		string UserDefinedName { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("ssid", ArgumentSemantic.Copy)]
		string Ssid { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("username", ArgumentSemantic.Copy)]
		string Username { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("password", ArgumentSemantic.Copy)]
		string Password { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("alwaysPromptForPassword")]
		bool AlwaysPromptForPassword{ get; set; }

		[Static]
		[Export ("profile")]
		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
		CW8021XProfile Profile { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
		[Export ("isEqualToProfile:")]
		bool IsEqualToProfile (CW8021XProfile profile);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
		[Static]
		[Export ("allUser8021XProfiles")]
		CW8021XProfile[] AllUser8021XProfiles { get; }
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWConfiguration : NSSecureCoding, NSMutableCopying {

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("rememberedNetworks")]
		NSSet RememberedNetworks { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("preferredNetworks")]
		CWWirelessProfile[] PreferredNetworks { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("alwaysRememberNetworks")]
		bool AlwaysRememberNetworks { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("disconnectOnLogout")]
		bool DisconnectOnLogout { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("requireAdminForNetworkChange")]
		bool RequireAdminForNetworkChange { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("requireAdminForPowerChange")]
		bool RequireAdminForPowerChange { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("requireAdminForIBSSCreation")]
		bool RequireAdminForIBSSCreation { get; set; }

		[Export ("networkProfiles", ArgumentSemantic.Copy)]
		[Internal]
		NSOrderedSet _NetworkProfiles { get; }
 
		[Export ("requireAdministratorForAssociation", ArgumentSemantic.Assign)]
		bool RequireAdministratorForAssociation { get; }
 
		[Export ("requireAdministratorForPower", ArgumentSemantic.Assign)]
		bool RequireAdministratorForPower { get; }
 
		[Export ("requireAdministratorForIBSSMode", ArgumentSemantic.Assign)]
		bool RequireAdministratorForIbssMode { get; }
 
		[Export ("rememberJoinedNetworks", ArgumentSemantic.Assign)]
		bool RememberJoinedNetworks { get; }
 
		[Export ("initWithConfiguration:")]
		NativeHandle Constructor (CWConfiguration configuration);

		[Export ("isEqualToConfiguration:")]
		bool IsEqualToConfiguration (CWConfiguration configuration);

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

		[Export ("requireAdministratorForPower", ArgumentSemantic.Assign)]
		bool RequireAdministratorForPower { get; set; }

		[Deprecated (PlatformName.MacOSX, 11,0)]
		[Export ("requireAdministratorForIBSSMode", ArgumentSemantic.Assign)]
		bool RequireAdministratorForIbssMode { get; set; }

		[Export ("rememberJoinedNetworks", ArgumentSemantic.Assign)]
		bool RememberJoinedNetworks { get; set; }
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWInterface {
		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsWoW")]
		bool SupportsWow { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsWEP")]
		bool SupportsWep { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsAES_CCM")]
		bool SupportsAesCcm { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsIBSS")]
		bool SupportsIbss { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsTKIP")]
		bool SupportsTkip { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsPMGT")]
		bool SupportsPmgt { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsHostAP")]
		bool SupportsHostAP { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsMonitorMode")]
		bool SupportsMonitorMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsWPA")]
		bool SupportsWpa { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsWPA2")]
		bool SupportsWpa2 { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsWME")]
		bool SupportsWme { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsShortGI40MHz")]
		bool SupportsShortGI40MHz { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsShortGI20MHz")]
		bool SupportsShortGI20MHz { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportsTSN")]
		bool SupportsTsn { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("power")]
		bool Power { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("powerSave")]
		bool PowerSave { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("name")]
		string Name { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportedChannels")]
		NSNumber[] SupportedChannels { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("supportedPHYModes")]
		NSNumber[] SupportedPhyModes { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("channel")]
		NSNumber Channel { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("phyMode")]
		NSNumber PhyMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("bssidData")]
		NSData BssidData { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("rssi")]
		NSNumber Rssi { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("noise")]
		NSNumber Noise { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("txRate")]
		NSNumber TxRate { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("securityMode")]
		NSNumber SecurityMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("interfaceState")]
		NSNumber InterfaceState { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("opMode")]
		NSNumber OpMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("txPower")]
		NSNumber TxPower { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Static]
		[Export ("supportedInterfaces")]
		string[] SupportedInterfaces { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Static]
		[Export ("interface")]
		CWInterface MainInterface { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Static]
		[Export ("interfaceWithName:")]
		CWInterface FromName ([NullAllowed]string name);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("isEqualToInterface:")]
		bool IsEqualToInterface (CWInterface intface);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("setChannel:error:")]
		bool SetChannel (nuint channel, out NSError error);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("scanForNetworksWithParameters:error:")]
		CWNetwork[] ScanForNetworksWithParameters ([NullAllowed] NSDictionary parameters, out NSError error);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("associateToNetwork:parameters:error:")]
		bool AssociateToNetwork ([NullAllowed] CWNetwork network, [NullAllowed] NSDictionary parameters, out NSError error);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("enableIBSSWithParameters:error:")]
		bool EnableIBSSWithParameters ([NullAllowed] NSDictionary parameters, out NSError error);

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("commitConfiguration:error:")]
		bool CommitConfiguration (CWConfiguration config, out NSError error);

		[Export ("powerOn", ArgumentSemantic.Assign)]
		bool PowerOn { get; }
		 
		[NullAllowed]
		[Export ("interfaceName", ArgumentSemantic.Copy)]
		string InterfaceName { get; }
		 
		[NullAllowed]
		[Export ("supportedWLANChannels")]
		[Internal]
		NSSet _SupportedWlanChannels { get; }

		[NullAllowed]
		[Export ("wlanChannel")]
		CWChannel WlanChannel { get; }
		 
		[Export ("activePHYMode")]
		CWPhyMode ActivePHYMode { get; }
		 
		[NullAllowed]
		[Export ("ssid")]
		string Ssid { get; }
		 
		[NullAllowed]
		[Export ("ssidData")]
		NSData SsidData { get; }
		 
		[NullAllowed]
		[Export ("bssid")]
		string Bssid { get; }
		 
		[Export ("rssiValue")]
		nint RssiValue { get; }
		 
		[Export ("noiseMeasurement")]
		nint NoiseMeasurement { get; }
		 
		[Export ("security")]
		CWSecurity Security { get; }
		 
		[Export ("transmitRate")]
		double TransmitRate { get; }
		 
		[NullAllowed]
		[Export ("countryCode")]
		string CountryCode { get; }
		 
		[Export ("interfaceMode")]
		CWInterfaceMode InterfaceMode { get; }
		 
		[Export ("transmitPower")]
		nint TransmitPower { get; }
		 
		[NullAllowed]
		[Export ("hardwareAddress")]
		string HardwareAddress { get; }
		 
		[Export ("deviceAttached", ArgumentSemantic.Assign)]
		bool DeviceAttached { get; }
		 
		[Export ("serviceActive")]
		bool ServiceActive { get; }
		 
		[NullAllowed]
		[Export ("cachedScanResults")]
		[Internal]
		NSSet _CachedScanResults { get; }
		 
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
		NativeHandle Constructor ([NullAllowed]string name);
		 
		[Export ("setPower:error:")]
		bool SetPower (bool power, out NSError error);
		 
		[Export ("setWLANChannel:error:")]
		bool SetWlanChannel (CWChannel channel, out NSError error);
		 
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
		 
		[Export ("associateToNetwork:password:error:")]
		bool AssociateToNetwork (CWNetwork network, [NullAllowed] string password, out NSError error);
		 
		[Export ("associateToEnterpriseNetwork:identity:username:password:error:")]
		bool AssociateToEnterpriseNetwork (CWNetwork network, [NullAllowed] SecIdentity identity, [NullAllowed] string username, [NullAllowed]string password, out NSError error);
		 
		[Deprecated (PlatformName.MacOSX, 11,0)]
		[Export ("startIBSSModeWithSSID:security:channel:password:error:")]
		bool StartIbssModeWithSsid (NSData ssidData, CWIbssModeSecurity security, nuint channel, [NullAllowed] string password, out NSError error);
		 
		[Export ("disassociate")]
		void Disassociate ();
		 
		[Export ("commitConfiguration:authorization:error:")]
		bool CommitConfiguration (CWConfiguration configuration, [NullAllowed] NSObject authorization, out NSError error);

		[Mac (10,13)]
		[Export ("scanForNetworksWithSSID:includeHidden:error:")]
		[return: NullAllowed]
		[Internal]
		NSSet _ScanForNetworksWithSsid ([NullAllowed] NSData ssid, bool includeHidden, [NullAllowed] out NSError error);

		[Mac (10,13)]
		[Export ("scanForNetworksWithName:includeHidden:error:")]
		[return: NullAllowed]
		[Internal]
		NSSet _ScanForNetworksWithName ([NullAllowed] string networkName, bool includeHidden, [NullAllowed] out NSError error);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
	interface CWWirelessProfile : NSCoding, NSCopying {
		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("ssid", ArgumentSemantic.Copy)]
		string Ssid { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("securityMode", ArgumentSemantic.Retain)]
		NSNumber SecurityMode { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("passphrase", ArgumentSemantic.Copy)]
		string Passphrase { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_10)]
		[Export ("user8021XProfile", ArgumentSemantic.Retain)]
		CW8021XProfile User8021XProfile { get; set; }

		[Availability (Deprecated = Platform.Mac_10_7)]
		[Export ("isEqualToProfile:")]
		bool IsEqualToProfile (CWWirelessProfile profile);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWNetwork : NSSecureCoding, NSCopying {

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[NullAllowed]
		[Export ("bssidData")]
		NSData BssidData { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("securityMode")]
		NSNumber SecurityMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("phyMode")]
		NSNumber PhyMode { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("channel")]
		NSNumber Channel { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("rssi")]
		NSNumber Rssi { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("noise")]
		NSNumber Noise { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("ieData")]
		NSData IeData { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("isIBSS")]
		bool IsIBSS { get; }

		[Availability (Deprecated = Platform.Mac_10_7, Obsoleted = Platform.Mac_10_9)]
		[Export ("wirelessProfile")]
		CWWirelessProfile WirelessProfile { get; }

		[NullAllowed]
		[Export ("ssid")]
		string Ssid { get; }
		 
		[NullAllowed]
		[Export ("ssidData")]
		NSData SsidData { get; }
		 
		[NullAllowed]
		[Export ("bssid")]
		string Bssid { get; }

		[NullAllowed]
		[Export ("wlanChannel")]
		CWChannel WlanChannel { get; }
		 
		[Export ("rssiValue")]
		nint RssiValue { get; }
		 
		[Export ("noiseMeasurement")]
		nint NoiseMeasurement { get; }
		 
		[NullAllowed]
		[Export ("informationElementData")]
		NSData InformationElementData { get; }
		 
		[NullAllowed]
		[Export ("countryCode")]
		string CountryCode { get; }
		 
		[Export ("beaconInterval")]
		nint BeaconInterval { get; }
		 
		[Export ("ibss")]
		bool Ibss { get; }
		 
		[Export ("isEqualToNetwork:")]
		bool IsEqualToNetwork (CWNetwork network);
		 
		[Export ("supportsSecurity:")]
		bool SupportsSecurity (CWSecurity security);
		 
		[Export ("supportsPHYMode:")]
		bool SupportsPhyMode (CWPhyMode phyMode);
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface CWNetworkProfile : NSCoding, NSSecureCoding, NSCopying, NSMutableCopying 
	{
		[NullAllowed]
		[Export ("ssid", ArgumentSemantic.Copy)]
		string Ssid { get; }

		[Export ("ssidData", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSData SsidData { get; }

		[Export ("security", ArgumentSemantic.Assign)]
		CWSecurity Security { get; }

		[Static]
		[Export ("networkProfile")]
		NSObject NetworkProfile ();

		[Export ("initWithNetworkProfile:")]
		NativeHandle Constructor (CWNetworkProfile networkProfile);

		[Static]
		[Export ("networkProfileWithNetworkProfile:")]
		NSObject NetworkProfileWithNetworkProfile (CWNetworkProfile networkProfile);

		[Export ("isEqualToNetworkProfile:")]
		bool IsEqualToNetworkProfile (CWNetworkProfile networkProfile);
	}

	[NoMacCatalyst]
	[BaseType (typeof (CWNetworkProfile))]
	interface CWMutableNetworkProfile : NSCoding, NSSecureCoding, NSCopying, NSMutableCopying  
	{
		[NullAllowed]
		[Export ("ssidData", ArgumentSemantic.Copy)]
		NSData SsidData { get; set; }

		[Export ("security", ArgumentSemantic.Assign)]
		CWSecurity Security { get; set; }
	}

	[Mac (10,10), NoMacCatalyst] 
	[BaseType (typeof (NSObject))]
	interface CWWiFiClient
	{
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		ICWEventDelegate Delegate { get; set; }
		
		[Export ("interface")]
		[NullAllowed]
		CWInterface MainInterface { get; }

		[return: NullAllowed]
		[Export ("interfaceWithName:")]
		CWInterface FromName ([NullAllowed] string name);

		[Export ("interfaces")]
		[NullAllowed]
		CWInterface[] Interfaces { get; }

		[NullAllowed]
		[Export ("interfaceNames")]
		[Static]
		string[] InterfaceNames { get; }

		[Export ("sharedWiFiClient")]
		[Static]
		CWWiFiClient SharedWiFiClient { get; }

		[Export ("startMonitoringEventWithType:error:")]
		bool StartMonitoringEvent (CWEventType type, out NSError error);

		[Export ("stopMonitoringAllEventsAndReturnError:")]
		bool StopMonitoringAllEvents (out NSError error);

		[Export ("stopMonitoringEventWithType:error:")]
		bool StopMonitoringEvent (CWEventType type, out NSError error);
	}
	
	interface ICWEventDelegate { }
	
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CWEventDelegate
	{
		[Export ("clientConnectionInterrupted")]
		void ClientConnectionInterrupted ();
		
		[Export ("clientConnectionInvalidated")]
		void ClientConnectionInvalidated ();
		
		[Export ("powerStateDidChangeForWiFiInterfaceWithName:")]
		void PowerStateDidChangeForWiFi (string interfaceName);
		
		[Export ("ssidDidChangeForWiFiInterfaceWithName:")]
		void SsidDidChangeForWiFi (string interfaceName);
		
		[Export ("bssidDidChangeForWiFiInterfaceWithName:")]
		void BssidDidChangeForWiFi (string interfaceName);
		
		[Export ("countryCodeDidChangeForWiFiInterfaceWithName:")]
		void CountryCodeDidChangeForWiFi (string interfaceName);
		
		[Export ("linkDidChangeForWiFiInterfaceWithName:")]
		void LinkDidChangeForWiFi (string interfaceName);
		
		[Export ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:")]
		void LinkQualityDidChangeForWiFi (string interfaceName, int rssi, double transmitRate);
		
		[Export ("modeDidChangeForWiFiInterfaceWithName:")]
		void ModeDidChangeForWiFi (string interfaceName);
		
		[Export ("scanCacheUpdatedForWiFiInterfaceWithName:")]
		void ScanCacheUpdatedForWiFi (string interfaceName);
	}
}
