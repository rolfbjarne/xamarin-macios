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
	public unsafe static partial class NSRulerMarkerClientViewDelegation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_LocationForPoint_X = "rulerView:locationForPoint:";
		static readonly NativeHandle selRulerView_LocationForPoint_XHandle = Selector.GetHandle ("rulerView:locationForPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_PointForLocation_X = "rulerView:pointForLocation:";
		static readonly NativeHandle selRulerView_PointForLocation_XHandle = Selector.GetHandle ("rulerView:pointForLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSView");
		/// <param name="This">The instance on which this method operates.</param><param name="ruler">To be added.</param><param name="locationForPoint">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rulerView:locationForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat RulerViewLocation (this NSView This, NSRulerView ruler, CGPoint locationForPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_CGPoint (This.Handle, selRulerView_LocationForPoint_XHandle, ruler__handle__, locationForPoint);
			GC.KeepAlive (This);
			GC.KeepAlive (ruler);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="ruler">To be added.</param><param name="pointForLocation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rulerView:pointForLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint RulerViewPoint (this NSView This, NSRulerView ruler, nfloat pointForLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle_nfloat (This.Handle, selRulerView_PointForLocation_XHandle, ruler__handle__, pointForLocation);
			GC.KeepAlive (This);
			GC.KeepAlive (ruler);
			return ret!;
		}
	} /* class NSRulerMarkerClientViewDelegation */
}
