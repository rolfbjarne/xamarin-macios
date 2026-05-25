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
	/// <summary>An enumeration of attributes for use with constraint-based layouts.</summary><remarks>Values used to specify particular constraint attributes in constraint-based layouts. These values are primarily used by methods in the <see cref="T:UIKit.NSLayoutConstraint" /> class. </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum NSLayoutAttribute : long {
		/// <summary>Indicates no attribute.</summary>
		NoAttribute = 0,
		/// <summary>The left-most X value of the element.</summary>
		Left = 1,
		/// <summary>The right-most X value of the element.</summary>
		Right = 2,
		/// <summary>The top-most Y value of the element.</summary>
		Top = 3,
		/// <summary>The bottom of the element.</summary>
		Bottom = 4,
		/// <summary>In locales with right-to-left text, this value is equal to <see cref="F:UIKit.NSLayoutAttribute.Left" />. In locales such as Hebrew or Arabic, equal to <see cref="F:UIKit.NSLayoutAttribute.Right" />.</summary>
		Leading = 5,
		/// <summary>In locales with right-to-left text, this value is equal to <see cref="F:UIKit.NSLayoutAttribute.Right" />. In locales such as Hebrew or Arabic, equal to <see cref="F:UIKit.NSLayoutAttribute.Left" />.</summary>
		Trailing = 6,
		/// <summary>The size of the element along the X axis.</summary>
		Width = 7,
		/// <summary>The size of the element along the Y axis.</summary>
		Height = 8,
		/// <summary>The left-to-right midpoint of the element.</summary>
		CenterX = 9,
		/// <summary>The top-to-bottom midpoint of the element.</summary>
		CenterY = 10,
		/// <summary>The line on which text without descenders sits.</summary>
		Baseline = 11,
		/// <summary>The element's last baseline.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LastBaseline = 11,
		/// <summary>The element's first baseline.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		FirstBaseline = 12,
		/// <summary>The left margin of the element.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LeftMargin = 13,
		/// <summary>The right margin of the element.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		RightMargin = 14,
		/// <summary>The top margin of the element.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TopMargin = 15,
		/// <summary>The margin from the bottom of the element.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		BottomMargin = 16,
		/// <summary>The leading edge of the element's margin.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		LeadingMargin = 17,
		/// <summary>The trailing margin of the element.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		TrailingMargin = 18,
		/// <summary>The X-center of the region bounded by the element's margins.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CenterXWithinMargins = 19,
		/// <summary>The Y-center of the region bounded by the element's margins.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		CenterYWithinMargins = 20,
	}
}
