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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>An enumeration of possible states for a <see cref="T:UIKit.UIControl" />.</summary><remarks>Flags representing the state of a control.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UIControlState : ulong {
		/// <summary>The normal state of the control (not disabled and not higlighted)</summary>
		Normal = 0,
		/// <summary>Control is highlighted.  You can change this through the Highlighted property of the control.</summary>
		Highlighted = 1,
		/// <summary>Control is in the disabled state.   You can change this through the Enabled property of the control.</summary>
		Disabled = 2,
		/// <summary>Selected state of the control.  You can change this value by accessing the Selected property of the UIControl.</summary>
		Selected = 4,
		/// <summary>Indicates that the control has the focus.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		Focused = 8,
		/// <summary>Mask for application defined states for a control.   Possible application-reservedd values are 0x00010000 to 0x00ff0000.</summary>
		Application = 16711680,
		/// <summary>Reserved mask, no states should be defined in this range by the application.</summary>
		Reserved = 4278190080,
	}
}
