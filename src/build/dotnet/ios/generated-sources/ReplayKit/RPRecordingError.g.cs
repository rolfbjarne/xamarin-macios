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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace ReplayKit {
	/// <summary>Enumerates errors that can be encountered while recording.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native ("RPRecordingErrorCode")]
	public enum RPRecordingError : long {
		/// <summary>Indicates that no error occurred.</summary>
		None = 0,
		/// <summary>Indicates that an unknown error occurred.</summary>
		Unknown = -5800,
		/// <summary>Indicates that the user declined to begin the recording.</summary>
		UserDeclined = -5801,
		/// <summary>Indicates that parental controls prevented the recording.</summary>
		Disabled = -5802,
		/// <summary>Indicates that the recording failed to start.</summary>
		FailedToStart = -5803,
		/// <summary>Indicates that an error occurred.</summary>
		Failed = -5804,
		/// <summary>Indicates that the available storage was not sufficient.</summary>
		InsufficientStorage = -5805,
		/// <summary>Indicates that another app interrupted the recording.</summary>
		Interrupted = -5806,
		/// <summary>Indicates that the recording was interrupted when the content was resized or the user multitasked.</summary>
		ContentResize = -5807,
		/// <summary>Indicates that the broadcast session was not started.</summary>
		BroadcastInvalidSession = -5808,
		/// <summary>Indicates that the user pressed the power button.</summary>
		SystemDormancy = -5809,
		/// <summary>Indicates that required entitlements were missing.</summary>
		Entitlements = -5810,
		/// <summary>Indicates that an active phone call prevented recording.</summary>
		ActivePhoneCall = -5811,
		/// <summary>To be added.</summary>
		FailedToSave = -5812,
		/// <summary>To be added.</summary>
		CarPlay = -5813,
		/// <summary>To be added.</summary>
		FailedApplicationConnectionInvalid = -5814,
		/// <summary>To be added.</summary>
		FailedApplicationConnectionInterrupted = -5815,
		/// <summary>To be added.</summary>
		FailedNoMatchingApplicationContext = -5816,
		/// <summary>To be added.</summary>
		FailedMediaServicesFailure = -5817,
		/// <summary>To be added.</summary>
		VideoMixingFailure = -5818,
		BroadcastSetupFailed = -5819,
		FailedToObtainUrl = -5820,
		FailedIncorrectTimeStamps = -5821,
		FailedToProcessFirstSample = -5822,
		FailedAssetWriterFailedToSave = -5823,
		FailedNoAssetWriter = -5824,
		FailedAssetWriterInWrongState = -5825,
		FailedAssetWriterExportFailed = -5826,
		FailedToRemoveFile = -5827,
		FailedAssetWriterExportCanceled = -5828,
		AttemptToStopNonRecording = -5829,
		AttemptToStartInRecordingState = -5830,
		PhotoFailure = -5831,
		RecordingInvalidSession = -5832,
		FailedToStartCaptureStack = -5833,
		InvalidParameter = -5834,
		FilePermissions = -5835,
		ExportClipToUrlInProgress = -5836,
	}
	/// <summary>Extension methods for the <see cref="global::ReplayKit.RPRecordingError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::ReplayKit.RPRecordingError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class RPRecordingErrorExtensions {
		[Field ("RPRecordingErrorDomain", "ReplayKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the ReplayKit.RPRecordingError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this RPRecordingError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.ReplayKit.Handle, "RPRecordingErrorDomain");
			return _domain;
		}
	}
}
