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
	/// <summary>A class used to receive notifications from a <see cref="T:UIKit.UIAlertView" />.</summary><remarks><para>A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UIAlertView" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIAlertViewDelegate_Protocol/index.html">Apple documentation for <c>UIAlertViewDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIAlertViewDelegate", WrapperType = typeof (UIAlertViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Clicked", Selector = "alertView:clickedButtonAtIndex:", ParameterType = new Type [] { typeof (UIAlertView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Canceled", Selector = "alertViewCancel:", ParameterType = new Type [] { typeof (UIAlertView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "willPresentAlertView:", ParameterType = new Type [] { typeof (UIAlertView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Presented", Selector = "didPresentAlertView:", ParameterType = new Type [] { typeof (UIAlertView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "alertView:willDismissWithButtonIndex:", ParameterType = new Type [] { typeof (UIAlertView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dismissed", Selector = "alertView:didDismissWithButtonIndex:", ParameterType = new Type [] { typeof (UIAlertView), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEnableFirstOtherButton", Selector = "alertViewShouldEnableFirstOtherButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIAlertView) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIAlertViewDelegate : INativeObject, IDisposable
	{
		/// <param name="alertview">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the user has clicked a button in this UIAlertView.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("alertView:clickedButtonAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Clicked (UIAlertView alertview, nint buttonIndex)
		{
			_Clicked (this, alertview, buttonIndex);
		}
		/// <param name="alertview">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the user has clicked a button in this UIAlertView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Clicked (IUIAlertViewDelegate This, UIAlertView alertview, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertview__handle__ = alertview!.GetNonNullHandle (nameof (alertview));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:clickedButtonAtIndex:"), alertview__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertview);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView is about to be canceled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("alertViewCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIAlertView alertView)
		{
			_Canceled (this, alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView is about to be canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Canceled (IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alertViewCancel:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView will shortly be presented to the application user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("willPresentAlertView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIAlertView alertView)
		{
			_WillPresent (this, alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView will shortly be presented to the application user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresent (IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentAlertView:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView has been presented to the application user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didPresentAlertView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Presented (UIAlertView alertView)
		{
			_Presented (this, alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView has been presented to the application user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Presented (IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentAlertView:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView will shortly be dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("alertView:willDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIAlertView alertView, nint buttonIndex)
		{
			_WillDismiss (this, alertView, buttonIndex);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView will shortly be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismiss (IUIAlertViewDelegate This, UIAlertView alertView, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:willDismissWithButtonIndex:"), alertView__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView has been dismissed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("alertView:didDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dismissed (UIAlertView alertView, nint buttonIndex)
		{
			_Dismissed (this, alertView, buttonIndex);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView has been dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Dismissed (IUIAlertViewDelegate This, UIAlertView alertView, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:didDismissWithButtonIndex:"), alertView__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Whether the first non-cancel button in this UIAlertView should be enabled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("alertViewShouldEnableFirstOtherButton:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEnableFirstOtherButton (UIAlertView alertView)
		{
			return _ShouldEnableFirstOtherButton (this, alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Whether the first non-cancel button in this UIAlertView should be enabled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEnableFirstOtherButton (IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alertViewShouldEnableFirstOtherButton:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Canceled(UIKit.UIAlertView)")]
		[DynamicDependencyAttribute ("Clicked(UIKit.UIAlertView,System.IntPtr)")]
		[DynamicDependencyAttribute ("Dismissed(UIKit.UIAlertView,System.IntPtr)")]
		[DynamicDependencyAttribute ("Presented(UIKit.UIAlertView)")]
		[DynamicDependencyAttribute ("ShouldEnableFirstOtherButton(UIKit.UIAlertView)")]
		[DynamicDependencyAttribute ("WillDismiss(UIKit.UIAlertView,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillPresent(UIKit.UIAlertView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAlertViewDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIAlertViewDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIAlertViewDelegate" /> interface to support all the methods from the UIAlertViewDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIAlertViewDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIAlertViewDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIAlertViewDelegate_Extensions {
		/// <param name="alertview">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the user has clicked a button in this UIAlertView.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Clicked (this IUIAlertViewDelegate This, UIAlertView alertview, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertview__handle__ = alertview!.GetNonNullHandle (nameof (alertview));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:clickedButtonAtIndex:"), alertview__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertview);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView is about to be canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Canceled (this IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alertViewCancel:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView will shortly be presented to the application user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentAlertView:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView has been presented to the application user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Presented (this IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentAlertView:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView will shortly be dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this IUIAlertViewDelegate This, UIAlertView alertView, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:willDismissWithButtonIndex:"), alertView__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView has been dismissed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Dismissed (this IUIAlertViewDelegate This, UIAlertView alertView, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("alertView:didDismissWithButtonIndex:"), alertView__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
		}
		/// <param name="alertView">To be added.</param><summary>Whether the first non-cancel button in this UIAlertView should be enabled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEnableFirstOtherButton (this IUIAlertViewDelegate This, UIAlertView alertView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var alertView__handle__ = alertView!.GetNonNullHandle (nameof (alertView));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("alertViewShouldEnableFirstOtherButton:"), alertView__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (alertView);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIAlertViewDelegateWrapper : BaseWrapper, IUIAlertViewDelegate {
		public UIAlertViewDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIAlertViewDelegateWrapper))]
		static UIAlertViewDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from a <see cref="T:UIKit.UIAlertView" />.</summary><remarks><para>A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UIAlertView" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIAlertViewDelegate_Protocol/index.html">Apple documentation for <c>UIAlertViewDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIAlertViewDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios9.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIAlertViewDelegate : NSObject, IUIAlertViewDelegate {
		/// <summary>Creates a new <see cref="UIAlertViewDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIAlertViewDelegate () : base (NSObjectFlag.Empty)
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
		protected UIAlertViewDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIAlertViewDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView is about to be canceled.</summary><remarks>To be added.</remarks>
		[Export ("alertViewCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIAlertView alertView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertview">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the user has clicked a button in this UIAlertView.</summary><remarks>To be added.</remarks>
		[Export ("alertView:clickedButtonAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Clicked (UIAlertView alertview, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView has been dismissed.</summary><remarks>To be added.</remarks>
		[Export ("alertView:didDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dismissed (UIAlertView alertView, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView has been presented to the application user.</summary><remarks>To be added.</remarks>
		[Export ("didPresentAlertView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Presented (UIAlertView alertView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertView">To be added.</param><summary>Whether the first non-cancel button in this UIAlertView should be enabled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("alertViewShouldEnableFirstOtherButton:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEnableFirstOtherButton (UIAlertView alertView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertView">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that this UIAlertView will shortly be dismissed.</summary><remarks>To be added.</remarks>
		[Export ("alertView:willDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIAlertView alertView, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="alertView">To be added.</param><summary>Indicates that this UIAlertView will shortly be presented to the application user.</summary><remarks>To be added.</remarks>
		[Export ("willPresentAlertView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIAlertView alertView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIAlertViewDelegate */
}
