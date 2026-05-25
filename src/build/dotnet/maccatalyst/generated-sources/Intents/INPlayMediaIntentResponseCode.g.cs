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
namespace Intents {
	[SupportedOSPlatform ("tvos14.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum INPlayMediaIntentResponseCode : long {
		/// <summary>To be added.</summary>
		Unspecified = 0,
		/// <summary>To be added.</summary>
		Ready = 1,
		/// <summary>To be added.</summary>
		ContinueInApp = 2,
		/// <summary>To be added.</summary>
		InProgress = 3,
		/// <summary>To be added.</summary>
		Success = 4,
		/// <summary>To be added.</summary>
		HandleInApp = 5,
		/// <summary>To be added.</summary>
		Failure = 6,
		/// <summary>To be added.</summary>
		FailureRequiringAppLaunch = 7,
		/// <summary>To be added.</summary>
		FailureUnknownMediaType = 8,
		/// <summary>To be added.</summary>
		FailureNoUnplayedContent = 9,
		/// <summary>To be added.</summary>
		FailureRestrictedContent = 10,
		FailureMaxStreamLimitReached = 11,
	}
}
