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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextViewDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSTextViewDelegate", WrapperType = typeof (NSTextViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkClicked", Selector = "textView:clickedOnLink:atIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (NSObject), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellClicked", Selector = "textView:clickedOnCell:inRect:atIndex:", ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextAttachmentCell), typeof (CGRect), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellDoubleClicked", Selector = "textView:doubleClickedOnCell:inRect:atIndex:", ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextAttachmentCell), typeof (CGRect), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritablePasteboardTypes", Selector = "textView:writablePasteboardTypesForCell:atIndex:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextAttachmentCell), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteCell", Selector = "textView:writeCell:atIndex:toPasteboard:type:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextAttachmentCell), typeof (UIntPtr), typeof (NSPasteboard), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeSelection", Selector = "textView:willChangeSelectionFromCharacterRange:toCharacterRange:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeSelectionFromRanges", Selector = "textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:", ReturnType = typeof (NSValue[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSValue[]), typeof (NSValue[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRanges", Selector = "textView:shouldChangeTextInRanges:replacementStrings:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (NSValue[]), typeof (String[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTypingAttributes", Selector = "textView:shouldChangeTypingAttributes:toAttributes:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (NSTextView), typeof (NSDictionary), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSelection", Selector = "textViewDidChangeSelection:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeTypingAttributes", Selector = "textViewDidChangeTypingAttributes:", ParameterType = new Type [] { typeof (NSNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayToolTip", Selector = "textView:willDisplayToolTip:forCharacterAtIndex:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSTextView), typeof (string), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletions", Selector = "textView:completions:forPartialWordRange:indexOfSelectedItem:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSTextView), typeof (String[]), typeof (NSRange), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRange", Selector = "textView:shouldChangeTextInRange:replacementString:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoCommandBySelector", Selector = "textView:doCommandBySelector:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (Selector) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSetSpellingState", Selector = "textView:shouldSetSpellingState:range:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSTextView), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuForEvent", Selector = "textView:menu:forEvent:atIndex:", ReturnType = typeof (NSMenu), ParameterType = new Type [] { typeof (NSTextView), typeof (NSMenu), typeof (NSEvent), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCheckText", Selector = "textView:willCheckTextInRange:options:types:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange), typeof (NSDictionary), typeof (NSTextCheckingTypes) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCheckText", Selector = "textView:didCheckTextInRange:types:options:results:orthography:wordCount:", ReturnType = typeof (NSTextCheckingResult[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange), typeof (NSTextCheckingTypes), typeof (NSDictionary), typeof (NSTextCheckingResult[]), typeof (NSOrthography), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedCell", Selector = "textView:draggedCell:inRect:event:atIndex:", ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextAttachmentCell), typeof (CGRect), typeof (NSEvent), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUndoManager", Selector = "undoManagerForTextView:", ReturnType = typeof (NSUndoManager), ParameterType = new Type [] { typeof (NSTextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUpdateTouchBarItemIdentifiers", Selector = "textView:shouldUpdateTouchBarItemIdentifiers:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSTextView), typeof (String[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCandidates", Selector = "textView:candidatesForSelectedRange:", ReturnType = typeof (NSObject[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextCheckingCandidates", Selector = "textView:candidates:forSelectedRange:", ReturnType = typeof (NSTextCheckingResult[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSTextCheckingResult[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectCandidates", Selector = "textView:shouldSelectCandidateAtIndex:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSTextView), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WritingToolsWillBegin", Selector = "textViewWritingToolsWillBegin:", ParameterType = new Type [] { typeof (NSTextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WritingToolsDidEnd", Selector = "textViewWritingToolsDidEnd:", ParameterType = new Type [] { typeof (NSTextView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritingToolsIgnoredRangesInEnclosingRange", Selector = "textView:writingToolsIgnoredRangesInEnclosingRange:", ReturnType = typeof (NSValue[]), ParameterType = new Type [] { typeof (NSTextView), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSTextViewDelegate : INativeObject, IDisposable, 
		AppKit.INSTextDelegate
	{
		/// <param name="textView">To be added.</param><param name="link">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:clickedOnLink:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LinkClicked (NSTextView textView, NSObject link, nuint charIndex)
		{
			return _LinkClicked (this, textView, link, charIndex);
		}
		/// <param name="textView">To be added.</param><param name="link">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _LinkClicked (INSTextViewDelegate This, NSTextView textView, NSObject link, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:clickedOnLink:atIndex:"), textView__handle__, link__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (link);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:clickedOnCell:inRect:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			_CellClicked (this, textView, cell, cellFrame, charIndex);
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellClicked (INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (This.Handle, Selector.GetHandle ("textView:clickedOnCell:inRect:atIndex:"), textView__handle__, cell__handle__, cellFrame, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:doubleClickedOnCell:inRect:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDoubleClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			_CellDoubleClicked (this, textView, cell, cellFrame, charIndex);
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CellDoubleClicked (INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (This.Handle, Selector.GetHandle ("textView:doubleClickedOnCell:inRect:atIndex:"), textView__handle__, cell__handle__, cellFrame, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="view">To be added.</param><param name="forCell">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:writablePasteboardTypesForCell:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritablePasteboardTypes (NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
		{
			return _GetWritablePasteboardTypes (this, view, forCell, charIndex);
		}
		/// <param name="view">To be added.</param><param name="forCell">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetWritablePasteboardTypes (INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var forCell__handle__ = forCell!.GetNonNullHandle (nameof (forCell));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:writablePasteboardTypesForCell:atIndex:"), view__handle__, forCell__handle__, charIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (forCell);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="cell">To be added.</param><param name="charIndex">To be added.</param><param name="pboard">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:writeCell:atIndex:toPasteboard:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteCell (NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
		{
			return _WriteCell (this, view, cell, charIndex, pboard, type);
		}
		/// <param name="view">To be added.</param><param name="cell">To be added.</param><param name="charIndex">To be added.</param><param name="pboard">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WriteCell (INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:writeCell:atIndex:toPasteboard:type:"), view__handle__, cell__handle__, charIndex, pboard__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (pboard);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRange">To be added.</param><param name="newSelectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange WillChangeSelection (NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			return _WillChangeSelection (this, textView, oldSelectedCharRange, newSelectedCharRange);
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRange">To be added.</param><param name="newSelectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _WillChangeSelection (INSTextViewDelegate This, NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_NSRange_NSRange (This.Handle, Selector.GetHandle ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:"), textView__handle__, oldSelectedCharRange, newSelectedCharRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRanges">To be added.</param><param name="newSelectedCharRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] WillChangeSelectionFromRanges (NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			return _WillChangeSelectionFromRanges (this, textView, oldSelectedCharRanges, newSelectedCharRanges);
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRanges">To be added.</param><param name="newSelectedCharRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSValue[] _WillChangeSelectionFromRanges (INSTextViewDelegate This, NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (oldSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldSelectedCharRanges));
			if (newSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newSelectedCharRanges));
			using var nsa_oldSelectedCharRanges = NSArray.FromNSObjects (oldSelectedCharRanges);
			using var nsa_newSelectedCharRanges = NSArray.FromNSObjects (newSelectedCharRanges);
			NSValue[]? ret;
			ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:"), textView__handle__, nsa_oldSelectedCharRanges.Handle, nsa_newSelectedCharRanges.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="affectedRanges">To be added.</param><param name="replacementStrings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldChangeTextInRanges:replacementStrings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRanges (NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			return _ShouldChangeTextInRanges (this, textView, affectedRanges, replacementStrings);
		}
		/// <param name="textView">To be added.</param><param name="affectedRanges">To be added.</param><param name="replacementStrings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeTextInRanges (INSTextViewDelegate This, NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (affectedRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (affectedRanges));
			if (replacementStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementStrings));
			using var nsa_affectedRanges = NSArray.FromNSObjects (affectedRanges);
			using var nsa_replacementStrings = NSArray.FromStrings (replacementStrings);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementStrings:"), textView__handle__, nsa_affectedRanges.Handle, nsa_replacementStrings.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="oldTypingAttributes">To be added.</param><param name="newTypingAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldChangeTypingAttributes:toAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ShouldChangeTypingAttributes (NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			return _ShouldChangeTypingAttributes (this, textView, oldTypingAttributes, newTypingAttributes);
		}
		/// <param name="textView">To be added.</param><param name="oldTypingAttributes">To be added.</param><param name="newTypingAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _ShouldChangeTypingAttributes (INSTextViewDelegate This, NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var oldTypingAttributes__handle__ = oldTypingAttributes!.GetNonNullHandle (nameof (oldTypingAttributes));
			var newTypingAttributes__handle__ = newTypingAttributes!.GetNonNullHandle (nameof (newTypingAttributes));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTypingAttributes:toAttributes:"), textView__handle__, oldTypingAttributes__handle__, newTypingAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (oldTypingAttributes);
			GC.KeepAlive (newTypingAttributes);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidChangeSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (NSNotification notification)
		{
			_DidChangeSelection (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSelection (INSTextViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeSelection:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textViewDidChangeTypingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeTypingAttributes (NSNotification notification)
		{
			_DidChangeTypingAttributes (this, notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeTypingAttributes (INSTextViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeTypingAttributes:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="textView">To be added.</param><param name="tooltip">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:willDisplayToolTip:forCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? WillDisplayToolTip (NSTextView textView, string tooltip, nuint characterIndex)
		{
			return _WillDisplayToolTip (this, textView, tooltip, characterIndex);
		}
		/// <param name="textView">To be added.</param><param name="tooltip">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _WillDisplayToolTip (INSTextViewDelegate This, NSTextView textView, string tooltip, nuint characterIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (tooltip is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tooltip));
			var nstooltip = CFString.CreateNative (tooltip);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:willDisplayToolTip:forCharacterAtIndex:"), textView__handle__, nstooltip, characterIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstooltip);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetCompletions (NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			return _GetCompletions (this, textView, words, charRange, ref index);
		}
		/// <param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static string[] _GetCompletions (INSTextViewDelegate This, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			fixed (nint* index__pointer = &index) {
			using var nsa_words = NSArray.FromStrings (words);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange_ref_IntPtr (This.Handle, Selector.GetHandle ("textView:completions:forPartialWordRange:indexOfSelectedItem:"), textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
			}
		}
		/// <param name="textView">To be added.</param><param name="affectedCharRange">To be added.</param><param name="replacementString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldChangeTextInRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			return _ShouldChangeTextInRange (this, textView, affectedCharRange, replacementString);
		}
		/// <param name="textView">To be added.</param><param name="affectedCharRange">To be added.</param><param name="replacementString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeTextInRange (INSTextViewDelegate This, NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementString:"), textView__handle__, affectedCharRange, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:doCommandBySelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoCommandBySelector (NSTextView textView, Selector commandSelector)
		{
			return _DoCommandBySelector (this, textView, commandSelector);
		}
		/// <param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DoCommandBySelector (INSTextViewDelegate This, NSTextView textView, Selector commandSelector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var commandSelector__handle__ = commandSelector!.GetNonNullHandle (nameof (commandSelector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:doCommandBySelector:"), textView__handle__, commandSelector.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (commandSelector);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="value">To be added.</param><param name="affectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldSetSpellingState:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ShouldSetSpellingState (NSTextView textView, nint value, NSRange affectedCharRange)
		{
			return _ShouldSetSpellingState (this, textView, value, affectedCharRange);
		}
		/// <param name="textView">To be added.</param><param name="value">To be added.</param><param name="affectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _ShouldSetSpellingState (INSTextViewDelegate This, NSTextView textView, nint value, NSRange affectedCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_NSRange (This.Handle, Selector.GetHandle ("textView:shouldSetSpellingState:range:"), textView__handle__, value, affectedCharRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:menu:forEvent:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu MenuForEvent (NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
		{
			return _MenuForEvent (this, view, menu, theEvent, charIndex);
		}
		/// <param name="view">To be added.</param><param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSMenu _MenuForEvent (INSTextViewDelegate This, NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:menu:forEvent:atIndex:"), view__handle__, menu__handle__, theEvent__handle__, charIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="options">To be added.</param><param name="checkingTypes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:willCheckTextInRange:options:types:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WillCheckText (NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			return _WillCheckText (this, view, range, options, checkingTypes);
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="options">To be added.</param><param name="checkingTypes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _WillCheckText (INSTextViewDelegate This, NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("textView:willCheckTextInRange:options:types:"), view__handle__, range, options__handle__, (UInt64)checkingTypes), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="checkingTypes">To be added.</param><param name="options">To be added.</param><param name="results">To be added.</param><param name="orthography">To be added.</param><param name="wordCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] DidCheckText (NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			return _DidCheckText (this, view, range, checkingTypes, options, results, orthography, wordCount);
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="checkingTypes">To be added.</param><param name="options">To be added.</param><param name="results">To be added.</param><param name="orthography">To be added.</param><param name="wordCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextCheckingResult[] _DidCheckText (INSTextViewDelegate This, NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			using var nsa_results = NSArray.FromNSObjects (results);
			NSTextCheckingResult[]? ret;
			ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:"), view__handle__, range, (UInt64)checkingTypes, options__handle__, nsa_results.Handle, orthography__handle__, wordCount), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			GC.KeepAlive (orthography);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("textView:draggedCell:inRect:event:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedCell (NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, nuint charIndex)
		{
			_DraggedCell (this, view, cell, rect, theEvent, charIndex);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DraggedCell (INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:draggedCell:inRect:event:atIndex:"), view__handle__, cell__handle__, rect, theEvent__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (theEvent);
		}
		/// <param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("undoManagerForTextView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager GetUndoManager (NSTextView view)
		{
			return _GetUndoManager (this, view);
		}
		/// <param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUndoManager _GetUndoManager (INSTextViewDelegate This, NSTextView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSUndoManager? ret;
			ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("undoManagerForTextView:"), view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="identifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldUpdateTouchBarItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShouldUpdateTouchBarItemIdentifiers (NSTextView textView, string[] identifiers)
		{
			return _ShouldUpdateTouchBarItemIdentifiers (this, textView, identifiers);
		}
		/// <param name="textView">To be added.</param><param name="identifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _ShouldUpdateTouchBarItemIdentifiers (INSTextViewDelegate This, NSTextView textView, string[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldUpdateTouchBarItemIdentifiers:"), textView__handle__, nsa_identifiers.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:candidatesForSelectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? GetCandidates (NSTextView textView, NSRange selectedRange)
		{
			return _GetCandidates (this, textView, selectedRange);
		}
		/// <param name="textView">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[]? _GetCandidates (INSTextViewDelegate This, NSTextView textView, NSRange selectedRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:candidatesForSelectedRange:"), textView__handle__, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="candidates">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:candidates:forSelectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] GetTextCheckingCandidates (NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			return _GetTextCheckingCandidates (this, textView, candidates, selectedRange);
		}
		/// <param name="textView">To be added.</param><param name="candidates">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextCheckingResult[] _GetTextCheckingCandidates (INSTextViewDelegate This, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (candidates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (candidates));
			using var nsa_candidates = NSArray.FromNSObjects (candidates);
			NSTextCheckingResult[]? ret;
			ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:candidates:forSelectedRange:"), textView__handle__, nsa_candidates.Handle, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textView:shouldSelectCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectCandidates (NSTextView textView, nuint index)
		{
			return _ShouldSelectCandidates (this, textView, index);
		}
		/// <param name="textView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSelectCandidates (INSTextViewDelegate This, NSTextView textView, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:shouldSelectCandidateAtIndex:"), textView__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("textViewWritingToolsWillBegin:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsWillBegin (NSTextView textView)
		{
			_WritingToolsWillBegin (this, textView);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WritingToolsWillBegin (INSTextViewDelegate This, NSTextView textView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewWritingToolsWillBegin:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		[global::Foundation.OptionalMember]
		[Export ("textViewWritingToolsDidEnd:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsDidEnd (NSTextView textView)
		{
			_WritingToolsDidEnd (this, textView);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WritingToolsDidEnd (INSTextViewDelegate This, NSTextView textView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewWritingToolsDidEnd:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		[global::Foundation.OptionalMember]
		[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (NSTextView textView, NSRange enclosingRange)
		{
			return _GetWritingToolsIgnoredRangesInEnclosingRange (this, textView, enclosingRange);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSValue[] _GetWritingToolsIgnoredRangesInEnclosingRange (INSTextViewDelegate This, NSTextView textView, NSRange enclosingRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSValue[]? ret;
			ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:"), textView__handle__, enclosingRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		[DynamicDependencyAttribute ("CellClicked(AppKit.NSTextView,AppKit.NSTextAttachmentCell,CoreGraphics.CGRect,System.UIntPtr)")]
		[DynamicDependencyAttribute ("CellDoubleClicked(AppKit.NSTextView,AppKit.NSTextAttachmentCell,CoreGraphics.CGRect,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DidChangeSelection(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidChangeTypingAttributes(Foundation.NSNotification)")]
		[DynamicDependencyAttribute ("DidCheckText(AppKit.NSTextView,Foundation.NSRange,Foundation.NSTextCheckingTypes,Foundation.NSDictionary,Foundation.NSTextCheckingResult[],Foundation.NSOrthography,System.IntPtr)")]
		[DynamicDependencyAttribute ("DoCommandBySelector(AppKit.NSTextView,ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute ("DraggedCell(AppKit.NSTextView,AppKit.NSTextAttachmentCell,CoreGraphics.CGRect,AppKit.NSEvent,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetCandidates(AppKit.NSTextView,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetCompletions(AppKit.NSTextView,System.String[],Foundation.NSRange,System.IntPtr@)")]
		[DynamicDependencyAttribute ("GetTextCheckingCandidates(AppKit.NSTextView,Foundation.NSTextCheckingResult[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetUndoManager(AppKit.NSTextView)")]
		[DynamicDependencyAttribute ("GetWritablePasteboardTypes(AppKit.NSTextView,AppKit.NSTextAttachmentCell,System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetWritingToolsIgnoredRangesInEnclosingRange(AppKit.NSTextView,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("LinkClicked(AppKit.NSTextView,Foundation.NSObject,System.UIntPtr)")]
		[DynamicDependencyAttribute ("MenuForEvent(AppKit.NSTextView,AppKit.NSMenu,AppKit.NSEvent,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldChangeTextInRange(AppKit.NSTextView,Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute ("ShouldChangeTextInRanges(AppKit.NSTextView,Foundation.NSValue[],System.String[])")]
		[DynamicDependencyAttribute ("ShouldChangeTypingAttributes(AppKit.NSTextView,Foundation.NSDictionary,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("ShouldSelectCandidates(AppKit.NSTextView,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ShouldSetSpellingState(AppKit.NSTextView,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ShouldUpdateTouchBarItemIdentifiers(AppKit.NSTextView,System.String[])")]
		[DynamicDependencyAttribute ("WillChangeSelection(AppKit.NSTextView,Foundation.NSRange,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("WillChangeSelectionFromRanges(AppKit.NSTextView,Foundation.NSValue[],Foundation.NSValue[])")]
		[DynamicDependencyAttribute ("WillCheckText(AppKit.NSTextView,Foundation.NSRange,Foundation.NSDictionary,Foundation.NSTextCheckingTypes)")]
		[DynamicDependencyAttribute ("WillDisplayToolTip(AppKit.NSTextView,System.String,System.UIntPtr)")]
		[DynamicDependencyAttribute ("WriteCell(AppKit.NSTextView,AppKit.NSTextAttachmentCell,System.UIntPtr,AppKit.NSPasteboard,System.String)")]
		[DynamicDependencyAttribute ("WritingToolsDidEnd(AppKit.NSTextView)")]
		[DynamicDependencyAttribute ("WritingToolsWillBegin(AppKit.NSTextView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSTextViewDelegate" /> interface to support all the methods from the NSTextViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSTextViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSTextViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSTextViewDelegate_Extensions {
		/// <param name="textView">To be added.</param><param name="link">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LinkClicked (this INSTextViewDelegate This, NSTextView textView, NSObject link, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:clickedOnLink:atIndex:"), textView__handle__, link__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (link);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellClicked (this INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (This.Handle, Selector.GetHandle ("textView:clickedOnCell:inRect:atIndex:"), textView__handle__, cell__handle__, cellFrame, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CellDoubleClicked (this INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (This.Handle, Selector.GetHandle ("textView:doubleClickedOnCell:inRect:atIndex:"), textView__handle__, cell__handle__, cellFrame, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="view">To be added.</param><param name="forCell">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetWritablePasteboardTypes (this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var forCell__handle__ = forCell!.GetNonNullHandle (nameof (forCell));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:writablePasteboardTypesForCell:atIndex:"), view__handle__, forCell__handle__, charIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (forCell);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="cell">To be added.</param><param name="charIndex">To be added.</param><param name="pboard">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WriteCell (this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:writeCell:atIndex:toPasteboard:type:"), view__handle__, cell__handle__, charIndex, pboard__handle__, nstype);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (pboard);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRange">To be added.</param><param name="newSelectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSRange WillChangeSelection (this INSTextViewDelegate This, NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_NSRange_NSRange (This.Handle, Selector.GetHandle ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:"), textView__handle__, oldSelectedCharRange, newSelectedCharRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRanges">To be added.</param><param name="newSelectedCharRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue[] WillChangeSelectionFromRanges (this INSTextViewDelegate This, NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (oldSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldSelectedCharRanges));
			if (newSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newSelectedCharRanges));
			using var nsa_oldSelectedCharRanges = NSArray.FromNSObjects (oldSelectedCharRanges);
			using var nsa_newSelectedCharRanges = NSArray.FromNSObjects (newSelectedCharRanges);
			NSValue[]? ret;
			ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:"), textView__handle__, nsa_oldSelectedCharRanges.Handle, nsa_newSelectedCharRanges.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="affectedRanges">To be added.</param><param name="replacementStrings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeTextInRanges (this INSTextViewDelegate This, NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (affectedRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (affectedRanges));
			if (replacementStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementStrings));
			using var nsa_affectedRanges = NSArray.FromNSObjects (affectedRanges);
			using var nsa_replacementStrings = NSArray.FromStrings (replacementStrings);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementStrings:"), textView__handle__, nsa_affectedRanges.Handle, nsa_replacementStrings.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="oldTypingAttributes">To be added.</param><param name="newTypingAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary ShouldChangeTypingAttributes (this INSTextViewDelegate This, NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var oldTypingAttributes__handle__ = oldTypingAttributes!.GetNonNullHandle (nameof (oldTypingAttributes));
			var newTypingAttributes__handle__ = newTypingAttributes!.GetNonNullHandle (nameof (newTypingAttributes));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTypingAttributes:toAttributes:"), textView__handle__, oldTypingAttributes__handle__, newTypingAttributes__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (oldTypingAttributes);
			GC.KeepAlive (newTypingAttributes);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSelection (this INSTextViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeSelection:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeTypingAttributes (this INSTextViewDelegate This, NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewDidChangeTypingAttributes:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="textView">To be added.</param><param name="tooltip">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? WillDisplayToolTip (this INSTextViewDelegate This, NSTextView textView, string tooltip, nuint characterIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (tooltip is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tooltip));
			var nstooltip = CFString.CreateNative (tooltip);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:willDisplayToolTip:forCharacterAtIndex:"), textView__handle__, nstooltip, characterIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstooltip);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static string[] GetCompletions (this INSTextViewDelegate This, NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			fixed (nint* index__pointer = &index) {
			using var nsa_words = NSArray.FromStrings (words);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange_ref_IntPtr (This.Handle, Selector.GetHandle ("textView:completions:forPartialWordRange:indexOfSelectedItem:"), textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
			}
		}
		/// <param name="textView">To be added.</param><param name="affectedCharRange">To be added.</param><param name="replacementString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeTextInRange (this INSTextViewDelegate This, NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementString:"), textView__handle__, affectedCharRange, nsreplacementString);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DoCommandBySelector (this INSTextViewDelegate This, NSTextView textView, Selector commandSelector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var commandSelector__handle__ = commandSelector!.GetNonNullHandle (nameof (commandSelector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:doCommandBySelector:"), textView__handle__, commandSelector.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			GC.KeepAlive (commandSelector);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="value">To be added.</param><param name="affectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint ShouldSetSpellingState (this INSTextViewDelegate This, NSTextView textView, nint value, NSRange affectedCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_NSRange (This.Handle, Selector.GetHandle ("textView:shouldSetSpellingState:range:"), textView__handle__, value, affectedCharRange);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMenu MenuForEvent (this INSTextViewDelegate This, NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			NSMenu? ret;
			ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:menu:forEvent:atIndex:"), view__handle__, menu__handle__, theEvent__handle__, charIndex), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="options">To be added.</param><param name="checkingTypes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary WillCheckText (this INSTextViewDelegate This, NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle_UInt64 (This.Handle, Selector.GetHandle ("textView:willCheckTextInRange:options:types:"), view__handle__, range, options__handle__, (UInt64)checkingTypes), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="checkingTypes">To be added.</param><param name="options">To be added.</param><param name="results">To be added.</param><param name="orthography">To be added.</param><param name="wordCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult[] DidCheckText (this INSTextViewDelegate This, NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			using var nsa_results = NSArray.FromNSObjects (results);
			NSTextCheckingResult[]? ret;
			ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:"), view__handle__, range, (UInt64)checkingTypes, options__handle__, nsa_results.Handle, orthography__handle__, wordCount), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			GC.KeepAlive (orthography);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DraggedCell (this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:draggedCell:inRect:event:atIndex:"), view__handle__, cell__handle__, rect, theEvent__handle__, charIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (theEvent);
		}
		/// <param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUndoManager GetUndoManager (this INSTextViewDelegate This, NSTextView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSUndoManager? ret;
			ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("undoManagerForTextView:"), view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="identifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ShouldUpdateTouchBarItemIdentifiers (this INSTextViewDelegate This, NSTextView textView, string[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textView:shouldUpdateTouchBarItemIdentifiers:"), textView__handle__, nsa_identifiers.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[]? GetCandidates (this INSTextViewDelegate This, NSTextView textView, NSRange selectedRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSObject[]? ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:candidatesForSelectedRange:"), textView__handle__, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="candidates">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult[] GetTextCheckingCandidates (this INSTextViewDelegate This, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (candidates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (candidates));
			using var nsa_candidates = NSArray.FromNSObjects (candidates);
			NSTextCheckingResult[]? ret;
			ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:candidates:forSelectedRange:"), textView__handle__, nsa_candidates.Handle, selectedRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSelectCandidates (this INSTextViewDelegate This, NSTextView textView, nuint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("textView:shouldSelectCandidateAtIndex:"), textView__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret != 0;
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WritingToolsWillBegin (this INSTextViewDelegate This, NSTextView textView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewWritingToolsWillBegin:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WritingToolsDidEnd (this INSTextViewDelegate This, NSTextView textView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textViewWritingToolsDidEnd:"), textView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (this INSTextViewDelegate This, NSTextView textView, NSRange enclosingRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSValue[]? ret;
			ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:"), textView__handle__, enclosingRange), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textView);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextViewDelegateWrapper : BaseWrapper, INSTextViewDelegate {
		public NSTextViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextViewDelegateWrapper))]
		static NSTextViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSTextViewDelegate" /> (for the protocol <c>NSTextViewDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSTextViewDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSTextViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextViewDelegate : NSTextDelegate, INSTextViewDelegate {
		/// <summary>Creates a new <see cref="NSTextViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextViewDelegate () : base (NSObjectFlag.Empty)
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
		protected NSTextViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSTextViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textView:clickedOnCell:inRect:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textView:doubleClickedOnCell:inRect:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDoubleClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeTypingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeTypingAttributes (NSNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="checkingTypes">To be added.</param><param name="options">To be added.</param><param name="results">To be added.</param><param name="orthography">To be added.</param><param name="wordCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] DidCheckText (NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:doCommandBySelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoCommandBySelector (NSTextView textView, Selector commandSelector)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textView:draggedCell:inRect:event:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedCell (NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:candidatesForSelectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? GetCandidates (NSTextView textView, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetCompletions (NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="candidates">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:candidates:forSelectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] GetTextCheckingCandidates (NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("undoManagerForTextView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager GetUndoManager (NSTextView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="forCell">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:writablePasteboardTypesForCell:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritablePasteboardTypes (NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (NSTextView textView, NSRange enclosingRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="link">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:clickedOnLink:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LinkClicked (NSTextView textView, NSObject link, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:menu:forEvent:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu MenuForEvent (NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="affectedCharRange">To be added.</param><param name="replacementString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="affectedRanges">To be added.</param><param name="replacementStrings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRanges:replacementStrings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRanges (NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="oldTypingAttributes">To be added.</param><param name="newTypingAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTypingAttributes:toAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ShouldChangeTypingAttributes (NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldSelectCandidateAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectCandidates (NSTextView textView, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="value">To be added.</param><param name="affectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldSetSpellingState:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ShouldSetSpellingState (NSTextView textView, nint value, NSRange affectedCharRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="identifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldUpdateTouchBarItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShouldUpdateTouchBarItemIdentifiers (NSTextView textView, string[] identifiers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRange">To be added.</param><param name="newSelectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange WillChangeSelection (NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRanges">To be added.</param><param name="newSelectedCharRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] WillChangeSelectionFromRanges (NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="options">To be added.</param><param name="checkingTypes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willCheckTextInRange:options:types:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WillCheckText (NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="textView">To be added.</param><param name="tooltip">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willDisplayToolTip:forCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? WillDisplayToolTip (NSTextView textView, string tooltip, nuint characterIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="view">To be added.</param><param name="cell">To be added.</param><param name="charIndex">To be added.</param><param name="pboard">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:writeCell:atIndex:toPasteboard:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteCell (NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textViewWritingToolsDidEnd:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsDidEnd (NSTextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textViewWritingToolsWillBegin:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsWillBegin (NSTextView textView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSTextViewDelegate */
}
