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
	[Register("NSTabViewController", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTabViewController : NSViewController, INSTabViewDelegate, INSToolbarDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTabViewItem_X = "addTabViewItem:";
		static readonly NativeHandle selAddTabViewItem_XHandle = Selector.GetHandle ("addTabViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanPropagateSelectedChildViewControllerTitleX = "canPropagateSelectedChildViewControllerTitle";
		static readonly NativeHandle selCanPropagateSelectedChildViewControllerTitleXHandle = Selector.GetHandle ("canPropagateSelectedChildViewControllerTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNibName_Bundle_X = "initWithNibName:bundle:";
		static readonly NativeHandle selInitWithNibName_Bundle_XHandle = Selector.GetHandle ("initWithNibName:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTabViewItem_AtIndex_X = "insertTabViewItem:atIndex:";
		static readonly NativeHandle selInsertTabViewItem_AtIndex_XHandle = Selector.GetHandle ("insertTabViewItem:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTabViewItem_X = "removeTabViewItem:";
		static readonly NativeHandle selRemoveTabViewItem_XHandle = Selector.GetHandle ("removeTabViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedTabViewItemIndexX = "selectedTabViewItemIndex";
		static readonly NativeHandle selSelectedTabViewItemIndexXHandle = Selector.GetHandle ("selectedTabViewItemIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanPropagateSelectedChildViewControllerTitle_X = "setCanPropagateSelectedChildViewControllerTitle:";
		static readonly NativeHandle selSetCanPropagateSelectedChildViewControllerTitle_XHandle = Selector.GetHandle ("setCanPropagateSelectedChildViewControllerTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedTabViewItemIndex_X = "setSelectedTabViewItemIndex:";
		static readonly NativeHandle selSetSelectedTabViewItemIndex_XHandle = Selector.GetHandle ("setSelectedTabViewItemIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabStyle_X = "setTabStyle:";
		static readonly NativeHandle selSetTabStyle_XHandle = Selector.GetHandle ("setTabStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabView_X = "setTabView:";
		static readonly NativeHandle selSetTabView_XHandle = Selector.GetHandle ("setTabView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabViewItems_X = "setTabViewItems:";
		static readonly NativeHandle selSetTabViewItems_XHandle = Selector.GetHandle ("setTabViewItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransitionOptions_X = "setTransitionOptions:";
		static readonly NativeHandle selSetTransitionOptions_XHandle = Selector.GetHandle ("setTransitionOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabStyleX = "tabStyle";
		static readonly NativeHandle selTabStyleXHandle = Selector.GetHandle ("tabStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabViewX = "tabView";
		static readonly NativeHandle selTabViewXHandle = Selector.GetHandle ("tabView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabView_DidSelectTabViewItem_X = "tabView:didSelectTabViewItem:";
		static readonly NativeHandle selTabView_DidSelectTabViewItem_XHandle = Selector.GetHandle ("tabView:didSelectTabViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabView_ShouldSelectTabViewItem_X = "tabView:shouldSelectTabViewItem:";
		static readonly NativeHandle selTabView_ShouldSelectTabViewItem_XHandle = Selector.GetHandle ("tabView:shouldSelectTabViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabView_WillSelectTabViewItem_X = "tabView:willSelectTabViewItem:";
		static readonly NativeHandle selTabView_WillSelectTabViewItem_XHandle = Selector.GetHandle ("tabView:willSelectTabViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabViewDidChangeNumberOfTabViewItems_X = "tabViewDidChangeNumberOfTabViewItems:";
		static readonly NativeHandle selTabViewDidChangeNumberOfTabViewItems_XHandle = Selector.GetHandle ("tabViewDidChangeNumberOfTabViewItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabViewItemForViewController_X = "tabViewItemForViewController:";
		static readonly NativeHandle selTabViewItemForViewController_XHandle = Selector.GetHandle ("tabViewItemForViewController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabViewItemsX = "tabViewItems";
		static readonly NativeHandle selTabViewItemsXHandle = Selector.GetHandle ("tabViewItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_X = "toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:";
		static readonly NativeHandle selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_XHandle = Selector.GetHandle ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbar_ItemIdentifier_CanBeInsertedAtIndex_X = "toolbar:itemIdentifier:canBeInsertedAtIndex:";
		static readonly NativeHandle selToolbar_ItemIdentifier_CanBeInsertedAtIndex_XHandle = Selector.GetHandle ("toolbar:itemIdentifier:canBeInsertedAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarAllowedItemIdentifiers_X = "toolbarAllowedItemIdentifiers:";
		static readonly NativeHandle selToolbarAllowedItemIdentifiers_XHandle = Selector.GetHandle ("toolbarAllowedItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarDefaultItemIdentifiers_X = "toolbarDefaultItemIdentifiers:";
		static readonly NativeHandle selToolbarDefaultItemIdentifiers_XHandle = Selector.GetHandle ("toolbarDefaultItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarDidRemoveItem_X = "toolbarDidRemoveItem:";
		static readonly NativeHandle selToolbarDidRemoveItem_XHandle = Selector.GetHandle ("toolbarDidRemoveItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarImmovableItemIdentifiers_X = "toolbarImmovableItemIdentifiers:";
		static readonly NativeHandle selToolbarImmovableItemIdentifiers_XHandle = Selector.GetHandle ("toolbarImmovableItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarSelectableItemIdentifiers_X = "toolbarSelectableItemIdentifiers:";
		static readonly NativeHandle selToolbarSelectableItemIdentifiers_XHandle = Selector.GetHandle ("toolbarSelectableItemIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolbarWillAddItem_X = "toolbarWillAddItem:";
		static readonly NativeHandle selToolbarWillAddItem_XHandle = Selector.GetHandle ("toolbarWillAddItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransitionOptionsX = "transitionOptions";
		static readonly NativeHandle selTransitionOptionsXHandle = Selector.GetHandle ("transitionOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTabViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTabViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTabViewController () : base (NSObjectFlag.Empty)
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
		public NSTabViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSTabViewController (NSObjectFlag t) : base (t)
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
		protected internal NSTabViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTabViewController (string? nibNameOrNull, NSBundle? nibBundleOrNull)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nibBundleOrNull__handle__ = nibBundleOrNull.GetHandle ();
			var nsnibNameOrNull = CFString.CreateNative (nibNameOrNull);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nibBundleOrNull);
			CFString.ReleaseNative (nsnibNameOrNull);
		}
		[Export ("addTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTabViewItem (NSTabViewItem tabViewItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabViewItem__handle__ = tabViewItem!.GetNonNullHandle (nameof (tabViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddTabViewItem_XHandle, tabViewItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddTabViewItem_XHandle, tabViewItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabViewItem);
		}
		[Export ("toolbarAllowedItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual string[] AllowedItemIdentifiers (NSToolbar toolbar)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToolbarAllowedItemIdentifiers_XHandle, toolbar__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarAllowedItemIdentifiers_XHandle, toolbar__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			return ret!;
		}
		[Export ("toolbarDefaultItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual string[] DefaultItemIdentifiers (NSToolbar toolbar)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToolbarDefaultItemIdentifiers_XHandle, toolbar__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarDefaultItemIdentifiers_XHandle, toolbar__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toolbarDidRemoveItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveItem (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToolbarDidRemoveItem_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarDidRemoveItem_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("tabView:didSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void DidSelect (NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTabView_DidSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTabView_DidSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		[Export ("toolbar:itemIdentifier:canBeInsertedAtIndex:")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetItemCanBeInsertedAt (NSToolbar toolbar, string itemIdentifier, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selToolbar_ItemIdentifier_CanBeInsertedAtIndex_XHandle, toolbar__handle__, nsitemIdentifier, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selToolbar_ItemIdentifier_CanBeInsertedAtIndex_XHandle, toolbar__handle__, nsitemIdentifier, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret != 0;
		}
		[Export ("tabViewItemForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTabViewItem GetTabViewItem (NSViewController viewController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			NSTabViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTabViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTabViewItemForViewController_XHandle, viewController__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTabViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTabViewItemForViewController_XHandle, viewController__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewController);
			return ret!;
		}
		[Export ("toolbarImmovableItemIdentifiers:")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString> GetToolbarImmovableItemIdentifiers (NSToolbar toolbar)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			NSSet<NSString>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToolbarImmovableItemIdentifiers_XHandle, toolbar__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarImmovableItemIdentifiers_XHandle, toolbar__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			return ret!;
		}
		[Export ("insertTabViewItem:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertTabViewItem (NSTabViewItem tabViewItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabViewItem__handle__ = tabViewItem!.GetNonNullHandle (nameof (tabViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertTabViewItem_AtIndex_XHandle, tabViewItem__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertTabViewItem_AtIndex_XHandle, tabViewItem__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabViewItem);
		}
		/// <param name="tabView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("tabViewDidChangeNumberOfTabViewItems:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NumberOfItemsChanged (NSTabView tabView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTabViewDidChangeNumberOfTabViewItems_XHandle, tabView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTabViewDidChangeNumberOfTabViewItems_XHandle, tabView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabView);
		}
		[Export ("removeTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTabViewItem (NSTabViewItem tabViewItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabViewItem__handle__ = tabViewItem!.GetNonNullHandle (nameof (tabViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveTabViewItem_XHandle, tabViewItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveTabViewItem_XHandle, tabViewItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabViewItem);
		}
		[Export ("toolbarSelectableItemIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual string[] SelectableItemIdentifiers (NSToolbar toolbar)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selToolbarSelectableItemIdentifiers_XHandle, toolbar__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarSelectableItemIdentifiers_XHandle, toolbar__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			return ret!;
		}
		[Export ("tabView:shouldSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual bool ShouldSelectTabViewItem (NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTabView_ShouldSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTabView_ShouldSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("toolbarWillAddItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillAddItem (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToolbarWillAddItem_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToolbarWillAddItem_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual NSToolbarItem? WillInsertItem (NSToolbar toolbar, string itemIdentifier, bool willBeInserted)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var toolbar__handle__ = toolbar!.GetNonNullHandle (nameof (toolbar));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			NSToolbarItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSToolbarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_XHandle, toolbar__handle__, nsitemIdentifier, willBeInserted ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSToolbarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selToolbar_ItemForItemIdentifier_WillBeInsertedIntoToolbar_XHandle, toolbar__handle__, nsitemIdentifier, willBeInserted ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toolbar);
			CFString.ReleaseNative (nsitemIdentifier);
			return ret!;
		}
		[Export ("tabView:willSelectTabViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void WillSelect (NSTabView tabView, NSTabViewItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var tabView__handle__ = tabView!.GetNonNullHandle (nameof (tabView));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTabView_WillSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTabView_WillSelectTabViewItem_XHandle, tabView__handle__, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tabView);
			GC.KeepAlive (item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPropagateSelectedChildViewControllerTitle {
			[Export ("canPropagateSelectedChildViewControllerTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanPropagateSelectedChildViewControllerTitleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanPropagateSelectedChildViewControllerTitleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanPropagateSelectedChildViewControllerTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanPropagateSelectedChildViewControllerTitle_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanPropagateSelectedChildViewControllerTitle_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedTabViewItemIndex {
			[Export ("selectedTabViewItemIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTabViewItemIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectedTabViewItemIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedTabViewItemIndex:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedTabViewItemIndex_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSelectedTabViewItemIndex_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTabViewControllerTabStyle TabStyle {
			[Export ("tabStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTabViewControllerTabStyle ret;
				if (IsDirectBinding) {
					ret = (NSTabViewControllerTabStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTabStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTabViewControllerTabStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTabStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTabStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTabStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTabStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTabView TabView {
			[Export ("tabView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTabView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTabView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTabViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTabView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTabViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTabView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTabView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTabView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTabViewItem[] TabViewItems {
			[Export ("tabViewItems", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTabViewItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTabViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTabViewItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTabViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTabViewItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTabViewItems:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTabViewItems_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTabViewItems_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSViewControllerTransitionOptions TransitionOptions {
			[Export ("transitionOptions")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSViewControllerTransitionOptions ret;
				if (IsDirectBinding) {
					ret = (NSViewControllerTransitionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTransitionOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSViewControllerTransitionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTransitionOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTransitionOptions:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetTransitionOptions_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetTransitionOptions_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSTabViewController */
}
