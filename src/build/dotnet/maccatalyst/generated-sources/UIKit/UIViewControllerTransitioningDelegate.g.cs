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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIViewControllerTransitioningDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIViewControllerTransitioningDelegate", WrapperType = typeof (UIViewControllerTransitioningDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnimationControllerForPresentedController", Selector = "animationControllerForPresentedController:presentingController:sourceController:", ReturnType = typeof (IUIViewControllerAnimatedTransitioning), ParameterType = new Type [] { typeof (UIViewController), typeof (UIViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnimationControllerForDismissedController", Selector = "animationControllerForDismissedController:", ReturnType = typeof (IUIViewControllerAnimatedTransitioning), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInteractionControllerForPresentation", Selector = "interactionControllerForPresentation:", ReturnType = typeof (IUIViewControllerInteractiveTransitioning), ParameterType = new Type [] { typeof (IUIViewControllerAnimatedTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInteractionControllerForDismissal", Selector = "interactionControllerForDismissal:", ReturnType = typeof (IUIViewControllerInteractiveTransitioning), ParameterType = new Type [] { typeof (IUIViewControllerAnimatedTransitioning) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPresentationControllerForPresentedViewController", Selector = "presentationControllerForPresentedViewController:presentingViewController:sourceViewController:", ReturnType = typeof (UIPresentationController), ParameterType = new Type [] { typeof (UIViewController), typeof (UIViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUIViewControllerTransitioningDelegate : INativeObject, IDisposable
	{
		/// <param name="presented">To be added.</param><param name="presenting">To be added.</param><param name="source">To be added.</param><summary>Returns the animation controller that is used when <paramref name="presenting" /> presents <paramref name="presented" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source)
		{
			return _GetAnimationControllerForPresentedController (this, presented, presenting, source);
		}
		/// <param name="presented">To be added.</param><param name="presenting">To be added.</param><param name="source">To be added.</param><summary>Returns the animation controller that is used when <paramref name="presenting" /> presents <paramref name="presented" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerAnimatedTransitioning _GetAnimationControllerForPresentedController (IUIViewControllerTransitioningDelegate This, UIViewController presented, UIViewController presenting, UIViewController source)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presented__handle__ = presented!.GetNonNullHandle (nameof (presented));
			var presenting__handle__ = presenting!.GetNonNullHandle (nameof (presenting));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("animationControllerForPresentedController:presentingController:sourceController:"), presented__handle__, presenting__handle__, source__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (presented);
			GC.KeepAlive (presenting);
			GC.KeepAlive (source);
			return ret!;
		}
		/// <param name="dismissed">To be added.</param><summary>When a dismissal animation is called, this method can be overridden to provide a custom UIViewControllerAnimatedTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("animationControllerForDismissedController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForDismissedController (UIViewController dismissed)
		{
			return _GetAnimationControllerForDismissedController (this, dismissed);
		}
		/// <param name="dismissed">To be added.</param><summary>When a dismissal animation is called, this method can be overridden to provide a custom UIViewControllerAnimatedTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerAnimatedTransitioning _GetAnimationControllerForDismissedController (IUIViewControllerTransitioningDelegate This, UIViewController dismissed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dismissed__handle__ = dismissed!.GetNonNullHandle (nameof (dismissed));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationControllerForDismissedController:"), dismissed__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dismissed);
			return ret!;
		}
		/// <param name="animator">To be added.</param><summary>When a controller is presented and an interaction desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("interactionControllerForPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForPresentation (IUIViewControllerAnimatedTransitioning animator)
		{
			return _GetInteractionControllerForPresentation (this, animator);
		}
		/// <param name="animator">To be added.</param><summary>When a controller is presented and an interaction desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerInteractiveTransitioning _GetInteractionControllerForPresentation (IUIViewControllerTransitioningDelegate This, IUIViewControllerAnimatedTransitioning animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionControllerForPresentation:"), animator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
			return ret!;
		}
		/// <param name="animator">To be added.</param><summary>When a controller is dismissed and an interaction is desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.|When a dismissal interaction is called and an interaction animation is desired, t</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("interactionControllerForDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForDismissal (IUIViewControllerAnimatedTransitioning animator)
		{
			return _GetInteractionControllerForDismissal (this, animator);
		}
		/// <param name="animator">To be added.</param><summary>When a controller is dismissed and an interaction is desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.|When a dismissal interaction is called and an interaction animation is desired, t</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerInteractiveTransitioning _GetInteractionControllerForDismissal (IUIViewControllerTransitioningDelegate This, IUIViewControllerAnimatedTransitioning animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionControllerForDismissal:"), animator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
			return ret!;
		}
		/// <param name="presentedViewController">To be added.</param><param name="presentingViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="sourceViewController">To be added.</param><summary>Returns the presentation controller that is used when <paramref name="presentingViewController" /> presents <paramref name="presentedViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPresentationController GetPresentationControllerForPresentedViewController (UIViewController presentedViewController, UIViewController? presentingViewController, UIViewController sourceViewController)
		{
			return _GetPresentationControllerForPresentedViewController (this, presentedViewController, presentingViewController, sourceViewController);
		}
		/// <param name="presentedViewController">To be added.</param><param name="presentingViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="sourceViewController">To be added.</param><summary>Returns the presentation controller that is used when <paramref name="presentingViewController" /> presents <paramref name="presentedViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPresentationController _GetPresentationControllerForPresentedViewController (IUIViewControllerTransitioningDelegate This, UIViewController presentedViewController, UIViewController? presentingViewController, UIViewController sourceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentedViewController__handle__ = presentedViewController!.GetNonNullHandle (nameof (presentedViewController));
			var presentingViewController__handle__ = presentingViewController.GetHandle ();
			var sourceViewController__handle__ = sourceViewController!.GetNonNullHandle (nameof (sourceViewController));
			UIPresentationController? ret;
			ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:"), presentedViewController__handle__, presentingViewController__handle__, sourceViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (presentedViewController);
			GC.KeepAlive (presentingViewController);
			GC.KeepAlive (sourceViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAnimationControllerForDismissedController(UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetAnimationControllerForPresentedController(UIKit.UIViewController,UIKit.UIViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetInteractionControllerForDismissal(UIKit.IUIViewControllerAnimatedTransitioning)")]
		[DynamicDependencyAttribute ("GetInteractionControllerForPresentation(UIKit.IUIViewControllerAnimatedTransitioning)")]
		[DynamicDependencyAttribute ("GetPresentationControllerForPresentedViewController(UIKit.UIViewController,UIKit.UIViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitioningDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIViewControllerTransitioningDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIViewControllerTransitioningDelegate" /> interface to support all the methods from the UIViewControllerTransitioningDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIViewControllerTransitioningDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIViewControllerTransitioningDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIViewControllerTransitioningDelegate_Extensions {
		/// <param name="presented">To be added.</param><param name="presenting">To be added.</param><param name="source">To be added.</param><summary>Returns the animation controller that is used when <paramref name="presenting" /> presents <paramref name="presented" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController (this IUIViewControllerTransitioningDelegate This, UIViewController presented, UIViewController presenting, UIViewController source)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presented__handle__ = presented!.GetNonNullHandle (nameof (presented));
			var presenting__handle__ = presenting!.GetNonNullHandle (nameof (presenting));
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("animationControllerForPresentedController:presentingController:sourceController:"), presented__handle__, presenting__handle__, source__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (presented);
			GC.KeepAlive (presenting);
			GC.KeepAlive (source);
			return ret!;
		}
		/// <param name="dismissed">To be added.</param><summary>When a dismissal animation is called, this method can be overridden to provide a custom UIViewControllerAnimatedTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerAnimatedTransitioning GetAnimationControllerForDismissedController (this IUIViewControllerTransitioningDelegate This, UIViewController dismissed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dismissed__handle__ = dismissed!.GetNonNullHandle (nameof (dismissed));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("animationControllerForDismissedController:"), dismissed__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dismissed);
			return ret!;
		}
		/// <param name="animator">To be added.</param><summary>When a controller is presented and an interaction desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerInteractiveTransitioning GetInteractionControllerForPresentation (this IUIViewControllerTransitioningDelegate This, IUIViewControllerAnimatedTransitioning animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionControllerForPresentation:"), animator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
			return ret!;
		}
		/// <param name="animator">To be added.</param><summary>When a controller is dismissed and an interaction is desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.|When a dismissal interaction is called and an interaction animation is desired, t</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerInteractiveTransitioning GetInteractionControllerForDismissal (this IUIViewControllerTransitioningDelegate This, IUIViewControllerAnimatedTransitioning animator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var animator__handle__ = animator!.GetNonNullHandle (nameof (animator));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("interactionControllerForDismissal:"), animator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (animator);
			return ret!;
		}
		/// <param name="presentedViewController">To be added.</param><param name="presentingViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="sourceViewController">To be added.</param><summary>Returns the presentation controller that is used when <paramref name="presentingViewController" /> presents <paramref name="presentedViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPresentationController GetPresentationControllerForPresentedViewController (this IUIViewControllerTransitioningDelegate This, UIViewController presentedViewController, UIViewController? presentingViewController, UIViewController sourceViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentedViewController__handle__ = presentedViewController!.GetNonNullHandle (nameof (presentedViewController));
			var presentingViewController__handle__ = presentingViewController.GetHandle ();
			var sourceViewController__handle__ = sourceViewController!.GetNonNullHandle (nameof (sourceViewController));
			UIPresentationController? ret;
			ret =  Runtime.GetNSObject<UIPresentationController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:"), presentedViewController__handle__, presentingViewController__handle__, sourceViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (presentedViewController);
			GC.KeepAlive (presentingViewController);
			GC.KeepAlive (sourceViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIViewControllerTransitioningDelegateWrapper : BaseWrapper, IUIViewControllerTransitioningDelegate {
		public UIViewControllerTransitioningDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIViewControllerTransitioningDelegateWrapper))]
		static UIViewControllerTransitioningDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIViewControllerTransitioningDelegate" /> (for the protocol <c>UIViewControllerTransitioningDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIViewControllerTransitioningDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIViewControllerTransitioningDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIViewControllerTransitioningDelegate : NSObject, IUIViewControllerTransitioningDelegate {
		/// <summary>Creates a new <see cref="UIViewControllerTransitioningDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIViewControllerTransitioningDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UIViewControllerTransitioningDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIViewControllerTransitioningDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="dismissed">To be added.</param><summary>When a dismissal animation is called, this method can be overridden to provide a custom UIViewControllerAnimatedTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationControllerForDismissedController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForDismissedController (UIViewController dismissed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presented">To be added.</param><param name="presenting">To be added.</param><param name="source">To be added.</param><summary>Returns the animation controller that is used when <paramref name="presenting" /> presents <paramref name="presented" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animator">To be added.</param><summary>When a controller is dismissed and an interaction is desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.|When a dismissal interaction is called and an interaction animation is desired, t</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("interactionControllerForDismissal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForDismissal (IUIViewControllerAnimatedTransitioning animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="animator">To be added.</param><summary>When a controller is presented and an interaction desired, this method can be overridden to provide a custom UIViewControllerInteractiveTransitioning.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("interactionControllerForPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForPresentation (IUIViewControllerAnimatedTransitioning animator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentedViewController">To be added.</param><param name="presentingViewController"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="sourceViewController">To be added.</param><summary>Returns the presentation controller that is used when <paramref name="presentingViewController" /> presents <paramref name="presentedViewController" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPresentationController GetPresentationControllerForPresentedViewController (UIViewController presentedViewController, UIViewController? presentingViewController, UIViewController sourceViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIViewControllerTransitioningDelegate */
}
