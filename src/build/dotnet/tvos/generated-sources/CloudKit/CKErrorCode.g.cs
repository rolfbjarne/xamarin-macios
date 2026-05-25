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
namespace CloudKit {
	/// <summary>Enumerates CloudKit error conditions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum CKErrorCode : long {
		/// <summary>The operation succeeded.</summary>
		None = 0,
		/// <summary>A CloudKit internal error. Non-recoverable.</summary>
		InternalError = 1,
		/// <summary>Indicates that some items failed but the overall operation succeeded.</summary>
		PartialFailure = 2,
		/// <summary>Indicates that the user is not online.</summary>
		NetworkUnavailable = 3,
		/// <summary>The network returned an error during processing.</summary>
		NetworkFailure = 4,
		/// <summary>The specified container is unknown or unauthorized.</summary>
		BadContainer = 5,
		/// <summary>CloudKit is not available.</summary>
		ServiceUnavailable = 6,
		/// <summary>Indicates that the client is currently rate-limited.</summary>
		RequestRateLimited = 7,
		/// <summary>The app is missing the required entitlement.</summary>
		MissingEntitlement = 8,
		/// <summary>The user is not currently authenticated. Common cause: User is not logged in to iCloud.</summary>
		NotAuthenticated = 9,
		/// <summary>Indicates the user has not allowed access for the data in the fetch or save.</summary>
		PermissionFailure = 10,
		/// <summary>Indicates the requested record does not exist.</summary>
		UnknownItem = 11,
		/// <summary>Indicates an error in the form or content of the request.</summary>
		InvalidArguments = 12,
		/// <summary>This error message is deprecated. Indicates that results were truncated by the server.</summary>
		ResultsTruncated = 13,
		/// <summary>The record was rejected because the server's values were different.</summary>
		ServerRecordChanged = 14,
		/// <summary>Server rejected request. Non-recoverable.</summary>
		ServerRejectedRequest = 15,
		/// <summary>The specified asset file could not be found.</summary>
		AssetFileNotFound = 16,
		/// <summary>The specified asset file was modified during the save operation.</summary>
		AssetFileModified = 17,
		/// <summary>The app version is less than the CloudKit-specified minimum acceptable version.</summary>
		IncompatibleVersion = 18,
		/// <summary>The request was rejected because of a conflict in a unique field.</summary>
		ConstraintViolation = 19,
		/// <summary>Indicates the operation was cancelled programmatically by the app.</summary>
		OperationCancelled = 20,
		/// <summary>Indicates the <see cref="P:CloudKit.CKFetchRecordChangesOperation.PreviousServerChangeToken" /> expired and the client must resynchronize.</summary>
		ChangeTokenExpired = 21,
		/// <summary>An item failed in a zone with atomic updates, so the batch was rejected.</summary>
		BatchRequestFailed = 22,
		/// <summary>Indicates that the zone is currently too busy. Suggested action is a delayed retry.</summary>
		ZoneBusy = 23,
		/// <summary>The operation could not be completed. Common cause: attempt to modify zones on public database.</summary>
		BadDatabase = 24,
		/// <summary>Indicates that the requested operation would have exceeded the user's storage quota.</summary>
		QuotaExceeded = 25,
		/// <summary>The specified zone is not recognized by the server.</summary>
		ZoneNotFound = 26,
		/// <summary>Indicates the request was too large. Suggested change: Refactor request into smaller batches.</summary>
		LimitExceeded = 27,
		/// <summary>Indicates the user deleted the zone. Suggested action: Remove local copy of zone data or ask user if app may upload data again.</summary>
		UserDeletedZone = 28,
		/// <summary>Indicates that there are too many participants attached to the share.</summary>
		TooManyParticipants = 29,
		/// <summary>Indicates that the <see cref="T:CloudKit.CKRecord" /> or <see cref="T:CloudKit.CKShare" /> hierarchy already exists in another share.</summary>
		AlreadyShared = 30,
		/// <summary>Indicates the <see cref="T:CloudKit.CKRecord" /> object's parent reference or it's share reference could not be found.</summary>
		ReferenceViolation = 31,
		/// <summary>Indicates an error due to a managed account restriction.</summary>
		ManagedAccountRestricted = 32,
		/// <summary>The user is not yet partificipating in the share..</summary>
		ParticipantMayNeedVerification = 33,
		/// <summary>Indicates that the response was lost.</summary>
		ResponseLost = 34,
		/// <summary>To be added.</summary>
		AssetNotAvailable = 35,
		TemporarilyUnavailable = 36,
		ParticipantAlreadyInvited = 37,
	}
	/// <summary>Extension methods for the <see cref="global::CloudKit.CKErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CloudKit.CKErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CKErrorCodeExtensions {
		[Field ("CKErrorDomain", "CloudKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CloudKit.CKErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CKErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKErrorDomain");
			return _domain;
		}
	}
}
