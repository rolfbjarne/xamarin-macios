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
namespace ClassKit {
	/// <summary>Contains keys for accessing error data.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class CLSErrorUserInfoKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ObjectKey;
		/// <summary>Gets a key that can be used for finding the object that caused the error.</summary><value>The key that can be used for finding the object that caused the error.</value><remarks>To be added.</remarks>
		[Field ("CLSErrorObjectKey",  "ClassKit")]
		public static NSString ObjectKey {
			get {
				if (_ObjectKey is null)
					_ObjectKey = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSErrorObjectKey")!;
				return _ObjectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SuccessfulObjectsKey;
		/// <summary>Represents the value associated with the constant 'CLSErrorSuccessfulObjectsKey'.</summary>
		[Field ("CLSErrorSuccessfulObjectsKey",  "ClassKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString SuccessfulObjectsKey {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SuccessfulObjectsKey is null)
					_SuccessfulObjectsKey = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSErrorSuccessfulObjectsKey")!;
				return _SuccessfulObjectsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlyingErrorsKey;
		/// <summary>Gets a key that can be used for finding the underlying error that caused the current error.</summary><value>The key that can be used for finding the underlying error that caused the current error.</value><remarks>To be added.</remarks>
		[Field ("CLSErrorUnderlyingErrorsKey",  "ClassKit")]
		public static NSString UnderlyingErrorsKey {
			get {
				if (_UnderlyingErrorsKey is null)
					_UnderlyingErrorsKey = Dlfcn.GetStringConstant (Libraries.ClassKit.Handle, "CLSErrorUnderlyingErrorsKey")!;
				return _UnderlyingErrorsKey;
			}
		}
	} /* class CLSErrorUserInfoKeys */
}
