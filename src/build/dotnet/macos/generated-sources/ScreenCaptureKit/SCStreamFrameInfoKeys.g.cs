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
namespace ScreenCaptureKit {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	public unsafe static partial class SCStreamFrameInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BoundingRect;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoBoundingRect'.</summary>
		[Field ("SCStreamFrameInfoBoundingRect",  "ScreenCaptureKit")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public static NSString BoundingRect {
			[SupportedOSPlatform ("macos14.0")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			get {
				if (_BoundingRect is null)
					_BoundingRect = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoBoundingRect")!;
				return _BoundingRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentRect;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoContentRect'.</summary>
		[Field ("SCStreamFrameInfoContentRect",  "ScreenCaptureKit")]
		public static NSString ContentRect {
			get {
				if (_ContentRect is null)
					_ContentRect = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoContentRect")!;
				return _ContentRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentScale;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoContentScale'.</summary>
		[Field ("SCStreamFrameInfoContentScale",  "ScreenCaptureKit")]
		public static NSString ContentScale {
			get {
				if (_ContentScale is null)
					_ContentScale = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoContentScale")!;
				return _ContentScale;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DirtyRects;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoDirtyRects'.</summary>
		[Field ("SCStreamFrameInfoDirtyRects",  "ScreenCaptureKit")]
		public static NSString DirtyRects {
			get {
				if (_DirtyRects is null)
					_DirtyRects = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoDirtyRects")!;
				return _DirtyRects;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayTime;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoDisplayTime'.</summary>
		[Field ("SCStreamFrameInfoDisplayTime",  "ScreenCaptureKit")]
		public static NSString DisplayTime {
			get {
				if (_DisplayTime is null)
					_DisplayTime = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoDisplayTime")!;
				return _DisplayTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InfoScaleFactor;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoScaleFactor'.</summary>
		[Field ("SCStreamFrameInfoScaleFactor",  "ScreenCaptureKit")]
		public static NSString InfoScaleFactor {
			get {
				if (_InfoScaleFactor is null)
					_InfoScaleFactor = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoScaleFactor")!;
				return _InfoScaleFactor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PresenterOverlayContentRect;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoPresenterOverlayContentRect'.</summary>
		[Field ("SCStreamFrameInfoPresenterOverlayContentRect",  "ScreenCaptureKit")]
		[SupportedOSPlatform ("macos14.2")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public static NSString PresenterOverlayContentRect {
			[SupportedOSPlatform ("macos14.2")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			get {
				if (_PresenterOverlayContentRect is null)
					_PresenterOverlayContentRect = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoPresenterOverlayContentRect")!;
				return _PresenterOverlayContentRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScreenRect;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoScreenRect'.</summary>
		[Field ("SCStreamFrameInfoScreenRect",  "ScreenCaptureKit")]
		[SupportedOSPlatform ("macos13.1")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		public static NSString ScreenRect {
			[SupportedOSPlatform ("macos13.1")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst18.2")]
			get {
				if (_ScreenRect is null)
					_ScreenRect = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoScreenRect")!;
				return _ScreenRect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Status;
		/// <summary>Represents the value associated with the constant 'SCStreamFrameInfoStatus'.</summary>
		[Field ("SCStreamFrameInfoStatus",  "ScreenCaptureKit")]
		public static NSString Status {
			get {
				if (_Status is null)
					_Status = Dlfcn.GetStringConstant (Libraries.ScreenCaptureKit.Handle, "SCStreamFrameInfoStatus")!;
				return _Status;
			}
		}
	} /* class SCStreamFrameInfoKeys */
}
