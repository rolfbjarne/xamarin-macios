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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	public unsafe static partial class NSStringDrawing_NSAttributedString  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAttributedString");
		/// <param name="This">The instance on which this method operates.</param><param name="point">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawAtPoint (this NSAttributedString This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("drawAtPoint:"), point);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawInRect (this NSAttributedString This, CGRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("drawInRect:"), rect);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("size")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetSize (this NSAttributedString This)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("size"));
			GC.KeepAlive (This);
			return ret;
		}
	} /* class NSStringDrawing_NSAttributedString */
}
