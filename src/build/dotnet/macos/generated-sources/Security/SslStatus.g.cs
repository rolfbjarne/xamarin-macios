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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
	/// <summary>Enumerates SSL connection status.</summary>
	public enum SslStatus : int {
		/// <summary>The connection succeeded.</summary>
		Success = 0,
		/// <summary>A general SSL protocol error.</summary>
		Protocol = -9800,
		/// <summary>Cipher suite negotation failed.</summary>
		Negotiation = -9801,
		/// <summary>Fatal alert.</summary>
		FatalAlert = -9802,
		/// <summary>The SSLHandshake method must be called again.</summary>
		WouldBlock = -9803,
		/// <summary>The session could not be found.</summary>
		SessionNotFound = -9804,
		/// <summary>The connection was closed gracefully.</summary>
		ClosedGraceful = -9805,
		/// <summary>The connection was closed due to an error.</summary>
		ClosedAbort = -9806,
		/// <summary>The verification of the common name field in the peer's certificate failed.</summary>
		XCertChainInvalid = -9807,
		/// <summary>Bad certificate format.</summary>
		BadCert = -9808,
		/// <summary>Undefined SSL cryptographic error.</summary>
		Crypto = -9809,
		/// <summary>Internal error.</summary>
		Internal = -9810,
		/// <summary>Module attach error.</summary>
		ModuleAttach = -9811,
		/// <summary>The root certificate is unknown.</summary>
		UnknownRootCert = -9812,
		/// <summary>The certificate chain does not have a root certificate.</summary>
		NoRootCert = -9813,
		/// <summary>The SSL certificate chain has expired.</summary>
		CertExpired = -9814,
		/// <summary>The SSL certificate chain has a certificate that is not yet valid.</summary>
		CertNotYetValid = -9815,
		/// <summary>The server closed the session without notification.</summary>
		ClosedNotNotified = -9816,
		/// <summary>The supplied buffer was too small.</summary>
		BufferOverflow = -9817,
		/// <summary>Bad SSL cipher suite.</summary>
		BadCipherSuite = -9818,
		/// <summary>An unexpected message was received.</summary>
		PeerUnexpectedMsg = -9819,
		/// <summary>Bad Message Authentication Code encountered.</summary>
		PeerBadRecordMac = -9820,
		/// <summary>Decryption failed.</summary>
		PeerDecryptionFail = -9821,
		/// <summary>A record overflow was encountered.</summary>
		PeerRecordOverflow = -9822,
		/// <summary>Decompression failure.</summary>
		PeerDecompressFail = -9823,
		/// <summary>The handshake with the peer failed.</summary>
		PeerHandshakeFail = -9824,
		/// <summary>A bad certificate was encountered.</summary>
		PeerBadCert = -9825,
		/// <summary>An unsupported certificate was encountered.</summary>
		PeerUnsupportedCert = -9826,
		/// <summary>A certificate was revoked.</summary>
		PeerCertRevoked = -9827,
		/// <summary>A certificate has expired.</summary>
		PeerCertExpired = -9828,
		/// <summary>A certificate is unknown.</summary>
		PeerCertUnknown = -9829,
		/// <summary>A bad parameter was detected.</summary>
		IllegalParam = -9830,
		/// <summary>An unknown certificate authority was encountered.</summary>
		PeerUnknownCA = -9831,
		/// <summary>Access was denied.</summary>
		PeerAccessDenied = -9832,
		/// <summary>Decoding error.</summary>
		PeerDecodeError = -9833,
		/// <summary>Decryption error.</summary>
		PeerDecryptError = -9834,
		/// <summary>An export restriction occurred.</summary>
		PeerExportRestriction = -9835,
		/// <summary>Bad protocol version.</summary>
		PeerProtocolVersion = -9836,
		/// <summary>There is insufficient security for the requested operation.</summary>
		PeerInsufficientSecurity = -9837,
		/// <summary>There was an internal error at the peer.</summary>
		PeerInternalError = -9838,
		/// <summary>The used cancelled the operation.</summary>
		PeerUserCancelled = -9839,
		/// <summary>Renegotiation is not allowed.</summary>
		PeerNoRenegotiation = -9840,
		/// <summary>Server certificate was valid or, if verification disabled, was ignored.</summary>
		PeerAuthCompleted = -9841,
		/// <summary>The server has requested a client certificate.</summary>
		PeerClientCertRequested = -9842,
		/// <summary>The host name connected to is not in the certificate.</summary>
		HostNameMismatch = -9843,
		/// <summary>The peer dropped the connection prior to responding.</summary>
		ConnectionRefused = -9844,
		/// <summary>Decrytion failed.</summary>
		DecryptionFail = -9845,
		/// <summary>Bad Method Authentication Code.</summary>
		BadRecordMac = -9846,
		/// <summary>A record overflow was encountered.</summary>
		RecordOverflow = -9847,
		/// <summary>Configuration error.</summary>
		BadConfiguration = -9848,
		/// <summary>An unexpected record was encountered.</summary>
		UnexpectedRecord = -9849,
		/// <summary>The Diffie-Hellman ephemeral key was weak.</summary>
		SSLWeakPeerEphemeralDHKey = -9850,
		/// <summary>A client hello was received.</summary>
		SSLClientHelloReceived = -9851,
		/// <summary>The socket reset.</summary>
		SSLTransportReset = -9852,
		/// <summary>The SSL network timed out.</summary>
		SSLNetworkTimeout = -9853,
		/// <summary>SSL configuration failed.</summary>
		SSLConfigurationFailed = -9854,
		/// <summary>The SSL extension is not supported.</summary>
		SSLUnsupportedExtension = -9855,
		/// <summary>An unexpected message was received.</summary>
		SSLUnexpectedMessage = -9856,
		/// <summary>Decompression failed.</summary>
		SSLDecompressFail = -9857,
		/// <summary>The SSL handshake could not negotiate a secure connection.</summary>
		SSLHandshakeFail = -9858,
		/// <summary>Certificate decoding failed.</summary>
		SSLDecodeError = -9859,
		/// <summary>The current SSL request is at a lower version than that of a prior attempt, of which the client is capable.</summary>
		SSLInappropriateFallback = -9860,
		/// <summary>A required extension was missing.</summary>
		SSLMissingExtension = -9861,
		/// <summary>The OCSP response was bad.</summary>
		SSLBadCertificateStatusResponse = -9862,
		/// <summary>An SSL certificate is required.</summary>
		SSLCertificateRequired = -9863,
		/// <summary>An unknown shared key (PSK) or remote password (SRP) identity was encountered.</summary>
		SSLUnknownPskIdentity = -9864,
		/// <summary>An unrecognized name was encountered.</summary>
		SSLUnrecognizedName = -9865,
		SslAtsViolation = -9880,
		SslAtsMinimumVersionViolation = -9881,
		SslAtsCiphersuiteViolation = -9882,
		SslAtsMinimumKeySizeViolation = -9883,
		SslAtsLeafCertificateHashAlgorithmViolation = -9884,
		SslAtsCertificateHashAlgorithmViolation = -9885,
		SslAtsCertificateTrustViolation = -9886,
		SslEarlyDataRejected = -9890,
	}
}
