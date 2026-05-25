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
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class IOMonoscopicImageLocation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Center;
		/// <summary>Represents the value associated with the constant 'kIIOMonoscopicImageLocation_Center'.</summary>
		[Field ("kIIOMonoscopicImageLocation_Center",  "ImageIO")]
		public static NSString Center {
			get {
				if (_Center is null)
					_Center = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMonoscopicImageLocation_Center")!;
				return _Center;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Left;
		/// <summary>Represents the value associated with the constant 'kIIOMonoscopicImageLocation_Left'.</summary>
		[Field ("kIIOMonoscopicImageLocation_Left",  "ImageIO")]
		public static NSString Left {
			get {
				if (_Left is null)
					_Left = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMonoscopicImageLocation_Left")!;
				return _Left;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Right;
		/// <summary>Represents the value associated with the constant 'kIIOMonoscopicImageLocation_Right'.</summary>
		[Field ("kIIOMonoscopicImageLocation_Right",  "ImageIO")]
		public static NSString Right {
			get {
				if (_Right is null)
					_Right = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMonoscopicImageLocation_Right")!;
				return _Right;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Unspecified;
		/// <summary>Represents the value associated with the constant 'kIIOMonoscopicImageLocation_Unspecified'.</summary>
		[Field ("kIIOMonoscopicImageLocation_Unspecified",  "ImageIO")]
		public static NSString Unspecified {
			get {
				if (_Unspecified is null)
					_Unspecified = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOMonoscopicImageLocation_Unspecified")!;
				return _Unspecified;
			}
		}
	} /* class IOMonoscopicImageLocation */
}
