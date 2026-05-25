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
	/// <summary>This interface represents the Objective-C protocol <c>UIApplicationDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIApplicationDelegate", WrapperType = typeof (UIApplicationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLaunching", Selector = "applicationDidFinishLaunching:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLaunching", Selector = "application:didFinishLaunchingWithOptions:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnActivated", Selector = "applicationDidBecomeActive:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnResignActivation", Selector = "applicationWillResignActive:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceiveMemoryWarning", Selector = "applicationDidReceiveMemoryWarning:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTerminate", Selector = "applicationWillTerminate:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplicationSignificantTimeChange", Selector = "applicationSignificantTimeChange:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegisteredForRemoteNotifications", Selector = "application:didRegisterForRemoteNotificationsWithDeviceToken:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToRegisterForRemoteNotifications", Selector = "application:didFailToRegisterForRemoteNotificationsWithError:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedRemoteNotification", Selector = "application:didReceiveRemoteNotification:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnterBackground", Selector = "applicationDidEnterBackground:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterForeground", Selector = "applicationWillEnterForeground:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProtectedDataWillBecomeUnavailable", Selector = "applicationProtectedDataWillBecomeUnavailable:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProtectedDataDidBecomeAvailable", Selector = "applicationProtectedDataDidBecomeAvailable:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenUrl", Selector = "application:openURL:options:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSUrl), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillFinishLaunching", Selector = "application:willFinishLaunchingWithOptions:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "application:viewControllerWithRestorationIdentifierPath:coder:", ReturnType = typeof (UIViewController), ParameterType = new Type [] { typeof (UIApplication), typeof (String[]), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSaveApplicationState", Selector = "application:shouldSaveApplicationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSaveSecureApplicationState", Selector = "application:shouldSaveSecureApplicationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRestoreApplicationState", Selector = "application:shouldRestoreApplicationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRestoreSecureApplicationState", Selector = "application:shouldRestoreSecureApplicationState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEncodeRestorableState", Selector = "application:willEncodeRestorableStateWithCoder:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDecodeRestorableState", Selector = "application:didDecodeRestorableStateWithCoder:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSCoder) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveRemoteNotification", Selector = "application:didReceiveRemoteNotification:fetchCompletionHandler:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSDictionary), typeof (global::System.Action<global::UIKit.UIBackgroundFetchResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V79) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleEventsForBackgroundUrl", Selector = "application:handleEventsForBackgroundURLSession:completionHandler:", ParameterType = new Type [] { typeof (UIApplication), typeof (string), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformFetch", Selector = "application:performFetchWithCompletionHandler:", ParameterType = new Type [] { typeof (UIApplication), typeof (global::System.Action<global::UIKit.UIBackgroundFetchResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V79) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContinueUserActivity", Selector = "application:continueUserActivity:restorationHandler:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSUserActivity), typeof (UIApplicationRestorationHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToContinueUserActivity", Selector = "application:didFailToContinueUserActivityWithType:error:", ParameterType = new Type [] { typeof (UIApplication), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillContinueUserActivity", Selector = "application:willContinueUserActivityWithType:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserActivityUpdated", Selector = "application:didUpdateUserActivity:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSUserActivity) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAllowExtensionPointIdentifier", Selector = "application:shouldAllowExtensionPointIdentifier:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleWatchKitExtensionRequest", Selector = "application:handleWatchKitExtensionRequest:reply:", ParameterType = new Type [] { typeof (UIApplication), typeof (NSDictionary), typeof (global::System.Action<NSDictionary>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V35) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRequestHealthAuthorization", Selector = "applicationShouldRequestHealthAuthorization:", ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserDidAcceptCloudKitShare", Selector = "application:userDidAcceptCloudKitShareWithMetadata:", ParameterType = new Type [] { typeof (UIApplication), typeof (CloudKit.CKShareMetadata) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHandlerForIntent", Selector = "application:handlerForIntent:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (UIApplication), typeof (Intents.INIntent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetConfiguration", Selector = "application:configurationForConnectingSceneSession:options:", ReturnType = typeof (UISceneConfiguration), ParameterType = new Type [] { typeof (UIApplication), typeof (UISceneSession), typeof (UISceneConnectionOptions) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDiscardSceneSessions", Selector = "application:didDiscardSceneSessions:", ParameterType = new Type [] { typeof (UIApplication), typeof (global::Foundation.NSSet<global::UIKit.UISceneSession>) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAutomaticallyLocalizeKeyCommands", Selector = "applicationShouldAutomaticallyLocalizeKeyCommands:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIApplication) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Window", Selector = "window", PropertyType = typeof (UIWindow), GetterSelector = "window", SetterSelector = "setWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUIApplicationDelegate : INativeObject, IDisposable
	{
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The application has finished launching.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLaunching (UIApplication application)
		{
			_FinishedLaunching (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The application has finished launching.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedLaunching (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidFinishLaunching:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that launching has finished and the app will shortly begin running.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FinishedLaunching (UIApplication application, NSDictionary? launchOptions)
		{
			return _FinishedLaunching (this, application, launchOptions);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that launching has finished and the app will shortly begin running.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _FinishedLaunching (IUIApplicationDelegate This, UIApplication application, NSDictionary? launchOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var launchOptions__handle__ = launchOptions.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFinishLaunchingWithOptions:"), application__handle__, launchOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (launchOptions);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has moved from the inactive to actie state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidBecomeActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnActivated (UIApplication application)
		{
			_OnActivated (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has moved from the inactive to actie state.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnActivated (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidBecomeActive:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app is about to move from the active state to the inactive state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillResignActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnResignActivation (UIApplication application)
		{
			_OnResignActivation (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app is about to move from the active state to the inactive state.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnResignActivation (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillResignActive:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has received a low-memory warning from the system.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidReceiveMemoryWarning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceiveMemoryWarning (UIApplication application)
		{
			_ReceiveMemoryWarning (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has received a low-memory warning from the system.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceiveMemoryWarning (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidReceiveMemoryWarning:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the app is about to terminate.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate (UIApplication application)
		{
			_WillTerminate (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the app is about to terminate.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillTerminate (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillTerminate:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates a significant change in time, such as midnight, change to Daylight Savings, or a shift in timezone.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationSignificantTimeChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationSignificantTimeChange (UIApplication application)
		{
			_ApplicationSignificantTimeChange (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates a significant change in time, such as midnight, change to Daylight Savings, or a shift in timezone.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ApplicationSignificantTimeChange (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationSignificantTimeChange:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="deviceToken">To be added.</param><summary>Indicates that the device successfully registered with Apple Push Service.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			_RegisteredForRemoteNotifications (this, application, deviceToken);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="deviceToken">To be added.</param><summary>Indicates that the device successfully registered with Apple Push Service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RegisteredForRemoteNotifications (IUIApplicationDelegate This, UIApplication application, NSData deviceToken)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didRegisterForRemoteNotificationsWithDeviceToken:"), application__handle__, deviceToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (deviceToken);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="error">To be added.</param><summary>Indicates that Apple Push Service did not successfully compete the registration process.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didFailToRegisterForRemoteNotificationsWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			_FailedToRegisterForRemoteNotifications (this, application, error);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="error">To be added.</param><summary>Indicates that Apple Push Service did not successfully compete the registration process.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToRegisterForRemoteNotifications (IUIApplicationDelegate This, UIApplication application, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToRegisterForRemoteNotificationsWithError:"), application__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="userInfo">A dictionary whose "aps" key contains information related to the notification</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didReceiveRemoteNotification:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			_ReceivedRemoteNotification (this, application, userInfo);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="userInfo">A dictionary whose "aps" key contains information related to the notification</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedRemoteNotification (IUIApplicationDelegate This, UIApplication application, NSDictionary userInfo)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:"), application__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application has entered the background.</summary><remarks><para>Apps should complete processing this method in approximately 5 seconds. If more time is necessary, applications can call <see cref="M:UIKit.UIApplication.BeginBackgroundTask(System.String,System.Action)" />.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationDidEnterBackground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (UIApplication application)
		{
			_DidEnterBackground (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application has entered the background.</summary><remarks><para>Apps should complete processing this method in approximately 5 seconds. If more time is necessary, applications can call <see cref="M:UIKit.UIApplication.BeginBackgroundTask(System.String,System.Action)" />.</para></remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnterBackground (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidEnterBackground:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application is about to enter the foreground.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationWillEnterForeground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (UIApplication application)
		{
			_WillEnterForeground (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application is about to enter the foreground.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEnterForeground (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillEnterForeground:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that protected files are about to be encrypted and unavailable for reading.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationProtectedDataWillBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataWillBecomeUnavailable (UIApplication application)
		{
			_ProtectedDataWillBecomeUnavailable (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that protected files are about to be encrypted and unavailable for reading.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProtectedDataWillBecomeUnavailable (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataWillBecomeUnavailable:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Protected files are now available.</summary><remarks><para>Content protection encrypts and restricts access to protected files in certain situations, such as when the device is locked. This method will be called when the device is unlocked and the files are available for reading.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationProtectedDataDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataDidBecomeAvailable (UIApplication application)
		{
			_ProtectedDataDidBecomeAvailable (this, application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Protected files are now available.</summary><remarks><para>Content protection encrypts and restricts access to protected files in certain situations, such as when the device is locked. This method will be called when the device is unlocked and the files are available for reading.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProtectedDataDidBecomeAvailable (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataDidBecomeAvailable:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> with context from <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:openURL:options:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenUrl (UIApplication app, NSUrl url, NSDictionary options)
		{
			return _OpenUrl (this, app, url, options);
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> with context from <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _OpenUrl (IUIApplicationDelegate This, UIApplication app, NSUrl url, NSDictionary options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openURL:options:"), app__handle__, url__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that the app is about to finish its launching procedures.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillFinishLaunching (UIApplication application, NSDictionary? launchOptions)
		{
			return _WillFinishLaunching (this, application, launchOptions);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that the app is about to finish its launching procedures.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillFinishLaunching (IUIApplicationDelegate This, UIApplication application, NSDictionary? launchOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var launchOptions__handle__ = launchOptions.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willFinishLaunchingWithOptions:"), application__handle__, launchOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (launchOptions);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="restorationIdentifierComponents">An array of identifiers that identify the path to the desired view controller, which should be last.</param><param name="coder">To be added.</param><summary>Retrieves the UIViewController identified by the last value in the restorationIdentifierComponents parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:viewControllerWithRestorationIdentifierPath:coder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetViewController (UIApplication application, string[] restorationIdentifierComponents, NSCoder coder)
		{
			return _GetViewController (this, application, restorationIdentifierComponents, coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="restorationIdentifierComponents">An array of identifiers that identify the path to the desired view controller, which should be last.</param><param name="coder">To be added.</param><summary>Retrieves the UIViewController identified by the last value in the restorationIdentifierComponents parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIViewController? _GetViewController (IUIApplicationDelegate This, UIApplication application, string[] restorationIdentifierComponents, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (restorationIdentifierComponents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restorationIdentifierComponents));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			using var nsa_restorationIdentifierComponents = NSArray.FromStrings (restorationIdentifierComponents);
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:viewControllerWithRestorationIdentifierPath:coder:"), application__handle__, nsa_restorationIdentifierComponents.Handle, coder__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret!;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should save application state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:shouldSaveApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveApplicationState (UIApplication application, NSCoder coder)
		{
			return _ShouldSaveApplicationState (this, application, coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should save application state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSaveApplicationState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldSaveApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("application:shouldSaveSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveSecureApplicationState (UIApplication application, NSCoder coder)
		{
			return _ShouldSaveSecureApplicationState (this, application, coder);
		}
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldSaveSecureApplicationState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldSaveSecureApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should restore saved state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:shouldRestoreApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreApplicationState (UIApplication application, NSCoder coder)
		{
			return _ShouldRestoreApplicationState (this, application, coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should restore saved state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRestoreApplicationState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldRestoreApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("application:shouldRestoreSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreSecureApplicationState (UIApplication application, NSCoder coder)
		{
			return _ShouldRestoreSecureApplicationState (this, application, coder);
		}
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRestoreSecureApplicationState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldRestoreSecureApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app is about to store application state data.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willEncodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (UIApplication application, NSCoder coder)
		{
			_WillEncodeRestorableState (this, application, coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app is about to store application state data.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillEncodeRestorableState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willEncodeRestorableStateWithCoder:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app should restore highest-level state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didDecodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDecodeRestorableState (UIApplication application, NSCoder coder)
		{
			_DidDecodeRestorableState (this, application, coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app should restore highest-level state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDecodeRestorableState (IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDecodeRestorableStateWithCoder:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="userInfo">To be added.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			_DidReceiveRemoteNotification (this, application, userInfo, completionHandler);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="userInfo">To be added.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveRemoteNotification (IUIApplicationDelegate This, UIApplication application, NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:fetchCompletionHandler:"), application__handle__, userInfo__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">To be added.</param><param name="sessionIdentifier">To be added.</param><param name="completionHandler">To be added.</param><summary>Raised when events relating to a background <see cref="T:Foundation.NSUrlSession" /> are waiting to be processed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:handleEventsForBackgroundURLSession:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleEventsForBackgroundUrl (UIApplication application, string sessionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			_HandleEventsForBackgroundUrl (this, application, sessionIdentifier, completionHandler);
		}
		/// <param name="application">To be added.</param><param name="sessionIdentifier">To be added.</param><param name="completionHandler">To be added.</param><summary>Raised when events relating to a background <see cref="T:Foundation.NSUrlSession" /> are waiting to be processed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleEventsForBackgroundUrl (IUIApplicationDelegate This, UIApplication application, string sessionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (sessionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sessionIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssessionIdentifier = CFString.CreateNative (sessionIdentifier);
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handleEventsForBackgroundURLSession:completionHandler:"), application__handle__, nssessionIdentifier, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nssessionIdentifier);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the application can begin a fetch operation if it has data to download.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:performFetchWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformFetch (UIApplication application, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			_PerformFetch (this, application, completionHandler);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the application can begin a fetch operation if it has data to download.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PerformFetch (IUIApplicationDelegate This, UIApplication application, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:performFetchWithCompletionHandler:"), application__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton.</param><param name="userActivity">The user activity identifier.</param><param name="completionHandler">System-provided callback that can be called with appropriate <see cref="T:UIKit.UIResponder" /> or <see cref="T:UIKit.UIDocument" /> objects.</param><summary>Informs the app that there is data associated with continuing a task specified as a <see cref="T:Foundation.NSUserActivity" /> object, and then returns whether the app continued the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:continueUserActivity:restorationHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ContinueUserActivity (UIApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler))]UIApplicationRestorationHandler completionHandler)
		{
			return _ContinueUserActivity (this, application, userActivity, completionHandler);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton.</param><param name="userActivity">The user activity identifier.</param><param name="completionHandler">System-provided callback that can be called with appropriate <see cref="T:UIKit.UIResponder" /> or <see cref="T:UIKit.UIDocument" /> objects.</param><summary>Informs the app that there is data associated with continuing a task specified as a <see cref="T:Foundation.NSUserActivity" /> object, and then returns whether the app continued the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _ContinueUserActivity (IUIApplicationDelegate This, UIApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler))]UIApplicationRestorationHandler completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDUIApplicationRestorationHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:continueUserActivity:restorationHandler:"), application__handle__, userActivity__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>Informs the app that the activity of the <paramref name="userActivityType" /> type could not be continued, and specifies a <paramref name="error" /> as the reason for the failure.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didFailToContinueUserActivityWithType:error:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (UIApplication application, string userActivityType, NSError error)
		{
			_DidFailToContinueUserActivity (this, application, userActivityType, error);
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>Informs the app that the activity of the <paramref name="userActivityType" /> type could not be continued, and specifies a <paramref name="error" /> as the reason for the failure.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToContinueUserActivity (IUIApplicationDelegate This, UIApplication application, string userActivityType, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToContinueUserActivityWithType:error:"), application__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton for the app.</param><param name="userActivityType">The user activity identifier.</param><summary>Informs the app that the user is attempting to continue a <paramref name="userActivityType" /> action for which data might not be available, and returns to notify the user that the app will continue the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:willContinueUserActivityWithType:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillContinueUserActivity (UIApplication application, string userActivityType)
		{
			return _WillContinueUserActivity (this, application, userActivityType);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton for the app.</param><param name="userActivityType">The user activity identifier.</param><summary>Informs the app that the user is attempting to continue a <paramref name="userActivityType" /> action for which data might not be available, and returns to notify the user that the app will continue the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _WillContinueUserActivity (IUIApplicationDelegate This, UIApplication application, string userActivityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willContinueUserActivityWithType:"), application__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nsuserActivityType);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>Informs the app that the <see cref="T:Foundation.NSUserActivity" /> object in <paramref name="userActivity" /> has been updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:didUpdateUserActivity:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityUpdated (UIApplication application, NSUserActivity userActivity)
		{
			_UserActivityUpdated (this, application, userActivity);
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>Informs the app that the <see cref="T:Foundation.NSUserActivity" /> object in <paramref name="userActivity" /> has been updated.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserActivityUpdated (IUIApplicationDelegate This, UIApplication application, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didUpdateUserActivity:"), application__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
		}
		/// <param name="application">To be added.</param><param name="extensionPointIdentifier">To be added.</param><summary>Requests permission from the app to run app extensions based on the extension point identified by <paramref name="extensionPointIdentifier" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:shouldAllowExtensionPointIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAllowExtensionPointIdentifier (UIApplication application, NSString extensionPointIdentifier)
		{
			return _ShouldAllowExtensionPointIdentifier (this, application, extensionPointIdentifier);
		}
		/// <param name="application">To be added.</param><param name="extensionPointIdentifier">To be added.</param><summary>Requests permission from the app to run app extensions based on the extension point identified by <paramref name="extensionPointIdentifier" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAllowExtensionPointIdentifier (IUIApplicationDelegate This, UIApplication application, NSString extensionPointIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var extensionPointIdentifier__handle__ = extensionPointIdentifier!.GetNonNullHandle (nameof (extensionPointIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldAllowExtensionPointIdentifier:"), application__handle__, extensionPointIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (extensionPointIdentifier);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><param name="reply">To be added.</param><summary>A watchkit extension has made a request.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:handleWatchKitExtensionRequest:reply:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleWatchKitExtensionRequest (UIApplication application, NSDictionary? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V35))]global::System.Action<NSDictionary> reply)
		{
			_HandleWatchKitExtensionRequest (this, application, userInfo, reply);
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><param name="reply">To be added.</param><summary>A watchkit extension has made a request.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleWatchKitExtensionRequest (IUIApplicationDelegate This, UIApplication application, NSDictionary? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V35))]global::System.Action<NSDictionary> reply)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo.GetHandle ();
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDActionArity1V35.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handleWatchKitExtensionRequest:reply:"), application__handle__, userInfo__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">To be added.</param><summary>The system calls this method when the developer's app should ask the user for access to HealthKit data.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldRequestHealthAuthorization:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShouldRequestHealthAuthorization (UIApplication application)
		{
			_ShouldRequestHealthAuthorization (this, application);
		}
		/// <param name="application">To be added.</param><summary>The system calls this method when the developer's app should ask the user for access to HealthKit data.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ShouldRequestHealthAuthorization (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldRequestHealthAuthorization:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">To be added.</param><param name="cloudKitShareMetadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("application:userDidAcceptCloudKitShareWithMetadata:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (UIApplication application, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			_UserDidAcceptCloudKitShare (this, application, cloudKitShareMetadata);
		}
		/// <param name="application">To be added.</param><param name="cloudKitShareMetadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UserDidAcceptCloudKitShare (IUIApplicationDelegate This, UIApplication application, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var cloudKitShareMetadata__handle__ = cloudKitShareMetadata!.GetNonNullHandle (nameof (cloudKitShareMetadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:userDidAcceptCloudKitShareWithMetadata:"), application__handle__, cloudKitShareMetadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (cloudKitShareMetadata);
		}
		[global::Foundation.OptionalMember]
		[Export ("application:handlerForIntent:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandlerForIntent (UIApplication application, global::Intents.INIntent intent)
		{
			return _GetHandlerForIntent (this, application, intent);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetHandlerForIntent (IUIApplicationDelegate This, UIApplication application, global::Intents.INIntent intent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handlerForIntent:"), application__handle__, intent__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (intent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("application:configurationForConnectingSceneSession:options:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISceneConfiguration GetConfiguration (UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
		{
			return _GetConfiguration (this, application, connectingSceneSession, options);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISceneConfiguration _GetConfiguration (IUIApplicationDelegate This, UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var connectingSceneSession__handle__ = connectingSceneSession!.GetNonNullHandle (nameof (connectingSceneSession));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			UISceneConfiguration? ret;
			ret =  Runtime.GetNSObject<UISceneConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:configurationForConnectingSceneSession:options:"), application__handle__, connectingSceneSession__handle__, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (connectingSceneSession);
			GC.KeepAlive (options);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("application:didDiscardSceneSessions:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDiscardSceneSessions (UIApplication application, NSSet<UISceneSession> sceneSessions)
		{
			_DidDiscardSceneSessions (this, application, sceneSessions);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDiscardSceneSessions (IUIApplicationDelegate This, UIApplication application, NSSet<UISceneSession> sceneSessions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var sceneSessions__handle__ = sceneSessions!.GetNonNullHandle (nameof (sceneSessions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDiscardSceneSessions:"), application__handle__, sceneSessions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (sceneSessions);
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationShouldAutomaticallyLocalizeKeyCommands:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyLocalizeKeyCommands (UIApplication application)
		{
			return _ShouldAutomaticallyLocalizeKeyCommands (this, application);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldAutomaticallyLocalizeKeyCommands (IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldAutomaticallyLocalizeKeyCommands:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ApplicationSignificantTimeChange(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("ContinueUserActivity(UIKit.UIApplication,Foundation.NSUserActivity,UIKit.UIApplicationRestorationHandler)")]
		[DynamicDependencyAttribute ("DidDecodeRestorableState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("DidDiscardSceneSessions(UIKit.UIApplication,Foundation.NSSet{UIKit.UISceneSession})")]
		[DynamicDependencyAttribute ("DidEnterBackground(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("DidFailToContinueUserActivity(UIKit.UIApplication,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveRemoteNotification(UIKit.UIApplication,Foundation.NSDictionary,System.Action{UIKit.UIBackgroundFetchResult})")]
		[DynamicDependencyAttribute ("FailedToRegisterForRemoteNotifications(UIKit.UIApplication,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FinishedLaunching(UIKit.UIApplication,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("FinishedLaunching(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("GetConfiguration(UIKit.UIApplication,UIKit.UISceneSession,UIKit.UISceneConnectionOptions)")]
		[DynamicDependencyAttribute ("GetHandlerForIntent(UIKit.UIApplication,Intents.INIntent)")]
		[DynamicDependencyAttribute ("GetViewController(UIKit.UIApplication,System.String[],Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("HandleEventsForBackgroundUrl(UIKit.UIApplication,System.String,System.Action)")]
		[DynamicDependencyAttribute ("HandleWatchKitExtensionRequest(UIKit.UIApplication,Foundation.NSDictionary,System.Action{Foundation.NSDictionary})")]
		[DynamicDependencyAttribute ("OnActivated(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("OnResignActivation(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("OpenUrl(UIKit.UIApplication,Foundation.NSUrl,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("PerformFetch(UIKit.UIApplication,System.Action{UIKit.UIBackgroundFetchResult})")]
		[DynamicDependencyAttribute ("ProtectedDataDidBecomeAvailable(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("ProtectedDataWillBecomeUnavailable(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("ReceivedRemoteNotification(UIKit.UIApplication,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("ReceiveMemoryWarning(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("RegisteredForRemoteNotifications(UIKit.UIApplication,Foundation.NSData)")]
		[DynamicDependencyAttribute ("ShouldAllowExtensionPointIdentifier(UIKit.UIApplication,Foundation.NSString)")]
		[DynamicDependencyAttribute ("ShouldAutomaticallyLocalizeKeyCommands(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("ShouldRequestHealthAuthorization(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("ShouldRestoreApplicationState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("ShouldRestoreSecureApplicationState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("ShouldSaveApplicationState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("ShouldSaveSecureApplicationState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("UserActivityUpdated(UIKit.UIApplication,Foundation.NSUserActivity)")]
		[DynamicDependencyAttribute ("UserDidAcceptCloudKitShare(UIKit.UIApplication,CloudKit.CKShareMetadata)")]
		[DynamicDependencyAttribute ("WillContinueUserActivity(UIKit.UIApplication,System.String)")]
		[DynamicDependencyAttribute ("WillEncodeRestorableState(UIKit.UIApplication,Foundation.NSCoder)")]
		[DynamicDependencyAttribute ("WillEnterForeground(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("WillFinishLaunching(UIKit.UIApplication,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("WillTerminate(UIKit.UIApplication)")]
		[DynamicDependencyAttribute ("Window")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIApplicationDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIApplicationDelegate ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the <see cref="T:UIKit.UIWindow" /> for the application.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		internal static UIWindow _GetWindow (IUIApplicationDelegate This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWindow ret;
			ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("window")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetWindow (IUIApplicationDelegate This, UIWindow? value)
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
	/// <summary>Extension methods to the <see cref="IUIApplicationDelegate" /> interface to support all the methods from the UIApplicationDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIApplicationDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIApplicationDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIApplicationDelegate_Extensions {
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The application has finished launching.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedLaunching (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidFinishLaunching:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that launching has finished and the app will shortly begin running.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool FinishedLaunching (this IUIApplicationDelegate This, UIApplication application, NSDictionary? launchOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var launchOptions__handle__ = launchOptions.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFinishLaunchingWithOptions:"), application__handle__, launchOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (launchOptions);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has moved from the inactive to actie state.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnActivated (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidBecomeActive:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app is about to move from the active state to the inactive state.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnResignActivation (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillResignActive:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has received a low-memory warning from the system.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceiveMemoryWarning (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidReceiveMemoryWarning:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the app is about to terminate.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillTerminate (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillTerminate:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates a significant change in time, such as midnight, change to Daylight Savings, or a shift in timezone.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ApplicationSignificantTimeChange (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationSignificantTimeChange:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="deviceToken">To be added.</param><summary>Indicates that the device successfully registered with Apple Push Service.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisteredForRemoteNotifications (this IUIApplicationDelegate This, UIApplication application, NSData deviceToken)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didRegisterForRemoteNotificationsWithDeviceToken:"), application__handle__, deviceToken__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (deviceToken);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="error">To be added.</param><summary>Indicates that Apple Push Service did not successfully compete the registration process.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToRegisterForRemoteNotifications (this IUIApplicationDelegate This, UIApplication application, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToRegisterForRemoteNotificationsWithError:"), application__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="userInfo">A dictionary whose "aps" key contains information related to the notification</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedRemoteNotification (this IUIApplicationDelegate This, UIApplication application, NSDictionary userInfo)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:"), application__handle__, userInfo__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application has entered the background.</summary><remarks><para>Apps should complete processing this method in approximately 5 seconds. If more time is necessary, applications can call <see cref="M:UIKit.UIApplication.BeginBackgroundTask(System.String,System.Action)" />.</para></remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnterBackground (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationDidEnterBackground:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application is about to enter the foreground.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEnterForeground (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationWillEnterForeground:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that protected files are about to be encrypted and unavailable for reading.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProtectedDataWillBecomeUnavailable (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataWillBecomeUnavailable:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Protected files are now available.</summary><remarks><para>Content protection encrypts and restricts access to protected files in certain situations, such as when the device is locked. This method will be called when the device is unlocked and the files are available for reading.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProtectedDataDidBecomeAvailable (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationProtectedDataDidBecomeAvailable:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> with context from <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OpenUrl (this IUIApplicationDelegate This, UIApplication app, NSUrl url, NSDictionary options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var app__handle__ = app!.GetNonNullHandle (nameof (app));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:openURL:options:"), app__handle__, url__handle__, options__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (app);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that the app is about to finish its launching procedures.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillFinishLaunching (this IUIApplicationDelegate This, UIApplication application, NSDictionary? launchOptions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var launchOptions__handle__ = launchOptions.GetHandle ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willFinishLaunchingWithOptions:"), application__handle__, launchOptions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (launchOptions);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="restorationIdentifierComponents">An array of identifiers that identify the path to the desired view controller, which should be last.</param><param name="coder">To be added.</param><summary>Retrieves the UIViewController identified by the last value in the restorationIdentifierComponents parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIViewController? GetViewController (this IUIApplicationDelegate This, UIApplication application, string[] restorationIdentifierComponents, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (restorationIdentifierComponents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restorationIdentifierComponents));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			using var nsa_restorationIdentifierComponents = NSArray.FromStrings (restorationIdentifierComponents);
			UIViewController? ret;
			ret =  Runtime.GetNSObject<UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:viewControllerWithRestorationIdentifierPath:coder:"), application__handle__, nsa_restorationIdentifierComponents.Handle, coder__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret!;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should save application state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSaveApplicationState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldSaveApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldSaveSecureApplicationState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldSaveSecureApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should restore saved state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRestoreApplicationState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldRestoreApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRestoreSecureApplicationState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldRestoreSecureApplicationState:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
			return ret != 0;
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app is about to store application state data.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillEncodeRestorableState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willEncodeRestorableStateWithCoder:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app should restore highest-level state.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDecodeRestorableState (this IUIApplicationDelegate This, UIApplication application, NSCoder coder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDecodeRestorableStateWithCoder:"), application__handle__, coder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (coder);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="userInfo">To be added.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveRemoteNotification (this IUIApplicationDelegate This, UIApplication application, NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didReceiveRemoteNotification:fetchCompletionHandler:"), application__handle__, userInfo__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">To be added.</param><param name="sessionIdentifier">To be added.</param><param name="completionHandler">To be added.</param><summary>Raised when events relating to a background <see cref="T:Foundation.NSUrlSession" /> are waiting to be processed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void HandleEventsForBackgroundUrl (this IUIApplicationDelegate This, UIApplication application, string sessionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (sessionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sessionIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nssessionIdentifier = CFString.CreateNative (sessionIdentifier);
			using var block_completionHandler = Trampolines.SDAction.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handleEventsForBackgroundURLSession:completionHandler:"), application__handle__, nssessionIdentifier, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nssessionIdentifier);
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the application can begin a fetch operation if it has data to download.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PerformFetch (this IUIApplicationDelegate This, UIApplication application, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:performFetchWithCompletionHandler:"), application__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton.</param><param name="userActivity">The user activity identifier.</param><param name="completionHandler">System-provided callback that can be called with appropriate <see cref="T:UIKit.UIResponder" /> or <see cref="T:UIKit.UIDocument" /> objects.</param><summary>Informs the app that there is data associated with continuing a task specified as a <see cref="T:Foundation.NSUserActivity" /> object, and then returns whether the app continued the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ContinueUserActivity (this IUIApplicationDelegate This, UIApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler))]UIApplicationRestorationHandler completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDUIApplicationRestorationHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:continueUserActivity:restorationHandler:"), application__handle__, userActivity__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>Informs the app that the activity of the <paramref name="userActivityType" /> type could not be continued, and specifies a <paramref name="error" /> as the reason for the failure.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToContinueUserActivity (this IUIApplicationDelegate This, UIApplication application, string userActivityType, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didFailToContinueUserActivityWithType:error:"), application__handle__, nsuserActivityType, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsuserActivityType);
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton for the app.</param><param name="userActivityType">The user activity identifier.</param><summary>Informs the app that the user is attempting to continue a <paramref name="userActivityType" /> action for which data might not be available, and returns to notify the user that the app will continue the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WillContinueUserActivity (this IUIApplicationDelegate This, UIApplication application, string userActivityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			if (userActivityType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userActivityType));
			var nsuserActivityType = CFString.CreateNative (userActivityType);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:willContinueUserActivityWithType:"), application__handle__, nsuserActivityType);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			CFString.ReleaseNative (nsuserActivityType);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>Informs the app that the <see cref="T:Foundation.NSUserActivity" /> object in <paramref name="userActivity" /> has been updated.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserActivityUpdated (this IUIApplicationDelegate This, UIApplication application, NSUserActivity userActivity)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userActivity__handle__ = userActivity!.GetNonNullHandle (nameof (userActivity));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didUpdateUserActivity:"), application__handle__, userActivity__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userActivity);
		}
		/// <param name="application">To be added.</param><param name="extensionPointIdentifier">To be added.</param><summary>Requests permission from the app to run app extensions based on the extension point identified by <paramref name="extensionPointIdentifier" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAllowExtensionPointIdentifier (this IUIApplicationDelegate This, UIApplication application, NSString extensionPointIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var extensionPointIdentifier__handle__ = extensionPointIdentifier!.GetNonNullHandle (nameof (extensionPointIdentifier));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:shouldAllowExtensionPointIdentifier:"), application__handle__, extensionPointIdentifier__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (extensionPointIdentifier);
			return ret != 0;
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><param name="reply">To be added.</param><summary>A watchkit extension has made a request.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void HandleWatchKitExtensionRequest (this IUIApplicationDelegate This, UIApplication application, NSDictionary? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V35))]global::System.Action<NSDictionary> reply)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var userInfo__handle__ = userInfo.GetHandle ();
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDActionArity1V35.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handleWatchKitExtensionRequest:reply:"), application__handle__, userInfo__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (userInfo);
		}
		/// <param name="application">To be added.</param><summary>The system calls this method when the developer's app should ask the user for access to HealthKit data.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShouldRequestHealthAuthorization (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldRequestHealthAuthorization:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
		}
		/// <param name="application">To be added.</param><param name="cloudKitShareMetadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserDidAcceptCloudKitShare (this IUIApplicationDelegate This, UIApplication application, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var cloudKitShareMetadata__handle__ = cloudKitShareMetadata!.GetNonNullHandle (nameof (cloudKitShareMetadata));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:userDidAcceptCloudKitShareWithMetadata:"), application__handle__, cloudKitShareMetadata__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (cloudKitShareMetadata);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetHandlerForIntent (this IUIApplicationDelegate This, UIApplication application, global::Intents.INIntent intent)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:handlerForIntent:"), application__handle__, intent__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (intent);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UISceneConfiguration GetConfiguration (this IUIApplicationDelegate This, UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var connectingSceneSession__handle__ = connectingSceneSession!.GetNonNullHandle (nameof (connectingSceneSession));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			UISceneConfiguration? ret;
			ret =  Runtime.GetNSObject<UISceneConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:configurationForConnectingSceneSession:options:"), application__handle__, connectingSceneSession__handle__, options__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (connectingSceneSession);
			GC.KeepAlive (options);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDiscardSceneSessions (this IUIApplicationDelegate This, UIApplication application, NSSet<UISceneSession> sceneSessions)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			var sceneSessions__handle__ = sceneSessions!.GetNonNullHandle (nameof (sceneSessions));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("application:didDiscardSceneSessions:"), application__handle__, sceneSessions__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			GC.KeepAlive (sceneSessions);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldAutomaticallyLocalizeKeyCommands (this IUIApplicationDelegate This, UIApplication application)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var application__handle__ = application!.GetNonNullHandle (nameof (application));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applicationShouldAutomaticallyLocalizeKeyCommands:"), application__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (application);
			return ret != 0;
		}
		/// <summary>Gets or sets the <see cref="T:UIKit.UIWindow" /> for the application.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIWindow GetWindow (this IUIApplicationDelegate This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIWindow ret;
			ret =  Runtime.GetNSObject<UIWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("window")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets or sets the <see cref="T:UIKit.UIWindow" /> for the application.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWindow (this IUIApplicationDelegate This, UIWindow? value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIApplicationDelegateWrapper : BaseWrapper, IUIApplicationDelegate {
		public UIApplicationDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIApplicationDelegateWrapper))]
		static UIApplicationDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIApplicationDelegate" /> (for the protocol <c>UIApplicationDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIApplicationDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UIApplicationDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIApplicationDelegate : NSObject, IUIApplicationDelegate {
		/// <summary>Creates a new <see cref="UIApplicationDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIApplicationDelegate () : base (NSObjectFlag.Empty)
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
		protected UIApplicationDelegate (NSObjectFlag t) : base (t)
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
		protected internal UIApplicationDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates a significant change in time, such as midnight, change to Daylight Savings, or a shift in timezone.</summary><remarks>To be added.</remarks>
		[Export ("applicationSignificantTimeChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplicationSignificantTimeChange (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton.</param><param name="userActivity">The user activity identifier.</param><param name="completionHandler">System-provided callback that can be called with appropriate <see cref="T:UIKit.UIResponder" /> or <see cref="T:UIKit.UIDocument" /> objects.</param><summary>Informs the app that there is data associated with continuing a task specified as a <see cref="T:Foundation.NSUserActivity" /> object, and then returns whether the app continued the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:continueUserActivity:restorationHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'ContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ContinueUserActivity (UIApplication application, NSUserActivity userActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUIApplicationRestorationHandler))]UIApplicationRestorationHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app should restore highest-level state.</summary><remarks>To be added.</remarks>
		[Export ("application:didDecodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDecodeRestorableState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:didDiscardSceneSessions:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDiscardSceneSessions (UIApplication application, NSSet<UISceneSession> sceneSessions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application has entered the background.</summary><remarks><para>Apps should complete processing this method in approximately 5 seconds. If more time is necessary, applications can call <see cref="M:UIKit.UIApplication.BeginBackgroundTask(System.String,System.Action)" />.</para></remarks>
		[Export ("applicationDidEnterBackground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidEnterBackground' from 'UISceneDelegate' or the 'UIApplication.DidEnterBackgroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnterBackground (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivityType">To be added.</param><param name="error">To be added.</param><summary>Informs the app that the activity of the <paramref name="userActivityType" /> type could not be continued, and specifies a <paramref name="error" /> as the reason for the failure.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToContinueUserActivityWithType:error:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidFailToContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToContinueUserActivity (UIApplication application, string userActivityType, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="userInfo">To be added.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="error">To be added.</param><summary>Indicates that Apple Push Service did not successfully compete the registration process.</summary><remarks>To be added.</remarks>
		[Export ("application:didFailToRegisterForRemoteNotificationsWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The application has finished launching.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidFinishLaunching:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLaunching (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that launching has finished and the app will shortly begin running.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:didFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FinishedLaunching (UIApplication application, NSDictionary? launchOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:configurationForConnectingSceneSession:options:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISceneConfiguration GetConfiguration (UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:handlerForIntent:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandlerForIntent (UIApplication application, global::Intents.INIntent intent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="restorationIdentifierComponents">An array of identifiers that identify the path to the desired view controller, which should be last.</param><param name="coder">To be added.</param><summary>Retrieves the UIViewController identified by the last value in the restorationIdentifierComponents parameter.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:viewControllerWithRestorationIdentifierPath:coder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIViewController? GetViewController (UIApplication application, string[] restorationIdentifierComponents, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="sessionIdentifier">To be added.</param><param name="completionHandler">To be added.</param><summary>Raised when events relating to a background <see cref="T:Foundation.NSUrlSession" /> are waiting to be processed.</summary><remarks>To be added.</remarks>
		[Export ("application:handleEventsForBackgroundURLSession:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleEventsForBackgroundUrl (UIApplication application, string sessionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userInfo">To be added.</param><param name="reply">To be added.</param><summary>A watchkit extension has made a request.</summary><remarks>To be added.</remarks>
		[Export ("application:handleWatchKitExtensionRequest:reply:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleWatchKitExtensionRequest (UIApplication application, NSDictionary? userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V35))]global::System.Action<NSDictionary> reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has moved from the inactive to actie state.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidBecomeActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'DidBecomeActive' from 'UISceneDelegate' or the 'UIApplication.DidBecomeActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnActivated (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app is about to move from the active state to the inactive state.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillResignActive:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillResignActive' from 'UISceneDelegate' or the 'UIApplication.WillResignActiveNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnResignActivation (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> with context from <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:openURL:options:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'OpenUrlContexts' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OpenUrl (UIApplication app, NSUrl url, NSDictionary options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="app">To be added.</param><param name="url">To be added.</param><param name="options">To be added.</param><summary>Indicates that the application should open the specified <paramref name="url" /> according to <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool OpenUrl (UIApplication app, NSUrl url, UIApplicationOpenUrlOptions options)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Handle to the UIApplication.</param><param name="completionHandler">Callback to invoke to notify the operating system of the result of the background fetch operation.</param><summary>Indicates that the application can begin a fetch operation if it has data to download.</summary><remarks>To be added.</remarks>
		[Export ("application:performFetchWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use a 'BGAppRefreshTask' from 'BackgroundTasks' framework.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformFetch (UIApplication application, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<UIBackgroundFetchResult> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Protected files are now available.</summary><remarks><para>Content protection encrypts and restricts access to protected files in certain situations, such as when the device is locked. This method will be called when the device is unlocked and the files are available for reading.</para></remarks>
		[Export ("applicationProtectedDataDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataDidBecomeAvailable (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that protected files are about to be encrypted and unavailable for reading.</summary><remarks>To be added.</remarks>
		[Export ("applicationProtectedDataWillBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProtectedDataWillBecomeUnavailable (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>The app has received a low-memory warning from the system.</summary><remarks>To be added.</remarks>
		[Export ("applicationDidReceiveMemoryWarning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceiveMemoryWarning (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="userInfo">A dictionary whose "aps" key contains information related to the notification</param><summary>Indicates that the app received a remote notification.</summary><remarks>To be added.</remarks>
		[Export ("application:didReceiveRemoteNotification:")]
		[ObsoletedOSPlatform ("ios10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UNUserNotificationCenterDelegate.WillPresentNotification/DidReceiveNotificationResponse' for user visible notifications and 'ReceivedRemoteNotification' for silent remote notifications.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="deviceToken">To be added.</param><summary>Indicates that the device successfully registered with Apple Push Service.</summary><remarks>To be added.</remarks>
		[Export ("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="extensionPointIdentifier">To be added.</param><summary>Requests permission from the app to run app extensions based on the extension point identified by <paramref name="extensionPointIdentifier" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldAllowExtensionPointIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAllowExtensionPointIdentifier (UIApplication application, NSString extensionPointIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("applicationShouldAutomaticallyLocalizeKeyCommands:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAutomaticallyLocalizeKeyCommands (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><summary>The system calls this method when the developer's app should ask the user for access to HealthKit data.</summary><remarks>To be added.</remarks>
		[Export ("applicationShouldRequestHealthAuthorization:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShouldRequestHealthAuthorization (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should restore saved state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldRestoreApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldRestoreSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreApplicationState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:shouldRestoreSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRestoreSecureApplicationState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Whether the application should save application state information.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:shouldSaveApplicationState:")]
		[ObsoletedOSPlatform ("ios13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("tvos13.2", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ShouldSaveSecureApplicationState' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveApplicationState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("application:shouldSaveSecureApplicationState:")]
		[SupportedOSPlatform ("ios13.2")]
		[SupportedOSPlatform ("tvos13.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSaveSecureApplicationState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="userActivity">To be added.</param><summary>Informs the app that the <see cref="T:Foundation.NSUserActivity" /> object in <paramref name="userActivity" /> has been updated.</summary><remarks>To be added.</remarks>
		[Export ("application:didUpdateUserActivity:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'DidUpdateUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserActivityUpdated (UIApplication application, NSUserActivity userActivity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">To be added.</param><param name="cloudKitShareMetadata">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("application:userDidAcceptCloudKitShareWithMetadata:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'UserDidAcceptCloudKitShare' from 'UIWindowSceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserDidAcceptCloudKitShare (UIApplication application, global::CloudKit.CKShareMetadata cloudKitShareMetadata)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">The <see cref="T:UIKit.UIApplication" /> singleton for the app.</param><param name="userActivityType">The user activity identifier.</param><summary>Informs the app that the user is attempting to continue a <paramref name="userActivityType" /> action for which data might not be available, and returns to notify the user that the app will continue the activity.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willContinueUserActivityWithType:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'UIScene' lifecycle, 'WillContinueUserActivity' from 'UISceneDelegate'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillContinueUserActivity (UIApplication application, string userActivityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="coder">To be added.</param><summary>Indicates that the app is about to store application state data.</summary><remarks>To be added.</remarks>
		[Export ("application:willEncodeRestorableStateWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEncodeRestorableState (UIApplication application, NSCoder coder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the application is about to enter the foreground.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillEnterForeground:")]
		[ObsoletedOSPlatform ("ios26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use UIScene lifecycle, 'WillEnterForeground' from 'UISceneDelegate' or the 'UIApplication.WillEnterForegroundNotification' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillEnterForeground (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><param name="launchOptions">An NSDictionary with the launch options, can be null.   Possible key values are UIApplication's LaunchOption static properties.</param><summary>Indicates that the app is about to finish its launching procedures.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("application:willFinishLaunchingWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WillFinishLaunching (UIApplication application, NSDictionary? launchOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="application">Reference to the UIApplication that invoked this delegate method.</param><summary>Indicates that the app is about to terminate.</summary><remarks>To be added.</remarks>
		[Export ("applicationWillTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillTerminate (UIApplication application)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Gets or sets the <see cref="T:UIKit.UIWindow" /> for the application.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
	} /* class UIApplicationDelegate */
}
