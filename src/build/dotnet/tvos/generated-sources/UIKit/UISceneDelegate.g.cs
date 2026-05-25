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
	/// <summary>This interface represents the Objective-C protocol <c>UISceneDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UISceneDelegate", WrapperType = typeof (UISceneDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillConnect", Selector = "scene:willConnectToSession:options:", ParameterType = new Type [] { typeof (UIScene), typeof (UISceneSession), typeof (UISceneConnectionOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnect", Selector = "sceneDidDisconnect:", ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeActive", Selector = "sceneDidBecomeActive:", ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResignActive", Selector = "sceneWillResignActive:", ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterForeground", Selector = "sceneWillEnterForeground:", ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnterBackground", Selector = "sceneDidEnterBackground:", ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenUrlContexts", Selector = "scene:openURLContexts:", ParameterType = new Type [] { typeof (UIScene), typeof (global::Foundation.NSSet<global::UIKit.UIOpenUrlContext>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetStateRestorationActivity", Selector = "stateRestorationActivityForScene:", ReturnType = typeof (NSUserActivity), ParameterType = new Type [] { typeof (UIScene) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreInteractionState", Selector = "scene:restoreInteractionStateWithUserActivity:", ParameterType = new Type [] { typeof (UIScene), typeof (NSUserActivity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillContinueUserActivity", Selector = "scene:willContinueUserActivityWithType:", ParameterType = new Type [] { typeof (UIScene), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContinueUserActivity", Selector = "scene:continueUserActivity:", ParameterType = new Type [] { typeof (UIScene), typeof (NSUserActivity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToContinueUserActivity", Selector = "scene:didFailToContinueUserActivityWithType:error:", ParameterType = new Type [] { typeof (UIScene), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateUserActivity", Selector = "scene:didUpdateUserActivity:", ParameterType = new Type [] { typeof (UIScene), typeof (NSUserActivity) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUISceneDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("scene:willConnectToSession:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillConnect (UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
		{
			_WillConnect (this, scene, session, connectionOptions);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillConnect (IUISceneDelegate This, UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var connectionOptions__handle__ = connectionOptions!.GetNonNullHandle (nameof (connectionOptions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:willConnectToSession:options:"), scene__handle__, session__handle__, connectionOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (session);
			GC.KeepAlive (connectionOptions);
		}
		[global::Foundation.OptionalMember]
		[Export ("sceneDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (UIScene scene)
		{
			_DidDisconnect (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnect (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidDisconnect:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[global::Foundation.OptionalMember]
		[Export ("sceneDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (UIScene scene)
		{
			_DidBecomeActive (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeActive (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidBecomeActive:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[global::Foundation.OptionalMember]
		[Export ("sceneWillResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (UIScene scene)
		{
			_WillResignActive (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillResignActive (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneWillResignActive:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[global::Foundation.OptionalMember]
		[Export ("sceneWillEnterForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (UIScene scene)
		{
			_WillEnterForeground (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEnterForeground (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneWillEnterForeground:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[global::Foundation.OptionalMember]
		[Export ("sceneDidEnterBackground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (UIScene scene)
		{
			_DidEnterBackground (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnterBackground (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidEnterBackground:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:openURLContexts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrlContexts (UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
		{
			_OpenUrlContexts (this, scene, urlContexts);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OpenUrlContexts (IUISceneDelegate This, UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var urlContexts__handle__ = urlContexts!.GetNonNullHandle (nameof (urlContexts));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:openURLContexts:"), scene__handle__, urlContexts__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (urlContexts);
		}
		[global::Foundation.OptionalMember]
		[Export ("stateRestorationActivityForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity? GetStateRestorationActivity (UIScene scene)
		{
			return _GetStateRestorationActivity (this, scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUserActivity? _GetStateRestorationActivity (IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			NSUserActivity? ret;
			ret =  Runtime.GetNSObject<NSUserActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stateRestorationActivityForScene:"), scene__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:restoreInteractionStateWithUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreInteractionState (UIScene scene, NSUserActivity stateRestorationActivity)
		{
			_RestoreInteractionState (this, scene, stateRestorationActivity);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RestoreInteractionState (IUISceneDelegate This, UIScene scene, NSUserActivity stateRestorationActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var stateRestorationActivity__handle__ = stateRestorationActivity!.GetNonNullHandle (nameof (stateRestorationActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:restoreInteractionStateWithUserActivity:"), scene__handle__, stateRestorationActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (stateRestorationActivity);
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:willContinueUserActivityWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillContinueUserActivity (UIScene scene, string userActivityType)
		{
			_WillContinueUserActivity (this, scene, userActivityType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillContinueUserActivity (IUISceneDelegate This, UIScene scene, string userActivityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:willContinueUserActivityWithType:"), scene__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			CFString.ReleaseNative (nsuserActivityType);
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:continueUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			_ContinueUserActivity (this, scene, userActivity);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContinueUserActivity (IUISceneDelegate This, UIScene scene, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:continueUserActivity:"), scene__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (userActivity);
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:didFailToContinueUserActivityWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (UIScene scene, string userActivityType, NSError error)
		{
			_DidFailToContinueUserActivity (this, scene, userActivityType, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToContinueUserActivity (IUISceneDelegate This, UIScene scene, string userActivityType, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:didFailToContinueUserActivityWithType:error:"), scene__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		[global::Foundation.OptionalMember]
		[Export ("scene:didUpdateUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			_DidUpdateUserActivity (this, scene, userActivity);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateUserActivity (IUISceneDelegate This, UIScene scene, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:didUpdateUserActivity:"), scene__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (userActivity);
		}
		[DynamicDependencyAttribute ("ContinueUserActivity(UIKit.UIScene,Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("DidBecomeActive(UIKit.UIScene)")]
		[DynamicDependencyAttribute ("DidDisconnect(UIKit.UIScene)")]
		[DynamicDependencyAttribute ("DidEnterBackground(UIKit.UIScene)")]
		[DynamicDependencyAttribute ("DidFailToContinueUserActivity(UIKit.UIScene,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidUpdateUserActivity(UIKit.UIScene,Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("GetStateRestorationActivity(UIKit.UIScene)")]
		[DynamicDependencyAttribute ("OpenUrlContexts(UIKit.UIScene,Foundation.NSSet{UIKit.UIOpenUrlContext})")]
		[DynamicDependencyAttribute ("RestoreInteractionState(UIKit.UIScene,Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("WillConnect(UIKit.UIScene,UIKit.UISceneSession,UIKit.UISceneConnectionOptions)")]
		[DynamicDependencyAttribute ("WillContinueUserActivity(UIKit.UIScene,System.String)")]
		[DynamicDependencyAttribute ("WillEnterForeground(UIKit.UIScene)")]
		[DynamicDependencyAttribute ("WillResignActive(UIKit.UIScene)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISceneDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISceneDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISceneDelegate" /> interface to support all the methods from the UISceneDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISceneDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISceneDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISceneDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillConnect (this IUISceneDelegate This, UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var connectionOptions__handle__ = connectionOptions!.GetNonNullHandle (nameof (connectionOptions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:willConnectToSession:options:"), scene__handle__, session__handle__, connectionOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (session);
			GC.KeepAlive (connectionOptions);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnect (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidDisconnect:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBecomeActive (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidBecomeActive:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillResignActive (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneWillResignActive:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEnterForeground (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneWillEnterForeground:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnterBackground (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sceneDidEnterBackground:"), scene__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OpenUrlContexts (this IUISceneDelegate This, UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var urlContexts__handle__ = urlContexts!.GetNonNullHandle (nameof (urlContexts));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:openURLContexts:"), scene__handle__, urlContexts__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (urlContexts);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUserActivity? GetStateRestorationActivity (this IUISceneDelegate This, UIScene scene)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			NSUserActivity? ret;
			ret =  Runtime.GetNSObject<NSUserActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stateRestorationActivityForScene:"), scene__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RestoreInteractionState (this IUISceneDelegate This, UIScene scene, NSUserActivity stateRestorationActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var stateRestorationActivity__handle__ = stateRestorationActivity!.GetNonNullHandle (nameof (stateRestorationActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:restoreInteractionStateWithUserActivity:"), scene__handle__, stateRestorationActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (stateRestorationActivity);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillContinueUserActivity (this IUISceneDelegate This, UIScene scene, string userActivityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:willContinueUserActivityWithType:"), scene__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			CFString.ReleaseNative (nsuserActivityType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContinueUserActivity (this IUISceneDelegate This, UIScene scene, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:continueUserActivity:"), scene__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (userActivity);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToContinueUserActivity (this IUISceneDelegate This, UIScene scene, string userActivityType, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:didFailToContinueUserActivityWithType:error:"), scene__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateUserActivity (this IUISceneDelegate This, UIScene scene, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scene:didUpdateUserActivity:"), scene__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (scene);
			GC.KeepAlive (userActivity);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISceneDelegateWrapper : BaseWrapper, IUISceneDelegate {
		public UISceneDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISceneDelegateWrapper))]
		static UISceneDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISceneDelegate" /> (for the protocol <c>UISceneDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISceneDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UISceneDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UISceneDelegate : NSObject, IUISceneDelegate {
		/// <summary>Creates a new <see cref="UISceneDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISceneDelegate () : base (NSObjectFlag.Empty)
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
		protected UISceneDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISceneDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("scene:continueUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContinueUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneDidEnterBackground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didFailToContinueUserActivityWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (UIScene scene, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:didUpdateUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateUserActivity (UIScene scene, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("stateRestorationActivityForScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserActivity? GetStateRestorationActivity (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:openURLContexts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenUrlContexts (UIScene scene, NSSet<UIOpenUrlContext> urlContexts)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:restoreInteractionStateWithUserActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreInteractionState (UIScene scene, NSUserActivity stateRestorationActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willConnectToSession:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillConnect (UIScene scene, UISceneSession session, UISceneConnectionOptions connectionOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("scene:willContinueUserActivityWithType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillContinueUserActivity (UIScene scene, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillEnterForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sceneWillResignActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillResignActive (UIScene scene)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISceneDelegate */
}
