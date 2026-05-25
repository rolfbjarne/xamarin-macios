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
namespace Foundation {
	/// <summary>Enumeration of various errors relating to Cocoa development.</summary><remarks>To be added.</remarks>
	public enum NSCocoaError : int {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		FileNoSuchFile = 4,
		/// <summary>To be added.</summary>
		FileLocking = 255,
		/// <summary>To be added.</summary>
		FileReadUnknown = 256,
		/// <summary>To be added.</summary>
		FileReadNoPermission = 257,
		/// <summary>To be added.</summary>
		FileReadInvalidFileName = 258,
		/// <summary>To be added.</summary>
		FileReadCorruptFile = 259,
		/// <summary>To be added.</summary>
		FileReadNoSuchFile = 260,
		/// <summary>To be added.</summary>
		FileReadInapplicableStringEncoding = 261,
		/// <summary>To be added.</summary>
		FileReadUnsupportedScheme = 262,
		/// <summary>To be added.</summary>
		FileReadTooLarge = 263,
		/// <summary>To be added.</summary>
		FileReadUnknownStringEncoding = 264,
		/// <summary>To be added.</summary>
		FileWriteUnknown = 512,
		/// <summary>To be added.</summary>
		FileWriteNoPermission = 513,
		/// <summary>To be added.</summary>
		FileWriteInvalidFileName = 514,
		/// <summary>To be added.</summary>
		FileWriteFileExists = 516,
		/// <summary>To be added.</summary>
		FileWriteInapplicableStringEncoding = 517,
		/// <summary>To be added.</summary>
		FileWriteUnsupportedScheme = 518,
		/// <summary>To be added.</summary>
		FileWriteOutOfSpace = 640,
		/// <summary>To be added.</summary>
		FileWriteVolumeReadOnly = 642,
		/// <summary>To be added.</summary>
		KeyValueValidation = 1024,
		/// <summary>To be added.</summary>
		Formatting = 2048,
		/// <summary>To be added.</summary>
		UserCancelled = 3072,
		/// <summary>To be added.</summary>
		FeatureUnsupported = 3328,
		/// <summary>To be added.</summary>
		ExecutableNotLoadable = 3584,
		/// <summary>To be added.</summary>
		ExecutableArchitectureMismatch = 3585,
		/// <summary>To be added.</summary>
		ExecutableRuntimeMismatch = 3586,
		/// <summary>To be added.</summary>
		ExecutableLoad = 3587,
		/// <summary>To be added.</summary>
		ExecutableLink = 3588,
		/// <summary>To be added.</summary>
		FileErrorMinimum = 0,
		/// <summary>To be added.</summary>
		FileErrorMaximum = 1023,
		/// <summary>To be added.</summary>
		ValidationErrorMinimum = 1024,
		/// <summary>To be added.</summary>
		ValidationErrorMaximum = 2047,
		/// <summary>To be added.</summary>
		ExecutableErrorMinimum = 3584,
		/// <summary>To be added.</summary>
		ExecutableErrorMaximum = 3839,
		/// <summary>To be added.</summary>
		FormattingErrorMinimum = 2048,
		/// <summary>To be added.</summary>
		FormattingErrorMaximum = 2559,
		/// <summary>To be added.</summary>
		PropertyListReadCorrupt = 3840,
		/// <summary>To be added.</summary>
		PropertyListReadUnknownVersion = 3841,
		/// <summary>To be added.</summary>
		PropertyListReadStream = 3842,
		/// <summary>To be added.</summary>
		PropertyListWriteStream = 3851,
		/// <summary>To be added.</summary>
		PropertyListWriteInvalid = 3852,
		/// <summary>To be added.</summary>
		PropertyListErrorMinimum = 3840,
		/// <summary>To be added.</summary>
		PropertyListErrorMaximum = 4095,
		/// <summary>To be added.</summary>
		XpcConnectionInterrupted = 4097,
		/// <summary>To be added.</summary>
		XpcConnectionInvalid = 4099,
		/// <summary>To be added.</summary>
		XpcConnectionReplyInvalid = 4101,
		XpcConnectionCodeSigningRequirementFailure = 4102,
		/// <summary>To be added.</summary>
		XpcConnectionErrorMinimum = 4096,
		/// <summary>To be added.</summary>
		XpcConnectionErrorMaximum = 4224,
		/// <summary>To be added.</summary>
		UbiquitousFileUnavailable = 4353,
		/// <summary>To be added.</summary>
		UbiquitousFileNotUploadedDueToQuota = 4354,
		/// <summary>To be added.</summary>
		UbiquitousFileUbiquityServerNotAvailable = 4355,
		/// <summary>To be added.</summary>
		UbiquitousFileErrorMinimum = 4352,
		/// <summary>To be added.</summary>
		UbiquitousFileErrorMaximum = 4607,
		/// <summary>To be added.</summary>
		UserActivityHandoffFailedError = 4608,
		/// <summary>To be added.</summary>
		UserActivityConnectionUnavailableError = 4609,
		/// <summary>To be added.</summary>
		UserActivityRemoteApplicationTimedOutError = 4610,
		/// <summary>To be added.</summary>
		UserActivityHandoffUserInfoTooLargeError = 4611,
		/// <summary>To be added.</summary>
		UserActivityErrorMinimum = 4608,
		/// <summary>To be added.</summary>
		UserActivityErrorMaximum = 4863,
		/// <summary>To be added.</summary>
		CoderReadCorruptError = 4864,
		/// <summary>To be added.</summary>
		CoderValueNotFoundError = 4865,
		/// <summary>To be added.</summary>
		CoderInvalidValueError = 4866,
		/// <summary>To be added.</summary>
		CoderErrorMinimum = 4864,
		/// <summary>To be added.</summary>
		CoderErrorMaximum = 4991,
		/// <summary>To be added.</summary>
		BundleErrorMinimum = 4992,
		/// <summary>To be added.</summary>
		BundleErrorMaximum = 5119,
		/// <summary>To be added.</summary>
		BundleOnDemandResourceOutOfSpaceError = 4992,
		/// <summary>To be added.</summary>
		BundleOnDemandResourceExceededMaximumSizeError = 4993,
		/// <summary>To be added.</summary>
		BundleOnDemandResourceInvalidTagError = 4994,
		/// <summary>To be added.</summary>
		CloudSharingNetworkFailureError = 5120,
		/// <summary>To be added.</summary>
		CloudSharingQuotaExceededError = 5121,
		/// <summary>To be added.</summary>
		CloudSharingTooManyParticipantsError = 5122,
		/// <summary>To be added.</summary>
		CloudSharingConflictError = 5123,
		/// <summary>To be added.</summary>
		CloudSharingNoPermissionError = 5124,
		/// <summary>To be added.</summary>
		CloudSharingOtherError = 5375,
		/// <summary>To be added.</summary>
		CloudSharingErrorMinimum = 5120,
		/// <summary>To be added.</summary>
		CloudSharingErrorMaximum = 5375,
		CompressionFailedError = 5376,
		DecompressionFailedError = 5377,
		CompressionErrorMinimum = 5376,
		CompressionErrorMaximum = 5503,
	}
}
