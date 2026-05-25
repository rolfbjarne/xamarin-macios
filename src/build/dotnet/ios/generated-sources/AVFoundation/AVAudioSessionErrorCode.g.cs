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
namespace AVFoundation {
	/// <summary>An enumeration whose values specify various errors relating to <see cref="T:AVFoundation.AVAudioSession" />s.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVAudioSessionErrorCode : long {
		/// <summary>Indicates that no error occurred. Success.</summary>
		None = 0,
		/// <summary>Indicates that Media Services has failed.</summary>
		MediaServicesFailed = 1836282486,
		/// <summary>Indicates that an attempt was made to inactivate a busy session.</summary>
		IsBusy = 560030580,
		/// <summary>Indicates that an operation that is incompatible with the current category was attempted.</summary>
		IncompatibleCategory = 560161140,
		/// <summary>Indicates that a session with nonmixable audio tried to activate while the app was in the background.</summary>
		CannotInterruptOthers = 560557684,
		/// <summary>Indicates that a required entitlement was not present.</summary>
		MissingEntitlement = 1701737535,
		/// <summary>Indicates that Siri was recording when the operation was attempted.</summary>
		SiriIsRecording = 1936290409,
		/// <summary>Indicates that audio playback was attempted when playback was not allowed.</summary>
		CannotStartPlaying = 561015905,
		/// <summary>Indicates that audio recording was attempted and failed.</summary>
		CannotStartRecording = 561145187,
		/// <summary>Indicates that the app tried to set a parameter to a disallowed value.</summary>
		BadParam = -50,
		/// <summary>Indicates that another app with higher priority preempted the operation.</summary>
		InsufficientPriority = 561017449,
		/// <summary>Indicates that a required resource, such as an audio input, is not available on the device.</summary>
		ResourceNotAvailable = 561145203,
		/// <summary>Indicates that an unspecified error occurred.</summary>
		Unspecified = 2003329396,
		ExpiredSession = 561210739,
		SessionNotActive = 1768841571,
	}
}
