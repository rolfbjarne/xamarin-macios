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
namespace UIKit {
	/// <summary>String drawing extension methods for <see cref="T:Foundation.NSString" />.</summary>
	public unsafe static partial class NSExtendedStringDrawing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawString (this NSString This, CGRect rect, NSStringDrawingOptions options, UIStringAttributes attributes, NSStringDrawingContext? context)
		{
			WeakDrawString (This, rect, options, attributes.GetDictionary (), context);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="size">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetBoundingRect (this NSString This, CGSize size, NSStringDrawingOptions options, UIStringAttributes attributes, NSStringDrawingContext? context)
		{
			return WeakGetBoundingRect (This, size, options, attributes.GetDictionary (), context);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithRect:options:attributes:context:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WeakDrawString (this NSString This, CGRect rect, NSStringDrawingOptions options, NSDictionary? attributes, NSStringDrawingContext? context)
		{
			var attributes__handle__ = attributes.GetHandle ();
			var context__handle__ = context.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("drawWithRect:options:attributes:context:"), rect, (UIntPtr) (ulong) options, attributes__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
			GC.KeepAlive (context);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="size">To be added.</param><param name="options">To be added.</param><param name="attributes">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingRectWithSize:options:attributes:context:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect WeakGetBoundingRect (this NSString This, CGSize size, NSStringDrawingOptions options, NSDictionary? attributes, NSStringDrawingContext? context)
		{
			var attributes__handle__ = attributes.GetHandle ();
			var context__handle__ = context.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGSize_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("boundingRectWithSize:options:attributes:context:"), size, (UIntPtr) (ulong) options, attributes__handle__, context__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGSize_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("boundingRectWithSize:options:attributes:context:"), size, (UIntPtr) (ulong) options, attributes__handle__, context__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (attributes);
			GC.KeepAlive (context);
			return ret!;
		}
	} /* class NSExtendedStringDrawing */
}
