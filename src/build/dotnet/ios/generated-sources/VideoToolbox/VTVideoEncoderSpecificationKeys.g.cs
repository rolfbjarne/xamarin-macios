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
	/// <summary>A class that encapsulates keys necessary by <see cref="T:VideoToolbox.VTVideoEncoderSpecification" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTVideoEncoderSpecificationKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableHardwareAcceleratedVideoEncoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoEncoderSpecification_EnableHardwareAcceleratedVideoEncoder",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("macos")]
		public static NSString EnableHardwareAcceleratedVideoEncoder {
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_EnableHardwareAcceleratedVideoEncoder is null)
					_EnableHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_EnableHardwareAcceleratedVideoEncoder")!;
				return _EnableHardwareAcceleratedVideoEncoder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderID;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoEncoderSpecification_EncoderID",  "VideoToolbox")]
		public static NSString EncoderID {
			get {
				if (_EncoderID is null)
					_EncoderID = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_EncoderID")!;
				return _EncoderID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredEncoderGpuRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID'.</summary>
		[Field ("kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PreferredEncoderGpuRegistryId {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PreferredEncoderGpuRegistryId is null)
					_PreferredEncoderGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_PreferredEncoderGPURegistryID")!;
				return _PreferredEncoderGpuRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequireHardwareAcceleratedVideoEncoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTVideoEncoderSpecification_RequireHardwareAcceleratedVideoEncoder",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("macos")]
		public static NSString RequireHardwareAcceleratedVideoEncoder {
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RequireHardwareAcceleratedVideoEncoder is null)
					_RequireHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_RequireHardwareAcceleratedVideoEncoder")!;
				return _RequireHardwareAcceleratedVideoEncoder;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RequiredEncoderGpuRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID'.</summary>
		[Field ("kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RequiredEncoderGpuRegistryId {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RequiredEncoderGpuRegistryId is null)
					_RequiredEncoderGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderSpecification_RequiredEncoderGPURegistryID")!;
				return _RequiredEncoderGpuRegistryId;
			}
		}
	} /* class VTVideoEncoderSpecificationKeys */
}
