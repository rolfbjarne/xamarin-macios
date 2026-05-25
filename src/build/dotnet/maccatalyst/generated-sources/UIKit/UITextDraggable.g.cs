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
	/// <summary>Interface for treating a text view as a drag source.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextDraggable", WrapperType = typeof (UITextDraggableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextDragDelegate", Selector = "textDragDelegate", PropertyType = typeof (IUITextDragDelegate), GetterSelector = "textDragDelegate", SetterSelector = "setTextDragDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextDragInteraction", Selector = "textDragInteraction", PropertyType = typeof (UIDragInteraction), GetterSelector = "textDragInteraction", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextDragActive", Selector = "textDragActive", PropertyType = typeof (bool), GetterSelector = "isTextDragActive", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextDragOptions", Selector = "textDragOptions", PropertyType = typeof (UITextDragOptions), GetterSelector = "textDragOptions", SetterSelector = "setTextDragOptions:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IUITextDraggable : INativeObject, IDisposable, 
		UIKit.IUIKeyInput
		, UIKit.IUITextInput
		, UIKit.IUITextInputTraits
	{
		[DynamicDependencyAttribute ("TextDragActive")]
		[DynamicDependencyAttribute ("TextDragDelegate")]
		[DynamicDependencyAttribute ("TextDragInteraction")]
		[DynamicDependencyAttribute ("TextDragOptions")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDraggableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextDraggable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets a delegate for managing drag source behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUITextDragDelegate? TextDragDelegate {
			[Export ("textDragDelegate", ArgumentSemantic.Weak)]
			get {
				return _GetTextDragDelegate (this);
			}
			[Export ("setTextDragDelegate:", ArgumentSemantic.Weak)]
			set {
				_SetTextDragDelegate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUITextDragDelegate _GetTextDragDelegate (IUITextDraggable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUITextDragDelegate ret;
			ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textDragDelegate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextDragDelegate (IUITextDraggable This, IUITextDragDelegate? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets the drag interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDragInteraction? TextDragInteraction {
			[Export ("textDragInteraction")]
			get {
				return _GetTextDragInteraction (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDragInteraction _GetTextDragInteraction (IUITextDraggable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDragInteraction ret;
			ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("textDragInteraction")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets a Boolean value that tells whether a drag session is active for the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool TextDragActive {
			[Export ("isTextDragActive")]
			get {
				return _GetTextDragActive (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTextDragActive (IUITextDraggable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTextDragActive"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets a value that controls how formatting is displayed in dragged text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextDragOptions TextDragOptions {
			[Export ("textDragOptions", ArgumentSemantic.Assign)]
			get {
				return _GetTextDragOptions (this);
			}
			[Export ("setTextDragOptions:", ArgumentSemantic.Assign)]
			set {
				_SetTextDragOptions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextDragOptions _GetTextDragOptions (IUITextDraggable This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextDragOptions ret;
			ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textDragOptions"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTextDragOptions (IUITextDraggable This, UITextDragOptions value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextDraggableWrapper : BaseWrapper, IUITextDraggable {
		public UITextDraggableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDraggableWrapper))]
		static UITextDraggableWrapper ()
		{
			GC.KeepAlive (null);
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
		/// <summary>Gets or sets a delegate for managing drag source behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUITextDragDelegate? TextDragDelegate {
			[Export ("textDragDelegate", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextDragDelegate ret;
				ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragDelegate")), false)!;
				return ret;
			}
			[Export ("setTextDragDelegate:", ArgumentSemantic.Weak)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the drag interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIDragInteraction? TextDragInteraction {
			[Export ("textDragInteraction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragInteraction ret;
				ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragInteraction")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether a drag session is active for the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool TextDragActive {
			[Export ("isTextDragActive")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextDragActive"));
				return ret != 0;
			}
		}
		/// <summary>Gets a value that controls how formatting is displayed in dragged text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextDragOptions TextDragOptions {
			[Export ("textDragOptions", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextDragOptions ret;
				ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textDragOptions"));
				return ret!;
			}
			[Export ("setTextDragOptions:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
			}
		}
		/// <summary>Gets a value that tells whether the key input has text in it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool HasText {
			[Export ("hasText")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasText"));
				return ret != 0;
			}
		}
		/// <summary>The range of a document's selected text.</summary><value>If there is no current specified selection, then it is set to <see langword="null" />.</value><remarks>If the specified range has length, it specifies currently selected text; if zero length, it specifies only the caret at the insertion point.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				return ret;
			}
			[Export ("setSelectedTextRange:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Attribute dictionary describing how text should be drawn.</summary><value>Strings indicating style definition.</value><remarks>This is marked to indicate the necessity for unique visual treatment in display.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSDictionary? MarkedTextStyle {
			[Export ("markedTextStyle", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextStyle")), false)!;
				return ret;
			}
			[Export ("setMarkedTextStyle:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the beginning of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UITextPosition BeginningOfDocument {
			[Export ("beginningOfDocument")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition ret;
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("beginningOfDocument")), false)!;
				return ret;
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the end of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UITextPosition EndOfDocument {
			[Export ("endOfDocument")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition ret;
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("endOfDocument")), false)!;
				return ret;
			}
		}
		/// <summary>Indicates a weak input delegate.</summary><value>Automatically assigned at runtime.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSObject? WeakInputDelegate {
			[Export ("inputDelegate", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputDelegate")), false)!;
				return ret;
			}
			[Export ("setInputDelegate:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputDelegate:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Indicates a weak tokenizer.</summary><value>Standard units of granularity including characters, words, lines, and paragraphs.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public NSObject WeakTokenizer {
			[Export ("tokenizer")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tokenizer")), false)!;
				return ret;
			}
		}
		/// <summary>The currently marked range of text in a given document.</summary><value>If there is no text marked, the value is <see langword="null" />; all else  is provisionally inserted requiring user confirmation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public UITextRange MarkedTextRange {
			[Export ("markedTextRange")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextRange")), false)!;
				return ret;
			}
		}
	}
}
