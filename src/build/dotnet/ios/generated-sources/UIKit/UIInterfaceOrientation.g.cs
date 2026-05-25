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
	/// <summary>An enumeration of values that specify the orientation of the user interface.</summary><remarks><para>The <see cref="T:UIKit.UIInterfaceOrientation" /> represents the rotation of the user interface and, in portrait modes, is the opposite of the <see cref="P:UIKit.UIDevice.Orientation" /> property. For instance, if the device is rotated 90 degrees clockwise from normal portrait mode such that the home button is to the left, the <see cref="P:UIKit.UIViewController.InterfaceOrientation" /> property will be  <see cref="F:UIKit.UIInterfaceOrientation.LandscapeLeft" /> but the <see cref="P:UIKit.UIDevice.Orientation" /> property will be <see cref="F:UIKit.UIDeviceOrientation.LandscapeRight" />.
	/// </para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIInterfaceOrientation : long {
		/// <summary>The orientation is unknown.</summary>
		Unknown = 0,
		/// <summary>The home button is at the bottom.</summary>
		Portrait = 1,
		/// <summary>The home button is at the top.</summary>
		PortraitUpsideDown = 2,
		/// <summary>The home button is to the left.</summary>
		LandscapeLeft = 4,
		/// <summary>The home button is to the right.</summary>
		LandscapeRight = 3,
	}
}
