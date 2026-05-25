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
	/// <summary>The visual style of a <see cref="T:UIKit.UIBarButtonItem" />.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIBarButtonItemStyle : long {
		/// <summary>Plain style, will glow when tapped.</summary>
		Plain = 0,
		/// <summary>Developers should not use this deprecated field. Developers should use 'UIBarButtonItemStyle.Plain' instead.</summary>
		[ObsoletedOSPlatform ("ios8.0", "Use 'UIBarButtonItemStyle.Plain' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'UIBarButtonItemStyle.Plain' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIBarButtonItemStyle.Plain' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		Bordered = 1,
		/// <summary>Style for a done button.   This should be used if the screen will be dismissed upon tapping.</summary>
		Done = 2,
	}
}
