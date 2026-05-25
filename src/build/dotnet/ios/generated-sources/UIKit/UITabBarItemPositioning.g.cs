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
	/// <summary>An enumeration whose values specify how a <see cref="T:UIKit.UITabBarItem" /> is positioned.</summary><remarks>To be added.</remarks><altmember cref="P:UIKit.UITabBar.ItemPositioning" /><altmember cref="P:UIKit.UITabBarAppearance.StackedItemPositioning" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITabBarItemPositioning : long {
		/// <summary>The item positioning is controlled by the user interface idiom.</summary>
		Automatic = 0,
		/// <summary>The tab bar items are distributed across the width of the tab bar. Default value on iPhone.</summary>
		Fill = 1,
		/// <summary>The tab bar items are centered in the tab bar. Default on iPad.</summary>
		Centered = 2,
	}
}
