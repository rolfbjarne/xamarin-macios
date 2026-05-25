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
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	public unsafe static partial class NSObject_UIAccessibilityTextNavigation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		[Export ("accessibilityNextTextNavigationElement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetAccessibilityNextTextNavigationElement (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityNextTextNavigationElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAXObjectReturnBlock))]
		[Export ("accessibilityNextTextNavigationElementBlock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AXObjectReturnBlock? GetAccessibilityNextTextNavigationElementBlock (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityNextTextNavigationElementBlock"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDAXObjectReturnBlock.Create (ret)!;
		}
		[Export ("accessibilityPreviousTextNavigationElement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetAccessibilityPreviousTextNavigationElement (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPreviousTextNavigationElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAXObjectReturnBlock))]
		[Export ("accessibilityPreviousTextNavigationElementBlock")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AXObjectReturnBlock? GetAccessibilityPreviousTextNavigationElementBlock (this NSObject This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPreviousTextNavigationElementBlock"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDAXObjectReturnBlock.Create (ret)!;
		}
		[Export ("setAccessibilityNextTextNavigationElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityNextTextNavigationElement (this NSObject This, NSObject? element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var element__handle__ = element.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityNextTextNavigationElement:"), element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (element);
		}
		[Export ("setAccessibilityNextTextNavigationElementBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetAccessibilityNextTextNavigationElementBlock (this NSObject This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAXObjectReturnBlock))]AXObjectReturnBlock? element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_element = Trampolines.SDAXObjectReturnBlock.CreateNullableBlock (element);
			BlockLiteral *block_ptr_element = null;
			if (element is not null)
				block_ptr_element = &block_element;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityNextTextNavigationElementBlock:"), (IntPtr) block_ptr_element);
			GC.KeepAlive (This);
		}
		[Export ("setAccessibilityPreviousTextNavigationElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityPreviousTextNavigationElement (this NSObject This, NSObject? element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var element__handle__ = element.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityPreviousTextNavigationElement:"), element__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (element);
		}
		[Export ("setAccessibilityPreviousTextNavigationElementBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetAccessibilityPreviousTextNavigationElementBlock (this NSObject This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAXObjectReturnBlock))]AXObjectReturnBlock? element)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_element = Trampolines.SDAXObjectReturnBlock.CreateNullableBlock (element);
			BlockLiteral *block_ptr_element = null;
			if (element is not null)
				block_ptr_element = &block_element;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityPreviousTextNavigationElementBlock:"), (IntPtr) block_ptr_element);
			GC.KeepAlive (This);
		}
	} /* class NSObject_UIAccessibilityTextNavigation */
}
