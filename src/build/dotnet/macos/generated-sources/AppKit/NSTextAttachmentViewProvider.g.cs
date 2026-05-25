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
	[Register("NSTextAttachmentViewProvider", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextAttachmentViewProvider : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_X = "attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:";
		static readonly NativeHandle selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_XHandle = Selector.GetHandle ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTextAttachment_ParentView_TextLayoutManager_Location_X = "initWithTextAttachment:parentView:textLayoutManager:location:";
		static readonly NativeHandle selInitWithTextAttachment_ParentView_TextLayoutManager_Location_XHandle = Selector.GetHandle ("initWithTextAttachment:parentView:textLayoutManager:location:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadViewX = "loadView";
		static readonly NativeHandle selLoadViewXHandle = Selector.GetHandle ("loadView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationX = "location";
		static readonly NativeHandle selLocationXHandle = Selector.GetHandle ("location");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTracksTextAttachmentViewBounds_X = "setTracksTextAttachmentViewBounds:";
		static readonly NativeHandle selSetTracksTextAttachmentViewBounds_XHandle = Selector.GetHandle ("setTracksTextAttachmentViewBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetView_X = "setView:";
		static readonly NativeHandle selSetView_XHandle = Selector.GetHandle ("setView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextAttachmentX = "textAttachment";
		static readonly NativeHandle selTextAttachmentXHandle = Selector.GetHandle ("textAttachment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutManagerX = "textLayoutManager";
		static readonly NativeHandle selTextLayoutManagerXHandle = Selector.GetHandle ("textLayoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTracksTextAttachmentViewBoundsX = "tracksTextAttachmentViewBounds";
		static readonly NativeHandle selTracksTextAttachmentViewBoundsXHandle = Selector.GetHandle ("tracksTextAttachmentViewBounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewX = "view";
		static readonly NativeHandle selViewXHandle = Selector.GetHandle ("view");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextAttachmentViewProvider");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSTextAttachmentViewProvider (NSObjectFlag t) : base (t)
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
		protected internal NSTextAttachmentViewProvider (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTextAttachment:parentView:textLayoutManager:location:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextAttachmentViewProvider (NSTextAttachment textAttachment, NSView? parentView, NSTextLayoutManager? textLayoutManager, INSTextLocation location)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textAttachment__handle__ = textAttachment!.GetNonNullHandle (nameof (textAttachment));
			var parentView__handle__ = parentView.GetHandle ();
			var textLayoutManager__handle__ = textLayoutManager.GetHandle ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTextAttachment_ParentView_TextLayoutManager_Location_XHandle, textAttachment__handle__, parentView__handle__, textLayoutManager__handle__, location__handle__), "initWithTextAttachment:parentView:textLayoutManager:location:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTextAttachment_ParentView_TextLayoutManager_Location_XHandle, textAttachment__handle__, parentView__handle__, textLayoutManager__handle__, location__handle__), "initWithTextAttachment:parentView:textLayoutManager:location:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textAttachment);
			GC.KeepAlive (parentView);
			GC.KeepAlive (textLayoutManager);
			GC.KeepAlive (location);
		}
		[Export ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAttachmentBounds (NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint position)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (this.Handle, selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_XHandle, attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (this.Handle, selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_XHandle, attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (&__objc_super__, selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_XHandle, attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (&__objc_super__, selAttachmentBoundsForAttributes_Location_TextContainer_ProposedLineFragment_Position_XHandle, attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (attributes);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("loadView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadView ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLoadViewXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selLoadViewXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSTextLocation Location {
			[Export ("location", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				INSTextLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<INSTextLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextAttachment_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextAttachment? TextAttachment {
			[Export ("textAttachment", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAttachment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextAttachmentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextAttachment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextAttachmentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextAttachment_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextLayoutManager_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutManager? TextLayoutManager {
			[Export ("textLayoutManager", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextLayoutManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextLayoutManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextLayoutManager_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TracksTextAttachmentViewBounds {
			[Export ("tracksTextAttachmentViewBounds")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTracksTextAttachmentViewBoundsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTracksTextAttachmentViewBoundsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTracksTextAttachmentViewBounds:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTracksTextAttachmentViewBounds_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTracksTextAttachmentViewBounds_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView? View {
			[Export ("view", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextAttachment_var = null;
				__mt_TextLayoutManager_var = null;
			}
		}
	} /* class NSTextAttachmentViewProvider */
}
