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
	[Register("NSCollectionViewLayout", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionViewLayout : NSObject, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionViewX = "collectionView";
		static readonly NativeHandle selCollectionViewXHandle = Selector.GetHandle ("collectionView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionViewContentSizeX = "collectionViewContentSize";
		static readonly NativeHandle selCollectionViewContentSizeXHandle = Selector.GetHandle ("collectionViewContentSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_X = "finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:";
		static readonly NativeHandle selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalLayoutAttributesForDisappearingItemAtIndexPath_X = "finalLayoutAttributesForDisappearingItemAtIndexPath:";
		static readonly NativeHandle selFinalLayoutAttributesForDisappearingItemAtIndexPath_XHandle = Selector.GetHandle ("finalLayoutAttributesForDisappearingItemAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_X = "finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:";
		static readonly NativeHandle selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalizeAnimatedBoundsChangeX = "finalizeAnimatedBoundsChange";
		static readonly NativeHandle selFinalizeAnimatedBoundsChangeXHandle = Selector.GetHandle ("finalizeAnimatedBoundsChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalizeCollectionViewUpdatesX = "finalizeCollectionViewUpdates";
		static readonly NativeHandle selFinalizeCollectionViewUpdatesXHandle = Selector.GetHandle ("finalizeCollectionViewUpdates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinalizeLayoutTransitionX = "finalizeLayoutTransition";
		static readonly NativeHandle selFinalizeLayoutTransitionXHandle = Selector.GetHandle ("finalizeLayoutTransition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsToDeleteForDecorationViewOfKind_X = "indexPathsToDeleteForDecorationViewOfKind:";
		static readonly NativeHandle selIndexPathsToDeleteForDecorationViewOfKind_XHandle = Selector.GetHandle ("indexPathsToDeleteForDecorationViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsToDeleteForSupplementaryViewOfKind_X = "indexPathsToDeleteForSupplementaryViewOfKind:";
		static readonly NativeHandle selIndexPathsToDeleteForSupplementaryViewOfKind_XHandle = Selector.GetHandle ("indexPathsToDeleteForSupplementaryViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsToInsertForDecorationViewOfKind_X = "indexPathsToInsertForDecorationViewOfKind:";
		static readonly NativeHandle selIndexPathsToInsertForDecorationViewOfKind_XHandle = Selector.GetHandle ("indexPathsToInsertForDecorationViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathsToInsertForSupplementaryViewOfKind_X = "indexPathsToInsertForSupplementaryViewOfKind:";
		static readonly NativeHandle selIndexPathsToInsertForSupplementaryViewOfKind_XHandle = Selector.GetHandle ("indexPathsToInsertForSupplementaryViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_X = "initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:";
		static readonly NativeHandle selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitialLayoutAttributesForAppearingItemAtIndexPath_X = "initialLayoutAttributesForAppearingItemAtIndexPath:";
		static readonly NativeHandle selInitialLayoutAttributesForAppearingItemAtIndexPath_XHandle = Selector.GetHandle ("initialLayoutAttributesForAppearingItemAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_X = "initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:";
		static readonly NativeHandle selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateLayoutX = "invalidateLayout";
		static readonly NativeHandle selInvalidateLayoutXHandle = Selector.GetHandle ("invalidateLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateLayoutWithContext_X = "invalidateLayoutWithContext:";
		static readonly NativeHandle selInvalidateLayoutWithContext_XHandle = Selector.GetHandle ("invalidateLayoutWithContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidationContextClassX = "invalidationContextClass";
		static readonly NativeHandle selInvalidationContextClassXHandle = Selector.GetHandle ("invalidationContextClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidationContextForBoundsChange_X = "invalidationContextForBoundsChange:";
		static readonly NativeHandle selInvalidationContextForBoundsChange_XHandle = Selector.GetHandle ("invalidationContextForBoundsChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_X = "invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:";
		static readonly NativeHandle selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_XHandle = Selector.GetHandle ("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesClassX = "layoutAttributesClass";
		static readonly NativeHandle selLayoutAttributesClassXHandle = Selector.GetHandle ("layoutAttributesClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForDecorationViewOfKind_AtIndexPath_X = "layoutAttributesForDecorationViewOfKind:atIndexPath:";
		static readonly NativeHandle selLayoutAttributesForDecorationViewOfKind_AtIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForDecorationViewOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForDropTargetAtPoint_X = "layoutAttributesForDropTargetAtPoint:";
		static readonly NativeHandle selLayoutAttributesForDropTargetAtPoint_XHandle = Selector.GetHandle ("layoutAttributesForDropTargetAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForElementsInRect_X = "layoutAttributesForElementsInRect:";
		static readonly NativeHandle selLayoutAttributesForElementsInRect_XHandle = Selector.GetHandle ("layoutAttributesForElementsInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForInterItemGapBeforeIndexPath_X = "layoutAttributesForInterItemGapBeforeIndexPath:";
		static readonly NativeHandle selLayoutAttributesForInterItemGapBeforeIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForInterItemGapBeforeIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForItemAtIndexPath_X = "layoutAttributesForItemAtIndexPath:";
		static readonly NativeHandle selLayoutAttributesForItemAtIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForItemAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_X = "layoutAttributesForSupplementaryViewOfKind:atIndexPath:";
		static readonly NativeHandle selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_XHandle = Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForAnimatedBoundsChange_X = "prepareForAnimatedBoundsChange:";
		static readonly NativeHandle selPrepareForAnimatedBoundsChange_XHandle = Selector.GetHandle ("prepareForAnimatedBoundsChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForCollectionViewUpdates_X = "prepareForCollectionViewUpdates:";
		static readonly NativeHandle selPrepareForCollectionViewUpdates_XHandle = Selector.GetHandle ("prepareForCollectionViewUpdates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForTransitionFromLayout_X = "prepareForTransitionFromLayout:";
		static readonly NativeHandle selPrepareForTransitionFromLayout_XHandle = Selector.GetHandle ("prepareForTransitionFromLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForTransitionToLayout_X = "prepareForTransitionToLayout:";
		static readonly NativeHandle selPrepareForTransitionToLayout_XHandle = Selector.GetHandle ("prepareForTransitionToLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareLayoutX = "prepareLayout";
		static readonly NativeHandle selPrepareLayoutXHandle = Selector.GetHandle ("prepareLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterClass_ForDecorationViewOfKind_X = "registerClass:forDecorationViewOfKind:";
		static readonly NativeHandle selRegisterClass_ForDecorationViewOfKind_XHandle = Selector.GetHandle ("registerClass:forDecorationViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterNib_ForDecorationViewOfKind_X = "registerNib:forDecorationViewOfKind:";
		static readonly NativeHandle selRegisterNib_ForDecorationViewOfKind_XHandle = Selector.GetHandle ("registerNib:forDecorationViewOfKind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldInvalidateLayoutForBoundsChange_X = "shouldInvalidateLayoutForBoundsChange:";
		static readonly NativeHandle selShouldInvalidateLayoutForBoundsChange_XHandle = Selector.GetHandle ("shouldInvalidateLayoutForBoundsChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_X = "shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:";
		static readonly NativeHandle selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_XHandle = Selector.GetHandle ("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetContentOffsetForProposedContentOffset_X = "targetContentOffsetForProposedContentOffset:";
		static readonly NativeHandle selTargetContentOffsetForProposedContentOffset_XHandle = Selector.GetHandle ("targetContentOffsetForProposedContentOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_X = "targetContentOffsetForProposedContentOffset:withScrollingVelocity:";
		static readonly NativeHandle selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_XHandle = Selector.GetHandle ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCollectionViewLayout");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSCollectionViewLayout" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCollectionViewLayout () : base (NSObjectFlag.Empty)
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
		public NSCollectionViewLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSCollectionViewLayout (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewLayout (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("finalizeAnimatedBoundsChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeAnimatedBoundsChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinalizeAnimatedBoundsChangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinalizeAnimatedBoundsChangeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finalizeCollectionViewUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeCollectionViewUpdates ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinalizeCollectionViewUpdatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinalizeCollectionViewUpdatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finalizeLayoutTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeLayoutTransition ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinalizeLayoutTransitionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinalizeLayoutTransitionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingDecorationElement (NSString elementKind, NSIndexPath decorationIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var decorationIndexPath__handle__ = decorationIndexPath!.GetNonNullHandle (nameof (decorationIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_XHandle, elementKind__handle__, decorationIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_XHandle, elementKind__handle__, decorationIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (decorationIndexPath);
			return ret!;
		}
		[Export ("finalLayoutAttributesForDisappearingItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingItem (NSIndexPath itemIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFinalLayoutAttributesForDisappearingItemAtIndexPath_XHandle, itemIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinalLayoutAttributesForDisappearingItemAtIndexPath_XHandle, itemIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		[Export ("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingSupplementaryElement (NSString elementKind, NSIndexPath elementIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var elementIndexPath__handle__ = elementIndexPath!.GetNonNullHandle (nameof (elementIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_XHandle, elementKind__handle__, elementIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_XHandle, elementKind__handle__, elementIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (elementIndexPath);
			return ret!;
		}
		[Export ("indexPathsToDeleteForDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetIndexPathsToDeleteForDecorationView (NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathsToDeleteForDecorationViewOfKind_XHandle, elementKind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathsToDeleteForDecorationViewOfKind_XHandle, elementKind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			return ret!;
		}
		[Export ("indexPathsToDeleteForSupplementaryViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetIndexPathsToDeleteForSupplementaryView (NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathsToDeleteForSupplementaryViewOfKind_XHandle, elementKind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathsToDeleteForSupplementaryViewOfKind_XHandle, elementKind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			return ret!;
		}
		[Export ("indexPathsToInsertForDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetIndexPathsToInsertForDecorationView (NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathsToInsertForDecorationViewOfKind_XHandle, elementKind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathsToInsertForDecorationViewOfKind_XHandle, elementKind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			return ret!;
		}
		[Export ("indexPathsToInsertForSupplementaryViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetIndexPathsToInsertForSupplementaryView (NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathsToInsertForSupplementaryViewOfKind_XHandle, elementKind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathsToInsertForSupplementaryViewOfKind_XHandle, elementKind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingDecorationElement (NSString elementKind, NSIndexPath decorationIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var decorationIndexPath__handle__ = decorationIndexPath!.GetNonNullHandle (nameof (decorationIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_XHandle, elementKind__handle__, decorationIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_XHandle, elementKind__handle__, decorationIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (decorationIndexPath);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingItem (NSIndexPath itemIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitialLayoutAttributesForAppearingItemAtIndexPath_XHandle, itemIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitialLayoutAttributesForAppearingItemAtIndexPath_XHandle, itemIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingSupplementaryElement (NSString elementKind, NSIndexPath elementIndexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var elementIndexPath__handle__ = elementIndexPath!.GetNonNullHandle (nameof (elementIndexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_XHandle, elementKind__handle__, elementIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_XHandle, elementKind__handle__, elementIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (elementIndexPath);
			return ret!;
		}
		[Export ("invalidationContextForBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutInvalidationContext GetInvalidationContext (CGRect newBounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCollectionViewLayoutInvalidationContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInvalidationContextForBoundsChange_XHandle, newBounds), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInvalidationContextForBoundsChange_XHandle, newBounds), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutInvalidationContext GetInvalidationContext (NSCollectionViewLayoutAttributes preferredAttributes, NSCollectionViewLayoutAttributes originalAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var preferredAttributes__handle__ = preferredAttributes!.GetNonNullHandle (nameof (preferredAttributes));
			var originalAttributes__handle__ = originalAttributes!.GetNonNullHandle (nameof (originalAttributes));
			NSCollectionViewLayoutInvalidationContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_XHandle, preferredAttributes__handle__, originalAttributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_XHandle, preferredAttributes__handle__, originalAttributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preferredAttributes);
			GC.KeepAlive (originalAttributes);
			return ret!;
		}
		[Export ("layoutAttributesForDecorationViewOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForDecorationView (NSString elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLayoutAttributesForDecorationViewOfKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLayoutAttributesForDecorationViewOfKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForDropTargetAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForDropTarget (CGPoint pointInCollectionView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCollectionViewLayoutAttributes ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selLayoutAttributesForDropTargetAtPoint_XHandle, pointInCollectionView), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selLayoutAttributesForDropTargetAtPoint_XHandle, pointInCollectionView), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutAttributesForElementsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes[] GetLayoutAttributesForElements (CGRect rect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSCollectionViewLayoutAttributes[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSCollectionViewLayoutAttributes>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selLayoutAttributesForElementsInRect_XHandle, rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSCollectionViewLayoutAttributes>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selLayoutAttributesForElementsInRect_XHandle, rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutAttributesForInterItemGapBeforeIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForInterItemGap (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLayoutAttributesForInterItemGapBeforeIndexPath_XHandle, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLayoutAttributesForInterItemGapBeforeIndexPath_XHandle, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForItem (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLayoutAttributesForItemAtIndexPath_XHandle, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLayoutAttributesForItemAtIndexPath_XHandle, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForSupplementaryView (NSString elementKind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_XHandle, elementKind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetTargetContentOffset (CGPoint proposedContentOffset, CGPoint velocity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_CGPoint (this.Handle, selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_XHandle, proposedContentOffset, velocity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_XHandle, proposedContentOffset, velocity);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("targetContentOffsetForProposedContentOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetTargetContentOffset (CGPoint proposedContentOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, selTargetContentOffsetForProposedContentOffset_XHandle, proposedContentOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint (&__objc_super__, selTargetContentOffsetForProposedContentOffset_XHandle, proposedContentOffset);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("invalidateLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateLayoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateLayoutXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidateLayoutWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout (NSCollectionViewLayoutInvalidationContext context)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInvalidateLayoutWithContext_XHandle, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInvalidateLayoutWithContext_XHandle, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("prepareForAnimatedBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForAnimatedBoundsChange (CGRect oldBounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selPrepareForAnimatedBoundsChange_XHandle, oldBounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selPrepareForAnimatedBoundsChange_XHandle, oldBounds);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareForCollectionViewUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForCollectionViewUpdates (NSCollectionViewUpdateItem[] updateItems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (updateItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updateItems));
			using var nsa_updateItems = NSArray.FromNSObjects (updateItems);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrepareForCollectionViewUpdates_XHandle, nsa_updateItems.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareForCollectionViewUpdates_XHandle, nsa_updateItems.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareForTransitionFromLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForTransitionFromLayout (NSCollectionViewLayout oldLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrepareForTransitionFromLayout_XHandle, oldLayout__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareForTransitionFromLayout_XHandle, oldLayout__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldLayout);
		}
		[Export ("prepareForTransitionToLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForTransitionToLayout (NSCollectionViewLayout newLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPrepareForTransitionToLayout_XHandle, newLayout__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPrepareForTransitionToLayout_XHandle, newLayout__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newLayout);
		}
		[Export ("prepareLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareLayout ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareLayoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPrepareLayoutXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("registerNib:forDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNib (NSNib? nib, NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nib__handle__ = nib.GetHandle ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRegisterNib_ForDecorationViewOfKind_XHandle, nib__handle__, elementKind__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRegisterNib_ForDecorationViewOfKind_XHandle, nib__handle__, elementKind__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nib);
			GC.KeepAlive (elementKind);
		}
		[Export ("shouldInvalidateLayoutForBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInvalidateLayout (CGRect newBounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect (this.Handle, selShouldInvalidateLayoutForBoundsChange_XHandle, newBounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect (&__objc_super__, selShouldInvalidateLayoutForBoundsChange_XHandle, newBounds);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInvalidateLayout (NSCollectionViewLayoutAttributes preferredAttributes, NSCollectionViewLayoutAttributes originalAttributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var preferredAttributes__handle__ = preferredAttributes!.GetNonNullHandle (nameof (preferredAttributes));
			var originalAttributes__handle__ = originalAttributes!.GetNonNullHandle (nameof (originalAttributes));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_XHandle, preferredAttributes__handle__, originalAttributes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_XHandle, preferredAttributes__handle__, originalAttributes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preferredAttributes);
			GC.KeepAlive (originalAttributes);
			return ret != 0;
		}
		[Export ("registerClass:forDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _RegisterClassForDecorationView (nint viewClass, NSString elementKind)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selRegisterClass_ForDecorationViewOfKind_XHandle, viewClass, elementKind__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selRegisterClass_ForDecorationViewOfKind_XHandle, viewClass, elementKind__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_CollectionView_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionView? CollectionView {
			[Export ("collectionView", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollectionViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollectionViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_CollectionView_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CollectionViewContentSize {
			[Export ("collectionViewContentSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selCollectionViewContentSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selCollectionViewContentSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class InvalidationContextClass {
			[Export ("invalidationContextClass")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Class ret;
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInvalidationContextClassXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class LayoutAttributesClass {
			[Export ("layoutAttributesClass")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Class ret;
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLayoutAttributesClassXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CollectionView_var = null;
			}
		}
	} /* class NSCollectionViewLayout */
}
