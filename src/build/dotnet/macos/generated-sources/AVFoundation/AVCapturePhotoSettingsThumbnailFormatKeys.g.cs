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
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class AVCapturePhotoSettingsThumbnailFormatKeys  {
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
	} /* class AVCapturePhotoSettingsThumbnailFormatKeys */
}
