// Copyright 2014 Xamarin Inc. All rights reserved.
// Copyright 2019 Microsoft Corporation

using CoreFoundation;

namespace CoreWlan {

	[NoMacCatalyst]
	[Native]
	[ErrorDomain ("CWErrorDomain")] // enum named `CWErr` in headers
	public enum CWStatus : long {
		/// <summary>The operation completed successfully.</summary>
		Ok = 0,
		/// <summary>Indicates EAPOL.</summary>
		EAPOL = 1,
		/// <summary>Indicates invalid parameter.</summary>
		InvalidParameter = -3900,
		/// <summary>Indicates no memory.</summary>
		NoMemory = -3901,
		/// <summary>Indicates unknown.</summary>
		Unknown = -3902,
		/// <summary>Indicates not supported.</summary>
		NotSupported = -3903,
		/// <summary>Indicates invalid format.</summary>
		InvalidFormat = -3904,
		/// <summary>Indicates timeout.</summary>
		Timeout = -3905,
		/// <summary>Indicates unspecified failure.</summary>
		UnspecifiedFailure = -3906,
		/// <summary>Indicates unsupported capabilities.</summary>
		UnsupportedCapabilities = -3907,
		/// <summary>Indicates reassociation denied.</summary>
		ReassociationDenied = -3908,
		/// <summary>Indicates association denied.</summary>
		AssociationDenied = -3909,
		/// <summary>Indicates authentication algorithm unsupported.</summary>
		AuthenticationAlgorithmUnsupported = -3910,
		/// <summary>Indicates invalid authentication sequence number.</summary>
		InvalidAuthenticationSequenceNumber = -3911,
		/// <summary>Indicates challenge failure.</summary>
		ChallengeFailure = -3912,
		/// <summary>Indicates AP full.</summary>
		APFull = -3913,
		/// <summary>Indicates unsupported rate set.</summary>
		UnsupportedRateSet = -3914,
		/// <summary>Indicates short slot unsupported.</summary>
		ShortSlotUnsupported = -3915,
		/// <summary>Indicates DSSSOFDM unsupported.</summary>
		DSSSOFDMUnsupported = -3916,
		/// <summary>Indicates invalid information element.</summary>
		InvalidInformationElement = -3917,
		/// <summary>Indicates invalid group cipher.</summary>
		InvalidGroupCipher = -3918,
		/// <summary>Indicates invalid pairwise cipher.</summary>
		InvalidPairwiseCipher = -3919,
		/// <summary>Indicates invalid AKMP.</summary>
		InvalidAKMP = -3920,
		/// <summary>Indicates unsupported RSN version.</summary>
		UnsupportedRSNVersion = -3921,
		/// <summary>Indicates invalid r s n capabilities.</summary>
		InvalidRSNCapabilities = -3922,
		/// <summary>Indicates cipher suite rejected.</summary>
		CipherSuiteRejected = -3923,
		/// <summary>Indicates invalid p m k.</summary>
		InvalidPMK = -3924,
		/// <summary>Indicates supplicant timeout.</summary>
		SupplicantTimeout = -3925,
		/// <summary>Indicates HT features not supported.</summary>
		HTFeaturesNotSupported = -3926,
		/// <summary>Indicates PCO transition time not supported.</summary>
		PCOTransitionTimeNotSupported = -3927,
		/// <summary>Indicates reference not bound.</summary>
		ReferenceNotBound = -3928,
		/// <summary>Indicates IPC failure.</summary>
		IPCFailure = -3929,
		/// <summary>Indicates operation not permitted.</summary>
		OperationNotPermitted = -3930,
		/// <summary>Indicates status.</summary>
		Status = -3931,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWPhyMode : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates a.</summary>
		A = 1,
		/// <summary>Indicates b.</summary>
		B = 2,
		/// <summary>Indicates g.</summary>
		G = 3,
		/// <summary>Indicates n.</summary>
		N = 4,
		/// <summary>Indicates AC.</summary>
		AC = 5,
		AX = 6,
		/// <summary>802.11be (Wi-Fi 7).</summary>
		[Mac (26, 4)]
		BE = 7,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWInterfaceMode : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates station.</summary>
		Station = 1,
		/// <summary>Indicates ibss.</summary>
		Ibss = 2,
		/// <summary>Indicates host a p.</summary>
		HostAP = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWSecurity : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates WEP.</summary>
		WEP = 1,
		/// <summary>Indicates WPA personal.</summary>
		WPAPersonal = 2,
		/// <summary>Indicates WPA personal mixed.</summary>
		WPAPersonalMixed = 3,
		/// <summary>Indicates WP a2 personal.</summary>
		WPA2Personal = 4,
		/// <summary>Indicates personal.</summary>
		Personal = 5,
		/// <summary>Indicates dynamic w e p.</summary>
		DynamicWEP = 6,
		/// <summary>Indicates WPA enterprise.</summary>
		WPAEnterprise = 7,
		/// <summary>Indicates WPA enterprise mixed.</summary>
		WPAEnterpriseMixed = 8,
		/// <summary>Indicates WP a2 enterprise.</summary>
		WPA2Enterprise = 9,
		/// <summary>Indicates enterprise.</summary>
		Enterprise = 10,
		Wpa3Personal = 11,
		Wpa3Enterprise = 12,
		Wpa3Transition = 13,
		[Mac (13, 0)]
		Owe = 14,
		[Mac (13, 0)]
		OweTransition = 15,
		/// <summary>Indicates unknown.</summary>
		Unknown = long.MaxValue,
	}

