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
namespace MetalKit {
	/// <summary>Static class that contains MetalKit constants related to MetalKit Model errors.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MTKModel  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>Gets the error domain where mesh initialization errors are reported.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MTKModelErrorDomain",  "MetalKit")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKModelErrorDomain")!;
				return _ErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorKey;
		/// <summary>Gets the key that is used to retrieve error information from the <see cref="P:Foundation.NSError.UserInfo" /> property of a MetalKit initialization error.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MTKModelErrorKey",  "MetalKit")]
		public static NSString ErrorKey {
			get {
				if (_ErrorKey is null)
					_ErrorKey = Dlfcn.GetStringConstant (Libraries.MetalKit.Handle, "MTKModelErrorKey")!;
				return _ErrorKey;
			}
		}
	} /* class MTKModel */
}
