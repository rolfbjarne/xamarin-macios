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
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSLayoutManager_NSTextViewSupport  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstTextViewX = "firstTextView";
		static readonly NativeHandle selFirstTextViewXHandle = Selector.GetHandle ("firstTextView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutManagerOwnsFirstResponderInWindow_X = "layoutManagerOwnsFirstResponderInWindow:";
		static readonly NativeHandle selLayoutManagerOwnsFirstResponderInWindow_XHandle = Selector.GetHandle ("layoutManagerOwnsFirstResponderInWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_X = "rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:";
		static readonly NativeHandle selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_XHandle = Selector.GetHandle ("rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerMarkersForTextView_ParagraphStyle_Ruler_X = "rulerMarkersForTextView:paragraphStyle:ruler:";
		static readonly NativeHandle selRulerMarkersForTextView_ParagraphStyle_Ruler_XHandle = Selector.GetHandle ("rulerMarkersForTextView:paragraphStyle:ruler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewForBeginningOfSelectionX = "textViewForBeginningOfSelection";
		static readonly NativeHandle selTextViewForBeginningOfSelectionXHandle = Selector.GetHandle ("textViewForBeginningOfSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutManager");
		[Export ("firstTextView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextView? GetFirstTextView (this NSLayoutManager This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextView ret;
			ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selFirstTextViewXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSView? GetRulerAccessoryView (this NSLayoutManager This, NSTextView textView, NSParagraphStyle paragraphStyle, NSRulerView ruler, bool enabled)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var paragraphStyle__handle__ = paragraphStyle!.GetNonNullHandle (nameof (paragraphStyle));
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			NSView? ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (This.Handle, selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_XHandle, textView__handle__, paragraphStyle__handle__, ruler__handle__, enabled ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (paragraphStyle);
			GC.KeepAlive (ruler);
			return ret!;
		}
		[Export ("rulerMarkersForTextView:paragraphStyle:ruler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRulerMarker[] GetRulerMarkers (this NSLayoutManager This, NSTextView textView, NSParagraphStyle paragraphStyle, NSRulerView ruler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var paragraphStyle__handle__ = paragraphStyle!.GetNonNullHandle (nameof (paragraphStyle));
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			NSRulerMarker[]? ret;
			ret = CFArray.ArrayFromHandle<NSRulerMarker>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selRulerMarkersForTextView_ParagraphStyle_Ruler_XHandle, textView__handle__, paragraphStyle__handle__, ruler__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (paragraphStyle);
			GC.KeepAlive (ruler);
			return ret!;
		}
		[Export ("textViewForBeginningOfSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextView? GetTextViewForBeginningOfSelection (this NSLayoutManager This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextView ret;
			ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, selTextViewForBeginningOfSelectionXHandle), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("layoutManagerOwnsFirstResponderInWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LayoutManagerOwnsFirstResponder (this NSLayoutManager This, NSWindow window)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, selLayoutManagerOwnsFirstResponderInWindow_XHandle, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (window);
			return ret != 0;
		}
	} /* class NSLayoutManager_NSTextViewSupport */
}
