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
	/// <summary>An enumeration whose values specify valid page-break modes for the <see cref="T:UIKit.UIWebView" />'s <see cref="P:UIKit.UIWebView.PaginationMode" /> property.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIWebPaginationMode : long {
		/// <summary>Content appears as one long scrolling view with no pages.</summary>
		Unpaginated = 0,
		/// <summary>The content will be broken into pages that flow from left to right.</summary>
		LeftToRight = 1,
		/// <summary>The content will be broken into pages that flow from top to bottom.</summary>
		TopToBottom = 2,
		/// <summary>The content will be broken into pages that flow from bottom to top.</summary>
		BottomToTop = 3,
		/// <summary>The content will be broken into pages that flow from right to left.</summary>
		RightToLeft = 4,
	}
}
