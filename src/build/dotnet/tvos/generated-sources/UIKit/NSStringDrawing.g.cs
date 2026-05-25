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
	/// <summary>Extension methods for <see cref="T:Foundation.NSString" /> to support easy screen drawing.</summary><remarks>To be added.</remarks><altmember cref="T:Foundation.NSString" />
	public unsafe static partial class NSStringDrawing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawString (this NSString This, CGPoint point, UIStringAttributes attributes)
		{
			WeakDrawString (This, point, attributes.GetDictionary ());
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawString (this NSString This, CGRect rect, UIStringAttributes attributes)
		{
			WeakDrawString (This, rect, attributes.GetDictionary ());
		}
		/// <param name="This">The instance on which this method operates.</param><param name="attributes">To be added.</param><summary>The SizeF of the string, if rendered with the specified <paramref name="attributes" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetSizeUsingAttributes (this NSString This, UIStringAttributes attributes)
		{
			return WeakGetSizeUsingAttributes (This, attributes.GetDictionary ());
		}
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WeakDrawString (this NSString This, CGPoint point, NSDictionary? attributes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("drawAtPoint:withAttributes:"), point, attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="attributes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:withAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WeakDrawString (this NSString This, CGRect rect, NSDictionary? attributes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (This.Handle, Selector.GetHandle ("drawInRect:withAttributes:"), rect, attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="attributes">To be added.</param><summary>Returns the size of the rendered string.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sizeWithAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize WeakGetSizeUsingAttributes (this NSString This, NSDictionary? attributes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes.GetHandle ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sizeWithAttributes:"), attributes__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
			return ret!;
		}
	} /* class NSStringDrawing */
}
