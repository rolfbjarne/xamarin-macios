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
	public unsafe static partial class VTExtensionPropertiesKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecName;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_CodecNameKey'.</summary>
		[Field ("kVTExtensionProperties_CodecNameKey",  "VideoToolbox")]
		public static NSString CodecName {
			get {
				if (_CodecName is null)
					_CodecName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_CodecNameKey")!;
				return _CodecName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainingBundleName;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_ContainingBundleNameKey'.</summary>
		[Field ("kVTExtensionProperties_ContainingBundleNameKey",  "VideoToolbox")]
		public static NSString ContainingBundleName {
			get {
				if (_ContainingBundleName is null)
					_ContainingBundleName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_ContainingBundleNameKey")!;
				return _ContainingBundleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainingBundleUrl;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_ContainingBundleURLKey'.</summary>
		[Field ("kVTExtensionProperties_ContainingBundleURLKey",  "VideoToolbox")]
		public static NSString ContainingBundleUrl {
			get {
				if (_ContainingBundleUrl is null)
					_ContainingBundleUrl = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_ContainingBundleURLKey")!;
				return _ContainingBundleUrl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtensionIdentifier;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_ExtensionIdentifierKey'.</summary>
		[Field ("kVTExtensionProperties_ExtensionIdentifierKey",  "VideoToolbox")]
		public static NSString ExtensionIdentifier {
			get {
				if (_ExtensionIdentifier is null)
					_ExtensionIdentifier = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_ExtensionIdentifierKey")!;
				return _ExtensionIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtensionName;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_ExtensionNameKey'.</summary>
		[Field ("kVTExtensionProperties_ExtensionNameKey",  "VideoToolbox")]
		public static NSString ExtensionName {
			get {
				if (_ExtensionName is null)
					_ExtensionName = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_ExtensionNameKey")!;
				return _ExtensionName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtensionUrl;
		/// <summary>Represents the value associated with the constant 'kVTExtensionProperties_ExtensionURLKey'.</summary>
		[Field ("kVTExtensionProperties_ExtensionURLKey",  "VideoToolbox")]
		public static NSString ExtensionUrl {
			get {
				if (_ExtensionUrl is null)
					_ExtensionUrl = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTExtensionProperties_ExtensionURLKey")!;
				return _ExtensionUrl;
			}
		}
	} /* class VTExtensionPropertiesKey */
}
