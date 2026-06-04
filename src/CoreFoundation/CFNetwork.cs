// Copyright 2015 Xamarin Inc. All rights reserved.

#nullable enable

namespace CoreFoundation {

	// note: Make sure names are identical/consistent with NSUrlError.*
	// they share the same values but there's more entries in CFNetworkErrors
	/// <summary>To be added.</summary>
	public enum CFNetworkErrors {
		/// <summary>Indicates host not found.</summary>
		HostNotFound = 1,
		/// <summary>Indicates host unknown.</summary>
		HostUnknown = 2,

		/// <summary>Indicates socks unknown client version.</summary>
		SocksUnknownClientVersion = 100,
		/// <summary>Indicates socks unsupported server version.</summary>
		SocksUnsupportedServerVersion = 101,
		/// <summary>Indicates socks4 request failed.</summary>
		Socks4RequestFailed = 110,
		/// <summary>Indicates socks4 identd failed.</summary>
		Socks4IdentdFailed = 111,
		/// <summary>Indicates socks4 id conflict.</summary>
		Socks4IdConflict = 112,
		/// <summary>Indicates socks4 unknown status code.</summary>
		Socks4UnknownStatusCode = 113,
		/// <summary>Indicates socks5 bad state.</summary>
		Socks5BadState = 120,
		/// <summary>Indicates socks5 bad response addr.</summary>
		Socks5BadResponseAddr = 121,
		/// <summary>Indicates socks5 bad credentials.</summary>
		Socks5BadCredentials = 122,
		/// <summary>Indicates socks5 unsupported negotiation method.</summary>
		Socks5UnsupportedNegotiationMethod = 123,
		/// <summary>Indicates socks5 no acceptable method.</summary>
		Socks5NoAcceptableMethod = 124,

		/// <summary>Indicates ftp unexpected status code.</summary>
		FtpUnexpectedStatusCode = 200,

		/// <summary>Indicates http authentication type unsupported.</summary>
		HttpAuthenticationTypeUnsupported = 300,
		/// <summary>Indicates http bad credentials.</summary>
		HttpBadCredentials = 301,
		/// <summary>Indicates http connection lost.</summary>
		HttpConnectionLost = 302,
		/// <summary>Indicates http parse failure.</summary>
		HttpParseFailure = 303,
		/// <summary>Indicates http redirection loop detected.</summary>
		HttpRedirectionLoopDetected = 304,
		/// <summary>Indicates http bad u r l.</summary>
		HttpBadURL = 305,
		/// <summary>Indicates http proxy connection failure.</summary>
		HttpProxyConnectionFailure = 306,
		/// <summary>Indicates http bad proxy credentials.</summary>
		HttpBadProxyCredentials = 307,
		/// <summary>Indicates pac file error.</summary>
		PacFileError = 308,
		/// <summary>Indicates pac file auth.</summary>
		PacFileAuth = 309,
		/// <summary>Indicates https proxy connection failure.</summary>
		HttpsProxyConnectionFailure = 310,
		/// <summary>Indicates https proxy failure unexpected response to connect method.</summary>
		HttpsProxyFailureUnexpectedResponseToConnectMethod = 311,

		// same names as NSUrlError - begin
		/// <summary>Indicates background session in use by another process.</summary>
		BackgroundSessionInUseByAnotherProcess = -996,
		/// <summary>Indicates background session was disconnected.</summary>
		BackgroundSessionWasDisconnected = -997,
		// same names as NSUrlError - end

		/// <summary>Indicates unknown.</summary>
		Unknown = -998,

