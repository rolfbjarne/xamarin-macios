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
	/// <summary>An enumeration indicating the resizing style for <see cref="T:UIKit.UIView" />s.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Flags]
	[Native]
	public enum UIViewAutoresizing : ulong {
		/// <summary>Indicates that the view does not resize.</summary>
		None = 0,
		/// <summary>Resizing is performed by expanding or shrinking the UIView in the direction of the left margin.</summary>
		FlexibleLeftMargin = 1,
		/// <summary>Resizing is performed by expanding or shrinking the UIView's width.</summary>
		FlexibleWidth = 2,
		/// <summary>Resizing is performed by expanding or shrinking the UIView in the direction of the right margin.</summary>
		FlexibleRightMargin = 4,
		/// <summary>Resizing is performed by expanding or shrinking the UIView in the direction of the top margin.</summary>
		FlexibleTopMargin = 8,
		/// <summary>Resizing is performed by expanding or shrinking the UIView's height.</summary>
		FlexibleHeight = 16,
		/// <summary>Resizing is performed by expanding or shrinking the UIView in the direction of the bottom margin.</summary>
		FlexibleBottomMargin = 32,
		/// <summary>Combination of all flexible margin values.</summary>
		FlexibleMargins = 45,
		/// <summary>Combines <see cref="F:UIKit.UIViewAutoresizing.FlexibleHeight" /> and <see cref="F:UIKit.UIViewAutoresizing.FlexibleWidth" />.</summary>
		FlexibleDimensions = 18,
		/// <summary>The UIView resizes on all sides.</summary>
		All = 63,
	}
}
