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
	[SupportedOSPlatform ("macos")]
	[Flags]
	[Native]
	public enum NSPrintPanelOptions : long {
		/// <summary>To be added.</summary>
		ShowsCopies = 1,
		/// <summary>To be added.</summary>
		ShowsPageRange = 2,
		/// <summary>To be added.</summary>
		ShowsPaperSize = 4,
		/// <summary>To be added.</summary>
		ShowsOrientation = 8,
		/// <summary>To be added.</summary>
		ShowsScaling = 16,
		/// <summary>To be added.</summary>
		ShowsPrintSelection = 32,
		/// <summary>To be added.</summary>
		ShowsPageSetupAccessory = 256,
		/// <summary>To be added.</summary>
		ShowsPreview = 131072,
	}
}
