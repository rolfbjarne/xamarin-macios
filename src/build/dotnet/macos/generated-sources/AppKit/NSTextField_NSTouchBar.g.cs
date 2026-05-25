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
	public unsafe static partial class NSTextField_NSTouchBar  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCharacterPickerTouchBarItemX = "allowsCharacterPickerTouchBarItem";
		static readonly NativeHandle selAllowsCharacterPickerTouchBarItemXHandle = Selector.GetHandle ("allowsCharacterPickerTouchBarItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticTextCompletionEnabled_X = "automaticTextCompletionEnabled:";
		static readonly NativeHandle selAutomaticTextCompletionEnabled_XHandle = Selector.GetHandle ("automaticTextCompletionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticTextCompletionEnabledX = "isAutomaticTextCompletionEnabled";
		static readonly NativeHandle selIsAutomaticTextCompletionEnabledXHandle = Selector.GetHandle ("isAutomaticTextCompletionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsCharacterPickerTouchBarItem_X = "setAllowsCharacterPickerTouchBarItem:";
		static readonly NativeHandle selSetAllowsCharacterPickerTouchBarItem_XHandle = Selector.GetHandle ("setAllowsCharacterPickerTouchBarItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextField");
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("allowsCharacterPickerTouchBarItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAllowsCharacterPickerTouchBarItem (this NSTextField This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selAllowsCharacterPickerTouchBarItemXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("isAutomaticTextCompletionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAutomaticTextCompletionEnabled (this NSTextField This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, selIsAutomaticTextCompletionEnabledXHandle);
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="This">The instance on which this method operates.</param><param name="allows">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAllowsCharacterPickerTouchBarItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAllowsCharacterPickerTouchBarItem (this NSTextField This, bool allows)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, selSetAllowsCharacterPickerTouchBarItem_XHandle, allows ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="This">The instance on which this method operates.</param><param name="enabled">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("automaticTextCompletionEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAutomaticTextCompletionEnabled (this NSTextField This, bool enabled)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, selAutomaticTextCompletionEnabled_XHandle, enabled ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	} /* class NSTextField_NSTouchBar */
}
