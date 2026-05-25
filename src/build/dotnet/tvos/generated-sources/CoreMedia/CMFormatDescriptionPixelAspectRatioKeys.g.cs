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
namespace CoreMedia {
	public unsafe static partial class CMFormatDescriptionPixelAspectRatioKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalSpacing;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionKey_PixelAspectRatioHorizontalSpacing'.</summary>
		[Field ("kCMFormatDescriptionKey_PixelAspectRatioHorizontalSpacing",  "CoreMedia")]
		public static NSString HorizontalSpacing {
			get {
				if (_HorizontalSpacing is null)
					_HorizontalSpacing = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionKey_PixelAspectRatioHorizontalSpacing")!;
				return _HorizontalSpacing;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerticalSpacing;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionKey_PixelAspectRatioVerticalSpacing'.</summary>
		[Field ("kCMFormatDescriptionKey_PixelAspectRatioVerticalSpacing",  "CoreMedia")]
		public static NSString VerticalSpacing {
			get {
				if (_VerticalSpacing is null)
					_VerticalSpacing = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionKey_PixelAspectRatioVerticalSpacing")!;
				return _VerticalSpacing;
			}
		}
	} /* class CMFormatDescriptionPixelAspectRatioKeys */
}
