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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>An enumeration of errors associated with creating or loading a <see cref="T:Foundation.NSUrl" />.</summary><remarks>To be added.</remarks>
	public enum NSUrlError : int {
		/// <summary>To be added.</summary>
		Unknown = -1,
		/// <summary>To be added.</summary>
		BackgroundSessionRequiresSharedContainer = -995,
		/// <summary>To be added.</summary>
		BackgroundSessionInUseByAnotherProcess = -996,
		/// <summary>To be added.</summary>
		BackgroundSessionWasDisconnected = -997,
		/// <summary>To be added.</summary>
		Cancelled = -999,
		/// <summary>To be added.</summary>
		BadURL = -1000,
		/// <summary>To be added.</summary>
		TimedOut = -1001,
		/// <summary>To be added.</summary>
		UnsupportedURL = -1002,
		/// <summary>To be added.</summary>
		CannotFindHost = -1003,
		/// <summary>To be added.</summary>
		CannotConnectToHost = -1004,
		/// <summary>To be added.</summary>
		NetworkConnectionLost = -1005,
		/// <summary>To be added.</summary>
		DNSLookupFailed = -1006,
		/// <summary>To be added.</summary>
		HTTPTooManyRedirects = -1007,
		/// <summary>To be added.</summary>
		ResourceUnavailable = -1008,
		/// <summary>To be added.</summary>
		NotConnectedToInternet = -1009,
		/// <summary>To be added.</summary>
		RedirectToNonExistentLocation = -1010,
		/// <summary>To be added.</summary>
		BadServerResponse = -1011,
		/// <summary>To be added.</summary>
		UserCancelledAuthentication = -1012,
		/// <summary>To be added.</summary>
		UserAuthenticationRequired = -1013,
		/// <summary>To be added.</summary>
		ZeroByteResource = -1014,
		/// <summary>To be added.</summary>
		CannotDecodeRawData = -1015,
		/// <summary>To be added.</summary>
		CannotDecodeContentData = -1016,
		/// <summary>To be added.</summary>
		CannotParseResponse = -1017,
		/// <summary>To be added.</summary>
		InternationalRoamingOff = -1018,
		/// <summary>To be added.</summary>
		CallIsActive = -1019,
		/// <summary>To be added.</summary>
		DataNotAllowed = -1020,
		/// <summary>To be added.</summary>
		RequestBodyStreamExhausted = -1021,
		/// <summary>To be added.</summary>
		AppTransportSecurityRequiresSecureConnection = -1022,
		/// <summary>To be added.</summary>
		FileDoesNotExist = -1100,
		/// <summary>To be added.</summary>
		FileIsDirectory = -1101,
		/// <summary>To be added.</summary>
		NoPermissionsToReadFile = -1102,
		/// <summary>To be added.</summary>
		DataLengthExceedsMaximum = -1103,
		/// <summary>To be added.</summary>
		FileOutsideSafeArea = -1104,
		/// <summary>To be added.</summary>
		SecureConnectionFailed = -1200,
		/// <summary>To be added.</summary>
		ServerCertificateHasBadDate = -1201,
		/// <summary>To be added.</summary>
		ServerCertificateUntrusted = -1202,
		/// <summary>To be added.</summary>
		ServerCertificateHasUnknownRoot = -1203,
		/// <summary>To be added.</summary>
		ServerCertificateNotYetValid = -1204,
		/// <summary>To be added.</summary>
		ClientCertificateRejected = -1205,
		/// <summary>To be added.</summary>
		ClientCertificateRequired = -1206,
		/// <summary>To be added.</summary>
		CannotLoadFromNetwork = -2000,
		/// <summary>To be added.</summary>
		CannotCreateFile = -3000,
		/// <summary>To be added.</summary>
		CannotOpenFile = -3001,
		/// <summary>To be added.</summary>
		CannotCloseFile = -3002,
		/// <summary>To be added.</summary>
		CannotWriteToFile = -3003,
		/// <summary>To be added.</summary>
		CannotRemoveFile = -3004,
		/// <summary>To be added.</summary>
		CannotMoveFile = -3005,
		/// <summary>To be added.</summary>
		DownloadDecodingFailedMidStream = -3006,
		/// <summary>To be added.</summary>
		DownloadDecodingFailedToComplete = -3007,
	}
}
