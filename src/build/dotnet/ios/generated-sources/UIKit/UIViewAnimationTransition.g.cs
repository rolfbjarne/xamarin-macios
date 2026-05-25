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
namespace UIKit {
	/// <summary>An enumeration of predefined animated transitions.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIViewAnimationTransition : long {
		/// <summary>The option for indicating that no transition is specified.</summary>
		None = 0,
		/// <summary>A transition that flips a UIView around a vertical axis from left to right. The left moves forward and the right backward.</summary>
		FlipFromLeft = 1,
		/// <summary>A transition that flips a UIView around a vertical axis from right to left The right moves forward and the left backward.</summary>
		FlipFromRight = 2,
		/// <summary>A transition that curls a UIView up from the bottom.</summary>
		CurlUp = 3,
		/// <summary>A transition that curls a UIView down from the top.</summary>
		CurlDown = 4,
	}
}
