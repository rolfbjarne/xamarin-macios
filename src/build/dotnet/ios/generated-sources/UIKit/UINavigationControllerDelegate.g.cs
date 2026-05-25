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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UINavigationControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UINavigationControllerDelegate", WrapperType = typeof (UINavigationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowViewController", Selector = "navigationController:willShowViewController:animated:", ParameterType = new Type [] { typeof (UINavigationController), typeof (UIViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowViewController", Selector = "navigationController:didShowViewController:animated:", ParameterType = new Type [] { typeof (UINavigationController), typeof (UIViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportedInterfaceOrientations", Selector = "navigationControllerSupportedInterfaceOrientations:", ReturnType = typeof (UIInterfaceOrientationMask), ParameterType = new Type [] { typeof (UINavigationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredInterfaceOrientation", Selector = "navigationControllerPreferredInterfaceOrientationForPresentation:", ReturnType = typeof (UIInterfaceOrientation), ParameterType = new Type [] { typeof (UINavigationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetInteractionControllerForAnimationController", Selector = "navigationController:interactionControllerForAnimationController:", ReturnType = typeof (IUIViewControllerInteractiveTransitioning), ParameterType = new Type [] { typeof (UINavigationController), typeof (IUIViewControllerAnimatedTransitioning) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnimationControllerForOperation", Selector = "navigationController:animationControllerForOperation:fromViewController:toViewController:", ReturnType = typeof (IUIViewControllerAnimatedTransitioning), ParameterType = new Type [] { typeof (UINavigationController), typeof (UINavigationControllerOperation), typeof (UIViewController), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IUINavigationControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Called by the system shortly before the  is displayed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationController:willShowViewController:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowViewController (UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			_WillShowViewController (this, navigationController, viewController, animated);
		}
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Called by the system shortly before the  is displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillShowViewController (IUINavigationControllerDelegate This, UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("navigationController:willShowViewController:animated:"), navigationController__handle__, viewController__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (viewController);
		}
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Extension method called shortly after the <paramref name="viewController" /> has been made visible.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationController:didShowViewController:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowViewController (UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			_DidShowViewController (this, navigationController, viewController, animated);
		}
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Extension method called shortly after the <paramref name="viewController" /> has been made visible.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShowViewController (IUINavigationControllerDelegate This, UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("navigationController:didShowViewController:animated:"), navigationController__handle__, viewController__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (viewController);
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to dynamically specify the supported orientations of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UINavigationController navigationController)
		{
			return _SupportedInterfaceOrientations (this, navigationController);
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to dynamically specify the supported orientations of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientationMask _SupportedInterfaceOrientations (IUINavigationControllerDelegate This, UINavigationController navigationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationControllerSupportedInterfaceOrientations:"), navigationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to set the preferred interface orientation of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientation (UINavigationController navigationController)
		{
			return _GetPreferredInterfaceOrientation (this, navigationController);
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to set the preferred interface orientation of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientation _GetPreferredInterfaceOrientation (IUINavigationControllerDelegate This, UINavigationController navigationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationControllerPreferredInterfaceOrientationForPresentation:"), navigationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><param name="animationController">To be added.</param><summary>Called by the system to retrieve an interactive transition animation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationController:interactionControllerForAnimationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForAnimationController (UINavigationController navigationController, IUIViewControllerAnimatedTransitioning animationController)
		{
			return _GetInteractionControllerForAnimationController (this, navigationController, animationController);
		}
		/// <param name="navigationController">To be added.</param><param name="animationController">To be added.</param><summary>Called by the system to retrieve an interactive transition animation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerInteractiveTransitioning _GetInteractionControllerForAnimationController (IUINavigationControllerDelegate This, UINavigationController navigationController, IUIViewControllerAnimatedTransitioning animationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var animationController__handle__ = animationController!.GetNonNullHandle (nameof (animationController));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationController:interactionControllerForAnimationController:"), navigationController__handle__, animationController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (animationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><param name="operation">To be added.</param><param name="fromViewController">To be added.</param><param name="toViewController">To be added.</param><summary>Called by the system to retrieve the transition animation for the <paramref name="operation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForOperation (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromViewController, UIViewController toViewController)
		{
			return _GetAnimationControllerForOperation (this, navigationController, operation, fromViewController, toViewController);
		}
		/// <param name="navigationController">To be added.</param><param name="operation">To be added.</param><param name="fromViewController">To be added.</param><param name="toViewController">To be added.</param><summary>Called by the system to retrieve the transition animation for the <paramref name="operation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIViewControllerAnimatedTransitioning _GetAnimationControllerForOperation (IUINavigationControllerDelegate This, UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromViewController, UIViewController toViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var toViewController__handle__ = toViewController!.GetNonNullHandle (nameof (toViewController));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationController:animationControllerForOperation:fromViewController:toViewController:"), navigationController__handle__, (IntPtr) (long) operation, fromViewController__handle__, toViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (toViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidShowViewController(UIKit.UINavigationController,UIKit.UIViewController,System.Boolean)")]
		[DynamicDependencyAttribute ("GetAnimationControllerForOperation(UIKit.UINavigationController,UIKit.UINavigationControllerOperation,UIKit.UIViewController,UIKit.UIViewController)")]
		[DynamicDependencyAttribute ("GetInteractionControllerForAnimationController(UIKit.UINavigationController,UIKit.IUIViewControllerAnimatedTransitioning)")]
		[DynamicDependencyAttribute ("GetPreferredInterfaceOrientation(UIKit.UINavigationController)")]
		[DynamicDependencyAttribute ("SupportedInterfaceOrientations(UIKit.UINavigationController)")]
		[DynamicDependencyAttribute ("WillShowViewController(UIKit.UINavigationController,UIKit.UIViewController,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUINavigationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUINavigationControllerDelegate" /> interface to support all the methods from the UINavigationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUINavigationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UINavigationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UINavigationControllerDelegate_Extensions {
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Called by the system shortly before the  is displayed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowViewController (this IUINavigationControllerDelegate This, UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("navigationController:willShowViewController:animated:"), navigationController__handle__, viewController__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (viewController);
		}
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Extension method called shortly after the <paramref name="viewController" /> has been made visible.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowViewController (this IUINavigationControllerDelegate This, UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("navigationController:didShowViewController:animated:"), navigationController__handle__, viewController__handle__, animated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (viewController);
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to dynamically specify the supported orientations of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientationMask SupportedInterfaceOrientations (this IUINavigationControllerDelegate This, UINavigationController navigationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationControllerSupportedInterfaceOrientations:"), navigationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to set the preferred interface orientation of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientation GetPreferredInterfaceOrientation (this IUINavigationControllerDelegate This, UINavigationController navigationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("navigationControllerPreferredInterfaceOrientationForPresentation:"), navigationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><param name="animationController">To be added.</param><summary>Called by the system to retrieve an interactive transition animation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerInteractiveTransitioning GetInteractionControllerForAnimationController (this IUINavigationControllerDelegate This, UINavigationController navigationController, IUIViewControllerAnimatedTransitioning animationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var animationController__handle__ = animationController!.GetNonNullHandle (nameof (animationController));
			IUIViewControllerInteractiveTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerInteractiveTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationController:interactionControllerForAnimationController:"), navigationController__handle__, animationController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (animationController);
			return ret!;
		}
		/// <param name="navigationController">To be added.</param><param name="operation">To be added.</param><param name="fromViewController">To be added.</param><param name="toViewController">To be added.</param><summary>Called by the system to retrieve the transition animation for the <paramref name="operation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IUIViewControllerAnimatedTransitioning GetAnimationControllerForOperation (this IUINavigationControllerDelegate This, UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromViewController, UIViewController toViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var navigationController__handle__ = navigationController!.GetNonNullHandle (nameof (navigationController));
			var fromViewController__handle__ = fromViewController!.GetNonNullHandle (nameof (fromViewController));
			var toViewController__handle__ = toViewController!.GetNonNullHandle (nameof (toViewController));
			IUIViewControllerAnimatedTransitioning? ret;
			ret =  Runtime.GetINativeObject<IUIViewControllerAnimatedTransitioning> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("navigationController:animationControllerForOperation:fromViewController:toViewController:"), navigationController__handle__, (IntPtr) (long) operation, fromViewController__handle__, toViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (navigationController);
			GC.KeepAlive (fromViewController);
			GC.KeepAlive (toViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UINavigationControllerDelegateWrapper : BaseWrapper, IUINavigationControllerDelegate {
		public UINavigationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UINavigationControllerDelegateWrapper))]
		static UINavigationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUINavigationControllerDelegate" /> (for the protocol <c>UINavigationControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUINavigationControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UINavigationControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UINavigationControllerDelegate : NSObject, IUINavigationControllerDelegate {
		/// <summary>Creates a new <see cref="UINavigationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UINavigationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UINavigationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UINavigationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Extension method called shortly after the <paramref name="viewController" /> has been made visible.</summary><remarks>To be added.</remarks>
		[Export ("navigationController:didShowViewController:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowViewController (UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationController">To be added.</param><param name="operation">To be added.</param><param name="fromViewController">To be added.</param><param name="toViewController">To be added.</param><summary>Called by the system to retrieve the transition animation for the <paramref name="operation" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerAnimatedTransitioning GetAnimationControllerForOperation (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromViewController, UIViewController toViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationController">To be added.</param><param name="animationController">To be added.</param><summary>Called by the system to retrieve an interactive transition animation.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationController:interactionControllerForAnimationController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIViewControllerInteractiveTransitioning GetInteractionControllerForAnimationController (UINavigationController navigationController, IUIViewControllerAnimatedTransitioning animationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to set the preferred interface orientation of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientation (UINavigationController navigationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationController">To be added.</param><summary>Can be overridden to dynamically specify the supported orientations of the .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("navigationControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UINavigationController navigationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="navigationController">To be added.</param><param name="viewController">To be added.</param><param name="animated">To be added.</param><summary>Called by the system shortly before the  is displayed.</summary><remarks>To be added.</remarks>
		[Export ("navigationController:willShowViewController:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowViewController (UINavigationController navigationController, [Transient] UIViewController viewController, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UINavigationControllerDelegate */
}
