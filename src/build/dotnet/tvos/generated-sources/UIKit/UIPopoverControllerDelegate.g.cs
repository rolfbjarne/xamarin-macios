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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIPopoverControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("ios9.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIPopoverControllerDelegate", WrapperType = typeof (UIPopoverControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "popoverControllerDidDismissPopover:", ParameterType = new Type [] { typeof (UIPopoverController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDismiss", Selector = "popoverControllerShouldDismissPopover:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIPopoverController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillReposition", Selector = "popoverController:willRepositionPopoverToRect:inView:", ParameterType = new Type [] { typeof (UIPopoverController), typeof (CGRect), typeof (UIView) }, ParameterByRef = new bool [] { false, true, true })]
	public partial interface IUIPopoverControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="popoverController">To be added.</param><summary>Indicates that the UIPopover was dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverControllerDidDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPopoverController popoverController)
		{
			_DidDismiss (this, popoverController);
		}
		/// <param name="popoverController">To be added.</param><summary>Indicates that the UIPopover was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismiss (IUIPopoverControllerDelegate This, UIPopoverController popoverController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverControllerDidDismissPopover:"), popoverController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
		}
		/// <param name="popoverController">To be added.</param><summary>Whether the popover should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverControllerShouldDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (UIPopoverController popoverController)
		{
			return _ShouldDismiss (this, popoverController);
		}
		/// <param name="popoverController">To be added.</param><summary>Whether the popover should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDismiss (IUIPopoverControllerDelegate This, UIPopoverController popoverController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverControllerShouldDismissPopover:"), popoverController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
			return ret != 0;
		}
		/// <param name="popoverController">To be added.</param><param name="rect">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("popoverController:willRepositionPopoverToRect:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillReposition (UIPopoverController popoverController, ref CGRect rect, ref UIView view)
		{
			_WillReposition (this, popoverController, ref rect, ref view);
		}
		/// <param name="popoverController">To be added.</param><param name="rect">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillReposition (IUIPopoverControllerDelegate This, UIPopoverController popoverController, ref CGRect rect, ref UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			fixed (CGRect* rect__pointer = &rect) {
			var viewValue = Runtime.RetainAndAutoreleaseNativeObject (view);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_CGRect_ref_NativeHandle (This.Handle, Selector.GetHandle ("popoverController:willRepositionPopoverToRect:inView:"), popoverController__handle__, rect__pointer, &viewValue);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
			view = Runtime.GetNSObject<UIView> (viewValue)!;
			}
		}
		[DynamicDependencyAttribute ("DidDismiss(UIKit.UIPopoverController)")]
		[DynamicDependencyAttribute ("ShouldDismiss(UIKit.UIPopoverController)")]
		[DynamicDependencyAttribute ("WillReposition(UIKit.UIPopoverController,CoreGraphics.CGRect@,UIKit.UIView@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIPopoverControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIPopoverControllerDelegate" /> interface to support all the methods from the UIPopoverControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIPopoverControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIPopoverControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIPopoverControllerDelegate_Extensions {
		/// <param name="popoverController">To be added.</param><summary>Indicates that the UIPopover was dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this IUIPopoverControllerDelegate This, UIPopoverController popoverController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverControllerDidDismissPopover:"), popoverController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
		}
		/// <param name="popoverController">To be added.</param><summary>Whether the popover should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldDismiss (this IUIPopoverControllerDelegate This, UIPopoverController popoverController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("popoverControllerShouldDismissPopover:"), popoverController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
			return ret != 0;
		}
		/// <param name="popoverController">To be added.</param><param name="rect">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillReposition (this IUIPopoverControllerDelegate This, UIPopoverController popoverController, ref CGRect rect, ref UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var popoverController__handle__ = popoverController!.GetNonNullHandle (nameof (popoverController));
			fixed (CGRect* rect__pointer = &rect) {
			var viewValue = Runtime.RetainAndAutoreleaseNativeObject (view);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_ref_CGRect_ref_NativeHandle (This.Handle, Selector.GetHandle ("popoverController:willRepositionPopoverToRect:inView:"), popoverController__handle__, rect__pointer, &viewValue);
			GC.KeepAlive (This);
			GC.KeepAlive (popoverController);
			view = Runtime.GetNSObject<UIView> (viewValue)!;
			}
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIPopoverControllerDelegateWrapper : BaseWrapper, IUIPopoverControllerDelegate {
		public UIPopoverControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIPopoverControllerDelegateWrapper))]
		static UIPopoverControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIPopoverControllerDelegate" /> (for the protocol <c>UIPopoverControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIPopoverControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIPopoverControllerDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("ios9.0")]
	[ObsoletedOSPlatform ("tvos9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIPopoverControllerDelegate : NSObject, IUIPopoverControllerDelegate {
		/// <summary>Creates a new <see cref="UIPopoverControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIPopoverControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected UIPopoverControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIPopoverControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="popoverController">To be added.</param><summary>Indicates that the UIPopover was dismissed.</summary><remarks>To be added.</remarks>
		[Export ("popoverControllerDidDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (UIPopoverController popoverController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="popoverController">To be added.</param><summary>Whether the popover should be dismissed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("popoverControllerShouldDismissPopover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDismiss (UIPopoverController popoverController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="popoverController">To be added.</param><param name="rect">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popoverController:willRepositionPopoverToRect:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillReposition (UIPopoverController popoverController, ref CGRect rect, ref UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIPopoverControllerDelegate */
}
