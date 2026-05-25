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
namespace UIKit {
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios18.1")]
	[SupportedOSPlatform ("maccatalyst18.1")]
	public unsafe static partial class NSObject_UIAccessibilityTextOperations  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		[Export ("accessibilityTextInputResponder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUITextInput? GetAccessibilityTextInputResponder (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUITextInput ret;
			ret =  Runtime.GetINativeObject<IUITextInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTextInputResponder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDUITextInputReturnHandler))]
		[Export ("accessibilityTextInputResponderBlock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static UITextInputReturnHandler? GetAccessibilityTextInputResponderHandler (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTextInputResponderBlock"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDUITextInputReturnHandler.Create (ret)!;
		}
		[Export ("setAccessibilityTextInputResponder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityTextInputResponder (this NSObject This, IUITextInput? textInput)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textInput__handle__ = textInput.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTextInputResponder:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[Export ("setAccessibilityTextInputResponderBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetAccessibilityTextInputResponderHandler (this NSObject This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITextInputReturnHandler))]UITextInputReturnHandler? handler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_handler = Trampolines.SDUITextInputReturnHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTextInputResponderBlock:"), (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
	} /* class NSObject_UIAccessibilityTextOperations */
}
