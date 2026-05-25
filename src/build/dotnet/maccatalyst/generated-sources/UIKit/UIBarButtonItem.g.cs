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
	[Register("UIBarButtonItem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIBarButtonItem : UIBarItem, INSCoding, IUIPopoverPresentationControllerSourceItem, IUISpringLoadedInteractionSupporting {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIBarButtonItem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIBarButtonItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIBarButtonItem () : base (NSObjectFlag.Empty)
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
		public UIBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UIBarButtonItem (NSObjectFlag t) : base (t)
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
		protected internal UIBarButtonItem (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithImage:style:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIImage? image, UIBarButtonItemStyle style, NSObject? target, Selector? action)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithImage:style:target:action:"), image__handle__, (IntPtr) (long) style, target__handle__, action__handle__), "initWithImage:style:target:action:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImage:style:target:action:"), image__handle__, (IntPtr) (long) style, target__handle__, action__handle__), "initWithImage:style:target:action:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			#pragma warning disable 168
			var postget1 = Target;
			#pragma warning restore 168
		}
		[Export ("initWithTitle:style:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (string? title, UIBarButtonItemStyle style, NSObject? target, Selector? action)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithTitle:style:target:action:"), nstitle, (IntPtr) (long) style, target__handle__, action__handle__), "initWithTitle:style:target:action:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTitle:style:target:action:"), nstitle, (IntPtr) (long) style, target__handle__, action__handle__), "initWithTitle:style:target:action:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			CFString.ReleaseNative (nstitle);
			#pragma warning disable 168
			var postget0 = Target;
			#pragma warning restore 168
		}
		[Export ("initWithBarButtonSystemItem:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIBarButtonSystemItem systemItem, NSObject? target, Selector? action)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithBarButtonSystemItem:target:action:"), (IntPtr) (long) systemItem, target__handle__, action__handle__), "initWithBarButtonSystemItem:target:action:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithBarButtonSystemItem:target:action:"), (IntPtr) (long) systemItem, target__handle__, action__handle__), "initWithBarButtonSystemItem:target:action:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			#pragma warning disable 168
			var postget0 = Target;
			#pragma warning restore 168
		}
		[Export ("initWithCustomView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIView customView)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var customView__handle__ = customView!.GetNonNullHandle (nameof (customView));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCustomView:"), customView__handle__), "initWithCustomView:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCustomView:"), customView__handle__), "initWithCustomView:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (customView);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("initWithBarButtonSystemItem:primaryAction:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIBarButtonSystemItem systemItem, UIAction? primaryAction)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var primaryAction__handle__ = primaryAction.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithBarButtonSystemItem:primaryAction:"), (IntPtr) (long) systemItem, primaryAction__handle__), "initWithBarButtonSystemItem:primaryAction:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithBarButtonSystemItem:primaryAction:"), (IntPtr) (long) systemItem, primaryAction__handle__), "initWithBarButtonSystemItem:primaryAction:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryAction);
		}
		[Export ("initWithPrimaryAction:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIAction? primaryAction)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var primaryAction__handle__ = primaryAction.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithPrimaryAction:"), primaryAction__handle__), "initWithPrimaryAction:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithPrimaryAction:"), primaryAction__handle__), "initWithPrimaryAction:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryAction);
		}
		[Export ("initWithBarButtonSystemItem:menu:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIBarButtonSystemItem systemItem, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var menu__handle__ = menu.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithBarButtonSystemItem:menu:"), (IntPtr) (long) systemItem, menu__handle__), "initWithBarButtonSystemItem:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithBarButtonSystemItem:menu:"), (IntPtr) (long) systemItem, menu__handle__), "initWithBarButtonSystemItem:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
		}
		[Export ("initWithTitle:menu:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (string? title, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var menu__handle__ = menu.GetHandle ();
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithTitle:menu:"), nstitle, menu__handle__), "initWithTitle:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTitle:menu:"), nstitle, menu__handle__), "initWithTitle:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("initWithImage:menu:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIImage? image, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			var menu__handle__ = menu.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithImage:menu:"), image__handle__, menu__handle__), "initWithImage:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImage:menu:"), image__handle__, menu__handle__), "initWithImage:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (menu);
		}
		[Export ("initWithPrimaryAction:menu:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIAction? primaryAction, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var primaryAction__handle__ = primaryAction.GetHandle ();
			var menu__handle__ = menu.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithPrimaryAction:menu:"), primaryAction__handle__, menu__handle__), "initWithPrimaryAction:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithPrimaryAction:menu:"), primaryAction__handle__, menu__handle__), "initWithPrimaryAction:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryAction);
			GC.KeepAlive (menu);
		}
		[Export ("initWithBarButtonSystemItem:primaryAction:menu:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIBarButtonSystemItem systemItem, UIAction? primaryAction, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var primaryAction__handle__ = primaryAction.GetHandle ();
			var menu__handle__ = menu.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithBarButtonSystemItem:primaryAction:menu:"), (IntPtr) (long) systemItem, primaryAction__handle__, menu__handle__), "initWithBarButtonSystemItem:primaryAction:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithBarButtonSystemItem:primaryAction:menu:"), (IntPtr) (long) systemItem, primaryAction__handle__, menu__handle__), "initWithBarButtonSystemItem:primaryAction:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (primaryAction);
			GC.KeepAlive (menu);
		}
		[Export ("initWithTitle:image:target:action:menu:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (string? title, UIImage? image, NSObject? target, Selector? action, UIMenu? menu)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			var menu__handle__ = menu.GetHandle ();
			var nstitle = CFString.CreateNative (title);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithTitle:image:target:action:menu:"), nstitle, image__handle__, target__handle__, action__handle__, menu__handle__), "initWithTitle:image:target:action:menu:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTitle:image:target:action:menu:"), nstitle, image__handle__, target__handle__, action__handle__, menu__handle__), "initWithTitle:image:target:action:menu:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			GC.KeepAlive (menu);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("initWithImage:landscapeImagePhone:style:target:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIBarButtonItem (UIImage? image, UIImage? landscapeImagePhone, UIBarButtonItemStyle style, NSObject? target, Selector? action)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var image__handle__ = image.GetHandle ();
			var landscapeImagePhone__handle__ = landscapeImagePhone.GetHandle ();
			var target__handle__ = target.GetHandle ();
			var action__handle__ = action.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithImage:landscapeImagePhone:style:target:action:"), image__handle__, landscapeImagePhone__handle__, (IntPtr) (long) style, target__handle__, action__handle__), "initWithImage:landscapeImagePhone:style:target:action:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithImage:landscapeImagePhone:style:target:action:"), image__handle__, landscapeImagePhone__handle__, (IntPtr) (long) style, target__handle__, action__handle__), "initWithImage:landscapeImagePhone:style:target:action:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
			GC.KeepAlive (landscapeImagePhone);
			GC.KeepAlive (target);
			GC.KeepAlive (action);
			#pragma warning disable 168
			var postget2 = Target;
			#pragma warning restore 168
		}
		[Export ("addSymbolEffect:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addSymbolEffect:"), symbolEffect__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addSymbolEffect:"), symbolEffect__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
		}
		[Export ("addSymbolEffect:options:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect, global::Symbols.NSSymbolEffectOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addSymbolEffect:options:"), symbolEffect__handle__, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("addSymbolEffect:options:"), symbolEffect__handle__, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
			GC.KeepAlive (options);
		}
		[Export ("addSymbolEffect:options:animated:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect, global::Symbols.NSSymbolEffectOptions options, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("addSymbolEffect:options:animated:"), symbolEffect__handle__, options__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("addSymbolEffect:options:animated:"), symbolEffect__handle__, options__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
			GC.KeepAlive (options);
		}
		[Export ("fixedSpaceItem")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIBarButtonItem CreateFixedSpaceItem ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIBarButtonItem ret;
			ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("fixedSpaceItem")), false)!;
			return ret;
		}
		[Export ("creatingMovableGroupWithCustomizationIdentifier:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIBarButtonItemGroup CreatingMovableGroup (string customizationIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (customizationIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customizationIdentifier));
			var nscustomizationIdentifier = CFString.CreateNative (customizationIdentifier);
			UIBarButtonItemGroup? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("creatingMovableGroupWithCustomizationIdentifier:"), nscustomizationIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("creatingMovableGroupWithCustomizationIdentifier:"), nscustomizationIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscustomizationIdentifier);
			return ret!;
		}
		[Export ("creatingOptionalGroupWithCustomizationIdentifier:inDefaultCustomization:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIBarButtonItemGroup CreatingOptionalGroup (string customizationIdentifier, bool inDefaultCustomization)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (customizationIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (customizationIdentifier));
			var nscustomizationIdentifier = CFString.CreateNative (customizationIdentifier);
			UIBarButtonItemGroup? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("creatingOptionalGroupWithCustomizationIdentifier:inDefaultCustomization:"), nscustomizationIdentifier, inDefaultCustomization ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("creatingOptionalGroupWithCustomizationIdentifier:inDefaultCustomization:"), nscustomizationIdentifier, inDefaultCustomization ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscustomizationIdentifier);
			return ret!;
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
		/// <param name="forState">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image used for the back button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backButtonBackgroundImageForState:barMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetBackButtonBackgroundImage (UIControlState forState, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backButtonBackgroundImageForState:barMetrics:"), (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonBackgroundImageForState:barMetrics:"), (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="barMetrics">To be added.</param><summary>The back button's vertical position offset for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBackButtonBackgroundVerticalPositionAdjustment (UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="barMetrics">To be added.</param><summary>The back button's title's position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backButtonTitlePositionAdjustmentForBarMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIOffset GetBackButtonTitlePositionAdjustment (UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIOffset ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backButtonTitlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonTitlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image for the specified UIControlState and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backgroundImageForState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetBackgroundImage (UIControlState state, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><param name="style">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image for the specified UIControlState, UIBarButtonItemStyle, and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backgroundImageForState:style:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetBackgroundImage (UIControlState state, UIBarButtonItemStyle style, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:style:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:style:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="forBarMetrics">To be added.</param><summary>The background's vertical position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("backgroundVerticalPositionAdjustmentForBarMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBackgroundVerticalPositionAdjustment (UIBarMetrics forBarMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) forBarMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) forBarMetrics);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fixedSpaceItemOfWidth:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIBarButtonItem GetFixedSpaceItem (nfloat width)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIBarButtonItem ret;
			ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("fixedSpaceItemOfWidth:"), width), false)!;
			return ret;
		}
		[Export ("frameInView:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrame (UIView referenceView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var referenceView__handle__ = referenceView!.GetNonNullHandle (nameof (referenceView));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("frameInView:"), referenceView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("frameInView:"), referenceView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("frameInView:"), referenceView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (referenceView);
			return ret!;
		}
		/// <param name="barMetrics">To be added.</param><summary>The title's position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("titlePositionAdjustmentForBarMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIOffset GetTitlePositionAdjustment (UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIOffset ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("titlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("titlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeAllSymbolEffects")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllSymbolEffects ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllSymbolEffects"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllSymbolEffects"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllSymbolEffectsWithOptions:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllSymbolEffects (global::Symbols.NSSymbolEffectOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAllSymbolEffectsWithOptions:"), options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAllSymbolEffectsWithOptions:"), options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		[Export ("removeAllSymbolEffectsWithOptions:animated:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllSymbolEffects (global::Symbols.NSSymbolEffectOptions options, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("removeAllSymbolEffectsWithOptions:animated:"), options__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("removeAllSymbolEffectsWithOptions:animated:"), options__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		[Export ("removeSymbolEffectOfType:options:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect, global::Symbols.NSSymbolEffectOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeSymbolEffectOfType:options:"), symbolEffect__handle__, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("removeSymbolEffectOfType:options:"), symbolEffect__handle__, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
			GC.KeepAlive (options);
		}
		[Export ("removeSymbolEffectOfType:options:animated:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect, global::Symbols.NSSymbolEffectOptions options, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("removeSymbolEffectOfType:options:animated:"), symbolEffect__handle__, options__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("removeSymbolEffectOfType:options:animated:"), symbolEffect__handle__, options__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
			GC.KeepAlive (options);
		}
		[Export ("removeSymbolEffectOfType:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSymbolEffect (global::Symbols.NSSymbolEffect symbolEffect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolEffect__handle__ = symbolEffect!.GetNonNullHandle (nameof (symbolEffect));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeSymbolEffectOfType:"), symbolEffect__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeSymbolEffectOfType:"), symbolEffect__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolEffect);
		}
		/// <param name="backgroundImage">To be added.</param><param name="forState">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the UIImage to be used as a background for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setBackButtonBackgroundImage:forState:barMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackButtonBackgroundImage (UIImage? backgroundImage, UIControlState forState, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var backgroundImage__handle__ = backgroundImage.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (backgroundImage);
		}
		/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>To be added.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UIBarButtonItem.Appearance" /> property and the <see cref="UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
		[Export ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackButtonBackgroundVerticalPositionAdjustment (nfloat adjustment, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the back button's title's position adjustment for the specified UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setBackButtonTitlePositionAdjustment:forBarMetrics:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackButtonTitlePositionAdjustment (UIOffset adjustment, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the background UIImage to use for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setBackgroundImage:forState:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var backgroundImage__handle__ = backgroundImage.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (backgroundImage);
		}
		/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="style">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the background image to use for the specified UIControlState, UIBarButtonItemStyle, and UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setBackgroundImage:forState:style:barMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarButtonItemStyle style, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var backgroundImage__handle__ = backgroundImage.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:style:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:style:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (backgroundImage);
		}
		/// <param name="adjustment">To be added.</param><param name="forBarMetrics">To be added.</param><summary>To be added.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UIBarButtonItem.Appearance" /> property and the <see cref="UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
		[Export ("setBackgroundVerticalPositionAdjustment:forBarMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBackgroundVerticalPositionAdjustment (nfloat adjustment, UIBarMetrics forBarMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) forBarMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) forBarMetrics);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSymbolImage:withContentTransition:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSymbolImage (UIImage symbolImage, global::Symbols.NSSymbolContentTransition transition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolImage__handle__ = symbolImage!.GetNonNullHandle (nameof (symbolImage));
			var transition__handle__ = transition!.GetNonNullHandle (nameof (transition));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setSymbolImage:withContentTransition:"), symbolImage__handle__, transition__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setSymbolImage:withContentTransition:"), symbolImage__handle__, transition__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolImage);
			GC.KeepAlive (transition);
		}
		[Export ("setSymbolImage:withContentTransition:options:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSymbolImage (UIImage symbolImage, global::Symbols.NSSymbolContentTransition transition, global::Symbols.NSSymbolEffectOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var symbolImage__handle__ = symbolImage!.GetNonNullHandle (nameof (symbolImage));
			var transition__handle__ = transition!.GetNonNullHandle (nameof (transition));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setSymbolImage:withContentTransition:options:"), symbolImage__handle__, transition__handle__, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setSymbolImage:withContentTransition:options:"), symbolImage__handle__, transition__handle__, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (symbolImage);
			GC.KeepAlive (transition);
			GC.KeepAlive (options);
		}
		/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the adjustment of the title's position for the specified UIBarMetrics.</summary><remarks>To be added.</remarks>
		[Export ("setTitlePositionAdjustment:forBarMetrics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitlePositionAdjustment (UIOffset adjustment, UIBarMetrics barMetrics)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr (this.Handle, Selector.GetHandle ("setTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr (&__objc_super__, Selector.GetHandle ("setTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? Action {
			[Export ("action")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("action")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("action")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAction:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAction:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAction:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIBarButtonItemBadge? Badge {
			[Export ("badge", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItemBadge? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBarButtonItemBadge> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("badge")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBarButtonItemBadge> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("badge")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBadge:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setBadge:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setBadge:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ButtonGroup_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIBarButtonItemGroup? ButtonGroup {
			[Export ("buttonGroup", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItemGroup? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buttonGroup")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("buttonGroup")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ButtonGroup_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ChangesSelectionAsPrimaryAction {
			[Export ("changesSelectionAsPrimaryAction")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("changesSelectionAsPrimaryAction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("changesSelectionAsPrimaryAction"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setChangesSelectionAsPrimaryAction:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setChangesSelectionAsPrimaryAction:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setChangesSelectionAsPrimaryAction:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIBarButtonItemGroup CreatingFixedGroup {
			[Export ("creatingFixedGroup")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItemGroup? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("creatingFixedGroup")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIBarButtonItemGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("creatingFixedGroup")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView? CustomView {
			[Export ("customView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("customView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCustomView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCustomView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Allows control over whether a UIBarButtonItem is enabled or disabled.</summary><value>True if the UIBarButtonItem is enabled. False if it is disabled.</value><remarks>If a UIBarButtonItem is enabled, it can be interacted with. If it is disabled, it still appears, but cannot be interacted with.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override bool Enabled {
			[Export ("isEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static UIBarButtonItem FlexibleSpaceItem {
			[Export ("flexibleSpaceItem")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItem? ret;
				ret =  Runtime.GetNSObject<UIBarButtonItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("flexibleSpaceItem")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool HidesSharedBackground {
			[Export ("hidesSharedBackground")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hidesSharedBackground"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hidesSharedBackground"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidesSharedBackground:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidesSharedBackground:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidesSharedBackground:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual string? Identifier {
			[Export ("identifier")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIdentifier:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override UIImage? Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("image")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setImage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setImage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override UIEdgeInsets ImageInsets {
			[Export ("imageInsets")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("imageInsets"));
					} else {
						ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSend_stret (this.Handle, Selector.GetHandle ("imageInsets"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageInsets"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("imageInsets"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setImageInsets:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setImageInsets:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("setImageInsets:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIMenu? Menu {
			[Export ("menu", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenu? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("menu")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("menu")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMenu:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMenu:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMenu:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIMenuElement? MenuRepresentation {
			[Export ("menuRepresentation", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIMenuElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("menuRepresentation")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIMenuElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("menuRepresentation")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMenuRepresentation:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMenuRepresentation:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMenuRepresentation:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet? PossibleTitles {
			[Export ("possibleTitles", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("possibleTitles")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("possibleTitles")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPossibleTitles:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPossibleTitles:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPossibleTitles:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UIContextMenuConfigurationElementOrder PreferredMenuElementOrder {
			[Export ("preferredMenuElementOrder", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIContextMenuConfigurationElementOrder ret;
				if (IsDirectBinding) {
					ret = (UIContextMenuConfigurationElementOrder) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredMenuElementOrder"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIContextMenuConfigurationElementOrder) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredMenuElementOrder"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredMenuElementOrder:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredMenuElementOrder:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPreferredMenuElementOrder:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIAction? PrimaryAction {
			[Export ("primaryAction", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("primaryAction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("primaryAction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPrimaryAction:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPrimaryAction:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPrimaryAction:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool Selected {
			[Export ("isSelected")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSelected"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSelected"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelected:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSelected:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSelected:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool SharesBackground {
			[Export ("sharesBackground")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("sharesBackground"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sharesBackground"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSharesBackground:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSharesBackground:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSharesBackground:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether the object participates in spring-loaded interactions.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool SpringLoaded {
			[Export ("isSpringLoaded")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSpringLoaded"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSpringLoaded"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSpringLoaded:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSpringLoaded:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIBarButtonItemStyle Style {
			[Export ("style")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIBarButtonItemStyle ret;
				if (IsDirectBinding) {
					ret = (UIBarButtonItemStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIBarButtonItemStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("style"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStyle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStyle:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setStyle:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual bool SymbolAnimationEnabled {
			[Export ("isSymbolAnimationEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSymbolAnimationEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isSymbolAnimationEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSymbolAnimationEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSymbolAnimationEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setSymbolAnimationEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override nint Tag {
			[Export ("tag")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tag"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tag"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTag:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTag:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTag:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Target_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Target {
			[Export ("target", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("target")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("target")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTarget:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTarget:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Target_var = value;
			}
		}
		/// <summary>The color used for tinting.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? TintColor {
			[Export ("tintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tintColor")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintColor")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTintColor:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTintColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTintColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public override string? Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("title")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTitle:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Width {
			[Export ("width")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("width"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("width"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setWidth:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setWidth:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setWidth:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ButtonGroup_var = null;
				__mt_Target_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::UIKit.UIBarButtonItem" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::UIKit.UIBarButtonItem" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::UIKit.UIBarButtonItem.Appearance" /> property or by calling <see cref="global::UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class UIBarButtonItemAppearance : global::UIKit.UIBarItem.UIBarItemAppearance {
			protected internal UIBarButtonItemAppearance (IntPtr handle) : base (handle) {}
			/// <param name="forState">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image used for the back button.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backButtonBackgroundImageForState:barMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetBackButtonBackgroundImage (UIControlState forState, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backButtonBackgroundImageForState:barMetrics:"), (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonBackgroundImageForState:barMetrics:"), (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="barMetrics">To be added.</param><summary>The back button's vertical position offset for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual nfloat GetBackButtonBackgroundVerticalPositionAdjustment (UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonBackgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="barMetrics">To be added.</param><summary>The back button's title's position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backButtonTitlePositionAdjustmentForBarMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIOffset GetBackButtonTitlePositionAdjustment (UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIOffset ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backButtonTitlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backButtonTitlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image for the specified UIControlState and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backgroundImageForState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetBackgroundImage (UIControlState state, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="state">To be added.</param><param name="style">To be added.</param><param name="barMetrics">To be added.</param><summary>The background image for the specified UIControlState, UIBarButtonItemStyle, and UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backgroundImageForState:style:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIImage GetBackgroundImage (UIControlState state, UIBarButtonItemStyle style, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("backgroundImageForState:style:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundImageForState:style:barMetrics:"), (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="forBarMetrics">To be added.</param><summary>The background's vertical position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("backgroundVerticalPositionAdjustmentForBarMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual nfloat GetBackgroundVerticalPositionAdjustment (UIBarMetrics forBarMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) forBarMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("backgroundVerticalPositionAdjustmentForBarMetrics:"), (IntPtr) (long) forBarMetrics);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="barMetrics">To be added.</param><summary>The title's position adjustment for the specified UIBarMetrics.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
			[Export ("titlePositionAdjustmentForBarMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIOffset GetTitlePositionAdjustment (UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				UIOffset ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("titlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIOffset_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("titlePositionAdjustmentForBarMetrics:"), (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			/// <param name="backgroundImage">To be added.</param><param name="forState">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the UIImage to be used as a background for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setBackButtonBackgroundImage:forState:barMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackButtonBackgroundImage (UIImage? backgroundImage, UIControlState forState, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var backgroundImage__handle__ = backgroundImage.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) forState, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (backgroundImage);
			}
			/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>To be added.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UIBarButtonItem.Appearance" /> property and the <see cref="UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
			[Export ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackButtonBackgroundVerticalPositionAdjustment (nfloat adjustment, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
			}
			/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the back button's title's position adjustment for the specified UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setBackButtonTitlePositionAdjustment:forBarMetrics:")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackButtonTitlePositionAdjustment (UIOffset adjustment, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr (this.Handle, Selector.GetHandle ("setBackButtonTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr (&__objc_super__, Selector.GetHandle ("setBackButtonTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
			}
			/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the background UIImage to use for the specified UIControlState and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setBackgroundImage:forState:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var backgroundImage__handle__ = backgroundImage.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (backgroundImage);
			}
			/// <param name="backgroundImage">To be added.</param><param name="state">To be added.</param><param name="style">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the background image to use for the specified UIControlState, UIBarButtonItemStyle, and UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setBackgroundImage:forState:style:barMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackgroundImage (UIImage? backgroundImage, UIControlState state, UIBarButtonItemStyle style, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				var backgroundImage__handle__ = backgroundImage.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundImage:forState:style:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundImage:forState:style:barMetrics:"), backgroundImage__handle__, (UIntPtr) (ulong) state, (IntPtr) (long) style, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (backgroundImage);
			}
			/// <param name="adjustment">To be added.</param><param name="forBarMetrics">To be added.</param><summary>To be added.</summary><remarks><para id="tool-remark">This member participates in the <see cref="T:UIKit.UIAppearance" /> styling system.  See the <see cref="UIKit.UIBarButtonItem.Appearance" /> property and the <see cref="UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method.</para></remarks>
			[Export ("setBackgroundVerticalPositionAdjustment:forBarMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetBackgroundVerticalPositionAdjustment (nfloat adjustment, UIBarMetrics forBarMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) forBarMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, Selector.GetHandle ("setBackgroundVerticalPositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) forBarMetrics);
						GC.KeepAlive (this);
					}
				}
			}
			/// <param name="adjustment">To be added.</param><param name="barMetrics">To be added.</param><summary>Specifies the adjustment of the title's position for the specified UIBarMetrics.</summary><remarks>To be added.</remarks>
			[Export ("setTitlePositionAdjustment:forBarMetrics:")]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual void SetTitlePositionAdjustment (UIOffset adjustment, UIBarMetrics barMetrics)
			{
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIOffset_IntPtr (this.Handle, Selector.GetHandle ("setTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIOffset_IntPtr (&__objc_super__, Selector.GetHandle ("setTitlePositionAdjustment:forBarMetrics:"), adjustment, (IntPtr) (long) barMetrics);
						GC.KeepAlive (this);
					}
				}
			}
			/// <summary>The color used for tinting.</summary><value>To be added.</value><remarks>To be added.</remarks>
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public virtual UIColor? TintColor {
				[Export ("tintColor", ArgumentSemantic.Retain)]
				get {
					global::UIKit.UIApplication.EnsureUIThread ();
					UIColor? ret;
					if (IsDirectBinding) {
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tintColor")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tintColor")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
				[Export ("setTintColor:", ArgumentSemantic.Retain)]
				set {
					global::UIKit.UIApplication.EnsureUIThread ();
					var value__handle__ = value.GetHandle ();
					if (IsDirectBinding) {
						global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTintColor:"), value__handle__);
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTintColor:"), value__handle__);
							GC.KeepAlive (this);
						}
					}
					GC.KeepAlive (value);
				}
			}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::UIKit.UIBarButtonItem" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIBarButtonItem" />, they should use the <see cref="global::UIKit.UIBarButtonItem.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance Appearance {
			get { return new UIBarButtonItemAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance" /> for the subclass of <see cref="global::UIKit.UIBarButtonItem" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIBarButtonItem" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIBarButtonItem.Appearance" /> property, or the <see cref="global::UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = UIBarButtonItem.GetAppearance<MyUIBarButtonItemSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance GetAppearance<T> () where T: UIBarButtonItem {
			return new UIBarButtonItemAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::UIKit.UIBarButtonItem" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIBarButtonItem" />, they should use the <see cref="global::UIKit.UIBarButtonItem.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new UIBarButtonItemAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance" /> for <see cref="global::UIKit.UIBarButtonItem" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIBarButtonItem.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIBarButtonItem" />, they should use the <see cref="global::UIKit.UIBarButtonItem.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance GetAppearance (UITraitCollection traits) {
			return new UIBarButtonItemAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance" /> for <see cref="global::UIKit.UIBarButtonItem" />.</summary>
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
		///var myTheme = UIBarButtonItem.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::UIKit.UIBarButtonItem" />, they should use the <see cref="global::UIKit.UIBarButtonItem.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new UIBarButtonItemAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance" /> for the subclass of <see cref="global::UIKit.UIBarButtonItem" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIBarButtonItem" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIBarButtonItem.Appearance" /> property, or the <see cref="global::UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIBarButtonItem.GetAppearance<MyUIBarButtonItemSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance GetAppearance<T> (UITraitCollection traits) where T: UIBarButtonItem {
			return new UIBarButtonItemAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance" /> for the subclass of <see cref="global::UIKit.UIBarButtonItem" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::UIKit.UIBarButtonItem" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::UIKit.UIBarButtonItem.Appearance" /> property, or the <see cref="global::UIKit.UIBarButtonItem.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = UIBarButtonItem.GetAppearance<MyUIBarButtonItemSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new UIBarButtonItemAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: UIBarButtonItem{
			return new UIBarButtonItemAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class UIBarButtonItem */
}
