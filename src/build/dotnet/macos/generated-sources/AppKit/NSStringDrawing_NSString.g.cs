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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSStringDrawing_NSString  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_WithAttributes_X = "drawAtPoint:withAttributes:";
		static readonly NativeHandle selDrawAtPoint_WithAttributes_XHandle = Selector.GetHandle ("drawAtPoint:withAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_WithAttributes_X = "drawInRect:withAttributes:";
		static readonly NativeHandle selDrawInRect_WithAttributes_XHandle = Selector.GetHandle ("drawInRect:withAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeWithAttributes_X = "sizeWithAttributes:";
		static readonly NativeHandle selSizeWithAttributes_XHandle = Selector.GetHandle ("sizeWithAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawAtPoint (this NSString This, CGPoint point, NSDictionary? attributes)
		{
			var attributes__handle__ = attributes.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (This.Handle, selDrawAtPoint_WithAttributes_XHandle, point, attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawAtPoint (this NSString This, CGPoint point, NSStringAttributes? attributes)
		{
			This.DrawAtPoint (point, attributes.GetDictionary ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawInRect (this NSString This, CGRect rect, NSDictionary? attributes)
		{
			var attributes__handle__ = attributes.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (This.Handle, selDrawInRect_WithAttributes_XHandle, rect, attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawInRect (this NSString This, CGRect rect, NSStringAttributes? attributes)
		{
			This.DrawInRect (rect, attributes.GetDictionary ()!);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="attributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sizeWithAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, NSDictionary? attributes)
		{
			var attributes__handle__ = attributes.GetHandle ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, selSizeWithAttributes_XHandle, attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="attributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize StringSize (this NSString This, NSStringAttributes? attributes)
		{
			return This.StringSize (attributes.GetDictionary ()!);
		}
	} /* class NSStringDrawing_NSString */
}
