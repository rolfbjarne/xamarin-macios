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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace BrowserEngineKit {
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class NSObject_BEAccessibility  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		[Export ("browserAccessibilityDeleteTextAtCursor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BrowserAccessibilityDeleteTextAtCursor (this NSObject This, nint numberOfCharacters)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("browserAccessibilityDeleteTextAtCursor:"), numberOfCharacters);
			GC.KeepAlive (This);
		}
		[Export ("browserAccessibilityInsertTextAtCursor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BrowserAccessibilityInsertTextAtCursor (this NSObject This, string text)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("browserAccessibilityInsertTextAtCursor:"), nstext);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstext);
		}
		[Export ("accessibilityLineEndPositionFromCurrentSelection")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetAccessibilityLineEndPositionFromCurrentSelection (this NSObject This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLineEndPositionFromCurrentSelection"));
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("accessibilityLineRangeForPosition:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRange GetAccessibilityLineRangeForPosition (this NSObject This, nint position)
		{
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityLineRangeForPosition:"), position);
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("accessibilityLineStartPositionFromCurrentSelection")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetAccessibilityLineStartPositionFromCurrentSelection (this NSObject This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLineStartPositionFromCurrentSelection"));
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilityAttributedValueInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString GetBrowserAccessibilityAttributedValue (this NSObject This, NSRange range)
		{
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("browserAccessibilityAttributedValueInRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilityContainerType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static BEAccessibilityContainerType GetBrowserAccessibilityContainerType (this NSObject This)
		{
			BEAccessibilityContainerType ret;
			ret = (BrowserEngineKit.BEAccessibilityContainerType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityContainerType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[Export ("browserAccessibilityCurrentStatus")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetBrowserAccessibilityCurrentStatus (this NSObject This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityCurrentStatus")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilityHasDOMFocus")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetBrowserAccessibilityHasDomFocus (this NSObject This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityHasDOMFocus"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[Export ("browserAccessibilityIsRequired")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetBrowserAccessibilityIsRequired (this NSObject This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityIsRequired"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[Export ("browserAccessibilityPressedState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static BEAccessibilityPressedState GetBrowserAccessibilityPressedState (this NSObject This)
		{
			BEAccessibilityPressedState ret;
			ret = (BrowserEngineKit.BEAccessibilityPressedState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityPressedState"));
			GC.KeepAlive (This);
			return ret!;
		}
		[Export ("browserAccessibilityRoleDescription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetBrowserAccessibilityRoleDescription (this NSObject This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilityRoleDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilitySelectedTextRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRange GetBrowserAccessibilitySelectedTextRange (this NSObject This)
		{
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilitySelectedTextRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilitySortDirection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetBrowserAccessibilitySortDirection (this NSObject This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("browserAccessibilitySortDirection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("browserAccessibilityValueInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetBrowserAccessibilityValue (this NSObject This, NSRange range)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("browserAccessibilityValueInRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("setBrowserAccessibilityContainerType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityContainerType (this NSObject This, BEAccessibilityContainerType value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setBrowserAccessibilityContainerType:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
		[Export ("setBrowserAccessibilityCurrentStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityCurrentStatus (this NSObject This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setBrowserAccessibilityCurrentStatus:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("setBrowserAccessibilityHasDOMFocus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityHasDomFocus (this NSObject This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setBrowserAccessibilityHasDOMFocus:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[Export ("setBrowserAccessibilityIsRequired:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityIsRequired (this NSObject This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setBrowserAccessibilityIsRequired:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[Export ("setBrowserAccessibilityPressedState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityPressedState (this NSObject This, BEAccessibilityPressedState value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setBrowserAccessibilityPressedState:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[Export ("setBrowserAccessibilityRoleDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilityRoleDescription (this NSObject This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setBrowserAccessibilityRoleDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("browserAccessibilitySetSelectedTextRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilitySelectedTextRange (this NSObject This, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("browserAccessibilitySetSelectedTextRange:"), range);
			GC.KeepAlive (This);
		}
		[Export ("setBrowserAccessibilitySortDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBrowserAccessibilitySortDirection (this NSObject This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setBrowserAccessibilitySortDirection:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	} /* class NSObject_BEAccessibility */
}
