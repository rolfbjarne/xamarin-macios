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
namespace ImageIO {
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe static partial class IOCameraModel  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Intrinsics;
		/// <summary>Represents the value associated with the constant 'kIIOCameraModel_Intrinsics'.</summary>
		[Field ("kIIOCameraModel_Intrinsics",  "ImageIO")]
		public static NSString Intrinsics {
			get {
				if (_Intrinsics is null)
					_Intrinsics = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraModel_Intrinsics")!;
				return _Intrinsics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModelType;
		/// <summary>Represents the value associated with the constant 'kIIOCameraModel_ModelType'.</summary>
		[Field ("kIIOCameraModel_ModelType",  "ImageIO")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public static NSString ModelType {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			get {
				if (_ModelType is null)
					_ModelType = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraModel_ModelType")!;
				return _ModelType;
			}
		}
	} /* class IOCameraModel */
}
