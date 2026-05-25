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
namespace AudioToolbox {
	/// <summary>The reason for AudioSession route change event to be raised.</summary>
	public enum AudioSessionRouteChangeReason : int {
		/// <summary>The route changed, but there is no information about why.</summary>
		Unknown = 0,
		/// <summary>A new audio device has been plugged.</summary>
		NewDeviceAvailable = 1,
		/// <summary>The previous device is no longer available.</summary>
		OldDeviceUnavailable = 2,
		/// <summary>The AudioSession category has changed.</summary>
		CategoryChange = 3,
		/// <summary>Audio has been forcibly been redirected by the user setting the AudioSession Category.</summary>
		Override = 4,
		/// <summary>Device has woken up from sleep</summary>
		WakeFromSleep = 6,
		/// <summary>There is no audio device for the current set category in the audio session.  For example, recording when there is no microphone available.</summary>
		NoSuitableRouteForCategory = 7,
		/// <summary>To be added.</summary>
		RouteConfigurationChange = 8,
	}
}
