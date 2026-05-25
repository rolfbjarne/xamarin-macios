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
	/// <summary>An enumeration whose values flag the hardware modifier keys associated with a <see cref="T:UIKit.UIKeyCommand" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UIKeyModifierFlags : long {
		/// <summary>The caps lock is pressed.</summary>
		AlphaShift = 65536,
		/// <summary>The shift key is pressed.</summary>
		Shift = 131072,
		/// <summary>The control key is pressed.</summary>
		Control = 262144,
		/// <summary>The option key is pressed.</summary>
		Alternate = 524288,
		/// <summary>The command key is pressed.</summary>
		Command = 1048576,
		/// <summary>The pressed key is on the numeric pad.</summary>
		NumericPad = 2097152,
	}
}
