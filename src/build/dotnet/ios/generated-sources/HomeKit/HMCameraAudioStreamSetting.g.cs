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
namespace HomeKit {
	/// <summary>Settings for camera's with audio devices. Used with <see cref="P:HomeKit.HMCameraStream.AudioStreamSetting" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum HMCameraAudioStreamSetting : ulong {
		/// <summary>The <see cref="T:HomeKit.HMCameraAudioStreamSetting" /> describing whether the audio capabilities are muted.</summary>
		Muted = 1,
		/// <summary>The <see cref="T:HomeKit.HMCameraAudioStreamSetting" /> describing whether camera microphone one-way audio is enabled.</summary>
		IncomingAudioAllowed = 2,
		/// <summary>The <see cref="T:HomeKit.HMCameraAudioStreamSetting" /> describing whether two-way audio is enabled.</summary>
		BidirectionalAudioAllowed = 3,
	}
}
