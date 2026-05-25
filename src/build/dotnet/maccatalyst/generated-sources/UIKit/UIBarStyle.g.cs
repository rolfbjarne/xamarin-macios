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
	/// <summary>The visual style for a navigation, search, or tool bar.</summary><remarks><para>The style used for <see cref="T:UIKit.UINavigationBar" />, <see cref="T:UIKit.UISearchBar" />, and <see cref="T:UIKit.UIToolbar" />.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIBarStyle : long {
		/// <summary>The system default</summary>
		Default = 0,
		/// <summary>Black</summary>
		Black = 1,
		/// <summary>Developers should not use this deprecated field. Developers should use 'UIBarStyle.Black'.</summary>
		[ObsoletedOSPlatform ("ios5.1", "Use 'UIBarStyle.Black'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIBarStyle.Black'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		BlackOpaque = 1,
		/// <summary>Black translucent</summary>
		[ObsoletedOSPlatform ("ios5.1", "Use 'UIBarStyle.Black' and set the translucency property to true.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIBarStyle.Black' and set the translucency property to true.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		BlackTranslucent = 2,
	}
}
