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
namespace ImageIO {
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe static partial class IOCameraExtrinsics  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoordinateSystemId;
		/// <summary>Represents the value associated with the constant 'kIIOCameraExtrinsics_CoordinateSystemID'.</summary>
		[Field ("kIIOCameraExtrinsics_CoordinateSystemID",  "ImageIO")]
		public static NSString CoordinateSystemId {
			get {
				if (_CoordinateSystemId is null)
					_CoordinateSystemId = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraExtrinsics_CoordinateSystemID")!;
				return _CoordinateSystemId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Position;
		/// <summary>Represents the value associated with the constant 'kIIOCameraExtrinsics_Position'.</summary>
		[Field ("kIIOCameraExtrinsics_Position",  "ImageIO")]
		public static NSString Position {
			get {
				if (_Position is null)
					_Position = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraExtrinsics_Position")!;
				return _Position;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Rotation;
		/// <summary>Represents the value associated with the constant 'kIIOCameraExtrinsics_Rotation'.</summary>
		[Field ("kIIOCameraExtrinsics_Rotation",  "ImageIO")]
		public static NSString Rotation {
			get {
				if (_Rotation is null)
					_Rotation = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraExtrinsics_Rotation")!;
				return _Rotation;
			}
		}
	} /* class IOCameraExtrinsics */
}
