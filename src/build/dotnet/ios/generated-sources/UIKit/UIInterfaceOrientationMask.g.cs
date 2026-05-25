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
	/// <summary>An enumeration of values that specify the available orientations of the user interface.</summary><remarks><para>A <see cref="T:UIKit.UIViewController" /> may support more than one <see cref="T:UIKit.UIInterfaceOrientation" />. This value, returned from <see cref="M:UIKit.UIViewController.GetSupportedInterfaceOrientations" /> and <see cref="M:UIKit.UIApplication.SupportedInterfaceOrientationsForWindow(UIKit.UIWindow)" />, specifies which orientations are supported by the application.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Flags]
	[Native]
	public enum UIInterfaceOrientationMask : ulong {
		/// <summary>The long side is vertical.</summary>
		Portrait = 2,
		/// <summary>The UIViewController supports landscape-left orientation.</summary>
		LandscapeLeft = 16,
		/// <summary>The UIViewController supports landscape-right orientation.</summary>
		LandscapeRight = 8,
		/// <summary>The UIViewController supports upside-down portrait orientation.</summary>
		PortraitUpsideDown = 4,
		/// <summary>The UIViewController supports both landscape-left and landscape-right orientations.</summary>
		Landscape = 24,
		/// <summary>The UIViewController supports all interface orientations.</summary>
		All = 30,
		/// <summary>The UIViewController supports all orientations except upside-down portrait.</summary>
		AllButUpsideDown = 26,
	}
}
