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
namespace SceneKit {
	/// <summary>Enumeration of the ways SceneKit can blend colors from a material with colors that already exist in the render target.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum SCNBlendMode : long {
		/// <summary>Indicates that colors will be blended by multiplying the source and destination values by their corresponding alpha values</summary>
		Alpha = 0,
		/// <summary>Indicates that colors will be blended by adding their values.</summary>
		Add = 1,
		/// <summary>Indicates that colors will be blended by subtracting the source from the destination.</summary>
		Subtract = 2,
		/// <summary>Indicates that colors will be blended by multiplying their corresponding components.</summary>
		Multiply = 3,
		/// <summary>Indicates that colors will be blended by multiplying their corresponding inverses.</summary>
		Screen = 4,
		/// <summary>Indicates that colors will be blended by replacing the destination with the source and ignoring the alpha channel.</summary>
		Replace = 5,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		Max = 6,
	}
}
