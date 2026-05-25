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
namespace BrowserEngineKit {
	[SupportedOSPlatform ("tvos17.4")]
	[SupportedOSPlatform ("macos14.4")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Native]
	public enum BEGestureType : long {
		Loupe = 0,
		OneFingerTap = 1,
		DoubleTapAndHold = 2,
		DoubleTap = 3,
		OneFingerDoubleTap = 8,
		OneFingerTripleTap = 9,
		TwoFingerSingleTap = 10,
		TwoFingerRangedSelectGesture = 11,
		IMPhraseBoundaryDrag = 14,
		ForceTouch = 15,
	}
}
