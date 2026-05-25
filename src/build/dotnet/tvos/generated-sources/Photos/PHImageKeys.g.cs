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
namespace Photos {
	/// <summary>Constants indicating results of image loading. Used with <see cref="M:Photos.PHImageManager.RequestImageForAsset(Photos.PHAsset,CoreGraphics.CGSize,Photos.PHImageContentMode,Photos.PHImageRequestOptions,Photos.PHImageResultHandler)" />, defines the keys and values passed to the <see cref="T:Photos.PHImageResultHandler" /> .</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class PHImageKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Cancelled;
		/// <summary>Represents the value associated with the constant PHImageCancelledKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PHImageCancelledKey",  "Photos")]
		public static NSString Cancelled {
			get {
				if (_Cancelled is null)
					_Cancelled = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHImageCancelledKey")!;
				return _Cancelled;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Error;
		/// <summary>Represents the value associated with the constant PHImageErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PHImageErrorKey",  "Photos")]
		public static NSString Error {
			get {
				if (_Error is null)
					_Error = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHImageErrorKey")!;
				return _Error;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultIsDegraded;
		/// <summary>Represents the value associated with the constant PHImageResultIsDegradedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PHImageResultIsDegradedKey",  "Photos")]
		public static NSString ResultIsDegraded {
			get {
				if (_ResultIsDegraded is null)
					_ResultIsDegraded = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHImageResultIsDegradedKey")!;
				return _ResultIsDegraded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultIsInCloud;
		/// <summary>Represents the value associated with the constant PHImageResultIsInCloudKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PHImageResultIsInCloudKey",  "Photos")]
		public static NSString ResultIsInCloud {
			get {
				if (_ResultIsInCloud is null)
					_ResultIsInCloud = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHImageResultIsInCloudKey")!;
				return _ResultIsInCloud;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResultRequestID;
		/// <summary>Represents the value associated with the constant PHImageResultRequestIDKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("PHImageResultRequestIDKey",  "Photos")]
		public static NSString ResultRequestID {
			get {
				if (_ResultRequestID is null)
					_ResultRequestID = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHImageResultRequestIDKey")!;
				return _ResultRequestID;
			}
		}
	} /* class PHImageKeys */
}
