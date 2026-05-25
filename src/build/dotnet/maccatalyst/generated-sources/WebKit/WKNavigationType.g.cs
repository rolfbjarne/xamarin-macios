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
namespace WebKit {
	/// <summary>Enumerates the types of action that can cause navigation.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum WKNavigationType : long {
		/// <summary>The user activated a link.</summary>
		LinkActivated = 0,
		/// <summary>The user submitted a form.</summary>
		FormSubmitted = 1,
		/// <summary>The user moved forward or backward through the browsing history.</summary>
		BackForward = 2,
		/// <summary>A page was reloaded.</summary>
		Reload = 3,
		/// <summary>The user resubmitted a form.</summary>
		FormResubmitted = 4,
		/// <summary>An action that is not represented by this enumeration caused the navigation.</summary>
		Other = -1,
	}
}
