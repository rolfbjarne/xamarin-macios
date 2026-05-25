//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Security {
	/// <summary>Status return from the SecKeyChain operations.</summary>
	public enum SecStatusCode : int {
		/// <summary>Success, there was no error.</summary>
		Success = 0,
		/// <summary>The specified feature is not implemented.</summary>
		Unimplemented = -4,
		/// <summary>Indicates that the disk was full.</summary>
		DiskFull = -34,
		/// <summary>Indicates an IO error.</summary>
		IO = -36,
		/// <summary>Indicates that a file is already open with read and write privileges.</summary>
		OpWr = -49,
		/// <summary>Invalid or incomplete parameters passed.</summary>
		Param = -50,
		/// <summary>Indicates that write permissions are already granted.</summary>
		WritePermissions = -61,
		/// <summary>Failure to allocate memory.</summary>
		Allocate = -108,
		/// <summary>Indicates that the user cancelled the operation.</summary>
		UserCanceled = -128,
		/// <summary>Indicates that authentication failed.</summary>
		BadReq = -909,
		/// <summary>Indicates an unspecified error in an internal component.</summary>
		InternalComponent = -2070,
		/// <summary>Indicates that an unknown Core Foundation error occurred.</summary>
		CoreFoundationUnknown = -4960,
		/// <summary>Indicates that a trust results were not available.</summary>
		NotAvailable = -25291,
		/// <summary>The keychain is read only.</summary>
		ReadOnly = -25292,
		/// <summary>Authentication failed.</summary>
		AuthFailed = -25293,
		/// <summary>The keychain specified does not exist.</summary>
		NoSuchKeyChain = -25294,
		/// <summary>The keychain provided is invalid.</summary>
		InvalidKeyChain = -25295,
		/// <summary>Duplicated key chain.</summary>
		DuplicateKeyChain = -25296,
		/// <summary>The item is duplicated.</summary>
		DuplicateItem = -25299,
		/// <summary>The item was not found.</summary>
		ItemNotFound = -25300,
		/// <summary>Indicates that the interaction with the Security Server was not allowed.</summary>
		InteractionNotAllowed = -25308,
		/// <summary>Indicates that data could not be decoded.</summary>
		Decode = -26275,
		/// <summary>Indicates that a callback was duplicated</summary>
		DuplicateCallback = -25297,
		/// <summary>Indicates that a callback was not valid.</summary>
		InvalidCallback = -25298,
		/// <summary>Indicates that a buffer was too small.</summary>
		BufferTooSmall = -25301,
		/// <summary>Indicates that data were too large.</summary>
		DataTooLarge = -25302,
		/// <summary>Indicates that no such attribute was found.</summary>
		NoSuchAttribute = -25303,
		/// <summary>Indicates an invalid item reference.</summary>
		InvalidItemRef = -25304,
		/// <summary>Indicates an invalid search reference.</summary>
		InvalidSearchRef = -25305,
		/// <summary>Indicates that no such class was found.</summary>
		NoSuchClass = -25306,
		/// <summary>Indicates that no default key chain was found.</summary>
		NoDefaultKeychain = -25307,
		/// <summary>Indicates that an attribute is read-only.</summary>
		ReadOnlyAttribute = -25309,
		/// <summary>Indicates that the wrong security version was encountered.</summary>
		WrongSecVersion = -25310,
		/// <summary>Indicates that a key's size was not supported.</summary>
		KeySizeNotAllowed = -25311,
		/// <summary>Indicates that no storage module was found.</summary>
		NoStorageModule = -25312,
		/// <summary>Indicates that no certificate module was found.</summary>
		NoCertificateModule = -25313,
		/// <summary>Indicates that no policy module was found.</summary>
		NoPolicyModule = -25314,
		/// <summary>Indicates that user interaction was required.</summary>
		InteractionRequired = -25315,
		/// <summary>Indicates that certain data were not available.</summary>
		DataNotAvailable = -25316,
		/// <summary>Indicates that data could not be modified.</summary>
		DataNotModifiable = -25317,
		/// <summary>Indicates that the certificate chain failed.</summary>
		CreateChainFailed = -25318,
		/// <summary>Indicates an invalid preferences domain.</summary>
		InvalidPrefsDomain = -25319,
		/// <summary>Indicates that a dark wake state prevented a UI from being displayed.</summary>
		InDarkWake = -25320,
		/// <summary>Indicates that the ACL was not in its canonical form.</summary>
		ACLNotSimple = -25240,
		/// <summary>Indicates that a trust policy could not be found.</summary>
		PolicyNotFound = -25241,
		/// <summary>Indicates an invalid trust setting.</summary>
		InvalidTrustSetting = -25242,
		/// <summary>Indicates that an item does not have access control.</summary>
		NoAccessForItem = -25243,
		/// <summary>Indicates an invalid owner change.</summary>
		InvalidOwnerEdit = -25244,
		/// <summary>Indicates that trust results are not available.</summary>
		TrustNotAvailable = -25245,
		/// <summary>Indicates that an unsupported format was encountered.</summary>
		UnsupportedFormat = -25256,
		/// <summary>Indicates that an unknown format was encountered.</summary>
		UnknownFormat = -25257,
		/// <summary>Indicates that an attempt was made to send a sensitive key unwrapped.</summary>
		KeyIsSensitive = -25258,
		/// <summary>Indicates that a module failed to load.</summary>
		MultiplePrivateKeys = -25259,
		/// <summary>Indicates that a pass phrase is required.</summary>
		PassphraseRequired = -25260,
		/// <summary>Indicates an invalid password reference.</summary>
		InvalidPasswordRef = -25261,
		/// <summary>Indicates invalid trust settings.</summary>
		InvalidTrustSettings = -25262,
		/// <summary>Indicates that trust settings were not found.</summary>
		NoTrustSettings = -25263,
		/// <summary>Indicates that a PKCS12 import failure caused a MAC failure.</summary>
		Pkcs12VerifyFailure = -25264,
		/// <summary>Indicates that the parent of the certificate is not actually the signer.</summary>
		NotSigner = -26267,
		/// <summary>To be added.</summary>
		MissingEntitlement = -34018,
		RestrictedApi = -34020,
		/// <summary>Indicates that a service was not available.</summary>
		ServiceNotAvailable = -67585,
		/// <summary>Indicates that a client ID was wrong.</summary>
		InsufficientClientID = -67586,
		/// <summary>Indicates that a device reset.</summary>
		DeviceReset = -67587,
		/// <summary>Indicates that a device failed.</summary>
		DeviceFailed = -67588,
		/// <summary>Indicates that an application ACL subject could not be added..</summary>
		AppleAddAppACLSubject = -67589,
		/// <summary>Indicates that a public key was incomplete.</summary>
		ApplePublicKeyIncomplete = -67590,
		/// <summary>Indicates a signature mismatch.</summary>
		AppleSignatureMismatch = -67591,
		/// <summary>Indicates that the start date for a key was invalid.</summary>
		AppleInvalidKeyStartDate = -67592,
		/// <summary>Indicates that the end date for a key was invalid.</summary>
		AppleInvalidKeyEndDate = -67593,
		/// <summary>Indicates that a conversion error occurred.</summary>
		ConversionError = -67594,
		/// <summary>Indicates that rollback to SSLv2 encountered an error.</summary>
		AppleSSLv2Rollback = -67595,
		/// <summary>Indicates that a quota was exceeded.</summary>
		QuotaExceeded = -67596,
		/// <summary>Indicates that a file was too large.</summary>
		FileTooBig = -67597,
		/// <summary>Indicates that a database blob ws not valid.</summary>
		InvalidDatabaseBlob = -67598,
		/// <summary>Indicates an invalid key blob.</summary>
		InvalidKeyBlob = -67599,
		/// <summary>Indicates that a database blob was not compatible.</summary>
		IncompatibleDatabaseBlob = -67600,
		/// <summary>Indicates that a database key blob was incompatible.</summary>
		IncompatibleKeyBlob = -67601,
		/// <summary>Indicates that a hostname mismatch occurred.</summary>
		HostNameMismatch = -67602,
		/// <summary>Indicates that an unknown critical extension flag was encountered</summary>
		UnknownCriticalExtensionFlag = -67603,
		/// <summary>Indicates that basic constraints were not found.</summary>
		NoBasicConstraints = -67604,
		/// <summary>Indicates that no basic CA constraints were found.</summary>
		NoBasicConstraintsCA = -67605,
		/// <summary>Indicates that the authority key ID was not valid.</summary>
		InvalidAuthorityKeyID = -67606,
		/// <summary>Indicates an invalid subject key ID.</summary>
		InvalidSubjectKeyID = -67607,
		/// <summary>Indicates an invalid key usage for a particular policy.</summary>
		InvalidKeyUsageForPolicy = -67608,
		/// <summary>Indicate an invalid extended key usage.</summary>
		InvalidExtendedKeyUsage = -67609,
		/// <summary>Indicates an invalid linkage to an ID.</summary>
		InvalidIDLinkage = -67610,
		/// <summary>Indicates that a path was too long.</summary>
		PathLengthConstraintExceeded = -67611,
		/// <summary>Indicates an invalid root.</summary>
		InvalidRoot = -67612,
		/// <summary>Indicates that a CRL was expired.</summary>
		CRLExpired = -67613,
		/// <summary>Indicates that a CRL was not yet valid.</summary>
		CRLNotValidYet = -67614,
		/// <summary>Indicates that a CRL could not be found.</summary>
		CRLNotFound = -67615,
		/// <summary>Indicates that a CRL server was down.</summary>
		CRLServerDown = -67616,
		/// <summary>Indicates that a URI was bad.</summary>
		CRLBadURI = -67617,
		/// <summary>Indicates that an unknown certificate extension was encountered.</summary>
		UnknownCertExtension = -67618,
		/// <summary>Indicates that an unknown CRL extension was encountered.</summary>
		UnknownCRLExtension = -67619,
		/// <summary>Indicates that a CRL was untrusted.</summary>
		CRLNotTrusted = -67620,
		/// <summary>Indicates that a CRL revocation policy failed.</summary>
		CRLPolicyFailed = -67621,
		/// <summary>Indicates that the issuing distribution point was not valid.</summary>
		IDPFailure = -67622,
		/// <summary>Indicates that a email addresses could not be found.</summary>
		SMIMEEmailAddressesNotFound = -67623,
		/// <summary>Indicates that a bad SMIME extended key usage was encountered.</summary>
		SMIMEBadExtendedKeyUsage = -67624,
		/// <summary>Indicates that a bad SMIME key usage was encountered.</summary>
		SMIMEBadKeyUsage = -67625,
		/// <summary>Indicates that a critical SMIME extended key usage was encountered where prohibited.</summary>
		SMIMEKeyUsageNotCritical = -67626,
		/// <summary>Indicates that the certificate did not contain the email address.</summary>
		SMIMENoEmailAddress = -67627,
		/// <summary>Indicates that the alternative name for the subject field was not critical.</summary>
		SMIMESubjAltNameNotCritical = -67628,
		/// <summary>Indicates that a bad extended key usage was encountered.</summary>
		SSLBadExtendedKeyUsage = -67629,
		/// <summary>Indicates that an OCSP response is bad.</summary>
		OCSPBadResponse = -67630,
		/// <summary>Indicates that an OCSP request is bad.</summary>
		OCSPBadRequest = -67631,
		/// <summary>Indicates that an OCSP server is not available.</summary>
		OCSPUnavailable = -67632,
		/// <summary>Indicates that an OCSP responder did not recognize a certificate.</summary>
		OCSPStatusUnrecognized = -67633,
		/// <summary>Indicates that the end of data was unexpectedly reached.</summary>
		EndOfData = -67634,
		/// <summary>Indicates a certificate revocation check was incomplete.</summary>
		IncompleteCertRevocationCheck = -67635,
		/// <summary>Indicates a network failure.</summary>
		NetworkFailure = -67636,
		/// <summary>Indicates that an OCSP response is not trusted back to an anchor.</summary>
		OCSPNotTrustedToAnchor = -67637,
		/// <summary>Indicates that a record was modified.</summary>
		RecordModified = -67638,
		/// <summary>Indicates an invalid OCSP response signature.</summary>
		OCSPSignatureError = -67639,
		/// <summary>Indicates that an OCSP response has no signer.</summary>
		OCSPNoSigner = -67640,
		/// <summary>Indicates that an OCSP responder received a malformed request.</summary>
		OCSPResponderMalformedReq = -67641,
		/// <summary>Indicates an OCSP responder internal error.</summary>
		OCSPResponderInternalError = -67642,
		/// <summary>Indicates that an OCSP responder is busy.</summary>
		OCSPResponderTryLater = -67643,
		/// <summary>Indicates than an OCSP responder requires a signature.</summary>
		OCSPResponderSignatureRequired = -67644,
		/// <summary>Indicates that an OCSP responder determined that a request was unauthorized.</summary>
		OCSPResponderUnauthorized = -67645,
		/// <summary>Indicates that an OCSP response nonce is different thatn the request's.</summary>
		OCSPResponseNonceMismatch = -67646,
		/// <summary>Indicates that the length of a code signing chain was bad.</summary>
		CodeSigningBadCertChainLength = -67647,
		/// <summary>To be added.</summary>
		CodeSigningNoBasicConstraints = -67648,
		/// <summary>Indicates that the length of a code signing path was too long.</summary>
		CodeSigningBadPathLengthConstraint = -67649,
		/// <summary>Indicates that no basic constraints were found.</summary>
		CodeSigningNoExtendedKeyUsage = -67650,
		/// <summary>Indicates that a development-only certificate was used.</summary>
		CodeSigningDevelopment = -67651,
		/// <summary>Indicates that an invalid certificate chain length was encountered.</summary>
		ResourceSignBadCertChainLength = -67652,
		/// <summary>Indicates that an invalid certificate extension key usage was encountered.</summary>
		ResourceSignBadExtKeyUsage = -67653,
		/// <summary>Indicates that the trust setting is DENY.</summary>
		TrustSettingDeny = -67654,
		/// <summary>Indicates an invalid subject name.</summary>
		InvalidSubjectName = -67655,
		/// <summary>Indicates that an unknown qualified certificate statement was encountered.</summary>
		UnknownQualifiedCertStatement = -67656,
		/// <summary>Indicates that a MobileMe request was queued.</summary>
		MobileMeRequestQueued = -67657,
		/// <summary>Indicates that a MobileMe request was redirected.</summary>
		MobileMeRequestRedirected = -67658,
		/// <summary>Indicates a MobileMe server error.</summary>
		MobileMeServerError = -67659,
		/// <summary>Indicates that a MobileMe server was not available.</summary>
		MobileMeServerNotAvailable = -67660,
		/// <summary>Indicates that no MobileMe server already exists.</summary>
		MobileMeServerAlreadyExists = -67661,
		/// <summary>Indicates a MobileMe server service error.</summary>
		MobileMeServerServiceErr = -67662,
		/// <summary>Indicates that a MobileMe request was pending.</summary>
		MobileMeRequestAlreadyPending = -67663,
		/// <summary>Indicates that no MobileMe request was pending.</summary>
		MobileMeNoRequestPending = -67664,
		/// <summary>Indicates a mobile CSVR failure.</summary>
		MobileMeCSRVerifyFailure = -67665,
		/// <summary>Indicates a MobileMe consistency check failure.</summary>
		MobileMeFailedConsistencyCheck = -67666,
		/// <summary>Indicates that the common security services manager ws not initialized.</summary>
		NotInitialized = -67667,
		/// <summary>Indicates an invalid handle usage.</summary>
		InvalidHandleUsage = -67668,
		/// <summary>Indicates that a PVC reference could not be found.</summary>
		PVCReferentNotFound = -67669,
		/// <summary>Indicates that the address of a function is outside the verified module.</summary>
		FunctionIntegrityFail = -67670,
		/// <summary>Indicates an unspecified internal error.</summary>
		InternalError = -67671,
		/// <summary>Indicates a memory error.</summary>
		MemoryError = -67672,
		/// <summary>Indicates that data were invalid.</summary>
		InvalidData = -67673,
		/// <summary>Indicates a module directory service error.</summary>
		MDSError = -67674,
		/// <summary>Indicates an invalid pointer.</summary>
		InvalidPointer = -67675,
		/// <summary>Indicates that a self-check failed.</summary>
		SelfCheckFailed = -67676,
		/// <summary>Indicates that a function failed.</summary>
		FunctionFailed = -67677,
		/// <summary>Indicates that a module manifest failed to be verified.</summary>
		ModuleManifestVerifyFailed = -67678,
		/// <summary>Indicates an invalid GUID.</summary>
		InvalidGUID = -67679,
		/// <summary>Indicates an invalid handle.</summary>
		InvalidHandle = -67680,
		/// <summary>Indicates that a database list was not valid.</summary>
		InvalidDBList = -67681,
		/// <summary>Indicates an invalid passthrough ID.</summary>
		InvalidPassthroughID = -67682,
		/// <summary>Indicates an invalid network address.</summary>
		InvalidNetworkAddress = -67683,
		/// <summary>Indicatest that the CRL was already signed.</summary>
		CRLAlreadySigned = -67684,
		/// <summary>Indicates an invalid number of fields.</summary>
		InvalidNumberOfFields = -67685,
		/// <summary>To be added.</summary>
		VerificationFailure = -67686,
		/// <summary>Indicates that an unknown tag was encountered.</summary>
		UnknownTag = -67687,
		/// <summary>Indicates an invalid signature.</summary>
		InvalidSignature = -67688,
		/// <summary>Indicates an invalid name.</summary>
		InvalidName = -67689,
		/// <summary>Indicates that the certificate reference was not valid.</summary>
		InvalidCertificateRef = -67690,
		/// <summary>Indicates that the cert group was not valid.</summary>
		InvalidCertificateGroup = -67691,
		/// <summary>Indicates that a tag could not be found.</summary>
		TagNotFound = -67692,
		/// <summary>Indicates an invalid query.</summary>
		InvalidQuery = -67693,
		/// <summary>Indicates an invalid value.</summary>
		InvalidValue = -67694,
		/// <summary>Indicates that a callback failed.</summary>
		CallbackFailed = -67695,
		/// <summary>Indicates that an ACL delete operation failed.</summary>
		ACLDeleteFailed = -67696,
		/// <summary>Indicates that an ACL replace operation failed.</summary>
		ACLReplaceFailed = -67697,
		/// <summary>Indicates that an ACL add operation failed.</summary>
		ACLAddFailed = -67698,
		/// <summary>Indicates that an ACL change operation failed.</summary>
		ACLChangeFailed = -67699,
		/// <summary>Indicates that the access credentials were not valid.</summary>
		InvalidAccessCredentials = -67700,
		/// <summary>Indicates an invalid record.</summary>
		InvalidRecord = -67701,
		/// <summary>Indicates that the ACL was not valid.</summary>
		InvalidACL = -67702,
		/// <summary>Indicates an invalid sample value.</summary>
		InvalidSampleValue = -67703,
		/// <summary>Indicates an incompatible version.</summary>
		IncompatibleVersion = -67704,
		/// <summary>Indicates that an access privilege was not granted.</summary>
		PrivilegeNotGranted = -67705,
		/// <summary>Indicates an invalid scope.</summary>
		InvalidScope = -67706,
		/// <summary>Indicates that PVC is already configured.</summary>
		PVCAlreadyConfigured = -67707,
		/// <summary>Indicates an invalid PVC</summary>
		InvalidPVC = -67708,
		/// <summary>Indicates that an EMM unload operation failed.</summary>
		EMMLoadFailed = -67709,
		/// <summary>Indicates that an EMM load operation failed.</summary>
		EMMUnloadFailed = -67710,
		/// <summary>To be added.</summary>
		AddinLoadFailed = -67711,
		/// <summary>Indicates an invalid key reference.</summary>
		InvalidKeyRef = -67712,
		/// <summary>Indicates an invalid key hierarchy.</summary>
		InvalidKeyHierarchy = -67713,
		/// <summary>Indicates that an add-in failed to load.</summary>
		AddinUnloadFailed = -67714,
		/// <summary>Indicates that a library reference could not be found.</summary>
		LibraryReferenceNotFound = -67715,
		/// <summary>Indicates that the add-in function table was not valid.</summary>
		InvalidAddinFunctionTable = -67716,
		/// <summary>Indicates an invalid service mask.</summary>
		InvalidServiceMask = -67717,
		/// <summary>To be added.</summary>
		ModuleNotLoaded = -67718,
		/// <summary>Indicates an invalid subservice ID.</summary>
		InvalidSubServiceID = -67719,
		/// <summary>Indicates that a requested attribute was not within a context.</summary>
		AttributeNotInContext = -67720,
		/// <summary>Indicates that a module failed while initializing.</summary>
		ModuleManagerInitializeFailed = -67721,
		/// <summary>Indicates that a module was not found.</summary>
		ModuleManagerNotFound = -67722,
		/// <summary>Indicates that a callback could not be found for a notification event.</summary>
		EventNotificationCallbackNotFound = -67723,
		/// <summary>Indicates that an input was too short or too long.</summary>
		InputLengthError = -67724,
		/// <summary>Indicates an output length error.</summary>
		OutputLengthError = -67725,
		/// <summary>ndicates that an access privilege was not supported.</summary>
		PrivilegeNotSupported = -67726,
		/// <summary>Indicates that an error occurred on a device.</summary>
		DeviceError = -67727,
		/// <summary>Indicates that the CSP handle was busy.</summary>
		AttachHandleBusy = -67728,
		/// <summary>Indicates that the developer is not logged in.</summary>
		NotLoggedIn = -67729,
		/// <summary>Indicates that there was a mismatch between security algorithms.</summary>
		AlgorithmMismatch = -67730,
		/// <summary>Indicates that a key was used incorrectly.</summary>
		KeyUsageIncorrect = -67731,
		/// <summary>Indicates that a key blob type was incorrect.</summary>
		KeyBlobTypeIncorrect = -67732,
		/// <summary>Indicates that a key header was inconsistent.</summary>
		KeyHeaderInconsistent = -67733,
		/// <summary>Indicates that unsupported key format was encountered.</summary>
		UnsupportedKeyFormat = -67734,
		/// <summary>Indicates that unsupported key size was encountered.</summary>
		UnsupportedKeySize = -67735,
		/// <summary>Indicates an invalid key usage mask.</summary>
		InvalidKeyUsageMask = -67736,
		/// <summary>Indicates that unsupported key usage mask was encountered.</summary>
		UnsupportedKeyUsageMask = -67737,
		/// <summary>Indicates an invalid key attribute mask.</summary>
		InvalidKeyAttributeMask = -67738,
		/// <summary>Indicates that unsupported key attribute mask was encountered.</summary>
		UnsupportedKeyAttributeMask = -67739,
		/// <summary>Indicates an invalid key label.</summary>
		InvalidKeyLabel = -67740,
		/// <summary>Indicates that unsupported key label was encountered.</summary>
		UnsupportedKeyLabel = -67741,
		/// <summary>Indicates an invalid key format.</summary>
		InvalidKeyFormat = -67742,
		/// <summary>Indicates that unsupported vector buffers were encountered.</summary>
		UnsupportedVectorOfBuffers = -67743,
		/// <summary>Indicates an invalid input vector.</summary>
		InvalidInputVector = -67744,
		/// <summary>Indicates an invalid output vector.</summary>
		InvalidOutputVector = -67745,
		/// <summary>Indicates that the context was not valid.</summary>
		InvalidContext = -67746,
		/// <summary>Indicates that the security algorithm was not valid.</summary>
		InvalidAlgorithm = -67747,
		/// <summary>Indicates that the key attribute was not valid.</summary>
		InvalidAttributeKey = -67748,
		/// <summary>Indicates that a key attribute was missing.</summary>
		MissingAttributeKey = -67749,
		/// <summary>Indicates that the init vector attribute was not valid.</summary>
		InvalidAttributeInitVector = -67750,
		/// <summary>Indicates that an init vector attribute was missing.</summary>
		MissingAttributeInitVector = -67751,
		/// <summary>Indicates that the salt attribute was not valid.</summary>
		InvalidAttributeSalt = -67752,
		/// <summary>Indicates that a salt attribute was missing.</summary>
		MissingAttributeSalt = -67753,
		/// <summary>Indicates that the padding attribute was not valid.</summary>
		InvalidAttributePadding = -67754,
		/// <summary>Indicates that a padding attribute was missing.</summary>
		MissingAttributePadding = -67755,
		/// <summary>Indicates that the random attribute was not valid.</summary>
		InvalidAttributeRandom = -67756,
		/// <summary>Indicates that a random attribute was missing.</summary>
		MissingAttributeRandom = -67757,
		/// <summary>Indicates that the seed attribute was not valid.</summary>
		InvalidAttributeSeed = -67758,
		/// <summary>Indicates that a seed attribute was missing.</summary>
		MissingAttributeSeed = -67759,
		/// <summary>Indicates that the passphrase attribute was not valid.</summary>
		InvalidAttributePassphrase = -67760,
		/// <summary>Indicates that a pass phrase attribute was missing.</summary>
		MissingAttributePassphrase = -67761,
		/// <summary>Indicates that the key length attribute was not valid.</summary>
		InvalidAttributeKeyLength = -67762,
		/// <summary>Indicates that a key length attribute was missing.</summary>
		MissingAttributeKeyLength = -67763,
		/// <summary>Indicates that the block size attribute was not valid.</summary>
		InvalidAttributeBlockSize = -67764,
		/// <summary>Indicates that a block size attribute was missing.</summary>
		MissingAttributeBlockSize = -67765,
		/// <summary>Indicates that the output size attribute was not valid.</summary>
		InvalidAttributeOutputSize = -67766,
		/// <summary>Indicates that an output size attribute was missing.</summary>
		MissingAttributeOutputSize = -67767,
		/// <summary>Indicates that the rounds attribute was not valid.</summary>
		InvalidAttributeRounds = -67768,
		/// <summary>Indicates that a rounds attribute was missing.</summary>
		MissingAttributeRounds = -67769,
		/// <summary>Indicates that the security algorithm was called with invalid parameters.</summary>
		InvalidAlgorithmParms = -67770,
		/// <summary>Indicates that required parameters for a security algorithm were missing.</summary>
		MissingAlgorithmParms = -67771,
		/// <summary>Indicates that the label attribute was not valid.</summary>
		InvalidAttributeLabel = -67772,
		/// <summary>Indicates that a label attribute was missing.</summary>
		MissingAttributeLabel = -67773,
		/// <summary>Indicates that the key type attribute was not valid.</summary>
		InvalidAttributeKeyType = -67774,
		/// <summary>Indicates that a key type attribute was missing.</summary>
		MissingAttributeKeyType = -67775,
		/// <summary>Indicates that the mode attribute was not valid.</summary>
		InvalidAttributeMode = -67776,
		/// <summary>Indicates that a mode attribute was missing.</summary>
		MissingAttributeMode = -67777,
		/// <summary>Indicates that the effective bits attribute was not valid.</summary>
		InvalidAttributeEffectiveBits = -67778,
		/// <summary>Indicates that an effective bits attribute was missing.</summary>
		MissingAttributeEffectiveBits = -67779,
		/// <summary>Indicates that the start date attribute was not valid.</summary>
		InvalidAttributeStartDate = -67780,
		/// <summary>Indicates that a start date attribute was missing.</summary>
		MissingAttributeStartDate = -67781,
		/// <summary>Indicates that the end date attribute was not valid.</summary>
		InvalidAttributeEndDate = -67782,
		/// <summary>Indicates that an end date attribute was missing.</summary>
		MissingAttributeEndDate = -67783,
		/// <summary>Indicates that the version attribute was not valid.</summary>
		InvalidAttributeVersion = -67784,
		/// <summary>Indicates that a versions attribute was missing.</summary>
		MissingAttributeVersion = -67785,
		/// <summary>Indicates that a prime attribute was not valid.</summary>
		InvalidAttributePrime = -67786,
		/// <summary>Indicates that a prime attribute was missing.</summary>
		MissingAttributePrime = -67787,
		/// <summary>Indicates that the base attribute was not valid.</summary>
		InvalidAttributeBase = -67788,
		/// <summary>Indicates that a base attribute was missing.</summary>
		MissingAttributeBase = -67789,
		/// <summary>Indicates that the subprime attribute was not valid.</summary>
		InvalidAttributeSubprime = -67790,
		/// <summary>Indicates that a subprime attribute was missing.</summary>
		MissingAttributeSubprime = -67791,
		/// <summary>Indicates that the iteration count attribute was not valid.</summary>
		InvalidAttributeIterationCount = -67792,
		/// <summary>Indicates that an iteration count attribute was missing.</summary>
		MissingAttributeIterationCount = -67793,
		/// <summary>Indicates that the database handle attribute was missing or not valid.</summary>
		InvalidAttributeDLDBHandle = -67794,
		/// <summary>Indicates that a database handle attribute was missing.</summary>
		MissingAttributeDLDBHandle = -67795,
		/// <summary>Indicates that the access credentials attribute was not valid.</summary>
		InvalidAttributeAccessCredentials = -67796,
		/// <summary>Indicates that the access credentials were missing.</summary>
		MissingAttributeAccessCredentials = -67797,
		/// <summary>Indicates that the public key format attribute was not valid.</summary>
		InvalidAttributePublicKeyFormat = -67798,
		/// <summary>Indicates that a public key format attribute was missing.</summary>
		MissingAttributePublicKeyFormat = -67799,
		/// <summary>Indicates that the private key attribute was not valid.</summary>
		InvalidAttributePrivateKeyFormat = -67800,
		/// <summary>Indicates that a private key format attribute was missing.</summary>
		MissingAttributePrivateKeyFormat = -67801,
		/// <summary>Indicates that the symmetric key format attribute was not valid.</summary>
		InvalidAttributeSymmetricKeyFormat = -67802,
		/// <summary>Indicates that a symmetric key format attribute was missing.</summary>
		MissingAttributeSymmetricKeyFormat = -67803,
		/// <summary>Indicates that a wrapped key format attribute was not valid.</summary>
		InvalidAttributeWrappedKeyFormat = -67804,
		/// <summary>Indicates that a wrapped key format attribute was missing.</summary>
		MissingAttributeWrappedKeyFormat = -67805,
		/// <summary>Indicates that a staged operation is in progress, so a time stamp is not (yet) appropriate.</summary>
		StagedOperationInProgress = -67806,
		/// <summary>Indicates that a staged operation has not yet started, so a time stamp is not (yet) appropriate.</summary>
		StagedOperationNotStarted = -67807,
		/// <summary>Indicates that a verification failed.</summary>
		VerifyFailed = -67808,
		/// <summary>Indicates that the query size is unknown.</summary>
		QuerySizeUnknown = -67809,
		/// <summary>Indicates mismatched block sizes.</summary>
		BlockSizeMismatch = -67810,
		/// <summary>Indicates that a public key was inconsistent.</summary>
		PublicKeyInconsistent = -67811,
		/// <summary>Indicates that a device could not be verified.</summary>
		DeviceVerifyFailed = -67812,
		/// <summary>Indicates an invalid login name </summary>
		InvalidLoginName = -67813,
		/// <summary>Indicates that the user was already logged in.</summary>
		AlreadyLoggedIn = -67814,
		/// <summary>Indicates that an invalid digest algorithm was specified.</summary>
		InvalidDigestAlgorithm = -67815,
		/// <summary>Indicates that the CRL group was not valid.</summary>
		InvalidCRLGroup = -67816,
		/// <summary>Indicates that a certificate could not operate.</summary>
		CertificateCannotOperate = -67817,
		/// <summary>Indicates that a certificate was expired.</summary>
		CertificateExpired = -67818,
		/// <summary>Indicates that a certificate was not yet valid.</summary>
		CertificateNotValidYet = -67819,
		/// <summary>Indicates that a certificate was revoked.</summary>
		CertificateRevoked = -67820,
		/// <summary>Indicates that a certificate was suspended.</summary>
		CertificateSuspended = -67821,
		/// <summary>Indicates that credentials were not sufficient for access.</summary>
		InsufficientCredentials = -67822,
		/// <summary>Indicates that an invalid action was not attempted.</summary>
		InvalidAction = -67823,
		/// <summary>Indicates that the authority was not valid.</summary>
		InvalidAuthority = -67824,
		/// <summary>Indicates a verification action failure.</summary>
		VerifyActionFailed = -67825,
		/// <summary>Indicates that the cert authority was not valid.</summary>
		InvalidCertAuthority = -67826,
		/// <summary>Indicates that the CRL authority was not valid.</summary>
		InvalidCRLAuthority = -67827,
		/// <summary>Indicates that the CRL encoding was not valid.</summary>
		InvalidCRLEncoding = -67828,
		/// <summary>Indicates that the CRL type was not valid..</summary>
		InvalidCRLType = -67829,
		/// <summary>Indicates that the CRL was not valid.</summary>
		InvalidCRL = -67830,
		/// <summary>Indicates an invalid form type.</summary>
		InvalidFormType = -67831,
		/// <summary>Indicates an invalid identifier.</summary>
		InvalidID = -67832,
		/// <summary>Indicates an invalid identifier.</summary>
		InvalidIdentifier = -67833,
		/// <summary>Indicates an invalid index.</summary>
		InvalidIndex = -67834,
		/// <summary>Indicates invalid policy identifiers.</summary>
		InvalidPolicyIdentifiers = -67835,
		/// <summary>Indicates an invalid time string.</summary>
		InvalidTimeString = -67836,
		/// <summary>Indicates an invalid reason.</summary>
		InvalidReason = -67837,
		/// <summary>Indicates invalid inputs to a request.</summary>
		InvalidRequestInputs = -67838,
		/// <summary>Indicates an invalid response vector.</summary>
		InvalidResponseVector = -67839,
		/// <summary>Indicates an invalid stop-on policy.</summary>
		InvalidStopOnPolicy = -67840,
		/// <summary>Indicates an invalid tuple.</summary>
		InvalidTuple = -67841,
		/// <summary>Indicates that multiple values were used where not supported.</summary>
		MultipleValuesUnsupported = -67842,
		/// <summary>Indicates that the policy is not trusted.</summary>
		NotTrusted = -67843,
		/// <summary>Indicates that no default authority was found.</summary>
		NoDefaultAuthority = -67844,
		/// <summary>Indicates that a trust policy rejected a form.</summary>
		RejectedForm = -67845,
		/// <summary>Indicates that a request was lost.</summary>
		RequestLost = -67846,
		/// <summary>Indicates that a request was rejected.</summary>
		RequestRejected = -67847,
		/// <summary>Indicates that an unsupported address type was encountered.</summary>
		UnsupportedAddressType = -67848,
		/// <summary>Indicates that an unsupported service was requested.</summary>
		UnsupportedService = -67849,
		/// <summary>Indicates an invalid tuple group.</summary>
		InvalidTupleGroup = -67850,
		/// <summary>Indicates that the base ACLs were not valid.</summary>
		InvalidBaseACLs = -67851,
		/// <summary>Indicates an invalid credentials tuple.</summary>
		InvalidTupleCredentials = -67852,
		/// <summary>Indicates an invalid encoding.</summary>
		InvalidEncoding = -67853,
		/// <summary>Indicates an invalid identity period.</summary>
		InvalidValidityPeriod = -67854,
		/// <summary>Indicates an invalid requestor.</summary>
		InvalidRequestor = -67855,
		/// <summary>Indicates that a request descriptor was invalid.</summary>
		RequestDescriptor = -67856,
		/// <summary>Indicates that the bundle info was not valid.</summary>
		InvalidBundleInfo = -67857,
		/// <summary>Indicates that a CRL index was not valid.</summary>
		InvalidCRLIndex = -67858,
		/// <summary>Indicates that no field values were found.</summary>
		NoFieldValues = -67859,
		/// <summary>Indicates that an unsupported field format was encountered.</summary>
		UnsupportedFieldFormat = -67860,
		/// <summary>Indicates that unsupported index information was encountered.</summary>
		UnsupportedIndexInfo = -67861,
		/// <summary>Indicates that unsupported locality was encountered.</summary>
		UnsupportedLocality = -67862,
		/// <summary>Indicates that an unsupported number of attributes was encountered.</summary>
		UnsupportedNumAttributes = -67863,
		/// <summary>Indicates that an unsupported number of indices was encountered.</summary>
		UnsupportedNumIndexes = -67864,
		/// <summary>Indicates that an unsupported number of record types was encountered.</summary>
		UnsupportedNumRecordTypes = -67865,
		/// <summary>Indicates that a field was specified multiple times.</summary>
		FieldSpecifiedMultiple = -67866,
		/// <summary>Indicates that a field format was not compatible.</summary>
		IncompatibleFieldFormat = -67867,
		/// <summary>Indicates an invalid parsing module.</summary>
		InvalidParsingModule = -67868,
		/// <summary>Indicates that a database was locked.</summary>
		DatabaseLocked = -67869,
		/// <summary>Indicates that a data store was open.</summary>
		DatastoreIsOpen = -67870,
		/// <summary>Indicates that a value was missing.</summary>
		MissingValue = -67871,
		/// <summary>Indicates that unsupported query limits were encountered.</summary>
		UnsupportedQueryLimits = -67872,
		/// <summary>Indicates that an unsupported number of selection predicates was encountered.</summary>
		UnsupportedNumSelectionPreds = -67873,
		/// <summary>Indicates that an unsupported operator was encountered.</summary>
		UnsupportedOperator = -67874,
		/// <summary>Indicates that a database location was not valid.</summary>
		InvalidDBLocation = -67875,
		/// <summary>Indicates that an invalid access request was made.</summary>
		InvalidAccessRequest = -67876,
		/// <summary>Indicates invalid index info.</summary>
		InvalidIndexInfo = -67877,
		/// <summary>Indicates an invalid owner.</summary>
		InvalidNewOwner = -67878,
		/// <summary>Indicates an invalid modification mode.</summary>
		InvalidModifyMode = -67879,
		/// <summary>Indicates that a required extension was missing.</summary>
		MissingRequiredExtension = -67880,
		/// <summary>Indicates that a noncritical extended key was encountered where they are disallowed.</summary>
		ExtendedKeyUsageNotCritical = -67881,
		/// <summary>Indicates that a timestamp was missing.</summary>
		TimestampMissing = -67882,
		/// <summary>Indicates that a timestamp was invalid.</summary>
		TimestampInvalid = -67883,
		/// <summary>Indicates that a timestamp was not trusted.</summary>
		TimestampNotTrusted = -67884,
		/// <summary>Indicates that a timestamp service was unavailable.</summary>
		TimestampServiceNotAvailable = -67885,
		/// <summary>Indicates that a bad algorithm ID was found in the timestamp.</summary>
		TimestampBadAlg = -67886,
		/// <summary>Indicates that the timestamp used an incorrect format.</summary>
		TimestampBadRequest = -67887,
		/// <summary>Indicates that the timestamp used an incorrect format.</summary>
		TimestampBadDataFormat = -67888,
		/// <summary>Indicates that a timestamp time was not available.</summary>
		TimestampTimeNotAvailable = -67889,
		/// <summary>Indicates that the policy is not accepted by the timestamp authority.</summary>
		TimestampUnacceptedPolicy = -67890,
		/// <summary>Indicates that an unaccepted extension was requested of a timestamp server.</summary>
		TimestampUnacceptedExtension = -67891,
		/// <summary>Indicates that additional information was not available for the timestamp.</summary>
		TimestampAddInfoNotAvailable = -67892,
		/// <summary>Indicates a timestamp system failure.</summary>
		TimestampSystemFailure = -67893,
		/// <summary>Indicates that a certificate signing time was missing.</summary>
		SigningTimeMissing = -67894,
		/// <summary>Indicates that a timestamp was rejected.</summary>
		TimestampRejection = -67895,
		/// <summary>Indicates that a timestamp transaction was waiting.</summary>
		TimestampWaiting = -67896,
		/// <summary>Indicates that a timestamp warning has been issued.</summary>
		TimestampRevocationWarning = -67897,
		/// <summary>Indicates that a timestamp revocation notification has been issued.</summary>
		TimestampRevocationNotification = -67898,
		CertificatePolicyNotAllowed = -67899,
		CertificateNameNotAllowed = -67900,
		CertificateValidityPeriodTooLong = -67901,
		CertificateIsCA = -67902,
		CertificateDuplicateExtension = -67903,
		MissingQualifiedCertStatement = -67904,
	}
}
