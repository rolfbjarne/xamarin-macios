//
// security.cs: Definitions for Security
//
// Authors: 
//  Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014 Xamarin Inc.
//

using CoreFoundation;

namespace Security {

	/// <summary>Contains values that represent security policies.</summary>
		
	[Static]
	interface SecPolicyIdentifier {
		// they are CFString -> https://github.com/Apple-FOSS-Mirror/libsecurity_keychain/blob/master/lib/SecPolicy.cpp

		// the Apple* prefix was kept since they are Apple-specific (not an RFC) OIDs

		/// <summary>Represents the value associated with the constant kSecPolicyAppleX509Basic</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleX509Basic")]
		NSString AppleX509Basic { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleSSL</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleSSL")]
		NSString AppleSSL { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleSMIME</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleSMIME")]
		NSString AppleSMIME { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleEAP</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleEAP")]
		NSString AppleEAP { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleIPsec</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleIPsec")]
		NSString AppleIPsec { get; }

		/// <summary>The PKINIT client policy identifier.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Field ("kSecPolicyApplePKINITClient")]
		NSString ApplePKINITClient { get; }

		/// <summary>The PKINIT server policy identifier.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Field ("kSecPolicyApplePKINITServer")]
		NSString ApplePKINITServer { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleCodeSigning</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleCodeSigning")]
		NSString AppleCodeSigning { get; }

		/// <summary>The Mac App Store receipt policy identifier.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyMacAppStoreReceipt")]
		NSString MacAppStoreReceipt { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleIDValidation</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleIDValidation")]
		NSString AppleIDValidation { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleTimeStamping</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyAppleTimeStamping")]
		NSString AppleTimeStamping { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyAppleRevocation</summary>
		///         <value>
		///         </value>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyAppleRevocation")]
		NSString AppleRevocation { get; }

		/// <summary>The Passbook signing policy identifier.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyApplePassbookSigning")]
		NSString ApplePassbookSigning { get; }

		/// <summary>The payment issuer encryption policy identifier.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyApplePayIssuerEncryption")]
		NSString ApplePayIssuerEncryption { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleSSLServer")]
		NSString AppleSslServer { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleSSLClient")]
		NSString AppleSslClient { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleEAPServer")]
		NSString AppleEapServer { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleEAPClient")]
		NSString AppleEapClient { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleIPSecServer")]
		NSString AppleIPSecServer { get; }

		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecPolicyAppleIPSecClient")]
		NSString AppleIPSecClient { get; }
	}

	/// <summary>Contains keys that index security policy data..</summary>
		
	[Static]
	interface SecPolicyPropertyKey {
		/// <summary>Represents the value associated with the constant kSecPolicyOid</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyOid")]
		NSString Oid { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyName</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyName")]
		NSString Name { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyClient</summary>
		///         <value>
		///         </value>
		[Field ("kSecPolicyClient")]
		NSString Client { get; }

		/// <summary>Represents the value associated with the constant kSecPolicyRevocationFlags</summary>
		///         <value>
		///         </value>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyRevocationFlags")]
		NSString RevocationFlags { get; }

		/// <summary>Gets the name of the security policy.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecPolicyTeamIdentifier")]
		NSString TeamIdentifier { get; }
	}

	/// <summary>Represents shared user name and password for a Website.</summary>
	[Static]
	[Introduced (PlatformName.MacCatalyst, 14, 0)]
	[NoTV] // removed in tvOS 10
	interface SecSharedCredential {
		/// <summary>Gets the properties of the security policy.</summary>
		[Field ("kSecSharedPassword")]
		NSString SharedPassword { get; }
	}


	/// <summary>Contains keys that index certificate data by type.</summary>
		
	[Static]
	interface SecTrustPropertyKey {
		/// <summary>Represents the value associated with the constant kSecPropertyTypeTitle</summary>
		///         <value>
		///         </value>
		[Field ("kSecPropertyTypeTitle")]
		NSString Title { get; }

		/// <summary>Represents the value associated with the constant kSecPropertyTypeError</summary>
		///         <value>
		///         </value>
		[Field ("kSecPropertyTypeError")]
		NSString Error { get; }
	}

	/// <summary>Contains keys that index trust data.</summary>
		
	[Static]
	[MacCatalyst (13, 1)]
	interface SecTrustResultKey {
		/// <summary>Represents the value associated with the constant kSecTrustEvaluationDate</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustEvaluationDate")]
		NSString EvaluationDate { get; }

		/// <summary>Represents the value associated with the constant kSecTrustExtendedValidation</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustExtendedValidation")]
		NSString ExtendedValidation { get; }

		/// <summary>Represents the value associated with the constant kSecTrustOrganizationName</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustOrganizationName")]
		NSString OrganizationName { get; }

		/// <summary>Represents the value associated with the constant kSecTrustResultValue</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustResultValue")]
		NSString ResultValue { get; }

		/// <summary>Represents the value associated with the constant kSecTrustRevocationChecked</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustRevocationChecked")]
		NSString RevocationChecked { get; }

		/// <summary>Represents the value associated with the constant kSecTrustRevocationValidUntilDate</summary>
		///         <value>
		///         </value>
		[Field ("kSecTrustRevocationValidUntilDate")]
		NSString RevocationValidUntilDate { get; }

		/// <summary>Gets the data associated with this identity.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecTrustCertificateTransparency")]
		NSString CertificateTransparency { get; }

		/// <summary>Developers should not use this deprecated property. </summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSecTrustCertificateTransparencyWhiteList")]
		NSString CertificateTransparencyWhiteList { get; }

		// QC = Qualified Certificate
		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecTrustQCStatements")]
		NSString QCStatements { get; }

		// QWAC = Qualified Website Authentication Certificate.
		[iOS (18, 4), TV (18, 4), MacCatalyst (18, 4), Mac (15, 4)]
		[Field ("kSecTrustQWACValidation")]
		NSString QwacValidation { get; }
	}

	/// <summary>Keys used to control query results.</summary>
	/// <remarks>You can use either an NSNumber or one of the values defined in this class when manually querying.</remarks>
	[Static]
	interface SecMatchLimit {
		/// <summary>Return a single match.</summary>
		///         <value />
		[Field ("kSecMatchLimitOne")]
		IntPtr MatchLimitOne { get; }

		/// <summary>Return all matches.</summary>
		///         <value />
		[Field ("kSecMatchLimitAll")]
		IntPtr MatchLimitAll { get; }
	}

	/// <summary>An enumeration whose values specify the <see cref="Security.SecRecord.KeyType" /> property.</summary>
		
	enum SecKeyType {
		/// <summary>Gets the certificate type.</summary>
		Invalid = -1,

		/// <summary>RSA algorithm.</summary>
		[Field ("kSecAttrKeyTypeRSA")]
		RSA = 0,

		/// <summary>Elliptic curve DSA algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecAttrKeyTypeEC")]
		EC = 1,

		/// <summary>Gets the type of the certificate.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecAttrKeyTypeECSECPrimeRandom")]
		ECSecPrimeRandom = 2,
	}

	/// <summary>The kind of cryptographic key</summary>
		
	enum SecKeyClass {
		/// <summary>Gets the subject value.</summary>
		Invalid = -1,

		/// <summary>Public part of a symmetric key.</summary>
		[Field ("kSecAttrKeyClassPublic")]
		Public = 0,

		/// <summary>Private part of an asymmetric key.</summary>
		[Field ("kSecAttrKeyClassPrivate")]
		Private = 1,

		/// <summary>A symmetric key.</summary>
		[Field ("kSecAttrKeyClassSymmetric")]
		Symmetric = 2,
	}

	[Static]
	[Internal]
	interface KeysAuthenticationType {
		[Field ("kSecAttrAuthenticationTypeNTLM")]
		IntPtr NTLM { get; }

		[Field ("kSecAttrAuthenticationTypeMSN")]
		IntPtr MSN { get; }

		[Field ("kSecAttrAuthenticationTypeDPA")]
		IntPtr DPA { get; }

		[Field ("kSecAttrAuthenticationTypeRPA")]
		IntPtr RPA { get; }

		[Field ("kSecAttrAuthenticationTypeHTTPBasic")]
		IntPtr HTTPBasic { get; }

		[Field ("kSecAttrAuthenticationTypeHTTPDigest")]
		IntPtr HTTPDigest { get; }

		[Field ("kSecAttrAuthenticationTypeHTMLForm")]
		IntPtr HTMLForm { get; }

		[Field ("kSecAttrAuthenticationTypeDefault")]
		IntPtr Default { get; }
	}

	[Static]
	[Internal]
	interface SecProtocolKeys {
		[Field ("kSecAttrProtocolFTP")]
		IntPtr FTP { get; }

		[Field ("kSecAttrProtocolFTPAccount")]
		IntPtr FTPAccount { get; }

		[Field ("kSecAttrProtocolHTTP")]
		IntPtr HTTP { get; }

		[Field ("kSecAttrProtocolIRC")]
		IntPtr IRC { get; }

		[Field ("kSecAttrProtocolNNTP")]
		IntPtr NNTP { get; }

		[Field ("kSecAttrProtocolPOP3")]
		IntPtr POP3 { get; }

		[Field ("kSecAttrProtocolSMTP")]
		IntPtr SMTP { get; }

		[Field ("kSecAttrProtocolSOCKS")]
		IntPtr SOCKS { get; }

		[Field ("kSecAttrProtocolIMAP")]
		IntPtr IMAP { get; }

		[Field ("kSecAttrProtocolLDAP")]
		IntPtr LDAP { get; }

		[Field ("kSecAttrProtocolAppleTalk")]
		IntPtr AppleTalk { get; }

		[Field ("kSecAttrProtocolAFP")]
		IntPtr AFP { get; }

		[Field ("kSecAttrProtocolTelnet")]
		IntPtr Telnet { get; }

		[Field ("kSecAttrProtocolSSH")]
		IntPtr SSH { get; }

		[Field ("kSecAttrProtocolFTPS")]
		IntPtr FTPS { get; }

		[Field ("kSecAttrProtocolHTTPS")]
		IntPtr HTTPS { get; }

		[Field ("kSecAttrProtocolHTTPProxy")]
		IntPtr HTTPProxy { get; }

		[Field ("kSecAttrProtocolHTTPSProxy")]
		IntPtr HTTPSProxy { get; }

		[Field ("kSecAttrProtocolFTPProxy")]
		IntPtr FTPProxy { get; }

		[Field ("kSecAttrProtocolSMB")]
		IntPtr SMB { get; }

		[Field ("kSecAttrProtocolRTSP")]
		IntPtr RTSP { get; }

		[Field ("kSecAttrProtocolRTSPProxy")]
		IntPtr RTSPProxy { get; }

		[Field ("kSecAttrProtocolDAAP")]
		IntPtr DAAP { get; }

		[Field ("kSecAttrProtocolEPPC")]
		IntPtr EPPC { get; }

		[Field ("kSecAttrProtocolIPP")]
		IntPtr IPP { get; }

		[Field ("kSecAttrProtocolNNTPS")]
		IntPtr NNTPS { get; }

		[Field ("kSecAttrProtocolLDAPS")]
		IntPtr LDAPS { get; }

		[Field ("kSecAttrProtocolTelnetS")]
		IntPtr TelnetS { get; }

		[Field ("kSecAttrProtocolIMAPS")]
		IntPtr IMAPS { get; }

		[Field ("kSecAttrProtocolIRCS")]
		IntPtr IRCS { get; }

		[Field ("kSecAttrProtocolPOP3S")]
		IntPtr POP3S { get; }
	}

	[Static]
	[Internal]
	interface KeysAccessible {
		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleWhenUnlocked")]
		IntPtr WhenUnlocked { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleAfterFirstUnlock")]
		IntPtr AfterFirstUnlock { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleAlways")]
		IntPtr Always { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleWhenUnlockedThisDeviceOnly")]
		IntPtr WhenUnlockedThisDeviceOnly { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		IntPtr AfterFirstUnlockThisDeviceOnly { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleAlwaysThisDeviceOnly")]
		IntPtr AlwaysThisDeviceOnly { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly")]
		IntPtr WhenPasscodeSetThisDeviceOnly { get; }
	}

	/// <summary>Contains attributes for creating and using public-private key pairs.</summary>
		
	[StrongDictionary ("SecAttributeKeys")]
	interface SecPublicPrivateKeyAttrs {
		/// <summary>Gets or sets the label for the key pair.</summary>
		///         <value>The label for the key pair.</value>
		string Label { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair is permanent.</summary>
		///         <value>A Boolean value that controls whether the key pair is permanent.</value>
		bool IsPermanent { get; set; }

		/// <summary>Gets or sets the application's private tag.</summary>
		///         <value>The application's private tag.</value>
		NSData ApplicationTag { get; set; }

		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key pair. This value can be significantly smaller than the actual key size.</summary>
		///         <value>A value that describes the minimum size of attack that can defeat the key pair. This value can be significantly smaller than the actual key size.</value>
		int EffectiveKeySize { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for encryption.</summary>
		///         <value>A Boolean value that controls whether the key pair can be used for encryption.</value>
#if MONOMAC
		[Advice ("On macOS when passed to 'GenerateKeyPair', 'false' seems to be the only valid value. Otherwise 'UnsupportedKeyUsageMask' is returned.")]
#endif
		bool CanEncrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for decryption.</summary>
		///         <value>A  Boolean value that controls whether the key pair can be used for decryption.</value>
#if MONOMAC
		[Advice ("On macOS when passed to 'GenerateKeyPair', 'false' seems to be the only valid value. Otherwise 'UnsupportedKeyUsageMask' is returned.")]
#endif
		bool CanDecrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for key derivation.</summary>
		///         <value>A  Boolean value that controls whether the key pair can be used for key derivation.</value>
		bool CanDerive { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for signing.</summary>
		///         <value>A Boolean value that controls whether the key pair can be used for signing.</value>
#if MONOMAC
		[Advice ("On macOS when passed to 'GenerateKeyPair', 'false' seems to be the only valid value. Otherwise 'UnsupportedKeyUsageMask' is returned.")]
#endif
		bool CanSign { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for verifying signatures.</summary>
		///         <value>A Boolean value that controls whether the key pair can be used for verifying signatures.</value>
#if MONOMAC
		[Advice ("On macOS when passed to 'GenerateKeyPair', 'false' seems to be the only valid value. Otherwise 'UnsupportedKeyUsageMask' is returned.")]
#endif
		bool CanVerify { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key pair can be used for key unwrapping.</summary>
		///         <value>A Boolean value that controls whether the key pair can be used for key unwrapping.</value>
#if MONOMAC
		[Advice ("On macOS when passed to 'GenerateKeyPair', 'false' seems to be the only valid value. Otherwise 'UnsupportedKeyUsageMask' is returned.")]
#endif
		bool CanUnwrap { get; set; }
	}

	[Static]
	[Internal]
	interface SecAttributeKeys {
		[Field ("kSecAttrLabel")]
		NSString LabelKey { get; }

		[Field ("kSecAttrIsPermanent")]
		NSString IsPermanentKey { get; }

		[Field ("kSecAttrApplicationTag")]
		NSString ApplicationTagKey { get; }

		[Field ("kSecAttrEffectiveKeySize")]
		NSString EffectiveKeySizeKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessControl")]
		NSString AccessControlKey { get; }

		[Field ("kSecAttrCanEncrypt")]
		NSString CanEncryptKey { get; }

		[Field ("kSecAttrCanDecrypt")]
		NSString CanDecryptKey { get; }

		[Field ("kSecAttrCanDerive")]
		NSString CanDeriveKey { get; }

		[Field ("kSecAttrCanSign")]
		NSString CanSignKey { get; }

		[Field ("kSecAttrCanVerify")]
		NSString CanVerifyKey { get; }

		[Field ("kSecAttrCanUnwrap")]
		NSString CanUnwrapKey { get; }
	}

	[Static]
	[Internal]
	interface SecKeyGenerationAttributeKeys : SecAttributeKeys {
		[Field ("kSecAttrKeyType")]
		NSString KeyTypeKey { get; }

		[Field ("kSecAttrKeySizeInBits")]
		NSString KeySizeInBitsKey { get; }

		[Field ("kSecPrivateKeyAttrs")]
		NSString PrivateKeyAttrsKey { get; }

		[Field ("kSecPublicKeyAttrs")]
		NSString PublicKeyAttrsKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrTokenID")]
		NSString TokenIDKey { get; }

		[Field ("kSecAttrCanWrap")]
		NSString CanWrapKey { get; }
	}

	[StrongDictionary ("SecAttributeKeys")]
	interface SecKeyParameters {
		/// <summary>Gets or sets the label for the key.</summary>
		///         <value>The label for the key.</value>
		string Label { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key is permanent.</summary>
		///         <value>A Boolean value that controls whether the key is permanent.</value>
		bool IsPermanent { get; set; }

		/// <summary>Gets or sets the application's private tag.</summary>
		///         <value>The application's private tag.</value>
		NSData ApplicationTag { get; set; }

		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</summary>
		///         <value>A value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</value>
		int EffectiveKeySize { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for encryption.</summary>
		///         <value>A Boolean value that controls whether the key can be used for encryption.</value>
		bool CanEncrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for decryption.</summary>
		///         <value>A  Boolean value that controls whether the key can be used for decryption.</value>
		bool CanDecrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key derivation.</summary>
		///         <value>A  Boolean value that controls whether the key can be used for key derivation.</value>
		bool CanDerive { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for signing.</summary>
		///         <value>A Boolean value that controls whether the key can be used for signing.</value>
		bool CanSign { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for verifying signatures.</summary>
		///         <value>A Boolean value that controls whether the key can be used for verifying signatures.</value>
		bool CanVerify { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key unwrapping.</summary>
		///         <value>A Boolean value that controls whether the key can be used for key unwrapping.</value>
		bool CanUnwrap { get; set; }
	}

	[StrongDictionary ("SecKeyGenerationAttributeKeys")]
	interface SecKeyGenerationParameters {
		/// <summary>Gets or sets the key size, in bits.</summary>
		///         <value>The key size, in bits.</value>
		int KeySizeInBits { get; set; }

		/// <summary>Gets or sets the attributes for the private key.</summary>
		///         <value>The attributes for the private key.</value>
		[StrongDictionary]
		[Export ("PrivateKeyAttrsKey")]
		SecKeyParameters PrivateKeyAttrs { get; set; }

		/// <summary>Gets or sets the attributes for the public key.</summary>
		///         <value>The attributes for the public key.</value>
		[StrongDictionary]
		[Export ("PublicKeyAttrsKey")]
		SecKeyParameters PublicKeyAttrs { get; set; }

		/// <summary>Gets or sets the label for the key.</summary>
		///         <value>The label for the key.</value>
		string Label { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key is permanent.</summary>
		///         <value>A Boolean value that controls whether the key is permanent.</value>
		bool IsPermanent { get; set; }

		/// <summary>Gets or sets the application's private tag.</summary>
		///         <value>The application's private tag.</value>
		NSData ApplicationTag { get; set; }

		/// <summary>Gets or sets a value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</summary>
		///         <value>A value that describes the minimum size of attack that can defeat the key. This value can be significantly smaller than the actual key size.</value>
		int EffectiveKeySize { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for encryption.</summary>
		///         <value>A Boolean value that controls whether the key can be used for encryption.</value>
		bool CanEncrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for decryption.</summary>
		///         <value>A  Boolean value that controls whether the key can be used for decryption.</value>
		bool CanDecrypt { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key derivation.</summary>
		///         <value>A  Boolean value that controls whether the key can be used for key derivation.</value>
		bool CanDerive { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for signing.</summary>
		///         <value>A Boolean value that controls whether the key can be used for signing.</value>
		bool CanSign { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for verifying signatures.</summary>
		///         <value>A Boolean value that controls whether the key can be used for verifying signatures.</value>
		bool CanVerify { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key wrapping.</summary>
		///         <value>A Boolean value that controls whether the key can be used for key wrapping.</value>
		bool CanWrap { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the key can be used for key unwrapping.</summary>
		///         <value>A Boolean value that controls whether the key can be used for key unwrapping.</value>
		bool CanUnwrap { get; set; }
	}

	[Static]
	[Internal]
	interface SecAttributeKey {
		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessible")]
		IntPtr Accessible { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrSynchronizableAny")]
		IntPtr SynchronizableAny { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrSynchronizable")]
		IntPtr Synchronizable { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrSyncViewHint")]
		IntPtr SyncViewHint { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessGroup")]
		IntPtr AccessGroup { get; }

		[Field ("kSecAttrCreationDate")]
		IntPtr CreationDate { get; }

		[Field ("kSecAttrModificationDate")]
		IntPtr ModificationDate { get; }

		[Field ("kSecAttrDescription")]
		IntPtr Description { get; }

		[Field ("kSecAttrComment")]
		IntPtr Comment { get; }

		[Field ("kSecAttrCreator")]
		IntPtr Creator { get; }

		[Field ("kSecAttrType")]
		IntPtr Type { get; }

		[Field ("kSecAttrIsInvisible")]
		IntPtr IsInvisible { get; }

		[Field ("kSecAttrIsNegative")]
		IntPtr IsNegative { get; }

		[Field ("kSecAttrAccount")]
		IntPtr Account { get; }

		[Field ("kSecAttrService")]
		IntPtr Service { get; }

		[Field ("kSecAttrGeneric")]
		IntPtr Generic { get; }

		[Field ("kSecAttrSecurityDomain")]
		IntPtr SecurityDomain { get; }

		[Field ("kSecAttrServer")]
		IntPtr Server { get; }

		[Field ("kSecAttrProtocol")]
		IntPtr Protocol { get; }

		[Field ("kSecAttrAuthenticationType")]
		IntPtr AuthenticationType { get; }

		[Field ("kSecAttrPort")]
		IntPtr Port { get; }

		[Field ("kSecAttrPath")]
		IntPtr Path { get; }

		[Field ("kSecAttrSubject")]
		IntPtr Subject { get; }

		[Field ("kSecAttrIssuer")]
		IntPtr Issuer { get; }

		[Field ("kSecAttrSerialNumber")]
		IntPtr SerialNumber { get; }

		[Field ("kSecAttrSubjectKeyID")]
		IntPtr SubjectKeyID { get; }

		[Field ("kSecAttrPublicKeyHash")]
		IntPtr PublicKeyHash { get; }

		[Field ("kSecAttrCertificateType")]
		IntPtr CertificateType { get; }

		[Field ("kSecAttrCertificateEncoding")]
		IntPtr CertificateEncoding { get; }

		[Field ("kSecAttrKeyClass")]
		IntPtr KeyClass { get; }

		[Field ("kSecAttrApplicationLabel")]
		IntPtr ApplicationLabel { get; }

		[Field ("kSecAttrIsSensitive")]
		IntPtr IsSensitive { get; }

		[Field ("kSecAttrIsExtractable")]
		IntPtr IsExtractable { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrTokenIDSecureEnclave")]
		IntPtr SecureEnclave { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecAttrAccessGroupToken")]
		IntPtr AccessGroupToken { get; }

		// note: 'kSecAttrPersistantReference' with the word "persistent" (correct) written with an 'a', so "persistant" (incorrect) was a typo in Xcode 9 beta 1
		[MacCatalyst (13, 1)]
		[Field ("kSecAttrPersistentReference")]
		IntPtr PersistentReference { get; }
	}

	[Static]
	[Internal]
	interface SecClass {
		[Field ("kSecClass")]
		IntPtr SecClassKey { get; }

		[Field ("kSecClassGenericPassword")]
		IntPtr GenericPassword { get; }

		[Field ("kSecClassInternetPassword")]
		IntPtr InternetPassword { get; }

		[Field ("kSecClassCertificate")]
		IntPtr Certificate { get; }

		[Field ("kSecClassKey")]
		IntPtr Key { get; }

		[Field ("kSecClassIdentity")]
		IntPtr Identity { get; }
	}

	// Technically the type could be static but Apple might had non static members in future releases and break out API
	[DisableDefaultCtor] // not required, nor useful
	[Partial]
	interface SecImportExport {
		/// <summary>Represents the value associated with the constant kSecImportExportPassphrase</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportExportPassphrase")]
		NSString Passphrase { get; }

		[NoiOS, NoTV, NoMacCatalyst]
		[Field ("kSecImportExportKeychain")]
		NSString Keychain { get; }

		[NoiOS, NoTV, NoMacCatalyst]
		[Field ("kSecImportExportAccess")]
		NSString Access { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kSecImportToMemoryOnly")]
		NSString ToMemoryOnly { get; }

		/// <summary>Represents the value associated with the constant kSecImportItemLabel</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportItemLabel")]
		NSString Label { get; }

		/// <summary>Represents the value associated with the constant kSecImportItemKeyID</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportItemKeyID")]
		NSString KeyId { get; }

		/// <summary>Represents the value associated with the constant kSecImportItemTrust</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportItemTrust")]
		NSString Trust { get; }

		/// <summary>Represents the value associated with the constant kSecImportItemCertChain</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportItemCertChain")]
		NSString CertChain { get; }

		/// <summary>Represents the value associated with the constant kSecImportItemIdentity</summary>
		///         <value>
		///         </value>
		[Field ("kSecImportItemIdentity")]
		NSString Identity { get; }
	}

	[Static]
	[Internal]
	interface SecItem {
		[Field ("kSecMatchPolicy")]
		IntPtr MatchPolicy { get; }

		[Field ("kSecMatchItemList")]
		IntPtr MatchItemList { get; }

		[Field ("kSecMatchSearchList")]
		IntPtr MatchSearchList { get; }

		[Field ("kSecMatchIssuers")]
		IntPtr MatchIssuers { get; }

		[Field ("kSecMatchEmailAddressIfPresent")]
		IntPtr MatchEmailAddressIfPresent { get; }

		[Field ("kSecMatchSubjectContains")]
		IntPtr MatchSubjectContains { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("kSecMatchHostOrSubdomainOfHost")]
		IntPtr MatchHostOrSubdomainOfHost { get; }

		[NoiOS, NoTV, NoMacCatalyst]
		[Field ("kSecMatchSubjectStartsWith")]
		IntPtr MatchSubjectStartsWith { get; }

		[NoiOS, NoTV, NoMacCatalyst]
		[Field ("kSecMatchSubjectEndsWith")]
		IntPtr MatchSubjectEndsWith { get; }

		[NoiOS, NoTV, NoMacCatalyst]
		[Field ("kSecMatchSubjectWholeString")]
		IntPtr MatchSubjectWholeString { get; }

		[Field ("kSecMatchCaseInsensitive")]
		IntPtr MatchCaseInsensitive { get; }

		[Field ("kSecMatchTrustedOnly")]
		IntPtr MatchTrustedOnly { get; }

		[Field ("kSecMatchValidOnDate")]
		IntPtr MatchValidOnDate { get; }

		[Field ("kSecMatchLimit")]
		IntPtr MatchLimit { get; }

		[Field ("kSecReturnData")]
		IntPtr ReturnData { get; }

		[Field ("kSecReturnAttributes")]
		IntPtr ReturnAttributes { get; }

		[Field ("kSecReturnRef")]
		IntPtr ReturnRef { get; }

		[Field ("kSecReturnPersistentRef")]
		IntPtr ReturnPersistentRef { get; }

		[Field ("kSecValueData")]
		IntPtr ValueData { get; }

		[Field ("kSecValueRef")]
		IntPtr ValueRef { get; }

		[Field ("kSecValuePersistentRef")]
		IntPtr ValuePersistentRef { get; }

		[Field ("kSecUseItemList")]
		IntPtr UseItemList { get; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[MacCatalyst (13, 1)]
		[Field ("kSecUseDataProtectionKeychain")]
		IntPtr UseDataProtectionKeychain { get; }

		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use 'LAContext.InteractionNotAllowed' instead.")]
		[Deprecated (PlatformName.iOS, 14, 0, message: "Use 'LAContext.InteractionNotAllowed' instead.")]
		[Deprecated (PlatformName.TvOS, 14, 0, message: "Use 'LAContext.InteractionNotAllowed' instead.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use 'LAContext.InteractionNotAllowed' instead.")]
		[Field ("kSecUseOperationPrompt")]
		IntPtr UseOperationPrompt { get; }

		[Deprecated (PlatformName.iOS, 9, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 11)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSecUseNoAuthenticationUI")]
		IntPtr UseNoAuthenticationUI { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecUseAuthenticationUI")]
		IntPtr UseAuthenticationUI { get; }

		[MacCatalyst (13, 1)]
		[Field ("kSecUseAuthenticationContext")]
		IntPtr UseAuthenticationContext { get; }

		[TV (17, 0), NoMacCatalyst, NoMac, NoiOS]
		[Field ("kSecUseUserIndependentKeychain")]
		IntPtr UseUserIndependentKeychain { get; }
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[Static]
	[Internal]
	interface SecCertificateOIDs {
		[Field ("kSecOIDX509V1SubjectPublicKey")]
		IntPtr SubjectPublicKey { get; }
	}

	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	[Static]
	[Internal]
	interface SecPropertyKey {
		[Field ("kSecPropertyKeyType")]
		IntPtr Type { get; }

		[Field ("kSecPropertyKeyLabel")]
		IntPtr Label { get; }

		[Field ("kSecPropertyKeyLocalizedLabel")]
		IntPtr LocalizedLabel { get; }

		[Field ("kSecPropertyKeyValue")]
		IntPtr Value { get; }
	}

	[MacCatalyst (13, 1)]
	enum SecKeyAlgorithm {
		/// <summary>RSA raw signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureRaw")]
		RsaSignatureRaw,

		/// <summary>RSA PKCS1v1.5 raw digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw")]
		RsaSignatureDigestPkcs1v15Raw,

		/// <summary>RSA PKCS1v1.5 SHA-1 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1")]
		RsaSignatureDigestPkcs1v15Sha1,

		/// <summary>RSA PKCS1v1.5 SHA-224 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224")]
		RsaSignatureDigestPkcs1v15Sha224,

		/// <summary>RSA PKCS1v1.5 SHA-256 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256")]
		RsaSignatureDigestPkcs1v15Sha256,

		/// <summary>RSA PKCS1v1.5 SHA-384 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384")]
		RsaSignatureDigestPkcs1v15Sha384,

		/// <summary>RSA PKCS1v1.5 SHA-512 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512")]
		RsaSignatureDigestPkcs1v15Sha512,

		/// <summary>RSA PKCS1v1.5 SHA-1 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1")]
		RsaSignatureMessagePkcs1v15Sha1,

		/// <summary>RSA PKCS1v1.5 SHA-224 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224")]
		RsaSignatureMessagePkcs1v15Sha224,

		/// <summary>RSA PKCS1v1.5 SHA-256 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256")]
		RsaSignatureMessagePkcs1v15Sha256,

		/// <summary>RSA PKCS1v1.5 SHA-384 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384")]
		RsaSignatureMessagePkcs1v15Sha384,

		/// <summary>RSA PKCS1v1.5 SHA-512 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512")]
		RsaSignatureMessagePkcs1v15Sha512,

		/// <summary>RSA PSS SHA-1 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureRFC4754")]
		EcdsaSignatureRfc4754,

		/// <summary>RSA PSS SHA-224 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962")]
		EcdsaSignatureDigestX962,

		/// <summary>RSA PSS SHA-256 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA1")]
		EcdsaSignatureDigestX962Sha1,

		/// <summary>RSA PSS SHA-384 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA224")]
		EcdsaSignatureDigestX962Sha224,

		/// <summary>RSA PSS SHA-512 message signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA256")]
		EcdsaSignatureDigestX962Sha256,

		/// <summary>RSA PSS SHA-1 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA384")]
		EcdsaSignatureDigestX962Sha384,

		/// <summary>RSA PSS SHA-224 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA512")]
		EcdsaSignatureDigestX962Sha512,

		/// <summary>RSA PSS SHA-256 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA1")]
		EcdsaSignatureMessageX962Sha1,

		/// <summary>RSA PSS SHA-384 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA224")]
		EcdsaSignatureMessageX962Sha224,

		/// <summary>RSA PSS SHA-512 digest signature algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA256")]
		EcdsaSignatureMessageX962Sha256,

		/// <summary>ECDSA signature with SHA-1 message algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA384")]
		EcdsaSignatureMessageX962Sha384,

		/// <summary>ECDSA signature with SHA-224 message algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA512")]
		EcdsaSignatureMessageX962Sha512,

		/// <summary>ECDSA signature with SHA-256 message algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionRaw")]
		RsaEncryptionRaw,

		/// <summary>ECDSA signature with SHA-384 message algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionPKCS1")]
		RsaEncryptionPkcs1,

		/// <summary>ECDSA signature with SHA-512 message algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1")]
		RsaEncryptionOaepSha1,

		/// <summary>ECDSA signature with SHA-1 digest algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224")]
		RsaEncryptionOaepSha224,

		/// <summary>ECDSA signature with SHA-224 digest algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256")]
		RsaEncryptionOaepSha256,

		/// <summary>ECDSA signature with SHA-256 digest algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384")]
		RsaEncryptionOaepSha384,

		/// <summary>ECDSA signature with SHA-384 digest algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512")]
		RsaEncryptionOaepSha512,

		/// <summary>ECDSA signature with SHA-512 digest algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM")]
		RsaEncryptionOaepSha1AesCgm,

		/// <summary>RSA PKCS1 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM")]
		RsaEncryptionOaepSha224AesGcm,

		/// <summary>RSA OAEP SHA-1 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM")]
		RsaEncryptionOaepSha256AesGcm,

		/// <summary>RSA OAEP SHA-224 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM")]
		RsaEncryptionOaepSha384AesGcm,

		/// <summary>RSA OAEP SHA-256 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM")]
		RsaEncryptionOaepSha512AesGcm,

		/// <summary>RSA OAEP SHA-384 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM")]
		EciesEncryptionStandardX963Sha1AesGcm,

		/// <summary>RSA OAEP SHA-512 encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM")]
		EciesEncryptionStandardX963Sha224AesGcm,

		/// <summary>RSA OAEP SHA-1 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM")]
		EciesEncryptionStandardX963Sha256AesGcm,

		/// <summary>RSA OAEP SHA-224 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM")]
		EciesEncryptionStandardX963Sha384AesGcm,

		/// <summary>RSA OAEP SHA-256 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM")]
		EciesEncryptionStandardX963Sha512AesGcm,

		/// <summary>RSA OAEP SHA-384 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM")]
		EciesEncryptionCofactorX963Sha1AesGcm,

		
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM")]
		EciesEncryptionCofactorX963Sha224AesGcm,

		/// <summary>ECIES cofactor X9.63 SHA-224 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM")]
		EciesEncryptionCofactorX963Sha256AesGcm,

		/// <summary>ECIES cofactor X9.63 SHA-256 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM")]
		EciesEncryptionCofactorX963Sha384AesGcm,

		/// <summary>ECIES cofactor X9.63 SHA-384 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM")]
		EciesEncryptionCofactorX963Sha512AesGcm,

		/// <summary>ECIES cofactor X9.63 SHA-512 AESGCM encryption algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandard")]
		EcdhKeyExchangeStandard,

		/// <summary>ECDH standard key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1")]
		EcdhKeyExchangeStandardX963Sha1,

		/// <summary>ECDH standard X9.63 SHA-1 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224")]
		EcdhKeyExchangeStandardX963Sha224,

		/// <summary>ECDH standard X9.63 SHA-224 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256")]
		EcdhKeyExchangeStandardX963Sha256,

		/// <summary>ECDH standard X9.63 SHA-256 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384")]
		EcdhKeyExchangeStandardX963Sha384,

		/// <summary>ECDH standard X9.63 SHA-384 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512")]
		EcdhKeyExchangeStandardX963Sha512,

		/// <summary>ECDH standard X9.63 SHA-512 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactor")]
		EcdhKeyExchangeCofactor,

		/// <summary>ECDH cofactor key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1")]
		EcdhKeyExchangeCofactorX963Sha1,

		/// <summary>ECDH cofactor X9.63 SHA-1 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224")]
		EcdhKeyExchangeCofactorX963Sha224,

		/// <summary>ECDH cofactor X9.63 SHA-224 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256")]
		EcdhKeyExchangeCofactorX963Sha256,

		/// <summary>ECDH cofactor X9.63 SHA-256 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384")]
		EcdhKeyExchangeCofactorX963Sha384,

		/// <summary>ECDH cofactor X9.63 SHA-384 key exchange algorithm.</summary>
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512")]
		EcdhKeyExchangeCofactorX963Sha512,

		/// <summary>ECDH cofactor X9.63 SHA-512 key exchange algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA1")]
		RsaSignatureDigestPssSha1,

		/// <summary>ECIES standard variable IV X9.63 SHA-224 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA224")]
		RsaSignatureDigestPssSha224,

		/// <summary>ECIES standard variable IV X9.63 SHA-256 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA256")]
		RsaSignatureDigestPssSha256,

		/// <summary>ECIES standard variable IV X9.63 SHA-384 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA384")]
		RsaSignatureDigestPssSha384,

		/// <summary>ECIES standard variable IV X9.63 SHA-512 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA512")]
		RsaSignatureDigestPssSha512,

		/// <summary>ECIES cofactor variable IV X9.63 SHA-224 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA1")]
		RsaSignatureMessagePssSha1,

		/// <summary>ECIES cofactor variable IV X9.63 SHA-256 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA224")]
		RsaSignatureMessagePssSha224,

		/// <summary>ECIES cofactor variable IV X9.63 SHA-384 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA256")]
		RsaSignatureMessagePssSha256,

		/// <summary>ECIES cofactor variable IV X9.63 SHA-512 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA384")]
		RsaSignatureMessagePssSha384,

		/// <summary>ECIES standard compact variable IV X9.63 SHA-224 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA512")]
		RsaSignatureMessagePssSha512,

		/// <summary>ECIES standard compact variable IV X9.63 SHA-256 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM")]
		EciesEncryptionStandardVariableIvx963Sha224AesGcm,

		/// <summary>ECIES standard compact variable IV X9.63 SHA-384 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM")]
		EciesEncryptionStandardVariableIvx963Sha256AesGcm,

		/// <summary>ECIES standard compact variable IV X9.63 SHA-512 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM")]
		EciesEncryptionStandardVariableIvx963Sha384AesGcm,

		/// <summary>ECIES cofactor compact variable IV X9.63 SHA-224 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM")]
		EciesEncryptionStandardVariableIvx963Sha512AesGcm,

		/// <summary>ECIES cofactor compact variable IV X9.63 SHA-256 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM")]
		EciesEncryptionCofactorVariableIvx963Sha224AesGcm,

		/// <summary>ECIES cofactor compact variable IV X9.63 SHA-384 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM")]
		EciesEncryptionCofactorVariableIvx963Sha256AesGcm,

		/// <summary>ECIES cofactor compact variable IV X9.63 SHA-512 AESGCM encryption algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM")]
		EciesEncryptionCofactorVariableIvx963Sha384AesGcm,

		/// <summary>ECDSA signature raw digest algorithm.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM")]
		EciesEncryptionCofactorVariableIvx963Sha512AesGcm,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754")]
		EcdsaSignatureDigestRfc4754,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA1")]
		EcdsaSignatureDigestRfc4754Sha1,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA224")]
		EcdsaSignatureDigestRfc4754Sha224,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA256")]
		EcdsaSignatureDigestRfc4754Sha256,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA384")]
		EcdsaSignatureDigestRfc4754Sha384,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestRFC4754SHA512")]
		EcdsaSignatureDigestRfc4754Sha512,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA1")]
		EcdsaSignatureMessageRfc4754Sha1,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA224")]
		EcdsaSignatureMessageRfc4754Sha224,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA256")]
		EcdsaSignatureMessageRfc4754Sha256,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA384")]
		EcdsaSignatureMessageRfc4754Sha384,

		[TV (17, 0), Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageRFC4754SHA512")]
		EcdsaSignatureMessageRfc4754Sha512,
	}

	[MacCatalyst (13, 1)]
	enum SslSessionConfig {
		/// <summary>Developers should not use this deprecated field. </summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSSLSessionConfig_default")]
		Default,

		/// <summary>ATS v1 session configuration.</summary>
		[Field ("kSSLSessionConfig_ATSv1")]
		Ats1,

		/// <summary>ATS v1 without Perfect Forward Secrecy session configuration.</summary>
		[Field ("kSSLSessionConfig_ATSv1_noPFS")]
		Ats1NoPfs,

		/// <summary>Standard session configuration.</summary>
		[Field ("kSSLSessionConfig_standard")]
		Standard,

		/// <summary>RC4 fallback session configuration.</summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSSLSessionConfig_RC4_fallback")]
		RC4Fallback,

		/// <summary>TLS v1 fallback session configuration.</summary>
		[Field ("kSSLSessionConfig_TLSv1_fallback")]
		Tls1Fallback,

		/// <summary>TLS v1 RC4 fallback session configuration.</summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSSLSessionConfig_TLSv1_RC4_fallback")]
		Tls1RC4Fallback,

		/// <summary>Legacy session configuration.</summary>
		[Field ("kSSLSessionConfig_legacy")]
		Legacy,

		/// <summary>Legacy DHE session configuration.</summary>
		[Field ("kSSLSessionConfig_legacy_DHE")]
		LegacyDhe,

		/// <summary>Anonymous session configuration.</summary>
		[Field ("kSSLSessionConfig_anonymous")]
		Anonymous,

		/// <summary>3DES fallback session configuration.</summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSSLSessionConfig_3DES_fallback")]
		ThreeDesFallback,

		/// <summary>TLS v1 3DES fallback session configuration.</summary>
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.TvOS, 11, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Field ("kSSLSessionConfig_TLSv1_3DES_fallback")]
		Tls1ThreeDesFallback,
	}

	[MacCatalyst (13, 1)]
	[Internal]
	[Static]
	interface SecKeyKeyExchangeParameterKey {
		[Field ("kSecKeyKeyExchangeParameterRequestedSize")]
		NSString RequestedSizeKey { get; }

		[Field ("kSecKeyKeyExchangeParameterSharedInfo")]
		NSString SharedInfoKey { get; }
	}

	[MacCatalyst (13, 1)]
	[StrongDictionary ("SecKeyKeyExchangeParameterKey")]
	interface SecKeyKeyExchangeParameter {

		/// <summary>Gets or sets the requested size for key exchange.</summary>
		int RequestedSize { get; set; }

		/// <summary>Gets or sets the shared info data for key exchange.</summary>
		NSData SharedInfo { get; set; }
	}

	[NoTV]
	[MacCatalyst (13, 1)]
	[Internal]
	[Static]
	interface SecSharedCredentialKeys {
		[Field ("kSecAttrServer")]
		NSString ServerKey { get; }

		[Field ("kSecAttrAccount")]
		NSString AccountKey { get; }

		[MacCatalyst (14, 0)]
		[Field ("kSecSharedPassword")]
		NSString PasswordKey { get; }

		[Field ("kSecAttrPort")]
		NSString PortKey { get; }
	}

	[NoTV]
	[MacCatalyst (13, 1)]
	[StrongDictionary ("SecSharedCredentialKeys")]
	interface SecSharedCredentialInfo {

		/// <summary>Gets or sets the server name.</summary>
		string Server { get; set; }

		/// <summary>Gets or sets the account name.</summary>
		string Account { get; set; }

		/// <summary>Gets or sets the password.</summary>
		string Password { get; set; }

		/// <summary>Gets or sets the port number.</summary>
		int Port { get; set; }
	}

	delegate void SecProtocolVerifyComplete (bool complete);

	// Respond with the identity to use for this challenge.
	delegate void SecProtocolChallengeComplete (SecIdentity2 identity);

	delegate void SecProtocolPreSharedKeySelectionComplete ([NullAllowed] DispatchData psk_identity);
	//
	// These are fake NSObject types, used purely for the generator to do all the heavy lifting with block generation
	//
	delegate void SecProtocolKeyUpdate (SecProtocolMetadata metadata, [BlockCallback] Action complete);
	delegate void SecProtocolChallenge (SecProtocolMetadata metadata, [BlockCallback] SecProtocolChallengeComplete challengeComplete);
	delegate void SecProtocolVerify (SecProtocolMetadata metadata, SecTrust2 trust, [BlockCallback] SecProtocolVerifyComplete verifyComplete);
	delegate void SecProtocolPreSharedKeySelection (SecProtocolMetadata metadata, [NullAllowed] DispatchData psk_identity_hint, [BlockCallback] SecProtocolPreSharedKeySelectionComplete complete);

	[Internal]
	[Partial]
	interface Callbacks {
		[Export ("options:keyUpdateBlock:keyUpdateQueue:")]
		[NoMethod]
		void SetKeyUpdateBlock (SecProtocolOptions options, [BlockCallback] SecProtocolKeyUpdate keyUpdateBlock, DispatchQueue keyUpdateQueue);

		[Export ("options:challengeBlock:challengeQueue:")]
		[NoMethod]
		void SetChallengeBlock (SecProtocolOptions options, [BlockCallback] SecProtocolChallenge challengeBlock, DispatchQueue challengeQueue);

		[Export ("options:protocolVerify:verifyQueue:")]
		[NoMethod]
		void SetVerifyBlock (SecProtocolOptions options, [BlockCallback] SecProtocolVerify verifyBlock, DispatchQueue verifyQueue);

		[Export ("options:pskSelectionBlock:pskSelectionQueue:")]
		[NoMethod]
		void SetProtocolPreSharedKeySelectionBlock (SecProtocolOptions options, [BlockCallback] SecProtocolPreSharedKeySelection pskSelectionBlock, DispatchQueue pskSelectionQueue);
	}
}
