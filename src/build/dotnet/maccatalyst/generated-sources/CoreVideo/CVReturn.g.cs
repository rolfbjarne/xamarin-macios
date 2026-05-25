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
namespace CoreVideo {
	/// <summary>Possible status codes for CoreVideo functions.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum CVReturn : int {
		/// <summary>The method executed successfully.</summary>
		Success = 0,
		/// <summary>Internal marker</summary>
		First = -6660,
		/// <summary>Generic error message.</summary>
		Error = -6660,
		/// <summary>Caller passed an invalid argument.</summary>
		InvalidArgument = -6661,
		/// <summary>Allocation failed.</summary>
		AllocationFailed = -6662,
		/// <summary>The operation is not supported.</summary>
		Unsupported = -6663,
		/// <summary>The specified display is invalid</summary>
		InvalidDisplay = -6670,
		/// <summary>The displauy link is already running.</summary>
		DisplayLinkAlreadyRunning = -6671,
		/// <summary>The display link is not running</summary>
		DisplayLinkNotRunning = -6672,
		/// <summary>There are no callbacks registered for the specified display link.</summary>
		DisplayLinkCallbacksNotSet = -6673,
		/// <summary>The specified pixel format is not valid.</summary>
		InvalidPixelFormat = -6680,
		/// <summary>Invalid buffer size.</summary>
		InvalidSize = -6681,
		/// <summary>The specified pixel buffer attributes are not valid.</summary>
		InvalidPixelBufferAttributes = -6682,
		/// <summary>The pixel format is not compatible with OpenGL.</summary>
		PixelBufferNotOpenGLCompatible = -6683,
		/// <summary>The pixel buffer is not compatible with Metal.</summary>
		PixelBufferNotMetalCompatible = -6684,
		/// <summary>Performing this operation would exceed the allocation threshold.</summary>
		WouldExceedAllocationThreshold = -6689,
		/// <summary>Failure to allocate the pool.</summary>
		PoolAllocationFailed = -6690,
		/// <summary>It is not possible to create a buffer pool with the specified attributes.</summary>
		InvalidPoolAttributes = -6691,
		/// <summary>The method will retry.</summary>
		Retry = -6692,
		/// <summary>Internal marker.</summary>
		Last = -6699,
	}
}
