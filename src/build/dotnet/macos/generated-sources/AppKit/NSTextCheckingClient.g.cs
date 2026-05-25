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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSTextCheckingClient</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextCheckingClient", WrapperType = typeof (NSTextCheckingClientWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnnotatedSubstring", Selector = "annotatedSubstringForProposedRange:actualRange:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAnnotations", Selector = "setAnnotations:range:", ParameterType = new Type [] { typeof (global::Foundation.NSDictionary<NSString, NSString>), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnnotations", Selector = "addAnnotations:range:", ParameterType = new Type [] { typeof (global::Foundation.NSDictionary<NSString, NSString>), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnnotation", Selector = "removeAnnotation:range:", ParameterType = new Type [] { typeof (string), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceCharacters", Selector = "replaceCharactersInRange:withAnnotatedString:", ParameterType = new Type [] { typeof (NSRange), typeof (NSAttributedString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectAndShow", Selector = "selectAndShowRange:", ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetView", Selector = "viewForRange:firstRect:actualRange:", ReturnType = typeof (NSView), ParameterType = new Type [] { typeof (NSRange), typeof (CGRect), typeof (NSRange) }, ParameterByRef = new bool [] { false, true, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CandidateListTouchBarItem", Selector = "candidateListTouchBarItem", PropertyType = typeof (NSCandidateListTouchBarItem), GetterSelector = "candidateListTouchBarItem", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextCheckingClient : INativeObject, IDisposable, 
		AppKit.INSTextInputClient
		, AppKit.INSTextInputTraits
	{
		[global::Foundation.RequiredMember]
		[Export ("annotatedSubstringForProposedRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSAttributedString? GetAnnotatedSubstring (NSRange range, ref NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSAttributedString? _GetAnnotatedSubstring (INSTextCheckingClient This, NSRange range, ref NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_ref_NSRange (This.Handle, Selector.GetHandle ("annotatedSubstringForProposedRange:actualRange:"), range, actualRange__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		[global::Foundation.RequiredMember]
		[Export ("setAnnotations:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAnnotations (NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAnnotations (INSTextCheckingClient This, NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotations__handle__ = annotations!.GetNonNullHandle (nameof (annotations));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setAnnotations:range:"), annotations__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (annotations);
		}
		[global::Foundation.RequiredMember]
		[Export ("addAnnotations:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotations (NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddAnnotations (INSTextCheckingClient This, NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotations__handle__ = annotations!.GetNonNullHandle (nameof (annotations));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("addAnnotations:range:"), annotations__handle__, range);
			GC.KeepAlive (This);
			GC.KeepAlive (annotations);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAnnotation:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotation (string annotationName, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAnnotation (INSTextCheckingClient This, string annotationName, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (annotationName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotationName));
			var nsannotationName = CFString.CreateNative (annotationName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("removeAnnotation:range:"), nsannotationName, range);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsannotationName);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceCharactersInRange:withAnnotatedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCharacters (NSRange range, NSAttributedString annotatedString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceCharacters (INSTextCheckingClient This, NSRange range, NSAttributedString annotatedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotatedString__handle__ = annotatedString!.GetNonNullHandle (nameof (annotatedString));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("replaceCharactersInRange:withAnnotatedString:"), range, annotatedString__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (annotatedString);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectAndShowRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAndShow (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectAndShow (INSTextCheckingClient This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("selectAndShowRange:"), range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("viewForRange:firstRect:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSView? GetView (NSRange range, ref CGRect firstRect, ref NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSView? _GetView (INSTextCheckingClient This, NSRange range, ref CGRect firstRect, ref NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGRect* firstRect__pointer = &firstRect) {
			fixed (NSRange* actualRange__pointer = &actualRange) {
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_ref_CGRect_ref_NSRange (This.Handle, Selector.GetHandle ("viewForRange:firstRect:actualRange:"), range, firstRect__pointer, actualRange__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
			}
		}
		[DynamicDependencyAttribute ("AddAnnotations(Foundation.NSDictionary{Foundation.NSString,Foundation.NSString},Foundation.NSRange)")]
		[DynamicDependencyAttribute ("CandidateListTouchBarItem")]
		[DynamicDependencyAttribute ("GetAnnotatedSubstring(Foundation.NSRange,Foundation.NSRange@)")]
		[DynamicDependencyAttribute ("GetView(Foundation.NSRange,CoreGraphics.CGRect@,Foundation.NSRange@)")]
		[DynamicDependencyAttribute ("RemoveAnnotation(System.String,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ReplaceCharacters(Foundation.NSRange,Foundation.NSAttributedString)")]
		[DynamicDependencyAttribute ("SelectAndShow(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetAnnotations(Foundation.NSDictionary{Foundation.NSString,Foundation.NSString},Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextCheckingClientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextCheckingClient ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSCandidateListTouchBarItem? CandidateListTouchBarItem {
			[Export ("candidateListTouchBarItem")]
			get {
				return _GetCandidateListTouchBarItem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCandidateListTouchBarItem _GetCandidateListTouchBarItem (INSTextCheckingClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCandidateListTouchBarItem ret;
			ret =  Runtime.GetNSObject<NSCandidateListTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("candidateListTouchBarItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextCheckingClientWrapper : BaseWrapper, INSTextCheckingClient {
		public NSTextCheckingClientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextCheckingClientWrapper))]
		static NSTextCheckingClientWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("annotatedSubstringForProposedRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString? GetAnnotatedSubstring (NSRange range, ref NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_ref_NSRange (this.Handle, Selector.GetHandle ("annotatedSubstringForProposedRange:actualRange:"), range, actualRange__pointer), false)!;
			return ret;
			}
		}
		[Export ("setAnnotations:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAnnotations (NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotations__handle__ = annotations!.GetNonNullHandle (nameof (annotations));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setAnnotations:range:"), annotations__handle__, range);
			GC.KeepAlive (annotations);
		}
		[Export ("addAnnotations:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddAnnotations (NSDictionary<NSString, NSString> annotations, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotations__handle__ = annotations!.GetNonNullHandle (nameof (annotations));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("addAnnotations:range:"), annotations__handle__, range);
			GC.KeepAlive (annotations);
		}
		[Export ("removeAnnotation:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAnnotation (string annotationName, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (annotationName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotationName));
			var nsannotationName = CFString.CreateNative (annotationName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("removeAnnotation:range:"), nsannotationName, range);
			CFString.ReleaseNative (nsannotationName);
		}
		[Export ("replaceCharactersInRange:withAnnotatedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceCharacters (NSRange range, NSAttributedString annotatedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var annotatedString__handle__ = annotatedString!.GetNonNullHandle (nameof (annotatedString));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("replaceCharactersInRange:withAnnotatedString:"), range, annotatedString__handle__);
			GC.KeepAlive (annotatedString);
		}
		[Export ("selectAndShowRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectAndShow (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("selectAndShowRange:"), range);
		}
		[Export ("viewForRange:firstRect:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSView? GetView (NSRange range, ref CGRect firstRect, ref NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGRect* firstRect__pointer = &firstRect) {
			fixed (NSRange* actualRange__pointer = &actualRange) {
			NSView ret;
			ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_ref_CGRect_ref_NSRange (this.Handle, Selector.GetHandle ("viewForRange:firstRect:actualRange:"), range, firstRect__pointer, actualRange__pointer), false)!;
			return ret;
			}
			}
		}
		[Export ("insertText:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertText (NSObject text, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("insertText:replacementRange:"), text__handle__, replacementRange);
			GC.KeepAlive (text);
		}
		[Export ("setMarkedText:selectedRange:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMarkedText (NSObject text, NSRange selectedRange, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NSRange (this.Handle, Selector.GetHandle ("setMarkedText:selectedRange:replacementRange:"), text__handle__, selectedRange, replacementRange);
			GC.KeepAlive (text);
		}
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UnmarkText ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unmarkText"));
		}
		[Export ("attributedSubstringForProposedRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString? GetAttributedSubstring (NSRange proposedRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("attributedSubstringForProposedRange:actualRange:"), proposedRange, actualRange__pointer), false)!;
			return ret;
			}
		}
		[Export ("firstRectForCharacterRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetFirstRect (NSRange characterRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("firstRectForCharacterRange:actualRange:"), characterRange, actualRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("firstRectForCharacterRange:actualRange:"), characterRange, actualRange__pointer);
			}
			return ret!;
			}
		}
		[Export ("characterIndexForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetCharacterIndex (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("characterIndexForPoint:"), point);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCandidateListTouchBarItem? CandidateListTouchBarItem {
			[Export ("candidateListTouchBarItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCandidateListTouchBarItem ret;
				ret =  Runtime.GetNSObject<NSCandidateListTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("candidateListTouchBarItem")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSRange SelectedRange {
			[Export ("selectedRange")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("selectedRange"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSRange MarkedRange {
			[Export ("markedRange")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("markedRange"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool HasMarkedText {
			[Export ("hasMarkedText")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasMarkedText"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public NSString[] ValidAttributesForMarkedText {
			[Export ("validAttributesForMarkedText")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSString[] ret;
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("validAttributesForMarkedText")), false)!;
				return ret;
			}
		}
	}
}
