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
namespace AVFoundation {
	/// <summary>An enumeration whose values define various audiovisual errors.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVError : long {
		/// <summary>Indicates that an unknown error occurred.</summary>
		Unknown = -11800,
		/// <summary>Indicates that system memory became full.</summary>
		OutOfMemory = -11801,
		/// <summary>Indicates that no data was received because the session was not running.</summary>
		SessionNotRunning = -11803,
		/// <summary>Indicates that the device was in use by another session.</summary>
		DeviceAlreadyUsedByAnotherSession = -11804,
		/// <summary>Indicates that no data was sent to the recording session.</summary>
		NoDataCaptured = -11805,
		/// <summary>Indicates that the recording session configuration was changed.</summary>
		SessionConfigurationChanged = -11806,
		/// <summary>Indicates that non-volatile storage was full.</summary>
		DiskFull = -11807,
		/// <summary>Indicates that the device was not connected.</summary>
		DeviceWasDisconnected = -11808,
		/// <summary>Indicates that the recording source media changed.</summary>
		MediaChanged = -11809,
		/// <summary>Indicates that the maximum allowable recording duration was reached.</summary>
		MaximumDurationReached = -11810,
		/// <summary>Indicates that the maximum allowable output file size was reached.</summary>
		MaximumFileSizeReached = -11811,
		/// <summary>Indicates that the source data was interrupted.</summary>
		MediaDiscontinuity = -11812,
		/// <summary>Indicates that the maximum number of samples was reached for the output file.</summary>
		MaximumNumberOfSamplesForFileFormatReached = -11813,
		/// <summary>Indicates that the device was not connected.</summary>
		DeviceNotConnected = -11814,
		/// <summary>Indicates that the device was in use by another application.</summary>
		DeviceInUseByAnotherApplication = -11815,
		/// <summary>Indicates that the device is locked for an update or for other configuration.</summary>
		DeviceLockedForConfigurationByAnotherProcess = -11817,
		/// <summary>Indicates that the recording sesion was interrupted.</summary>
		SessionWasInterrupted = -11818,
		/// <summary>Indicates that media services were reset.</summary>
		MediaServicesWereReset = -11819,
		/// <summary>Indicates that data export failed.</summary>
		ExportFailed = -11820,
		/// <summary>Indicates that the media data could not be decoded.</summary>
		DecodeFailed = -11821,
		/// <summary>Indicates that the source media was not valid.</summary>
		InvalidSourceMedia = -11822,
		/// <summary>Indicates that data could not be written because the output file already exists.</summary>
		FileAlreadyExists = -11823,
		/// <summary>Indicates that the source media contained gaps and could not be loaded.</summary>
		CompositionTrackSegmentsNotContiguous = -11824,
		/// <summary>Indicates that the source media's play duration on the device was not valid.</summary>
		InvalidCompositionTrackSegmentDuration = -11825,
		/// <summary>Indicates that the source media could not be opened because a track start time was not valid.</summary>
		InvalidCompositionTrackSegmentSourceStartTime = -11826,
		/// <summary>Indicates that the source media had no duration set.</summary>
		InvalidCompositionTrackSegmentSourceDuration = -11827,
		/// <summary>Indicates that the media was in an urecognizable format and could therefore not be opened.</summary>
		FormatNotRecognized = -11828,
		/// <summary>Indicates that the data could not be parsed.</summary>
		FailedToParse = -11829,
		/// <summary>Indicates that the maximum number of still images was reached for the output file.</summary>
		MaximumStillImageCaptureRequestsExceeded = -11830,
		/// <summary>Indicates that the app is not authorized to play the content.</summary>
		ContentIsProtected = -11831,
		/// <summary>Indicates that playback failed because no image was present at a specified time.</summary>
		NoImageAtTime = -11832,
		/// <summary>Indicates that a decoder for the media data could not be found.</summary>
		DecoderNotFound = -11833,
		/// <summary>Indicates that a required data encoder was missing.</summary>
		EncoderNotFound = -11834,
		/// <summary>Indicates that the user is not authorized to play the content.</summary>
		ContentIsNotAuthorized = -11835,
		/// <summary>The application is not authorized.</summary>
		ApplicationIsNotAuthorized = -11836,
		/// <summary>Indicates that the device is not available while the app is backgrounded.</summary>
		DeviceIsNotAvailableInBackground = -11837,
		/// <summary>Indicates that an operation that was not supported on a specific asset or asset type was attempted.</summary>
		OperationNotSupportedForAsset = -11838,
		/// <summary>Indicates that the decoder for the media data was unavailable.</summary>
		DecoderTemporarilyUnavailable = -11839,
		/// <summary>Indicates that a required data encoder was unavailable.</summary>
		EncoderTemporarilyUnavailable = -11840,
		/// <summary>Indicates that a video composition operation was not valid.</summary>
		InvalidVideoComposition = -11841,
		/// <summary>Indicates that an attempt was made to follow a reference for which authorization was lacking.</summary>
		ReferenceForbiddenByReferencePolicy = -11842,
		/// <summary>Indicates that the ouptut path contained an invalid extension.</summary>
		InvalidOutputURLPathExtension = -11843,
		/// <summary>Indicates that the screen could not be captured.</summary>
		ScreenCaptureFailed = -11844,
		/// <summary>Indicates that the display was disabled.</summary>
		DisplayWasDisabled = -11845,
		/// <summary>Indicates that a torch level was unavailable, possibly due to overheating.</summary>
		TorchLevelUnavailable = -11846,
		/// <summary>Indicates that an operation was interrupted.</summary>
		OperationInterrupted = -11847,
		/// <summary>Indicates that the media format is not supported by the device.</summary>
		IncompatibleAsset = -11848,
		/// <summary>Indicates that the media data could not be loaded due to missing required data.</summary>
		FailedToLoadMediaData = -11849,
		/// <summary>Indicates that the media server is not correctly configured.</summary>
		ServerIncorrectlyConfigured = -11850,
		/// <summary>Indicates that the application was not authorized on the device.</summary>
		ApplicationIsNotAuthorizedToUseDevice = -11852,
		/// <summary>Indicates that the data could not be parsed.</summary>
		FailedToParse2 = -11853,
		/// <summary>Indicates that the file type does not support sample references.</summary>
		FileTypeDoesNotSupportSampleReferences = -11854,
		/// <summary>Indicates that the media data was corrupted.</summary>
		UndecodableMediaData = -11855,
		/// <summary>Indicates that playback failed because the controller lacked necessary internet access.</summary>
		AirPlayControllerRequiresInternet = -11856,
		/// <summary>Indicates that playback failed because the receiver lacked necessary internet access.</summary>
		AirPlayReceiverRequiresInternet = -11857,
		/// <summary>Indicates that a video compositor failed.</summary>
		VideoCompositorFailed = -11858,
		/// <summary>Indicates that an attempt was made to start a recording while another was in progress.</summary>
		RecordingAlreadyInProgress = -11859,
		CreateContentKeyRequestFailed = -11860,
		/// <summary>Indicates that the output settings were not supported.</summary>
		UnsupportedOutputSettings = -11861,
		/// <summary>Indicates that a disallowed operation was attempted.</summary>
		OperationNotAllowed = -11862,
		/// <summary>To be added.</summary>
		ContentIsUnavailable = -11863,
		/// <summary>To be added.</summary>
		FormatUnsupported = -11864,
		/// <summary>To be added.</summary>
		MalformedDepth = -11865,
		/// <summary>To be added.</summary>
		ContentNotUpdated = -11866,
		/// <summary>To be added.</summary>
		NoLongerPlayable = -11867,
		/// <summary>To be added.</summary>
		NoCompatibleAlternatesForExternalDisplay = -11868,
		/// <summary>To be added.</summary>
		NoSourceTrack = -11869,
		ExternalPlaybackNotSupportedForAsset = -11870,
		OperationNotSupportedForPreset = -11871,
		SessionHardwareCostOverage = -11872,
		UnsupportedDeviceActiveFormat = -11873,
		IncorrectlyConfigured = -11875,
		SegmentStartedWithNonSyncSample = -11876,
		RosettaNotInstalled = -11877,
		OperationCancelled = -11878,
		RequestCancelled = -11879,
		InvalidSampleCursor = -11880,
		FailedToLoadSampleData = -11881,
		AirPlayReceiverTemporarilyUnavailable = -11882,
		EncodeFailed = -11883,
		SandboxExtensionDenied = -11884,
		ToneMappingFailed = -11885,
		MediaExtensionDisabled = -11886,
		MediaExtensionConflict = -11887,
		ContentKeyRequestPlaybackDestinationDoesNotSupportDeviceIdentifierRandomization = -11888,
		ContentKeyInvalid = -11889,
		NoSmartFramingsEnabled = -11890,
		AutoWhiteBalanceNotLocked = -11891,
		FollowExternalSyncDeviceTimedOut = -11892,
	}
}
