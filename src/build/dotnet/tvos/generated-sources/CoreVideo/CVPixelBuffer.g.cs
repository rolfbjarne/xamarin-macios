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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreVideo {
	/// <summary>A <see cref="T:CoreVideo.CVImageBuffer" /> that holds pixels.</summary>
	public unsafe partial class CVPixelBuffer  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BytesPerRowAlignmentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferBytesPerRowAlignmentKey",  "CoreVideo")]
		public static NSString BytesPerRowAlignmentKey {
			get {
				if (_BytesPerRowAlignmentKey is null)
					_BytesPerRowAlignmentKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferBytesPerRowAlignmentKey")!;
				return _BytesPerRowAlignmentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGBitmapContextCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferCGBitmapContextCompatibilityKey",  "CoreVideo")]
		public static NSString CGBitmapContextCompatibilityKey {
			get {
				if (_CGBitmapContextCompatibilityKey is null)
					_CGBitmapContextCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferCGBitmapContextCompatibilityKey")!;
				return _CGBitmapContextCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGImageCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferCGImageCompatibilityKey",  "CoreVideo")]
		public static NSString CGImageCompatibilityKey {
			get {
				if (_CGImageCompatibilityKey is null)
					_CGImageCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferCGImageCompatibilityKey")!;
				return _CGImageCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedPixelsBottomKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferExtendedPixelsBottomKey",  "CoreVideo")]
		public static NSString ExtendedPixelsBottomKey {
			get {
				if (_ExtendedPixelsBottomKey is null)
					_ExtendedPixelsBottomKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsBottomKey")!;
				return _ExtendedPixelsBottomKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedPixelsLeftKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferExtendedPixelsLeftKey",  "CoreVideo")]
		public static NSString ExtendedPixelsLeftKey {
			get {
				if (_ExtendedPixelsLeftKey is null)
					_ExtendedPixelsLeftKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsLeftKey")!;
				return _ExtendedPixelsLeftKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedPixelsRightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferExtendedPixelsRightKey",  "CoreVideo")]
		public static NSString ExtendedPixelsRightKey {
			get {
				if (_ExtendedPixelsRightKey is null)
					_ExtendedPixelsRightKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsRightKey")!;
				return _ExtendedPixelsRightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedPixelsTopKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferExtendedPixelsTopKey",  "CoreVideo")]
		public static NSString ExtendedPixelsTopKey {
			get {
				if (_ExtendedPixelsTopKey is null)
					_ExtendedPixelsTopKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsTopKey")!;
				return _ExtendedPixelsTopKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferHeightKey",  "CoreVideo")]
		public static NSString HeightKey {
			get {
				if (_HeightKey is null)
					_HeightKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferHeightKey")!;
				return _HeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IOSurfacePropertiesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferIOSurfacePropertiesKey",  "CoreVideo")]
		public static NSString IOSurfacePropertiesKey {
			get {
				if (_IOSurfacePropertiesKey is null)
					_IOSurfacePropertiesKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferIOSurfacePropertiesKey")!;
				return _IOSurfacePropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IOSurfacePurgeableKey;
		/// <summary>Represents the value associated with the constant 'kCVPixelBufferIOSurfacePurgeableKey'.</summary>
		[Field ("kCVPixelBufferIOSurfacePurgeableKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios15.0")]
		public static NSString IOSurfacePurgeableKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			get {
				if (_IOSurfacePurgeableKey is null)
					_IOSurfacePurgeableKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferIOSurfacePurgeableKey")!;
				return _IOSurfacePurgeableKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MemoryAllocatorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferMemoryAllocatorKey",  "CoreVideo")]
		public static NSString MemoryAllocatorKey {
			get {
				if (_MemoryAllocatorKey is null)
					_MemoryAllocatorKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferMemoryAllocatorKey")!;
				return _MemoryAllocatorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetalCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferMetalCompatibilityKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MetalCompatibilityKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MetalCompatibilityKey is null)
					_MetalCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferMetalCompatibilityKey")!;
				return _MetalCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferOpenGLCompatibilityKey",  "CoreVideo")]
		public static NSString OpenGLCompatibilityKey {
			get {
				if (_OpenGLCompatibilityKey is null)
					_OpenGLCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferOpenGLCompatibilityKey")!;
				return _OpenGLCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLESCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferOpenGLESCompatibilityKey",  "CoreVideo")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OpenGLESCompatibilityKey {
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OpenGLESCompatibilityKey is null)
					_OpenGLESCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferOpenGLESCompatibilityKey")!;
				return _OpenGLESCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenGLESTextureCacheCompatibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferOpenGLESTextureCacheCompatibilityKey",  "CoreVideo")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OpenGLESTextureCacheCompatibilityKey {
			[UnsupportedOSPlatform ("macos")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OpenGLESTextureCacheCompatibilityKey is null)
					_OpenGLESTextureCacheCompatibilityKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferOpenGLESTextureCacheCompatibilityKey")!;
				return _OpenGLESTextureCacheCompatibilityKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelFormatTypeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferPixelFormatTypeKey",  "CoreVideo")]
		public static NSString PixelFormatTypeKey {
			get {
				if (_PixelFormatTypeKey is null)
					_PixelFormatTypeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferPixelFormatTypeKey")!;
				return _PixelFormatTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneAlignmentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferPlaneAlignmentKey",  "CoreVideo")]
		public static NSString PlaneAlignmentKey {
			get {
				if (_PlaneAlignmentKey is null)
					_PlaneAlignmentKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferPlaneAlignmentKey")!;
				return _PlaneAlignmentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVPixelBufferWidthKey",  "CoreVideo")]
		public static NSString WidthKey {
			get {
				if (_WidthKey is null)
					_WidthKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVPixelBufferWidthKey")!;
				return _WidthKey;
			}
		}
	} /* class CVPixelBuffer */
}
