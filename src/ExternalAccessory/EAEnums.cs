//
// EAEnums.cs: API definition for ExternalAccessory binding
//
// Copyright 2012-2014 Xamarin Inc. All rights reserved.
//

namespace ExternalAccessory {

	/// <summary>Enumerates unconfigured but supported features.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum EAWiFiUnconfiguredAccessoryProperties : ulong {
		/// <summary>Indicates supports air play.</summary>
		SupportsAirPlay = (1 << 0),
		/// <summary>Indicates supports air print.</summary>
		SupportsAirPrint = (1 << 1),
		/// <summary>Indicates supports home kit.</summary>
		SupportsHomeKit = (1 << 2), // iOS 8 beta 5
	}

	/// <summary>Enumerates the possible states of unconfigured accessory browsers.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum EAWiFiUnconfiguredAccessoryBrowserState : long {
		/// <summary>Indicates wi fi unavailable.</summary>
		WiFiUnavailable = 0,
		/// <summary>Indicates stopped.</summary>
		Stopped,
		/// <summary>Indicates searching.</summary>
		Searching,
		/// <summary>Indicates configuring.</summary>
		Configuring,
	}

	// NSInteger -> EAWiFiUnconfiguredAccessoryBrowser.h
	/// <summary>Enumerates the possible states encountered while configuring accessory browsers.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum EAWiFiUnconfiguredAccessoryConfigurationStatus : long {
		/// <summary>Indicates success.</summary>
		Success,
		/// <summary>Indicates user cancelled configuration.</summary>
		UserCancelledConfiguration,
		/// <summary>Indicates failed.</summary>
		Failed,
	}

	// NSInteger -> EAAccessoryManager.h
	[MacCatalyst (13, 1)]
	[Native ("EABluetoothAccessoryPickerErrorCode")]
	[ErrorDomain ("EABluetoothAccessoryPickerErrorDomain")]
	public enum EABluetoothAccessoryPickerError : long {
		/// <summary>Indicates already connected.</summary>
		AlreadyConnected,
		/// <summary>Indicates not found.</summary>
		NotFound,
		/// <summary>Indicates cancelled.</summary>
		Cancelled,
		/// <summary>Indicates failed.</summary>
		Failed,
	}
}
