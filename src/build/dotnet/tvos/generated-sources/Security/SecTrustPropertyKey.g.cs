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
namespace Security {
	/// <summary>Contains keys that index certificate data by type.</summary><remarks>To be added.</remarks>
	public unsafe static partial class SecTrustPropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Error;
		/// <summary>Represents the value associated with the constant kSecPropertyTypeError</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPropertyTypeError",  "Security")]
		public static NSString Error {
			get {
				if (_Error is null)
					_Error = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPropertyTypeError")!;
				return _Error;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Title;
		/// <summary>Represents the value associated with the constant kSecPropertyTypeTitle</summary><value></value><remarks>To be added.</remarks>
		[Field ("kSecPropertyTypeTitle",  "Security")]
		public static NSString Title {
			get {
				if (_Title is null)
					_Title = Dlfcn.GetStringConstant (Libraries.Security.Handle, "kSecPropertyTypeTitle")!;
				return _Title;
			}
		}
	} /* class SecTrustPropertyKey */
}
