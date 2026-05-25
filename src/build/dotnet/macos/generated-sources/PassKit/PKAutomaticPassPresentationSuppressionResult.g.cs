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
namespace PassKit {
	/// <summary>Enumerates results that are used in calls to <see cref="M:PassKit.PKPassLibrary.RequestAutomaticPassPresentationSuppression(System.Action{PassKit.PKAutomaticPassPresentationSuppressionResult})" />.</summary>
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum PKAutomaticPassPresentationSuppressionResult : ulong {
		/// <summary>Suppression is not supported on this device.</summary>
		NotSupported = 0,
		/// <summary>System is already presenting a pass and cannot be suppressed.</summary>
		AlreadyPresenting = 1,
		/// <summary>The user denied the ability to suppress presentation.</summary>
		Denied = 2,
		/// <summary>The suppression was cancelled.</summary>
		Cancelled = 3,
		/// <summary>The suppression of pass presentation succeeded.</summary>
		Success = 4,
	}
}
