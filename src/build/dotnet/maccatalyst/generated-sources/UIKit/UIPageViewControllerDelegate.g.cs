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
	/// <summary>This interface represents the Objective-C protocol <c>UIPageViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIPageViewControllerDelegate", WrapperType = typeof (UIPageViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishAnimating", Selector = "pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:", ParameterType = new Type [] { typeof (UIPageViewController), typeof (bool), typeof (UIViewController[]), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSpineLocation", Selector = "pageViewController:spineLocationForInterfaceOrientation:", ReturnType = typeof (UIPageViewControllerSpineLocation), ParameterType = new Type [] { typeof (UIPageViewController), typeof (UIInterfaceOrientation) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTransition", Selector = "pageViewController:willTransitionToViewControllers:", ParameterType = new Type [] { typeof (UIPageViewController), typeof (UIViewController[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportedInterfaceOrientations", Selector = "pageViewControllerSupportedInterfaceOrientations:", ReturnType = typeof (UIInterfaceOrientationMask), ParameterType = new Type [] { typeof (UIPageViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredInterfaceOrientationForPresentation", Selector = "pageViewControllerPreferredInterfaceOrientationForPresentation:", ReturnType = typeof (UIInterfaceOrientation), ParameterType = new Type [] { typeof (UIPageViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIPageViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="pageViewController">To be added.</param><param name="finished">To be added.</param><param name="previousViewControllers">To be added.</param><param name="completed">To be added.</param><summary>Indicates that animation has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAnimating (UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed)
		{
			_DidFinishAnimating (this, pageViewController, finished, previousViewControllers, completed);
		}
		/// <param name="pageViewController">To be added.</param><param name="finished">To be added.</param><param name="previousViewControllers">To be added.</param><param name="completed">To be added.</param><summary>Indicates that animation has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishAnimating (IUIPageViewControllerDelegate This, UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			if (previousViewControllers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previousViewControllers));
			using var nsa_previousViewControllers = NSArray.FromNSObjects (previousViewControllers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle_bool (This.Handle, Selector.GetHandle ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:"), pageViewController__handle__, finished ? (byte) 1 : (byte) 0, nsa_previousViewControllers.Handle, completed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><param name="orientation">To be added.</param><summary>The location of the spine of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageViewController:spineLocationForInterfaceOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPageViewControllerSpineLocation GetSpineLocation (UIPageViewController pageViewController, UIInterfaceOrientation orientation)
		{
			return _GetSpineLocation (this, pageViewController, orientation);
		}
		/// <param name="pageViewController">To be added.</param><param name="orientation">To be added.</param><summary>The location of the spine of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIPageViewControllerSpineLocation _GetSpineLocation (IUIPageViewControllerDelegate This, UIPageViewController pageViewController, UIInterfaceOrientation orientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIPageViewControllerSpineLocation ret;
			ret = (UIPageViewControllerSpineLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pageViewController:spineLocationForInterfaceOrientation:"), pageViewController__handle__, (IntPtr) (long) orientation);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><param name="pendingViewControllers">To be added.</param><summary>Indicates that a transition is about to begin.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageViewController:willTransitionToViewControllers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransition (UIPageViewController pageViewController, UIViewController[] pendingViewControllers)
		{
			_WillTransition (this, pageViewController, pendingViewControllers);
		}
		/// <param name="pageViewController">To be added.</param><param name="pendingViewControllers">To be added.</param><summary>Indicates that a transition is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTransition (IUIPageViewControllerDelegate This, UIPageViewController pageViewController, UIViewController[] pendingViewControllers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			if (pendingViewControllers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pendingViewControllers));
			using var nsa_pendingViewControllers = NSArray.FromNSObjects (pendingViewControllers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageViewController:willTransitionToViewControllers:"), pageViewController__handle__, nsa_pendingViewControllers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The supported interface orientations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageViewControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UIPageViewController pageViewController)
		{
			return _SupportedInterfaceOrientations (this, pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The supported interface orientations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientationMask _SupportedInterfaceOrientations (IUIPageViewControllerDelegate This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageViewControllerSupportedInterfaceOrientations:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><summary>The preferred orientation of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("pageViewControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (UIPageViewController pageViewController)
		{
			return _GetPreferredInterfaceOrientationForPresentation (this, pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The preferred orientation of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIInterfaceOrientation _GetPreferredInterfaceOrientationForPresentation (IUIPageViewControllerDelegate This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageViewControllerPreferredInterfaceOrientationForPresentation:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidFinishAnimating(UIKit.UIPageViewController,System.Boolean,UIKit.UIViewController[],System.Boolean)")]
		[DynamicDependencyAttribute ("GetPreferredInterfaceOrientationForPresentation(UIKit.UIPageViewController)")]
		[DynamicDependencyAttribute ("GetSpineLocation(UIKit.UIPageViewController,UIKit.UIInterfaceOrientation)")]
		[DynamicDependencyAttribute ("SupportedInterfaceOrientations(UIKit.UIPageViewController)")]
		[DynamicDependencyAttribute ("WillTransition(UIKit.UIPageViewController,UIKit.UIViewController[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPageViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPageViewControllerDelegate" /> interface to support all the methods from the UIPageViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPageViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPageViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPageViewControllerDelegate_Extensions {
		/// <param name="pageViewController">To be added.</param><param name="finished">To be added.</param><param name="previousViewControllers">To be added.</param><param name="completed">To be added.</param><summary>Indicates that animation has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishAnimating (this IUIPageViewControllerDelegate This, UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			if (previousViewControllers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (previousViewControllers));
			using var nsa_previousViewControllers = NSArray.FromNSObjects (previousViewControllers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle_bool (This.Handle, Selector.GetHandle ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:"), pageViewController__handle__, finished ? (byte) 1 : (byte) 0, nsa_previousViewControllers.Handle, completed ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><param name="orientation">To be added.</param><summary>The location of the spine of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPageViewControllerSpineLocation GetSpineLocation (this IUIPageViewControllerDelegate This, UIPageViewController pageViewController, UIInterfaceOrientation orientation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIPageViewControllerSpineLocation ret;
			ret = (UIPageViewControllerSpineLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("pageViewController:spineLocationForInterfaceOrientation:"), pageViewController__handle__, (IntPtr) (long) orientation);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><param name="pendingViewControllers">To be added.</param><summary>Indicates that a transition is about to begin.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTransition (this IUIPageViewControllerDelegate This, UIPageViewController pageViewController, UIViewController[] pendingViewControllers)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			if (pendingViewControllers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pendingViewControllers));
			using var nsa_pendingViewControllers = NSArray.FromNSObjects (pendingViewControllers);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pageViewController:willTransitionToViewControllers:"), pageViewController__handle__, nsa_pendingViewControllers.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
		}
		/// <param name="pageViewController">To be added.</param><summary>The supported interface orientations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientationMask SupportedInterfaceOrientations (this IUIPageViewControllerDelegate This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIInterfaceOrientationMask ret;
			ret = (UIInterfaceOrientationMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageViewControllerSupportedInterfaceOrientations:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
		/// <param name="pageViewController">To be added.</param><summary>The preferred orientation of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (this IUIPageViewControllerDelegate This, UIPageViewController pageViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var pageViewController__handle__ = pageViewController!.GetNonNullHandle (nameof (pageViewController));
			UIInterfaceOrientation ret;
			ret = (UIInterfaceOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("pageViewControllerPreferredInterfaceOrientationForPresentation:"), pageViewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (pageViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPageViewControllerDelegateWrapper : BaseWrapper, IUIPageViewControllerDelegate {
		public UIPageViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPageViewControllerDelegateWrapper))]
		static UIPageViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPageViewControllerDelegate" /> (for the protocol <c>UIPageViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPageViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPageViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIPageViewControllerDelegate : NSObject, IUIPageViewControllerDelegate {
		/// <summary>Creates a new <see cref="UIPageViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPageViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPageViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPageViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="pageViewController">To be added.</param><param name="finished">To be added.</param><param name="previousViewControllers">To be added.</param><param name="completed">To be added.</param><summary>Indicates that animation has completed.</summary><remarks>To be added.</remarks>
		[Export ("pageViewController:didFinishAnimating:previousViewControllers:transitionCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAnimating (UIPageViewController pageViewController, bool finished, UIViewController[] previousViewControllers, bool completed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><summary>The preferred orientation of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewControllerPreferredInterfaceOrientationForPresentation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientation GetPreferredInterfaceOrientationForPresentation (UIPageViewController pageViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><param name="orientation">To be added.</param><summary>The location of the spine of the UIPageViewController.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewController:spineLocationForInterfaceOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIPageViewControllerSpineLocation GetSpineLocation (UIPageViewController pageViewController, UIInterfaceOrientation orientation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><summary>The supported interface orientations.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pageViewControllerSupportedInterfaceOrientations:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIInterfaceOrientationMask SupportedInterfaceOrientations (UIPageViewController pageViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="pageViewController">To be added.</param><param name="pendingViewControllers">To be added.</param><summary>Indicates that a transition is about to begin.</summary><remarks>To be added.</remarks>
		[Export ("pageViewController:willTransitionToViewControllers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTransition (UIPageViewController pageViewController, UIViewController[] pendingViewControllers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPageViewControllerDelegate */
}
