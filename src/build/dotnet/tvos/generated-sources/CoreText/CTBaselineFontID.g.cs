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
namespace CoreText {
	internal unsafe partial class CTBaselineFontID  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Original;
		/// <summary>Represents the value associated with the constant 'kCTBaselineOriginalFont'.</summary>
		[Field ("kCTBaselineOriginalFont",  "CoreText")]
		public static NSString Original {
			get {
				if (_Original is null)
					_Original = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineOriginalFont")!;
				return _Original;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Reference;
		/// <summary>Represents the value associated with the constant 'kCTBaselineReferenceFont'.</summary>
		[Field ("kCTBaselineReferenceFont",  "CoreText")]
		public static NSString Reference {
			get {
				if (_Reference is null)
					_Reference = Dlfcn.GetStringConstant (Libraries.CoreText.Handle, "kCTBaselineReferenceFont")!;
				return _Reference;
			}
		}
	} /* class CTBaselineFontID */
}
