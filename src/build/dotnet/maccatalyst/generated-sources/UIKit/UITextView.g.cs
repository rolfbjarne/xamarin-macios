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
	[Register("UITextView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITextView : UIScrollView, INSCoding, IUIContentSizeCategoryAdjusting, IUIKeyInput, IUILetterformAwareAdjusting, IUIPasteConfigurationSupporting, IUITextDraggable, IUITextDroppable, IUITextInput, IUITextInputTraits, IUITextPasteConfigurationSupporting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UITextView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UITextView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITextView () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public UITextView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected UITextView (NSObjectFlag t) : base (t)
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
		protected internal UITextView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithFrame:textContainer:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextView (CGRect frame, NSTextContainer? textContainer)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("initWithFrame:textContainer:"), frame, textContainer__handle__), "initWithFrame:textContainer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithFrame:textContainer:"), frame, textContainer__handle__), "initWithFrame:textContainer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textContainer);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="point">To be added.</param><summary>Begins displaying the floating cursor at the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[Export ("beginFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginFloatingCursor (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("beginFloatingCursorAtPoint:"), point);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="itemProviders">The ittem providers to check.</param><summary>Returns <see langword="true" /> if the responder can paste from the specified item providers.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canPasteItemProviders:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual bool CanPaste (NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("canPasteItemProviders:"), nsa_itemProviders.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="first">First text position.</param><param name="second">Second text position.</param><summary>Gets a comparison of one position to another.</summary><returns>An indication as to whether two text positions are identical or if one is prior to the other.</returns><remarks>To be added.</remarks>
		[Export ("comparePosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult ComparePosition (UITextPosition first, UITextPosition second)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var first__handle__ = first!.GetNonNullHandle (nameof (first));
			var second__handle__ = second!.GetNonNullHandle (nameof (second));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("comparePosition:toPosition:"), first__handle__, second__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (first);
			GC.KeepAlive (second);
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("deleteBackward")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteBackward ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deleteBackward"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("deleteBackward"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>The recognition of dictation failed.</summary><remarks>To be added.</remarks>
		[Export ("dictationRecognitionFailed")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecognitionFailed ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dictationRecognitionFailed"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dictationRecognitionFailed"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>The recording of dictation ended.</summary><remarks>To be added.</remarks>
		[Export ("dictationRecordingDidEnd")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DictationRecordingDidEnd ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dictationRecordingDidEnd"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dictationRecordingDidEnd"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didDismissWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissWritingTools ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didDismissWritingTools"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didDismissWritingTools"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawTextHighlightBackgroundForTextRange:origin:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawTextHighlightBackground (NSTextRange textRange, CGPoint origin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("drawTextHighlightBackgroundForTextRange:origin:"), textRange__handle__, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("drawTextHighlightBackgroundForTextRange:origin:"), textRange__handle__, origin);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <summary>Ends display of the floating cursor.</summary><remarks>To be added.</remarks>
		[Export ("endFloatingCursor")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndFloatingCursor ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endFloatingCursor"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("endFloatingCursor"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("attributedTextInRange:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedText (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSAttributedString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("attributedTextInRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="forPosition">A positioning object that indicates a specified location.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets the base writing direction for a text position.</summary><returns>A text-range object that represents the distance from position to the farthest extent in a given direction.</returns><remarks>To be added.</remarks>
		[Export ("baseWritingDirectionForPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWritingDirection GetBaseWritingDirection (UITextPosition forPosition, UITextStorageDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			NSWritingDirection ret;
			if (IsDirectBinding) {
				ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("baseWritingDirectionForPosition:inDirection:"), forPosition__handle__, (IntPtr) (long) direction);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="position">A positioning object that indicates a specified location.</param><summary>A rectangle used for drawing a caret at a given insertion point.</summary><returns>A rectangle defining an area for drawing a caret.</returns><remarks>To be added.</remarks>
		[Export ("caretRectForPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetCaretRectForPosition (UITextPosition? position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("caretRectForPosition:"), position__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (position);
			return ret!;
		}
		[Export ("caretTransformForPosition:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform GetCaretTransform (UITextPosition forPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var forPosition__handle__ = forPosition!.GetNonNullHandle (nameof (forPosition));
			CGAffineTransform ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("caretTransformForPosition:"), forPosition__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (forPosition);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="range">To be added.</param><summary>Calculates and returns the offset into <paramref name="range" /> of the character that is in <paramref name="position" /> in the document.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterOffsetOfPosition:withinRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetCharacterOffsetOfPosition (UITextPosition position, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var position__handle__ = position!.GetNonNullHandle (nameof (position));
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("characterOffsetOfPosition:withinRange:"), position__handle__, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (position);
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="byExtendingPosition">A text positioning object identifying a location in a document.</param><param name="direction">Constant indicating layout direction.</param><summary>Gets a character range within the limits of a defined direction.</summary><returns>Gets a range from a given text position to the ultimate extent in a defined direction.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeByExtendingPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRange (UITextPosition byExtendingPosition, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var byExtendingPosition__handle__ = byExtendingPosition!.GetNonNullHandle (nameof (byExtendingPosition));
			UITextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("characterRangeByExtendingPosition:inDirection:"), byExtendingPosition__handle__, (IntPtr) (long) direction), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (byExtendingPosition);
			return ret!;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the character or a range of characters in a document that exists at a given point.</summary><returns>Gets the point in a view where the document text is being drawn.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeAtPoint:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetCharacterRangeAtPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("characterRangeAtPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">Point in a view where document text is being drawn.</param><summary>Gets the closest position in a document that exists to a given point.</summary><returns>The closest position to the point. </returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("closestPositionToPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="point">To be added.</param><param name="withinRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("closestPositionToPoint:withinRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetClosestPositionToPoint (CGPoint point, UITextRange withinRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("closestPositionToPoint:withinRange:"), point, withinRange__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (withinRange);
			return ret!;
		}
		[Export ("editMenuForTextRange:suggestedActions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetEditMenu (UITextRange textRange, UIMenuElement[] suggestedActions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			UIMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("editMenuForTextRange:suggestedActions:"), textRange__handle__, nsa_suggestedActions.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
			return ret!;
		}
		/// <param name="range">	
		/// A UITextRange object indicating the range of a document's text.</param><summary>Gets the first rectangle enclosing a specified range of document text.</summary><returns>The first rectangle enclosing a specified range.</returns><remarks>To be added.</remarks>
		[Export ("firstRectForRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFirstRectForRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("firstRectForRange:"), range__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("firstRectForRange:"), range__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("firstRectForRange:"), range__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="placeholder">To be added.</param><summary>Returns the rectangle in which to display the animated dictation result placeholder.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("frameForDictationResultPlaceholder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForDictationResultPlaceholder (NSObject placeholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("frameForDictationResultPlaceholder:"), placeholder__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (placeholder);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets the number of visible characters between two defined text positions.</summary><returns>The number of visible characters between the two specified text positions.</returns><remarks>To be added.</remarks>
		[Export ("offsetFromPosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetOffsetFromPosition (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("offsetFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from the initial position.</summary><returns>The specified character offset.</returns><remarks>To be added.</remarks>
		[Export ("positionFromPosition:offset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionFromPosition:offset:"), fromPosition__handle__, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position</param><param name="inDirection">A constant indicating either backward or forward direction for storage.</param><param name="offset">Character offset from the initial position.</param><summary>Gets the character offset from an initial position.</summary><returns>The specified character offset.</returns><remarks>This can be either a positive or negative value.</remarks>
		[Export ("positionFromPosition:inDirection:offset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextPosition fromPosition, UITextLayoutDirection inDirection, nint offset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("positionFromPosition:inDirection:offset:"), fromPosition__handle__, (IntPtr) (long) inDirection, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			return ret!;
		}
		/// <param name="withinRange">To be added.</param><param name="atCharacterOffset">To be added.</param><summary>Calculates and returns the absolute position in the document that is <paramref name="atCharacterOffset" /> characters into <paramref name="withinRange" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("positionWithinRange:atCharacterOffset:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPosition (UITextRange withinRange, nint atCharacterOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var withinRange__handle__ = withinRange!.GetNonNullHandle (nameof (withinRange));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionWithinRange:atCharacterOffset:"), withinRange__handle__, atCharacterOffset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (withinRange);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><param name="direction">A constant indicating direction for storage.</param><summary>Gets a position within a specified range.</summary><returns>A position within a specified range.</returns><remarks>To be added.</remarks>
		[Export ("positionWithinRange:farthestInDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPosition GetPositionWithinRange (UITextRange range, UITextLayoutDirection direction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("positionWithinRange:farthestInDirection:"), range__handle__, (IntPtr) (long) direction), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets an array of selection rects that corresponds to a text range.</summary><returns>An array of selection rects.</returns><remarks>To be added.</remarks>
		[Export ("selectionRectsForRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextSelectionRect[] GetSelectionRects (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			UITextSelectionRect[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UITextSelectionRect>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("selectionRectsForRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <param name="fromPosition">Initial text position.</param><param name="toPosition">Ultimate text position.</param><summary>Gets a specified text range.</summary><returns>Defined text range.</returns><remarks>To be added.</remarks>
		[Export ("textRangeFromPosition:toPosition:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextRange GetTextRange (UITextPosition fromPosition, UITextPosition toPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromPosition__handle__ = fromPosition!.GetNonNullHandle (nameof (fromPosition));
			var toPosition__handle__ = toPosition!.GetNonNullHandle (nameof (toPosition));
			UITextRange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textRangeFromPosition:toPosition:"), fromPosition__handle__, toPosition__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromPosition);
			GC.KeepAlive (toPosition);
			return ret!;
		}
		/// <param name="atPosition">To be added.</param><param name="inDirection">To be added.</param><summary>Returns a dictionary of style properties for text at the <paramref name="atPosition" /> position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textStylingAtPosition:inDirection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetTextStyling (UITextPosition atPosition, UITextStorageDirection inDirection)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var atPosition__handle__ = atPosition!.GetNonNullHandle (nameof (atPosition));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("textStylingAtPosition:inDirection:"), atPosition__handle__, (IntPtr) (long) inDirection), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (atPosition);
			return ret!;
		}
		[Export ("textViewUsingTextLayoutManager:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITextView GetTextView (bool usingTextLayoutManager)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextView ret;
			ret =  Runtime.GetNSObject<UITextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, Selector.GetHandle ("textViewUsingTextLayoutManager:"), usingTextLayoutManager ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, UITextRange replacementRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var replacementRange__handle__ = replacementRange!.GetNonNullHandle (nameof (replacementRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:"), adaptiveImageGlyph__handle__, replacementRange__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (replacementRange);
		}
		[Export ("insertAttributedText:")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAttributedText (NSAttributedString text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertAttributedText:"), text__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertAttributedText:"), text__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (text);
		}
		/// <param name="dictationResult">To be added.</param><summary>Inserts a dictation result at the current position.</summary><remarks>To be added.</remarks>
		[Export ("insertDictationResult:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDictationResult (NSArray dictationResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dictationResult__handle__ = dictationResult!.GetNonNullHandle (nameof (dictationResult));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertDictationResult:"), dictationResult__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dictationResult);
		}
		/// <summary>Returns the placeholder object to use before dictation results are finished being generated.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("insertDictationResultPlaceholder")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject InsertDictationResultPlaceholder ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("insertDictationResultPlaceholder")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertText:alternatives:style:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (string text, string[] alternatives, UITextAlternativeStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			if (alternatives is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternatives));
			var nstext = CFString.CreateNative (text);
			using var nsa_alternatives = NSArray.FromStrings (alternatives);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertText:alternatives:style:"), nstext, nsa_alternatives.Handle, (IntPtr) (long) style);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
		}
		/// <param name="text">To be added.</param><summary>Inserts text at the cursor.</summary><remarks>To be added.</remarks>
		[Export ("insertText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertText:"), nstext);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("insertText:"), nstext);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstext);
		}
		[Export ("insertTextPlaceholderWithSize:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextPlaceholder InsertTextPlaceholder (CGSize size)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPlaceholder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITextPlaceholder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("insertTextPlaceholderWithSize:"), size), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="itemProviders">The item providers for the items to paste.</param><summary>Performs the paste.</summary><remarks>To be added.</remarks>
		[Export ("pasteItemProviders:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void Paste (NSItemProvider[] itemProviders)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pasteItemProviders:"), nsa_itemProviders.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="placeholder">To be added.</param><param name="willInsertResult">To be added.</param><summary>The <paramref name="placeholder" /> is no longer needed.</summary><remarks>To be added.</remarks>
		[Export ("removeDictationResultPlaceholder:willInsertResult:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDictationResultPlaceholder (NSObject placeholder, bool willInsertResult)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("removeDictationResultPlaceholder:willInsertResult:"), placeholder__handle__, willInsertResult ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (placeholder);
		}
		[Export ("removeTextPlaceholder:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextPlaceholder (UITextPlaceholder textPlaceholder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textPlaceholder__handle__ = textPlaceholder!.GetNonNullHandle (nameof (textPlaceholder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeTextPlaceholder:"), textPlaceholder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textPlaceholder);
		}
		[Export ("replaceRange:withAttributedText:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceRange (UITextRange range, NSAttributedString attributedText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var attributedText__handle__ = attributedText!.GetNonNullHandle (nameof (attributedText));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceRange:withAttributedText:"), range__handle__, attributedText__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			GC.KeepAlive (attributedText);
		}
		/// <param name="range">The range of text to be replaced.</param><param name="text">A string defining text replacement within a "range".</param><summary>Replaces document text within a specified range.</summary><remarks>To be added.</remarks>
		[Export ("replaceRange:withText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceText (UITextRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceRange:withText:"), range__handle__, nstext);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			CFString.ReleaseNative (nstext);
		}
		[Export ("scrollRangeToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRangeToVisible (NSRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("scrollRangeToVisible:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("scrollRangeToVisible:"), range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setAttributedMarkedText:selectedRange:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributedMarkedText (NSAttributedString? markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var markedText__handle__ = markedText.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setAttributedMarkedText:selectedRange:"), markedText__handle__, selectedRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markedText);
		}
		/// <param name="writingDirection">Constant indicating layout direction.</param><param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Sets a base direction for writing in the specified range of text.</summary><remarks>To be added.</remarks>
		[Export ("setBaseWritingDirection:forRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBaseWritingDirectionforRange (NSWritingDirection writingDirection, UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("setBaseWritingDirection:forRange:"), (IntPtr) (long) writingDirection, range__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
		}
		/// <param name="markedText">Text that is to be marked.</param><param name="selectedRange">An NSRange object indicating the range of a document's text.</param><summary>Sets the marked text and marks it as the current selection.</summary><remarks>To be added.</remarks>
		[Export ("setMarkedText:selectedRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (string markedText, NSRange selectedRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (markedText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markedText));
			var nsmarkedText = CFString.CreateNative (markedText);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setMarkedText:selectedRange:"), nsmarkedText, selectedRange);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmarkedText);
		}
		/// <param name="inRange">To be added.</param><param name="replacementText">To be added.</param><summary>Asks whether the text in <paramref name="inRange" /> should be replaced with <paramref name="replacementText" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldChangeTextInRange:replacementText:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (UITextRange inRange, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var inRange__handle__ = inRange!.GetNonNullHandle (nameof (inRange));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldChangeTextInRange:replacementText:"), inRange__handle__, nsreplacementText);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inRange);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		/// <param name="range">A UITextRange object indicating the range of a document's text.</param><summary>Gets all the text that is specified within a certain range.</summary><returns>Document substring falling within a certain specified range.</returns><remarks>To be added.</remarks>
		[Export ("textInRange:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TextInRange (UITextRange range)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textInRange:"), range__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (range);
			return ret!;
		}
		/// <summary>Unmarks all currently marked text within a document</summary><remarks>Subsequent to this method being called, the value of "MarkedTextRange" is set to <see langword="null" />.</remarks>
		[Export ("unmarkText")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unmarkText"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unmarkText"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="point">To be added.</param><summary>Moves the floating curor to the specified <paramref name="point" />.</summary><remarks>To be added.</remarks>
		[Export ("updateFloatingCursorAtPoint:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFloatingCursor (CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("updateFloatingCursorAtPoint:"), point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willDismissEditMenuWithAnimator:"), animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animator);
		}
		[Export ("willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (IUIEditMenuInteractionAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willPresentEditMenuWithAnimator:"), animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animator);
		}
		[Export ("willPresentWritingTools")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentWritingTools ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("willPresentWritingTools"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("willPresentWritingTools"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AdjustsFontForContentSizeCategory {
			[Export ("adjustsFontForContentSizeCategory")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("adjustsFontForContentSizeCategory"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("adjustsFontForContentSizeCategory"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAdjustsFontForContentSizeCategory:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdjustsFontForContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAdjustsFontForContentSizeCategory:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual UIWritingToolsResultOptions AllowedWritingToolsResultOptions {
			[Export ("allowedWritingToolsResultOptions", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWritingToolsResultOptions ret;
				if (IsDirectBinding) {
					ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allowedWritingToolsResultOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowedWritingToolsResultOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAllowedWritingToolsResultOptions:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setAllowedWritingToolsResultOptions:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEditingTextAttributes {
			[Export ("allowsEditingTextAttributes")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsEditingTextAttributes"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsEditingTextAttributes"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEditingTextAttributes:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsEditingTextAttributes:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsEditingTextAttributes:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool AllowsNumberPadPopover {
			[Export ("allowsNumberPadPopover")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsNumberPadPopover"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsNumberPadPopover"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsNumberPadPopover:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsNumberPadPopover:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString AttributedText {
			[Export ("attributedText", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributedText")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributedText")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedText:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttributedText:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAttributedText:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocapitalizationType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextAutocapitalizationType AutocapitalizationType {
			[Export ("autocapitalizationType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAutocapitalizationType ret;
				if (IsDirectBinding) {
					ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("autocapitalizationType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextAutocapitalizationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autocapitalizationType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutocapitalizationType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAutocapitalizationType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The <see cref="T:UIKit.UITextAutocorrectionType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextAutocorrectionType AutocorrectionType {
			[Export ("autocorrectionType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAutocorrectionType ret;
				if (IsDirectBinding) {
					ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("autocorrectionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextAutocorrectionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autocorrectionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutocorrectionType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAutocorrectionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the beginning of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextPosition BeginningOfDocument {
			[Export ("beginningOfDocument")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("beginningOfDocument")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("beginningOfDocument")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UITextViewBorderStyle BorderStyle {
			[Export ("borderStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextViewBorderStyle ret;
				if (IsDirectBinding) {
					ret = (UITextViewBorderStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("borderStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextViewBorderStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("borderStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBorderStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBorderStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setBorderStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsOnInsertion {
			[Export ("clearsOnInsertion")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsOnInsertion"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsOnInsertion"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsOnInsertion:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsOnInsertion:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsOnInsertion:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual UIDataDetectorType DataDetectorTypes {
			[Export ("dataDetectorTypes")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDataDetectorType ret;
				if (IsDirectBinding) {
					ret = (UIDataDetectorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataDetectorTypes"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIDataDetectorType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataDetectorTypes"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDataDetectorTypes:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setDataDetectorTypes:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setDataDetectorTypes:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the UIKit.IUITextViewDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUITextViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new IUITextViewDelegate Delegate {
			get {
				return (WeakDelegate as IUITextViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>This property determines if the text view is editable or not.</summary><altmember cref="P:UIKit.UITextView.AllowsEditingTextAttributes" /><altmember cref="P:UIKit.UITextView.AttributedText" /><altmember cref="P:UIKit.UITextView.DataDetectorTypes" /><altmember cref="P:UIKit.UITextView.Font" /><altmember cref="P:UIKit.UITextView.Text" /><altmember cref="P:UIKit.UITextView.TextAlignment" /><altmember cref="P:UIKit.UITextView.TextColor" /><altmember cref="P:UIKit.UITextView.TypingAttributes" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEditable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEditable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEditable:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEditable:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEditable:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the return key is automatically enabled.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool EnablesReturnKeyAutomatically {
			[Export ("enablesReturnKeyAutomatically")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enablesReturnKeyAutomatically"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enablesReturnKeyAutomatically"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnablesReturnKeyAutomatically:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnablesReturnKeyAutomatically:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The position of text indicating the beginning of a document.</summary><value>Gets the end of the document.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextPosition EndOfDocument {
			[Export ("endOfDocument")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("endOfDocument")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("endOfDocument")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIFindInteraction? FindInteraction {
			[Export ("findInteraction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIFindInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIFindInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("findInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIFindInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("findInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual bool FindInteractionEnabled {
			[Export ("isFindInteractionEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isFindInteractionEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isFindInteractionEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFindInteractionEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFindInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setFindInteractionEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFont? Font {
			[Export ("font", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIFont? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("font")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("font")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFont:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFont:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setFont:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets a value that tells whether the key input has text in it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool HasText {
			[Export ("hasText")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasText"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasText"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextInlinePredictionType InlinePredictionType {
			[Export ("inlinePredictionType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextInlinePredictionType ret;
				if (IsDirectBinding) {
					ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inlinePredictionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextInlinePredictionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inlinePredictionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInlinePredictionType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setInlinePredictionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? InputAccessoryView {
			[Export ("inputAccessoryView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputAccessoryView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputAccessoryView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputAccessoryView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputAccessoryView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputAccessoryView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The input delegate object for this <see cref="T:UIKit.UITextField" />.</summary><value>The default value is a system-provided <see cref="T:UIKit.UITextInputDelegate" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IUITextInputDelegate InputDelegate {
			get {
				return (WeakInputDelegate as IUITextInputDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakInputDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? InputView {
			[Export ("inputView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInputView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject InteractionState {
			[Export ("interactionState", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("interactionState")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("interactionState")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInteractionState:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInteractionState:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInteractionState:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardAppearance" /> used by the <see cref="T:UIKit.IUITextInput" /></summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.UIKeyboardAppearance KeyboardAppearance {
			[Export ("keyboardAppearance")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIKeyboardAppearance ret;
				if (IsDirectBinding) {
					ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keyboardAppearance"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIKeyboardAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyboardAppearance"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyboardAppearance:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setKeyboardAppearance:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The <see cref="T:UIKit.UIKeyboardType" /> used by the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIKeyboardType KeyboardType {
			[Export ("keyboardType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIKeyboardType ret;
				if (IsDirectBinding) {
					ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keyboardType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIKeyboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyboardType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setKeyboardType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setKeyboardType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutManager LayoutManager {
			[Export ("layoutManager", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("layoutManager")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutManager")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The currently marked range of text in a given document.</summary><value>If there is no text marked, the value is <see langword="null" />; all else  is provisionally inserted requiring user confirmation.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextRange MarkedTextRange {
			[Export ("markedTextRange")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("markedTextRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Attribute dictionary describing how text should be drawn.</summary><value>Strings indicating style definition.</value><remarks>This is marked to indicate the necessity for unique visual treatment in display.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSDictionary? MarkedTextStyle {
			[Export ("markedTextStyle", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("markedTextStyle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("markedTextStyle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMarkedTextStyle:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMarkedTextStyle:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		public virtual UITextMathExpressionCompletionType MathExpressionCompletionType {
			[Export ("mathExpressionCompletionType")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextMathExpressionCompletionType ret;
				if (IsDirectBinding) {
					ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mathExpressionCompletionType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextMathExpressionCompletionType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mathExpressionCompletionType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMathExpressionCompletionType:")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setMathExpressionCompletionType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The password entry rules.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextInputPasswordRules? PasswordRules {
			[Export ("passwordRules", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextInputPasswordRules? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("passwordRules")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextInputPasswordRules> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("passwordRules")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPasswordRules:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasswordRules:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasswordRules:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The <see cref="T:UIKit.UIPasteConfiguration" /> supported by <see langword="this" /> object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIPasteConfiguration? PasteConfiguration {
			[Export ("pasteConfiguration", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPasteConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIPasteConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pasteConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPasteConfiguration:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasteConfiguration:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PasteDelegate_var;
		/// <summary>Gets the delegate for handling text pasting and text drops.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextPasteDelegate? PasteDelegate {
			[Export ("pasteDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextPasteDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextPasteDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pasteDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PasteDelegate_var = ret;
				return ret!;
			}
			[Export ("setPasteDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPasteDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_PasteDelegate_var = value;
			}
		}
		/// <summary>The form of the return key for the <see cref="T:UIKit.IUITextInput" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIReturnKeyType ReturnKeyType {
			[Export ("returnKeyType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIReturnKeyType ret;
				if (IsDirectBinding) {
					ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("returnKeyType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIReturnKeyType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("returnKeyType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReturnKeyType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setReturnKeyType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the entered text should be hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SecureTextEntry {
			[Export ("isSecureTextEntry")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSecureTextEntry"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSecureTextEntry"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSecureTextEntry:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSecureTextEntry:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the application user can select content and interact with links and text attachments.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks><altmember cref="P:UIKit.UITextView.ClearsOnInsertion" /><altmember cref="M:UIKit.UITextView.ScrollRangeToVisible(Foundation.NSRange)" /><altmember cref="P:UIKit.UITextView.SelectedRange" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Selectable {
			[Export ("isSelectable")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelectable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSelectable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelectable:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSelectable:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSelectable:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange SelectedRange {
			[Export ("selectedRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("selectedRange"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedRange"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedRange:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setSelectedRange:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("setSelectedRange:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindAs (typeof (NSRange[]), OriginalType = typeof (NSValue[]))]
		public virtual NSRange[] SelectedRanges {
			[Export ("selectedRanges", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSRange[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <NSRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedRanges")), NSValue.ToNSRange, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <NSRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedRanges")), NSValue.ToNSRange, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedRanges:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_SelectedRanges = NSArray.FromNSObjects (o => NSValue.FromRange (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedRanges:"), nsb_SelectedRanges.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedRanges:"), nsb_SelectedRanges.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_SelectedRanges?.Dispose ();
			}
		}
		/// <summary>The range of a document's selected text.</summary><value>If there is no current specified selection, then it is set to <see langword="null" />.</value><remarks>If the specified range has length, it specifies currently selected text; if zero length, it specifies only the caret at the insertion point.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedTextRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedTextRange:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedTextRange:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>A value that controls whether the cursor is displayed at the start of the last line or end of the second-to-last line of a multiline selection.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextStorageDirection SelectionAffinity {
			[Export ("selectionAffinity")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextStorageDirection ret;
				if (IsDirectBinding) {
					ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionAffinity"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextStorageDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectionAffinity"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionAffinity:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectionAffinity:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UILetterformAwareSizingRule SizingRule {
			[Export ("sizingRule", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILetterformAwareSizingRule ret;
				if (IsDirectBinding) {
					ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sizingRule"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UILetterformAwareSizingRule) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sizingRule"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSizingRule:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSizingRule:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart dashes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartDashesType SmartDashesType {
			[Export ("smartDashesType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartDashesType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartDashesType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartDashesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartDashesType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartDashesType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartDashesType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart insert style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartInsertDeleteType SmartInsertDeleteType {
			[Export ("smartInsertDeleteType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartInsertDeleteType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartInsertDeleteType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartInsertDeleteType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartInsertDeleteType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartInsertDeleteType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartInsertDeleteType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The smart quotes style.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITextSmartQuotesType SmartQuotesType {
			[Export ("smartQuotesType", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSmartQuotesType ret;
				if (IsDirectBinding) {
					ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("smartQuotesType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSmartQuotesType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("smartQuotesType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSmartQuotesType:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSmartQuotesType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that tells whether spell-checking is on, off, or if spell-checking will be enabled only when auto-complete is enabled (default).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextSpellCheckingType SpellCheckingType {
			[Export ("spellCheckingType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextSpellCheckingType ret;
				if (IsDirectBinding) {
					ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("spellCheckingType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextSpellCheckingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("spellCheckingType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSpellCheckingType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSpellCheckingType:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("ios18.4")]
		public virtual Class SubclassForWritingToolsCoordinator {
			[Export ("subclassForWritingToolsCoordinator")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("subclassForWritingToolsCoordinator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("subclassForWritingToolsCoordinator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("supportsAdaptiveImageGlyph"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSupportsAdaptiveImageGlyph:")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSupportsAdaptiveImageGlyph:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Text {
			[Export ("text", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("text")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("text")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setText:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setText:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setText:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITextAlignment TextAlignment {
			[Export ("textAlignment")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextAlignment ret;
				if (IsDirectBinding) {
					ret = UITextAlignmentExtensions.ToManaged ((nint) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textAlignment")));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = UITextAlignmentExtensions.ToManaged ((nint) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textAlignment")));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextAlignment:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextAlignment:"), (IntPtr) UITextAlignmentExtensions.ToNative (value));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTextAlignment:"), (IntPtr) UITextAlignmentExtensions.ToNative (value));
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? TextColor {
			[Export ("textColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextColor:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer TextContainer {
			[Export ("textContainer", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIEdgeInsets TextContainerInset {
			[Export ("textContainerInset", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("textContainerInset"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("textContainerInset"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textContainerInset"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("textContainerInset"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTextContainerInset:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setTextContainerInset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setTextContainerInset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The semantic of the expected input, which allows the system to, for example, provide custom keyboards.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString TextContentType {
			[Export ("textContentType")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textContentType")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textContentType")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextContentType:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextContentType:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextContentType:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets a Boolean value that tells whether a drag session is active for the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool TextDragActive {
			[Export ("isTextDragActive")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextDragActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTextDragActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextDragDelegate_var;
		/// <summary>Gets or sets a delegate for managing drag source behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextDragDelegate? TextDragDelegate {
			[Export ("textDragDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextDragDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextDragDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextDragDelegate_var = ret;
				return ret!;
			}
			[Export ("setTextDragDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextDragDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextDragDelegate_var = value;
			}
		}
		/// <summary>Gets the drag interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIDragInteraction? TextDragInteraction {
			[Export ("textDragInteraction")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDragInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDragInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIDragInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets a value that controls how formatting is displayed in dragged text.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UITextDragOptions TextDragOptions {
			[Export ("textDragOptions", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextDragOptions ret;
				if (IsDirectBinding) {
					ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textDragOptions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITextDragOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDragOptions"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextDragOptions:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTextDragOptions:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets a Boolean value that tells whether there is an active text drop session on the view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool TextDropActive {
			[Export ("isTextDropActive")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTextDropActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTextDropActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextDropDelegate_var;
		/// <summary>Gets or sets a delegate for managing text drop behavior.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IUITextDropDelegate? TextDropDelegate {
			[Export ("textDropDelegate", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUITextDropDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IUITextDropDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDropDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IUITextDropDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDropDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextDropDelegate_var = ret;
				return ret!;
			}
			[Export ("setTextDropDelegate:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextDropDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextDropDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextDropDelegate_var = value;
			}
		}
		/// <summary>Gets the drop interaction on the text view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIDropInteraction? TextDropInteraction {
			[Export ("textDropInteraction")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDropInteraction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIDropInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textDropInteraction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIDropInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textDropInteraction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual NSDictionary<NSString, NSObject>? TextHighlightAttributes {
			[Export ("textHighlightAttributes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textHighlightAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textHighlightAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextHighlightAttributes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextHighlightAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextHighlightAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Returns the input view that provides the coordinate system for geometric operations within the text input.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIView TextInputView {
			[Export ("textInputView")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textInputView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textInputView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual NSTextLayoutManager? TextLayoutManager {
			[Export ("textLayoutManager")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textLayoutManager")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textLayoutManager")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextStorage TextStorage {
			[Export ("textStorage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textStorage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textStorage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>This property provides information on the tokenizer that would be used to break up the text into units such as characters, words, lines, and paragraphs.</summary><value></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IUITextInputTokenizer Tokenizer {
			get {
				return (WeakTokenizer as IUITextInputTokenizer)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use 'TypingAttributes2' instead, because this property will return null instead of an empty dictionary.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual NSDictionary? TypingAttributes {
			[Export ("typingAttributes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (SelectedRange.Length == 0) return null;
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typingAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("typingAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypingAttributes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary? TypingAttributes2 {
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typingAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("typingAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTypingAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.4")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public virtual CGRect UnobscuredContentRect {
			[Export ("unobscuredContentRect")]
			[SupportedOSPlatform ("ios26.4")]
			[SupportedOSPlatform ("tvos26.4")]
			[SupportedOSPlatform ("maccatalyst26.4")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("unobscuredContentRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unobscuredContentRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("unobscuredContentRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool UsesStandardTextScaling {
			[Export ("usesStandardTextScaling")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesStandardTextScaling"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("usesStandardTextScaling"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesStandardTextScaling:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesStandardTextScaling:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUsesStandardTextScaling:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakInputDelegate_var;
		/// <summary>Indicates a weak input delegate.</summary><value>Automatically assigned at runtime.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject? WeakInputDelegate {
			[Export ("inputDelegate", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("inputDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakInputDelegate_var = ret;
				return ret!;
			}
			[Export ("setInputDelegate:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setInputDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakInputDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WeakLinkTextAttributes {
			[Export ("linkTextAttributes", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("linkTextAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("linkTextAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLinkTextAttributes:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLinkTextAttributes:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setLinkTextAttributes:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Indicates a weak tokenizer.</summary><value>Standard units of granularity including characters, words, lines, and paragraphs.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject WeakTokenizer {
			[Export ("tokenizer")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tokenizer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tokenizer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual bool WritingToolsActive {
			[Export ("isWritingToolsActive")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWritingToolsActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isWritingToolsActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("ios18.0")]
		public virtual UIWritingToolsBehavior WritingToolsBehavior {
			[Export ("writingToolsBehavior", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWritingToolsBehavior ret;
				if (IsDirectBinding) {
					ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("writingToolsBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("writingToolsBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setWritingToolsBehavior:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setWritingToolsBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("ios18.2")]
		public virtual UIWritingToolsCoordinator WritingToolsCoordinator {
			[Export ("writingToolsCoordinator")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIWritingToolsCoordinator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIWritingToolsCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("writingToolsCoordinator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIWritingToolsCoordinator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("writingToolsCoordinator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentInputModeDidChangeNotification;
		/// <summary>Notification constant for CurrentInputModeDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCurrentInputModeDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCurrentInputModeDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UITextView.Notifications.ObserveCurrentInputModeDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UITextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextView.Notifications.ObserveCurrentInputModeDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UITextView.CurrentInputModeDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification CurrentInputModeDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification CurrentInputModeDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextView.CurrentInputModeDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextInputCurrentInputModeDidChangeNotification",  "UIKit")]
		[Advice ("Use UITextView.Notifications.ObserveCurrentInputModeDidChange helper method instead.")]
		public static NSString CurrentInputModeDidChangeNotification {
			get {
				if (_CurrentInputModeDidChangeNotification is null)
					_CurrentInputModeDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputCurrentInputModeDidChangeNotification")!;
				return _CurrentInputModeDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextBackgroundColorKey;
		/// <summary>Developers should not use this deprecated property. Developers should use 'NSAttributedString.BackgroundColorAttributeName'.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextBackgroundColorKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextBackgroundColorKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.BackgroundColorAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextBackgroundColorKey is null)
					_TextBackgroundColorKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextBackgroundColorKey")!;
				return _TextBackgroundColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextColorKey;
		/// <summary>The property holds the key that should be used to retrieve the value of the text color from a <see cref="T:Foundation.NSDictionary" />.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextColorKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextColorKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.ForegroundColorAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextColorKey is null)
					_TextColorKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextColorKey")!;
				return _TextColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextDidBeginEditingNotification;
		/// <summary>Notification constant for TextDidBeginEditing</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextDidBeginEditing(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextDidBeginEditing(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UITextView.Notifications.ObserveTextDidBeginEditing ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UITextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextView.Notifications.ObserveTextDidBeginEditing (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UITextView.TextDidBeginEditingNotification, (notification) => { Console.WriteLine ("Received the notification TextDidBeginEditing", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextDidBeginEditing", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextView.TextDidBeginEditingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextViewTextDidBeginEditingNotification",  "UIKit")]
		[Advice ("Use UITextView.Notifications.ObserveTextDidBeginEditing helper method instead.")]
		public static NSString TextDidBeginEditingNotification {
			get {
				if (_TextDidBeginEditingNotification is null)
					_TextDidBeginEditingNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextViewTextDidBeginEditingNotification")!;
				return _TextDidBeginEditingNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextDidChangeNotification;
		/// <summary>Notification constant for TextDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UITextView.Notifications.ObserveTextDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UITextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextView.Notifications.ObserveTextDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UITextView.TextDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification TextDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextView.TextDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextViewTextDidChangeNotification",  "UIKit")]
		[Advice ("Use UITextView.Notifications.ObserveTextDidChange helper method instead.")]
		public static NSString TextDidChangeNotification {
			get {
				if (_TextDidChangeNotification is null)
					_TextDidChangeNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextViewTextDidChangeNotification")!;
				return _TextDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextDidEndEditingNotification;
		/// <summary>Notification constant for TextDidEndEditing</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextDidEndEditing(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextDidEndEditing(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = UITextView.Notifications.ObserveTextDidEndEditing ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, UITextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UITextView.Notifications.ObserveTextDidEndEditing (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     UITextView.TextDidEndEditingNotification, (notification) => { Console.WriteLine ("Received the notification TextDidEndEditing", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextDidEndEditing", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UITextView.TextDidEndEditingNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UITextViewTextDidEndEditingNotification",  "UIKit")]
		[Advice ("Use UITextView.Notifications.ObserveTextDidEndEditing helper method instead.")]
		public static NSString TextDidEndEditingNotification {
			get {
				if (_TextDidEndEditingNotification is null)
					_TextDidEndEditingNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextViewTextDidEndEditingNotification")!;
				return _TextDidEndEditingNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextFontKey;
		/// <summary>The property holds the key that should be used to retrieve the value of the font for the text from a <see cref="T:Foundation.NSDictionary" />.</summary><value></value><remarks>To be added.</remarks>
		[Field ("UITextInputTextFontKey",  "UIKit")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.FontAttributeName'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.FontAttributeName'.")]
		[SupportedOSPlatform ("ios")]
		public static NSString TextFontKey {
			[ObsoletedOSPlatform ("ios8.0", "Use 'NSAttributedString.FontAttributeName'.")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSAttributedString.FontAttributeName'.")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_TextFontKey is null)
					_TextFontKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextInputTextFontKey")!;
				return _TextFontKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal override Type GetInternalEventDelegateType
		{
			get { return typeof (_UITextViewDelegate); }
		}
		internal override _UIScrollViewDelegate CreateInternalEventDelegateType ()
		{
			return (_UIScrollViewDelegate)(new _UITextViewDelegate());
		}
		internal _UITextViewDelegate EnsureUITextViewDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UITextViewDelegate;
			if (del is null){
				del = (_UITextViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUITextViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UITextViewDelegate : _UIScrollViewDelegate, IUITextViewDelegate { 
			public _UITextViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UITextViewDelegate))]
			static _UITextViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? changed;
			[Export ("textViewDidChange:")]
			public void Changed (UITextView textView)
			{
				var handler = changed;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal EventHandler? editingEnded;
			[Export ("textViewDidEndEditing:")]
			public void EditingEnded (UITextView textView)
			{
				var handler = editingEnded;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal EventHandler? editingStarted;
			[Export ("textViewDidBeginEditing:")]
			public void EditingStarted (UITextView textView)
			{
				var handler = editingStarted;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal UITextViewRange? getWritingToolsIgnoredRangesInEnclosingRange;
			[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
			public NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (UITextView textView, NSRange enclosingRange)
			{
				var handler = getWritingToolsIgnoredRangesInEnclosingRange;
				if (handler is not null)
					return handler (textView, enclosingRange);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal EventHandler? selectionChanged;
			[Export ("textViewDidChangeSelection:")]
			public void SelectionChanged (UITextView textView)
			{
				var handler = selectionChanged;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal UITextViewCondition? shouldBeginEditing;
			[Export ("textViewShouldBeginEditing:")]
			public bool ShouldBeginEditing (UITextView textView)
			{
				var handler = shouldBeginEditing;
				if (handler is not null)
					return handler (textView);
				return true!;
			}
			internal UITextViewChange? shouldChangeText;
			[Export ("textView:shouldChangeTextInRange:replacementText:")]
			public bool ShouldChangeText (UITextView textView, NSRange range, string text)
			{
				var handler = shouldChangeText;
				if (handler is not null)
					return handler (textView, range, text);
				return true!;
			}
			internal UITextViewCondition? shouldEndEditing;
			[Export ("textViewShouldEndEditing:")]
			public bool ShouldEndEditing (UITextView textView)
			{
				var handler = shouldEndEditing;
				if (handler is not null)
					return handler (textView);
				return true!;
			}
			internal Func<UITextView,NSTextAttachment,NSRange,bool>? shouldInteractWithTextAttachment;
			[Export ("textView:shouldInteractWithTextAttachment:inRange:")]
			public bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange)
			{
				var handler = shouldInteractWithTextAttachment;
				if (handler is not null)
					return handler (textView, textAttachment, characterRange);
				return true!;
			}
			internal UITextViewDelegateShouldInteractTextDelegate? shouldInteractWithTextAttachment1;
			[Export ("textView:shouldInteractWithTextAttachment:inRange:interaction:")]
			public bool ShouldInteractWithTextAttachment (UITextView textView, NSTextAttachment textAttachment, NSRange characterRange, UITextItemInteraction interaction)
			{
				var handler = shouldInteractWithTextAttachment1;
				if (handler is not null)
					return handler (textView, textAttachment, characterRange, interaction);
				return true!;
			}
			internal Func<UITextView,NSUrl,NSRange,bool>? shouldInteractWithUrl;
			[Export ("textView:shouldInteractWithURL:inRange:")]
			public bool ShouldInteractWithUrl (UITextView textView, NSUrl URL, NSRange characterRange)
			{
				var handler = shouldInteractWithUrl;
				if (handler is not null)
					return handler (textView, URL, characterRange);
				return true!;
			}
			internal UITextViewDelegateShouldInteractUrlDelegate? shouldInteractWithUrl2;
			[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
			public bool ShouldInteractWithUrl (UITextView textView, NSUrl url, NSRange characterRange, UITextItemInteraction interaction)
			{
				var handler = shouldInteractWithUrl2;
				if (handler is not null)
					return handler (textView, url, characterRange, interaction);
				return true!;
			}
			internal EventHandler? writingToolsDidEnd;
			[Export ("textViewWritingToolsDidEnd:")]
			public void WritingToolsDidEnd (UITextView textView)
			{
				var handler = writingToolsDidEnd;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal EventHandler? writingToolsWillBegin;
			[Export ("textViewWritingToolsWillBegin:")]
			public void WritingToolsWillBegin (UITextView textView)
			{
				var handler = writingToolsWillBegin;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			public override bool RespondsToSelector (Selector? sel)
			{
				if (sel is null)
					return false;
				NativeHandle selHandle = sel.Handle;
				if (selHandle.Equals (Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:")))
					return getWritingToolsIgnoredRangesInEnclosingRange is not null;
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("respondsToSelector:"), selHandle) != 0;
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler Changed {
			add { EnsureUITextViewDelegate ()!.changed += value; }
			remove { EnsureUITextViewDelegate ()!.changed -= value; }
		}
		/// <summary>Raised when editing has finished in this UITextView.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler Ended {
			add { EnsureUITextViewDelegate ()!.editingEnded += value; }
			remove { EnsureUITextViewDelegate ()!.editingEnded -= value; }
		}
		/// <summary>Raised when editing has started on this UITextView.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler Started {
			add { EnsureUITextViewDelegate ()!.editingStarted += value; }
			remove { EnsureUITextViewDelegate ()!.editingStarted -= value; }
		}
		public UITextViewRange? GetWritingToolsIgnoredRangesInEnclosingRange {
			get { return EnsureUITextViewDelegate ()!.getWritingToolsIgnoredRangesInEnclosingRange; }
			set { EnsureUITextViewDelegate ()!.getWritingToolsIgnoredRangesInEnclosingRange = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler SelectionChanged {
			add { EnsureUITextViewDelegate ()!.selectionChanged += value; }
			remove { EnsureUITextViewDelegate ()!.selectionChanged -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>The delegate value, usually an anonymous method, a method or a lambda function.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UITextViewCondition? ShouldBeginEditing {
			get { return EnsureUITextViewDelegate ()!.shouldBeginEditing; }
			set { EnsureUITextViewDelegate ()!.shouldBeginEditing = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>The delegate value, usually an anonymous method, a method or a lambda function.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UITextViewChange? ShouldChangeText {
			get { return EnsureUITextViewDelegate ()!.shouldChangeText; }
			set { EnsureUITextViewDelegate ()!.shouldChangeText = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>The delegate value, usually an anonymous method, a method or a lambda function.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public UITextViewCondition? ShouldEndEditing {
			get { return EnsureUITextViewDelegate ()!.shouldEndEditing; }
			set { EnsureUITextViewDelegate ()!.shouldEndEditing = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>
		///         </value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public Func<UITextView,NSTextAttachment,NSRange,bool>? ShouldInteractWithTextAttachment {
			get { return EnsureUITextViewDelegate ()!.shouldInteractWithTextAttachment; }
			set { EnsureUITextViewDelegate ()!.shouldInteractWithTextAttachment = value; }
		}
		/// <summary>Gets or sets the delegate for determining whether the text view should interact with specific text attachments.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public UITextViewDelegateShouldInteractTextDelegate? AllowTextAttachmentInteraction {
			get { return EnsureUITextViewDelegate ()!.shouldInteractWithTextAttachment1; }
			set { EnsureUITextViewDelegate ()!.shouldInteractWithTextAttachment1 = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>
		///         </value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public Func<UITextView,NSUrl,NSRange,bool>? ShouldInteractWithUrl {
			get { return EnsureUITextViewDelegate ()!.shouldInteractWithUrl; }
			set { EnsureUITextViewDelegate ()!.shouldInteractWithUrl = value; }
		}
		/// <summary>Gets or sets the delegate for determining whether the text view should interact with specific URLs.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public UITextViewDelegateShouldInteractUrlDelegate? AllowUrlInteraction {
			get { return EnsureUITextViewDelegate ()!.shouldInteractWithUrl2; }
			set { EnsureUITextViewDelegate ()!.shouldInteractWithUrl2 = value; }
		}
		public event EventHandler WritingToolsDidEnd {
			add { EnsureUITextViewDelegate ()!.writingToolsDidEnd += value; }
			remove { EnsureUITextViewDelegate ()!.writingToolsDidEnd -= value; }
		}
		public event EventHandler WritingToolsWillBegin {
			add { EnsureUITextViewDelegate ()!.writingToolsWillBegin += value; }
			remove { EnsureUITextViewDelegate ()!.writingToolsWillBegin -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PasteDelegate_var = null;
				__mt_TextDragDelegate_var = null;
				__mt_TextDropDelegate_var = null;
				__mt_WeakDelegate_var = null;
				__mt_WeakInputDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UITextView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UITextView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UITextView.Appearance" /> property or by calling <see cref="global::UIKit.UITextView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UITextViewAppearance : global::UIKit.UIScrollView.UIScrollViewAppearance {
			protected internal UITextViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UITextView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextView" />, they should use the <see cref="global::UIKit.UITextView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UITextViewAppearance Appearance {
			get { return new UITextViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextView.UITextViewAppearance" /> for the subclass of <see cref="global::UIKit.UITextView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextView.Appearance" /> property, or the <see cref="global::UIKit.UITextView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UITextView.GetAppearance<MyUITextViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance GetAppearance<T> () where T: UITextView {
			return new UITextViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UITextView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextView" />, they should use the <see cref="global::UIKit.UITextView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UITextViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextView.UITextViewAppearance" /> for <see cref="global::UIKit.UITextView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextView" />, they should use the <see cref="global::UIKit.UITextView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance GetAppearance (UITraitCollection traits) {
			return new UITextViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextView.UITextViewAppearance" /> for <see cref="global::UIKit.UITextView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UITextView" />, they should use the <see cref="global::UIKit.UITextView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UITextViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextView.UITextViewAppearance" /> for the subclass of <see cref="global::UIKit.UITextView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextView.Appearance" /> property, or the <see cref="global::UIKit.UITextView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextView.GetAppearance<MyUITextViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance GetAppearance<T> (UITraitCollection traits) where T: UITextView {
			return new UITextViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UITextView.UITextViewAppearance" /> for the subclass of <see cref="global::UIKit.UITextView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UITextView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UITextView.Appearance" /> property, or the <see cref="global::UIKit.UITextView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UITextView.GetAppearance<MyUITextViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UITextViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UITextView{
			return new UITextViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UITextView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.CurrentInputModeDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.CurrentInputModeDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextView.Notifications.ObserveCurrentInputModeDidChange ((notification) => {
			///   Console.WriteLine ("Observed CurrentInputModeDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentInputModeDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentInputModeDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.CurrentInputModeDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.CurrentInputModeDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextView.Notifications.ObserveCurrentInputModeDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CurrentInputModeDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentInputModeDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentInputModeDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidBeginEditingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidBeginEditingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextView.Notifications.ObserveTextDidBeginEditing ((notification) => {
			///   Console.WriteLine ("Observed TextDidBeginEditingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidBeginEditing (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidBeginEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidBeginEditingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidBeginEditingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextView.Notifications.ObserveTextDidBeginEditing (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextDidBeginEditingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidBeginEditing (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidBeginEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextView.Notifications.ObserveTextDidChange ((notification) => {
			///   Console.WriteLine ("Observed TextDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextView.Notifications.ObserveTextDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidEndEditingNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidEndEditingNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UITextView.Notifications.ObserveTextDidEndEditing ((notification) => {
			///   Console.WriteLine ("Observed TextDidEndEditingNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidEndEditing (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidEndEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UITextView.TextDidEndEditingNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UITextView.TextDidEndEditingNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UITextView.Notifications.ObserveTextDidEndEditing (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextDidEndEditingNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextDidEndEditing (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextDidEndEditingNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UITextView */
}
