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
namespace MetalKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class MTKTextureLoaderKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllocateMipmapsKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionAllocateMipmaps'.</summary>
		[Field ("MTKTextureLoaderOptionAllocateMipmaps",  "MetalKit")]
		public static NSString AllocateMipmapsKey {
			get {
				if (_AllocateMipmapsKey is null)
					_AllocateMipmapsKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionAllocateMipmaps")!;
				return _AllocateMipmapsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CubeLayoutKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionCubeLayout'.</summary>
		[Field ("MTKTextureLoaderOptionCubeLayout",  "MetalKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString CubeLayoutKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_CubeLayoutKey is null)
					_CubeLayoutKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionCubeLayout")!;
				return _CubeLayoutKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenerateMipmapsKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionGenerateMipmaps'.</summary>
		[Field ("MTKTextureLoaderOptionGenerateMipmaps",  "MetalKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GenerateMipmapsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GenerateMipmapsKey is null)
					_GenerateMipmapsKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionGenerateMipmaps")!;
				return _GenerateMipmapsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LoadAsArrayKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionLoadAsArray'.</summary>
		[Field ("MTKTextureLoaderOptionLoadAsArray",  "MetalKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString LoadAsArrayKey {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_LoadAsArrayKey is null)
					_LoadAsArrayKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionLoadAsArray")!;
				return _LoadAsArrayKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionOrigin'.</summary>
		[Field ("MTKTextureLoaderOptionOrigin",  "MetalKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OriginKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OriginKey is null)
					_OriginKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionOrigin")!;
				return _OriginKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SrgbKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionSRGB'.</summary>
		[Field ("MTKTextureLoaderOptionSRGB",  "MetalKit")]
		public static NSString SrgbKey {
			get {
				if (_SrgbKey is null)
					_SrgbKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionSRGB")!;
				return _SrgbKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextureCpuCacheModeKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionTextureCPUCacheMode'.</summary>
		[Field ("MTKTextureLoaderOptionTextureCPUCacheMode",  "MetalKit")]
		public static NSString TextureCpuCacheModeKey {
			get {
				if (_TextureCpuCacheModeKey is null)
					_TextureCpuCacheModeKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureCPUCacheMode")!;
				return _TextureCpuCacheModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextureStorageModeKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionTextureStorageMode'.</summary>
		[Field ("MTKTextureLoaderOptionTextureStorageMode",  "MetalKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TextureStorageModeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TextureStorageModeKey is null)
					_TextureStorageModeKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureStorageMode")!;
				return _TextureStorageModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextureUsageKey;
		/// <summary>Represents the value associated with the constant 'MTKTextureLoaderOptionTextureUsage'.</summary>
		[Field ("MTKTextureLoaderOptionTextureUsage",  "MetalKit")]
		public static NSString TextureUsageKey {
			get {
				if (_TextureUsageKey is null)
					_TextureUsageKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKTextureLoaderOptionTextureUsage")!;
				return _TextureUsageKey;
			}
		}
	} /* class MTKTextureLoaderKeys */
}
