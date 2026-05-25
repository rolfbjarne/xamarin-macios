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
namespace AVFoundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class AVPixelAspectRatioPropertiesKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioHorizontalSpacingKey;
		/// <summary>Represents the value associated with the constant 'AVVideoPixelAspectRatioHorizontalSpacingKey'.</summary>
		[Field ("AVVideoPixelAspectRatioHorizontalSpacingKey",  "AVFoundation")]
		public static NSString PixelAspectRatioHorizontalSpacingKey {
			get {
				if (_PixelAspectRatioHorizontalSpacingKey is null)
					_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioHorizontalSpacingKey")!;
				return _PixelAspectRatioHorizontalSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioVerticalSpacingKey;
		/// <summary>Represents the value associated with the constant 'AVVideoPixelAspectRatioVerticalSpacingKey'.</summary>
		[Field ("AVVideoPixelAspectRatioVerticalSpacingKey",  "AVFoundation")]
		public static NSString PixelAspectRatioVerticalSpacingKey {
			get {
				if (_PixelAspectRatioVerticalSpacingKey is null)
					_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioVerticalSpacingKey")!;
				return _PixelAspectRatioVerticalSpacingKey;
			}
		}
	} /* class AVPixelAspectRatioPropertiesKeys */
}
