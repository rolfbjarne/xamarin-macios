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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
