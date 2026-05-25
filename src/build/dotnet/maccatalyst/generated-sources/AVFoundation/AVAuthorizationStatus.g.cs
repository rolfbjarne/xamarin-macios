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
	/// <summary>An enumeration whose values specify whether a <see cref="T:AVFoundation.AVCaptureDevice" /> has been authorized by the user for use. Used with <see cref="M:AVFoundation.AVCaptureDevice.GetAuthorizationStatus(Foundation.NSString)" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum AVAuthorizationStatus : long {
		/// <summary>The user has not interacted with the permissions dialog.</summary>
		NotDetermined = 0,
		/// <summary>The user is denied access and may not change permission.</summary>
		Restricted = 1,
		/// <summary>The user has denied access.</summary>
		Denied = 2,
		/// <summary>The user has granted access.</summary>
		Authorized = 3,
	}
}
