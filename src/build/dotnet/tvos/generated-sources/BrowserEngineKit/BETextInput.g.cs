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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BETextInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BETextInput", WrapperType = typeof (BETextInputWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CanPerformAction", Selector = "canPerformAction:withSender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleKeyEntry", Selector = "handleKeyEntry:withCompletionHandler:", ParameterType = new Type [] { typeof (BrowserEngineKit.BEKeyEntry), typeof (BrowserEngineKit.BETextInputHandleKeyEntryCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDBETextInputHandleKeyEntryCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShiftKeyStateChanged", Selector = "shiftKeyStateChangedFromState:toState:", ParameterType = new Type [] { typeof (BrowserEngineKit.BEKeyModifierFlags), typeof (BrowserEngineKit.BEKeyModifierFlags) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetText", Selector = "textInRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetOffset", Selector = "offsetFromPosition:toPosition:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextPosition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBaseWritingDirection", Selector = "setBaseWritingDirection:forRange:", ParameterType = new Type [] { typeof (NSWritingDirection), typeof (UITextRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Delete", Selector = "deleteInDirection:toGranularity:", ParameterType = new Type [] { typeof (UITextStorageDirection), typeof (UITextGranularity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TransposeCharactersAroundSelection", Selector = "transposeCharactersAroundSelection")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceText", Selector = "replaceText:withText:options:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (BrowserEngineKit.BETextReplacementOptions), typeof (BrowserEngineKit.BETextInputReplaceTextCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDBETextInputReplaceTextCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestTextContextForAutocorrection", Selector = "requestTextContextForAutocorrectionWithCompletionHandler:", ParameterType = new Type [] { typeof (BrowserEngineKit.BETextInputRequestTextContextForAutocorrectionCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextContextForAutocorrectionCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestTextRects", Selector = "requestTextRectsForString:withCompletionHandler:", ParameterType = new Type [] { typeof (string), typeof (BrowserEngineKit.BETextInputRequestTextRectsCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextRectsCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTextStyling", Selector = "textStylingAtPosition:inDirection:", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), ParameterType = new Type [] { typeof (UITextPosition), typeof (UITextStorageDirection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceSelectedText", Selector = "replaceSelectedText:withText:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateCurrentSelection", Selector = "updateCurrentSelectionTo:fromGesture:inState:", ParameterType = new Type [] { typeof (CGPoint), typeof (BrowserEngineKit.BEGestureType), typeof (UIGestureRecognizerState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSelection", Selector = "setSelectionFromPoint:toPoint:gesture:state:", ParameterType = new Type [] { typeof (CGPoint), typeof (CGPoint), typeof (BrowserEngineKit.BEGestureType), typeof (UIGestureRecognizerState) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdjustSelectionBoundary", Selector = "adjustSelectionBoundaryToPoint:touchPhase:baseIsStart:flags:", ParameterType = new Type [] { typeof (CGPoint), typeof (BrowserEngineKit.BESelectionTouchPhase), typeof (bool), typeof (BrowserEngineKit.BESelectionFlags) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldTextInteractionGestureBeginAtPoint", Selector = "textInteractionGesture:shouldBeginAtPoint:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (BrowserEngineKit.BEGestureType), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCaretRect", Selector = "caretRectForPosition:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (UITextPosition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSelectionRects", Selector = "selectionRectsForRange:", ReturnType = typeof (UITextSelectionRect[]), ParameterType = new Type [] { typeof (UITextRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectWordForReplacement", Selector = "selectWordForReplacement")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateSelection", Selector = "updateSelectionWithExtentPoint:boundary:completionHandler:", ParameterType = new Type [] { typeof (CGPoint), typeof (UITextGranularity), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectText", Selector = "selectTextInGranularity:atPoint:completionHandler:", ParameterType = new Type [] { typeof (UITextGranularity), typeof (CGPoint), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectPosition", Selector = "selectPositionAtPoint:completionHandler:", ParameterType = new Type [] { typeof (CGPoint), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectPosition", Selector = "selectPositionAtPoint:withContextRequest:completionHandler:", ParameterType = new Type [] { typeof (CGPoint), typeof (BrowserEngineKit.BETextDocumentRequest), typeof (global::System.Action<global::BrowserEngineKit.BETextDocumentContext>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V13) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AdjustSelection", Selector = "adjustSelectionByRange:completionHandler:", ParameterType = new Type [] { typeof (BrowserEngineKit.BEDirectionalTextRange), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Move", Selector = "moveByOffset:", ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MoveSelectionAtBoundary", Selector = "moveSelectionAtBoundary:inStorageDirection:completionHandler:", ParameterType = new Type [] { typeof (UITextGranularity), typeof (UITextStorageDirection), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectTextForEditMenu", Selector = "selectTextForEditMenuWithLocationInView:completionHandler:", ParameterType = new Type [] { typeof (CGPoint), typeof (global::System.Action<bool, NSString, NSRange>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetMarkedText", Selector = "setMarkedText:selectedRange:", ParameterType = new Type [] { typeof (string), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAttributedMarkedText", Selector = "setAttributedMarkedText:selectedRange:", ParameterType = new Type [] { typeof (NSAttributedString), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnmarkText", Selector = "unmarkText")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsPointNearMarkedText", Selector = "isPointNearMarkedText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestDocumentContext", Selector = "requestDocumentContext:completionHandler:", ParameterType = new Type [] { typeof (BrowserEngineKit.BETextDocumentRequest), typeof (global::System.Action<global::BrowserEngineKit.BETextDocumentContext>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V13) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WillInsertFinalDictationResult", Selector = "willInsertFinalDictationResult")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceDictatedText", Selector = "replaceDictatedText:withText:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidInsertFinalDictationResult", Selector = "didInsertFinalDictationResult")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAlternativesForSelectedText", Selector = "alternativesForSelectedText", ReturnType = typeof (BrowserEngineKit.BETextAlternatives[]))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddTextAlternatives", Selector = "addTextAlternatives:", ParameterType = new Type [] { typeof (BrowserEngineKit.BETextAlternatives) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertTextAlternatives", Selector = "insertTextAlternatives:", ParameterType = new Type [] { typeof (BrowserEngineKit.BETextAlternatives) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveTextAlternatives", Selector = "removeTextAlternatives")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertTextPlaceholder", Selector = "insertTextPlaceholderWithSize:completionHandler:", ParameterType = new Type [] { typeof (CGSize), typeof (global::System.Action<global::UIKit.UITextPlaceholder>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V14) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveTextPlaceholder", Selector = "removeTextPlaceholder:willInsertText:completionHandler:", ParameterType = new Type [] { typeof (UITextPlaceholder), typeof (bool), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertTextSuggestion", Selector = "insertTextSuggestion:", ParameterType = new Type [] { typeof (BrowserEngineKit.BETextSuggestion) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Autoscroll", Selector = "autoscrollToPoint:", ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelAutoscroll", Selector = "cancelAutoscroll")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "KeyboardWillDismiss", Selector = "keyboardWillDismiss")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakAsyncInputDelegate", Selector = "asyncInputDelegate", PropertyType = typeof (NSObject), GetterSelector = "asyncInputDelegate", SetterSelector = "setAsyncInputDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Editable", Selector = "editable", PropertyType = typeof (bool), GetterSelector = "isEditable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutomaticallyPresentEditMenu", Selector = "automaticallyPresentEditMenu", PropertyType = typeof (bool), GetterSelector = "automaticallyPresentEditMenu", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ExtendedTextInputTraits", Selector = "extendedTextInputTraits", PropertyType = typeof (BrowserEngineKit.IBEExtendedTextInputTraits), GetterSelector = "extendedTextInputTraits", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReplaceAllowed", Selector = "replaceAllowed", PropertyType = typeof (bool), GetterSelector = "isReplaceAllowed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedText", Selector = "selectedText", PropertyType = typeof (string), GetterSelector = "selectedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedTextRange", Selector = "selectedTextRange", PropertyType = typeof (UITextRange), GetterSelector = "selectedTextRange", SetterSelector = "setSelectedTextRange:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectionAtDocumentStart", Selector = "selectionAtDocumentStart", PropertyType = typeof (bool), GetterSelector = "isSelectionAtDocumentStart", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedText", Selector = "markedText", PropertyType = typeof (string), GetterSelector = "markedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AttributedMarkedText", Selector = "attributedMarkedText", PropertyType = typeof (NSAttributedString), GetterSelector = "attributedMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MarkedTextRange", Selector = "markedTextRange", PropertyType = typeof (UITextRange), GetterSelector = "markedTextRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HasMarkedText", Selector = "hasMarkedText", PropertyType = typeof (bool), GetterSelector = "hasMarkedText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextInputView", Selector = "textInputView", PropertyType = typeof (UIView), GetterSelector = "textInputView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextFirstRect", Selector = "textFirstRect", PropertyType = typeof (CGRect), GetterSelector = "textFirstRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextLastRect", Selector = "textLastRect", PropertyType = typeof (CGRect), GetterSelector = "textLastRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UnobscuredContentRect", Selector = "unobscuredContentRect", PropertyType = typeof (CGRect), GetterSelector = "unobscuredContentRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UnscaledView", Selector = "unscaledView", PropertyType = typeof (UIView), GetterSelector = "unscaledView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectionClipRect", Selector = "selectionClipRect", PropertyType = typeof (CGRect), GetterSelector = "selectionClipRect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionContainerViewBelowText", Selector = "selectionContainerViewBelowText", PropertyType = typeof (UIView), GetterSelector = "selectionContainerViewBelowText", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionContainerViewAboveText", Selector = "selectionContainerViewAboveText", PropertyType = typeof (UIView), GetterSelector = "selectionContainerViewAboveText", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IBETextInput : INativeObject, IDisposable, 
		BrowserEngineKit.IBEResponderEditActions
		, BrowserEngineKit.IBETextSelectionDirectionNavigation
		, UIKit.IUIKeyInput
		, UIKit.IUIResponderStandardEditActions
		, UIKit.IUITextInputTraits
	{
		[global::Foundation.RequiredMember]
		[Export ("canPerformAction:withSender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (Selector action, NSObject? sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanPerformAction (IBETextInput This, Selector action, NSObject? sender)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var sender__handle__ = sender.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("canPerformAction:withSender:"), action.Handle, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (action);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("handleKeyEntry:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleKeyEntry (BEKeyEntry entry, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputHandleKeyEntryCallback))]BETextInputHandleKeyEntryCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleKeyEntry (IBETextInput This, BEKeyEntry entry, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputHandleKeyEntryCallback))]BETextInputHandleKeyEntryCallback completionHandler)
		{
			var entry__handle__ = entry!.GetNonNullHandle (nameof (entry));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBETextInputHandleKeyEntryCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleKeyEntry:withCompletionHandler:"), entry__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (entry);
		}
		[global::Foundation.RequiredMember]
		[Export ("shiftKeyStateChangedFromState:toState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShiftKeyStateChanged (BEKeyModifierFlags oldState, BEKeyModifierFlags newState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ShiftKeyStateChanged (IBETextInput This, BEKeyModifierFlags oldState, BEKeyModifierFlags newState)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("shiftKeyStateChangedFromState:toState:"), (IntPtr) (long) oldState, (IntPtr) (long) newState);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("textInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetText (global::UIKit.UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetText (IBETextInput This, global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("offsetFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffset (global::UIKit.UITextPosition from, global::UIKit.UITextPosition toPosition)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetOffset (IBETextInput This, global::UIKit.UITextPosition from, global::UIKit.UITextPosition toPosition)
		{
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), from__handle__, toPosition__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (from);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setBaseWritingDirection:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBaseWritingDirection (NSWritingDirection writingDirection, global::UIKit.UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBaseWritingDirection (IBETextInput This, NSWritingDirection writingDirection, global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
		}
		[global::Foundation.RequiredMember]
		[Export ("deleteInDirection:toGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Delete (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Delete (IBETextInput This, global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("deleteInDirection:toGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("transposeCharactersAroundSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransposeCharactersAroundSelection ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TransposeCharactersAroundSelection (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("transposeCharactersAroundSelection"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceText:withText:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceText (string originalText, string replacementText, BETextReplacementOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputReplaceTextCallback))]BETextInputReplaceTextCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReplaceText (IBETextInput This, string originalText, string replacementText, BETextReplacementOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputReplaceTextCallback))]BETextInputReplaceTextCallback completionHandler)
		{
			if (originalText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (originalText));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsoriginalText = CFString.CreateNative (originalText);
			var nsreplacementText = CFString.CreateNative (replacementText);
			using var block_completionHandler = Trampolines.SDBETextInputReplaceTextCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("replaceText:withText:options:completionHandler:"), nsoriginalText, nsreplacementText, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsoriginalText);
			CFString.ReleaseNative (nsreplacementText);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestTextContextForAutocorrectionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestTextContextForAutocorrection ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextContextForAutocorrectionCallback))]BETextInputRequestTextContextForAutocorrectionCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestTextContextForAutocorrection (IBETextInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextContextForAutocorrectionCallback))]BETextInputRequestTextContextForAutocorrectionCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBETextInputRequestTextContextForAutocorrectionCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestTextContextForAutocorrectionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestTextRectsForString:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestTextRects (string input, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextRectsCallback))]BETextInputRequestTextRectsCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestTextRects (IBETextInput This, string input, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextRectsCallback))]BETextInputRequestTextRectsCallback completionHandler)
		{
			if (input is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (input));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsinput = CFString.CreateNative (input);
			using var block_completionHandler = Trampolines.SDBETextInputRequestTextRectsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("requestTextRectsForString:withCompletionHandler:"), nsinput, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinput);
		}
		[global::Foundation.RequiredMember]
		[Export ("textStylingAtPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? GetTextStyling (global::UIKit.UITextPosition position, global::UIKit.UITextStorageDirection direction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject>? _GetTextStyling (IBETextInput This, global::UIKit.UITextPosition position, global::UIKit.UITextStorageDirection direction)
		{
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), position__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (position);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceSelectedText:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceSelectedText (string text, string replacementText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceSelectedText (IBETextInput This, string text, string replacementText)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nstext = CFString.CreateNative (text);
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceSelectedText:withText:"), nstext, nsreplacementText);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstext);
			CFString.ReleaseNative (nsreplacementText);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateCurrentSelectionTo:fromGesture:inState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateCurrentSelection (CGPoint point, BEGestureType gestureType, global::UIKit.UIGestureRecognizerState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateCurrentSelection (IBETextInput This, CGPoint point, BEGestureType gestureType, global::UIKit.UIGestureRecognizerState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("updateCurrentSelectionTo:fromGesture:inState:"), point, (IntPtr) (long) gestureType, (IntPtr) (long) state);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setSelectionFromPoint:toPoint:gesture:state:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelection (CGPoint from, CGPoint to, BEGestureType gesture, global::UIKit.UIGestureRecognizerState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelection (IBETextInput This, CGPoint from, CGPoint to, BEGestureType gesture, global::UIKit.UIGestureRecognizerState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setSelectionFromPoint:toPoint:gesture:state:"), from, to, (IntPtr) (long) gesture, (IntPtr) (long) state);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("adjustSelectionBoundaryToPoint:touchPhase:baseIsStart:flags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AdjustSelectionBoundary (CGPoint point, BESelectionTouchPhase touch, bool boundaryIsStart, BESelectionFlags flags)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AdjustSelectionBoundary (IBETextInput This, CGPoint point, BESelectionTouchPhase touch, bool boundaryIsStart, BESelectionFlags flags)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_bool_UIntPtr (This.Handle, Selector.GetHandle ("adjustSelectionBoundaryToPoint:touchPhase:baseIsStart:flags:"), point, (IntPtr) (long) touch, boundaryIsStart ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) flags);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("textInteractionGesture:shouldBeginAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldTextInteractionGestureBeginAtPoint (BEGestureType gestureType, CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldTextInteractionGestureBeginAtPoint (IBETextInput This, BEGestureType gestureType, CGPoint point)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("textInteractionGesture:shouldBeginAtPoint:"), (IntPtr) (long) gestureType, point);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("caretRectForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCaretRect (global::UIKit.UITextPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetCaretRect (IBETextInput This, global::UIKit.UITextPosition position)
		{
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
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
		[global::Foundation.RequiredMember]
		[Export ("selectionRectsForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UITextSelectionRect[] GetSelectionRects (global::UIKit.UITextRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UITextSelectionRect[] _GetSelectionRects (IBETextInput This, global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::UIKit.UITextSelectionRect[]? ret;
			ret = CFArray.ArrayFromHandle<global::UIKit.UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("selectWordForReplacement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectWordForReplacement ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectWordForReplacement (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("selectWordForReplacement"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateSelectionWithExtentPoint:boundary:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UpdateSelection (CGPoint extentPoint, global::UIKit.UITextGranularity granularity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _UpdateSelection (IBETextInput This, CGPoint extentPoint, global::UIKit.UITextGranularity granularity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("updateSelectionWithExtentPoint:boundary:completionHandler:"), extentPoint, (IntPtr) (long) granularity, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectTextInGranularity:atPoint:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectText (global::UIKit.UITextGranularity granularity, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectText (IBETextInput This, global::UIKit.UITextGranularity granularity, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("selectTextInGranularity:atPoint:completionHandler:"), (IntPtr) (long) granularity, point, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectPositionAtPoint:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectPosition (CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectPosition (IBETextInput This, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("selectPositionAtPoint:completionHandler:"), point, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectPositionAtPoint:withContextRequest:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectPosition (CGPoint point, BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectPosition (IBETextInput This, CGPoint point, BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V13.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("selectPositionAtPoint:withContextRequest:completionHandler:"), point, request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[global::Foundation.RequiredMember]
		[Export ("adjustSelectionByRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AdjustSelection (BEDirectionalTextRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AdjustSelection (IBETextInput This, BEDirectionalTextRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_BEDirectionalTextRange_NativeHandle (This.Handle, Selector.GetHandle ("adjustSelectionByRange:completionHandler:"), range, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("moveByOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Move (nint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Move (IBETextInput This, nint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("moveByOffset:"), offset);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("moveSelectionAtBoundary:inStorageDirection:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MoveSelectionAtBoundary (global::UIKit.UITextGranularity granularity, global::UIKit.UITextStorageDirection direction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _MoveSelectionAtBoundary (IBETextInput This, global::UIKit.UITextGranularity granularity, global::UIKit.UITextStorageDirection direction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("moveSelectionAtBoundary:inStorageDirection:completionHandler:"), (IntPtr) (long) granularity, (IntPtr) (long) direction, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectTextForEditMenuWithLocationInView:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectTextForEditMenu (CGPoint locationInView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<bool, NSString, NSRange> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SelectTextForEditMenu (IBETextInput This, CGPoint locationInView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<bool, NSString, NSRange> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (This.Handle, Selector.GetHandle ("selectTextForEditMenuWithLocationInView:completionHandler:"), locationInView, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (string? markedText, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMarkedText (IBETextInput This, string? markedText, NSRange selectedRange)
		{
			var nsmarkedText = CFString.CreateNative (markedText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmarkedText);
		}
		[global::Foundation.RequiredMember]
		[Export ("setAttributedMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributedMarkedText (NSAttributedString? markedText, NSRange selectedRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAttributedMarkedText (IBETextInput This, NSAttributedString? markedText, NSRange selectedRange)
		{
			var markedText__handle__ = markedText.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			GC.KeepAlive (This);
			GC.KeepAlive (markedText);
		}
		[global::Foundation.RequiredMember]
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnmarkText (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("unmarkText"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("isPointNearMarkedText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPointNearMarkedText (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsPointNearMarkedText (IBETextInput This, CGPoint point)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("isPointNearMarkedText:"), point);
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("requestDocumentContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestDocumentContext (BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestDocumentContext (IBETextInput This, BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V13.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("requestDocumentContext:completionHandler:"), request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (request);
		}
		[global::Foundation.RequiredMember]
		[Export ("willInsertFinalDictationResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillInsertFinalDictationResult ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillInsertFinalDictationResult (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willInsertFinalDictationResult"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceDictatedText:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceDictatedText (string oldText, string newText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceDictatedText (IBETextInput This, string oldText, string newText)
		{
			if (oldText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldText));
			if (newText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newText));
			var nsoldText = CFString.CreateNative (oldText);
			var nsnewText = CFString.CreateNative (newText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceDictatedText:withText:"), nsoldText, nsnewText);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsoldText);
			CFString.ReleaseNative (nsnewText);
		}
		[global::Foundation.RequiredMember]
		[Export ("didInsertFinalDictationResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInsertFinalDictationResult ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidInsertFinalDictationResult (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("didInsertFinalDictationResult"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("alternativesForSelectedText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BETextAlternatives[]? GetAlternativesForSelectedText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BETextAlternatives[]? _GetAlternativesForSelectedText (IBETextInput This)
		{
			BETextAlternatives[] ret;
			ret = CFArray.ArrayFromHandle<BETextAlternatives>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("alternativesForSelectedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("addTextAlternatives:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTextAlternatives (BETextAlternatives alternatives)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddTextAlternatives (IBETextInput This, BETextAlternatives alternatives)
		{
			var alternatives__handle__ = alternatives!.GetNonNullHandle (nameof (alternatives));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addTextAlternatives:"), alternatives__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alternatives);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertTextAlternatives:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertTextAlternatives (BETextAlternatives alternatives)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertTextAlternatives (IBETextInput This, BETextAlternatives alternatives)
		{
			var alternatives__handle__ = alternatives!.GetNonNullHandle (nameof (alternatives));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertTextAlternatives:"), alternatives__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alternatives);
		}
		[global::Foundation.OptionalMember]
		[Export ("removeTextAlternatives")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextAlternatives ()
		{
			_RemoveTextAlternatives (this);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveTextAlternatives (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("removeTextAlternatives"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertTextPlaceholderWithSize:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InsertTextPlaceholder (CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V14))]global::System.Action<global::UIKit.UITextPlaceholder> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _InsertTextPlaceholder (IBETextInput This, CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V14))]global::System.Action<global::UIKit.UITextPlaceholder> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V14.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (This.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:completionHandler:"), size, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeTextPlaceholder:willInsertText:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveTextPlaceholder (global::UIKit.UITextPlaceholder placeholder, bool willInsertText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RemoveTextPlaceholder (IBETextInput This, global::UIKit.UITextPlaceholder placeholder, bool willInsertText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (This.Handle, Selector.GetHandle ("removeTextPlaceholder:willInsertText:completionHandler:"), placeholder__handle__, willInsertText ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (placeholder);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertTextSuggestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertTextSuggestion (BETextSuggestion textSuggestion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertTextSuggestion (IBETextInput This, BETextSuggestion textSuggestion)
		{
			var textSuggestion__handle__ = textSuggestion!.GetNonNullHandle (nameof (textSuggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("insertTextSuggestion:"), textSuggestion__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textSuggestion);
		}
		[global::Foundation.RequiredMember]
		[Export ("autoscrollToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Autoscroll (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Autoscroll (IBETextInput This, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("autoscrollToPoint:"), point);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("cancelAutoscroll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAutoscroll ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelAutoscroll (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelAutoscroll"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("keyboardWillDismiss")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void KeyboardWillDismiss ()
		{
			_KeyboardWillDismiss (this);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _KeyboardWillDismiss (IBETextInput This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("keyboardWillDismiss"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddTextAlternatives(BrowserEngineKit.BETextAlternatives)")]
		[DynamicDependencyAttribute ("AdjustSelection(BrowserEngineKit.BEDirectionalTextRange,System.Action)")]
		[DynamicDependencyAttribute ("AdjustSelectionBoundary(CoreGraphics.CGPoint,BrowserEngineKit.BESelectionTouchPhase,System.Boolean,BrowserEngineKit.BESelectionFlags)")]
		[DynamicDependencyAttribute ("AttributedMarkedText")]
		[DynamicDependencyAttribute ("AutomaticallyPresentEditMenu")]
		[DynamicDependencyAttribute ("Autoscroll(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("CancelAutoscroll()")]
		[DynamicDependencyAttribute ("CanPerformAction(ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Delete(UIKit.UITextStorageDirection,UIKit.UITextGranularity)")]
		[DynamicDependencyAttribute ("DidInsertFinalDictationResult()")]
		[DynamicDependencyAttribute ("Editable")]
		[DynamicDependencyAttribute ("ExtendedTextInputTraits")]
		[DynamicDependencyAttribute ("GetAlternativesForSelectedText()")]
		[DynamicDependencyAttribute ("GetCaretRect(UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetOffset(UIKit.UITextPosition,UIKit.UITextPosition)")]
		[DynamicDependencyAttribute ("GetSelectionRects(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetText(UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("GetTextStyling(UIKit.UITextPosition,UIKit.UITextStorageDirection)")]
		[DynamicDependencyAttribute ("HandleKeyEntry(BrowserEngineKit.BEKeyEntry,BrowserEngineKit.BETextInputHandleKeyEntryCallback)")]
		[DynamicDependencyAttribute ("HasMarkedText")]
		[DynamicDependencyAttribute ("InsertTextAlternatives(BrowserEngineKit.BETextAlternatives)")]
		[DynamicDependencyAttribute ("InsertTextPlaceholder(CoreGraphics.CGSize,System.Action{UIKit.UITextPlaceholder})")]
		[DynamicDependencyAttribute ("InsertTextSuggestion(BrowserEngineKit.BETextSuggestion)")]
		[DynamicDependencyAttribute ("IsPointNearMarkedText(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("KeyboardWillDismiss()")]
		[DynamicDependencyAttribute ("MarkedText")]
		[DynamicDependencyAttribute ("MarkedTextRange")]
		[DynamicDependencyAttribute ("Move(System.IntPtr)")]
		[DynamicDependencyAttribute ("MoveSelectionAtBoundary(UIKit.UITextGranularity,UIKit.UITextStorageDirection,System.Action)")]
		[DynamicDependencyAttribute ("RemoveTextAlternatives()")]
		[DynamicDependencyAttribute ("RemoveTextPlaceholder(UIKit.UITextPlaceholder,System.Boolean,System.Action)")]
		[DynamicDependencyAttribute ("ReplaceAllowed")]
		[DynamicDependencyAttribute ("ReplaceDictatedText(System.String,System.String)")]
		[DynamicDependencyAttribute ("ReplaceSelectedText(System.String,System.String)")]
		[DynamicDependencyAttribute ("ReplaceText(System.String,System.String,BrowserEngineKit.BETextReplacementOptions,BrowserEngineKit.BETextInputReplaceTextCallback)")]
		[DynamicDependencyAttribute ("RequestDocumentContext(BrowserEngineKit.BETextDocumentRequest,System.Action{BrowserEngineKit.BETextDocumentContext})")]
		[DynamicDependencyAttribute ("RequestTextContextForAutocorrection(BrowserEngineKit.BETextInputRequestTextContextForAutocorrectionCallback)")]
		[DynamicDependencyAttribute ("RequestTextRects(System.String,BrowserEngineKit.BETextInputRequestTextRectsCallback)")]
		[DynamicDependencyAttribute ("SelectedText")]
		[DynamicDependencyAttribute ("SelectedTextRange")]
		[DynamicDependencyAttribute ("SelectionAtDocumentStart")]
		[DynamicDependencyAttribute ("SelectionClipRect")]
		[DynamicDependencyAttribute ("SelectionContainerViewAboveText")]
		[DynamicDependencyAttribute ("SelectionContainerViewBelowText")]
		[DynamicDependencyAttribute ("SelectPosition(CoreGraphics.CGPoint,BrowserEngineKit.BETextDocumentRequest,System.Action{BrowserEngineKit.BETextDocumentContext})")]
		[DynamicDependencyAttribute ("SelectPosition(CoreGraphics.CGPoint,System.Action)")]
		[DynamicDependencyAttribute ("SelectText(UIKit.UITextGranularity,CoreGraphics.CGPoint,System.Action)")]
		[DynamicDependencyAttribute ("SelectTextForEditMenu(CoreGraphics.CGPoint,System.Action{System.Boolean,Foundation.NSString,Foundation.NSRange})")]
		[DynamicDependencyAttribute ("SelectWordForReplacement()")]
		[DynamicDependencyAttribute ("SetAttributedMarkedText(Foundation.NSAttributedString,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetBaseWritingDirection(Foundation.NSWritingDirection,UIKit.UITextRange)")]
		[DynamicDependencyAttribute ("SetMarkedText(System.String,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetSelection(CoreGraphics.CGPoint,CoreGraphics.CGPoint,BrowserEngineKit.BEGestureType,UIKit.UIGestureRecognizerState)")]
		[DynamicDependencyAttribute ("ShiftKeyStateChanged(BrowserEngineKit.BEKeyModifierFlags,BrowserEngineKit.BEKeyModifierFlags)")]
		[DynamicDependencyAttribute ("ShouldTextInteractionGestureBeginAtPoint(BrowserEngineKit.BEGestureType,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("TextFirstRect")]
		[DynamicDependencyAttribute ("TextInputView")]
		[DynamicDependencyAttribute ("TextLastRect")]
		[DynamicDependencyAttribute ("TransposeCharactersAroundSelection()")]
		[DynamicDependencyAttribute ("UnmarkText()")]
		[DynamicDependencyAttribute ("UnobscuredContentRect")]
		[DynamicDependencyAttribute ("UnscaledView")]
		[DynamicDependencyAttribute ("UpdateCurrentSelection(CoreGraphics.CGPoint,BrowserEngineKit.BEGestureType,UIKit.UIGestureRecognizerState)")]
		[DynamicDependencyAttribute ("UpdateSelection(CoreGraphics.CGPoint,UIKit.UITextGranularity,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("WeakAsyncInputDelegate")]
		[DynamicDependencyAttribute ("WillInsertFinalDictationResult()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBETextInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? WeakAsyncInputDelegate {
			[Export ("asyncInputDelegate", ArgumentSemantic.Weak)]
			get {
				return _GetWeakAsyncInputDelegate (this);
			}
			[Export ("setAsyncInputDelegate:", ArgumentSemantic.Weak)]
			set {
				_SetWeakAsyncInputDelegate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetWeakAsyncInputDelegate (IBETextInput This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asyncInputDelegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWeakAsyncInputDelegate (IBETextInput This, NSObject? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAsyncInputDelegate:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				return _GetEditable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetEditable (IBETextInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEditable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AutomaticallyPresentEditMenu {
			[Export ("automaticallyPresentEditMenu")]
			get {
				return _GetAutomaticallyPresentEditMenu (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAutomaticallyPresentEditMenu (IBETextInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("automaticallyPresentEditMenu"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IBEExtendedTextInputTraits? ExtendedTextInputTraits {
			[Export ("extendedTextInputTraits")]
			get {
				return _GetExtendedTextInputTraits (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IBEExtendedTextInputTraits _GetExtendedTextInputTraits (IBETextInput This)
		{
			IBEExtendedTextInputTraits ret;
			ret =  Runtime.GetINativeObject<IBEExtendedTextInputTraits> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("extendedTextInputTraits")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ReplaceAllowed {
			[Export ("isReplaceAllowed")]
			get {
				return _GetReplaceAllowed (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReplaceAllowed (IBETextInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReplaceAllowed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? SelectedText {
			[Export ("selectedText")]
			get {
				return _GetSelectedText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSelectedText (IBETextInput This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UITextRange? SelectedTextRange {
			[Export ("selectedTextRange", ArgumentSemantic.Copy)]
			get {
				return _GetSelectedTextRange (this);
			}
			[Export ("setSelectedTextRange:", ArgumentSemantic.Copy)]
			set {
				_SetSelectedTextRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UITextRange _GetSelectedTextRange (IBETextInput This)
		{
			global::UIKit.UITextRange ret;
			ret =  Runtime.GetNSObject<global::UIKit.UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSelectedTextRange (IBETextInput This, global::UIKit.UITextRange? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SelectionAtDocumentStart {
			[Export ("isSelectionAtDocumentStart")]
			get {
				return _GetSelectionAtDocumentStart (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSelectionAtDocumentStart (IBETextInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelectionAtDocumentStart"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? MarkedText {
			[Export ("markedText")]
			get {
				return _GetMarkedText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetMarkedText (IBETextInput This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("markedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAttributedString? AttributedMarkedText {
			[Export ("attributedMarkedText")]
			get {
				return _GetAttributedMarkedText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString _GetAttributedMarkedText (IBETextInput This)
		{
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("attributedMarkedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UITextRange? MarkedTextRange {
			[Export ("markedTextRange")]
			get {
				return _GetMarkedTextRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UITextRange _GetMarkedTextRange (IBETextInput This)
		{
			global::UIKit.UITextRange ret;
			ret =  Runtime.GetNSObject<global::UIKit.UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("markedTextRange")), false)!;
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
		internal static bool _GetHasMarkedText (IBETextInput This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasMarkedText"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UIView TextInputView {
			[Export ("textInputView")]
			get {
				return _GetTextInputView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView _GetTextInputView (IBETextInput This)
		{
			global::UIKit.UIView ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textInputView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect TextFirstRect {
			[Export ("textFirstRect")]
			get {
				return _GetTextFirstRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetTextFirstRect (IBETextInput This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("textFirstRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("textFirstRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect TextLastRect {
			[Export ("textLastRect")]
			get {
				return _GetTextLastRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetTextLastRect (IBETextInput This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("textLastRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("textLastRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect UnobscuredContentRect {
			[Export ("unobscuredContentRect")]
			get {
				return _GetUnobscuredContentRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetUnobscuredContentRect (IBETextInput This)
		{
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UIView UnscaledView {
			[Export ("unscaledView")]
			get {
				return _GetUnscaledView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView _GetUnscaledView (IBETextInput This)
		{
			global::UIKit.UIView ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("unscaledView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect SelectionClipRect {
			[Export ("selectionClipRect")]
			get {
				return _GetSelectionClipRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetSelectionClipRect (IBETextInput This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("selectionClipRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("selectionClipRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIView SelectionContainerViewBelowText {
			[Export ("selectionContainerViewBelowText")]
			get {
				return _GetSelectionContainerViewBelowText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView _GetSelectionContainerViewBelowText (IBETextInput This)
		{
			global::UIKit.UIView ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectionContainerViewBelowText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIView SelectionContainerViewAboveText {
			[Export ("selectionContainerViewAboveText")]
			get {
				return _GetSelectionContainerViewAboveText (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIView _GetSelectionContainerViewAboveText (IBETextInput This)
		{
			global::UIKit.UIView ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectionContainerViewAboveText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BETextInputWrapper : BaseWrapper, IBETextInput {
		public BETextInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextInputWrapper))]
		static BETextInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("canPerformAction:withSender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanPerformAction (Selector action, NSObject? sender)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var sender__handle__ = sender.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("canPerformAction:withSender:"), action.Handle, sender__handle__);
			GC.KeepAlive (action);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("handleKeyEntry:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleKeyEntry (BEKeyEntry entry, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputHandleKeyEntryCallback))]BETextInputHandleKeyEntryCallback completionHandler)
		{
			var entry__handle__ = entry!.GetNonNullHandle (nameof (entry));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBETextInputHandleKeyEntryCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleKeyEntry:withCompletionHandler:"), entry__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (entry);
		}
		[Export ("shiftKeyStateChangedFromState:toState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ShiftKeyStateChanged (BEKeyModifierFlags oldState, BEKeyModifierFlags newState)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("shiftKeyStateChangedFromState:toState:"), (IntPtr) (long) oldState, (IntPtr) (long) newState);
		}
		[Export ("textInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? GetText (global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		[Export ("offsetFromPosition:toPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetOffset (global::UIKit.UITextPosition from, global::UIKit.UITextPosition toPosition)
		{
			var from__handle__ = from!.GetNonNullHandle (nameof (from));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), from__handle__, toPosition__handle__);
			GC.KeepAlive (from);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		[Export ("setBaseWritingDirection:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBaseWritingDirection (NSWritingDirection writingDirection, global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			GC.KeepAlive (range);
		}
		[Export ("deleteInDirection:toGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Delete (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deleteInDirection:toGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
		}
		[Export ("transposeCharactersAroundSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TransposeCharactersAroundSelection ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("transposeCharactersAroundSelection"));
		}
		[Export ("replaceText:withText:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReplaceText (string originalText, string replacementText, BETextReplacementOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputReplaceTextCallback))]BETextInputReplaceTextCallback completionHandler)
		{
			if (originalText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (originalText));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsoriginalText = CFString.CreateNative (originalText);
			var nsreplacementText = CFString.CreateNative (replacementText);
			using var block_completionHandler = Trampolines.SDBETextInputReplaceTextCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("replaceText:withText:options:completionHandler:"), nsoriginalText, nsreplacementText, (UIntPtr) (ulong) options, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsoriginalText);
			CFString.ReleaseNative (nsreplacementText);
		}
		[Export ("requestTextContextForAutocorrectionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestTextContextForAutocorrection ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextContextForAutocorrectionCallback))]BETextInputRequestTextContextForAutocorrectionCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDBETextInputRequestTextContextForAutocorrectionCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestTextContextForAutocorrectionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("requestTextRectsForString:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestTextRects (string input, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDBETextInputRequestTextRectsCallback))]BETextInputRequestTextRectsCallback completionHandler)
		{
			if (input is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (input));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsinput = CFString.CreateNative (input);
			using var block_completionHandler = Trampolines.SDBETextInputRequestTextRectsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestTextRectsForString:withCompletionHandler:"), nsinput, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsinput);
		}
		[Export ("textStylingAtPosition:inDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject>? GetTextStyling (global::UIKit.UITextPosition position, global::UIKit.UITextStorageDirection direction)
		{
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), position__handle__, (IntPtr) (long) direction), false)!;
			GC.KeepAlive (position);
			return ret!;
		}
		[Export ("replaceSelectedText:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceSelectedText (string text, string replacementText)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nstext = CFString.CreateNative (text);
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceSelectedText:withText:"), nstext, nsreplacementText);
			CFString.ReleaseNative (nstext);
			CFString.ReleaseNative (nsreplacementText);
		}
		[Export ("updateCurrentSelectionTo:fromGesture:inState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateCurrentSelection (CGPoint point, BEGestureType gestureType, global::UIKit.UIGestureRecognizerState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateCurrentSelectionTo:fromGesture:inState:"), point, (IntPtr) (long) gestureType, (IntPtr) (long) state);
		}
		[Export ("setSelectionFromPoint:toPoint:gesture:state:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetSelection (CGPoint from, CGPoint to, BEGestureType gesture, global::UIKit.UIGestureRecognizerState state)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setSelectionFromPoint:toPoint:gesture:state:"), from, to, (IntPtr) (long) gesture, (IntPtr) (long) state);
		}
		[Export ("adjustSelectionBoundaryToPoint:touchPhase:baseIsStart:flags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AdjustSelectionBoundary (CGPoint point, BESelectionTouchPhase touch, bool boundaryIsStart, BESelectionFlags flags)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_bool_UIntPtr (this.Handle, Selector.GetHandle ("adjustSelectionBoundaryToPoint:touchPhase:baseIsStart:flags:"), point, (IntPtr) (long) touch, boundaryIsStart ? (byte) 1 : (byte) 0, (UIntPtr) (ulong) flags);
		}
		[Export ("textInteractionGesture:shouldBeginAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldTextInteractionGestureBeginAtPoint (BEGestureType gestureType, CGPoint point)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_CGPoint (this.Handle, Selector.GetHandle ("textInteractionGesture:shouldBeginAtPoint:"), (IntPtr) (long) gestureType, point);
			return ret != 0;
		}
		[Export ("caretRectForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetCaretRect (global::UIKit.UITextPosition position)
		{
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
			}
			GC.KeepAlive (position);
			return ret!;
		}
		[Export ("selectionRectsForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UITextSelectionRect[] GetSelectionRects (global::UIKit.UITextRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			global::UIKit.UITextSelectionRect[]? ret;
			ret = CFArray.ArrayFromHandle<global::UIKit.UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		[Export ("selectWordForReplacement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectWordForReplacement ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("selectWordForReplacement"));
		}
		[Export ("updateSelectionWithExtentPoint:boundary:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void UpdateSelection (CGPoint extentPoint, global::UIKit.UITextGranularity granularity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("updateSelectionWithExtentPoint:boundary:completionHandler:"), extentPoint, (IntPtr) (long) granularity, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("selectTextInGranularity:atPoint:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectText (global::UIKit.UITextGranularity granularity, CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("selectTextInGranularity:atPoint:completionHandler:"), (IntPtr) (long) granularity, point, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("selectPositionAtPoint:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectPosition (CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("selectPositionAtPoint:completionHandler:"), point, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("selectPositionAtPoint:withContextRequest:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectPosition (CGPoint point, BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V13.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("selectPositionAtPoint:withContextRequest:completionHandler:"), point, request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (request);
		}
		[Export ("adjustSelectionByRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AdjustSelection (BEDirectionalTextRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_BEDirectionalTextRange_NativeHandle (this.Handle, Selector.GetHandle ("adjustSelectionByRange:completionHandler:"), range, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("moveByOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Move (nint offset)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("moveByOffset:"), offset);
		}
		[Export ("moveSelectionAtBoundary:inStorageDirection:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void MoveSelectionAtBoundary (global::UIKit.UITextGranularity granularity, global::UIKit.UITextStorageDirection direction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("moveSelectionAtBoundary:inStorageDirection:completionHandler:"), (IntPtr) (long) granularity, (IntPtr) (long) direction, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("selectTextForEditMenuWithLocationInView:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SelectTextForEditMenu (CGPoint locationInView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<bool, NSString, NSRange> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity3V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("selectTextForEditMenuWithLocationInView:completionHandler:"), locationInView, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("setMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetMarkedText (string? markedText, NSRange selectedRange)
		{
			var nsmarkedText = CFString.CreateNative (markedText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			CFString.ReleaseNative (nsmarkedText);
		}
		[Export ("setAttributedMarkedText:selectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetAttributedMarkedText (NSAttributedString? markedText, NSRange selectedRange)
		{
			var markedText__handle__ = markedText.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			GC.KeepAlive (markedText);
		}
		[Export ("unmarkText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UnmarkText ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unmarkText"));
		}
		[Export ("isPointNearMarkedText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsPointNearMarkedText (CGPoint point)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("isPointNearMarkedText:"), point);
			return ret != 0;
		}
		[Export ("requestDocumentContext:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestDocumentContext (BETextDocumentRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V13))]global::System.Action<BETextDocumentContext> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V13.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestDocumentContext:completionHandler:"), request__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (request);
		}
		[Export ("willInsertFinalDictationResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WillInsertFinalDictationResult ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willInsertFinalDictationResult"));
		}
		[Export ("replaceDictatedText:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceDictatedText (string oldText, string newText)
		{
			if (oldText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldText));
			if (newText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newText));
			var nsoldText = CFString.CreateNative (oldText);
			var nsnewText = CFString.CreateNative (newText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceDictatedText:withText:"), nsoldText, nsnewText);
			CFString.ReleaseNative (nsoldText);
			CFString.ReleaseNative (nsnewText);
		}
		[Export ("didInsertFinalDictationResult")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidInsertFinalDictationResult ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didInsertFinalDictationResult"));
		}
		[Export ("alternativesForSelectedText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BETextAlternatives[]? GetAlternativesForSelectedText ()
		{
			BETextAlternatives[] ret;
			ret = CFArray.ArrayFromHandle<BETextAlternatives>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("alternativesForSelectedText")), false)!;
			return ret;
		}
		[Export ("addTextAlternatives:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddTextAlternatives (BETextAlternatives alternatives)
		{
			var alternatives__handle__ = alternatives!.GetNonNullHandle (nameof (alternatives));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addTextAlternatives:"), alternatives__handle__);
			GC.KeepAlive (alternatives);
		}
		[Export ("insertTextAlternatives:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertTextAlternatives (BETextAlternatives alternatives)
		{
			var alternatives__handle__ = alternatives!.GetNonNullHandle (nameof (alternatives));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertTextAlternatives:"), alternatives__handle__);
			GC.KeepAlive (alternatives);
		}
		[Export ("insertTextPlaceholderWithSize:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void InsertTextPlaceholder (CGSize size, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V14))]global::System.Action<global::UIKit.UITextPlaceholder> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V14.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NativeHandle (this.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:completionHandler:"), size, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("removeTextPlaceholder:willInsertText:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RemoveTextPlaceholder (global::UIKit.UITextPlaceholder placeholder, bool willInsertText, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("removeTextPlaceholder:willInsertText:completionHandler:"), placeholder__handle__, willInsertText ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (placeholder);
		}
		[Export ("insertTextSuggestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertTextSuggestion (BETextSuggestion textSuggestion)
		{
			var textSuggestion__handle__ = textSuggestion!.GetNonNullHandle (nameof (textSuggestion));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertTextSuggestion:"), textSuggestion__handle__);
			GC.KeepAlive (textSuggestion);
		}
		[Export ("autoscrollToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Autoscroll (CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("autoscrollToPoint:"), point);
		}
		[Export ("cancelAutoscroll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CancelAutoscroll ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAutoscroll"));
		}
		[Export ("moveInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MoveInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("moveInLayoutDirection:"), (IntPtr) (long) direction);
		}
		[Export ("extendInLayoutDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExtendInLayoutDirection (global::UIKit.UITextLayoutDirection direction)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("extendInLayoutDirection:"), (IntPtr) (long) direction);
		}
		[Export ("moveInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MoveInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("moveInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
		}
		[Export ("extendInStorageDirection:byGranularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ExtendInStorageDirection (global::UIKit.UITextStorageDirection direction, global::UIKit.UITextGranularity granularity)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("extendInStorageDirection:byGranularity:"), (IntPtr) (long) direction, (IntPtr) (long) granularity);
		}
		/// <param name="text">To be added.</param><summary>Inserts text at the cursor.</summary><remarks>To be added.</remarks>
		[Export ("insertText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertText (string text)
		{
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
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deleteBackward"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? WeakAsyncInputDelegate {
			[Export ("asyncInputDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asyncInputDelegate")), false)!;
				return ret;
			}
			[Export ("setAsyncInputDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAsyncInputDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Editable {
			[Export ("isEditable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditable"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AutomaticallyPresentEditMenu {
			[Export ("automaticallyPresentEditMenu")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("automaticallyPresentEditMenu"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IBEExtendedTextInputTraits? ExtendedTextInputTraits {
			[Export ("extendedTextInputTraits")]
			get {
				IBEExtendedTextInputTraits ret;
				ret =  Runtime.GetINativeObject<IBEExtendedTextInputTraits> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("extendedTextInputTraits")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ReplaceAllowed {
			[Export ("isReplaceAllowed")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReplaceAllowed"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? SelectedText {
			[Export ("selectedText")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedText")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UITextRange? SelectedTextRange {
			[Export ("selectedTextRange", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UITextRange ret;
				ret =  Runtime.GetNSObject<global::UIKit.UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				return ret;
			}
			[Export ("setSelectedTextRange:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SelectionAtDocumentStart {
			[Export ("isSelectionAtDocumentStart")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelectionAtDocumentStart"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? MarkedText {
			[Export ("markedText")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedText")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString? AttributedMarkedText {
			[Export ("attributedMarkedText")]
			get {
				NSAttributedString ret;
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributedMarkedText")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UITextRange? MarkedTextRange {
			[Export ("markedTextRange")]
			get {
				global::UIKit.UITextRange ret;
				ret =  Runtime.GetNSObject<global::UIKit.UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextRange")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool HasMarkedText {
			[Export ("hasMarkedText")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasMarkedText"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView TextInputView {
			[Export ("textInputView")]
			get {
				global::UIKit.UIView ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textInputView")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect TextFirstRect {
			[Export ("textFirstRect")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("textFirstRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("textFirstRect"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect TextLastRect {
			[Export ("textLastRect")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("textLastRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("textLastRect"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect UnobscuredContentRect {
			[Export ("unobscuredContentRect")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIView UnscaledView {
			[Export ("unscaledView")]
			get {
				global::UIKit.UIView ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("unscaledView")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect SelectionClipRect {
			[Export ("selectionClipRect")]
			get {
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("selectionClipRect"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("selectionClipRect"));
				}
				return ret!;
			}
		}
		/// <summary>Gets a value that tells whether the key input has text in it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public bool HasText {
			[Export ("hasText")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasText"));
				return ret != 0;
			}
		}
	}
}
