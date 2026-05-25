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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos11.0")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSWorkspaceLaunchOptions : ulong {
		/// <summary>To be added.</summary>
		Print = 2,
		WithErrorPresentation = 64,
		/// <summary>To be added.</summary>
		InhibitingBackgroundOnly = 128,
		/// <summary>To be added.</summary>
		WithoutAddingToRecents = 256,
		/// <summary>To be added.</summary>
		WithoutActivation = 512,
		/// <summary>To be added.</summary>
		Async = 65536,
		/// <summary>To be added.</summary>
		AllowingClassicStartup = 131072,
		/// <summary>To be added.</summary>
		PreferringClassic = 262144,
		/// <summary>To be added.</summary>
		NewInstance = 524288,
		/// <summary>To be added.</summary>
		Hide = 1048576,
		/// <summary>To be added.</summary>
		HideOthers = 2097152,
		/// <summary>To be added.</summary>
		Default = 196608,
	}
}
