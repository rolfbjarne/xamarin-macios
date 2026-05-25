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
namespace UIKit {
	/// <summary>An enumeration of event subtypes.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIEventSubtype : long {
		/// <summary>The event has no subtype.</summary>
		None = 0,
		/// <summary>An event relating to the user shaking the device.</summary>
		MotionShake = 1,
		/// <summary>A remote-control event for playing audio or video.</summary>
		RemoteControlPlay = 100,
		/// <summary>A remote-control event for pausing audio or video.</summary>
		RemoteControlPause = 101,
		/// <summary>A remote-control event for stopping audio or video. </summary>
		RemoteControlStop = 102,
		/// <summary>A remote-control event for toggling play/pause of audio or video.</summary>
		RemoteControlTogglePlayPause = 103,
		/// <summary>A remote-controler event for skipping to the next track.</summary>
		RemoteControlNextTrack = 104,
		/// <summary>A remote-control event for skipping to the previous track.</summary>
		RemoteControlPreviousTrack = 105,
		/// <summary>A remote-control event to start seeking backward through audio or video.</summary>
		RemoteControlBeginSeekingBackward = 106,
		/// <summary>A remote-control event to end seeking backward through audio or video.</summary>
		RemoteControlEndSeekingBackward = 107,
		/// <summary>A remote-control event to begin seeking forward through audio or video.</summary>
		RemoteControlBeginSeekingForward = 108,
		/// <summary>A remote-control event to end seeking forward through audio or video.</summary>
		RemoteControlEndSeekingForward = 109,
	}
}
