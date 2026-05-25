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
	public unsafe static partial class NSStringDrawing_NSAttributedString  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_X = "drawAtPoint:";
		static readonly NativeHandle selDrawAtPoint_XHandle = Selector.GetHandle ("drawAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInRect_X = "drawInRect:";
		static readonly NativeHandle selDrawInRect_XHandle = Selector.GetHandle ("drawInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSizeX = "size";
		static readonly NativeHandle selSizeXHandle = Selector.GetHandle ("size");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAttributedString");
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawAtPoint (this NSAttributedString This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, selDrawAtPoint_XHandle, point);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawInRect (this NSAttributedString This, CGRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, selDrawInRect_XHandle, rect);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("size")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetSize (this NSAttributedString This)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, selSizeXHandle);
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSStringDrawing_NSAttributedString */
}
