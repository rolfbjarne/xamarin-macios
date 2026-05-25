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
namespace CoreGraphics {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos15.0", "Use ScreenCaptureKit instead.")]
	[ObsoletedOSPlatform ("maccatalyst18.0", "Use ScreenCaptureKit instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CGDisplayStreamKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorSpace;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamColorSpace'.</summary>
		[Field ("kCGDisplayStreamColorSpace",  "CoreGraphics")]
		public static NSString ColorSpace {
			get {
				if (_ColorSpace is null)
					_ColorSpace = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamColorSpace")!;
				return _ColorSpace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DestinationRect;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamDestinationRect'.</summary>
		[Field ("kCGDisplayStreamDestinationRect",  "CoreGraphics")]
		public static NSString DestinationRect {
			get {
				if (_DestinationRect is null)
					_DestinationRect = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamDestinationRect")!;
				return _DestinationRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinimumFrameTime;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamMinimumFrameTime'.</summary>
		[Field ("kCGDisplayStreamMinimumFrameTime",  "CoreGraphics")]
		public static NSString MinimumFrameTime {
			get {
				if (_MinimumFrameTime is null)
					_MinimumFrameTime = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamMinimumFrameTime")!;
				return _MinimumFrameTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreserveAspectRatio;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamPreserveAspectRatio'.</summary>
		[Field ("kCGDisplayStreamPreserveAspectRatio",  "CoreGraphics")]
		public static NSString PreserveAspectRatio {
			get {
				if (_PreserveAspectRatio is null)
					_PreserveAspectRatio = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamPreserveAspectRatio")!;
				return _PreserveAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QueueDepth;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamQueueDepth'.</summary>
		[Field ("kCGDisplayStreamQueueDepth",  "CoreGraphics")]
		public static NSString QueueDepth {
			get {
				if (_QueueDepth is null)
					_QueueDepth = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamQueueDepth")!;
				return _QueueDepth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShowCursor;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamShowCursor'.</summary>
		[Field ("kCGDisplayStreamShowCursor",  "CoreGraphics")]
		public static NSString ShowCursor {
			get {
				if (_ShowCursor is null)
					_ShowCursor = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamShowCursor")!;
				return _ShowCursor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceRect;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamSourceRect'.</summary>
		[Field ("kCGDisplayStreamSourceRect",  "CoreGraphics")]
		public static NSString SourceRect {
			get {
				if (_SourceRect is null)
					_SourceRect = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamSourceRect")!;
				return _SourceRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YCbCrMatrix;
		/// <summary>Represents the value associated with the constant 'kCGDisplayStreamYCbCrMatrix'.</summary>
		[Field ("kCGDisplayStreamYCbCrMatrix",  "CoreGraphics")]
		public static NSString YCbCrMatrix {
			get {
				if (_YCbCrMatrix is null)
					_YCbCrMatrix = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGDisplayStreamYCbCrMatrix")!;
				return _YCbCrMatrix;
			}
		}
	} /* class CGDisplayStreamKeys */
}
