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
namespace Photos {
	/// <summary>Defines keys for the <c>info</c> dictionary passed to the result handler in <see cref="M:Photos.PHLivePhoto.RequestLivePhoto(Foundation.NSUrl[],AppKit.NSImage,CoreGraphics.CGSize,Photos.PHImageContentMode,System.Action{Photos.PHLivePhoto,Foundation.NSDictionary})" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class PHLivePhotoInfo  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CancelledKey;
		/// <summary>Key for a Boolean that tells whether the request was cancelled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PHLivePhotoInfoCancelledKey",  "Photos")]
		public static NSString CancelledKey {
			get {
				if (_CancelledKey is null)
					_CancelledKey = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLivePhotoInfoCancelledKey")!;
				return _CancelledKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorKey;
		/// <summary>Key for the error message.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PHLivePhotoInfoErrorKey",  "Photos")]
		public static NSString ErrorKey {
			get {
				if (_ErrorKey is null)
					_ErrorKey = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLivePhotoInfoErrorKey")!;
				return _ErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IsDegradedKey;
		/// <summary>Key for a Boolean value that tells whether the returned resource is of a lower quality than the requested resource.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("PHLivePhotoInfoIsDegradedKey",  "Photos")]
		public static NSString IsDegradedKey {
			get {
				if (_IsDegradedKey is null)
					_IsDegradedKey = Dlfcn.GetStringConstant (Libraries.Photos.Handle, "PHLivePhotoInfoIsDegradedKey")!;
				return _IsDegradedKey;
			}
		}
	} /* class PHLivePhotoInfo */
}
