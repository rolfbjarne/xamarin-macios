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
	/// <summary>A class used to receive notifications from a <see cref="T:UIKit.UIActionSheet" />.</summary><remarks>A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UIActionSheet" />.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIModalViewDelegate_Protocol/index.html">Apple documentation for <c>UIActionSheetDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios8.3")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIActionSheetDelegate", WrapperType = typeof (UIActionSheetDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Clicked", Selector = "actionSheet:clickedButtonAtIndex:", ParameterType = new Type [] { typeof (UIActionSheet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Canceled", Selector = "actionSheetCancel:", ParameterType = new Type [] { typeof (UIActionSheet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresent", Selector = "willPresentActionSheet:", ParameterType = new Type [] { typeof (UIActionSheet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Presented", Selector = "didPresentActionSheet:", ParameterType = new Type [] { typeof (UIActionSheet) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDismiss", Selector = "actionSheet:willDismissWithButtonIndex:", ParameterType = new Type [] { typeof (UIActionSheet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dismissed", Selector = "actionSheet:didDismissWithButtonIndex:", ParameterType = new Type [] { typeof (UIActionSheet), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIActionSheetDelegate : INativeObject, IDisposable
	{
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the button at the buttonIndex was clicked.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("actionSheet:clickedButtonAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Clicked (UIActionSheet actionSheet, nint buttonIndex)
		{
			_Clicked (this, actionSheet, buttonIndex);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the button at the buttonIndex was clicked.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Clicked (IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:clickedButtonAtIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the UIActionSheet was canceled.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("actionSheetCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIActionSheet actionSheet)
		{
			_Canceled (this, actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the UIActionSheet was canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Canceled (IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("actionSheetCancel:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet is about to be presented.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("willPresentActionSheet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIActionSheet actionSheet)
		{
			_WillPresent (this, actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillPresent (IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentActionSheet:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet was presented to the user.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didPresentActionSheet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Presented (UIActionSheet actionSheet)
		{
			_Presented (this, actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet was presented to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Presented (IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentActionSheet:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action sheet will shortly be dismissed due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("actionSheet:willDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIActionSheet actionSheet, nint buttonIndex)
		{
			_WillDismiss (this, actionSheet, buttonIndex);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action sheet will shortly be dismissed due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillDismiss (IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:willDismissWithButtonIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action was dismissed from the screen due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("actionSheet:didDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dismissed (UIActionSheet actionSheet, nint buttonIndex)
		{
			_Dismissed (this, actionSheet, buttonIndex);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action was dismissed from the screen due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Dismissed (IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:didDismissWithButtonIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		[DynamicDependencyAttribute ("Canceled(UIKit.UIActionSheet)")]
		[DynamicDependencyAttribute ("Clicked(UIKit.UIActionSheet,System.IntPtr)")]
		[DynamicDependencyAttribute ("Dismissed(UIKit.UIActionSheet,System.IntPtr)")]
		[DynamicDependencyAttribute ("Presented(UIKit.UIActionSheet)")]
		[DynamicDependencyAttribute ("WillDismiss(UIKit.UIActionSheet,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillPresent(UIKit.UIActionSheet)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActionSheetDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIActionSheetDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIActionSheetDelegate" /> interface to support all the methods from the UIActionSheetDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIActionSheetDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIActionSheetDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIActionSheetDelegate_Extensions {
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the button at the buttonIndex was clicked.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Clicked (this IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:clickedButtonAtIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the UIActionSheet was canceled.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Canceled (this IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("actionSheetCancel:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet is about to be presented.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillPresent (this IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("willPresentActionSheet:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet was presented to the user.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Presented (this IUIActionSheetDelegate This, UIActionSheet actionSheet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didPresentActionSheet:"), actionSheet__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action sheet will shortly be dismissed due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillDismiss (this IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:willDismissWithButtonIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action was dismissed from the screen due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Dismissed (this IUIActionSheetDelegate This, UIActionSheet actionSheet, nint buttonIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var actionSheet__handle__ = actionSheet!.GetNonNullHandle (nameof (actionSheet));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("actionSheet:didDismissWithButtonIndex:"), actionSheet__handle__, buttonIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (actionSheet);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIActionSheetDelegateWrapper : BaseWrapper, IUIActionSheetDelegate {
		public UIActionSheetDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActionSheetDelegateWrapper))]
		static UIActionSheetDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>A class used to receive notifications from a <see cref="T:UIKit.UIActionSheet" />.</summary><remarks>A strongly typed implementation of a class that can be used to respond to events raised by the <see cref="T:UIKit.UIActionSheet" />.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIModalViewDelegate_Protocol/index.html">Apple documentation for <c>UIActionSheetDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIActionSheetDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios8.3")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIActionSheetDelegate : NSObject, IUIActionSheetDelegate {
		/// <summary>Creates a new <see cref="UIActionSheetDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIActionSheetDelegate () : base (NSObjectFlag.Empty)
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
		protected UIActionSheetDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIActionSheetDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="actionSheet">To be added.</param><summary>Indicates that the UIActionSheet was canceled.</summary><remarks>To be added.</remarks>
		[Export ("actionSheetCancel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Canceled (UIActionSheet actionSheet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the button at the buttonIndex was clicked.</summary><remarks>To be added.</remarks>
		[Export ("actionSheet:clickedButtonAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Clicked (UIActionSheet actionSheet, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action was dismissed from the screen due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[Export ("actionSheet:didDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Dismissed (UIActionSheet actionSheet, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet was presented to the user.</summary><remarks>To be added.</remarks>
		[Export ("didPresentActionSheet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Presented (UIActionSheet actionSheet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionSheet">To be added.</param><param name="buttonIndex">To be added.</param><summary>Indicates that the action sheet will shortly be dismissed due to pushing of the button at buttonIndex.</summary><remarks>To be added.</remarks>
		[Export ("actionSheet:willDismissWithButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillDismiss (UIActionSheet actionSheet, nint buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionSheet">To be added.</param><summary>Indicates that the action sheet is about to be presented.</summary><remarks>To be added.</remarks>
		[Export ("willPresentActionSheet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillPresent (UIActionSheet actionSheet)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIActionSheetDelegate */
}
