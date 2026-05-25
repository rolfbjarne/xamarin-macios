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
	#pragma warning disable CS1573
	/// <summary>IUITextInput works with the inputting of text and allows the manipulation of features including autocorrection and many other text input features related to document presentation.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITextInput", WrapperType = typeof (UITextInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TextInRange", Selector = "textInRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceText", Selector = "replaceRange:withText:", ParameterType = new Type [] { typeof (UITextRange), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMarkedText", Selector = "setMarkedText:selectedRange:", ParameterType = new Type [] { typeof (string), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnmarkText", Selector = "unmarkText")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTextRange", Selector = "textRangeFromPosition:toPosition:", ReturnType = typeof (UITextRange), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextPosition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPosition", Selector = "positionFromPosition:offset:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (UITextPosition), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPosition", Selector = "positionFromPosition:inDirection:offset:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextLayoutDirection), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ComparePosition", Selector = "comparePosition:toPosition:", ReturnType = typeof (NSComparisonResult), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextPosition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOffsetFromPosition", Selector = "offsetFromPosition:toPosition:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextPosition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPositionWithinRange", Selector = "positionWithinRange:farthestInDirection:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (UITextRange), typeof (UITextLayoutDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCharacterRange", Selector = "characterRangeByExtendingPosition:inDirection:", ReturnType = typeof (UITextRange), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextLayoutDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBaseWritingDirection", Selector = "baseWritingDirectionForPosition:inDirection:", ReturnType = typeof (NSWritingDirection), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextStorageDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBaseWritingDirectionforRange", Selector = "setBaseWritingDirection:forRange:", ParameterType = new Type [] { typeof (NSWritingDirection), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFirstRectForRange", Selector = "firstRectForRange:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCaretRectForPosition", Selector = "caretRectForPosition:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UITextPosition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetClosestPositionToPoint", Selector = "closestPositionToPoint:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetClosestPositionToPoint", Selector = "closestPositionToPoint:withinRange:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (CGPoint), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCharacterRangeAtPoint", Selector = "characterRangeAtPoint:", ReturnType = typeof (UITextRange), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextStyling", Selector = "textStylingAtPosition:inDirection:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextStorageDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPosition", Selector = "positionWithinRange:atCharacterOffset:", ReturnType = typeof (UITextPosition), ParameterType = new Type [] { typeof (UITextRange), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCharacterOffsetOfPosition", Selector = "characterOffsetOfPosition:withinRange:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DictationRecognitionFailed", Selector = "dictationRecognitionFailed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DictationRecordingDidEnd", Selector = "dictationRecordingDidEnd")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertDictationResult", Selector = "insertDictationResult:", ParameterType = new Type [] { typeof (NSArray) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSelectionRects", Selector = "selectionRectsForRange:", ReturnType = typeof (UITextSelectionRect[]), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRange", Selector = "shouldChangeTextInRange:replacementText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextRange), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFrameForDictationResultPlaceholder", Selector = "frameForDictationResultPlaceholder:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertDictationResultPlaceholder", Selector = "insertDictationResultPlaceholder", ReturnType = typeof (NSObject))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveDictationResultPlaceholder", Selector = "removeDictationResultPlaceholder:willInsertResult:", ParameterType = new Type [] { typeof (NSObject), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginFloatingCursor", Selector = "beginFloatingCursorAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateFloatingCursor", Selector = "updateFloatingCursorAtPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndFloatingCursor", Selector = "endFloatingCursor")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCaretTransform", Selector = "caretTransformForPosition:", ReturnType = typeof (CGAffineTransform), ParameterType = new Type [] { typeof (UITextPosition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertText", Selector = "insertText:alternatives:style:", ParameterType = new Type [] { typeof (string), typeof (String[]), typeof (UITextAlternativeStyle) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAttributedMarkedText", Selector = "setAttributedMarkedText:selectedRange:", ParameterType = new Type [] { typeof (NSAttributedString), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertTextPlaceholder", Selector = "insertTextPlaceholderWithSize:", ReturnType = typeof (UITextPlaceholder), ParameterType = new Type [] { typeof (CGSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveTextPlaceholder", Selector = "removeTextPlaceholder:", ParameterType = new Type [] { typeof (UITextPlaceholder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentEditMenu", Selector = "willPresentEditMenuWithAnimator:", ParameterType = new Type [] { typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismissEditMenu", Selector = "willDismissEditMenuWithAnimator:", ParameterType = new Type [] { typeof (IUIEditMenuInteractionAnimating) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEditMenu", Selector = "editMenuForTextRange:suggestedActions:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (UITextRange), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertAdaptiveImageGlyph", Selector = "insertAdaptiveImageGlyph:replacementRange:", ParameterType = new Type [] { typeof (NSAdaptiveImageGlyph), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InsertAttributedText", Selector = "insertAttributedText:", ParameterType = new Type [] { typeof (NSAttributedString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAttributedText", Selector = "attributedTextInRange:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplaceRange", Selector = "replaceRange:withAttributedText:", ParameterType = new Type [] { typeof (UITextRange), typeof (NSAttributedString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentWritingTools", Selector = "willPresentWritingTools")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissWritingTools", Selector = "didDismissWritingTools")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedTextRange", Selector = "selectedTextRange", PropertyType = typeof (UITextRange), GetterSelector = "selectedTextRange", SetterSelector = "setSelectedTextRange:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedTextStyle", Selector = "markedTextStyle", PropertyType = typeof (NSDictionary), GetterSelector = "markedTextStyle", SetterSelector = "setMarkedTextStyle:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BeginningOfDocument", Selector = "beginningOfDocument", PropertyType = typeof (UITextPosition), GetterSelector = "beginningOfDocument", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "EndOfDocument", Selector = "endOfDocument", PropertyType = typeof (UITextPosition), GetterSelector = "endOfDocument", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakInputDelegate", Selector = "inputDelegate", PropertyType = typeof (NSObject), GetterSelector = "inputDelegate", SetterSelector = "setInputDelegate:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakTokenizer", Selector = "tokenizer", PropertyType = typeof (NSObject), GetterSelector = "tokenizer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextInputView", Selector = "textInputView", PropertyType = typeof (UIView), GetterSelector = "textInputView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionAffinity", Selector = "selectionAffinity", PropertyType = typeof (UITextStorageDirection), GetterSelector = "selectionAffinity", SetterSelector = "setSelectionAffinity:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedTextRange", Selector = "markedTextRange", PropertyType = typeof (UITextRange), GetterSelector = "markedTextRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsAdaptiveImageGlyph", Selector = "supportsAdaptiveImageGlyph", PropertyType = typeof (bool), GetterSelector = "supportsAdaptiveImageGlyph", SetterSelector = "setSupportsAdaptiveImageGlyph:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Editable", Selector = "editable", PropertyType = typeof (bool), GetterSelector = "isEditable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UnobscuredContentRect", Selector = "unobscuredContentRect", PropertyType = typeof (CGRect), GetterSelector = "unobscuredContentRect", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextInput : INativeObject, IDisposable, 
		UIKit.IUIKeyInput
		, UIKit.IUITextInputTraits
	{
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets all the text that is specified within a certain range.</summary><returns>Document substring falling within a certain specified range.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("textInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TextInRange (UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets all the text that is specified within a certain range.</summary><returns>Document substring falling within a certain specified range.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _TextInRange (IUITextInput This, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="range">The range of text to be replaced.</param><param name="text">A string defining text replacement within a "range".</param><summary>Replaces document text within a specified range.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("replaceRange:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceText (UITextRange range, string text)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">The range of text to be replaced.</param><param name="text">A string defining text replacement within a "range".</param><summary>Replaces document text within a specified range.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceText (IUITextInput This, UITextRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			CFString.ReleaseNative (nstext);
		}
		/// <param name="markedText">Text that is to be marked.</param><param name="selectedRange">An NSRange object indicating the range of a document's text.</param><summary>Sets the marked text and marks it as the current selection.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (string markedText, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="markedText">Text that is to be marked.</param><param name="selectedRange">An NSRange object indicating the range of a document's text.</param><summary>Sets the marked text and marks it as the current selection.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMarkedText (IUITextInput This, string markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (markedText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markedText));
			var nsmarkedText = CFString.CreateNative (markedText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmarkedText);
		}
		/// <summary>Unmarks all currently marked text within a document</summary><remarks>Subsequent to this method being called, the value of "MarkedTextRange" is set to <see langword="null" />.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Unmarks all currently marked text within a document</summary><remarks>Subsequent to this method being called, the value of "MarkedTextRange" is set to <see langword="null" />.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnmarkText (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("unmarkText"));
			GC.KeepAlive (This);
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets a specified text range.</summary><returns>Defined text range.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("textRangeFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetTextRange (UITextPosition fromPosition, UITextPosition toPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets a specified text range.</summary><returns>Defined text range.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetTextRange (IUITextInput This, UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from the initial position.</summary><returns>The specified character offset.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("positionFromPosition:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, nint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fromPosition">Initial text position.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from the initial position.</summary><returns>The specified character offset.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetPosition (IUITextInput This, UITextPosition fromPosition, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position</param><param name="inDirection">A constant indicating either backward or forward direction for storage.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from an initial position.</summary><returns>The specified character offset.</returns><remarks>This can be either a positive or negative value.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("positionFromPosition:inDirection:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, UITextLayoutDirection inDirection, nint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fromPosition">Initial text position</param><param name="inDirection">A constant indicating either backward or forward direction for storage.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from an initial position.</summary><returns>The specified character offset.</returns><remarks>This can be either a positive or negative value.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetPosition (IUITextInput This, UITextPosition fromPosition, UITextLayoutDirection inDirection, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="first">First text position.</param><param name="second">Second text position.</param><summary>Gets a comparison of one position to another.</summary><returns>An indication as to whether two text positions are identical or if one is prior to the other.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("comparePosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult ComparePosition (UITextPosition first, UITextPosition second)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="first">First text position.</param><param name="second">Second text position.</param><summary>Gets a comparison of one position to another.</summary><returns>An indication as to whether two text positions are identical or if one is prior to the other.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSComparisonResult _ComparePosition (IUITextInput This, UITextPosition first, UITextPosition second)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var first__handle__ = first!.GetNonNullHandle (nameof (first));
			var second__handle__ = second!.GetNonNullHandle (nameof (second));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (first);
			GC.KeepAlive (second);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets the number of visible characters between two defined text positions.</summary><returns>The number of visible characters between the two specified text positions.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("offsetFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromPosition (UITextPosition fromPosition, UITextPosition toPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets the number of visible characters between two defined text positions.</summary><returns>The number of visible characters between the two specified text positions.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetOffsetFromPosition (IUITextInput This, UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><param name="direction">A constant indicating direction for storage.</param><summary>Gets a position within a specified range.</summary><returns>A position within a specified range.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("positionWithinRange:farthestInDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPositionWithinRange (UITextRange range, UITextLayoutDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><param name="direction">A constant indicating direction for storage.</param><summary>Gets a position within a specified range.</summary><returns>A position within a specified range.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetPositionWithinRange (IUITextInput This, UITextRange range, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="byExtendingPosition">A text positioning object identifying a location in a document.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets a character range within the limits of a defined direction.</summary><returns>Gets a range from a given text position to the ultimate extent in a defined direction.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("characterRangeByExtendingPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRange (UITextPosition byExtendingPosition, UITextLayoutDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="byExtendingPosition">A text positioning object identifying a location in a document.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets a character range within the limits of a defined direction.</summary><returns>Gets a range from a given text position to the ultimate extent in a defined direction.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetCharacterRange (IUITextInput This, UITextPosition byExtendingPosition, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var byExtendingPosition__handle__ = byExtendingPosition!.GetNonNullHandle (nameof (byExtendingPosition));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (byExtendingPosition);
			return ret!;
		}
		/// <param name="forPosition">A positioning object that indicates a specified location.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets the base writing direction for a text position.</summary><returns>A text-range object that represents the distance from position to the farthest extent in a given direction.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("baseWritingDirectionForPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWritingDirection GetBaseWritingDirection (UITextPosition forPosition, UITextStorageDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="forPosition">A positioning object that indicates a specified location.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets the base writing direction for a text position.</summary><returns>A text-range object that represents the distance from position to the farthest extent in a given direction.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSWritingDirection _GetBaseWritingDirection (IUITextInput This, UITextPosition forPosition, UITextStorageDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			NSWritingDirection ret;
			ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (This);
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="writingDirection">Constant indicating layout direction.</param><param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Sets a base direction for writing in the specified range of text.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setBaseWritingDirection:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBaseWritingDirectionforRange (NSWritingDirection writingDirection, UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="writingDirection">Constant indicating layout direction.</param><param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Sets a base direction for writing in the specified range of text.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBaseWritingDirectionforRange (IUITextInput This, NSWritingDirection writingDirection, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
		}
		/// <param name="range">	
		/// A UITextRange object indicating the range of a document's text.</param><summary>Gets the first rectangle enclosing a specified range of document text.</summary><returns>The first rectangle enclosing a specified range.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("firstRectForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFirstRectForRange (UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">	
		/// A UITextRange object indicating the range of a document's text.</param><summary>Gets the first rectangle enclosing a specified range of document text.</summary><returns>The first rectangle enclosing a specified range.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFirstRectForRange (IUITextInput This, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="position">A positioning object that indicates a specified location.</param><summary>A rectangle used for drawing a caret at a given insertion point.</summary><returns>A rectangle defining an area for drawing a caret.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("caretRectForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCaretRectForPosition (UITextPosition? position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="position">A positioning object that indicates a specified location.</param><summary>A rectangle used for drawing a caret at a given insertion point.</summary><returns>A rectangle defining an area for drawing a caret.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetCaretRectForPosition (IUITextInput This, UITextPosition? position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (position);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the closest position in a document that exists to a given point.</summary><returns>The closest position to the point. </returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("closestPositionToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the closest position in a document that exists to a given point.</summary><returns>The closest position to the point. </returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetClosestPositionToPoint (IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="point">To be added.</param><param name="withinRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("closestPositionToPoint:withinRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point, UITextRange withinRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">To be added.</param><param name="withinRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetClosestPositionToPoint (IUITextInput This, CGPoint point, UITextRange withinRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the character or a range of characters in a document that exists at a given point.</summary><returns>Gets the point in a view where the document text is being drawn.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("characterRangeAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRangeAtPoint (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the character or a range of characters in a document that exists at a given point.</summary><returns>Gets the point in a view where the document text is being drawn.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetCharacterRangeAtPoint (IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="atPosition">To be added.</param><param name="inDirection">To be added.</param><summary>Returns a dictionary of style properties for text at the <paramref name="atPosition" /> position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("textStylingAtPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetTextStyling (UITextPosition atPosition, UITextStorageDirection inDirection)
		{
			return _GetTextStyling (this, atPosition, inDirection);
		}
		/// <param name="atPosition">To be added.</param><param name="inDirection">To be added.</param><summary>Returns a dictionary of style properties for text at the <paramref name="atPosition" /> position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetTextStyling (IUITextInput This, UITextPosition atPosition, UITextStorageDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var atPosition__handle__ = atPosition!.GetNonNullHandle (nameof (atPosition));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (atPosition);
			return ret!;
		}
		/// <param name="withinRange">To be added.</param><param name="atCharacterOffset">To be added.</param><summary>Calculates and returns the absolute position in the document that is <paramref name="atCharacterOffset" /> characters into <paramref name="withinRange" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("positionWithinRange:atCharacterOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextRange withinRange, nint atCharacterOffset)
		{
			return _GetPosition (this, withinRange, atCharacterOffset);
		}
		/// <param name="withinRange">To be added.</param><param name="atCharacterOffset">To be added.</param><summary>Calculates and returns the absolute position in the document that is <paramref name="atCharacterOffset" /> characters into <paramref name="withinRange" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetPosition (IUITextInput This, UITextRange withinRange, nint atCharacterOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="range">To be added.</param><summary>Calculates and returns the offset into <paramref name="range" /> of the character that is in <paramref name="position" /> in the document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("characterOffsetOfPosition:withinRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetCharacterOffsetOfPosition (UITextPosition position, UITextRange range)
		{
			return _GetCharacterOffsetOfPosition (this, position, range);
		}
		/// <param name="position">To be added.</param><param name="range">To be added.</param><summary>Calculates and returns the offset into <paramref name="range" /> of the character that is in <paramref name="position" /> in the document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetCharacterOffsetOfPosition (IUITextInput This, UITextPosition position, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (position);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <summary>The recognition of dictation failed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dictationRecognitionFailed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecognitionFailed ()
		{
			_DictationRecognitionFailed (this);
		}
		/// <summary>The recognition of dictation failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DictationRecognitionFailed (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dictationRecognitionFailed"));
			GC.KeepAlive (This);
		}
		/// <summary>The recording of dictation ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dictationRecordingDidEnd")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecordingDidEnd ()
		{
			_DictationRecordingDidEnd (this);
		}
		/// <summary>The recording of dictation ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DictationRecordingDidEnd (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dictationRecordingDidEnd"));
			GC.KeepAlive (This);
		}
		/// <param name="dictationResult">To be added.</param><summary>Inserts a dictation result at the current position.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("insertDictationResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDictationResult (NSArray dictationResult)
		{
			_InsertDictationResult (this, dictationResult);
		}
		/// <param name="dictationResult">To be added.</param><summary>Inserts a dictation result at the current position.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertDictationResult (IUITextInput This, NSArray dictationResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dictationResult__handle__ = dictationResult!.GetNonNullHandle (nameof (dictationResult));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (dictationResult);
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets an array of selection rects that corresponds to a text range.</summary><returns>An array of selection rects.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("selectionRectsForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextSelectionRect[] GetSelectionRects (UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets an array of selection rects that corresponds to a text range.</summary><returns>An array of selection rects.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextSelectionRect[] _GetSelectionRects (IUITextInput This, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextSelectionRect[]? ret;
			ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="inRange">To be added.</param><param name="replacementText">To be added.</param><summary>Asks whether the text in <paramref name="inRange" /> should be replaced with <paramref name="replacementText" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("shouldChangeTextInRange:replacementText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (UITextRange inRange, string replacementText)
		{
			return _ShouldChangeTextInRange (this, inRange, replacementText);
		}
		/// <param name="inRange">To be added.</param><param name="replacementText">To be added.</param><summary>Asks whether the text in <paramref name="inRange" /> should be replaced with <paramref name="replacementText" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeTextInRange (IUITextInput This, UITextRange inRange, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var inRange__handle__ = inRange!.GetNonNullHandle (nameof (inRange));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (inRange);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		/// <param name="placeholder">To be added.</param><summary>Returns the rectangle in which to display the animated dictation result placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("frameForDictationResultPlaceholder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForDictationResultPlaceholder (NSObject placeholder)
		{
			return _GetFrameForDictationResultPlaceholder (this, placeholder);
		}
		/// <param name="placeholder">To be added.</param><summary>Returns the rectangle in which to display the animated dictation result placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetFrameForDictationResultPlaceholder (IUITextInput This, NSObject placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <summary>Returns the placeholder object to use before dictation results are finished being generated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("insertDictationResultPlaceholder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject InsertDictationResultPlaceholder ()
		{
			return _InsertDictationResultPlaceholder (this);
		}
		/// <summary>Returns the placeholder object to use before dictation results are finished being generated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _InsertDictationResultPlaceholder (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="placeholder">To be added.</param><param name="willInsertResult">To be added.</param><summary>The <paramref name="placeholder" /> is no longer needed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("removeDictationResultPlaceholder:willInsertResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDictationResultPlaceholder (NSObject placeholder, bool willInsertResult)
		{
			_RemoveDictationResultPlaceholder (this, placeholder, willInsertResult);
		}
		/// <param name="placeholder">To be added.</param><param name="willInsertResult">To be added.</param><summary>The <paramref name="placeholder" /> is no longer needed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveDictationResultPlaceholder (IUITextInput This, NSObject placeholder, bool willInsertResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (placeholder);
		}
		/// <param name="point">To be added.</param><summary>Begins displaying the floating cursor at the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("beginFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginFloatingCursor (CGPoint point)
		{
			_BeginFloatingCursor (this, point);
		}
		/// <param name="point">To be added.</param><summary>Begins displaying the floating cursor at the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginFloatingCursor (IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
			GC.KeepAlive (This);
		}
		/// <param name="point">To be added.</param><summary>Moves the floating curor to the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("updateFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFloatingCursor (CGPoint point)
		{
			_UpdateFloatingCursor (this, point);
		}
		/// <param name="point">To be added.</param><summary>Moves the floating curor to the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateFloatingCursor (IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
			GC.KeepAlive (This);
		}
		/// <summary>Ends display of the floating cursor.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("endFloatingCursor")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndFloatingCursor ()
		{
			_EndFloatingCursor (this);
		}
		/// <summary>Ends display of the floating cursor.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndFloatingCursor (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endFloatingCursor"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("caretTransformForPosition:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetCaretTransform (UITextPosition forPosition)
		{
			return _GetCaretTransform (this, forPosition);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGAffineTransform _GetCaretTransform (IUITextInput This, UITextPosition forPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("insertText:alternatives:style:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (string text, string[] alternatives, UITextAlternativeStyle style)
		{
			_InsertText (this, text, alternatives, style);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertText (IUITextInput This, string text, string[] alternatives, UITextAlternativeStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (alternatives is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternatives));
			var nstext = CFString.CreateNative (text);
			using var nsa_alternatives = NSArray.FromStrings (alternatives);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstext);
		}
		[global::Foundation.OptionalMember]
		[Export ("setAttributedMarkedText:selectedRange:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributedMarkedText (NSAttributedString? markedText, NSRange selectedRange)
		{
			_SetAttributedMarkedText (this, markedText, selectedRange);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttributedMarkedText (IUITextInput This, NSAttributedString? markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var markedText__handle__ = markedText.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			GC.KeepAlive (This);
			GC.KeepAlive (markedText);
		}
		[global::Foundation.OptionalMember]
		[Export ("insertTextPlaceholderWithSize:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPlaceholder InsertTextPlaceholder (CGSize size)
		{
			return _InsertTextPlaceholder (this, size);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPlaceholder _InsertTextPlaceholder (IUITextInput This, CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPlaceholder ret;
			ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("removeTextPlaceholder:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextPlaceholder (UITextPlaceholder textPlaceholder)
		{
			_RemoveTextPlaceholder (this, textPlaceholder);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveTextPlaceholder (IUITextInput This, UITextPlaceholder textPlaceholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPlaceholder__handle__ = textPlaceholder!.GetNonNullHandle (nameof (textPlaceholder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPlaceholder);
		}
		[global::Foundation.OptionalMember]
		[Export ("willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			_WillPresentEditMenu (this, animator);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentEditMenu (IUITextInput This, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			_WillDismissEditMenu (this, animator);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismissEditMenu (IUITextInput This, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
		}
		[global::Foundation.OptionalMember]
		[Export ("editMenuForTextRange:suggestedActions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextRange textRange, UIMenuElement[] suggestedActions)
		{
			return _GetEditMenu (this, textRange, suggestedActions);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetEditMenu (IUITextInput This, UITextRange textRange, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textRange);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, UITextRange replacementRange)
		{
			_InsertAdaptiveImageGlyph (this, adaptiveImageGlyph, replacementRange);
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertAdaptiveImageGlyph (IUITextInput This, NSAdaptiveImageGlyph adaptiveImageGlyph, UITextRange replacementRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var replacementRange__handle__ = replacementRange!.GetNonNullHandle (nameof (replacementRange));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (replacementRange);
		}
		[global::Foundation.OptionalMember]
		[Export ("insertAttributedText:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAttributedText (NSAttributedString text)
		{
			_InsertAttributedText (this, text);
		}
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertAttributedText (IUITextInput This, NSAttributedString text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertAttributedText:"), text__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (text);
		}
		[global::Foundation.OptionalMember]
		[Export ("attributedTextInRange:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedText (UITextRange range)
		{
			return _GetAttributedText (this, range);
		}
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _GetAttributedText (IUITextInput This, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("replaceRange:withAttributedText:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceRange (UITextRange range, NSAttributedString attributedText)
		{
			_ReplaceRange (this, range, attributedText);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceRange (IUITextInput This, UITextRange range, NSAttributedString attributedText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var attributedText__handle__ = attributedText!.GetNonNullHandle (nameof (attributedText));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (attributedText);
		}
		[global::Foundation.OptionalMember]
		[Export ("willPresentWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentWritingTools ()
		{
			_WillPresentWritingTools (this);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresentWritingTools (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willPresentWritingTools"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("didDismissWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissWritingTools ()
		{
			_DidDismissWritingTools (this);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissWritingTools (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didDismissWritingTools"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("BeginFloatingCursor(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("BeginningOfDocument")]
		[DynamicDependencyAttribute ("ComparePosition(UIKit.UITextPosition,UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("DictationRecognitionFailed()")]
		[DynamicDependencyAttribute ("DictationRecordingDidEnd()")]
		[DynamicDependencyAttribute ("DidDismissWritingTools()")]
		[DynamicDependencyAttribute ("Editable")]
		[DynamicDependencyAttribute ("EndFloatingCursor()")]
		[DynamicDependencyAttribute ("EndOfDocument")]
		[DynamicDependencyAttribute ("GetAttributedText(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetBaseWritingDirection(UIKit.UITextPosition,UIKit.UITextStorageDirection)")]
		[DynamicDependencyAttribute ("GetCaretRectForPosition(UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetCaretTransform(UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetCharacterOffsetOfPosition(UIKit.UITextPosition,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetCharacterRange(UIKit.UITextPosition,UIKit.UITextLayoutDirection)")]
		[DynamicDependencyAttribute ("GetCharacterRangeAtPoint(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetClosestPositionToPoint(CoreGraphics.CGPoint,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetClosestPositionToPoint(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetEditMenu(UIKit.UITextRange,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("GetFirstRectForRange(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetFrameForDictationResultPlaceholder(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetOffsetFromPosition(UIKit.UITextPosition,UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetPosition(UIKit.UITextPosition,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetPosition(UIKit.UITextPosition,UIKit.UITextLayoutDirection,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetPosition(UIKit.UITextRange,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetPositionWithinRange(UIKit.UITextRange,UIKit.UITextLayoutDirection)")]
		[DynamicDependencyAttribute ("GetSelectionRects(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetTextRange(UIKit.UITextPosition,UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetTextStyling(UIKit.UITextPosition,UIKit.UITextStorageDirection)")]
		[DynamicDependencyAttribute ("InsertAdaptiveImageGlyph(UIKit.NSAdaptiveImageGlyph,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("InsertAttributedText(Foundation.NSAttributedString)")]
		[DynamicDependencyAttribute ("InsertDictationResult(Foundation.NSArray)")]
		[DynamicDependencyAttribute ("InsertDictationResultPlaceholder()")]
		[DynamicDependencyAttribute ("InsertText(System.String,System.String[],UIKit.UITextAlternativeStyle)")]
		[DynamicDependencyAttribute ("InsertTextPlaceholder(CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("MarkedTextRange")]
		[DynamicDependencyAttribute ("MarkedTextStyle")]
		[DynamicDependencyAttribute ("RemoveDictationResultPlaceholder(Foundation.NSObject,System.Boolean)")]
		[DynamicDependencyAttribute ("RemoveTextPlaceholder(UIKit.UITextPlaceholder)")]
		[DynamicDependencyAttribute ("ReplaceRange(UIKit.UITextRange,Foundation.NSAttributedString)")]
		[DynamicDependencyAttribute ("ReplaceText(UIKit.UITextRange,System.String)")]
		[DynamicDependencyAttribute ("SelectedTextRange")]
		[DynamicDependencyAttribute ("SelectionAffinity")]
		[DynamicDependencyAttribute ("SetAttributedMarkedText(Foundation.NSAttributedString,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetBaseWritingDirectionforRange(Foundation.NSWritingDirection,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("SetMarkedText(System.String,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("ShouldChangeTextInRange(UIKit.UITextRange,System.String)")]
		[DynamicDependencyAttribute ("SupportsAdaptiveImageGlyph")]
		[DynamicDependencyAttribute ("TextInputView")]
		[DynamicDependencyAttribute ("TextInRange(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("UnmarkText()")]
		[DynamicDependencyAttribute ("UnobscuredContentRect")]
		[DynamicDependencyAttribute ("UpdateFloatingCursor(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("WeakInputDelegate")]
		[DynamicDependencyAttribute ("WeakTokenizer")]
		[DynamicDependencyAttribute ("WillDismissEditMenu(UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPresentEditMenu(UIKit.IUIEditMenuInteractionAnimating)")]
		[DynamicDependencyAttribute ("WillPresentWritingTools()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextInput ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The range of a document's selected text.</summary><value>If there is no current specified selection, then it is set to <see langword="null" />.</value><remarks>If the specified range has length, it specifies currently selected text; if zero length, it specifies only the caret at the insertion point.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			get {
				return _GetSelectedTextRange (this);
			}
			[Export ("setSelectedTextRange:")]
			set {
				_SetSelectedTextRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetSelectedTextRange (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectedTextRange (IUITextInput This, UITextRange? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Attribute dictionary describing how text should be drawn.</summary><value>Strings indicating style definition.</value><remarks>This is marked to indicate the necessity for unique visual treatment in display.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary? MarkedTextStyle {
			[Export ("markedTextStyle", ArgumentSemantic.Copy)]
			get {
				return _GetMarkedTextStyle (this);
			}
			[Export ("setMarkedTextStyle:", ArgumentSemantic.Copy)]
			set {
				_SetMarkedTextStyle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetMarkedTextStyle (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("markedTextStyle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMarkedTextStyle (IUITextInput This, NSDictionary? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the beginning of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextPosition BeginningOfDocument {
			[Export ("beginningOfDocument")]
			get {
				return _GetBeginningOfDocument (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetBeginningOfDocument (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("beginningOfDocument")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the end of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextPosition EndOfDocument {
			[Export ("endOfDocument")]
			get {
				return _GetEndOfDocument (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetEndOfDocument (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("endOfDocument")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Indicates a weak input delegate.</summary><value>Automatically assigned at runtime.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? WeakInputDelegate {
			[Export ("inputDelegate", ArgumentSemantic.Assign)]
			get {
				return _GetWeakInputDelegate (this);
			}
			[Export ("setInputDelegate:", ArgumentSemantic.Assign)]
			set {
				_SetWeakInputDelegate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetWeakInputDelegate (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputDelegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWeakInputDelegate (IUITextInput This, NSObject? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputDelegate:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Indicates a weak tokenizer.</summary><value>Standard units of granularity including characters, words, lines, and paragraphs.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject WeakTokenizer {
			[Export ("tokenizer")]
			get {
				return _GetWeakTokenizer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetWeakTokenizer (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("tokenizer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the input view that provides the coordinate system for geometric operations within the text input.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UIView TextInputView {
			[Export ("textInputView")]
			get {
				return _GetTextInputView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIView _GetTextInputView (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textInputView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>A value that controls whether the cursor is displayed at the start of the last line or end of the second-to-last line of a multiline selection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UITextStorageDirection SelectionAffinity {
			[Export ("selectionAffinity")]
			get {
				return _GetSelectionAffinity (this);
			}
			[Export ("setSelectionAffinity:")]
			set {
				_SetSelectionAffinity (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextStorageDirection _GetSelectionAffinity (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextStorageDirection ret;
			ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("selectionAffinity"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectionAffinity (IUITextInput This, UITextStorageDirection value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>The currently marked range of text in a given document.</summary><value>If there is no text marked, the value is <see langword="null" />; all else  is provisionally inserted requiring user confirmation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextRange MarkedTextRange {
			[Export ("markedTextRange")]
			get {
				return _GetMarkedTextRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetMarkedTextRange (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("markedTextRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			get {
				return _GetSupportsAdaptiveImageGlyph (this);
			}
			[Export ("setSupportsAdaptiveImageGlyph:")]
			set {
				_SetSupportsAdaptiveImageGlyph (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsAdaptiveImageGlyph (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSupportsAdaptiveImageGlyph (IUITextInput This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[global::Foundation.OptionalMember]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				return _GetEditable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEditable (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEditable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[global::Foundation.OptionalMember]
		public virtual CGRect UnobscuredContentRect {
			[Export ("unobscuredContentRect")]
			get {
				return _GetUnobscuredContentRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetUnobscuredContentRect (IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("unobscuredContentRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("unobscuredContentRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextInput" /> interface to support all the methods from the UITextInput protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextInput" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextInput protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextInput_Extensions {
		/// <param name="atPosition">To be added.</param><param name="inDirection">To be added.</param><summary>Returns a dictionary of style properties for text at the <paramref name="atPosition" /> position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetTextStyling (this IUITextInput This, UITextPosition atPosition, UITextStorageDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var atPosition__handle__ = atPosition!.GetNonNullHandle (nameof (atPosition));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (atPosition);
			return ret!;
		}
		/// <param name="withinRange">To be added.</param><param name="atCharacterOffset">To be added.</param><summary>Calculates and returns the absolute position in the document that is <paramref name="atCharacterOffset" /> characters into <paramref name="withinRange" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextPosition GetPosition (this IUITextInput This, UITextRange withinRange, nint atCharacterOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="range">To be added.</param><summary>Calculates and returns the offset into <paramref name="range" /> of the character that is in <paramref name="position" /> in the document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetCharacterOffsetOfPosition (this IUITextInput This, UITextPosition position, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (position);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <summary>The recognition of dictation failed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DictationRecognitionFailed (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dictationRecognitionFailed"));
			GC.KeepAlive (This);
		}
		/// <summary>The recording of dictation ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DictationRecordingDidEnd (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dictationRecordingDidEnd"));
			GC.KeepAlive (This);
		}
		/// <param name="dictationResult">To be added.</param><summary>Inserts a dictation result at the current position.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertDictationResult (this IUITextInput This, NSArray dictationResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dictationResult__handle__ = dictationResult!.GetNonNullHandle (nameof (dictationResult));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (dictationResult);
		}
		/// <param name="inRange">To be added.</param><param name="replacementText">To be added.</param><summary>Asks whether the text in <paramref name="inRange" /> should be replaced with <paramref name="replacementText" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeTextInRange (this IUITextInput This, UITextRange inRange, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var inRange__handle__ = inRange!.GetNonNullHandle (nameof (inRange));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (inRange);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		/// <param name="placeholder">To be added.</param><summary>Returns the rectangle in which to display the animated dictation result placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetFrameForDictationResultPlaceholder (this IUITextInput This, NSObject placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <summary>Returns the placeholder object to use before dictation results are finished being generated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject InsertDictationResultPlaceholder (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="placeholder">To be added.</param><param name="willInsertResult">To be added.</param><summary>The <paramref name="placeholder" /> is no longer needed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveDictationResultPlaceholder (this IUITextInput This, NSObject placeholder, bool willInsertResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (placeholder);
		}
		/// <param name="point">To be added.</param><summary>Begins displaying the floating cursor at the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginFloatingCursor (this IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
			GC.KeepAlive (This);
		}
		/// <param name="point">To be added.</param><summary>Moves the floating curor to the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateFloatingCursor (this IUITextInput This, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
			GC.KeepAlive (This);
		}
		/// <summary>Ends display of the floating cursor.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndFloatingCursor (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endFloatingCursor"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGAffineTransform GetCaretTransform (this IUITextInput This, UITextPosition forPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			CGAffineTransform ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertText (this IUITextInput This, string text, string[] alternatives, UITextAlternativeStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (alternatives is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternatives));
			var nstext = CFString.CreateNative (text);
			using var nsa_alternatives = NSArray.FromStrings (alternatives);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstext);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAttributedMarkedText (this IUITextInput This, NSAttributedString? markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var markedText__handle__ = markedText.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			GC.KeepAlive (This);
			GC.KeepAlive (markedText);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextPlaceholder InsertTextPlaceholder (this IUITextInput This, CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPlaceholder ret;
			ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTextPlaceholder (this IUITextInput This, UITextPlaceholder textPlaceholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPlaceholder__handle__ = textPlaceholder!.GetNonNullHandle (nameof (textPlaceholder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textPlaceholder);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentEditMenu (this IUITextInput This, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismissEditMenu (this IUITextInput This, IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIMenu? GetEditMenu (this IUITextInput This, UITextRange textRange, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (textRange);
			return ret!;
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertAdaptiveImageGlyph (this IUITextInput This, NSAdaptiveImageGlyph adaptiveImageGlyph, UITextRange replacementRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var replacementRange__handle__ = replacementRange!.GetNonNullHandle (nameof (replacementRange));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (replacementRange);
		}
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InsertAttributedText (this IUITextInput This, NSAttributedString text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertAttributedText:"), text__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (text);
		}
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString GetAttributedText (this IUITextInput This, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReplaceRange (this IUITextInput This, UITextRange range, NSAttributedString attributedText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var attributedText__handle__ = attributedText!.GetNonNullHandle (nameof (attributedText));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (attributedText);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresentWritingTools (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willPresentWritingTools"));
			GC.KeepAlive (This);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissWritingTools (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didDismissWritingTools"));
			GC.KeepAlive (This);
		}
		/// <summary>Returns the input view that provides the coordinate system for geometric operations within the text input.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIView GetTextInputView (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIView ret;
			ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textInputView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>A value that controls whether the cursor is displayed at the start of the last line or end of the second-to-last line of a multiline selection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextStorageDirection GetSelectionAffinity (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextStorageDirection ret;
			ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("selectionAffinity"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>A value that controls whether the cursor is displayed at the start of the last line or end of the second-to-last line of a multiline selection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSelectionAffinity (this IUITextInput This, UITextStorageDirection value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsAdaptiveImageGlyph (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSupportsAdaptiveImageGlyph (this IUITextInput This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEditable (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEditable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetUnobscuredContentRect (this IUITextInput This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("unobscuredContentRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("unobscuredContentRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextInputWrapper : BaseWrapper, IUITextInput {
		public UITextInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextInputWrapper))]
		static UITextInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets all the text that is specified within a certain range.</summary><returns>Document substring falling within a certain specified range.</returns><remarks>To be added.</remarks>
		[Export ("textInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string TextInRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="range">The range of text to be replaced.</param><param name="text">A string defining text replacement within a "range".</param><summary>Replaces document text within a specified range.</summary><remarks>To be added.</remarks>
		[Export ("replaceRange:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceText (UITextRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
			GC.KeepAlive (range);
			CFString.ReleaseNative (nstext);
		}
		/// <param name="markedText">Text that is to be marked.</param><param name="selectedRange">An NSRange object indicating the range of a document's text.</param><summary>Sets the marked text and marks it as the current selection.</summary><remarks>To be added.</remarks>
		[Export ("setMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMarkedText (string markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (markedText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markedText));
			var nsmarkedText = CFString.CreateNative (markedText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			CFString.ReleaseNative (nsmarkedText);
		}
		/// <summary>Unmarks all currently marked text within a document</summary><remarks>Subsequent to this method being called, the value of "MarkedTextRange" is set to <see langword="null" />.</remarks>
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UnmarkText ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unmarkText"));
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets a specified text range.</summary><returns>Defined text range.</returns><remarks>To be added.</remarks>
		[Export ("textRangeFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange GetTextRange (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from the initial position.</summary><returns>The specified character offset.</returns><remarks>To be added.</remarks>
		[Export ("positionFromPosition:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetPosition (UITextPosition fromPosition, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position</param><param name="inDirection">A constant indicating either backward or forward direction for storage.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from an initial position.</summary><returns>The specified character offset.</returns><remarks>This can be either a positive or negative value.</remarks>
		[Export ("positionFromPosition:inDirection:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetPosition (UITextPosition fromPosition, UITextLayoutDirection inDirection, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="first">First text position.</param><param name="second">Second text position.</param><summary>Gets a comparison of one position to another.</summary><returns>An indication as to whether two text positions are identical or if one is prior to the other.</returns><remarks>To be added.</remarks>
		[Export ("comparePosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSComparisonResult ComparePosition (UITextPosition first, UITextPosition second)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var first__handle__ = first!.GetNonNullHandle (nameof (first));
			var second__handle__ = second!.GetNonNullHandle (nameof (second));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
			GC.KeepAlive (first);
			GC.KeepAlive (second);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets the number of visible characters between two defined text positions.</summary><returns>The number of visible characters between the two specified text positions.</returns><remarks>To be added.</remarks>
		[Export ("offsetFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetOffsetFromPosition (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><param name="direction">A constant indicating direction for storage.</param><summary>Gets a position within a specified range.</summary><returns>A position within a specified range.</returns><remarks>To be added.</remarks>
		[Export ("positionWithinRange:farthestInDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetPositionWithinRange (UITextRange range, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="byExtendingPosition">A text positioning object identifying a location in a document.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets a character range within the limits of a defined direction.</summary><returns>Gets a range from a given text position to the ultimate extent in a defined direction.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeByExtendingPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange GetCharacterRange (UITextPosition byExtendingPosition, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var byExtendingPosition__handle__ = byExtendingPosition!.GetNonNullHandle (nameof (byExtendingPosition));
			UITextRange? ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (byExtendingPosition);
			return ret!;
		}
		/// <param name="forPosition">A positioning object that indicates a specified location.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets the base writing direction for a text position.</summary><returns>A text-range object that represents the distance from position to the farthest extent in a given direction.</returns><remarks>To be added.</remarks>
		[Export ("baseWritingDirectionForPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSWritingDirection GetBaseWritingDirection (UITextPosition forPosition, UITextStorageDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			NSWritingDirection ret;
			ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="writingDirection">Constant indicating layout direction.</param><param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Sets a base direction for writing in the specified range of text.</summary><remarks>To be added.</remarks>
		[Export ("setBaseWritingDirection:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBaseWritingDirectionforRange (NSWritingDirection writingDirection, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			GC.KeepAlive (range);
		}
		/// <param name="range">	
		/// A UITextRange object indicating the range of a document's text.</param><summary>Gets the first rectangle enclosing a specified range of document text.</summary><returns>The first rectangle enclosing a specified range.</returns><remarks>To be added.</remarks>
		[Export ("firstRectForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetFirstRectForRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="position">A positioning object that indicates a specified location.</param><summary>A rectangle used for drawing a caret at a given insertion point.</summary><returns>A rectangle defining an area for drawing a caret.</returns><remarks>To be added.</remarks>
		[Export ("caretRectForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetCaretRectForPosition (UITextPosition? position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
			}
			GC.KeepAlive (position);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the closest position in a document that exists to a given point.</summary><returns>The closest position to the point. </returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetClosestPositionToPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
			return ret;
		}
		/// <param name="point">To be added.</param><param name="withinRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:withinRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition GetClosestPositionToPoint (CGPoint point, UITextRange withinRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the character or a range of characters in a document that exists at a given point.</summary><returns>Gets the point in a view where the document text is being drawn.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange GetCharacterRangeAtPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
			return ret;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets an array of selection rects that corresponds to a text range.</summary><returns>An array of selection rects.</returns><remarks>To be added.</remarks>
		[Export ("selectionRectsForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextSelectionRect[] GetSelectionRects (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextSelectionRect[]? ret;
			ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="text">To be added.</param><summary>Inserts text at the cursor.</summary><remarks>To be added.</remarks>
		[Export ("insertText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertText (string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertText:"), nstext);
			CFString.ReleaseNative (nstext);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("deleteBackward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeleteBackward ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deleteBackward"));
		}
		/// <summary>The range of a document's selected text.</summary><value>If there is no current specified selection, then it is set to <see langword="null" />.</value><remarks>If the specified range has length, it specifies currently selected text; if zero length, it specifies only the caret at the insertion point.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				return ret;
			}
			[Export ("setSelectedTextRange:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Attribute dictionary describing how text should be drawn.</summary><value>Strings indicating style definition.</value><remarks>This is marked to indicate the necessity for unique visual treatment in display.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary? MarkedTextStyle {
			[Export ("markedTextStyle", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextStyle")), false)!;
				return ret;
			}
			[Export ("setMarkedTextStyle:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the beginning of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition BeginningOfDocument {
			[Export ("beginningOfDocument")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition ret;
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("beginningOfDocument")), false)!;
				return ret;
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the end of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition EndOfDocument {
			[Export ("endOfDocument")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition ret;
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("endOfDocument")), false)!;
				return ret;
			}
		}
		/// <summary>Indicates a weak input delegate.</summary><value>Automatically assigned at runtime.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? WeakInputDelegate {
			[Export ("inputDelegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputDelegate")), false)!;
				return ret;
			}
			[Export ("setInputDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Indicates a weak tokenizer.</summary><value>Standard units of granularity including characters, words, lines, and paragraphs.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject WeakTokenizer {
			[Export ("tokenizer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tokenizer")), false)!;
				return ret;
			}
		}
		/// <summary>The currently marked range of text in a given document.</summary><value>If there is no text marked, the value is <see langword="null" />; all else  is provisionally inserted requiring user confirmation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange MarkedTextRange {
			[Export ("markedTextRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextRange")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a value that tells whether the key input has text in it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool HasText {
			[Export ("hasText")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasText"));
				return ret != 0;
			}
		}
	}
}
