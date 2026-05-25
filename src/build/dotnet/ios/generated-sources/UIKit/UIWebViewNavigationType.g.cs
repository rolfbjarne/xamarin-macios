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
	/// <summary>An enumeration of navigation types for use in a <see cref="T:UIKit.UIWebView" />.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIWebViewNavigationType : long {
		/// <summary>The user tapped a link.</summary>
		LinkClicked = 0,
		/// <summary>The app user has submitted a form.</summary>
		FormSubmitted = 1,
		/// <summary>The app user has tapped either the back or forward button.</summary>
		BackForward = 2,
		/// <summary>The app user has tapped the reload button.</summary>
		Reload = 3,
		/// <summary>The app user has resubmitted a form.</summary>
		FormResubmitted = 4,
		/// <summary>The app user has performed some other action.</summary>
		Other = 5,
	}
}
