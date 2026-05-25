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
	public enum NSEventMask : ulong {
		/// <summary>To be added.</summary>
		LeftMouseDown = 2,
		/// <summary>To be added.</summary>
		LeftMouseUp = 4,
		/// <summary>To be added.</summary>
		RightMouseDown = 8,
		/// <summary>To be added.</summary>
		RightMouseUp = 16,
		/// <summary>To be added.</summary>
		MouseMoved = 32,
		/// <summary>To be added.</summary>
		LeftMouseDragged = 64,
		/// <summary>To be added.</summary>
		RightMouseDragged = 128,
		/// <summary>To be added.</summary>
		MouseEntered = 256,
		/// <summary>To be added.</summary>
		MouseExited = 512,
		/// <summary>To be added.</summary>
		KeyDown = 1024,
		/// <summary>To be added.</summary>
		KeyUp = 2048,
		/// <summary>To be added.</summary>
		FlagsChanged = 4096,
		/// <summary>To be added.</summary>
		AppKitDefined = 8192,
		/// <summary>To be added.</summary>
		SystemDefined = 16384,
		/// <summary>To be added.</summary>
		ApplicationDefined = 32768,
		/// <summary>To be added.</summary>
		Periodic = 65536,
		/// <summary>To be added.</summary>
		CursorUpdate = 131072,
		/// <summary>To be added.</summary>
		ScrollWheel = 4194304,
		/// <summary>To be added.</summary>
		TabletPoint = 8388608,
		/// <summary>To be added.</summary>
		TabletProximity = 16777216,
		/// <summary>To be added.</summary>
		OtherMouseDown = 33554432,
		/// <summary>To be added.</summary>
		OtherMouseUp = 67108864,
		/// <summary>To be added.</summary>
		OtherMouseDragged = 134217728,
		/// <summary>To be added.</summary>
		EventGesture = 536870912,
		/// <summary>To be added.</summary>
		EventMagnify = 1073741824,
		/// <summary>To be added.</summary>
		EventSwipe = 2147483648,
		/// <summary>To be added.</summary>
		EventRotate = 262144,
		/// <summary>To be added.</summary>
		EventBeginGesture = 524288,
		/// <summary>To be added.</summary>
		EventEndGesture = 1048576,
		/// <summary>To be added.</summary>
		SmartMagnify = 4294967296,
		/// <summary>To be added.</summary>
		Pressure = 17179869184,
		/// <summary>To be added.</summary>
		DirectTouch = 137438953472,
		ChangeMode = 274877906944,
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		MouseCancelled = 1099511627776,
		/// <summary>To be added.</summary>
		AnyEvent = 18446744073709551615,
	}
}
