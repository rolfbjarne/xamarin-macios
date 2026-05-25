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
	[Register("NSStackView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSStackView : NSView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddArrangedSubview_X = "addArrangedSubview:";
		static readonly NativeHandle selAddArrangedSubview_XHandle = Selector.GetHandle ("addArrangedSubview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddView_InGravity_X = "addView:inGravity:";
		static readonly NativeHandle selAddView_InGravity_XHandle = Selector.GetHandle ("addView:inGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentX = "alignment";
		static readonly NativeHandle selAlignmentXHandle = Selector.GetHandle ("alignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArrangedSubviewsX = "arrangedSubviews";
		static readonly NativeHandle selArrangedSubviewsXHandle = Selector.GetHandle ("arrangedSubviews");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClippingResistancePriorityForOrientation_X = "clippingResistancePriorityForOrientation:";
		static readonly NativeHandle selClippingResistancePriorityForOrientation_XHandle = Selector.GetHandle ("clippingResistancePriorityForOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomSpacingAfterView_X = "customSpacingAfterView:";
		static readonly NativeHandle selCustomSpacingAfterView_XHandle = Selector.GetHandle ("customSpacingAfterView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetachedViewsX = "detachedViews";
		static readonly NativeHandle selDetachedViewsXHandle = Selector.GetHandle ("detachedViews");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDetachesHiddenViewsX = "detachesHiddenViews";
		static readonly NativeHandle selDetachesHiddenViewsXHandle = Selector.GetHandle ("detachesHiddenViews");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDistributionX = "distribution";
		static readonly NativeHandle selDistributionXHandle = Selector.GetHandle ("distribution");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEdgeInsetsX = "edgeInsets";
		static readonly NativeHandle selEdgeInsetsXHandle = Selector.GetHandle ("edgeInsets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasEqualSpacingX = "hasEqualSpacing";
		static readonly NativeHandle selHasEqualSpacingXHandle = Selector.GetHandle ("hasEqualSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHuggingPriorityForOrientation_X = "huggingPriorityForOrientation:";
		static readonly NativeHandle selHuggingPriorityForOrientation_XHandle = Selector.GetHandle ("huggingPriorityForOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertArrangedSubview_AtIndex_X = "insertArrangedSubview:atIndex:";
		static readonly NativeHandle selInsertArrangedSubview_AtIndex_XHandle = Selector.GetHandle ("insertArrangedSubview:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertView_AtIndex_InGravity_X = "insertView:atIndex:inGravity:";
		static readonly NativeHandle selInsertView_AtIndex_InGravity_XHandle = Selector.GetHandle ("insertView:atIndex:inGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrientationX = "orientation";
		static readonly NativeHandle selOrientationXHandle = Selector.GetHandle ("orientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveArrangedSubview_X = "removeArrangedSubview:";
		static readonly NativeHandle selRemoveArrangedSubview_XHandle = Selector.GetHandle ("removeArrangedSubview:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveView_X = "removeView:";
		static readonly NativeHandle selRemoveView_XHandle = Selector.GetHandle ("removeView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlignment_X = "setAlignment:";
		static readonly NativeHandle selSetAlignment_XHandle = Selector.GetHandle ("setAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClippingResistancePriority_ForOrientation_X = "setClippingResistancePriority:forOrientation:";
		static readonly NativeHandle selSetClippingResistancePriority_ForOrientation_XHandle = Selector.GetHandle ("setClippingResistancePriority:forOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCustomSpacing_AfterView_X = "setCustomSpacing:afterView:";
		static readonly NativeHandle selSetCustomSpacing_AfterView_XHandle = Selector.GetHandle ("setCustomSpacing:afterView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDetachesHiddenViews_X = "setDetachesHiddenViews:";
		static readonly NativeHandle selSetDetachesHiddenViews_XHandle = Selector.GetHandle ("setDetachesHiddenViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDistribution_X = "setDistribution:";
		static readonly NativeHandle selSetDistribution_XHandle = Selector.GetHandle ("setDistribution:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEdgeInsets_X = "setEdgeInsets:";
		static readonly NativeHandle selSetEdgeInsets_XHandle = Selector.GetHandle ("setEdgeInsets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasEqualSpacing_X = "setHasEqualSpacing:";
		static readonly NativeHandle selSetHasEqualSpacing_XHandle = Selector.GetHandle ("setHasEqualSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHuggingPriority_ForOrientation_X = "setHuggingPriority:forOrientation:";
		static readonly NativeHandle selSetHuggingPriority_ForOrientation_XHandle = Selector.GetHandle ("setHuggingPriority:forOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOrientation_X = "setOrientation:";
		static readonly NativeHandle selSetOrientation_XHandle = Selector.GetHandle ("setOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpacing_X = "setSpacing:";
		static readonly NativeHandle selSetSpacing_XHandle = Selector.GetHandle ("setSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetViews_InGravity_X = "setViews:inGravity:";
		static readonly NativeHandle selSetViews_InGravity_XHandle = Selector.GetHandle ("setViews:inGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVisibilityPriority_ForView_X = "setVisibilityPriority:forView:";
		static readonly NativeHandle selSetVisibilityPriority_ForView_XHandle = Selector.GetHandle ("setVisibilityPriority:forView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpacingX = "spacing";
		static readonly NativeHandle selSpacingXHandle = Selector.GetHandle ("spacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStackViewWithViews_X = "stackViewWithViews:";
		static readonly NativeHandle selStackViewWithViews_XHandle = Selector.GetHandle ("stackViewWithViews:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewsX = "views";
		static readonly NativeHandle selViewsXHandle = Selector.GetHandle ("views");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewsInGravity_X = "viewsInGravity:";
		static readonly NativeHandle selViewsInGravity_XHandle = Selector.GetHandle ("viewsInGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibilityPriorityForView_X = "visibilityPriorityForView:";
		static readonly NativeHandle selVisibilityPriorityForView_XHandle = Selector.GetHandle ("visibilityPriorityForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSStackView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSStackView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSStackView () : base (NSObjectFlag.Empty)
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
		public NSStackView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSStackView (NSObjectFlag t) : base (t)
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
		protected internal NSStackView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSStackView (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addArrangedSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddArrangedSubview (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddArrangedSubview_XHandle, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddArrangedSubview_XHandle, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("addView:inGravity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddView (NSView aView, NSStackViewGravity gravity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selAddView_InGravity_XHandle, aView__handle__, (IntPtr) (long) gravity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selAddView_InGravity_XHandle, aView__handle__, (IntPtr) (long) gravity);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
		}
		[Export ("clippingResistancePriorityForOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ClippingResistancePriorityForOrientation (NSLayoutConstraintOrientation orientation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_IntPtr (this.Handle, selClippingResistancePriorityForOrientation_XHandle, (IntPtr) (long) orientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_IntPtr (&__objc_super__, selClippingResistancePriorityForOrientation_XHandle, (IntPtr) (long) orientation);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("customSpacingAfterView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CustomSpacingAfterView (NSView aView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (this.Handle, selCustomSpacingAfterView_XHandle, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle (&__objc_super__, selCustomSpacingAfterView_XHandle, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
			return ret!;
		}
		[Export ("stackViewWithViews:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSStackView FromViews (NSView[] views)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			NSStackView ret;
			ret =  Runtime.GetNSObject<NSStackView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selStackViewWithViews_XHandle, nsa_views.Handle), false)!;
			return ret;
		}
		[Export ("huggingPriorityForOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float HuggingPriority (NSLayoutConstraintOrientation orientation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_IntPtr (this.Handle, selHuggingPriorityForOrientation_XHandle, (IntPtr) (long) orientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_IntPtr (&__objc_super__, selHuggingPriorityForOrientation_XHandle, (IntPtr) (long) orientation);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertArrangedSubview:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertArrangedSubview (NSView view, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertArrangedSubview_AtIndex_XHandle, view__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertArrangedSubview_AtIndex_XHandle, view__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("insertView:atIndex:inGravity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertView (NSView aView, nuint index, NSStackViewGravity gravity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selInsertView_AtIndex_InGravity_XHandle, aView__handle__, index, (IntPtr) (long) gravity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selInsertView_AtIndex_InGravity_XHandle, aView__handle__, index, (IntPtr) (long) gravity);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
		}
		[Export ("removeArrangedSubview:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveArrangedSubview (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveArrangedSubview_XHandle, view__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveArrangedSubview_XHandle, view__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("removeView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveView (NSView aView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveView_XHandle, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveView_XHandle, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
		}
		[Export ("setClippingResistancePriority:forOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetClippingResistancePriority (float clippingResistancePriority, NSLayoutConstraintOrientation orientation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_IntPtr (this.Handle, selSetClippingResistancePriority_ForOrientation_XHandle, clippingResistancePriority, (IntPtr) (long) orientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_IntPtr (&__objc_super__, selSetClippingResistancePriority_ForOrientation_XHandle, clippingResistancePriority, (IntPtr) (long) orientation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setCustomSpacing:afterView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCustomSpacing (nfloat spacing, NSView aView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (this.Handle, selSetCustomSpacing_AfterView_XHandle, spacing, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_NativeHandle (&__objc_super__, selSetCustomSpacing_AfterView_XHandle, spacing, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
		}
		[Export ("setHuggingPriority:forOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHuggingPriority (float huggingPriority, NSLayoutConstraintOrientation orientation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_IntPtr (this.Handle, selSetHuggingPriority_ForOrientation_XHandle, huggingPriority, (IntPtr) (long) orientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_IntPtr (&__objc_super__, selSetHuggingPriority_ForOrientation_XHandle, huggingPriority, (IntPtr) (long) orientation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setViews:inGravity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetViews (NSView[] views, NSStackViewGravity gravity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (views is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (views));
			using var nsa_views = NSArray.FromNSObjects (views);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetViews_InGravity_XHandle, nsa_views.Handle, (IntPtr) (long) gravity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetViews_InGravity_XHandle, nsa_views.Handle, (IntPtr) (long) gravity);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setVisibilityPriority:forView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibilityPriority (float priority, NSView aView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_NativeHandle (this.Handle, selSetVisibilityPriority_ForView_XHandle, priority, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_NativeHandle (&__objc_super__, selSetVisibilityPriority_ForView_XHandle, priority, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
		}
		[Export ("viewsInGravity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView[] ViewsInGravity (NSStackViewGravity gravity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSView[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selViewsInGravity_XHandle, (IntPtr) (long) gravity), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selViewsInGravity_XHandle, (IntPtr) (long) gravity), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("visibilityPriorityForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float VisibilityPriority (NSView aView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aView__handle__ = aView!.GetNonNullHandle (nameof (aView));
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, selVisibilityPriorityForView_XHandle, aView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, selVisibilityPriorityForView_XHandle, aView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aView);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutAttribute Alignment {
			[Export ("alignment")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSLayoutAttribute ret;
				if (IsDirectBinding) {
					ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlignmentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLayoutAttribute) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAlignmentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlignment:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAlignment_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAlignment_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView[] ArrangedSubviews {
			[Export ("arrangedSubviews", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selArrangedSubviewsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selArrangedSubviewsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSStackViewDelegate Delegate {
			get {
				return (WeakDelegate as INSStackViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView[] DetachedViews {
			[Export ("detachedViews", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDetachedViewsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDetachedViewsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DetachesHiddenViews {
			[Export ("detachesHiddenViews")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDetachesHiddenViewsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDetachesHiddenViewsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDetachesHiddenViews:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDetachesHiddenViews_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDetachesHiddenViews_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSStackViewDistribution Distribution {
			[Export ("distribution", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSStackViewDistribution ret;
				if (IsDirectBinding) {
					ret = (NSStackViewDistribution) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDistributionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSStackViewDistribution) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDistributionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDistribution:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDistribution_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDistribution_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEdgeInsets EdgeInsets {
			[Export ("edgeInsets")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEdgeInsets ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend (this.Handle, selEdgeInsetsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSend_stret (this.Handle, selEdgeInsetsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper (&__objc_super__, selEdgeInsetsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.NSEdgeInsets_objc_msgSendSuper_stret (&__objc_super__, selEdgeInsetsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setEdgeInsets:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSEdgeInsets (this.Handle, selSetEdgeInsets_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSEdgeInsets (&__objc_super__, selSetEdgeInsets_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.11", "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool HasEqualSpacing {
			[Export ("hasEqualSpacing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasEqualSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasEqualSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasEqualSpacing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasEqualSpacing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasEqualSpacing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserInterfaceLayoutOrientation Orientation {
			[Export ("orientation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserInterfaceLayoutOrientation ret;
				if (IsDirectBinding) {
					ret = (NSUserInterfaceLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUserInterfaceLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOrientation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOrientation_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetOrientation_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Spacing {
			[Export ("spacing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selSpacingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selSpacingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpacing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetSpacing_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetSpacing_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView[] Views {
			[Export ("views", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSView>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
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
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSStackView */
}
