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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class AVPlayerItemVideoOutputSettingsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowWideColorKey;
		/// <summary>Represents the value associated with the constant 'AVVideoAllowWideColorKey'.</summary>
		[Field ("AVVideoAllowWideColorKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AllowWideColorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AllowWideColorKey is null)
					_AllowWideColorKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoAllowWideColorKey")!;
				return _AllowWideColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CodecKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCodecKey'.</summary>
		[Field ("AVVideoCodecKey",  "AVFoundation")]
		public static NSString CodecKey {
			get {
				if (_CodecKey is null)
					_CodecKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCodecKey")!;
				return _CodecKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorPropertiesKey;
		/// <summary>Represents the value associated with the constant 'AVVideoColorPropertiesKey'.</summary>
		[Field ("AVVideoColorPropertiesKey",  "AVFoundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ColorPropertiesKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ColorPropertiesKey is null)
					_ColorPropertiesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoColorPropertiesKey")!;
				return _ColorPropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CompressionPropertiesKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCompressionPropertiesKey'.</summary>
		[Field ("AVVideoCompressionPropertiesKey",  "AVFoundation")]
		public static NSString CompressionPropertiesKey {
			get {
				if (_CompressionPropertiesKey is null)
					_CompressionPropertiesKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCompressionPropertiesKey")!;
				return _CompressionPropertiesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeightKey;
		/// <summary>Represents the value associated with the constant 'AVVideoHeightKey'.</summary>
		[Field ("AVVideoHeightKey",  "AVFoundation")]
		public static NSString HeightKey {
			get {
				if (_HeightKey is null)
					_HeightKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoHeightKey")!;
				return _HeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ScalingModeKey;
		/// <summary>Represents the value associated with the constant 'AVVideoScalingModeKey'.</summary>
		[Field ("AVVideoScalingModeKey",  "AVFoundation")]
		public static NSString ScalingModeKey {
			get {
				if (_ScalingModeKey is null)
					_ScalingModeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoScalingModeKey")!;
				return _ScalingModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthKey;
		/// <summary>Represents the value associated with the constant 'AVVideoWidthKey'.</summary>
		[Field ("AVVideoWidthKey",  "AVFoundation")]
		public static NSString WidthKey {
			get {
				if (_WidthKey is null)
					_WidthKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoWidthKey")!;
				return _WidthKey;
			}
		}
	} /* class AVPlayerItemVideoOutputSettingsKeys */
}
