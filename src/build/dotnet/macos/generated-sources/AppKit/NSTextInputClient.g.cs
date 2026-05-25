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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextInputClient</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextInputClient", WrapperType = typeof (NSTextInputClientWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertText", Selector = "insertText:replacementRange:", ParameterType = new Type [] { typeof (NSObject), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMarkedText", Selector = "setMarkedText:selectedRange:replacementRange:", ParameterType = new Type [] { typeof (NSObject), typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnmarkText", Selector = "unmarkText")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttributedSubstring", Selector = "attributedSubstringForProposedRange:actualRange:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFirstRect", Selector = "firstRectForCharacterRange:actualRange:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCharacterIndex", Selector = "characterIndexForPoint:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFractionOfDistanceThroughGlyph", Selector = "fractionOfDistanceThroughGlyphForPoint:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetBaselineDelta", Selector = "baselineDeltaForCharacterAtIndex:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawsVertically", Selector = "drawsVerticallyForCharacterAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertAdaptiveImageGlyph", Selector = "insertAdaptiveImageGlyph:replacementRange:", ParameterType = new Type [] { typeof (NSAdaptiveImageGlyph), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedRange", Selector = "selectedRange", PropertyType = typeof (NSRange), GetterSelector = "selectedRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedRange", Selector = "markedRange", PropertyType = typeof (NSRange), GetterSelector = "markedRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HasMarkedText", Selector = "hasMarkedText", PropertyType = typeof (bool), GetterSelector = "hasMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ValidAttributesForMarkedText", Selector = "validAttributesForMarkedText", PropertyType = typeof (NSString[]), GetterSelector = "validAttributesForMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AttributedString", Selector = "attributedString", PropertyType = typeof (NSAttributedString), GetterSelector = "attributedString", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WindowLevel", Selector = "windowLevel", PropertyType = typeof (NSWindowLevel), GetterSelector = "windowLevel", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UnionRectInVisibleSelectedRange", Selector = "unionRectInVisibleSelectedRange", PropertyType = typeof (CGRect), GetterSelector = "unionRectInVisibleSelectedRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DocumentVisibleRect", Selector = "documentVisibleRect", PropertyType = typeof (CGRect), GetterSelector = "documentVisibleRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreferredTextAccessoryPlacement", Selector = "preferredTextAccessoryPlacement", PropertyType = typeof (NSTextCursorAccessoryPlacement), GetterSelector = "preferredTextAccessoryPlacement", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsAdaptiveImageGlyph", Selector = "supportsAdaptiveImageGlyph", PropertyType = typeof (bool), GetterSelector = "supportsAdaptiveImageGlyph", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSTextInputClient : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("insertText:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (NSObject text, NSRange replacementRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertText (INSTextInputClient This, NSObject text, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("insertText:replacementRange:"), text__handle__, replacementRange);
			GC.KeepAlive (This);
			GC.KeepAlive (text);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMarkedText:selectedRange:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (NSObject text, NSRange selectedRange, NSRange replacementRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMarkedText (INSTextInputClient This, NSObject text, NSRange selectedRange, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NSRange (This.Handle, Selector.GetHandle ("setMarkedText:selectedRange:replacementRange:"), text__handle__, selectedRange, replacementRange);
			GC.KeepAlive (This);
			GC.KeepAlive (text);
		}
		[global::Foundation.RequiredMember]
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnmarkText (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("unmarkText"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("attributedSubstringForProposedRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSAttributedString? GetAttributedSubstring (NSRange proposedRange, out NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSAttributedString? _GetAttributedSubstring (INSTextInputClient This, NSRange proposedRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_out_NSRange (This.Handle, Selector.GetHandle ("attributedSubstringForProposedRange:actualRange:"), proposedRange, actualRange__pointer), false)!;
			GC.KeepAlive (This);
			return ret;
			}
		}
		[global::Foundation.RequiredMember]
		[Export ("firstRectForCharacterRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGRect GetFirstRect (NSRange characterRange, out NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static CGRect _GetFirstRect (INSTextInputClient This, NSRange characterRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange_out_NSRange (This.Handle, Selector.GetHandle ("firstRectForCharacterRange:actualRange:"), characterRange, actualRange__pointer);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange_out_NSRange (This.Handle, Selector.GetHandle ("firstRectForCharacterRange:actualRange:"), characterRange, actualRange__pointer);
				GC.KeepAlive (This);
			}
			return ret!;
			}
		}
		[global::Foundation.RequiredMember]
		[Export ("characterIndexForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetCharacterIndex (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetCharacterIndex (INSTextInputClient This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("characterIndexForPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fractionOfDistanceThroughGlyphForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetFractionOfDistanceThroughGlyph (CGPoint point)
		{
			return _GetFractionOfDistanceThroughGlyph (this, point);
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetFractionOfDistanceThroughGlyph (INSTextInputClient This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("baselineDeltaForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBaselineDelta (nuint charIndex)
		{
			return _GetBaselineDelta (this, charIndex);
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetBaselineDelta (INSTextInputClient This, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("baselineDeltaForCharacterAtIndex:"), charIndex);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("drawsVerticallyForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsVertically (nuint charIndex)
		{
			return _DrawsVertically (this, charIndex);
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DrawsVertically (INSTextInputClient This, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("drawsVerticallyForCharacterAtIndex:"), charIndex);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, NSRange replacementRange)
		{
			_InsertAdaptiveImageGlyph (this, adaptiveImageGlyph, replacementRange);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertAdaptiveImageGlyph (INSTextInputClient This, NSAdaptiveImageGlyph adaptiveImageGlyph, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptiveImageGlyph);
		}
		[DynamicDependencyAttribute ("AttributedString")]
		[DynamicDependencyAttribute ("DocumentVisibleRect")]
		[DynamicDependencyAttribute ("DrawsVertically(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetAttributedSubstring(Foundation.NSRange,Foundation.NSRange@)")]
		[DynamicDependencyAttribute ("GetBaselineDelta(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetCharacterIndex(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetFirstRect(Foundation.NSRange,Foundation.NSRange@)")]
		[DynamicDependencyAttribute ("GetFractionOfDistanceThroughGlyph(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("HasMarkedText")]
		[DynamicDependencyAttribute ("InsertAdaptiveImageGlyph(AppKit.NSAdaptiveImageGlyph,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("InsertText(Foundation.NSObject,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("MarkedRange")]
		[DynamicDependencyAttribute ("PreferredTextAccessoryPlacement")]
		[DynamicDependencyAttribute ("SelectedRange")]
		[DynamicDependencyAttribute ("SetMarkedText(Foundation.NSObject,Foundation.NSRange,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SupportsAdaptiveImageGlyph")]
		[DynamicDependencyAttribute ("UnionRectInVisibleSelectedRange")]
		[DynamicDependencyAttribute ("UnmarkText()")]
		[DynamicDependencyAttribute ("ValidAttributesForMarkedText")]
		[DynamicDependencyAttribute ("WindowLevel")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextInputClientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextInputClient ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange SelectedRange {
			[Export ("selectedRange")]
			get {
				return _GetSelectedRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetSelectedRange (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("selectedRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange MarkedRange {
			[Export ("markedRange")]
			get {
				return _GetMarkedRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetMarkedRange (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("markedRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool HasMarkedText {
			[Export ("hasMarkedText")]
			get {
				return _GetHasMarkedText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetHasMarkedText (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasMarkedText"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSString[] ValidAttributesForMarkedText {
			[Export ("validAttributesForMarkedText")]
			get {
				return _GetValidAttributesForMarkedText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString[] _GetValidAttributesForMarkedText (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSString[] ret;
			ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("validAttributesForMarkedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSAttributedString AttributedString {
			[Export ("attributedString")]
			get {
				return _GetAttributedString (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _GetAttributedString (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("attributedString")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSWindowLevel WindowLevel {
			[Export ("windowLevel")]
			get {
				return _GetWindowLevel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWindowLevel _GetWindowLevel (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWindowLevel ret;
			ret = (NSWindowLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("windowLevel"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual CGRect UnionRectInVisibleSelectedRange {
			[Export ("unionRectInVisibleSelectedRange")]
			get {
				return _GetUnionRectInVisibleSelectedRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetUnionRectInVisibleSelectedRange (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("unionRectInVisibleSelectedRange"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("unionRectInVisibleSelectedRange"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual CGRect DocumentVisibleRect {
			[Export ("documentVisibleRect")]
			get {
				return _GetDocumentVisibleRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetDocumentVisibleRect (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("documentVisibleRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("documentVisibleRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual NSTextCursorAccessoryPlacement PreferredTextAccessoryPlacement {
			[Export ("preferredTextAccessoryPlacement")]
			get {
				return _GetPreferredTextAccessoryPlacement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextCursorAccessoryPlacement _GetPreferredTextAccessoryPlacement (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextCursorAccessoryPlacement ret;
			ret = (NSTextCursorAccessoryPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("preferredTextAccessoryPlacement"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			get {
				return _GetSupportsAdaptiveImageGlyph (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsAdaptiveImageGlyph (INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextInputClient" /> interface to support all the methods from the NSTextInputClient protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextInputClient" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextInputClient protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextInputClient_Extensions {
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetFractionOfDistanceThroughGlyph (this INSTextInputClient This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetBaselineDelta (this INSTextInputClient This, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("baselineDeltaForCharacterAtIndex:"), charIndex);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DrawsVertically (this INSTextInputClient This, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("drawsVerticallyForCharacterAtIndex:"), charIndex);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertAdaptiveImageGlyph (this INSTextInputClient This, NSAdaptiveImageGlyph adaptiveImageGlyph, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptiveImageGlyph);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString GetAttributedString (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("attributedString")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSWindowLevel GetWindowLevel (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSWindowLevel ret;
			ret = (NSWindowLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("windowLevel"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetUnionRectInVisibleSelectedRange (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("unionRectInVisibleSelectedRange"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("unionRectInVisibleSelectedRange"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetDocumentVisibleRect (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("documentVisibleRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("documentVisibleRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCursorAccessoryPlacement GetPreferredTextAccessoryPlacement (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextCursorAccessoryPlacement ret;
			ret = (NSTextCursorAccessoryPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("preferredTextAccessoryPlacement"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsAdaptiveImageGlyph (this INSTextInputClient This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextInputClientWrapper : BaseWrapper, INSTextInputClient {
		public NSTextInputClientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextInputClientWrapper))]
		static NSTextInputClientWrapper ()
		{
			GC.KeepAlive (null);
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
		public NSRange SelectedRange {
			[Export ("selectedRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("selectedRange"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange MarkedRange {
			[Export ("markedRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("markedRange"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HasMarkedText {
			[Export ("hasMarkedText")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasMarkedText"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString[] ValidAttributesForMarkedText {
			[Export ("validAttributesForMarkedText")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSString[] ret;
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("validAttributesForMarkedText")), false)!;
				return ret;
			}
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextInputClient" /> (for the protocol <c>NSTextInputClient</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextInputClient" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTextInputClient", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSTextInputClient : NSObject, INSTextInputClient {
		/// <summary>Creates a new <see cref="NSTextInputClient" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSTextInputClient () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSTextInputClient (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSTextInputClient (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("drawsVerticallyForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsVertically (nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("attributedSubstringForProposedRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSAttributedString? GetAttributedSubstring (NSRange proposedRange, out NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("baselineDeltaForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBaselineDelta (nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("characterIndexForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetCharacterIndex (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("firstRectForCharacterRange:actualRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGRect GetFirstRect (NSRange characterRange, out NSRange actualRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fractionOfDistanceThroughGlyphForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetFractionOfDistanceThroughGlyph (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, NSRange replacementRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("insertText:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (NSObject text, NSRange replacementRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setMarkedText:selectedRange:replacementRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (NSObject text, NSRange selectedRange, NSRange replacementRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString AttributedString {
			[Export ("attributedString")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual CGRect DocumentVisibleRect {
			[Export ("documentVisibleRect")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMarkedText {
			[Export ("hasMarkedText")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange MarkedRange {
			[Export ("markedRange")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSTextCursorAccessoryPlacement PreferredTextAccessoryPlacement {
			[Export ("preferredTextAccessoryPlacement")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange SelectedRange {
			[Export ("selectedRange")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual CGRect UnionRectInVisibleSelectedRange {
			[Export ("unionRectInVisibleSelectedRange")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] ValidAttributesForMarkedText {
			[Export ("validAttributesForMarkedText")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindowLevel WindowLevel {
			[Export ("windowLevel")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class NSTextInputClient */
}
