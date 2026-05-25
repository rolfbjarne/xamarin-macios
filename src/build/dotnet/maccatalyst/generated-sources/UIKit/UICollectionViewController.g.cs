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
	[Register("UICollectionViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollectionViewController : UIViewController, INSCoding, IUICollectionViewDataSource, IUICollectionViewDelegate, IUICollectionViewSource, IUIScrollViewDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UICollectionViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UICollectionViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollectionViewController () : base (NSObjectFlag.Empty)
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
		public UICollectionViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UICollectionViewController (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICollectionViewController (string? nibName, NSBundle? bundle)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		[Export ("initWithCollectionViewLayout:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICollectionViewController (UICollectionViewLayout layout)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var layout__handle__ = layout!.GetNonNullHandle (nameof (layout));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCollectionViewLayout:"), layout__handle__), "initWithCollectionViewLayout:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCollectionViewLayout:"), layout__handle__), "initWithCollectionViewLayout:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layout);
		}
		[Export ("collectionView:canEditItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanEditItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:canEditItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:canEditItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The <see cref="T:UIKit.UICollectionView" /> is associated with <c>this</c>.</param><param name="indexPath">The <see cref="T:Foundation.NSIndexPath" /> of the item being checked.</param><summary>Whether the item at <paramref name="indexPath" /> can be focused.</summary><returns>Returns <see langword="true" /> if the item can be focused.</returns><remarks><para>If this method is not implemented, the item's <see cref="P:UIKit.UIView.CanBecomeFocused" /> property will be checked.</para></remarks>
		[Export ("collectionView:canFocusItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanFocusItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:canFocusItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:canFocusItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:canMoveItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanMoveItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:canMoveItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:canMoveItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified <paramref name="indexPath" /> supports the specified action.</summary><returns>The default value is <see langword="false" />.</returns><remarks><para>This method is called after <see cref="UIKit.UICollectionViewDelegate_Extensions.ShouldShowMenu(UIKit.IUICollectionViewDelegate,UIKit.UICollectionView,Foundation.NSIndexPath)" /> and allows the developer to remove particular menu items from the displayed editing menu.</para></remarks>
		[Export ("collectionView:canPerformAction:forItemAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:canPerformAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:canPerformAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
			return ret != 0;
		}
		[Export ("collectionView:canPerformPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanPerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:canPerformPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:canPerformPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingCell:forItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CellDisplayingEnded (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didEndDisplayingCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didEndDisplayingCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration relating to a scroll event has ended.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationEnded (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidEndDecelerating:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidEndDecelerating:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view object that is decelerating the scrolling content.</param><summary>Indicates that deceleration of a scrolling event has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDecelerating:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DecelerationStarted (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewWillBeginDecelerating:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewWillBeginDecelerating:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		[Export ("collectionView:didBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginMultipleSelectionInteraction (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didBeginMultipleSelectionInteractionAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didBeginMultipleSelectionInteractionAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="scrollView">The scroll view whose insets changed.</param><summary>Method that is called when the inset values change.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidChangeAdjustedContentInset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAdjustedContentInset (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidChangeAdjustedContentInset:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidChangeAdjustedContentInset:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		[Export ("collectionViewDidEndMultipleSelectionInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndMultipleSelectionInteraction (UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("collectionViewDidEndMultipleSelectionInteraction:"), collectionView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionViewDidEndMultipleSelectionInteraction:"), collectionView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Indicates that the focus changed as detailed in the <paramref name="context" />.</summary><remarks><para>The values of <see cref="P:UIKit.UICollectionViewFocusUpdateContext.PreviouslyFocusedIndexPath" /> and <see cref="P:UIKit.UICollectionViewFocusUpdateContext.NextFocusedIndexPath" /> may be <see langword="null" /> if focus was previously not within, or just departed, the <paramref name="collectionView" />.</para></remarks>
		[Export ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:"), collectionView__handle__, context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didUpdateFocusInContext:withAnimationCoordinator:"), collectionView__handle__, context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
		}
		/// <param name="scrollView">Scroll view being zoomed.</param><summary>Indicates that the specified scrollView has zoomed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidZoom:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidZoom (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidZoom:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidZoom:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view where the content finished scrolling.</param><param name="willDecelerate"><see langword="true" /> if the scrolling movement will continue (but decelerate) after the user lifts their finger. If <see langword="false" /> then the scrolling stops immediately upon touch-up.</param><summary>Indicates that dragging has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndDragging:willDecelerate:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingEnded (UIScrollView scrollView, bool willDecelerate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:"), scrollView__handle__, willDecelerate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("scrollViewDidEndDragging:willDecelerate:"), scrollView__handle__, willDecelerate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view whose content is about to be scrolled.</param><summary>Indicates that dragging has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginDragging:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggingStarted (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewWillBeginDragging:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewWillBeginDragging:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
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
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Gets a cell.</summary><returns>A collection view cell.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:cellForItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewCell? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewCell> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:cellForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("collectionView:contextMenuConfigurationForItemAtIndexPath:point:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UICollectionView collectionView, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIContextMenuConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemAtIndexPath:point:"), collectionView__handle__, indexPath__handle__, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemAtIndexPath:point:"), collectionView__handle__, indexPath__handle__, point), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIContextMenuConfiguration? GetContextMenuConfiguration (UICollectionView collectionView, NSIndexPath[] indexPaths, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (indexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (indexPaths));
			using var nsa_indexPaths = NSArray.FromNSObjects (indexPaths);
			UIContextMenuConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:"), collectionView__handle__, nsa_indexPaths.Handle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIContextMenuConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("collectionView:contextMenuConfigurationForItemsAtIndexPaths:point:"), collectionView__handle__, nsa_indexPaths.Handle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[Export ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationDismissalPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:contextMenuConfiguration:dismissalPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetContextMenuConfigurationHighlightPreview (UICollectionView collectionView, UIContextMenuConfiguration configuration, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:contextMenuConfiguration:highlightPreviewForItemAtIndexPath:"), collectionView__handle__, configuration__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="title">The title of the item.</param><param name="atIndex">The index into the index titles for which to retrieve the index path.</param><summary>Requests the index path for the item in the collection view at the specified index with the specified title.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:indexPathForIndexTitle:atIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (UICollectionView collectionView, string title, nint atIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var nstitle = CFString.CreateNative (title);
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("collectionView:indexPathForIndexTitle:atIndex:"), collectionView__handle__, nstitle, atIndex), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("collectionView:indexPathForIndexTitle:atIndex:"), collectionView__handle__, nstitle, atIndex), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			CFString.ReleaseNative (nstitle);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>When overridden, allows the developer to specify the item that should initially receive focus.</summary><returns>To be added.</returns><remarks><para>The value returned by this method will be ignored on re-entry if the <paramref name="collectionView" /> object's <see cref="P:UIKit.UICollectionView.RemembersLastFocusedIndexPath" /> is <see langword="true" />. </para></remarks>
		[Export ("indexPathForPreferredFocusedViewInCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPathForPreferredFocusedView (UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathForPreferredFocusedViewInCollectionView:"), collectionView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathForPreferredFocusedViewInCollectionView:"), collectionView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>Requests the index titles for the items in the specified collection view.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexTitlesForCollectionView:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetIndexTitles (UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexTitlesForCollectionView:"), collectionView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexTitlesForCollectionView:"), collectionView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="section">To be added.</param><summary>Returns the number of items in the specified section.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("collectionView:numberOfItemsInSection:"), collectionView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		[Export ("collectionView:previewForDismissingContextMenuWithConfiguration:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForDismissingContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:previewForDismissingContextMenuWithConfiguration:"), collectionView__handle__, configuration__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:previewForDismissingContextMenuWithConfiguration:"), collectionView__handle__, configuration__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[Export ("collectionView:previewForHighlightingContextMenuWithConfiguration:")]
		[ObsoletedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITargetedPreview? GetPreviewForHighlightingContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			UITargetedPreview? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:previewForHighlightingContextMenuWithConfiguration:"), collectionView__handle__, configuration__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITargetedPreview> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:previewForHighlightingContextMenuWithConfiguration:"), collectionView__handle__, configuration__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			return ret!;
		}
		[Export ("collectionView:sceneActivationConfigurationForItemAtIndexPath:point:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIWindowSceneActivationConfiguration? GetSceneActivationConfigurationForItem (UICollectionView collectionView, NSIndexPath indexPath, CGPoint point)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UIWindowSceneActivationConfiguration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIWindowSceneActivationConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("collectionView:sceneActivationConfigurationForItemAtIndexPath:point:"), collectionView__handle__, indexPath__handle__, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIWindowSceneActivationConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("collectionView:sceneActivationConfigurationForItemAtIndexPath:point:"), collectionView__handle__, indexPath__handle__, point), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("collectionView:selectionFollowsFocusForItemAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetSelectionFollowsFocusForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:selectionFollowsFocusForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:selectionFollowsFocusForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="proposedContentOffset">To be added.</param><summary>When overridden, allows the developer to modify the content offset for layout and animation changes.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:targetContentOffsetForProposedContentOffset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetTargetContentOffset (UICollectionView collectionView, CGPoint proposedContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("collectionView:targetContentOffsetForProposedContentOffset:"), collectionView__handle__, proposedContentOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("collectionView:targetContentOffsetForProposedContentOffset:"), collectionView__handle__, proposedContentOffset);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="originalIndexPath">To be added.</param><param name="proposedIndexPath">To be added.</param><summary>When overridden, allows the developer to modify the final location of a moved item. (For instance, to disallow a move to a particular <paramref name="proposedIndexPath" />.)</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GetTargetIndexPathForMoveOfItemFromOriginalIndexPath' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForMove (UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, proposedIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:targetIndexPathForMoveFromItemAtIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, proposedIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		[Export ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForMoveOfItemFromOriginalIndexPath (UICollectionView collectionView, NSIndexPath originalIndexPath, NSIndexPath currentIndexPath, NSIndexPath proposedIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var originalIndexPath__handle__ = originalIndexPath!.GetNonNullHandle (nameof (originalIndexPath));
			var currentIndexPath__handle__ = currentIndexPath!.GetNonNullHandle (nameof (currentIndexPath));
			var proposedIndexPath__handle__ = proposedIndexPath!.GetNonNullHandle (nameof (proposedIndexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, currentIndexPath__handle__, proposedIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:targetIndexPathForMoveOfItemFromOriginalIndexPath:atCurrentIndexPath:toProposedIndexPath:"), collectionView__handle__, originalIndexPath__handle__, currentIndexPath__handle__, proposedIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (originalIndexPath);
			GC.KeepAlive (currentIndexPath);
			GC.KeepAlive (proposedIndexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The reusable view used for the supplementary element at the specified indexPath.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionReusableView GetViewForSupplementaryElement (UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionReusableView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionReusableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, elementKind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionReusableView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:"), collectionView__handle__, elementKind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been deselected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didDeselectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemDeselected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been highlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didHighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemHighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been selected.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Indicates that the cell at the specified indexPath has been unhighlighted.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didUnhighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ItemUnhighlighted (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didUnhighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didUnhighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="sourceIndexPath">To be added.</param><param name="destinationIndexPath">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:moveItemAtIndexPath:toIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItem (UICollectionView collectionView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var sourceIndexPath__handle__ = sourceIndexPath!.GetNonNullHandle (nameof (sourceIndexPath));
			var destinationIndexPath__handle__ = destinationIndexPath!.GetNonNullHandle (nameof (destinationIndexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:moveItemAtIndexPath:toIndexPath:"), collectionView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:moveItemAtIndexPath:toIndexPath:"), collectionView__handle__, sourceIndexPath__handle__, destinationIndexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (sourceIndexPath);
			GC.KeepAlive (destinationIndexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><summary>The number of sections in this UICollectionViewDataSource.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInCollectionView:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections (UICollectionView collectionView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("numberOfSectionsInCollectionView:"), collectionView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="action">To be added.</param><param name="indexPath">To be added.</param><param name="sender">To be added.</param><summary>Whether the cell at the specified indexPath supports the specified Copy or Paste action.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:performAction:forItemAtIndexPath:withSender:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (UICollectionView collectionView, Selector action, NSIndexPath indexPath, NSObject sender)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:performAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:performAction:forItemAtIndexPath:withSender:"), collectionView__handle__, action.Handle, indexPath__handle__, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (action);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (sender);
		}
		[Export ("collectionView:performPrimaryActionForItemAtIndexPath:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPrimaryActionForItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:performPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:performPrimaryActionForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
		}
		/// <param name="scrollView">Scroll view that is performing a scrolling animation.</param><summary>Indicates that all animations relating to scrolling have completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndScrollingAnimation:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollAnimationEnded (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidEndScrollingAnimation:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidEndScrollingAnimation:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view where the scrolling occurred.</param><summary>Indicates that the specified scrollView has scrolled.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScroll:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Scrolled (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidScroll:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidScroll:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		/// <param name="scrollView">Scroll view that was scrolled.</param><summary>Indicates that the specified scrollView's scrolling has ended at the top.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrolledToTop (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewDidScrollToTop:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewDidScrollToTop:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
		}
		[Export ("collectionView:shouldBeginMultipleSelectionInteractionAtIndexPath:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginMultipleSelectionInteraction (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldBeginMultipleSelectionInteractionAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be deselected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldDeselectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeselectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldDeselectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should allow itself to be highlighted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldHighlightItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHighlightItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldHighlightItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="scrollView">Scroll view requesting whether scroll is allowed.</param><summary>Whether a scroll to the beginning of the scrollView should be permitted.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scrollViewShouldScrollToTop:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldScrollToTop (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewShouldScrollToTop:"), scrollView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewShouldScrollToTop:"), scrollView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath allows itself to be selected.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSelectItemAtIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSelectItem (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldSelectItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">To be added.</param><summary>Whether the cell at the specified indexPath should show an Action menu.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldShowMenuForItemAtIndexPath:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'GetContextMenuConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetContextMenuConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowMenu (UICollectionView collectionView, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldShowMenuForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldShowMenuForItemAtIndexPath:"), collectionView__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="indexPath">The index path to the item.</param><param name="context">The spring-loaded interaction context.</param><summary>Method that is called to indicate whether the identified item should springload in the specified context.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldSpringLoadItemAtIndexPath:withContext:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSpringLoadItem (UICollectionView collectionView, NSIndexPath indexPath, IUISpringLoadedInteractionContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldSpringLoadItemAtIndexPath:withContext:"), collectionView__handle__, indexPath__handle__, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldSpringLoadItemAtIndexPath:withContext:"), collectionView__handle__, indexPath__handle__, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="context">To be added.</param><summary>When overridden, allows the developer to prevent the focus change specified in <paramref name="context" />.</summary><returns><see langword="true" /> if the focus specified in <paramref name="context" /> is allowed.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:shouldUpdateFocusInContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (UICollectionView collectionView, UICollectionViewFocusUpdateContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:shouldUpdateFocusInContext:"), collectionView__handle__, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:shouldUpdateFocusInContext:"), collectionView__handle__, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>Indicates that the supplementary view at the specified indexPath has been removed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SupplementaryViewDisplayingEnded (UICollectionView collectionView, UICollectionReusableView view, NSString elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:didEndDisplayingSupplementaryView:forElementOfKind:atIndexPath:"), collectionView__handle__, view__handle__, elementKind__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="fromLayout">To be added.</param><param name="toLayout">To be added.</param><summary>The UICollectionViewTransitionLayout to be used when moving from the specified fromLayout to the toLayout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:transitionLayoutForOldLayout:newLayout:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewTransitionLayout TransitionLayout (UICollectionView collectionView, UICollectionViewLayout fromLayout, UICollectionViewLayout toLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var fromLayout__handle__ = fromLayout!.GetNonNullHandle (nameof (fromLayout));
			var toLayout__handle__ = toLayout!.GetNonNullHandle (nameof (toLayout));
			UICollectionViewTransitionLayout? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewTransitionLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:transitionLayoutForOldLayout:newLayout:"), collectionView__handle__, fromLayout__handle__, toLayout__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (fromLayout);
			GC.KeepAlive (toLayout);
			return ret!;
		}
		/// <param name="scrollView">Scroll view displaying the content.</param><summary>The UIView to scale when zooming is requested.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("viewForZoomingInScrollView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIView ViewForZoomingInScrollView (UIScrollView scrollView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			UIView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForZoomingInScrollView:"), scrollView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("viewForZoomingInScrollView:"), scrollView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
			return ret!;
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="cell">To be added.</param><param name="indexPath">To be added.</param><summary>The <paramref name="cell" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplayCell:forItemAtIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayCell (UICollectionView collectionView, UICollectionViewCell cell, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:willDisplayCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:willDisplayCell:forItemAtIndexPath:"), collectionView__handle__, cell__handle__, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (cell);
			GC.KeepAlive (indexPath);
		}
		[Export ("collectionView:willDisplayContextMenuWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplayContextMenu (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:willDisplayContextMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:willDisplayContextMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		/// <param name="collectionView">The collection view that originated the request.</param><param name="view">To be added.</param><param name="elementKind">To be added.</param><param name="indexPath">To be added.</param><summary>The supplementary <paramref name="view" /> is about to be displayed.</summary><remarks>To be added.</remarks>
		[Export ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDisplaySupplementaryView (UICollectionView collectionView, UICollectionReusableView view, string elementKind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			var nselementKind = CFString.CreateNative (elementKind);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:willDisplaySupplementaryView:forElementKind:atIndexPath:"), collectionView__handle__, view__handle__, nselementKind, indexPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (view);
			GC.KeepAlive (indexPath);
			CFString.ReleaseNative (nselementKind);
		}
		[Export ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEndContextMenuInteraction (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionAnimating? animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:willEndContextMenuInteractionWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		/// <param name="scrollView">Scroll view where user touch ended.</param><param name="velocity">The velocity of the scroll view (in points) when the touch ended.</param><param name="targetContentOffset">The expected offset when the scrolling action decelerates to a stop.</param><summary>Indicates that dragging is about to end.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillEndDragging (UIScrollView scrollView, CGPoint velocity, ref CGPoint targetContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			fixed (CGPoint* targetContentOffset__pointer = &targetContentOffset) {
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_ref_CGPoint (this.Handle, Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:"), scrollView__handle__, velocity, targetContentOffset__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_ref_CGPoint (&__objc_super__, Selector.GetHandle ("scrollViewWillEndDragging:withVelocity:targetContentOffset:"), scrollView__handle__, velocity, targetContentOffset__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
			}
		}
		[Export ("collectionView:willPerformPreviewActionForMenuWithConfiguration:animator:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPerformPreviewAction (UICollectionView collectionView, UIContextMenuConfiguration configuration, IUIContextMenuInteractionCommitAnimating animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collectionView:willPerformPreviewActionForMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("collectionView:willPerformPreviewActionForMenuWithConfiguration:animator:"), collectionView__handle__, configuration__handle__, animator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (configuration);
			GC.KeepAlive (animator);
		}
		/// <param name="scrollView">Scroll view containing the content being zoomed.</param><param name="withView">View representing the content that needs to be scaled.</param><param name="atScale">The scale factor to use. This value must be between the limits set by the <see cref="T:UIKit.UIScrollView" /> properties <see cref="P:UIKit.UIScrollView.MinimumZoomScale" /> and <see cref="P:UIKit.UIScrollView.MaximumZoomScale" />.</param><summary>Indicates that zooming has completed.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewDidEndZooming:withView:atScale:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingEnded (UIScrollView scrollView, UIView withView, nfloat atScale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var withView__handle__ = withView!.GetNonNullHandle (nameof (withView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:"), scrollView__handle__, withView__handle__, atScale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("scrollViewDidEndZooming:withView:atScale:"), scrollView__handle__, withView__handle__, atScale);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
			GC.KeepAlive (withView);
		}
		/// <param name="scrollView">Scroll view containing the content.</param><param name="view">The content view about to be zoomed.</param><summary>Indicates that zooming has begun.</summary><remarks>To be added.</remarks>
		[Export ("scrollViewWillBeginZooming:withView:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ZoomingStarted (UIScrollView scrollView, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scrollView__handle__ = scrollView!.GetNonNullHandle (nameof (scrollView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("scrollViewWillBeginZooming:withView:"), scrollView__handle__, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("scrollViewWillBeginZooming:withView:"), scrollView__handle__, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scrollView);
			GC.KeepAlive (view);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClearsSelectionOnViewWillAppear {
			[Export ("clearsSelectionOnViewWillAppear")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("clearsSelectionOnViewWillAppear"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clearsSelectionOnViewWillAppear"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setClearsSelectionOnViewWillAppear:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClearsSelectionOnViewWillAppear:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setClearsSelectionOnViewWillAppear:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionView CollectionView {
			[Export ("collectionView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICollectionView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UICollectionView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("collectionView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UICollectionView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collectionView")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCollectionView:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCollectionView:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCollectionView:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool InstallsStandardGestureForInteractiveMovement {
			[Export ("installsStandardGestureForInteractiveMovement")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("installsStandardGestureForInteractiveMovement"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("installsStandardGestureForInteractiveMovement"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setInstallsStandardGestureForInteractiveMovement:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInstallsStandardGestureForInteractiveMovement:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setInstallsStandardGestureForInteractiveMovement:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayout Layout {
			[Export ("collectionViewLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICollectionViewLayout? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UICollectionViewLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("collectionViewLayout")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UICollectionViewLayout> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collectionViewLayout")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UseLayoutToLayoutNavigationTransitions {
			[Export ("useLayoutToLayoutNavigationTransitions")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useLayoutToLayoutNavigationTransitions"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("useLayoutToLayoutNavigationTransitions"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUseLayoutToLayoutNavigationTransitions:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseLayoutToLayoutNavigationTransitions:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUseLayoutToLayoutNavigationTransitions:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class UICollectionViewController */
}
