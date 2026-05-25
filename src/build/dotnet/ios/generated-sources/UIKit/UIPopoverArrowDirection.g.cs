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
	/// <summary>An enumeration indicating the direction of the arrow attached to a <see cref="T:UIKit.UIPopoverController" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UIPopoverArrowDirection : ulong {
		/// <summary>The arrow will be on top.</summary>
		Up = 1,
		/// <summary>The arrow will be at the bottom.</summary>
		Down = 2,
		/// <summary>The arrow will be on the left.</summary>
		Left = 4,
		/// <summary>The arrow will be on the right.</summary>
		Right = 8,
		/// <summary>This lets the system decide the best position for the arrow.</summary>
		Any = 15,
		/// <summary>The direction of the arrow is unknown.</summary>
		Unknown = 18446744073709551615,
	}
}
