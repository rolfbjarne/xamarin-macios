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
	public unsafe static partial class NSResponder_NSTouchBarProvider  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeTouchBarX = "makeTouchBar";
		static readonly NativeHandle selMakeTouchBarXHandle = Selector.GetHandle ("makeTouchBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTouchBar_X = "setTouchBar:";
		static readonly NativeHandle selSetTouchBar_XHandle = Selector.GetHandle ("setTouchBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchBarX = "touchBar";
		static readonly NativeHandle selTouchBarXHandle = Selector.GetHandle ("touchBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSResponder");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("touchBar")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTouchBar? GetTouchBar (this NSResponder This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTouchBar ret;
			ret =  Runtime.GetNSObject<NSTouchBar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selTouchBarXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("makeTouchBar")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTouchBar MakeTouchBar (this NSResponder This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTouchBar ret;
			ret =  Runtime.GetNSObject<NSTouchBar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selMakeTouchBarXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="bar">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setTouchBar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTouchBar (this NSResponder This, NSTouchBar? bar)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var bar__handle__ = bar.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selSetTouchBar_XHandle, bar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (bar);
		}
	} /* class NSResponder_NSTouchBarProvider */
}
