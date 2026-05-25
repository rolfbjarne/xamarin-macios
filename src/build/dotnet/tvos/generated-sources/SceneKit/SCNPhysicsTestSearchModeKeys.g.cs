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
namespace SceneKit {
	/// <summary>Enumerates values that control which collision search results are returned.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class SCNPhysicsTestSearchModeKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _All;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestSearchModeAll</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestSearchModeAll",  "SceneKit")]
		public static NSString All {
			get {
				if (_All is null)
					_All = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeAll")!;
				return _All;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Any;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestSearchModeAny</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestSearchModeAny",  "SceneKit")]
		public static NSString Any {
			get {
				if (_Any is null)
					_Any = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeAny")!;
				return _Any;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Closest;
		/// <summary>Represents the value associated with the constant SCNPhysicsTestSearchModeClosest</summary><value></value><remarks>To be added.</remarks>
		[Field ("SCNPhysicsTestSearchModeClosest",  "SceneKit")]
		public static NSString Closest {
			get {
				if (_Closest is null)
					_Closest = Dlfcn.GetStringConstant (Libraries.SceneKit.Handle, "SCNPhysicsTestSearchModeClosest")!;
				return _Closest;
			}
		}
	} /* class SCNPhysicsTestSearchModeKeys */
}
