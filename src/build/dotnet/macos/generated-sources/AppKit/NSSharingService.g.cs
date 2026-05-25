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
	[Register("NSSharingService", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSharingService : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccountNameX = "accountName";
		static readonly NativeHandle selAccountNameXHandle = Selector.GetHandle ("accountName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlternateImageX = "alternateImage";
		static readonly NativeHandle selAlternateImageXHandle = Selector.GetHandle ("alternateImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentFileURLsX = "attachmentFileURLs";
		static readonly NativeHandle selAttachmentFileURLsXHandle = Selector.GetHandle ("attachmentFileURLs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPerformWithItems_X = "canPerformWithItems:";
		static readonly NativeHandle selCanPerformWithItems_XHandle = Selector.GetHandle ("canPerformWithItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageX = "image";
		static readonly NativeHandle selImageXHandle = Selector.GetHandle ("image");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTitle_Image_AlternateImage_Handler_X = "initWithTitle:image:alternateImage:handler:";
		static readonly NativeHandle selInitWithTitle_Image_AlternateImage_Handler_XHandle = Selector.GetHandle ("initWithTitle:image:alternateImage:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuItemTitleX = "menuItemTitle";
		static readonly NativeHandle selMenuItemTitleXHandle = Selector.GetHandle ("menuItemTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageBodyX = "messageBody";
		static readonly NativeHandle selMessageBodyXHandle = Selector.GetHandle ("messageBody");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformWithItems_X = "performWithItems:";
		static readonly NativeHandle selPerformWithItems_XHandle = Selector.GetHandle ("performWithItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPermanentLinkX = "permanentLink";
		static readonly NativeHandle selPermanentLinkXHandle = Selector.GetHandle ("permanentLink");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecipientsX = "recipients";
		static readonly NativeHandle selRecipientsXHandle = Selector.GetHandle ("recipients");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMenuItemTitle_X = "setMenuItemTitle:";
		static readonly NativeHandle selSetMenuItemTitle_XHandle = Selector.GetHandle ("setMenuItemTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRecipients_X = "setRecipients:";
		static readonly NativeHandle selSetRecipients_XHandle = Selector.GetHandle ("setRecipients:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSubject_X = "setSubject:";
		static readonly NativeHandle selSetSubject_XHandle = Selector.GetHandle ("setSubject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharingServiceNamed_X = "sharingServiceNamed:";
		static readonly NativeHandle selSharingServiceNamed_XHandle = Selector.GetHandle ("sharingServiceNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharingServicesForItems_X = "sharingServicesForItems:";
		static readonly NativeHandle selSharingServicesForItems_XHandle = Selector.GetHandle ("sharingServicesForItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubjectX = "subject";
		static readonly NativeHandle selSubjectXHandle = Selector.GetHandle ("subject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSharingService");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSSharingService" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSharingService () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSSharingService (NSObjectFlag t) : base (t)
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
		protected internal NSSharingService (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTitle:image:alternateImage:handler:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSSharingService (string title, NSImage image, NSImage alternateImage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSSharingServiceHandler))]NSSharingServiceHandler handler)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			var alternateImage__handle__ = alternateImage!.GetNonNullHandle (nameof (alternateImage));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var nstitle = CFString.CreateNative (title);
			using var block_handler = Trampolines.SDNSSharingServiceHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTitle_Image_AlternateImage_Handler_XHandle, nstitle, image__handle__, alternateImage__handle__, (IntPtr) block_ptr_handler), "initWithTitle:image:alternateImage:handler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTitle_Image_AlternateImage_Handler_XHandle, nstitle, image__handle__, alternateImage__handle__, (IntPtr) block_ptr_handler), "initWithTitle:image:alternateImage:handler:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (alternateImage);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("canPerformWithItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformWithItems (NSObject[]? items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_items = items is null ? null : NSArray.FromNSObjects (items);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanPerformWithItems_XHandle, nsa_items.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanPerformWithItems_XHandle, nsa_items.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("sharingServiceNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSharingService GetSharingService (NSString serviceName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var serviceName__handle__ = serviceName!.GetNonNullHandle (nameof (serviceName));
			NSSharingService? ret;
			ret =  Runtime.GetNSObject<NSSharingService> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSharingServiceNamed_XHandle, serviceName__handle__), false)!;
			GC.KeepAlive (serviceName);
			return ret!;
		}
		[Export ("performWithItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformWithItems (NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformWithItems_XHandle, nsa_items.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformWithItems_XHandle, nsa_items.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sharingServicesForItems:")]
		[ObsoletedOSPlatform ("macos13.0", "Use 'NSSharingServicePicker.StandardShareMenuItem' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSharingService[] SharingServicesForItems (NSObject[] items)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			NSSharingService[] ret;
			ret = CFArray.ArrayFromHandle<NSSharingService>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSharingServicesForItems_XHandle, nsa_items.Handle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountName {
			[Export ("accountName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccountNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccountNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage AlternateImage {
			[Export ("alternateImage", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAlternateImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAlternateImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] AttachmentFileUrls {
			[Export ("attachmentFileURLs", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttachmentFileURLsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttachmentFileURLsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSSharingServiceDelegate? Delegate {
			get {
				return (WeakDelegate as INSSharingServiceDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MenuItemTitle {
			[Export ("menuItemTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMenuItemTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMenuItemTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMenuItemTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMenuItemTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMenuItemTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MessageBody {
			[Export ("messageBody")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMessageBodyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMessageBodyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl PermanentLink {
			[Export ("permanentLink", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPermanentLinkXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPermanentLinkXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Recipients {
			[Export ("recipients", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecipientsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecipientsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRecipients:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRecipients_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRecipients_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Subject {
			[Export ("subject")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubjectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubjectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSubject:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSubject_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSubject_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSSharingServiceDelegate); }
		}
		internal virtual _NSSharingServiceDelegate CreateInternalEventDelegateType ()
		{
			return (_NSSharingServiceDelegate)(new _NSSharingServiceDelegate());
		}
		internal _NSSharingServiceDelegate EnsureNSSharingServiceDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSSharingServiceDelegate;
			if (del is null){
				del = (_NSSharingServiceDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSSharingServiceDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSSharingServiceDelegate : NSObject, INSSharingServiceDelegate { 
			public _NSSharingServiceDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSSharingServiceDelegate))]
			static _NSSharingServiceDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal NSSharingServiceAnchoringViewForSharingService? createAnchoringView;
			[Export ("anchoringViewForSharingService:showRelativeToRect:preferredEdge:")]
			public NSView? CreateAnchoringView (NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
			{
				var handler = createAnchoringView;
				if (handler is not null)
					return handler (sharingService, ref positioningRect, ref preferredEdge);
				return null!;
			}
			internal EventHandler<NSSharingServiceDidFailToShareItemsEventArgs>? didFailToShareItems;
			[Export ("sharingService:didFailToShareItems:error:")]
			public void DidFailToShareItems (NSSharingService sharingService, NSObject[] items, NSError error)
			{
				var handler = didFailToShareItems;
				if (handler is not null){
					var args = new NSSharingServiceDidFailToShareItemsEventArgs (items, error);
					handler (sharingService, args);
				}
			}
			internal EventHandler<NSSharingServiceItemsEventArgs>? didShareItems;
			[Export ("sharingService:didShareItems:")]
			public void DidShareItems (NSSharingService sharingService, NSObject[] items)
			{
				var handler = didShareItems;
				if (handler is not null){
					var args = new NSSharingServiceItemsEventArgs (items);
					handler (sharingService, args);
				}
			}
			internal NSSharingServiceSourceFrameOnScreenForShareItem? sourceFrameOnScreenForShareItem;
			[Export ("sharingService:sourceFrameOnScreenForShareItem:")]
			public CGRect SourceFrameOnScreenForShareItem (NSSharingService sharingService, INSPasteboardWriting item)
			{
				var handler = sourceFrameOnScreenForShareItem;
				if (handler is not null)
					return handler (sharingService, item);
				throw new Exception ("No event handler has been added to the SourceFrameOnScreenForShareItem event.");
			}
			internal NSSharingServiceSourceWindowForShareItems? sourceWindowForShareItems;
			[Export ("sharingService:sourceWindowForShareItems:sharingContentScope:")]
			public NSWindow SourceWindowForShareItems (NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
			{
				var handler = sourceWindowForShareItems;
				if (handler is not null)
					return handler (sharingService, items, sharingContentScope);
				return null!;
			}
			internal NSSharingServiceTransitionImageForShareItem? transitionImageForShareItem;
			[Export ("sharingService:transitionImageForShareItem:contentRect:")]
			public NSImage TransitionImageForShareItem (NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
			{
				var handler = transitionImageForShareItem;
				if (handler is not null)
					return handler (sharingService, item, contentRect);
				return null!;
			}
			internal EventHandler<NSSharingServiceItemsEventArgs>? willShareItems;
			[Export ("sharingService:willShareItems:")]
			public void WillShareItems (NSSharingService sharingService, NSObject[] items)
			{
				var handler = willShareItems;
				if (handler is not null){
					var args = new NSSharingServiceItemsEventArgs (items);
					handler (sharingService, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServiceAnchoringViewForSharingService? CreateAnchoringView {
			get { return EnsureNSSharingServiceDelegate ()!.createAnchoringView; }
			set { EnsureNSSharingServiceDelegate ()!.createAnchoringView = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSSharingServiceDidFailToShareItemsEventArgs> DidFailToShareItems {
			add { EnsureNSSharingServiceDelegate ()!.didFailToShareItems += value; }
			remove { EnsureNSSharingServiceDelegate ()!.didFailToShareItems -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSSharingServiceItemsEventArgs> DidShareItems {
			add { EnsureNSSharingServiceDelegate ()!.didShareItems += value; }
			remove { EnsureNSSharingServiceDelegate ()!.didShareItems -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServiceSourceFrameOnScreenForShareItem? SourceFrameOnScreenForShareItem {
			get { return EnsureNSSharingServiceDelegate ()!.sourceFrameOnScreenForShareItem; }
			set { EnsureNSSharingServiceDelegate ()!.sourceFrameOnScreenForShareItem = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServiceSourceWindowForShareItems? SourceWindowForShareItems {
			get { return EnsureNSSharingServiceDelegate ()!.sourceWindowForShareItems; }
			set { EnsureNSSharingServiceDelegate ()!.sourceWindowForShareItems = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSSharingServiceTransitionImageForShareItem? TransitionImageForShareItem {
			get { return EnsureNSSharingServiceDelegate ()!.transitionImageForShareItem; }
			set { EnsureNSSharingServiceDelegate ()!.transitionImageForShareItem = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSSharingServiceItemsEventArgs> WillShareItems {
			add { EnsureNSSharingServiceDelegate ()!.willShareItems += value; }
			remove { EnsureNSSharingServiceDelegate ()!.willShareItems -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSSharingService */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSSharingServiceDidFailToShareItemsEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSSharingServiceDidFailToShareItemsEventArgs" /> with the specified event data.</summary>
		/// <param name="items">The value for the <see cref="Items" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public NSSharingServiceDidFailToShareItemsEventArgs (NSObject[] items, NSError error)
		{
			this.Error = error;
			this.Items = items;
		}
		public NSError Error { get; set; }
		public NSObject[] Items { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSSharingServiceItemsEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSSharingServiceItemsEventArgs" /> with the specified event data.</summary>
		/// <param name="items">The value for the <see cref="Items" /> property.</param>
		public NSSharingServiceItemsEventArgs (NSObject[] items)
		{
			this.Items = items;
		}
		public NSObject[] Items { get; set; }
	}
}
