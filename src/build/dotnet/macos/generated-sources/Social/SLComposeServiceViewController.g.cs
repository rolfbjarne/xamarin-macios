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
namespace Social {
	/// <summary>A standard UIViewController for composing data for social sharing.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Social/Reference/SLComposeServiceViewController_Class/index.html">Apple documentation for <c>SLComposeServiceViewController</c></related>
	[Register("SLComposeServiceViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class SLComposeServiceViewController : global::AppKit.NSViewController, global::AppKit.INSTextViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharactersRemainingX = "charactersRemaining";
		static readonly NativeHandle selCharactersRemainingXHandle = Selector.GetHandle ("charactersRemaining");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentTextX = "contentText";
		static readonly NativeHandle selContentTextXHandle = Selector.GetHandle ("contentText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSelectCancelX = "didSelectCancel";
		static readonly NativeHandle selDidSelectCancelXHandle = Selector.GetHandle ("didSelectCancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidSelectPostX = "didSelectPost";
		static readonly NativeHandle selDidSelectPostXHandle = Selector.GetHandle ("didSelectPost");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNibName_Bundle_X = "initWithNibName:bundle:";
		static readonly NativeHandle selInitWithNibName_Bundle_XHandle = Selector.GetHandle ("initWithNibName:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContentValidX = "isContentValid";
		static readonly NativeHandle selIsContentValidXHandle = Selector.GetHandle ("isContentValid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderX = "placeholder";
		static readonly NativeHandle selPlaceholderXHandle = Selector.GetHandle ("placeholder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentationAnimationDidFinishX = "presentationAnimationDidFinish";
		static readonly NativeHandle selPresentationAnimationDidFinishXHandle = Selector.GetHandle ("presentationAnimationDidFinish");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCharactersRemaining_X = "setCharactersRemaining:";
		static readonly NativeHandle selSetCharactersRemaining_XHandle = Selector.GetHandle ("setCharactersRemaining:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlaceholder_X = "setPlaceholder:";
		static readonly NativeHandle selSetPlaceholder_XHandle = Selector.GetHandle ("setPlaceholder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewX = "textView";
		static readonly NativeHandle selTextViewXHandle = Selector.GetHandle ("textView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_Candidates_ForSelectedRange_X = "textView:candidates:forSelectedRange:";
		static readonly NativeHandle selTextView_Candidates_ForSelectedRange_XHandle = Selector.GetHandle ("textView:candidates:forSelectedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_CandidatesForSelectedRange_X = "textView:candidatesForSelectedRange:";
		static readonly NativeHandle selTextView_CandidatesForSelectedRange_XHandle = Selector.GetHandle ("textView:candidatesForSelectedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ClickedOnCell_InRect_AtIndex_X = "textView:clickedOnCell:inRect:atIndex:";
		static readonly NativeHandle selTextView_ClickedOnCell_InRect_AtIndex_XHandle = Selector.GetHandle ("textView:clickedOnCell:inRect:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ClickedOnLink_AtIndex_X = "textView:clickedOnLink:atIndex:";
		static readonly NativeHandle selTextView_ClickedOnLink_AtIndex_XHandle = Selector.GetHandle ("textView:clickedOnLink:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_X = "textView:completions:forPartialWordRange:indexOfSelectedItem:";
		static readonly NativeHandle selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_XHandle = Selector.GetHandle ("textView:completions:forPartialWordRange:indexOfSelectedItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_X = "textView:didCheckTextInRange:types:options:results:orthography:wordCount:";
		static readonly NativeHandle selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_XHandle = Selector.GetHandle ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_DoCommandBySelector_X = "textView:doCommandBySelector:";
		static readonly NativeHandle selTextView_DoCommandBySelector_XHandle = Selector.GetHandle ("textView:doCommandBySelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_DoubleClickedOnCell_InRect_AtIndex_X = "textView:doubleClickedOnCell:inRect:atIndex:";
		static readonly NativeHandle selTextView_DoubleClickedOnCell_InRect_AtIndex_XHandle = Selector.GetHandle ("textView:doubleClickedOnCell:inRect:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_DraggedCell_InRect_Event_AtIndex_X = "textView:draggedCell:inRect:event:atIndex:";
		static readonly NativeHandle selTextView_DraggedCell_InRect_Event_AtIndex_XHandle = Selector.GetHandle ("textView:draggedCell:inRect:event:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_Menu_ForEvent_AtIndex_X = "textView:menu:forEvent:atIndex:";
		static readonly NativeHandle selTextView_Menu_ForEvent_AtIndex_XHandle = Selector.GetHandle ("textView:menu:forEvent:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldChangeTextInRange_ReplacementString_X = "textView:shouldChangeTextInRange:replacementString:";
		static readonly NativeHandle selTextView_ShouldChangeTextInRange_ReplacementString_XHandle = Selector.GetHandle ("textView:shouldChangeTextInRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldChangeTextInRanges_ReplacementStrings_X = "textView:shouldChangeTextInRanges:replacementStrings:";
		static readonly NativeHandle selTextView_ShouldChangeTextInRanges_ReplacementStrings_XHandle = Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementStrings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldChangeTypingAttributes_ToAttributes_X = "textView:shouldChangeTypingAttributes:toAttributes:";
		static readonly NativeHandle selTextView_ShouldChangeTypingAttributes_ToAttributes_XHandle = Selector.GetHandle ("textView:shouldChangeTypingAttributes:toAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldSelectCandidateAtIndex_X = "textView:shouldSelectCandidateAtIndex:";
		static readonly NativeHandle selTextView_ShouldSelectCandidateAtIndex_XHandle = Selector.GetHandle ("textView:shouldSelectCandidateAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldSetSpellingState_Range_X = "textView:shouldSetSpellingState:range:";
		static readonly NativeHandle selTextView_ShouldSetSpellingState_Range_XHandle = Selector.GetHandle ("textView:shouldSetSpellingState:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_ShouldUpdateTouchBarItemIdentifiers_X = "textView:shouldUpdateTouchBarItemIdentifiers:";
		static readonly NativeHandle selTextView_ShouldUpdateTouchBarItemIdentifiers_XHandle = Selector.GetHandle ("textView:shouldUpdateTouchBarItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_X = "textView:willChangeSelectionFromCharacterRange:toCharacterRange:";
		static readonly NativeHandle selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_XHandle = Selector.GetHandle ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_X = "textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:";
		static readonly NativeHandle selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_XHandle = Selector.GetHandle ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WillCheckTextInRange_Options_Types_X = "textView:willCheckTextInRange:options:types:";
		static readonly NativeHandle selTextView_WillCheckTextInRange_Options_Types_XHandle = Selector.GetHandle ("textView:willCheckTextInRange:options:types:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WillDisplayToolTip_ForCharacterAtIndex_X = "textView:willDisplayToolTip:forCharacterAtIndex:";
		static readonly NativeHandle selTextView_WillDisplayToolTip_ForCharacterAtIndex_XHandle = Selector.GetHandle ("textView:willDisplayToolTip:forCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WritablePasteboardTypesForCell_AtIndex_X = "textView:writablePasteboardTypesForCell:atIndex:";
		static readonly NativeHandle selTextView_WritablePasteboardTypesForCell_AtIndex_XHandle = Selector.GetHandle ("textView:writablePasteboardTypesForCell:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WriteCell_AtIndex_ToPasteboard_Type_X = "textView:writeCell:atIndex:toPasteboard:type:";
		static readonly NativeHandle selTextView_WriteCell_AtIndex_ToPasteboard_Type_XHandle = Selector.GetHandle ("textView:writeCell:atIndex:toPasteboard:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextView_WritingToolsIgnoredRangesInEnclosingRange_X = "textView:writingToolsIgnoredRangesInEnclosingRange:";
		static readonly NativeHandle selTextView_WritingToolsIgnoredRangesInEnclosingRange_XHandle = Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewDidChangeSelection_X = "textViewDidChangeSelection:";
		static readonly NativeHandle selTextViewDidChangeSelection_XHandle = Selector.GetHandle ("textViewDidChangeSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewDidChangeTypingAttributes_X = "textViewDidChangeTypingAttributes:";
		static readonly NativeHandle selTextViewDidChangeTypingAttributes_XHandle = Selector.GetHandle ("textViewDidChangeTypingAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewWritingToolsDidEnd_X = "textViewWritingToolsDidEnd:";
		static readonly NativeHandle selTextViewWritingToolsDidEnd_XHandle = Selector.GetHandle ("textViewWritingToolsDidEnd:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewWritingToolsWillBegin_X = "textViewWritingToolsWillBegin:";
		static readonly NativeHandle selTextViewWritingToolsWillBegin_XHandle = Selector.GetHandle ("textViewWritingToolsWillBegin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUndoManagerForTextView_X = "undoManagerForTextView:";
		static readonly NativeHandle selUndoManagerForTextView_XHandle = Selector.GetHandle ("undoManagerForTextView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateContentX = "validateContent";
		static readonly NativeHandle selValidateContentXHandle = Selector.GetHandle ("validateContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SLComposeServiceViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SLComposeServiceViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SLComposeServiceViewController () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SLComposeServiceViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected SLComposeServiceViewController (NSObjectFlag t) : base (t)
		{
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
		protected internal SLComposeServiceViewController (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="nibName"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new view controller from a named NIB in the provided bundle.</summary><remarks>To be added.</remarks>
		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SLComposeServiceViewController (string? nibName, NSBundle? bundle)
			: base (NSObjectFlag.Empty)
		{
			var bundle__handle__ = bundle.GetHandle ();
			var nsnibName = CFString.CreateNative (nibName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithNibName_Bundle_XHandle, nsnibName, bundle__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithNibName_Bundle_XHandle, nsnibName, bundle__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsnibName);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textView:clickedOnCell:inRect:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellClicked (global::AppKit.NSTextView textView, global::AppKit.NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (this.Handle, selTextView_ClickedOnCell_InRect_AtIndex_XHandle, textView__handle__, cell__handle__, cellFrame, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGRect_UIntPtr (&__objc_super__, selTextView_ClickedOnCell_InRect_AtIndex_XHandle, textView__handle__, cell__handle__, cellFrame, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="textView">To be added.</param><param name="cell">To be added.</param><param name="cellFrame">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textView:doubleClickedOnCell:inRect:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDoubleClicked (global::AppKit.NSTextView textView, global::AppKit.NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_UIntPtr (this.Handle, selTextView_DoubleClickedOnCell_InRect_AtIndex_XHandle, textView__handle__, cell__handle__, cellFrame, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGRect_UIntPtr (&__objc_super__, selTextView_DoubleClickedOnCell_InRect_AtIndex_XHandle, textView__handle__, cell__handle__, cellFrame, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (cell);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeSelection:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSelection (NSNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextViewDidChangeSelection_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextViewDidChangeSelection_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeTypingAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeTypingAttributes (NSNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextViewDidChangeTypingAttributes_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextViewDidChangeTypingAttributes_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="checkingTypes">To be added.</param><param name="options">To be added.</param><param name="results">To be added.</param><param name="orthography">To be added.</param><param name="wordCount">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] DidCheckText (global::AppKit.NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			using var nsa_results = NSArray.FromNSObjects (results);
			NSTextCheckingResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_XHandle, view__handle__, range, (UInt64)checkingTypes, options__handle__, nsa_results.Handle, orthography__handle__, wordCount), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_XHandle, view__handle__, range, (UInt64)checkingTypes, options__handle__, nsa_results.Handle, orthography__handle__, wordCount), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			GC.KeepAlive (orthography);
			return ret!;
		}
		[Export ("didSelectCancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectCancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidSelectCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidSelectCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didSelectPost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPost ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidSelectPostXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidSelectPostXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><param name="commandSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:doCommandBySelector:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoCommandBySelector (global::AppKit.NSTextView textView, Selector commandSelector)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var commandSelector__handle__ = commandSelector!.GetNonNullHandle (nameof (commandSelector));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTextView_DoCommandBySelector_XHandle, textView__handle__, commandSelector.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTextView_DoCommandBySelector_XHandle, textView__handle__, commandSelector.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (commandSelector);
			return ret != 0;
		}
		[Export ("textView:draggedCell:inRect:event:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedCell (global::AppKit.NSTextView view, global::AppKit.NSTextAttachmentCell cell, CGRect rect, global::AppKit.NSEvent theEvent, nuint charIndex)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CGRect_NativeHandle_UIntPtr (this.Handle, selTextView_DraggedCell_InRect_Event_AtIndex_XHandle, view__handle__, cell__handle__, rect, theEvent__handle__, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_CGRect_NativeHandle_UIntPtr (&__objc_super__, selTextView_DraggedCell_InRect_Event_AtIndex_XHandle, view__handle__, cell__handle__, rect, theEvent__handle__, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (theEvent);
		}
		/// <param name="textView">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:candidatesForSelectedRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? GetCandidates (global::AppKit.NSTextView textView, NSRange selectedRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (this.Handle, selTextView_CandidatesForSelectedRange_XHandle, textView__handle__, selectedRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selTextView_CandidatesForSelectedRange_XHandle, textView__handle__, selectedRange), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="words">To be added.</param><param name="charRange">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[] GetCompletions (global::AppKit.NSTextView textView, string[] words, NSRange charRange, ref nint index)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (words is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (words));
			fixed (nint* index__pointer = &index) {
			using var nsa_words = NSArray.FromStrings (words);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange_ref_IntPtr (this.Handle, selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_XHandle, textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange_ref_IntPtr (&__objc_super__, selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_XHandle, textView__handle__, nsa_words.Handle, charRange, index__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
			}
		}
		/// <param name="textView">To be added.</param><param name="candidates">To be added.</param><param name="selectedRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:candidates:forSelectedRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] GetTextCheckingCandidates (global::AppKit.NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (candidates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (candidates));
			using var nsa_candidates = NSArray.FromNSObjects (candidates);
			NSTextCheckingResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NSRange (this.Handle, selTextView_Candidates_ForSelectedRange_XHandle, textView__handle__, nsa_candidates.Handle, selectedRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange (&__objc_super__, selTextView_Candidates_ForSelectedRange_XHandle, textView__handle__, nsa_candidates.Handle, selectedRange), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("undoManagerForTextView:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUndoManager GetUndoManager (global::AppKit.NSTextView view)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSUndoManager? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selUndoManagerForTextView_XHandle, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUndoManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selUndoManagerForTextView_XHandle, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="forCell">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:writablePasteboardTypesForCell:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritablePasteboardTypes (global::AppKit.NSTextView view, global::AppKit.NSTextAttachmentCell forCell, nuint charIndex)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var forCell__handle__ = forCell!.GetNonNullHandle (nameof (forCell));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selTextView_WritablePasteboardTypesForCell_AtIndex_XHandle, view__handle__, forCell__handle__, charIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selTextView_WritablePasteboardTypesForCell_AtIndex_XHandle, view__handle__, forCell__handle__, charIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (forCell);
			return ret!;
		}
		[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (global::AppKit.NSTextView textView, NSRange enclosingRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSValue[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (this.Handle, selTextView_WritingToolsIgnoredRangesInEnclosingRange_XHandle, textView__handle__, enclosingRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selTextView_WritingToolsIgnoredRangesInEnclosingRange_XHandle, textView__handle__, enclosingRange), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		[Export ("isContentValid")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsContentValid ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContentValidXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContentValidXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="link">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:clickedOnLink:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LinkClicked (global::AppKit.NSTextView textView, NSObject link, nuint charIndex)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selTextView_ClickedOnLink_AtIndex_XHandle, textView__handle__, link__handle__, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selTextView_ClickedOnLink_AtIndex_XHandle, textView__handle__, link__handle__, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (link);
			return ret != 0;
		}
		/// <param name="view">To be added.</param><param name="menu">To be added.</param><param name="theEvent">To be added.</param><param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:menu:forEvent:atIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenu MenuForEvent (global::AppKit.NSTextView view, global::AppKit.NSMenu menu, global::AppKit.NSEvent theEvent, nuint charIndex)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			global::AppKit.NSMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (this.Handle, selTextView_Menu_ForEvent_AtIndex_XHandle, view__handle__, menu__handle__, theEvent__handle__, charIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selTextView_Menu_ForEvent_AtIndex_XHandle, view__handle__, menu__handle__, theEvent__handle__, charIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (menu);
			GC.KeepAlive (theEvent);
			return ret!;
		}
		[Export ("presentationAnimationDidFinish")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentationAnimationDidFinish ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPresentationAnimationDidFinishXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPresentationAnimationDidFinishXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><param name="affectedCharRange">To be added.</param><param name="replacementString">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRange:replacementString:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (global::AppKit.NSTextView textView, NSRange affectedCharRange, string replacementString)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (this.Handle, selTextView_ShouldChangeTextInRange_ReplacementString_XHandle, textView__handle__, affectedCharRange, nsreplacementString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NSRange_NativeHandle (&__objc_super__, selTextView_ShouldChangeTextInRange_ReplacementString_XHandle, textView__handle__, affectedCharRange, nsreplacementString);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="affectedRanges">To be added.</param><param name="replacementStrings">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRanges:replacementStrings:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRanges (global::AppKit.NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (affectedRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (affectedRanges));
			if (replacementStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementStrings));
			using var nsa_affectedRanges = NSArray.FromNSObjects (affectedRanges);
			using var nsa_replacementStrings = NSArray.FromStrings (replacementStrings);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTextView_ShouldChangeTextInRanges_ReplacementStrings_XHandle, textView__handle__, nsa_affectedRanges.Handle, nsa_replacementStrings.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTextView_ShouldChangeTextInRanges_ReplacementStrings_XHandle, textView__handle__, nsa_affectedRanges.Handle, nsa_replacementStrings.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="oldTypingAttributes">To be added.</param><param name="newTypingAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTypingAttributes:toAttributes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ShouldChangeTypingAttributes (global::AppKit.NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var oldTypingAttributes__handle__ = oldTypingAttributes!.GetNonNullHandle (nameof (oldTypingAttributes));
			var newTypingAttributes__handle__ = newTypingAttributes!.GetNonNullHandle (nameof (newTypingAttributes));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTextView_ShouldChangeTypingAttributes_ToAttributes_XHandle, textView__handle__, oldTypingAttributes__handle__, newTypingAttributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTextView_ShouldChangeTypingAttributes_ToAttributes_XHandle, textView__handle__, oldTypingAttributes__handle__, newTypingAttributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (oldTypingAttributes);
			GC.KeepAlive (newTypingAttributes);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldSelectCandidateAtIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectCandidates (global::AppKit.NSTextView textView, nuint index)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selTextView_ShouldSelectCandidateAtIndex_XHandle, textView__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selTextView_ShouldSelectCandidateAtIndex_XHandle, textView__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="value">To be added.</param><param name="affectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldSetSpellingState:range:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ShouldSetSpellingState (global::AppKit.NSTextView textView, nint value, NSRange affectedCharRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr_NSRange (this.Handle, selTextView_ShouldSetSpellingState_Range_XHandle, textView__handle__, value, affectedCharRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr_NSRange (&__objc_super__, selTextView_ShouldSetSpellingState_Range_XHandle, textView__handle__, value, affectedCharRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="identifiers">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldUpdateTouchBarItemIdentifiers:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShouldUpdateTouchBarItemIdentifiers (global::AppKit.NSTextView textView, string[] identifiers)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTextView_ShouldUpdateTouchBarItemIdentifiers_XHandle, textView__handle__, nsa_identifiers.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTextView_ShouldUpdateTouchBarItemIdentifiers_XHandle, textView__handle__, nsa_identifiers.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		[Export ("validateContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ValidateContent ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selValidateContentXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selValidateContentXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRange">To be added.</param><param name="newSelectedCharRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange WillChangeSelection (global::AppKit.NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_NSRange_NSRange (this.Handle, selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_XHandle, textView__handle__, oldSelectedCharRange, newSelectedCharRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_NSRange_NSRange (&__objc_super__, selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_XHandle, textView__handle__, oldSelectedCharRange, newSelectedCharRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="oldSelectedCharRanges">To be added.</param><param name="newSelectedCharRanges">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] WillChangeSelectionFromRanges (global::AppKit.NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (oldSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (oldSelectedCharRanges));
			if (newSelectedCharRanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newSelectedCharRanges));
			using var nsa_oldSelectedCharRanges = NSArray.FromNSObjects (oldSelectedCharRanges);
			using var nsa_newSelectedCharRanges = NSArray.FromNSObjects (newSelectedCharRanges);
			NSValue[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_XHandle, textView__handle__, nsa_oldSelectedCharRanges.Handle, nsa_newSelectedCharRanges.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_XHandle, textView__handle__, nsa_oldSelectedCharRanges.Handle, nsa_newSelectedCharRanges.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="range">To be added.</param><param name="options">To be added.</param><param name="checkingTypes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willCheckTextInRange:options:types:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WillCheckText (global::AppKit.NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle_UInt64 (this.Handle, selTextView_WillCheckTextInRange_Options_Types_XHandle, view__handle__, range, options__handle__, (UInt64)checkingTypes), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange_NativeHandle_UInt64 (&__objc_super__, selTextView_WillCheckTextInRange_Options_Types_XHandle, view__handle__, range, options__handle__, (UInt64)checkingTypes), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="textView">To be added.</param><param name="tooltip">To be added.</param><param name="characterIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:willDisplayToolTip:forCharacterAtIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? WillDisplayToolTip (global::AppKit.NSTextView textView, string tooltip, nuint characterIndex)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (tooltip is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tooltip));
			var nstooltip = CFString.CreateNative (tooltip);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selTextView_WillDisplayToolTip_ForCharacterAtIndex_XHandle, textView__handle__, nstooltip, characterIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selTextView_WillDisplayToolTip_ForCharacterAtIndex_XHandle, textView__handle__, nstooltip, characterIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstooltip);
			return ret!;
		}
		/// <param name="view">To be added.</param><param name="cell">To be added.</param><param name="charIndex">To be added.</param><param name="pboard">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:writeCell:atIndex:toPasteboard:type:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteCell (global::AppKit.NSTextView view, global::AppKit.NSTextAttachmentCell cell, nuint charIndex, global::AppKit.NSPasteboard pboard, string type)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, selTextView_WriteCell_AtIndex_ToPasteboard_Type_XHandle, view__handle__, cell__handle__, charIndex, pboard__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selTextView_WriteCell_AtIndex_ToPasteboard_Type_XHandle, view__handle__, cell__handle__, charIndex, pboard__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			GC.KeepAlive (cell);
			GC.KeepAlive (pboard);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("textViewWritingToolsDidEnd:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsDidEnd (global::AppKit.NSTextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextViewWritingToolsDidEnd_XHandle, textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextViewWritingToolsDidEnd_XHandle, textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		[Export ("textViewWritingToolsWillBegin:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsWillBegin (global::AppKit.NSTextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextViewWritingToolsWillBegin_XHandle, textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextViewWritingToolsWillBegin_XHandle, textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? CharactersRemaining {
			[Export ("charactersRemaining", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCharactersRemainingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCharactersRemainingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCharactersRemaining:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCharactersRemaining_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCharactersRemaining_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ContentText {
			[Export ("contentText")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentTextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentTextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Placeholder {
			[Export ("placeholder")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPlaceholder:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPlaceholder_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPlaceholder_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSTextView TextView {
			[Export ("textView")]
			get {
				global::AppKit.NSTextView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SLComposeServiceViewController */
}
