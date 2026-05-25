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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreMidi {
	/// <summary>An enumeration whose values specify which hosts are eligible to connect to a MIDI network session.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum MidiNetworkConnectionPolicy : ulong {
		/// <summary>To be added.</summary>
		NoOne = 0,
		/// <summary>To be added.</summary>
		HostsInContactsList = 1,
		/// <summary>To be added.</summary>
		Anyone = 2,
	}
}
