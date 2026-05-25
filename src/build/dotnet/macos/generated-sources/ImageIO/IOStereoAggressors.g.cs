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
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class IOStereoAggressors  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Severity;
		/// <summary>Represents the value associated with the constant 'kIIOStereoAggressors_Severity'.</summary>
		[Field ("kIIOStereoAggressors_Severity",  "ImageIO")]
		public static NSString Severity {
			get {
				if (_Severity is null)
					_Severity = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOStereoAggressors_Severity")!;
				return _Severity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SubTypeUri;
		/// <summary>Represents the value associated with the constant 'kIIOStereoAggressors_SubTypeURI'.</summary>
		[Field ("kIIOStereoAggressors_SubTypeURI",  "ImageIO")]
		public static NSString SubTypeUri {
			get {
				if (_SubTypeUri is null)
					_SubTypeUri = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOStereoAggressors_SubTypeURI")!;
				return _SubTypeUri;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>Represents the value associated with the constant 'kIIOStereoAggressors_Type'.</summary>
		[Field ("kIIOStereoAggressors_Type",  "ImageIO")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kIIOStereoAggressors_Type")!;
				return _Type;
			}
		}
	} /* class IOStereoAggressors */
}
