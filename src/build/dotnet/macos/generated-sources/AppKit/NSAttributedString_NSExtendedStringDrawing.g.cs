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
	public unsafe static partial class NSAttributedString_NSExtendedStringDrawing  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectWithSize_Options_Context_X = "boundingRectWithSize:options:context:";
		static readonly NativeHandle selBoundingRectWithSize_Options_Context_XHandle = Selector.GetHandle ("boundingRectWithSize:options:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithRect_Options_Context_X = "drawWithRect:options:context:";
		static readonly NativeHandle selDrawWithRect_Options_Context_XHandle = Selector.GetHandle ("drawWithRect:options:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAttributedString");
		/// <param name="This">The instance on which this method operates.</param><param name="size">To be added.</param><param name="options">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingRectWithSize:options:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect BoundingRectWithSize (this NSAttributedString This, CGSize size, NSStringDrawingOptions options, NSStringDrawingContext? context)
		{
			var context__handle__ = context.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGSize_UIntPtr_NativeHandle (This.Handle, selBoundingRectWithSize_Options_Context_XHandle, size, (UIntPtr) (ulong) options, context__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGSize_UIntPtr_NativeHandle (This.Handle, selBoundingRectWithSize_Options_Context_XHandle, size, (UIntPtr) (ulong) options, context__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (context);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><param name="options">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithRect:options:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawWithRect (this NSAttributedString This, CGRect rect, NSStringDrawingOptions options, NSStringDrawingContext? context)
		{
			var context__handle__ = context.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_UIntPtr_NativeHandle (This.Handle, selDrawWithRect_Options_Context_XHandle, rect, (UIntPtr) (ulong) options, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (context);
		}
	} /* class NSAttributedString_NSExtendedStringDrawing */
}
