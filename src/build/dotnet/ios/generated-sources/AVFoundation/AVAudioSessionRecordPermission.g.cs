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
	/// <summary>Enumerates valid permissions for <see cref="T:AVFoundation.AVAudioSession" />.</summary><remarks>To be added.</remarks>
	[ObsoletedOSPlatform ("ios17.0", "Use 'AVAudioApplicationRecordPermission' instead.")]
	[ObsoletedOSPlatform ("tvos17.0", "Use 'AVAudioApplicationRecordPermission' instead.")]
	[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'AVAudioApplicationRecordPermission' instead.")]
	[ObsoletedOSPlatform ("macos14.0", "Use 'AVAudioApplicationRecordPermission' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum AVAudioSessionRecordPermission : ulong {
		/// <summary>The user has neither nor denied permission, generally because they have not yet interacted with the permissions dialog.</summary>
		Undetermined = 1970168948,
		/// <summary>The user denied permission.</summary>
		Denied = 1684369017,
		/// <summary>The user granted permission.</summary>
		Granted = 1735552628,
	}
}
