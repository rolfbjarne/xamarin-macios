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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
	public unsafe static partial class IOCameraModelType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericPinhole;
		/// <summary>Represents the value associated with the constant 'kIIOCameraModelType_GenericPinhole'.</summary>
		[Field ("kIIOCameraModelType_GenericPinhole",  "ImageIO")]
		public static NSString GenericPinhole {
			get {
				if (_GenericPinhole is null)
					_GenericPinhole = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraModelType_GenericPinhole")!;
				return _GenericPinhole;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SimplifiedPinhole;
		/// <summary>Represents the value associated with the constant 'kIIOCameraModelType_SimplifiedPinhole'.</summary>
		[Field ("kIIOCameraModelType_SimplifiedPinhole",  "ImageIO")]
		public static NSString SimplifiedPinhole {
			get {
				if (_SimplifiedPinhole is null)
					_SimplifiedPinhole = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOCameraModelType_SimplifiedPinhole")!;
				return _SimplifiedPinhole;
			}
		}
	} /* class IOCameraModelType */
}
