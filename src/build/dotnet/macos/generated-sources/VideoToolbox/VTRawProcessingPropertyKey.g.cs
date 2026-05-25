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
namespace VideoToolbox {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos15.0")]
	public unsafe static partial class VTRawProcessingPropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetadataForSidecarFile;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingPropertyKey_MetadataForSidecarFile'.</summary>
		[Field ("kVTRAWProcessingPropertyKey_MetadataForSidecarFile",  "VideoToolbox")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSString MetadataForSidecarFile {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				if (_MetadataForSidecarFile is null)
					_MetadataForSidecarFile = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingPropertyKey_MetadataForSidecarFile")!;
				return _MetadataForSidecarFile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetalDeviceRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingPropertyKey_MetalDeviceRegistryID'.</summary>
		[Field ("kVTRAWProcessingPropertyKey_MetalDeviceRegistryID",  "VideoToolbox")]
		public static NSString MetalDeviceRegistryId {
			get {
				if (_MetalDeviceRegistryId is null)
					_MetalDeviceRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingPropertyKey_MetalDeviceRegistryID")!;
				return _MetalDeviceRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputColorAttachments;
		/// <summary>Represents the value associated with the constant 'kVTRAWProcessingPropertyKey_OutputColorAttachments'.</summary>
		[Field ("kVTRAWProcessingPropertyKey_OutputColorAttachments",  "VideoToolbox")]
		public static NSString OutputColorAttachments {
			get {
				if (_OutputColorAttachments is null)
					_OutputColorAttachments = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTRAWProcessingPropertyKey_OutputColorAttachments")!;
				return _OutputColorAttachments;
			}
		}
	} /* class VTRawProcessingPropertyKey */
}
