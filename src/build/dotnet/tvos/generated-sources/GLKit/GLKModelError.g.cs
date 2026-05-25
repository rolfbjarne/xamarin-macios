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
namespace GLKit {
	/// <summary>Defines values whose values represent constant values relating to errors.</summary>
	[ObsoletedOSPlatform ("ios12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'Metal' instead.")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class GLKModelError  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Domain;
		/// <summary>A value corresponding to the constant <c>kGLKModelErrorDomain</c>.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kGLKModelErrorDomain",  "GLKit")]
		public static NSString Domain {
			get {
				if (_Domain is null)
					_Domain = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "kGLKModelErrorDomain")!;
				return _Domain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Key;
		/// <summary>A value corresponding to the constant <c>kGLKModelErrorKey</c>.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kGLKModelErrorKey",  "GLKit")]
		public static NSString Key {
			get {
				if (_Key is null)
					_Key = Dlfcn.GetStringConstant (Libraries.GLKit.Handle, "kGLKModelErrorKey")!;
				return _Key;
			}
		}
	} /* class GLKModelError */
}
