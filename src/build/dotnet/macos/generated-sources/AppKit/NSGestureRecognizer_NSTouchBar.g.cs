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
	public unsafe static partial class NSGestureRecognizer_NSTouchBar  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedTouchTypesX = "allowedTouchTypes";
		static readonly NativeHandle selAllowedTouchTypesXHandle = Selector.GetHandle ("allowedTouchTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowedTouchTypes_X = "setAllowedTouchTypes:";
		static readonly NativeHandle selSetAllowedTouchTypes_XHandle = Selector.GetHandle ("setAllowedTouchTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSGestureRecognizer");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("allowedTouchTypes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTouchTypeMask GetAllowedTouchTypes (this NSGestureRecognizer This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTouchTypeMask ret;
			ret = (NSTouchTypeMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, selAllowedTouchTypesXHandle);
			GC.KeepAlive (This);
			return ret!;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="types">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAllowedTouchTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowedTouchTypes (this NSGestureRecognizer This, NSTouchTypeMask types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, selSetAllowedTouchTypes_XHandle, (UIntPtr) (ulong) types);
			GC.KeepAlive (This);
		}
	} /* class NSGestureRecognizer_NSTouchBar */
}
