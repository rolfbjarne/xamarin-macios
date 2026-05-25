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
namespace Vision {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class VNImageOptionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CIContextKey;
		/// <summary>Represents the value associated with the constant 'VNImageOptionCIContext'.</summary>
		[Field ("VNImageOptionCIContext",  "Vision")]
		public static NSString CIContextKey {
			get {
				if (_CIContextKey is null)
					_CIContextKey = Dlfcn.GetStringConstant (Libraries.Vision.Handle, "VNImageOptionCIContext")!;
				return _CIContextKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraIntrinsicsKey;
		/// <summary>Represents the value associated with the constant 'VNImageOptionCameraIntrinsics'.</summary>
		[Field ("VNImageOptionCameraIntrinsics",  "Vision")]
		public static NSString CameraIntrinsicsKey {
			get {
				if (_CameraIntrinsicsKey is null)
					_CameraIntrinsicsKey = Dlfcn.GetStringConstant (Libraries.Vision.Handle, "VNImageOptionCameraIntrinsics")!;
				return _CameraIntrinsicsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropertiesKey;
		/// <summary>Represents the value associated with the constant 'VNImageOptionProperties'.</summary>
		[Field ("VNImageOptionProperties",  "Vision")]
		public static NSString PropertiesKey {
			get {
				if (_PropertiesKey is null)
					_PropertiesKey = Dlfcn.GetStringConstant (Libraries.Vision.Handle, "VNImageOptionProperties")!;
				return _PropertiesKey;
			}
		}
	} /* class VNImageOptionKeys */
}
