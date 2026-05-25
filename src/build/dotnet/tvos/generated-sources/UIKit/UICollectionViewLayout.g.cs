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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[Register("UICollectionViewLayout", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UICollectionViewLayout : NSObject, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UICollectionViewLayout");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UICollectionViewLayout" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UICollectionViewLayout () : base (NSObjectFlag.Empty)
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
		public UICollectionViewLayout (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UICollectionViewLayout (NSObjectFlag t) : base (t)
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
		protected internal UICollectionViewLayout (NativeHandle handle) : base (handle)
		{
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
		public virtual void EncodeTo (NSCoder encoder)
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
		[Export ("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingDecorationElement (NSString elementKind, NSIndexPath decorationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var decorationIndexPath__handle__ = decorationIndexPath!.GetNonNullHandle (nameof (decorationIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:"), elementKind__handle__, decorationIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:"), elementKind__handle__, decorationIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (decorationIndexPath);
			return ret!;
		}
		[Export ("finalLayoutAttributesForDisappearingItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingItem (NSIndexPath itemIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finalLayoutAttributesForDisappearingItemAtIndexPath:"), itemIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("finalLayoutAttributesForDisappearingItemAtIndexPath:"), itemIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		[Export ("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingSupplementaryElement (NSString elementKind, NSIndexPath elementIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var elementIndexPath__handle__ = elementIndexPath!.GetNonNullHandle (nameof (elementIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:"), elementKind__handle__, elementIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:"), elementKind__handle__, elementIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (elementIndexPath);
			return ret!;
		}
		[Export ("finalizeAnimatedBoundsChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeAnimatedBoundsChange ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finalizeAnimatedBoundsChange"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("finalizeAnimatedBoundsChange"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finalizeCollectionViewUpdates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeCollectionViewUpdates ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finalizeCollectionViewUpdates"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("finalizeCollectionViewUpdates"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("finalizeLayoutTransition")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinalizeLayoutTransition ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finalizeLayoutTransition"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("finalizeLayoutTransition"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("indexPathsToDeleteForDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath[] GetIndexPathsToDeleteForDecorationViewOfKind (NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			NSIndexPath[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathsToDeleteForDecorationViewOfKind:"), kind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathsToDeleteForDecorationViewOfKind:"), kind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			return ret!;
		}
		[Export ("indexPathsToDeleteForSupplementaryViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath[] GetIndexPathsToDeleteForSupplementaryView (NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			NSIndexPath[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathsToDeleteForSupplementaryViewOfKind:"), kind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathsToDeleteForSupplementaryViewOfKind:"), kind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			return ret!;
		}
		[Export ("indexPathsToInsertForDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath[] GetIndexPathsToInsertForDecorationView (NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			NSIndexPath[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathsToInsertForDecorationViewOfKind:"), kind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathsToInsertForDecorationViewOfKind:"), kind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			return ret!;
		}
		[Export ("indexPathsToInsertForSupplementaryViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath[] GetIndexPathsToInsertForSupplementaryView (NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			NSIndexPath[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("indexPathsToInsertForSupplementaryViewOfKind:"), kind__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSIndexPath>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("indexPathsToInsertForSupplementaryViewOfKind:"), kind__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			return ret!;
		}
		[Export ("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutInvalidationContext GetInvalidationContext (UICollectionViewLayoutAttributes preferredAttributes, UICollectionViewLayoutAttributes originalAttributes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var preferredAttributes__handle__ = preferredAttributes!.GetNonNullHandle (nameof (preferredAttributes));
			var originalAttributes__handle__ = originalAttributes!.GetNonNullHandle (nameof (originalAttributes));
			UICollectionViewLayoutInvalidationContext? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:"), preferredAttributes__handle__, originalAttributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:"), preferredAttributes__handle__, originalAttributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preferredAttributes);
			GC.KeepAlive (originalAttributes);
			return ret!;
		}
		[Export ("invalidationContextForBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutInvalidationContext GetInvalidationContextForBoundsChange (CGRect newBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UICollectionViewLayoutInvalidationContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("invalidationContextForBoundsChange:"), newBounds), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("invalidationContextForBoundsChange:"), newBounds), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("invalidationContextForEndingInteractiveMovementOfItemsToFinalIndexPaths:previousIndexPaths:movementCancelled:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutInvalidationContext GetInvalidationContextForEndingInteractiveMovementOfItems (NSIndexPath[] finalIndexPaths, NSIndexPath[] previousIndexPaths, bool movementCancelled)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (finalIndexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (finalIndexPaths));
			if (previousIndexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previousIndexPaths));
			using var nsa_finalIndexPaths = NSArray.FromNSObjects (finalIndexPaths);
			using var nsa_previousIndexPaths = NSArray.FromNSObjects (previousIndexPaths);
			UICollectionViewLayoutInvalidationContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("invalidationContextForEndingInteractiveMovementOfItemsToFinalIndexPaths:previousIndexPaths:movementCancelled:"), nsa_finalIndexPaths.Handle, nsa_previousIndexPaths.Handle, movementCancelled ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("invalidationContextForEndingInteractiveMovementOfItemsToFinalIndexPaths:previousIndexPaths:movementCancelled:"), nsa_finalIndexPaths.Handle, nsa_previousIndexPaths.Handle, movementCancelled ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("invalidationContextForInteractivelyMovingItems:withTargetPosition:previousIndexPaths:previousPosition:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutInvalidationContext GetInvalidationContextForInteractivelyMovingItems (NSIndexPath[] targetIndexPaths, CGPoint targetPosition, NSIndexPath[] previousIndexPaths, CGPoint previousPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (targetIndexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetIndexPaths));
			if (previousIndexPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previousIndexPaths));
			using var nsa_targetIndexPaths = NSArray.FromNSObjects (targetIndexPaths);
			using var nsa_previousIndexPaths = NSArray.FromNSObjects (previousIndexPaths);
			UICollectionViewLayoutInvalidationContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("invalidationContextForInteractivelyMovingItems:withTargetPosition:previousIndexPaths:previousPosition:"), nsa_targetIndexPaths.Handle, targetPosition, nsa_previousIndexPaths.Handle, previousPosition), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutInvalidationContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("invalidationContextForInteractivelyMovingItems:withTargetPosition:previousIndexPaths:previousPosition:"), nsa_targetIndexPaths.Handle, targetPosition, nsa_previousIndexPaths.Handle, previousPosition), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutAttributesForInteractivelyMovingItemAtIndexPath:withTargetPosition:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes GetLayoutAttributesForInteractivelyMovingItem (NSIndexPath indexPath, CGPoint targetPosition)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("layoutAttributesForInteractivelyMovingItemAtIndexPath:withTargetPosition:"), indexPath__handle__, targetPosition), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("layoutAttributesForInteractivelyMovingItemAtIndexPath:withTargetPosition:"), indexPath__handle__, targetPosition), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("targetIndexPathForInteractivelyMovingItem:withPosition:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetTargetIndexPathForInteractivelyMovingItem (NSIndexPath previousIndexPath, CGPoint position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var previousIndexPath__handle__ = previousIndexPath!.GetNonNullHandle (nameof (previousIndexPath));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint (this.Handle, Selector.GetHandle ("targetIndexPathForInteractivelyMovingItem:withPosition:"), previousIndexPath__handle__, position), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, Selector.GetHandle ("targetIndexPathForInteractivelyMovingItem:withPosition:"), previousIndexPath__handle__, position), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (previousIndexPath);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingDecorationElement (NSString elementKind, NSIndexPath decorationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var decorationIndexPath__handle__ = decorationIndexPath!.GetNonNullHandle (nameof (decorationIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:"), elementKind__handle__, decorationIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:"), elementKind__handle__, decorationIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (decorationIndexPath);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingItem (NSIndexPath itemIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemIndexPath__handle__ = itemIndexPath!.GetNonNullHandle (nameof (itemIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initialLayoutAttributesForAppearingItemAtIndexPath:"), itemIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initialLayoutAttributesForAppearingItemAtIndexPath:"), itemIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIndexPath);
			return ret!;
		}
		[Export ("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingSupplementaryElement (NSString elementKind, NSIndexPath elementIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var elementKind__handle__ = elementKind!.GetNonNullHandle (nameof (elementKind));
			var elementIndexPath__handle__ = elementIndexPath!.GetNonNullHandle (nameof (elementIndexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:"), elementKind__handle__, elementIndexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:"), elementKind__handle__, elementIndexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (elementKind);
			GC.KeepAlive (elementIndexPath);
			return ret!;
		}
		[Export ("invalidateLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateLayout"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("invalidateLayout"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidateLayoutWithContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout (UICollectionViewLayoutInvalidationContext context)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("invalidateLayoutWithContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("invalidateLayoutWithContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("invalidationContextClass")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class InvalidationContextClass ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			Class ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("invalidationContextClass")), false)!;
			return ret;
		}
		[Export ("layoutAttributesForDecorationViewOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes LayoutAttributesForDecorationView (NSString kind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("layoutAttributesForDecorationViewOfKind:atIndexPath:"), kind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("layoutAttributesForDecorationViewOfKind:atIndexPath:"), kind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForElementsInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect (CGRect rect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UICollectionViewLayoutAttributes[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UICollectionViewLayoutAttributes>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("layoutAttributesForElementsInRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UICollectionViewLayoutAttributes>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("layoutAttributesForElementsInRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutAttributesForItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes LayoutAttributesForItem (NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("layoutAttributesForItemAtIndexPath:"), indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("layoutAttributesForItemAtIndexPath:"), indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionViewLayoutAttributes LayoutAttributesForSupplementaryView (NSString kind, NSIndexPath indexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			UICollectionViewLayoutAttributes? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:"), kind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UICollectionViewLayoutAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("layoutAttributesForSupplementaryViewOfKind:atIndexPath:"), kind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("prepareForAnimatedBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForAnimatedBoundsChange (CGRect oldBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("prepareForAnimatedBoundsChange:"), oldBounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("prepareForAnimatedBoundsChange:"), oldBounds);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareForCollectionViewUpdates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForCollectionViewUpdates (UICollectionViewUpdateItem[] updateItems)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (updateItems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (updateItems));
			using var nsa_updateItems = NSArray.FromNSObjects (updateItems);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareForCollectionViewUpdates:"), nsa_updateItems.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareForCollectionViewUpdates:"), nsa_updateItems.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareForTransitionFromLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForTransitionFromLayout (UICollectionViewLayout oldLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var oldLayout__handle__ = oldLayout!.GetNonNullHandle (nameof (oldLayout));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareForTransitionFromLayout:"), oldLayout__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareForTransitionFromLayout:"), oldLayout__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldLayout);
		}
		[Export ("prepareForTransitionToLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForTransitionToLayout (UICollectionViewLayout newLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var newLayout__handle__ = newLayout!.GetNonNullHandle (nameof (newLayout));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareForTransitionToLayout:"), newLayout__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareForTransitionToLayout:"), newLayout__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newLayout);
		}
		[Export ("prepareLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareLayout ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareLayout"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prepareLayout"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("registerClass:forDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void RegisterClassForDecorationView (nint classPtr, NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("registerClass:forDecorationViewOfKind:"), classPtr, kind__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("registerClass:forDecorationViewOfKind:"), classPtr, kind__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kind);
		}
		[Export ("registerNib:forDecorationViewOfKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterNibForDecorationView (UINib? nib, NSString kind)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nib__handle__ = nib.GetHandle ();
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerNib:forDecorationViewOfKind:"), nib__handle__, kind__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerNib:forDecorationViewOfKind:"), nib__handle__, kind__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nib);
			GC.KeepAlive (kind);
		}
		[Export ("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInvalidateLayout (UICollectionViewLayoutAttributes preferredAttributes, UICollectionViewLayoutAttributes originalAttributes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var preferredAttributes__handle__ = preferredAttributes!.GetNonNullHandle (nameof (preferredAttributes));
			var originalAttributes__handle__ = originalAttributes!.GetNonNullHandle (nameof (originalAttributes));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:"), preferredAttributes__handle__, originalAttributes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:"), preferredAttributes__handle__, originalAttributes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (preferredAttributes);
			GC.KeepAlive (originalAttributes);
			return ret != 0;
		}
		[Export ("shouldInvalidateLayoutForBoundsChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldInvalidateLayoutForBoundsChange (CGRect newBounds)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("shouldInvalidateLayoutForBoundsChange:"), newBounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("shouldInvalidateLayoutForBoundsChange:"), newBounds);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint TargetContentOffset (CGPoint proposedContentOffset, CGPoint scrollingVelocity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_CGPoint (this.Handle, Selector.GetHandle ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:"), proposedContentOffset, scrollingVelocity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, Selector.GetHandle ("targetContentOffsetForProposedContentOffset:withScrollingVelocity:"), proposedContentOffset, scrollingVelocity);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("targetContentOffsetForProposedContentOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint TargetContentOffsetForProposedContentOffset (CGPoint proposedContentOffset)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("targetContentOffsetForProposedContentOffset:"), proposedContentOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("targetContentOffsetForProposedContentOffset:"), proposedContentOffset);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICollectionView CollectionView {
			[Export ("collectionView")]
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CollectionViewContentSize {
			[Export ("collectionViewContentSize")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("collectionViewContentSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("collectionViewContentSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIUserInterfaceLayoutDirection DevelopmentLayoutDirection {
			[Export ("developmentLayoutDirection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("developmentLayoutDirection"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("developmentLayoutDirection"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool FlipsHorizontallyInOppositeLayoutDirection {
			[Export ("flipsHorizontallyInOppositeLayoutDirection")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("flipsHorizontallyInOppositeLayoutDirection"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("flipsHorizontallyInOppositeLayoutDirection"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class LayoutAttributesClass {
			[Export ("layoutAttributesClass")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				Class ret;
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("layoutAttributesClass")), false)!;
				return ret;
			}
		}
		/// <summary>Represents the value associated with the constant 'UICollectionViewLayoutAutomaticDimension'.</summary>
		[Field ("UICollectionViewLayoutAutomaticDimension",  "UIKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static nfloat AutomaticDimension {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				return Dlfcn.GetNFloat (Libraries.UIKit.Handle, "UICollectionViewLayoutAutomaticDimension");
			}
		}
	} /* class UICollectionViewLayout */
}
