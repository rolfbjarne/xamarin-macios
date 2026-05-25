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
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	internal unsafe static partial class CGImageAnimationOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DelayTimeKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAnimationDelayTime'.</summary>
		[Field ("kCGImageAnimationDelayTime",  "ImageIO")]
		public static NSString DelayTimeKey {
			get {
				if (_DelayTimeKey is null)
					_DelayTimeKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAnimationDelayTime")!;
				return _DelayTimeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LoopCountKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAnimationLoopCount'.</summary>
		[Field ("kCGImageAnimationLoopCount",  "ImageIO")]
		public static NSString LoopCountKey {
			get {
				if (_LoopCountKey is null)
					_LoopCountKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAnimationLoopCount")!;
				return _LoopCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StartIndexKey;
		/// <summary>Represents the value associated with the constant 'kCGImageAnimationStartIndex'.</summary>
		[Field ("kCGImageAnimationStartIndex",  "ImageIO")]
		public static NSString StartIndexKey {
			get {
				if (_StartIndexKey is null)
					_StartIndexKey = Dlfcn.GetStringConstant (Libraries.ImageIO.Handle, "kCGImageAnimationStartIndex")!;
				return _StartIndexKey;
			}
		}
	} /* class CGImageAnimationOptionsKeys */
}
