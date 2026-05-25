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
	/// <summary>Describes a view's contents so that the app dev can control if it should be flipped between left-to-right and right-to-left layouts.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UISemanticContentAttribute : long {
		/// <summary>Indicates a default left-right view that is flipped when necessary.</summary>
		Unspecified = 0,
		/// <summary>Indicates a view that contains playback controls, which are not left-right flipped.</summary>
		Playback = 1,
		/// <summary>Indicates a view that contains directional controls, which are not left-right flipped.</summary>
		Spatial = 2,
		/// <summary>Forces the contents to be laid out left to right.</summary>
		ForceLeftToRight = 3,
		/// <summary>Forces the contents to be laid out right to left.</summary>
		ForceRightToLeft = 4,
	}
}
