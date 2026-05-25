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
namespace CoreAnimation {
	/// <summary>Constants used for the FillMode property in CAAnimation and CALayer, used to control the behavior of objects once the animation has completed.</summary><remarks>These are used in the FillMode property of CAAnimation and CALayer.</remarks>
	public unsafe static partial class CAFillMode  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Backwards;
		/// <summary>Represents the value associated with the constant kCAFillModeBackwards</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFillModeBackwards",  "CoreAnimation")]
		public static NSString Backwards {
			get {
				if (_Backwards is null)
					_Backwards = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFillModeBackwards")!;
				return _Backwards;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Both;
		/// <summary>Represents the value associated with the constant kCAFillModeBoth</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFillModeBoth",  "CoreAnimation")]
		public static NSString Both {
			get {
				if (_Both is null)
					_Both = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFillModeBoth")!;
				return _Both;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Forwards;
		/// <summary>Represents the value associated with the constant kCAFillModeForwards</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFillModeForwards",  "CoreAnimation")]
		public static NSString Forwards {
			get {
				if (_Forwards is null)
					_Forwards = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFillModeForwards")!;
				return _Forwards;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Removed;
		/// <summary>Represents the value associated with the constant kCAFillModeRemoved</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFillModeRemoved",  "CoreAnimation")]
		public static NSString Removed {
			get {
				if (_Removed is null)
					_Removed = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFillModeRemoved")!;
				return _Removed;
			}
		}
	} /* class CAFillMode */
}
