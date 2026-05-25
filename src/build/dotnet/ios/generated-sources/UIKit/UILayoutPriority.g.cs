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
	/// <summary>An enumeration of values used by flow layouts to prioritize constraints.</summary><remarks><para>Higher values are considered more important by the flow layout constraint engine. Application developers should not specify a layout priority greater than the value of <see cref="F:UIKit.UILayoutPriority.Required" /></para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public enum UILayoutPriority : int {
		/// <summary>Indicates a required constraint. The underlying value of this is 1000.</summary>
		Required = 1000,
		/// <summary>The resistance by which a button resists compressing its content.</summary>
		DefaultHigh = 750,
		/// <summary>The priority at which a button hugs its content horizontally.</summary>
		DefaultLow = 250,
		/// <summary>Generally not used; the priority at which a view wants to conform to the value of UIView.SystemLayoutSizeFitting.</summary>
		FittingSizeLevel = 50,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		DragThatCanResizeScene = 510,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		SceneSizeStayPut = 500,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		DragThatCannotResizeScene = 490,
	}
}
