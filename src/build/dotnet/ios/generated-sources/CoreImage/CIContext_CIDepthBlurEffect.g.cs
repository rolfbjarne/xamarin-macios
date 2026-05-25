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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreImage {
	public unsafe static partial class CIContext_CIDepthBlurEffect  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIContext");
		/// <param name="This">The instance on which this method operates.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("depthBlurEffectFilterForImageURL:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetDepthBlurEffectFilter (this CIContext This, NSUrl url, NSDictionary? options)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthBlurEffectFilterForImageURL:options:"), url__handle__, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="data">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("depthBlurEffectFilterForImageData:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetDepthBlurEffectFilter (this CIContext This, NSData data, NSDictionary? options)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("depthBlurEffectFilterForImageData:options:"), data__handle__, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="image">To be added.</param><param name="disparityImage">To be added.</param><param name="portraitEffectsMatte">To be added.</param><param name="orientation">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:orientation:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetDepthBlurEffectFilter (this CIContext This, CIImage image, CIImage disparityImage, CIImage? portraitEffectsMatte, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary? options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var disparityImage__handle__ = disparityImage!.GetNonNullHandle (nameof (disparityImage));
			var portraitEffectsMatte__handle__ = portraitEffectsMatte.GetHandle ();
			var options__handle__ = options.GetHandle ();
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_int_NativeHandle (This.Handle, Selector.GetHandle ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:orientation:options:"), image__handle__, disparityImage__handle__, portraitEffectsMatte__handle__, (int)orientation, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (disparityImage);
			GC.KeepAlive (portraitEffectsMatte);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:orientation:options:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetDepthBlurEffectFilter (this CIContext This, CIImage image, CIImage disparityImage, CIImage? portraitEffectsMatte, CIImage? hairSemanticSegmentation, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary? options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var disparityImage__handle__ = disparityImage!.GetNonNullHandle (nameof (disparityImage));
			var portraitEffectsMatte__handle__ = portraitEffectsMatte.GetHandle ();
			var hairSemanticSegmentation__handle__ = hairSemanticSegmentation.GetHandle ();
			var options__handle__ = options.GetHandle ();
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_int_NativeHandle (This.Handle, Selector.GetHandle ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:orientation:options:"), image__handle__, disparityImage__handle__, portraitEffectsMatte__handle__, hairSemanticSegmentation__handle__, (int)orientation, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (disparityImage);
			GC.KeepAlive (portraitEffectsMatte);
			GC.KeepAlive (hairSemanticSegmentation);
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:glassesMatte:gainMap:orientation:options:")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilter? GetDepthBlurEffectFilter (this CIContext This, CIImage image, CIImage disparityImage, CIImage? portraitEffectsMatte, CIImage? hairSemanticSegmentation, CIImage? glassesMatte, CIImage? gainMap, global::ImageIO.CGImagePropertyOrientation orientation, NSDictionary? options)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var disparityImage__handle__ = disparityImage!.GetNonNullHandle (nameof (disparityImage));
			var portraitEffectsMatte__handle__ = portraitEffectsMatte.GetHandle ();
			var hairSemanticSegmentation__handle__ = hairSemanticSegmentation.GetHandle ();
			var glassesMatte__handle__ = glassesMatte.GetHandle ();
			var gainMap__handle__ = gainMap.GetHandle ();
			var options__handle__ = options.GetHandle ();
			CIFilter? ret;
			ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_int_NativeHandle (This.Handle, Selector.GetHandle ("depthBlurEffectFilterForImage:disparityImage:portraitEffectsMatte:hairSemanticSegmentation:glassesMatte:gainMap:orientation:options:"), image__handle__, disparityImage__handle__, portraitEffectsMatte__handle__, hairSemanticSegmentation__handle__, glassesMatte__handle__, gainMap__handle__, (int)orientation, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (image);
			GC.KeepAlive (disparityImage);
			GC.KeepAlive (portraitEffectsMatte);
			GC.KeepAlive (hairSemanticSegmentation);
			GC.KeepAlive (glassesMatte);
			GC.KeepAlive (gainMap);
			GC.KeepAlive (options);
			return ret!;
		}
	} /* class CIContext_CIDepthBlurEffect */
}
