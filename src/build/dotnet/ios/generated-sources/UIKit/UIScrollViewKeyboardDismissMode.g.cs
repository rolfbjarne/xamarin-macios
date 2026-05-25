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
	/// <summary>An enumeration whose values specify the mode in which the keyboard is dismissed in a scrollview.</summary><remarks>To be added.</remarks><altmember cref="P:UIKit.UIScrollView.KeyboardDismissMode" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIScrollViewKeyboardDismissMode : long {
		/// <summary>The keyboard does not get dismissed with a drag.</summary>
		None = 0,
		/// <summary>The keyboard is dismissed when a drag begins.</summary>
		OnDrag = 1,
		/// <summary>The keyboard follows the dragging touch offscreen, and can be pulled up again to cancel the dismissal.</summary>
		Interactive = 2,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		OnDragWithAccessory = 3,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		InteractiveWithAccessory = 4,
	}
}
