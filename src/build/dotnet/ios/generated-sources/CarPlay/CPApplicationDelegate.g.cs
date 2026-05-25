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
namespace CarPlay {
	#pragma warning disable CS1573
	/// <summary>The application delegate for CarPlay applications.</summary>
	[SupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "CPApplicationDelegate", WrapperType = typeof (CPApplicationDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidConnectCarInterfaceController", Selector = "application:didConnectCarInterfaceController:toWindow:", ParameterType = new Type [] { typeof (UIApplication), typeof (CarPlay.CPInterfaceController), typeof (CarPlay.CPWindow) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidDisconnectCarInterfaceController", Selector = "application:didDisconnectCarInterfaceController:fromWindow:", ParameterType = new Type [] { typeof (UIApplication), typeof (CarPlay.CPInterfaceController), typeof (CarPlay.CPWindow) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectNavigationAlert", Selector = "application:didSelectNavigationAlert:", ParameterType = new Type [] { typeof (UIApplication), typeof (CarPlay.CPNavigationAlert) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectManeuver", Selector = "application:didSelectManeuver:", ParameterType = new Type [] { typeof (UIApplication), typeof (CarPlay.CPManeuver) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICPApplicationDelegate : INativeObject, IDisposable, 
		UIKit.IUIApplicationDelegate
	{
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("application:didConnectCarInterfaceController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnectCarInterfaceController (ICPApplicationDelegate This, global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didConnectCarInterfaceController:toWindow:"), application__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("application:didDisconnectCarInterfaceController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnectCarInterfaceController (ICPApplicationDelegate This, global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDisconnectCarInterfaceController:fromWindow:"), application__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		/// <param name="application">The application in which a navigation alert was selected.</param><param name="navigationAlert">The selected navigation alert.</param><summary>Method that is called when the user selects a navigation alert.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didSelectNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectNavigationAlert (global::UIKit.UIApplication application, CPNavigationAlert navigationAlert)
		{
			_DidSelectNavigationAlert (this, application, navigationAlert);
		}
		/// <param name="application">The application in which a navigation alert was selected.</param><param name="navigationAlert">The selected navigation alert.</param><summary>Method that is called when the user selects a navigation alert.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectNavigationAlert (ICPApplicationDelegate This, global::UIKit.UIApplication application, CPNavigationAlert navigationAlert)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didSelectNavigationAlert:"), application__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="application">The application in which a maneuver was selected.</param><param name="maneuver">The selected maneuver.</param><summary>Method that is called when the user selects a maneuver.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didSelectManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectManeuver (global::UIKit.UIApplication application, CPManeuver maneuver)
		{
			_DidSelectManeuver (this, application, maneuver);
		}
		/// <param name="application">The application in which a maneuver was selected.</param><param name="maneuver">The selected maneuver.</param><summary>Method that is called when the user selects a maneuver.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectManeuver (ICPApplicationDelegate This, global::UIKit.UIApplication application, CPManeuver maneuver)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didSelectManeuver:"), application__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (maneuver);
		}
		[DynamicDependencyAttribute ("DidConnectCarInterfaceController(UIKit.UIApplication,CarPlay.CPInterfaceController,CarPlay.CPWindow)")]
		[DynamicDependencyAttribute ("DidDisconnectCarInterfaceController(UIKit.UIApplication,CarPlay.CPInterfaceController,CarPlay.CPWindow)")]
		[DynamicDependencyAttribute ("DidSelectManeuver(UIKit.UIApplication,CarPlay.CPManeuver)")]
		[DynamicDependencyAttribute ("DidSelectNavigationAlert(UIKit.UIApplication,CarPlay.CPNavigationAlert)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPApplicationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPApplicationDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPApplicationDelegate" /> interface to support all the methods from the CPApplicationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPApplicationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPApplicationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPApplicationDelegate_Extensions {
		/// <param name="application">The application in which a navigation alert was selected.</param><param name="navigationAlert">The selected navigation alert.</param><summary>Method that is called when the user selects a navigation alert.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectNavigationAlert (this ICPApplicationDelegate This, global::UIKit.UIApplication application, CPNavigationAlert navigationAlert)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var navigationAlert__handle__ = navigationAlert!.GetNonNullHandle (nameof (navigationAlert));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didSelectNavigationAlert:"), application__handle__, navigationAlert__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (navigationAlert);
		}
		/// <param name="application">The application in which a maneuver was selected.</param><param name="maneuver">The selected maneuver.</param><summary>Method that is called when the user selects a maneuver.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectManeuver (this ICPApplicationDelegate This, global::UIKit.UIApplication application, CPManeuver maneuver)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var maneuver__handle__ = maneuver!.GetNonNullHandle (nameof (maneuver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didSelectManeuver:"), application__handle__, maneuver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (maneuver);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPApplicationDelegateWrapper : BaseWrapper, ICPApplicationDelegate {
		public CPApplicationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPApplicationDelegateWrapper))]
		static CPApplicationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didConnectCarInterfaceController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidConnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("application:didConnectCarInterfaceController:toWindow:"), application__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (application);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didDisconnectCarInterfaceController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidDisconnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var interfaceController__handle__ = interfaceController!.GetNonNullHandle (nameof (interfaceController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("application:didDisconnectCarInterfaceController:fromWindow:"), application__handle__, interfaceController__handle__, window__handle__);
			GC.KeepAlive (application);
			GC.KeepAlive (interfaceController);
			GC.KeepAlive (window);
		}
	}
}
namespace CarPlay {
	/// <summary>The application delegate for CarPlay applications.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPApplicationDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class CPApplicationDelegate : NSObject, ICPApplicationDelegate, global::UIKit.IUIApplicationDelegate {
		/// <summary>Creates a new <see cref="CPApplicationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CPApplicationDelegate () : base (NSObjectFlag.Empty)
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
		protected CPApplicationDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPApplicationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Performs the most important action of the app. Often, this is toggling the most important state of the app.</summary><returns><see langword="true" /> if the action succeeded.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityPerformMagicTap")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformMagicTap ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates a significant change in time, such as midnight, change to Daylight Savings, or a shift in timezone.</summary><remarks>To be added.</remarks>
		[Export ("applicationSignificantTimeChange:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationSignificantTimeChange (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="oldStatusBarFrame">The status bar's previous Frame.</param><summary>Indicates that the frame of the status bar has changed.</summary><remarks>To be added.</remarks>
		[Export ("application:didChangeStatusBarFrame:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ViewWillTransitionToSize' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedStatusBarFrame (global::UIKit.UIApplication application, CGRect oldStatusBarFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton.</param><param name="userActivity">The user activity identifier.</param><param name="completionHandler">System-provided callback that can be called with appropriate <see cref="T:UIKit.UIResponder" /> or <see cref="T:UIKit.UIDocument" /> objects.</param><summary>Informs the app that there is data associated with continuing a task specified as a <see cref="T:Foundation.NSUserActivity" /> object, and then returns whether the app continued the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:continueUserActivity:restorationHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ContinueUserActivity (global::UIKit.UIApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler))]global::UIKit.UIApplicationRestorationHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="oldStatusBarOrientation">The status bar's previous orientation.</param><summary>Indicates that the orientation of the status bar has changed.</summary><remarks>To be added.</remarks>
		[Export ("application:didChangeStatusBarOrientation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ViewWillTransitionToSize' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeStatusBarOrientation (global::UIKit.UIApplication application, global::UIKit.UIInterfaceOrientation oldStatusBarOrientation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didConnectCarInterfaceController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app should restore highest-level state.</summary><remarks>To be added.</remarks>
		[Export ("application:didDecodeRestorableStateWithCoder:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDecodeRestorableState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:didDiscardSceneSessions:")]
		[SupportedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDiscardSceneSessions (global::UIKit.UIApplication application, NSSet<global::UIKit.UISceneSession> sceneSessions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="interfaceController">To be added.</param><param name="window">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:didDisconnectCarInterfaceController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectCarInterfaceController (global::UIKit.UIApplication application, CPInterfaceController interfaceController, CPWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application has entered the background.</summary><remarks><para>Apps should complete processing this method in approximately 5 seconds. If more time is necessary, applications can call <see cref="M:UIKit.UIApplication.BeginBackgroundTask(System.String,System.Action)" />.</para></remarks>
		[Export ("applicationDidEnterBackground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>Informs the app that the activity of the <paramref name="userActivityType" /> type could not be continued, and specifies a <paramref name="error" /> as the reason for the failure.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToContinueUserActivityWithType:error:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (global::UIKit.UIApplication application, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="userInfo">To be added.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveRemoteNotification (global::UIKit.UIApplication application, NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V28))]global::System.Action<global::UIKit.UIBackgroundFetchResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="notificationSettings">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'UNUserNotificationCenter.RequestAuthorization' instead.</summary><remarks>To be added.</remarks>
		[Export ("application:didRegisterUserNotificationSettings:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenter.RequestAuthorization' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRegisterUserNotificationSettings (global::UIKit.UIApplication application, global::UIKit.UIUserNotificationSettings notificationSettings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The application in which a maneuver was selected.</param><param name="maneuver">The selected maneuver.</param><summary>Method that is called when the user selects a maneuver.</summary><remarks>To be added.</remarks>
		[Export ("application:didSelectManeuver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectManeuver (global::UIKit.UIApplication application, CPManeuver maneuver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The application in which a navigation alert was selected.</param><param name="navigationAlert">The selected navigation alert.</param><summary>Method that is called when the user selects a navigation alert.</summary><remarks>To be added.</remarks>
		[Export ("application:didSelectNavigationAlert:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectNavigationAlert (global::UIKit.UIApplication application, CPNavigationAlert navigationAlert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="error">To be added.</param><summary>Indicates that Apple Push Service did not successfully compete the registration process.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToRegisterForRemoteNotificationsWithError:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToRegisterForRemoteNotifications (global::UIKit.UIApplication application, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The application has finished launching.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidFinishLaunching:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLaunching (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that launching has finished and the app will shortly begin running.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:didFinishLaunchingWithOptions:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FinishedLaunching (global::UIKit.UIApplication application, NSDictionary? launchOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:configurationForConnectingSceneSession:options:")]
		[SupportedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UISceneConfiguration GetConfiguration (global::UIKit.UIApplication application, global::UIKit.UISceneSession connectingSceneSession, global::UIKit.UISceneConnectionOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:handlerForIntent:")]
		[SupportedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandlerForIntent (global::UIKit.UIApplication application, global::Intents.INIntent intent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="forWindow">To be added.</param><summary>The interface orientations supported by the app.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:supportedInterfaceOrientationsForWindow:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIInterfaceOrientationMask GetSupportedInterfaceOrientations (global::UIKit.UIApplication application, [Transient] global::UIKit.UIWindow? forWindow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="restorationIdentifierComponents">An array of identifiers that identify the path to the desired view controller, which should be last.</param><param name="coder">To be added.</param><summary>Retrieves the UIViewController identified by the last value in the restorationIdentifierComponents parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:viewControllerWithRestorationIdentifierPath:coder:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController? GetViewController (global::UIKit.UIApplication application, string[] restorationIdentifierComponents, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="actionIdentifier">To be added.</param><param name="localNotification">To be added.</param><param name="completionHandler">To be added.</param><summary>Informs the app that the user selected an action identified by the <paramref name="actionIdentifier" /> value from an alert of a <see cref="T:UIKit.UILocalNotification" /> object, and executes the <paramref name="completionHandler" /> block after it completes the action.</summary><remarks>To be added.</remarks>
		[Export ("application:handleActionWithIdentifier:forLocalNotification:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.DidReceiveNotificationResponse' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAction (global::UIKit.UIApplication application, string actionIdentifier, global::UIKit.UILocalNotification localNotification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="actionIdentifier">To be added.</param><param name="localNotification">To be added.</param><param name="responseInfo">To be added.</param><param name="completionHandler">To be added.</param><summary>Informs the app of a custom action to perform based on a local notification, and includes the <paramref name="actionIdentifier" /> value, <paramref name="responseInfo" /> data from the notification, and <paramref name="completionHandler" /> for the app developer to run after performing the action.</summary><remarks>To be added.</remarks>
		[Export ("application:handleActionWithIdentifier:forLocalNotification:withResponseInfo:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.DidReceiveNotificationResponse' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAction (global::UIKit.UIApplication application, string actionIdentifier, global::UIKit.UILocalNotification localNotification, NSDictionary responseInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="actionIdentifier">To be added.</param><param name="remoteNotificationInfo">To be added.</param><param name="completionHandler">To be added.</param><summary>Informs the app of a custom action to perform based on a push notification, and includes the <paramref name="actionIdentifier" /> value, <paramref name="remoteNotificationInfo" /> data from the notification, and <paramref name="completionHandler" /> for the app developer to run after performing the action.</summary><remarks>To be added.</remarks>
		[Export ("application:handleActionWithIdentifier:forRemoteNotification:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.DidReceiveNotificationResponse' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAction (global::UIKit.UIApplication application, string actionIdentifier, NSDictionary remoteNotificationInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="actionIdentifier">To be added.</param><param name="remoteNotificationInfo">To be added.</param><param name="responseInfo">To be added.</param><param name="completionHandler">To be added.</param><summary>Informs the app of a custom action to perform based on a remote notification, and includes the <paramref name="actionIdentifier" /> value, <paramref name="remoteNotificationInfo" /> data from the notification, and <paramref name="completionHandler" /> for the app developer to run after performing the action.</summary><remarks>To be added.</remarks>
		[Export ("application:handleActionWithIdentifier:forRemoteNotification:withResponseInfo:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.DidReceiveNotificationResponse' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAction (global::UIKit.UIApplication application, string actionIdentifier, NSDictionary remoteNotificationInfo, NSDictionary responseInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="sessionIdentifier">To be added.</param><param name="completionHandler">To be added.</param><summary>Raised when events relating to a background <see cref="T:Foundation.NSUrlSession" /> are waiting to be processed.</summary><remarks>To be added.</remarks>
		[Export ("application:handleEventsForBackgroundURLSession:completionHandler:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleEventsForBackgroundUrl (global::UIKit.UIApplication application, string sessionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The application that created the intent.</param><param name="intent">The intent.</param><param name="completionHandler">A handler to run after the operation completes.</param><summary>The system is requesting that the application handle the specified <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("application:handleIntent:completionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GetHandlerForIntent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleIntent (global::UIKit.UIApplication application, global::Intents.INIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V29))]global::System.Action<global::Intents.INIntentResponse> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="url">To be added.</param><summary>Developers should use <see cref="M:UIKit.UIApplicationDelegate.OpenUrl(UIKit.UIApplication,Foundation.NSUrl,System.String,Foundation.NSObject)" /> rather than this deprecated method.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:handleOpenURL:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Override 'OpenUrl (UIApplication, NSUrl, NSDictionary)'. The later will be called if both are implemented.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleOpenURL (global::UIKit.UIApplication application, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><param name="reply">To be added.</param><summary>A watchkit extension has made a request.</summary><remarks>To be added.</remarks>
		[Export ("application:handleWatchKitExtensionRequest:reply:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleWatchKitExtensionRequest (global::UIKit.UIApplication application, NSDictionary? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V30))]global::System.Action<NSDictionary> reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has moved from the inactive to actie state.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidBecomeActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnActivated (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app is about to move from the active state to the inactive state.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillResignActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnResignActivation (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to this application (<see cref="P:UIKit.UIApplication.SharedApplication" />).</param><param name="url">The <see cref="T:Foundation.NSUrl" /> specified by the calling application.</param><param name="sourceApplication">The bundle ID of the calling application.</param><param name="annotation">Optional property-list data passed by the calling application.</param><summary>Loads a resource from the specified URL.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openURL:sourceApplication:annotation:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Override 'OpenUrl (UIApplication, NSUrl, NSDictionary)'. The later will be called if both are implemented.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenUrl (global::UIKit.UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> with context from <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openURL:options:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenUrl (global::UIKit.UIApplication app, NSUrl url, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> according to <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool OpenUrl (global::UIKit.UIApplication app, NSUrl url, global::UIKit.UIApplicationOpenUrlOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="shortcutItem">To be added.</param><param name="completionHandler">To be added.</param><summary>
		/// Called by the system when the user initiates a Home screen quick action, unless the interaction was handled
		/// in <see cref="M:UIKit.UIApplicationDelegate.WillFinishLaunching(UIKit.UIApplication,Foundation.NSDictionary)" />
		/// or <see cref="M:UIKit.UIApplicationDelegate.FinishedLaunching(UIKit.UIApplication)" />.
		/// </summary><remarks>To be added.</remarks>
		[Export ("application:performActionForShortcutItem:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'PerformAction' from 'UIWindowSceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformActionForShortcutItem (global::UIKit.UIApplication application, global::UIKit.UIApplicationShortcutItem shortcutItem, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIOperationHandler))]global::UIKit.UIOperationHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the application can begin a fetch operation if it has data to download.</summary><remarks>To be added.</remarks>
		[Export ("application:performFetchWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformFetch (global::UIKit.UIApplication application, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V28))]global::System.Action<global::UIKit.UIBackgroundFetchResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Protected files are now available.</summary><remarks><para>Content protection encrypts and restricts access to protected files in certain situations, such as when the device is locked. This method will be called when the device is unlocked and the files are available for reading.</para></remarks>
		[Export ("applicationProtectedDataDidBecomeAvailable:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataDidBecomeAvailable (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that protected files are about to be encrypted and unavailable for reading.</summary><remarks>To be added.</remarks>
		[Export ("applicationProtectedDataWillBecomeUnavailable:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataWillBecomeUnavailable (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has received a low-memory warning from the system.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidReceiveMemoryWarning:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceiveMemoryWarning (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="notification">To be added.</param><summary>Indicates that the app received a local notification.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveLocalNotification:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedLocalNotification (global::UIKit.UIApplication application, global::UIKit.UILocalNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="userInfo">A dictionary whose "aps" key contains information related to the notification</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveRemoteNotification:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedRemoteNotification (global::UIKit.UIApplication application, NSDictionary userInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="deviceToken">To be added.</param><summary>Indicates that the device successfully registered with Apple Push Service.</summary><remarks>To be added.</remarks>
		[Export ("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisteredForRemoteNotifications (global::UIKit.UIApplication application, NSData deviceToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="extensionPointIdentifier">To be added.</param><summary>Requests permission from the app to run app extensions based on the extension point identified by <paramref name="extensionPointIdentifier" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldAllowExtensionPointIdentifier:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAllowExtensionPointIdentifier (global::UIKit.UIApplication application, NSString extensionPointIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationShouldAutomaticallyLocalizeKeyCommands:")]
		[SupportedOSPlatform ("ios15.0")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyLocalizeKeyCommands (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><summary>The system calls this method when the developer's app should ask the user for access to HealthKit data.</summary><remarks>To be added.</remarks>
		[Export ("applicationShouldRequestHealthAuthorization:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShouldRequestHealthAuthorization (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should restore saved state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldRestoreApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreApplicationState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:shouldRestoreSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreSecureApplicationState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should save application state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldSaveApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveApplicationState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:shouldSaveSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveSecureApplicationState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>Informs the app that the <see cref="T:Foundation.NSUserActivity" /> object in <paramref name="userActivity" /> has been updated.</summary><remarks>To be added.</remarks>
		[Export ("application:didUpdateUserActivity:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityUpdated (global::UIKit.UIApplication application, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="cloudKitShareMetadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:userDidAcceptCloudKitShareWithMetadata:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (global::UIKit.UIApplication application, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="newStatusBarFrame">To be added.</param><summary>Indicates that the frame of the status bar is about to change.</summary><remarks>To be added.</remarks>
		[Export ("application:willChangeStatusBarFrame:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ViewWillTransitionToSize' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeStatusBarFrame (global::UIKit.UIApplication application, CGRect newStatusBarFrame)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="newStatusBarOrientation">To be added.</param><param name="duration">To be added.</param><summary>Indicates that the orientation of the status bar is about to change.</summary><remarks>To be added.</remarks>
		[Export ("application:willChangeStatusBarOrientation:duration:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'ViewWillTransitionToSize' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeStatusBarOrientation (global::UIKit.UIApplication application, global::UIKit.UIInterfaceOrientation newStatusBarOrientation, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton for the app.</param><param name="userActivityType">The user activity identifier.</param><summary>Informs the app that the user is attempting to continue a <paramref name="userActivityType" /> action for which data might not be available, and returns to notify the user that the app will continue the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willContinueUserActivityWithType:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillContinueUserActivity (global::UIKit.UIApplication application, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app is about to store application state data.</summary><remarks>To be added.</remarks>
		[Export ("application:willEncodeRestorableStateWithCoder:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (global::UIKit.UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application is about to enter the foreground.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillEnterForeground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that the app is about to finish its launching procedures.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willFinishLaunchingWithOptions:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillFinishLaunching (global::UIKit.UIApplication application, NSDictionary? launchOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the app is about to terminate.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillTerminate:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate (global::UIKit.UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets or sets the <see cref="T:UIKit.UIWindow" /> for the application.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.UIWindow? Window {
			[Export ("window", ArgumentSemantic.Retain)]
			[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setWindow:", ArgumentSemantic.Retain)]
			[ObsoletedOSPlatform ("ios13.0", "Use 'CPTemplateApplicationSceneDelegate' instead.")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class CPApplicationDelegate */
}
