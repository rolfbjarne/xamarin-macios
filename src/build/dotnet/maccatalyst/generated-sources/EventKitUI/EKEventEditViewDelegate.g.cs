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
namespace EventKitUI {
	#pragma warning disable CS1573
	/// <summary>Delegate class used to receive notifications from the EKEventEditViewController class.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventEditViewDelegateRef/index.html">Apple documentation for <c>EKEventEditViewDelegate</c></related>
	[Protocol (Name = "EKEventEditViewDelegate", WrapperType = typeof (EKEventEditViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Completed", Selector = "eventEditViewController:didCompleteWithAction:", ParameterType = new Type [] { typeof (EventKitUI.EKEventEditViewController), typeof (EventKitUI.EKEventEditViewAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDefaultCalendarForNewEvents", Selector = "eventEditViewControllerDefaultCalendarForNewEvents:", ReturnType = typeof (EventKit.EKCalendar), ParameterType = new Type [] { typeof (EventKitUI.EKEventEditViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IEKEventEditViewDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("eventEditViewController:didCompleteWithAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Completed (EKEventEditViewController controller, EKEventEditViewAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Completed (IEKEventEditViewDelegate This, EKEventEditViewController controller, EKEventEditViewAction action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("eventEditViewController:didCompleteWithAction:"), controller__handle__, (IntPtr) (long) action);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("eventEditViewControllerDefaultCalendarForNewEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::EventKit.EKCalendar GetDefaultCalendarForNewEvents (EKEventEditViewController controller)
		{
			return _GetDefaultCalendarForNewEvents (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::EventKit.EKCalendar _GetDefaultCalendarForNewEvents (IEKEventEditViewDelegate This, EKEventEditViewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::EventKit.EKCalendar? ret;
			ret =  Runtime.GetNSObject<global::EventKit.EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventEditViewControllerDefaultCalendarForNewEvents:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
		[DynamicDependencyAttribute ("Completed(EventKitUI.EKEventEditViewController,EventKitUI.EKEventEditViewAction)")]
		[DynamicDependencyAttribute ("GetDefaultCalendarForNewEvents(EventKitUI.EKEventEditViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EKEventEditViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IEKEventEditViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IEKEventEditViewDelegate" /> interface to support all the methods from the EKEventEditViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IEKEventEditViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original EKEventEditViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class EKEventEditViewDelegate_Extensions {
		/// <param name="controller">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::EventKit.EKCalendar GetDefaultCalendarForNewEvents (this IEKEventEditViewDelegate This, EKEventEditViewController controller)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::EventKit.EKCalendar? ret;
			ret =  Runtime.GetNSObject<global::EventKit.EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventEditViewControllerDefaultCalendarForNewEvents:"), controller__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class EKEventEditViewDelegateWrapper : BaseWrapper, IEKEventEditViewDelegate {
		public EKEventEditViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (EKEventEditViewDelegateWrapper))]
		static EKEventEditViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="controller">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("eventEditViewController:didCompleteWithAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Completed (EKEventEditViewController controller, EKEventEditViewAction action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("eventEditViewController:didCompleteWithAction:"), controller__handle__, (IntPtr) (long) action);
			GC.KeepAlive (controller);
		}
	}
}
namespace EventKitUI {
	/// <summary>Delegate class used to receive notifications from the EKEventEditViewController class.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventEditViewDelegateRef/index.html">Apple documentation for <c>EKEventEditViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__EventKitUI_EKEventEditViewDelegate", false)]
	[Model]
	public unsafe abstract partial class EKEventEditViewDelegate : NSObject, IEKEventEditViewDelegate {
		/// <summary>Creates a new <see cref="EKEventEditViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected EKEventEditViewDelegate () : base (NSObjectFlag.Empty)
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
		protected EKEventEditViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal EKEventEditViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("eventEditViewController:didCompleteWithAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Completed (EKEventEditViewController controller, EKEventEditViewAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("eventEditViewControllerDefaultCalendarForNewEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::EventKit.EKCalendar GetDefaultCalendarForNewEvents (EKEventEditViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class EKEventEditViewDelegate */
}