		// same names as NSUrlError - begin
		/// <summary>Indicates cancelled.</summary>
		Cancelled = -999,
		/// <summary>Indicates bad u r l.</summary>
		BadURL = -1000,
		/// <summary>Indicates timed out.</summary>
		TimedOut = -1001,
		/// <summary>Indicates unsupported u r l.</summary>
		UnsupportedURL = -1002,
		/// <summary>Indicates cannot find host.</summary>
		CannotFindHost = -1003,
		/// <summary>Indicates cannot connect to host.</summary>
		CannotConnectToHost = -1004,
		/// <summary>Indicates network connection lost.</summary>
		NetworkConnectionLost = -1005,
		/// <summary>Indicates DNS lookup failed.</summary>
		DNSLookupFailed = -1006,
		/// <summary>Indicates HTTP too many redirects.</summary>
		HTTPTooManyRedirects = -1007,
		/// <summary>Indicates resource unavailable.</summary>
		ResourceUnavailable = -1008,
		/// <summary>Indicates not connected to internet.</summary>
		NotConnectedToInternet = -1009,
		/// <summary>Indicates redirect to non existent location.</summary>
		RedirectToNonExistentLocation = -1010,
		/// <summary>Indicates bad server response.</summary>
		BadServerResponse = -1011,
		/// <summary>Indicates user cancelled authentication.</summary>
		UserCancelledAuthentication = -1012,
		/// <summary>Indicates user authentication required.</summary>
		UserAuthenticationRequired = -1013,
		/// <summary>Indicates zero byte resource.</summary>
		ZeroByteResource = -1014,
		/// <summary>Indicates cannot decode raw data.</summary>
		CannotDecodeRawData = -1015,
		/// <summary>Indicates cannot decode content data.</summary>
		CannotDecodeContentData = -1016,
		/// <summary>Indicates cannot parse response.</summary>
		CannotParseResponse = -1017,
		/// <summary>Indicates international roaming off.</summary>
		InternationalRoamingOff = -1018,
		/// <summary>Indicates call is active.</summary>
		CallIsActive = -1019,
		/// <summary>Indicates data not allowed.</summary>
		DataNotAllowed = -1020,
		/// <summary>Indicates request body stream exhausted.</summary>
		RequestBodyStreamExhausted = -1021,
		/// <summary>Indicates app transport security requires secure connection.</summary>
		AppTransportSecurityRequiresSecureConnection = -1022,

		/// <summary>Indicates file does not exist.</summary>
		FileDoesNotExist = -1100,
		/// <summary>Indicates file is directory.</summary>
		FileIsDirectory = -1101,
		/// <summary>Indicates no permissions to read file.</summary>
		NoPermissionsToReadFile = -1102,
		/// <summary>Indicates data length exceeds maximum.</summary>
		DataLengthExceedsMaximum = -1103,
		/// <summary>Indicates file outside safe area.</summary>
		FileOutsideSafeArea = -1104,

		/// <summary>Indicates secure connection failed.</summary>
		SecureConnectionFailed = -1200,
		/// <summary>Indicates server certificate has bad date.</summary>
		ServerCertificateHasBadDate = -1201,
		/// <summary>Indicates server certificate untrusted.</summary>
		ServerCertificateUntrusted = -1202,
		/// <summary>Indicates server certificate has unknown root.</summary>
		ServerCertificateHasUnknownRoot = -1203,
		/// <summary>Indicates server certificate not yet valid.</summary>
		ServerCertificateNotYetValid = -1204,
		/// <summary>Indicates client certificate rejected.</summary>
		ClientCertificateRejected = -1205,
		/// <summary>Indicates client certificate required.</summary>
		ClientCertificateRequired = -1206,

		/// <summary>Indicates cannot load from network.</summary>
		CannotLoadFromNetwork = -2000,

		/// <summary>Indicates cannot create file.</summary>
		CannotCreateFile = -3000,
		/// <summary>Indicates cannot open file.</summary>
		CannotOpenFile = -3001,
		/// <summary>Indicates cannot close file.</summary>
		CannotCloseFile = -3002,
		/// <summary>Indicates cannot write to file.</summary>
		CannotWriteToFile = -3003,
		/// <summary>Indicates cannot remove file.</summary>
		CannotRemoveFile = -3004,
		/// <summary>Indicates cannot move file.</summary>
		CannotMoveFile = -3005,
		/// <summary>Indicates download decoding failed mid stream.</summary>
		DownloadDecodingFailedMidStream = -3006,
		/// <summary>Indicates download decoding failed to complete.</summary>
		DownloadDecodingFailedToComplete = -3007,
		// same names as NSUrlError - end

		/// <summary>Indicates cannot parse cookie file.</summary>
		CannotParseCookieFile = -4000,

		/// <summary>Indicates net service unknown.</summary>
		NetServiceUnknown = -72000,
		/// <summary>Indicates net service collision.</summary>
		NetServiceCollision = -72001,
		/// <summary>Indicates net service not found.</summary>
		NetServiceNotFound = -72002,
		/// <summary>Indicates net service in progress.</summary>
		NetServiceInProgress = -72003,
		/// <summary>Indicates net service bad argument.</summary>
		NetServiceBadArgument = -72004,
		/// <summary>Indicates net service cancel.</summary>
		NetServiceCancel = -72005,
		/// <summary>Indicates net service invalid.</summary>
		NetServiceInvalid = -72006,
		/// <summary>Indicates net service timeout.</summary>
		NetServiceTimeout = -72007,
		NetServiceMissingRequiredConfiguration = -72008,
		/// <summary>Indicates net service dns service failure.</summary>
		NetServiceDnsServiceFailure = -73000,
	}
}
