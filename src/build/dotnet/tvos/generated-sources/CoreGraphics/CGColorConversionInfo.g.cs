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
namespace CoreGraphics {
	public unsafe partial class CGColorConversionInfo  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BlackPointCompensationKey;
		/// <summary>Represents the value associated with the constant 'kCGColorConversionBlackPointCompensation'.</summary>
		[Field ("kCGColorConversionBlackPointCompensation",  "CoreGraphics")]
		internal static NSString BlackPointCompensationKey {
			get {
				if (_BlackPointCompensationKey is null)
					_BlackPointCompensationKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorConversionBlackPointCompensation")!;
				return _BlackPointCompensationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TrcSizeKey;
		/// <summary>Represents the value associated with the constant 'kCGColorConversionTRCSize'.</summary>
		[Field ("kCGColorConversionTRCSize",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString TrcSizeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TrcSizeKey is null)
					_TrcSizeKey = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorConversionTRCSize")!;
				return _TrcSizeKey;
			}
		}
	} /* class CGColorConversionInfo */
}
