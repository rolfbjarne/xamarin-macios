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
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTVideoDecoderSpecification" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTVideoDecoderSpecificationKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableHardwareAcceleratedVideoDecoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoDecoderSpecification_EnableHardwareAcceleratedVideoDecoder",  "VideoToolbox")]
		public static NSString EnableHardwareAcceleratedVideoDecoder {
			get {
				if (_EnableHardwareAcceleratedVideoDecoder is null)
					_EnableHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_EnableHardwareAcceleratedVideoDecoder")!;
				return _EnableHardwareAcceleratedVideoDecoder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredDecoderGpuRegistryId;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoDecoderSpecification_PreferredDecoderGPURegistryID",  "VideoToolbox")]
		public static NSString PreferredDecoderGpuRegistryId {
			get {
				if (_PreferredDecoderGpuRegistryId is null)
					_PreferredDecoderGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_PreferredDecoderGPURegistryID")!;
				return _PreferredDecoderGpuRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequireHardwareAcceleratedVideoDecoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoDecoderSpecification_RequireHardwareAcceleratedVideoDecoder",  "VideoToolbox")]
		public static NSString RequireHardwareAcceleratedVideoDecoder {
			get {
				if (_RequireHardwareAcceleratedVideoDecoder is null)
					_RequireHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_RequireHardwareAcceleratedVideoDecoder")!;
				return _RequireHardwareAcceleratedVideoDecoder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequiredDecoderGpuRegistryId;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoDecoderSpecification_RequiredDecoderGPURegistryID",  "VideoToolbox")]
		public static NSString RequiredDecoderGpuRegistryId {
			get {
				if (_RequiredDecoderGpuRegistryId is null)
					_RequiredDecoderGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoDecoderSpecification_RequiredDecoderGPURegistryID")!;
				return _RequiredDecoderGpuRegistryId;
			}
		}
	} /* class VTVideoDecoderSpecificationKeys */
}
