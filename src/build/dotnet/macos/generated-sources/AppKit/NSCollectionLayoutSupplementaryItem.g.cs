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
	[Register("NSCollectionLayoutSupplementaryItem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSCollectionLayoutSupplementaryItem : NSCollectionLayoutItem, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerAnchorX = "containerAnchor";
		static readonly NativeHandle selContainerAnchorXHandle = Selector.GetHandle ("containerAnchor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementKindX = "elementKind";
		static readonly NativeHandle selElementKindXHandle = Selector.GetHandle ("elementKind");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAnchorX = "itemAnchor";
		static readonly NativeHandle selItemAnchorXHandle = Selector.GetHandle ("itemAnchor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZIndex_X = "setZIndex:";
		static readonly NativeHandle selSetZIndex_XHandle = Selector.GetHandle ("setZIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_X = "supplementaryItemWithLayoutSize:elementKind:containerAnchor:";
		static readonly NativeHandle selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_XHandle = Selector.GetHandle ("supplementaryItemWithLayoutSize:elementKind:containerAnchor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_X = "supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:";
		static readonly NativeHandle selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_XHandle = Selector.GetHandle ("supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZIndexX = "zIndex";
		static readonly NativeHandle selZIndexXHandle = Selector.GetHandle ("zIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCollectionLayoutSupplementaryItem");
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
		protected NSCollectionLayoutSupplementaryItem (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionLayoutSupplementaryItem (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("supplementaryItemWithLayoutSize:elementKind:containerAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutSupplementaryItem Create (NSCollectionLayoutSize layoutSize, string elementKind, NSCollectionLayoutAnchor containerAnchor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var containerAnchor__handle__ = containerAnchor!.GetNonNullHandle (nameof (containerAnchor));
			var nselementKind = CFString.CreateNative (elementKind);
			NSCollectionLayoutSupplementaryItem? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutSupplementaryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_XHandle, layoutSize__handle__, nselementKind, containerAnchor__handle__), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (containerAnchor);
			CFString.ReleaseNative (nselementKind);
			return ret!;
		}
		[Export ("supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutSupplementaryItem Create (NSCollectionLayoutSize layoutSize, string elementKind, NSCollectionLayoutAnchor containerAnchor, NSCollectionLayoutAnchor itemAnchor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			if (elementKind is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementKind));
			var containerAnchor__handle__ = containerAnchor!.GetNonNullHandle (nameof (containerAnchor));
			var itemAnchor__handle__ = itemAnchor!.GetNonNullHandle (nameof (itemAnchor));
			var nselementKind = CFString.CreateNative (elementKind);
			NSCollectionLayoutSupplementaryItem? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutSupplementaryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_XHandle, layoutSize__handle__, nselementKind, containerAnchor__handle__, itemAnchor__handle__), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (containerAnchor);
			GC.KeepAlive (itemAnchor);
			CFString.ReleaseNative (nselementKind);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionLayoutAnchor ContainerAnchor {
			[Export ("containerAnchor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionLayoutAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionLayoutAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContainerAnchorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionLayoutAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContainerAnchorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ElementKind {
			[Export ("elementKind")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selElementKindXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selElementKindXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionLayoutAnchor? ItemAnchor {
			[Export ("itemAnchor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionLayoutAnchor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionLayoutAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemAnchorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionLayoutAnchor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemAnchorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ZIndex {
			[Export ("zIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selZIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selZIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZIndex:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetZIndex_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetZIndex_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSCollectionLayoutSupplementaryItem */
}
