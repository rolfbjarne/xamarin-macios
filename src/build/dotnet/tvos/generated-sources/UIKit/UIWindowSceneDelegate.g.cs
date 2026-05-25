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
	/// <summary>This interface represents the Objective-C protocol <c>UIWindowSceneDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIWindowSceneDelegate", WrapperType = typeof (UIWindowSceneDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateEffectiveGeometry", Selector = "windowScene:didUpdateEffectiveGeometry:", ParameterType = new Type [] { typeof (UIWindowScene), typeof (UIWindowSceneGeometry) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidAcceptCloudKitShare", Selector = "windowScene:userDidAcceptCloudKitShareWithMetadata:", ParameterType = new Type [] { typeof (UIWindowScene), typeof (CloudKit.CKShareMetadata) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredWindowingControlStyle", Selector = "preferredWindowingControlStyleForScene:", ReturnType = typeof (UISceneWindowingControlStyle), ParameterType = new Type [] { typeof (UIWindowScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Window", Selector = "window", PropertyType = typeof (UIWindow), GetterSelector = "window", SetterSelector = "setWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUIWindowSceneDelegate : INativeObject, IDisposable, 
		UIKit.IUISceneDelegate
	{
		[global::Foundation.OptionalMember]
		[Export ("windowScene:didUpdateEffectiveGeometry:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateEffectiveGeometry (UIWindowScene windowScene, UIWindowSceneGeometry previousEffectiveGeometry)
		{
			_DidUpdateEffectiveGeometry (this, windowScene, previousEffectiveGeometry);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateEffectiveGeometry (IUIWindowSceneDelegate This, UIWindowScene windowScene, UIWindowSceneGeometry previousEffectiveGeometry)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			var previousEffectiveGeometry__handle__ = previousEffectiveGeometry!.GetNonNullHandle (nameof (previousEffectiveGeometry));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("windowScene:didUpdateEffectiveGeometry:"), windowScene__handle__, previousEffectiveGeometry__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			GC.KeepAlive (previousEffectiveGeometry);
		}
		[global::Foundation.OptionalMember]
		[Export ("windowScene:userDidAcceptCloudKitShareWithMetadata:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (UIWindowScene windowScene, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			_UserDidAcceptCloudKitShare (this, windowScene, cloudKitShareMetadata);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserDidAcceptCloudKitShare (IUIWindowSceneDelegate This, UIWindowScene windowScene, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			var cloudKitShareMetadata__handle__ = cloudKitShareMetadata!.GetNonNullHandle (nameof (cloudKitShareMetadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("windowScene:userDidAcceptCloudKitShareWithMetadata:"), windowScene__handle__, cloudKitShareMetadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			GC.KeepAlive (cloudKitShareMetadata);
		}
		[global::Foundation.OptionalMember]
		[Export ("preferredWindowingControlStyleForScene:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISceneWindowingControlStyle GetPreferredWindowingControlStyle (UIWindowScene windowScene)
		{
			return _GetPreferredWindowingControlStyle (this, windowScene);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISceneWindowingControlStyle _GetPreferredWindowingControlStyle (IUIWindowSceneDelegate This, UIWindowScene windowScene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			UISceneWindowingControlStyle? ret;
			ret =  Runtime.GetNSObject<UISceneWindowingControlStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredWindowingControlStyleForScene:"), windowScene__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidUpdateEffectiveGeometry(UIKit.UIWindowScene,UIKit.UIWindowSceneGeometry)")]
		[DynamicDependencyAttribute ("GetPreferredWindowingControlStyle(UIKit.UIWindowScene)")]
		[DynamicDependencyAttribute ("UserDidAcceptCloudKitShare(UIKit.UIWindowScene,CloudKit.CKShareMetadata)")]
		[DynamicDependencyAttribute ("Window")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIWindowSceneDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIWindowSceneDelegate ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UIWindow? Window {
			[Export ("window", ArgumentSemantic.Retain)]
			get {
				return _GetWindow (this);
			}
			[Export ("setWindow:", ArgumentSemantic.Retain)]
			set {
				_SetWindow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIWindow _GetWindow (IUIWindowSceneDelegate This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWindow ret;
			ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("window")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWindow (IUIWindowSceneDelegate This, UIWindow? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIWindowSceneDelegate" /> interface to support all the methods from the UIWindowSceneDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIWindowSceneDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIWindowSceneDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIWindowSceneDelegate_Extensions {
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateEffectiveGeometry (this IUIWindowSceneDelegate This, UIWindowScene windowScene, UIWindowSceneGeometry previousEffectiveGeometry)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			var previousEffectiveGeometry__handle__ = previousEffectiveGeometry!.GetNonNullHandle (nameof (previousEffectiveGeometry));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("windowScene:didUpdateEffectiveGeometry:"), windowScene__handle__, previousEffectiveGeometry__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			GC.KeepAlive (previousEffectiveGeometry);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserDidAcceptCloudKitShare (this IUIWindowSceneDelegate This, UIWindowScene windowScene, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			var cloudKitShareMetadata__handle__ = cloudKitShareMetadata!.GetNonNullHandle (nameof (cloudKitShareMetadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("windowScene:userDidAcceptCloudKitShareWithMetadata:"), windowScene__handle__, cloudKitShareMetadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			GC.KeepAlive (cloudKitShareMetadata);
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISceneWindowingControlStyle GetPreferredWindowingControlStyle (this IUIWindowSceneDelegate This, UIWindowScene windowScene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var windowScene__handle__ = windowScene!.GetNonNullHandle (nameof (windowScene));
			UISceneWindowingControlStyle? ret;
			ret =  Runtime.GetNSObject<UISceneWindowingControlStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("preferredWindowingControlStyleForScene:"), windowScene__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (windowScene);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIWindow GetWindow (this IUIWindowSceneDelegate This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWindow ret;
			ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("window")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWindow (this IUIWindowSceneDelegate This, UIWindow? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIWindowSceneDelegateWrapper : BaseWrapper, IUIWindowSceneDelegate {
		public UIWindowSceneDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIWindowSceneDelegateWrapper))]
		static UIWindowSceneDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIWindowSceneDelegate" /> (for the protocol <c>UIWindowSceneDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIWindowSceneDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIWindowSceneDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UIWindowSceneDelegate : NSObject, IUIWindowSceneDelegate, IUISceneDelegate {
		/// <summary>Creates a new <see cref="UIWindowSceneDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIWindowSceneDelegate () : base (NSObjectFlag.Empty)
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
		protected UIWindowSceneDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIWindowSceneDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("scene:continueUserActivity:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidBecomeActive:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidDisconnect:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidEnterBackground:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didFailToContinueUserActivityWithType:error:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (UIScene scene, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("windowScene:didUpdateEffectiveGeometry:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateEffectiveGeometry (UIWindowScene windowScene, UIWindowSceneGeometry previousEffectiveGeometry)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didUpdateUserActivity:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("preferredWindowingControlStyleForScene:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISceneWindowingControlStyle GetPreferredWindowingControlStyle (UIWindowScene windowScene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("stateRestorationActivityForScene:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity? GetStateRestorationActivity (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:openURLContexts:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrlContexts (UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:restoreInteractionStateWithUserActivity:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreInteractionState (UIScene scene, NSUserActivity stateRestorationActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("windowScene:userDidAcceptCloudKitShareWithMetadata:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (UIWindowScene windowScene, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willConnectToSession:options:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillConnect (UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willContinueUserActivityWithType:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillContinueUserActivity (UIScene scene, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillEnterForeground:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillResignActive:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIWindow? Window {
			[Export ("window", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setWindow:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIWindowSceneDelegate */
}
