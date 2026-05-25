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
	[Register("NSSplitViewController", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSplitViewController : NSViewController, INSSplitViewDelegate, INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSplitViewItem_X = "addSplitViewItem:";
		static readonly NativeHandle selAddSplitViewItem_XHandle = Selector.GetHandle ("addSplitViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNibName_Bundle_X = "initWithNibName:bundle:";
		static readonly NativeHandle selInitWithNibName_Bundle_XHandle = Selector.GetHandle ("initWithNibName:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSplitViewItem_AtIndex_X = "insertSplitViewItem:atIndex:";
		static readonly NativeHandle selInsertSplitViewItem_AtIndex_XHandle = Selector.GetHandle ("insertSplitViewItem:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumThicknessForInlineSidebarsX = "minimumThicknessForInlineSidebars";
		static readonly NativeHandle selMinimumThicknessForInlineSidebarsXHandle = Selector.GetHandle ("minimumThicknessForInlineSidebars");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveSplitViewItem_X = "removeSplitViewItem:";
		static readonly NativeHandle selRemoveSplitViewItem_XHandle = Selector.GetHandle ("removeSplitViewItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumThicknessForInlineSidebars_X = "setMinimumThicknessForInlineSidebars:";
		static readonly NativeHandle selSetMinimumThicknessForInlineSidebars_XHandle = Selector.GetHandle ("setMinimumThicknessForInlineSidebars:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSplitView_X = "setSplitView:";
		static readonly NativeHandle selSetSplitView_XHandle = Selector.GetHandle ("setSplitView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSplitViewItems_X = "setSplitViewItems:";
		static readonly NativeHandle selSetSplitViewItems_XHandle = Selector.GetHandle ("setSplitViewItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitViewX = "splitView";
		static readonly NativeHandle selSplitViewXHandle = Selector.GetHandle ("splitView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_AdditionalEffectiveRectOfDividerAtIndex_X = "splitView:additionalEffectiveRectOfDividerAtIndex:";
		static readonly NativeHandle selSplitView_AdditionalEffectiveRectOfDividerAtIndex_XHandle = Selector.GetHandle ("splitView:additionalEffectiveRectOfDividerAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_CanCollapseSubview_X = "splitView:canCollapseSubview:";
		static readonly NativeHandle selSplitView_CanCollapseSubview_XHandle = Selector.GetHandle ("splitView:canCollapseSubview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ConstrainMaxCoordinate_OfSubviewAt_X = "splitView:constrainMaxCoordinate:ofSubviewAt:";
		static readonly NativeHandle selSplitView_ConstrainMaxCoordinate_OfSubviewAt_XHandle = Selector.GetHandle ("splitView:constrainMaxCoordinate:ofSubviewAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ConstrainMinCoordinate_OfSubviewAt_X = "splitView:constrainMinCoordinate:ofSubviewAt:";
		static readonly NativeHandle selSplitView_ConstrainMinCoordinate_OfSubviewAt_XHandle = Selector.GetHandle ("splitView:constrainMinCoordinate:ofSubviewAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ConstrainSplitPosition_OfSubviewAt_X = "splitView:constrainSplitPosition:ofSubviewAt:";
		static readonly NativeHandle selSplitView_ConstrainSplitPosition_OfSubviewAt_XHandle = Selector.GetHandle ("splitView:constrainSplitPosition:ofSubviewAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_X = "splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:";
		static readonly NativeHandle selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_XHandle = Selector.GetHandle ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ResizeSubviewsWithOldSize_X = "splitView:resizeSubviewsWithOldSize:";
		static readonly NativeHandle selSplitView_ResizeSubviewsWithOldSize_XHandle = Selector.GetHandle ("splitView:resizeSubviewsWithOldSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ShouldAdjustSizeOfSubview_X = "splitView:shouldAdjustSizeOfSubview:";
		static readonly NativeHandle selSplitView_ShouldAdjustSizeOfSubview_XHandle = Selector.GetHandle ("splitView:shouldAdjustSizeOfSubview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_X = "splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:";
		static readonly NativeHandle selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_XHandle = Selector.GetHandle ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitView_ShouldHideDividerAtIndex_X = "splitView:shouldHideDividerAtIndex:";
		static readonly NativeHandle selSplitView_ShouldHideDividerAtIndex_XHandle = Selector.GetHandle ("splitView:shouldHideDividerAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitViewDidResizeSubviews_X = "splitViewDidResizeSubviews:";
		static readonly NativeHandle selSplitViewDidResizeSubviews_XHandle = Selector.GetHandle ("splitViewDidResizeSubviews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitViewItemForViewController_X = "splitViewItemForViewController:";
		static readonly NativeHandle selSplitViewItemForViewController_XHandle = Selector.GetHandle ("splitViewItemForViewController:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitViewItemsX = "splitViewItems";
		static readonly NativeHandle selSplitViewItemsXHandle = Selector.GetHandle ("splitViewItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitViewWillResizeSubviews_X = "splitViewWillResizeSubviews:";
		static readonly NativeHandle selSplitViewWillResizeSubviews_XHandle = Selector.GetHandle ("splitViewWillResizeSubviews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleInspector_X = "toggleInspector:";
		static readonly NativeHandle selToggleInspector_XHandle = Selector.GetHandle ("toggleInspector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleSidebar_X = "toggleSidebar:";
		static readonly NativeHandle selToggleSidebar_XHandle = Selector.GetHandle ("toggleSidebar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSplitViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSSplitViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSplitViewController () : base (NSObjectFlag.Empty)
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
		public NSSplitViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSSplitViewController (NSObjectFlag t) : base (t)
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
		protected internal NSSplitViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSplitViewController (string? nibNameOrNull, NSBundle? nibBundleOrNull)
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
		[Export ("addSplitViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSplitViewItem (NSSplitViewItem splitViewItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitViewItem__handle__ = splitViewItem!.GetNonNullHandle (nameof (splitViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddSplitViewItem_XHandle, splitViewItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSplitViewItem_XHandle, splitViewItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitViewItem);
		}
		[Export ("splitView:canCollapseSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual bool CanCollapse (NSSplitView splitView, NSView subview)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSplitView_CanCollapseSubview_XHandle, splitView__handle__, subview__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSplitView_CanCollapseSubview_XHandle, splitView__handle__, subview__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		/// <param name="splitView">To be added.</param><param name="proposedPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainSplitPosition:ofSubviewAt:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ConstrainSplitPosition (NSSplitView splitView, nfloat proposedPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (this.Handle, selSplitView_ConstrainSplitPosition_OfSubviewAt_XHandle, splitView__handle__, proposedPosition, subviewDividerIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_nfloat_IntPtr (&__objc_super__, selSplitView_ConstrainSplitPosition_OfSubviewAt_XHandle, splitView__handle__, proposedPosition, subviewDividerIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitViewDidResizeSubviews:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResizeSubviews (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSplitViewDidResizeSubviews_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSplitViewDidResizeSubviews_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("splitView:additionalEffectiveRectOfDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual CGRect GetAdditionalEffectiveRect (NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_IntPtr (this.Handle, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_IntPtr (&__objc_super__, selSplitView_AdditionalEffectiveRectOfDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		[Export ("splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual CGRect GetEffectiveRect (NSSplitView splitView, CGRect proposedEffectiveRect, CGRect drawnRect, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_CGRect_CGRect_IntPtr (this.Handle, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_XHandle, splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_CGRect_CGRect_IntPtr (this.Handle, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_XHandle, splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_CGRect_CGRect_IntPtr (&__objc_super__, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_XHandle, splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_CGRect_CGRect_IntPtr (&__objc_super__, selSplitView_EffectiveRect_ForDrawnRect_OfDividerAtIndex_XHandle, splitView__handle__, proposedEffectiveRect, drawnRect, dividerIndex);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		[Export ("splitViewItemForViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSplitViewItem GetSplitViewItem (NSViewController viewController)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			NSSplitViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSplitViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSplitViewItemForViewController_XHandle, viewController__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSplitViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSplitViewItemForViewController_XHandle, viewController__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewController);
			return ret!;
		}
		[Export ("insertSplitViewItem:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSplitViewItem (NSSplitViewItem splitViewItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitViewItem__handle__ = splitViewItem!.GetNonNullHandle (nameof (splitViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertSplitViewItem_AtIndex_XHandle, splitViewItem__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertSplitViewItem_AtIndex_XHandle, splitViewItem__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitViewItem);
		}
		[Export ("removeSplitViewItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSplitViewItem (NSSplitViewItem splitViewItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitViewItem__handle__ = splitViewItem!.GetNonNullHandle (nameof (splitViewItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveSplitViewItem_XHandle, splitViewItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveSplitViewItem_XHandle, splitViewItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitViewItem);
		}
		/// <param name="splitView">To be added.</param><param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitView:resizeSubviewsWithOldSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resize (NSSplitView splitView, CGSize oldSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGSize (this.Handle, selSplitView_ResizeSubviewsWithOldSize_XHandle, splitView__handle__, oldSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGSize (&__objc_super__, selSplitView_ResizeSubviewsWithOldSize_XHandle, splitView__handle__, oldSize);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
		}
		/// <param name="splitView">To be added.</param><param name="proposedMaximumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainMaxCoordinate:ofSubviewAt:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMaxCoordinateOfSubview (NSSplitView splitView, nfloat proposedMaximumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (this.Handle, selSplitView_ConstrainMaxCoordinate_OfSubviewAt_XHandle, splitView__handle__, proposedMaximumPosition, subviewDividerIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_nfloat_IntPtr (&__objc_super__, selSplitView_ConstrainMaxCoordinate_OfSubviewAt_XHandle, splitView__handle__, proposedMaximumPosition, subviewDividerIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="proposedMinimumPosition">To be added.</param><param name="subviewDividerIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:constrainMinCoordinate:ofSubviewAt:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SetMinCoordinateOfSubview (NSSplitView splitView, nfloat proposedMinimumPosition, nint subviewDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_nfloat_IntPtr (this.Handle, selSplitView_ConstrainMinCoordinate_OfSubviewAt_XHandle, splitView__handle__, proposedMinimumPosition, subviewDividerIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_nfloat_IntPtr (&__objc_super__, selSplitView_ConstrainMinCoordinate_OfSubviewAt_XHandle, splitView__handle__, proposedMinimumPosition, subviewDividerIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			return ret!;
		}
		/// <param name="splitView">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("splitView:shouldAdjustSizeOfSubview:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAdjustSize (NSSplitView splitView, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSplitView_ShouldAdjustSizeOfSubview_XHandle, splitView__handle__, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSplitView_ShouldAdjustSizeOfSubview_XHandle, splitView__handle__, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			GC.KeepAlive (view);
			return ret != 0;
		}
		[Export ("splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:")]
		[ObsoletedOSPlatform ("macos10.15", "This delegate method is never called, and NSSplitViewController's implementation always returns false.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual bool ShouldCollapseForDoubleClick (NSSplitView splitView, NSView subview, nint doubleClickAtDividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			var subview__handle__ = subview!.GetNonNullHandle (nameof (subview));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_XHandle, splitView__handle__, subview__handle__, doubleClickAtDividerIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selSplitView_ShouldCollapseSubview_ForDoubleClickOnDividerAtIndex_XHandle, splitView__handle__, subview__handle__, doubleClickAtDividerIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			GC.KeepAlive (subview);
			return ret != 0;
		}
		[Export ("splitView:shouldHideDividerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual bool ShouldHideDivider (NSSplitView splitView, nint dividerIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var splitView__handle__ = splitView!.GetNonNullHandle (nameof (splitView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSplitView_ShouldHideDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSplitView_ShouldHideDividerAtIndex_XHandle, splitView__handle__, dividerIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (splitView);
			return ret != 0;
		}
		/// <param name="notification">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("splitViewWillResizeSubviews:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SplitViewWillResizeSubviews (NSNotification notification)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSplitViewWillResizeSubviews_XHandle, notification__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSplitViewWillResizeSubviews_XHandle, notification__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (notification);
		}
		[Export ("toggleInspector:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleInspector (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleInspector_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleInspector_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleSidebar:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleSidebar (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleSidebar_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleSidebar_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateUserInterfaceItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (INSValidatedUserInterfaceItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateUserInterfaceItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateUserInterfaceItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MinimumThicknessForInlineSidebars {
			[Export ("minimumThicknessForInlineSidebars", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMinimumThicknessForInlineSidebarsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMinimumThicknessForInlineSidebarsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumThicknessForInlineSidebars:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMinimumThicknessForInlineSidebars_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMinimumThicknessForInlineSidebars_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSplitView SplitView {
			[Export ("splitView", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSplitView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSplitView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSplitViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSplitView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSplitViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSplitView:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSplitView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSplitView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSplitViewItem[] SplitViewItems {
			[Export ("splitViewItems", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSplitViewItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSSplitViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSplitViewItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSSplitViewItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSplitViewItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSplitViewItems:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSplitViewItems_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSplitViewItems_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSSplitViewControllerAutomaticDimension",  "AppKit")]
		public static nfloat AutomaticDimension {
			get {
				return Dlfcn.GetNFloat (Libraries.AppKit.Handle, "NSSplitViewControllerAutomaticDimension");
			}
		}
	} /* class NSSplitViewController */
}
