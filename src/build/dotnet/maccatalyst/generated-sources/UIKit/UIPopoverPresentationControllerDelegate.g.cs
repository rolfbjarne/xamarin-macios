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
	/// <summary>Delegate object for <see cref="T:UIKit.UIPopoverPresentationController" /> objects. Provides methods relating to presentation and dismissal events and allows fine-grained control for adaptive presentations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPopoverPresentationControllerDelegate_protocol/index.html">Apple documentation for <c>UIPopoverPresentationControllerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIPopoverPresentationControllerDelegate", WrapperType = typeof (UIPopoverPresentationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForPopoverPresentation", Selector = "prepareForPopoverPresentation:", ParameterType = new Type [] { typeof (UIPopoverPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDismissPopover", Selector = "popoverPresentationControllerShouldDismissPopover:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIPopoverPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismissPopover", Selector = "popoverPresentationControllerDidDismissPopover:", ParameterType = new Type [] { typeof (UIPopoverPresentationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillRepositionPopover", Selector = "popoverPresentationController:willRepositionPopoverToRect:inView:", ParameterType = new Type [] { typeof (UIPopoverPresentationController), typeof (CGRect), typeof (UIView) }, ParameterByRef = new bool [] { false, true, true })]
	public partial interface IUIPopoverPresentationControllerDelegate : INativeObject, IDisposable, 
		UIKit.IUIAdaptivePresentationControllerDelegate
	{
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> will be presented soon.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("prepareForPopoverPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController)
		{
			_PrepareForPopoverPresentation (this, popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> will be presented soon.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrepareForPopoverPresentation (IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareForPopoverPresentation:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>Asks if the popover that is controlled by <paramref name="popoverPresentationController" /> should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverPresentationControllerShouldDismissPopover:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'ShouldDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'ShouldDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismissPopover (UIPopoverPresentationController popoverPresentationController)
		{
			return _ShouldDismissPopover (this, popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>Asks if the popover that is controlled by <paramref name="popoverPresentationController" /> should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'ShouldDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'ShouldDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDismissPopover (IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationControllerShouldDismissPopover:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
			return ret != 0;
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverPresentationControllerDidDismissPopover:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'DidDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'DidDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPopover (UIPopoverPresentationController popoverPresentationController)
		{
			_DidDismissPopover (this, popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'DidDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'DidDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismissPopover (IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationControllerDidDismissPopover:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><param name="targetRect">To be added.</param><param name="inView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverPresentationController:willRepositionPopoverToRect:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillRepositionPopover (UIPopoverPresentationController popoverPresentationController, ref CGRect targetRect, ref UIView inView)
		{
			_WillRepositionPopover (this, popoverPresentationController, ref targetRect, ref inView);
		}
		/// <param name="popoverPresentationController">To be added.</param><param name="targetRect">To be added.</param><param name="inView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillRepositionPopover (IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController, ref CGRect targetRect, ref UIView inView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			fixed (CGRect* targetRect__pointer = &targetRect) {
			var inViewValue = Runtime.RetainAndAutoreleaseNativeObject (inView);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_CGRect_ref_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationController:willRepositionPopoverToRect:inView:"), popoverPresentationController__handle__, targetRect__pointer, &inViewValue);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
			inView = Runtime.GetNSObject<UIView> (inViewValue)!;
			}
		}
		[DynamicDependencyAttribute ("DidDismissPopover(UIKit.UIPopoverPresentationController)")]
		[DynamicDependencyAttribute ("PrepareForPopoverPresentation(UIKit.UIPopoverPresentationController)")]
		[DynamicDependencyAttribute ("ShouldDismissPopover(UIKit.UIPopoverPresentationController)")]
		[DynamicDependencyAttribute ("WillRepositionPopover(UIKit.UIPopoverPresentationController,CoreGraphics.CGRect@,UIKit.UIView@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverPresentationControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPopoverPresentationControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPopoverPresentationControllerDelegate" /> interface to support all the methods from the UIPopoverPresentationControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPopoverPresentationControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPopoverPresentationControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPopoverPresentationControllerDelegate_Extensions {
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> will be presented soon.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrepareForPopoverPresentation (this IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prepareForPopoverPresentation:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>Asks if the popover that is controlled by <paramref name="popoverPresentationController" /> should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'ShouldDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'ShouldDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDismissPopover (this IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationControllerShouldDismissPopover:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
			return ret != 0;
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'DidDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'DidDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismissPopover (this IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationControllerDidDismissPopover:"), popoverPresentationController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
		}
		/// <param name="popoverPresentationController">To be added.</param><param name="targetRect">To be added.</param><param name="inView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillRepositionPopover (this IUIPopoverPresentationControllerDelegate This, UIPopoverPresentationController popoverPresentationController, ref CGRect targetRect, ref UIView inView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverPresentationController__handle__ = popoverPresentationController!.GetNonNullHandle (nameof (popoverPresentationController));
			fixed (CGRect* targetRect__pointer = &targetRect) {
			var inViewValue = Runtime.RetainAndAutoreleaseNativeObject (inView);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_CGRect_ref_NativeHandle (This.Handle, Selector.GetHandle ("popoverPresentationController:willRepositionPopoverToRect:inView:"), popoverPresentationController__handle__, targetRect__pointer, &inViewValue);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverPresentationController);
			inView = Runtime.GetNSObject<UIView> (inViewValue)!;
			}
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPopoverPresentationControllerDelegateWrapper : BaseWrapper, IUIPopoverPresentationControllerDelegate {
		public UIPopoverPresentationControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverPresentationControllerDelegateWrapper))]
		static UIPopoverPresentationControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>Delegate object for <see cref="T:UIKit.UIPopoverPresentationController" /> objects. Provides methods relating to presentation and dismissal events and allows fine-grained control for adaptive presentations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPopoverPresentationControllerDelegate_protocol/index.html">Apple documentation for <c>UIPopoverPresentationControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIPopoverPresentationControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPopoverPresentationControllerDelegate : UIAdaptivePresentationControllerDelegate, IUIPopoverPresentationControllerDelegate {
		/// <summary>Creates a new <see cref="UIPopoverPresentationControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPopoverPresentationControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPopoverPresentationControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPopoverPresentationControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> was dismissed.</summary><remarks>To be added.</remarks>
		[Export ("popoverPresentationControllerDidDismissPopover:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'DidDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'DidDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismissPopover (UIPopoverPresentationController popoverPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>The popover that is controlled by <paramref name="popoverPresentationController" /> will be presented soon.</summary><remarks>To be added.</remarks>
		[Export ("prepareForPopoverPresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForPopoverPresentation (UIPopoverPresentationController popoverPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="popoverPresentationController">To be added.</param><summary>Asks if the popover that is controlled by <paramref name="popoverPresentationController" /> should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("popoverPresentationControllerShouldDismissPopover:")]
		[ObsoletedOSPlatform ("ios13.0", "Replaced by 'ShouldDismiss'.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Replaced by 'ShouldDismiss'.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismissPopover (UIPopoverPresentationController popoverPresentationController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="popoverPresentationController">To be added.</param><param name="targetRect">To be added.</param><param name="inView">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popoverPresentationController:willRepositionPopoverToRect:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillRepositionPopover (UIPopoverPresentationController popoverPresentationController, ref CGRect targetRect, ref UIView inView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPopoverPresentationControllerDelegate */
}
