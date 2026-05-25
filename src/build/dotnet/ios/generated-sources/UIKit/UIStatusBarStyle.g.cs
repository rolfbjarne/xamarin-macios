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
	/// <summary>The visual style of the status bar.</summary><remarks><para>Starting in iOS 7, the status bar does not have background content, so application developers must ensure that the style of the status bar works with the content of the <see cref="T:UIKit.UIView" /> that will appear behind it. The <see cref="F:UIKit.UIStatusBarStyle.Default" /> style of the status bar presents dark content (i.e., its text and content are dark). If the underlying view has dark content, the status bar will be more legible if the application developer overrides <see cref="M:UIKit.UIViewController.PreferredStatusBarStyle" /> so that it returns <see cref="F:UIKit.UIStatusBarStyle.LightContent" />.</para></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIStatusBarStyle : long {
		/// <summary>The default, dark, value for content in the status bar. Preferable for use with lighter-colored content views.</summary>
		Default = 0,
		/// <summary>Application developers should not use this deprecated style.</summary>
		[ObsoletedOSPlatform ("ios7.0", "Use 'LightContent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LightContent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		BlackTranslucent = 1,
		/// <summary>Content in the status bar is drawn with light values. Preferable for use wth darker-colored content views.</summary>
		LightContent = 1,
		/// <summary>Developers should not use this deprecated field. Developers should use 'LightContent' instead.</summary>
		[ObsoletedOSPlatform ("ios7.0", "Use 'LightContent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LightContent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		BlackOpaque = 2,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		DarkContent = 3,
	}
}
