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
	public unsafe static partial class NSApplication_NSTouchBarCustomization  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticCustomizeTouchBarMenuItemEnabledX = "isAutomaticCustomizeTouchBarMenuItemEnabled";
		static readonly NativeHandle selIsAutomaticCustomizeTouchBarMenuItemEnabledXHandle = Selector.GetHandle ("isAutomaticCustomizeTouchBarMenuItemEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticCustomizeTouchBarMenuItemEnabled_X = "setAutomaticCustomizeTouchBarMenuItemEnabled:";
		static readonly NativeHandle selSetAutomaticCustomizeTouchBarMenuItemEnabled_XHandle = Selector.GetHandle ("setAutomaticCustomizeTouchBarMenuItemEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleTouchBarCustomizationPalette_X = "toggleTouchBarCustomizationPalette:";
		static readonly NativeHandle selToggleTouchBarCustomizationPalette_XHandle = Selector.GetHandle ("toggleTouchBarCustomizationPalette:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSApplication");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isAutomaticCustomizeTouchBarMenuItemEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAutomaticCustomizeTouchBarMenuItemEnabled (this NSApplication This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsAutomaticCustomizeTouchBarMenuItemEnabledXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAutomaticCustomizeTouchBarMenuItemEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutomaticCustomizeTouchBarMenuItemEnabled (this NSApplication This, bool enabled)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, selSetAutomaticCustomizeTouchBarMenuItemEnabled_XHandle, enabled ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toggleTouchBarCustomizationPalette:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleTouchBarCustomizationPalette (this NSApplication This, NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, selToggleTouchBarCustomizationPalette_XHandle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
	} /* class NSApplication_NSTouchBarCustomization */
}
