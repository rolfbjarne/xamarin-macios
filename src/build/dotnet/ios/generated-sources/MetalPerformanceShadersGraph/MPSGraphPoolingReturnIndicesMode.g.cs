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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("ios15.3")]
	[SupportedOSPlatform ("tvos15.3")]
	[SupportedOSPlatform ("macos12.2")]
	[SupportedOSPlatform ("maccatalyst15.3")]
	[Native]
	public enum MPSGraphPoolingReturnIndicesMode : ulong {
		None = 0,
		GlobalFlatten1d = 1,
		GlobalFlatten2d = 2,
		GlobalFlatten3d = 3,
		GlobalFlatten4d = 4,
		LocalFlatten1d = 5,
		LocalFlatten2d = 6,
		LocalFlatten3d = 7,
		LocalFlatten4d = 8,
	}
}
