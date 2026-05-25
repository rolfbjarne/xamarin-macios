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
namespace IOSurface {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class IOSurfacePropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BytesPerElementKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyBytesPerElement'.</summary>
		[Field ("IOSurfacePropertyKeyBytesPerElement",  "IOSurface")]
		public static NSString BytesPerElementKey {
			get {
				if (_BytesPerElementKey is null)
					_BytesPerElementKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyBytesPerElement")!;
				return _BytesPerElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BytesPerRowKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyBytesPerRow'.</summary>
		[Field ("IOSurfacePropertyKeyBytesPerRow",  "IOSurface")]
		public static NSString BytesPerRowKey {
			get {
				if (_BytesPerRowKey is null)
					_BytesPerRowKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyBytesPerRow")!;
				return _BytesPerRowKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CacheModeKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyCacheMode'.</summary>
		[Field ("IOSurfacePropertyKeyCacheMode",  "IOSurface")]
		public static NSString CacheModeKey {
			get {
				if (_CacheModeKey is null)
					_CacheModeKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyCacheMode")!;
				return _CacheModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElementHeightKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyElementHeight'.</summary>
		[Field ("IOSurfacePropertyKeyElementHeight",  "IOSurface")]
		public static NSString ElementHeightKey {
			get {
				if (_ElementHeightKey is null)
					_ElementHeightKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyElementHeight")!;
				return _ElementHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ElementWidthKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyElementWidth'.</summary>
		[Field ("IOSurfacePropertyKeyElementWidth",  "IOSurface")]
		public static NSString ElementWidthKey {
			get {
				if (_ElementWidthKey is null)
					_ElementWidthKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyElementWidth")!;
				return _ElementWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeightKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyHeight'.</summary>
		[Field ("IOSurfacePropertyKeyHeight",  "IOSurface")]
		public static NSString HeightKey {
			get {
				if (_HeightKey is null)
					_HeightKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyHeight")!;
				return _HeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyName'.</summary>
		[Field ("IOSurfacePropertyKeyName",  "IOSurface")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString NameKey {
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_NameKey is null)
					_NameKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyName")!;
				return _NameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OffsetKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyOffset'.</summary>
		[Field ("IOSurfacePropertyKeyOffset",  "IOSurface")]
		public static NSString OffsetKey {
			get {
				if (_OffsetKey is null)
					_OffsetKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyOffset")!;
				return _OffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelFormatKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPixelFormat'.</summary>
		[Field ("IOSurfacePropertyKeyPixelFormat",  "IOSurface")]
		public static NSString PixelFormatKey {
			get {
				if (_PixelFormatKey is null)
					_PixelFormatKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPixelFormat")!;
				return _PixelFormatKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelSizeCastingAllowedKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPixelSizeCastingAllowed'.</summary>
		[Field ("IOSurfacePropertyKeyPixelSizeCastingAllowed",  "IOSurface")]
		public static NSString PixelSizeCastingAllowedKey {
			get {
				if (_PixelSizeCastingAllowedKey is null)
					_PixelSizeCastingAllowedKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPixelSizeCastingAllowed")!;
				return _PixelSizeCastingAllowedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneBaseKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneBase'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneBase",  "IOSurface")]
		public static NSString PlaneBaseKey {
			get {
				if (_PlaneBaseKey is null)
					_PlaneBaseKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBase")!;
				return _PlaneBaseKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneBytesPerElementKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneBytesPerElement'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneBytesPerElement",  "IOSurface")]
		public static NSString PlaneBytesPerElementKey {
			get {
				if (_PlaneBytesPerElementKey is null)
					_PlaneBytesPerElementKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBytesPerElement")!;
				return _PlaneBytesPerElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneBytesPerRowKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneBytesPerRow'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneBytesPerRow",  "IOSurface")]
		public static NSString PlaneBytesPerRowKey {
			get {
				if (_PlaneBytesPerRowKey is null)
					_PlaneBytesPerRowKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBytesPerRow")!;
				return _PlaneBytesPerRowKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneElementHeightKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneElementHeight'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneElementHeight",  "IOSurface")]
		public static NSString PlaneElementHeightKey {
			get {
				if (_PlaneElementHeightKey is null)
					_PlaneElementHeightKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneElementHeight")!;
				return _PlaneElementHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneElementWidthKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneElementWidth'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneElementWidth",  "IOSurface")]
		public static NSString PlaneElementWidthKey {
			get {
				if (_PlaneElementWidthKey is null)
					_PlaneElementWidthKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneElementWidth")!;
				return _PlaneElementWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneHeightKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneHeight'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneHeight",  "IOSurface")]
		public static NSString PlaneHeightKey {
			get {
				if (_PlaneHeightKey is null)
					_PlaneHeightKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneHeight")!;
				return _PlaneHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneInfoKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneInfo'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneInfo",  "IOSurface")]
		public static NSString PlaneInfoKey {
			get {
				if (_PlaneInfoKey is null)
					_PlaneInfoKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneInfo")!;
				return _PlaneInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneOffsetKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneOffset'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneOffset",  "IOSurface")]
		public static NSString PlaneOffsetKey {
			get {
				if (_PlaneOffsetKey is null)
					_PlaneOffsetKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneOffset")!;
				return _PlaneOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneSizeKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneSize'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneSize",  "IOSurface")]
		public static NSString PlaneSizeKey {
			get {
				if (_PlaneSizeKey is null)
					_PlaneSizeKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneSize")!;
				return _PlaneSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaneWidthKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyPlaneWidth'.</summary>
		[Field ("IOSurfacePropertyKeyPlaneWidth",  "IOSurface")]
		public static NSString PlaneWidthKey {
			get {
				if (_PlaneWidthKey is null)
					_PlaneWidthKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneWidth")!;
				return _PlaneWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyWidth'.</summary>
		[Field ("IOSurfacePropertyKeyWidth",  "IOSurface")]
		public static NSString WidthKey {
			get {
				if (_WidthKey is null)
					_WidthKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyWidth")!;
				return _WidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __DeprecatedAllocSizeKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyAllocSizeKey'.</summary>
		[Field ("IOSurfacePropertyAllocSizeKey",  "IOSurface")]
		internal static NSString _DeprecatedAllocSizeKey {
			get {
				if (__DeprecatedAllocSizeKey is null)
					__DeprecatedAllocSizeKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyAllocSizeKey")!;
				return __DeprecatedAllocSizeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __NewAllocSizeKey;
		/// <summary>Represents the value associated with the constant 'IOSurfacePropertyKeyAllocSize'.</summary>
		[Field ("IOSurfacePropertyKeyAllocSize",  "IOSurface")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString _NewAllocSizeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (__NewAllocSizeKey is null)
					__NewAllocSizeKey = Dlfcn.GetStringConstant (Libraries.IOSurface.Handle, "IOSurfacePropertyKeyAllocSize")!;
				return __NewAllocSizeKey;
			}
		}
	} /* class IOSurfacePropertyKey */
}
