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
namespace AVFoundation {
	[SupportedOSPlatform ("ios18.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class AVCaptionSettingsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaSubTypeKey;
		/// <summary>Represents the value associated with the constant 'AVCaptionMediaSubTypeKey'.</summary>
		[Field ("AVCaptionMediaSubTypeKey",  "AVFoundation")]
		public static NSString MediaSubTypeKey {
			get {
				if (_MediaSubTypeKey is null)
					_MediaSubTypeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptionMediaSubTypeKey")!;
				return _MediaSubTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MediaTypeKey;
		/// <summary>Represents the value associated with the constant 'AVCaptionMediaTypeKey'.</summary>
		[Field ("AVCaptionMediaTypeKey",  "AVFoundation")]
		public static NSString MediaTypeKey {
			get {
				if (_MediaTypeKey is null)
					_MediaTypeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptionMediaTypeKey")!;
				return _MediaTypeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseDropFrameTimeCodeKey;
		/// <summary>Represents the value associated with the constant 'AVCaptionUseDropFrameTimeCodeKey'.</summary>
		[Field ("AVCaptionUseDropFrameTimeCodeKey",  "AVFoundation")]
		public static NSString UseDropFrameTimeCodeKey {
			get {
				if (_UseDropFrameTimeCodeKey is null)
					_UseDropFrameTimeCodeKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptionUseDropFrameTimeCodeKey")!;
				return _UseDropFrameTimeCodeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UseTimeCodeFrameDurationKey;
		/// <summary>Represents the value associated with the constant 'AVCaptionTimeCodeFrameDurationKey'.</summary>
		[Field ("AVCaptionTimeCodeFrameDurationKey",  "AVFoundation")]
		public static NSString UseTimeCodeFrameDurationKey {
			get {
				if (_UseTimeCodeFrameDurationKey is null)
					_UseTimeCodeFrameDurationKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVCaptionTimeCodeFrameDurationKey")!;
				return _UseTimeCodeFrameDurationKey;
			}
		}
	} /* class AVCaptionSettingsKeys */
}
