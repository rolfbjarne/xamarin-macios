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
	/// <summary>This enum provides the possible values for the <see cref="F:AudioToolbox.AUAudioMixParameter.Style" /> parameter.</summary>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedOSPlatform ("tvos")]
	public enum AUAudioMixRenderingStyle : uint {
		/// <summary>Render with a cinematic style. This is the default value.</summary>
		Cinematic = 0,
		/// <summary>Render with a studio style.</summary>
		Studio = 1,
		/// <summary>Render with an in-frame style.</summary>
		InFrame = 2,
		/// <summary>Render the background only with a cinematic style.</summary>
		CinematicBackgroundStem = 3,
		/// <summary>Render the foreground only with a cinematic style.</summary>
		CinematicForegroundStem = 4,
		/// <summary>Render the foreground only with a stydio style.</summary>
		StudioForegroundStem = 5,
		/// <summary>Render the foreground only with an in-frame style.</summary>
		InFrameForegroundStem = 6,
		/// <summary>Render with a standard style.</summary>
		Standard = 7,
		/// <summary>Render the background only with a studio style.</summary>
		StudioBackgroundStem = 8,
		/// <summary>Render the background only with an in-frame style.</summary>
		InFrameBackgroundStem = 9,
	}
}
