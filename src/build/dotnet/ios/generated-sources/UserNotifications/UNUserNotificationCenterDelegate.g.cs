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
namespace UserNotifications {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UNUserNotificationCenterDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UNUserNotificationCenterDelegate", WrapperType = typeof (UNUserNotificationCenterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentNotification", Selector = "userNotificationCenter:willPresentNotification:withCompletionHandler:", ParameterType = new Type [] { typeof (UserNotifications.UNUserNotificationCenter), typeof (UserNotifications.UNNotification), typeof (global::System.Action<global::UserNotifications.UNNotificationPresentationOptions>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V280) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveNotificationResponse", Selector = "userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:", ParameterType = new Type [] { typeof (UserNotifications.UNUserNotificationCenter), typeof (UserNotifications.UNNotificationResponse), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenSettings", Selector = "userNotificationCenter:openSettingsForNotification:", ParameterType = new Type [] { typeof (UserNotifications.UNUserNotificationCenter), typeof (UserNotifications.UNNotification) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUNUserNotificationCenterDelegate : INativeObject, IDisposable
	{
		/// <param name="center">The notification center that received the response.</param><param name="notification">To be added.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called to deliver a notification to an application that is running in the foreground.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPresentNotification (UNUserNotificationCenter center, UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V280))]global::System.Action<UNNotificationPresentationOptions> completionHandler)
		{
			_WillPresentNotification (this, center, notification, completionHandler);
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">To be added.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called to deliver a notification to an application that is running in the foreground.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WillPresentNotification (IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V280))]global::System.Action<UNNotificationPresentationOptions> completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V280.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center__handle__, notification__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (notification);
		}
		/// <param name="center">The notification center that received the response.</param><param name="response">The user's response.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called after the user selects an action from a notification from the app.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveNotificationResponse (UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_DidReceiveNotificationResponse (this, center, response, completionHandler);
		}
		/// <param name="center">The notification center that received the response.</param><param name="response">The user's response.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called after the user selects an action from a notification from the app.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveNotificationResponse (IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (response);
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">The notification.</param><summary>Called to open the in-app notification settings.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userNotificationCenter:openSettingsForNotification:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenSettings (UNUserNotificationCenter center, UNNotification? notification)
		{
			_OpenSettings (this, center, notification);
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">The notification.</param><summary>Called to open the in-app notification settings.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenSettings (IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification? notification)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var notification__handle__ = notification.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:openSettingsForNotification:"), center__handle__, notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (notification);
		}
		[DynamicDependencyAttribute ("DidReceiveNotificationResponse(UserNotifications.UNUserNotificationCenter,UserNotifications.UNNotificationResponse,System.Action)")]
		[DynamicDependencyAttribute ("OpenSettings(UserNotifications.UNUserNotificationCenter,UserNotifications.UNNotification)")]
		[DynamicDependencyAttribute ("WillPresentNotification(UserNotifications.UNUserNotificationCenter,UserNotifications.UNNotification,System.Action{UserNotifications.UNNotificationPresentationOptions})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UNUserNotificationCenterDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUNUserNotificationCenterDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUNUserNotificationCenterDelegate" /> interface to support all the methods from the UNUserNotificationCenterDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUNUserNotificationCenterDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UNUserNotificationCenterDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UNUserNotificationCenterDelegate_Extensions {
		/// <param name="center">The notification center that received the response.</param><param name="notification">To be added.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called to deliver a notification to an application that is running in the foreground.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void WillPresentNotification (this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V280))]global::System.Action<UNNotificationPresentationOptions> completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V280.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center__handle__, notification__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (notification);
		}
		/// <param name="center">The notification center that received the response.</param><param name="response">The user's response.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called after the user selects an action from a notification from the app.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveNotificationResponse (this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (response);
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">The notification.</param><summary>Called to open the in-app notification settings.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenSettings (this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification? notification)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var notification__handle__ = notification.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("userNotificationCenter:openSettingsForNotification:"), center__handle__, notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (center);
			GC.KeepAlive (notification);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UNUserNotificationCenterDelegateWrapper : BaseWrapper, IUNUserNotificationCenterDelegate {
		public UNUserNotificationCenterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UNUserNotificationCenterDelegateWrapper))]
		static UNUserNotificationCenterDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UserNotifications {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUNUserNotificationCenterDelegate" /> (for the protocol <c>UNUserNotificationCenterDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUNUserNotificationCenterDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__UserNotifications_UNUserNotificationCenterDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UNUserNotificationCenterDelegate : NSObject, IUNUserNotificationCenterDelegate {
		/// <summary>Creates a new <see cref="UNUserNotificationCenterDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UNUserNotificationCenterDelegate () : base (NSObjectFlag.Empty)
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
		protected UNUserNotificationCenterDelegate (NSObjectFlag t) : base (t)
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
		protected internal UNUserNotificationCenterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="center">The notification center that received the response.</param><param name="response">The user's response.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called after the user selects an action from a notification from the app.</summary><remarks>To be added.</remarks>
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveNotificationResponse (UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">The notification.</param><summary>Called to open the in-app notification settings.</summary><remarks>To be added.</remarks>
		[Export ("userNotificationCenter:openSettingsForNotification:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenSettings (UNUserNotificationCenter center, UNNotification? notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="center">The notification center that received the response.</param><param name="notification">To be added.</param><param name="completionHandler">An action that takes no arguments and returns no value.</param><summary>Called to deliver a notification to an application that is running in the foreground.</summary><remarks>To be added.</remarks>
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillPresentNotification (UNUserNotificationCenter center, UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V280))]global::System.Action<UNNotificationPresentationOptions> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UNUserNotificationCenterDelegate */
}