	[NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 11, 0)]
	[Native]
	public enum CWIbssModeSecurity : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates WE p40.</summary>
		WEP40 = 1,
		/// <summary>Indicates WE p104.</summary>
		WEP104 = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWChannelWidth : ulong {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates twenty m hz.</summary>
		TwentyMHz = 1,
		/// <summary>Indicates fourty m hz.</summary>
		FourtyMHz = 2,
		/// <summary>Indicates eighty m hz.</summary>
		EightyMHz = 3,
		/// <summary>Indicates one hundred sixty m hz.</summary>
		OneHundredSixtyMHz = 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWChannelBand : ulong {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates two g hz.</summary>
		TwoGHz = 1,
		/// <summary>Indicates five g hz.</summary>
		FiveGHz = 2,
		SixGHz = 3,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWCipherKeyFlags : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates unicast.</summary>
		Unicast = 1 << 1,
		/// <summary>Indicates multicast.</summary>
		Multicast = 1 << 2,
		/// <summary>Indicates tx.</summary>
		Tx = 1 << 3,
		/// <summary>Indicates rx.</summary>
		Rx = 1 << 4,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWKeychainDomain : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates user.</summary>
		User = 1,
		/// <summary>Indicates system.</summary>
		System = 2,
	}

	[NoMacCatalyst]
	[Native]
	public enum CWEventType : long {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates power did change.</summary>
		PowerDidChange = 1,
		/// <summary>Indicates ssid did change.</summary>
		SsidDidChange = 2,
		/// <summary>Indicates bssid did change.</summary>
		BssidDidChange = 3,
		/// <summary>Indicates country code did change.</summary>
		CountryCodeDidChange = 4,
		/// <summary>Indicates link did change.</summary>
		LinkDidChange = 5,
		/// <summary>Indicates link quality did change.</summary>
		LinkQualityDidChange = 6,
		/// <summary>Indicates mode did change.</summary>
		ModeDidChange = 7,
		/// <summary>Indicates scan cache updated.</summary>
		ScanCacheUpdated = 8,

		/// <summary>Indicates virtual interface state changed.</summary>
		[Deprecated (PlatformName.MacOSX, 11, 0)]
		VirtualInterfaceStateChanged = 9,

		/// <summary>Indicates ranging report event.</summary>
		[Deprecated (PlatformName.MacOSX, 11, 0)]
		RangingReportEvent = 10,
		/// <summary>Indicates unknown.</summary>
		Unknown = long.MaxValue,
	}
}
