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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class VTVideoEncoderList  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecName;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_CodecName'.</summary>
		[Field ("kVTVideoEncoderList_CodecName",  "VideoToolbox")]
		public static NSString CodecName {
			get {
				if (_CodecName is null)
					_CodecName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_CodecName")!;
				return _CodecName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecType;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_CodecType'.</summary>
		[Field ("kVTVideoEncoderList_CodecType",  "VideoToolbox")]
		public static NSString CodecType {
			get {
				if (_CodecType is null)
					_CodecType = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_CodecType")!;
				return _CodecType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayName;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_DisplayName'.</summary>
		[Field ("kVTVideoEncoderList_DisplayName",  "VideoToolbox")]
		public static NSString DisplayName {
			get {
				if (_DisplayName is null)
					_DisplayName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_DisplayName")!;
				return _DisplayName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderID;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_EncoderID'.</summary>
		[Field ("kVTVideoEncoderList_EncoderID",  "VideoToolbox")]
		public static NSString EncoderID {
			get {
				if (_EncoderID is null)
					_EncoderID = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_EncoderID")!;
				return _EncoderID;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncoderName;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_EncoderName'.</summary>
		[Field ("kVTVideoEncoderList_EncoderName",  "VideoToolbox")]
		public static NSString EncoderName {
			get {
				if (_EncoderName is null)
					_EncoderName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_EncoderName")!;
				return _EncoderName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GpuRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_GPURegistryID'.</summary>
		[Field ("kVTVideoEncoderList_GPURegistryID",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString GpuRegistryId {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GpuRegistryId is null)
					_GpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_GPURegistryID")!;
				return _GpuRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IncludeStandardDefinitionDVEncoders;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderListOption_IncludeStandardDefinitionDVEncoders'.</summary>
		[Field ("kVTVideoEncoderListOption_IncludeStandardDefinitionDVEncoders",  "VideoToolbox")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IncludeStandardDefinitionDVEncoders {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IncludeStandardDefinitionDVEncoders is null)
					_IncludeStandardDefinitionDVEncoders = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderListOption_IncludeStandardDefinitionDVEncoders")!;
				return _IncludeStandardDefinitionDVEncoders;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InstanceLimit;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_InstanceLimit'.</summary>
		[Field ("kVTVideoEncoderList_InstanceLimit",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString InstanceLimit {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_InstanceLimit is null)
					_InstanceLimit = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_InstanceLimit")!;
				return _InstanceLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsHardwareAccelerated;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_IsHardwareAccelerated'.</summary>
		[Field ("kVTVideoEncoderList_IsHardwareAccelerated",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString IsHardwareAccelerated {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_IsHardwareAccelerated is null)
					_IsHardwareAccelerated = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_IsHardwareAccelerated")!;
				return _IsHardwareAccelerated;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PerformanceRating;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_PerformanceRating'.</summary>
		[Field ("kVTVideoEncoderList_PerformanceRating",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PerformanceRating {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PerformanceRating is null)
					_PerformanceRating = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_PerformanceRating")!;
				return _PerformanceRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QualityRating;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_QualityRating'.</summary>
		[Field ("kVTVideoEncoderList_QualityRating",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString QualityRating {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_QualityRating is null)
					_QualityRating = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_QualityRating")!;
				return _QualityRating;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedSelectionProperties;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_SupportedSelectionProperties'.</summary>
		[Field ("kVTVideoEncoderList_SupportedSelectionProperties",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SupportedSelectionProperties {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SupportedSelectionProperties is null)
					_SupportedSelectionProperties = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_SupportedSelectionProperties")!;
				return _SupportedSelectionProperties;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportsFrameReordering;
		/// <summary>Represents the value associated with the constant 'kVTVideoEncoderList_SupportsFrameReordering'.</summary>
		[Field ("kVTVideoEncoderList_SupportsFrameReordering",  "VideoToolbox")]
		[SupportedOSPlatform ("ios14.2")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SupportsFrameReordering {
			[SupportedOSPlatform ("ios14.2")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SupportsFrameReordering is null)
					_SupportsFrameReordering = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTVideoEncoderList_SupportsFrameReordering")!;
				return _SupportsFrameReordering;
			}
		}
	} /* class VTVideoEncoderList */
}
