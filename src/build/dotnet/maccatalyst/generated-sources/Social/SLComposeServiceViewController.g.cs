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
namespace Social {
	/// <summary>A standard UIViewController for composing data for social sharing.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Social/Reference/SLComposeServiceViewController_Class/index.html">Apple documentation for <c>SLComposeServiceViewController</c></related>
	[Register("SLComposeServiceViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class SLComposeServiceViewController : global::UIKit.UIViewController, global::UIKit.IUITextViewDelegate {
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
		public SLComposeServiceViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cancel"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text or text attributes in the specified UITextView were changed by the app user.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChange:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Changed (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewDidChange:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewDidChange:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		[Export ("didSelectCancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectCancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didSelectCancel"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didSelectCancel"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("didSelectPost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectPost ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("didSelectPost"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("didSelectPost"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><summary>Indicates that editing has ended in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidEndEditing:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingEnded (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewDidEndEditing:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewDidEndEditing:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Indicates editing has begun in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidBeginEditing:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditingStarted (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewDidBeginEditing:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewDidBeginEditing:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		[Export ("configurationItems")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SLComposeSheetConfigurationItem[] GetConfigurationItems ()
		{
			SLComposeSheetConfigurationItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SLComposeSheetConfigurationItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configurationItems")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SLComposeSheetConfigurationItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configurationItems")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textView:editMenuForTextInRange:suggestedActions:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIMenu? GetEditMenuForText (global::UIKit.UITextView textView, NSRange range, global::UIKit.UIMenuElement[] suggestedActions)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			global::UIKit.UIMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("textView:editMenuForTextInRange:suggestedActions:"), textView__handle__, range, nsa_suggestedActions.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:editMenuForTextInRange:suggestedActions:"), textView__handle__, range, nsa_suggestedActions.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		[Export ("textView:editMenuForTextInRanges:suggestedActions:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIMenu? GetEditMenuForText (global::UIKit.UITextView textView, NSValue[] ranges, global::UIKit.UIMenuElement[] suggestedActions)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (suggestedActions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suggestedActions));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			using var nsa_suggestedActions = NSArray.FromNSObjects (suggestedActions);
			global::UIKit.UIMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:editMenuForTextInRanges:suggestedActions:"), textView__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:editMenuForTextInRanges:suggestedActions:"), textView__handle__, nsa_ranges.Handle, nsa_suggestedActions.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret!;
		}
		[Export ("textView:menuConfigurationForTextItem:defaultMenu:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UITextItemMenuConfiguration? GetMenuConfiguration (global::UIKit.UITextView textView, global::UIKit.UITextItem textItem, global::UIKit.UIMenu defaultMenu)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textItem__handle__ = textItem!.GetNonNullHandle (nameof (textItem));
			var defaultMenu__handle__ = defaultMenu!.GetNonNullHandle (nameof (defaultMenu));
			global::UIKit.UITextItemMenuConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UITextItemMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:menuConfigurationForTextItem:defaultMenu:"), textView__handle__, textItem__handle__, defaultMenu__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UITextItemMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:menuConfigurationForTextItem:defaultMenu:"), textView__handle__, textItem__handle__, defaultMenu__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textItem);
			GC.KeepAlive (defaultMenu);
			return ret!;
		}
		[Export ("textView:primaryActionForTextItem:defaultAction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIAction? GetPrimaryAction (global::UIKit.UITextView textView, global::UIKit.UITextItem textItem, global::UIKit.UIAction defaultAction)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textItem__handle__ = textItem!.GetNonNullHandle (nameof (textItem));
			var defaultAction__handle__ = defaultAction!.GetNonNullHandle (nameof (defaultAction));
			global::UIKit.UIAction? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:primaryActionForTextItem:defaultAction:"), textView__handle__, textItem__handle__, defaultAction__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:primaryActionForTextItem:defaultAction:"), textView__handle__, textItem__handle__, defaultAction__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textItem);
			GC.KeepAlive (defaultAction);
			return ret!;
		}
		[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (global::UIKit.UITextView textView, NSRange enclosingRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			NSValue[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:"), textView__handle__, enclosingRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:"), textView__handle__, enclosingRange), false)!;
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isContentValid"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isContentValid"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("loadPreviewView")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView LoadPreviewView ()
		{
			global::UIKit.UIView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("loadPreviewView")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("loadPreviewView")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("popConfigurationViewController")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PopConfigurationViewController ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popConfigurationViewController"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("popConfigurationViewController"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("presentationAnimationDidFinish")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentationAnimationDidFinish ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("presentationAnimationDidFinish"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentationAnimationDidFinish"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("pushConfigurationViewController:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushConfigurationViewController (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushConfigurationViewController:"), viewController__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pushConfigurationViewController:"), viewController__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewController);
		}
		[Export ("reloadConfigurationItems")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadConfigurationItems ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadConfigurationItems"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reloadConfigurationItems"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="textView">To be added.</param><summary>Indicates the text selection has changed in the specified UITextView.</summary><remarks>To be added.</remarks>
		[Export ("textViewDidChangeSelection:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionChanged (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewDidChangeSelection:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewDidChangeSelection:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should begin in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textViewShouldBeginEditing:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewShouldBeginEditing:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewShouldBeginEditing:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the specified text should be replaced in the UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldChangeTextInRange:replacementText:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (global::UIKit.UITextView textView, NSRange range, string text)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementText:"), textView__handle__, range, nstext);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:shouldChangeTextInRange:replacementText:"), textView__handle__, range, nstext);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nstext);
			return ret != 0;
		}
		[Export ("textView:shouldChangeTextInRanges:replacementText:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (global::UIKit.UITextView textView, NSValue[] ranges, string replacementText)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementText:"), textView__handle__, nsa_ranges.Handle, nsreplacementText);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:shouldChangeTextInRanges:replacementText:"), textView__handle__, nsa_ranges.Handle, nsreplacementText);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><summary>Whether editing should end in the specified UITextView.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textViewShouldEndEditing:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewShouldEndEditing:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewShouldEndEditing:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="textAttachment">To be added.</param><param name="characterRange">To be added.</param><summary>Developers should not use this deprecated method. Developers should use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithTextAttachment:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (global::UIKit.UITextView textView, global::UIKit.NSTextAttachment textAttachment, NSRange characterRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:"), textView__handle__, textAttachment__handle__, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:"), textView__handle__, textAttachment__handle__, characterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="textAttachment">The attachment.</param><param name="characterRange">The character range where the attachment is attached.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithTextAttachment:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Replaced by 'GetPrimaryAction' and 'GetMenuConfiguration'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithTextAttachment (global::UIKit.UITextView textView, global::UIKit.NSTextAttachment textAttachment, NSRange characterRange, global::UIKit.UITextItemInteraction interaction)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (this.Handle, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:interaction:"), textView__handle__, textAttachment__handle__, characterRange, (IntPtr) (long) interaction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange_IntPtr (&__objc_super__, Selector.GetHandle ("textView:shouldInteractWithTextAttachment:inRange:interaction:"), textView__handle__, textAttachment__handle__, characterRange, (IntPtr) (long) interaction);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textAttachment);
			return ret != 0;
		}
		/// <param name="textView">To be added.</param><param name="URL">To be added.</param><param name="characterRange">To be added.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithURL:inRange:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithUrl' overload that takes 'UITextItemInteraction' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (global::UIKit.UITextView textView, NSUrl URL, NSRange characterRange)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var URL__handle__ = URL!.GetNonNullHandle (nameof (URL));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:"), textView__handle__, URL__handle__, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:"), textView__handle__, URL__handle__, characterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (URL);
			return ret != 0;
		}
		/// <param name="textView">The text view that has the attachment.</param><param name="url">To be added.</param><param name="characterRange">The character range of the URL in the text view.</param><param name="interaction">The interaction type to check.</param><summary>Whether the specified UITextView should allow user interaction with the specified URL in the given range of text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
		[ObsoletedOSPlatform ("ios10.0", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'ShouldInteractWithTextAttachment' overload that takes 'UITextItemInteraction' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInteractWithUrl (global::UIKit.UITextView textView, NSUrl url, NSRange characterRange, global::UIKit.UITextItemInteraction interaction)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NSRange_IntPtr (this.Handle, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:interaction:"), textView__handle__, url__handle__, characterRange, (IntPtr) (long) interaction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange_IntPtr (&__objc_super__, Selector.GetHandle ("textView:shouldInteractWithURL:inRange:interaction:"), textView__handle__, url__handle__, characterRange, (IntPtr) (long) interaction);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("validateContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ValidateContent ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("validateContent"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("validateContent"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("textView:willDismissEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismissEditMenu (global::UIKit.UITextView textView, global::UIKit.IUIEditMenuInteractionAnimating aniamtor)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var aniamtor__handle__ = aniamtor!.GetNonNullHandle (nameof (aniamtor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:willDismissEditMenuWithAnimator:"), textView__handle__, aniamtor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:willDismissEditMenuWithAnimator:"), textView__handle__, aniamtor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (aniamtor);
		}
		[Export ("textView:textItemMenuWillDisplayForTextItem:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplay (global::UIKit.UITextView textView, global::UIKit.UITextItem textItem, global::UIKit.IUIContextMenuInteractionAnimating animator)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textItem__handle__ = textItem!.GetNonNullHandle (nameof (textItem));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:textItemMenuWillDisplayForTextItem:animator:"), textView__handle__, textItem__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:textItemMenuWillDisplayForTextItem:animator:"), textView__handle__, textItem__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textItem);
			GC.KeepAlive (animator);
		}
		[Export ("textView:textItemMenuWillEndForTextItem:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnd (global::UIKit.UITextView textView, global::UIKit.UITextItem textItem, global::UIKit.IUIContextMenuInteractionAnimating animator)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var textItem__handle__ = textItem!.GetNonNullHandle (nameof (textItem));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:textItemMenuWillEndForTextItem:animator:"), textView__handle__, textItem__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:textItemMenuWillEndForTextItem:animator:"), textView__handle__, textItem__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (textItem);
			GC.KeepAlive (animator);
		}
		[Export ("textView:willPresentEditMenuWithAnimator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresentEditMenu (global::UIKit.UITextView textView, global::UIKit.IUIEditMenuInteractionAnimating animator)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textView:willPresentEditMenuWithAnimator:"), textView__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("textView:willPresentEditMenuWithAnimator:"), textView__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
			GC.KeepAlive (animator);
		}
		[Export ("textViewWritingToolsDidEnd:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritingToolsDidEnd (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewWritingToolsDidEnd:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewWritingToolsDidEnd:"), textView__handle__);
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
		public virtual void WritingToolsWillBegin (global::UIKit.UITextView textView)
		{
			var textView__handle__ = textView!.GetNonNullHandle (nameof (textView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textViewWritingToolsWillBegin:"), textView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textViewWritingToolsWillBegin:"), textView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textView);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual global::UIKit.UIViewController? AutoCompletionViewController {
			[Export ("autoCompletionViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("autoCompletionViewController")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autoCompletionViewController")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAutoCompletionViewController:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAutoCompletionViewController:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAutoCompletionViewController:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? CharactersRemaining {
			[Export ("charactersRemaining", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("charactersRemaining")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("charactersRemaining")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCharactersRemaining:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCharactersRemaining:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCharactersRemaining:"), value__handle__);
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
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contentText")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contentText")), false)!;
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
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("placeholder")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("placeholder")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPlaceholder:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPlaceholder:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPlaceholder:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UITextView TextView {
			[Export ("textView")]
			get {
				global::UIKit.UITextView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SLComposeServiceViewController */
}
