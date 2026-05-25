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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace StoreKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SKOverlayDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "SKOverlayDelegate", WrapperType = typeof (SKOverlayDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToLoad", Selector = "storeOverlay:didFailToLoadWithError:", ParameterType = new Type [] { typeof (StoreKit.SKOverlay), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartPresentation", Selector = "storeOverlay:willStartPresentation:", ParameterType = new Type [] { typeof (StoreKit.SKOverlay), typeof (StoreKit.SKOverlayTransitionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishPresentation", Selector = "storeOverlay:didFinishPresentation:", ParameterType = new Type [] { typeof (StoreKit.SKOverlay), typeof (StoreKit.SKOverlayTransitionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartDismissal", Selector = "storeOverlay:willStartDismissal:", ParameterType = new Type [] { typeof (StoreKit.SKOverlay), typeof (StoreKit.SKOverlayTransitionContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishDismissal", Selector = "storeOverlay:didFinishDismissal:", ParameterType = new Type [] { typeof (StoreKit.SKOverlay), typeof (StoreKit.SKOverlayTransitionContext) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISKOverlayDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("storeOverlay:didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoad (SKOverlay overlay, NSError error)
		{
			_DidFailToLoad (this, overlay, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToLoad (ISKOverlayDelegate This, SKOverlay overlay, NSError error)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFailToLoadWithError:"), overlay__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("storeOverlay:willStartPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPresentation (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			_WillStartPresentation (this, overlay, transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartPresentation (ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:willStartPresentation:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("storeOverlay:didFinishPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishPresentation (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			_DidFinishPresentation (this, overlay, transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishPresentation (ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFinishPresentation:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("storeOverlay:willStartDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartDismissal (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			_WillStartDismissal (this, overlay, transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartDismissal (ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:willStartDismissal:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[global::Foundation.OptionalMember]
		[Export ("storeOverlay:didFinishDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDismissal (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			_DidFinishDismissal (this, overlay, transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishDismissal (ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFinishDismissal:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[DynamicDependencyAttribute ("DidFailToLoad(StoreKit.SKOverlay,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishDismissal(StoreKit.SKOverlay,StoreKit.SKOverlayTransitionContext)")]
		[DynamicDependencyAttribute ("DidFinishPresentation(StoreKit.SKOverlay,StoreKit.SKOverlayTransitionContext)")]
		[DynamicDependencyAttribute ("WillStartDismissal(StoreKit.SKOverlay,StoreKit.SKOverlayTransitionContext)")]
		[DynamicDependencyAttribute ("WillStartPresentation(StoreKit.SKOverlay,StoreKit.SKOverlayTransitionContext)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKOverlayDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISKOverlayDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISKOverlayDelegate" /> interface to support all the methods from the SKOverlayDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISKOverlayDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SKOverlayDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SKOverlayDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToLoad (this ISKOverlayDelegate This, SKOverlay overlay, NSError error)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFailToLoadWithError:"), overlay__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartPresentation (this ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:willStartPresentation:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishPresentation (this ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFinishPresentation:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartDismissal (this ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:willStartDismissal:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishDismissal (this ISKOverlayDelegate This, SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var transitionContext__handle__ = transitionContext!.GetNonNullHandle (nameof (transitionContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("storeOverlay:didFinishDismissal:"), overlay__handle__, transitionContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (overlay);
			GC.KeepAlive (transitionContext);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SKOverlayDelegateWrapper : BaseWrapper, ISKOverlayDelegate {
		public SKOverlayDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKOverlayDelegateWrapper))]
		static SKOverlayDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace StoreKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISKOverlayDelegate" /> (for the protocol <c>SKOverlayDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISKOverlayDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__StoreKit_SKOverlayDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class SKOverlayDelegate : NSObject, ISKOverlayDelegate {
		/// <summary>Creates a new <see cref="SKOverlayDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKOverlayDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected SKOverlayDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal SKOverlayDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("storeOverlay:didFailToLoadWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToLoad (SKOverlay overlay, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("storeOverlay:didFinishDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDismissal (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("storeOverlay:didFinishPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishPresentation (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("storeOverlay:willStartDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartDismissal (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("storeOverlay:willStartPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartPresentation (SKOverlay overlay, SKOverlayTransitionContext transitionContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SKOverlayDelegate */
}
