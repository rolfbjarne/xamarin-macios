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
	/// <summary>This interface represents the Objective-C protocol <c>CPTemplateApplicationDashboardSceneDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.4")]
	[Protocol (Name = "CPTemplateApplicationDashboardSceneDelegate", WrapperType = typeof (CPTemplateApplicationDashboardSceneDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnectDashboardController", Selector = "templateApplicationDashboardScene:didConnectDashboardController:toWindow:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationDashboardScene), typeof (CarPlay.CPDashboardController), typeof (UIWindow) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnectDashboardController", Selector = "templateApplicationDashboardScene:didDisconnectDashboardController:fromWindow:", ParameterType = new Type [] { typeof (CarPlay.CPTemplateApplicationDashboardScene), typeof (CarPlay.CPDashboardController), typeof (UIWindow) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ICPTemplateApplicationDashboardSceneDelegate : INativeObject, IDisposable, 
		UIKit.IUISceneDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationDashboardScene:didConnectDashboardController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectDashboardController (CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			_DidConnectDashboardController (this, templateApplicationDashboardScene, dashboardController, window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnectDashboardController (ICPTemplateApplicationDashboardSceneDelegate This, CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			var templateApplicationDashboardScene__handle__ = templateApplicationDashboardScene!.GetNonNullHandle (nameof (templateApplicationDashboardScene));
			var dashboardController__handle__ = dashboardController!.GetNonNullHandle (nameof (dashboardController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationDashboardScene:didConnectDashboardController:toWindow:"), templateApplicationDashboardScene__handle__, dashboardController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationDashboardScene);
			GC.KeepAlive (dashboardController);
			GC.KeepAlive (window);
		}
		[global::Foundation.OptionalMember]
		[Export ("templateApplicationDashboardScene:didDisconnectDashboardController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectDashboardController (CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			_DidDisconnectDashboardController (this, templateApplicationDashboardScene, dashboardController, window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnectDashboardController (ICPTemplateApplicationDashboardSceneDelegate This, CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			var templateApplicationDashboardScene__handle__ = templateApplicationDashboardScene!.GetNonNullHandle (nameof (templateApplicationDashboardScene));
			var dashboardController__handle__ = dashboardController!.GetNonNullHandle (nameof (dashboardController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationDashboardScene:didDisconnectDashboardController:fromWindow:"), templateApplicationDashboardScene__handle__, dashboardController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationDashboardScene);
			GC.KeepAlive (dashboardController);
			GC.KeepAlive (window);
		}
		[DynamicDependencyAttribute ("DidConnectDashboardController(CarPlay.CPTemplateApplicationDashboardScene,CarPlay.CPDashboardController,UIKit.UIWindow)")]
		[DynamicDependencyAttribute ("DidDisconnectDashboardController(CarPlay.CPTemplateApplicationDashboardScene,CarPlay.CPDashboardController,UIKit.UIWindow)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPTemplateApplicationDashboardSceneDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICPTemplateApplicationDashboardSceneDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICPTemplateApplicationDashboardSceneDelegate" /> interface to support all the methods from the CPTemplateApplicationDashboardSceneDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICPTemplateApplicationDashboardSceneDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CPTemplateApplicationDashboardSceneDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CPTemplateApplicationDashboardSceneDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidConnectDashboardController (this ICPTemplateApplicationDashboardSceneDelegate This, CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			var templateApplicationDashboardScene__handle__ = templateApplicationDashboardScene!.GetNonNullHandle (nameof (templateApplicationDashboardScene));
			var dashboardController__handle__ = dashboardController!.GetNonNullHandle (nameof (dashboardController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationDashboardScene:didConnectDashboardController:toWindow:"), templateApplicationDashboardScene__handle__, dashboardController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationDashboardScene);
			GC.KeepAlive (dashboardController);
			GC.KeepAlive (window);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnectDashboardController (this ICPTemplateApplicationDashboardSceneDelegate This, CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			var templateApplicationDashboardScene__handle__ = templateApplicationDashboardScene!.GetNonNullHandle (nameof (templateApplicationDashboardScene));
			var dashboardController__handle__ = dashboardController!.GetNonNullHandle (nameof (dashboardController));
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("templateApplicationDashboardScene:didDisconnectDashboardController:fromWindow:"), templateApplicationDashboardScene__handle__, dashboardController__handle__, window__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (templateApplicationDashboardScene);
			GC.KeepAlive (dashboardController);
			GC.KeepAlive (window);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CPTemplateApplicationDashboardSceneDelegateWrapper : BaseWrapper, ICPTemplateApplicationDashboardSceneDelegate {
		public CPTemplateApplicationDashboardSceneDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CPTemplateApplicationDashboardSceneDelegateWrapper))]
		static CPTemplateApplicationDashboardSceneDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CarPlay {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICPTemplateApplicationDashboardSceneDelegate" /> (for the protocol <c>CPTemplateApplicationDashboardSceneDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICPTemplateApplicationDashboardSceneDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CarPlay_CPTemplateApplicationDashboardSceneDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.4")]
	public unsafe partial class CPTemplateApplicationDashboardSceneDelegate : NSObject, ICPTemplateApplicationDashboardSceneDelegate, global::UIKit.IUISceneDelegate {
		/// <summary>Creates a new <see cref="CPTemplateApplicationDashboardSceneDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CPTemplateApplicationDashboardSceneDelegate () : base (NSObjectFlag.Empty)
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
		protected CPTemplateApplicationDashboardSceneDelegate (NSObjectFlag t) : base (t)
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
		protected internal CPTemplateApplicationDashboardSceneDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("scene:continueUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueUserActivity (global::UIKit.UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidBecomeActive:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationDashboardScene:didConnectDashboardController:toWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectDashboardController (CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidDisconnect:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("templateApplicationDashboardScene:didDisconnectDashboardController:fromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnectDashboardController (CPTemplateApplicationDashboardScene templateApplicationDashboardScene, CPDashboardController dashboardController, global::UIKit.UIWindow window)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidEnterBackground:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didFailToContinueUserActivityWithType:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (global::UIKit.UIScene scene, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didUpdateUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserActivity (global::UIKit.UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("stateRestorationActivityForScene:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity? GetStateRestorationActivity (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:openURLContexts:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrlContexts (global::UIKit.UIScene scene, NSSet<global::UIKit.UIOpenUrlContext> urlContexts)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:restoreInteractionStateWithUserActivity:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreInteractionState (global::UIKit.UIScene scene, NSUserActivity stateRestorationActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willConnectToSession:options:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillConnect (global::UIKit.UIScene scene, global::UIKit.UISceneSession session, global::UIKit.UISceneConnectionOptions connectionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willContinueUserActivityWithType:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillContinueUserActivity (global::UIKit.UIScene scene, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillEnterForeground:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillResignActive:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.4")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (global::UIKit.UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CPTemplateApplicationDashboardSceneDelegate */
}
