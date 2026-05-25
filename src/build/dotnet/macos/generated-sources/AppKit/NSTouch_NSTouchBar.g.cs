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
	public unsafe static partial class NSTouch_NSTouchBar  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationInView_X = "locationInView:";
		static readonly NativeHandle selLocationInView_XHandle = Selector.GetHandle ("locationInView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousLocationInView_X = "previousLocationInView:";
		static readonly NativeHandle selPreviousLocationInView_XHandle = Selector.GetHandle ("previousLocationInView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTouch");
		/// <param name="This">The instance on which this method operates.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("locationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint GetLocation (this NSTouch This, NSView? view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, selLocationInView_XHandle, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previousLocationInView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint GetPreviousLocation (this NSTouch This, NSView? view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view.GetHandle ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle (This.Handle, selPreviousLocationInView_XHandle, view__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("type")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTouchType GetTouchType (this NSTouch This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTouchType ret;
			ret = (NSTouchType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, selTypeXHandle);
			GC.KeepAlive (This);
			return ret!;
		}
	} /* class NSTouch_NSTouchBar */
}
