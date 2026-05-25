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
	internal unsafe static partial class AVCompressionPropertiesKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureKey;
		/// <summary>Represents the value associated with the constant 'AVVideoCleanApertureKey'.</summary>
		[Field ("AVVideoCleanApertureKey",  "AVFoundation")]
		public static NSString CleanApertureKey {
			get {
				if (_CleanApertureKey is null)
					_CleanApertureKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoCleanApertureKey")!;
				return _CleanApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioKey;
		/// <summary>Represents the value associated with the constant 'AVVideoPixelAspectRatioKey'.</summary>
		[Field ("AVVideoPixelAspectRatioKey",  "AVFoundation")]
		public static NSString PixelAspectRatioKey {
			get {
				if (_PixelAspectRatioKey is null)
					_PixelAspectRatioKey = Dlfcn.GetStringConstant (Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioKey")!;
				return _PixelAspectRatioKey;
			}
		}
	} /* class AVCompressionPropertiesKeys */
}
